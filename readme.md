# BookStore API

## Описание
Приложение для автоматизации книжного магазина с использованием ASP.NET Core Web API и PostgreSQL.

## Требования
- .NET 6.0 или новее
- PostgreSQL
- Git

## Установка

1. Клонируйте репозиторий:

   git clone <URL вашего репозитория>
   cd BookStoreApi
   
2. Установите зависимости:

dotnet restore

3. Настройте строку подключения в appsettings.json.

4. Примените миграции базы данных:

dotnet ef database update

5. Запустите приложение:

dotnet run
