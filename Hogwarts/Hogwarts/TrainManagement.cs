using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts
{
    public  class TrainManagement : AllowedPersons
    {
        int bed { get ; set; }  
        int wagon { get; set; }//
        int cabin { get; set; }
        public TrainManagement(int code)
        {
            if (code / 1000 == 0)//compartment is not greater than 9
            {
                this.bed = code % 10;
                this.wagon = (code / 10) % 10;
                this.cabin = code / 100;
            }
            else if (code / 1000 != 0)//room number is 10
            {
                this.bed = code % 10;
                this.wagon = 10;
                this.cabin = code / 1000;
            }
        }
        public int ManageTrain (int code)
        {
            this.bed++;
            if (this.bed == 6)
            {
                this.bed = 1;
                this.wagon++;
                if (this.wagon == 11)
                {
                    this.wagon = 1;
                    this.cabin++;
                }
            }
            if (this.wagon == 10)
            {
                int dormitoryNumber = (this.cabin * 1000) + (this.wagon * 10) + (this.bed);
                return dormitoryNumber;
            }
            else
            {
                int dormitoryNumber = (this.cabin * 100) + (this.wagon * 10) + (this.bed);
                return dormitoryNumber;
            }
        }
    }
}
