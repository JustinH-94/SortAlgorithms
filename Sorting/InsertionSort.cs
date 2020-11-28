using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.Diagnostics;
namespace Sorting
{
    class InsertionSort
    {
        Stopwatch sw = new Stopwatch();
        double time;
        public void insertionSort(List<int> scores)
        {
            sw.Start();
            Sort(scores);
            sw.Stop();
            time = sw.Elapsed.TotalMilliseconds / 1000;
            WriteLine("InsertionSort");
            asymptoticNot();
            Description();
            Pseudocode();
            for (int i = 0; i < scores.Count; i++)
            {
                Write(scores[i]+" ");
            }
            WriteLine("\nRunTime: " + time + " seconds");
        }

        void Sort(List<int> scores)
        {
            for (int i = 0; i < scores.Count - 1; i++) //Loop that runs the length of the list
            {
                for (int j = i + 1; j > 0; j--) //Second loop that runs with j being the same as i and as long as it's greater than 0. Then decrements
                {
                    if (scores[j] < scores[j - 1]) //checks to see if the length of the item in the list is than the previous item
                    {
                        var temp = scores[j - 1]; //if yes, sort begins with the previous item being stored into a temp variable.
                        scores[j - 1] = scores[j];//the smaller valued item is then placed into the spot below it
                        scores[j] = temp;//then the previous item gets stored
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
        void Description()
        {
            WriteLine("Description: Insertion Sort is a sorting algorithm that uses fisher-yates shuffle that uses two loop structures. One that is the size of" +
                " the array/list-1 and increments while the other is set to the size of the increment of the first loop + 1 and decrements. The second array checks if the next " +
                "element in the array/list is less than the element of the first array. If so, then they swap places. The second array will decement until it hits 0. Stops, " +
                "then move first loop will increment and go back to sorting on the second loop. This happens until the first loop reaches the array/list size -1.\n");
        }

        void asymptoticNot()
        {
            WriteLine("Best: O(n)\n" +
                "Worst Case: O(n^2)\n");
        }

        void Pseudocode()
        {
            WriteLine("sort(DataType: scores)\n" +
                "for i to length of scores -1 \n" +
                "for j=i+1 to 0\n" +
                "if scores[j] < scores[j-1]\n" +
                "swap scores[j] and scores[j-1]\n" +
                "if not then break\n" +
                "decrement j\n" +
                "increment i\n" +
                "end sort");
        }
    }
}
