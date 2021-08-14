$env:DOTNET_TieredPGO=1
dotnet build -c Release ./Repro/TieredPGORepro.csproj
dotnet run -c Release --project ./Repro/TieredPGORepro.csproj
