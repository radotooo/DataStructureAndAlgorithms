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


console.log(generate(6))

// console.log(numIdenticalPaires([1,2,3,1,1,3]))