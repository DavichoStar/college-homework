def cargar():
    lista = []
    for x in range(10):
        valor = int(input("Ingrese valor:"))
        lista.append(valor)
    return lista


def imprimir(lista):
    for x in range(len(lista)):
        print(lista[x], end=",")


# bloque principal
imprimir(cargar())
