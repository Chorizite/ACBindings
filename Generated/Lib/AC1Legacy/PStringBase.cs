using System.Runtime.CompilerServices;
namespace ACBindings.Internal.AC1Legacy;

public unsafe struct PStringBase__sbyte
{
    public PSRefBuffer__sbyte* m_buffer;

    public PStringBase__sbyte(string str)
    {
        m_buffer = *s_NullBuffer;
        __Ctor((PStringBase__sbyte*)Unsafe.AsPointer(ref this), System.Text.Encoding.ASCII.GetBytes(str + '\0'));
    }

    public override string ToString()
    {
        if (m_buffer == null || m_buffer->m_len == 0) return "null";
        return new string((sbyte*)m_buffer->m_data, 0, m_buffer->m_len - 1);
    }

    // Implicit conversions - char version
    public static implicit operator PStringBase__sbyte(string inStr) => new(inStr);

    // Constructors (flattened)
    public static delegate* unmanaged[Thiscall]<PStringBase__sbyte*, byte[], void> __Ctor
        = (delegate* unmanaged[Thiscall]<PStringBase__sbyte*, byte[], void>)0x0048C3E0;

    public static delegate* unmanaged[Thiscall]<PStringBase__sbyte*, int, void> __Ctor_int32
        = (delegate* unmanaged[Thiscall]<PStringBase__sbyte*, int, void>)0x004ADBA0;

    // Methods - only char-specific ones
    public uint GetPackSize()
        => ((delegate* unmanaged[Thiscall]<ref PStringBase__sbyte, uint>)0x004FD1F0)(ref this);

    public uint Pack(void** addr, uint size)
        => ((delegate* unmanaged[Thiscall]<ref PStringBase__sbyte, void**, uint, uint>)0x004FD290)(ref this, addr, size);

    public int UnPack(void** addr, uint size)
        => ((delegate* unmanaged[Thiscall]<ref PStringBase__sbyte, void**, uint, int>)0x004FD460)(ref this, addr, size);

    public void allocate_ref_buffer(uint len)
        => ((delegate* unmanaged[Thiscall]<ref PStringBase__sbyte, uint, void>)0x00403560)(ref this, len);

    public void append_n_chars(byte* str, uint count)
        => ((delegate* unmanaged[Thiscall]<ref PStringBase__sbyte, byte*, uint, void>)0x004910C0)(ref this, str, count);

    public void break_reference()
        => ((delegate* unmanaged[Thiscall]<ref PStringBase__sbyte, void>)0x00411870)(ref this);

    public void clear()
        => ((delegate* unmanaged[Thiscall]<ref PStringBase__sbyte, void>)0x004AB990)(ref this);

    public int cmp(PStringBase__sbyte* rhs, int case_sensitive)
        => ((delegate* unmanaged[Thiscall]<ref PStringBase__sbyte, PStringBase__sbyte*, int, int>)0x004ABA90)(ref this, rhs, case_sensitive);

    public uint compute_hash()
        => ((delegate* unmanaged[Thiscall]<ref PStringBase__sbyte, uint>)0x004FE440)(ref this);

    public byte eq(PStringBase__sbyte* rhs, int case_sensitive)
        => ((delegate* unmanaged[Thiscall]<ref PStringBase__sbyte, PStringBase__sbyte*, int, byte>)0x004AC350)(ref this, rhs, case_sensitive);

    public int find_substring(PStringBase__sbyte* str)
        => ((delegate* unmanaged[Thiscall]<ref PStringBase__sbyte, PStringBase__sbyte*, int>)0x00542EA0)(ref this, str);

    public int replace(PStringBase__sbyte* search, PStringBase__sbyte* str)
        => ((delegate* unmanaged[Thiscall]<ref PStringBase__sbyte, PStringBase__sbyte*, PStringBase__sbyte*, int>)0x00566D10)(ref this, search, str);

    public void set(byte* str)
        => ((delegate* unmanaged[Thiscall]<ref PStringBase__sbyte, byte*, void>)0x004034C0)(ref this, str);

    public PStringBase__ushort* to_wpstring(PStringBase__ushort* result, ushort i_sourceCodePage)
        => ((delegate* unmanaged[Thiscall]<ref PStringBase__sbyte, PStringBase__ushort*, ushort, PStringBase__ushort*>)0x005571C0)(ref this, result, i_sourceCodePage);

    public void trim(int pre, int post, PStringBase__sbyte filter)
        => ((delegate* unmanaged[Thiscall]<ref PStringBase__sbyte, int, int, PStringBase__sbyte, void>)0x0056F9A0)(ref this, pre, post, filter);

    public int vsprintf(byte* fmt, byte* args)
        => ((delegate* unmanaged[Thiscall]<ref PStringBase__sbyte, byte*, byte*, int>)0x00487480)(ref this, fmt, args);

    // Globals - char version
    public static PSRefBuffer__sbyte** s_NullBuffer = (PSRefBuffer__sbyte**)0x008EF11C;
    public static PStringBase__sbyte* null_string = (PStringBase__sbyte*)0x008EF120;
    public static PStringBase__sbyte* whitespace_string = (PStringBase__sbyte*)0x008EF124;
}

public unsafe struct PStringBase__ushort
{
    public PSRefBuffer__ushort* m_buffer;

    public override string ToString()
    {
        if (m_buffer == null || m_buffer->m_len == 0) return "null";
        return new string((char*)m_buffer->m_data, 0, m_buffer->m_len - 1);
    }

    // Implicit conversions - only stub (no direct int → wide-string in original)
    public static implicit operator PStringBase__ushort(string inStr)
    {
        PStringBase__ushort ret;
        ret.m_buffer = *s_NullBuffer_w;

        ushort[] buf = new ushort[inStr.Length];
        for (int i = 0; i < inStr.Length; i++)
            buf[i] = inStr[i];

        __Ctor_16((PStringBase__ushort*)&ret, buf);
        return ret;
    }

    // Constructor (wide version)
    public static delegate* unmanaged[Thiscall]<PStringBase__ushort*, ushort[], void> __Ctor_16
        = (delegate* unmanaged[Thiscall]<PStringBase__ushort*, ushort[], void>)0x005444D0;

    // Methods - only ushort-specific ones
    public void allocate_ref_buffer(uint len)
        => ((delegate* unmanaged[Thiscall]<ref PStringBase__ushort, uint, void>)0x00543680)(ref this, len);

    public void set(ushort* str)
        => ((delegate* unmanaged[Thiscall]<ref PStringBase__ushort, ushort*, void>)0x0055F580)(ref this, str);

    public PStringBase__sbyte* to_spstring(PStringBase__sbyte* result, ushort i_targetCodePage)
        => ((delegate* unmanaged[Thiscall]<ref PStringBase__ushort, PStringBase__sbyte*, ushort, PStringBase__sbyte*>)0x00546290)(ref this, result, i_targetCodePage);

    // Globals - ushort version
    public static PSRefBuffer__ushort** s_NullBuffer_w = (PSRefBuffer__ushort**)0x008EF12C;
    public static PStringBase__ushort* null_string_w = (PStringBase__ushort*)0x008EF130;
    public static PStringBase__ushort* whitespace_string_w = (PStringBase__ushort*)0x008EF134;
}