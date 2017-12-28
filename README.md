# HRIS

Tools VS Extensions: Go to https://visualstudiogallery.msdn.microsoft.com/ or install it directly from your Visual Studio (Tools > Extensions and Updates > Online > Visual Studio Gallery)
  - CodeMaid
  - AttachTo-Next
  - SlowCheetah
  
To Generate Database
1. Update App.Config ConnectionStrings base on your database.
2. Go to "Package Manager Console" and input "Update-Database", It will create database, tables and seed database

Note: Please make sure your default project is HRIS.Data just incase Update-Database is not working