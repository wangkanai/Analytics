#./dotnet-install.ps1 -Channel Current -version 3.0.100
dotnet --version
dotnet restore
dotnet build -c Release
dotnet test
dotnet pack -c Release -o .\artifacts
