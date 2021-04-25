using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PF2e_Encounter_Builder.Models
{
    public class DisplayMonsterModel
    {
        [Required]
        public string MonsterName;
        [Required]
        [Range(-1,25)]
        public int Level;
        public int FamilyId;
        public int TerrainId;
        public int TypeId;
        public string FamilyName;
        public string TypeName;
        public string TerrainName;
    }
}
