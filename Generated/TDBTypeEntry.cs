namespace ACBindings.Internal;

public unsafe struct TDBTypeEntry : System.IDisposable
{
    // Members
    public byte bRecursed;
    public byte bRegistered;
    public ACBindings.Internal.PStringBase__sbyte pRootGamePath;
    public ACBindings.Internal.PStringBase__sbyte pRootEngPath;
    public ACBindings.Internal.PStringBase__sbyte TypeName;
    public ACBindings.Internal.IDClass____tagDataID HighestDIDAssigned;
    public ACBindings.Internal.AutoGrowHashTable___IDClass____tagDataID___TFileEntry_ptr DIDs;

    // Generated Constructor
    public TDBTypeEntry() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0067A200
    /// void __thiscall TDBTypeEntry::~TDBTypeEntry(TDBTypeEntry*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TDBTypeEntry, void>)0x0067A200)(ref this);

    /// <summary>
    /// <code>Offset: 0x0067B2A0
    /// void __thiscall TDBTypeEntry::TDBTypeEntry(TDBTypeEntry*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TDBTypeEntry, void>)0x0067B2A0)(ref this);
}

