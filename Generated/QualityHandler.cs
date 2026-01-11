namespace ACBindings.Internal;

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

    /// <summary>
    /// <code>Offset: 0x00693C50
    /// bool __thiscall QualityHandler::Remove(QualityHandler*,QualityChangeHandler*)</code>
    /// </summary>
    public byte Remove(ACBindings.Internal.QualityChangeHandler* i_pcHandler) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QualityHandler, ACBindings.Internal.QualityChangeHandler*, byte>)0x00693C50)(ref this, i_pcHandler);

    /// <summary>
    /// <code>Offset: 0x00693DD0
    /// bool __thiscall QualityHandler::Remove(QualityHandler*,unsigned __int64,QualityChangeHandler*)</code>
    /// </summary>
    public byte Remove(ulong statCode, ACBindings.Internal.QualityChangeHandler* i_pcHandler) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QualityHandler, ulong, ACBindings.Internal.QualityChangeHandler*, byte>)0x00693DD0)(ref this, statCode, i_pcHandler);

    /// <summary>
    /// <code>Offset: 0x00693E20
    /// bool __thiscall QualityHandler::CallChangeHandler(QualityHandler*,CWeenieObject*,StatType,unsigned int)</code>
    /// </summary>
    public byte CallChangeHandler(ACBindings.Internal.CWeenieObject* cwobj, ACBindings.Internal.StatType stype, uint senum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QualityHandler, ACBindings.Internal.CWeenieObject*, ACBindings.Internal.StatType, uint, byte>)0x00693E20)(ref this, cwobj, stype, senum);

    /// <summary>
    /// <code>Offset: 0x00693EA0
    /// bool __thiscall QualityHandler::CallRemoveHandler(QualityHandler*,CWeenieObject*,StatType,unsigned int)</code>
    /// </summary>
    public byte CallRemoveHandler(ACBindings.Internal.CWeenieObject* cwobj, ACBindings.Internal.StatType stype, uint senum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QualityHandler, ACBindings.Internal.CWeenieObject*, ACBindings.Internal.StatType, uint, byte>)0x00693EA0)(ref this, cwobj, stype, senum);

    /// <summary>
    /// <code>Offset: 0x006944F0
    /// bool __thiscall QualityHandler::Add(QualityHandler*,unsigned __int64,QualityChangeHandler*)</code>
    /// </summary>
    public byte Add(ulong statCode, ACBindings.Internal.QualityChangeHandler* i_pcHandler) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QualityHandler, ulong, ACBindings.Internal.QualityChangeHandler*, byte>)0x006944F0)(ref this, statCode, i_pcHandler);

    /// <summary>
    /// <code>Offset: 0x00694600
    /// void __thiscall QualityHandler::~QualityHandler(QualityHandler*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QualityHandler, void>)0x00694600)(ref this);
}

