using Blazored.FluentValidation;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using RichnessSoft.Common;
using RichnessSoft.Entity.Model;
using static log4net.Appender.ColoredConsoleAppender;

namespace RichnessSoft.Web2.Pages.Databases.Products
{
    public partial class WarehouseEdit
    {
        [Parameter]
        public int Id { get; set; }

        [Parameter]
        public string ParrentMenu { get; set; }
        private bool _loaded;
        string backURL = "";
        string Mode { get; set; }

        Warehouse warehouse { get; set; }
        MudDatePicker _picker;

        private FluentValidationValidator _fluentValidationValidator;
        private bool Validated => _fluentValidationValidator.Validate(options => { options.IncludeAllRuleSets(); });

        protected override async Task OnInitializedAsync()
        {
            backURL = "/Database/Whouse/" + ParrentMenu;
            if (Id > 0)
            {
                Mode = gbVar.ModeEdit;
                var r = warehouseService.GetById(Id);
                warehouse = (Warehouse)r.Data;
            }
            else
            {
                Mode = gbVar.ModeInsert;
                warehouse = new Warehouse();
                warehouse.companyid = store.CurentCompany.id;
                warehouse.active = ConstUtil.ACTIVE.YES;
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
                        results = warehouseService.Add(warehouse);
                    }
                    else if (Mode == gbVar.ModeEdit)
                    {
                        results = warehouseService.Edit(warehouse);
                    }
                    _loaded = false;
                    if (results.Success)
                    {
                        await Dialog.ShowMessageBox("info", Lng["SAVE_MSG_SUCCESS"], "OK");
                        if (Mode == gbVar.ModeInsert)
                        {
                            warehouse = new Warehouse();
                        }
                        else
                        {
                            NavigationManager.NavigateTo($"/Database/Whouse/{ParrentMenu}");
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
            var res = warehouseService.GetByCode(warehouse.companyid, warehouse.code);
            if (res.Data != null && !string.IsNullOrEmpty(((Warehouse)res.Data)?.code))
            {
                Warehouse OldData = (Warehouse)res.Data;
                if (Mode == gbVar.ModeInsert)
                {
                    bSucc = false;
                }
                else if (Mode == gbVar.ModeEdit && OldData.id != warehouse.id)
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
                warehouse.inactivedate = null;
                _picker.Clear();
            }
            StateHasChanged();
        }
    }
}