using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialisation_Demo
{
    [Serializable] //attribute 
    //informs to the runtime thst this class allow to serilise.
    public  class Department
    { 
        public int Id { get; set; }
        public string Name { get; set; }
        public  string Location { get; set; }
    }
}
