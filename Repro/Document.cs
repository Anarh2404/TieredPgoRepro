using MongoDB.Bson;

namespace Repro
{
    public class Document
    {
        public ObjectId OldId { get; set; }

        public List<FirstLevelDocument> InnerDocuments { get; set; }
    }

    public class FirstLevelDocument
    {
        public List<SecondLevelDocument> InnerDocuments { get; set; }
    }

    public class SecondLevelDocument
    {
    }
}
