# Pizza Api - Net Core
## [Tutorial](https://docs.microsoft.com/en-us/learn/modules/build-web-api-aspnet-core/7-crud)
## [README.md Tutorial](https://docs.github.com/en/github/writing-on-github/working-with-advanced-formatting/organizing-information-with-tables)

## Instalar
* [Net Core](https://dotnet.microsoft.com/download)
* [Certificados Development Https](https://docs.microsoft.com/en-us/aspnet/core/security/enforcing-ssl#trust-the-aspnet-core-https-development-certificate-on-windows-and-macos)

## Pasos
* Abrir una terminal
* **dotnet tool install -g Microsoft.dotnet-httprepl**
* **httprepl** http://localhost:5223
* pref set editor.command.default "**commandLine**" (ruta completa de editor de texto)
* probar los comandos
* probar api

## Probar Api httprepl
| Comando | Accion|
|:---|---|
| **get** | obtener todas las pizzas |
| **get num** | reemplazar num para obtener una pizza por id |
| **post -c "{ "atributo":valor, "atributo":"valor" }"** | crear una pizza |
| **delete num**| eliminar una pizza |
| **put num** | modificar una pizza|


## Comandos
* **ls** (Podemos ver los controladores disponibles)
* **cd nombre_controlador** (Acceder a la carpeta de un controlador)
* **cd ..** (Acceder a la carpeta anterior)

## Rutas
* [GetAll](http://localhost:5223/pizza)
* [Get](http://localhost:5223/pizza/1)
* Post - http://localhost:5223/pizza
* Put - http://localhost:5223/pizza/1
* Delete - http://localhost:5223/pizza/1

### Contenido adicional
* [Beginner series](https://docs.microsoft.com/en-us/shows/Beginners-Series-to-Web-APIs/?WT.mc_id=Educationaldotnet-c9-scottha&page=1)
