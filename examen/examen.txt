# Examen de Fco. Javier Serrano Sánchez
# Materia: Python

import cx_Oracle
connection = cx_Oracle.connect("system", "netoracle", "localhost/XE")
cursor = connection.cursor()


opcion=-1
while opcion not in range(7): # Error en la opción

    # Menú
    print("--- PULSA EN LA OPCIÓN ---")
    print("1.- Alta Doctor")
    print("2.- Modificar salario de Doctor")
    print("3.- Eliminar Doctor")
    print("4.- Mostrar apellido y especialidad de un Doctor")
    print("5.- Visualizar datos de grupo de un hospital")
    print("6.- Salir")
    opcion = int(input())

    if opcion == 1:
        try:
            hospital = input("Introduzca el código del hospital")
            doctor = input("Introduzca el número del doctor: ")
            apellido = input("Introduzca el apellido del doctor: ")
            especialidad = input("Introduzca la especialidad del doctor: ")
            salario = input("Introduzca el salario: ")
            cursor.callproc("alta_doctor", (hospital, doctor, apellido, especialidad, salario))

            if cursor.rowcount > 0:
                print("Registro modificado satisfactoriamente")
            else:
                print("Dato no encontrado")

        except connection.Error as error:
            print("Error: ", error)


    elif opcion == 2:
        try:
            doctor = input("Introduzca el número del doctor: ")
            salario = input("Introduzca el salario: ")
            cursor.callproc("modificar_doctor", (doctor, salario))

            if cursor.rowcount > 0:
                print("Registro modificado satisfactoriamente")
            else:
                print("Dato no encontrado")

        except connection.Error as error:
            print("Error: ", error)


    elif opcion == 3:
        try:
            doctor = input("Introduzca el número del doctor: ")
            cursor.callproc("eliminar_doctor", (doctor,))

            if cursor.rowcount > 0:
                print("Registro eliminado satisfactoriamente")
            else:
                print("Dato no encontrado")

        except connection.Error as error:
            print("Error: ", error)



    elif opcion == 4:
        try:
            doctor = input("Introduzca el número del doctor: ")
            consulta = ("SELECT apellido,especialidad FROM doctor WHERE DOCTOR_NO=:p1")
            cursor.execute(consulta, (doctor,))

            resultado = False
            for ape, esp in cursor:
                print("CÓDIGO DOCTOR: ", doctor)
                print("Apellido: ", ape)
                print("Especialidad: ", esp)

                resultado = True
            if resultado == False:
                print("No se encontraron resultados")

        except connection.Error as error:
            print("Error: ", error)

    elif opcion == 5:
        try:
            hospital = input("Introduzca el número del hospital: ")
            consulta = ("SELECT SUM(salario), AVG(salario), COUNT(salario) FROM doctor GROUP BY hospital_code WHERE hospital_code=:p1")
            cursor.execute(consulta, (hospital,))

            resultado = False
            for suma, media, num_doctores in cursor:
                print("DATOS DE GRUPO:")
                print("---------------")

                print("Suma salarial: ", suma)
                print("Media salarial: ", media)
                print("Número de doctores: ", num_doctores)

                resultado = True
            if resultado == False:
                print("No se encontraron resultados")

        except connection.Error as error:
            print("Error: ", error)



    else:
        print("Fin del programa")






connection.close()