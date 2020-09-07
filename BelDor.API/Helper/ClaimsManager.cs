using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BelDor.API.Helper
{
    public static class ClaimsManager
    {
        public static string GetClaims(this ClaimsPrincipal claimsPrincipal, string type)
        {
            var claim = claimsPrincipal.Claims.Where(c => c.Type == type).FirstOrDefault();

            return claim.Value;
        }
        public static int GetUserId(this ClaimsPrincipal claimsPrincipal)
        {
            var claim = claimsPrincipal.Claims.Where(c => c.Type == "Id").FirstOrDefault();

            return int.Parse(claim.Value);
        }
    }
}
