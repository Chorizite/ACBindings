namespace ACBindings;

// QualityHandler
public unsafe struct QualityHandler : System.IDisposable
{
    // Base Classes
    public ACBindings.IntrusiveHashData__uint__QualityHandler_ptr BaseClass_IntrusiveHashData; // ACBindings.IntrusiveHashData__uint__QualityHandler_ptr

    // Members
    public ACBindings.HashTable__ulong__SmartArray__QualityChangeHandler_ptr_ptr m_handlers;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // bool __thiscall QualityHandler::Remove(QualityHandler*,QualityChangeHandler*)
    public byte Remove(ACBindings.QualityChangeHandler* i_pcHandler) => ((delegate* unmanaged[Thiscall]<ref ACBindings.QualityHandler, ACBindings.QualityChangeHandler*, byte>)0x00693C50)(ref this, i_pcHandler);
    // bool __thiscall QualityHandler::Remove(QualityHandler*,unsigned __int64,QualityChangeHandler*)
    public byte Remove(ulong statCode, ACBindings.QualityChangeHandler* i_pcHandler) => ((delegate* unmanaged[Thiscall]<ref ACBindings.QualityHandler, ulong, ACBindings.QualityChangeHandler*, byte>)0x00693DD0)(ref this, statCode, i_pcHandler);
    // bool __thiscall QualityHandler::CallChangeHandler(QualityHandler*,CWeenieObject*,StatType,unsigned int)
    public byte CallChangeHandler(ACBindings.CWeenieObject* cwobj, ACBindings.StatType stype, uint senum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.QualityHandler, ACBindings.CWeenieObject*, ACBindings.StatType, uint, byte>)0x00693E20)(ref this, cwobj, stype, senum);
    // bool __thiscall QualityHandler::CallRemoveHandler(QualityHandler*,CWeenieObject*,StatType,unsigned int)
    public byte CallRemoveHandler(ACBindings.CWeenieObject* cwobj, ACBindings.StatType stype, uint senum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.QualityHandler, ACBindings.CWeenieObject*, ACBindings.StatType, uint, byte>)0x00693EA0)(ref this, cwobj, stype, senum);
    // bool __thiscall QualityHandler::Add(QualityHandler*,unsigned __int64,QualityChangeHandler*)
    public byte Add(ulong statCode, ACBindings.QualityChangeHandler* i_pcHandler) => ((delegate* unmanaged[Thiscall]<ref ACBindings.QualityHandler, ulong, ACBindings.QualityChangeHandler*, byte>)0x006944F0)(ref this, statCode, i_pcHandler);
    // void __thiscall QualityHandler::~QualityHandler(QualityHandler*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.QualityHandler, void>)0x00694600)(ref this);
}

