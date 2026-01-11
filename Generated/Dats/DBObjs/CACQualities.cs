namespace ACBindings.Internal;

public unsafe struct CACQualities
{
    // Base Classes
    public ACBindings.Internal.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.Internal.SerializeUsingPackDBObj
    public ACBindings.Internal.CBaseQualities BaseClass_CBaseQualities; // ACBindings.Internal.CBaseQualities

    // Child Types
    public unsafe struct CACQualities_vtbl
    {
        // Members
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, ACBindings.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*> QueryInterface; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> AddRef; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> Release; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, void> DBObj_dtor_18; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.Archive*, void> Serialize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> InitLoad; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> GetSubObjects; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> ReleaseSubObjects; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> NotifyFidelityLevel; // function pointer
        public System.IntPtr Refresh;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.DBObj*, byte> CopyInto; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, void> Destroy; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.IDataGraph*, void> FillDataGraph; // function pointer
        public System.IntPtr SetDID;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, uint> GetDBOType; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.DBObj*> Allocate; // function pointer
        public System.IntPtr SaveToDisk;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> ReloadFromDisk; // function pointer
        public System.IntPtr InqPluralNameString;

        // Methods
    }

    // Members
    public ACBindings.Internal.AttributeCache* _attribCache;
    public System.IntPtr _skillStatsTable;
    public ACBindings.Internal.Body* _body;
    public ACBindings.Internal.CSpellBook* _spell_book;
    public ACBindings.Internal.CEnchantmentRegistry* _enchantment_reg;
    public ACBindings.Internal.EventFilter* _event_filter;
    public ACBindings.Internal.CEmoteTable* _emote_table;
    public System.IntPtr _create_list;
    public ACBindings.Internal.PageDataList* _pageDataList;
    public ACBindings.Internal.GeneratorTable* _generator_table;
    public ACBindings.Internal.GeneratorRegistry* _generator_registry;
    public ACBindings.Internal.GeneratorQueue* _generator_queue;

    // Generated Constructor
    public CACQualities(void** a2) {
        _ConstructorInternal(a2);
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0058FCE0
    /// int __thiscall CACQualities::HasSpellBook(CACQualities*)</code>
    /// </summary>
    public int HasSpellBook() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, int>)0x0058FCE0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0058FCF0
    /// int __thiscall CACQualities::IsSpellKnown(CACQualities*,const unsigned int)</code>
    /// </summary>
    public int IsSpellKnown(uint spell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, uint, int>)0x0058FCF0)(ref this, spell);

    /// <summary>
    /// <code>Offset: 0x0058FD10
    /// int __thiscall CACQualities::TranscribeSpells(_DWORD*,_DWORD*)</code>
    /// </summary>
    public int TranscribeSpells(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, int*, int>)0x0058FD10)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x0058FD30
    /// int __thiscall CACQualities::HasEnchantmentRegistry(CACQualities*)</code>
    /// </summary>
    public int HasEnchantmentRegistry() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, int>)0x0058FD30)(ref this);

    /// <summary>
    /// <code>Offset: 0x0058FD40
    /// int __thiscall CACQualities::IsEnchanted(CACQualities*,const unsigned int)</code>
    /// </summary>
    public int IsEnchanted(uint spell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, uint, int>)0x0058FD40)(ref this, spell);

    /// <summary>
    /// <code>Offset: 0x0058FD60
    /// int __thiscall CACQualities::PurgeEnchantments(CACQualities*)</code>
    /// </summary>
    public int PurgeEnchantments() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, int>)0x0058FD60)(ref this);

    /// <summary>
    /// <code>Offset: 0x0058FD70
    /// int __thiscall CACQualities::PurgeBadEnchantments(CACQualities*)</code>
    /// </summary>
    public int PurgeBadEnchantments() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, int>)0x0058FD70)(ref this);

    /// <summary>
    /// <code>Offset: 0x0058FD80
    /// int __thiscall CACQualities::GetEnchantmentsInEffect(_DWORD*,_DWORD*)</code>
    /// </summary>
    public int GetEnchantmentsInEffect(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, int*, int>)0x0058FD80)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x0058FDA0
    /// int __thiscall CACQualities::RemoveEnchantment(CACQualities*,const unsigned int)</code>
    /// </summary>
    public int RemoveEnchantment(uint eid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, uint, int>)0x0058FDA0)(ref this, eid);

    /// <summary>
    /// <code>Offset: 0x0058FDC0
    /// int __thiscall CACQualities::RemoveEnchantments(_DWORD*,int)</code>
    /// </summary>
    public int RemoveEnchantments(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, int, int>)0x0058FDC0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x0058FDE0
    /// int __thiscall CACQualities::UpdateEnchantment(CACQualities*,const Enchantment*)</code>
    /// </summary>
    public int UpdateEnchantment(ACBindings.Internal.Enchantment* to_update) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, ACBindings.Internal.Enchantment*, int>)0x0058FDE0)(ref this, to_update);

    /// <summary>
    /// <code>Offset: 0x0058FE20
    /// void __thiscall CACQualities::UpdateEnchantments(CEnchantmentRegistry**,int)</code>
    /// </summary>
    public void UpdateEnchantments(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, int, void>)0x0058FE20)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x0058FE60
    /// int __thiscall CACQualities::InqVitae(CACQualities*,Enchantment*)</code>
    /// </summary>
    public int InqVitae(ACBindings.Internal.Enchantment* vitae) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, ACBindings.Internal.Enchantment*, int>)0x0058FE60)(ref this, vitae);

    /// <summary>
    /// <code>Offset: 0x0058FE80
    /// float __thiscall CACQualities::GetVitaeValue(CACQualities*)</code>
    /// </summary>
    public float GetVitaeValue() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, float>)0x0058FE80)(ref this);

    /// <summary>
    /// <code>Offset: 0x0058FEA0
    /// int __thiscall CACQualities::EnchantAttribute(CACQualities*,unsigned int,unsigned int*)</code>
    /// </summary>
    public int EnchantAttribute(uint stype, uint* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, uint, uint*, int>)0x0058FEA0)(ref this, stype, val);

    /// <summary>
    /// <code>Offset: 0x0058FEC0
    /// int __thiscall CACQualities::EnchantAttribute2nd(CACQualities*,unsigned int,unsigned int*)</code>
    /// </summary>
    public int EnchantAttribute2nd(uint stype, uint* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, uint, uint*, int>)0x0058FEC0)(ref this, stype, val);

    /// <summary>
    /// <code>Offset: 0x0058FEE0
    /// int __thiscall CACQualities::EnchantSkill(CACQualities*,unsigned int,int*)</code>
    /// </summary>
    public int EnchantSkill(uint stype, int* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, uint, int*, int>)0x0058FEE0)(ref this, stype, val);

    /// <summary>
    /// <code>Offset: 0x0058FF00
    /// int __thiscall CACQualities::EnchantInt(CACQualities*,unsigned int,int*,int)</code>
    /// </summary>
    public int EnchantInt(uint stype, int* val, int allow_negative) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, uint, int*, int, int>)0x0058FF00)(ref this, stype, val, allow_negative);

    /// <summary>
    /// <code>Offset: 0x0058FF20
    /// int __thiscall CACQualities::EnchantFloat(CACQualities*,unsigned int,long double*)</code>
    /// </summary>
    public int EnchantFloat(uint stype, double* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, uint, double*, int>)0x0058FF20)(ref this, stype, val);

    /// <summary>
    /// <code>Offset: 0x0058FF40
    /// int __thiscall CACQualities::GetFloatEnchantmentDetails(CACQualities*,unsigned int,EnchantedQualityDetails*)</code>
    /// </summary>
    public int GetFloatEnchantmentDetails(uint stype, ACBindings.Internal.EnchantedQualityDetails* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, uint, ACBindings.Internal.EnchantedQualityDetails*, int>)0x0058FF40)(ref this, stype, val);

    /// <summary>
    /// <code>Offset: 0x0058FF60
    /// int __thiscall CACQualities::InqLoad(CACQualities*,float*)</code>
    /// </summary>
    public int InqLoad(float* load) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, float*, int>)0x0058FF60)(ref this, load);

    /// <summary>
    /// <code>Offset: 0x00590050
    /// int __thiscall CACQualities::AddSpell(CACQualities*,const unsigned int)</code>
    /// </summary>
    public int AddSpell(uint newSpell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, uint, int>)0x00590050)(ref this, newSpell);

    /// <summary>
    /// <code>Offset: 0x005900B0
    /// int __thiscall CACQualities::RemoveSpell(CACQualities*,const unsigned int)</code>
    /// </summary>
    public int RemoveSpell(uint spell) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, uint, int>)0x005900B0)(ref this, spell);

    /// <summary>
    /// <code>Offset: 0x00590680
    /// int __thiscall CACQualities::InqPluralNameString(_DWORD*,int*)</code>
    /// </summary>
    public int InqPluralNameString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, int*, int>)0x00590680)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x005926D0
    /// int __thiscall CACQualities::InqAttribute(CACQualities*,unsigned int,Attribute*)</code>
    /// </summary>
    public int InqAttribute(uint stype, ACBindings.Internal.Attribute* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, uint, ACBindings.Internal.Attribute*, int>)0x005926D0)(ref this, stype, retval);

    /// <summary>
    /// <code>Offset: 0x00592700
    /// int __thiscall CACQualities::InqAttribute(CACQualities*,unsigned int,unsigned int*,int)</code>
    /// </summary>
    public int InqAttribute(uint stype, uint* retval, int raw) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, uint, uint*, int, int>)0x00592700)(ref this, stype, retval, raw);

    /// <summary>
    /// <code>Offset: 0x00592750
    /// int __thiscall CACQualities::SetAttribute(CACQualities*,unsigned int,const Attribute*)</code>
    /// </summary>
    public int SetAttribute(uint stype, ACBindings.Internal.Attribute* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, uint, ACBindings.Internal.Attribute*, int>)0x00592750)(ref this, stype, val);

    /// <summary>
    /// <code>Offset: 0x005927A0
    /// int __thiscall CACQualities::SetAttribute(CACQualities*,unsigned int,unsigned int)</code>
    /// </summary>
    public int SetAttribute(uint stype, uint init_val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, uint, uint, int>)0x005927A0)(ref this, stype, init_val);

    /// <summary>
    /// <code>Offset: 0x005927F0
    /// int __thiscall CACQualities::InqAttribute2nd(CACQualities*,unsigned int,SecondaryAttribute*)</code>
    /// </summary>
    public int InqAttribute2nd(uint stype, ACBindings.Internal.SecondaryAttribute* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, uint, ACBindings.Internal.SecondaryAttribute*, int>)0x005927F0)(ref this, stype, retval);

    /// <summary>
    /// <code>Offset: 0x00592820
    /// int __thiscall CACQualities::InqMaxRunRate(CACQualities*,float*)</code>
    /// </summary>
    public int InqMaxRunRate(float* rate) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, float*, int>)0x00592820)(ref this, rate);

    /// <summary>
    /// <code>Offset: 0x00592850
    /// int __thiscall CACQualities::CanJump(CACQualities*,float)</code>
    /// </summary>
    public int CanJump(float extent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, float, int>)0x00592850)(ref this, extent);

    /// <summary>
    /// <code>Offset: 0x00592890
    /// int __thiscall CACQualities::JumpStaminaCost(CACQualities*,float,int*)</code>
    /// </summary>
    public int JumpStaminaCost(float extent, int* cost) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, float, int*, int>)0x00592890)(ref this, extent, cost);

    /// <summary>
    /// <code>Offset: 0x00592A20
    /// int __thiscall CACQualities::InqAttribute2ndBaseLevel(CACQualities*,unsigned int,unsigned int*,int)</code>
    /// </summary>
    public int InqAttribute2ndBaseLevel(uint stype, uint* retval, int raw) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, uint, uint*, int, int>)0x00592A20)(ref this, stype, retval, raw);

    /// <summary>
    /// <code>Offset: 0x00592AF0
    /// int __thiscall CACQualities::InqSkill(CACQualities*,unsigned int,Skill*)</code>
    /// </summary>
    public int InqSkill(uint stype, ACBindings.Internal.Skill* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, uint, ACBindings.Internal.Skill*, int>)0x00592AF0)(ref this, stype, retval);

    /// <summary>
    /// <code>Offset: 0x00592B40
    /// int __thiscall CACQualities::InqSkillLevel(CACQualities*,unsigned int,int*)</code>
    /// </summary>
    public int InqSkillLevel(uint stype, int* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, uint, int*, int>)0x00592B40)(ref this, stype, retval);

    /// <summary>
    /// <code>Offset: 0x00592B70
    /// int __thiscall CACQualities::InqSkillAdvancementClass(CACQualities*,unsigned int,SKILL_ADVANCEMENT_CLASS*)</code>
    /// </summary>
    public int InqSkillAdvancementClass(uint stype, ACBindings.Internal.SKILL_ADVANCEMENT_CLASS* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, uint, ACBindings.Internal.SKILL_ADVANCEMENT_CLASS*, int>)0x00592B70)(ref this, stype, retval);

    /// <summary>
    /// <code>Offset: 0x00592D20
    /// int __thiscall CACQualities::InqAttribute2nd(CACQualities*,unsigned int,unsigned int*,int)</code>
    /// </summary>
    public int InqAttribute2nd(uint stype, uint* retval, int raw) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, uint, uint*, int, int>)0x00592D20)(ref this, stype, retval, raw);

    /// <summary>
    /// <code>Offset: 0x00592E00
    /// int __thiscall CACQualities::BoundsCheck(CACQualities*,unsigned int,int*,unsigned int*)</code>
    /// </summary>
    public int BoundsCheck(uint stype, int* val, uint* max) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, uint, int*, uint*, int>)0x00592E00)(ref this, stype, val, max);

    /// <summary>
    /// <code>Offset: 0x00592E60
    /// int __thiscall CACQualities::InqSkillBaseLevel(CACQualities*,unsigned int,int*,int)</code>
    /// </summary>
    public int InqSkillBaseLevel(uint stype, int* retval, int raw) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, uint, int*, int, int>)0x00592E60)(ref this, stype, retval, raw);

    /// <summary>
    /// <code>Offset: 0x00592F60
    /// int __thiscall CACQualities::SetSkill(CACQualities*,unsigned int,const Skill*)</code>
    /// </summary>
    public int SetSkill(uint stype, ACBindings.Internal.Skill* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, uint, ACBindings.Internal.Skill*, int>)0x00592F60)(ref this, stype, val);

    /// <summary>
    /// <code>Offset: 0x00593060
    /// int __thiscall CACQualities::SetSkillLevel(CACQualities*,unsigned int,unsigned int)</code>
    /// </summary>
    public int SetSkillLevel(uint stype, uint val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, uint, uint, int>)0x00593060)(ref this, stype, val);

    /// <summary>
    /// <code>Offset: 0x00593150
    /// int __thiscall CACQualities::SetSkillAdvancementClass(CACQualities*,unsigned int,SKILL_ADVANCEMENT_CLASS)</code>
    /// </summary>
    public int SetSkillAdvancementClass(uint stype, ACBindings.Internal.SKILL_ADVANCEMENT_CLASS val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, uint, ACBindings.Internal.SKILL_ADVANCEMENT_CLASS, int>)0x00593150)(ref this, stype, val);

    /// <summary>
    /// <code>Offset: 0x00593250
    /// int __thiscall CACQualities::SetAttribute2nd(CACQualities*,unsigned int,const SecondaryAttribute*)</code>
    /// </summary>
    public int SetAttribute2nd(uint stype, ACBindings.Internal.SecondaryAttribute* val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, uint, ACBindings.Internal.SecondaryAttribute*, int>)0x00593250)(ref this, stype, val);

    /// <summary>
    /// <code>Offset: 0x00593310
    /// int __thiscall CACQualities::SetAttribute2nd(CACQualities*,unsigned int,unsigned int,unsigned int*,unsigned int*)</code>
    /// </summary>
    public int SetAttribute2nd(uint stype, uint val, uint* bounded_val, uint* max) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, uint, uint, uint*, uint*, int>)0x00593310)(ref this, stype, val, bounded_val, max);

    /// <summary>
    /// <code>Offset: 0x00593380
    /// int __thiscall CACQualities::InqSkill(CACQualities*,unsigned int,int*,int)</code>
    /// </summary>
    public int InqSkill(uint stype, int* retval, int raw) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, uint, int*, int, int>)0x00593380)(ref this, stype, retval, raw);

    /// <summary>
    /// <code>Offset: 0x00593570
    /// int __thiscall CACQualities::InqRunRate(CACQualities*,float*)</code>
    /// </summary>
    public int InqRunRate(float* rate) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, float*, int>)0x00593570)(ref this, rate);

    /// <summary>
    /// <code>Offset: 0x00593740
    /// int __thiscall CACQualities::InqJumpVelocity(CACQualities*,float,float*)</code>
    /// </summary>
    public int InqJumpVelocity(float extent, float* v_z) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, float, float*, int>)0x00593740)(ref this, extent, v_z);

    /// <summary>
    /// <code>Offset: 0x00593AF0
    /// int __thiscall CACQualities::SetAttribute2nd(CACQualities*,unsigned int,unsigned int)</code>
    /// </summary>
    public int SetAttribute2nd(uint stype, uint val) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, uint, uint, int>)0x00593AF0)(ref this, stype, val);

    /// <summary>
    /// <code>Offset: 0x00593B10
    /// void __thiscall CACQualities::Clear(CACQualities*)</code>
    /// </summary>
    public void Clear() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, void>)0x00593B10)(ref this);

    /// <summary>
    /// <code>Offset: 0x00593C00
    /// int __thiscall CACQualities::InqWeenieTypeString(CACQualities*,char*,const unsigned int)</code>
    /// </summary>
    public int InqWeenieTypeString(sbyte* buff, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, sbyte*, uint, int>)0x00593C00)(ref this, buff, size);

    /// <summary>
    /// <code>Offset: 0x00593C20
    /// void __thiscall CACQualities::SetPackHeader(CACQualities*,unsigned int*)</code>
    /// </summary>
    public void SetPackHeader(uint* bitfield) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, uint*, void>)0x00593C20)(ref this, bitfield);

    /// <summary>
    /// <code>Offset: 0x00593CC0
    /// unsigned int __thiscall CACQualities::GetPackSize(CACQualities*)</code>
    /// </summary>
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, uint>)0x00593CC0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00593E70
    /// int __thiscall CACQualities::CACQualities(int,void**)</code>
    /// </summary>
    public int _ConstructorInternal(void** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, void**, int>)0x00593E70)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x00593EF0
    /// unsigned int __thiscall CACQualities::GetDBOType(CACQualities*)</code>
    /// </summary>
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, uint>)0x00593EF0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00593FF0
    /// DBObj* __cdecl CACQualities::Allocator()</code>
    /// </summary>
    public static ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>)0x00593FF0)();

    /// <summary>
    /// <code>Offset: 0x00594020
    /// unsigned int __thiscall CACQualities::Pack(CACQualities*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, void**, uint, uint>)0x00594020)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005941C0
    /// unsigned int __thiscall CACQualities::Pack2(char*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack2(void** a2, uint a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, void**, uint, uint>)0x005941C0)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x005941D0
    /// int __thiscall CACQualities::UnPack(CACQualities*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, void**, uint, int>)0x005941D0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x00594760
    /// int __thiscall CACQualities::UnPack2(char*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack2(void** a2, uint a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CACQualities, void**, uint, int>)0x00594760)(ref this, a2, a3);
}

