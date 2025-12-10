using System;
using System.Collections.Generic;

namespace AkademiQPortfolio.Data
{
    public partial class SkillTable
    {
        public int SkillId { get; set; }
        public string? Title { get; set; }
        public byte? Levels { get; set; }
        public string? Test { get; set; }
    }
}



//Bizim ilk başta skill diye bir nesne üretiyoruz --> SkillTable 

// Abdullah 20 test2

// Skill = skillID, Title(abdullah), Levels(20), Test(test2)