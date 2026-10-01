# ⌨️🖱️ Prueba Evaluable: Control de Periféricos

Este proyecto es una aplicación de escritorio desarrollada en **C#** utilizando **Windows Forms**. Está estructurado bajo un enfoque orientado a objetos y centrado en la implementación de abstracciones para gestionar y controlar periféricos como teclados y ratones.

---

## 📋 Índice
- [Características Principales](#-características-principales)
- [Tecnologías Utilizadas](#%EF%B8%8F-tecnologías-utilizadas)
- [Estructura del Proyecto](#%EF%B8%8F-estructura-del-proyecto)
- [Requisitos Previos](#-requisitos-previos)
- [Instalación y Ejecución](#%EF%B8%8F-instalación-y-ejecución)

---

## ✨ Características Principales
* **Interfaz Gráfica de Usuario (GUI):** Formulario interactivo basado en Windows Forms para la visualización y pruebas.
* **Diseño Desacoplado:** Uso de interfaces (`IControladorDispositivo`) para definir los contratos comunes de interacción con el hardware simulado.
* **Controladores Específicos:** Implementación de lógica dedicada a la entrada y gestión tanto de teclado (`TecladoControlador`) como de ratón (`RatonControlador`).

---

## 🛠️ Tecnologías Utilizadas
* **Lenguaje:** [C#](https://microsoft.com)
* **Tecnología UI:** Windows Forms (.NET)
* **IDE recomendado:** [Visual Studio](https://microsoft.com)

---

## 🏗️ Estructura del Proyecto

El repositorio contiene los siguientes archivos principales reflejados en la solución:

```text
├── Form1.cs                    # Lógica interna y eventos del formulario principal
├── Form1.Designer.cs           # Código generado automáticamente por el diseñador de UI
├── Form1.resx                  # Recursos incrustados del formulario (iconos, textos, etc.)
├── IControladorDispositivo.cs  # Interfaz base que define el comportamiento de los periféricos
├── Program.cs                  # Punto de entrada de la aplicación de Windows Forms
├── RatonControlador.cs         # Lógica específica para el control de dispositivos tipo ratón
├── TecladoControlador.cs       # Lógica específica para el control de dispositivos tipo teclado
├── *.csproj                    # Archivo de definición del proyecto de C#
└── *.sln                       # Archivo de solución de Visual Studio
```

---

## 📌 Requisitos Previos
Para poder compilar y ejecutar este software de forma nativa se requiere:
* **Entorno de ejecución:** Windows (es nativo de Windows Forms).
* **Herramienta:** Visual Studio 2022 o superior con la carga de trabajo de *Desarrollo de escritorio de .NET* instalada.

---

## ⚙️ Instalación y Ejecución

1. **Clona o descarga este repositorio** en tu equipo local.
2. Abre el archivo de solución de Visual Studio (`.sln`) haciendo doble clic en él.
3. Asegúrate de que el proyecto esté configurado como proyecto de inicio.
4. Presiona la tecla **`F5`** o haz clic en el botón **Iniciar / Run** dentro de Visual Studio para compilar y lanzar la interfaz gráfica.
