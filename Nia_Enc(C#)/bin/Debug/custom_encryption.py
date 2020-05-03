class custom_encryption:
    def Encryption(self,s,k):
        encstr=""
        if(k<0):
            k1=0-k
            k=k1
        for i in s:
                if(ord(i))>=65 and (ord(i)<=90):
                    temp=(ord(i)+k)
                    if temp>90:
                        temp=temp%90+64
                    encstr=encstr+chr(temp)
                elif(ord(i))>=97 and (ord(i)<=122):
                    temp=(ord(i)+k)
                    if temp>122:
                        temp=temp%122+96
                    encstr=encstr+chr(temp)
                else:
                    if(ord(i)>=48 and ord(i)<=57) or ((ord(i)>=32) and (ord(i)<=47)) or ((ord(i)>=58) and (ord(i)<=64)) or ((ord(i)>=91) and (ord(i)<=96)) or ((ord(i)>=123) and (ord(i)<=126)):
                        encstr=encstr+chr(ord(i)+k+150)
                    else:
                        encstr=encstr+chr(ord(i)+k+150)
        res=""
        for i in range(len(encstr)):
            c=encstr[i]
            if(i%2==0):
                if(c.isupper()):
                    res=res+encstr[i].lower()
                elif(c.islower()):
                    res=res+encstr[i].upper()
                else:
                    res=res+c
            else:
                res=res+c
        return res 
    def decryption(self,s,k):
        res=""
        for i in range(len(s)):
            c=s[i]
            if(i%2==0):
                if(c.isupper()):
                    res=res+s[i].lower()
                elif(c.islower()):
                    res=res+s[i].upper()
                else:
                    
                    res=res+c
            else:
                res=res+c
        decstr=""
        if k<0:
            k1=-k
            k=k1
        for i in res:
            if((ord(i))>=65) and (ord(i))<=90:
                decstr=decstr+chr((ord(i) -k-65) % 26 + 65)
            elif((ord(i))>=97) and (ord(i))<=122:
                decstr=decstr+chr((ord(i) -k - 97) % 26 + 97)
            else:
                decstr=decstr+chr(ord(i)-k-150)
        return decstr
