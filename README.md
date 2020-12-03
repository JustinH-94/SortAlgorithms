# SortAlgorithms
The Repo shows an example of my demonstration of my knowledge of sorting Algoirthms: Insertion, Quick Sort, Merge Sort, Heap Sort, Bubble Sort, and Selection Sort.
The code takes data from a file, converts into int, and stores into a int list where the list then goes to different class labeled by each of the sorting algorithms.
Each algorithm gets timed with how fast they get the sorting done. So all in all it's a test to see which is better when sorting a data filled with scores.

## Bubble Sort
Bubble Sort has been the slowest algorithm to complete sorting. I took a while loop that doesn't end until the bool isSorted is false. And have isSorted set to be true
in case the array is sorted.
```C#
while(!isSorted)
{
  isSorted = true;
}
```
Within that loop, ran another loop that ends when the increment reachs the max count of the list, scores.
```C#
for (int i = 0; i < scores.Count - 1; i++)
{

}
```
From there, an if statement that checks to see if the current element in the list is greater than the next element of the list. If so, they swap places. Followed by 
setting isSorted to false, since the array isn't sorted.
```C#
if (scores[i] > scores[i + 1])
{
var temp = scores[i];
scores[i] = scores[i + 1];
scores[i + 1] = temp;
isSorted =false;
}
```

## Insertion Sort
Insertion sort has been the fastest algorithm in sorting the data provided. I used a double for loop, the first being standard increment to the size of the array.
While the second loop is set to the size of the first loop's increment + 1. then decrement to 0.
```C#
for(int i = 0; i < scores.Count; i++)
{
    for(int j = i + 1; j > 0; j--)
    {
    }
}
```
Within those double for loops, there is an if statement that checks if the current j index of the array is lower than the element below it. If true, then they
both swap places.
```C#
if (scores[j] > scores[j - 1])
{
var temp = scores[j];
scores[j] = scores[j - 1];
scores[j - 1] = temp;
}
```

## Selection Sort
For the selection sort, I also had another double for loop. The first loop is a standard increment while the second loop is also a standard except it's increment
is one value higher. In between the loops is int variable that is declared to be equal to increment i of the first loop.
```C#
for(int i = 0; i < scores.Count; i++)
{
    int minIndex = i;
    for(int j = i + 1; j < scores.Count; j++)
    {
    }
}
```
Within those double for loops is an if statement that sees if the element in jth index of the array is less than the minIndex of the array. If so, then j is
set equal to minIndex.
```C#
minIndex = j;
```
Outside of the second for loop is the swap between the minIndex of the array with the element of the i'th in the array.
```C#
var temp = scores[i];
scores[i] = scores[minIndex];
scores[minIndex] = temp;
```

