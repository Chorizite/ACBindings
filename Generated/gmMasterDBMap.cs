namespace ACBindings;

// gmMasterDBMap
public unsafe struct gmMasterDBMap
{
    // Base Classes
    public ACBindings.MasterDBMap BaseClass_MasterDBMap; // ACBindings.MasterDBMap

    // Child Types
    // gmMasterDBMap_vtbl
    public unsafe struct gmMasterDBMap_vtbl
    {
        // Members
        public System.IntPtr InitDBTypeDef_Internal; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr DivineType_Internal;
        public System.IntPtr InqTypeByString_Internal;
        public System.IntPtr InqStringByType_Internal;

        // Methods
    }

    // Methods
    // int __stdcall gmMasterDBMap::DivineType_Internal(unsigned int)
    public static int DivineType_Internal(uint a1) => ((delegate* unmanaged[Stdcall]<uint, int>)0x005D6A90)(a1);
    // int __thiscall gmMasterDBMap::DivineType_Internal(char*,int)
    public int DivineType_Internal(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmMasterDBMap, int, int>)0x005D6BE0)(ref this, a2);
    // char __thiscall gmMasterDBMap::InqTypeByString_Internal(char*,char**,char*)
    public sbyte InqTypeByString_Internal(sbyte** a2, sbyte* String2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmMasterDBMap, sbyte**, sbyte*, sbyte>)0x005D71D0)(ref this, a2, String2);
    // char __stdcall gmMasterDBMap::InqStringByType_Internal(int,void**)
    public static sbyte InqStringByType_Internal(int a1, void** a2) => ((delegate* unmanaged[Stdcall]<int, void**, sbyte>)0x005D7700)(a1, a2);
    // bool __thiscall gmMasterDBMap::InitDBTypeDef_Internal(gmMasterDBMap*)
    public byte InitDBTypeDef_Internal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmMasterDBMap, byte>)0x005D77E0)(ref this);
}

