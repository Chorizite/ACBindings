namespace ACBindings;

// ULInt_StringInfoData
public unsafe struct ULInt_StringInfoData
{
    // Base Classes
    public ACBindings.StringInfoData BaseClass_StringInfoData; // ACBindings.StringInfoData

    // Child Types
    // ULInt_StringInfoData_vtbl
    public unsafe struct ULInt_StringInfoData_vtbl
    {
        // Members
        public System.IntPtr ULInt_StringInfoData_dtor_0; // function pointer
        public System.IntPtr GetSubDataIDs; // function pointer
        public System.IntPtr GetSubPrivateIDs;
        public System.IntPtr IsValid; // function pointer
        public System.IntPtr Serialize; // function pointer
        public System.IntPtr ToString;

        // Methods
    }

    // Members
    public ulong m_iVal;

    // Methods
    // void __thiscall ULInt_StringInfoData::Serialize(ULInt_StringInfoData*,Archive*)
    public void Serialize(ACBindings.Archive* io_rcArchive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ULInt_StringInfoData, ACBindings.Archive*, void>)0x0042F200)(ref this, io_rcArchive);
    // int* __thiscall ULInt_StringInfoData::ToString(unsigned __int64*,int*)
    public int* ToString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ULInt_StringInfoData, int*, int*>)0x0042FA30)(ref this, a2);
}

