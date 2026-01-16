namespace ACBindings.Internal;


/// <summary>Manages registration of event handlers, storing handler references and providing virtual function dispatch support.</summary>
public unsafe struct NoticeRegistrar : System.IDisposable
{
    // Child Types

    /// <summary>Provides a virtual function table for NoticeRegistrar, defining operations for destructor and managing notice handlers.</summary>
    public unsafe struct NoticeRegistrar_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.NoticeRegistrar*, void> NoticeRegistrar_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.NoticeRegistrar*, uint, ACBindings.Internal.NoticeHandler*, byte> RegisterNoticeHandler; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.NoticeRegistrar*, uint, ACBindings.Internal.NoticeHandler*, byte> UnRegisterNoticeHandler; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.NoticeRegistrar*, ACBindings.Internal.NoticeHandler*, byte> UnRegisterAllNoticeHandlers; // function pointer
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

    /// <summary>Initializes a new NoticeRegistrar instance by assigning its virtual function table pointer and clearing the handler list.
    /// <code>Offset: 0x0043C6C0
    /// void __thiscall NoticeRegistrar::NoticeRegistrar(NoticeRegistrar*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NoticeRegistrar, void>)0x0043C6C0)(ref this);

    /// <summary>Destroys all registered handlers associated with this registrar, releasing each handler and clearing the internal handler list.
    /// <code>Offset: 0x0043C740
    /// void __thiscall NoticeRegistrar::DestroyHandlers(NoticeRegistrar*)</code>
    /// </summary>
    public void DestroyHandlers() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NoticeRegistrar, void>)0x0043C740)(ref this);

    /// <summary>Destroys a NoticeRegistrar instance by cleaning up its handlers and restoring the virtual table pointer.
    /// <code>Offset: 0x0043C850
    /// void __thiscall NoticeRegistrar::~NoticeRegistrar(NoticeRegistrar*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NoticeRegistrar, void>)0x0043C850)(ref this);

    /// <summary>Removes a notice handler from the internal list associated with a given notice ID.
    /// <code>Offset: 0x0043C860
    /// bool __thiscall NoticeRegistrar::UnRegisterNoticeHandler(NoticeRegistrar*,unsigned int,NoticeHandler*)</code>
    /// </summary>
    /// <param name="i_notice">The identifier of the notice whose handlers are being managed.</param>
    /// <param name="i_pcHandler">Pointer to the handler instance to be unregistered.</param>
    /// <returns>True if the handler was found and removed; otherwise returns true (the function always reports success).</returns>
    public byte UnRegisterNoticeHandler(uint i_notice, ACBindings.Internal.NoticeHandler* i_pcHandler) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NoticeRegistrar, uint, ACBindings.Internal.NoticeHandler*, byte>)0x0043C860)(ref this, i_notice, i_pcHandler);

    /// <summary>Removes the specified NoticeHandler from all lists registered in this NoticeRegistrar instance.
    /// <code>Offset: 0x0043C8A0
    /// bool __thiscall NoticeRegistrar::UnRegisterAllNoticeHandlers(NoticeRegistrar*,NoticeHandler*)</code>
    /// </summary>
    /// <param name="i_pcHandler">The handler to be unregistered from every notice list.</param>
    /// <returns>True after attempting removal; the function always succeeds.</returns>
    public byte UnRegisterAllNoticeHandlers(ACBindings.Internal.NoticeHandler* i_pcHandler) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NoticeRegistrar, ACBindings.Internal.NoticeHandler*, byte>)0x0043C8A0)(ref this, i_pcHandler);

    /// <summary>Retrieves a notice handler for a given notice ID from the registrar's internal table.
    /// <code>Offset: 0x0043C930
    /// int __thiscall NoticeRegistrar::GetNoticeHandlers(_DWORD*,int)</code>
    /// </summary>
    /// <param name="a2">The identifier of the notice whose handler is requested.</param>
    /// <returns>A pointer to the handler function if found; otherwise zero.</returns>
    public int GetNoticeHandlers(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NoticeRegistrar, int, int>)0x0043C930)(ref this, a2);

    /// <summary>Registers a NoticeHandler for the specified notice ID, adding it to an internal hash table if not already present. Creates the handlers storage on first use.
    /// <code>Offset: 0x0043CA10
    /// bool __thiscall NoticeRegistrar::RegisterNoticeHandler(NoticeRegistrar*,unsigned int,NoticeHandler*)</code>
    /// </summary>
    /// <param name="i_notice">The identifier of the notice to register the handler for.</param>
    /// <param name="i_pcHandler">Pointer to the NoticeHandler instance to associate with the notice.</param>
    /// <returns>True if the handler was successfully registered; false if memory allocation failed during initialization.</returns>
    public byte RegisterNoticeHandler(uint i_notice, ACBindings.Internal.NoticeHandler* i_pcHandler) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NoticeRegistrar, uint, ACBindings.Internal.NoticeHandler*, byte>)0x0043CA10)(ref this, i_notice, i_pcHandler);
}

