function hanoi(n, source, target, auxiliary) {
    // this is the base case when there are no more disks to move, stop the recursion
    if (n > 0) {

      // move the n-1 smaller disks from the source peg to the auxiliary peg or rod
      // using the target peg as temporary storage
      hanoi(n - 1, source, auxiliary, target);
  
      // print the move for the current disk (the largest one) from the source peg to the target peg
      printMove(n, source, target);
  
      // move the current disk (the largest one) from the source peg to the target peg
      moveDisk(source, target);
  
      // display the current state of the towers
      displayTowers();
  
      // move the n-1 smaller disks from the auxiliary peg to the target peg,
      // using the source peg as temporary storage
      hanoi(n - 1, auxiliary, target, source);
    }
  }
  
  
  function printMove(n, source, target) {
    // function that logs it into the console
    console.log(`Move disk ${n} from ${source} to ${target}`);
  }

  
  function moveDisk(source, target) {
    // remove the top disk from the source tower
    const topDisk = towers[source].pop();
  
    // add the top disk to the target tower
    towers[target].push(topDisk);
  }
  
  
  function displayTowers() {
    // create the ascii art of the current state of the towers
    const output = createTowerOutput();
  
    // Print the ascii art representation to the console
    console.log(output);
  }
  
  
  function createTowerOutput() {
    // get the maximum height of the towers
    const maxHeight = getMaxTowerHeight(towers);
  
    // initialize an empty string for the output
    let output = "";
  
    // iterate through the rows of the towers from top to bottom
    for (let i = maxHeight - 1; i >= 0; i--) {
      // create an ascii art row for the current row number and append it to the output
      output += createDiskRow(i);
  
      // add a newline character to separate rows
      output += "\n";
    }
  
    // add labels (A, B, C) for the pegs at the bottom of the output
    output += "A      B      C\n";
  
    // return the final ASCII art representation of the towers
    return output;
  }
  

  function getMaxTowerHeight(towers) {
    // initialize a variable to store the maximum height
    let maxHeight = 0;
  
    // iterate through each tower
    for (let i = 0; i < towers.length; i++) {
      // get the height of the current tower
      const towerHeight = towers[i].length;
  
      // if the current tower's height is greater than the maxHeight, update maxHeight
      if (towerHeight > maxHeight) {
        maxHeight = towerHeight;
      }
    }
  
    // return the highest tower height after completing the loop
    return maxHeight;
  }
  
  
  
  function createDiskRow(rowNumber) {
    let row = "";
  
    // iterate through each tower
    for (let towerIndex = 0; towerIndex < 3; towerIndex++) {
      // check if there is a disk at the current row of the tower
      const diskSize = towers[towerIndex][rowNumber];
  
      if (diskSize !== undefined) {
        // calculate the number of spaces before and after the asterisks (padding)
        const padding = 3 - diskSize;
  
        // calculate the number of asterisks needed to represent the disk (diskWidth)
        const diskWidth = 2 * diskSize - 1;
  
        // add padding spaces, disk asterisks, and padding spaces to the row string
        row += " ".repeat(padding) + "*".repeat(diskWidth) + " ".repeat(padding);
      } else {
        // if there's no disk at the current row, add 5 spaces to represent an empty space
        row += " ".repeat(5);
      }
  
      // add a space between towers
      row += " ";
    }
  
    // return the ASCII art row for the current row number
    return row;
  }
  
  
const numDisks = 3;
const towers = [[], [], []];
  
for (let i = numDisks; i > 0; i--) {
  towers[0].push(i);
}
  
console.log("Initial state:");
displayTowers();
hanoi(numDisks, 0, 2, 1);