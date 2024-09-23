# Proyecto API en C#

## Requisitos

- .NET SDK (versión [tu versión de .NET])
- [Visual Studio](https://visualstudio.microsoft.com/) o cualquier otro IDE que soporte C#
- Node.js y npm (para el proyecto Angular)

## Instalación

1. **Clonar el repositorio**

   ```bash
   git clone [URL del repositorio]
   cd [nombre del proyecto]
Ejecutar el proyecto API

Abre el proyecto en tu IDE preferido o usa el terminal:

bash
Copiar código
dotnet run
La API se ejecutará por defecto en https://localhost:5001 o http://localhost:5000.

Configuración del Frontend (Angular)
Clonar el repositorio del frontend

Si el frontend también está en un repositorio separado, clónalo:

git clone [URL del repositorio del frontend]
cd [nombre del proyecto Angular]
Instalar dependencias

Asegúrate de estar en el directorio del proyecto Angular y ejecuta:

npm install
Configurar el puerto de la API

Abre el archivo environment.development.ts en la carpeta src/environments y cambia la variable apiUrl para que apunte al puerto de tu API local. Por ejemplo:

export const environment = {
    production: false,
    urlApiVendor: 'http://localhost:5000' // Cambia este puerto según sea necesario
};
Ejecutar el proyecto Angular

Una vez configurado, ejecuta el proyecto Angular:

ng serve --o
El frontend se ejecutará en http://localhost:4200 por defecto.

Notas
Asegúrate de que tanto la API como el frontend se estén ejecutando en sus respectivos puertos.
No se requiere conexión a bases de datos para este proyecto, así que no es necesario configurar ninguna base de datos.
