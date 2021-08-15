// See https://aka.ms/new-console-template for more information


using System;

using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using Repro;

var seader = new DocumentFactory();
var data = seader.Generate();
for (int i = 0; i < 1000; i++)
{
    Console.WriteLine(i);
    var bytes = data.ToBson();
    _ = BsonSerializer.Deserialize<Document>(bytes);
}

Console.WriteLine("Done");
