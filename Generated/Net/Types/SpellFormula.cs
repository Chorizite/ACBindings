namespace ACBindings;

// SpellFormula
public unsafe struct SpellFormula
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // SpellFormula_vtbl
    public unsafe struct SpellFormula_vtbl
    {
        // Members
        public System.IntPtr SpellFormula_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public fixed uint _comps[8];

    // Methods
    // int __thiscall SpellFormula::Complete(SpellFormula*)
    public int Complete() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SpellFormula, int>)0x005BD950)(ref this);
    // int __thiscall SpellFormula::SetComponent(SpellFormula*,const int,const unsigned int)
    public int SetComponent(int num, uint comp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SpellFormula, int, uint, int>)0x005BD970)(ref this, num, comp);
    // int __thiscall SpellFormula::GetNumSpellComponents(SpellFormula*)
    public int GetNumSpellComponents() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SpellFormula, int>)0x005BD990)(ref this);
    // unsigned int __thiscall SpellFormula::GetTargetingType(SpellFormula*)
    public uint GetTargetingType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SpellFormula, uint>)0x005BD9E0)(ref this);
    // unsigned int __thiscall SpellFormula::GetPowerLevelOfPowerComponent(SpellFormula*)
    public uint GetPowerLevelOfPowerComponent() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SpellFormula, uint>)0x005BDA10)(ref this);
    // unsigned int __thiscall SpellFormula::FindMostPowerfulPowerComponent(SpellFormula*,unsigned int*)
    public uint FindMostPowerfulPowerComponent(uint* power_lvl) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SpellFormula, uint*, uint>)0x005BDA20)(ref this, power_lvl);
    // int __thiscall SpellFormula::Decrypt(SpellFormula*,const unsigned int)
    public int Decrypt(uint key) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SpellFormula, uint, int>)0x005BDAC0)(ref this, key);
    // unsigned int __thiscall SpellFormula::Pack(SpellFormula*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SpellFormula, void**, uint, uint>)0x005BDB30)(ref this, addr, size);
    // int __thiscall SpellFormula::UnPack(SpellFormula*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SpellFormula, void**, uint, int>)0x005BDBB0)(ref this, addr, size);
    // int __thiscall SpellFormula::RandomizeVersion1(_DWORD*,int*)
    public int RandomizeVersion1(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SpellFormula, int*, int>)0x005BDC40)(ref this, a2);
    // int __thiscall SpellFormula::RandomizeVersion2(_DWORD*,int*)
    public int RandomizeVersion2(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SpellFormula, int*, int>)0x005BDE10)(ref this, a2);
    // int __thiscall SpellFormula::RandomizeVersion3(_DWORD*,int*)
    public int RandomizeVersion3(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SpellFormula, int*, int>)0x005BDEF0)(ref this, a2);
    // int __thiscall SpellFormula::RandomizeForName(_DWORD*,int*,int)
    public int RandomizeForName(int* a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SpellFormula, int*, int, int>)0x005BE120)(ref this, a2, a3);
}

