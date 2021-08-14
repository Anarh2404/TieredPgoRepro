$env:DOTNET_TieredPGO=0
dotnet build -c Release ./Repro/TieredPGORepro.csproj
dotnet run -c Release --project ./Repro/TieredPGORepro.csproj
