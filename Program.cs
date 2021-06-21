using System;

namespace NoOfOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test Array 1
            int[] M = { 3, 7, 1, 4, 1, 2 };
            int[] N = { 3, 7, 3, 6, 3, 2 };

            // Test Array 2
            int[] M1 = { 1, 1, 1, 1, 1 };
            int[] N1 = { 1, 2, 1, 3, 1 };

            // Other Variables and Array
            int[] minIndex = { -1, -1, -1, -1, -1, -1 };
            int min = 0, steps = 0;
            bool equal = false, first = true;

            // Test With Array 1
            do {
                for (int i = 0; i < M.Length; i++)
                {
                    if (M[i] != N[i])
                    {
                        if (min == 0)
                        {
                            min = N[i] - M[i];
                            minIndex[i] = 1;
                        } else if ((N[i] - M[i]) < min)
                        {
                            min = N[i] - M[i];
                            minIndex[i] = 1;
                        }else
                        {
                            minIndex[i] = 1;
                        }
                    }
                }
                for (int i = 0; i < M.Length; i++)
                {
                    if(minIndex[i] == 1)
                    {
                        M[i] += min;
                        minIndex[i] = -1;
                    }
                }
                
                if(min == 0)
                {
                    equal = true;
                }
                
                if(first == false)
                {
                    steps += 1;
                }

                min = 0;
                first = false;

            } while (equal == false);
            
            // Output
            Console.WriteLine("Test With Array 1- \nOutput: {0}\n", steps);

            // Variable Reset
            steps = 0;
            equal = false;
            first = true;

            // Test With Array 2
            do
            {
                for (int i = 0; i < M1.Length; i++)
                {
                    if (M1[i] != N1[i])
                    {
                        if (min == 0)
                        {
                            min = N1[i] - M1[i];
                            minIndex[i] = 1;
                        }
                        else if ((N1[i] - M1[i]) < min)
                        {
                            min = N1[i] - M1[i];
                            minIndex[i] = 1;
                        }
                        else
                        {
                            minIndex[i] = 1;
                        }
                    }
                }
                for (int i = 0; i < M1.Length; i++)
                {
                    if (minIndex[i] == 1)
                    {
                        M1[i] += min;
                        minIndex[i] = -1;
                    }
                }

                if (min == 0)
                {
                    equal = true;
                }

                if (first == false)
                {
                    steps += 1;
                }

                min = 0;
                first = false;

            } while (equal == false);

            // Output
            Console.WriteLine("\nTest With Array 2- \nOutput: {0}\n", steps);
        }
    }
}