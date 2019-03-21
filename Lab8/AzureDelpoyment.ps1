#Script allows to deploy ARM template from local machine
#Use only if Build definition is not available from VSTS level
Connect-AzureRmAccount
Select-AzureRmSubscription -TenantId '4ec96a97-5e57-4557-83e5-84db076ad6df'
Get-AzureRmResourceGroup -Name 'dataplatformDBRCloudRGdev'
New-AzureRmResourceGroupDeployment -Name 'AzureArchDeployment' -ResourceGroupName 'dataplatformDBRCloudRGdev' `

#Make sure that you are using newest version of the repo with correct branch
#Make sure that paths to files are up to date

#Local deployment from local files
New-AzureRmResourceGroupDeployment -ResourceGroupName dataplatformDBRCloudRGdev `
 -TemplateFile "C:\...\azuredeploy.json"`
 -TemplateParameterFile "C:\...\azuredeploy.parameters.json"

