# GrpcSample_dotNetCore_Python
# Define Protobuf message format 
# Python : https://itw01.com/FHQA9EG.html

1. Python Env Setting
$ python -m pip install grpcio
$ python -m pip install grpcio-tools

1.1 Compile protobuf from python server
$ python -m grpc_tools.protoc -I./ --python_out=. --grpc_python_out=. ./hello.proto


# C# .net-core Exception
2. Grpc.Core.RpcException: 'Status(StatusCode="Unavailable", Detail="Error starting gRPC call. HttpRequestException
Solved 
> AppContext.SetSwitch(  "System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);



