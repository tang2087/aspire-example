var builder = DistributedApplication.CreateBuilder(args);

var sql = builder.AddSqlServer("sql", port: 14330)
    .WithDataVolume("sql-data")
    .WithLifetime(ContainerLifetime.Persistent);

var db = sql.AddDatabase(name: "database");

var apiService = builder.AddProject<Projects.aspire_example_ApiService>("apiservice")
.WithReference(db).WaitFor(db);

builder.AddProject<Projects.aspire_example_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
