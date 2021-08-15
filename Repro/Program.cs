// See https://aka.ms/new-console-template for more information


using System;

using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using Repro;


var data = CreateDocument();
for (int i = 0; i < 1000; i++)
{
    Console.WriteLine(i);
    var bytes = data.ToBson();
    _ = BsonSerializer.Deserialize<Document>(bytes);
}

Console.WriteLine("Done");


Document CreateDocument()
{
    const int documentsCount = 50;

    var complexDocument = new Document();

    for (var j = 0; j < documentsCount; j++)
    {
        var firstLevelDocument = new FirstLevelDocument();

        for (var k = 0; k < documentsCount; k++)
        {
            firstLevelDocument.InnerDocuments.Add(new SecondLevelDocument());
        }

        complexDocument.InnerDocuments.Add(firstLevelDocument);
    }

    return complexDocument;
}
