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
    public class Program_HowGreenIsMyValley
    {
        public static void Main_HowGreenIsMyValley(string[] args)
        {
            
      //How Green Is My Valley?
      
     Console.Write("Input the number of elements to store in the array: ");
            int number = Convert.ToInt32(Console.ReadLine());
            
            int[] array = new int[number];
            int[] left = new int [number];
            int[] right = new int [number];
            

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
                    if(array[j+1] > array[j])
                    {
                        a = array[j+1];
                        array[j+1] = array[j];
                        array[j] = a;
                    }
                }
            }
            int k = 0;
            int p = 0;

            for(int i = 0; i < number; i++)
            {
                if(i % 2 == 0)
                {
                    left[k] = array[i];
                    k++;
                }
                else
                {
                    right[p] = array[i];
                    p++;
                }
            }
            Console.Write("The bottom is : " + array[number-1]);
            Console.WriteLine(" ");
            Console.WriteLine("Left wing is : ");
            for (int i = 0; i < k; i++)
            {
                Console.Write(left[i] +" ");
            }
            Console.WriteLine(" ");
            Console.WriteLine("Right wing is : ");
            for (int i = p-1; i >= 0; i--)
            {
                Console.Write(right[i]+" ");
            }
            Console.WriteLine(" ");
            Console.Write("make_valley(a) : [ ");
            for(int i = 0; i < k; i++)
            {
                Console.Write(left[i] +" ");
            }
            for(int i = p-1; i >= 0; i--)
            {
                Console.Write(right[i]+" ");
            }
            Console.Write("]");
            
            
           


            
           
            
            
    
            
            
            
            
            
            
            
            
            
           



            

            
                
                
            
            


            
                
            
        
        }
          
    }
}