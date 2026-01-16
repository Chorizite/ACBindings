namespace ACBindings.Internal;


/// <summary>Handles client‑side magic operations for a player, including spell selection, component checks, target validation, and icon caching. Maintains tables of spell and component data, manages reference counts, and communicates changes via the game’s notification system.</summary>
public unsafe struct ClientMagicSystem : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.ClientSystem BaseClass_ClientSystem; // ACBindings.Internal.ClientSystem

    // Statics
    public static ACBindings.Internal.ClientMagicSystem** s_pMagicSystem = (ACBindings.Internal.ClientMagicSystem**)0x0087144C;
    public static uint* targetingSpell = (uint*)0x00871450;
    public static ACBindings.Internal.RGBAColor* s_NullColor = (ACBindings.Internal.RGBAColor*)0x00871460;

    // Child Types
    public unsafe struct ClientMagicSystem_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, ACBindings.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*> QueryInterface; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientSystem*, void> OnStartup; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientSystem*, void> UseTime; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientSystem*, void> OnBeginCharacterSession; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientSystem*, void> OnEndCharacterSession; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientSystem*, void> OnShutdown; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientMagicSystem*, ACBindings.Internal.ClientMagicSystem.Enum13> You_Must_Not_Have_Multiple_Implementations_Of_AddRef_In_A_Hierarchy; // function pointer

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

    /// <summary>Increments the object's Turbine_RefCount in a thread‑safe manner and returns the new reference count.
    /// <code>Offset: 0x00509440
    /// unsigned int __thiscall ClientMagicSystem::AddRef(ClientTradeSystem*)</code>
    /// </summary>
    /// <param name="this">Pointer to the instance whose Turbine_RefCount is incremented.</param>
    /// <returns>The updated reference count after incrementation.</returns>
    public uint AddRef() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientMagicSystem, uint>)0x00509440)(ref this);

    /// <summary>Retrieves the global instance of the client's magic system.
    /// <code>Offset: 0x00567C00
    /// ClientMagicSystem* __cdecl ClientMagicSystem::GetMagicSystem()</code>
    /// </summary>
    /// <returns>Pointer to the shared ClientMagicSystem instance, or nullptr if it has not been initialized.</returns>
    public static ACBindings.Internal.ClientMagicSystem* GetMagicSystem() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.ClientMagicSystem*>)0x00567C00)();

    /// <summary>Retrieves the client’s spell component table, lazily initializing it if necessary.
    /// <code>Offset: 0x00567C10
    /// SpellComponentTable* __thiscall ClientMagicSystem::GetSpellComponentTable(ClientMagicSystem*)</code>
    /// </summary>
    /// <returns>A pointer to the SpellComponentTable associated with this ClientMagicSystem instance.</returns>
    public ACBindings.Internal.SpellComponentTable* GetSpellComponentTable() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientMagicSystem, ACBindings.Internal.SpellComponentTable*>)0x00567C10)(ref this);

    /// <summary>Releases spell tables and cleans up the global magic system instance during shutdown, resetting associated pointers to null.
    /// <code>Offset: 0x00567C40
    /// void __thiscall ClientMagicSystem::OnShutdown(ClientMagicSystem*)</code>
    /// </summary>
    public void OnShutdown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientMagicSystem, void>)0x00567C40)(ref this);

    /// <summary>Releases the character's hands before casting a spell. If a non‑zero targetID is supplied, casts a targeted spell; otherwise casts an untargeted spell and increments the UI busy counter.
    /// <code>Offset: 0x00567C90
    /// void __thiscall ClientMagicSystem::FreeHandsAndCastSpell(ClientMagicSystem*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="spellID">The identifier of the spell to cast.</param>
    /// <param name="targetID">Identifier of the target entity; zero indicates an untargeted cast.</param>
    public void FreeHandsAndCastSpell(uint spellID, uint targetID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientMagicSystem, uint, uint, void>)0x00567C90)(ref this, spellID, targetID);

    /// <summary>Resets the current selection and targeting spell indices to zero when a character session ends.
    /// <code>Offset: 0x00567CF0
    /// void __thiscall ClientMagicSystem::OnEndCharacterSession(ClientMagicSystem*)</code>
    /// </summary>
    public void OnEndCharacterSession() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientMagicSystem, void>)0x00567CF0)(ref this);

    /// <summary>Retrieves a requested interface from the client magic system based on its GUID, returning success or failure status.
    /// <code>Offset: 0x00567D00
    /// TResult* __thiscall ClientMagicSystem::QueryInterface(ClientMagicSystem*,TResult*,const Turbine_GUID*,void**)</code>
    /// </summary>
    /// <param name="this">The current ClientMagicSystem instance.</param>
    /// <param name="result">Structure to receive the operation result code; set to 0 on success or an error code otherwise.</param>
    /// <param name="i_rcInterface">GUID identifying the desired interface.</param>
    /// <param name="o_ppvInterface">Receives a pointer to the requested interface implementation if available; remains unchanged on failure.</param>
    /// <returns>Pointer to result for chaining; identical to the supplied TResult* argument.</returns>
    public ACBindings.Internal.TResult* QueryInterface(ACBindings.Internal.TResult* result, ACBindings.Internal.Turbine_GUID* i_rcInterface, void** o_ppvInterface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientMagicSystem, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*>)0x00567D00)(ref this, result, i_rcInterface, o_ppvInterface);

    /// <summary>Retrieves base data for a specified spell and stores it in the provided CSpellBase structure.
    /// <code>Offset: 0x00567EB0
    /// bool __thiscall ClientMagicSystem::InqSpellBase(ClientMagicSystem*,unsigned int,CSpellBase*)</code>
    /// </summary>
    /// <param name="spellID">Identifier of the spell whose information is requested.</param>
    /// <param name="spellBase">Pointer to a CSpellBase object that receives the queried data if available.</param>
    /// <returns>True if the spell was found and the information was successfully populated; otherwise, false.</returns>
    public byte InqSpellBase(uint spellID, ACBindings.Internal.CSpellBase* spellBase) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientMagicSystem, uint, ACBindings.Internal.CSpellBase*, byte>)0x00567EB0)(ref this, spellID, spellBase);

    /// <summary>Retrieves the name of a spell identified by <paramref name="key"/> and stores it in the supplied buffer.
    /// <code>Offset: 0x00567EF0
    /// int* __thiscall ClientMagicSystem::GetSpellName(CSpellTable**,int*,unsigned int)</code>
    /// </summary>
    /// <param name="a2">Pointer to a buffer that receives the retrieved spell name.</param>
    /// <param name="key">The unique identifier used to look up the spell.</param>
    /// <returns>A pointer to the buffer containing the spell name.</returns>
    public int* GetSpellName(int* a2, uint key) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientMagicSystem, int*, uint, int*>)0x00567EF0)(ref this, a2, key);

    /// <summary>Retrieves the text description for a spell identified by its key, writing the result into the supplied buffer and returning that buffer.
    /// <code>Offset: 0x00567F60
    /// int* __thiscall ClientMagicSystem::GetSpellDescription(CSpellTable**,int*,unsigned int)</code>
    /// </summary>
    /// <param name="a2">Pointer to a buffer where the spell description will be stored.</param>
    /// <param name="key">Unique identifier of the spell whose description is requested.</param>
    /// <returns>The same pointer passed in as <c>a2</c>, now pointing to a string containing the spell’s description.</returns>
    public int* GetSpellDescription(int* a2, uint key) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientMagicSystem, int*, uint, int*>)0x00567F60)(ref this, a2, key);

    /// <summary>Determines whether the specified target object is valid for the spell’s required target type, optionally displaying user notices when incompatible.
    /// <code>Offset: 0x00567FD0
    /// bool __cdecl ClientMagicSystem::ObjectCompatibleWithSpellTargetType(unsigned int,unsigned int,bool)</code>
    /// </summary>
    /// <param name="targetID">The unique identifier of the potential target object.</param>
    /// <param name="targetType">Bitmask indicating acceptable target types for the spell.</param>
    /// <param name="quiet">If true, suppresses any UI messages about incompatibility.</param>
    /// <returns>True when the target satisfies all compatibility checks; otherwise false.</returns>
    public static byte ObjectCompatibleWithSpellTargetType(uint targetID, uint targetType, byte quiet) => ((delegate* unmanaged[Cdecl]<uint, uint, byte, byte>)0x00567FD0)(targetID, targetType, quiet);

    /// <summary>Composes a complete spell icon into the supplied Graphic by layering base, component, and effect textures based on the specified spell ID.
    /// <code>Offset: 0x005682F0
    /// void __thiscall ClientMagicSystem::CompositeSpellIcon(ClientMagicSystem*,unsigned int,Graphic*)</code>
    /// </summary>
    /// <param name="spellID">Identifier of the spell whose icon should be composed.</param>
    /// <param name="icon">Graphic that will receive the composite icon; its image surface is updated with the layered textures.</param>
    public void CompositeSpellIcon(uint spellID, ACBindings.Internal.Graphic* icon) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientMagicSystem, uint, ACBindings.Internal.Graphic*, void>)0x005682F0)(ref this, spellID, icon);

    /// <summary>Composites a spell component’s icon onto the surface window of the supplied UI element.
    /// <code>Offset: 0x005684C0
    /// char __stdcall ClientMagicSystem::CompositeSpellComponentIcon(int,int)</code>
    /// </summary>
    /// <param name="a1">Identifier for the spell component whose icon should be retrieved and displayed.</param>
    /// <param name="a2">Pointer to an object containing the target surface window (at offset 8) that receives the composite icon.</param>
    /// <returns>Zero or non‑zero status code indicating whether the icon was successfully composited; if the component cannot be found, the surface is filled with a null color.</returns>
    public static sbyte CompositeSpellComponentIcon(int a1, int a2) => ((delegate* unmanaged[Stdcall]<int, int, sbyte>)0x005684C0)(a1, a2);

    /// <summary>Adds a new spell to the current player’s magic list and broadcasts a spell‑added notice to the system.
    /// <code>Offset: 0x00568590
    /// unsigned int __thiscall ClientMagicSystem::Handle_Magic__UpdateSpell(ClientMagicSystem*,unsigned int)</code>
    /// </summary>
    /// <param name="spell_id">The identifier of the spell to add.</param>
    /// <returns>Zero, indicating success (currently unused).</returns>
    public uint Handle_Magic__UpdateSpell(uint spell_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientMagicSystem, uint, uint>)0x00568590)(ref this, spell_id);

    /// <summary>Removes the specified spell from the player's active spell set, updates internal client state and broadcasts a removal notice.
    /// <code>Offset: 0x00568630
    /// unsigned int __thiscall ClientMagicSystem::Handle_Magic__RemoveSpell(ClientMagicSystem*,unsigned int)</code>
    /// </summary>
    /// <param name="spell_id">Identifier of the spell to remove.</param>
    /// <returns>A status code; zero indicates successful removal.</returns>
    public uint Handle_Magic__RemoveSpell(uint spell_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientMagicSystem, uint, uint>)0x00568630)(ref this, spell_id);

    /// <summary>Updates the active enchantment on the current player by forwarding the provided Enchantment to CACQualities, then dispatches a notification when the enchantment changes or its vita is modified.
    /// <code>Offset: 0x005686D0
    /// unsigned int __thiscall ClientMagicSystem::Handle_Magic__UpdateEnchantment(ClientMagicSystem*,const Enchantment*)</code>
    /// </summary>
    /// <param name="this">ClientMagicSystem instance invoking the update.</param>
    /// <param name="enchant">Enchantment data containing spell information to apply.</param>
    /// <returns>Zero on success (the function currently always returns 0).</returns>
    public uint Handle_Magic__UpdateEnchantment(ACBindings.Internal.Enchantment* enchant) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientMagicSystem, ACBindings.Internal.Enchantment*, uint>)0x005686D0)(ref this, enchant);

    /// <summary>Applies an updated enchantment set to the current player and notifies other systems of the change.
    /// <code>Offset: 0x00568780
    /// int __stdcall ClientMagicSystem::Handle_Magic__UpdateMultipleEnchantments(int)</code>
    /// </summary>
    /// <param name="a1">The value used to update the player's enchantments, typically representing a new enchantment count or configuration.</param>
    /// <returns>Zero indicating successful execution; currently unused for error handling.</returns>
    public static int Handle_Magic__UpdateMultipleEnchantments(int a1) => ((delegate* unmanaged[Stdcall]<int, int>)0x00568780)(a1);

    /// <summary>Purges all active enchantments from the current player and sends notifications for changes in enchantments and vitae.
    /// <code>Offset: 0x00568810
    /// unsigned int __thiscall ClientMagicSystem::Handle_Magic__PurgeEnchantments(ClientMagicSystem*)</code>
    /// </summary>
    /// <returns>An unsigned integer status code; currently always zero.</returns>
    public uint Handle_Magic__PurgeEnchantments() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientMagicSystem, uint>)0x00568810)(ref this);

    /// <summary>Purge invalid or negative enchantments from the current player descriptor, then broadcast changes to enchantments and vitae.
    /// <code>Offset: 0x005688A0
    /// unsigned int __thiscall ClientMagicSystem::Handle_Magic__PurgeBadEnchantments(ClientMagicSystem*)</code>
    /// </summary>
    /// <returns>Zero on completion (always returned by this implementation).</returns>
    public uint Handle_Magic__PurgeBadEnchantments() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientMagicSystem, uint>)0x005688A0)(ref this);

    /// <summary>Determines whether spell components are required for the player by querying the player’s quality flags.
    /// <code>Offset: 0x00568930
    /// bool __thiscall ClientMagicSystem::AreSpellComponentsRequired(ClientMagicSystem*)</code>
    /// </summary>
    /// <returns>True if the player's qualities indicate that spell components must be used; otherwise, false.</returns>
    public byte AreSpellComponentsRequired() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientMagicSystem, byte>)0x00568930)(ref this);

    /// <summary>Checks whether the given spell can be applied to the specified target and optionally displays a casting notification.
    /// <code>Offset: 0x005689D0
    /// bool __cdecl ClientMagicSystem::ObjectCompatibleWithSpell(unsigned int,unsigned int,bool,bool)</code>
    /// </summary>
    /// <param name="targetID">Identifier of the object to which the spell is intended.</param>
    /// <param name="spellID">Identifier of the spell being evaluated.</param>
    /// <param name="quiet">If true, suppresses error messages when compatibility fails.</param>
    /// <param name="displayCastMessage">When true and the spell is compatible, a “Casting …” notice is sent to the UI.</param>
    /// <returns>True if the spell is compatible with the target; otherwise false.</returns>
    public static byte ObjectCompatibleWithSpell(uint targetID, uint spellID, byte quiet, byte displayCastMessage) => ((delegate* unmanaged[Cdecl]<uint, uint, byte, byte, byte>)0x005689D0)(targetID, spellID, quiet, displayCastMessage);

    /// <summary>Retrieves the spell formula that should be used for a given spell, taking into account the caster’s current state and whether they own the required magic pack or have a customized version of the spell.
    /// <code>Offset: 0x00568AF0
    /// SpellFormula* __cdecl ClientMagicSystem::GetAppropriateSpellFormula(SpellFormula*,const CSpellBase*)</code>
    /// </summary>
    /// <param name="result">Pointer to a SpellFormula object that will receive the computed formula. The function populates this structure and returns it.</param>
    /// <param name="sBase">Const pointer to the base data for the spell whose formula is being requested.</param>
    /// <returns>Returns the same pointer passed in as <paramref name="result"/>, now filled with the appropriate formula data.</returns>
    public static ACBindings.Internal.SpellFormula* GetAppropriateSpellFormula(ACBindings.Internal.SpellFormula* result, ACBindings.Internal.CSpellBase* sBase) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.SpellFormula*, ACBindings.Internal.CSpellBase*, ACBindings.Internal.SpellFormula*>)0x00568AF0)(result, sBase);

    /// <summary>Casts a spell with the specified ID after verifying component availability and target validity. If required components are missing or an unsuitable target is selected, displays an appropriate notice message instead of casting.
    /// <code>Offset: 0x00568DE0
    /// void __cdecl ClientMagicSystem::CastSpell(unsigned int,bool)</code>
    /// </summary>
    /// <param name="spellID">Identifier of the spell to cast.</param>
    /// <param name="targetIsSelected">Flag indicating whether a target was selected before attempting to cast (unused in this implementation).</param>
    public static void CastSpell(uint spellID, byte targetIsSelected) => ((delegate* unmanaged[Cdecl]<uint, byte, void>)0x00568DE0)(spellID, targetIsSelected);

    /// <summary>Displays a message to the client indicating that an enchantment has expired.
    /// <code>Offset: 0x00569460
    /// bool __thiscall ClientMagicSystem::NotifyOfEnchantmentRemoval(ClientMagicSystem*,unsigned int)</code>
    /// </summary>
    /// <param name="eid">The identifier of the enchantment whose removal should be reported.</param>
    /// <returns>True if the expiration notification was successfully processed; otherwise, false.</returns>
    public byte NotifyOfEnchantmentRemoval(uint eid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientMagicSystem, uint, byte>)0x00569460)(ref this, eid);

    /// <summary>Removes an enchantment identified by <paramref name="eid"/> from the player's active qualities, updates internal state, and triggers system notices about vitae or enchantments changes. Optionally notifies the client magic system when <paramref name="fNotify"/> is true.
    /// <code>Offset: 0x005696F0
    /// unsigned int __thiscall ClientMagicSystem::Handle_Magic__RemoveEnchantment(ClientMagicSystem*,unsigned int,bool)</code>
    /// </summary>
    /// <param name="eid">Identifier of the enchantment to be removed from the player’s active qualities.</param>
    /// <param name="fNotify">If set to true, the function informs the client magic system that an enchantment has been removed after processing.</param>
    /// <returns>Zero on completion; the function currently always returns 0 regardless of the outcome of the removal operation.</returns>
    public uint Handle_Magic__RemoveEnchantment(uint eid, byte fNotify) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientMagicSystem, uint, byte, uint>)0x005696F0)(ref this, eid, fNotify);

    /// <summary>Removes a list of enchantments from the current player’s qualities and updates the game state. Optionally triggers individual removal notifications for each enchantment in the list.
    /// <code>Offset: 0x005697D0
    /// int __thiscall ClientMagicSystem::Handle_Magic__RemoveMultipleEnchantments(ClientMagicSystem*,int,char)</code>
    /// </summary>
    /// <param name="a2">Pointer to an array of enchantment IDs to remove, terminated by 0.</param>
    /// <param name="a3">When non‑zero, a notification is sent for each removed enchantment; otherwise only aggregate notices are dispatched.</param>
    /// <returns>Zero on success.</returns>
    public int Handle_Magic__RemoveMultipleEnchantments(int a2, sbyte a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientMagicSystem, int, sbyte, int>)0x005697D0)(ref this, a2, a3);

    /// <summary>Removes an enchantment identified by its ID by delegating to the internal removal routine with no special options.
    /// <code>Offset: 0x005698B0
    /// unsigned int __thiscall ClientMagicSystem::Handle_Magic__DispelEnchantment(ClientMagicSystem*,unsigned int)</code>
    /// </summary>
    /// <param name="eid">The unique identifier of the enchantment effect to dispel.</param>
    /// <returns>A status code indicating whether the removal succeeded or failed.</returns>
    public uint Handle_Magic__DispelEnchantment(uint eid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientMagicSystem, uint, uint>)0x005698B0)(ref this, eid);

    /// <summary>Dispels multiple enchantments associated with the specified magic identifier by delegating to the underlying removal routine.
    /// <code>Offset: 0x005698C0
    /// int __thiscall ClientMagicSystem::Handle_Magic__DispelMultipleEnchantments(ClientMagicSystem*,int)</code>
    /// </summary>
    /// <param name="a2">Identifier specifying which set of enchantments should be dispelled.</param>
    /// <returns>Status code returned from the internal removal operation, indicating success or failure.</returns>
    public int Handle_Magic__DispelMultipleEnchantments(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientMagicSystem, int, int>)0x005698C0)(ref this, a2);

    /// <summary>Retrieves the graphical icon for a specified spell. If not cached, creates and stores it for future use.
    /// <code>Offset: 0x00569990
    /// Graphic* __thiscall ClientMagicSystem::GetSpellIcon(ClientMagicSystem*,unsigned int)</code>
    /// </summary>
    /// <param name="spellID">Identifier of the spell whose icon is requested.</param>
    /// <returns>Pointer to the Graphic representing the spell's icon; null if creation fails or no surface available.</returns>
    public ACBindings.Internal.Graphic* GetSpellIcon(uint spellID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientMagicSystem, uint, ACBindings.Internal.Graphic*>)0x00569990)(ref this, spellID);

    /// <summary>Retrieves the icon graphic for a specified spell component, creating and caching it on first request.
    /// <code>Offset: 0x00569A50
    /// int __thiscall ClientMagicSystem::GetSpellComponentIcon(_DWORD*,unsigned int)</code>
    /// </summary>
    /// <param name="this">The ClientMagicSystem instance containing component tables and caches.</param>
    /// <param name="a2">Identifier of the spell component whose icon is requested.</param>
    /// <returns>An integer pointer to the Graphic object representing the component icon, or 0 if the icon cannot be created.</returns>
    public int GetSpellComponentIcon(uint a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientMagicSystem, uint, int>)0x00569A50)(ref this, a2);

    /// <summary>Initializes a new ClientMagicSystem instance by setting up base class vtables, initializing reference counts, clearing spell data pointers, resetting the selected spell, creating icon lookup tables, storing a global system pointer, and incrementing the internal reference counter.
    /// <code>Offset: 0x00569BD0
    /// void __thiscall ClientMagicSystem::ClientMagicSystem(ClientMagicSystem*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientMagicSystem, void>)0x00569BD0)(ref this);

    /// <summary>Destroys a ClientMagicSystem instance, freeing all spell and component icon tables and decrementing reference counts.
    /// <code>Offset: 0x00569C40
    /// void __thiscall ClientMagicSystem::~ClientMagicSystem(ClientMagicSystem*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientMagicSystem, void>)0x00569C40)(ref this);

    /// <summary>Releases a reference to the magic system, decrementing its internal reference counter and destroying the instance when the count reaches zero.
    /// <code>Offset: 0x00569DD0
    /// unsigned int __thiscall ClientMagicSystem::Release(ClientMagicSystem*)</code>
    /// </summary>
    /// <returns>The remaining reference count after release; zero indicates the object was deleted.</returns>
    public uint Release() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientMagicSystem, uint>)0x00569DD0)(ref this);
}

