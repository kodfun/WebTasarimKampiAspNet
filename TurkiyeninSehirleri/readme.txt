Tools > NuGet Package Manager > Package Manager Console

Default project: TurkiyeninSehirleri

Install-Package Microsoft.EntityFrameworkCore
Install-Package Microsoft.EntityFrameworkCore.SqlServer
Install-Package Microsoft.EntityFrameworkCore.Tools


-- Veritabanını Oluşturma
Add-Migration Ilk
Update-Database