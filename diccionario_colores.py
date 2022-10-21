colores = dict()

colores = {
    "Amarillo" : "Yellow",
    "Rosa"     : "Pink",
    "Azul"     : "Blue",
    "Blanco"   : "White",
    "Rojo"     : "Red"
}

def controlErrores():
    try:
        color = input("¿Color? ")
        print (f"{ color } = { colores[color]}")
    except KeyError:
        print ("Ese color no está en la lista")

controlErrores()