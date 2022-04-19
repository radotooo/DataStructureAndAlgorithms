/*
 * @lc app=leetcode id=58 lang=javascript
 *
 * [58] Length of Last Word
 */

// @lc code=start
/**
 * @param {string} s
 * @return {number}
 */
var lengthOfLastWord = function (s) {
    const result = s.split(' ').filter(x => x)

    return result[result.length - 1].length
};
// @lc code=end

