/*
 * @lc app=leetcode id=9 lang=javascript
 *
 * [9] Palindrome Number
 */

// @lc code=start
/**
 * @param {number} x
 * @return {boolean}
 */
var isPalindrome = function (x) {
    if (x < 0) return false;

    const value = x
    let result = 0

    while (x) {
        const lastNum = x % 10
        x = Math.floor(x / 10);
        result = (result * 10) + lastNum
    }

    return result === value
};

// @lc code=end

