class Solution:
    def canBeValid(self, s: str, locked: str) -> bool:
        if len(s) % 2 != 0:
            return False  

        n = len(s)
        open_possible = 0
        close_possible = 0

        for i in range(n):
            if locked[i] == '0' or s[i] == '(':
                open_possible += 1
            else:
                open_possible -= 1
            
            if open_possible < 0:
                return False



        return True