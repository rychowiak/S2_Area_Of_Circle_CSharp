using AreaOfCircle;

internal class Program
{
    private static void Main(string[] args)
    {
        double radius;
        while(true)
        {
            Console.Write("Enter radius of circle: ");
            radius = Convert.ToDouble(Console.ReadLine());
            if (radius < 1)
            {
                Console.WriteLine("Please enter a positive number.");
                continue;
            }
            else
                break;
        }


        Circle.CircleArea(radius, 3.14);
        double circumference = Circle.CircleCircumference(radius, 3.14);
        Circle.CircleDiameter(radius);

        double km, litersConsumed;

        while (true)
        {
            Console.Write("How many km per liters your car consumes? (only km): ");
            km = Convert.ToDouble(Console.ReadLine());

            if (km < 1)
            {
                Console.WriteLine("Please enter positive number");
                continue;
            }
            else
                break;
        }

        litersConsumed = circumference / km;
        Console.WriteLine("Assuming the radius entered is in km, your car will use {0:0.00} liters of gas to go around the circle.", litersConsumed);
    }
}