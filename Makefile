.PHONY: build install test clean

# Reasonable default GOPATH and INSTALL_ROOT
TOP?=$(shell cd .. && git rev-parse --show-toplevel)
-include $(TOP)/mk/base.mk

$(info VENV_DIR=$(VENV_DIR))
$(info INSTALL_ROOT=$(INSTALL_ROOT))

default: build

clean:
	rm $(INSTALL_ROOT)/lib/*

build: 
	dotnet build src/BoonAmber/BoonAmber.csproj

install: 
	mkdir -p $(INSTALL_ROOT)/lib && \
	cp -r src/BoonAmber/bin/* $(INSTALL_ROOT)/lib/

test: build
	dotnet test src/BoonAmber.Test/BoonAmber.Test.csproj

run: build
	dotnet run src/examples/examples.csproj

generate:
	mv README.md README.copy && \
	bin/swagger-codegen generate -i amber-api.json -l csharp -c swagger-config.json && \
	rm -rf git_push.sh && \
	mv README.copy README.md