﻿using Skoruba.IdentityServer4.Admin.EntityFramework.Configuration.Configuration;
using System;
using System.Reflection;
using MySqlMigrationAssembly = Nikan.Services.Identity.Admin.EntityFramework.MySql.Helpers.MigrationAssembly;
using PostgreSQLMigrationAssembly = Nikan.Services.Identity.Admin.EntityFramework.PostgreSQL.Helpers.MigrationAssembly;
using SqlMigrationAssembly = Nikan.Services.Identity.Admin.EntityFramework.SqlServer.Helpers.MigrationAssembly;

namespace Nikan.Services.Identity.Admin.Configuration.Database
{
  public static class MigrationAssemblyConfiguration
  {
    public static string GetMigrationAssemblyByProvider(DatabaseProviderConfiguration databaseProvider)
    {
      return databaseProvider.ProviderType switch
      {
        DatabaseProviderType.SqlServer => typeof(SqlMigrationAssembly).GetTypeInfo().Assembly.GetName().Name,
        DatabaseProviderType.PostgreSQL => typeof(PostgreSQLMigrationAssembly).GetTypeInfo()
            .Assembly.GetName()
            .Name,
        DatabaseProviderType.MySql => typeof(MySqlMigrationAssembly).GetTypeInfo().Assembly.GetName().Name,
        _ => throw new ArgumentOutOfRangeException()
      };
    }
  }
}







