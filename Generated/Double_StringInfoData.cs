namespace ACBindings;

// Double_StringInfoData
public unsafe struct Double_StringInfoData
{
    // Base Classes
    public ACBindings.StringInfoData BaseClass_StringInfoData; // ACBindings.StringInfoData

    // Child Types
    // Double_StringInfoData_vtbl
    public unsafe struct Double_StringInfoData_vtbl
    {
        // Members
        public System.IntPtr Double_StringInfoData_dtor_0; // function pointer
        public System.IntPtr GetSubDataIDs; // function pointer
        public System.IntPtr GetSubPrivateIDs;
        public System.IntPtr IsValid; // function pointer
        public System.IntPtr Serialize; // function pointer
        public System.IntPtr ToString;

        // Methods
    }

    // Members
    public double m_fVal;
    public ushort m_iPrecision;

    // Methods
    // void __thiscall Double_StringInfoData::Serialize(Double_StringInfoData*,Archive*)
    public void Serialize(ACBindings.Archive* io_rcArchive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Double_StringInfoData, ACBindings.Archive*, void>)0x0042F180)(ref this, io_rcArchive);
    // int* __thiscall Double_StringInfoData::ToString(int,int*)
    public int* ToString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Double_StringInfoData, int*, int*>)0x0042F9D0)(ref this, a2);
}

