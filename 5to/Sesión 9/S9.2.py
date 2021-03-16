import random


def generate():
    return random.randint(1, 100)


def inputNumberValid(mensaje):
    while True:
        try:
            number = int(input(mensaje))
        except ValueError:
            print("Debes escribir un número.")
            continue

        if number < 0:
            print("Debes escribir un número positivo.")
            continue
        else:
            break
    return number


def adivinar(numb):
    userNumber = inputNumberValid("Número:")
    intentos = 1
    while userNumber != numb:
        if userNumber > numb:
            print("El número es menor a " + str(userNumber))
        else:
            print("El número es mayor a " + str(userNumber))
        intentos += 1
        userNumber = inputNumberValid("Número:")
    if intentos == 1:
        print("¡Ganaste en el primer intento!")
    else:
        print("¡Ganaste en " + str(intentos) + " intentos!")


# bloque principal
numberRandom = generate()
print("Adivina el número entre el 1 y el 100")
adivinar(numberRandom)
