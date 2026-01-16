namespace ACBindings.Internal;


/// <summary>
/// Manages quality change handlers for entities, the player, and global contexts, providing registration, removal, and event dispatching through an internal hash table of handler objects.
/// </summary>
public unsafe struct QualityRegistrar : System.IDisposable
{
    // Statics
    public static ACBindings.Internal.QualityRegistrar** s_pQR = (ACBindings.Internal.QualityRegistrar**)0x008F958C;

    // Child Types
    public unsafe struct QualityRegistrar_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.QualityRegistrar*, void> QualityRegistrar_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.QualityRegistrar*, uint, ACBindings.Internal.StatType, uint, ACBindings.Internal.QualityChangeHandler*, byte> RegisterQualityHandler; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.QualityRegistrar*, ACBindings.Internal.StatType, uint, ACBindings.Internal.QualityChangeHandler*, byte> RegisterQualityHandlerForThePlayer; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.QualityRegistrar*, uint, ACBindings.Internal.StatType, uint, ACBindings.Internal.QualityChangeHandler*, byte> UnRegisterQualityHandler; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.QualityRegistrar*, ACBindings.Internal.StatType, uint, ACBindings.Internal.QualityChangeHandler*, byte> UnRegisterQualityHandlerForThePlayer; // function pointer
        public fixed byte gap14[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.QualityRegistrar*, uint, byte> UnRegisterAllQualityHandler; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.Internal.IntrusiveHashTable__uint___QualityHandler_ptr m_handlers;
    public ACBindings.Internal.QualityHandler m_PlayerQualityHandler;
    public ACBindings.Internal.QualityHandler m_GlobalQualityHandler;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Unregisters a quality change handler from all registered quality handlers, including the internal player and global handlers.
    /// <code>Offset: 0x00693D00
    /// bool __thiscall QualityRegistrar::UnRegisterAllQualityHandler(QualityRegistrar*,QualityChangeHandler*)</code>
    /// </summary>
    /// <param name="i_pcHandler">The QualityChangeHandler to remove.</param>
    /// <returns>True upon completion (currently always returns true).</returns>
    public byte UnRegisterAllQualityHandler(ACBindings.Internal.QualityChangeHandler* i_pcHandler) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QualityRegistrar, ACBindings.Internal.QualityChangeHandler*, byte>)0x00693D00)(ref this, i_pcHandler);

    /// <summary>Unregisters the specified quality change handler from either a target‑specific or global registry based on the provided identifier and statistic code.
    /// <code>Offset: 0x00693F30
    /// bool __thiscall QualityRegistrar::UnRegisterQualityHandler(QualityRegistrar*,unsigned int,StatType,unsigned int,QualityChangeHandler*)</code>
    /// </summary>
    /// <param name="i_iidTarget">Identifier of the target entity; zero selects the global handler.</param>
    /// <param name="i_StatType">Statistic type used to locate the handler entry.</param>
    /// <param name="i_StatCode">Specific statistic code paired with the type for lookup.</param>
    /// <param name="i_pcHandler">Pointer to the quality change handler instance to remove.</param>
    /// <returns>True if the handler was successfully found and removed; otherwise false.</returns>
    public byte UnRegisterQualityHandler(uint i_iidTarget, ACBindings.Internal.StatType i_StatType, uint i_StatCode, ACBindings.Internal.QualityChangeHandler* i_pcHandler) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QualityRegistrar, uint, ACBindings.Internal.StatType, uint, ACBindings.Internal.QualityChangeHandler*, byte>)0x00693F30)(ref this, i_iidTarget, i_StatType, i_StatCode, i_pcHandler);

    /// <summary>Removes a quality change handler for a specific player statistic.
    /// <code>Offset: 0x00693FA0
    /// bool __thiscall QualityRegistrar::UnRegisterQualityHandlerForThePlayer(QualityRegistrar*,StatType,unsigned int,QualityChangeHandler*)</code>
    /// </summary>
    /// <param name="i_StatType">The type of the statistic to modify.</param>
    /// <param name="i_StatCode">Numeric code identifying the specific statistic instance.</param>
    /// <param name="i_pcHandler">Pointer to the handler to unregister.</param>
    /// <returns>True if the handler was found and removed; otherwise, false.</returns>
    public byte UnRegisterQualityHandlerForThePlayer(ACBindings.Internal.StatType i_StatType, uint i_StatCode, ACBindings.Internal.QualityChangeHandler* i_pcHandler) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QualityRegistrar, ACBindings.Internal.StatType, uint, ACBindings.Internal.QualityChangeHandler*, byte>)0x00693FA0)(ref this, i_StatType, i_StatCode, i_pcHandler);

    /// <summary>Delegates a quality change event for the given object to the appropriate handler(s) based on the object's identifier, then notifies both player‑specific and global handlers.
    /// <code>Offset: 0x00694010
    /// bool __thiscall QualityRegistrar::CallChangeHandler(QualityRegistrar*,CWeenieObject*,StatType,unsigned int)</code>
    /// </summary>
    /// <param name="cwobj">The object whose quality changed.</param>
    /// <param name="stype">The type of stat that changed.</param>
    /// <param name="senum">An additional enumeration value associated with the change.</param>
    /// <returns>True if the event was processed; always true in current implementation.</returns>
    public byte CallChangeHandler(ACBindings.Internal.CWeenieObject* cwobj, ACBindings.Internal.StatType stype, uint senum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QualityRegistrar, ACBindings.Internal.CWeenieObject*, ACBindings.Internal.StatType, uint, byte>)0x00694010)(ref this, cwobj, stype, senum);

    /// <summary>Removes a quality handler for a given object and stat type, invoking removal on the appropriate per-object, player, and global handlers.
    /// <code>Offset: 0x006940A0
    /// bool __thiscall QualityRegistrar::CallRemoveHandler(QualityRegistrar*,CWeenieObject*,StatType,unsigned int)</code>
    /// </summary>
    /// <param name="this">The QualityRegistrar instance performing the removal.</param>
    /// <param name="cwobj">The object whose quality is being removed.</param>
    /// <param name="stype">The statistical type of the quality to remove.</param>
    /// <param name="senum">An enumeration value identifying the specific quality or context for removal.</param>
    /// <returns>True upon completion, indicating that the removal was attempted on all relevant handlers.</returns>
    public byte CallRemoveHandler(ACBindings.Internal.CWeenieObject* cwobj, ACBindings.Internal.StatType stype, uint senum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QualityRegistrar, ACBindings.Internal.CWeenieObject*, ACBindings.Internal.StatType, uint, byte>)0x006940A0)(ref this, cwobj, stype, senum);

    /// <summary>Removes all quality handlers associated with the specified target identifier from the registrar.
    /// <code>Offset: 0x00694470
    /// bool __thiscall QualityRegistrar::UnRegisterAllQualityHandler(QualityRegistrar*,unsigned int)</code>
    /// </summary>
    /// <param name="i_iidTarget">The identifier of the handlers to unregister.</param>
    /// <returns>True if any handlers were found and removed; otherwise, false.</returns>
    public byte UnRegisterAllQualityHandler(uint i_iidTarget) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QualityRegistrar, uint, byte>)0x00694470)(ref this, i_iidTarget);

    /// <summary>Registers a quality change handler for the current player using the specified stat type and code.
    /// <code>Offset: 0x00694570
    /// bool __thiscall QualityRegistrar::RegisterQualityHandlerForThePlayer(QualityRegistrar*,StatType,unsigned int,QualityChangeHandler*)</code>
    /// </summary>
    /// <param name="i_StatType">The type of statistic to monitor.</param>
    /// <param name="i_StatCode">The specific identifier of the statistic within its type.</param>
    /// <param name="i_pcHandler">Pointer to the handler invoked when quality changes occur.</param>
    /// <returns>True if registration succeeded; otherwise, false.</returns>
    public byte RegisterQualityHandlerForThePlayer(ACBindings.Internal.StatType i_StatType, uint i_StatCode, ACBindings.Internal.QualityChangeHandler* i_pcHandler) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QualityRegistrar, ACBindings.Internal.StatType, uint, ACBindings.Internal.QualityChangeHandler*, byte>)0x00694570)(ref this, i_StatType, i_StatCode, i_pcHandler);

    /// <summary>Registers a quality change handler for the specified target ID and stat combination. If the target ID is zero, registers as a global handler. Returns true when the handler was successfully added.
    /// <code>Offset: 0x00694730
    /// bool __thiscall QualityRegistrar::RegisterQualityHandler(QualityRegistrar*,unsigned int,StatType,unsigned int,QualityChangeHandler*)</code>
    /// </summary>
    /// <param name="i_iidTarget">Identifier of the target entity; 0 denotes the global context.</param>
    /// <param name="i_StatType">The type of statistic to monitor.</param>
    /// <param name="i_StatCode">Specific code within the stat type.</param>
    /// <param name="i_pcHandler">Pointer to the QualityChangeHandler instance to register.</param>
    /// <returns>True if registration succeeds; otherwise, false.</returns>
    public byte RegisterQualityHandler(uint i_iidTarget, ACBindings.Internal.StatType i_StatType, uint i_StatCode, ACBindings.Internal.QualityChangeHandler* i_pcHandler) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QualityRegistrar, uint, ACBindings.Internal.StatType, uint, ACBindings.Internal.QualityChangeHandler*, byte>)0x00694730)(ref this, i_iidTarget, i_StatType, i_StatCode, i_pcHandler);

    /// <summary>Destroys a QualityRegistrar instance by clearing its handler table, deleting global and player quality handlers, freeing bucket memory, and resetting internal state including the global registrar reference.
    /// <code>Offset: 0x00694870
    /// void __thiscall QualityRegistrar::~QualityRegistrar(QualityRegistrar*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QualityRegistrar, void>)0x00694870)(ref this);
}

