import cx_Oracle
from django.db.transaction import commit

class Departamento:
    def __init__(self):
        self.connection = cx_Oracle.connect("system", "netoracle", "localhost/XE")

    def introducir_depto(self, mi_dept, mi_nombre, mi_loc):
        cursor = self.connection.cursor()
        try:
            consulta = ("INSERT INTO dept (dept_no, dnombre, loc) VALUES (:p1, :p2, :p3)")

            cursor.execute(consulta, (mi_dept, mi_nombre, mi_loc))
            self.connection.commit()
            #registros = cursor.rowcount
        except self.connection.Error as error:
            print("Error: ", error)

        #return registros

    def borrar_depto(self, mi_dept):
        cursor = self.connection.cursor()

        try:
            consulta = ("DELETE FROM dept WHERE dept_no = :p1")
            cursor.execute(consulta, (mi_dept,))
            self.connection.commit()

        except self.connection.Error as error:
            print("Error: ", error)

    def modificar_depto(self, dep, nom, loc):
        cursor = self.connection.cursor()

        try:
            consulta = ("UPDATE dept SET dnombre = :p1, loc = :p2 WHERE dept_no = dep)")
            cursor.execute(consulta, (dep, nom, loc))
            self.connection.commit()
        except self.connection.Error as error:
            print("Error: ", error)



