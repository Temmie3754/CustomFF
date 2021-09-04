using Exiled.API.Interfaces;
using System.Collections.Generic;
using System.ComponentModel;

namespace CustomFF
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        [Description("Teams below cannot damage other teams in their list")]
        public Dictionary<Team, List<Team>> DisabledDamage { get; set; } = new Dictionary<Team, List<Team>> {
            { Team.CDP, new List<Team>{ Team.CDP, Team.CHI} },
            { Team.CHI, new List<Team>{ Team.CDP, Team.CHI} },
            { Team.MTF, new List<Team>{ Team.MTF, Team.RSC} },
            { Team.RSC, new List<Team>{ Team.MTF, Team.RSC} },
            { Team.SCP, new List<Team>{ Team.SCP } }};

        [Description("Should cuffed players be considered on the same team?")]
        public bool DisableCuffedDamage { get; set; } = true;


    }
}
