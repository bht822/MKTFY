#Project Variables

PROJECT_NAME ?= MKTFY
ORG_NAME ?= MKTFY
REPO_NAME ?= MKTFY

.PHONY: migrations db build docker rebuild

migrations:
		cd ./MKTFY.App && dotnet ef --startup-project ../MKTFY.Api/ migrations add $(mname) && cd ..

db:
	cd ./MKTFY.App && dotnet ef --startup-project ../MKTFY.Api/  database update && cd ..

build:
	dotnet build MKTFY.sln

docker: 
	docker-compose $(f) 
rebuild:
	docker-compose build && dockre-compose up

