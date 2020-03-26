from tkinter import *
root=Tk()
e=Entry(root,width=40,bg="black",fg="white",borderwidth=5)
#e.pack()
e.grid(row=0,column=0,columnspan=3,padx=10,pady=10)
#to give default value to text field
e.insert(0,"Enter the file name")

#s=DISABLED
x=Label(root,text="Gargoyle")
myLabe2=Label(root,text=e.get())
def click():
    p=Label(root,text="File name is:"+e.get())
    #p.grid(row=4,column=4)
    p.pack()
#myLabel.pack()
##x.grid(row=0,column=0)
#myLabe2.grid(row=1,column=1)
#b=Button(root,text="click",state=s,padx=40,pady=40)
b=Button(root,text="Enter the name of the file",padx=40,pady=40,command=click,fg="white",bg="black")
b.pack()
root.mainloop()
