
# Sistema de Notas con Manejo de Excepciones

## Objetivo de la Actividad

Aplicar el manejo de excepciones en una aplicación de consola utilizando bloques `try-catch-finally`, validando la entrada de datos y controlando errores durante la ejecución del programa.

## Explicación del Try-Catch-Finally y su Importancia

En este proyecto utilicé el bloque try-catch-finally para evitar que el programa se cierre cuando el usuario cometa un error al escribir la nota.

El bloque try es donde se ocoloca el codigo que puede generar errores. En mi caso, ahí es donde le pido al usuario que ingrese la nota y la convierto a un número usando double.Parse().

El bloque catch se encarga de capturar los errores. Por ejemplo, si el usuario escribe letras en lugar de números, el programa detecta el error y muestra un mensaje indicando que debe ingresar una nota válida, en lugar de cerrarse de forma inesperada. El bloque finally siempre se ejecuta sin importar si ocurrió un error o no. Lo utilicé para mostrar un mensaje indicando que el proceso ha finalizado.

Es uso del try-catch-finally es importante porque permite controlar errores de una forma más segura y profesional. Gracias a esto, el programa puede seguir funcionando correctamente y brindar mensajes claros al usuario cuando ocurre algún problema.

## ⚙️ Funcionalidades

La aplicación incluye las siguientes funcionalidades:

* Registro del nombre del estudiante.
* Validación de que el nombre no contenga números.
* Captura de la nota mediante entrada por consola.
* Validación del rango de la nota (0 - 100).
* Manejo de excepciones mediante bloques try-catch-finally.
* Captura de errores de formato (FormatException).
* Captura de errores inesperados mediante un catch.
* Determinación automática de aprobación o reprobación.
* Mensaje de finalización del proceso utilizando el bloque finally.

## 🛠️ Tecnologías Utilizadas

* **Lenguaje:** C#
* **Framework:** .NET 6+
* **Tipo de Proyecto:** Aplicación de Consola
* **IDE:** Visual Studio 2022

## 📸 Imágenes de la Ejecución del Proyecto

### Ejecución Exitosa

<img width="853" height="627" alt="image" src="https://github.com/user-attachments/assets/32abaa47-b6ce-4b40-9328-9b622eca2fb8" />

###  Error por Formato

<img width="865" height="580" alt="image" src="https://github.com/user-attachments/assets/8381f34a-2beb-45f5-9370-d9d40a4b3a99" />

### Error por Nota Fuera de Rango

<img width="972" height="507" alt="image" src="https://github.com/user-attachments/assets/668ffcdd-1d19-4d51-8e10-a8cd7ac053aa" />

## ▶️ Uso o Ejecución

1. Clonar el repositorio desde GitHub.
2. Abrir la solución en Visual Studio o Visual Studio Code.
3. Ejecutar la aplicación.
4. Ingresar el nombre del estudiante.
5. Ingresar una nota válida.
6. Visualizar el resultado obtenido.
7. Observar los mensajes de error si se introduce información incorrecta.

## 🎓 Contexto Académico

* **Módulo Formativo:** Desarrollo de Aplicaciones y Sistemas de Información
* **Curso / Sección:** 5to D1
* **Año Escolar:** 2025-2026

## 👤 Autor

**Nombre del estudiante:** Isaac Reynold Disla Santana


