using System;
    namespace GreetingApp
{
    class GreetingProgram
    {
        static void Main(string[] args)
        {

            Console.Write("Enter your name: ");
            var name = Console.ReadLine();
            Console.Write("Enter the total number of your enrolled courses: ");
            int numOfCourse = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the price of your favorite book: ");
            double bookPrice = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nName: " + name);
            Console.WriteLine("Total enrolled courses: " + numOfCourse);
            Console.WriteLine("Price of my favorite book: " + bookPrice);

        }
    }
} //by January Toribio Jr.
//unique na din to someday
