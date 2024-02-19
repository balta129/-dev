using System;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;

namespace RepeatLesson
{
    public class Program_Q4
    {
        public static void Main_Q4(string[] args)
        {
            Console.Write("Input the number of elements to store in the array: ");
            int number = Convert.ToInt32(Console.ReadLine());
            
            int[] array = new int[number];
            int[] arraycopied = new int[number];
            

            Console.WriteLine("Input " + number + " number of elements in the array:");

            for(int i = 0; i < number; i++)
            {
                Console.Write("Element - "+ i +" : " );
                array [i] = Convert.ToInt32(Console.ReadLine());
            }
           
            Console.WriteLine("The elements stored in the first array are: ");
            
            for(int i = 0; i < number; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine(" ");
            for(int i = 0; i < number; i++)
            {
                arraycopied[i] = array[i];
            }

            Console.WriteLine("The elements copied into the second array are: ");
            for(int i = 0; i < number; i++)
            {
                Console.Write(array[i] + " ");
            }


            
                
            
        
        }
          
    }
}