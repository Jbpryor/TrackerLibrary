using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class TournamentModel
    {
        /// <summary>
        /// The unique identifier for the tournament.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Represents the name of each tournament.
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// Represents the fee for each team to play.
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// Represents the group of teams entered into each
        /// tournament in the form of a list.
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new();

        /// <summary>
        /// Represents the prizes given for the tournament in
        /// the form of a list.
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new();

        /// <summary>
        /// Represents the number of rounds for each game in 
        /// the tournament.
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new();
    }
}
