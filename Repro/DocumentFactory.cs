using MongoDB.Bson;

namespace Repro
{
    public class DocumentFactory
    {
        public Document Generate()
        {
            const int innerDocumentOneCount = 50;
            const int innerDocumentTwoCount = 25;

            var complexDocument = new Document{OldId = ObjectId.GenerateNewId()};
            complexDocument.InnerDocuments = new List<FirstLevelDocument>();

            for (var j = 0; j < innerDocumentOneCount; j++)
            {
                var firstLevelDocument = new FirstLevelDocument();
                firstLevelDocument.InnerDocuments = new List<SecondLevelDocument>();

                for (var k = 0; k < innerDocumentTwoCount; k++)
                {
                    var secondLevelDocument = new SecondLevelDocument();

                    firstLevelDocument.InnerDocuments.Add(secondLevelDocument);
                }

                complexDocument.InnerDocuments.Add(firstLevelDocument);
            }

            return complexDocument;
        }
    }
}
