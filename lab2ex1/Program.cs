/*
  Scrieti o functie care citeşte de la tastatură un şir de n numere naturale şi
    determină media aritmetică a celor pare, n fiind citit de la tastatra
 */


namespace lab2ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = Convert.ToInt32(Console.In.ReadLine());
            int[] array = new int[size];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.In.ReadLine());

            }
            int sum = 0; 
            for (int i = 0;i < array.Length; i++)
            {
                if (array[i] %2 == 0)
                {
                    Console.WriteLine(array[i]);
                    sum += array[i];
                }
            }
            Console.WriteLine(sum/size);
        }
    }
}
