using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Scaffolding.Internal;
using Microsoft.Extensions.DependencyInjection;

namespace ScaffoldMyDb
{
    // Not officially supported. Using this is "I know what I'm doing" territory
    public class MyScaffoldingDesignTimeServices: IDesignTimeServices
    {
        public void ConfigureDesignTimeServices(IServiceCollection services)
        {
            // override the defautlt naming service
            services.AddSingleton<ICandidateNamingService, MyScaffoldingCandidateNamingService>();
        }
    }

    // Not officially supported. Using this is "I know what I'm doing" territory
    public class MyScaffoldingCandidateNamingService : CandidateNamingService
    {
        public override string GenerateCandidateIdentifier(string original)
        {
            Console.WriteLine("Naming request: " + original);

            // original will be the table name, column name, index name, etc.
            // In this override, you are free to do whatever you want.
            // the base class will return PascalCase
            //var pascalCaseify = base.GenerateCandidateIdentifier(original);
            //return pascalCaseify;

            return original;
        }
    }
}
