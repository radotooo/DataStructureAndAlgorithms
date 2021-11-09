/**

 * @param {number[]} nums
 * @return {number}
 */
 var numIdenticalPairs = function(nums) {
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
 var searchInsert = function(nums, target) {
    const result =  nums.findIndex(num => num === target ? target : num > target) 

    return result < 0 ? nums.length : result
};

 var searchInsertBinary = function(nums, target) {
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
 var generate = function(numRows) {
    let result = [[1]]

    if (numRows === 1) result

     for (let index = 0; index < numRows -1; index++) {
         const currentArr = result[index]

         const temp = currentArr.reduce((a,b,i) => {
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
 var diameterOfBinaryTree = function(root) {
    let result = 0;
    helper(root);
    return result

    function helper(root){
        if(!root)return 0;

        let left = helper(root.left);
        console.log(left);
        let right = helper(root.right);

        console.log(right);
        result = Math.max(left + right , result);

        return 1 + Math.max(left, right)
    }
};

// 231. Power of Two
var isPowerOfTwo = function(n) {
    if (n === 1) return true
    if (n < 1) return false
    return isPowerOfTwo(n/2)
};

// Alternative 1
var isPowerOfTwo = function (n) {
    return  Math.log2(n) % 1 === 0;
    };

console.log(isPowerOfTwo(3));
// console.log(numIdenticalPaires([1,2,3,1,1,3]))