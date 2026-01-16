namespace ACBindings.Internal;


/// <summary>Handles registration and lookup of quality change callbacks, mapping unique identifiers to collections of handler objects for dynamic adjustment of system quality settings.</summary>
public unsafe struct QualityHandler : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.IntrusiveHashData__uint___QualityHandler_ptr BaseClass_IntrusiveHashData; // ACBindings.Internal.IntrusiveHashData__uint___QualityHandler_ptr

    // Members
    public ACBindings.Internal.HashTable__ulong___SmartArray___QualityChangeHandler_ptr_ptr m_handlers;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Removes the specified QualityChangeHandler from the internal collection of handlers stored in this QualityHandler instance. Searches the hash table for the handler and excises it if found, adjusting the list to preserve integrity.
    /// <code>Offset: 0x00693C50
    /// bool __thiscall QualityHandler::Remove(QualityHandler*,QualityChangeHandler*)</code>
    /// </summary>
    /// <param name="i_pcHandler">The handler to be removed.</param>
    /// <returns>Always true after attempting removal; indicates that the operation completed (the handler may or may not have been present).</returns>
    public byte Remove(ACBindings.Internal.QualityChangeHandler* i_pcHandler) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QualityHandler, ACBindings.Internal.QualityChangeHandler*, byte>)0x00693C50)(ref this, i_pcHandler);

    /// <summary>Removes a QualityChangeHandler from the handlers table for a given stat code.
    /// <code>Offset: 0x00693DD0
    /// bool __thiscall QualityHandler::Remove(QualityHandler*,unsigned __int64,QualityChangeHandler*)</code>
    /// </summary>
    /// <param name="statCode">The unique identifier of the quality or stat whose handler should be removed.</param>
    /// <param name="i_pcHandler">Pointer to the handler instance to remove.</param>
    /// <returns>True if the handler was successfully located and removed; otherwise false.</returns>
    public byte Remove(ulong statCode, ACBindings.Internal.QualityChangeHandler* i_pcHandler) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QualityHandler, ulong, ACBindings.Internal.QualityChangeHandler*, byte>)0x00693DD0)(ref this, statCode, i_pcHandler);

    /// <summary>Invokes all quality change handlers registered for the specified stat type and sub‑enumeration on the provided object.
    /// <code>Offset: 0x00693E20
    /// bool __thiscall QualityHandler::CallChangeHandler(QualityHandler*,CWeenieObject*,StatType,unsigned int)</code>
    /// </summary>
    /// <param name="cwobj">The object whose quality has changed.</param>
    /// <param name="stype">The statistical type identifying which quality to update.</param>
    /// <param name="senum">An unsigned integer representing a sub‑enumeration within that stat type.</param>
    /// <returns>True if at least one handler was found and called; otherwise, false.</returns>
    public byte CallChangeHandler(ACBindings.Internal.CWeenieObject* cwobj, ACBindings.Internal.StatType stype, uint senum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QualityHandler, ACBindings.Internal.CWeenieObject*, ACBindings.Internal.StatType, uint, byte>)0x00693E20)(ref this, cwobj, stype, senum);

    /// <summary>Invokes all quality change handlers registered for the specified object, statistic type, and enumeration index.
    /// <code>Offset: 0x00693EA0
    /// bool __thiscall QualityHandler::CallRemoveHandler(QualityHandler*,CWeenieObject*,StatType,unsigned int)</code>
    /// </summary>
    /// <param name="cwobj">The CWeenieObject whose quality change handlers are to be called.</param>
    /// <param name="stype">The statistic type identifying which handlers to invoke.</param>
    /// <param name="senum">The specific enumeration index within that statistic type.</param>
    /// <returns>True if a handler list existed for the given key and was processed; otherwise false.</returns>
    public byte CallRemoveHandler(ACBindings.Internal.CWeenieObject* cwobj, ACBindings.Internal.StatType stype, uint senum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QualityHandler, ACBindings.Internal.CWeenieObject*, ACBindings.Internal.StatType, uint, byte>)0x00693EA0)(ref this, cwobj, stype, senum);

    /// <summary>Registers a quality change handler for the specified stat code, ensuring duplicate handlers are not added.
    /// <code>Offset: 0x006944F0
    /// bool __thiscall QualityHandler::Add(QualityHandler*,unsigned __int64,QualityChangeHandler*)</code>
    /// </summary>
    /// <param name="statCode">Identifier of the stat whose changes will trigger the handler.</param>
    /// <param name="i_pcHandler">Pointer to the handler instance to be invoked on quality changes.</param>
    /// <returns>True if the handler was successfully added; otherwise false.</returns>
    public byte Add(ulong statCode, ACBindings.Internal.QualityChangeHandler* i_pcHandler) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QualityHandler, ulong, ACBindings.Internal.QualityChangeHandler*, byte>)0x006944F0)(ref this, statCode, i_pcHandler);

    /// <summary>Destroys a QualityHandler instance, freeing its handler tables and deallocating related resources.
    /// <code>Offset: 0x00694600
    /// void __thiscall QualityHandler::~QualityHandler(QualityHandler*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QualityHandler, void>)0x00694600)(ref this);
}

