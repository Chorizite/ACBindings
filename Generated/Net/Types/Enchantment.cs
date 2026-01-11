namespace ACBindings.Internal;

public unsafe struct Enchantment
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct Enchantment_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Enchantment*, void> Enchantment_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Enchantment*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Enchantment*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Enchantment*, void**, uint, int> UnPack; // function pointer

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
    public ACBindings.Internal.StatMod _smod;

    // Generated Constructor
    public Enchantment(ACBindings.Internal.Enchantment* that) {
        _ConstructorInternal(that);
    }
    public Enchantment() {
        _ConstructorInternal();
    }
    public Enchantment(uint spid) {
        _ConstructorInternal(spid);
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x004B8A00
    /// void __thiscall Enchantment::Enchantment(Enchantment*,const Enchantment*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.Enchantment* that) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Enchantment, ACBindings.Internal.Enchantment*, void>)0x004B8A00)(ref this, that);

    /// <summary>
    /// <code>Offset: 0x005CBC10
    /// int __thiscall Enchantment::Duel(Enchantment*,const Enchantment*)</code>
    /// </summary>
    public int Duel(ACBindings.Internal.Enchantment* challenger) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Enchantment, ACBindings.Internal.Enchantment*, int>)0x005CBC10)(ref this, challenger);

    /// <summary>
    /// <code>Offset: 0x005CBC40
    /// int __thiscall Enchantment::Enchant(Enchantment*,float*)</code>
    /// </summary>
    public int Enchant(float* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Enchantment, float*, int>)0x005CBC40)(ref this, value);

    /// <summary>
    /// <code>Offset: 0x005CBC80
    /// int __thiscall Enchantment::Enchant(Enchantment*,EnchantedQualityDetails*)</code>
    /// </summary>
    public int Enchant(ACBindings.Internal.EnchantedQualityDetails* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Enchantment, ACBindings.Internal.EnchantedQualityDetails*, int>)0x005CBC80)(ref this, value);

    /// <summary>
    /// <code>Offset: 0x005CBCF0
    /// unsigned int __thiscall Enchantment::GetPackSize(Enchantment*)</code>
    /// </summary>
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Enchantment, uint>)0x005CBCF0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005CBD10
    /// int __thiscall Enchantment::AffectsAttackSkills(Enchantment*,unsigned int)</code>
    /// </summary>
    public int AffectsAttackSkills(uint key) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Enchantment, uint, int>)0x005CBD10)(ref this, key);

    /// <summary>
    /// <code>Offset: 0x005CBD60
    /// int __thiscall Enchantment::AffectsDefenseSkills(Enchantment*,unsigned int)</code>
    /// </summary>
    public int AffectsDefenseSkills(uint key) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Enchantment, uint, int>)0x005CBD60)(ref this, key);

    /// <summary>
    /// <code>Offset: 0x005CBDD0
    /// void __thiscall Enchantment::Enchantment(Enchantment*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Enchantment, void>)0x005CBDD0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005CBE30
    /// void __thiscall Enchantment::Enchantment(Enchantment*,const unsigned int)</code>
    /// </summary>
    public void _ConstructorInternal(uint spid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Enchantment, uint, void>)0x005CBE30)(ref this, spid);

    /// <summary>
    /// <code>Offset: 0x005CBEA0
    /// unsigned int __thiscall Enchantment::Pack(Enchantment*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Enchantment, void**, uint, uint>)0x005CBEA0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005CBF70
    /// int __thiscall Enchantment::UnPack(Enchantment*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Enchantment, void**, uint, int>)0x005CBF70)(ref this, addr, size);
}

