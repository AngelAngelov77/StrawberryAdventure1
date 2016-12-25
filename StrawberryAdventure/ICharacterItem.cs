using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrawberryAdventure
{
    public interface IItem
    {
        BodyPositions BodyPosition { get; set; }
        int BonusAttack { get; set; }
        int BonusDefense { get; set; }
        int BonusHitPoints { get; set; }
        int BonusAttackSpeed { get; set; }
        int BonusAccuracy { get; set; }
        int BonusEvasion { get; set; }
        ItemType Type { get; set; }
        string Name { get; set; }
        int SubType { get; set; }
        int BonusShieldDefense { get; set; }
        int BonusShieldDefenseRate { get; set; }
        int ExperienceModifier { get; set; }

        void ToString();
        void Equip();
    }
}