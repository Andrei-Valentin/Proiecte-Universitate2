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
from tkinter.ttk import Combobox
from tkinter.filedialog import askopenfilename 
from PIL import ImageTk, Image
import os
from algoritmi import *



def program(Dataset, configuratie, algoritm, norma, k, path_poza):
    OptiuniAlgoritmi = ["NN", "kNN", "EIG", "EIGC", "Lanczos"]
    Algoritm = OptiuniAlgoritmi[algoritm-1]
    
    

     #Crearea matricei de antrenare
    OptiuneAntrenare = configuratie
    
    if OptiuneAntrenare == 1:
      nrPozeAntrenare = 6 # de aici trebuie modificata matricea de antrenare
    elif OptiuneAntrenare == 2:
      nrPozeAntrenare = 8
    elif OptiuneAntrenare == 3:
      nrPozeAntrenare = 9
    A = np.zeros([10304, 40 * nrPozeAntrenare])
    
    index = 0
    pathSursa= r"C:\Users\Andrei\.spyder-py3\BazaDeDate"
    
    
    for i in range(1, 41):
      pathPersoane = pathSursa +"\s" + str(i) + "\\"
      for j in range(1, nrPozeAntrenare + 1):
        pathPozaAntrenare = pathPersoane + str(j) + '.pgm'
        # citim poza ca matrice 112 x 92:
        pozaAntrenare = np.array(cv2.imread(pathPozaAntrenare,0))
        # vectorizam poza:
        pozaVect = pozaAntrenare.reshape(10304,)
        A[:,index] = pozaVect
        index = index + 1   
    
    
    pozaTest = (np.array(cv2.imread(path_poza,0))).reshape(10304,)
    
    if(Algoritm == "NN"):
        predictie = AlgoritmulNN(A, pozaTest , norma)
    elif(Algoritm == "kNN"):
        predictie = AlgoritmulkNN(A, pozaTest , norma, k)
    elif(Algoritm == "EIG"):
        predictie = Eigenfaces(A, pozaTest , norma, k)
    elif(Algoritm == "EIGC"):
        predictie = EigenfacesClase(A, pozaTest , norma, k)
    elif(Algoritm == "Lanczos"):
        predictie = Lanczos(A, pozaTest , norma, k)


    return predictie