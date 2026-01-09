namespace ACBindings;

// CEnchantmentRegistry
public unsafe struct CEnchantmentRegistry
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // CEnchantmentRegistry_vtbl
    public unsafe struct CEnchantmentRegistry_vtbl
    {
        // Members
        public System.IntPtr CEnchantmentRegistry_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr _mult_list;
    public System.IntPtr _add_list;
    public System.IntPtr _cooldown_list;
    public ACBindings.Enchantment* _vitae;
    public uint m_cHelpfulEnchantments;
    public uint m_cHarmfulEnchantments;

    // Generated Constructor
    public CEnchantmentRegistry() {
        _ConstructorInternal();
    }

    // Methods
    // int __thiscall CEnchantmentRegistry::InqVitae(CEnchantmentRegistry*,Enchantment*)
    public int InqVitae(ACBindings.Enchantment* vitae) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CEnchantmentRegistry, ACBindings.Enchantment*, int>)0x00594770)(ref this, vitae);
    // unsigned int __thiscall CEnchantmentRegistry::pack_size(GenericQualitiesData*)
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CEnchantmentRegistry, uint>)0x005947B0)(ref this);
    // void __thiscall CEnchantmentRegistry::CEnchantmentRegistry(CEnchantmentRegistry*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CEnchantmentRegistry, void>)0x00594820)(ref this);
    // void __thiscall CEnchantmentRegistry::Clear(CEnchantmentRegistry*)
    public void Clear() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CEnchantmentRegistry, void>)0x00594840)(ref this);
    // int __thiscall CEnchantmentRegistry::UpdateVitae(CEnchantmentRegistry*,const Enchantment*)
    public int UpdateVitae(ACBindings.Enchantment* vitae) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CEnchantmentRegistry, ACBindings.Enchantment*, int>)0x00594890)(ref this, vitae);
    // unsigned int __thiscall CEnchantmentRegistry::Pack(CEnchantmentRegistry*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CEnchantmentRegistry, void**, uint, uint>)0x005948F0)(ref this, addr, size);
    // int __stdcall CEnchantmentRegistry::Enchant(int,float*)
    public static int Enchant(int a1, float* value) => ((delegate* unmanaged[Stdcall]<int, float*, int>)0x005949C0)(a1, value);
    // int __stdcall CEnchantmentRegistry::Enchant(int,EnchantedQualityDetails*)
    public static int Enchant(int a1, ACBindings.EnchantedQualityDetails* value) => ((delegate* unmanaged[Stdcall]<int, ACBindings.EnchantedQualityDetails*, int>)0x005949F0)(a1, value);
    // int __stdcall CEnchantmentRegistry::ReplaceEnchantmentInList(Enchantment*,int)
    public static int ReplaceEnchantmentInList(ACBindings.Enchantment* rhs, int a2) => ((delegate* unmanaged[Stdcall]<ACBindings.Enchantment*, int, int>)0x00594A20)(rhs, a2);
    // int __stdcall CEnchantmentRegistry::IsEnchantmentInList(int,int)
    public static int IsEnchantmentInList(int a1, int a2) => ((delegate* unmanaged[Stdcall]<int, int, int>)0x00594A70)(a1, a2);
    // int __thiscall CEnchantmentRegistry::UpdateSpellTotals(CEnchantmentRegistry*,unsigned int,int)
    public int UpdateSpellTotals(uint spell, int iDelta) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CEnchantmentRegistry, uint, int, int>)0x00594AB0)(ref this, spell, iDelta);
    // int __thiscall CEnchantmentRegistry::CountSpellsInList(CEnchantmentRegistry*,int)
    public int CountSpellsInList(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CEnchantmentRegistry, int, int>)0x00594B40)(ref this, a2);
    // int __stdcall CEnchantmentRegistry::AttemptToReplaceSpellInList(int,int)
    public static int AttemptToReplaceSpellInList(int a1, int a2) => ((delegate* unmanaged[Stdcall]<int, int, int>)0x00594B70)(a1, a2);
    // int __thiscall CEnchantmentRegistry::AddEnchantmentToList(CEnchantmentRegistry*,Enchantment*,_DWORD**)
    public int AddEnchantmentToList(ACBindings.Enchantment* a2, int** a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CEnchantmentRegistry, ACBindings.Enchantment*, int**, int>)0x00594C60)(ref this, a2, a3);
    // int __thiscall CEnchantmentRegistry::UpdateEnchantment(CEnchantmentRegistry*,const Enchantment*)
    public int UpdateEnchantment(ACBindings.Enchantment* to_update) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CEnchantmentRegistry, ACBindings.Enchantment*, int>)0x00594CE0)(ref this, to_update);
    // int __thiscall CEnchantmentRegistry::UpdateEnchantmentList(CEnchantmentRegistry*,int)
    public int UpdateEnchantmentList(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CEnchantmentRegistry, int, int>)0x00594DC0)(ref this, a2);
    // int __thiscall CEnchantmentRegistry::IsEnchanted(CEnchantmentRegistry*,const unsigned int)
    public int IsEnchanted(uint spell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CEnchantmentRegistry, uint, int>)0x00594DF0)(ref this, spell);
    // int __thiscall CEnchantmentRegistry::UnPack(CEnchantmentRegistry*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CEnchantmentRegistry, void**, uint, int>)0x00594E60)(ref this, addr, size);
    // int __stdcall CEnchantmentRegistry::Duel(Enchantment*,_DWORD*)
    public static int Duel(ACBindings.Enchantment* challenger, int* a2) => ((delegate* unmanaged[Stdcall]<ACBindings.Enchantment*, int*, int>)0x00595120)(challenger, a2);
    // int __thiscall CEnchantmentRegistry::RemoveEnchantmentFromList(CEnchantmentRegistry*,unsigned int,_DWORD*)
    public int RemoveEnchantmentFromList(uint spid, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CEnchantmentRegistry, uint, int*, int>)0x005951D0)(ref this, spid, a3);
    // int __thiscall CEnchantmentRegistry::OnCooldown(CEnchantmentRegistry*,const unsigned int,long double*)
    public int OnCooldown(uint cooldown_id, double* time_left) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CEnchantmentRegistry, uint, double*, int>)0x00595230)(ref this, cooldown_id, time_left);
    // int __stdcall CEnchantmentRegistry::GetEnchantmentsInEffectFromList(int,_DWORD*)
    public static int GetEnchantmentsInEffectFromList(int a1, int* a2) => ((delegate* unmanaged[Stdcall]<int, int*, int>)0x005952A0)(a1, a2);
    // int __stdcall CEnchantmentRegistry::CullEnchantmentsFromList(int,int,unsigned int,_DWORD*)
    public static int CullEnchantmentsFromList(int a1, int a2, uint key, int* a4) => ((delegate* unmanaged[Stdcall]<int, int, uint, int*, int>)0x005952E0)(a1, a2, key, a4);
    // int __thiscall CEnchantmentRegistry::RemoveEnchantment(CEnchantmentRegistry*,const unsigned int)
    public int RemoveEnchantment(uint eid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CEnchantmentRegistry, uint, int>)0x00595350)(ref this, eid);
    // int __thiscall CEnchantmentRegistry::GetEnchantmentsInEffect(int*,_DWORD*)
    public int GetEnchantmentsInEffect(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CEnchantmentRegistry, int*, int>)0x005953B0)(ref this, a2);
    // int __thiscall CEnchantmentRegistry::EnchantAttribute(CEnchantmentRegistry*,unsigned int,unsigned int*)
    public int EnchantAttribute(uint stype, uint* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CEnchantmentRegistry, uint, uint*, int>)0x005953E0)(ref this, stype, val);
    // int __thiscall CEnchantmentRegistry::EnchantAttribute2nd(CEnchantmentRegistry*,unsigned int,unsigned int*)
    public int EnchantAttribute2nd(uint stype, uint* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CEnchantmentRegistry, uint, uint*, int>)0x005954E0)(ref this, stype, val);
    // int __thiscall CEnchantmentRegistry::EnchantSkill(CEnchantmentRegistry*,unsigned int,int*)
    public int EnchantSkill(uint stype, int* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CEnchantmentRegistry, uint, int*, int>)0x00595620)(ref this, stype, val);
    // int __thiscall CEnchantmentRegistry::EnchantInt(CEnchantmentRegistry*,unsigned int,int*,int)
    public int EnchantInt(uint stype, int* val, int allow_negative) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CEnchantmentRegistry, uint, int*, int, int>)0x00595710)(ref this, stype, val, allow_negative);
    // int __thiscall CEnchantmentRegistry::EnchantFloat(CEnchantmentRegistry*,unsigned int,long double*)
    public int EnchantFloat(uint stype, double* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CEnchantmentRegistry, uint, double*, int>)0x00595820)(ref this, stype, val);
    // int __thiscall CEnchantmentRegistry::GetFloatEnchantmentDetails(CEnchantmentRegistry*,unsigned int,EnchantedQualityDetails*)
    public int GetFloatEnchantmentDetails(uint stype, ACBindings.EnchantedQualityDetails* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CEnchantmentRegistry, uint, ACBindings.EnchantedQualityDetails*, int>)0x00595900)(ref this, stype, val);
    // int __thiscall CEnchantmentRegistry::RemoveEnchantments(CEnchantmentRegistry*,int)
    public int RemoveEnchantments(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CEnchantmentRegistry, int, int>)0x005959B0)(ref this, a2);
    // int __thiscall CEnchantmentRegistry::PurgeEnchantmentList(CEnchantmentRegistry*,int)
    public int PurgeEnchantmentList(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CEnchantmentRegistry, int, int>)0x00595AC0)(ref this, a2);
    // int __thiscall CEnchantmentRegistry::PurgeBadEnchantmentList(CEnchantmentRegistry*,int)
    public int PurgeBadEnchantmentList(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CEnchantmentRegistry, int, int>)0x00595B80)(ref this, a2);
}

