from salario_clase import Salario
miSalario = Salario()

print("---PULSA EN LA OPCIÓN---")
print("1.- Búsqueda de salario y comisión")
print("2.- Modificar salario y comisión")
opcion = input("Opción: ")

try:
    if opcion == "1":
        miSalario.consultarSalario()

    elif opcion == "2":
        miSalario.modificarSalario()

except connection.Error as error:
    print("Error de conexión: ", error)



