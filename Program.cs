namespace exe_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variable declaration
            float workHours = 0, missedHours = 0, hourPay = 0, totalPay = 0;

            //recieving input
            Console.WriteLine("Enter hours worked:");
            workHours = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter hours missed:");
            missedHours= int.Parse(Console.ReadLine());

            Console.WriteLine("Enter pay per hour:");
            hourPay= int.Parse(Console.ReadLine());

            //calculating salary without bonus
            totalPay = hourPay * workHours;

            //adding or not adding 10% bonus
            if (missedHours<3.5)
            {
                totalPay += totalPay / 10;
            }

            //printing salary
            Console.WriteLine($"The salary is: {totalPay}");

        }
    }
}