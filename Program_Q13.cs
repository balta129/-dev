using System;
using System.Diagnostics;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;

namespace RepeatLesson
{
    public class Program_Q13
    {
        public static void Main_Q13(string[] args)
        {
            // soruyu tam anlayamadım o yüzden sıralayıp yazdırdım.
            
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
            array2[0] = newnumber;
            int a = 0;
            
            for(int i = 0; i < number; i++)
            {
                array2[i+1] = array[i];
            }

            for(int i = 0; i < number+1; i++)
            {
                for(int j = 0; j < number+1-1; j++)
                {
                    if(array2[j] > array2[j+1])
                    {
                        a = array2[j+1];
                        array2[j+1] = array2[j];
                        array2[j] = a;
                    }
                }
            }
           
        
            Console.WriteLine("The exist array list is : ");
            for(int i = 0; i < number; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine(" ");
            Console.WriteLine("After Insert the list is : ");
            for(int i = 0; i <= number; i++)
            {
                Console.Write(array2[i] + " ");
            }
            
            
            



            
           

            
            
    
            
            
            
            
            
            
            
            
            
           



            

            
                
                
            
            


            
                
            
        
        }
          
    }
}