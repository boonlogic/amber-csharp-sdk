# BoonAmber - the C# library for the Amber API Server

Boon Logic Amber API Server

Build Information:
- API version: 1.0.3
- SDK version: 1.0.0
- Build package: io.swagger.codegen.v3.generators.dotnet.CSharpClientCodegen

## Frameworks supported
- .NET Core >=1.0
- .NET Framework >=4.5.2
- Mono/Xamarin >=vNext
- UWP >=10.0

## Dependencies
- RestSharp >= 106.13.0
- JsonSubTypes >= 1.8.0
- Newtonsoft.Json >= 13.0.1
- Polly >= 7.2.3
- System.ComponentModel.Annotations >= 5.0.0

## Installation
Generate the DLL using your preferred tool

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using BoonAmber.Api;
using BoonAmber.Client;
using BoonAmber.Model;
```

## Getting Started

```csharp
using System;
using System.Diagnostics;
using BoonAmber.Api;
using BoonAmber.Client;
using BoonAmber.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {
            var apiInstance = new DefaultApi("default", "~/.Amber.license");

            try
            {
                // Try to get version
                var result = apiInstance.GetVersion();
                Console.WriteLine(result);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception when calling DefaultApi.GetVersion: " + e.Message );
            }
        }
    }
}