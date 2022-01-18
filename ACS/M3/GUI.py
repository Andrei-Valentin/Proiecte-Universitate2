import cv2
import statistics as st
import numpy as np
from numpy import dot
from numpy import linalg as la
from numpy.linalg import norm
import matplotlib
from matplotlib import pyplot as plt
from collections import Counter
import time
import os
from tkinter import *
from tkinter.ttk import *
from tkinter.ttk import Combobox
from tkinter.filedialog import askopenfilename 
from PIL import ImageTk, Image
import os
from algoritmi import *
from Program import program

window = Tk()

BD=StringVar()
BD.set("ORL")

alg=IntVar()
alg.set(1)

config=IntVar()
config.set(2)

norma=IntVar()
norma.set(1)

path = StringVar()
path.set("")

def open_file():
    global file_path
    file_path = askopenfilename(filetypes=[('Image Files', '*pgm')])
    if file_path is not None:
        #path.set(file_path)
        imagine = Image.open(file_path)
        imagine = imagine.resize((300, 300), Image.ANTIALIAS)
        imagine = ImageTk.PhotoImage(imagine)
        
        img = Label(window, image = imagine)
        img.image = imagine
        img.place(x=400,y=150)
        
        Label(window, text='Imaginea a fost incarcata cu succes!', foreground='green').place(x=560,y=610)

def cautare():
    bd = BD.get()
    configuratie = config.get()
    algoritm = alg.get()
    norm = norma.get()
    path_poza = file_path
    if cb1.get():
        k = cb1.get()
    if cb2.get():
        k = cb2.get()
    
    predictie = program(bd, configuratie, algoritm, norm, k, path_poza)
    print(predictie)
    
    imagine1 = Image.open(r"C:\Users\Andrei\.spyder-py3\BazaDeDate\s" + str(predictie//8+1) + "\\" + str(predictie%8+1) + ".pgm")
    imagine1 = imagine1.resize((300, 300), Image.ANTIALIAS)
    imagine1 = ImageTk.PhotoImage(imagine1)
    
    img1 = Label(window, image = imagine1)
    img1.image = imagine1
    img1.place(x=750,y=150)
    
    
    

 
    
    
imagine = Image.open(r"C:\Users\Andrei\.spyder-py3\bg5.png")
imagine = imagine.resize((1100, 700), Image.ANTIALIAS)
imagine = ImageTk.PhotoImage(imagine)

img = Label(window, image = imagine)
img.image = imagine
img.place(x=0,y=0)

    
    


lbl=Label(window, text="BAZA DE DATE", fg='black', font=("Helvetica", 16))
lbl.place(x=60, y=30)


r1=Radiobutton(window, text="ORL", variable=BD,value= "ORL")
r1.place(x=60,y=80)


lbl=Label(window, text="CONFIGURATIE ANTRENARE", fg='black', font=("Helvetica", 16))
lbl.place(x=60, y=130)


r1cfg=Radiobutton(window, text="60%-40%", variable=config,value=1)
r1cfg.place(x=60,y=180)
r2cfg=Radiobutton(window, text="80%-20%", variable=config,value=2)
r2cfg.place(x=160,y=180)
r3cfg=Radiobutton(window, text="90%-10%", variable=config,value=3)
r3cfg.place(x=260,y=180)


lbl=Label(window, text="ALGORITM", fg='black', font=("Helvetica", 16))
lbl.place(x=60, y=230)


r1alg=Radiobutton(window, text="NN", variable=alg,value=1)
r1alg.place(x=60,y=280)
r2alg=Radiobutton(window, text="kNN", variable=alg,value=2)
r2alg.place(x=60,y=310)

valoriK=(3, 5, 7, 9)
cb1 = Combobox(window, state="readonly", values = valoriK, width = 5)
cb1.place(x=120, y=312)



lbtxt=Label(window, text="K pentru algoritmii proiectivi", fg='black', font=("Helvetica", 11))
lbtxt.place(x=60, y=340)

valoriK=(20, 40, 60, 80, 100)
cb2 = Combobox(window, state="readonly", values = valoriK, width = 5)
cb2.place(x=250, y=342)

r3alg=Radiobutton(window, text="Eigenfaces", variable=alg,value=3)
r3alg.place(x=60,y=370)

r4alg=Radiobutton(window, text="Eigenfaces cu reprezentanti", variable=alg,value=4)
r4alg.place(x=60,y=400)
r5alg=Radiobutton(window, text="Lanczos", variable=alg,value=5)
r5alg.place(x=60,y=430)

lbl=Label(window, text="NORMA", fg='black', font=("Helvetica", 16))
lbl.place(x=60, y=470)


r1nrm=Radiobutton(window, text="Manhattan", variable=norma,value=1)
r1nrm.place(x=60,y=510)
r2nrm=Radiobutton(window, text="Euclidiana", variable=norma,value=2)
r2nrm.place(x=60,y=540)
r3nrm=Radiobutton(window, text="Infinit", variable=norma,value=3)
r3nrm.place(x=60,y=570)
r4nrm=Radiobutton(window, text="Cos", variable=norma,value=4)
r4nrm.place(x=60,y=600)


labelIncarcare = Label(window, text='Incarcare imagine', font=("Helvetica", 12))
labelIncarcare.grid(row=0, column=0, padx=10)
labelIncarcare.place(x=590,y=550)

btn=Button(window, text="Cautare", fg='blue', bg = '#8aa5cf' , command = lambda:cautare(), width = 12)
btn.bind("<Enter>", lambda e: btn.config(fg='#caf0f8', bg='#03045e'))
btn.bind("<Leave>", lambda e: btn.config(fg='blue', bg='#8aa5cf'))
btn.place(x=660, y=580)


butonAlegere = Button(window, text ='Alege imagine', fg='blue', bg = '#8aa5cf', command = lambda:open_file(), width = 12) 
butonAlegere.bind("<Enter>", lambda e: butonAlegere.config(fg='#caf0f8', bg='#03045e'))
butonAlegere.bind("<Leave>", lambda e: butonAlegere.config(fg='blue', bg='#8aa5cf'))
butonAlegere.place(x=560,y=580)



window.title('Interfata algoritmi')
window.geometry("1100x700+10+10")
window.mainloop()
