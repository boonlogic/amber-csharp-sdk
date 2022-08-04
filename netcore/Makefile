.PHONY: build install test clean

# Reasonable default GOPATH and INSTALL_ROOT
TOP?=$(shell cd ../.. && git rev-parse --show-toplevel)
-include $(TOP)/mk/base.mk

$(info INSTALL_ROOT=$(INSTALL_ROOT))

cwd  := $(shell pwd)

default: build

clean:
	rm $(INSTALL_ROOT)/lib/*

build: 
	dotnet build src/BoonAmber/BoonAmber.csproj

install: 
	mkdir -p $(INSTALL_ROOT)/lib && \
	cp -r src/BoonAmber/bin/* $(INSTALL_ROOT)/lib/

test: build
	TEST_LICENSE_FILE=$(cwd)/src/BoonAmber.Test/test.Amber.license dotnet test src/BoonAmber.Test/BoonAmber.Test.csproj

run: build
	dotnet run --project src/examples/examples.csproj
