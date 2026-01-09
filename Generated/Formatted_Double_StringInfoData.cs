namespace ACBindings;

// Formatted_Double_StringInfoData
public unsafe struct Formatted_Double_StringInfoData
{
    // Base Classes
    public ACBindings.Double_StringInfoData BaseClass_Double_StringInfoData; // ACBindings.Double_StringInfoData
    public ACBindings.Formatted_StringInfoData BaseClass_Formatted_StringInfoData; // ACBindings.Formatted_StringInfoData

    // Child Types
    // Formatted_Double_StringInfoData_vtbl
    public unsafe struct Formatted_Double_StringInfoData_vtbl
    {
        // Members
        public System.IntPtr Formatted_Double_StringInfoData_dtor_0; // function pointer
        public System.IntPtr GetSubDataIDs; // function pointer
        public System.IntPtr GetSubPrivateIDs;
        public System.IntPtr IsValid; // function pointer
        public System.IntPtr Serialize; // function pointer
        public System.IntPtr ToString;

        // Methods
    }

    // Methods
    // void __thiscall Formatted_Double_StringInfoData::Serialize(Formatted_Double_StringInfoData*,Archive*)
    public void Serialize(ACBindings.Archive* io_rcArchive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Formatted_Double_StringInfoData, ACBindings.Archive*, void>)0x0042F2A0)(ref this, io_rcArchive);
    // int* __thiscall Formatted_Double_StringInfoData::ToString(int,int*)
    public int* ToString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Formatted_Double_StringInfoData, int*, int*>)0x0042FA90)(ref this, a2);
}

