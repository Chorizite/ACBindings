namespace ACBindings.Internal;

public unsafe struct AttributeCache
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct AttributeCache_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AttributeCache*, void> AttributeCache_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AttributeCache*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AttributeCache*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AttributeCache*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.Attribute* _strength;
    public ACBindings.Internal.Attribute* _endurance;
    public ACBindings.Internal.Attribute* _quickness;
    public ACBindings.Internal.Attribute* _coordination;
    public ACBindings.Internal.Attribute* _focus;
    public ACBindings.Internal.Attribute* _self;
    public ACBindings.Internal.SecondaryAttribute* _health;
    public ACBindings.Internal.SecondaryAttribute* _stamina;
    public ACBindings.Internal.SecondaryAttribute* _mana;

    // Generated Constructor
    public AttributeCache() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x005CD390
    /// void __thiscall AttributeCache::CleanUp(AttributeCache*)</code>
    /// </summary>
    public void CleanUp() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AttributeCache, void>)0x005CD390)(ref this);

    /// <summary>
    /// <code>Offset: 0x005CD430
    /// int __thiscall AttributeCache::InqAttribute(AttributeCache*,unsigned int,unsigned int*)</code>
    /// </summary>
    public int InqAttribute(uint stype, uint* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AttributeCache, uint, uint*, int>)0x005CD430)(ref this, stype, retval);

    /// <summary>
    /// <code>Offset: 0x005CD520
    /// int __thiscall AttributeCache::InqAttribute2nd(AttributeCache*,unsigned int,unsigned int*)</code>
    /// </summary>
    public int InqAttribute2nd(uint stype, uint* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AttributeCache, uint, uint*, int>)0x005CD520)(ref this, stype, retval);

    /// <summary>
    /// <code>Offset: 0x005CD5F0
    /// void __thiscall AttributeCache::AttributeCache(AttributeCache*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AttributeCache, void>)0x005CD5F0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005CD620
    /// int __thiscall AttributeCache::InqAttribute(AttributeCache*,unsigned int,Attribute*)</code>
    /// </summary>
    public int InqAttribute(uint stype, ACBindings.Internal.Attribute* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AttributeCache, uint, ACBindings.Internal.Attribute*, int>)0x005CD620)(ref this, stype, retval);

    /// <summary>
    /// <code>Offset: 0x005CD690
    /// int __thiscall AttributeCache::SetAttribute(AttributeCache*,unsigned int,const Attribute*)</code>
    /// </summary>
    public int SetAttribute(uint stype, ACBindings.Internal.Attribute* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AttributeCache, uint, ACBindings.Internal.Attribute*, int>)0x005CD690)(ref this, stype, val);

    /// <summary>
    /// <code>Offset: 0x005CD860
    /// int __thiscall AttributeCache::SetAttribute(AttributeCache*,unsigned int,const unsigned int)</code>
    /// </summary>
    public int SetAttribute(uint stype, uint val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AttributeCache, uint, uint, int>)0x005CD860)(ref this, stype, val);

    /// <summary>
    /// <code>Offset: 0x005CDA20
    /// int __thiscall AttributeCache::InqAttribute2nd(AttributeCache*,unsigned int,SecondaryAttribute*)</code>
    /// </summary>
    public int InqAttribute2nd(uint stype, ACBindings.Internal.SecondaryAttribute* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AttributeCache, uint, ACBindings.Internal.SecondaryAttribute*, int>)0x005CDA20)(ref this, stype, retval);

    /// <summary>
    /// <code>Offset: 0x005CDA90
    /// int __thiscall AttributeCache::SetAttribute2nd(AttributeCache*,unsigned int,const SecondaryAttribute*)</code>
    /// </summary>
    public int SetAttribute2nd(uint stype, ACBindings.Internal.SecondaryAttribute* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AttributeCache, uint, ACBindings.Internal.SecondaryAttribute*, int>)0x005CDA90)(ref this, stype, val);

    /// <summary>
    /// <code>Offset: 0x005CDBA0
    /// int __thiscall AttributeCache::SetAttribute2nd(AttributeCache*,unsigned int,const unsigned int)</code>
    /// </summary>
    public int SetAttribute2nd(uint stype, uint val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AttributeCache, uint, uint, int>)0x005CDBA0)(ref this, stype, val);

    /// <summary>
    /// <code>Offset: 0x005CDD70
    /// unsigned int __thiscall AttributeCache::Pack(AttributeCache*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AttributeCache, void**, uint, uint>)0x005CDD70)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005CDF00
    /// int __thiscall AttributeCache::UnPack(AttributeCache*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AttributeCache, void**, uint, int>)0x005CDF00)(ref this, addr, size);
}

