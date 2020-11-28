using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.Diagnostics;
namespace Sorting
{
    class HeapSort
    {
        Stopwatch sw = new Stopwatch();
        public void heapSort(List<int> scores)
        {
            sw.Start();
            sort(scores);
            sw.Stop();
            double time = sw.Elapsed.TotalMilliseconds / 1000;
            WriteLine("HeapSort");
            asymptoticNot();
            Description();
            Pseudocode();
            for (int i = 0; i <scores.Count; i++)
                Write(scores[i]+" ");
            WriteLine("\nRunTime: " + time + " seconds");
        }

        void sort(List<int> scores)
        {
            int index = scores.Count; //set an index that is the size of the array/list
            for (int i = index / 2 - 1; i >= 0; i--)//a loop that will set the size of the a value by half the array - 1.
                heap(scores, index, i); //passing array/list, with size of said array/list, and the newly set sized value.
            for (int i = index - 1; i > 0; i--)//a loop that will run down the entire length of the array/list and decrement until it hits 0 and the sorting finally finishes
            {//fisher yates shuffle begins, shuffling between the beginning element of the array/list and the top element of the list/array.
                var temp = scores[0];
                scores[0] = scores[i];
                scores[i] = temp;
                heap(scores, i, 0);//then heap sorting continues
            }
        }


        void heap(List<int> scores,int index, int i)
        {
            int biggest = i;//this is to create a new int that will be called the "biggest" element of the array/list until proven otherwise;
            int left = 2 * i + 1;//set the int called left that'll be compared to with the "biggest" element in the array.
            int right = 2 * i + 2;//set another that'll be compared to
            if (left < index && scores[left] > scores[biggest])//if statement that will check if the value of Left is less than the size of the array AND if it's element in the index it's placed within the array/list is bigger than the value of the "biggest" index in the array/list 
                biggest = left;//if all true, then the left value becomes the new biggest until proven otherwise
            if (right < index && scores[right] > scores[biggest])//if statement that will check if the value of Right is less than the size of the array AND if it's element in the index it's placed within the array/list is bigger than the value of the "biggest" index in the array/list 
                biggest = right;//if all true, then the right value becomes the new "biggest"
            if (biggest != i)// checks to see if the value of the biggest variable is not equal to the value of first "biggest" value.
            {//if true, then fisher yates shuffle begins, between the elements of scores[i] and scores[biggest]
                var temp = scores[i];
                scores[i] = scores[biggest];
                scores[biggest] = temp;
                heap(scores,index, biggest); //Then recursion occurs for heaping another segment of the array/list
            }
        }
        void Description()
        {
            WriteLine("Description: Heap Sort is a sorting algorithm that uses a binary tree like system that " +
                "divides the array/list into sorted and unsorted areas that happens to find the larger elements " +
                "much faster than most other sorting algorithms. It compares the top element and the bottom element " +
                "and swaps them usually making one of the larger elements thus it being sorted in place.\n");
        }

        void asymptoticNot()
        {
            WriteLine("Average case: O(n log n)");
        }

        void Pseudocode()
        {
            WriteLine("sort(DataType: scores)\n" +
                "//set size of the list//array into a new int\n" +
                "int index = scores.Count\n" +
                "for i = index/2 -1 to 0\n" +
                "//send the array/list, index, and the newly set i to the heap method\n" +
                "heap(score, index, i)\n" +
                "end i loop\n" +
                "for i = index-1 to 0\n" +
                "//then swap the 0 and ith element\n" +
                "swap score[0] and score[i]\n" +
                "//then pass it into the heap method with the array/list, i, and 0\n" +
                "heap(scores, i, 0)\n" +
                "end i loop\n" +
                "end sort\n" +
                "\n" +
                "heap(DataType: sort, data index, data i)\n" +
                "//set a new int to the size of i value\n" +
                "biggest = i\n" +
                "//then set a new int left to the value of i times 2 plus 1\n" +
                "left = i*2 + 1\n" +
                "//then set a new int right to the value of i times 2 plus 2\n" +
                "right = i*2 + 2\n" +
                "//if score's left index is greater than the score's biggest index\n" +
                "if score[left] > score[Index]\n" +
                "biggest =left\n" +
                "//if score's right index is greater than the score's biggest index\n" +
                "if score[right] > score[index]\n" +
                "biggest = right\n" +
                "//if value of biggest does not equal to value of i\n" +
                "if(biggest != i)\n" +
                "swap score[i] and score[biggest]\n" +
                "//continue to heap\n" +
                "heap(scores, index, biggest)\n" +
                "end heap");
        }
    }
}
