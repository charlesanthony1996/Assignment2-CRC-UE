// using System;
// using System.Collections.Generic;


// class Hanoi
// {
//     // initializing a array of lists to represent the towers here
//     // double brackets
//     private static List<int>[] towers;

//     static void Main(string[] args)
//     {
//         // xchange the number of disks as you like it,
//         // set to three here
//         int numDisks = 3;

//         // first list contains all the disks
//         // initilalizing the other two here
//         towers = new List<int>[] {
//             new List<int>(numDisks),
//             new List<int>(0),
//             new List<int>(0),
//         };

//         // adsd the disks to the first tower here
//         for (int i = numDisks; i >= 1; i--)
//         {
//             towers[0].Add(i);
//         }
        
//         // logging the state
//         Console.WriteLine("Initial state:");
//         // calling the display towers here
//         DisplayTowers();
        
//         // starting the iterative solution
//         IterativeHanoi(numDisks);
//     }

    
//     static void IterativeHanoi(int n)
//     {
//         // calculagte the nuymber of required moves
//         // needed help here
//         int numMoves = (int)Math.Pow(2, n) - 1;

//         // declaring the source, target and auxiliary here
//         int source, target, auxiliary;

//         // if n is even, set the pegs/rods in order
//         if (n % 2 == 0)
//         {
//             source = 0;
//             target = 1;
//             auxiliary = 2;
//         }
//         // pegs -> rods used alternatively
//         // if n is odd, set it in a different order
//         else
//         {
//             source = 0;
//             target = 2;
//             auxiliary = 1;
//         }

//         // looping through all the possible moves
//         for (int move = 1; move <= numMoves; move++)
//         {

//             int from = -1, to = -1;

//             // this determines the move based on current iteration
//             switch (move % 3)
//             {
//                 case 1:
//                     from = source;
//                     to = target;
//                     break;

//                 case 2:
//                     from = source;
//                     to = auxiliary;
//                     break;

//                 case 0:
//                     from = auxiliary;
//                     to = target;
//                     break;
//             }

//             // if the move is possible, do it and log it into the console
//             if (CanMove(from, to))
//             {
//                 MoveDisk(from, to);
//                 PrintMove(from, to);
//                 DisplayTowers();
//             }

//             // if its not possible , swapping takes place here and do it
//             else
//             {
//                 MoveDisk(to, from);
//                 PrintMove(to, from);
//                 DisplayTowers();
//             }
//         }
//     }

//     // function that checks legality
//     static bool CanMove(int from, int to)
//     {
//         if (towers[from].Count == 0)
//         {
//             return false;
//         }
//         if (towers[to].Count == 0 || towers[from][towers[from].Count - 1] < towers[to][towers[to].Count - 1])
//         {
//             return true;
//         }
//         return false;
//     }

//     // loggin the swap into the console
//     static void PrintMove(int from, int to)
//     {
//         Console.WriteLine($"Move disk from {from} to {to}");
//     }

//     // same function from the recursive solution
//     static void MoveDisk(int source, int target)
//     {
//         int topDisk = towers[source][towers[source].Count - 1];
//         towers[source].RemoveAt(towers[source].Count - 1);
//         towers[target].Add(topDisk);
//     }

//     // moving the disk from one peg/rod to the other
//     // same as in the recursive solution
//     // nothing has changed here
//     static void DisplayTowers()
//     {
//         string output = CreateTowerOutput();
//         Console.WriteLine(output);
//     }

//     // twoer creation function
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

//         // columns at the bottom
//         output += "A      B      C\n";
//         return output;
//     }


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

//             // adding a space between the towers for clarity/ clearness
//             row += " ";
//         }

//         return row;
//     }
// }
