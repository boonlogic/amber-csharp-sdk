.PHONY: build install test clean

# Reasonable default GOPATH and INSTALL_ROOT
TOP?=$(shell cd ../.. && git rev-parse --show-toplevel)
-include $(TOP)/mk/base.mk

#Mono:
#sudo apt install gnupg ca-certificates
#sudo apt-key adv --keyserver hkp://keyserver.ubuntu.com:80 --recv-keys 3FA7E0328081BFF6A14DA29AA6A19B38D3D831EF
#echo "deb https://download.mono-project.com/repo/ubuntu stable-bionic main" | sudo tee /etc/apt/sources.list.d/mono-official-stable.list
#sudo apt update
#sudo apt install mono-devel
#wget https://dist.nuget.org/win-x86-commandline/latest/nuget.exe

$(info INSTALL_ROOT=$(INSTALL_ROOT))

cwd  := $(shell pwd)

default: build

clean:
	rm $(INSTALL_ROOT)/lib/*


packages:
	mkdir -p bin
	mono nuget.exe install src/BoonAmber/packages.config -o packages
	cp packages/Newtonsoft.Json.*/lib/net45/Newtonsoft.Json.dll bin/Newtonsoft.Json.dll
	cp packages/RestSharp.*/lib/net45/RestSharp.dll bin/RestSharp.dll
	cp packages/JsonSubTypes.*/lib/net45/JsonSubTypes.dll bin/JsonSubTypes.dll

build:
	msbuild src/BoonAmber/BoonAmber.csproj

install: 
	mkdir -p $(INSTALL_ROOT)/lib && \
	cp -r src/BoonAmber/bin/* $(INSTALL_ROOT)/lib/

test: build
	TEST_LICENSE_FILE=$(cwd)/src/BoonAmber.Test/test.Amber.license dotnet test src/BoonAmber.Test/BoonAmber.Test.csproj

run: build
	dotnet run --project src/examples/examples.csproj
