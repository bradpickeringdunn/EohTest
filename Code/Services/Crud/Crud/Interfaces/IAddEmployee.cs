﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Data.Crud.Models;

namespace EohTest.Service.Crud
{
    public interface IAddEmployee : IDisposable
    {
        void Execute(Employee employee);
    }
}