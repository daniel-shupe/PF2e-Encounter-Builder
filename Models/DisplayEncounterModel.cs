using PF2eDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PF2e_Encounter_Builder.Models
{
    public class DisplayEncounterModel
    {
        public string DifficultyId;
        public int TypeId;
        public string TypeName;
        public int TerrainId;
        public string TerrainName;
        public int Level;
        public List<MonsterModel> Monsters;
        public int Players;
    }
}
