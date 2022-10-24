
premios = [166116.06, 133948.48, 32353.38, 1528.22, 123.13, 66.37, 44.89, 15.91]

print("\n--- ACCESO A LOS PRIMEROS PREMIOS DEL EUROMILLÓN ---\n")

def controlErrores():
    try:
        premio_obtenido = abs(int(input("Introduzca el número del premio a mostrar: ")))
        print(f"El premio {premio_obtenido}º tiene {str(premios[premio_obtenido - 1])} €")
    except IndexError:
        print("Ese número no está en la lista de premios")

controlErrores()