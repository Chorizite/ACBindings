namespace ACBindings;

// LInt_StringInfoData
public unsafe struct LInt_StringInfoData
{
    // Base Classes
    public ACBindings.StringInfoData BaseClass_StringInfoData; // ACBindings.StringInfoData

    // Child Types
    // LInt_StringInfoData_vtbl
    public unsafe struct LInt_StringInfoData_vtbl
    {
        // Members
        public System.IntPtr LInt_StringInfoData_dtor_0; // function pointer
        public System.IntPtr GetSubDataIDs; // function pointer
        public System.IntPtr GetSubPrivateIDs;
        public System.IntPtr IsValid; // function pointer
        public System.IntPtr Serialize; // function pointer
        public System.IntPtr ToString;

        // Methods
    }

    // Members
    public long m_iVal;

    // Methods
    // int* __thiscall LInt_StringInfoData::ToString(__int64*,int*)
    public int* ToString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.LInt_StringInfoData, int*, int*>)0x0042FA00)(ref this, a2);
}

