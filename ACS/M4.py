import cv2 as cv
import numpy as np
import matplotlib
from matplotlib import pyplot as plt
from collections import Counter
import time
import os
from tkinter import ttk
from tkinter import *
from tkinter.filedialog import askopenfilename 
from PIL import ImageTk, Image

global poza
global poza_originala
poza = None
poza_originala = None

window = Tk()


def open_file():
    global file_path
    global poza
    global poza_originala
    file_path = askopenfilename(filetypes=[('Image Files', '*jpg')])
    if file_path is not None:
    #path.set(file_path)
        poza = cv.imread(file_path)
        b,g,r = cv.split(poza)
        poza = cv.merge((r,g,b))
        poza_originala = poza

        imagine = Image.open(file_path)
        imagine = imagine.resize((300, 300), Image.ANTIALIAS)
        imagine = ImageTk.PhotoImage(imagine)
        
        img = Label(window, image = imagine)
        img.image = imagine
        img.place(relx=.3, y = 275, anchor="center")
         
        Label(window, text='Imaginea a fost incarcata cu succes!', foreground='green').place(relx=.3, y = 550, anchor="center")
        lbl=Label(window, text="IMAGINE ORIGINALA", fg='black', font=("Helvetica", 16))
        lbl.place(relx=.3, y = 100, anchor="center")

        lbl=Label(window, text="IMAGINE PROCESATA", fg='black', font=("Helvetica", 16))
        lbl.place(relx=.7, y = 100, anchor="center")
        
      
        
def reset():
    global poza
    if(poza) is not None:
        poza = poza_originala
        
        im = Image.fromarray(poza)
        im = im.resize((300, 300), Image.ANTIALIAS)
        imgtk = ImageTk.PhotoImage(image=im) 
        
        imgFlip = Label(window, image = imgtk)
        imgFlip.image = imgtk
        imgFlip.place(relx=.7, y = 275, anchor="center")
    else:
        messagebox.showerror("Eroare", "Trebuie mai intai sa incarcati o imagine")
        


def salvare():
    global poza
    if(poza) is not None:
        if(len(poza.shape)<3):
            cv.imwrite('poza_procesata.jpg', poza)
        else:
            rs,gs,bs = cv.split(poza)
            
            pozas = cv.merge((bs,gs,rs))
            
            cv.imwrite('poza_procesata.jpg', pozas)
            
        Label(window, text='Imaginea a fost salvata cu succes!', foreground='green').place(relx=.7, y = 550, anchor="center")
    else:
        messagebox.showerror("Eroare", "Trebuie mai intai sa incarcati o imagine")
        
 

       
        
def text():
    global poza
    if(poza) is not None:
        inaltime, lungime = poza.shape[:2]
        cerc = np.zeros((inaltime, lungime), np.uint8)
        inaltime2 = int(inaltime * 0.95)
        lungime2 = int(lungime * 0.05)
        
        text = enter1.get()
        pozaCopie = poza
        
        pozaText = cv.putText(pozaCopie, text , (lungime2,inaltime2), cv.FONT_HERSHEY_SIMPLEX, 
                   int(min(inaltime,lungime)* 0.005), (252, 183, 98), 4, cv.LINE_AA)
        
        poza = pozaText
        
        im = Image.fromarray(pozaText)
        im = im.resize((300, 300), Image.ANTIALIAS)
        imgtk = ImageTk.PhotoImage(image=im) 
        
        imgFlip = Label(window, image = imgtk)
        imgFlip.image = imgtk
        imgFlip.place(relx=.7, y = 275, anchor="center")    
    else:
        messagebox.showerror("Eroare", "Trebuie mai intai sa incarcati o imagine")
    
    
    
def oglindire():
    global poza
    if(poza) is not None:
        pozaFlip = cv.flip(poza,1)
        
        poza = pozaFlip
        
        im = Image.fromarray(pozaFlip)
        im = im.resize((300, 300), Image.ANTIALIAS)
        imgtk = ImageTk.PhotoImage(image=im) 
        
        imgFlip = Label(window, image = imgtk)
        imgFlip.image = imgtk
        imgFlip.place(relx=.7, y = 275, anchor="center")
    else:
        messagebox.showerror("Eroare", "Trebuie mai intai sa incarcati o imagine")
        
        
        
def detectieMuchii():
    global poza
    if(poza) is not None:
        pozaGray = cv.cvtColor(poza, cv.COLOR_BGR2GRAY)
        pozaBlur = cv.GaussianBlur(pozaGray, (25,25), cv.BORDER_DEFAULT)
        pozaContur = cv.Canny(pozaBlur, threshold1 = 5, threshold2 = 25)
        
        poza = pozaContur
        
        im = Image.fromarray(pozaContur)
        im = im.resize((300, 300), Image.ANTIALIAS)
        imgtk = ImageTk.PhotoImage(image=im) 
        
        imgFlip = Label(window, image = imgtk)
        imgFlip.image = imgtk
        imgFlip.place(relx=.7, y = 275, anchor="center")
    else:
        messagebox.showerror("Eroare", "Trebuie mai intai sa incarcati o imagine")
        
        

def thresholding():
    global poza
    if(poza) is not None:
        pozaGray = cv.cvtColor(poza, cv.COLOR_BGR2GRAY)
        pozaThreshold = cv.threshold(pozaGray,25,255,cv.THRESH_BINARY)
        
        poza = pozaThreshold
        
        im = Image.fromarray(pozaThreshold)
        im = im.resize((300, 300), Image.ANTIALIAS)
        imgtk = ImageTk.PhotoImage(image=im) 
        
        imgFlip = Label(window, image = imgtk)
        imgFlip.image = imgtk
        imgFlip.place(relx=.7, y = 275, anchor="center")
    else:
        messagebox.showerror("Eroare", "Trebuie mai intai sa incarcati o imagine")



def border():
    global poza
    if(poza) is not None:
        pozaBorder = cv.copyMakeBorder(poza, 10, 10, 10, 10, cv.BORDER_CONSTANT, value = (252, 183, 98))
        
        poza = pozaBorder
        
        im = Image.fromarray(pozaBorder)
        im = im.resize((300, 300), Image.ANTIALIAS)
        imgtk = ImageTk.PhotoImage(image=im) 
        
        imgFlip = Label(window, image = imgtk)
        imgFlip.image = imgtk
        imgFlip.place(relx=.7, y = 275, anchor="center")
    else:
        messagebox.showerror("Eroare", "Trebuie mai intai sa incarcati o imagine")
        
        
        
def filtruCutie():
    global poza
    if(poza) is not None:
        pozaFiltruCutie = cv.boxFilter(poza, ddepth = -1, ksize = (10,10), normalize = True)
        
        poza = pozaFiltruCutie
        
        im = Image.fromarray(pozaFiltruCutie)
        im = im.resize((300, 300), Image.ANTIALIAS)
        imgtk = ImageTk.PhotoImage(image=im) 
        
        imgFlip = Label(window, image = imgtk)
        imgFlip.image = imgtk
        imgFlip.place(relx=.7, y = 275, anchor="center")
    else:
        messagebox.showerror("Eroare", "Trebuie mai intai sa incarcati o imagine")
      
        
        
def decupareCerc():
    global poza
    if(poza) is not None:
        inaltime, lungime = poza.shape[:2]
        cerc = np.zeros((inaltime, lungime), np.uint8)
        inaltime2 = int(inaltime // 2)
        lungime2 = int(lungime // 2)
        cerc = cv.circle(cerc, (lungime2, inaltime2), int(0.4*min(lungime,inaltime)) , (255,255,255), -1)
        pozaMascaCerc = cv.bitwise_and(poza, poza, mask = cerc)
        
        poza = pozaMascaCerc
        
        im = Image.fromarray(pozaMascaCerc)
        im = im.resize((300, 300), Image.ANTIALIAS)
        imgtk = ImageTk.PhotoImage(image=im) 
        
        imgFlip = Label(window, image = imgtk)
        imgFlip.image = imgtk
        imgFlip.place(relx=.7, y = 275, anchor="center")
    else:
        messagebox.showerror("Eroare", "Trebuie mai intai sa incarcati o imagine")
      
        

def histograma():
    global poza
    if(poza) is not None:
        r, g, b = poza[:,:,0], poza[:,:,1], poza[:,:,2]
        
        hist_b = cv.calcHist([b],[0],None,[256],[0,256])
        hist_g = cv.calcHist([g],[0],None,[256],[0,256])
        hist_r = cv.calcHist([r],[0],None,[256],[0,256])
        plt.plot(hist_r, color='r', label="r")
        plt.plot(hist_g, color='g', label="g")
        plt.plot(hist_b, color='b', label="b")
        plt.legend()
        plt.savefig("histograma.png")
        plt.close()
        
    else:
        messagebox.showerror("Eroare", "Trebuie mai intai sa incarcati o imagine")
        


def sift():
    global poza
    if(poza) is not None:
        cv.SIFT_create()
        pozaGray = cv.cvtColor(poza, cv.COLOR_BGR2GRAY)
        keypoints = cv.detect(poza, None)
        pozaSift = cv.drawKeypoints(pozaGray, keypoints, poza)
        
        poza = pozaSift
        
        im = Image.fromarray(pozaSift)
        im = im.resize((300, 300), Image.ANTIALIAS)
        imgtk = ImageTk.PhotoImage(image=im) 
        
        imgFlip = Label(window, image = imgtk)
        imgFlip.image = imgtk
        imgFlip.place(relx=.7, y = 275, anchor="center")
    else:
        messagebox.showerror("Eroare", "Trebuie mai intai sa incarcati o imagine")





lbl=Label(window, text="APLICATIE DE PROCESARE IMAGINI", fg='black', font=("Helvetica", 32))
lbl.place(relx=.5, y = 50, anchor="center")



butonAlegere = Button(window, text ='Alege imagine', fg='white', bg = '#f5a442', command = lambda:open_file(), width = 16, height = 2) 
butonAlegere.bind("<Enter>", lambda e: butonAlegere.config(fg='#caf0f8', bg='#fcb762'))
butonAlegere.bind("<Leave>", lambda e: butonAlegere.config(fg='white', bg='#f5a442'))
butonAlegere.place(relx=.3, y = 500, anchor="center")



butonReset = Button(window, text ='Resetare imagine', fg='white', bg = '#f5a442', command = lambda:reset(), width = 16, height = 2) 
butonReset.bind("<Enter>", lambda e: butonReset.config(fg='#caf0f8', bg='#fcb762'))
butonReset.bind("<Leave>", lambda e: butonReset.config(fg='white', bg='#f5a442'))
butonReset.place(relx=.5, y = 500, anchor="center")



butonSave = Button(window, text ='Salvare imagine', fg='white', bg = '#f5a442', command = lambda:salvare(), width = 16, height = 2) 
butonSave.bind("<Enter>", lambda e: butonSave.config(fg='#caf0f8', bg='#fcb762'))
butonSave.bind("<Leave>", lambda e: butonSave.config(fg='white', bg='#f5a442'))
butonSave.place(relx=.7, y = 500, anchor="center")







butonOglindire = Button(window, text ='Oglindire imagine', fg='white', bg = '#f5a442', command = lambda:oglindire(), width = 16, height = 2) 
butonOglindire.bind("<Enter>", lambda e: butonOglindire.config(fg='#caf0f8', bg='#fcb762'))
butonOglindire.bind("<Leave>", lambda e: butonOglindire.config(fg='white', bg='#f5a442'))
butonOglindire.place(relx=.075, y = 125, anchor="center")



butonBorder = Button(window, text ='Adaugare border', fg='white', bg = '#f5a442', command = lambda:border(), width = 16, height = 2) 
butonBorder.bind("<Enter>", lambda e: butonBorder.config(fg='#caf0f8', bg='#fcb762'))
butonBorder.bind("<Leave>", lambda e: butonBorder.config(fg='white', bg='#f5a442'))
butonBorder.place(relx=.075, y = 175, anchor="center")



butonFCutie = Button(window, text ='Filtru cutie', fg='white', bg = '#f5a442', command = lambda:filtruCutie(), width = 16, height = 2) 
butonFCutie.bind("<Enter>", lambda e: butonFCutie.config(fg='#caf0f8', bg='#fcb762'))
butonFCutie.bind("<Leave>", lambda e: butonFCutie.config(fg='white', bg='#f5a442'))
butonFCutie.place(relx=.075, y = 225, anchor="center")



butonMasca = Button(window, text ='Masca cerc', fg='white', bg = '#f5a442', command = lambda:decupareCerc(), width = 16, height = 2) 
butonMasca.bind("<Enter>", lambda e: butonMasca.config(fg='#caf0f8', bg='#fcb762'))
butonMasca.bind("<Leave>", lambda e: butonMasca.config(fg='white', bg='#f5a442'))
butonMasca.place(relx=.075, y = 275, anchor="center")



butonKeypoints = Button(window, text ='Desenare keypoints', fg='white', bg = '#f5a442', command = lambda:sift(), width = 16, height = 2) 
butonKeypoints.bind("<Enter>", lambda e: butonKeypoints.config(fg='#caf0f8', bg='#fcb762'))
butonKeypoints.bind("<Leave>", lambda e: butonKeypoints.config(fg='white', bg='#f5a442'))
butonKeypoints.place(relx=.075, y = 325, anchor="center")






butonDetectieMuchii = Button(window, text ='Detectare muchii', fg='white', bg = '#f5a442', command = lambda:detectieMuchii(), width = 16, height = 2) 
butonDetectieMuchii.bind("<Enter>", lambda e: butonDetectieMuchii.config(fg='#caf0f8', bg='#fcb762'))
butonDetectieMuchii.bind("<Leave>", lambda e: butonDetectieMuchii.config(fg='white', bg='#f5a442'))
butonDetectieMuchii.place(relx=.925, y = 125, anchor="center")



butonThresholding = Button(window, text ='Thresholding', fg='white', bg = '#f5a442', command = lambda:thresholding(), width = 16, height = 2) 
butonThresholding.bind("<Enter>", lambda e: butonThresholding.config(fg='#caf0f8', bg='#fcb762'))
butonThresholding.bind("<Leave>", lambda e: butonThresholding.config(fg='white', bg='#f5a442'))
butonThresholding.place(relx=.925, y = 175, anchor="center")



butonHistograma = Button(window, text ='Histograma RGB', fg='white', bg = '#f5a442', command = lambda:histograma(), width = 16, height = 2) 
butonHistograma.bind("<Enter>", lambda e: butonHistograma.config(fg='#caf0f8', bg='#fcb762'))
butonHistograma.bind("<Leave>", lambda e: butonHistograma.config(fg='white', bg='#f5a442'))
butonHistograma.place(relx=.925, y = 225, anchor="center")


Label(window, text="Adaugare text").place(relx=.925, y = 275, anchor="center")
enter1 = Entry(window)
enter1.place(relx=.925, y = 300, anchor="center")

butonText = Button(window, text ='Enter', fg='white', bg = '#f5a442', command = lambda:text(), width = 12, height = 1) 
butonText.bind("<Enter>", lambda e: butonText.config(fg='#caf0f8', bg='#fcb762'))
butonText.bind("<Leave>", lambda e: butonText.config(fg='white', bg='#f5a442'))
butonText.place(relx=.925, y = 335, anchor="center")



window.title('Aplicatie procesare imagini')
window.geometry("1100x700+10+10")
window.iconbitmap(r'C:\Users\Andrei\Documents\Cultura\ANUL III UNIVERSITATEA OVIDIUS\ALGORITMI STINTIFICI\Proiecte\Tema 4\iconita.ico')
window.mainloop()