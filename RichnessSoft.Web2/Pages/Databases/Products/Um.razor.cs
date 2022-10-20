using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http;
using MudBlazor;
using RichnessSoft.Entity.Model;

namespace RichnessSoft.Web2.Pages.Databases.Products
{
    public partial class Um
    {
        [Parameter]
        public string ParrentMenu { get; set; }

        string backURL = "";
        List<UM> ListData = new List<UM>();
        private UM _Um = new();
        private string _searchString = "";
        private bool _loaded;

        protected override void OnInitialized()
        {
            store.OnChange += StateHasChanged;
        }

        protected override async Task OnInitializedAsync()
        {
            _loaded = true;
            await CheckState();
            Task.Delay(1000);
            await LoadData();
            _loaded = false;
        }

        protected override void OnAfterRender(bool firstRender)
        {
        }

        async Task LoadData()
        {

            if (store.CurentCompany == null)
                return;

            var res = await Task.Run(() => umService.GetAllAsync(store.CurentCompany.id));
            ListData = (List<UM>)res.Data;
        }


        protected override void OnParametersSet()
        {
            backURL = "SubMenu/" + ParrentMenu;
        }

        private bool Search(UM um)
        {
            if (string.IsNullOrWhiteSpace(_searchString)) return true;
            if (um.code?.Contains(_searchString, StringComparison.OrdinalIgnoreCase) == true)
            {
                return true;
            }
            if (um.name1?.Contains(_searchString, StringComparison.OrdinalIgnoreCase) == true)
            {
                return true;
            }
            if (um.name2?.Contains(_searchString, StringComparison.OrdinalIgnoreCase) == true)
            {
                return true;
            }
            return false;
        }

        async void EditUm(int id)
        {
            string URL = $"/Database/UmEdit/{id}/{ParrentMenu}";
            NavigationManager.NavigateTo(URL);
        }

        async void DeleteUm(int id)
        {
            bool? result = await Dialog.ShowMessageBox(
            "Deletd", Lng["CONFIRM_MSG_DEL"],
            yesText: "Yes", cancelText: "Cancel");

            if (result == true)
            {
                var r = umService.GetById(id);
                UM um = (UM)r.Data;
                var res = umService.Delete(um);
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
                StateHasChanged();
            }
        }

        async void AddNewAsync()
        {
            string URL = $"/Database/UmEdit/0/{ParrentMenu}";
            NavigationManager.NavigateTo(URL);
        }

        async void ReloadAsync()
        {
            _loaded = true;
            await LoadData();
            _loaded = false;
            StateHasChanged();
        }

    }
}
