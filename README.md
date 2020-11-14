# petclinicdemo
Proyecto de Clinica de Mascotas

## Crear un proyecto mvc con login

- dotnet new mvc -au Individiual


## migrations 

- Remover la carpeta Migrations
- Cambiar la cadena de conexion
- dotnet ef migrations add Initial --context EsportshubApi.Models.ApplicationDbContext -o YourFolderPath

- example:

dotnet ef migrations add CreateIdentitySchema --context petclinicdemo.Data.ApplicationDbContext -o "C:\Users\fduarte\Documents\Personal\USMP\FIA\Programacion I\20202\petclinicdemo\Data\Migrations"

- dotnet ef database update

## Starup

- dotnet watch run

## Proceso de Ramas

- JP: Crea el proyecto inicial con el login y con la bd conectada y hace push sobre main

- Patricia: git clone URL ex: "https://github.com/fduartej/petclinicdemo.git"

- Jean Pierre: git clone URL 

