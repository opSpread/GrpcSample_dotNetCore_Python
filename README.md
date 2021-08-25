# GrpcSample_dotNetCore_Python
# Define Protobuf message format 

1. Python Server Setting
$ python -m pip install grpcio
$ python -m pip install grpcio-tools

# C# .net-core Exception
2. Grpc.Core.RpcException: 'Status(StatusCode="Unavailable", Detail="Error starting gRPC call. HttpRequestException
Solved 
> AppContext.SetSwitch(  "System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);



