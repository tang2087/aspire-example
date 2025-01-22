# aspire-example
.NET Aspire sample project to reproduce an issue about network

This repo is created to reproduce [an issue](https://github.com/dotnet/aspire/issues/6639#issuecomment-2603547146) in .NET Aspire 9.


## Start project
```
dotnet watch run --project aspire-example.AppHost/
```

The error will show up:

fail: Aspire.Hosting.Dcp.dcpctrl.NetworkReconciler[0]
      could not connect a container to the network      {"NetworkName": {"name":"default-aspire-network"}, "Reconciliation": 4, "Container": "834e3b95b68976d8fd4b684061869303f7038cf9e64ef278091406ca33959458", "Network": "default-aspire-network-k6l8o0auf8", "error": "container 834e3b95b68976d8fd4b684061869303f7038cf9e64ef278091406ca33959458 is not connected to network 7957dba6640ba7dbc309e0de81499db467264999493602e0972c20392044e744\nobject already exists\ncontainer already attached"}
