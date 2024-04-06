using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1 {
    class Program {
        static void Main (string[] args) {
            String strName, strHours, strRate; // declaring strings
            Double dblHours, dblRate, dblGross, dblNet, dblTax = 0; // declaring doubles

            Console.WriteLine ("Welcome to the Payroll Calc"); // welcome message


            Console.Write ("Please enter your name: "); //  name prompt
            strName = Console.ReadLine (); // read name

            Console.Write ("Please enter hours worked: "); // hours prompt
            strHours = Console.ReadLine (); // read hours

            Console.WriteLine ("Please enter your rate (hr): "); // rate prompt
            strRate = Console.ReadLine (); // read rate


            //converting to float
            dblHours = Convert.ToDouble (strHours);
            dblRate = Convert.ToDouble (strRate);


            //calculating gross pay
            dblGross = dblHours * dblRate;


            //tax brackets
            if (dblGross <= 300) {
                dblTax = 0;
            } 
            
            else if (dblGross >= 500 && dblGross <= 700) {
                dblTax =  dblGross * 0.1;
            } 
            
            else if (dblGross >= 700 && dblGross <= 1000) {
                dblTax = dblGross * 0.15;
            } 
            
            else if (dblGross >= 1000) {
                dblTax = dblGross * 0.2;
            }

            dblNet = dblGross - dblTax;

            Console.WriteLine ($"Hello {strName} your gross pay is: {dblGross} | net pay: {dblNet} | taxed: {dblTax}");

            Console.WriteLine ("Thank you for using the Payroll Calc");

            Console.ReadKey ();

        }
    }
}
