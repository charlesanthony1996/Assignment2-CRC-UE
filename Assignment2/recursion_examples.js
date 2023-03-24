// understanding basic recursion

function factorial(n) {
    if(n === 0){
        return 1;
    }
    else {
        return n * factorial(n - 1)
    }
}


// console.log(factorial(5))
// 5 * 4 * 3 * 2 * 1 = 120


// fibonacci example

function fibonacci(n) {
    if(n == 0) {
        return 0
    }
    else if(n === 1) {
        return 1
    }
    else {
        // its addition here, where as its multiplication in factorials!. the main diff!
        return fibonacci(n -1) + fibonacci(n - 2)
    }
}


// at latest index = 1 ,1 2, 3, 5, 8, 13, 21, 34, 55
// console.log(fibonacci(10))


// since the tower of hanoi problem usually takes in 4 arguments we will try to understand something that takes in 2 or 3

// the gcd problem -> to find the greatest common denominator


function gcd(a, b) {
    if(b === 0) {
        return a
    } else {
        // the result of 1% b keeps dividing with b
        // this is recursive process until b is zero and cannot go on further!
        return gcd(b, a % b)
    }
}


// console.log(gcd(5, 3))


// now lets come up with something that takes 3 parameters for the recursive function!
// string combinations example

function stringCombinations(str, length, result = "") {
    if(result.length === length) {
        console.log(result)
        return
    }

    for(let i = 0; i< str.length; i++) {
        // recursive action takes place here!
        // takes in the string, its length, and updated result
        stringCombinations(str, length, result + str[i])
    }
}

// stringCombinations("charles", 6)


function towerofhanoi(n, src, dest, aux) {
    // src -> source rod
    // dest -> destination rod
    // aux -> temp state rod or the inbetween rod
    // n -> number of disks

    // check whether there is only one disk
    if( n === 1) {
        // then just send the disk in the source to the destination
        console.log(`${"*".repeat(n)} ${src} goes to -> ${dest}`)
        return;
    }
    
    // dest rod is a temporary holder
    towerofhanoi(n - 1, src, aux, dest)

    // pathway is cleared.. move the largest disk from the source to the destination
    console.log(`${"*".repeat(n)} ${src} -> ${dest}`)

    // temp rod is sent to the dest rod , while the source rod is a temp holding base
    towerofhanoi(n - 1, aux, dest, src)

}

// usage example
towerofhanoi(3, "A", "C", "B")
