"""
Disponer tres controles de tipo Radiobutton con las etiquetas 'Rojo', 'Verde' y 'Azul'. Cuando se presione
un botón cambiar el color de fondo del formulario.
Si consideramos que la variable ventana1 es un objeto de la clase Tk, luego si queremos que el fondo sea de
color rojo debemos llamar al método configure y en el parámetro bg indicar un string con el color a activar
("red", "green" o "blue"):

APOYO
self.ventana1.configure(bg="red")
"""
import tkinter as tk


class Aplicacion:
    def __init__(self):
        self.ventana1 = tk.Tk()
        self.ventana1.title("Colores de Fondo")
        self.label = tk.Label(
            self.ventana1, text="Seecciona el color para el fondo:")
        self.label.grid(column=0, row=1)
        self.seleccion = tk.IntVar()
        self.radio1 = tk.Radiobutton(
            self.ventana1, text="Rojo", variable=self.seleccion, value=0)
        self.radio1.grid(column=0, row=2)
        self.radio2 = tk.Radiobutton(
            self.ventana1, text="Verde", variable=self.seleccion, value=1)
        self.radio2.grid(column=0, row=3)
        self.radio3 = tk.Radiobutton(
            self.ventana1, text="Azul", variable=self.seleccion, value=2)
        self.radio3.grid(column=0, row=4)
        self.boton1 = tk.Button(
            self.ventana1, text="Aplicar", command=self.cambiarFondo)
        self.boton1.grid(column=1, row=3)
        self.ventana1.mainloop()

    def cambiarFondo(self):
        colores = ["red", "green", "blue"]
        self.ventana1.configure(bg=colores[self.seleccion.get()])

        self.label.configure(bg=colores[self.seleccion.get()], fg="white")
        self.radio1.configure(bg=colores[self.seleccion.get()])
        self.radio2.configure(bg=colores[self.seleccion.get()])
        self.radio3.configure(bg=colores[self.seleccion.get()])
        self.boton1.configure(bg=colores[self.seleccion.get()], fg="white")


aplicacion1 = Aplicacion()
