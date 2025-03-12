class Solution: 

    def reverse_words_manual(self, s) -> str:

        res = ' '
        l, r = 0,0

        while r < len(s):
            if s[r] != ' ':
                r+=1
            else:
                res += s[l:r+1][::-1]
                r += 1
                l = r
        
        res += " "    
        res += s[l:r+2][::-1]

        return res[2:]
        
    print(reverse_words_manual("Hello World!"))