using Blazored.FluentValidation;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using RichnessSoft.Common;
using RichnessSoft.Entity.Model;

namespace RichnessSoft.Web2.Pages.Databases.Customer
{
    public partial class SaleAreaEdit
    {
        [Parameter]
        public int Id { get; set; }

        [Parameter]
        public string ParrentMenu { get; set; }
        private bool _loaded;
        string backURL = "";
        string Mode { get; set; }

        SaleArea saleArea { get; set; }
        MudDatePicker _picker;
        private FluentValidationValidator _fluentValidationValidator;
        private bool Validated => _fluentValidationValidator.Validate(options => { options.IncludeAllRuleSets(); });

        protected override async Task OnInitializedAsync()
        {
            backURL = "/Database/Territory/" + ParrentMenu;
            if (Id > 0)
            {
                Mode = gbVar.ModeEdit;
                var r = saleAreaService.GetById(Id);
                saleArea = (SaleArea)r.Data;
            }
            else
            {
                Mode = gbVar.ModeInsert;
                saleArea = new SaleArea();
                saleArea.companyid = store.CurentCompany.id;
                saleArea.active = ConstUtil.ACTIVE.YES;
            }
        }
        async void SaveAsync()
        {
            ResultModel results = new ResultModel();
            try
            {
                _loaded = true;
                string strErrMsg = "";
                string strErrFocus = "";
                if (Validated && CheckDupCode())
                {
                    if (Mode == gbVar.ModeInsert)
                    {
                        results = saleAreaService.Add(saleArea);
                    }
                    else if (Mode == gbVar.ModeEdit)
                    {
                        results = saleAreaService.Edit(saleArea);
                    }
                    _loaded = false;
                    if (results.Success)
                    {
                        await Dialog.ShowMessageBox("info", Lng["SAVE_MSG_SUCCESS"], "OK");
                        if (Mode == gbVar.ModeInsert)
                        {
                            saleArea = new SaleArea();
                        }
                        else
                        {
                            NavigationManager.NavigateTo($"/Database/Territory/{ParrentMenu}");
                        }
                    }
                    else
                    {
                        await Dialog.ShowMessageBox("error", Lng["SAVE_MSG_FAIL"], "OK");
                        await Dialog.ShowMessageBox("info", results.Message, "OK");
                    }
                    StateHasChanged();
                }
                _loaded = false;
            }
            catch (Exception)
            {
                throw;
            }
        }
        private bool CheckDupCode()
        {
            bool bSucc = true;
            var res = saleAreaService.GetByCode(saleArea.companyid, saleArea.code);
            if (res.Data != null && !string.IsNullOrEmpty(((SaleArea)res.Data)?.code))
            {
                SaleArea OldData = (SaleArea)res.Data;
                if (Mode == gbVar.ModeInsert)
                {
                    bSucc = false;
                }
                else if (Mode == gbVar.ModeEdit && OldData.id != saleArea.id)
                {
                    bSucc = false;
                }
            }
            if (bSucc == false)
            {
                _snackBar.Add(Lng["DUPLICATED_CODE"], Severity.Error);
            }
            return bSucc;
        }
        async void activeChange(IEnumerable<string> values)
        {
            var sss = values.ToArray();
            if (sss[0] == ConstUtil.ACTIVE.YES)
            {
                saleArea.inactivedate = null;
                _picker.Clear();
            }
            StateHasChanged();
        }
    }
}