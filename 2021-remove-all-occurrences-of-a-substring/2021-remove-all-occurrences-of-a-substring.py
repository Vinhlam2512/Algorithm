def check_match(stack: list, part: str, part_length: int) -> bool:
    return "".join(stack[-part_length:]) == part


class Solution:
    def removeOccurrences(self, s: str, part: str) -> str:
        stack = []
        part_length = len(part)

        for char in s:
            stack.append(char)

            if len(stack) >= part_length and check_match(stack, part, part_length):
                for _ in range(part_length):
                    stack.pop()

        return "".join(stack)