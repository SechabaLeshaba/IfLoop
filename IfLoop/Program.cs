internal class Program
{
    private static void Main(string[] args)
    {
        //declaration
        int mark;
        int sum = 0;
        int average;

        //inputs
        for (int i = 0; i <= 2; i++)
        {
            Console.Write(" Enter mark {0}: ", (i + 1));
            mark = Convert.ToInt32(Console.ReadLine());

            if (mark < 0)
            {
                Console.WriteLine(" Wrong value entered,Please Re-Enter");
                i = i - 1;
            }
            else if(mark > 100)
            {
                Console.WriteLine(" Wrong value entered,Please Re-Enter");
                i = i - 1;
            }
            else
            {
                sum = sum + mark;
            }
            //Calculations
            sum = sum + mark;
        }
       

        //Calculations
        
        average= sum / 3;
       

        if(average < 50)
        {
            Console.WriteLine("fail");
        }
        else if(average < 75)
        {
            Console.WriteLine("Pass ");
        }
        else
        {
            Console.WriteLine("PD");
        }
        Console.WriteLine(average);
    }
}