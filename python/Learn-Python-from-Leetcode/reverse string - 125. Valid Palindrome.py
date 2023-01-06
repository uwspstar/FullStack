"""
curses.ascii.isalnum(c) 检测 ASCII 字母数字类字符；
它等价于 isalpha(c) 或 isdigit(c)。
"""

"""
array.reverse() 反转数组中各项的顺序。
new_str[::-1] 反转 string 的顺序

"""

"""
A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters, it reads the same forward and backward. Alphanumeric characters include letters and numbers.
"""


class Solution:
    def isPalindrome(self, s: str) -> bool:
        new_str = ''
        for c in s:
            if c.isalnum():
                new_str += c.lower()  # lower
        return new_str == new_str[::-1]  # reverse string


class Solution2:
    def isPalindrome(self, s: str) -> bool:

        filtered_chars = filter(lambda ch: ch.isalnum(), s)
        lowercase_filtered_chars = map(lambda ch: ch.lower(), filtered_chars)

        filtered_chars_list = list(lowercase_filtered_chars)
        reversed_chars_list = filtered_chars_list[::-1]

        return filtered_chars_list == reversed_chars_list


# two pointers


class Solution:
    def isPalindrome(self, s: str) -> bool:

        i, j = 0, len(s) - 1

        while i < j:
            while i < j and not s[i].isalnum():
                i += 1
            while i < j and not s[j].isalnum():
                j -= 1

            if s[i].lower() != s[j].lower():
                return False

            i += 1
            j -= 1

        return True
