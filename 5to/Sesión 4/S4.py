def cargar_paisespoblacion():
    paises = []
    for x in range(5):
        nom = input("Ingresar el nombre del pais:")
        cant = int(input("Ingrese la cantidad de habitantes:"))
        paises.append((nom, cant))
    return paises


def imprimir(paises):
    print("Paises y su poblacion")
    for x in range(len(paises)):
        print(paises[x][0], paises[x][1])


def pais_maspoblacion(paises):
    pos = 0
    for x in range(1, len(paises)):
        if paises[x][1] > paises[pos][1]:
            pos = x
    print("Pais con mayor cantidad de habitantes:", paises[pos][0])


# bloque principal

paises = cargar_paisespoblacion()
imprimir(paises)
pais_maspoblacion(paises)
