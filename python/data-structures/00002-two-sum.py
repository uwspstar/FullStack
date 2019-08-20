# You are given a list of numbers, and a target number k. Return whether or not there are two numbers in the list that add up to k.

# Example:
# Given [4, 7, 1 , -3, 2] and k = 5, 
# return true since 4 + 1 = 5.




# def two_sum(list, k):
#   a_set = set()
#   for x in list:
#     if k - x in a_set:
#       return True
#     a_set.add(x)
#   return False
# print(two_sum([4,7, 1,-3,2], 5))

# def two_sum(list, k):
#   for i in range(len(list)): 
#     for j in range(i + 1,len(list)):
#       if list[i] + list[j] == k:
#         return True
#   return False

# print(two_sum([4,7,-11,-3,2], 5))

# def two_sum(list, k):
#   index = 0
#   for x in list:
#     for y in list[index:len(list)]:
#       if (k - y) == x:
#         return True
#     index += 1;
#   return False

# print(two_sum([4, 7, 1, -3, 2], 5))
