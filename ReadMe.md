az login

az account set -s"YourSub" 
az group create --name my-poc-rg --location AustraliaEast

#create ACR
az acr create --resource-group my-poc-rg --name mypocacr --sku Basic

#Build images using ACR with the local DockerFiles
az acr build --registry mypocacr --image additionapi:0.1 -f .\additionapi\Dockerfile .
az acr build --registry mypocacr --image subtraction:0.1 -f .\subtractionapi\Dockerfile .

#List all the repos
az acr repository list --name mypocacr

#Create AKS Cluster
az aks create --resource-group my-poc-rg --name my-poc-k8s --node-count 1 --generate-ssh-keys
#Attach ACR to AKS Cluster
az aks update -n my-poc-k8s -g my-poc-rg --attach-acr mypocacr