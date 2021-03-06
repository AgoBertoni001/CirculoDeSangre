
# Documentación.


## Listado de requerimientos:
•	El sistema debe estar desarrollado como aplicación web y escritorio en lenguaje c#.

•	El sistema comparte con el Banco datos de informes.

•	El sistema debe permitir darle el alta al asociado.

•	El sistema debe almacenar los datos del asociado.

•	El sistema debe determinar la categoría del asociado.

•	El sistema debe mantener actualizado los cambios de categorías diariamente.

•	El sistema debe mostrar la totalidad de los datos de los asociados.

•	El sistema debe registrar las peticiones de donación emitidas por el Banco de Sangre.

•	El sistema debe permitir buscar lista de asociados que cumplan con condiciones y estén en la categoría activo para donar.

•	El sistema debe permitir elegir un turno de donación dentro de un rango de fechas establecidas.

•	El sistema debe notificar al asociado cuando se confirme el turno.

•	El sistema debe registrar cada donación mediante los informes que envía el Banco. 

•	El sistema debe permitir liquidar las cuotas para cada asociado. 

•	El sistema debe registrar el cobro y la forma de pago. 

•	El sistema debe controlar las cobranzas mensualmente. 

•	El sistema debe permitir generar listados que determine el porcentaje de pagos de cuotas por categoría de asociado.




## Iteración 1:
### Tiempo estimado: 1 semana.
•	El sistema debe permitir darle el alta al asociad

•	El sistema debe almacenar los datos del asociado.

•	El sistema debe determinar la categoría del asociado.

•	El sistema debe mantener actualizado los cambios de categorías diariamente.

•	El sistema debe mostrar la totalidad de los asociados.

•	El sistema debe mantener actualizado los cambios de categorías diariamente.

## Iteración 2:
### Tiempo estimado: 1 semana.

•	El sistema debe registrar las peticiones de donación emitidas por el Banco de Sangre.

•	El sistema debe permitir buscar lista de asociados que cumplan con condiciones y estén en la categoría activo para donar.

•	El sistema debe permitir elegir un turno de donación dentro de un rango de fechas establecidas.
## Iteración 3:
### Tiempo estimado: 1 semana.
•	El sistema debe notificar al asociado cuando se confirme el turno.

•	El sistema debe registrar cada donación mediante los informes que envía el Banco. 
## Iteración 4:
### Tiempo estimado: 2 semanas.
•	El sistema debe permitir liquidar las cuotas para cada asociado. 

•	El sistema debe registrar el cobro y la forma de pago. 

•	El sistema debe controlar las cobranzas mensualmente. 
## Iteración 5:
### Tiempo estimado: 1 semana.
•	El sistema debe permitir generar listados que determine el porcentaje de pagos de cuotas por categoría de asociado.

## Diagrama Casos de Uso

![DiagramaCU](https://user-images.githubusercontent.com/99101418/166554689-7c3f95e8-1dce-4c0c-b2df-a77538a64444.png)


## Diagrama Clase

![image](https://user-images.githubusercontent.com/102813997/167223362-bf5d2c1b-b587-441d-b1a9-13fda754dee9.png)



## Iteración 1:
En esta iteración comenzamos con el alta del asociado, almacenando sus datos y calculando automáticamente la categoría a la que pertenece manteniéndola actualizada y mostrar la totalidad de los datos del mismo.

## Descripcion de Casos de Uso:
 ***Descripcion 1:***
![Descripcion1](https://user-images.githubusercontent.com/99101418/166555559-ed58341e-22f9-4144-baff-24f57bd60299.png)

***Descripcion 2:***
![Descripcion2](https://user-images.githubusercontent.com/99101418/166555594-18d45b3c-48b7-416f-ad82-6c7c4cf69c39.png)

## Diagrama de Interfaces:
![DiagramaDeInterfaces1](https://user-images.githubusercontent.com/99101418/166555703-13a1c887-15ef-44b5-9959-d5e6907c9861.png)

![DiagramaDeInterfaces2](https://user-images.githubusercontent.com/99101418/166555714-108c15db-3021-46aa-8689-cab120fd5b21.png)

# Iteracion 2:
En esta iteración se espera que el Banco envíe la petición la cual debe indicar la cantidad de personas que necesitan que vayan a donar, la fecha límite, tipo y factor grupo. La petición recibida se registra. Luego se determinan los asociados que están en condiciones de realizar la donación, es decir, que cumpla el tiempo de espera necesario desde la última donación y que permanezca a la categoría “activo”. 
 
 Una vez determinado las condiciones, se crea una lista de prioridad de los asociados, después el asociado determina la fecha y se envían las notificaciones correspondientes de confirmación de turno.

## BPMN:

![BPMN](https://user-images.githubusercontent.com/99101418/166556097-c2bb90d8-8590-4e77-ba44-a0f003225e8f.png)

## Descripcion de Casos de Uso:
***Descripcion 1:***
![Descripcion1](https://user-images.githubusercontent.com/99101418/166558962-7c7ba19e-e115-4be1-86da-a2e2945e0b44.png)

***Descripcion 2:***
![image](https://user-images.githubusercontent.com/102813997/167223617-8e9b78c4-45de-466f-88e0-71479533768f.png)

## Prototipos:
![Prototipo Asociados Activos](https://user-images.githubusercontent.com/102813997/169367771-c6b11455-0143-4661-a6b8-8109db7abdd2.png)
![Prototipo Gestion de Turnos](https://user-images.githubusercontent.com/102813997/169367841-7bcf17ec-30be-4e15-8a27-05783f22aee6.png)
![Prototipo Registrar Peticion](https://user-images.githubusercontent.com/102813997/169367876-acbd37ea-b430-4f6e-ab98-dfb47bef131e.png)

