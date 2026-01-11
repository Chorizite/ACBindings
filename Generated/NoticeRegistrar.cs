namespace ACBindings.Internal;

public unsafe struct NoticeRegistrar : System.IDisposable
{
    // Child Types
    public unsafe struct NoticeRegistrar_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.NoticeRegistrar*, void> NoticeRegistrar_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.NoticeRegistrar*, uint, ACBindings.Internal.NoticeHandler*, byte> RegisterNoticeHandler; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.NoticeRegistrar*, uint, ACBindings.Internal.NoticeHandler*, byte> UnRegisterNoticeHandler; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.NoticeRegistrar*, ACBindings.Internal.NoticeHandler*, byte> UnRegisterAllNoticeHandlers; // function pointer
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

    /// <summary>
    /// <code>Offset: 0x0043C6C0
    /// void __thiscall NoticeRegistrar::NoticeRegistrar(NoticeRegistrar*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NoticeRegistrar, void>)0x0043C6C0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0043C740
    /// void __thiscall NoticeRegistrar::DestroyHandlers(NoticeRegistrar*)</code>
    /// </summary>
    public void DestroyHandlers() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NoticeRegistrar, void>)0x0043C740)(ref this);

    /// <summary>
    /// <code>Offset: 0x0043C850
    /// void __thiscall NoticeRegistrar::~NoticeRegistrar(NoticeRegistrar*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NoticeRegistrar, void>)0x0043C850)(ref this);

    /// <summary>
    /// <code>Offset: 0x0043C860
    /// bool __thiscall NoticeRegistrar::UnRegisterNoticeHandler(NoticeRegistrar*,unsigned int,NoticeHandler*)</code>
    /// </summary>
    public byte UnRegisterNoticeHandler(uint i_notice, ACBindings.Internal.NoticeHandler* i_pcHandler) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NoticeRegistrar, uint, ACBindings.Internal.NoticeHandler*, byte>)0x0043C860)(ref this, i_notice, i_pcHandler);

    /// <summary>
    /// <code>Offset: 0x0043C8A0
    /// bool __thiscall NoticeRegistrar::UnRegisterAllNoticeHandlers(NoticeRegistrar*,NoticeHandler*)</code>
    /// </summary>
    public byte UnRegisterAllNoticeHandlers(ACBindings.Internal.NoticeHandler* i_pcHandler) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NoticeRegistrar, ACBindings.Internal.NoticeHandler*, byte>)0x0043C8A0)(ref this, i_pcHandler);

    /// <summary>
    /// <code>Offset: 0x0043C930
    /// int __thiscall NoticeRegistrar::GetNoticeHandlers(_DWORD*,int)</code>
    /// </summary>
    public int GetNoticeHandlers(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NoticeRegistrar, int, int>)0x0043C930)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x0043CA10
    /// bool __thiscall NoticeRegistrar::RegisterNoticeHandler(NoticeRegistrar*,unsigned int,NoticeHandler*)</code>
    /// </summary>
    public byte RegisterNoticeHandler(uint i_notice, ACBindings.Internal.NoticeHandler* i_pcHandler) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NoticeRegistrar, uint, ACBindings.Internal.NoticeHandler*, byte>)0x0043CA10)(ref this, i_notice, i_pcHandler);
}

