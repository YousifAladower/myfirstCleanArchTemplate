var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.myfirstClean_Web>("web");

builder.Build().Run();
