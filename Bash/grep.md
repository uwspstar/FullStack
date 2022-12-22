# grep

- <https://www.youtube.com/watch?v=VGgTmxXp7xQ>

- `grep <string> <file-name>`在给定的文件中搜寻指定的字符串。
  - `grep "xing" test.txt`
- `grep -i <string> <file-name>` 在搜寻时会忽略字符串的大小写
- `grep -r <string> <file-name>` 则会在当前工作目录的文件中递归搜寻指定的字符串。
- `grep -w <string> <file-name>` exactly match.
- `grep -n <string> <file-name>` show line number.
- `grep -B <number> <string> <file-name>` show number of lines before the match string.
  - `grep -win -B 2 "xing" test.txt`
