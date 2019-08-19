# Given a list of numbers with only 3 unique numbers (1, 2, 3), sort the list in O(n) time.

# Example 1:
# Input: [3, 3, 2, 1, 3, 2, 1]
# Output: [1, 1, 2, 2, 3, 3, 3]
# def sortNums(nums):
#   # Fill this in.

# print sortNums([3, 3, 2, 1, 3, 2, 1])
# # [1, 1, 2, 2, 3, 3, 3]

def sortNums(nums):
  number_one = 0
  number_two = 0
  number_three = 0
  for x in nums:
    if x == 1:
      number_one += 1
    if x == 2:
      number_two += 1
    if x == 3:
      number_three += 1
  return [1] * number_one + [2] * number_two + [3] * number_three


print(sortNums([3, 3, 2, 1, 3, 2, 1]))
