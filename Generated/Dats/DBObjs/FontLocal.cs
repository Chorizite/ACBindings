namespace ACBindings;

// FontLocal
public unsafe struct FontLocal
{
    // Base Classes
    public ACBindings.Font BaseClass_Font; // ACBindings.Font

    // Child Types
    // FontLocal_vtbl
    public unsafe struct FontLocal_vtbl
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

    // Methods
    // DBObj* __cdecl FontLocal::GetGlobalOrLocalFont(int)
    public static ACBindings.DBObj* GetGlobalOrLocalFont(int a1) => ((delegate* unmanaged[Cdecl]<int, ACBindings.DBObj*>)0x0044B680)(a1);
    // unsigned int __thiscall FontLocal::GetDBOType(FontLocal*)
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.FontLocal, uint>)0x004F8300)(ref this);
    // DBObj* __thiscall FontLocal::Allocate(FontLocal*)
    public ACBindings.DBObj* Allocate() => ((delegate* unmanaged[Thiscall]<ref ACBindings.FontLocal, ACBindings.DBObj*>)0x004F8800)(ref this);
}

