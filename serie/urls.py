from django.contrib import admin
from django.urls import path, include

urlpatterns = [
    path('gestion/', include('gestion.urls')),
    path('admin/', admin.site.urls),
]




from django.urls import path

from gestion import views

urlpatterns=[
    path('formulario_modificar', views.formulario_modificar, name='formulario_modificar'),
    path('formulario_borrar', views.formulario_borrar, name='formulario_borrar'),
    path('borrar', views.borrar, name='borrar'),
    path('menu', views.menu, name='menu'),
    path('listado', views.listado, name='listado'),
    path('',views.index,name='index')
]
