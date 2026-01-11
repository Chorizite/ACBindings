namespace ACBindings.Internal;

public unsafe struct QualityRegistrar : System.IDisposable
{
    // Child Types
    public unsafe struct QualityRegistrar_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.QualityRegistrar*, void> QualityRegistrar_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.QualityRegistrar*, uint, ACBindings.Internal.StatType, uint, ACBindings.Internal.QualityChangeHandler*, byte> RegisterQualityHandler; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.QualityRegistrar*, ACBindings.Internal.StatType, uint, ACBindings.Internal.QualityChangeHandler*, byte> RegisterQualityHandlerForThePlayer; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.QualityRegistrar*, uint, ACBindings.Internal.StatType, uint, ACBindings.Internal.QualityChangeHandler*, byte> UnRegisterQualityHandler; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.QualityRegistrar*, ACBindings.Internal.StatType, uint, ACBindings.Internal.QualityChangeHandler*, byte> UnRegisterQualityHandlerForThePlayer; // function pointer
        public fixed byte gap14[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.QualityRegistrar*, uint, byte> UnRegisterAllQualityHandler; // function pointer

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

    /// <summary>
    /// <code>Offset: 0x00693D00
    /// bool __thiscall QualityRegistrar::UnRegisterAllQualityHandler(QualityRegistrar*,QualityChangeHandler*)</code>
    /// </summary>
    public byte UnRegisterAllQualityHandler(ACBindings.Internal.QualityChangeHandler* i_pcHandler) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QualityRegistrar, ACBindings.Internal.QualityChangeHandler*, byte>)0x00693D00)(ref this, i_pcHandler);

    /// <summary>
    /// <code>Offset: 0x00693F30
    /// bool __thiscall QualityRegistrar::UnRegisterQualityHandler(QualityRegistrar*,unsigned int,StatType,unsigned int,QualityChangeHandler*)</code>
    /// </summary>
    public byte UnRegisterQualityHandler(uint i_iidTarget, ACBindings.Internal.StatType i_StatType, uint i_StatCode, ACBindings.Internal.QualityChangeHandler* i_pcHandler) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QualityRegistrar, uint, ACBindings.Internal.StatType, uint, ACBindings.Internal.QualityChangeHandler*, byte>)0x00693F30)(ref this, i_iidTarget, i_StatType, i_StatCode, i_pcHandler);

    /// <summary>
    /// <code>Offset: 0x00693FA0
    /// bool __thiscall QualityRegistrar::UnRegisterQualityHandlerForThePlayer(QualityRegistrar*,StatType,unsigned int,QualityChangeHandler*)</code>
    /// </summary>
    public byte UnRegisterQualityHandlerForThePlayer(ACBindings.Internal.StatType i_StatType, uint i_StatCode, ACBindings.Internal.QualityChangeHandler* i_pcHandler) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QualityRegistrar, ACBindings.Internal.StatType, uint, ACBindings.Internal.QualityChangeHandler*, byte>)0x00693FA0)(ref this, i_StatType, i_StatCode, i_pcHandler);

    /// <summary>
    /// <code>Offset: 0x00694010
    /// bool __thiscall QualityRegistrar::CallChangeHandler(QualityRegistrar*,CWeenieObject*,StatType,unsigned int)</code>
    /// </summary>
    public byte CallChangeHandler(ACBindings.Internal.CWeenieObject* cwobj, ACBindings.Internal.StatType stype, uint senum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QualityRegistrar, ACBindings.Internal.CWeenieObject*, ACBindings.Internal.StatType, uint, byte>)0x00694010)(ref this, cwobj, stype, senum);

    /// <summary>
    /// <code>Offset: 0x006940A0
    /// bool __thiscall QualityRegistrar::CallRemoveHandler(QualityRegistrar*,CWeenieObject*,StatType,unsigned int)</code>
    /// </summary>
    public byte CallRemoveHandler(ACBindings.Internal.CWeenieObject* cwobj, ACBindings.Internal.StatType stype, uint senum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QualityRegistrar, ACBindings.Internal.CWeenieObject*, ACBindings.Internal.StatType, uint, byte>)0x006940A0)(ref this, cwobj, stype, senum);

    /// <summary>
    /// <code>Offset: 0x00694470
    /// bool __thiscall QualityRegistrar::UnRegisterAllQualityHandler(QualityRegistrar*,unsigned int)</code>
    /// </summary>
    public byte UnRegisterAllQualityHandler(uint i_iidTarget) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QualityRegistrar, uint, byte>)0x00694470)(ref this, i_iidTarget);

    /// <summary>
    /// <code>Offset: 0x00694570
    /// bool __thiscall QualityRegistrar::RegisterQualityHandlerForThePlayer(QualityRegistrar*,StatType,unsigned int,QualityChangeHandler*)</code>
    /// </summary>
    public byte RegisterQualityHandlerForThePlayer(ACBindings.Internal.StatType i_StatType, uint i_StatCode, ACBindings.Internal.QualityChangeHandler* i_pcHandler) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QualityRegistrar, ACBindings.Internal.StatType, uint, ACBindings.Internal.QualityChangeHandler*, byte>)0x00694570)(ref this, i_StatType, i_StatCode, i_pcHandler);

    /// <summary>
    /// <code>Offset: 0x00694730
    /// bool __thiscall QualityRegistrar::RegisterQualityHandler(QualityRegistrar*,unsigned int,StatType,unsigned int,QualityChangeHandler*)</code>
    /// </summary>
    public byte RegisterQualityHandler(uint i_iidTarget, ACBindings.Internal.StatType i_StatType, uint i_StatCode, ACBindings.Internal.QualityChangeHandler* i_pcHandler) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QualityRegistrar, uint, ACBindings.Internal.StatType, uint, ACBindings.Internal.QualityChangeHandler*, byte>)0x00694730)(ref this, i_iidTarget, i_StatType, i_StatCode, i_pcHandler);

    /// <summary>
    /// <code>Offset: 0x00694870
    /// void __thiscall QualityRegistrar::~QualityRegistrar(QualityRegistrar*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QualityRegistrar, void>)0x00694870)(ref this);
}

