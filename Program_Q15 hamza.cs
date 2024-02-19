using System;
using System.Diagnostics;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;

namespace RepeatLesson
{
    public class Program_Q15hamza
    {
        public static void Main_Q15hamza(string[] args)
        {
            // soruyu tam anlayamadım o yüzden küçükten büyüğe sıralayıp doğru yere sayıyı koydurdum.
            
            Console.Write("Input the number of elements to store in the array: ");
            int number = Convert.ToInt32(Console.ReadLine());
           
            int[] array = new int[number];
            int[] array2 = new int[number-1];
        
            Console.WriteLine("Input " + number + " number of elements in the array:");

            for(int i = 0; i < number; i++)
            {
                Console.Write("Element - "+ i +" : " );
                array [i] = Convert.ToInt32(Console.ReadLine());
            }
            
            Console.Write("Input the position where to delete : ");
            int delete = Convert.ToInt32(Console.ReadLine());
            
            for(int i = 0; i < delete-1; i++)
            {
                array2[i] = array[i];
            }
            for(int i = delete; i < number; i++)
            {
                array2[i-1] = array[i];
            }
            Console.Write("The new list is : ");
            for(int i = 0; i < number-1; i++)
            {
                Console.Write(array2[i] + " ");
            }




            
            
            
            
            



            
           

            
            
    
            
            
            
            
            
            
            
            
            
           



            

            
                
                
            
            


            
                
            
        
        }
          
    }
}