﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_Samplel {
    class Program {
        static void Main (string[] args) {
            String strFirst, strOperand, strNum1, strNum2;
            Int32 intNum1 = 0, intNum2 = 0, intNum3, intResult = 0;
            Double dblResult;

            Console.WriteLine ("Hello There!");

            Console.Write ("Please enter your first name: ");
            strFirst = Console.ReadLine ();

            Console.WriteLine ("Hello " + strFirst + "! Let's do some math!");

            Console.Write ("Please enter the first number: ");
            strNum1 = Console.ReadLine ();

            Console.Write ("Please enter the math operation (PLUS, MINUS, MULTIPLY, DIVIDE, EXPONENT): ");
            strOperand = Console.ReadLine ();

            Console.Write ("Please enter the second number: ");
            strNum2 = Console.ReadLine ();

            intNum1 = Int32.Parse (strNum1);
            intNum2 = Convert.ToInt32 (strNum2);

            strOperand = strOperand.ToUpper();
            switch (strOperand) {
                case "PLUS":
                    dblResult = intNum1 + intNum2;
                    break;
                case "MINUS":
                    dblResult = intNum1 - intNum2;
                    break;
                case "DIVIDE":
                    dblResult = intNum1 / intNum2;
                    break;
                case "MULTIPLY":
                    dblResult = intNum1 * intNum2;
                    break;
                case "EXPONENT":
                    dblResult = Math.Pow(intNum1, intNum2);
                    Console.WriteLine ($"\n\nThe Exponent of {intNum1} and {intNum2} equals: {dblResult}");
                    break;
            }

            if (strOperand != "EXPONENT") {
                dblResult = (Double) intResult;
            }


            //dblResult = (Double) intResult;

            if (strOperand == "PLUS")
                Console.WriteLine ($"\n\nThe sum of {intNum1} and {intNum2} equals: {dblResult}");
            else if (strOperand == "MINUS")
                Console.WriteLine ($"\n\nThe difference of {intNum1} and {intNum2} equals: {dblResult}");
            else if (strOperand == "DIVIDE")
                Console.WriteLine ($"\n\nThe quotient of {intNum1} and {intNum2} equals: {dblResult}");
            else if (strOperand == "MULTIPLY")
                Console.WriteLine ($"\n\nThe Product of {intNum1} and {intNum2} equals: {dblResult}");
            else if (strOperand == "EXPONENT")
                Console.WriteLine ($"\n\nThe Exponent of {intNum1} and {intNum2} equals: {intResult}");

            Console.WriteLine ("\n\nPress Any Key to Continue");
            Console.ReadKey ();
        }
    }
}