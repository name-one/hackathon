using LinqToDB.Mapping;

namespace Hackathon
{
    [Table(Schema = "dbo", Name = "CandidateResults")]
    public class CandidateStats
    {
        [Column]
        public long ElectionId { get; set; }

        [Column]
        public long RegionId { get; set; }

        [Column]
        public long CandidateId { get; set; }

        [Column]
        public long Value { get; set; }
    }
}