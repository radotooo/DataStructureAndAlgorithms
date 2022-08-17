/*
 * @lc app=leetcode id=53 lang=javascript
 *
 * [53] Maximum Subarray
 */

// @lc code=start
/**
 * @param {number[]} nums
 * @return {number}
 */
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

function maxSubArray2(nums) {
    let maxCurrent = nums[0];
    let maxGlobal = nums[0];
    for (let i = 1; i < nums.length; i++) {
        maxCurrent = Math.max(nums[i], maxCurrent + nums[i]);
        if (maxCurrent > maxGlobal) {
            maxGlobal = maxCurrent;
        }
    }
    return maxGlobal
}

console.error(maxSubArray2([5, 3, -4, 1]));
// @lc code=end

