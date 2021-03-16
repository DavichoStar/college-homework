def cargar_lista():
    li = []
    for x in range(5):
        valor = int(input("Ingresa valor: "))
        li.append(valor)
    return li


def imprimir_mayor(li):
    print("Elementos de la lista mayores a 10")
    for x in range(len(li)):
        if li[x] > 10:
            print(li[x])


# Bloque principal
imprimir_mayor(cargar_lista())
