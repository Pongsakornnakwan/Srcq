using Blazored.FluentValidation;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using RichnessSoft.Common;
using RichnessSoft.Entity.Model;
using RichnessSoft.Service.BS;
using static log4net.Appender.ColoredConsoleAppender;

namespace RichnessSoft.Web2.Pages.Databases.Banks
{
    public partial class BankBranchEdit
    {
        [Parameter]
        public int Id { get; set; }

        [Parameter]
        public string ParrentMenu { get; set; }
        private bool _loaded;
        string backURL = "";
        string Mode { get; set; }

        BankBranch bankBranch { get; set; }
        MudDatePicker _picker;

        private FluentValidationValidator _fluentValidationValidator;
        private bool Validated => _fluentValidationValidator.Validate(options => { options.IncludeAllRuleSets(); });

        protected override async Task OnInitializedAsync()
        {
            backURL = "/Database/BankBranch/" + ParrentMenu;
            if (Id > 0)
            {
                Mode = gbVar.ModeEdit;
                var r = bankbranchService.GetById(Id);
                bankBranch = (BankBranch)r.Data;
            }
            else
            {
                Mode = gbVar.ModeInsert;
                bankBranch = new BankBranch();
                bankBranch.companyid = store.CurentCompany.id;
                bankBranch.active = ConstUtil.ACTIVE.YES;
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
                        results = bankbranchService.Add(bankBranch);
                    }
                    else if (Mode == gbVar.ModeEdit)
                    {
                        results = bankbranchService.Edit(bankBranch);
                    }
                    _loaded = false;
                    if (results.Success)
                    {
                        await Dialog.ShowMessageBox("info", Lng["SAVE_MSG_SUCCESS"], "OK");
                        if (Mode == gbVar.ModeInsert)
                        {
                            bankBranch = new BankBranch();
                        }
                        else
                        {
                            NavigationManager.NavigateTo($"/Database/BankBranch/{ParrentMenu}");
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
            var res = bankbranchService.GetByCode(bankBranch.companyid, bankBranch.code);
            if (res.Data != null && !string.IsNullOrEmpty(((BankBranch)res.Data)?.code))
            {
                BankBranch OldData = (BankBranch)res.Data;
                if (Mode == gbVar.ModeInsert)
                {
                    bSucc = false;
                }
                else if (Mode == gbVar.ModeEdit && OldData.id != bankBranch.id)
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
                bankBranch.inactivedate = null;
                _picker.Clear();
            }
            StateHasChanged();
        }
    }
}