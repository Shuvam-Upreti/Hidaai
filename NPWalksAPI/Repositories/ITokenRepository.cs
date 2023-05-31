using Microsoft.AspNetCore.Identity;

namespace HidaaiAPI.Repositories
{
    public interface ITokenRepository
    {
        //need user information= IdentityUser, needs roles also so List<string>roles, returns string token 
        string CreateJWTToken(IdentityUser user,List<string>roles);
    }
}
