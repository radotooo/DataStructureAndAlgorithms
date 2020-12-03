// const { expect } = require('chai');
const { twoSum, duplicateCount } = require('./solution');

describe('test twoSum', () => {
  test('should return data', () => {
    expect(twoSum([1, 2, 3], 4)).toEqual([0, 2]);
    expect(twoSum([1234, 5678, 9012], 14690)).toEqual([1, 2]);
    expect(twoSum([2, 2, 4], 4)).toEqual([0, 1]);
  });
});

describe('test dublicateCount', () => {
  test('should return value', () => {
    expect(duplicateCount('')).toEqual(0);
    expect(duplicateCount('abcde')).toEqual(0);
    expect(duplicateCount('aabbcde')).toEqual(2);
    expect(duplicateCount('aabBcde')).toEqual(2);
    expect(duplicateCount('Indivisibility')).toEqual(1);
    expect(duplicateCount('Indivisibilities')).toEqual(2);
  });
});
