
param suffix string = uniqueString(resourceGroup().id)

param location string = resourceGroup().location


resource acr 'Microsoft.ContainerRegistry/registries@2021-09-01' = {
  name: 'cr${suffix}'
  location: location
  sku: {
    name:  'Basic'
  }
  properties: {
    adminUserEnabled: false
  }
}

output acrLoginServer string = acr.properties.loginServer
