/**

 * @param {number[]} nums
 * @return {number}
 */
var numIdenticalPairs = function (nums) {
    let result = 0
    for (let i = 0; i < nums.length; i++) {
        for (let j = i; j < nums.length; j++) {
            if (nums[j] === nums[i] && j > i) result++;
        }
    }
    return result
};

// 35. Search Insert Position
/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number}
 */
var searchInsert = function (nums, target) {
    const result = nums.findIndex(num => num === target ? target : num > target)

    return result < 0 ? nums.length : result
};

var searchInsertBinary = function (nums, target) {
    return binarySearch(nums, target, 0, nums.length - 1)
};

function binarySearch(nums, target, left, right) {
    if (left > right) {
        return nums.length
    }

    const mid = Math.floor((left + right) / 2)
    if (nums[mid] === target) {
        return mid
    } else if (nums[mid] > target) {
        return search(nums, target, left, mid - 1)
    } else {
        return search(nums, target, mid + 1, right)
    }
}

// 118. Pascal's Triangle

/**
 * @param {number} numRows
 * @return {number[][]}
 */
var generate = function (numRows) {
    let result = [[1]]

    if (numRows === 1) result

    for (let index = 0; index < numRows - 1; index++) {
        const currentArr = result[index]

        const temp = currentArr.reduce((a, b, i) => {
            if (i === currentArr.length - 1) return a

            a.push(currentArr[i] + currentArr[i + 1])

            return a
        }, [1])

        temp.push(1)

        result.push(temp)
    }

    return result
};

class TreeNode {
    constructor(val, left, right) {
        this.val = val
        this.left = left
        this.right = right
    }
}

/**
 * Definition for a binary tree node.
 * function TreeNode(val, left, right) {
 *     this.val = (val===undefined ? 0 : val)
 *     this.left = (left===undefined ? null : left)
 *     this.right = (right===undefined ? null : right)
 * }
 */
/**
 * @param {TreeNode} root
 * @return {number}
 */
var diameterOfBinaryTree = function (root) {
    let result = 0;
    helper(root);
    return result

    function helper(root) {
        if (!root) return 0;

        let left = helper(root.left);
        console.log(left);
        let right = helper(root.right);

        console.log(right);
        result = Math.max(left + right, result);

        return 1 + Math.max(left, right)
    }
};

// 231. Power of Two
var isPowerOfTwo = function (n) {
    if (n === 1) return true
    if (n < 1) return false
    return isPowerOfTwo(n / 2)
};

// Alternative 1
var isPowerOfTwo = function (n) {
    return Math.log2(n) % 1 === 0;
};

// 1047. Remove All Adjacent Duplicates In String
/**
* @param {string} s
* @return {string}
*/
var removeDuplicates = function (s) {
    // const stack = [];

    // for(let i = 0; i < s.length; i++) {
    //     if(stack[stack.length - 1] === s[i]) stack.pop()
    //     else stack.push(s[i])
    // }
    // return stack.join('')
    return match(s, /(\w)\1/gm)
};

const match = (s, regex) => {
    if (!regex.test(s)) {
        return s
    }

    return match(s.replace(regex, ''), regex)
}

// 1295. Find Numbers with Even Number of Digits

/**
 * @param {number[]} nums
 * @return {number}
 */
var findNumbers = function (nums) {
    return nums.reduce((acc, num) => {
        if (`${num}`.length % 2 === 0) acc++
        return acc
    }, 0)
};

// 205. Isomorphic Strings
/**
 * @param {string} s
 * @param {string} t
 * @return {boolean}
 */
var isIsomorphic = function (s, t) {
    const sData = {};
    const tData = {};

    for (var i = 0; i < s.length; i++) {
        charS = s[i]
        charT = t[i]

        if (sData[charS] === undefined) sData[charS] = i
        if (tData[charT] === undefined) tData[charT] = i

        if (sData[charS] !== tData[charT]) return false;
    }
    return true;
};

/**
 * @param {string} a
 * @param {string} b
 * @return {string}
 */
var addBinary = function (a, b) {
    return (BigInt('0b' + a) + BigInt('0b' + b)).toString(2)
}

/**
* @param {number[]} gain
* @return {number}
*/
var largestAltitude = function (gain) {
    return Math.max(...gain.reduce((acc, curr, i) => {
        acc.push(acc[acc.length - 1] + curr)
        return acc
    }, [0]))
};

/**
 * @param {number} numBottles
 * @param {number} numExchange
 * @return {number}
 */
var numWaterBottles = function (numBottles, numExchange) {

    let result = numBottles;

    while (numBottles >= numExchange) {
        const exchange = Math.floor(numBottles / numExchange);

        result += exchange;
        numBottles = exchange + (numBottles % numExchange);
    }
    return result;
};

/**
 * @param {number[]} students
 * @param {number[]} sandwiches
 * @return {number}
 */
var countStudents = function (students, sandwiches) {
    if (!students.includes(sandwiches[0]) || !sandwiches) {
        return students.length ? students.length : 0
    }
    students.splice(students.indexOf(sandwiches[0]), 1)
    sandwiches.shift()
    return countStudents(students, sandwiches)
};

/**
 * @param {number[][]} matrix
 * @return {number[][]}
 */
var transpose = function (matrix) {
    for (const [i, terator] of matrix.entries()) {
        console.log(matrix[i].join(", "))
    }
    return
};

// 1287
var indSpecialInteger = function (arr) {
    const percentage = Math.floor(arr.length / 4)
    const result = {}
    arr.forEach(num => {
        !result[num] ? result[num] = 1 : result[num]++
    })

    return Object.entries(result).find(([letter, value]) => value > percentage)[0]
};

var findNumbers = function (nums) {
    return nums.reduce((el, num) => {
        if (num.toString().length % 2 === 0) el++
        return el
    }, 0)
};


// 217. Contains Duplicate
var containsDuplicate = function (nums) {
    const numbers = []
    for (const num of nums) {
        if (numbers.includes(num)) return true
        numbers.push(num)
    }
    return false
};

//53. Maximum Subarray
var maxSubArray = function (nums) {
    let max = nums[0]
    let temp = 0

    nums.forEach((value, index) => {
        if (temp < 0) temp = 0
        temp += nums[index]
        max = Math.max(max, temp)
    })

    return max
}

// 1 two sum
var twoSum = function (nums, target) {
    let indexes = []

    for (let index = 0; index < nums.length; index++) {

        indexes.push(index)

        for (let c = index + 1; c < nums.length; c++) {
            if (nums[index] + nums[c] === target) indexes.push(c)
        }

        if (indexes.length === 2) return indexes
        else indexes = []
    }
};

// 88
var merge = function (nums1, m, nums2, n) {
    nums1.splice(m, n, ...nums2);
    nums1.sort((a, b) => a - b);
};

// 350. Intersection of Two Arrays II
var intersect = function (nums1, nums2) {
    const result = []

    for (const nums of nums1) {
        if (!nums2.length) return result
        if (nums2.includes(nums)) {
            result.push(nums)
            nums2.splice(nums2.indexOf(nums), 1)
        }
    }

    return result
};

// 121. Best Time to Buy and Sell Stock
/**
 * @param {number[]} prices
 * @return {number}
 */
var maxProfit = function (prices) {
    let maxValue = 0
    let minValue = prices[0]

    for (let i = 1; i < prices.length; i++) {
        if (prices[i] < minValue) minValue = prices[i]
        else if (prices[i] - minValue > maxValue) maxValue = prices[i] - minValue
    }

    return maxValue
}

/**
 * @param {number[][]} mat
 * @param {number} r
 * @param {number} c
 * @return {number[][]}
 */
var matrixReshape = function (mat, r, c) {
    const row = mat.length
    const col = mat[0].length

    if (row * col !== r * c) return mat

    let temp = []

    return mat.flat().reduce((arr, el) => {
        temp.push(el)
        if (temp.length === c) {
            arr.push(temp)
            temp = []
        }
        return arr
    }, []);
}

/**
 * @param {number} numRows
 * @return {number[][]}
 */
var generate = function (numRows) {
    if (numRows === 1) return [[1]]
    if (numRows === 2) return [[1], [1, 1]]
    const result = [[1], [1, 1]]

    for (let i = 1; i < numRows - 1; i++) {
        const temp = []
        for (let j = 0; j < result[i].length - 1; j++) {
            temp.push(result[i][j] + result[i][j + 1])
        }
        result.push([1, ...temp, 1])
    }

    return result
};

/**
 * @param {character[][]} board
 * @return {boolean}
 */
var isValidSudoku = function (board) {
    for (const [i, values] of board.entries()) {
        let inside = []
        for (const [k, value] of values.entries()) {

            if (k % 3 === 0 && k !== 0) {
                inside.push(" | ")
            }
            inside.push(value)
        }
        if (i % 3 === 0 && i !== 0) console.log('-'.repeat(25))
        console.log(...inside);
    }
}

/**
 * @param {string} s
 * @return {number}
 */
var firstUniqChar = function (s) {
    return s.indexOf([...s].find(c => s.indexOf(c) === s.lastIndexOf(c)))
}

/**
 * @param {string} ransomNote
 * @param {string} magazine
 * @return {boolean}
 */
var canConstruct = function (s, t) {
    for (const letter of s) {
        console.error(s.length, t.length);
        if (!t.includes(letter) || (s``.length !== t.length)) return false
        t = t.replace(letter, ' ')
    }
    return true
};

var search = function (nums, target) {
    const num = binarySearch2(nums, target)

    return num !== undefined ? nums.indexOf(num) : -1
};

var binarySearch2 = function (nums, target) {
    if (!nums.length) return;

    const middle = Math.floor(nums.length / 2)
    const num = nums[middle];

    if (nums[middle] === target) return target

    if (num > target) return binarySearch2(nums.slice(0, middle), target)
    else return binarySearch2(nums.slice(middle + 1), target)
};
