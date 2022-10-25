using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http;
using MudBlazor;
using RichnessSoft.Entity.Model;

namespace RichnessSoft.Web2.Pages.Databases.Banks
{
    public partial class BankBranchs
    {
        [Parameter]
        public string ParrentMenu { get; set; }

        private bool _loaded;
        string backURL = "";
        List<BankBranch> ListData = new List<BankBranch>();
        private string _searchString { get; set; }
        private BankBranch _bankBranch { get; set; }

        protected override async Task OnInitializedAsync()
        {
            _loaded = true;
            await CheckState();
            Task.Delay(1000);
            await LoadData();
            _loaded = false;
        }
        async Task LoadData()
        {

            if (store.CurentCompany == null)
                return;

            var res = await Task.Run(() => bankbranchService.GetAllAsync(store.CurentCompany.id));
            ListData = (List<BankBranch>)res.Data;
        }
        protected override void OnParametersSet()
        {
            backURL = "SubMenu/" + ParrentMenu;
        }

        async void AddNewAsync()
        {
            string URL = $"/Database/BankBranchEdit/0/{ParrentMenu}";
            NavigationManager.NavigateTo(URL);
        }

        async void ReloadAsync()
        {
            _loaded = true;
            await LoadData();
            _loaded = false;
            StateHasChanged();
        }

        async void OnEdit(int id)
        {
            string URL = $"/Database/BankBranchEdit/{id}/{ParrentMenu}";
            NavigationManager.NavigateTo(URL);
        }

        async void OnDelete(int id)
        {
            bool? result = await Dialog.ShowMessageBox(
           "Deletd", Lng["CONFIRM_MSG_DEL"],
           yesText: "Yes", cancelText: "Cancel");

            if (result == true)
            {
                _loaded = true;
                var r = bankbranchService.GetById(id);
                BankBranch bankBranch = (BankBranch)r.Data;
                var res = bankbranchService.Delete(bankBranch);
                if (res.Success)
                {
                    await Dialog.ShowMessageBox("info", Lng["CONFIRM_MSG_DEL_SUCCESS"], "OK");
                    await LoadData();
                }
                else
                {
                    await Dialog.ShowMessageBox("info", Lng["CONFIRM_MSG_DEL_FAIL"], "OK");
                    await Dialog.ShowMessageBox("info", res.Message, "OK");
                }
                _loaded = false;
                StateHasChanged();
            }
        }

        private bool Search(BankBranch bankBranch)
        {
            if (string.IsNullOrWhiteSpace(_searchString)) return true;
            if (bankBranch.code?.Contains(_searchString, StringComparison.OrdinalIgnoreCase) == true)
            {
                return true;
            }
            if (bankBranch.name1?.Contains(_searchString, StringComparison.OrdinalIgnoreCase) == true)
            {
                return true;
            }
            if (bankBranch.name2?.Contains(_searchString, StringComparison.OrdinalIgnoreCase) == true)
            {
                return true;
            }
            return false;
        }
    }
}