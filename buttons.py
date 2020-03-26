from tkinter import *
root=Tk()
root.title("buttons")
e=Entry(root,width=35,borderwidth=4)
e.grid(row=0,column=0,padx=10,pady=10)
def click(number):
    cur=e.get()
    e.delete(0,END)
    e.insert(0,str(cur)+str(number))
b1=Button(root,text="1",padx=10,pady=10,command=lambda:click(1))
b1.grid(row=1,column=0,padx=10,pady=10)
root.mainloop()