using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.Diagnostics;
namespace Sorting
{
    class MergeSort
    {
        Stopwatch sw = new Stopwatch();
        public void mergeSort(List<int> scores)
        {
            sw.Start();
            int low = 0; //create a int value to be 0
            int high = scores.Count - 1;//create a int value to be size of list -1
            Sort(scores, low, high);//pass list, low, and high
            sw.Stop();
            double time = sw.Elapsed.TotalMilliseconds / 1000;
            WriteLine("Merge Sort");
            asymptoticNot();
            Description();
            Pseudocode();
            Display(scores);
            WriteLine("\nRunTime: " + time + " seconds");
        }
        void Description()
        {
            WriteLine("Description: Merge Sort is a sorting algorithm that splits the array/list into two different arrays. " +
                "Then sort those arrays, to finally compare each element from both arrays and place them back into the original" +
                "array. \n");
        }

        void asymptoticNot()
        {
            WriteLine("Average & Worst Case: O(n log n)\n");
        }

        void Pseudocode()
        {
            WriteLine("sort(DataType: scores)\n" +
                "set int to be 0 and another int to be size of array -1 \n" +
                "if (left is less than right)\n" +
                "set middle = (high + low) /2\n" +
                "recusion with middle being the max\n" +
                "recursion with middle +1 being the min\n" +
                "pass array, left, middle, right to method merge()\n" +
                "\n" +
                "merge(data list scores, data l, data m, data r)\n" +
                "node1 equals to m - 1 + 1\n" +
                "node2 equals to r - m\n" +
                "//create variable i and j\n" +
                "i,j\n" +
                "//create new arrays that are the size of node1 and another size node2\n" +
                "[]Left size of node1\n" +
                "[]Right size of node2\n" +
                "for i = 0 to node1\n" +
                "//make array left to array scores with l + r as its index\n" +
                "Left[i]=scores[l+i]\n" +
                "incremenet i\n" +
                "end i loop\n" +
                "//set i and j to 0\n" +
                "//set a new int to l\n" +
                "while i is less than node1 and j is less than node2\n" +
                "if left[i] less than or equal to right[j]\n" +
                "//if yes, set scores[k] to equal to Left[i]\n" +
                "increment i\n" +
                "end if, begin else\n" +
                "//makes scores[k] equal to Right[j]\n" +
                "increment j\n" +
                "end if\n" +
                "increment k\n" +
                "end while\n" +
                "while i less than node1\n" +
                "//set scores[k] equal to Left[i]\n" +
                "//increment i and k\n" +
                "end while\n" +
                "while j less than node2\n" +
                "//set scores[k] equal to Right[j]\n" +
                "increment k and j\n" +
                "end while\n" +
                "end merge()\n");
        }

        void Sort(List<int> scores, int left, int right)
        {
            if(left < right)//check to see if left is less than right
            {   //if true, then declare variable middle to be the mean of the values of left and right
                int middle = (left + right) / 2;
                Sort(scores, left, middle);//recursion, pass the array, left, and middle to Sort
                Sort(scores, middle + 1, right);//recursion, pass the array, right, and right to Sort

                merge(scores, left, middle, right);//pass scores, left, middle, right to be sorted
            }
        }

        void merge(List<int> scores, int l, int m, int r)
        {
            int node1 = m - l + 1;//declare variables node1 and node2 to be the size of the left side, and right side respectively
            int node2 = r - m;
            int i, j;//declare i and j to be used as indexes throughout the rest of the method
            int[] Left = new int[node1];//create two new arrays called left and right that are set to size of node1 and node2
            int[] Right = new int[node2];

            //fill in both arrays with different sections of the original array. array left being set to the left side of the original array, and the array right being set to the right side of the original array plus the middle
            for (i = 0; i < node1; i++)
                Left[i] = scores[l + i];
            for (j = 0; j < node2; j++)
                Right[j] = scores[m + 1 + j];
            i = 0;
            j = 0;

            int k = l;
            //While loop that runs as long as i and j are less than nodes 1 and 2. This loop will compare Left and Right arrays and if value of one is lower than the other then the lower one gets re-added back into the original array
            while( i < node1 && j < node2)
            {
                if(Left[i] <= Right[j])
                {
                    scores[k] = Left[i];
                    i++;
                }
                else
                {
                    scores[k] = Right[j];
                    j++;
                }
                k++;
            }

            //while loops is similar to the while loop above but copies the remains elements back into the original array
            while(i< node1)
            {
                scores[k] = Left[i];
                i++;
                k++;
            }
            while (j < node2)
            {
                scores[k] = Right[j];
                j++;
                k++;
            }
        }

        void Display(List<int> scores)
        {
            for (int i = 0; i < scores.Count; i++)
                Write(scores[i]+" ");
        }
    }
}
