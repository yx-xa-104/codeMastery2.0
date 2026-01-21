var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.codemastery_be>("codemastery-be");

builder.Build().Run();
