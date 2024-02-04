using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Represents one match in the tournament.
    /// </summary>
    public class MatchupModel
    {
        /// <summary>
        /// The unique identifier for the person.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Represents two competing teams in the current match.
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        /// <summary>
        /// The ID from the database that will be used to identify the winner.
        /// </summary>
        public int WinnerId { get; set; }

        /// <summary>
        /// Represents the winner of the two teams.
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// Represents the current round that the 
        /// match is a part of.
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
