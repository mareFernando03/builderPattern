# Creador de Pizzas con el Patrón Builder 🍕 

Este proyecto es un ejemplo interactivo en C# que implementa el **Patrón de Diseño Builder**. Permite a los usuarios crear una pizza personalizada seleccionando el tipo de masa, salsa y los ingredientes a través de la consola. El objetivo de este programa es mostrar de manera práctica y sencilla cómo funciona el patrón *Builder* en el desarrollo de software.

## Descripción del Patrón Builder 🛠️

El patrón *Builder* es un patrón de diseño creacional que permite la construcción paso a paso de objetos complejos. A través de este patrón, se puede construir diferentes versiones de un objeto utilizando el mismo código, garantizando flexibilidad y claridad en el proceso de creación.

En este caso, se utiliza el patrón Builder para construir una pizza, donde los pasos para definir la **masa**, **salsa**, y **ingredientes** están definidos en el constructor. El usuario puede interactuar con el programa y elegir qué tipo de pizza quiere crear.

## Estructura del Proyecto 📂

- **Pizza.cs**: Clase que representa el producto que queremos construir (Pizza).
- **IPizzaBuilder.cs**: Interfaz Builder que define los métodos para construir cada parte de la pizza.
- **PizzaPersonalizadaBuilder.cs**: Clase concreta que implementa la construcción de una pizza personalizada.
- **DirectorDePizzas.cs**: Director que organiza los pasos de la construcción.
- **Program.cs**: Programa principal que permite la interacción con el usuario a través de la consola.

## Características del Proyecto 🧩

- Interactividad: El usuario puede elegir cómo desea que se construya su pizza.
- Patrón Builder: Muestra claramente cómo se puede construir un objeto complejo paso a paso utilizando el patrón de diseño.
- Flexibilidad: Se pueden añadir más opciones de ingredientes, salsas o tipos de masa simplemente extendiendo el código.

## Instrucciones de Instalación 🖥️

1. Clona el repositorio:

    ```bash
    git clone https://github.com/tu-usuario/patron-builder-pizza.git
    ```

2. Abre el proyecto en **Visual Studio** o en tu IDE de preferencia.

3. Ejecuta el proyecto presionando `Ctrl + F5` o haciendo clic en **"Iniciar sin depurar"**.

## Cómo usar el programa 🕹️

Cuando ejecutes el programa, este te pedirá que elijas los componentes de tu pizza:

1. **Tipo de masa**: Puedes elegir entre masa fina o masa gruesa.
2. **Tipo de salsa**: Puedes elegir entre salsa de tomate o salsa barbacoa.
3. **Ingredientes**: Puedes elegir entre queso mozzarella, pepperoni o vegetales.

### Ejemplo de uso:

```bash
¡Bienvenido al creador de pizzas!
Vamos a construir una pizza personalizada.
Elige el tipo de masa:
1. Masa fina
2. Masa gruesa
1
Elige el tipo de salsa:
1. Salsa de tomate
2. Salsa barbacoa
2
Elige los ingredientes:
1. Queso mozzarella
2. Pepperoni
3. Vegetales
3
Has creado la siguiente pizza: Pizza con Masa fina, Salsa barbacoa y los siguientes ingredientes: Vegetales.
¡Gracias por usar el creador de pizzas!
