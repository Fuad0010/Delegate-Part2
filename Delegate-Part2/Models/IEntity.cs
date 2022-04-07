using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Part2.Models
{
    internal interface IEntity        //IEntity interface
                                      //- Id - property olacaq
                                      //Bu interface-i implement edən class-larda id dəyəri avtomatik artacaq və qıraqdan set etmək olmaz yalnız get etmək olar.
    {
        private static int _id;
        public int Id{ get { return _id; } }
        void IEntity()
        {
            _id++;
            
        }
        
    }
}
