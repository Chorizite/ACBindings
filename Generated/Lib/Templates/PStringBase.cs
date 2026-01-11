using System.Runtime.CompilerServices;

namespace ACBindings.Internal;

public unsafe struct PStringBase__sbyte
{
    public static PSRefBufferCharData__sbyte** s_NullBuffer = (PSRefBufferCharData__sbyte**)0x00818344;
    public static PStringBase__sbyte* null_string = (PStringBase__sbyte*)0x008183B4;
    
    public PSRefBufferCharData__sbyte* m_charbuffer;

    public PStringBase__sbyte(string str)
    {
        m_charbuffer = *s_NullBuffer;
        __Ctor((PStringBase__sbyte*)Unsafe.AsPointer(ref this), System.Text.Encoding.ASCII.GetBytes(str + '\0'));
    }
    
    public static delegate* unmanaged[Thiscall]<PStringBase__sbyte*, byte[], void> __Ctor = (delegate* unmanaged[Thiscall]<PStringBase__sbyte*, byte[], void>)0x00401340;

    public static implicit operator PStringBase__sbyte(string inStr) => new PStringBase__sbyte(inStr);
    
    public override string ToString()
    {
        int len = 0;
        if (m_charbuffer != null)
        {
            sbyte* ptr = (sbyte*)m_charbuffer->m_data;
            while (ptr[len] != 0) len++;
        }
        return new string((sbyte*)m_charbuffer, 0, len);
    }

    public void SetAtIndex(uint nIndex, sbyte zCharacter)
        => ((delegate* unmanaged[Thiscall]<ref PStringBase__sbyte, uint, sbyte, void>)0x00408770)(ref this, nIndex, zCharacter);

    public byte allocate(uint num_chars)
        => ((delegate* unmanaged[Thiscall]<ref PStringBase__sbyte, uint, byte>)0x00408D90)(ref this, num_chars);

    public byte allocate_ref_buffer(uint len)
        => ((delegate* unmanaged[Thiscall]<ref PStringBase__sbyte, uint, byte>)0x00401280)(ref this, len);

    public void append_n_chars(sbyte* str, uint count)
        => ((delegate* unmanaged[Thiscall]<ref PStringBase__sbyte, sbyte*, uint, void>)0x00404EF0)(ref this, str, count);

    public void append_string(PStringBase__sbyte* str)
        => ((delegate* unmanaged[Thiscall]<ref PStringBase__sbyte, PStringBase__sbyte*, void>)0x004064E0)(ref this, str);

    public void append_uint32(uint num)
        => ((delegate* unmanaged[Thiscall]<ref PStringBase__sbyte, uint, void>)0x0040F110)(ref this, num);

    public void break_reference()
        => ((delegate* unmanaged[Thiscall]<ref PStringBase__sbyte, void>)0x004080C0)(ref this);

    public void clear()
        => ((delegate* unmanaged[Thiscall]<ref PStringBase__sbyte, void>)0x00404CD0)(ref this);

    public int cmp(PStringBase__sbyte* rhs, byte case_sensitive)
        => ((delegate* unmanaged[Thiscall]<ref PStringBase__sbyte, PStringBase__sbyte*, byte, int>)0x00404B40)(ref this, rhs, case_sensitive);

    public byte eq(PStringBase__sbyte* rhs, byte case_sensitive)
        => ((delegate* unmanaged[Thiscall]<ref PStringBase__sbyte, PStringBase__sbyte*, byte, byte>)0x00404D20)(ref this, rhs, case_sensitive);

    public int find_substring(PStringBase__sbyte* str)
        => ((delegate* unmanaged[Thiscall]<ref PStringBase__sbyte, PStringBase__sbyte*, int>)0x00404D40)(ref this, str);

    public uint hash()
        => ((delegate* unmanaged[Thiscall]<ref PStringBase__sbyte, uint>)0x004134B0)(ref this);

    public int replace(PStringBase__sbyte* search, PStringBase__sbyte* str)
        => ((delegate* unmanaged[Thiscall]<ref PStringBase__sbyte, PStringBase__sbyte*, PStringBase__sbyte*, int>)0x004053A0)(ref this, search, str);

    public void set(PStringBase__sbyte* str)
        => ((delegate* unmanaged[Thiscall]<ref PStringBase__sbyte, PStringBase__sbyte*, void>)0x00401700)(ref this, str);

    public void set(sbyte* str)
        => ((delegate* unmanaged[Thiscall]<ref PStringBase__sbyte, sbyte*, void>)0x00405000)(ref this, str);

    public int to_int32()
        => ((delegate* unmanaged[Thiscall]<ref PStringBase__sbyte, int>)0x00429A50)(ref this);

    public uint to_uint32()
        => ((delegate* unmanaged[Thiscall]<ref PStringBase__sbyte, uint>)0x00404D70)(ref this);

    public PStringBase__ushort* to_wpstring(PStringBase__ushort* result, ushort i_sourceCodePage)
        => ((delegate* unmanaged[Thiscall]<ref PStringBase__sbyte, PStringBase__ushort*, ushort, PStringBase__ushort*>)0x00403350)(ref this, result, i_sourceCodePage);

    public void trim(byte pre, byte post, PStringBase__sbyte filter)
        => ((delegate* unmanaged[Thiscall]<ref PStringBase__sbyte, byte, byte, PStringBase__sbyte, void>)0x00435720)(ref this, pre, post, filter);

    public int vsprintf(sbyte* fmt, sbyte* args)
        => ((delegate* unmanaged[Thiscall]<ref PStringBase__sbyte, sbyte*, sbyte*, int>)0x00402390)(ref this, fmt, args);
}

public unsafe struct PStringBase__ushort
{
    public static PSRefBufferCharData__ushort** s_NullBuffer_w = (PSRefBufferCharData__ushort**)0x00818340;
    public static PStringBase__ushort* null_string_w = (PStringBase__ushort*)0x0083774C;
    public static PStringBase__ushort* whitespace_string_w = (PStringBase__ushort*)0x00837750;
    
    public PSRefBufferCharData__ushort* m_charbuffer;

    public PStringBase__ushort(string str)
    {
        m_charbuffer = *s_NullBuffer_w;
        __Ctor((PStringBase__ushort*)Unsafe.AsPointer(ref this), System.Text.Encoding.ASCII.GetBytes(str + '\0'));
    }
    
    public static delegate* unmanaged[Thiscall]<PStringBase__ushort*, byte[], void> __Ctor = (delegate* unmanaged[Thiscall]<PStringBase__ushort*, byte[], void>)0x00401A60;

    public static implicit operator PStringBase__ushort(string inStr) => new PStringBase__ushort(inStr);

    public override string ToString()
    {
        int len = 0;
        if (m_charbuffer != null)
        {
            ushort* ptr = (ushort*)m_charbuffer->m_data;
            while (ptr[len] != 0) len++;
        }
        return new string((char*)m_charbuffer, 0, len);
    }

    public void SetAtIndex(uint nIndex, ushort zCharacter)
        => ((delegate* unmanaged[Thiscall]<ref PStringBase__ushort, uint, ushort, void>)0x004089F0)(ref this, nIndex, zCharacter);

    public byte allocate(uint num_chars)
        => ((delegate* unmanaged[Thiscall]<ref PStringBase__ushort, uint, byte>)0x00408EC0)(ref this, num_chars);

    public byte allocate_ref_buffer(uint len)
        => ((delegate* unmanaged[Thiscall]<ref PStringBase__ushort, uint, byte>)0x004022D0)(ref this, len);

    public void append_int32(int num)
        => ((delegate* unmanaged[Thiscall]<ref PStringBase__ushort, int, void>)0x0047B520)(ref this, num);

    public void append_n_chars(ushort* str, uint count)
        => ((delegate* unmanaged[Thiscall]<ref PStringBase__ushort, ushort*, uint, void>)0x00402490)(ref this, str, count);

    public void append_string(PStringBase__ushort* str)
        => ((delegate* unmanaged[Thiscall]<ref PStringBase__ushort, PStringBase__ushort*, void>)0x00402790)(ref this, str);

    public void append_string(ushort* str)
        => ((delegate* unmanaged[Thiscall]<ref PStringBase__ushort, ushort*, void>)0x0040B8F0)(ref this, str);

    public void break_reference()
        => ((delegate* unmanaged[Thiscall]<ref PStringBase__ushort, void>)0x00408390)(ref this);

    public void clear()
        => ((delegate* unmanaged[Thiscall]<ref PStringBase__ushort, void>)0x0040B220)(ref this);

    public int replace(PStringBase__ushort* search, PStringBase__ushort* str)
        => ((delegate* unmanaged[Thiscall]<ref PStringBase__ushort, PStringBase__ushort*, PStringBase__ushort*, int>)0x0040D870)(ref this, search, str);

    public uint to_uint32()
        => ((delegate* unmanaged[Thiscall]<ref PStringBase__ushort, uint>)0x00478B80)(ref this);

    public PStringBase__ushort* to_spstring(PStringBase__ushort* result, ushort i_targetCodePage)
        => ((delegate* unmanaged[Thiscall]<ref PStringBase__ushort, PStringBase__ushort*, ushort, PStringBase__ushort*>)0x00408FD0)(ref this, result, i_targetCodePage);
}