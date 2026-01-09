namespace ACBindings.AC1Legacy;

// AC1Legacy::vlong
public unsafe struct vlong : System.IDisposable
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // AC1Legacy::vlong_vtbl
    public unsafe struct vlong_vtbl
    {
        // Members
        public System.IntPtr AC1Legacy; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.AC1Legacy.vlong_value* value;
    public int negative;

    // Generated Constructor
    public vlong(uint x) {
        _ConstructorInternal(x);
    }
    public vlong(ACBindings.AC1Legacy.vlong* x) {
        _ConstructorInternal(x);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall AC1Legacy::vlong::store(AC1Legacy::vlong*,unsigned int*,unsigned int)
    public void store(uint* a, uint n) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AC1Legacy.vlong, uint*, uint, void>)0x005B1740)(ref this, a, n);
    // void __thiscall AC1Legacy::vlong::docopy(AC1Legacy::vlong*)
    public void docopy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.AC1Legacy.vlong, void>)0x005B1770)(ref this);
    // unsigned int __thiscall AC1Legacy::vlong::bit(AC1Legacy::vlong*,unsigned int)
    public uint bit(uint i) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AC1Legacy.vlong, uint, uint>)0x005B17B0)(ref this, i);
    // void __thiscall AC1Legacy::vlong::setbit(AC1Legacy::vlong*,unsigned int)
    public void setbit(uint i) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AC1Legacy.vlong, uint, void>)0x005B17F0)(ref this, i);
    // unsigned int __thiscall AC1Legacy::vlong::GetPackSize(AC1Legacy::vlong*)
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.AC1Legacy.vlong, uint>)0x005B1880)(ref this);
    // void __thiscall AC1Legacy::vlong::load(AC1Legacy::vlong*,unsigned int*,unsigned int)
    public void load(uint* a, uint n) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AC1Legacy.vlong, uint*, uint, void>)0x005B1890)(ref this, a, n);
    // void __thiscall AC1Legacy::vlong::vlong(AC1Legacy::vlong*,unsigned int)
    public void _ConstructorInternal(uint x) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AC1Legacy.vlong, uint, void>)0x005B1900)(ref this, x);
    // void __thiscall AC1Legacy::vlong::vlong(AC1Legacy::vlong*,const AC1Legacy::vlong*)
    public void _ConstructorInternal(ACBindings.AC1Legacy.vlong* x) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AC1Legacy.vlong, ACBindings.AC1Legacy.vlong*, void>)0x005B1950)(ref this, x);
    // void __thiscall AC1Legacy::vlong::~vlong(AC1Legacy::vlong*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.AC1Legacy.vlong, void>)0x005B19D0)(ref this);
    // int __thiscall AC1Legacy::vlong::read_from_hex_string(AC1Legacy::vlong*,const char*)
    public int read_from_hex_string(sbyte* str) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AC1Legacy.vlong, sbyte*, int>)0x005B1BC0)(ref this, str);
    // unsigned int __thiscall AC1Legacy::vlong::Pack(AC1Legacy::vlong*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AC1Legacy.vlong, void**, uint, uint>)0x005B1F20)(ref this, addr, size);
    // int __thiscall AC1Legacy::vlong::UnPack(AC1Legacy::vlong*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AC1Legacy.vlong, void**, uint, int>)0x005B1F70)(ref this, addr, size);
}

