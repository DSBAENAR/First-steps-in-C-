# First-steps-in-C#
# Some projects you may interested!
# 1. Making a story by user input
# 2. You have three types of coins:
  - A bronze coin is worth 1 cent 
  - A silver coin is worth 5 cents
  - A gold coin is worth 10 cents
  
  What is the minimum number of coins that equals 98 cents?
  
  It’s a hard question to answer in your head, but it’s a fun problem to solve with programming. In this project you’ll use C# to build a Money Maker: a program in       which a user enters an amount and gets the minimum number of coins that equal that value.
  
  For example, 16 cents could be:
  
  16 bronze coins,
  3 silver coins and 1 bronze coin, or
  1 gold coin, 1 silver coin, 1 bronze coin
  
# 3. In this project you’ll make a program that measures the strength of any given password based on the following criteria. A strong password:

- Is at least 8 characters long
- has lowercase letters
- has uppercase letters
- has numerical digits
- has symbols, like #, ?, !
- The program will ask the user to input a password, and using conditional logic and control flow, it will rate the password.

# 4. Choose Your Own Adventure
In this project, you’ll use logic and conditional statements to write a classic text-based Choose Your Own Adventure Game. Depending on what choices your user makes, the program will have a different result. If you’re interested in game development, this is a great project to get your started! While we’re only working with text, the principles of user input and control flow are used to build even highly advanced games.

We’ve provided you with a template to write a game, but we highly encourage you to take what you’ve learned here and use your creativity to write an original game, either here on Codecademy or off-platform!

# 5. Architect Arithmetic
Architects have big ideas – but big ideas can be expensive. How expensive? Depends on the size.
In this project, you’ll use methods to build a program that calculates the material cost for any architect’s floor plan. In this case, i had to calculate the cost for teotihuacan building.

# 6. Ejercicio: Desarrollo de lógica de decisión con instrucciones if (Microsoft learn)
   Usará el método Random.Next() para simular el lanzamiento de tres dados de seis caras. Para calcular la puntuación, evaluará los valores obtenidos. Si la puntuación    es mayor que un total arbitrario, se mostrará un mensaje de éxito al usuario. Si la puntuación está por debajo del límite, se mostrará un mensaje de fracaso al         usuario.

   Si dos dados cualesquiera muestran el mismo valor, se obtienen dos puntos extra por obtener un doble.
   Si los tres dados muestran el mismo valor, se obtienen seis puntos extra por obtener un triple.
   Si la suma de los tres dados, junto con los puntos extra, es igual o mayor que 15, gana el juego. De lo contrario, pierde.

# 7. Proyecto Guiado (por Microsoft learn)
## Información general del proyecto
Estamos desarrollando una aplicación Student Grading que automatiza el cálculo de las calificaciones para los alumnos de una clase. Los parámetros de la aplicación son:

Cree una aplicación de consola de C#.

Comience con cuatro alumnos. Cada alumno tiene cinco notas de examen.

Cada nota de examen es un valor entero, de 0 a 100, donde 100 representa el 100 % correcto.

La calificación global del examen de un alumno es el promedio de sus cinco notas de examen.

Criterios para las tareas de créditos adicionales:

Incluya notas de tareas de créditos adicionales en la matriz de notas del alumno.
Las asignaciones de créditos adicionales valen el 10 % de una nota de examen (al calcular la nota numérica final).
Agregaremos las notas de las tareas de créditos adicionales a la nota total del examen del alumno antes de calcular la calificación numérica final.
La aplicación debe asignar automáticamente calificaciones con letras en función de la nota final calculada para cada alumno.

La aplicación debe generar o mostrar el nombre de cada alumno y la nota con formato.

La aplicación debe admitir la incorporación de otros alumnos y de otras notas sin que ello afecte al código en gran medida.

# 8. Actualización del proyecto guiado ( por Microsoft Learn)
## Introducción.
Supongamos que es auxiliar de un profesor en un colegio y que desarrolló una aplicación para automatizar el proceso de calificación. La aplicación usa matrices para almacenar los nombres de los alumnos y las tareas calificadas. La aplicación también implementa una combinación de instrucciones de iteración y selección para calcular y notificar la calificación final de cada alumno. La aplicación incluso diferencia entre las tareas de los exámenes y las tareas de créditos adicionales al calcular las calificaciones de los alumnos. Aunque la aplicación hace todo lo que el profesor solicitó, ha recibido una solicitud de nuevas características. El profesor le ha pedido que actualice el informe de calificaciones para que muestre las notas de los exámenes y las tareas de créditos adicionales separadas de la calificación numérica final y la nota con letra.

Este módulo le desafía a agregar nuevas funcionalidades a la aplicación Student Grading.

En resumen, debe usar la especificación del informe de calificaciones actualizada del profesor para:

- Actualizar el código de iteración y selección para calcular las notas finales independientes de los exámenes, las tareas de créditos adicionales y la calificación global.
- Actualizar el código que escribe el informe de calificaciones en la consola.

## Ejercicio: Actualización de la salida con formato

La aplicación Student Grading se usa para calcular y notificar calificaciones de alumnos en función de su examen calificado y de las asignaciones de crédito adicionales. Su objetivo en este desafío es actualizar el código que genera un informe de puntuación de acuerdo con los requisitos actualizados del profesor.

### Especificación
En este primer ejercicio de desafío, tiene que crear instancias de las variables necesarias para el informe de puntuación actualizado y, a continuación, actualizar la instrucción Console.WriteLine() que escribe las calificaciones de los alumnos en la consola.

La aplicación actualizada debe:

- Usar las matrices y los valores de matriz existentes de todos los cálculos de calificaciones de alumnos.
- Usar la estructura anidada proporcionada por las instrucciones foreach y if existentes.
- Declarar e inicializar cualquier otra variable de entero que sea necesaria para calcular las sumas.
- Declarar e inicializar cualquier otra variable decimal que sea necesaria para los cálculos y valores de los informes de puntuación.

# Ejercicio: Actualización de los valores calculados

La aplicación Student Grading se usa para calcular y notificar calificaciones de alumnos en función de su examen calificado y de las asignaciones de crédito adicionales. Su objetivo en este desafío es actualizar el código que calcula las calificaciones de los alumnos de acuerdo con los requisitos actualizados del profesor.

## Especificación
En este segundo ejercicio de desafío, tiene que crear instancias de las variables necesarias para el informe de puntuación actualizado, completar los cálculos necesarios y, a continuación, actualizar la instrucción Console.WriteLine() que escribe las calificaciones de los alumnos en la consola.

La aplicación actualizada debe:

- Usar las matrices y los valores de matriz existentes de todos los cálculos de calificaciones de alumnos.
- Usar la estructura anidada proporcionada por las instrucciones foreach y if existentes.
- Calcular la suma de las puntuaciones de exámenes y asignaciones de crédito adicionales mediante las variables del primer ejercicio o el código original.
- Calcular el promedio de las puntuaciones de los exámenes y los créditos adicionales mediante las variables del primer ejercicio o el código original.
- Calcular la puntuación numérica final de la siguiente manera: agregue el 10 % de la suma de puntuación de crédito adicional a la suma de puntuación del examen y, a continuación, divida ese valor por el número de exámenes.
- Calcular los puntos de crédito adicionales obtenidos de la siguiente manera: divida el 10 % de la suma de puntuación de crédito adicional por el número de exámenes.
