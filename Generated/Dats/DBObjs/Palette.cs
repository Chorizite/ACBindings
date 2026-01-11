namespace ACBindings.Internal;

public unsafe struct Palette
{
    // Base Classes
    public ACBindings.Internal.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.Internal.SerializeUsingPackDBObj

    // Statics
    public static int* curr_solid_index = (int*)0x0081F918;
    public static ACBindings.Internal.Palette* solid_color_palette = (ACBindings.Internal.Palette*)0x00846758;

    // Child Types
    public unsafe struct Palette_vtbl
    {
        // Members
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, ACBindings.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*> QueryInterface; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> AddRef; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> Release; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, void> DBObj_dtor_18; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.Archive*, void> Serialize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> InitLoad; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> GetSubObjects; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> ReleaseSubObjects; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> NotifyFidelityLevel; // function pointer
        public System.IntPtr Refresh;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.DBObj*, byte> CopyInto; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, void> Destroy; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.IDataGraph*, void> FillDataGraph; // function pointer
        public System.IntPtr SetDID;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, uint> GetDBOType; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.DBObj*> Allocate; // function pointer
        public System.IntPtr SaveToDisk;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> ReloadFromDisk; // function pointer

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

    /// <summary>
    /// <code>Offset: 0x004F7B70
    /// DBObj* __cdecl Palette::Allocator()</code>
    /// </summary>
    public static ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>)0x004F7B70)();

    /// <summary>
    /// <code>Offset: 0x00527490
    /// unsigned int __thiscall Palette::GetDBOType(Palette*)</code>
    /// </summary>
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Palette, uint>)0x00527490)(ref this);

    /// <summary>
    /// <code>Offset: 0x0053ECF0
    /// void __thiscall Palette::Destroy(Palette*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Palette, void>)0x0053ECF0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0053ED10
    /// void __cdecl Palette::releasePalette(Palette*)</code>
    /// </summary>
    public static void releasePalette(ACBindings.Internal.Palette* pal) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.Palette*, void>)0x0053ED10)(pal);

    /// <summary>
    /// <code>Offset: 0x0053ED90
    /// Palette* __cdecl Palette::copyRef(Palette*)</code>
    /// </summary>
    public static ACBindings.Internal.Palette* copyRef(ACBindings.Internal.Palette* palette) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.Palette*, ACBindings.Internal.Palette*>)0x0053ED90)(palette);

    /// <summary>
    /// <code>Offset: 0x0053EDB0
    /// unsigned int __thiscall Palette::get_color32(Palette*,unsigned int)</code>
    /// </summary>
    public uint get_color32(uint color_index) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Palette, uint, uint>)0x0053EDB0)(ref this, color_index);

    /// <summary>
    /// <code>Offset: 0x0053EDC0
    /// bool __thiscall Palette::InitLoad(Palette*)</code>
    /// </summary>
    public byte InitLoad() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Palette, byte>)0x0053EDC0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0053EE60
    /// void __thiscall Palette::Palette(Palette*,int)</code>
    /// </summary>
    public void _ConstructorInternal(int total_num_colors) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Palette, int, void>)0x0053EE60)(ref this, total_num_colors);

    /// <summary>
    /// <code>Offset: 0x0053EEC0
    /// int __thiscall Palette::Modify(_DWORD*,int,unsigned int,int)</code>
    /// </summary>
    public int Modify(int a2, uint a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Palette, int, uint, int, int>)0x0053EEC0)(ref this, a2, a3, a4);

    /// <summary>
    /// <code>Offset: 0x0053EF50
    /// int __thiscall Palette::Modify(Palette*,Subpalette*)</code>
    /// </summary>
    public int Modify(ACBindings.Internal.Subpalette* subs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Palette, ACBindings.Internal.Subpalette*, int>)0x0053EF50)(ref this, subs);

    /// <summary>
    /// <code>Offset: 0x0053EF90
    /// int __thiscall Palette::Modify(Palette*,int,Subpalette*)</code>
    /// </summary>
    public int Modify(int numSubs, ACBindings.Internal.Subpalette* subs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Palette, int, ACBindings.Internal.Subpalette*, int>)0x0053EF90)(ref this, numSubs, subs);

    /// <summary>
    /// <code>Offset: 0x0053EFE0
    /// Palette* __cdecl Palette::makeModifiedPalette()</code>
    /// </summary>
    public static ACBindings.Internal.Palette* makeModifiedPalette() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.Palette*>)0x0053EFE0)();

    /// <summary>
    /// <code>Offset: 0x0053F010
    /// unsigned int __thiscall Palette::Pack(Palette*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Palette, void**, uint, uint>)0x0053F010)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x0053F070
    /// int __thiscall Palette::UnPack(Palette*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Palette, void**, uint, int>)0x0053F070)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x0053F120
    /// DBObj* __cdecl Palette::makeModifiedPalette(int,Subpalette*)</code>
    /// </summary>
    public static ACBindings.Internal.DBObj* makeModifiedPalette(int a1, ACBindings.Internal.Subpalette* subs) => ((delegate* unmanaged[Cdecl]<int, ACBindings.Internal.Subpalette*, ACBindings.Internal.DBObj*>)0x0053F120)(a1, subs);
}

