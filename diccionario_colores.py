colores = dict()

colores = {
    "amarillo" : "Yellow",
    "rosa"     : "Pink",
    "azul"     : "Blue",
    "blanco"   : "White",
    "rojo"     : "Red"
}

print("\n--- DICCIONARIO DE COLORES ---\n")

def controlErrores():
    try:
        color = input("¿Color? ").lower()
        print (f"{ color } = { colores[color]}")
    except KeyError:
        print ("Ese color no está en la lista")

controlErrores()