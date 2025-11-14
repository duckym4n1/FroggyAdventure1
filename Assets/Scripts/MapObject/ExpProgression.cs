using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ExpProgression
{
    static readonly Dictionary<MapType, float> MapExp = new Dictionary<MapType, float>
    {
        { MapType.Normal, 1 },
        { MapType.HiddenStreet, 1.4f },
        { MapType.Bonus, 1.2f },
        { MapType.PrisonBreak, 2}
    };

    static readonly Dictionary<Rarity, float> ItemEXp = new Dictionary<Rarity, float>
    {
        { Rarity.Common, 1 },
        { Rarity.Uncommon, 1.2f },
        { Rarity.Rare, 1.5f },
        { Rarity.Epic, 2 },
        { Rarity.Legendary, 3 }
    };
}
public enum Rarity
{
    Common,
    Uncommon,
    Rare,
    Epic,
    Legendary
}

public enum MapType
{
    Normal,
    HiddenStreet,
    Bonus,
    PrisonBreak,
}