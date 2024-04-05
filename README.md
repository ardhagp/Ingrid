![Start Line](https://res.cloudinary.com/cagakmelon/image/upload/v1686057819/apps/ingrid-assets/readme.md/readme.md.png)

#   <span style="color:darkorange">**About**</span>
----
Multi purpose application

#   <span style="color:darkorange">**Project Status**</span>
---
| <span style="color:darkorange">_Information_</span> | <span style="color:darkorange">_Value_</span> |
|--:|--|
|License| [![Static Badge](https://img.shields.io/badge/License-MIT-blue)](https://opensource.org/license/mit/) |
|Last Check In| [![Build status](https://cagakmelon.visualstudio.com/Ingrid/_apis/build/status/www.iupdt.my.id/scheduled/CI-Build)](https://cagakmelon.visualstudio.com/Ingrid/_build/latest?definitionId=8) |
|Midnight Build| [![Build status](https://cagakmelon.visualstudio.com/Ingrid/_apis/build/status/www.iupdt.my.id/scheduled/Midnight-Build-Beta)](https://cagakmelon.visualstudio.com/Ingrid/_build/latest?definitionId=1) |
|Beta Version| ![Deployment](https://cagakmelon.vsrm.visualstudio.com/_apis/public/Release/badge/b18fd3bc-9ceb-49c2-a02c-ceaf5dd627ef/1/2) |
|Stable Release| ![Deployment](https://cagakmelon.vsrm.visualstudio.com/_apis/public/Release/badge/b18fd3bc-9ceb-49c2-a02c-ceaf5dd627ef/2/3) |

| <span style="color:darkorange">_Information_</span> | <span style="color:darkorange">_Value_</span> |
|--:|--|
|Azure Build| [![Build Status](https://dev.azure.com/cagakmelon/Ingrid/_apis/build/status%2Ffrom%20Github%2Fardhagp.Ingrid?branchName=master)](https://dev.azure.com/cagakmelon/Ingrid/_build/latest?definitionId=12&branchName=master) |
|Epics| [![Board Status](https://cagakmelon.visualstudio.com/b18fd3bc-9ceb-49c2-a02c-ceaf5dd627ef/d8d5eb94-3f20-4331-b741-a71cad549752/_apis/work/boardbadge/618e4563-8610-4e05-baa7-5e30f40ea320?columnOptions=1)](https://cagakmelon.visualstudio.com/b18fd3bc-9ceb-49c2-a02c-ceaf5dd627ef/_boards/board/t/d8d5eb94-3f20-4331-b741-a71cad549752/Epics/) |
|Features| [![Board Status](https://cagakmelon.visualstudio.com/b18fd3bc-9ceb-49c2-a02c-ceaf5dd627ef/d8d5eb94-3f20-4331-b741-a71cad549752/_apis/work/boardbadge/e555542b-4c40-4b49-839c-9f4f3facb8ff?columnOptions=1)](https://cagakmelon.visualstudio.com/b18fd3bc-9ceb-49c2-a02c-ceaf5dd627ef/_boards/board/t/d8d5eb94-3f20-4331-b741-a71cad549752/Features/) |
|Stories| [![Board Status](https://cagakmelon.visualstudio.com/b18fd3bc-9ceb-49c2-a02c-ceaf5dd627ef/d8d5eb94-3f20-4331-b741-a71cad549752/_apis/work/boardbadge/531d42ad-5741-4fbf-b551-86a086c98e7f?columnOptions=1)](https://cagakmelon.visualstudio.com/b18fd3bc-9ceb-49c2-a02c-ceaf5dd627ef/_boards/board/t/d8d5eb94-3f20-4331-b741-a71cad549752/Stories/) |
|Offline Setup| [![Static Badge](https://img.shields.io/badge/Download-Installer-gold)](https://www.iupdt.my.id/Ingrid.zip) |

#   <span style="color:darkorange">**Tools**</span>
----
<span style="color:orange">1.</span>	Visual Studio Community Edition ([Download](https://visualstudio.microsoft.com/downloads/)) <br/>
<span style="color:orange">2.</span>	.NET 6 ([Download](https://dotnet.microsoft.com/en-us/download/dotnet/6.0))<br/>
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
   "BETTERSTACK": "<input your BetterStack Key>"
  }
}
```
by accessing this directory:
```
%APPDATA%\Microsoft\UserSecrets\{guid}\secrets.json
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
dotnet user-secrets set KEYS:BETTERSTACK "<input your BetterStack Key>"
```
----

To obtain Syncfusion Key, please sign up with <span style="color:orange">**Community License**</span> and visit this page : [Syncfusion](https://www.syncfusion.com/account/downloads)
Then follow this steps below :
![](https://res.cloudinary.com/cagakmelon/image/upload/v1696932718/apps/ingrid-assets/readme.md/get_license_key.png)

#   <span style="color:darkorange">**About MIT License**</span>
----
This application is released under the [MIT license]($/Ingrid/LICENSE). You can use the code for any purpose, including commercial projects.
![MIT License](https://res.cloudinary.com/cagakmelon/image/upload/v1697064703/apps/ingrid-assets/readme.md/license.png)

#   <span style="color:darkorange">**Navigation**</span>
----
| <span style="color:darkcyan">Helpful Pages :</span> | [My Dashboard](https://cagakmelon.visualstudio.com/Ingrid/_dashboards/dashboard/0985ae4c-795d-4346-a81d-dcb33669aa7d) | [Wiki](https://cagakmelon.visualstudio.com/Ingrid/_wiki/wikis/Ingrid.wiki/1/Ingrid-WIKI) |
| -- | -- | -- |

![End Line](https://res.cloudinary.com/cagakmelon/image/upload/v1686057819/apps/ingrid-assets/readme.md/readme.md.png)
