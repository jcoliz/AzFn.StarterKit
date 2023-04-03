# Deployment scripts

This project uses Bicep modules from the [AzDeploy.Bicep](https://github.com/jcoliz/AzDeploy.Bicep) project. Please be sure you've cloned this repo with submodules to ensure you have these locally!

The starter kit uses the basic [fn-storage](https://github.com/jcoliz/AzDeploy.Bicep/blob/main/Web/fn-storage.bicep) module to deploy just the app and related storage.

For more specific configuration, a solution-specific deployment would be needed. See the [AzFn.IoTHubTrigger deployment script](https://github.com/jcoliz/AzFn.IoTHubTrigger/blob/main/.azure/deploy/azuredeploy.bicep) as an example.