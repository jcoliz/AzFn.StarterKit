$env:RESOURCEGROUP = "azfunc"
az group create --name $env:RESOURCEGROUP --location "West US 2"
az deployment group create --name "Func-$(Get-Random)" --resource-group $env:RESOURCEGROUP --template-file "azuredeploy.json"
