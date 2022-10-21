premios = [166116.06, 133948.48, 32353.38, 1528.22, 123.13, 66.37, 44.89, 15.91]

print("--- ACCESO A LOS PRIMEROS PREMIOS DEL EUROMILLÓN ---")
print("")


def controlErrores():
    try:
        premio_obtenido = int(input("Introduzca el número del premio a mostrar: ")) - 1
        print("Premio obtenido: " + str(premios[premio_obtenido]) + " €")
    except IndexError:
        print("Ese número no está en la lista de premios")

controlErrores()