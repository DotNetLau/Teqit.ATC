var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.Teqit_ATC_ApiService>("apiservice");

builder.AddProject<Projects.Teqit_ATC_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
