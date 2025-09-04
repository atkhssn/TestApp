param(
  [string]$project = "src\TestApp\TestApp.csproj",
  [string]$version = "0.1.0"
)

dotnet restore $project
dotnet publish $project -c Release -r win-x64 --self-contained true /p:PublishSingleFile=true

# compile Inno Setup (adjust ISCC path if different)
& "C:\Program Files (x86)\Inno Setup 6\ISCC.exe" "installer\Setup.iss" /DMyAppVersion=$version /DSourceDir="$(Resolve-Path $PSScriptRoot\..\src\TestApp\bin\Release\net9.0-windows\win-x64\publish)"
