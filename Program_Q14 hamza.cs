using System;
using System.Diagnostics;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;

namespace RepeatLesson
{
    public class Program_Q14hamza
    {
        public static void Main_Q14hamza
        (string[] args)
        {
            
            
            Console.Write("Input the number of elements to store in the array: ");
            int number = Convert.ToInt32(Console.ReadLine());
           
            int[] array = new int[number];
            int[] array2 = new int[number+1];
        
            Console.WriteLine("Input " + number + " number of elements in the array:");

            for(int i = 0; i < number; i++)
            {
                Console.Write("Element - "+ i +" : " );
                array [i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Input the value to be inserted : ");
            int newnumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the Position, where the value to be inserted : ");
            int position = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < position - 1; i++)
            {
                array2[i] = array[i];
            }
            array2[position-1] = newnumber;
            for (int i = position-1; i < number; i++)
            {
                array2[i+1] = array[i];
            }
            Console.WriteLine("The current list of the array : ");
            for(int i = 0; i < number; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine(" ");
            Console.WriteLine("After Insert the element the new list is : ");
            for(int i = 0; i < number + 1; i++)
            {
                Console.Write(array2[i] + " ");
            }

            
            
            
            
            



            
           

            
            
    
            
            
            
            
            
            
            
            
            
           



            

            
                
                
            
            


            
                
            
        
        }
          
    }
}