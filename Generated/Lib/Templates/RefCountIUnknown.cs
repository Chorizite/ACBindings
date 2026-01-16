namespace ACBindings.Internal;

public unsafe struct RefCountIUnknown___gmCCommunicationSystem_uiChatInterfaceProvider
{
    // Base Classes
    public ACBindings.Internal.gmCCommunicationSystem.uiChatInterfaceProvider BaseClass_gmCCommunicationSystem_uiChatInterfaceProvider; // ACBindings.Internal.gmCCommunicationSystem.uiChatInterfaceProvider
    public ACBindings.Internal.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.Internal.ReferenceCountTemplate

    // Child Types
    public unsafe struct RefCountIUnknown_vtbl___gmCCommunicationSystem_uiChatInterfaceProvider
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, ACBindings.Internal._GUID*, void**, int> QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> Release; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IChatNetwork*, ACBindings.Internal.tagBLOB, int> SendData; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IChatNetwork*, int> UseTime; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CCommunicationSystem.ChatInterfaceProvider*, void> ChatInterfaceProvider_dtor_14; // function pointer
        public System.IntPtr You_Must_Not_Have_Multiple_Implementations_Of_AddRef_In_A_Hierarchy;

        // Methods
    }
    // RefCountIUnknown<gmCCommunicationSystem::uiChatInterfaceProvider>::Enum2
    public enum Enum2 : uint
    {
    }

    // Methods

    /// <summary>Decrements the object's reference count and returns the updated count.
    /// <code>Offset: 0x0058A5E0
    /// int __stdcall RefCountIUnknown&lt;gmCCommunicationSystem::uiChatInterfaceProvider&gt;::Release(int)</code>
    /// </summary>
    /// <param name="a1">Pointer to the RefCountIUnknown instance whose reference count will be released.</param>
    /// <returns>The new reference count after decrementing; zero indicates no remaining references.</returns>
    // int __stdcall RefCountIUnknown<gmCCommunicationSystem::uiChatInterfaceProvider>::Release(int) (template type method)

    /// <summary>Increments the object's reference count and returns the updated count.
    /// <code>Offset: 0x0058A640
    /// unsigned int __stdcall RefCountIUnknown&lt;gmCCommunicationSystem::uiChatInterfaceProvider&gt;::AddRef()</code>
    /// </summary>
    /// <returns>The new reference count after incrementing.</returns>
    // unsigned int __stdcall RefCountIUnknown<gmCCommunicationSystem::uiChatInterfaceProvider>::AddRef() (template type method)

    /// <summary>Decrements the object's reference count and destroys it when the count reaches zero.
    /// <code>Offset: 0x0058A650
    /// unsigned int __stdcall RefCountIUnknown&lt;gmCCommunicationSystem::uiChatInterfaceProvider&gt;::Release()</code>
    /// </summary>
    /// <returns>The new reference count after the release operation.</returns>
    // unsigned int __stdcall RefCountIUnknown<gmCCommunicationSystem::uiChatInterfaceProvider>::Release() (template type method)

    /// <summary>Increments the object's internal reference counter and returns the updated value.
    /// <code>Offset: 0x006C0700
    /// LONG __stdcall RefCountIUnknown&lt;gmCCommunicationSystem::uiChatInterfaceProvider&gt;::AddRef(int)</code>
    /// </summary>
    /// <param name="a1">Pointer to the RefCountIUnknown instance whose reference count is increased.</param>
    /// <returns>The new reference count after incrementing.</returns>
    // LONG __stdcall RefCountIUnknown<gmCCommunicationSystem::uiChatInterfaceProvider>::AddRef(int) (template type method)
}

