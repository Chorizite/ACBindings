namespace ACBindings.Internal;


/// <summary>Encapsulates metadata for a spell component region, including identifiers and item count.</summary>
/// <field name="classID">Identifier of the component class.</field>
/// <field name="objectID">Unique object identifier within the game world.</field>
/// <field name="iconID">Identifier for the visual icon representing the component.</field>
/// <field name="numItems">Number of items present in this region.</field>
public unsafe struct SpellComponentRegion
{
    // Members
    public ACBindings.Internal.IDClass____tagDataID classID;
    public uint objectID;
    public ACBindings.Internal.IDClass____tagDataID iconID;
    public uint numItems;

    // Methods
}

