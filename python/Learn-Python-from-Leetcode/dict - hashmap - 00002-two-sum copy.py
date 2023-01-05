"""
Dicts store an arbitrary number of objects, each identified by a unique dictionary key. Dictionaries are often also called maps, hashmaps, lookup tables, or associative arrays. 
hey allow the efficient lookup, insertion, and deletion of any object associated with a given key.

以下示例返回的字典均等于 {"one": 1, "two": 2, "three": 3}:

>>>
a = dict(one=1, two=2, three=3)
b = {'one': 1, 'two': 2, 'three': 3}
c = dict(zip(['one', 'two', 'three'], [1, 2, 3]))
d = dict([('two', 2), ('one', 1), ('three', 3)])
e = dict({'three': 3, 'one': 1, 'two': 2})
f = dict({'one': 1, 'three': 3}, two=2)
a == b == c == d == e == f


Difference between Hashtable and Dictionary in C#
https://www.geeksforgeeks.org/difference-between-hashtable-and-dictionary-in-c-sharp/
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
