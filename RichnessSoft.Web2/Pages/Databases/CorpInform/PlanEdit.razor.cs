using Blazored.FluentValidation;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using RichnessSoft.Common;
using RichnessSoft.Entity.Model;
using RichnessSoft.Service.BS;
using System.Numerics;

namespace RichnessSoft.Web2.Pages.Databases.CorpInform
{
    public partial class PlanEdit
    {
        [Parameter]
        public int Id { get; set; }

        [Parameter]
        public string ParrentMenu { get; set; }
        private bool _loaded;
        string backURL = "";
        string Mode { get; set; }

        Plans plan { get; set; }
        MudDatePicker _picker;

        private FluentValidationValidator _fluentValidationValidator;
        private bool Validated => _fluentValidationValidator.Validate(options => { options.IncludeAllRuleSets(); });

        protected override async Task OnInitializedAsync()
        {
            backURL = "/Database/Plan/" + ParrentMenu;
            if (Id > 0)
            {
                Mode = gbVar.ModeEdit;
                var r = plansService.GetById(Id);
                plan = (Plans)r.Data;
            }
            else
            {
                Mode = gbVar.ModeInsert;
                plan = new Plans();
                plan.companyid = store.CurentCompany.id;
                plan.active = ConstUtil.ACTIVE.YES;
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
                        results = plansService.Add(plan);
                    }
                    else if (Mode == gbVar.ModeEdit)
                    {
                        results = plansService.Edit(plan);
                    }
                    _loaded = false;
                    if (results.Success)
                    {
                        await Dialog.ShowMessageBox("info", Lng["SAVE_MSG_SUCCESS"], "OK");
                        if (Mode == gbVar.ModeInsert)
                        {
                            plan = new Plans();
                        }
                        else
                        {
                            NavigationManager.NavigateTo($"/Database/Plan/{ParrentMenu}");
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
            var res = plansService.GetByCode(plan.companyid, plan.code);
            if (res.Data != null && !string.IsNullOrEmpty(((Plans)res.Data)?.code))
            {
                Plans OldData = (Plans)res.Data;
                if (Mode == gbVar.ModeInsert)
                {
                    bSucc = false;
                }
                else if (Mode == gbVar.ModeEdit && OldData.id != plan.id)
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
                plan.inactivedate = null;
                _picker.Clear();
            }
            StateHasChanged();
        }
    }
}