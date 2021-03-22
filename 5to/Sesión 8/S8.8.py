import tkinter as tk


class Aplicacion:
    def __init__(self):
        self.ventana1 = tk.Tk()
        self.label1 = tk.Label(self.ventana1, text="Ingrese primer valor:")
        self.label1.grid(column=0, row=0)
        self.dato1 = tk.StringVar()
        self.entry1 = tk.Entry(self.ventana1, width=20,
                               textvariable=self.dato1)
        self.entry1.grid(column=1, row=0)
        self.label2 = tk.Label(self.ventana1, text="Ingrese segundo valor:")
        self.label2.grid(column=0, row=1)
        self.dato2 = tk.StringVar()
        self.entry2 = tk.Entry(self.ventana1, width=20,
                               textvariable=self.dato2)
        self.entry2.grid(column=1, row=1)
        self.seleccion = tk.IntVar()
        self.radio1 = tk.Radiobutton(
            self.ventana1, text="Sumar", variable=self.seleccion, value=1)
        self.radio1.grid(column=1, row=2)
        self.radio2 = tk.Radiobutton(
            self.ventana1, text="Restar", variable=self.seleccion, value=2)
        self.radio2.grid(column=1, row=3)
        self.boton1 = tk.Button(
            self.ventana1, text="Operar", command=self.operar)
        self.boton1.grid(column=1, row=4)
        self.label3 = tk.Label(self.ventana1, text="resultado")
        self.label3.grid(column=1, row=5)
        self.ventana1.mainloop()

    def operar(self):
        if self.seleccion.get() == 1:
            suma = int(self.dato1.get())+int(self.dato2.get())
            self.label3.configure(text=suma)
        if self.seleccion.get() == 2:
            resta = int(self.dato1.get())-int(self.dato2.get())
            self.label3.configure(text=resta)


aplicacion1 = Aplicacion()
