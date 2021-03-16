def cargar():
    agenda = {}
    continua1 = "s"
    while continua1 == "s":
        fecha = input("Ingrese la fecha con formato dd/mm/aa: ")
        continua2 = "s"
        lista = []
        while continua2 == "s":
            hora = input("Ingrese la hora de la actividad con formato hh:mm: ")
            actividad = input("Ingrese la descripcon de la actividad: ")
            lista.append((hora, actividad))
            continua2 = input(
                "¿Ingresa otra actividad para la misma fecha? [s/n]: ")
        agenda[fecha] = lista
        continua1 = input("¿Ingresa otra fecha? [s/n]: ")
    return agenda


def consulta_fecha(agenda):
    fecha = input("Ingrese la fecha que desea consultar: ")
    if fecha in agenda:
        for hora, actividad in agenda[fecha]:
            print(hora, actividad)
    else:
        print("No hay actividades agendadas para dicha fecha")
    print("Cerrando Agenda...")


def imprimir(agenda):
    print("Listado completa de la agenda")
    for fecha in agenda:
        print("Para la fecha: ", fecha)
        for hora, actividad in agenda[fecha]:
            print(hora, actividad)
    consulta_fecha(agenda)


# bloque principal
imprimir(cargar())
