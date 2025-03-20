using Microsoft.AspNetCore.Identity;

namespace NZWalks.API.Repositories
{
    public interface ITokenRepository
    {
        public string CreateToken(IdentityUser user, List<string> roles);
    }
}
