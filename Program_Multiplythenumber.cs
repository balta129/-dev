using System;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;

namespace RepeatLesson
{
    public class Program_Multiplythenumber
    {
        public static void Main_Multiplythenumber(string[] args)
        {
            
      //Jack really likes his number five: the trick here is that you have to multiply each number by 5 raised to the number of digits of each numbers, so, for example:
      //multiply(3) == 15 // 3 * 5¹
      //multiply(10) == 250 // 10 * 5²
      //multiply(200) == 25000 // 200 * 5³
      //multiply(0) == 0 // 0 * 5¹
      //multiply(-3) == -15 // -3 * 5¹
       Console.Write("Please enter the multiply number: ");
            int multiply = Convert.ToInt32(Console.ReadLine());
            
              if( -10 < multiply && multiply < 10)
            {
                Console.Write("multiply("+multiply+") == "+multiply*5+"");
            }
              else if( -100 < multiply && multiply < 100)
              {
                Console.Write("multiply("+multiply+") == "+multiply*5*5+"");
              }
              else if( -1000 < multiply && multiply < 1000)
              {
                Console.Write("multiply("+multiply+") == "+multiply*5*5*5+"");
              }

           


            
           
            
            
    
            
            
            
            
            
            
            
            
            
           



            

            
                
                
            
            


            
                
            
        
        }
          
    }
}