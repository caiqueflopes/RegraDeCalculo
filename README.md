# Regra_De_Calculo_Pasch

FullStack C# + Angular

FRONT
-----------------------------------------------------
	TECNOLOGIAS
	BOOTSTRAP 4 ANGULAR 13
-----------------------------------------------------
Certifique-se angular cli esta instalado (npm install -g @angular/cli)

Install NodeJs from NodeJs Official Page

Open Terminal

Go to your file project

Run in terminal: npm install -g @angular/cli@latest

Then: npm install

And: npm start
------------------------------------------------
BACK
.NetFramework 5.0
-----------------------------------------------
	INICIALIZAÇÃO-----------
	intalar nuget EntityFrameworkCore.Design(version 5.0)
	intalar nuget EntityFrameworkCore.Sqlite(version 5.0)
	intalar dotnet tool install --global dotnet-ef
	EXECUTAR dotnet clean
	EXECUTAR dotnet build
		PARA CRIAR MIGAÇÃO-----------------
			EXECUTAR dotnet ef migrations add InitialCreation
		DPS DA MIGRAÇÃO CRIADA-------------
			EXECUTAR dotnet ef migrations add NovoCampoData
			EXECUTAR dotnet ef database update
			EXECUTAR dotnet watch run
-------------------------------------------------------
