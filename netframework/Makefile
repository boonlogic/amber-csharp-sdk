.PHONY: build packages install test clean run

# Reasonable default GOPATH and INSTALL_ROOT
TOP?=$(shell cd ../.. && git rev-parse --show-toplevel)
-include $(TOP)/mk/base.mk

#Mono + Nuget:
#sudo apt install gnupg ca-certificates
#sudo apt-key adv --keyserver hkp://keyserver.ubuntu.com:80 --recv-keys 3FA7E0328081BFF6A14DA29AA6A19B38D3D831EF
#echo "deb https://download.mono-project.com/repo/ubuntu stable-bionic main" | sudo tee /etc/apt/sources.list.d/mono-official-stable.list
#sudo apt update
#sudo apt install mono-devel nunit-console
#sudo wget https://dist.nuget.org/win-x86-commandline/latest/nuget.exe -O /usr/local/bin/nuget.exe
#sudo chmod +x /usr/local/bin/nuget.exe
#mono /usr/local/bin/nuget.exe sources add -source https://api.nuget.org/v3/index.json
#mono /usr/local/bin/nuget.exe sources list

$(info INSTALL_ROOT=$(INSTALL_ROOT))

CWD  := $(shell pwd)
NUGET_CLI?=/usr/local/bin/nuget.exe

default: build

clean:
	rm $(INSTALL_ROOT)/lib/*


packages:
	mkdir -p bin
	mono $(NUGET_CLI) install src/BoonAmber/packages.config -o packages
	mono $(NUGET_CLI) install src/BoonAmber.Test/packages.config -o packages
	cp packages/Newtonsoft.Json.*/lib/net45/Newtonsoft.Json.dll bin/Newtonsoft.Json.dll
	cp packages/RestSharp.*/lib/net452/RestSharp.dll bin/RestSharp.dll
	cp packages/JsonSubTypes.*/lib/net45/JsonSubTypes.dll bin/JsonSubTypes.dll
	cp packages/xunit.*/lib/net20/xunit.dll bin/xunit.dll

build:
	msbuild src/BoonAmber/BoonAmber.csproj

install: 
	mkdir -p $(INSTALL_ROOT)/lib && \
	cp -r src/BoonAmber/bin/* $(INSTALL_ROOT)/lib/

test: build
	msbuild src/BoonAmber.Test/BoonAmber.Test.csproj 
	TEST_LICENSE_FILE=$(CWD)/src/BoonAmber.Test/test.Amber.license nunit-console src/BoonAmber.Test/bin/Debug/BoonAmber.Test.dll

run: build
	msbuild run --project src/examples/examples.csproj
