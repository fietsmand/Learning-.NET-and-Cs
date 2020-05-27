## .NET Commands

```
dotnet restore
```
The `dotnet restore` command uses NuGet to restore dependencies as well as tools specified in the `.csproj` file.
This command is implicitly run when executing the following commands:

```
dotnet new
dotnet build
dotnet build-server
dotnet run
dotnet test
dotnet publish
dotnet pack
```

---
```
dotnet new <TEMPLATE>
``` 
Creates a new project based on an optional template

---

```bash
dotnet build
```

Builds a project and all dependencies

---

```bash
dotnet build-server <COMMAND>
```

Can be used to interact with servers started by a build.
The only command at this point is `shutdown`

```bash
dotnet build-server shutdown
```

Will shut down (by default) all servers started from dotnet

---

```bash
dotnet run
```

Will run the source code of the current project.
This command relies on the `dotnet build` command to build the code.

---

```bash
dotnet test
```

Builds the project and runs a test host application for each test project.

---

```bash
dotnet publish 

--output <OUTPUT_DIRECTORY>
```

Publishes the application to a folder for deployment to a hosting system

Compiles the application, reads through the dependencies and then publishes the remaining files to a directory

You might have to specify the runtime to create an executable for OSX like this:

```dotnet
    dotnet publish -r <RUNTIME>[e.g. osx.10.10-x64]
```

---

```bash
dotnet pack
```

Packs the code into a NuGet package.
Builds project and creates NuGet Packages (.nupkg files)