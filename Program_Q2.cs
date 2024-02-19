using System;

namespace RepeatLesson
{
    public class Program_Q2
    {
        public static void Main_Q2(string[] args)
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
            Console.WriteLine("The values store into array are:");

            for(int i = 0; i < number; i++)
            {
                Console.Write(array[i]+" ");
            }
            Console.WriteLine(" ");
            Console.WriteLine("The values store into the array in reverse are:");

            for(int i = number-1; i >= 0; i--)
            {
                Console.Write(array[i]+" ");
            }


           
            
                
            
        
        }
          
    }
}