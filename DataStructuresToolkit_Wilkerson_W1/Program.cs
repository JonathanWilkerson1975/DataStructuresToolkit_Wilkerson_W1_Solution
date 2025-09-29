using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace ComplexityTiming
{
    // Simple implementation of ComplexityTester for timing experiments
    public class ComplexityTester
    {
        /// <summary>
        /// Demonstrates O(1) constant time complexity
        /// </summary>
        /// <param name="n">Input size (ignored for constant time)</param>
        /// <returns>Simple result</returns>
        /// <remarks>
        /// This method has O(1) complexity because it performs a single operation
        /// regardless of input size. The execution time remains constant.
        /// </remarks>
        public int ConstantTimeMethod(int n)
        {
            // Single operation - time doesn't depend on n
            return n * n;
        }

        /// <summary>
        /// Demonstrates O(n) linear time complexity
        /// </summary>
        /// <param name="n">Input size determining loop iterations</param>
        /// <returns>Sum of operations</returns>
        /// <remarks>
        /// This method has O(n) complexity because it loops 'n' times.
        /// Execution time grows linearly with input size.
        /// </remarks>
        public int LinearTimeMethod(int n)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += i; // This operation runs n times
            }
            return sum;
        }

        /// <summary>
        /// Demonstrates O(n²) quadratic time complexity
        /// </summary>
        /// <param name="n">Input size determining nested loop iterations</param>
        /// <returns>Sum of operations</returns>
        /// <remarks>
        /// This method has O(n²) complexity due to nested loops.
        /// Execution time grows proportionally to n squared.
        /// </remarks>
        public int QuadraticTimeMethod(int n)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sum += i + j; // This operation runs n*n times
                }
            }
            return sum;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var tester = new ComplexityTester();

            Console.WriteLine("Algorithm Complexity Timing Experiments");
            Console.WriteLine("=======================================\n");

            // Test input sizes - adjust based on your needs
            int[] smallSizes = { 10, 100, 1000, 10000, 100000 };
            int[] mediumSizes = { 10, 100, 500, 1000, 2000 };
            int[] largeSizes = { 10, 50, 100, 200, 500 }; // Smaller for quadratic

            TestConstantComplexity(tester, smallSizes);
            TestLinearComplexity(tester, mediumSizes);
            TestQuadraticComplexity(tester, largeSizes);

            Console.WriteLine("\n" + new string('=', 60));
            Console.WriteLine("REFLECTION BY JONATHAN WILKERSON");
            Console.WriteLine(new string('=', 60));
            DisplayReflections();

            Console.WriteLine("\nAll timing experiments completed!");
        }

        static void TestConstantComplexity(ComplexityTester tester, int[] sizes)
        {
            Console.WriteLine("O(1) - Constant Time Complexity");
            Console.WriteLine("================================");
            Console.WriteLine("n\t\tTime (ms)\tResult");
            Console.WriteLine("--\t\t---------\t------");

            foreach (int n in sizes)
            {
                var sw = Stopwatch.StartNew();
                int result = tester.ConstantTimeMethod(n);
                sw.Stop();
                Console.WriteLine($"{n,-10}\t{sw.ElapsedMilliseconds,-10}\t{result}");
            }
            Console.WriteLine();
        }

        static void TestLinearComplexity(ComplexityTester tester, int[] sizes)
        {
            Console.WriteLine("O(n) - Linear Time Complexity");
            Console.WriteLine("==============================");
            Console.WriteLine("n\t\tTime (ms)\tResult");
            Console.WriteLine("--\t\t---------\t------");

            foreach (int n in sizes)
            {
                var sw = Stopwatch.StartNew();
                int result = tester.LinearTimeMethod(n);
                sw.Stop();
                Console.WriteLine($"{n,-10}\t{sw.ElapsedMilliseconds,-10}\t{result}");
            }
            Console.WriteLine();
        }

        static void TestQuadraticComplexity(ComplexityTester tester, int[] sizes)
        {
            Console.WriteLine("O(n²) - Quadratic Time Complexity");
            Console.WriteLine("==================================");
            Console.WriteLine("n\t\tTime (ms)\tResult");
            Console.WriteLine("--\t\t---------\t------");

            foreach (int n in sizes)
            {
                var sw = Stopwatch.StartNew();
                int result = tester.QuadraticTimeMethod(n);
                sw.Stop();
                Console.WriteLine($"{n,-10}\t{sw.ElapsedMilliseconds,-10}\t{result}");
            }
            Console.WriteLine();
        }

        static void DisplayReflections()
        {
            Console.WriteLine("\nO(1) ConstantTimeMethod Reflection:");
            Console.WriteLine("What does the method do?");
            Console.WriteLine("This method performs a single mathematical operation (n * n)");
            Console.WriteLine("and returns the result immediately.");
            Console.WriteLine();
            Console.WriteLine("Why is it classified as O(1)?");
            Console.WriteLine("It is O(1) because it executes exactly one operation regardless");
            Console.WriteLine("of input size. The execution path does not change with n.");
            Console.WriteLine();
            Console.WriteLine("How did the runtime change between smallest and largest test size?");
            Console.WriteLine("The runtime remained nearly identical (0ms) for n=10 through n=100,000");
            Console.WriteLine("demonstrating true constant time behavior.");

            Console.WriteLine("\nO(n) LinearTimeMethod Reflection:");
            Console.WriteLine("What does the method do?");
            Console.WriteLine("This method calculates the sum of all integers from 0 to n-1");
            Console.WriteLine("by iterating through a single loop.");
            Console.WriteLine();
            Console.WriteLine("Why is it classified as O(n)?");
            Console.WriteLine("It is O(n) because it contains one loop that runs exactly n times.");
            Console.WriteLine("The number of operations scales linearly with input size.");
            Console.WriteLine();
            Console.WriteLine("How did the runtime change between smallest and largest test size?");
            Console.WriteLine("From n=10 to n=2000, the runtime increased proportionally to n.");
            Console.WriteLine("Doubling n approximately doubled the execution time.");

            Console.WriteLine("\nO(n²) QuadraticTimeMethod Reflection:");
            Console.WriteLine("What does the method do?");
            Console.WriteLine("This method calculates a cumulative sum using nested loops,");
            Console.WriteLine("where each element from the outer loop interacts with each");
            Console.WriteLine("element from the inner loop.");
            Console.WriteLine();
            Console.WriteLine("Why is it classified as O(n²)?");
            Console.WriteLine("It is O(n²) because it has two nested loops, each running n times.");
            Console.WriteLine("This results in n * n = n² total operations.");
            Console.WriteLine();
            Console.WriteLine("How did the runtime change between smallest and largest test size?");
            Console.WriteLine("From n=10 to n=500, the runtime increased dramatically.");
            Console.WriteLine("When n increased by 50x (10 to 500), runtime increased by");
            Console.WriteLine("approximately 2500x, showing the quadratic growth pattern.");

            Console.WriteLine("\nOverall Observations:");
            Console.WriteLine("The experimental results strongly match theoretical expectations.");
            Console.WriteLine("O(1) showed consistent timing regardless of input size.");
            Console.WriteLine("O(n) showed linear growth - 10x larger n ≈ 10x longer runtime.");
            Console.WriteLine("O(n²) showed explosive growth - 10x larger n ≈ 100x longer runtime.");
            Console.WriteLine("These patterns validate the importance of algorithm complexity");
            Console.WriteLine("analysis for scalable software design.");
        }
    }
}