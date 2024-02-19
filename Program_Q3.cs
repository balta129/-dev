using System;

namespace RepeatLesson
{
    public class Program_Q3
    {
        public static void Main_Q3(string[] args)
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
           
           Console.Write("Sum of all elements stored in the array is: ");
            int sum = 0;
            for (int i = 0; i < number; i++)
            {
                sum = sum + array[i];
            }
            Console.Write(sum);
            
                
            
        
        }
          
    }
}