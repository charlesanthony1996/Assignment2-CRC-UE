using System;
using System.Collections.Generic;
// public interface or the contract for the class is instantiated here 
// it take in the unordered array as a parameter
public interface ISorter<T>
{
    void Sort(T[] array);
}

// bubblesort class is implemented here using the contract which is the ISorter interface
public class BubbleSort<T> :ISorter<T> where T: IComparable<T>
{
    // sort method takes an array of type T and sorts it using the bubble sort algorithm
    public void Sort(T[] array)
    {
        
        int n = array.Length;
        // outer loop goes through every element of the array
        for(int i = 0; i < n - 1; i++) {
            // inner loop goes through the unsorted part of the array
            for(int j = 0; j < n -i- 1; j++) {
                // adjacency with the next element thats always infront of this one
                // remove inner loop and see the outcome to see the change
                if(array[j].CompareTo(array[j+ 1]) > 0)
                {
                    // swapping takes place only if the elements are not in order here
                    T temp = array[j];
                    array[j] = array[j+ 1];
                    array[j+ 1] = temp;
                }
            }
        }
    }
}

// end of bubblesort class

// mergesort class begins

public static class MergeSort
{
    public static void Sort<T>(List <T> list) where T: IComparable<T>
    {
        // if the list is null or has 1 element, its already sorted
        if(list == null || list.Count <= 1)
        {
            return;
        }

        // divide the list into two halves

        int mid = list.Count / 2;
        List<T> left = new List<T>();
        List<T> right = new List<T>();

        // copy the first half of elements to the left part of the list

        for(int i = 0; i< mid; i++)
        {
            left.Add(list[i]);
        }

        // copy the second half of elements to the right part of the list

        for(int i = mid; i < list.Count; i++)
        {
            right.Add(list[i]);
        }

        // revursively sort left and right lists

        Sort(left);
        Sort(right);

        // merge the sorted left and right lists
        Merge(list, left, right);
    }


    private static void Merge<T>(List<T> list, List<T> left, List<T> right) where T: IComparable <T>
    {
        // inits to the variables for indexing
        int leftIndex = 0;
        int rightIndex = 0;
        int arrayIndex = 0;


        while(leftIndex < left.Count && rightIndex < right.Count)
        {

            // compare elements from the left and right lists , and add the smaller one to the left of the list first
            // refer to the viz on this link -> https://www.youtube.com/watch?v=4VqmGXwpLqc

            if(left[leftIndex].CompareTo(right[rightIndex]) <= 0)
            {
                list[arrayIndex] = left[leftIndex];
                leftIndex++;

            }
            else
            {
                list[arrayIndex] = right[rightIndex];
                rightIndex++;
            }

            arrayIndex++;

        }

        // add the remaining elements from the left list

        while(leftIndex < left.Count)
        {
            list[arrayIndex] = left[leftIndex];
            leftIndex++;
            arrayIndex++;

        }

        // add the remaining elements from the right list
        // that were not added to the left one

        while(rightIndex < right.Count)
        {
            list[arrayIndex] = right[rightIndex];
            rightIndex++;
            arrayIndex++;
        }

    }
    
}

public class Program
{
    public static void Main(string[] args)
    {
        // Check if there is at least 1 argument and decide the sorting algorithm to use
        // command to run -> dotnet build && dotnet run merge
        if (args.Length > 0 && args[0].ToLower() == "merge")
        {
            // Create the list with unsorted numbers
            List<int> list = new List<int> {1, 6, 2, 4, 8, 5};

            // Sort the list using mergsort
            MergeSort.Sort(list);

            // Print the sorted list to the console
            Console.Write("Sorted list (MergeSort): ");
            foreach (int num in list)
            {
                Console.Write(num + " ");
            }
        }
        else
        // runs by default
        // cmd -> dotnet build && dotnet run
        {
            // Create an array with unsorted numbers
            int[] numbers = {1, 3, 2, 4};

            // Instantiate a BubbleSort object
            ISorter<int> sorter = new BubbleSort<int>();

            // Sort the array using the BubbleSort object
            sorter.Sort(numbers);

            // Print the sorted numbers onto the console
            Console.Write("Sorted numbers (BubbleSort): ");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
        }
    }
}
