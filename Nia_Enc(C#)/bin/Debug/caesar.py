class caesar:
    def encrypt(self,text,s): 
        if(s<0):
            s1=0-s
            s=s1
        result = "" 
        for i in range(len(text)): 
            char = text[i] 
            if (char.isupper()): 
                result += chr((ord(char) + s-65) % 26 + 65) 
            else: 
                result += chr((ord(char) + s - 97) % 26 + 97) 
        return result 
    #Cipher(n) = De-cipher(26-n)