numero = input("Introduzca un número: ")
exp = len(numero)
print("Longitud del número: ", exp)
suma = 0
print(exp)

for i in range(exp):
    base = int(numero[i])
    print("Base: ", base)
    suma = suma +pow(base,exp)

if suma == int(numero):
    print(f"{numero} es un número narcisista")
else:
    print(f"{numero} NO es un número narcisista")