﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Services
{
     public  interface IUsuario<T>
    {

        bool Login(string user , string pass);

    }
}
