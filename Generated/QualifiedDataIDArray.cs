namespace ACBindings;

// QualifiedDataIDArray
public unsafe struct QualifiedDataIDArray : System.IDisposable
{
    // Base Classes
    public ACBindings.IntrusiveHashTable__QualifiedDataID__DBObjSaveInfo_ptr BaseClass_IntrusiveHashTable; // ACBindings.IntrusiveHashTable__QualifiedDataID__DBObjSaveInfo_ptr

    // Child Types
    // QualifiedDataIDArray_vtbl
    public unsafe struct QualifiedDataIDArray_vtbl
    {
        // Members
        public System.IntPtr QualifiedDataIDArray_dtor_0; // function pointer

        // Methods
    }

    // Members
    public ACBindings.IntrusiveHashIterator__QualifiedDataID__DBObjSaveInfo_ptr m_CurBracketIterator;
    public uint m_LastBracketIndex;

    // Generated Constructor
    public QualifiedDataIDArray(int nRequestStartSize) {
        _ConstructorInternal(nRequestStartSize);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall QualifiedDataIDArray::QualifiedDataIDArray(QualifiedDataIDArray*,int)
    public void _ConstructorInternal(int nRequestStartSize) => ((delegate* unmanaged[Thiscall]<ref ACBindings.QualifiedDataIDArray, int, void>)0x004149F0)(ref this, nRequestStartSize);
    // void __thiscall QualifiedDataIDArray::ExpensiveUpdateIterator(QualifiedDataIDArray*,unsigned int)
    public void ExpensiveUpdateIterator(uint idx) => ((delegate* unmanaged[Thiscall]<ref ACBindings.QualifiedDataIDArray, uint, void>)0x0041A2A0)(ref this, idx);
    // void __thiscall QualifiedDataIDArray::~QualifiedDataIDArray(QualifiedDataIDArray*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.QualifiedDataIDArray, void>)0x0041A410)(ref this);
    // bool __thiscall QualifiedDataIDArray::AdoptDBObjSaveInfo(QualifiedDataIDArray*,DBObjSaveInfo*)
    public byte AdoptDBObjSaveInfo(ACBindings.DBObjSaveInfo* i_pHashData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.QualifiedDataIDArray, ACBindings.DBObjSaveInfo*, byte>)0x0041A450)(ref this, i_pHashData);
    // bool __thiscall QualifiedDataIDArray::AddQDID(QualifiedDataIDArray*,const QualifiedDataID*,unsigned int)
    public byte AddQDID(ACBindings.QualifiedDataID* i_data, uint i_dwSubDataIDFlags) => ((delegate* unmanaged[Thiscall]<ref ACBindings.QualifiedDataIDArray, ACBindings.QualifiedDataID*, uint, byte>)0x0041A4E0)(ref this, i_data, i_dwSubDataIDFlags);
    // char __thiscall QualifiedDataIDArray::CopyDIDs(QualifiedDataIDArray*,_DWORD*,unsigned int)
    public sbyte CopyDIDs(int* a2, uint i_dwSubDataIDFlags) => ((delegate* unmanaged[Thiscall]<ref ACBindings.QualifiedDataIDArray, int*, uint, sbyte>)0x0041A590)(ref this, a2, i_dwSubDataIDFlags);
    // bool __thiscall QualifiedDataIDArray::AddDID(QualifiedDataIDArray*,int,unsigned int)
    public byte AddDID(int a2, uint i_dwSubDataIDFlags) => ((delegate* unmanaged[Thiscall]<ref ACBindings.QualifiedDataIDArray, int, uint, byte>)0x0041AAA0)(ref this, a2, i_dwSubDataIDFlags);
}

