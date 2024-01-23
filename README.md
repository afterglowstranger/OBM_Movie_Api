# OBM_Movie_Api


The Project consists of:

A Mysql Database, sql table, stored procs and data dumps in directory DB_BackupFiles.
There are foreign keys so run Castings and MovieGenres last, should work fine.

An Api project "OBM_MovieApi", endpoints presented via Swagger.

A simple web front end "SimpleFrontend" which provides a skin onto the api.

A Model library "ModelLibrary" for shared models.

A console app "HarvestMovieData" for consuming the moview/actor data, which I abandonned as it was proving too time consuming to keep stopping and fixing errant records.  I switched to Excel and some vba code to open the files read the content and either directly construct sql insert statements or convert to json and then create the sql.  This is Extract_Casting_Actor.xlsm, which has 4 macros which trigger the vba code.

Setting OBM_MoviewApi and SimpleFrontend as startuup projects should give you both a Swagger page and the front end in separate tabs/browser windows.