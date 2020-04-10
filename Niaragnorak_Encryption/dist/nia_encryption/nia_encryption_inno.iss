; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "nia_Encryption"
#define MyAppVersion "1.5"
#define MyAppPublisher "Niaragnorak"
#define MyAppURL "http://www.github.com/Python_encryption"
#define MyAppExeName "Niaragnorak_Encryption.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{62002298-C7A8-4ECE-AA63-ED1EC4EABE6D}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={pf}\{#MyAppName}
DefaultGroupName={#MyAppName}
OutputDir=C:\Users\Nilansh Thakur\Desktop\MY PROJECTS\python_encryption\python_encrpytion_GUI\Niaragnorak_Encryption\dist\nia_encryption
OutputBaseFilename=setup
SetupIconFile=C:\Users\Nilansh Thakur\Desktop\MY PROJECTS\python_encryption\python_encrpytion_GUI\Niaragnorak_Encryption\img1.ico
Compression=lzma
SolidCompression=yes

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "C:\Users\Nilansh Thakur\Desktop\MY PROJECTS\python_encryption\python_encrpytion_GUI\Niaragnorak_Encryption\dist\Niaragnorak_Encryption.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Python\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

