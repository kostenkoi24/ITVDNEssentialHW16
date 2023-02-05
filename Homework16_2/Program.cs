using System;

namespace Homework16_2
{

    class Block
    {
        int leftSide;
        int rightSide;
        int topSide;
        int downSide;

        public Block(int leftSide, int rightSide, int topSide, int downSide )
        {
            this.leftSide = leftSide;
            this.rightSide = rightSide;
            this.topSide = topSide;
            this.downSide = downSide;

        }


        public override string ToString() => $"[leftSide: {leftSide}; rightSide: {rightSide}; topSide: {topSide}; downSide: {downSide}]";



        public override bool Equals(object obj)
        {

            if (obj is Block && obj != null)
            {
                Block temp;
                temp = (Block)obj;
                if (temp.leftSide == this.leftSide && temp.rightSide == this.rightSide && temp.topSide == this.topSide && temp.downSide == this.downSide)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
            
        }

       
    }

    class Program
    {
        static void Main(string[] args)
        {
            Block block0 = new Block(5, 5, 10, 10);
            Block block1 = new Block(5, 5, 10, 10);
            Block block2 = new Block(6, 6, 7, 7);

            Console.WriteLine(block0.ToString());

            Console.WriteLine($"Equals {block0.ToString()} and {block1.ToString()} = {block0.Equals(block1)}" );

            Console.WriteLine($"Equals {block0.ToString()} and {block2.ToString()} = {block0.Equals(block2)}");


            Console.ReadKey();
            
    
        }


        

    }

}
