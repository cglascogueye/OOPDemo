using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDemo
{   //Encapsulation:
    class House
    {
        private string bedType;
        private string toiletType;
        private decimal squareFeet;
        public int price;

        public virtual string[] HouseAmenities(string TinyHouseComforts)
        {
            return new string[0];
        }
    }

    
    
        

    
}
