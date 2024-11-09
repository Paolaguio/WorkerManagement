
# WorkerManagement

## Introducción
WorkerManagement es un sistema de gestión de trabajadores desarrollado en .NET, que permite realizar operaciones de registro y consulta de empleados en una base de datos MySQL. Este proyecto utiliza **Entity Framework** y **MySQL.Data** como paquetes NuGet para facilitar la conexión y manipulación de datos.

## Requisitos previos
- **.NET SDK** compatible.
- **MySQL Workbench** para gestionar la base de datos.
- **Paquetes NuGet** necesarios: `EntityFramework` y `MySQL.Data`.

## Instalación

### 1. Clonar el repositorio
Descarga el proyecto desde el repositorio usando el siguiente comando:
```bash
git clone https://github.com/Paolaguio/WorkerManagement.git
```

### 2. Configurar la base de datos en MySQL Workbench
- Importa la base de datos a MySQL Workbench utilizando el archivo `.sql` incluido en el repositorio.
- Ajusta la configuración de la conexión en el archivo `appsettings.json`. Cambia la contraseña y otros parámetros según los valores de tu instalación local.

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=WorkerManagement;User=root;Password=tu_contraseña;"
  }
}
```

### 3. Restaurar paquetes NuGet
Ejecuta el siguiente comando para restaurar los paquetes necesarios:
```bash
dotnet restore
```

## Funcionalidades del Proyecto

### Controladores
- **GET** y **POST**: El controlador de trabajadores permite gestionar (crear y consultar) los registros de los trabajadores en la base de datos.

### Modelo
El proyecto cuenta con un modelo para representar la estructura de los datos de los trabajadores.

### Servicios
En la carpeta `Services` se encuentra la lógica para la conexión y las operaciones con la base de datos.
