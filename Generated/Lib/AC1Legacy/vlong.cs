namespace ACBindings.Internal.AC1Legacy;

public unsafe struct vlong : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct vlong_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AC1Legacy.vlong*, void> AC1Legacy; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AC1Legacy.vlong*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AC1Legacy.vlong*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AC1Legacy.vlong*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.AC1Legacy.vlong_value* value;
    public int negative;

    // Generated Constructor
    public vlong(uint x) {
        _ConstructorInternal(x);
    }
    public vlong(ACBindings.Internal.AC1Legacy.vlong* x) {
        _ConstructorInternal(x);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x005B1740
    /// void __thiscall AC1Legacy::vlong::store(AC1Legacy::vlong*,unsigned int*,unsigned int)</code>
    /// </summary>
    public void store(uint* a, uint n) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AC1Legacy.vlong, uint*, uint, void>)0x005B1740)(ref this, a, n);

    /// <summary>
    /// <code>Offset: 0x005B1770
    /// void __thiscall AC1Legacy::vlong::docopy(AC1Legacy::vlong*)</code>
    /// </summary>
    public void docopy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AC1Legacy.vlong, void>)0x005B1770)(ref this);

    /// <summary>
    /// <code>Offset: 0x005B17B0
    /// unsigned int __thiscall AC1Legacy::vlong::bit(AC1Legacy::vlong*,unsigned int)</code>
    /// </summary>
    public uint bit(uint i) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AC1Legacy.vlong, uint, uint>)0x005B17B0)(ref this, i);

    /// <summary>
    /// <code>Offset: 0x005B17F0
    /// void __thiscall AC1Legacy::vlong::setbit(AC1Legacy::vlong*,unsigned int)</code>
    /// </summary>
    public void setbit(uint i) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AC1Legacy.vlong, uint, void>)0x005B17F0)(ref this, i);

    /// <summary>
    /// <code>Offset: 0x005B1880
    /// unsigned int __thiscall AC1Legacy::vlong::GetPackSize(AC1Legacy::vlong*)</code>
    /// </summary>
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AC1Legacy.vlong, uint>)0x005B1880)(ref this);

    /// <summary>
    /// <code>Offset: 0x005B1890
    /// void __thiscall AC1Legacy::vlong::load(AC1Legacy::vlong*,unsigned int*,unsigned int)</code>
    /// </summary>
    public void load(uint* a, uint n) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AC1Legacy.vlong, uint*, uint, void>)0x005B1890)(ref this, a, n);

    /// <summary>
    /// <code>Offset: 0x005B1900
    /// void __thiscall AC1Legacy::vlong::vlong(AC1Legacy::vlong*,unsigned int)</code>
    /// </summary>
    public void _ConstructorInternal(uint x) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AC1Legacy.vlong, uint, void>)0x005B1900)(ref this, x);

    /// <summary>
    /// <code>Offset: 0x005B1950
    /// void __thiscall AC1Legacy::vlong::vlong(AC1Legacy::vlong*,const AC1Legacy::vlong*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.AC1Legacy.vlong* x) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AC1Legacy.vlong, ACBindings.Internal.AC1Legacy.vlong*, void>)0x005B1950)(ref this, x);

    /// <summary>
    /// <code>Offset: 0x005B19D0
    /// void __thiscall AC1Legacy::vlong::~vlong(AC1Legacy::vlong*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AC1Legacy.vlong, void>)0x005B19D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005B1BC0
    /// int __thiscall AC1Legacy::vlong::read_from_hex_string(AC1Legacy::vlong*,const char*)</code>
    /// </summary>
    public int read_from_hex_string(sbyte* str) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AC1Legacy.vlong, sbyte*, int>)0x005B1BC0)(ref this, str);

    /// <summary>
    /// <code>Offset: 0x005B1F20
    /// unsigned int __thiscall AC1Legacy::vlong::Pack(AC1Legacy::vlong*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AC1Legacy.vlong, void**, uint, uint>)0x005B1F20)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005B1F70
    /// int __thiscall AC1Legacy::vlong::UnPack(AC1Legacy::vlong*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AC1Legacy.vlong, void**, uint, int>)0x005B1F70)(ref this, addr, size);
}

