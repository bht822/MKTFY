#Project Variables

PROJECT_NAME ?= MKTFY
ORG_NAME ?= MKTFY
REPO_NAME ?= MKTFY

.PHONY: migrations db

migrations:
		cd ./MKTFY.App && dotnet ef --startup-project ../MKTFY.Api/ migrations add $(mname) && cd ..

db:
	cd ./MKTFY.App && dotnet ef --startup-project ../MKTFY.Api/  database update && cd ..


