import PyPDF2
pdffileobj=open('Prajwal_Krishna.pdf','rb')
pdfreader=PyPDF2.PdfFileReader(pdffileobj)
x=pdfreader.numPages
pageobj=pdfreader.getPage(x-1)
text=pageobj.extractText()
file1=open("1.txt","w",encoding='UTF-8')
file1.writelines(text)
file1.close()