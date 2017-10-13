
											Taken from https://docs.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection

to put Asp.Net Core 2.0 => Error 

Error :"You must add a reference to assembly netstandard, Version=2.0.0.0"

https://github.com/dotnet/core/issues/860

I have a similar problem, and I remove the RuntimeFrameworkVersion, and the problem was fixed.
Try to remove <RuntimeFrameworkVersion>1.1.1</RuntimeFrameworkVersion> or <NetStandardImplicitPackageVersion section in the csproj.


See https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app-xplat/working-with-sql for SQLite


Migration in SQLite :
PMC>
Add-Migration InitialCreateFirst

update-database