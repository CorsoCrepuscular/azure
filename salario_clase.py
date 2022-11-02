import cx_Oracle

class Salario:
    def __init__(self):
        p_numero = ""
        p_salario = 0
        p_comision = 0
        self.connection = cx_Oracle.connect('system', 'netoracle', 'localhost/XE')
        self.cursor = self.connection.cursor()

    def consultarSalario(self):
        try:
            p_numero   = input("Introduzca emp_no: ")
            p_salario  = self.cursor.var(cx_Oracle.NUMBER)
            p_comision = self.cursor.var(cx_Oracle.NUMBER)
            args = (p_numero, p_salario, p_comision)
            result_args = self.cursor.callproc('salarios2.consultar', args)
            print(f"EMPLEADO Nº: {result_args[0]}")
            print(f"SALARIO: {result_args[1]}")
            print(f"COMISION: {result_args[2]}")

        except self.connection.Error as error:
            print("Error de conexión: ", error)

        self.cursor.close()
        self.connection.close()

    def modificarSalario(self):
        try:
            p_numero   = input("Introduzca emp_no: ")
            p_salario  = input("Introduzca nuevo salario: ")
            p_comision = input("Introduzca nueva comisión: ")
            args = (p_numero, p_salario, p_comision)
            self.cursor.callproc('salarios2.modificar', args)
            print("¡Datos modificados!")

        except self.connection.Error as error:
            print("Error de conexión: ", error)

        self.cursor.close()
        self.connection.close()