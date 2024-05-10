> [!IMPORTANT]
> This page is intended for developers who want to collaborate to improving Ingrid.
> If you are **_non developer_** and want to use Ingrid in your computer please refer to this [WIKI Install Page](https://github.com/ardhagp/Ingrid/wiki) page.

![Start Line](https://res.cloudinary.com/cagakmelon/image/upload/v1686057819/apps/ingrid-assets/readme.md/readme.md.png)
#   <span style="color:darkorange">**About Project & Status**</span>
Ingid is a Wesktop App for Windows OS that has multi purposes by your request.

[![built with Codeium](https://codeium.com/badges/main)](https://codeium.com) [![streak](https://codeium.com/badges/v2/user/ardhagp/streak)](https://codeium.com/profile/ardhagp) [![Build Status](https://dev.azure.com/cagakmelon/Ingrid/_apis/build/status%2Fgithub-linked%2Fscheduled%2Fci-build?branchName=master)](https://dev.azure.com/cagakmelon/Ingrid/_build/latest?definitionId=12&branchName=master) [![Static Badge](https://img.shields.io/badge/License-MIT-blue)](https://opensource.org/license/mit/) ![Ingrid Web](https://cronitor.io/badges/Md00mr/production/9SJ4jVW0r8b4oLx3tPo7e6TZl5M.svg) [![Static Badge](https://img.shields.io/badge/Download-Installer-gold)](https://www.iupdt.my.id/Ingrid.zip)

#   <span style="color:darkorange">**Tools**</span>
<span style="color:orange">1.</span>	Visual Studio Community Edition ([Download](https://visualstudio.microsoft.com/downloads/)) <br/>
<span style="color:orange">2.</span>	.NET 7 ([Download](https://dotnet.microsoft.com/en-us/download/dotnet/7.0))<br/>
<span style="color:orange">3.</span>  SQL Server 2022 Express / Developer Edition ([Download](https://www.microsoft.com/en-us/sql-server/sql-server-downloads))<br/>
| <span style="color:darkorange">_Instruction For Database_</span> |
| -- |
| 1. Download [Data](https://cagakmelon.visualstudio.com/Ingrid/_versionControl?version=T&path=%24/Ingrid/Database/SQL%20Server/DatabaseSchema_Data/File/db_universe_erp.mdf) and [File](https://cagakmelon.visualstudio.com/b18fd3bc-9ceb-49c2-a02c-ceaf5dd627ef/_apis/tfvc/items?path=%24/Ingrid/Database/SQL%20Server/DatabaseSchema_File/File/db_universe_erp_file.mdf&versionDescriptor%5BversionOptions%5D=0&versionDescriptor%5BversionType%5D=5&versionDescriptor%5Bversion%5D=&%24format=octetStream&api-version=5.0&download=true) as your database attachments. <br/>2. Synchronize two database above by using this file inside Ingrid repository : [db_universe_erp.scmp](https://cagakmelon.visualstudio.com/Ingrid/_versionControl?path=%24/Ingrid/Database/SQL%20Server/DatabaseSchema_Data/db_universe_erp.scmp) and [db_universe_erp_file.scmp](https://cagakmelon.visualstudio.com/Ingrid/_versionControl?path=%24/Ingrid/Database/SQL%20Server/DatabaseSchema_File/db_universe_erp_file.scmp) <br/>3. Create user <span style="color:orange">**mvu_admin**</span> with password <span style="color:orange">**admin**</span> <br/>4. Set <span style="color:orange">**db_universe_erp.mdf**</span> and <span style="color:orange">**db_universe_erp_file.mdf**</span> ownership to <span style="color:orange">**mvu_admin**</span> |

<span style="color:orange">4.</span> Open <span style="color:orange">**User Secret**</span> from <span style="color:orange">**Bridge Project**</span>, see below image.

![Manage User Secret](https://res.cloudinary.com/cagakmelon/image/upload/v1696932706/apps/ingrid-assets/readme.md/manage_user_secret.png)


Then type this json structure.
``` json
{
  "KEYS": {
	  "SALT": "<input random characters including Upper and Lower Case, Symbols and Space>",
    "SYNCFUSION": "<input your Syncfusion Key>",
    "BETTERSTACK_LOG": "<input your BetterStack Key>"
  }
}
```
or simply by editing _secrets.json_ in this directory:
```
%APPDATA%\Microsoft\UserSecrets\{guid}\
```
----
What if Manage User Secrets context menu doesn't show up?

![Missing User Secrets context menu](https://res.cloudinary.com/cagakmelon/image/upload/v1711475296/apps/ingrid-assets/readme.md/2024-03-27_002550.png)

No worries, you are still able to manage by using Dev PowerShell with this command :

| <span style="color:darkorange">_Dev PowerShell Commands_</span> | <span style="color:darkorange">_Function_</span> |
| -- | -- |
| dotnet user-secrets clear | Delete all KeyName |
| dotnet user-secrets list | Displaying KeyName and its values |
| dotnet user-secrets set KeyName "KeyValue" | Set KeyName and KeyValue |
| dotnet user-secrets remove KeyName | Remove specified KeyName |

then type this command using PowerShell
```
dotnet user-secrets set KEYS:SALT "<input random characters including Upper and Lower Case, Symbols and Space>"
dotnet user-secrets set KEYS:SYNCFUSION "<input your Syncfusion Key>"
dotnet user-secrets set KEYS:BETTERSTACK_LOG "<input your BetterStack Key>"
```

![Start Line](https://res.cloudinary.com/cagakmelon/image/upload/v1686057819/apps/ingrid-assets/readme.md/readme.md.png)
## About Keys :
### 1. Syncfusion
To obtain Syncfusion Key, please sign up with <span style="color:orange">**Community License**</span> and visit this page : [Syncfusion](https://www.syncfusion.com/account/downloads)
Then follow this steps below :

![](https://res.cloudinary.com/cagakmelon/image/upload/v1696932718/apps/ingrid-assets/readme.md/get_license_key.png)

### 2. BetterStack
To obtain BetterStack Key, please sign up <span style="color:orange">**BetterStack**</span> and open [https://betterstack.com/settings](https://betterstack.com/settings) 

![](https://res.cloudinary.com/cagakmelon/image/upload/v1712380400/apps/ingrid-assets/readme.md/2024-04-06_120426.jpg)

![Start Line](https://res.cloudinary.com/cagakmelon/image/upload/v1686057819/apps/ingrid-assets/readme.md/readme.md.png)
#   <span style="color:darkorange">**About MIT License**</span>
This application is released under the [MIT license]($/Ingrid/LICENSE). You can use the code for any purpose, including commercial projects.

![MIT License](https://res.cloudinary.com/cagakmelon/image/upload/v1697064703/apps/ingrid-assets/readme.md/license.png)

![Start Line](https://res.cloudinary.com/cagakmelon/image/upload/v1686057819/apps/ingrid-assets/readme.md/readme.md.png)
#   <span style="color:darkorange">**Navigation**</span>
| <span style="color:darkcyan">Helpful Pages :</span> | [Ingrid Web](https://ardhagp.github.io/Ingrid) | [Ingrid Wiki](https://github.com/ardhagp/Ingrid/wiki) |
| -- | -- | -- |
