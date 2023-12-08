---
services: app-service\web,app-service
platforms: dotnet
author: tiagocostapt
---

# Based on the ASP.NET sample for Azure App Service

This was originally ASP.NET MVC web app template, which I adapted to my specific use case!
This is deployed to an Azure App Service through Git, which has a build and test workflow. Once that is successful, it is also tested by an AzureDevOps pipeline that uses a locally hosted Agent in order to test "visiting" the webpage.

## License

See [LICENSE](LICENSE).
