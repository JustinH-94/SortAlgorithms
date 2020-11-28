using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.Diagnostics;
namespace Sorting
{
    class QuickSort
    {
        Stopwatch sw = new Stopwatch();
        public void quickSort(List<int> scores)
        {
            sw.Start();
            int low = 0;//To set the lowest element in the array/list
            int high = scores.Count - 1;//To set the highest element in the array/list. minus 1 because the low was set to 0.
            Sort(scores,low, high);//pass array/list, low, and high to the sort method where quick sort begins
            sw.Stop();
            double time = sw.Elapsed.TotalMilliseconds / 1000;
            WriteLine("QuickSort");
            asymptoticNot();
            Description();
            Pseudocode();
            Display(scores);
            WriteLine("\nRunTime: " + time + " seconds");
        }

        void Description()
        {
            WriteLine("Description: Quick Sort is a sorting algorithm that is like a divide and conquer strategy. The algoritm " +
                "divides the array/list into segments and sorts each segment, and on to the next segment. It sets an index " +
                "that acts as a pivot that divides the array/list. It will then recurisvely call itself on the subdivided sections until " +
                "that section is sorted.\n");
        }

        void asymptoticNot()
        {
            WriteLine("Average Case: O(n long n)\n" +
                "Worst Case: O(n^2)\n");
        }

        void Pseudocode()
        {
            WriteLine("sort(DataType: scores)\n" +
                "// set a new int to 0 and another int to length of array/list -1\n" +
                "low = 0;\n" +
                "high = scores.count-1\n" +
                "//check if low is actually less than high\n" +
                "if low < high\n" +
                "//set an int, whose value is the return value of the method parition which passes the array/list ,low, and high\n" +
                "pi = partition(Scores, low, high)\n" +
                "//recursion with the newly found low and hi\n" +
                "sort(scores, low, pi-1)\n" +
                "sort(scores, pi+1, high)\n" +
                "end if\n" +
                "end sort\n" +
                "\n" +
                "partition(datatype scores, data low, data high)\n" +
                "//set an int to the value of the last element of the array/list\n" +
                "pivot = scores[high]\n" +
                "//set an int to the value of low -1\n" +
                "i = low-1\n" +
                "for j = low to high\n" +
                "if scores[j] is less than pivot\n" +
                "increment i if true\n" +
                "swap scores[i] and scores[j]\n" +
                "end if\n" +
                "increment j\n" +
                "end j loop\n" +
                "swap scores[high] and scores[i+1]\n" +
                "return i+1\n" +
                "end partition\n");
        }

        void Sort(List<int> scores,int low, int high)
        {
            if( low < high)//this is to make sure low value is actually less than high value
            {
                int pi = Partition(scores,low, high);//pi is set to be the middle point and separates the array/list into segments

                Sort(scores,low, pi-1);//recursion where the process repeats with a different high value (it now being pi-1)
                Sort(scores,pi + 1, high);//recursion where the process repeats with a different low value (it not being pi+1)
            }
        }

        int Partition(List<int> scores,int low, int high)
        {
            int pivot = scores[high]; //setting pivot to be the element of last element of the list/array (at least to the segment)
            int i = low - 1; //setting the value of i to low -1.

            for (int j = low; j < high; j++)//this for loop that increments till j hits the value of high
            {
                if (scores[j] < pivot)//checks to see if the value of scores[j] is less than the pivot
                {
                    i++;

                    var temp = scores[i];//fisher yates shuffle the scores[i] and scores[j]
                    scores[i] = scores[j];
                    scores[j] = temp;
                }
            }

            var temp2 = scores[i + 1];//fisher yates shuffle the scores[i+1] and scores[high]
            scores[i + 1] = scores[high];
            scores[high] = temp2;
            return i + 1;//return the the pivot
        }

        void Display(List<int> scores)
        {
            for(int i =0; i < scores.Count; i++)
            {
                Write(scores[i]+ " ");
            }
        }
    }
}
