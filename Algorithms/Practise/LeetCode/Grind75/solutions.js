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

console.error(mergeTwoLists("(){}[]"))
console.error(mergeTwsValid("{[)}"))
console.error(mergeTwsValid("(("))
