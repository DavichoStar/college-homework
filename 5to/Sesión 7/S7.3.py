def cargar_alumnos():
    alumnos = {}
    continua1 = "s"
    while continua1 == "s":
        dni = input("Ingrese el DNI del alumno: ")
        continua2 = "s"
        lista = []
        while continua2 == "s":
            materia = input("Ingrese el nombre de la materia: ")
            parcia1 = int(input("Ingrese la nota del primer parcial: "))
            parcia2 = int(input("Ingrese la nota del segundo parcial: "))
            parcia3 = int(input("Ingrese la nota del tercero parcial: "))
            lista.append((materia, parcia1, parcia2, parcia3))
            continua2 = input(
                "¿Quieres ingresar otra materia para este alumno? [s/n]: ")
        alumnos[dni] = lista
        continua1 = input("¿Quieres ingresar otro alumno? [s/n]: ")
    return alumnos


def consulta_dni(agenda):
    continua1 = "s"
    while continua1 == "s":
        dni = input("Ingrese el DNI del alumno que desea consultar: ")
        if dni in agenda:
            for materia, parcia1, parcia2, parcia3 in agenda[dni]:
                print("|=============================|")
                print("Materia:", materia, "\n  Calificaciones: P1",
                      parcia1, "| P2:", parcia2, "| P3:", parcia3)
        else:
            print("No hay alumnos con ese DNI registrado.")
        print("|=============================|")
        continua1 = input("¿Consultar otro dni? [s/n]: ")
    print("Cerrando Lista de alumnos...")


def imprimir(alumnos):
    print("|=============================|")
    print("| Listado completa de alumnos |")
    print("|=============================|")
    for dni in alumnos:
        print("Alumno con DNI: ", dni)
        for materia, parcia1, parcia2, parcia3 in alumnos[dni]:
            print(materia + ":\n  Calificaciones:",
                  parcia1, "|", parcia2, "|", parcia3)
    consulta_dni(alumnos)


# bloque principal
imprimir(cargar_alumnos())
