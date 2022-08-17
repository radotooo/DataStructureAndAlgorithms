/*
 * @lc app=leetcode id=70 lang=javascript
 *
 * [70] Climbing Stairs
 */

// @lc code=start
/**
 * @param {number} n
 * @return {number}
 */
var climbStairs = function (n) {
    let res = []
    res[0] = 1
    res[1] = 1

    for (let i = 2; i <= n; i++) {
        res[i] = res[i - 1] + res[i - 2]
    }

    return res[n]
};
// @lc code=end

