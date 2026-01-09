namespace ACBindings;

// AttributeCache
public unsafe struct AttributeCache
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // AttributeCache_vtbl
    public unsafe struct AttributeCache_vtbl
    {
        // Members
        public System.IntPtr AttributeCache_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Attribute* _strength;
    public ACBindings.Attribute* _endurance;
    public ACBindings.Attribute* _quickness;
    public ACBindings.Attribute* _coordination;
    public ACBindings.Attribute* _focus;
    public ACBindings.Attribute* _self;
    public ACBindings.SecondaryAttribute* _health;
    public ACBindings.SecondaryAttribute* _stamina;
    public ACBindings.SecondaryAttribute* _mana;

    // Generated Constructor
    public AttributeCache() {
        _ConstructorInternal();
    }

    // Methods
    // void __thiscall AttributeCache::CleanUp(AttributeCache*)
    public void CleanUp() => ((delegate* unmanaged[Thiscall]<ref ACBindings.AttributeCache, void>)0x005CD390)(ref this);
    // int __thiscall AttributeCache::InqAttribute(AttributeCache*,unsigned int,unsigned int*)
    public int InqAttribute(uint stype, uint* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AttributeCache, uint, uint*, int>)0x005CD430)(ref this, stype, retval);
    // int __thiscall AttributeCache::InqAttribute2nd(AttributeCache*,unsigned int,unsigned int*)
    public int InqAttribute2nd(uint stype, uint* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AttributeCache, uint, uint*, int>)0x005CD520)(ref this, stype, retval);
    // void __thiscall AttributeCache::AttributeCache(AttributeCache*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.AttributeCache, void>)0x005CD5F0)(ref this);
    // int __thiscall AttributeCache::InqAttribute(AttributeCache*,unsigned int,Attribute*)
    public int InqAttribute(uint stype, ACBindings.Attribute* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AttributeCache, uint, ACBindings.Attribute*, int>)0x005CD620)(ref this, stype, retval);
    // int __thiscall AttributeCache::SetAttribute(AttributeCache*,unsigned int,const Attribute*)
    public int SetAttribute(uint stype, ACBindings.Attribute* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AttributeCache, uint, ACBindings.Attribute*, int>)0x005CD690)(ref this, stype, val);
    // int __thiscall AttributeCache::SetAttribute(AttributeCache*,unsigned int,const unsigned int)
    public int SetAttribute(uint stype, uint val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AttributeCache, uint, uint, int>)0x005CD860)(ref this, stype, val);
    // int __thiscall AttributeCache::InqAttribute2nd(AttributeCache*,unsigned int,SecondaryAttribute*)
    public int InqAttribute2nd(uint stype, ACBindings.SecondaryAttribute* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AttributeCache, uint, ACBindings.SecondaryAttribute*, int>)0x005CDA20)(ref this, stype, retval);
    // int __thiscall AttributeCache::SetAttribute2nd(AttributeCache*,unsigned int,const SecondaryAttribute*)
    public int SetAttribute2nd(uint stype, ACBindings.SecondaryAttribute* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AttributeCache, uint, ACBindings.SecondaryAttribute*, int>)0x005CDA90)(ref this, stype, val);
    // int __thiscall AttributeCache::SetAttribute2nd(AttributeCache*,unsigned int,const unsigned int)
    public int SetAttribute2nd(uint stype, uint val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AttributeCache, uint, uint, int>)0x005CDBA0)(ref this, stype, val);
    // unsigned int __thiscall AttributeCache::Pack(AttributeCache*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AttributeCache, void**, uint, uint>)0x005CDD70)(ref this, addr, size);
    // int __thiscall AttributeCache::UnPack(AttributeCache*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AttributeCache, void**, uint, int>)0x005CDF00)(ref this, addr, size);
}

