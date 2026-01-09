namespace ACBindings;

// Formatted_ULInt_StringInfoData
public unsafe struct Formatted_ULInt_StringInfoData
{
    // Base Classes
    public ACBindings.ULInt_StringInfoData BaseClass_ULInt_StringInfoData; // ACBindings.ULInt_StringInfoData
    public ACBindings.Formatted_StringInfoData BaseClass_Formatted_StringInfoData; // ACBindings.Formatted_StringInfoData

    // Child Types
    // Formatted_ULInt_StringInfoData_vtbl
    public unsafe struct Formatted_ULInt_StringInfoData_vtbl
    {
        // Members
        public System.IntPtr Formatted_ULInt_StringInfoData_dtor_0; // function pointer
        public System.IntPtr GetSubDataIDs; // function pointer
        public System.IntPtr GetSubPrivateIDs;
        public System.IntPtr IsValid; // function pointer
        public System.IntPtr Serialize; // function pointer
        public System.IntPtr ToString;

        // Methods
    }

    // Methods
    // int* __thiscall Formatted_ULInt_StringInfoData::ToString(int,int*)
    public int* ToString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Formatted_ULInt_StringInfoData, int*, int*>)0x0042FAF0)(ref this, a2);
}

