# https://docs.python.org/zh-cn/3/howto/sorting.html#sortinghowto

"""
Python 列表有一个内置的 list.sort() 方法可以直接修改列表。还有一个 sorted() 内置函数，它会从一个可迭代对象构建一个新的排序列表。

sorted(iterable, /, *, key=None, reverse=False)
根据 iterable 中的项返回一个新的已排序列表。

具有两个可选参数, 它们都必须指定为关键字参数。sorted(student_tuples, key=itemgetter(2), reverse=True)

key 指定带有单个参数的函数，用于从 iterable 的每个元素中提取用于比较的键 (例如 key=str.lower)。 默认值为 None (直接比较元素)。

reverse 为一个布尔值。 如果设为 True, 则每个列表元素将按反向顺序比较进行排序。

内置的 sorted() 确保是稳定的。 如果一个排序确保不会改变比较结果相等的元素的相对顺序就称其为稳定的 --- 这有利于进行多重排序（例如先按部门、再按薪级排序）。


简单的升序排序非常简单：只需调用 sorted() 函数。它返回一个新的排序后列表：
sorted([5, 2, 3, 1, 4])
[1, 2, 3, 4, 5]

你也可以使用 list.sort() 方法，它会直接修改原列表（并返回 None 以避免混淆），通常来说它不如 sorted() 方便 ——— 但如果你不需要原列表，它会更有效率。
a = [5, 2, 3, 1, 4]
a.sort()
a
[1, 2, 3, 4, 5]

另外一个区别是， list.sort() 方法只是为列表定义的，而 sorted() 函数可以接受任何可迭代对象。

sorted({1: 'D', 2: 'B', 3: 'B', 4: 'E', 5: 'A'})
[1, 2, 3, 4, 5]

Python 中使用的 Timsort 算法可以有效地进行多种排序，因为它可以利用数据集中已存在的任何排序。

"""


"""
1. sorted: 一种直接的编码方式就是排序,不过排序的复杂度略高。

2. hashmap: 异位词中字符出现的次数肯定都是一样的，所以可以把 s, t 中的字符计数器作为编码，比较每个字符的出现次数即可判断 s 和 t 是否是异位词。
"""


"""
内置的 sorted() 确保是稳定的。 如果一个排序确保不会改变比较结果相等的元素的相对顺序就称其为稳定的 --- 这有利于进行多重排序（例如先按部门、再按薪级排序）。
"""



from collections import defaultdict
from collections import Counter
class Solution:
    # Anagram using all the original letters exactly once.
    def isAnagram(self, s: str, t: str) -> bool:

        return sorted(s) == sorted(t)
    """
    
    def isAnagram(self, s: str, t: str) -> bool:
        hashmap = defaultdict(int)
        if len(s) != len(t):
            return False
        
        for x in s:
            hashmap[x] += 1
        
        for y in t:
            hashmap[y] -= 1
            if hashmap[y] < 0:
                return False
        
        return True
    """
