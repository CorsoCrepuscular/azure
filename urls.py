from django.contrib import admin
from django.urls import path, include

urlpatterns = [
    path('alta_dept/', include ('alta_dept.urls')),
    path('datospost2/', include('datospost2.urls')),
    path('peliculas/', include('peliculas.urls')),
    path('deportes/', include('deportes.urls')),
    path('gestion/', include('gestion.urls')),
    path('admin/', admin.site.urls)
]

