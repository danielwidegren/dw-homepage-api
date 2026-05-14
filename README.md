## Requirements
* dotnet 10

## Start dev server
`dotnet run`

## Check for outdated packages
`dotnet list package --outdated`

## Rebuild packages
`dotnet restore`

## Azure
https://portal.azure.com/#home

### Blob storage
Blob storage called "music1" via the "music" storage account.

#### Connection string
The blob storage connection string is available in Azure via Storage account > Security + networking > Access keys.

#### Development environment blob storage secret
## dotnet user-secrets
* `dotnet user-secrets init` - generates id for user secrets in project.
* `dotnet user-secrets set "BlobConnectionString" "<secret value>"` - stores the secret.

## SSH
### Lägga till nyckel (i powershell)
1. ssh-keygen -t ed25519 -C "your_email@example.com"
2. `Start-Service ssh-agent`.
  * Vid fel, testa `Get-Service ssh`. Om den står som Stopped, kör först `Set-Service -Name ssh-agent -StartupType Automatic`, sen Start-Service kommandot igen.
3. `ssh-add ~/.ssh/id_ed25519`.
  * Om det inte funkar, kör exakt path, `ssh-add C:\Users\$env:USERNAME\.ssh\id_ed25519`.
4. `Get-Content ~/.ssh/id_ed25519.pub`. Kopiera och lägg in i Github.