using LinqToDB;
using LinqToDB.Data;
using LinqToDB.Mapping;

namespace Hackathon
{
    public class Db : DataConnection
    {
        public Db()
            : base("MyDb")
        {
        }

        public ITable<Stats> Stats => GetTable<Stats>();

        public ITable<CandidateStats> CandidateStats => GetTable<CandidateStats>();

        public ITable<NamedEntity> Candidates => GetTable<CandidatesDto>();

        public ITable<NamedEntity> Regions => GetTable<RegionsDto>();

        public ITable<NamedEntity> StatTypes => GetTable<StatTypesDto>();
        public ITable<NamedEntity> Elections => GetTable<ElectionsDto>();

        [Table("Candidates")]
        private class CandidatesDto : NamedEntity { }

        [Table("Regions")]
        private class RegionsDto : NamedEntity { }

        [Table("StatType")]
        private class StatTypesDto : NamedEntity { }

        [Table("Elections")]
        private class ElectionsDto : NamedEntity { }
    }
}