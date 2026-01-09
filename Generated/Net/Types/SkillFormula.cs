namespace ACBindings;

// SkillFormula
public unsafe struct SkillFormula
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // SkillFormula_vtbl
    public unsafe struct SkillFormula_vtbl
    {
        // Members
        public System.IntPtr SkillFormula_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

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
    public SkillFormula(ACBindings.SkillFormula* that) {
        _ConstructorInternal(that);
    }

    // Methods
    // void __thiscall SkillFormula::SkillFormula(SkillFormula*,const SkillFormula*)
    public void _ConstructorInternal(ACBindings.SkillFormula* that) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SkillFormula, ACBindings.SkillFormula*, void>)0x00480710)(ref this, that);
    // int __thiscall SkillFormula::Calculate(SkillFormula*,unsigned int,unsigned int,unsigned int*)
    public int Calculate(uint attr1, uint attr2, uint* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SkillFormula, uint, uint, uint*, int>)0x00592660)(ref this, attr1, attr2, retval);
    // unsigned int __thiscall SkillFormula::Pack(SkillFormula*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SkillFormula, void**, uint, uint>)0x005CB7E0)(ref this, addr, size);
    // int __thiscall SkillFormula::UnPack(SkillFormula*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SkillFormula, void**, uint, int>)0x005CB840)(ref this, addr, size);
}

