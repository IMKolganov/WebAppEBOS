# WebAppEBOS

"C:\Program Files\dotnet\dotnet.exe" ef migrations add --project WebAppEBOS.Entity\WebAppEBOS.Entity.csproj --startup-project WebAppEBOS.App\WebAppEBOS.csproj --context WebAppEBOS.Data.ApplicationDbContext --configuration Debug Initial --output-dir Migrations


"C:\Program Files\dotnet\dotnet.exe" ef database drop --project WebAppEBOS.Entity\WebAppEBOS.Entity.csproj --startup-project WebAppEBOS.App\WebAppEBOS.csproj --configuration Debug --force


"C:\Program Files\dotnet\dotnet.exe" ef database update --project WebAppEBOS.Entity\WebAppEBOS.Entity.csproj --startup-project WebAppEBOS.App\WebAppEBOS.csproj --context WebAppEBOS.Data.ApplicationDbContext --configuration Debug 20230816135708_Initial
