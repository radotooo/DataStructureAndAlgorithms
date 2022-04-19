/*
 * @lc app=leetcode id=20 lang=javascript
 *
 * [20] Valid Parentheses
 */

// @lc code=start
/**
 * @param {string} s
 * @return {boolean}
 */
var isValid = function (s) {
    const leftPart = '([{';
    const rightPart = ')]}';
    const stack = [];

    for (let i = 0; i < s.length; i++) {

        if (leftPart.includes(s[i])) {
            stack.push(s[i]);
        } else {
            if ((stack.length === 0) || (leftPart.indexOf(stack.pop()) !== rightPart.indexOf(s[i]))) return false;
        }
    }

    return !stack.length
};
// @lc code=end

