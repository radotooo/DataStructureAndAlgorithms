var twoSum = function(nums, target) {
    for (let index = 0; index < nums.length; index++) {
        for (let c = index + 1; c < nums.length; c++) {
            const value = nums[index] + nums[c]

            if (target === value) return [index, c]

        }
    }
};

var isValid = function(s) {
    const oposite = {
        ')': '(',
        '}': '{',
        ']': '[',
    }

    const stack = []

    for (let index = 0; index < s.length; index++) {
        const val = s[index]

        oposite[val] && (oposite[val] === stack[stack.length - 1])
            ? stack.pop()
            : stack.push(s[index])
    }

    return !stack.length
};

// 21. Merge Two Sorted Lists
/**
 * @param {ListNode} list1
 * @param {ListNode} list2
 * @return {ListNode}
 */
var mergeTwoLists = function(list1, list2) {
    let node = new ListNode()
    let dummy = node

    while (list1 && list2) {
        if (list1.val <= list2.val) {
            node.next = list1
            list1 = list1.next
        } else {
            node.next = list2
            list2 = list2.next
        }
        node = node.next
    }

    if (list1) node.next = list1
    if (list2) node.next = list2

    return dummy.next
};

/**
 * @param {number[]} prices
 * @return {number}
 */
var maxProfit = function(prices) {
    let currentNum = prices[0]
    let profit = 0
    for (let i = 1; i < prices.length; i++) {
        const num = prices[i]
        if (currentNum > num) {
            currentNum = num
            continue;
        }

        const res = Math.abs(currentNum - num)

        if (res > profit) profit = res
    }
    return profit || 0
};

/**
 * @param {string} s
 * @return {boolean}
 */
var isPalindrome = function(s) {
    const regexp = /[^A-Za-z0-9]+/gm;
    const array = s.toLowerCase().replace(regexp, '');

    for (let i = 0; i < array.length; i++) {
        if (array[i] !== array[array.length - 1 - i]) return false
    }

    return true
};

var invertTree = function(root) {
    if (!root) return root

    const left = invertTree(root.left)
    const right = invertTree(root.right)

    root.right = left
    root.left = right

    return root
};

var isAnagram = function(s, t) {
    if ((s.length < t.length) || (s.length !== t.length)) return false

    for (let i = 0; i < s.length; i++) {
        if (!t.includes(s[i])) return false
        t = t.replace(s[i], '')
    }

    return true
};

/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number}
 */
var search = function(nums, target) {
    const val = binary(nums, target)

    return val && nums.indexOf(val)
}

const binary = (nums, target) => {
    if (!nums.length) return
    const middle = Math.floor(nums.length / 2)
    const val = nums[middle]
    if (val === target) {
        return val
    }
    if (val < target) return binary(nums.slice(middle + 1), target)
    if (val > target) return binary(nums.slice(0, middle), target)
}

var search2 = function(nums, target) {
    let low = 0;
    let high = nums.length - 1;
    /*
      Instead of using recursion to iterate, we use a while loop, bounded
      by low less than or equal to high.
    */
    while (low <= high) {
        let mid = Math.floor(low + (high - low) / 2);
        console.error({ low, high, mid })
        if (target == nums[mid]) {
            return mid;
        } else if (target < nums[mid]) {
            /* Move 'inward' from the high element */
            high = mid - 1;
        } else {
            low = mid + 1; /* Move inward from the low element */
        }

        console.error(low, high)
    }
    return -1; /* Element not found */
};

// 733. Flood Fill
var floodFill = function(image, sr, sc, color) {
    if (image[sr][sc] === color) return image;

    fillImage(image, sr, sc, image[sr][sc], color);
    return image;
};


function fillImage(image, sr, sc, color, newColor) {
    if (sr < 0 || sr >= image.length || sc < 0 || sc >= image[sr].length || image[sr][sc] !== color) return;

    const currentColor = image[sr][sc]
    image[sr][sc] = newColor;

    fillImage(image, sr, sc + 1, color, newColor);
    fillImage(image, sr, sc - 1, color, newColor);
    fillImage(image, sr + 1, sc, color, newColor);
    fillImage(image, sr - 1, sc, color, newColor);
}

// console.error(floodFill([[1, 1, 1], [1, 1, 0], [1, 0, 1]], 1, 1, 2))
console.error(floodFill([[0, 0, 0], [0, 0, 0]], 1, 0, 2))
