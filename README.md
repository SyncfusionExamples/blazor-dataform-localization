# Blazor DataForm Localization

A compact example showing how to localize data-annotation labels, validation messages, and [DataForm](https://www.syncfusion.com/blazor-components/blazor-data-form) component strings in a Blazor Web App with hybrid rendering.

## Overview

This sample demonstrates a model-driven localization approach for **Syncfusion DataForm** with complete data annotation support. The `UserDetails` model demonstrates how to combine Display attributes with validation error localization to achieve full UI localization without writing localization code in components. The app runs in German (de-DE) by default and shows how all DataForm field labels, validation messages, and component UI strings are resolved from .resx files.

## Features

- **Localized Field Labels and Validation Messages**: Map data model properties to localized display names and validation error messages
- **Component String Localization**: Integrate custom resource provider with DataForm for UI string translation
- **Multi-Language Resource Files**: Support multiple cultures with neutral and culture-specific resource assemblies
- **Application Culture Configuration**: Set global culture for consistent localization across all components
- **Multiple Validation Attributes**: Localize error messages for different validation rules on the same property
- **Hybrid Rendering**: Localization works with both server-side and client-side interactive components

## Prerequisites

- [.NET SDK 8.0](https://dotnet.microsoft.com/download/dotnet/8.0) or later
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) or later
- [Visual Studio Code](https://code.visualstudio.com/)

## Getting started

### Clone the repository:

```bash
git clone https://github.com/SyncfusionExamples/blazor-dataform-localization.git
cd blazor-dataform-localization
```

### Run with Visual Studio

1. Open the solution file using Visual Studio 2022 or later.
2. Restore the NuGet packages by rebuilding the solution.
3. Build the project to ensure there are no compilation errors.
4. Run the project.

### Run with .NET CLI

```bash
# Restore dependencies
dotnet restore

# Run the project
dotnet run
```

## References

- https://blazor.syncfusion.com/documentation/common/localization
- https://blazor.syncfusion.com/documentation/data-form/localization