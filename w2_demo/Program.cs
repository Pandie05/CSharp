using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w2_demo {
    class Program {

        static string reverseString(string str) {

            string reversed = "";
            
            Console.WriteLine("input: " + str);

            for (int i = str.Length - 1; i >= 0; i--) {

                reversed += str[i];
            }

            return reversed;

        }

        static void Main (string[] args) { 

           /*  for (int i = 1; i <= 10; i++) {

                for (int j = 1; j <= 10; j++) {

                    Console.Write ($"{i * j}\t");

                }

                Console.WriteLine ($"\n");
                
            }
            */

            Console.WriteLine($"Output: {reverseString("TacocaT | RacecaR | HannaH")}");

        }

    }
}        