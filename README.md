Actividad 2 - Programación orientada a objetos con C#
1. Crear un sistema que permita registrar alumnos, materias y las inscripciones a las materias de cada 
año.
De los alumnos se desea conocer: nombre, apellido, fecha de nacimiento, documento y número de 
legajo.
De las materias solo el nombre.
De las inscripciones: año lectivo (2023, 2024, 2025…), la materia, el alumno y un valor booleano 
‘aprobado’. 
Utilizando un menú principal, el sistema debe resolver estas necesidades:
1. Cargar materias
2. Cargar alumnos
3. Cargar inscripciones. Permite cargar una inscripción. Antes de guardar, verificar que no 
exista previamente una inscripción idéntica.
4. Buscar materias. Permite ingresar un texto y traer las materias similares al texto buscado. Si 
se ingresa el texto buscado en blanco, mostrar todas las materias.
5. Buscar alumnos. Mismo funcionamiento que el punto anterior, pero con alumnos. Buscar el 
dato ingresado en todos los datos disponibles de cada alumno.
6. Ver inscripciones. El usuario deberá seleccionar una materia y año lectivo, luego se 
mostrarán todos los alumnos inscriptos indicando si están o no aprobados.
7. Aprobar alumnos. El usuario debe seleccionar una materia y un año lectivo. Mostrar por 
pantalla uno por uno los alumnos que cursan esa materia en ese año y preguntar si aprobó o 
no. Guardar esa información en el valor ‘aprobado’ de la inscripción.
8. Ver materias aprobadas. El usuario deberá seleccionar un alumno y se mostrarán todas las 
materias aprobadas (Materia y año lectivo).
2. Tomando el ejemplo visto donde se cargan productos, ventas y clientes, ajustar el sistema para que 
incluya estas nuevas funcionalidades, agregando cada una al menú principal:
1. Buscar productos. Se le solicita al usuario que ingrese un texto y luego se muestran todos los 
productos que sean similares (en alguno de sus datos) al texto ingresado.
2. Buscar clientes. Mismo funcionamiento que el punto anterior, pero para buscar clientes.
3. Producto más vendido. El sistema debe analizar los datos de las ventas y mostrar el o los 
productos mas vendidos indicando la cantidad de veces que fue vendido (si más de uno 
comparte el primer puesto, mostrar todos los que sean los más vendidos)
4. Informe de clientes. El sistema debe mostrar una lista de todos los clientes indicando cuanto
gastó en total (sumando todas las ventas del sistema para ese cliente) y la cantidad de ventas 
realizadas por el cliente.
