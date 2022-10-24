from ClaseCodigo import Codigo
miCodigo = Codigo()
numero = input ("Introduzca el código EAN: ")
resultado = miCodigo.calcularNumero(numero)
print (resultado)