namespace ACBindings;

// QualityRegistrar
public unsafe struct QualityRegistrar : System.IDisposable
{
    // Statics
    public static ACBindings.QualityRegistrar* s_pQR = (ACBindings.QualityRegistrar*)0x008F958C;

    // Child Types
    // QualityRegistrar_vtbl
    public unsafe struct QualityRegistrar_vtbl
    {
        // Members
        public System.IntPtr QualityRegistrar_dtor_0; // function pointer
        public System.IntPtr RegisterQualityHandler; // function pointer
        public System.IntPtr RegisterQualityHandlerForThePlayer; // function pointer
        public System.IntPtr UnRegisterQualityHandler; // function pointer
        public System.IntPtr UnRegisterQualityHandlerForThePlayer; // function pointer
        public fixed byte gap14[4];
        public System.IntPtr UnRegisterAllQualityHandler; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.IntrusiveHashTable__uint__QualityHandler_ptr m_handlers;
    public ACBindings.QualityHandler m_PlayerQualityHandler;
    public ACBindings.QualityHandler m_GlobalQualityHandler;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // bool __thiscall QualityRegistrar::UnRegisterAllQualityHandler(QualityRegistrar*,QualityChangeHandler*)
    public byte UnRegisterAllQualityHandler(ACBindings.QualityChangeHandler* i_pcHandler) => ((delegate* unmanaged[Thiscall]<ref ACBindings.QualityRegistrar, ACBindings.QualityChangeHandler*, byte>)0x00693D00)(ref this, i_pcHandler);
    // bool __thiscall QualityRegistrar::UnRegisterQualityHandler(QualityRegistrar*,unsigned int,StatType,unsigned int,QualityChangeHandler*)
    public byte UnRegisterQualityHandler(uint i_iidTarget, ACBindings.StatType i_StatType, uint i_StatCode, ACBindings.QualityChangeHandler* i_pcHandler) => ((delegate* unmanaged[Thiscall]<ref ACBindings.QualityRegistrar, uint, ACBindings.StatType, uint, ACBindings.QualityChangeHandler*, byte>)0x00693F30)(ref this, i_iidTarget, i_StatType, i_StatCode, i_pcHandler);
    // bool __thiscall QualityRegistrar::UnRegisterQualityHandlerForThePlayer(QualityRegistrar*,StatType,unsigned int,QualityChangeHandler*)
    public byte UnRegisterQualityHandlerForThePlayer(ACBindings.StatType i_StatType, uint i_StatCode, ACBindings.QualityChangeHandler* i_pcHandler) => ((delegate* unmanaged[Thiscall]<ref ACBindings.QualityRegistrar, ACBindings.StatType, uint, ACBindings.QualityChangeHandler*, byte>)0x00693FA0)(ref this, i_StatType, i_StatCode, i_pcHandler);
    // bool __thiscall QualityRegistrar::CallChangeHandler(QualityRegistrar*,CWeenieObject*,StatType,unsigned int)
    public byte CallChangeHandler(ACBindings.CWeenieObject* cwobj, ACBindings.StatType stype, uint senum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.QualityRegistrar, ACBindings.CWeenieObject*, ACBindings.StatType, uint, byte>)0x00694010)(ref this, cwobj, stype, senum);
    // bool __thiscall QualityRegistrar::CallRemoveHandler(QualityRegistrar*,CWeenieObject*,StatType,unsigned int)
    public byte CallRemoveHandler(ACBindings.CWeenieObject* cwobj, ACBindings.StatType stype, uint senum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.QualityRegistrar, ACBindings.CWeenieObject*, ACBindings.StatType, uint, byte>)0x006940A0)(ref this, cwobj, stype, senum);
    // bool __thiscall QualityRegistrar::UnRegisterAllQualityHandler(QualityRegistrar*,unsigned int)
    public byte UnRegisterAllQualityHandler(uint i_iidTarget) => ((delegate* unmanaged[Thiscall]<ref ACBindings.QualityRegistrar, uint, byte>)0x00694470)(ref this, i_iidTarget);
    // bool __thiscall QualityRegistrar::RegisterQualityHandlerForThePlayer(QualityRegistrar*,StatType,unsigned int,QualityChangeHandler*)
    public byte RegisterQualityHandlerForThePlayer(ACBindings.StatType i_StatType, uint i_StatCode, ACBindings.QualityChangeHandler* i_pcHandler) => ((delegate* unmanaged[Thiscall]<ref ACBindings.QualityRegistrar, ACBindings.StatType, uint, ACBindings.QualityChangeHandler*, byte>)0x00694570)(ref this, i_StatType, i_StatCode, i_pcHandler);
    // bool __thiscall QualityRegistrar::RegisterQualityHandler(QualityRegistrar*,unsigned int,StatType,unsigned int,QualityChangeHandler*)
    public byte RegisterQualityHandler(uint i_iidTarget, ACBindings.StatType i_StatType, uint i_StatCode, ACBindings.QualityChangeHandler* i_pcHandler) => ((delegate* unmanaged[Thiscall]<ref ACBindings.QualityRegistrar, uint, ACBindings.StatType, uint, ACBindings.QualityChangeHandler*, byte>)0x00694730)(ref this, i_iidTarget, i_StatType, i_StatCode, i_pcHandler);
    // void __thiscall QualityRegistrar::~QualityRegistrar(QualityRegistrar*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.QualityRegistrar, void>)0x00694870)(ref this);
}

