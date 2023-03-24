// using System;
// using System.Collections.Generic;

// // refer to the hanoi.js to understand it in js as well
// // hanoi class creation
// class Hanoi
// {
//     // declare the towers here as an array of lists of numbers
//     private static List<int>[] towers;

//     static void Main(string[] args)
//     {
//         // number of disks
//         // feel free to change it
//         int numDisks = 3;
//         // initialize the towers
//         towers = new List<int>[] {
//             new List<int>(numDisks),
//             new List<int>(0),
//             new List<int>(0),
//         };

//         // add the disks to the first tower
//         for (int i = numDisks; i >= 1; i--)
//         {
//             towers[0].Add(i);
//         }

//         // print the starting state
//         Console.WriteLine("Initial state:");
//         DisplayTowers();
//         // call the hanoi algorithm here
//         HanoiAlgorithm(numDisks, 0, 2, 1);
//     }

//     // hanoi recursion algorithm
//     // takes 4 params
//     // refer to hanoi.js file for the understanding of this
//     static void HanoiAlgorithm(int n, int source, int target, int auxiliary)
//     {
//         if (n > 0)
//         {
//             // solve for the n-1 disks
//             HanoiAlgorithm(n - 1, source, auxiliary, target);
//             // log the move to the console
//             PrintMove(n, source, target);
//             // move the disk
//             MoveDisk(source, target);
//             // display the asteriks on the console
//             DisplayTowers();

//             // solve for the remaining n-1 disks
//             HanoiAlgorithm(n - 1, auxiliary, target, source);
//         }
//     }


//     // this just prints out the move that we are making
//     static void PrintMove(int n, int source, int target)
//     {
//         Console.WriteLine($"Move disk {n} from {source} to {target}");
//     }


//     // function that moves the disk
//     static void MoveDisk(int source, int target)
//     {
//         int topDisk = towers[source][towers[source].Count - 1];
//         towers[source].RemoveAt(towers[source].Count - 1);
//         towers[target].Add(topDisk);
//     }


//     // displays the current state of the towers
//     static void DisplayTowers()
//     {
//         string output = CreateTowerOutput();
//         Console.WriteLine(output);
//     }


//     // this creates a string to represent the towers
//     static string CreateTowerOutput()
//     {
//         int maxHeight = GetMaxTowerHeight(towers);
//         string output = "";

//         // loop through the rows of the towers
//         for (int i = maxHeight - 1; i >= 0; i--)
//         {
//             output += CreateDiskRow(i);
//             output += "\n";
//         }

//         output += "A      B      C\n";
//         return output;
//     }


//     // get the height of the tallest tower
//     static int GetMaxTowerHeight(List<int>[] towers)
//     {
//         int maxHeight = 0;

//         for (int i = 0; i < towers.Length; i++)
//         {
//             int towerHeight = towers[i].Count;

//             // if the tower is taller than the previous tallest tower
//             // update the max height
//             if (towerHeight > maxHeight)
//             {
//                 maxHeight = towerHeight;
//             }
//         }

//         return maxHeight;
//     }


//     // this creates a string to represent a single row of the towers
//     static string CreateDiskRow(int rowNumber)
//     {
//         string row = "";

//         // loop through the tower
//         for (int towerIndex = 0; towerIndex < 3; towerIndex++)
//         {
//             if (rowNumber < towers[towerIndex].Count)
//             {
//                 int diskSize = towers[towerIndex][rowNumber];
//                 int padding = 3 - diskSize;
//                 int diskWidth = 2 * diskSize - 1;

//                 row += new string(' ', padding) + new string('*', diskWidth) + new string(' ', padding);
//             }

//             // otherwise just add spaces
//             else
//             {
//                 row += new string(' ', 5);
//             }

//             // adding a space between the towers for clarity
//             row += " ";
//         }

//         return row;
//     }
// }


