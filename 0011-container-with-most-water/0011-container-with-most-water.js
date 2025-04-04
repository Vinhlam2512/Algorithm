/**
 * @param {number[]} height
 * @return {number}
 */
var maxArea = function (height) {
  var left = 0;
  var right = height.length - 1;
  var maxArea = 0;
  while (left < right) {
    const heightMin = Math.min(height[left], height[right]);
    const width = right - left;
    const area = width * heightMin;
    maxArea = Math.max(maxArea, area);
    if (height[left] <= height[right]) {
      left++;
    } else {
      right--;
    }
  }
  return maxArea;
};