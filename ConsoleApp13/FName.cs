using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    public class FName
    {
        public FName() { }
        public FName(string SurName, string Name, string FathName)
        {
            string FullName = SurName + "." + Name +"."+ FathName;
        }
        public string SurName { get; set; }
        public string Name { get; set; }
        public string FathName { get; set; }

        public override string ToString()
        {
            return "(" + SurName + " " + Name + " " + FathName + ")";
        }
        
    }
}
