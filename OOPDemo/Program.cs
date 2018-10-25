using System;

namespace OOPDemo
{
    class Program
    {
        //INHERITANCE
        static void Main(string[] args)
        { }
        class TinyHouse : House
        {

            string bedType = "murphyBed";
            string toiletType = "compostToilet";
            int price = 41500;
            int squareFeet = 150;

            //POLYMORPHISM
            public override string[] HouseAmenities(string TinyHouseComforts)
            {
                return new string[]
                {  "The entire House is light weight",
                    "Built for sub-zero temperature",
                    "Significant decreased environmental footprint."
                };
            }








            //ABSTRACTION













        }
    }
}





