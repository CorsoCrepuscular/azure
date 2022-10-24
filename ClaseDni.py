class Dni:
    
    letrasDni = ""
    def __init__(self):
        self.letrasDni = "TRWAGMYFPDXBNJZSQVHLCKET"
    def calcularresultado(self,numer):
        self.resultado = (numer- (int(numer / 23) * 23))
        letra = self.letrasDni[self.resultado]
        return letra

