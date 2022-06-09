import numpy as np
import matplotlib.pyplot as plt
import pandas as pd

from sklearn import datasets, linear_model
from sklearn.linear_model import LinearRegression
from sklearn.metrics import mean_squared_error, r2_score, mean_absolute_error
from sklearn.preprocessing import PolynomialFeatures
from sklearn import metrics

from mpl_toolkits.mplot3d import Axes3D



date = pd.read_csv(r'bd_regresie_tema1.csv', usecols=['bodyfat', 'age', 'cest', 'hip', 'forearm'])
print(date.shape)
print(date.describe())
print()

t1 = date['bodyfat'] 
t2 = date['age']
t3 = date['cest']
t4 = date['hip']

b = date['forearm']

m = len(date)

T = np.ones((m,1))
T = np.insert(T, 1, t1, axis=-1)
T = np.insert(T, 1, t2, axis=-1)
T = np.insert(T, 1, t3, axis=1)
T = np.insert(T, 1, t4, axis=1)




# Regresie liniara
lin = LinearRegression()
lin.fit(T,b)

b_prediction =  lin.predict(T)

eroare = metrics.mean_squared_error(b, b_prediction)*m
print("Pentru regresia liniara:")
print('SSE:', eroare)
print('MAE:', mean_absolute_error(b,b_prediction))
print('MSE:', mean_squared_error(b,b_prediction))
print('RMSE:', np.sqrt(mean_squared_error(b,b_prediction)))
print('R^2:', r2_score(b,b_prediction))
print()


# Regresie Polinomiala 
poly = PolynomialFeatures(degree = 4)
t_poly = poly.fit_transform(T)
poly.fit(t_poly, b)

lin2 = LinearRegression()
lin2.fit(t_poly, b)

b_prediction = lin2.predict(poly.fit_transform(T))


eroare = metrics.mean_squared_error(b, b_prediction)*m
print("Pentru regresia polinomiala:")
print('SSE:', eroare)
print('MAE:', mean_absolute_error(b,b_prediction))
print('MSE:', mean_squared_error(b,b_prediction))
print('RMSE:', np.sqrt(mean_squared_error(b,b_prediction)))
print('R^2:', r2_score(b,b_prediction))

fig = plt.figure()
ax = plt.axes(projection='3d')
#ax.scatter3D(t1,t1, t2, t3, t4, b)
#t1_plt = np.linspace(np.min(t1), np.max(t1),50)
#t2_plt = np.linspace(np.min(t2), np.max(t2),50)
#t3_plt = np.linspace(np.min(t3), np.max(t3),50)
#t4_plt = np.linspace(np.min(t4), np.max(t4),50)
#X, Y = np.meshgrid(t1_plt, t2_plt, t3_plt, t4_plt)
#coefs = np.hstack((lin2.intercept_, lin2.coef_[0,:]))
#b_pred_plt = place(X, Y, coefs)
#ax.plot_surface(X, Y, b_pred_plt, rstride=1, cstride=1, cmap='viridis', edgecolor='none')
#ax.set_title('Regresie surface')
#ax.view_init(60, 35)#cota de 60 grade(pe plan x-y) si 35 grade azimuth


