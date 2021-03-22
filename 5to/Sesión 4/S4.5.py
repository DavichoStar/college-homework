def ordenar(v1, v2, v3):
    if (v1 < v2 and v1 < v3):
        if (v2 < v3):
            print(v1, v2, v3)
        else:
            print(v1, v3, v2)
    else:
        if (v2 < v3):
            if (v1 < v3):
                print(v2, v1, v3)
            else:
                print(v2, v3, v1)
        else:
            if (v1 < v2):
                print(v3, v1, v2)
            else:
                print(v3, v2, v1)


def cargar():
    num1 = int(input("Ingresa el primer valor:"))
    num2 = int(input("Ingresa el segundo valor:"))
    num3 = int(input("Ingresa el tercer valor:"))
    ordenar(num1, num2, num3)


# Bloque Principal
cargar()
