.PHONY: build install test clean

# Reasonable default GOPATH and INSTALL_ROOT
TOP?=$(shell cd .. && git rev-parse --show-toplevel)
-include $(TOP)/mk/base.mk

CWD  := $(shell pwd)
AMBER_TEST_LICENSE_FILE?=$(CWD)/src/BoonAmber.Test/test.Amber.license
PKG_VERSION ?= 1.0.0

default: build

clean:
	rm $(INSTALL_ROOT)/lib/*

update_version:
	sed -i "s:<Version>.*</Version>:<Version>$(PKG_VERSION)</Version>:gi" src/BoonAmber/BoonAmber.csproj

build: update_version
	dotnet build src/BoonAmber/BoonAmber.csproj
	dotnet build src/BoonAmber.Test/BoonAmber.Test.csproj

install: 
	mkdir -p $(INSTALL_ROOT)/lib && \
	cp -r src/BoonAmber/bin/* $(INSTALL_ROOT)/lib/

test:
	AMBER_TEST_LICENSE_FILE=$(AMBER_TEST_LICENSE_FILE) dotnet test src/BoonAmber.Test/BoonAmber.Test.csproj

test-%:
	AMBER_TEST_LICENSE_ID=$* AMBER_TEST_LICENSE_FILE=$(AMBER_TEST_LICENSE_FILE)  dotnet test src/BoonAmber.Test/BoonAmber.Test.csproj

run:
	dotnet run --project src/examples/examples.csproj

package: update_version
	dotnet pack src/BoonAmber/BoonAmber.csproj
	dotnet nuget push src/BoonAmber/bin/Debug/BoonAmber.$(PKG_VERSION).nupkg --api-key $(NUGET_API_KEY) --source https://api.nuget.org/v3/index.json


# Generate will only update the models folder, DefaultAPI.cs will need to be modified
# Add other models to the list of git checkouts if needed
generate:
	codegen/openapi-codegen generate -i amber-api.json -g csharp-netcore -o swagger_temp --generate-alias-as-model -c swagger-config.json
	rm -rf src/BoonAmber/Model
	mv swagger_temp/src/BoonAmber/Model src/BoonAmber/
	rm -rf swagger_temp
	cd src/BoonAmber/Model/ && git checkout -- PCA.cs
