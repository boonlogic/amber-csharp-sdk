.PHONY: build install test clean

# Reasonable default GOPATH and INSTALL_ROOT
TOP?=$(shell cd ../.. && git rev-parse --show-toplevel)
-include $(TOP)/mk/base.mk

$(info INSTALL_ROOT=$(INSTALL_ROOT))

CWD  := $(shell pwd)
AMBER_TEST_LICENSE_FILE?=$(CWD)/src/BoonAmber.Test/test.Amber.license

default: build

clean:
	rm $(INSTALL_ROOT)/lib/*

build: 
	dotnet build src/BoonAmber/BoonAmber.csproj
	dotnet build src/BoonAmber.Test/BoonAmber.Test.csproj

install: 
	mkdir -p $(INSTALL_ROOT)/lib && \
	cp -r src/BoonAmber/bin/* $(INSTALL_ROOT)/lib/

test:
	AMBER_TEST_LICENSE_FILE=$(AMBER_TEST_LICENSE_FILE) dotnet test src/BoonAmber.Test/BoonAmber.Test.csproj

run:
	dotnet run --project src/examples/examples.csproj
