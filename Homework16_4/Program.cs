using System;

namespace Homework16_4
{

   
    class MyClass
    {
       
        DateTime date;

        public MyClass()
        {
            date = DateTime.Now.Date;
        }

        public MyClass(DateTime date)
        {
            this.date = date;
        }

        public DateTime Date { get { return date; } }

        
        public static int operator - (MyClass d1, MyClass d2) => (d1.date - d2.date).Days;

        public static int Datediff(MyClass d1, MyClass d2)
        {
            return d1 - d2; //use int operator - 
        }


        public static MyClass operator +(MyClass myClass, int change) => new MyClass(myClass.Date.AddDays(change));

    }

    class Program
    {
        static void Main(string[] args)
        {

            MyClass myClass1 = new MyClass();
            MyClass myClass2 = new MyClass(DateTime.Now.AddYears(1).Date);

            Console.WriteLine($"BeginDate: {myClass1.Date}");
            Console.WriteLine($"EndDate: {myClass2.Date}");

            int d = Math.Abs( MyClass.Datediff(myClass1, myClass2) );

            Console.WriteLine($"Diff = {d}");

            MyClass myClass3 = myClass2 + d; //use int operator +

            Console.WriteLine($"Ovveride +: {myClass3.Date} = {myClass2.Date} + {d}");


            Console.ReadKey();
        }
    }
}
