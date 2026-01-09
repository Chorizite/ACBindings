namespace ACBindings;

// TDBTypeEntry
public unsafe struct TDBTypeEntry : System.IDisposable
{
    // Members
    public byte bRecursed;
    public byte bRegistered;
    public ACBindings.PStringBase__sbyte pRootGamePath;
    public ACBindings.PStringBase__sbyte pRootEngPath;
    public ACBindings.PStringBase__sbyte TypeName;
    public ACBindings.IDClass___tagDataID HighestDIDAssigned;
    public ACBindings.AutoGrowHashTable__IDClass___tagDataID__TFileEntry_ptr DIDs;

    // Generated Constructor
    public TDBTypeEntry() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall TDBTypeEntry::~TDBTypeEntry(TDBTypeEntry*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.TDBTypeEntry, void>)0x0067A200)(ref this);
    // void __thiscall TDBTypeEntry::TDBTypeEntry(TDBTypeEntry*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.TDBTypeEntry, void>)0x0067B2A0)(ref this);
}

