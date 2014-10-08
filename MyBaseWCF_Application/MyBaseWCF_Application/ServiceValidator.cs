using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;
using System.IdentityModel;
using System.IdentityModel.Tokens;
using System.IdentityModel.Selectors;

namespace MyBaseWCF_Application
{
    public class ServiceValidator: UserNamePasswordValidator
    {

        public override void Validate(string userName, string password)
        {
            if (userName !="userOne" && password  !="password1")
            {
                throw new SecurityTokenValidationException("Failed to AUthorize");
            }
        }
    }
}