using System;
using System.Diagnostics;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;

namespace RepeatLesson
{
    public class Program_Q10
    {
        public static void Main_Q10(string[] args)
        {
            
            Console.Write("Input the number of elements to store in the array: ");
            int number = Convert.ToInt32(Console.ReadLine());
            
            int[] array = new int[number];
            int[] even = new int[100]; // çift
            int[] odd = new int[100];  //tek   
           
            Console.WriteLine("Input " + number + " number of elements in the array:");

            for(int i = 0; i < number; i++)
            {
                Console.Write("Element - "+ i +" : " );
                array [i] = Convert.ToInt32(Console.ReadLine());
            }
            int a = 0;
            int k = 0;
            for (int i = 0; i < number; i++)
            {
                if (array[i] % 2 == 0)
                {
                    even[k] = array[i];
                    k++;
                    
                }
                if (array[i] % 2 != 0)
                {
                    odd[a] = array[i];
                    a++;
                    
                }
            }
                Console.WriteLine("The even elements are : ");
                for(int i = 0; i < k; i++)
                {
                    Console.Write(even[i] + " ");
                }
                Console.WriteLine(" ");
                Console.WriteLine("The odd elements are : ");
                for(int i = 0; i < a; i++)
                {
                    Console.Write(odd[i] + " ");
                }

            
            
    
            
            
            
            
            
            
            
            
            
           



            

            
                
                
            
            


            
                
            
        
        }
          
    }
}