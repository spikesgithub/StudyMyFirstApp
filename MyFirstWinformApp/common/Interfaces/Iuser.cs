using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstWinformApp.common.Interfaces
{
    public interface Iuser
    {
        public string UserName { get; set; }
        void SayHello();
    }
}
