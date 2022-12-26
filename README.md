
# dotnet6-api project
Ministered by Stephany Henrique de Almeida Batista
![Udemy](https://img.shields.io/badge/Udemy-A100FF?style=for-the-badge&logo=Udemy&logoColor=white&link=https://ifood.udemy.com/user/stephany-henrique-de-almeida-batista/)

## 🚀 Frameworks & Library

![VisualCode](https://img.shields.io/badge/VSCode-0078D4?style=for-the-badge&logo=visual%20studio%20code&logoColor=white&link=https://code.visualstudio.com/download)
![Rancher](https://img.shields.io/badge/Rancher-0075A8?style=for-the-badge&logo=rancher&logoColor=white&link=https://rancher.com/docs/)
![MSSQL](https://img.shields.io/badge/Microsoft_SQL_Server_/_DOCKER_CONTAINER-CC2927?style=for-the-badge&logo=microsoft-sql-server&logoColor=white&link=https://learn.microsoft.com/en-us/sql/linux/quickstart-install-connect-docker?view=sql-server-ver16&pivots=cs1-bash)
![Azure Data Studio](https://img.shields.io/badge/Azure_Data_studio-0078D7?style=for-the-badge&logo=azure-devops&logoColor=white&link=https://azure.microsoft.com/pt-br/products/data-studio/)
![Nuget](https://img.shields.io/badge/NuGet-004880?style=for-the-badge&logo=nuget&logoColor=white&link=https://nuget.org/)
![Postman](https://img.shields.io/badge/Postman-FF6C37?style=for-the-badge&logo=Postman&logoColor=white&link=https://www.postman.com/)
## 📚 How to use
- Install Rancher Desktop and WSL
- Download SQL Server container and run the docker image
```
docker pull mcr.microsoft.com/mssql/server:2022-latest
docker run -e "ACCEPT_EULA=Y"  -e "MSSQL_SA_PASSWORD=@Sql2022"  -p 1433:1433  --name sqlserver --hostname sql1  -d mcr.microsoft.com/mssql/server:2022-latest
```
- Use Azure Data Studio to connect to database
- Clone this project
- Install the nuget packages and tools
```
dotnet tool install --global dotnet-ef
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet tool install --global dotnet-outdated-tool
```
- Update database with migrations
```
dotnet ef database update
```
- Build
```
dotnet build
```
- Run
```
dotnet run
```

## ✅ Endpoints
### Use Postman to requests
- **Insert Product**
Method: POST
Url: https://localhost:3001/products
Body: 
```
{
"code":  "113",
"name":  "HD++",
"description":  "HD1",
"categoryId":  "1",
"tags":  ["tech",  "hds",  "hardware"]
}
```
- **List Product**
Method: GET
Url: https://localhost:3001/{id}
Body: ***empty***

- **Edit Product**
Method: POST
Url: https://localhost:3001/{id}
Body: 
```
{
"code":  "113",
"name":  "HD++",
"description":  "HD2",
"categoryId":  "1",
"tags":  ["hardware"]
}
```
- **Delete Product**
Method: POST
Url: https://localhost:3001/{id}
Body: ***empty***

## 👨🏻‍💻 Author
<a  href="https://www.linkedin.com/in/andrebelluci/">
<img  style="border-radius: 50%;"  src="https://code.ifoodcorp.com.br/uploads/-/system/user/avatar/1822/avatar.png?width=90"  width="100px;"  alt=""/>
<br />

**André Belluci**

![StackOverflow](https://img.shields.io/badge/Stack_Overflow-FE7A16?style=for-the-badge&logo=stack-overflow&logoColor=white&link=https://stackoverflow.com/users/8166695/andr%c3%a9-belluci)
![LinkedIn Badge](https://img.shields.io/badge/LinkedIn-0077B5?style=for-the-badge&logo=linkedin&logoColor=white&link=https://www.linkedin.com/in/andrebelluci/)
![Gmail Badge](https://img.shields.io/badge/Gmail-D14836?style=for-the-badge&logo=gmail&logoColor=white&link=mailto:andrebelluci@gmail.com)
![Instagram](https://img.shields.io/badge/Instagram-E4405F?style=for-the-badge&logo=instagram&logoColor=white&link=https://instagram.com/andrebelluci)
![Telegram](https://img.shields.io/badge/Telegram-2CA5E0?style=for-the-badge&logo=telegram&logoColor=white&link=https://t.me/andrebelluci)
![Strava](https://img.shields.io/badge/Strava-FC4C02?style=for-the-badge&logo=strava&logoColor=white&link=https://www.strava.com/athletes/7420087)