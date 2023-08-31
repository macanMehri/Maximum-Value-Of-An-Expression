using System;


namespace tamrin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your list of numbers: ");

            int[] TheArray = new int[100000];
            int len = 0;
            try
            {
                for (int i = 0; i < TheArray.Length; i++)
                {
                    if (i == TheArray.Length - 1)
                    {
                        Console.WriteLine("You are not allowed to insert more numbers!");
                        break;
                    }
                    Console.Write(string.Format("Please enter value of index {0} or -1000 to proceed: ", i + 1));
                    TheArray[i] = Convert.ToInt32(Console.ReadLine());

                    if (TheArray[i] == -1000)
                        break;

                    len++;
                }

                Console.WriteLine("Now please enter three numbers: ");
                Console.Write("Please enter number for x: ");
                int n1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter number for y: ");
                int n2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter number for z: ");
                int n3 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(string.Format("The max value of the expression is: {0}", MaxValue(TheArray, len, n1, n2, n3)));
                Console.ReadKey();

                // finding the max value of (x*i + y*j + z*k)               for i <= j <= k
                int MaxValue(int[] l, int ArrayLength, int x, int y, int z)
                {
                    int max = 0;
                    int value;

                    for (int i = 0; i < ArrayLength; i++)
                    {
                        for (int j = i; j < ArrayLength; j++)
                        {
                            for (int k = j; k < ArrayLength; k++)
                            {
                                value = (x * l[i]) + (y * l[j]) + (z * l[k]);

                                if (value > max)
                                    max = value;
                            }
                        }
                    }
                    return max;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
