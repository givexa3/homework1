﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Homework1.Service
{
    public interface ITransientService : IService { }
    public class TransientService : ITransientService
    {
        private string _guid;

        public TransientService()
        {
            _guid = Guid.NewGuid().ToString();
        }

        public string GetGuid()
        {
            return _guid;
        }
    }
}
