using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.Diagnostics;
namespace Sorting
{
    class BubbleSort
    {
        Stopwatch stopwatch = new Stopwatch();
        bool isSorted = false;
        double time;
        public void bubbleSort(List<int> scores)
        {
            stopwatch.Start();
            sort(scores);
            stopwatch.Stop();
            time= stopwatch.Elapsed.TotalMilliseconds/1000;
            WriteLine("BubbleSort");
            asymptoticNot();
            Description();
            Pseudocode();
            for (int i = 0; i <scores.Count; i++)
            {
                Write(scores[i] + " ");
            }
            WriteLine("\nRunTime: "+time+" seconds");
        }

        void sort(List<int> scores)
        {
            while (!isSorted) //this while loop will remain true as long as the list is not sorted.
            {
                isSorted = true; //In case the list is sorted, this will execute and break the loop.
                for (int i = 0; i < scores.Count - 1; i++) //For loop that will loop the length of the list minus. Minus one is added because the code will break if not done.
                {
                    if (scores[i] > scores[i + 1]) //Checks to see if the first name of the list is greater than the second name of the list.
                    {
                        var temp = scores[i]; //if yes, then the first name will be placed into a temporary variable.
                        scores[i] = scores[i + 1];//the second/next name will be placed into the first/previous name's spot on the list.
                        scores[i + 1] = temp;//the first/previous name occupies the next slot.

                        isSorted = false;//since this if statement executed, this list is not sorted.
                    }
                }
            }
        }

        void Description()
        {
            WriteLine("Description: Bubble Sort is a sorting algorithm that take the first element of the array/list and compares it to the next element.\n" +
                      "If the first element is greater than the next element, than the swap places using the fisher-yates shuffle. Then the code\n" +
                      "will proceed to do this with every element in the array/list.\n");
        }

        void asymptoticNot()
        {
            WriteLine("Best & Worst Case: O(n^2)");
        }

        void Pseudocode()
        {
            WriteLine("sort(DataType: scores)\n" +
                "//set bool to true to keep sorting until finished\n" +
                "while(isSorted)\n" +
                "//In case there is nothing more to swap with\n" +
                "isSorted = true\n" +
                "//Loop the array/list to find items not sorted\n" +
                "for i = 0 to length of array/list -1\n" +
                "//check if the first/current element is greater than the next element\n" +
                "if(scores[i] > score[i+1] then\n" +
                "//if yes, use fisher yates shuffle\n" +
                "var temp = score[i]\n" +
                "score[i] = score[i+1]\n" +
                "score[i+1] = temp\n" +
                "//Since array was not sorted\n" +
                "isSorted =false\n" +
                "close if\n" +
                "increment i\n" +
                "end While\n" +
                "end Sort\n");
        }
    }
}
