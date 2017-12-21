# Getting started

# APIMATIC CodeGen as a Service

[APIMATIC](https://apimatic.io) is an automatic code generator for RESTful APIs. This API exposes the access to its underlying code
generation engine. We currently support the following format for API descriptions, `API Blueprint`, `RAML`,
`Google API Discovery`, `IODocs`, `WADL`, and  `Swagger`. Although most API descriptions can be used, not all API
decsriptions are written well-enough for automatic code generation and may fail the code generation process.
For this purpose, we have provided a verbose validation API, which can be used to improve your API description.

> **Looking for a way to convert between API description formats like Swagger and API Blueprint?** Try [APIMATIC's Transformer API](http://docs.apimatictransformerapi.apiary.io/#) or it's web version at [Transformer](https://apimatic.io/transformer).

[APIMATIC](https://apimatic.io) works in two modes i.e., perform operations on **pre-configured** API descriptions, and perform 
operations on API descriptions sent **on the fly** with requests. The later mode of operations has its
limitations with respect to the customization of the generated code through our *codegen settings*.

See [this article](https://docs.apimatic.io/api-editor/codegen-settings/)
for more information about customization of the output code.

## Working with pre-configured API descriptions

This mode of operation is useful where APIs are stable and therefore can be pre-configured in [APIMATIC](https://apimatic.io).
You can always update an API description in [APIMATIC](https://apimatic.io) using the API Editor by clicking on the *Edit* button.
When working with stored API descriptions, pre-configured *codegen settings* are used that allow customization
of the generated output. In order to uniquely identify the API to perform operations on, an *API Key* is used,
which can be retrieved using the API context menu. This *API Key* is a secret value and therefore operations
on pre-configured API descriptions do not require authentication.

See [this article](https://docs.apimatic.io/getting-started/manage-apis/#view-api-integration-key)
on how to get your API Key from [APIMATIC](https://apimatic.io).

## Working with API descriptions documents

This mode of operation is useful in cases where API descriptions are automatically generated from a process
or external source and cannot be pre-configured in [APIMATIC](https://apimatic.io). In this case code generation uses the default
*codegen settings*. However, if custom *codegen settings* are desired you may use the [APIMATIC](https://apimatic.io) format for
generating your API descriptions, which contains nested *codegen settings*. For getting the full benefit
of our advanced features in our code generator, you must either pre-configure your API, or use [APIMATIC](https://apimatic.io)
format for API description.

# APIMATIC API Transformer

[APIMATIC](https://www.apimatic.io) Transformer allows its users to convert between different API description formats e.g. `Swagger`, `RAML`, etc. This enables the user to benefit from a wide range of tools available associated with any format, not just one. 
The complete list of supported formats of [Transformer](https://apimatic.io/transformer) are: 

Inputs  			| Outputs
------------------  | -------------------
API Blueprint		| API Blueprint
Swagger v.1.2		| Swagger 1.2
Swagger 2.0 (JSON and YAML)	| Swagger 2.0 (JSON, YAML)
Open API v.3.0 	| Open API 3.0
WADL 2009 (W3C)	| WADL 2009 (W3C)
WSDL (W3C)		| WSDL (W3C)
Google Discovery    | RAML 0.8 - 1.0	
RAML 0.8 - 1.0	    | Postman Collection 1.0 - 2.0
I/O Docs - Mashery	| APIMATIC Format	
HAR 1.2		|
Postman Collection 1.0 - 2.0	|
APIMATIC Format		|
Mashape		|

## How to Build

The generated code uses the Newtonsoft Json.NET NuGet Package. If the automatic NuGet package restore
is enabled, these dependencies will be installed automatically. Therefore,
you will need internet access for build.

1. Open the solution (CodeGenAndTransformerAPI.sln) file.
2. Invoke the build process using `Ctrl+Shift+B` shortcut key or using the `Build` menu as shown below.

![Building SDK using Visual Studio](https://apidocs.io/illustration/cs?step=buildSDK&workspaceFolder=CodeGen%20and%20Transformer%20API-CSharp&workspaceName=CodeGenAndTransformerAPI&projectName=CodeGenAndTransformerAPI.PCL)

## How to Use

The build process generates a portable class library, which can be used like a normal class library. The generated library is compatible with Windows Forms, Windows RT, Windows Phone 8,
Silverlight 5, Xamarin iOS, Xamarin Android and Mono. More information on how to use can be found at the [MSDN Portable Class Libraries documentation](http://msdn.microsoft.com/en-us/library/vstudio/gg597391%28v=vs.100%29.aspx).

The following section explains how to use the CodeGenAndTransformerAPI library in a new console project.

### 1. Starting a new project

For starting a new project, right click on the current solution from the *solution explorer* and choose  ``` Add -> New Project ```.

![Add a new project in the existing solution using Visual Studio](https://apidocs.io/illustration/cs?step=addProject&workspaceFolder=CodeGen%20and%20Transformer%20API-CSharp&workspaceName=CodeGenAndTransformerAPI&projectName=CodeGenAndTransformerAPI.PCL)

Next, choose "Console Application", provide a ``` TestConsoleProject ``` as the project name and click ``` OK ```.

![Create a new console project using Visual Studio](https://apidocs.io/illustration/cs?step=createProject&workspaceFolder=CodeGen%20and%20Transformer%20API-CSharp&workspaceName=CodeGenAndTransformerAPI&projectName=CodeGenAndTransformerAPI.PCL)

### 2. Set as startup project

The new console project is the entry point for the eventual execution. This requires us to set the ``` TestConsoleProject ``` as the start-up project. To do this, right-click on the  ``` TestConsoleProject ``` and choose  ``` Set as StartUp Project ``` form the context menu.

![Set the new cosole project as the start up project](https://apidocs.io/illustration/cs?step=setStartup&workspaceFolder=CodeGen%20and%20Transformer%20API-CSharp&workspaceName=CodeGenAndTransformerAPI&projectName=CodeGenAndTransformerAPI.PCL)

### 3. Add reference of the library project

In order to use the CodeGenAndTransformerAPI library in the new project, first we must add a projet reference to the ``` TestConsoleProject ```. First, right click on the ``` References ``` node in the *solution explorer* and click ``` Add Reference... ```.

![Open references of the TestConsoleProject](https://apidocs.io/illustration/cs?step=addReference&workspaceFolder=CodeGen%20and%20Transformer%20API-CSharp&workspaceName=CodeGenAndTransformerAPI&projectName=CodeGenAndTransformerAPI.PCL)

Next, a window will be displayed where we must set the ``` checkbox ``` on ``` CodeGenAndTransformerAPI.PCL ``` and click ``` OK ```. By doing this, we have added a reference of the ```CodeGenAndTransformerAPI.PCL``` project into the new ``` TestConsoleProject ```.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=createReference&workspaceFolder=CodeGen%20and%20Transformer%20API-CSharp&workspaceName=CodeGenAndTransformerAPI&projectName=CodeGenAndTransformerAPI.PCL)

### 4. Write sample code

Once the ``` TestConsoleProject ``` is created, a file named ``` Program.cs ``` will be visible in the *solution explorer* with an empty ``` Main ``` method. This is the entry point for the execution of the entire solution.
Here, you can add code to initialize the client library and acquire the instance of a *Controller* class. Sample code to initialize the client library and using controller methods is given in the subsequent sections.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=addCode&workspaceFolder=CodeGen%20and%20Transformer%20API-CSharp&workspaceName=CodeGenAndTransformerAPI&projectName=CodeGenAndTransformerAPI.PCL)

## How to Test

The generated SDK also contain one or more Tests, which are contained in the Tests project.
In order to invoke these test cases, you will need *NUnit 3.0 Test Adapter Extension for Visual Studio*.
Once the SDK is complied, the test cases should appear in the Test Explorer window.
Here, you can click *Run All* to execute these test cases.

## Initialization

### Authentication
In order to setup authentication and initialization of the API client, you need the following information.

| Parameter | Description |
|-----------|-------------|
| basicAuthUserName | The username to use with basic authentication |
| basicAuthPassword | The password to use with basic authentication |



API client can be initialized as following.

```csharp
// Configuration parameters and credentials
string basicAuthUserName = "basicAuthUserName"; // The username to use with basic authentication
string basicAuthPassword = "basicAuthPassword"; // The password to use with basic authentication

CodeGenAndTransformerAPIClient client = new CodeGenAndTransformerAPIClient(basicAuthUserName, basicAuthPassword);
```



# Class Reference

## <a name="list_of_controllers"></a>List of Controllers

* [CodeGenerationController](#code_generation_controller)
* [APIDescriptionValidationController](#api_description_validation_controller)
* [APITransformerController](#api_transformer_controller)

## <a name="code_generation_controller"></a>![Class: ](https://apidocs.io/img/class.png "CodeGenAndTransformerAPI.PCL.Controllers.CodeGenerationController") CodeGenerationController

### Get singleton instance

The singleton instance of the ``` CodeGenerationController ``` class can be accessed from the API Client.

```csharp
CodeGenerationController codeGeneration = client.CodeGeneration;
```

### <a name="using_file_as_string"></a>![Method: ](https://apidocs.io/img/method.png "CodeGenAndTransformerAPI.PCL.Controllers.CodeGenerationController.UsingFileAsString") UsingFileAsString

> The code generation endpoint. The response is a path to the generated zip file relative to https://apimatic.io/


```csharp
Task<string> UsingFileAsString(
        string name,
        Models.Format format,
        Models.Template template,
        FileStreamInfo body,
        int? dl = 0)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| name |  ``` Required ```  | The name of the API being used for code generation |
| format |  ``` Required ```  | The format of the API description to use for code generation |
| template |  ``` Required ```  | The template to use for code generation |
| body |  ``` Required ```  | The input file to use for code generation |
| dl |  ``` Optional ```  ``` DefaultValue ```  | Optional |


#### Example Usage

```csharp
string name = "name";
var format = Models.FormatHelper.ParseString("Enum_API Blueprint");
var template = Models.TemplateHelper.ParseString("cs_portable_net_lib");
FileStreamInfo body = new FileStreamInfo(new FileStream(@"pathToFile",FileMode.Open));
int? dl = 0;

string result = await codeGeneration.UsingFileAsString(name, format, template, body, dl);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 401 | Unauthorized: Access is denied due to invalid credentials. |
| 412 | Precondition Failed |


### <a name="using_url_as_string"></a>![Method: ](https://apidocs.io/img/method.png "CodeGenAndTransformerAPI.PCL.Controllers.CodeGenerationController.UsingUrlAsString") UsingUrlAsString

> The code generation endpoint. The response is a path to the generated zip file relative to https://apimatic.io/


```csharp
Task<string> UsingUrlAsString(
        Models.Template template,
        Models.Format format,
        string name,
        string descriptionUrl,
        int? dl = 0)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| template |  ``` Required ```  | The template to use for code generation |
| format |  ``` Required ```  | The format of the API description to use for code generation |
| name |  ``` Required ```  | The name of the API being used for code generation |
| descriptionUrl |  ``` Required ```  | The absolute public Uri for an API description doucment |
| dl |  ``` Optional ```  ``` DefaultValue ```  | Optional |


#### Example Usage

```csharp
var template = Models.TemplateHelper.ParseString("cs_portable_net_lib");
var format = Models.FormatHelper.ParseString("Enum_API Blueprint");
string name = "name";
string descriptionUrl = "descriptionUrl";
int? dl = 0;

string result = await codeGeneration.UsingUrlAsString(template, format, name, descriptionUrl, dl);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 401 | Unauthorized: Access is denied due to invalid credentials. |
| 412 | Precondition Failed |


### <a name="using_file_as_binary"></a>![Method: ](https://apidocs.io/img/method.png "CodeGenAndTransformerAPI.PCL.Controllers.CodeGenerationController.UsingFileAsBinary") UsingFileAsBinary

> The code generation endpoint! Upload a file and convert it to the given format. The API description format of uploaded file will be detected automatically. The response is generated zip file as per selected template.


```csharp
Task<Stream> UsingFileAsBinary(
        string name,
        Models.Format format,
        Models.Template template,
        FileStreamInfo body,
        int? dl = 1)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| name |  ``` Required ```  | The name of the API being used for code generation |
| format |  ``` Required ```  | The format of the API description to use for code generation |
| template |  ``` Required ```  | The template to use for code generation |
| body |  ``` Required ```  | The input file to use for code generation |
| dl |  ``` Optional ```  ``` DefaultValue ```  | Optional |


#### Example Usage

```csharp
string name = "name";
var format = Models.FormatHelper.ParseString("Enum_API Blueprint");
var template = Models.TemplateHelper.ParseString("cs_portable_net_lib");
FileStreamInfo body = new FileStreamInfo(new FileStream(@"pathToFile",FileMode.Open));
int? dl = 1;

Stream result = await codeGeneration.UsingFileAsBinary(name, format, template, body, dl);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 401 | Unauthorized: Access is denied due to invalid credentials. |
| 412 | Precondition Failed |


### <a name="using_url_as_binary"></a>![Method: ](https://apidocs.io/img/method.png "CodeGenAndTransformerAPI.PCL.Controllers.CodeGenerationController.UsingUrlAsBinary") UsingUrlAsBinary

> Download API description from the given URL and convert it to the given format. The API description format of the provided file will be detected automatically. The response is generated zip file as per selected template.


```csharp
Task<Stream> UsingUrlAsBinary(
        Models.Template template,
        Models.Format format,
        string name,
        string descriptionUrl,
        int? dl = 1)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| template |  ``` Required ```  | The template to use for code generation |
| format |  ``` Required ```  | The format of the API description to use for code generation |
| name |  ``` Required ```  | The name of the API being used for code generation |
| descriptionUrl |  ``` Required ```  | The absolute public Uri for an API description doucment |
| dl |  ``` Optional ```  ``` DefaultValue ```  | Optional |


#### Example Usage

```csharp
var template = Models.TemplateHelper.ParseString("cs_portable_net_lib");
var format = Models.FormatHelper.ParseString("Enum_API Blueprint");
string name = "name";
string descriptionUrl = "descriptionUrl";
int? dl = 1;

Stream result = await codeGeneration.UsingUrlAsBinary(template, format, name, descriptionUrl, dl);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 401 | Unauthorized: Access is denied due to invalid credentials. |
| 412 | Precondition Failed |


### <a name="using_apikey_as_binary"></a>![Method: ](https://apidocs.io/img/method.png "CodeGenAndTransformerAPI.PCL.Controllers.CodeGenerationController.UsingApikeyAsBinary") UsingApikeyAsBinary

> Convert an API from the user's account using the API's [API Integration Key](https://docs.apimatic.io/getting-started/manage-apis/#view-api-integration-key). The response is generated zip file as per selected template.
> > Note: This endpoint does not require Basic Authentication.


```csharp
Task<Stream> UsingApikeyAsBinary(string apikey, Models.Template template, int? dl = 1)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| apikey |  ``` Required ```  | The API Key of the pre-configured API |
| template |  ``` Required ```  | The template to use for code generation |
| dl |  ``` Optional ```  ``` DefaultValue ```  | Optional |


#### Example Usage

```csharp
string apikey = "apikey";
var template = Models.TemplateHelper.ParseString("cs_portable_net_lib");
int? dl = 1;

Stream result = await codeGeneration.UsingApikeyAsBinary(apikey, template, dl);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 401 | Unauthorized: Access is denied due to invalid credentials. |
| 412 | Precondition Failed |


### <a name="using_apikey_as_string"></a>![Method: ](https://apidocs.io/img/method.png "CodeGenAndTransformerAPI.PCL.Controllers.CodeGenerationController.UsingApikeyAsString") UsingApikeyAsString

> The code generation endpoint. The response is a path to the generated zip file relative to https://apimatic.io/
> > Note: This endpoint does not require Basic Authentication.


```csharp
Task<string> UsingApikeyAsString(string apikey, Models.Template template, int? dl = 0)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| apikey |  ``` Required ```  | The API Key of the pre-configured API |
| template |  ``` Required ```  | The template to use for code generation |
| dl |  ``` Optional ```  ``` DefaultValue ```  | Optional |


#### Example Usage

```csharp
string apikey = "apikey";
var template = Models.TemplateHelper.ParseString("cs_portable_net_lib");
int? dl = 0;

string result = await codeGeneration.UsingApikeyAsString(apikey, template, dl);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 401 | Unauthorized: Access is denied due to invalid credentials. |
| 412 | Precondition Failed |


[Back to List of Controllers](#list_of_controllers)

## <a name="api_description_validation_controller"></a>![Class: ](https://apidocs.io/img/class.png "CodeGenAndTransformerAPI.PCL.Controllers.APIDescriptionValidationController") APIDescriptionValidationController

### Get singleton instance

The singleton instance of the ``` APIDescriptionValidationController ``` class can be accessed from the API Client.

```csharp
APIDescriptionValidationController aPIDescriptionValidation = client.APIDescriptionValidation;
```

### <a name="using_file"></a>![Method: ](https://apidocs.io/img/method.png "CodeGenAndTransformerAPI.PCL.Controllers.APIDescriptionValidationController.UsingFile") UsingFile

> This endpoint can be used to validate an API description document *on the fly* and see detailed error messages along with any warnings or useful information.


```csharp
Task<Models.ValidateAnAPIDescriptionResponse> UsingFile(FileStreamInfo body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | The input file to use for validation |


#### Example Usage

```csharp
FileStreamInfo body = new FileStreamInfo(new FileStream(@"pathToFile",FileMode.Open));

Models.ValidateAnAPIDescriptionResponse result = await aPIDescriptionValidation.UsingFile(body);

```


### <a name="using_url"></a>![Method: ](https://apidocs.io/img/method.png "CodeGenAndTransformerAPI.PCL.Controllers.APIDescriptionValidationController.UsingUrl") UsingUrl

> This endpoint can be used to validate an API description document *on the fly* from its public Uri, and see detailed error messages along with any warnings or useful information. This endpoint is useful for API descriptions with relative links e.g., includes (RAML) and paths (swagger).


```csharp
Task<Models.ValidateAnAPIDescriptionResponse> UsingUrl(string descriptionUrl)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| descriptionUrl |  ``` Required ```  | The absolute public Uri for an API description doucment |


#### Example Usage

```csharp
string descriptionUrl = "descriptionUrl";

Models.ValidateAnAPIDescriptionResponse result = await aPIDescriptionValidation.UsingUrl(descriptionUrl);

```


### <a name="using_apikey"></a>![Method: ](https://apidocs.io/img/method.png "CodeGenAndTransformerAPI.PCL.Controllers.APIDescriptionValidationController.UsingApikey") UsingApikey

> This endpoint can be used to validate a *pre-configured* API description and see detailed error messages along with any warnings or useful information.


```csharp
Task<Models.ValidateAnAPIDescriptionResponse> UsingApikey(string apikey)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| apikey |  ``` Required ```  | The API Key of a pre-configured API description from APIMATIC |


#### Example Usage

```csharp
string apikey = "apikey";

Models.ValidateAnAPIDescriptionResponse result = await aPIDescriptionValidation.UsingApikey(apikey);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="api_transformer_controller"></a>![Class: ](https://apidocs.io/img/class.png "CodeGenAndTransformerAPI.PCL.Controllers.APITransformerController") APITransformerController

### Get singleton instance

The singleton instance of the ``` APITransformerController ``` class can be accessed from the API Client.

```csharp
APITransformerController aPITransformer = client.APITransformer;
```

### <a name="using_apikey"></a>![Method: ](https://apidocs.io/img/method.png "CodeGenAndTransformerAPI.PCL.Controllers.APITransformerController.UsingApikey") UsingApikey

> Convert an API from the user's account using the API's [Api Integration Key](https://docs.apimatic.io/getting-started/manage-apis/#view-api-integration-key). The converted file is returned as the response.
> > Note: This endpoint does not require Basic Authentication.


```csharp
Task<Stream> UsingApikey(Models.FormatTransformer format, string apikey)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| format |  ``` Required ```  | The API format to convert to |
| apikey |  ``` Required ```  | Apikey of an already uploaded API Description on APIMATIC |


#### Example Usage

```csharp
var format = Models.FormatTransformerHelper.ParseString("apimatic");
string apikey = "apikey";

Stream result = await aPITransformer.UsingApikey(format, apikey);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |


### <a name="using_url"></a>![Method: ](https://apidocs.io/img/method.png "CodeGenAndTransformerAPI.PCL.Controllers.APITransformerController.UsingUrl") UsingUrl

> Download API description from the given URL and convert it to the given format. The API description format of the provided file will be detected automatically. The converted file is returned as the response.


```csharp
Task<Stream> UsingUrl(Models.FormatTransformer format, string descriptionUrl)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| format |  ``` Required ```  | The API format to convert to |
| descriptionUrl |  ``` Required ```  | The URL where the API description will be downloaded from |


#### Example Usage

```csharp
var format = Models.FormatTransformerHelper.ParseString("apimatic");
string descriptionUrl = "descriptionUrl";

Stream result = await aPITransformer.UsingUrl(format, descriptionUrl);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |


### <a name="using_file"></a>![Method: ](https://apidocs.io/img/method.png "CodeGenAndTransformerAPI.PCL.Controllers.APITransformerController.UsingFile") UsingFile

> Upload a file and convert it to the given format. The API description format of the uploaded file will be detected automatically. The converted file is returned as the response.


```csharp
Task<Stream> UsingFile(Models.FormatTransformer format, FileStreamInfo file)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| format |  ``` Required ```  | The API format to convert to |
| file |  ``` Required ```  | The input file to convert |


#### Example Usage

```csharp
var format = Models.FormatTransformerHelper.ParseString("apimatic");
FileStreamInfo file = new FileStreamInfo(new FileStream(@"pathToFile",FileMode.Open));

Stream result = await aPITransformer.UsingFile(format, file);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad Request |


[Back to List of Controllers](#list_of_controllers)



