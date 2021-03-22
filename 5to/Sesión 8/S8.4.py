""" 
Problema Propuesto:

Disponer dos objetos de la clase Button con las etiquetas: "varón" y "mujer", al presionarse
mostrar en la barra de títulos de la ventana la etiqueta del botón presionado.
"""
import tkinter as tk


class Aplicacion:
    def __init__(self):
        self.ventana1 = tk.Tk()
        self.ventana1.title("Problema Propuesto")
        self.seleccion = tk.IntVar()
        self.seleccion.set(2)
        self.radio1 = tk.Radiobutton(
            self.ventana1, text="Varon", variable=self.seleccion, value=1, command=self.mostrarseleccionado)
        self.radio1.grid(column=0, row=0)
        self.radio2 = tk.Radiobutton(
            self.ventana1, text="Mujer", variable=self.seleccion, value=2, command=self.mostrarseleccionado)
        self.radio2.grid(column=1, row=0)
        self.ventana1.mainloop()

    def mostrarseleccionado(self):
        if self.seleccion.get() == 1:
            self.ventana1.title("Varon")
        if self.seleccion.get() == 2:
            self.ventana1.title("Mujer")


aplicacion1 = Aplicacion()
