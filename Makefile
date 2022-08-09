.PHONY: build install test clean

# Reasonable default GOPATH and INSTALL_ROOT
TOP?=$(shell cd .. && git rev-parse --show-toplevel)
-include $(TOP)/mk/base.mk

# "netcore" or "netframework"
DOTNET_VERSION?=netcore

build:
	make -C $(DOTNET_VERSION) build

install:
	make -C $(DOTNET_VERSION) install

test:
	make -C $(DOTNET_VERSION) test

test-%:
	AMBER_TEST_LICENSE_ID=$* make -C $(DOTNET_VERSION) test

run:
	make -C $(DOTNET_VERSION) run

package:
	echo 'TODO'

# Warning: make generate will overwrite some custom code
ifeq ($(DOTNET_VERSION), netcore)
generate:
	codegen/openapi-codegen generate -i amber-api.json -g csharp-netcore -o netcore --generate-alias-as-model -c netcore/swagger-config.json
else
generate:
	codegen/swagger-codegen generate -i amber-api.json -l csharp -o netframework -c netframework/swagger-config.json
endif
