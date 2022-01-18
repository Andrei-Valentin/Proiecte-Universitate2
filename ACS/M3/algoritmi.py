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

def AlgoritmulNN(A, pozaCautata, norma):
  distante = np.zeros(len(A[0]))

  if(norma == "L1"):
    for i in range(0,len(distante)):
      distante[i] = np.linalg.norm((A[:,i]-pozaCautata), ord=1)

  elif(norma == "L2"):
    for i in range(0,len(distante)):
      distante[i] = la.norm(A[:,i]-pozaCautata)

  elif(norma == "LINF"):
    for i in range(0,len(distante)):
      distante[i] = np.linalg.norm((A[:,i]-pozaCautata), ord=np.inf)

  elif(norma == "LCOS"):
    for i in range(0,len(distante)):
      distante[i] = 1 - np.inner(A[:,i], pozaCautata)/(norm(A[:,i])*norm(pozaCautata))

  else:
    print("Nume norma incorect. Incercati L1, L2, LINF sau LCOS")
    return -1
    

  pozitia = np.argmin(distante) # returneaza indicele la care se afla cea mai mica distanta
  
  return pozitia # pozitia la care se afla imaginea gasita



#Algoritmul kNN

def AlgoritmulkNN(A, pozaCautata, norma, k):
  distante = np.zeros(len(A[0]))

  if(norma == "L1"):
    for i in range(0,len(distante)):
      distante[i] = np.linalg.norm((A[:,i]-pozaCautata), ord=1)

  elif(norma == "L2"):
    for i in range(0,len(distante)):
      distante[i] = la.norm(A[:,i]-pozaCautata)

  elif(norma == "LINF"):
    for i in range(0,len(distante)):
      distante[i] = np.linalg.norm((A[:,i]-pozaCautata), ord=np.inf)

  elif(norma == "LCOS"):
    for i in range(0,len(distante)):
      distante[i] = 1 - np.inner(A[:,i], pozaCautata)/(norm(A[:,i])*norm(pozaCautata))

  else:
    print("Nume norma incorect. Incercati L1, L2, LINF sau LCOS")
    return -1


  vector_pozitii = np.argsort(distante) # returneaza indicii la care se afla distantele cele mai mici (care au fost ordonate crescator)
  vector_pozitii = vector_pozitii[:k]

  print("Pozitiile imaginilor cu distantele cele mai mici:")
  print(vector_pozitii)
  print("Persoana din pozele respective:")
  print(vector_pozitii//nrPozeAntrenare+1)
  print()

  aparitii_clase = Counter(vector_pozitii//nrPozeAntrenare)
  predictie_knn = aparitii_clase.most_common(1)[0][0]*nrPozeAntrenare
  
  return predictie_knn # pozitia la care se afla prima imagine a persoanei gasite


def Eigenfaces(A, pozaCautata, norma, k):
  ###Preprocesare
  global timp_preproc
  global timp_cautare

  timp_start = time.perf_counter()

  media = np.mean(A, axis = 1) 

  A = (A.T - media).T

  L = np.dot(A.T, A)

  d, v = np.linalg.eig(L)

  v = np.dot(A, v)


  indici = np.argsort(d) 

  top_k_indici = indici[::-1][:k]

  HQPB = v[:,top_k_indici]


  proiectii = np.dot(A.T, HQPB)

  timp_fin = time.perf_counter()
  timp_preproc = timp_fin - timp_start # timpul scurs (durata preprocesarii)

  ###Interogare/Cautare
  timp_start = time.perf_counter()

  pozaCautata = pozaCautata - media

  pr_pozaCautata = np.dot(pozaCautata, HQPB)

  rezultat_EIG = AlgoritmulNN(proiectii.T, pr_pozaCautata , norma)

  timp_fin = time.perf_counter()
  timp_cautare = timp_fin - timp_start # timpul scurs (durata cautarii)

  return rezultat_EIG




def EigenfacesClase(A, pozaCautata, norma, k):
  ###Preprocesare
  global timp_preproc
  global timp_cautare

  timp_start = time.perf_counter()

  media = np.mean(A, axis = 1) 

  #Crearea tabloului RC
  RC = np.zeros([10304,40])

  for i in range(0,40):
    poze_persoana = np.zeros([10304, nrPozeAntrenare])
    for j in range(0,nrPozeAntrenare):
      poze_persoana[:,j] = A[:, i*nrPozeAntrenare + j]
    RC[:,i] = A[:, i*nrPozeAntrenare + random.randint(1, nrPozeAntrenare-1)]

  RC = (RC.T - media).T

  L = np.dot(RC.T, RC)

  d, v = np.linalg.eig(L)
  v = np.dot(RC, v)


  indici = np.argsort(d) 

  top_k_indici = indici[::-1][:k]

  HQPB = v[:,top_k_indici]

  proiectii = np.dot(RC.T, HQPB)

  timp_fin = time.perf_counter()
  timp_preproc = timp_fin - timp_start # timpul scurs (durata preprocesarii)

  ###Interogare/Cautare
  timp_start = time.perf_counter()

  pozaCautata = pozaCautata - media

  pr_pozaCautata = np.dot(pozaCautata, HQPB)

  rezultat_EIGC = AlgoritmulNN(proiectii.T, pr_pozaCautata , norma)

  timp_fin = time.perf_counter()
  timp_cautare = timp_fin - timp_start # timpul scurs (durata cautarii)

  return rezultat_EIGC


def Lanczos(A, pozaCautata, norma, k):
  global timp_preproc
  global timp_cautare

  #Preprocesare
  timp_start = time.perf_counter()

  media = np.mean(A, axis = 1)
  m = 10304
  q = np.zeros([m, k+2])
  q[:,0]=np.zeros(m)
  q[:,1]=np.ones(m)
  q[:,1]=q[:,1]/la.norm(q[:,1])

  for i in range(1,k+1):
    w = np.dot(A, np.dot(A.T, q[:,i])) - np.dot(la.norm(q[:,i-1]),q[:,i-1])
    a = np.dot(w, q[:,i])
    w = w - np.dot(a,q[:,i])
    q[:,i+1]=w/la.norm(q[:,i])

  HQPB = q[:,2:]

  timp_fin = time.perf_counter()
  timp_preproc = timp_fin - timp_start # timpul scurs (durata preprocesarii)


  #Cautare 
  timp_start = time.perf_counter()

  proiectii = np.dot(A.T, HQPB)

  pozaCautata = pozaCautata - media

  pr_pozaCautata = np.dot(pozaCautata, HQPB)

  rezultat_Lanczos = AlgoritmulNN(proiectii.T, pr_pozaCautata , norma)

  timp_fin = time.perf_counter()
  timp_cautare = timp_fin - timp_start # timpul scurs (durata cautarii)
  return rezultat_Lanczos