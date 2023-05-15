# Setup

`dotnet new console --name MySite`

`cd MySite`

`dotnet add package Statiq.Web --version 1.0.0-beta.54`

Update [Program.cs](../src/Program.cs)

```csharp
using System.Threading.Tasks;
using Statiq.App;
using Statiq.Web;

return await Bootstrapper
  .Factory
  .CreateWeb(args)
  .RunAsync();
```

`mkdir input`

`touch index.md`

```md
Title: My First Statiq page
---
# Hello World!

Hello from my first Statiq page.

Testing
```

`dotnet run`

`dotnet run -- preview`

- http://localhost:5080
