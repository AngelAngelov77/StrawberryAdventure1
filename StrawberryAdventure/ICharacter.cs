namespace StrawberryAdventure
{
    public interface ICharacterBasic
    {
        int BasicHitPoints { get; set; }
        int BasicAttack { get; set; }
        int BasicDefense { get; set; }
        int BasicAccuracy { get; set; }
        int BasicAttackSpeed { get; set; }
        int BasicEvasion { get; set; }
        int BasicShieldDefenseRate { get; set; }
        int BasicCriticalRate { get; set; }
        int BasicCriticalDamageModifier { get; set; }
        int BasicMinimalDamage { get; set; }
        int BasicMaximalDamage { get; set; }
        int Level { get; set; }
        ICharacterInventory Inventory { get; set; }

        string Name { get; set; }
        ISkills[] Skills { get; set; }
    }
}