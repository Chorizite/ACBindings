namespace ACBindings;

// Palette
public unsafe struct Palette
{
    // Base Classes
    public ACBindings.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.SerializeUsingPackDBObj

    // Statics
    public static int* curr_solid_index = (int*)0x0081F918;
    public static ACBindings.Palette* solid_color_palette = (ACBindings.Palette*)0x00846758;

    // Child Types
    // Palette_vtbl
    public unsafe struct Palette_vtbl
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
    public uint num_colors;
    public float min_lighting;
    public uint* ARGB;

    // Generated Constructor
    public Palette(int total_num_colors) {
        _ConstructorInternal(total_num_colors);
    }

    // Methods
    // DBObj* __cdecl Palette::Allocator()
    public static ACBindings.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.DBObj*>)0x004F7B70)();
    // unsigned int __thiscall Palette::GetDBOType(Palette*)
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Palette, uint>)0x00527490)(ref this);
    // void __thiscall Palette::Destroy(Palette*)
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Palette, void>)0x0053ECF0)(ref this);
    // void __cdecl Palette::releasePalette(Palette*)
    public static void releasePalette(ACBindings.Palette* pal) => ((delegate* unmanaged[Cdecl]<ACBindings.Palette*, void>)0x0053ED10)(pal);
    // Palette* __cdecl Palette::copyRef(Palette*)
    public static ACBindings.Palette* copyRef(ACBindings.Palette* palette) => ((delegate* unmanaged[Cdecl]<ACBindings.Palette*, ACBindings.Palette*>)0x0053ED90)(palette);
    // unsigned int __thiscall Palette::get_color32(Palette*,unsigned int)
    public uint get_color32(uint color_index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Palette, uint, uint>)0x0053EDB0)(ref this, color_index);
    // bool __thiscall Palette::InitLoad(Palette*)
    public byte InitLoad() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Palette, byte>)0x0053EDC0)(ref this);
    // void __thiscall Palette::Palette(Palette*,int)
    public void _ConstructorInternal(int total_num_colors) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Palette, int, void>)0x0053EE60)(ref this, total_num_colors);
    // int __thiscall Palette::Modify(_DWORD*,int,unsigned int,int)
    public int Modify(int a2, uint a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Palette, int, uint, int, int>)0x0053EEC0)(ref this, a2, a3, a4);
    // int __thiscall Palette::Modify(Palette*,Subpalette*)
    public int Modify(ACBindings.Subpalette* subs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Palette, ACBindings.Subpalette*, int>)0x0053EF50)(ref this, subs);
    // int __thiscall Palette::Modify(Palette*,int,Subpalette*)
    public int Modify(int numSubs, ACBindings.Subpalette* subs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Palette, int, ACBindings.Subpalette*, int>)0x0053EF90)(ref this, numSubs, subs);
    // Palette* __cdecl Palette::makeModifiedPalette()
    public static ACBindings.Palette* makeModifiedPalette() => ((delegate* unmanaged[Cdecl]<ACBindings.Palette*>)0x0053EFE0)();
    // unsigned int __thiscall Palette::Pack(Palette*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Palette, void**, uint, uint>)0x0053F010)(ref this, addr, size);
    // int __thiscall Palette::UnPack(Palette*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Palette, void**, uint, int>)0x0053F070)(ref this, addr, size);
    // DBObj* __cdecl Palette::makeModifiedPalette(int,Subpalette*)
    public static ACBindings.DBObj* makeModifiedPalette(int a1, ACBindings.Subpalette* subs) => ((delegate* unmanaged[Cdecl]<int, ACBindings.Subpalette*, ACBindings.DBObj*>)0x0053F120)(a1, subs);
}

