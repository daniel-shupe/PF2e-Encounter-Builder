using PF2eDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PF2e_Encounter_Builder.Models
{
    //  model used to hold parameters for encounter generation
    public class DisplayEncounterModel
    {
        public string Difficulty;   //  difficulty of random encounter
        public string CreatureType; //  creature type of random encounter
        public string Terrain;  //  terrain of random encounter
        public int Level;   //  average level of party
        public List<MonsterModel> Monsters; //  list of available monsters
        public int Players; //  party size
        public string Alignment;    //  alignment of monsters in encounter
        public string Family;   //  family of monsters in encounter
    }
}
