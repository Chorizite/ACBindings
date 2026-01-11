namespace ACBindings.Internal;

public unsafe struct SkillFormula
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct SkillFormula_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SkillFormula*, void> SkillFormula_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SkillFormula*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SkillFormula*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SkillFormula*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint _w;
    public uint _x;
    public uint _y;
    public uint _z;
    public uint _attr1;
    public uint _attr2;

    // Generated Constructor
    public SkillFormula(ACBindings.Internal.SkillFormula* that) {
        _ConstructorInternal(that);
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00480710
    /// void __thiscall SkillFormula::SkillFormula(SkillFormula*,const SkillFormula*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.SkillFormula* that) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkillFormula, ACBindings.Internal.SkillFormula*, void>)0x00480710)(ref this, that);

    /// <summary>
    /// <code>Offset: 0x00592660
    /// int __thiscall SkillFormula::Calculate(SkillFormula*,unsigned int,unsigned int,unsigned int*)</code>
    /// </summary>
    public int Calculate(uint attr1, uint attr2, uint* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkillFormula, uint, uint, uint*, int>)0x00592660)(ref this, attr1, attr2, retval);

    /// <summary>
    /// <code>Offset: 0x005CB7E0
    /// unsigned int __thiscall SkillFormula::Pack(SkillFormula*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkillFormula, void**, uint, uint>)0x005CB7E0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005CB840
    /// int __thiscall SkillFormula::UnPack(SkillFormula*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkillFormula, void**, uint, int>)0x005CB840)(ref this, addr, size);
}

