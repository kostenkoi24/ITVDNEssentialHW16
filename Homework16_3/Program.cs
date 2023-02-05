using System;

namespace Homework16_3
{

    class House
    {
        int number;

        string adress;

        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }


        public string Adress 
        { 
            get
            {
                return adress;
            }
            set
            {
                adress = value;
            }
        }

        public House Clone()
        {
            return (House)this.MemberwiseClone();
        }

        public House DeepClone()
        {
            House DeepcloneHouse = (House)this.MemberwiseClone();
            DeepcloneHouse.Adress = this.Adress + " <- deep clone result";
            DeepcloneHouse.Number = 99;

            return DeepcloneHouse;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            House house = new House();
            house.Adress = "Poshtova squer";
            house.Number = 1;

            House deepClonehouse = house.DeepClone();
            deepClonehouse.Adress = deepClonehouse.Adress;

            Console.WriteLine($"Original: {house.Adress}");
            Console.WriteLine($"DeepClone: {deepClonehouse.Adress}");


            House house1 = new House();
            house1.Adress = "khreschatyk";
            house1.Number = 28;

            Console.WriteLine($"Original befor: {house1.Adress}");
            House cloneHouse1 = house1.Clone();
            cloneHouse1.Adress = "Lobanovskogo";
            Console.WriteLine($"Clone: {cloneHouse1.Adress}");
            
            Console.WriteLine($"Original after change clone: {house1.Adress}");



            Console.ReadKey();
            
        }
    }
}
