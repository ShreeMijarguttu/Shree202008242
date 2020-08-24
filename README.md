**BOS Starter Code for ASP.NET Core 3.1**

**Purpose of this Repository**

Starter Code helps the developer to jump start the development effort and directly focus on the business logic for the application.

**Features**

1. ASP.NET Core 3.1
2. Razor Pages
3. Authentication with BOS Identity
4. Profile Picture
5. Advanced User and Role Management Module
6. Information Architecture
7. Permission Management

**Prerequisites**

1. Visual Studio 2019 Community and above
2. .NET Core 3.1 SDK and above

**Getting Started**

1. Create a Custom Module and corresponding Operations for your application in BOS Console. [Learn more.](https://developers.bosframework.com/ApplicationManagement/InformationArchitecture/ModulesAndOperations)

- In BOS Console, open your application dashboard, click on &quot; **Modules &amp; Operations**&quot; under Application Management.
- Create a custom module with the module name, module/page path and the operations required. Module Code and Operation codes will be auto-generated and available on the module card to copy them.
- Roles &amp; Permissions - The newly created custom module will be automatically associated with the Super admin role. You can also create your application roles and associate this custom module to those roles.
- These roles are then assigned to Users completing the Permissions and accessibility of the specific Module.
- The custom module will appear as a link in the navigation of the hosted application when logged-in with the users to whom this module is associated.

2. Directly get started with creation of the Controller and View for the module in Starter Code. [Learn more.](https://developers.bosframework.com/StarterCode/Web/DotNetCore)

- When a new custom Module is created it will have a generated Code and your defined Page Path. Copy this Code and Page Path then use in your application code as described below.
- In your Starter Code application find the NavigationMenu.cshtml file. Place the code snippet from[the samples](https://developers.bosframework.com/StarterCode/Web/DotNetCore) into the _foreach_ loop starting at line #67. Be sure to use your generated Code here.
- In your application code you will need to create a Controller named following your Module name with corresponding methods/functions following the naming convention used in creating your Operations. See the snippet from [the samples](https://developers.bosframework.com/StarterCode/Web/DotNetCore) for an example of a Controller with a single Index action.
- From the Application Dashboard you will need to copy the Operations Codes. Simply click the Clipboard icon next to the truncated Operations list to copy the list to your clipboard.
- Paste this output into a text document somewhere for your reference for the items below.
- To correspond to this Index action you will need to add a View under /Views/Schedules called Index.cshtml. In this view you will use the proper Operations Code to determine access to the page as well as the actions that a User can take within this view. See the snippet from [the samples provided](https://developers.bosframework.com/StarterCode/Web/DotNetCore) for the implementation of the Operations Code.