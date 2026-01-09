namespace ACBindings;

// Subpalette
public unsafe struct Subpalette
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // Subpalette_vtbl
    public unsafe struct Subpalette_vtbl
    {
        // Members
        public System.IntPtr Subpalette_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.IDClass___tagDataID subID;
    public uint offset;
    public uint numcolors;
    public ACBindings.Subpalette* prev;
    public ACBindings.Subpalette* next;

    // Generated Constructor
    public Subpalette() {
        _ConstructorInternal();
    }

    // Methods
    // void __thiscall Subpalette::Subpalette(Subpalette*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Subpalette, void>)0x00500660)(ref this);
    // int __thiscall Subpalette::replaces(Subpalette*,const Subpalette*)
    public int replaces(ACBindings.Subpalette* change) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Subpalette, ACBindings.Subpalette*, int>)0x005AE8E0)(ref this, change);
    // int __thiscall Subpalette::supercedes(Subpalette*,const Subpalette*)
    public int supercedes(ACBindings.Subpalette* change) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Subpalette, ACBindings.Subpalette*, int>)0x005AE920)(ref this, change);
    // unsigned int __thiscall Subpalette::Pack(Subpalette*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Subpalette, void**, uint, uint>)0x005AEB00)(ref this, addr, size);
    // int __thiscall Subpalette::UnPack(Subpalette*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Subpalette, void**, uint, int>)0x005AEB60)(ref this, addr, size);
}

