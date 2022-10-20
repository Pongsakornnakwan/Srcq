using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components;
using RichnessSoft.Service.Store;

namespace RichnessSoft.Web2.Shared
{
    public class razorBase : ComponentBase
    {

        [Inject]
        public ProfileStore store { get; set; }

        [Inject]
        ISessionStorageService SessionStorage { get;set;}

        public async Task CheckState()
        {
            if (store.CurentCompany == null)
            {
                var goUser = await Task.Run(() => SessionStorage.GetItemAsync<string>("Username"));
                await Task.Run(() => store.SetState(goUser.Result, "01"));
            }
        }
    }
}
