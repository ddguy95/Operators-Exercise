namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1

            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;

            if (a == 17 && b == 4)
            {
                Console.WriteLine($"{a}/{b} is quotient {quotient} remainder {remainder}");
            }


            //Exercise 2 see ClassCircleMethod1

            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            ClassCircleMethod1.AreaOfCircle(radius);

        }
    }
}