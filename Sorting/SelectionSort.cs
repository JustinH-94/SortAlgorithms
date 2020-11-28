using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.Diagnostics;
namespace Sorting
{
    class SelectionSort
    {
        Stopwatch sw = new Stopwatch();
        public void selectionSort(List<int> scores)
        {
            sw.Start();
            Sort(scores);
            sw.Stop();
            double time = sw.Elapsed.TotalMilliseconds / 1000;
            WriteLine("SelectionSort");
            asymptoticNot();
            Description();
            Pseudocode();
            for (int i =0; i < scores.Count; i++)
            {
                Write(scores[i] + " ");
            }
            WriteLine("\nRunTime: " + time + " seconds");
        }

        void Sort(List<int> scores)
        {
            for (int i = 0; i < scores.Count - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < scores.Count; j++)
                {
                    if (scores[j] < scores[minIndex])
                    {
                        minIndex = j;
                    }
                }
                var temp = scores[i];
                scores[i] = scores[minIndex];
                scores[minIndex] = temp;
            }
        }
        void Description()
        {
            WriteLine("Description: Selection Sort is a sorting algorithm that uses two loop structures. The first loop spans the length of the array/list -1, while " +
                "the second loop spans the length of array/list but having its increment(j) being the increment(i) of the first loop + 1. The second runs an if statement that " +
                "checks to see if there is an element that is less than the minimum index (in case i of the first loop). If so, then j takes place being the minimum index until " +
                "the loop finds another value lower than the minimum index. Once it checks the array/list, the minimum index will swap places with the i in the array/list. The " +
                "the first loop increments and the process continues.\n");
        }

        void asymptoticNot()
        {
            WriteLine("Average & Worst Case: O(n^2)\n");
        }

        void Pseudocode()
        {
            WriteLine("sort(DataType: scores)\n" +
                "for i = 0 to length of array/list -1\n" +
                "//set an in to i, this will be the minimum index\n" +
                "minIndex = i\n" +
                "for j = i+1 to length of array/list\n" +
                "//check to see if any element in j array/list is less than the minimum index\n" +
                "if scores[j] < scores[minIndex]\n" +
                "//if so, then store j into minimum index\n" +
                "minimum index = j\n" +
                "end if\n" +
                "end j loop\n" +
                "//with fisher yates swap minimum index and i in the array/list\n" +
                "swap( score[i] and score[minIndex]\n" +
                "end i loop\n" +
                "end sort");
        }
    }
}
