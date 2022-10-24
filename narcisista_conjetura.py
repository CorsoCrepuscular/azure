import sys



def narcisista():
        print("--------------NÚMERO NARCISISTA------------")
        num2 = 0
        num = input("Introduzca un número: ")
        potencia = len(num)

        for i in range(len(num)):
            num2 = pow(int(num[i]), potencia) + num2

        if int(num2) == int(num):
            print(f"{num} ES UN NÚMERO NARCISITA")
        else:
            print(f"{num} NO ES UN NÚMERO NARCISITA")

def conjetura():
        print("--------------CONJETURA DE COLLATZ------------")

        numero = int(input("Introduzca un número:"))
        resultado = ""
        while numero != 1:
            resultado += "\n"
            if (numero % 2 == 0):
                numero = numero / 2
            else:
                numero = (numero * 3) + 1
            resultado += str(numero)
            resultado += "\n"

        print(f"Resultado Conjetura {resultado} ")

print("--- PULSA EN OPCIÓN ---")
print("1.- Comprobar número Narcisista")
print("2.- Mostrar conjetura de Collatz")
print("3.- Salir")
opcion = input("Opción: ")
print(opcion)

while opcion!=3:
    if int(opcion) !in range (1,4):
        print("Opción errónea")

    elif opcion == "1":
        narcisista()

    elif opcion == "2":
        conjetura()




