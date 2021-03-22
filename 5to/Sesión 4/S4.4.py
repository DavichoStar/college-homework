def cantidad_vocales(cadena):
    cant = 0
    for x in range(len(cadena)):
        if cadena[x] == "a" or cadena[x] == "e" or cadena[x] == "i" or cadena[x] == "o" or cadena[x] == "u":
            cant += 1
    print("Cantidad de vocales de la palabra", cadena, "es:", str(cant))


# Bloque principal
cantidad_vocales("administracion")
cantidad_vocales("hola mundo")
cantidad_vocales("ana")
