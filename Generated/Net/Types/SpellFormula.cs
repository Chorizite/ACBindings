namespace ACBindings.Internal;

public unsafe struct SpellFormula
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct SpellFormula_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SpellFormula*, void> SpellFormula_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SpellFormula*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SpellFormula*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.SpellFormula*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public fixed uint _comps[8];

    // Methods

    /// <summary>
    /// <code>Offset: 0x005BD950
    /// int __thiscall SpellFormula::Complete(SpellFormula*)</code>
    /// </summary>
    public int Complete() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellFormula, int>)0x005BD950)(ref this);

    /// <summary>
    /// <code>Offset: 0x005BD970
    /// int __thiscall SpellFormula::SetComponent(SpellFormula*,const int,const unsigned int)</code>
    /// </summary>
    public int SetComponent(int num, uint comp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellFormula, int, uint, int>)0x005BD970)(ref this, num, comp);

    /// <summary>
    /// <code>Offset: 0x005BD990
    /// int __thiscall SpellFormula::GetNumSpellComponents(SpellFormula*)</code>
    /// </summary>
    public int GetNumSpellComponents() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellFormula, int>)0x005BD990)(ref this);

    /// <summary>
    /// <code>Offset: 0x005BD9E0
    /// unsigned int __thiscall SpellFormula::GetTargetingType(SpellFormula*)</code>
    /// </summary>
    public uint GetTargetingType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellFormula, uint>)0x005BD9E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005BDA10
    /// unsigned int __thiscall SpellFormula::GetPowerLevelOfPowerComponent(SpellFormula*)</code>
    /// </summary>
    public uint GetPowerLevelOfPowerComponent() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellFormula, uint>)0x005BDA10)(ref this);

    /// <summary>
    /// <code>Offset: 0x005BDA20
    /// unsigned int __thiscall SpellFormula::FindMostPowerfulPowerComponent(SpellFormula*,unsigned int*)</code>
    /// </summary>
    public uint FindMostPowerfulPowerComponent(uint* power_lvl) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellFormula, uint*, uint>)0x005BDA20)(ref this, power_lvl);

    /// <summary>
    /// <code>Offset: 0x005BDAC0
    /// int __thiscall SpellFormula::Decrypt(SpellFormula*,const unsigned int)</code>
    /// </summary>
    public int Decrypt(uint key) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellFormula, uint, int>)0x005BDAC0)(ref this, key);

    /// <summary>
    /// <code>Offset: 0x005BDB30
    /// unsigned int __thiscall SpellFormula::Pack(SpellFormula*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellFormula, void**, uint, uint>)0x005BDB30)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005BDBB0
    /// int __thiscall SpellFormula::UnPack(SpellFormula*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellFormula, void**, uint, int>)0x005BDBB0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005BDC40
    /// int __thiscall SpellFormula::RandomizeVersion1(_DWORD*,int*)</code>
    /// </summary>
    public int RandomizeVersion1(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellFormula, int*, int>)0x005BDC40)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x005BDE10
    /// int __thiscall SpellFormula::RandomizeVersion2(_DWORD*,int*)</code>
    /// </summary>
    public int RandomizeVersion2(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellFormula, int*, int>)0x005BDE10)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x005BDEF0
    /// int __thiscall SpellFormula::RandomizeVersion3(_DWORD*,int*)</code>
    /// </summary>
    public int RandomizeVersion3(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellFormula, int*, int>)0x005BDEF0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x005BE120
    /// int __thiscall SpellFormula::RandomizeForName(_DWORD*,int*,int)</code>
    /// </summary>
    public int RandomizeForName(int* a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SpellFormula, int*, int, int>)0x005BE120)(ref this, a2, a3);
}

