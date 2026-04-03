using HeroEngine.Core.Models.Enums;
using HeroEngine.Core.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace HeroEngine.Core.Models
{
    public class ThunderSmash : AAbility
    {
        public ThunderSmash(): base ("Thunder Smash", RandomRarityHelper.GetRandomRarity(), EAbilityType.Attack, 40)
        {
        }
        public override void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
