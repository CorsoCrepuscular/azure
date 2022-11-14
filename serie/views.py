from django.http import HttpResponse
from django.shortcuts import render
import requests
import json

from requests import HTTPError

from gestion.models import Serie

def index(request):
    return HttpResponse("Página de inicio")

def menu(request):
    return render(request, 'htmls/menu.html')

def listado(request):
    api_url = "https://apiseriespersonajes.azurewebsites.net/api/Series"

    try:
        response = requests.get(api_url)
        response.raise_for_status()
        response_json = response.json()
        contexto = {
            'listado_series': response_json
        }

        return render(request, 'htmls/listado.html', contexto)


    except HTTPError as http_err:
        print(f'HTTP error occurred: {http_err}')
    except Exception as err:
        print(f'Other error occurred: {err}')

def formulario_borrar(request):
    # Mostramos un listado con todas las series
    api_url = "https://apiseriespersonajes.azurewebsites.net/api/Series"

    try:
        response = requests.get(api_url)
        response.raise_for_status()
        response_json = response.json()
        contexto = {
            'listado_series': response_json
        }

        return render(request, 'htmls/form_borrar.html', contexto)

    except HTTPError as http_err:
        print(f'HTTP error occurred: {http_err}')
    except Exception as err:
        print(f'Other error occurred: {err}')


def borrar(request):
    id_serie = request.POST['id']
    api_url = "https://apiseriespersonajes.azurewebsites.net/api/Series/" + str(id_serie)

    try:
        response = requests.delete(api_url)
        print("Status: " + str(response.status_code))

        return render(HttpResponse, 'Serie eliminada')


    except HTTPError as http_err:
        print(f'HTTP error occurred: {http_err}')
    except Exception as err:
        print(f'Other error occurred: {err}')


def formulario_modificar(request):
    return render(request, 'htmls/form_modificar.html')


def modificar(request):
    id_serie = request.POST['id_serie']
    nuevo_nombre = request.POST['nombre']
    nuevo_imagen= request.POST['imagen']
    nuevo_puntuacion = request.POST['puntuacion']
    nuevo_anyo = request.POST['anyo']

    api_url = "https://apiseriespersonajes.azurewebsites.net/api/Series/"
    contexto = {
        'datos'
    }

    nueva_serie = {"id_serie": id_serie, "nombre": nuevo_nombre, "imagen": nuevo_imagen, "puntuacion": nuevo_puntuacion, "anyo": nuevo_anyo }

    response = requests.put(api_url, json=nueva_serie)
    # convertimos la respuesta a objeto diccionario
    # print(response.json())
    print("Status: " + str(response.status_code))

    """
    id_serie = request.POST['id']
    api_url = "https://apiseriespersonajes.azurewebsites.net/api/Series/" + str(id_serie)
    """