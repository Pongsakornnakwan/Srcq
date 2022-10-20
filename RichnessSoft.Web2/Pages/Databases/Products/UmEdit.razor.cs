using Blazored.FluentValidation;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using RichnessSoft.Common;
using RichnessSoft.Entity.Model;

namespace RichnessSoft.Web2.Pages.Databases.Products
{
    public partial class UmEdit
    {
        [Parameter]
        public int Id { get; set; }

        [Parameter]
        public string ParrentMenu { get; set; }

        private bool _loaded;

        string backURL = "";
        UM Um { get; set; }
        string Mode { get; set; }
        MudForm form;
        MudDatePicker _picker;

        bool success;
        string[] errors = { };
        private FluentValidationValidator _fluentValidationValidator;
        private bool Validated => _fluentValidationValidator.Validate(options => { options.IncludeAllRuleSets(); });

        protected override async Task OnInitializedAsync()
        {
            backURL = "/Database/Um/" + ParrentMenu;
            if (Id > 0)
            {
                Mode = gbVar.ModeEdit;
                var r = umService.GetById(Id);
                Um = (UM)r.Data;
            }
            else
            {
                Mode = gbVar.ModeInsert;
                Um = new UM();
                Um.companyid = store.CurentCompany.id;
                Um.active = ConstUtil.ACTIVE.YES;
            }
        }

        async void activeChange(IEnumerable<string> values)
        {
            var sss = values.ToArray();
            if (sss[0] == ConstUtil.ACTIVE.YES)
            {
                Um.inactivedate = null;
                _picker.Clear();
            }
            StateHasChanged();
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
                        results = umService.Add(Um);
                    }
                    else if (Mode == gbVar.ModeEdit)
                    {
                        results = umService.Edit(Um);
                    }
                    _loaded = false;
                    if (results.Success)
                    {
                        await Dialog.ShowMessageBox("info", Lng["SAVE_MSG_SUCCESS"],"OK");
                        if (Mode == gbVar.ModeInsert)
                        {
                            Um = new UM();
                        }
                        else
                        {
                            NavigationManager.NavigateTo($"/Database/Um/{ParrentMenu}");
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
            var res = umService.GetByCode(Um.companyid,Um.code);
            if (res.Data != null && !string.IsNullOrEmpty(((UM)res.Data)?.code))
            {
                UM OldData = (UM)res.Data;
                if (Mode == gbVar.ModeInsert)
                {
                    bSucc = false;
                }
                else if (Mode == gbVar.ModeEdit && OldData.id != Um.id)
                {
                    bSucc = false;
                }
            }
            if (bSucc == false) {
                _snackBar.Add(Lng["DUPLICATED_CODE"], Severity.Error);
            }
            return bSucc;
        }
    }
}