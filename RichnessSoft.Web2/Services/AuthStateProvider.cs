using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace RichnessSoft.Web2.Services
{
    public class AuthStateProvider : AuthenticationStateProvider
    {
        private ISessionStorageService _sessionStorage;
        public AuthStateProvider(ISessionStorageService sessionStorage)
        {
            _sessionStorage = sessionStorage;
        }
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            string username = "";
            try
            {
                username = await _sessionStorage.GetItemAsync<string>("Username");
            }
            catch (Exception)
            {
            }
            ClaimsIdentity identity;
            if (!string.IsNullOrEmpty(username))
            {
                identity = new ClaimsIdentity(new[]
                {
                        new Claim(ClaimTypes.Name, username),
                }, "RichnessSoftplatform");
                
            }
            else
            {
                identity = new ClaimsIdentity();
            }
            var user = new ClaimsPrincipal(identity);
            return await Task.FromResult(new AuthenticationState(user));
        }
        public void MarkUserAsAuthenticated(string username)
        {
            var identity = new ClaimsIdentity(new[]
                { new Claim(ClaimTypes.Name, username),
                }, "RichnessSoftplatform");
            var user = new ClaimsPrincipal(identity);

            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        }
        public void MarkUserAsLoggedOut()
        {
            _sessionStorage.RemoveItemAsync("Username");
            var identity = new ClaimsIdentity();
            var user = new ClaimsPrincipal(identity);
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        }
    }
}
