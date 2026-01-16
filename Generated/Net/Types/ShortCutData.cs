namespace ACBindings.Internal;


/// <summary>
/// Holds shortcut configuration data, mapping a slot index to an object identifier and spell identifier.
/// Used by the application to serialize and manage hotkey assignments within the user interface.
/// </summary>
public unsafe struct ShortCutData
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct ShortCutData_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ShortCutData*, void> ShortCutData_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ShortCutData*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ShortCutData*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ShortCutData*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public int index_;
    public uint objectID_;
    public uint spellID_;

    // Generated Constructor
    public ShortCutData(int index, uint objectID, uint spellID) {
        _ConstructorInternal(index, objectID, spellID);
    }
    public ShortCutData() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Creates a shortcut data record with the given slot index, object identifier, and spell identifier.
    /// <code>Offset: 0x005D6730
    /// void __thiscall ShortCutData::ShortCutData(ShortCutData*,int,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="index">The position number for the shortcut.</param>
    /// <param name="objectID">Identifier of the associated game object.</param>
    /// <param name="spellID">Identifier of the associated spell.</param>
    public void _ConstructorInternal(int index, uint objectID, uint spellID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ShortCutData, int, uint, uint, void>)0x005D6730)(ref this, index, objectID, spellID);

    /// <summary>Initializes a new ShortCutData object with default values: index, objectID, and spellID are set to zero.
    /// <code>Offset: 0x005D6750
    /// void __thiscall ShortCutData::ShortCutData(ShortCutData*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ShortCutData, void>)0x005D6750)(ref this);
}

