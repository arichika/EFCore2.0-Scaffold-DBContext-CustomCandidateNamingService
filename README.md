# EFCore2.0-Scaffold-DBContext-CustomCandidateNamingService

# How to use

* open Package Manager Console  

* type this `cd .\ScaffoldMyDb` in PM Console.

* next, `Scaffold-DbContext -Connection "Server=(local);Database=MyNiceDb;Trusted_Connection=True;" -Provider Microsoft.EntityFrameworkCore.SqlServer -OutputDir EntityModels -Force` do this.
  * please set your enviromets value, `database name`, `access rights` and so on.
