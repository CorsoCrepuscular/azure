class Codigo:
    def __init__(self):
        digito = ""

    def calcularNumero(self, numero):
        sumaPares = 0
        sumaImpares = 0
        longitud = len(numero)
        print(longitud)
        if longitud != 8 and longitud != 13:
            long = False
            print("Longitud errónea")
        else:
            long = True


        numeroTruncado = numero[:-1]
        digitoUsuario = numero[-1]
        print("Digito Usuario: ", digitoUsuario)
        impares = numeroTruncado[::2]
        pares = numeroTruncado[1::2]
        for i in range(len(pares)):
            sumaPares = sumaPares + int(pares[i])
        print("sumaPares: ", sumaPares)

        for i in range(len(impares)):
            sumaImpares = sumaImpares + int(impares[i])
        print("sumaPares: ", sumaPares)

        if longitud == 13:
            sumaPares = sumaPares * 3
            print("Suma Pares: ",sumaPares)
        if longitud == 8:
            sumaImpares = sumaImpares * 3
            print("Suma Impares: ", sumaImpares)

        suma = sumaPares + sumaImpares
        print("Suma: ", suma)
        resto = suma % 10
        print("Resto: ",resto)
        digitoControl = 10 - resto
        print("Digito Control: ", digitoControl)

        if int(digitoUsuario) == digitoControl:
            codigoEan = True
        else:
            codigoEan = False

        return codigoEan







"""
    class Dni:
        letrasDni = ""
        def __init__(self):
            self.letrasDni = "TRWAGMYFPDXBNJZSQVHLCKET"
        def calcularresultado(self, numer):
            self.resultado = (numer - (int(numer / 23) * 23))
            letra = self.letrasDni[self.resultado]
            return letra
"""