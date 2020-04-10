import tkinter as tk
import try1
from tkinter import *
from tkinter.filedialog import askopenfilename
root=tk.Tk()
root.configure(background='black')
root.title("Python_Encryption")
root.geometry('1920x1080')
dummy=Label(root,text="",bg='black')
welcome=Label(root,text="WELCOME TO PYTHON ENCRYPTION",bg='black',fg='white',font=('Helvetica', 28, 'bold'))
welcome.pack()
for i in range(50):
    dummy.pack()
option1=Label(root,text="1.String encryption",bg='black',fg='yellow',font=('Helvetica', 18, 'bold'))
option1.pack()
string1=Entry(root,width=40,bg="black",fg="white",borderwidth=4)
string1.pack()
string1.insert(0,"Enter string to Encrypt")
key1=Entry(root,width=40,bg="black",fg="white",borderwidth=4)
key1.pack()
key1.insert(0,"Enter the encryption key")
def encrypted():
    s1=string1.get()
    k1=int(key1.get())
    return  try1.Encryption(s1,k1)
p=Label(root,text="",bg="black",fg="red",font=('Helvetica', 16, 'bold'))
p.pack()
def encryptres():
    #p=Label(root,text=encrypted(),bg="black",fg="red")
    #p.pack()
    p.config(text=encrypted(),fg="red")
def decryptres():
    s1=string1.get()
    k1=int(key1.get())
    res=try1.decryption(k1,4,s1)
    #p=Label(root,text=res,bg="black",fg="blue")
    #p.pack()
    p.config(text=res,fg="blue")
copied=""
def copy():
    global copied
    s1=string1.get()
    k1=int(key1.get())
    copied=try1.Encryption(s1,k1)
    print(copied)
    p.config(text="Encryption copied...You can use it to decrypt in option 2",fg="yellow")

frame = tk.Frame(root)
frame.pack()
encryptstring=Button(frame,text="Encrypt string",padx=10,pady=5,bg="black",fg="red",font=('Helvetica', 12, 'bold'),command=lambda:encryptres())
encryptstring.pack(side=tk.LEFT)
decryptstring=Button(frame,text="Decrypt string",padx=10,pady=5,bg="black",fg="blue",font=('Helvetica', 12, 'bold'),command=lambda:decryptres())
decryptstring.pack(side=tk.LEFT)
copystring=Button(frame,text="Copy encrypted string",padx=10,pady=5,bg="black",fg="yellow",font=('Helvetica', 12, 'bold'),command=lambda:copy())
copystring.pack(side=tk.LEFT)
dummy1=Label(root,text="",bg='black')
for i in range(30):
    dummy1.pack()
option2=Label(root,text="2.String decryption",bg='black',fg='orange',font=('Helvetica', 18, 'bold'))
option2.pack()
string2=Entry(root,width=40,bg="black",fg="white",borderwidth=4)
string2.pack()
string2.insert(0,"Enter string to Decrypt")
key2=Entry(root,width=40,bg="black",fg="white",borderwidth=4)
key2.pack()
key2.insert(0,"Enter the encryption key")
p1=Label(root,text="",bg="black",fg="red",font=('Helvetica', 16, 'bold'))
p1.pack()
def copied1():
    print(copied)
    string2.delete(0,END)
    string2.insert(0,str(copied1))
def result():
    s1=copied
    k1=int(key2.get())
    res=try1.decryption(k1,3,s1)
    p1.config(text=res,fg="white")
framed= tk.Frame(root)
framed.pack()
copydecrypt=Button(framed,text="Decrypt copied encrypted string",padx=10,pady=5,bg="black",fg="blue",font=('Helvetica', 12, 'bold'),command=lambda:copied1())
copydecrypt.pack(side=tk.LEFT)
decrypted=Button(framed,text="Decrypt",padx=10,pady=5,bg="black",fg="yellow",font=('Helvetica', 12, 'bold'),command=lambda:result())
decrypted.pack(side=tk.LEFT)

dummy2=Label(root,text="",bg='black')
for i in range(80):
    dummy2.pack()
option3=Label(root,text="File Encryption and Decryption",bg='black',fg='green',font=('Helvetica', 22, 'bold'))
option3.pack()
p2=Label(root,text="",bg="black",fg="red",font=('Helvetica', 16, 'bold'))
p2.pack()
fileframe=tk.Frame(root)
fileframe.pack()
fileenc=""
def choose():
    global fileenc
    fileenc= askopenfilename()
    p2.config(text=fileenc,fg="violet")
def encryptfile():
    f1=open(fileenc,"r",encoding="utf-8")
    file1=f1.read().split('\n')
    k=int(key3.get())
    f2=open("encrypted.txt","w",encoding="utf-8")
    arr=[]
    for i in file1:
        arr.append(try1.Encryption(i,k))
        s=arr.pop()
        f2.write(s)
        f2.write('\n')
    f1.close()
    f2.close()
    p2.config(text="File encrypted successfully encrypted.txt",fg='orange')    
def decryptfile():
    k=int(key3.get())
    f2=open("encrypted.txt","r",encoding="utf-8")
    f3=open("result.txt","w",encoding="utf-8")
    file2=f2.read().split('\n')
    for i in file2:
        x=try1.decryption(k,3,i)
        f3.write(x)
        f3.write('\n')
    f2.close()
    f3.close()
    p2.config(text="The file has been successfully decrypted in result.txt",fg='white')

key3=Entry(fileframe,width=98,bg="black",fg="white",borderwidth=4)
key3.pack()
key3.insert(0,"Enter the encryption key for the file")
choosefile=Button(fileframe,text="Choose file to encrypt/decrypt",padx=10,pady=5,bg="black",fg="orange",font=('Helvetica', 14, 'bold'),command=lambda:choose())
choosefile.pack(side=tk.LEFT)
encryptionfile=Button(fileframe,text="Encrypt file",padx=10,pady=5,bg="black",fg="green",font=('Helvetica', 14, 'bold'),command=lambda:encryptfile())
encryptionfile.pack(side=tk.LEFT)
decryptionfile=Button(fileframe,text="Decrypt file",padx=10,pady=5,bg="black",fg="blue",font=('Helvetica', 14, 'bold'),command=lambda:decryptfile())
decryptionfile.pack(side=tk.LEFT)

dummy3=Label(root,text="",bg='black')
for i in range(50):
    dummy3.pack()
button = tk.Button(root, text='Exit Program', width=50,bg="black",fg="red", command=root.destroy)
button.pack()
root.mainloop()
