﻿using MenStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenStore.Application.Contracts
{
    public interface IUserRepository:IGenericRepository<User>
    {

        public User CheckUser(User username);
    }
}
