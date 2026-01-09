namespace ACBindings;

// ClientMagicSystem
public unsafe struct ClientMagicSystem : System.IDisposable
{
    // Base Classes
    public ACBindings.ClientSystem BaseClass_ClientSystem; // ACBindings.ClientSystem

    // Statics
    public static uint* targetingSpell = (uint*)0x0086EDA8;

    // Child Types
    // ClientMagicSystem_vtbl
    public unsafe struct ClientMagicSystem_vtbl
    {
        // Members
        public System.IntPtr IUnknown_QueryInterface; // function pointer
        public System.IntPtr IUnknown_AddRef; // function pointer
        public System.IntPtr IUnknown_Release; // function pointer
        public System.IntPtr QueryInterface; // function pointer
        public System.IntPtr AddRef; // function pointer
        public System.IntPtr Release; // function pointer
        public System.IntPtr OnStartup; // function pointer
        public System.IntPtr UseTime; // function pointer
        public System.IntPtr OnBeginCharacterSession; // function pointer
        public System.IntPtr OnEndCharacterSession; // function pointer
        public System.IntPtr OnShutdown; // function pointer
        public System.IntPtr You_Must_Not_Have_Multiple_Implementations_Of_AddRef_In_A_Hierarchy; // function pointer

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
    public ACBindings.Turbine_RefCount m_cTurbineRefCount;
    public ACBindings.CSpellTable* spellTable;
    public ACBindings.SpellComponentTable* spellComponentTable;
    public uint selectedSpell;
    public ACBindings.HashTable__uint__Graphic_ptr m_hashSpellIconTable;
    public ACBindings.HashTable__IDClass___tagDataID__Graphic_ptr m_hashSpellComponentIconTable;

    // Generated Constructor
    public ClientMagicSystem() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // unsigned int __thiscall ClientMagicSystem::AddRef(ClientTradeSystem*)
    public uint AddRef() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientMagicSystem, uint>)0x00509440)(ref this);
    // ClientMagicSystem* __cdecl ClientMagicSystem::GetMagicSystem()
    public static ACBindings.ClientMagicSystem* GetMagicSystem() => ((delegate* unmanaged[Cdecl]<ACBindings.ClientMagicSystem*>)0x00567C00)();
    // SpellComponentTable* __thiscall ClientMagicSystem::GetSpellComponentTable(ClientMagicSystem*)
    public ACBindings.SpellComponentTable* GetSpellComponentTable() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientMagicSystem, ACBindings.SpellComponentTable*>)0x00567C10)(ref this);
    // void __thiscall ClientMagicSystem::OnShutdown(ClientMagicSystem*)
    public void OnShutdown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientMagicSystem, void>)0x00567C40)(ref this);
    // void __thiscall ClientMagicSystem::FreeHandsAndCastSpell(ClientMagicSystem*,unsigned int,unsigned int)
    public void FreeHandsAndCastSpell(uint spellID, uint targetID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientMagicSystem, uint, uint, void>)0x00567C90)(ref this, spellID, targetID);
    // void __thiscall ClientMagicSystem::OnEndCharacterSession(ClientMagicSystem*)
    public void OnEndCharacterSession() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientMagicSystem, void>)0x00567CF0)(ref this);
    // TResult* __thiscall ClientMagicSystem::QueryInterface(ClientMagicSystem*,TResult*,const Turbine_GUID*,void**)
    public ACBindings.TResult* QueryInterface(ACBindings.TResult* result, ACBindings.Turbine_GUID* i_rcInterface, void** o_ppvInterface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientMagicSystem, ACBindings.TResult*, ACBindings.Turbine_GUID*, void**, ACBindings.TResult*>)0x00567D00)(ref this, result, i_rcInterface, o_ppvInterface);
    // bool __thiscall ClientMagicSystem::InqSpellBase(ClientMagicSystem*,unsigned int,CSpellBase*)
    public byte InqSpellBase(uint spellID, ACBindings.CSpellBase* spellBase) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientMagicSystem, uint, ACBindings.CSpellBase*, byte>)0x00567EB0)(ref this, spellID, spellBase);
    // int* __thiscall ClientMagicSystem::GetSpellName(CSpellTable**,int*,unsigned int)
    public int* GetSpellName(int* a2, uint key) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientMagicSystem, int*, uint, int*>)0x00567EF0)(ref this, a2, key);
    // int* __thiscall ClientMagicSystem::GetSpellDescription(CSpellTable**,int*,unsigned int)
    public int* GetSpellDescription(int* a2, uint key) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientMagicSystem, int*, uint, int*>)0x00567F60)(ref this, a2, key);
    // bool __cdecl ClientMagicSystem::ObjectCompatibleWithSpellTargetType(unsigned int,unsigned int,bool)
    public static byte ObjectCompatibleWithSpellTargetType(uint targetID, uint targetType, byte quiet) => ((delegate* unmanaged[Cdecl]<uint, uint, byte, byte>)0x00567FD0)(targetID, targetType, quiet);
    // void __thiscall ClientMagicSystem::CompositeSpellIcon(ClientMagicSystem*,unsigned int,Graphic*)
    public void CompositeSpellIcon(uint spellID, ACBindings.Graphic* icon) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientMagicSystem, uint, ACBindings.Graphic*, void>)0x005682F0)(ref this, spellID, icon);
    // char __stdcall ClientMagicSystem::CompositeSpellComponentIcon(int,int)
    public static sbyte CompositeSpellComponentIcon(int a1, int a2) => ((delegate* unmanaged[Stdcall]<int, int, sbyte>)0x005684C0)(a1, a2);
    // unsigned int __thiscall ClientMagicSystem::Handle_Magic__UpdateSpell(ClientMagicSystem*,unsigned int)
    public uint Handle_Magic__UpdateSpell(uint spell_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientMagicSystem, uint, uint>)0x00568590)(ref this, spell_id);
    // unsigned int __thiscall ClientMagicSystem::Handle_Magic__RemoveSpell(ClientMagicSystem*,unsigned int)
    public uint Handle_Magic__RemoveSpell(uint spell_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientMagicSystem, uint, uint>)0x00568630)(ref this, spell_id);
    // unsigned int __thiscall ClientMagicSystem::Handle_Magic__UpdateEnchantment(ClientMagicSystem*,const Enchantment*)
    public uint Handle_Magic__UpdateEnchantment(ACBindings.Enchantment* enchant) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientMagicSystem, ACBindings.Enchantment*, uint>)0x005686D0)(ref this, enchant);
    // int __stdcall ClientMagicSystem::Handle_Magic__UpdateMultipleEnchantments(int)
    public static int Handle_Magic__UpdateMultipleEnchantments(int a1) => ((delegate* unmanaged[Stdcall]<int, int>)0x00568780)(a1);
    // unsigned int __thiscall ClientMagicSystem::Handle_Magic__PurgeEnchantments(ClientMagicSystem*)
    public uint Handle_Magic__PurgeEnchantments() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientMagicSystem, uint>)0x00568810)(ref this);
    // unsigned int __thiscall ClientMagicSystem::Handle_Magic__PurgeBadEnchantments(ClientMagicSystem*)
    public uint Handle_Magic__PurgeBadEnchantments() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientMagicSystem, uint>)0x005688A0)(ref this);
    // bool __thiscall ClientMagicSystem::AreSpellComponentsRequired(ClientMagicSystem*)
    public byte AreSpellComponentsRequired() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientMagicSystem, byte>)0x00568930)(ref this);
    // bool __cdecl ClientMagicSystem::ObjectCompatibleWithSpell(unsigned int,unsigned int,bool,bool)
    public static byte ObjectCompatibleWithSpell(uint targetID, uint spellID, byte quiet, byte displayCastMessage) => ((delegate* unmanaged[Cdecl]<uint, uint, byte, byte, byte>)0x005689D0)(targetID, spellID, quiet, displayCastMessage);
    // SpellFormula* __cdecl ClientMagicSystem::GetAppropriateSpellFormula(SpellFormula*,const CSpellBase*)
    public static ACBindings.SpellFormula* GetAppropriateSpellFormula(ACBindings.SpellFormula* result, ACBindings.CSpellBase* sBase) => ((delegate* unmanaged[Cdecl]<ACBindings.SpellFormula*, ACBindings.CSpellBase*, ACBindings.SpellFormula*>)0x00568AF0)(result, sBase);
    // void __cdecl ClientMagicSystem::CastSpell(unsigned int,bool)
    public static void CastSpell(uint spellID, byte targetIsSelected) => ((delegate* unmanaged[Cdecl]<uint, byte, void>)0x00568DE0)(spellID, targetIsSelected);
    // bool __thiscall ClientMagicSystem::NotifyOfEnchantmentRemoval(ClientMagicSystem*,unsigned int)
    public byte NotifyOfEnchantmentRemoval(uint eid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientMagicSystem, uint, byte>)0x00569460)(ref this, eid);
    // unsigned int __thiscall ClientMagicSystem::Handle_Magic__RemoveEnchantment(ClientMagicSystem*,unsigned int,bool)
    public uint Handle_Magic__RemoveEnchantment(uint eid, byte fNotify) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientMagicSystem, uint, byte, uint>)0x005696F0)(ref this, eid, fNotify);
    // int __thiscall ClientMagicSystem::Handle_Magic__RemoveMultipleEnchantments(ClientMagicSystem*,int,char)
    public int Handle_Magic__RemoveMultipleEnchantments(int a2, sbyte a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientMagicSystem, int, sbyte, int>)0x005697D0)(ref this, a2, a3);
    // unsigned int __thiscall ClientMagicSystem::Handle_Magic__DispelEnchantment(ClientMagicSystem*,unsigned int)
    public uint Handle_Magic__DispelEnchantment(uint eid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientMagicSystem, uint, uint>)0x005698B0)(ref this, eid);
    // int __thiscall ClientMagicSystem::Handle_Magic__DispelMultipleEnchantments(ClientMagicSystem*,int)
    public int Handle_Magic__DispelMultipleEnchantments(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientMagicSystem, int, int>)0x005698C0)(ref this, a2);
    // Graphic* __thiscall ClientMagicSystem::GetSpellIcon(ClientMagicSystem*,unsigned int)
    public ACBindings.Graphic* GetSpellIcon(uint spellID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientMagicSystem, uint, ACBindings.Graphic*>)0x00569990)(ref this, spellID);
    // int __thiscall ClientMagicSystem::GetSpellComponentIcon(_DWORD*,unsigned int)
    public int GetSpellComponentIcon(uint a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientMagicSystem, uint, int>)0x00569A50)(ref this, a2);
    // void __thiscall ClientMagicSystem::ClientMagicSystem(ClientMagicSystem*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientMagicSystem, void>)0x00569BD0)(ref this);
    // void __thiscall ClientMagicSystem::~ClientMagicSystem(ClientMagicSystem*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientMagicSystem, void>)0x00569C40)(ref this);
    // unsigned int __thiscall ClientMagicSystem::Release(ClientMagicSystem*)
    public uint Release() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClientMagicSystem, uint>)0x00569DD0)(ref this);
}

