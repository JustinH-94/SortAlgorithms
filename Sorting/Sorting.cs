using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.IO;
namespace Sorting
{
    class Sorting
    {
        BubbleSort bubble = new BubbleSort();
        InsertionSort insert = new InsertionSort();
        SelectionSort select = new SelectionSort();
        HeapSort heap = new HeapSort();
        QuickSort quick = new QuickSort();
        MergeSort merge = new MergeSort();
        List<int> scores = new List<int>();
        string[] tempList;
        public Sorting()
        {
            LoadScores();
            bubble.bubbleSort(scores);
            Continue();
            insert.insertionSort(scores);
            Continue();
            select.selectionSort(scores);
            Continue();
            heap.heapSort(scores);
            Continue();
            quick.quickSort(scores);
            Continue();
            merge.mergeSort(scores);
            Continue();
            Summary();
            ReadKey(true);
        }

        void Continue()
        {
            WriteLine("Press Any Key to Continue...");
            ReadKey(true);
            Clear();
        }

        void LoadScores()
        {
            tempList = File.ReadAllLines("scores.txt");
            for(int i = 0; i <tempList.Length; i++)
                scores.Add(Convert.ToInt32(tempList[i]));
        }

        void Summary()
        {
            WriteLine("When comparing all algorithms with how fast they sort the data. It can be seen that Insertion Sort is faster than the any of the other,\n" +
                "while Bubble Sort is the slowest. The sorting algorithms Heap, Quick, and Merge generally have the same speed, which is surprising when there\n" +
                "is so much more coding going into them. With that being said, these codes are being done in milliseconds, which may make a difference when " +
                "data gets bigger.");
        }
    }
}
