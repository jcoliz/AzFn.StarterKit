# Azure Functions Starter Kit

This is a simple Azure Functions App which can be used as a template for a new project.

## What's Here?

* **Complete ARM Template**: Deploys a Function App and related storage using Bicep modules. See [.azure/deploy/](/.azure/deploy/).
* **Code Examples**: Very simple sample code to respond to an HTTP trigger. See [Hello.cs](/StarterKit/Hello.cs).
* **Azure Dev Ops Pipeline Definitions**: Ready-to-use pipelines for [Continuous Integration](/.azure/pipelines/ci.yaml) and [Continuous Deployment](/.azure/pipelines/cd.yaml).


## References

* [ADO Azure Functions Sample](https://github.com/microsoft/devops-project-samples/tree/master/dotnet/aspnetcore/functionApp/Application)
* [Azure Functions: Continuous delivery with Azure Pipelines](https://learn.microsoft.com/en-us/azure/azure-functions/functions-how-to-azure-devops)
