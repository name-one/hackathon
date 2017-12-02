using LinqToDB.Mapping;

namespace Hackathon
{
    public class NamedEntity
    {
        [Column]
        public long Id { get; set; }

        [Column]
        public string Name { get; set; }
    }
}