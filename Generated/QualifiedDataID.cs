namespace ACBindings.Internal;


/// <summary>Identifies a data element by its type and unique ID, enabling lookup and categorization across the system.</summary>
public unsafe struct QualifiedDataID
{
    // Members
    public uint Type;
    public ACBindings.Internal.IDClass____tagDataID ID;

    // Generated Constructor
    public QualifiedDataID(int a2, int a3) {
        _ConstructorInternal(a2, a3);
    }

    // Methods

    /// <summary>Constructs a QualifiedDataID from an ID and optional type, deriving the type when omitted.
    /// <code>Offset: 0x004220B0
    /// int* __thiscall QualifiedDataID::QualifiedDataID(int*,int,int)</code>
    /// </summary>
    /// <param name="a2">The data identifier assigned to the QualifiedDataID.</param>
    /// <param name="a3">Explicit type value; if zero, the type is calculated from the ID via MasterDBMap::DivineType.</param>
    /// <returns>Pointer to the initialized QualifiedDataID instance.</returns>
    public int* _ConstructorInternal(int a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QualifiedDataID, int, int, int*>)0x004220B0)(ref this, a2, a3);
}

