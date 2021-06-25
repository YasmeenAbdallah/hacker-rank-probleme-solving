using System;
using System.Collections.Generic;
using System.Linq;


namespace hacker_rank_probleme_solving
{
    class Program
    {
        //compare triple probleme
        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            int aliceScore = 0;
            int bobScore = 0;
            for (var i = 0; i < 3; i++)
            {
                if (a[i] > b[i]) aliceScore++;
                else if (b[i] > a[i]) bobScore++;

            }
            List<int> result = new List<int>();
            if (aliceScore > bobScore)
            {
                result.Add(aliceScore);
                result.Add(bobScore);
            }
            else
            {
                result.Add(bobScore);
                result.Add(aliceScore);


            }
            return result;

        }

        //the diagonal
        /*
         * Complete the 'diagonalDifference' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts 2D_INTEGER_ARRAY arr as parameter.
         */

        public static int diagonalDifference(List<List<int>> arr)
        {
            int deffernce = 0;
            int right = 0 , left=0 , counter=arr.Count-1;
          
            for (int i = 0; i < arr.Count; i++)
            {
                
                   right += arr[i][i];
                   left += arr[i][counter];
                counter--;
                
            }
            deffernce = Math.Abs(right - left);
            

            return deffernce;
        }

        /* Complete the 'aVeryBigSum' function below.
         *
         * The function is expected to return a LONG_INTEGER.
         * The function accepts LONG_INTEGER_ARRAY ar as parameter.
         */

        public static long aVeryBigSum(List<long> ar)
            {
                long result = ar.Sum();
                return result;
            }

        /*
        * Complete the 'plusMinus' function below.
        *
        * The function accepts INTEGER_ARRAY arr as parameter.
        */

        public static void plusMinus(List<int> arr)
        {
            int postiveCounter = 0 , negativeCounter = 0, zeroCounter = 0;
            double positiveResult = 0.0, negativeResult = 0.0, zeroResults = 0.0;
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] > 0)
                {
                    postiveCounter++;
                }
                else if(arr[i] < 0){
                    negativeCounter++;

                }
                else
                {
                    zeroCounter++;
                }
            }
           
            positiveResult = ((double)postiveCounter / arr.Count);
            negativeResult = ((double)negativeCounter / arr.Count);
            zeroResults = ((double)zeroCounter / arr.Count);

            Console.WriteLine(positiveResult.ToString("N6"));
            Console.WriteLine(negativeResult.ToString("N6"));
            Console.WriteLine(zeroResults.ToString("N6"));
        }

        /*
        * Complete the 'staircase' function below.
        *
        * The function accepts INTEGER n as parameter.
        */

        public static void staircase(int n)
        {
            int spaces = n;
          

            for (int i = 1; i <= n; i++)
            {
                
                Console.WriteLine(new String(' ', n - i) + new String('#', i));


            }
        }


        /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

        public static void miniMaxSum(List<int> arr)
        {
            if (arr.Count == 5)
            {
                List<long> re= arr.Select(i => (long)i).ToList();
                re.Sort();
                long min = re.GetRange(0, 4).Sum();
                long max = re.GetRange(1, 4).Sum();
                Console.Write(min +" ");
                Console.WriteLine(max);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
        static void Main(string[] args)
        {
            /* this for compare triple fun
            List<int> a = new List<int>(){ 5, 10, 7 };
            List<int> b = new List<int>() { 3, 6, 10 };
            List<int> result = compareTriplets(a, b);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            */
            List<int> rowValue = new List<int>();
            List<List<int>> matrix = new();
            rowValue = new List<int>() { 11, 2, 4 } ;
            matrix.Add(rowValue);
            rowValue = new List<int>() { 4, 5, 6 };
            matrix.Add(rowValue);
            rowValue = new List<int>() { 10, 8, -12 };
            matrix.Add(rowValue);
            //  int result=diagonalDifference(matrix);
            //  Console.WriteLine(result);
            //  List<long> longSum = new List<long>() { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 };

            // long result = aVeryBigSum(longSum);
            // Console.WriteLine(result);
            // List<int> plus = new List<int>() {1,1,0,-1,-1 };
            //  plusMinus(plus);
            // staircase(6);
            List<int>Value = new List<int>() { 426980153, 354802167, 142980735, 968217435, 734892650 };
            miniMaxSum(Value);
        }
    }
}
