using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructordemo
{
    public class  course
    {
        private int id, fees;
        private string name;    
        public course(int id ,int fees,string name)
        {
            this .id = id;
            this.fees = fees;
            this.name = name;
        }
       public string Print()
       {
           return $" {id}{name}{fees}"; 
       }

    }
}
