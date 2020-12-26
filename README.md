# petclinicdemo
Proyecto de Clinica de Mascotas

## Crear un proyecto mvc con login

- dotnet new mvc -au Individiual


## migrations 

- Remover la carpeta Migrations
- Cambiar la cadena de conexion
- dotnet ef migrations add Initial --context EsportshubApi.Models.ApplicationDbContext -o YourFolderPath

- example:

dotnet ef migrations add OtherSchema --context petclinicdemo.Data.ApplicationDbContext -o "C:\Users\fduarte\Documents\Personal\USMP\FIA\Programacion I\20202\petclinicdemo\Data\Migrations"

- dotnet ef database update

## Startup

- dotnet watch run

## Proceso de Ramas

- JP: Crea el proyecto inicial con el login y con la bd conectada y hace push sobre main

- Patricia: git clone URL ex: "https://github.com/fduartej/petclinicdemo.git"

- Jean Pierre: git clone URL 

## customizar el ui

https://andrewlock.net/customising-aspnetcore-identity-without-editing-the-pagemodel/
Pasos
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 3.1.4
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 3.1.4
dotnet tool install --global dotnet-aspnet-codegenerator --version 3.1.4
dotnet aspnet-codegenerator identity -dc MinerTrabajoFInal.Data.ApplicationDbContext --files "Account.Register"

## Crear CRUD 

dotnet aspnet-codegenerator controller -name EmpleadoController -m Empleado -dc petclinicdemo.Data.ApplicationDbContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries

dotnet aspnet-codegenerator controller -name ProductoController -m Producto -dc petclinicdemo.Data.ApplicationDbContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries
