using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts
{
    public class Plant
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public string Description { get; set; }
        public Plant(string name,int num,string des) 
        {
            this.Name = name;
            this.Number = num;
            this.Description = des;
        }
        public static List<Plant> Plants { get; set; }=new List<Plant>();
    }
}
