namespace ACBindings.Internal;


/// <summary>Represents a salvageable item, storing its ID, name, material type, workmanship level, value, material flag, power rating, and quantity available for processing.</summary>
public unsafe struct SalvageDataBlob
{
    // Members
    public uint itemID;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte name;
    public uint material;
    public int workmanship;
    public int value;
    public int isMaterial;
    public int power;
    public int numberItems;

    // Methods
}

