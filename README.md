![Selamat Datang](https://res.cloudinary.com/cagakmelon/image/upload/v1686057819/apps/ingrid-assets/readme.md/readme.md.png)

#   <span style="color:orange">Project Status</span>
---
| <span style="color:gold">Information</span> | <span style="color:gold">Value</span> |
|--:|--|
|License| ![Static Badge](https://img.shields.io/badge/License-MIT-blue) |
|Last Check In| [![Build status](https://cagakmelon.visualstudio.com/Ingrid/_apis/build/status/www.iupdt.my.id/scheduled/CI-Build)](https://cagakmelon.visualstudio.com/Ingrid/_build/latest?definitionId=8) |
|Midnight Build| [![Build status](https://cagakmelon.visualstudio.com/Ingrid/_apis/build/status/www.iupdt.my.id/scheduled/Midnight-Build-Beta)](https://cagakmelon.visualstudio.com/Ingrid/_build/latest?definitionId=1) |
|Beta Version| ![Deployment](https://cagakmelon.vsrm.visualstudio.com/_apis/public/Release/badge/b18fd3bc-9ceb-49c2-a02c-ceaf5dd627ef/1/2) |
|Stable Release| ![Deployment](https://cagakmelon.vsrm.visualstudio.com/_apis/public/Release/badge/b18fd3bc-9ceb-49c2-a02c-ceaf5dd627ef/2/3) |
|Epics| [![Board Status](https://cagakmelon.visualstudio.com/b18fd3bc-9ceb-49c2-a02c-ceaf5dd627ef/d8d5eb94-3f20-4331-b741-a71cad549752/_apis/work/boardbadge/618e4563-8610-4e05-baa7-5e30f40ea320?columnOptions=1)](https://cagakmelon.visualstudio.com/b18fd3bc-9ceb-49c2-a02c-ceaf5dd627ef/_boards/board/t/d8d5eb94-3f20-4331-b741-a71cad549752/Epics/) |
|Features| [![Board Status](https://cagakmelon.visualstudio.com/b18fd3bc-9ceb-49c2-a02c-ceaf5dd627ef/d8d5eb94-3f20-4331-b741-a71cad549752/_apis/work/boardbadge/e555542b-4c40-4b49-839c-9f4f3facb8ff?columnOptions=1)](https://cagakmelon.visualstudio.com/b18fd3bc-9ceb-49c2-a02c-ceaf5dd627ef/_boards/board/t/d8d5eb94-3f20-4331-b741-a71cad549752/Features/) |
|Stories| [![Board Status](https://cagakmelon.visualstudio.com/b18fd3bc-9ceb-49c2-a02c-ceaf5dd627ef/d8d5eb94-3f20-4331-b741-a71cad549752/_apis/work/boardbadge/531d42ad-5741-4fbf-b551-86a086c98e7f?columnOptions=1)](https://cagakmelon.visualstudio.com/b18fd3bc-9ceb-49c2-a02c-ceaf5dd627ef/_boards/board/t/d8d5eb94-3f20-4331-b741-a71cad549752/Stories/) |
|Offline Setup| [![Static Badge](https://img.shields.io/badge/Download-Installer-gold)](https://www.iupdt.my.id/Ingrid.zip) |



#   <span style="color:orange">About</span>
----
Multi purpose application

#   <span style="color:orange">Tools</span>
----
<span style="color:gold">1.</span>	Visual Studio Community Edition ([Download](https://visualstudio.microsoft.com/downloads/))

<span style="color:gold">2.</span>	.NET 6 ([Download](https://dotnet.microsoft.com/en-us/download/dotnet/6.0))

<span style="color:gold">3.</span>  SQL Server 2022 Express / Developer Edition ([Download](https://www.microsoft.com/en-us/sql-server/sql-server-downloads))

| **Instruction For Database** |
| -- |
| 1. Download [Data](https://cagakmelon.visualstudio.com/b18fd3bc-9ceb-49c2-a02c-ceaf5dd627ef/_apis/tfvc/items?path=%24/Ingrid/Database/SQL%20Server/DatabaseSchema_Data/File/db_universe_erp.mdf&versionDescriptor%5BversionOptions%5D=0&versionDescriptor%5BversionType%5D=5&versionDescriptor%5Bversion%5D=&%24format=octetStream&api-version=5.0&download=true) and [File](https://cagakmelon.visualstudio.com/b18fd3bc-9ceb-49c2-a02c-ceaf5dd627ef/_apis/tfvc/items?path=%24/Ingrid/Database/SQL%20Server/DatabaseSchema_File/File/db_universe_erp_file.mdf&versionDescriptor%5BversionOptions%5D=0&versionDescriptor%5BversionType%5D=5&versionDescriptor%5Bversion%5D=&%24format=octetStream&api-version=5.0&download=true) as your database attachments. |
| 2. Synchronize two database above by using this file inside Ingrid repository : [db_universe_erp.scmp](https://cagakmelon.visualstudio.com/Ingrid/_versionControl?path=%24/Ingrid/Database/SQL%20Server/DatabaseSchema_Data/db_universe_erp.scmp) and [db_universe_erp_file.scmp](https://cagakmelon.visualstudio.com/Ingrid/_versionControl?path=%24/Ingrid/Database/SQL%20Server/DatabaseSchema_File/db_universe_erp_file.scmp) |
| 3. Create user **mvu_admin** with password **admin** |
| 4. Set **db_universe_erp.mdf** and **db_universe_erp_file.mdf** ownership to **mvu_admin** |

<span style="color:gold">4.</span> Open **User Secret** from Bridge Project see below image.



Then type this json structure.
``` json
{
  "KEYS": {
	  "SALT": "<input random characters including Upper and Lower Case, Symbols and Space>",
    "SYNCFUSION": "<input your Syncfusion Key>"
  }
}
```

To obtain Syncfusion Key, please **signup with community license** and visit this page : [Syncfusion](https://www.syncfusion.com/account/downloads)
Then follow this steps below :
1. 
2. 

#   <span style="color:orange">About MIT License</span>
----
  


#   <span style="color:orange">Navigation</span>
----
| Helpful Pages : | [Dashboard](https://cagakmelon.visualstudio.com/Ingrid/_dashboards/dashboard/0985ae4c-795d-4346-a81d-dcb33669aa7d) | [Wiki](https://cagakmelon.visualstudio.com/Ingrid/_wiki/wikis/Ingrid.wiki/1/Ingrid-WIKI) |
| -- | -- | -- |

