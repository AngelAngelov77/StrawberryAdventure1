using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrawberryAdventure
{
    public interface ICharacterInventory
    {
        StrawberryAdventure.IItem ItemBody { get; set; }

        IItem ItemHead { get; set; }

        StrawberryAdventure.IItem ItemLeftHand { get; set; }

        StrawberryAdventure.IItem ItemLeftRing { get; set; }

        StrawberryAdventure.IItem ItemLegs { get; set; }

        StrawberryAdventure.IItem ItemRightHand { get; set; }
        StrawberryAdventure.IItem ItemRightRing { get; set; }
        StrawberryAdventure.IItem[] ItemsInBelt { get; set; }
        StrawberryAdventure.IItem ItemBelt { get; set; }
        StrawberryAdventure.IItem[] ItemsInBackpack { get; set; }
        int ItemNeckle { get; set; }
    }
}