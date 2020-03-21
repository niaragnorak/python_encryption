def dic(p):
    if p==0:
        small="abcdefghijklmnopqrstuvwxyz"
        di1={chr(i):(2400-i) for i in range(97,123,1)}
        big="ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        di2={chr(i):(2500+i) for i in range(90,64,-1)}
        return di1,di2
    else:
        small="abcdefghijklmnopqrstuvwxyz"
        di11={chr(i):(4900-i) for i in range(97,123,1)}
        big="ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        di22={chr(i):(5000-i) for i in range(90,64,-1)}
        return di11,di22
def Encryption(s,k):
    encstr=""
    if k<0:
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
                    encstr=encstr+chr(ord(i)+k+5000)
                else:
                    encstr=encstr+chr(ord(i)+k+5000)
    elif k==0:
        d1,d2=dic(0)
        for i in s:
            if(ord(i))>=65 and (ord(i)<=90):
                encstr=encstr+chr(d2[i])
            elif(ord(i))>=97 and (ord(i)<=122):
                encstr=encstr+chr(d1[i])
            else:
                if(ord(i)>=48 and ord(i)<=57) or ((ord(i)>=32) and (ord(i)<=47)) or ((ord(i)>=58) and (ord(i)<=64)) or ((ord(i)>=91) and (ord(i)<=96)) or ((ord(i)>=123) and (ord(i)<=126)):
                    encstr=encstr+chr(ord(i)+k+5000)
                else:
                    encstr=encstr+chr(ord(i)+k+5000)
    else:
        d11,d22=dic(k)
        for i in s:
            if(ord(i))>=65 and (ord(i)<=90):
                encstr=encstr+chr(d22[i])
            elif(ord(i))>=97 and (ord(i)<=122):
                encstr=encstr+chr(d11[i])
            else:
                if(ord(i)>=48 and ord(i)<=57) or ((ord(i)>=32) and (ord(i)<=47)) or ((ord(i)>=58) and (ord(i)<=64)) or ((ord(i)>=91) and (ord(i)<=96)) or ((ord(i)>=123) and (ord(i)<=126)):
                    encstr=encstr+chr(ord(i)+k+5000)
                else:
                    encstr=encstr+chr(ord(i)+k+5000)
    return encstr
def decryption(k):
    p=Encryption(s,k)
    decstr=""
    if k<0:
        for i in p:
            if((ord(i))>=65) and (ord(i))<=90:
                decstr=decstr+chr((ord(i) - k-65) % 26 + 65)
            elif((ord(i))>=97) and (ord(i))<=122:
                decstr=decstr+chr((ord(i) - k - 97) % 26 + 97)
            else:
                decstr=decstr+chr(ord(i)-k-5000)
    elif k==0:
        dic1,dic2=dic(0)
        p=Encryption(s,k)
        keys1=[]
        values1=[]
        keys2=[]
        values2=[]
        for j in dic1.keys():
            keys1.append(j)
        for j in dic1.items():
            values1.append(chr(j[1]))
        for j in dic2.keys():
            keys2.append(j)
        for j in dic2.items():
            values2.append(chr(j[1]))

        for i in p:
            if((ord(i))>=2278) and (ord(i))<=2303:
                pos=values1.index(i)
                decstr=decstr+keys1[pos]
                '''for z in range(len(keys1)):
                    if ord(i)==values1:
                        decstr=decstr+chr(values1)'''
            elif((ord(i))>=2565) and (ord(i))<=2590:
                pos=values2.index(i)
                decstr=decstr+keys2[pos]
                '''for z in range(len(keys2)):
                    if ord(i)==values2:
                        decstr=decstr+chr(values2)'''
            else:
                decstr=decstr+chr(ord(i)-k-5000)

    else:
        dic11,dic22=dic(k)
        p=Encryption(s,k)
        keys1=[]
        values1=[]
        keys2=[]
        values2=[]
        for j in dic11.keys():
            keys1.append(j)
        for j in dic11.items():
            values1.append(chr(j[1]))
        for j in dic22.keys():
            keys2.append(j)
        for j in dic22.items():
            values2.append(chr(j[1]))
        for i in p:
            if((ord(i))>=4778) and (ord(i))<=4803:
                pos=values1.index(i)
                decstr=decstr+keys1[pos]
                '''for z in range(len(keys1)):
                    if ord(i)==values1:
                        decstr=decstr+chr(values1)'''
            elif((ord(i))>=4910) and (ord(i))<=4935:
                pos=values2.index(i)
                decstr=decstr+keys2[pos]
                '''for z in range(len(keys2)):
                    if ord(i)==values2:
                        decstr=decstr+chr(values2)'''
            else:
                decstr=decstr+chr(ord(i)-k-5000)
    return decstr
'''s="BinodKumarThakur@2*(^^>?><?><"":"
k=0
print("Encapsulated:   ",Encryption(s,k))
print("Decapsulated:   ",decryption(k))'''
print("Enter the encrypted number:")
k=int(input())
f1=open("p1.txt","r",encoding="utf-8")
f2=open("p2.txt","w",encoding="utf-8")
#f3=open("p3.txt","w",encoding="utf-8")
arr=[]
#ap=[]
file1=f1.read().split('\n')
for i in file1:
    arr.append(Encryption(i,k))
    s=arr.pop()
    f2.write(s)
    f2.write('\n')

f1.close()
'''for i in arr:
    f2.write(i)
    f2.write('\n')'''
f2.close()
'''f2=open("p2.txt","r",encoding="utf-8")
f3=open("p3.txt","w",encoding="utf-8")
file2=f2.read().split('\n')
for i in file2:
    word=i
    #print(word)
    #print(decryption(word,k))
    ap.append(decryption(word,k))
f2.close()
for i in ap:
    f3.write(i)
    f3.write('\n')
f3.close()'''



