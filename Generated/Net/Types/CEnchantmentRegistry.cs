namespace ACBindings.Internal;

public unsafe struct CEnchantmentRegistry
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct CEnchantmentRegistry_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CEnchantmentRegistry*, void> CEnchantmentRegistry_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CEnchantmentRegistry*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CEnchantmentRegistry*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CEnchantmentRegistry*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr _mult_list;
    public System.IntPtr _add_list;
    public System.IntPtr _cooldown_list;
    public ACBindings.Internal.Enchantment* _vitae;
    public uint m_cHelpfulEnchantments;
    public uint m_cHarmfulEnchantments;

    // Generated Constructor
    public CEnchantmentRegistry() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00594770
    /// int __thiscall CEnchantmentRegistry::InqVitae(CEnchantmentRegistry*,Enchantment*)</code>
    /// </summary>
    public int InqVitae(ACBindings.Internal.Enchantment* vitae) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnchantmentRegistry, ACBindings.Internal.Enchantment*, int>)0x00594770)(ref this, vitae);

    /// <summary>
    /// <code>Offset: 0x005947B0
    /// unsigned int __thiscall CEnchantmentRegistry::pack_size(GenericQualitiesData*)</code>
    /// </summary>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnchantmentRegistry, uint>)0x005947B0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00594820
    /// void __thiscall CEnchantmentRegistry::CEnchantmentRegistry(CEnchantmentRegistry*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnchantmentRegistry, void>)0x00594820)(ref this);

    /// <summary>
    /// <code>Offset: 0x00594840
    /// void __thiscall CEnchantmentRegistry::Clear(CEnchantmentRegistry*)</code>
    /// </summary>
    public void Clear() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnchantmentRegistry, void>)0x00594840)(ref this);

    /// <summary>
    /// <code>Offset: 0x00594890
    /// int __thiscall CEnchantmentRegistry::UpdateVitae(CEnchantmentRegistry*,const Enchantment*)</code>
    /// </summary>
    public int UpdateVitae(ACBindings.Internal.Enchantment* vitae) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnchantmentRegistry, ACBindings.Internal.Enchantment*, int>)0x00594890)(ref this, vitae);

    /// <summary>
    /// <code>Offset: 0x005948F0
    /// unsigned int __thiscall CEnchantmentRegistry::Pack(CEnchantmentRegistry*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnchantmentRegistry, void**, uint, uint>)0x005948F0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005949C0
    /// int __stdcall CEnchantmentRegistry::Enchant(int,float*)</code>
    /// </summary>
    public static int Enchant(int a1, float* value) => ((delegate* unmanaged[Stdcall]<int, float*, int>)0x005949C0)(a1, value);

    /// <summary>
    /// <code>Offset: 0x005949F0
    /// int __stdcall CEnchantmentRegistry::Enchant(int,EnchantedQualityDetails*)</code>
    /// </summary>
    public static int Enchant(int a1, ACBindings.Internal.EnchantedQualityDetails* value) => ((delegate* unmanaged[Stdcall]<int, ACBindings.Internal.EnchantedQualityDetails*, int>)0x005949F0)(a1, value);

    /// <summary>
    /// <code>Offset: 0x00594A20
    /// int __stdcall CEnchantmentRegistry::ReplaceEnchantmentInList(Enchantment*,int)</code>
    /// </summary>
    public static int ReplaceEnchantmentInList(ACBindings.Internal.Enchantment* rhs, int a2) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.Enchantment*, int, int>)0x00594A20)(rhs, a2);

    /// <summary>
    /// <code>Offset: 0x00594A70
    /// int __stdcall CEnchantmentRegistry::IsEnchantmentInList(int,int)</code>
    /// </summary>
    public static int IsEnchantmentInList(int a1, int a2) => ((delegate* unmanaged[Stdcall]<int, int, int>)0x00594A70)(a1, a2);

    /// <summary>
    /// <code>Offset: 0x00594AB0
    /// int __thiscall CEnchantmentRegistry::UpdateSpellTotals(CEnchantmentRegistry*,unsigned int,int)</code>
    /// </summary>
    public int UpdateSpellTotals(uint spell, int iDelta) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnchantmentRegistry, uint, int, int>)0x00594AB0)(ref this, spell, iDelta);

    /// <summary>
    /// <code>Offset: 0x00594B40
    /// int __thiscall CEnchantmentRegistry::CountSpellsInList(CEnchantmentRegistry*,int)</code>
    /// </summary>
    public int CountSpellsInList(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnchantmentRegistry, int, int>)0x00594B40)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x00594B70
    /// int __stdcall CEnchantmentRegistry::AttemptToReplaceSpellInList(int,int)</code>
    /// </summary>
    public static int AttemptToReplaceSpellInList(int a1, int a2) => ((delegate* unmanaged[Stdcall]<int, int, int>)0x00594B70)(a1, a2);

    /// <summary>
    /// <code>Offset: 0x00594C60
    /// int __thiscall CEnchantmentRegistry::AddEnchantmentToList(CEnchantmentRegistry*,Enchantment*,_DWORD**)</code>
    /// </summary>
    public int AddEnchantmentToList(ACBindings.Internal.Enchantment* a2, int** a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnchantmentRegistry, ACBindings.Internal.Enchantment*, int**, int>)0x00594C60)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x00594CE0
    /// int __thiscall CEnchantmentRegistry::UpdateEnchantment(CEnchantmentRegistry*,const Enchantment*)</code>
    /// </summary>
    public int UpdateEnchantment(ACBindings.Internal.Enchantment* to_update) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnchantmentRegistry, ACBindings.Internal.Enchantment*, int>)0x00594CE0)(ref this, to_update);

    /// <summary>
    /// <code>Offset: 0x00594DC0
    /// int __thiscall CEnchantmentRegistry::UpdateEnchantmentList(CEnchantmentRegistry*,int)</code>
    /// </summary>
    public int UpdateEnchantmentList(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnchantmentRegistry, int, int>)0x00594DC0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x00594DF0
    /// int __thiscall CEnchantmentRegistry::IsEnchanted(CEnchantmentRegistry*,const unsigned int)</code>
    /// </summary>
    public int IsEnchanted(uint spell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnchantmentRegistry, uint, int>)0x00594DF0)(ref this, spell);

    /// <summary>
    /// <code>Offset: 0x00594E60
    /// int __thiscall CEnchantmentRegistry::UnPack(CEnchantmentRegistry*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnchantmentRegistry, void**, uint, int>)0x00594E60)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x00595120
    /// int __stdcall CEnchantmentRegistry::Duel(Enchantment*,_DWORD*)</code>
    /// </summary>
    public static int Duel(ACBindings.Internal.Enchantment* challenger, int* a2) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.Enchantment*, int*, int>)0x00595120)(challenger, a2);

    /// <summary>
    /// <code>Offset: 0x005951D0
    /// int __thiscall CEnchantmentRegistry::RemoveEnchantmentFromList(CEnchantmentRegistry*,unsigned int,_DWORD*)</code>
    /// </summary>
    public int RemoveEnchantmentFromList(uint spid, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnchantmentRegistry, uint, int*, int>)0x005951D0)(ref this, spid, a3);

    /// <summary>
    /// <code>Offset: 0x00595230
    /// int __thiscall CEnchantmentRegistry::OnCooldown(CEnchantmentRegistry*,const unsigned int,long double*)</code>
    /// </summary>
    public int OnCooldown(uint cooldown_id, double* time_left) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnchantmentRegistry, uint, double*, int>)0x00595230)(ref this, cooldown_id, time_left);

    /// <summary>
    /// <code>Offset: 0x005952A0
    /// int __stdcall CEnchantmentRegistry::GetEnchantmentsInEffectFromList(int,_DWORD*)</code>
    /// </summary>
    public static int GetEnchantmentsInEffectFromList(int a1, int* a2) => ((delegate* unmanaged[Stdcall]<int, int*, int>)0x005952A0)(a1, a2);

    /// <summary>
    /// <code>Offset: 0x005952E0
    /// int __stdcall CEnchantmentRegistry::CullEnchantmentsFromList(int,int,unsigned int,_DWORD*)</code>
    /// </summary>
    public static int CullEnchantmentsFromList(int a1, int a2, uint key, int* a4) => ((delegate* unmanaged[Stdcall]<int, int, uint, int*, int>)0x005952E0)(a1, a2, key, a4);

    /// <summary>
    /// <code>Offset: 0x00595350
    /// int __thiscall CEnchantmentRegistry::RemoveEnchantment(CEnchantmentRegistry*,const unsigned int)</code>
    /// </summary>
    public int RemoveEnchantment(uint eid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnchantmentRegistry, uint, int>)0x00595350)(ref this, eid);

    /// <summary>
    /// <code>Offset: 0x005953B0
    /// int __thiscall CEnchantmentRegistry::GetEnchantmentsInEffect(int*,_DWORD*)</code>
    /// </summary>
    public int GetEnchantmentsInEffect(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnchantmentRegistry, int*, int>)0x005953B0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x005953E0
    /// int __thiscall CEnchantmentRegistry::EnchantAttribute(CEnchantmentRegistry*,unsigned int,unsigned int*)</code>
    /// </summary>
    public int EnchantAttribute(uint stype, uint* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnchantmentRegistry, uint, uint*, int>)0x005953E0)(ref this, stype, val);

    /// <summary>
    /// <code>Offset: 0x005954E0
    /// int __thiscall CEnchantmentRegistry::EnchantAttribute2nd(CEnchantmentRegistry*,unsigned int,unsigned int*)</code>
    /// </summary>
    public int EnchantAttribute2nd(uint stype, uint* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnchantmentRegistry, uint, uint*, int>)0x005954E0)(ref this, stype, val);

    /// <summary>
    /// <code>Offset: 0x00595620
    /// int __thiscall CEnchantmentRegistry::EnchantSkill(CEnchantmentRegistry*,unsigned int,int*)</code>
    /// </summary>
    public int EnchantSkill(uint stype, int* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnchantmentRegistry, uint, int*, int>)0x00595620)(ref this, stype, val);

    /// <summary>
    /// <code>Offset: 0x00595710
    /// int __thiscall CEnchantmentRegistry::EnchantInt(CEnchantmentRegistry*,unsigned int,int*,int)</code>
    /// </summary>
    public int EnchantInt(uint stype, int* val, int allow_negative) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnchantmentRegistry, uint, int*, int, int>)0x00595710)(ref this, stype, val, allow_negative);

    /// <summary>
    /// <code>Offset: 0x00595820
    /// int __thiscall CEnchantmentRegistry::EnchantFloat(CEnchantmentRegistry*,unsigned int,long double*)</code>
    /// </summary>
    public int EnchantFloat(uint stype, double* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnchantmentRegistry, uint, double*, int>)0x00595820)(ref this, stype, val);

    /// <summary>
    /// <code>Offset: 0x00595900
    /// int __thiscall CEnchantmentRegistry::GetFloatEnchantmentDetails(CEnchantmentRegistry*,unsigned int,EnchantedQualityDetails*)</code>
    /// </summary>
    public int GetFloatEnchantmentDetails(uint stype, ACBindings.Internal.EnchantedQualityDetails* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnchantmentRegistry, uint, ACBindings.Internal.EnchantedQualityDetails*, int>)0x00595900)(ref this, stype, val);

    /// <summary>
    /// <code>Offset: 0x005959B0
    /// int __thiscall CEnchantmentRegistry::RemoveEnchantments(CEnchantmentRegistry*,int)</code>
    /// </summary>
    public int RemoveEnchantments(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnchantmentRegistry, int, int>)0x005959B0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x00595AC0
    /// int __thiscall CEnchantmentRegistry::PurgeEnchantmentList(CEnchantmentRegistry*,int)</code>
    /// </summary>
    public int PurgeEnchantmentList(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnchantmentRegistry, int, int>)0x00595AC0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x00595B80
    /// int __thiscall CEnchantmentRegistry::PurgeBadEnchantmentList(CEnchantmentRegistry*,int)</code>
    /// </summary>
    public int PurgeBadEnchantmentList(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CEnchantmentRegistry, int, int>)0x00595B80)(ref this, a2);
}

