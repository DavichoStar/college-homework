def cargar_empleados():
    nombres = []
    sueldos = []
    for x in range(5):
        nombre = input("Ingresar el nombre del empleado:")
        sueldo1 = int(input("Ingrese el primer sueldo: "))
        sueldo2 = int(input("Ingrese el segundo sueldo: "))
        sueldo3 = int(input("Ingrese el tercer sueldo: "))
        sueldototal = sueldo1+sueldo2+sueldo3
        print("Su sueldo total es de: ", sueldototal)
        print("*************************************")
        nombres.append(nombre)
        sueldos.append(sueldototal)
    return nombres, sueldos


def imprimir(empleados):
    for x in range(len(empleados)):
        empleado = empleados[1][x]
        if empleado > 10_000:
            print("Los empleados con sueldos mayor a $10000 es: ",
                  empleados[0][x])


# Bloque principal
empleadosList = cargar_empleados()
imprimir(empleadosList)
