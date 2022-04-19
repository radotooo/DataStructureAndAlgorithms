/*
 * @lc app=leetcode id=13 lang=javascript
 *
 * [13] Roman to Integer
 */

// @lc code=start
/**
 * @param {string} s
 * @return {number}
 */
var romanToInt = function (s) {
    const nums = {
        'I': 1,
        'V': 5,
        'X': 10,
        'L': 50,
        'C': 100,
        'D': 500,
        'M': 1000,
    }

    const combinations = {
        'IV': 4,
        'IX': 9,
        'XL': 40,
        'XC': 90,
        'CD': 400,
        'CM': 900,
    }

    let resuls = 0

    for (let index = 0; index < s.split('').length; index++) {

        const currentLetter = s[index]
        const nextLetter = s[index + 1]
        const combination = currentLetter + nextLetter

        if (combinations[combination]) {
            resuls += combinations[combination]
            index++
        } else {
            resuls += nums[currentLetter]
        }
    }

    return resuls
};

// @lc code=end

