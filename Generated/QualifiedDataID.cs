namespace ACBindings;

// QualifiedDataID
public unsafe struct QualifiedDataID
{
    // Members
    public uint Type;
    public ACBindings.IDClass___tagDataID ID;

    // Generated Constructor
    public QualifiedDataID(int a2, int a3) {
        _ConstructorInternal(a2, a3);
    }

    // Methods
    // int* __thiscall QualifiedDataID::QualifiedDataID(int*,int,int)
    public int* _ConstructorInternal(int a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.QualifiedDataID, int, int, int*>)0x004220B0)(ref this, a2, a3);
}

