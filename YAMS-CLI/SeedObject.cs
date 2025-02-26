using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace YAMS_CLI;

public class SeedObject
{
    [JsonInclude]
    [JsonPropertyName("configuration_identifier")]
    public ConfigurationIdentifier Identifier;
    
    [JsonInclude]
    [JsonPropertyName("game_patches")]
    public GamePatches Patches;
    
    [JsonInclude]
    [JsonPropertyName("pickups")]
    public Dictionary<string, PickupObject> PickupObjects = new Dictionary<string, PickupObject>();
    
    [JsonInclude]
    [JsonPropertyName("rooms")]
    public Dictionary<string, RoomObject> RoomObjects = new Dictionary<string, RoomObject>();

    [JsonInclude]
    [JsonPropertyName("starting_items")]
    public Dictionary<ItemEnum, int> StartingItems = new Dictionary<ItemEnum, int>();

    [JsonInclude]
    [JsonPropertyName("starting_location")]
    public StartingLocationObject StartingLocation;
}

public class GamePatches
{
    [JsonInclude]
    [JsonPropertyName("septogg_helpers")]
    public bool SeptoggHelpers;
    
    [JsonInclude]
    [JsonPropertyName("change_level_design")]
    public bool ChangeLevelDesign;

    [JsonInclude] [JsonPropertyName("remove_grave_grotto_blocks")]
    public bool RemoveGraveGrottoBlocks;
    
    [JsonInclude]
    [JsonPropertyName("respawn_bomb_blocks")]
    public bool RespawnBombBlocks;
    
    [JsonInclude]
    [JsonPropertyName("skip_cutscenes")]
    public bool SkipCutscenes;
    
    [JsonInclude]
    [JsonPropertyName("energy_per_tank")]
    public int EnergyPerTank;
    
    [JsonInclude]
    [JsonPropertyName("require_missile_launcher")]
    public bool RequireMissileLauncher;
    
    [JsonInclude]
    [JsonPropertyName("require_super_launcher")]
    public bool RequireSuperLauncher;
    
    [JsonInclude]
    [JsonPropertyName("require_pb_launcher")]
    public bool RequirePBLauncher;
    
}

public class ConfigurationIdentifier
{
    [JsonInclude]
    [JsonPropertyName("hash")]
    public string Hash = "";
    
    [JsonInclude]
    [JsonPropertyName("word_hash")]
    public string WordHash = "";
}


public class StartingLocationObject
{
    [JsonInclude]
    [JsonPropertyName("save_room")]
    public int SaveRoom;
}

[JsonConverter(typeof(JsonStringEnumMemberConverter))]
public enum ItemEnum
{
    [EnumMember(Value = "Metroid DNA 1")]
    DNA1,
    [EnumMember(Value = "Metroid DNA 2")]
    DNA2,
    [EnumMember(Value = "Metroid DNA 3")]
    DNA3,
    [EnumMember(Value = "Metroid DNA 4")]
    DNA4,
    [EnumMember(Value = "Metroid DNA 5")]
    DNA5,
    [EnumMember(Value = "Metroid DNA 6")]
    DNA6,
    [EnumMember(Value = "Metroid DNA 7")]
    DNA7,
    [EnumMember(Value = "Metroid DNA 8")]
    DNA8,
    [EnumMember(Value = "Metroid DNA 9")]
    DNA9,
    [EnumMember(Value = "Metroid DNA 10")]
    DNA10,
    [EnumMember(Value = "Metroid DNA 11")]
    DNA11,
    [EnumMember(Value = "Metroid DNA 12")]
    DNA12,
    [EnumMember(Value = "Metroid DNA 13")]
    DNA13,
    [EnumMember(Value = "Metroid DNA 14")]
    DNA14,
    [EnumMember(Value = "Metroid DNA 15")]
    DNA15,
    [EnumMember(Value = "Metroid DNA 16")]
    DNA16,
    [EnumMember(Value = "Metroid DNA 17")]
    DNA17,
    [EnumMember(Value = "Metroid DNA 18")]
    DNA18,
    [EnumMember(Value = "Metroid DNA 19")]
    DNA19,
    [EnumMember(Value = "Metroid DNA 20")]
    DNA20,
    [EnumMember(Value = "Metroid DNA 21")]
    DNA21,
    [EnumMember(Value = "Metroid DNA 22")]
    DNA22,
    [EnumMember(Value = "Metroid DNA 23")]
    DNA23,
    [EnumMember(Value = "Metroid DNA 24")]
    DNA24,
    [EnumMember(Value = "Metroid DNA 25")]
    DNA25,
    [EnumMember(Value = "Metroid DNA 26")]
    DNA26,
    [EnumMember(Value = "Metroid DNA 27")]
    DNA27,
    [EnumMember(Value = "Metroid DNA 28")]
    DNA28,
    [EnumMember(Value = "Metroid DNA 29")]
    DNA29,
    [EnumMember(Value = "Metroid DNA 30")]
    DNA30,
    [EnumMember(Value = "Metroid DNA 31")]
    DNA31,
    [EnumMember(Value = "Metroid DNA 32")]
    DNA32,
    [EnumMember(Value = "Metroid DNA 33")]
    DNA33,
    [EnumMember(Value = "Metroid DNA 34")]
    DNA34,
    [EnumMember(Value = "Metroid DNA 35")]
    DNA35,
    [EnumMember(Value = "Metroid DNA 36")]
    DNA36,
    [EnumMember(Value = "Metroid DNA 37")]
    DNA37,
    [EnumMember(Value = "Metroid DNA 38")]
    DNA38,
    [EnumMember(Value = "Metroid DNA 39")]
    DNA39,
    [EnumMember(Value = "Metroid DNA 40")]
    DNA40,
    [EnumMember(Value = "Metroid DNA 41")]
    DNA41,
    [EnumMember(Value = "Metroid DNA 42")]
    DNA42,
    [EnumMember(Value = "Metroid DNA 43")]
    DNA43,
    [EnumMember(Value = "Metroid DNA 44")]
    DNA44,
    [EnumMember(Value = "Metroid DNA 45")]
    DNA45,
    [EnumMember(Value = "Metroid DNA 46")]
    DNA46,
    
    [EnumMember(Value = "Missile Expansion")]
    MissileExpansion,
    [EnumMember(Value = "Super Missile Expansion")]
    SuperMissileExpansion,
    [EnumMember(Value = "Power Bomb Expansion")]
    PBombExpansion,
    [EnumMember(Value = "Energy Tank")]
    EnergyTank,
    
    [EnumMember(Value = "Missiles")]
    Missile,
    [EnumMember(Value = "Locked Missiles")]
    LockedMissile,
    [EnumMember(Value = "Super Missiles")]
    SuperMissile,
    [EnumMember(Value = "Locked Super Missiles")]
    LockedSuperMissile,
    [EnumMember(Value = "Power Bombs")]
    PBomb,
    [EnumMember(Value = "Locked Power Bombs")]
    LockedPBomb,
    
    [EnumMember(Value = "Missile Launcher")]
    MissileLauncher,
    [EnumMember(Value = "Super Missile Launcher")]
    SuperMissileLauncher,
    [EnumMember(Value = "Power Bomb Launcher")]
    PBombLauncher,
    
    [EnumMember(Value = "Bombs")]
    Bombs,
    [EnumMember(Value = "Power Grip")]
    Powergrip,
    [EnumMember(Value = "Spider Ball")]
    Spiderball,
    [EnumMember(Value = "Spring Ball")]
    Springball,
    [EnumMember(Value = "Hi-Jump")]
    Hijump,
    [EnumMember(Value = "Varia Suit")]
    Varia,
    [EnumMember(Value = "Space Jump")]
    Spacejump,
    [EnumMember(Value = "Speed Booster")]
    Speedbooster,
    [EnumMember(Value = "Screw Attack")]
    Screwattack,
    [EnumMember(Value = "Gravity Suit")]
    Gravity,
    [EnumMember(Value = "Power Beam")]
    Power,
    [EnumMember(Value = "Charge Beam")]
    Charge,
    [EnumMember(Value = "Ice Beam")]
    Ice,
    [EnumMember(Value = "Wave Beam")]
    Wave,
    [EnumMember(Value = "Spazer Beam")]
    Spazer,
    [EnumMember(Value = "Plasma Beam")]
    Plasma,
    [EnumMember(Value = "Morph Ball")]
    Morphball,
    [EnumMember(Value = "Nothing")]
    Nothing
    
}

public class PickupObject
{
    [JsonInclude]
    [JsonPropertyName("item_id")]
    public string ItemID;
    [JsonInclude]
    [JsonPropertyName("sprite_details")]
    public SpriteDetails SpriteDetails;
    [JsonInclude]
    [JsonPropertyName("item_effect")]
    public ItemEnum ItemEffect;
    [JsonInclude]
    [JsonPropertyName("quantity")]
    public int Quantity;

    [JsonInclude] 
    [JsonPropertyName("text")]
    public TextDetails Text;

}

public class SpriteDetails
{
    [JsonInclude]
    [JsonPropertyName("name")]
    public string Name = "sItemUnknown";
    [JsonInclude]
    [JsonPropertyName("speed")]
    public decimal Speed;
}

public class TextDetails
{
    [JsonInclude] 
    [JsonPropertyName("header")]
    public string Header = "INVALID TEXT";
    
    [JsonInclude] 
    [JsonPropertyName("description")]
    public string Description = "INVALID DESCRIPTION";
}

public class RoomObject
{
    [JsonInclude]
    [JsonPropertyName("display_name")]
    public string DisplayName = "";
}