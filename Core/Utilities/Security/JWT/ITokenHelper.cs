using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.JWT
{
    public interface ITokenHelper
    {
        //user gönderip token alacağız
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
        
    }
}
