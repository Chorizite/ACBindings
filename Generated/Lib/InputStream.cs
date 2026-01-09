namespace ACBindings;

// InputStream
public unsafe struct InputStream : System.IDisposable
{
    // Members
    public byte parsing_from_string;
    public byte keep_locked;
    public ACBindings.PStringBaseIter_Const__sbyte in_string_iter;
    public byte* in_file;
    public ushort line;
    public ushort col;
    public uint num_chars;
    public sbyte curr_char;
    public byte done;

    // Generated Constructor
    public InputStream() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // char __thiscall InputStream::Next(InputStream*)
    public sbyte Next() => ((delegate* unmanaged[Thiscall]<ref ACBindings.InputStream, sbyte>)0x006BBA50)(ref this);
    // char __thiscall InputStream::SetFile(void*,const char**,_DWORD*,unsigned int,double)
    public sbyte SetFile(sbyte** a2, int* a3, uint a4, double a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.InputStream, sbyte**, int*, uint, double, sbyte>)0x006BBAE0)(ref this, a2, a3, a4, a5);
    // void __thiscall InputStream::InputStream(InputStream*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.InputStream, void>)0x006BBC60)(ref this);
    // void __thiscall InputStream::~InputStream(InputStream*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.InputStream, void>)0x006BBC90)(ref this);
}

