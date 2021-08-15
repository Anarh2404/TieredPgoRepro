namespace Repro
{
    public class DocumentFactory
    {
        public Document Generate()
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
    }
}
