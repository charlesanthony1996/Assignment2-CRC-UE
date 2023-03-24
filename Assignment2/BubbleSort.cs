// using System;
// using System.Collections.Generic;

// // public interface or the contract for the class is instantiated here 
// // it take in the unordered array as a parameter
// public interface ISorter<T>
// {
//     void Sort(T[] array);
// }

// // bubblesort class is implemented here using the contract which is the ISorter interface
// public class BubbleSort<T> :ISorter<T> where T: IComparable<T>
// {
//     // sort method takes an array of type T and sorts it using the bubble sort algorithm
//     public void Sort(T[] array)
//     {
        
//         int n = array.Length;
//         // outer loop goes through every element of the array
//         for(int i = 0; i < n - 1; i++) {
//             // inner loop goes through the unsorted part of the array
//             for(int j = 0; j < n -i- 1; j++) {
//                 // adjacency with the next element thats always infront of this one
//                 // remove inner loop and see the outcome to see the change
//                 if(array[j].CompareTo(array[j+ 1]) > 0)
//                 {
//                     // swapping takes place only if the elements are not in order here
//                     T temp = array[j];
//                     array[j] = array[j+ 1];
//                     array[j+ 1] = temp;
//                 }
//             }
//         }
//     }
// }

// public class Program
// {
//     public static void Main(string[] args)
//     {
//         // where the array of unordered numbers goes
//         int[] numbers = {1, 3, 2, 4};

//         // instantiate a bubble sort object here
//         ISorter<int> sorter = new BubbleSort<int>();

//         // sorting process is done here
//         sorter.Sort(numbers);

//         // print the sorted numbers onto the console
//         Console.Write("Sorted numbers: ");
//         // printing it out in the same line
//         foreach(int num in numbers)
//         {
//             Console.Write(num + " " );
//         }

//     }
// }
