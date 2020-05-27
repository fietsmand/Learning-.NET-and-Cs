# .NET Commands


## `dotnet restore`

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

## `dotnet new`

```
dotnet new <TEMPLATE>
``` 
Creates a new project based on an optional template

---

## `dotnet build`

```bash
dotnet build
```

Builds a project and all dependencies

---

## `dotnet build-server`

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

## `dotnet run`

```bash
dotnet run
```

Will run the source code of the current project.
This command relies on the `dotnet build` command to build the code.

Running with `-p <PROJECT>` option allows you to specify the program to be run.

---

## `dotnet test`

```bash
dotnet test
```

Builds the project and runs a test host application for each test project.

---

## `dotnet publish`

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

## `dotnet pack`


```bash
dotnet pack
```

Packs the code into a NuGet package.
Builds project and creates NuGet Packages (.nupkg files)

---

## `dotnet sln`

```bash
dotnet sln
```

Lists or modifies the projects in a .NET Core Solution file.

```bash
dotnet sln <SOLUTION_FILE> add <PROJECT_PATH>
```

Adds project to the solution.

---

## `dotnet add`

```bash
dotnet add <PROJECT> [package | reference] <PACKAGE_NAME | PROJECT_PATH>
```

Add a NuGet package or a project-to-project reference to the project