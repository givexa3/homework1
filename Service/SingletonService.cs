using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Homework1.Service
{
    public interface ISingletonService : IService { }
    public class SingletonService : ISingletonService
    {
        private string _guid;

        public SingletonService()
        {
            _guid = Guid.NewGuid().ToString();
        }

        public string GetGuid()
        {
            return _guid;
        }
    }
}
