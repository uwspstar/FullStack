# Given a list of numbers, 
# where every number shows up twice except for one number, 
# find that one number.

# Example:
# Input: [4, 3, 2, 4, 1, 3, 2]

def singleNumber(nums):
  for i in range(len(nums)):
    no_found = True
    for j in range(len(nums)):
      if(nums[i] == nums[j] and i != j):
        no_found = False
        break 
    if no_found:
      return nums[i]
