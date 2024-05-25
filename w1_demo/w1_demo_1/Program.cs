using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_Samplel {
    class Program {
        static void Main (string[] args) {

            // Declare Variables
            String strFirst, strOperand, strNum1, strNum2;
            Int32 intNum1 = 0, intNum2 = 0, intResult = 0;
            Double dblResult;

            // Display a welcome message
            Console.WriteLine ("Hello There!");

            // Prompt the user for their first name
            Console.Write ("Please enter your first name: ");
            strFirst = Console.ReadLine ();

            Console.WriteLine ("Hello " + strFirst + "! Let's do some math!");

            Console.Write ("Please enter the first number: ");
            strNum1 = Console.ReadLine ();

            // Prompt the user for the math operation
            Console.Write ("Please enter the math operation (PLUS, MINUS, MULTIPLY, DIVIDE): ");
            strOperand = Console.ReadLine ();

            strOperand = strOperand.ToUpper ();

            Console.Write ("Please enter the second number: ");
            strNum2 = Console.ReadLine ();

            // Convert the string values to integers
            intNum1 = Int32.Parse (strNum1);
            intNum2 = Convert.ToInt32 (strNum2);


            // Perform the math operations with switch case
            switch (strOperand) {
                case "PLUS":
                    intResult = intNum1 + intNum2;
                    break;
                case "MINUS":
                    intResult = intNum1 - intNum2;
                    break;
                case "DIVIDE":
                    intResult = intNum1 / intNum2;
                    break;
                case "MULTIPLY":
                    intResult = intNum1 * intNum2;
                    break;
            }

            // Convert the integer result to a double
            dblResult = (Double) intResult;

            // Display the result
            if (strOperand == "PLUS")
                Console.WriteLine ($"\n\nThe sum of {intNum1} and {intNum2} equals: {dblResult}");
            else if (strOperand == "MINUS")
                Console.WriteLine ($"\n\nThe difference of {intNum1} and {intNum2} equals: {dblResult}");
            else if (strOperand == "DIVIDE")
                Console.WriteLine ($"\n\nThe quotient of {intNum1} and {intNum2} equals: {dblResult}");
            else if (strOperand =="MULTIPLY")
                Console.WriteLine($"\n\nThe result of {intNum1} and {intNum2} equals: {dblResult}");

            // Pause the program
            Console.WriteLine ("\n\nPress Any Key to Continue");
            Console.ReadKey ();
        }
    }
}