; -------------------------------------------------------------
; Inno Setup Script for TestApp
; This script is configured for GitHub Actions CI/CD workflow
; -------------------------------------------------------------

#define MyAppName "TestApp"
#define MyAppPublisher "Your Company"
#define MyAppURL "https://github.com/atkhssn/TestApp/"
#define MyAppExeName "TestApp.exe"

; Version is passed from CI workflow: /DMyAppVersion="x.y.z"
#ifndef MyAppVersion
  #define MyAppVersion "0.0.0-dev"
#endif

; SourceDir is passed from CI workflow: /DSourceDir="publish-folder"
#ifndef SourceDir
  #define SourceDir "src\TestApp\bin\Release\net9.0-windows\win-x64\publish"
#endif

[Setup]
AppId={{A1B2C3D4-E5F6-1234-ABCD-987654321000}  ; Generate your own GUID
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
DefaultDirName={autopf}\{#MyAppName}
DefaultGroupName={#MyAppName}
UninstallDisplayIcon={app}\{#MyAppExeName}
Compression=lzma
SolidCompression=yes
OutputDir=dist
OutputBaseFilename={#MyAppName}-Setup-{#MyAppVersion}
;SetupIconFile=installer\app.ico
PrivilegesRequired=lowest

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "{#SourceDir}\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "Launch {#MyAppName}"; Flags: nowait postinstall skipifsilent
