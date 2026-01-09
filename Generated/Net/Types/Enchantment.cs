namespace ACBindings;

// Enchantment
public unsafe struct Enchantment
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // Enchantment_vtbl
    public unsafe struct Enchantment_vtbl
    {
        // Members
        public System.IntPtr Enchantment_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public uint _id;
    public uint m_SpellSetID;
    public uint _spell_category;
    public int _power_level;
    public double _start_time;
    public double _duration;
    public uint _caster;
    public float _degrade_modifier;
    public float _degrade_limit;
    public double _last_time_degraded;
    public ACBindings.StatMod _smod;

    // Generated Constructor
    public Enchantment(ACBindings.Enchantment* that) {
        _ConstructorInternal(that);
    }
    public Enchantment() {
        _ConstructorInternal();
    }
    public Enchantment(uint spid) {
        _ConstructorInternal(spid);
    }

    // Methods
    // void __thiscall Enchantment::Enchantment(Enchantment*,const Enchantment*)
    public void _ConstructorInternal(ACBindings.Enchantment* that) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Enchantment, ACBindings.Enchantment*, void>)0x004B8A00)(ref this, that);
    // int __thiscall Enchantment::Duel(Enchantment*,const Enchantment*)
    public int Duel(ACBindings.Enchantment* challenger) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Enchantment, ACBindings.Enchantment*, int>)0x005CBC10)(ref this, challenger);
    // int __thiscall Enchantment::Enchant(Enchantment*,float*)
    public int Enchant(float* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Enchantment, float*, int>)0x005CBC40)(ref this, value);
    // int __thiscall Enchantment::Enchant(Enchantment*,EnchantedQualityDetails*)
    public int Enchant(ACBindings.EnchantedQualityDetails* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Enchantment, ACBindings.EnchantedQualityDetails*, int>)0x005CBC80)(ref this, value);
    // unsigned int __thiscall Enchantment::GetPackSize(Enchantment*)
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Enchantment, uint>)0x005CBCF0)(ref this);
    // int __thiscall Enchantment::AffectsAttackSkills(Enchantment*,unsigned int)
    public int AffectsAttackSkills(uint key) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Enchantment, uint, int>)0x005CBD10)(ref this, key);
    // int __thiscall Enchantment::AffectsDefenseSkills(Enchantment*,unsigned int)
    public int AffectsDefenseSkills(uint key) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Enchantment, uint, int>)0x005CBD60)(ref this, key);
    // void __thiscall Enchantment::Enchantment(Enchantment*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Enchantment, void>)0x005CBDD0)(ref this);
    // void __thiscall Enchantment::Enchantment(Enchantment*,const unsigned int)
    public void _ConstructorInternal(uint spid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Enchantment, uint, void>)0x005CBE30)(ref this, spid);
    // unsigned int __thiscall Enchantment::Pack(Enchantment*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Enchantment, void**, uint, uint>)0x005CBEA0)(ref this, addr, size);
    // int __thiscall Enchantment::UnPack(Enchantment*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Enchantment, void**, uint, int>)0x005CBF70)(ref this, addr, size);
}

