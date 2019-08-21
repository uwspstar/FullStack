# Given a list of numbers, 
# where every number shows up twice except for one number, 
# find that one number.

# Example:
# Input: [4, 3, 2, 4, 1, 3, 2]

# with XOR 
def singleNumber(nums):
  num = 0
  for n in nums:
    num ^= n
  return num


print singleNumber([4, 3, 2, 4, 1, 3, 2])

# nest loop
def singleNumber(nums):
  for i in range(len(nums)):
    no_found = True
    for j in range(len(nums)):
      if(nums[i] == nums[j] and i != j):
        no_found = False
        break 
    if no_found:
      return nums[i]
    
    
print singleNumber([4, 3, 2, 4, 1, 3, 2])

# with dictory

def singleNumber(nums):
  my_dict = {}
  for x in nums: 
      if x in my_dict:
        my_dict[x] = my_dict[x] + 1 
      else:
        my_dict[x] = 1
  
  print(f"my_dict : {my_dict}")
  for key, val in my_dict.items():
    if my_dict[key] == 1:
      return key
 
print(singleNumber([4, -1,3, 2, 4, 1, 1,3, 2]))
