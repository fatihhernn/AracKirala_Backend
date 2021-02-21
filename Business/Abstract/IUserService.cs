﻿using Core.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetById(int user);
        IResult Add(User user);
        IResult Update(User user);
        IResult Delete(User user);
    }
}
