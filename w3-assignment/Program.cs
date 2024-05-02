using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w3_assignment
{
    class Program
    {

        static void Main(string[] args)
        {

            //starting lists
        
            List<string> names = new List<string>();
            List<int> hoursWorked = new List<int>();
            List<double> hourlyRates = new List<double>();
            List<double> taxBrackets = new List<double>();
            string answer;

            //begining user input loop (do while loop)
            do
            {
                Console.Write("Enter employee name: ");
                string name = Console.ReadLine();

                names.Add(name);

                //apend to list
                hoursWorked.Add(GetIntInput("Enter hours worked: "));
                hourlyRates.Add(GetDoubleInput("Enter hourly rate: "));
                taxBrackets.Add(GetDoubleInput("Tax (as decimal): "));

                Console.Write("Do you want to enter another employee? (y/n): ");
                answer = Console.ReadLine().ToLower();

            } while (answer == "y");

            //output loop
            double totalIncome = 0;
            for (int i = 0; i < names.Count; i++)
            {
                double pay = CalcPay(hoursWorked[i], hourlyRates[i], taxBrackets[i]);
                Console.WriteLine($"{names[i]}'s pay is {pay}");
                totalIncome += pay;
            }

            //average income calc
            double averageIncome = totalIncome / names.Count;
            Console.WriteLine($"The average income is {averageIncome}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        //input valid method
        static int GetIntInput(string prompt){
        
            int value;
            Console.Write(prompt);

            while (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                Console.Write(prompt);
            }
            return value;
        }

        //user input method
        static double GetDoubleInput(string prompt){
        
            double value;
            Console.Write(prompt);

            while (!double.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                Console.Write(prompt);
            }
            return value;
        }

        //calc method
        static double CalcPay(int hours, double rate, double taxBracket)
        {
            double grossPay = hours * rate;
            double tax = grossPay * taxBracket;
            return grossPay - tax;
        }
    }
}
            