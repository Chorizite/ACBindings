namespace ACBindings;

// NoticeRegistrar
public unsafe struct NoticeRegistrar : System.IDisposable
{
    // Child Types
    // NoticeRegistrar_vtbl
    public unsafe struct NoticeRegistrar_vtbl
    {
        // Members
        public System.IntPtr NoticeRegistrar_dtor_0; // function pointer
        public System.IntPtr RegisterNoticeHandler; // function pointer
        public System.IntPtr UnRegisterNoticeHandler; // function pointer
        public System.IntPtr UnRegisterAllNoticeHandlers; // function pointer
        public System.IntPtr GetNoticeHandlers;

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public System.IntPtr m_handlers;

    // Generated Constructor
    public NoticeRegistrar() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall NoticeRegistrar::NoticeRegistrar(NoticeRegistrar*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.NoticeRegistrar, void>)0x0043C6C0)(ref this);
    // void __thiscall NoticeRegistrar::DestroyHandlers(NoticeRegistrar*)
    public void DestroyHandlers() => ((delegate* unmanaged[Thiscall]<ref ACBindings.NoticeRegistrar, void>)0x0043C740)(ref this);
    // void __thiscall NoticeRegistrar::~NoticeRegistrar(NoticeRegistrar*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.NoticeRegistrar, void>)0x0043C850)(ref this);
    // bool __thiscall NoticeRegistrar::UnRegisterNoticeHandler(NoticeRegistrar*,unsigned int,NoticeHandler*)
    public byte UnRegisterNoticeHandler(uint i_notice, ACBindings.NoticeHandler* i_pcHandler) => ((delegate* unmanaged[Thiscall]<ref ACBindings.NoticeRegistrar, uint, ACBindings.NoticeHandler*, byte>)0x0043C860)(ref this, i_notice, i_pcHandler);
    // bool __thiscall NoticeRegistrar::UnRegisterAllNoticeHandlers(NoticeRegistrar*,NoticeHandler*)
    public byte UnRegisterAllNoticeHandlers(ACBindings.NoticeHandler* i_pcHandler) => ((delegate* unmanaged[Thiscall]<ref ACBindings.NoticeRegistrar, ACBindings.NoticeHandler*, byte>)0x0043C8A0)(ref this, i_pcHandler);
    // int __thiscall NoticeRegistrar::GetNoticeHandlers(_DWORD*,int)
    public int GetNoticeHandlers(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.NoticeRegistrar, int, int>)0x0043C930)(ref this, a2);
    // bool __thiscall NoticeRegistrar::RegisterNoticeHandler(NoticeRegistrar*,unsigned int,NoticeHandler*)
    public byte RegisterNoticeHandler(uint i_notice, ACBindings.NoticeHandler* i_pcHandler) => ((delegate* unmanaged[Thiscall]<ref ACBindings.NoticeRegistrar, uint, ACBindings.NoticeHandler*, byte>)0x0043CA10)(ref this, i_notice, i_pcHandler);
}

