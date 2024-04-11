using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w2_assignment {
    class Program {
        static void Main (string[] args) { 

        //employee num (for the loop)
        Console.Write("enter the number of employees: ");
        int numEmployees = Convert.ToInt32(Console.ReadLine());

        //make List
        List<string> names = new List<string>();
        List<int> hoursWorked = new List<int>();
        List<double> hourlyRates = new List<double>();
        List<double> taxBrackets = new List<double>();


        //for loop based on employees
        for (int i = 0; i < numEmployees; i++)
        {

            //variables

            Console.Write("enter employee name: ");
            names.Add(Console.ReadLine());

            Console.Write("enter hours worked: ");
            hoursWorked.Add(Convert.ToInt32(Console.ReadLine()));

            Console.Write("enter hourly rate: ");
            hourlyRates.Add(Convert.ToDouble(Console.ReadLine()));

            Console.Write("enter tax bracket (as a decimal): ");
            taxBrackets.Add(Convert.ToDouble(Console.ReadLine()));
        }

        //calcs
        double totalIncome = 0;
        for (int i = 0; i < numEmployees; i++)
        {
            double grossPay = hoursWorked[i] * hourlyRates[i];
            double tax = grossPay * taxBrackets[i];
            double pay = grossPay - tax;

            Console.WriteLine($"{names[i]}'s pay is {pay}");
            totalIncome += pay;
        }

        //avg
        double averageIncome = totalIncome / numEmployees;
        Console.WriteLine($"the average income is {averageIncome}");
         
        }
    }
}
        