using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace RichnessSoft.Web.Services
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
            var username = await _sessionStorage.GetItemAsync<string>("Username");
            ClaimsIdentity identity;
            if (username != null)
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
