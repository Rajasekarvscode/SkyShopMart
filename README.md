\SS1.0\SkyShopMart> dotnet ef migrations add SkyShopDBEntity --project Infrastructure --startup-project SkyShop.API

dotnet ef migrations list --project Infrastructure --startup-project  SkyShop.API
dotnet ef database update --project Infrastructure --startup-project  SkyShop.API
dotnet ef migrations add RemoveQuantityInStock --project Infrastructure --startup-project SkyShop.API



-----------------
mkdir SkyShop
cd SkyShop

dotnet new sln -n SkyShop

dotnet new webapi -n SkyShop.API
dotnet new classlib -n Infrastructure

dotnet sln add SkyShop.API/SkyShop.API.csproj
dotnet sln add Infrastructure/Infrastructure.csproj
-----------------
