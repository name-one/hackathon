using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToDB;
using LinqToDB.Data;

namespace Hackathon
{
    public class Source
    {
        private static Source _instance;

        public static Source Instance => _instance = _instance ?? new Source();

        private readonly Stats[] _stats;
        private readonly CandidateStats[] _candStats;
        private readonly NamedEntity[] _candidates;
        private readonly NamedEntity[] _elections;
        private readonly NamedEntity[] _statTypes;
        private readonly NamedEntity[] _regions;

        private Source()
        {
            using (var db = new Db())
            {
                _stats = db.Stats.ToArray();
                _candStats = db.CandidateStats.ToArray();
                _candidates = db.Candidates.ToArray();
                _elections = db.Elections.ToArray();
                _statTypes = db.StatTypes.ToArray();
                _regions = db.Regions.ToArray();
            }
        }

        public Stats[] GetStats()
        {
            return _stats;
        }

        public CandidateStats[] GetCandidateStats()
        {
            return _candStats;
        }

        public NamedEntity[] GetCandidates()
        {
            return _candidates;
        }

        public NamedEntity[] GetElections()
        {
            return _elections;
        }

        public NamedEntity[] GetStatTypes()
        {
            return _statTypes;
        }

        public NamedEntity[] GetRegions()
        {
            return _regions;
        }
    }
}
