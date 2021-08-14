// See https://aka.ms/new-console-template for more information


using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using Repro;

var seader = new DocumentFactory();
var data = seader.Generate();
for (int i = 0; i < 1000; i++)
{
    var bytes = data.ToBson();
    var data2 = BsonSerializer.Deserialize<Document>(bytes);
    Console.WriteLine(i);
}

Console.WriteLine("Done");
