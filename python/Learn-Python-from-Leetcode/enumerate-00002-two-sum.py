"""
(class) enumerate
Return an enumerate object.

  iterable
    an object supporting iteration, such as array,

The enumerate object yields pairs containing a count (from start, which defaults to zero and a value yielded by the iterable argument.

enumerate is useful for obtaining an indexed list:
    (0, seq[0]), (1, seq[1]), (2, seq[2]), ...


A hash table reduces the lookup time from O(n) to O(1) by trading space for speed. It supports fast lookup in near constant time. I say "near" because if a collision occurred, a lookup could degenerate to O(n) time. However, lookup in a hash table should be amortized O(1) time as long as the hash function was chosen carefully.
"""


# You are given a list of numbers, and a target number k. Return whether or not there are two numbers in the list that add up to k.

# Example:
# Given [4, 7, 1 , -3, 2] and k = 5,
# return true since 4 + 1 = 5.


from ast import List


class Solution:
    def two_sum(self, nums: List[int], target: int) -> List[int]:
        hashmap = {}
        for i, n in enumerate(nums):
            diff = target
            if diff in hashmap:
                return [hashmap[diff], i]
            hashmap[n] = i

        return [-1, -1]


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
