namespace ACBindings;

// DualEnumIDMap
public unsafe struct DualEnumIDMap
{
    // Base Classes
    public ACBindings.EnumIDMap BaseClass_EnumIDMap; // ACBindings.EnumIDMap

    // Child Types
    // DualEnumIDMap_vtbl
    public unsafe struct DualEnumIDMap_vtbl
    {
        // Members
        public System.IntPtr IUnknown_QueryInterface; // function pointer
        public System.IntPtr IUnknown_AddRef; // function pointer
        public System.IntPtr IUnknown_Release; // function pointer
        public System.IntPtr QueryInterface; // function pointer
        public System.IntPtr AddRef; // function pointer
        public System.IntPtr Release; // function pointer
        public System.IntPtr DBObj_dtor_18; // function pointer
        public System.IntPtr Serialize; // function pointer
        public System.IntPtr GetSubDataIDs; // function pointer
        public System.IntPtr InitLoad; // function pointer
        public System.IntPtr GetSubObjects; // function pointer
        public System.IntPtr ReleaseSubObjects; // function pointer
        public System.IntPtr NotifyFidelityLevel; // function pointer
        public System.IntPtr Refresh;
        public System.IntPtr CopyInto; // function pointer
        public System.IntPtr Destroy; // function pointer
        public System.IntPtr FillDataGraph; // function pointer
        public System.IntPtr SetDID;
        public System.IntPtr GetDBOType; // function pointer
        public System.IntPtr Allocate; // function pointer
        public System.IntPtr SaveToDisk;
        public System.IntPtr ReloadFromDisk; // function pointer

        // Methods
    }

    // Members
    public ACBindings.HashTable__IDClass___tagDataID__uint m_IDToEnum;

    // Methods
    // char __thiscall DualEnumIDMap::DIDToEnum(_DWORD*,unsigned int,_DWORD*)
    public sbyte DIDToEnum(uint a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DualEnumIDMap, uint, int*, sbyte>)0x00415CE0)(ref this, a2, a3);
    // bool __thiscall DualEnumIDMap::InitLoad(DualEnumIDMap*)
    public byte InitLoad() => ((delegate* unmanaged[Thiscall]<ref ACBindings.DualEnumIDMap, byte>)0x00416180)(ref this);
    // DBObj* __thiscall DualEnumIDMap::Allocate(DualEnumIDMap*)
    public ACBindings.DBObj* Allocate() => ((delegate* unmanaged[Thiscall]<ref ACBindings.DualEnumIDMap, ACBindings.DBObj*>)0x004FB7E0)(ref this);
}

