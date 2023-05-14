
using BuberDinner.Contracts.Authentication;

namespace BuberDinner.Application.Services.Authentication
{
    public interface IAuthenticationService
    {
        AuthenticationResponse Login(string email, string password);

        AuthenticationResponse Register(int id, string firstName, string lastName, string email, string token);
    }
}
