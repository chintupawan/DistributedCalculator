az extension add --name containerapp --upgrade

az provider register --namespace Microsoft.App


az containerapp update -n calculator-api -g pa1-poc-rg --image pa1pocacr.azurecr.io/additionapi:0.2 --registry-server pa1pocacr.azurecr.io  --registry-password g8PoBg9Ul6EQnngEvQ6ldvOA/ZGiLmh5 --registry-username pa1pocacr