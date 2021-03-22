def mostrar_mensaje(mensaje):
    print("*************************************************")
    print(mensaje)
    print("*************************************************")


def carga_suma():
    valor1 = int(input("Ingrese el primer valor:"))
    valor2 = int(input("Ingrese el segundo valor:"))
    suma = valor1+valor2
    print("La suma de los dos valores es:", suma)


# programa principal
cadena = "El programa calcula la suma de dos valores ingresados por teclado."
mostrar_mensaje(cadena)
carga_suma()
mostrar_mensaje("Gracias por utilizar este programa")
