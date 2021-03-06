# Ethos Integration SDK C# Object Library

This repository contains generated C# objects for use with the Ethos Integration SDK (EISDK) for C#. The code in this repository is not manually maintained, but rather is generated and pushed by an automated process to this repository. _FOR THIS REASON, CONTRIBUTIONS TO THIS REPOSITORY ARE NOT ACCEPTED, BUT FORKING OF THIS REPOSITORY IS ENABLED_. The binaries for this library are available on NuGet.  

This contains the C# objects for both the Eedm and Bpapi object libraries.

Following are the instructions on how to add a NuGet package reference in DotNet project:

1. Right click on "Dependencies" under your dotnet project
2. Then select "Manage NuGet Packages"
3. Under the browse tab in the search text box type "Ellucian.Generated" and hit enter
4. The result should have "Ellucian.Generated.Eedm" and "Ellucian.Generated.BpApi.Ban" libraries
5. You can then select each library by selecting in the result window and clicking on the "Install" button in the right pane of the result window

Once installed you are ready to explore various objects and use them in your project.

C# sites for the EISDK C# object libraries:

[C# EISDK Object Library API Doc for BPAPIs](https://ellucian-developer.github.io/integration-sdk-objects-csharp-doc/Bpapi/Ban/)

[C# EISDK Object Library API Doc for EEDM APIs](https://ellucian-developer.github.io/integration-sdk-objects-csharp-doc/Eedm/)
