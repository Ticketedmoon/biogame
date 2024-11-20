# Biogame
A biographical web application about me built in C# and .NET

## Some useful commands to remember

### .NET

#### build a .NET project
```
dotnet build
```

#### run a .NET project
```
dotnet run 
```

**Note:** This uses the default profile from the launch settings (`launchSettings.json`)

#### run a .NET project under a specific profile
```
dotnet run --launch-profile "http"
dotnet run --launch-profile "https"
```

**Note:** This uses the specified profile from the launch settings (`launchSettings.json`)

#### execute a .NET project and recompile when any file change
```
dotnet watch
```

#### install a nuget package with dotnet cli
```
dotnet add package Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore
```

#### install a nuget package with a specific version with dotnet cli
```
dotnet add package Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore --version 8.0.11
```

### Git

#### Reset local branch back to the state of a remote branch
```
git reset --hard origin/main
```

#### Clean untracked files
```
git clean -d --force
```