using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Part2.Models
{
    internal interface IEntity
    {
        private static int _id;
        public int Id{ get { return _id; } }
        void IEntity()
        {
            _id++;
            
        }
        
    }
}
