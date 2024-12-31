using Cliente_gRPC;
using Grpc.Net.Client;



using (var channel = GrpcChannel.ForAddress("http://localhost:5057"))
{
	var client = new Names.NamesClient(channel);

	// Modo asincrono awaut 
	var reply = await client.SayHelloAsync(new HelloRequest
	{
		Name = "Allstar ",
	});

	//Respuesta 2 

	var reply2 = await client.GetAsync(new NamesRequest { }); 

	Console.WriteLine(reply.Message);

	//Hacemos un recorrido de los nombre de la respuesta 2
	foreach ( var name in reply2.Name)
	{
		Console.WriteLine(name);
	}



	Console.ReadKey(); 

}
