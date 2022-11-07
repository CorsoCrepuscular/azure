from django.http import HttpResponse
from django.shortcuts import render

from alta_dept.models import Departamento

def menu(request):
    return render(request, "menu.html")

def form_alta(request):
    return render(request, "form_alta.html")

def form_baja(request):
    return render(request, "form_baja.html")

def form_consulta(request):
    return render(request, "form_consulta.html")

def form_modificar(request):
    return render(request, "form_modificar.html")

def alta(request):
    dep = request.POST['departamento']
    nom = request.POST['nombre']
    loc = request.POST['localidad']

    mi_departamento = Departamento()
    mi_departamento.introducir_depto(dep, nom, loc)

    #return render (request, "alta_dept/form_alta.html", contexto)
    return HttpResponse("Registro insertado")
    #print("Registros insertados: ", )


def baja(request):
    dep = request.POST['departamento']

    mi_departamento = Departamento()
    mi_departamento.borrar_depto(dep)

    return HttpResponse("Registro eliminado")

def modificar(request):
    dep = request.POST['departamento']
    nom = request.POST['nombre']
    loc = request.POST['localidad']

    mi_departamento = Departamento()
    mi_departamento.modificar_depto(dep, nom, loc)

    # return render (request, "alta_dept/form_alta.html", contexto)
    return HttpResponse("Registro insertado")
    # print("Registros insertados: ", )

def consulta(request):
    pass






"""
def empleados(request):
    ofi = request.POST['txtOficio']
    emple = Empleado()
    cursor = emple.devolverdato(ofi)
    contexto = {
        'listado_empleados': cursor
    }
    return render(request, "empleados/listado.html", contexto)


from django.shortcuts import render

"""
