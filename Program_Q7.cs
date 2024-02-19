using System;
using System.Diagnostics;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

namespace RepeatLesson
{
    public class Program_Q7
    {
        public static void Main_Q7(string[] args)
        {
            
            Console.Write("Input the number of elements to store in the first array: ");
            int number = Convert.ToInt32(Console.ReadLine());
            
            int[] array = new int[number];
           
            Console.WriteLine("Input " + number + " number of elements in the array:");

            for(int i = 0; i < number; i++)
            {
                Console.Write("Element - "+ i +" : " );
                array [i] = Convert.ToInt32(Console.ReadLine());
            }
            
            Console.Write("Input the number of elements to store in the second array: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int[] array2 = new int[number2];
            
            Console.WriteLine("Input " + number2 + " number of elements in the array:");

            for(int i = 0; i < number2; i++)
            {
                Console.Write("Element - "+ i +" : " );
                array2[i] = Convert.ToInt32(Console.ReadLine());
            }
               
            int[]array3 = new int[number+number2];
           
            for(int i = 0; i < number; i++)
            {
                array3[i] = array[i];
            }  
            for(int j = 0; j < number2; j++)
            {
                array3[number-1+j+1] = array2[j];
            }
            
            int a = 0;
            for(int i = 0; i < number+number2; i++)
            {
                for(int j = 0; j < number+number2-1; j++)
                {
                    if(array3[j] > array3[j+1])
                    {
                        a = array3[j+1];
                        array3[j+1] = array3[j];
                        array3[j] = a;
                    }
                }
            }
            Console.WriteLine("The merged array in ascending order is : ");
            for(int i = 0; i < number+number2; i++)
            {
                Console.Write(array3[i] +" ");
            }
            
            
            
            
            
            
            
           



            

            
                
                
            
            


            
                
            
        
        }
          
    }
}