using System;
using System.Diagnostics;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;

namespace RepeatLesson
{
    public class Program_Q16
    {
        public static void Main_Q16(string[] args)
        {
            
            Console.Write("Input the number of elements to store in the array: ");
            int number = Convert.ToInt32(Console.ReadLine());
            
            int[] array = new int[number];
           
           
            Console.WriteLine("Input " + number + " number of elements in the array:");

            for(int i = 0; i < number; i++)
            {
                Console.Write("Element - "+ i +" : " );
                array [i] = Convert.ToInt32(Console.ReadLine());
            }
            int a = 0;
            for(int i = 0; i < number; i++)
            {
                for(int j = 0; j < number-1; j++)
                {
                    if(array[j] > array[j+1])
                    {
                        a = array[j+1];
                        array[j+1] = array[j];
                        array[j] = a;
                    }
                }
            }   
            Console.Write("The Second largest element in the array is : ");
            Console.Write(array[number-2]);

            
           
            
            
    
            
            
            
            
            
            
            
            
            
           



            

            
                
                
            
            


            
                
            
        
        }
          
    }
}