namespace For_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = GetPow(3, 4);
            Console.WriteLine(result);
            for (int i=0; i <=4; i+=2)
            {
                for (int j=0; j <=4; j+=2)
                    for(int k=0; k <= 4; k+=2)
                    {
                        Console.WriteLine($"{i},{j},{k}");

                    }
                
            }

            string[] fruits = { "Mangoes","Apples","Citrus","Avocado","Grapes","Passion" };

            for (int fruit=0; fruit < fruits.Length; fruit++)
            {
                Console.WriteLine(fruits[fruit]);
            }
        }

        static int GetPow(int baseNum, int powNum)
        {
            int value = 1;

            for( int i=0; i <powNum; i++)
            {
                value = value * baseNum;
            }

            return value;
        }
    }
}