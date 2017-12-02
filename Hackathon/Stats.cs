using LinqToDB.Mapping;

namespace Hackathon
{
    [Table(Schema = "dbo", Name = "Stats")]
    public class Stats
    {
        [Column]
        public long ElectionId { get; set; }    

        [Column]
        public long RegionId { get; set; }    

        [Column]
        public long StatTypeId { get; set; }    

        [Column]
        public long Value { get; set; }    
    }
}