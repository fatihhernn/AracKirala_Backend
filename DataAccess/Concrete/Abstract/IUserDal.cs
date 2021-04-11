using Core.DataAccess;
using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IUserDal:IEntityRepository<User>
    {
        //kullanıcını claimlerini çekmek istiyoruz. tablolar ile join işlemi gerçekleştircez
        List<OperationClaim> GetClaims(User user);
    }
}
