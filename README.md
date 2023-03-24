## Charles Anthony - cc211002

## TL;DR

> Command to run bubblesort -> `dotnet build && dotnet run` \
> Command to run mergesort -> `dotnet build && dotnet run merge`\
> Command to solve the tower of hanoi -> `csc hanoi.cs && mono hanoi.exe`

# 

## About the project

### Built with dotnet this time.Although mono could be used to run the two programs seperately as well.
### 1.BubbleSort.cs
### 2.MergeSort.cs

### Main commands to run -> dotnet build && dotnet run or dotnet build && dotnet run merge

### Get started

> Prerequisites\
1.install homebrew via 
                /bin/bash -c "$(curl -fsSL https://raw.githubusercontent.com/Homebrew/install/HEAD/install.sh)"\ \
                2.brew install mono


> Installation -> using mcs is also possible. csc is what i used (regarding the compiler) 

> This is only if you have mono or feel the need to run the files seperately

> Command to run bubblesort -> csc bubblesort.cs && mono bubblesort.exe

> Command to run mergesort -> csc mergesort.cs && mono mergesort.exe

### Usage

### 1. Bubble sort algorithm using generics and interfaces 

* Program.cs -> command to run -> dotnet build && dotnet run

* how to run the individual program -> csc bubblesort.cs && mono bubblesort.exe

 - dotnet is used to run the program
 
* Adjusting the program -> You have to change the array that needs to be sorted after the method to get it sorted for a different array of elements

* How the program works is mentioned in the comments of of the program itself.

*There is a main.js file that breaks everything down to understand bubblesort and mergesort as well



### 2. Merge sort algorithm using generics and interfaces

* Program.cs -> command to run -> dotnet build && dotnet run merge

* How to run the individual program -> csc mergesort.cs && mono mergesort.exe

 - dotnet is used to run the program. but the mergesort.cs can be run individually as well

* Adjusting the program -> You have to change the array that needs to be sorted after the method to get it sorted for a different array of elements


### 3. Tower of hanoi problem

* hanoi.js -> please refer to this file to understand the basic principles of recursion. where multiple examples explain and get you to understand the hanoi problem much more effectively. (Only if you need to)
explained at a more modular level with inline commenting

* hanoi.cs -> Was not able to use dotnet for this and mono or any other preferred compiler should be used to run this program.

* The ascii art comprises of asteriks and shows the disk or rod at each stage.



### Roadmap
### 1.Tasks to do for both

- [x] Basic implementation with comments

- [x] Markdown completion

- [ ] Time it function for each run

- [x] Implementation in other languages eg:- python, c and c++, js

- [ ] ascii art viz time delay added (For more clear viewing)

### 2. Table for execution times


| File  | Language | Time (seconds) |
| ------------- |            |       |
| program.cs      | c sharp     |       |   
| bubblesort.cs  | c sharp     |       |
| mergesort.cs | c sharp      |       |
|bubblesort.c | c |             |
|bubblesort.cpp | cpp |         |
| bubblesort.js| javascript|    |


### Contributing

* For the time being I am the sole contributor

### License

* mit

### Contact

Email -> cc211002@fhstp.ac.at \
Github -> https://github.com/charlesanthony1996 (project will be available there soon)

### Acknowledgements

Professor Hsiang-Yun Wu for her lectures and guidance