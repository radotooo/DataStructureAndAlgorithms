//!Jaden Casing Strings

// const { reporters } = require("mocha");

//
// String.prototype.toJadenCase = function () {
//   return this.split(' ')
//     .map((x) => x[0].toUpperCase() + x.slice(1))
//     .join(' ');
// };

//!Sum of Digits / Digital Root
function digital_root(n) {
  var numbers = [];
  numbers = n
    .toString()
    .split('')
    .map((x) => Number(x));

  while (numbers.length > 1) {
    numbers = numbers
      .reduce((a, b) => a + b)
      .toString()
      .split('')
      .map((x) => Number(x));
  }
  return Number(numbers.toString());
}
//* Best..
//*   if (n < 10) return n;

//*   return digital_root(
//*     n.toString().split('').reduce(function(acc, d) { return acc + +d; }, 0));
//! Square Every Digit
function squareDigits(num) {
  return +num
    .toString()
    .split('')
    .map((x) => Number(Math.pow(x, 2)))
    .join('');
}
//! Ones and Zeros
const binaryArrayToNumber = (arr) => {
  return parseInt(arr.join(''), 2);
};

//!Convert string to camel case
function toCamelCase(str) {
  if (str === '') {
    return '';
  }
  result = str.split(/[-_]+/).filter((x) => x !== '');
  let firstWord = result.slice(0, 1).join('');

  if (firstWord.charAt(0) === firstWord.charAt(0).toLowerCase()) {
    return (
      firstWord +
      result
        .slice(1)
        .map((x) => x[0].toUpperCase() + x.slice(1))
        .join('')
    );
  }
  return result.map((x) => x[0].toUpperCase() + x.slice(1)).join('');
}
//* Best..
//* var regExp=/[-_]\w/ig;
//* return str.replace(regExp,function(match){
//*      return match.charAt(1).toUpperCase();
//* });
//! Moving Zeros To The End
var moveZeros = function (arr) {
  return arr.filter((x) => x !== 0).concat(arr.filter((x) => x === 0));
};

//!Format a string of names like 'Bart, Lisa & Maggie'.
function list(names) {
  if (names.length <= 1) {
    return names.length === 1 ? names[0].name : '';
  } else if (names.length >= 2) {
    let lastElement = names.slice(names.length - 1);
    return (
      names
        .slice(0, names.length - 1)
        .map((x) => x.name)
        .join(', ') +
      ' & ' +
      lastElement[0].name
    );
  }

  //console.log(names.map(x=>x.name).join(","));
  // console.log([...names]);
  let lastName = [...names].join();
  console.log(lastName);
}

//console.log(list([ {name: 'Bart'}, {name: 'Lisa'},{name: 'rado'},{name: 'gosho'}]));
//!Equal Sides Of An Array

function findEven(arr) {
  for (let i = 0; i <= arr.length; i++) {
    let leftNum = arr.slice(0, i).reduce((a, b) => a + b, 0);
    let rightNum = arr.slice(i + 1, arr.length).reduce((a, b) => a + b, 0);
    if (leftNum === rightNum) {
      return i;
    }
  }
  return -1;
}

//!Who likes it?

const nameConditions = {
  0: () => {
    return 'no one likes this';
  },
  1: (names) => {
    return `${names[0]} likes this`;
  },
  2: (names) => {
    return `${names[0]} and ${names[1]} like this`;
  },
  3: (names) => {
    return `${names[0]}, ${names[1]} and ${names[2]} like this`;
  },
  default: (names) => {
    return `${names[0]}, ${names[1]} and ${names.slice(2)} others like this`;
  },
};
function likes(names) {
  let aSize = names.length;
  if (aSize <= 3) {
    return nameConditions[aSize](names);
  }

  return nameConditions['default'](names);
}

//! Did I Finish my Sudoku?

function doneOrNot(board) {
  let col = [];
  let row = [];
  innerMatrix = [];
  for (let i = 0; i < board.length; i++) {
    for (let g = 0; g < board[i].length; g++) {
      if (!col.includes(board[i][g])) {
        col.push(board[i][g]);
      }

      if (!row.includes(board[g][i])) {
        row.push(board[g][i]);
      }

      if (row.length !== col.length) {
        return 'Try again!';
      }
    }
    col = [];
    row = [];
  }
  for (let c = 0; c < board.length; c += 3) {
    for (let b = 0; b < board[c].length; b++) {
      if (board[c][b] === board[b][c]) {
        return 'Try again!';
      }
    }
  }
  return 'Finished!';
}

//!Extract the domain name from a URL
function domainName(url) {
  let a = url.match(/(?:http(?:s)?:\/\/)?(?:w{3}\.)?([^\.]+)/i)[1];

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

  return fib(N - 1) + fib(N - 2);
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
    previous = next;
    next = sum;
    result.push(sum);
  }
  return result.join(',');
};
//!Regex Password Validation
function validate(password) {
  return /(put answer here)/.test(password);
}

function findOdd(A) {
  let bc = A.reduce((a, b) => {
    if (a[b] === undefined) {
      a[b] = 1;
    } else {
      a[b] += 1;
    }
    return a;
  }, {});

  console.log(bc);
}

//! Convert a linked list to a string
class Node {
  constructor(data, next = null) {
    this.data = data;
    this.next = next;
  }
}

function stringify(list) {
  let result = [];
  GetAllElementsFromLinkedList(list, result);

  if (result.length === 1) {
    return 'null';
  } else {
    return result.join(' -> ');
  }
}

function GetAllElementsFromLinkedList(linkedList, result) {
  if (linkedList === null) {
    result.push('null');
    return;
  }
  if (linkedList.data != undefined) {
    result.push(linkedList.data);
  }
  GetAllElementsFromLinkedList(linkedList.next, result);
}

//*best
//  function stringify2(list) {
//      return list === null ? "null" : `${list.data} -> ${stringify(list.next)}`;
//     }

//!Simple max digit sum
function MaxDigitSum(n) {
  //   if(n<=9){
  //       return n;
  //   }
  //   if(n==10){
  //       return 9;
  //   }
  let maxSum = 0;
  let result = 0;
  for (let index = n; index <= n; index++) {
    let elementsSum = index
      .toString()
      .split('')
      .map(Number)
      .reduce((a, b) => a + b, 0);

    if (elementsSum >= maxSum) {
      maxSum = elementsSum;
      result = index;
    }
  }
  return result;
}
//*best
// var sum=(x)=>[...x].reduce((a,b)=>+a + +b)
// function solve(n){
//     let s = [...''+n], i=1
//     while (i<s.length && s[i]==9) i++
//     s[i-1] -= 1
//     let num = s.slice(0,i).join``+'9'.repeat(s.slice(i).length)
//     return sum(num)>sum(''+n)?+num:n
// }

//!Sum of pairs

function sumOFPairs0n(ints, s) {
  let resultList = {};

  for (let i = 0; i < ints.length; i++) {
    if (resultList.hasOwnProperty(s - ints[i])) {
      return [resultList[s - ints[i]], ints[i]];
    }
    resultList[ints[i]] = ints[i];
  }
}

//! Array Helpers
Array.prototype.square = function () {
  return this.map((x) => x * x);
};
Array.prototype.cube = function () {
  return this.map((x) => x * x * x);
};
Array.prototype.average = function () {
  if (this === undefined || this.length == 0) {
    return NaN;
  }
  console.log(this.reduce((a, b) => a + b));
  return this.reduce((a, b) => a + b) / this.length;
};
Array.prototype.sum = function () {
  return this.reduce((a, b) => a + b);
};
Array.prototype.even = function () {
  return this.filter((x) => x % 2 == 0);
};
Array.prototype.odd = function () {
  return this.filter((x) => x % 2 == 1);
};

//Interview task generate excel column name from index

function ColumnNameSolve(num) {
  let columnName = '';

  while (num > 0) {
    let rem = num % 26;

    if (rem == 0) {
      columnname += 'z';
      num = num / 26 - 1;
    } else {
      columnName += String.fromCharCode(rem - 1 + 65);
      num = Math.floor(num / 26);
    }
  }
  return columnName.split('').reverse().join('');
}

//Count characters in your string

function count(string) {
  return [...string].reduce((a, b) => {
    a[b] === undefined ? (a[b] = 1) : a[b]++;
    return a;
  }, {});
}
//Two Sum
function twoSum(numbers, target) {
  let result = [];
  numbers.map((x, i) =>
    numbers.map((a, index) =>
      numbers[i] + numbers[index] === target && i !== index
        ? result.push([i, index])
        : ''
    )
  );
  return result[0];
}

//Count the number of Duplicates
function duplicateCount(text) {
  return Object.values(
    [...text.toLowerCase()].reduce((a, b, i, array) => {
      a.hasOwnProperty(b) ? a[b]++ : (a[b] = 1);
      return a;
    }, {})
  ).filter((x) => x > 1).length;
}
// console.log(duplicateCount('aabBcde'));

function ggg(string) {
  console.log([...string.toLowerCase()]);
}

//Autocomplete! Yay!
function autocomplete(input, dictionary) {
  return dictionary
    .reduce((a, b) => {
      if (
        b
          .toLowerCase()
          .replace(/[^a-z]/gi, '')
          .startsWith(input.replace(/[^a-z]/gi, ''))
      ) {
        a.push(b.replace(/[^a-z]/gi, ''));
      }
      return a;
    }, [])
    .slice(0, 5);
}
//best
// const autocomplete = (input, dictionary) => dictionary.filter(w => w.toLowerCase().startsWith(input.replace(/[^A-Z]/gi,''))).slice(0,5);

function fourLetters(names) {
  let gg = names.split(' ');
  console.log(gg);
  return names.split(' ').filter((x) => x.length === 4).length;
}

function fourLettersArr(array) {
  let frequency = array.reduce((a, b) => {
    if (a[b]) {
      a[b]++;
    } else {
      a[b] = 1;
    }
    return a;
  }, {});

  let a = Object.entries(frequency);
  a = a.sort((a, b) => {
    return b[1] - a[1] || a[0] - b[0];
  });

  let result = [];
  for (let index = 0; index < a.length; index++) {
    for (let c = 0; c < a[index][1]; c++) {
      result.push(Number(a[index][0]));
    }
  }
  console.log(result);
}

function longestSubstring(test) {
  let letters = [];
  let hightScore = 0;

  [...test].map((b) => {
    if (!letters.includes(b)) {
      letters.push(b);
    } else {
      letters.length > hightScore ? (hightScore = letters.length) : '';
      letters = [];
    }
  });

  return hightScore;
}

function getResult(nums) {
  return nums
    .sort((a, b) => {
      console.log(b + '' + a);
      console.log('middle');
      console.log(a + '' + b);
      console.log(nums);
      return b + '' + a - (a + '' + b);
    })
    .join('');
}

function getNumberOfRepetitions(s) {
  if (s === '') return 0;
  return s.match(/(.)\1*/g).sort((a, b) => b.length - a.length)[0].length;
}

function closestSum(nums, target) {
  nums.sort((a, b) => a - b);
  let closest = null;

  for (let i = 0; i < nums.length; i++) {
    let low = i + 1;
    let high = nums.length - 1;

    while (low < high) {
      const sum = nums[i] + nums[low] + nums[high];
      const myDiff = Math.abs(target - sum);
      const currDiff = Math.abs(target - closest);

      if (myDiff < currDiff || closest === null) {
        closest = sum;
      }

      if (sum === target) {
        return sum;
      } else if (sum < target) {
        low++;
      } else {
        high--;
      }
    }
    while (nums[i] === nums[i + 1]) i++;
  }
  return closest;
}

function applyBackspaces(s) {
  let result = [];
  [...s].map((a) => {
    if (a === '$') {
      result.pop();
    } else {
      result.push(a);
    }
  });
  return result.join('');
}
function cache(func) {
  let data = {};
  if (Object.hasOwnProperty(func)) {
    let resultOfFunc = func();
    data[func] = resultOfFunc;
    return resultOfFunc;
  } else {
    return data[func];
  }
}

function findOutlier(integers) {
  let odd = integers.filter((x) => Math.abs(x % 2) === 0);
  let even = integers.filter((x) => Math.abs(x % 2) === 1);

  return even.length === 1 ? even[0] : odd[0];
}

var number = function (busStops) {
  return busStops.reduce((a, b) => {
    a += b[0];
    a -= b[1];
    return a;
  }, 0);
};

function findShort(s) {
  return Math.min(...s.map((x) => x.length));
}

// Simple Pig Latin
function pigIt(str) {
  return str
    .split(' ')
    .reduce((a, b) => {
      b.match(/\w+/gm) ? (a += ' ' + b.slice(1) + b[0] + 'ay') : (a += ' ' + b);
      return a;
    }, '')
    .trim();
}
//best
//  function pigIt(str){
//   return str.replace(/(\w)(\w*)(\s|$)/g, "\$2\$1ay\$3")
// }

function anagrams(word, words) {
  let result = [];
  let values = [...word];

  for (let i = 0; i < words.length; i++) {
    if (words[i].length === word.length) {
      for (let c = 0; c < words[i].length; c++) {
        let letter = words[i][c];
        if (values.includes(letter)) {
          let indexOF = values.indexOf(letter);
          values.splice(indexOF, 1);
        }
      }
      if (values.length === 0) {
        result.push(words[i]);
      }

      values = [...word];
    }
  }
  return result;
}
//best
// words.filter(w => w.split('').sort().join('') === word.split('').sort().join('')); .....
  function largestPairSum(arr){

    let biggestNum = Number.NEGATIVE_INFINITY
    for (let i = 0; i < arr.length; i++) {
      for (let c = i+1; c < arr.length; c++) {
        const num = arr[i] + arr[c]
        if(num>biggestNum){
          biggestNum = num
        }
      }
    }
    return biggestNum
  }
  
  function getAverage(arr){
    return arr.reduce((a,b) => a + b) / arr.length
  }

  function filter_list(arr) {
    return arr.filter(x => typeof(x) !== 'string' )
  }

  function monkeyCount(n) {
    return Array.from(Array(n+1).keys()).slice(1)
    }

    function removeSmallest(numbers) {
     numbers.splice(numbers.indexOf(Math.min(...numbers)), 1);
      return numbers;
    }

    var uniqueInOrder=function(iterable) {
      return [...iterable].filter((a,index) => a !== iterable[index + 1]) 
    }

    function highAndLow(numbers){
      const splitNumbers = numbers.split(' ')
      
      return `${Math.max(...splitNumbers)} ${Math.min(...splitNumbers)}`
    }

    function expandedForm(num) {
      return num.toString().split('').reduce((arr, value, index, numbers) => {
        if (value > 0) {
          const result = `${ numbers[index] }${ '0'.repeat(numbers.length - 1 -index) }`
          arr.push(result)
        }

        return arr
      }, []).join(' + ')
    }

    function expandedForm2(num) {
      return String(num)
              .split("")
              .map((num, index, arr) => num + "0".repeat(arr.length - index -1 ))
              .filter((num) => Number(num) != 0)
              .join(" + ")
    }

    // Sort the odd
    function sortArray(array) {
      let index = -1
      const oddNumbers = array.filter((x) =>  x % 2 ).sort((a,b) => a-b)
      console.log(oddNumbers)
      return array.map((x) => x % 2 ? oddNumbers.shift() : x);
      // Return a sorted array.
    }
      
    function sumStrings(a, b) { 
     return (Number(a) + Number(b)).toString()
    }

    function multiply(a, b) {
     return (BigInt(a) * BigInt(b)).toString().replace('/^0+/', '')
    }

console.log(multiply('10', '10'))
// console.log(towerBuilder(11))
// console.log(towerBuilder(5))
// console.log(sortArray([]))
