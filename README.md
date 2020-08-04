 # Sve-Blazor-ChipsInput

Chips/Tags input component for Blazor

![Main gif](/Sve-Blazor-ChipsInput-Examples/Content/Main.gif)


### Installation
1. Install the [NuGet](https://www.nuget.org/packages/Sve.Blazor.ChipsInput/) package:

   ```
   > dotnet add package Sve.Blazor.ChipsInput
   
   OR
   
   PM> Install-Package Sve.Blazor.ChipsInput
   ```
   Use the `--version` option to specify a specific version to install.

   Or use the build in NuGet package manager of your favorite IDEA. Simply search for `Sve.Blazor.ChipsInput`, select a version and hit install.

2. Import the component:

   Add the following using statement `@using Sve.Blazor.ChipsInput.Components` to one of the following: 
   - For global import add it to your  `_Imports.razor` file
   - For a scoped import add  it to your desired Blazor component


## Usage

| Name                             | Type                              | Default                                                   | Description                                                  |
| -------------------------------- | --------------------------------- | --------------------------------------------------------- | ------------------------------------------------------------ |
| Chips                            | List<string>                      | List                                                      | The list of chips/tags                                       |
| OnChipsChanged                   | EventCallback<List<string>>       | null                                                      | The callback which is called when the chips/tags list has changed |
| ReadonlyChips                    | bool                              | false                                                     | Indicates whether or not chips are readonly                  |
| AllowedValues                    | List<string>?                     | null                                                      | A list of allowed chip/tag values                            |
| AllowedValueValidationMessage    | string                            | "The value is not present in the allowed values list"     | The validation message to use when the chip/tag value is not present in the AllowedValues list |
| ChipClass                        | string                            | ""                                                        | The css class placed on every chip                           |
| ChipsListClass                   | string                            | ""                                                        | The css class placed on the list tag of the chips            |
| ChipsContainerClass              | string                            | ""                                                        | The css class placed on the container of the chips input     |
| EnableBackspaceRemove            | bool                              | true                                                      | Indicates whether or not backspace will remove the last chip |
| ShowValidationErrors             | bool                              | false                                                     | Indicates whether or not to show validation errors           |
| AllowEmptyValue                  | bool                              | false                                                     | Indicates whether or not empty values are allowed as a value |
| AllowEmptyValueValidationMessage | string                            | "An empty input is not allowed"                           | The validation message to use when the AllowEmptyValue rule is not respected |
| MaxValueCount                    | int?                              | null                                                      | The maximum number of chips                                  |
| MaxValueCountValidationMessage   | string                            | "The max amount of chip values has been reached"          | The validation message to use when the MaxValueCount rule is not respected |
| MinValueLength                   | int?                              | null                                                      | The minimum value length of a chip                           |
| MinValueLengthValidationMessage  | string                            | "The chip value doesn't meet the min length requirements" | The validation message to use when the MinValueLength rule is not respected |
| MaxValueLength                   | int?                              | null                                                      | The maximum value length of a chip                           |
| MaxValueLengthValidationMessage  | string                            | "The chip value exceeds the max length requirements"      | The validation message to use when the MaxValueLength rule is not respected |
| ShowInputOutline                 | bool                              | Indicates whether or not to show the text input outline   | Indicates whether or not to show the text input outline      |
| CustomValidation                 | EventCallback<ChipValidationArgs> | null                                                      | Callback to perform custom validation                        |
| PrependIconTemplate              | RenderFragment?                   | null                                                      | Custom template for prepending an icon to the chip           |
| ValidationErrorTemplate          | RenderFragment<string>?           | null                                                      | Custom template for showing validation errors, make sure to set 'ShowValidationErrors' to true in order for validation errors to render |
| InputBorderRadius                | double                            | .25                                                       | The border radius of the chip input container in rem         |
| ChipBorderRadius                 | double                            | .25                                                       | The border radius of the chip in rem                         |
| InputAttributes                  | Dictionary<string, object>        | Dictionary                                                | Custom attributes for the text input                         |

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details
