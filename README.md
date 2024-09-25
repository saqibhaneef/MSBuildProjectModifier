
```markdown
# MSBuildProjectModifier

**MSBuildProjectModifier** is a .NET library that simplifies adding and managing file references in MSBuild project files. The library provides functionality to programmatically add file references, check if references exist, and verify if project files are present.

## Features
- Add references to files in MSBuild project files.
- Check if a reference to a file already exists in the project.
- Verify if an MSBuild project file exists.

## Installation

Install the NuGet package via the .NET CLI:

```bash
dotnet add package MSBuildProjectModifier
```

Or use the NuGet Package Manager in Visual Studio:

```bash
Install-Package MSBuildProjectModifier
```
## Sample Project : [MSBuild Project Modifier Sample](https://github.com/saqibhaneef/MSBuild-Project-Modifier-Sample)

## Usage

### 1. Add a File Reference to an MSBuild Project

You can use the `AddReference` method to add a file reference to an MSBuild project. If the reference already exists, no changes are made.

```csharp
using MSBuildProjectModifier;
using Microsoft.Build.Evaluation;

public class Example
{
    private readonly IMsBuildManager _msBuildManager;

    public Example(IMsBuildManager msBuildManager)
    {
        _msBuildManager = msBuildManager;
    }

    public void AddReferenceToProject()
    {
        string projectFilePath = @"path\to\your\project.csproj";
        string filePath = @"path\to\your\file.config";
        string itemType = "Content";
        MsBuildProjectModifierLoadOptions loadSettings = MsBuildProjectModifierLoadOptions.Default;

        _msBuildManager.AddReference(projectFilePath, filePath, itemType, loadSettings);
    }
}
```

### 2. Check if a Reference Exists

You can use the `IsReferenceExists` method to check if a reference to a specific file exists in the MSBuild project file.

```csharp
public bool CheckReferenceExists()
{
    string projectFilePath = @"path\to\your\project.csproj";
    string filePath = @"path\to\your\file.config";
    string attribute = "Include";
    LoadOptions loadOptions = LoadOptions.None;

    return _msBuildManager.IsReferenceExists(projectFilePath, filePath, attribute, loadOptions);
}
```

### 3. Check if a Project File Exists

You can use the `IsProjectExists` method to check if the given MSBuild project file exists.

```csharp
public bool CheckProjectExists()
{
    string projectFilePath = @"path\to\your\project.csproj";
    return _msBuildManager.IsProjectExists(projectFilePath);
}
```

## API

### `AddReference(string projectFilePath, string filePath, string itemType, MsBuildProjectModifierLoadOptions projectLoadSettings)`
- **projectFilePath**: Full path to the MSBuild project file.
- **filePath**: Full path to the file you want to add as a reference.
- **itemType**: The type of item to add (e.g., `Content`, `Reference`).
- **projectLoadSettings**: Settings used to load the MSBuild project.

### `IsReferenceExists(string projectFilePath, string filePath, string attribute, LoadOptions loadOptions)`
- **projectFilePath**: Full path to the MSBuild project file.
- **filePath**: Full path to the file reference to check.
- **attribute**: Attribute to check (e.g., `Include`).
- **loadOptions**: XML load options for parsing the project file.

### `IsProjectExists(string projectFilePath)`
- **projectFilePath**: Full path to the MSBuild project file.
- **Returns**: `True` if the project file exists, otherwise `False`.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.
