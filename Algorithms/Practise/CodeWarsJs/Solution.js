
//!Jaden Casing Strings

const { reporters } = require("mocha");

//
String.prototype.toJadenCase = function () {
    return this.split(" ").map(x => x[0].toUpperCase() + x.slice(1)).join(" ")
};

//!Sum of Digits / Digital Root
function digital_root(n) {

    var numbers = [];
    numbers = n.toString().split("").map(x => Number(x));

    while (numbers.length > 1) {
        numbers = numbers.reduce((a, b) => a + b).toString().split("").map(x => Number(x));
    }
    return Number(numbers.toString())
}
//* Best..
//*   if (n < 10) return n;

//*   return digital_root(
//*     n.toString().split('').reduce(function(acc, d) { return acc + +d; }, 0));
//! Square Every Digit
function squareDigits(num) {
    return +num.toString().split("").map(x => Number(Math.pow(x, 2))).join("")

}
//! Ones and Zeros
const binaryArrayToNumber = arr => {

    return parseInt(arr.join(""), 2)
};

//!Convert string to camel case
function toCamelCase(str) {
    if (str === "") {
        return "";
    }
    result = str.split(/[-_]+/).filter(x => x !== "")
    let firstWord = result.slice(0, 1).join("")

    if (firstWord.charAt(0) === firstWord.charAt(0).toLowerCase()) {
        return firstWord + result.slice(1).map(x => x[0].toUpperCase() + x.slice(1)).join("");
    }
    return result.map(x => x[0].toUpperCase() + x.slice(1)).join("");

}
//* Best..
//* var regExp=/[-_]\w/ig;
//* return str.replace(regExp,function(match){
//*      return match.charAt(1).toUpperCase();
//* });
//! Moving Zeros To The End
var moveZeros = function (arr) {

    return arr.filter(x => x !== 0).concat(arr.filter(x => x === 0))

}

//!Format a string of names like 'Bart, Lisa & Maggie'.
function list(names) {


    if (names.length <= 1) {
        return names.length === 1 ? names[0].name : ""
    }
    else if (names.length >= 2) {

        let lastElement = names.slice(names.length - 1)
        return names.slice(0, names.length - 1).map(x => x.name).join(", ") + " & " + lastElement[0].name;

    }

    //console.log(names.map(x=>x.name).join(","));
    // console.log([...names]);
    let lastName = [...names].join()
    console.log(lastName);
}

//console.log(list([ {name: 'Bart'}, {name: 'Lisa'},{name: 'rado'},{name: 'gosho'}]));
//!Equal Sides Of An Array

function findEven(arr) {
    for (let i = 0; i <= arr.length; i++) {
        let leftNum = arr.slice(0, i).reduce((a, b) => a + b, 0)
        let rightNum = arr.slice(i + 1, arr.length).reduce((a, b) => a + b, 0)
        if (leftNum === rightNum) {
            return i;
        }
    }
    return -1;
}

//!Who likes it?


const nameConditions = {
    0: () => { return 'no one likes this' },
    1: (names) => { return `${names[0]} likes this` },
    2: (names) => { return `${names[0]} and ${names[1]} like this` },
    3: (names) => { return `${names[0]}, ${names[1]} and ${names[2]} like this` },
    default: (names) => { return `${names[0]}, ${names[1]} and ${names.slice(2)} others like this` }
}
function likes(names) {

    let aSize = names.length
    if (aSize <= 3) {
        return nameConditions[aSize](names)
    }

    return nameConditions['default'](names)
}

//! Did I Finish my Sudoku?

function doneOrNot(board) {
    let col = []
    let row = [];
    innerMatrix = [];
    for (let i = 0; i < board.length; i++) {
        for (let g = 0; g < board[i].length; g++) {

            if (!col.includes(board[i][g])) {

                col.push(board[i][g])
            }

            if (!row.includes(board[g][i])) {

                row.push(board[g][i])
            }

            if (row.length !== col.length) {
                return "Try again!"
            }
        }
        col = [];
        row = [];
    }
    for (let c = 0; c < board.length; c += 3) {
        for (let b = 0; b < board[c].length; b++) {
            if (board[c][b] === board[b][c]) {
                return "Try again!"

            }

        }

    }
    return "Finished!"
}

//!Extract the domain name from a URL
function domainName(url) {

    let a = url.match(/(?:http(?:s)?:\/\/)?(?:w{3}\.)?([^\.]+)/i)[1]

    return a;
}
//!Halving Sum
function halvingSum(n) {
    let sum = n;
    while (n > 1) {
        n = Math.floor(n / 2);
        sum += n;
    }
    return sum;
}
//console.log(halvingSum(25));
let sum = 0;
var fib = function (N) {
    if (N <= 1) {
        return 1;
    }


    return fib(N - 1) + fib(N - 2)


};
var fib2 = function (N) {
    if (N < 1) {
        return n;
    }
    if (N === 2) {
        return 1;
    }

    let sum = 0;
    let result = [];
    let previous = 1;
    let next = 1;
    for (let i = 3; i <= N; i++) {


        sum = previous + next;
        previous = next
        next = sum;
        result.push(sum)

    }
    return result.join(",")

};
//!Regex Password Validation
function validate(password) {
    return /(put answer here)/.test(password);
}
let b = {};

function findOdd(A) {
    let bc = A.reduce((a, b) => {
        if (a[b] === undefined) {
            a[b] = 1;
        }
        else {
            a[b] += 1;
        }
        return a;
    }, {});

    console.log(bc);
    
}
findOdd([1, 2, 3, 4, 5, 6, 6, 6]);
