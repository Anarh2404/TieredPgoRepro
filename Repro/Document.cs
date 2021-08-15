using System.Collections.Generic;

using MongoDB.Bson;

namespace Repro
{
    public class Document
    {
        public ObjectId OldId { get; set; } = ObjectId.GenerateNewId();

        public List<FirstLevelDocument> InnerDocuments { get; set; } = new List<FirstLevelDocument>();
    }

    public class FirstLevelDocument
    {
        public List<SecondLevelDocument> InnerDocuments { get; set; } = new List<SecondLevelDocument>();
    }

    public class SecondLevelDocument
    {
    }
}
