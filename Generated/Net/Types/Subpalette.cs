namespace ACBindings.Internal;

public unsafe struct Subpalette
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct Subpalette_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Subpalette*, void> Subpalette_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Subpalette*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Subpalette*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Subpalette*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.IDClass____tagDataID subID;
    public uint offset;
    public uint numcolors;
    public ACBindings.Internal.Subpalette* prev;
    public ACBindings.Internal.Subpalette* next;

    // Generated Constructor
    public Subpalette() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00500660
    /// void __thiscall Subpalette::Subpalette(Subpalette*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Subpalette, void>)0x00500660)(ref this);

    /// <summary>
    /// <code>Offset: 0x005AE8E0
    /// int __thiscall Subpalette::replaces(Subpalette*,const Subpalette*)</code>
    /// </summary>
    public int replaces(ACBindings.Internal.Subpalette* change) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Subpalette, ACBindings.Internal.Subpalette*, int>)0x005AE8E0)(ref this, change);

    /// <summary>
    /// <code>Offset: 0x005AE920
    /// int __thiscall Subpalette::supercedes(Subpalette*,const Subpalette*)</code>
    /// </summary>
    public int supercedes(ACBindings.Internal.Subpalette* change) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Subpalette, ACBindings.Internal.Subpalette*, int>)0x005AE920)(ref this, change);

    /// <summary>
    /// <code>Offset: 0x005AEB00
    /// unsigned int __thiscall Subpalette::Pack(Subpalette*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Subpalette, void**, uint, uint>)0x005AEB00)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005AEB60
    /// int __thiscall Subpalette::UnPack(Subpalette*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Subpalette, void**, uint, int>)0x005AEB60)(ref this, addr, size);
}

