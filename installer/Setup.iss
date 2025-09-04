; installer/MyApp.iss
#define MyAppName "Test App"
#define MyAppPublisher "atkhssn"
#define MyAppURL "https://github.com/atkhssn/TestApp"
#ifndef MyAppVersion
  #define MyAppVersion "0.1.0"
#endif

#ifndef SourceDir
  #define SourceDir "src\TestApp\bin\Release\net9.0-windows\win-x64\publish"
#endif

[Setup]
AppId={{7D79C2EA-7DAB-4D54-93E4-0B9DAB8A5C9A}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
DefaultDirName={autopf}\{#MyAppName}
DefaultGroupName={#MyAppName}
OutputDir=dist
OutputBaseFilename={#MyAppName}-{#MyAppVersion}-setup
Compression=lzma
SolidCompression=yes
WizardStyle=modern
UninstallDisplayIcon={app}\Test-App.exe

[Files]
Source: "{#SourceDir}\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\Test-App.exe"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\Test-App.exe"; Tasks: desktopicon

[Tasks]
Name: "desktopicon"; Description: "Create a &desktop shortcut"; GroupDescription: "Additional icons:"; Flags: unchecked

[Run]
Filename: "{app}\Test-App.exe"; Description: "Launch {#MyAppName}"; Flags: nowait postinstall skipifsilent
