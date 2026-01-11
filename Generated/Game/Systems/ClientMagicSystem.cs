namespace ACBindings.Internal;

public unsafe struct ClientMagicSystem : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.ClientSystem BaseClass_ClientSystem; // ACBindings.Internal.ClientSystem

    // Statics
    public static ACBindings.Internal.ClientMagicSystem* s_pMagicSystem = (ACBindings.Internal.ClientMagicSystem*)0x0087144C;
    public static uint* targetingSpell = (uint*)0x00871450;

    // Child Types
    public unsafe struct ClientMagicSystem_vtbl
    {
        // Members
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, ACBindings.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*> QueryInterface; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> AddRef; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> Release; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientSystem*, void> OnStartup; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientSystem*, void> UseTime; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientSystem*, void> OnBeginCharacterSession; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientSystem*, void> OnEndCharacterSession; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientSystem*, void> OnShutdown; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientMagicSystem*, ACBindings.Internal.ClientMagicSystem.Enum13> You_Must_Not_Have_Multiple_Implementations_Of_AddRef_In_A_Hierarchy; // function pointer

        // Methods
    }
    // ClientMagicSystem::Enum12
    public enum Enum12 : uint
    {
    }
    // ClientMagicSystem::Enum13
    public enum Enum13 : uint
    {
    }
    // ClientMagicSystem::Enum14
    public enum Enum14 : uint
    {
    }
    // ClientMagicSystem::Enum15
    public enum Enum15 : uint
    {
    }
    // ClientMagicSystem::Enum4
    public enum Enum4 : uint
    {
    }
    // ClientMagicSystem::Enum7
    public enum Enum7 : uint
    {
    }

    // Members
    public ACBindings.Internal.Turbine_RefCount m_cTurbineRefCount;
    public ACBindings.Internal.CSpellTable* spellTable;
    public ACBindings.Internal.SpellComponentTable* spellComponentTable;
    public uint selectedSpell;
    public ACBindings.Internal.HashTable__uint___Graphic_ptr m_hashSpellIconTable;
    public ACBindings.Internal.HashTable___IDClass____tagDataID___Graphic_ptr m_hashSpellComponentIconTable;

    // Generated Constructor
    public ClientMagicSystem() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00509440
    /// unsigned int __thiscall ClientMagicSystem::AddRef(ClientTradeSystem*)</code>
    /// </summary>
    public uint AddRef() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientMagicSystem, uint>)0x00509440)(ref this);

    /// <summary>
    /// <code>Offset: 0x00567C00
    /// ClientMagicSystem* __cdecl ClientMagicSystem::GetMagicSystem()</code>
    /// </summary>
    public static ACBindings.Internal.ClientMagicSystem* GetMagicSystem() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.ClientMagicSystem*>)0x00567C00)();

    /// <summary>
    /// <code>Offset: 0x00567C10
    /// SpellComponentTable* __thiscall ClientMagicSystem::GetSpellComponentTable(ClientMagicSystem*)</code>
    /// </summary>
    public ACBindings.Internal.SpellComponentTable* GetSpellComponentTable() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientMagicSystem, ACBindings.Internal.SpellComponentTable*>)0x00567C10)(ref this);

    /// <summary>
    /// <code>Offset: 0x00567C40
    /// void __thiscall ClientMagicSystem::OnShutdown(ClientMagicSystem*)</code>
    /// </summary>
    public void OnShutdown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientMagicSystem, void>)0x00567C40)(ref this);

    /// <summary>
    /// <code>Offset: 0x00567C90
    /// void __thiscall ClientMagicSystem::FreeHandsAndCastSpell(ClientMagicSystem*,unsigned int,unsigned int)</code>
    /// </summary>
    public void FreeHandsAndCastSpell(uint spellID, uint targetID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientMagicSystem, uint, uint, void>)0x00567C90)(ref this, spellID, targetID);

    /// <summary>
    /// <code>Offset: 0x00567CF0
    /// void __thiscall ClientMagicSystem::OnEndCharacterSession(ClientMagicSystem*)</code>
    /// </summary>
    public void OnEndCharacterSession() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientMagicSystem, void>)0x00567CF0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00567D00
    /// TResult* __thiscall ClientMagicSystem::QueryInterface(ClientMagicSystem*,TResult*,const Turbine_GUID*,void**)</code>
    /// </summary>
    public ACBindings.Internal.TResult* QueryInterface(ACBindings.Internal.TResult* result, ACBindings.Internal.Turbine_GUID* i_rcInterface, void** o_ppvInterface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientMagicSystem, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*>)0x00567D00)(ref this, result, i_rcInterface, o_ppvInterface);

    /// <summary>
    /// <code>Offset: 0x00567EB0
    /// bool __thiscall ClientMagicSystem::InqSpellBase(ClientMagicSystem*,unsigned int,CSpellBase*)</code>
    /// </summary>
    public byte InqSpellBase(uint spellID, ACBindings.Internal.CSpellBase* spellBase) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientMagicSystem, uint, ACBindings.Internal.CSpellBase*, byte>)0x00567EB0)(ref this, spellID, spellBase);

    /// <summary>
    /// <code>Offset: 0x00567EF0
    /// int* __thiscall ClientMagicSystem::GetSpellName(CSpellTable**,int*,unsigned int)</code>
    /// </summary>
    public int* GetSpellName(int* a2, uint key) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientMagicSystem, int*, uint, int*>)0x00567EF0)(ref this, a2, key);

    /// <summary>
    /// <code>Offset: 0x00567F60
    /// int* __thiscall ClientMagicSystem::GetSpellDescription(CSpellTable**,int*,unsigned int)</code>
    /// </summary>
    public int* GetSpellDescription(int* a2, uint key) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientMagicSystem, int*, uint, int*>)0x00567F60)(ref this, a2, key);

    /// <summary>
    /// <code>Offset: 0x00567FD0
    /// bool __cdecl ClientMagicSystem::ObjectCompatibleWithSpellTargetType(unsigned int,unsigned int,bool)</code>
    /// </summary>
    public static byte ObjectCompatibleWithSpellTargetType(uint targetID, uint targetType, byte quiet) => ((delegate* unmanaged[Cdecl]<uint, uint, byte, byte>)0x00567FD0)(targetID, targetType, quiet);

    /// <summary>
    /// <code>Offset: 0x005682F0
    /// void __thiscall ClientMagicSystem::CompositeSpellIcon(ClientMagicSystem*,unsigned int,Graphic*)</code>
    /// </summary>
    public void CompositeSpellIcon(uint spellID, ACBindings.Internal.Graphic* icon) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientMagicSystem, uint, ACBindings.Internal.Graphic*, void>)0x005682F0)(ref this, spellID, icon);

    /// <summary>
    /// <code>Offset: 0x005684C0
    /// char __stdcall ClientMagicSystem::CompositeSpellComponentIcon(int,int)</code>
    /// </summary>
    public static sbyte CompositeSpellComponentIcon(int a1, int a2) => ((delegate* unmanaged[Stdcall]<int, int, sbyte>)0x005684C0)(a1, a2);

    /// <summary>
    /// <code>Offset: 0x00568590
    /// unsigned int __thiscall ClientMagicSystem::Handle_Magic__UpdateSpell(ClientMagicSystem*,unsigned int)</code>
    /// </summary>
    public uint Handle_Magic__UpdateSpell(uint spell_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientMagicSystem, uint, uint>)0x00568590)(ref this, spell_id);

    /// <summary>
    /// <code>Offset: 0x00568630
    /// unsigned int __thiscall ClientMagicSystem::Handle_Magic__RemoveSpell(ClientMagicSystem*,unsigned int)</code>
    /// </summary>
    public uint Handle_Magic__RemoveSpell(uint spell_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientMagicSystem, uint, uint>)0x00568630)(ref this, spell_id);

    /// <summary>
    /// <code>Offset: 0x005686D0
    /// unsigned int __thiscall ClientMagicSystem::Handle_Magic__UpdateEnchantment(ClientMagicSystem*,const Enchantment*)</code>
    /// </summary>
    public uint Handle_Magic__UpdateEnchantment(ACBindings.Internal.Enchantment* enchant) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientMagicSystem, ACBindings.Internal.Enchantment*, uint>)0x005686D0)(ref this, enchant);

    /// <summary>
    /// <code>Offset: 0x00568780
    /// int __stdcall ClientMagicSystem::Handle_Magic__UpdateMultipleEnchantments(int)</code>
    /// </summary>
    public static int Handle_Magic__UpdateMultipleEnchantments(int a1) => ((delegate* unmanaged[Stdcall]<int, int>)0x00568780)(a1);

    /// <summary>
    /// <code>Offset: 0x00568810
    /// unsigned int __thiscall ClientMagicSystem::Handle_Magic__PurgeEnchantments(ClientMagicSystem*)</code>
    /// </summary>
    public uint Handle_Magic__PurgeEnchantments() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientMagicSystem, uint>)0x00568810)(ref this);

    /// <summary>
    /// <code>Offset: 0x005688A0
    /// unsigned int __thiscall ClientMagicSystem::Handle_Magic__PurgeBadEnchantments(ClientMagicSystem*)</code>
    /// </summary>
    public uint Handle_Magic__PurgeBadEnchantments() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientMagicSystem, uint>)0x005688A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00568930
    /// bool __thiscall ClientMagicSystem::AreSpellComponentsRequired(ClientMagicSystem*)</code>
    /// </summary>
    public byte AreSpellComponentsRequired() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientMagicSystem, byte>)0x00568930)(ref this);

    /// <summary>
    /// <code>Offset: 0x005689D0
    /// bool __cdecl ClientMagicSystem::ObjectCompatibleWithSpell(unsigned int,unsigned int,bool,bool)</code>
    /// </summary>
    public static byte ObjectCompatibleWithSpell(uint targetID, uint spellID, byte quiet, byte displayCastMessage) => ((delegate* unmanaged[Cdecl]<uint, uint, byte, byte, byte>)0x005689D0)(targetID, spellID, quiet, displayCastMessage);

    /// <summary>
    /// <code>Offset: 0x00568AF0
    /// SpellFormula* __cdecl ClientMagicSystem::GetAppropriateSpellFormula(SpellFormula*,const CSpellBase*)</code>
    /// </summary>
    public static ACBindings.Internal.SpellFormula* GetAppropriateSpellFormula(ACBindings.Internal.SpellFormula* result, ACBindings.Internal.CSpellBase* sBase) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.SpellFormula*, ACBindings.Internal.CSpellBase*, ACBindings.Internal.SpellFormula*>)0x00568AF0)(result, sBase);

    /// <summary>
    /// <code>Offset: 0x00568DE0
    /// void __cdecl ClientMagicSystem::CastSpell(unsigned int,bool)</code>
    /// </summary>
    public static void CastSpell(uint spellID, byte targetIsSelected) => ((delegate* unmanaged[Cdecl]<uint, byte, void>)0x00568DE0)(spellID, targetIsSelected);

    /// <summary>
    /// <code>Offset: 0x00569460
    /// bool __thiscall ClientMagicSystem::NotifyOfEnchantmentRemoval(ClientMagicSystem*,unsigned int)</code>
    /// </summary>
    public byte NotifyOfEnchantmentRemoval(uint eid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientMagicSystem, uint, byte>)0x00569460)(ref this, eid);

    /// <summary>
    /// <code>Offset: 0x005696F0
    /// unsigned int __thiscall ClientMagicSystem::Handle_Magic__RemoveEnchantment(ClientMagicSystem*,unsigned int,bool)</code>
    /// </summary>
    public uint Handle_Magic__RemoveEnchantment(uint eid, byte fNotify) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientMagicSystem, uint, byte, uint>)0x005696F0)(ref this, eid, fNotify);

    /// <summary>
    /// <code>Offset: 0x005697D0
    /// int __thiscall ClientMagicSystem::Handle_Magic__RemoveMultipleEnchantments(ClientMagicSystem*,int,char)</code>
    /// </summary>
    public int Handle_Magic__RemoveMultipleEnchantments(int a2, sbyte a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientMagicSystem, int, sbyte, int>)0x005697D0)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x005698B0
    /// unsigned int __thiscall ClientMagicSystem::Handle_Magic__DispelEnchantment(ClientMagicSystem*,unsigned int)</code>
    /// </summary>
    public uint Handle_Magic__DispelEnchantment(uint eid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientMagicSystem, uint, uint>)0x005698B0)(ref this, eid);

    /// <summary>
    /// <code>Offset: 0x005698C0
    /// int __thiscall ClientMagicSystem::Handle_Magic__DispelMultipleEnchantments(ClientMagicSystem*,int)</code>
    /// </summary>
    public int Handle_Magic__DispelMultipleEnchantments(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientMagicSystem, int, int>)0x005698C0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x00569990
    /// Graphic* __thiscall ClientMagicSystem::GetSpellIcon(ClientMagicSystem*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.Graphic* GetSpellIcon(uint spellID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientMagicSystem, uint, ACBindings.Internal.Graphic*>)0x00569990)(ref this, spellID);

    /// <summary>
    /// <code>Offset: 0x00569A50
    /// int __thiscall ClientMagicSystem::GetSpellComponentIcon(_DWORD*,unsigned int)</code>
    /// </summary>
    public int GetSpellComponentIcon(uint a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientMagicSystem, uint, int>)0x00569A50)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x00569BD0
    /// void __thiscall ClientMagicSystem::ClientMagicSystem(ClientMagicSystem*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientMagicSystem, void>)0x00569BD0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00569C40
    /// void __thiscall ClientMagicSystem::~ClientMagicSystem(ClientMagicSystem*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientMagicSystem, void>)0x00569C40)(ref this);

    /// <summary>
    /// <code>Offset: 0x00569DD0
    /// unsigned int __thiscall ClientMagicSystem::Release(ClientMagicSystem*)</code>
    /// </summary>
    public uint Release() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientMagicSystem, uint>)0x00569DD0)(ref this);
}

