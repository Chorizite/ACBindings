namespace ACBindings;

// CACQualities
public unsafe struct CACQualities
{
    // Base Classes
    public ACBindings.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.SerializeUsingPackDBObj
    public ACBindings.CBaseQualities BaseClass_CBaseQualities; // ACBindings.CBaseQualities

    // Child Types
    // CACQualities_vtbl
    public unsafe struct CACQualities_vtbl
    {
        // Members
        public System.IntPtr IUnknown_QueryInterface; // function pointer
        public System.IntPtr IUnknown_AddRef; // function pointer
        public System.IntPtr IUnknown_Release; // function pointer
        public System.IntPtr QueryInterface; // function pointer
        public System.IntPtr AddRef; // function pointer
        public System.IntPtr Release; // function pointer
        public System.IntPtr DBObj_dtor_18; // function pointer
        public System.IntPtr Serialize; // function pointer
        public System.IntPtr GetSubDataIDs; // function pointer
        public System.IntPtr InitLoad; // function pointer
        public System.IntPtr GetSubObjects; // function pointer
        public System.IntPtr ReleaseSubObjects; // function pointer
        public System.IntPtr NotifyFidelityLevel; // function pointer
        public System.IntPtr Refresh;
        public System.IntPtr CopyInto; // function pointer
        public System.IntPtr Destroy; // function pointer
        public System.IntPtr FillDataGraph; // function pointer
        public System.IntPtr SetDID;
        public System.IntPtr GetDBOType; // function pointer
        public System.IntPtr Allocate; // function pointer
        public System.IntPtr SaveToDisk;
        public System.IntPtr ReloadFromDisk; // function pointer
        public System.IntPtr InqPluralNameString;

        // Methods
    }

    // Members
    public ACBindings.AttributeCache* _attribCache;
    public System.IntPtr _skillStatsTable;
    public ACBindings.Body* _body;
    public ACBindings.CSpellBook* _spell_book;
    public ACBindings.CEnchantmentRegistry* _enchantment_reg;
    public ACBindings.EventFilter* _event_filter;
    public ACBindings.CEmoteTable* _emote_table;
    public System.IntPtr _create_list;
    public ACBindings.PageDataList* _pageDataList;
    public ACBindings.GeneratorTable* _generator_table;
    public ACBindings.GeneratorRegistry* _generator_registry;
    public ACBindings.GeneratorQueue* _generator_queue;

    // Generated Constructor
    public CACQualities(void** a2) {
        _ConstructorInternal(a2);
    }

    // Methods
    // int __thiscall CACQualities::HasSpellBook(CACQualities*)
    public int HasSpellBook() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CACQualities, int>)0x0058FCE0)(ref this);
    // int __thiscall CACQualities::IsSpellKnown(CACQualities*,const unsigned int)
    public int IsSpellKnown(uint spell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CACQualities, uint, int>)0x0058FCF0)(ref this, spell);
    // int __thiscall CACQualities::TranscribeSpells(_DWORD*,_DWORD*)
    public int TranscribeSpells(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CACQualities, int*, int>)0x0058FD10)(ref this, a2);
    // int __thiscall CACQualities::HasEnchantmentRegistry(CACQualities*)
    public int HasEnchantmentRegistry() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CACQualities, int>)0x0058FD30)(ref this);
    // int __thiscall CACQualities::IsEnchanted(CACQualities*,const unsigned int)
    public int IsEnchanted(uint spell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CACQualities, uint, int>)0x0058FD40)(ref this, spell);
    // int __thiscall CACQualities::PurgeEnchantments(CACQualities*)
    public int PurgeEnchantments() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CACQualities, int>)0x0058FD60)(ref this);
    // int __thiscall CACQualities::PurgeBadEnchantments(CACQualities*)
    public int PurgeBadEnchantments() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CACQualities, int>)0x0058FD70)(ref this);
    // int __thiscall CACQualities::GetEnchantmentsInEffect(_DWORD*,_DWORD*)
    public int GetEnchantmentsInEffect(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CACQualities, int*, int>)0x0058FD80)(ref this, a2);
    // int __thiscall CACQualities::RemoveEnchantment(CACQualities*,const unsigned int)
    public int RemoveEnchantment(uint eid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CACQualities, uint, int>)0x0058FDA0)(ref this, eid);
    // int __thiscall CACQualities::RemoveEnchantments(_DWORD*,int)
    public int RemoveEnchantments(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CACQualities, int, int>)0x0058FDC0)(ref this, a2);
    // int __thiscall CACQualities::UpdateEnchantment(CACQualities*,const Enchantment*)
    public int UpdateEnchantment(ACBindings.Enchantment* to_update) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CACQualities, ACBindings.Enchantment*, int>)0x0058FDE0)(ref this, to_update);
    // void __thiscall CACQualities::UpdateEnchantments(CEnchantmentRegistry**,int)
    public void UpdateEnchantments(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CACQualities, int, void>)0x0058FE20)(ref this, a2);
    // int __thiscall CACQualities::InqVitae(CACQualities*,Enchantment*)
    public int InqVitae(ACBindings.Enchantment* vitae) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CACQualities, ACBindings.Enchantment*, int>)0x0058FE60)(ref this, vitae);
    // float __thiscall CACQualities::GetVitaeValue(CACQualities*)
    public float GetVitaeValue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CACQualities, float>)0x0058FE80)(ref this);
    // int __thiscall CACQualities::EnchantAttribute(CACQualities*,unsigned int,unsigned int*)
    public int EnchantAttribute(uint stype, uint* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CACQualities, uint, uint*, int>)0x0058FEA0)(ref this, stype, val);
    // int __thiscall CACQualities::EnchantAttribute2nd(CACQualities*,unsigned int,unsigned int*)
    public int EnchantAttribute2nd(uint stype, uint* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CACQualities, uint, uint*, int>)0x0058FEC0)(ref this, stype, val);
    // int __thiscall CACQualities::EnchantSkill(CACQualities*,unsigned int,int*)
    public int EnchantSkill(uint stype, int* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CACQualities, uint, int*, int>)0x0058FEE0)(ref this, stype, val);
    // int __thiscall CACQualities::EnchantInt(CACQualities*,unsigned int,int*,int)
    public int EnchantInt(uint stype, int* val, int allow_negative) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CACQualities, uint, int*, int, int>)0x0058FF00)(ref this, stype, val, allow_negative);
    // int __thiscall CACQualities::EnchantFloat(CACQualities*,unsigned int,long double*)
    public int EnchantFloat(uint stype, double* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CACQualities, uint, double*, int>)0x0058FF20)(ref this, stype, val);
    // int __thiscall CACQualities::GetFloatEnchantmentDetails(CACQualities*,unsigned int,EnchantedQualityDetails*)
    public int GetFloatEnchantmentDetails(uint stype, ACBindings.EnchantedQualityDetails* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CACQualities, uint, ACBindings.EnchantedQualityDetails*, int>)0x0058FF40)(ref this, stype, val);
    // int __thiscall CACQualities::InqLoad(CACQualities*,float*)
    public int InqLoad(float* load) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CACQualities, float*, int>)0x0058FF60)(ref this, load);
    // int __thiscall CACQualities::AddSpell(CACQualities*,const unsigned int)
    public int AddSpell(uint newSpell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CACQualities, uint, int>)0x00590050)(ref this, newSpell);
    // int __thiscall CACQualities::RemoveSpell(CACQualities*,const unsigned int)
    public int RemoveSpell(uint spell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CACQualities, uint, int>)0x005900B0)(ref this, spell);
    // int __thiscall CACQualities::InqPluralNameString(_DWORD*,int*)
    public int InqPluralNameString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CACQualities, int*, int>)0x00590680)(ref this, a2);
    // int __thiscall CACQualities::InqAttribute(CACQualities*,unsigned int,Attribute*)
    public int InqAttribute(uint stype, ACBindings.Attribute* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CACQualities, uint, ACBindings.Attribute*, int>)0x005926D0)(ref this, stype, retval);
    // int __thiscall CACQualities::InqAttribute(CACQualities*,unsigned int,unsigned int*,int)
    public int InqAttribute(uint stype, uint* retval, int raw) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CACQualities, uint, uint*, int, int>)0x00592700)(ref this, stype, retval, raw);
    // int __thiscall CACQualities::SetAttribute(CACQualities*,unsigned int,const Attribute*)
    public int SetAttribute(uint stype, ACBindings.Attribute* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CACQualities, uint, ACBindings.Attribute*, int>)0x00592750)(ref this, stype, val);
    // int __thiscall CACQualities::SetAttribute(CACQualities*,unsigned int,unsigned int)
    public int SetAttribute(uint stype, uint init_val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CACQualities, uint, uint, int>)0x005927A0)(ref this, stype, init_val);
    // int __thiscall CACQualities::InqAttribute2nd(CACQualities*,unsigned int,SecondaryAttribute*)
    public int InqAttribute2nd(uint stype, ACBindings.SecondaryAttribute* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CACQualities, uint, ACBindings.SecondaryAttribute*, int>)0x005927F0)(ref this, stype, retval);
    // int __thiscall CACQualities::InqMaxRunRate(CACQualities*,float*)
    public int InqMaxRunRate(float* rate) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CACQualities, float*, int>)0x00592820)(ref this, rate);
    // int __thiscall CACQualities::CanJump(CACQualities*,float)
    public int CanJump(float extent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CACQualities, float, int>)0x00592850)(ref this, extent);
    // int __thiscall CACQualities::JumpStaminaCost(CACQualities*,float,int*)
    public int JumpStaminaCost(float extent, int* cost) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CACQualities, float, int*, int>)0x00592890)(ref this, extent, cost);
    // int __thiscall CACQualities::InqAttribute2ndBaseLevel(CACQualities*,unsigned int,unsigned int*,int)
    public int InqAttribute2ndBaseLevel(uint stype, uint* retval, int raw) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CACQualities, uint, uint*, int, int>)0x00592A20)(ref this, stype, retval, raw);
    // int __thiscall CACQualities::InqSkill(CACQualities*,unsigned int,Skill*)
    public int InqSkill(uint stype, ACBindings.Skill* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CACQualities, uint, ACBindings.Skill*, int>)0x00592AF0)(ref this, stype, retval);
    // int __thiscall CACQualities::InqSkillLevel(CACQualities*,unsigned int,int*)
    public int InqSkillLevel(uint stype, int* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CACQualities, uint, int*, int>)0x00592B40)(ref this, stype, retval);
    // int __thiscall CACQualities::InqSkillAdvancementClass(CACQualities*,unsigned int,SKILL_ADVANCEMENT_CLASS*)
    public int InqSkillAdvancementClass(uint stype, ACBindings.SKILL_ADVANCEMENT_CLASS* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CACQualities, uint, ACBindings.SKILL_ADVANCEMENT_CLASS*, int>)0x00592B70)(ref this, stype, retval);
    // int __thiscall CACQualities::InqAttribute2nd(CACQualities*,unsigned int,unsigned int*,int)
    public int InqAttribute2nd(uint stype, uint* retval, int raw) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CACQualities, uint, uint*, int, int>)0x00592D20)(ref this, stype, retval, raw);
    // int __thiscall CACQualities::BoundsCheck(CACQualities*,unsigned int,int*,unsigned int*)
    public int BoundsCheck(uint stype, int* val, uint* max) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CACQualities, uint, int*, uint*, int>)0x00592E00)(ref this, stype, val, max);
    // int __thiscall CACQualities::InqSkillBaseLevel(CACQualities*,unsigned int,int*,int)
    public int InqSkillBaseLevel(uint stype, int* retval, int raw) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CACQualities, uint, int*, int, int>)0x00592E60)(ref this, stype, retval, raw);
    // int __thiscall CACQualities::SetSkill(CACQualities*,unsigned int,const Skill*)
    public int SetSkill(uint stype, ACBindings.Skill* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CACQualities, uint, ACBindings.Skill*, int>)0x00592F60)(ref this, stype, val);
    // int __thiscall CACQualities::SetSkillLevel(CACQualities*,unsigned int,unsigned int)
    public int SetSkillLevel(uint stype, uint val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CACQualities, uint, uint, int>)0x00593060)(ref this, stype, val);
    // int __thiscall CACQualities::SetSkillAdvancementClass(CACQualities*,unsigned int,SKILL_ADVANCEMENT_CLASS)
    public int SetSkillAdvancementClass(uint stype, ACBindings.SKILL_ADVANCEMENT_CLASS val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CACQualities, uint, ACBindings.SKILL_ADVANCEMENT_CLASS, int>)0x00593150)(ref this, stype, val);
    // int __thiscall CACQualities::SetAttribute2nd(CACQualities*,unsigned int,const SecondaryAttribute*)
    public int SetAttribute2nd(uint stype, ACBindings.SecondaryAttribute* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CACQualities, uint, ACBindings.SecondaryAttribute*, int>)0x00593250)(ref this, stype, val);
    // int __thiscall CACQualities::SetAttribute2nd(CACQualities*,unsigned int,unsigned int,unsigned int*,unsigned int*)
    public int SetAttribute2nd(uint stype, uint val, uint* bounded_val, uint* max) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CACQualities, uint, uint, uint*, uint*, int>)0x00593310)(ref this, stype, val, bounded_val, max);
    // int __thiscall CACQualities::InqSkill(CACQualities*,unsigned int,int*,int)
    public int InqSkill(uint stype, int* retval, int raw) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CACQualities, uint, int*, int, int>)0x00593380)(ref this, stype, retval, raw);
    // int __thiscall CACQualities::InqRunRate(CACQualities*,float*)
    public int InqRunRate(float* rate) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CACQualities, float*, int>)0x00593570)(ref this, rate);
    // int __thiscall CACQualities::InqJumpVelocity(CACQualities*,float,float*)
    public int InqJumpVelocity(float extent, float* v_z) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CACQualities, float, float*, int>)0x00593740)(ref this, extent, v_z);
    // int __thiscall CACQualities::SetAttribute2nd(CACQualities*,unsigned int,unsigned int)
    public int SetAttribute2nd(uint stype, uint val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CACQualities, uint, uint, int>)0x00593AF0)(ref this, stype, val);
    // void __thiscall CACQualities::Clear(CACQualities*)
    public void Clear() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CACQualities, void>)0x00593B10)(ref this);
    // int __thiscall CACQualities::InqWeenieTypeString(CACQualities*,char*,const unsigned int)
    public int InqWeenieTypeString(sbyte* buff, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CACQualities, sbyte*, uint, int>)0x00593C00)(ref this, buff, size);
    // void __thiscall CACQualities::SetPackHeader(CACQualities*,unsigned int*)
    public void SetPackHeader(uint* bitfield) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CACQualities, uint*, void>)0x00593C20)(ref this, bitfield);
    // unsigned int __thiscall CACQualities::GetPackSize(CACQualities*)
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CACQualities, uint>)0x00593CC0)(ref this);
    // int __thiscall CACQualities::CACQualities(int,void**)
    public int _ConstructorInternal(void** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CACQualities, void**, int>)0x00593E70)(ref this, a2);
    // unsigned int __thiscall CACQualities::GetDBOType(CACQualities*)
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CACQualities, uint>)0x00593EF0)(ref this);
    // DBObj* __cdecl CACQualities::Allocator()
    public static ACBindings.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.DBObj*>)0x00593FF0)();
    // unsigned int __thiscall CACQualities::Pack(CACQualities*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CACQualities, void**, uint, uint>)0x00594020)(ref this, addr, size);
    // unsigned int __thiscall CACQualities::Pack2(char*,void**,unsigned int)
    public uint Pack2(void** a2, uint a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CACQualities, void**, uint, uint>)0x005941C0)(ref this, a2, a3);
    // int __thiscall CACQualities::UnPack(CACQualities*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CACQualities, void**, uint, int>)0x005941D0)(ref this, addr, size);
    // int __thiscall CACQualities::UnPack2(char*,void**,unsigned int)
    public int UnPack2(void** a2, uint a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CACQualities, void**, uint, int>)0x00594760)(ref this, a2, a3);
}

