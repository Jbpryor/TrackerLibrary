﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class TeamModel
    {
        public int Id { get; set; }
        /// <summary>
        /// Represents the name of the team.
        /// </summary>
        public string TeamName { get; set; }

        /// <summary>
        /// Represents the members of the team as a list.
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new();
    }
}
