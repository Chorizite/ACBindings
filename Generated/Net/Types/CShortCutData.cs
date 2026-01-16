namespace ACBindings.Internal;


/// <summary>Provides data for a shortcut entry, linking a UI slot to an object and spell identifier while enabling virtual dispatch through its base ShortCutData class.</summary>
public unsafe struct CShortCutData
{
    // Base Classes
    public ACBindings.Internal.ShortCutData BaseClass_ShortCutData; // ACBindings.Internal.ShortCutData

    // Child Types
    public unsafe struct CShortCutData_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CShortCutData*, void> CShortCutData_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CShortCutData*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CShortCutData*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CShortCutData*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Generated Constructor
    public CShortCutData(int index, uint objectID, uint spellID) {
        _ConstructorInternal(index, objectID, spellID);
    }

    // Methods

    /// <summary>Initializes a CShortCutData instance with the specified slot index, object identifier, and spell identifier.
    /// <code>Offset: 0x0059B5B0
    /// void __thiscall CShortCutData::CShortCutData(CShortCutData*,int,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="index">The shortcut slot number to assign to this data structure.</param>
    /// <param name="objectID">Identifier for the target game object associated with the shortcut.</param>
    /// <param name="spellID">Identifier for the spell linked to this shortcut entry.</param>
    public void _ConstructorInternal(int index, uint objectID, uint spellID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CShortCutData, int, uint, uint, void>)0x0059B5B0)(ref this, index, objectID, spellID);
}

