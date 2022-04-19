/*
 * @lc app=leetcode id=14 lang=javascript
 *
 * [14] Longest Common Prefix
 */

// @lc code=start
/**
 * @param {string[]} strs
 * @return {string}
 */
var longestCommonPrefix = function (strs) {
    const word = strs[0];

    for (let index = word.length; index > 0; index--) {
        const currentWord = word.substring(0, index);

        if (strs.every(x => x.startsWith(currentWord))) return currentWord;
    }
    return '';
};

// @lc code=end

