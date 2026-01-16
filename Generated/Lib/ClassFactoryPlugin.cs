namespace ACBindings.Internal;

public unsafe struct ClassFactoryPlugin___CObjectMaint
{
    // Base Classes
    public ACBindings.Internal.IObjectFactory BaseClass_IObjectFactory; // ACBindings.Internal.IObjectFactory

    // Child Types
    public unsafe struct ClassFactoryPlugin_vtbl___CObjectMaint
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, ACBindings.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*> QueryInterface; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.IObjectFactory*, ACBindings.Internal.TResult*, ACBindings.Internal.Interface*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*> CreateInstance; // function pointer
        public System.IntPtr You_Must_Not_Have_Multiple_Implementations_Of_AddRef_In_A_Hierarchy;

        // Methods
    }
    public unsafe struct ClassFactoryPlugin_vtbl___ClientObjMaintSystem
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, ACBindings.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*> QueryInterface; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.IObjectFactory*, ACBindings.Internal.TResult*, ACBindings.Internal.Interface*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*> CreateInstance; // function pointer
        public System.IntPtr You_Must_Not_Have_Multiple_Implementations_Of_AddRef_In_A_Hierarchy;

        // Methods
    }
    // ClassFactoryPlugin<CObjectMaint>::Enum3
    public enum Enum3 : uint
    {
    }

    // Members
    public ACBindings.Internal.Turbine_RefCount m_cTurbineRefCount;

    // Methods
}

public unsafe struct ClassFactoryPlugin___ClientObjMaintSystem
{
    // Base Classes
    public ACBindings.Internal.IObjectFactory BaseClass_IObjectFactory; // ACBindings.Internal.IObjectFactory

    // Child Types
    // ClassFactoryPlugin<ClientObjMaintSystem>::Enum3
    public enum Enum3 : uint
    {
    }

    // Members
    public ACBindings.Internal.Turbine_RefCount m_cTurbineRefCount;

    // Methods

    /// <summary>Attempts to retrieve an interface from the class factory by matching the requested interface identifier.
    /// <code>Offset: 0x00558020
    /// _DWORD* __thiscall ClassFactoryPlugin&lt;ClientObjMaintSystem&gt;::QueryInterface(void*,_DWORD*,_DWORD*,_DWORD*)</code>
    /// </summary>
    /// <param name="this">Pointer to the current ClassFactoryPlugin instance.</param>
    /// <param name="a2">Output parameter that receives the result code; set to 0 on success or E_NOINTERFACE (-2147467262) on failure.</param>
    /// <param name="a3">Array of four DWORDs describing the desired interface identifier to query.</param>
    /// <param name="a4">When successful, receives a pointer to the requested interface object.</param>
    /// <returns>Pointer to the result code parameter (a2) after processing.</returns>
    // _DWORD* __thiscall ClassFactoryPlugin<ClientObjMaintSystem>::QueryInterface(void*,_DWORD*,_DWORD*,_DWORD*) (template type method)

    /// <summary>Decrements the object's reference count and frees the instance when the count reaches zero.
    /// <code>Offset: 0x005580B0
    /// LONG __thiscall ClassFactoryPlugin&lt;ClientObjMaintSystem&gt;::Release(volatile LONG*)</code>
    /// </summary>
    /// <returns>The current reference count after decrementing; a return value of 0 means the object was destroyed.</returns>
    // LONG __thiscall ClassFactoryPlugin<ClientObjMaintSystem>::Release(volatile LONG*) (template type method)

    /// <summary>Creates a ClientObjMaintSystem instance, initializing it with supplied flags and optionally retrieving an auxiliary interface.
    /// <code>Offset: 0x005580E0
    /// _DWORD* __stdcall ClassFactoryPlugin&lt;ClientObjMaintSystem&gt;::CreateInstance(_DWORD*,int,int,_DWORD*)</code>
    /// </summary>
    /// <param name="a1">Output parameter that receives the result of initialization; on success contains the value written by the object's init routine, otherwise holds one of two error codes (-2147221232 when the reserved argument is non‑zero, or -2147467261 when the optional interface pointer is null).</param>
    /// <param name="a2">Must be zero; the function uses it internally as an output slot for the initialization routine and will fail immediately if a non‑zero value is passed.</param>
    /// <param name="a3">Integer configuration flags forwarded to the object's initialization method.</param>
    /// <param name="a4">Optional pointer that, on success, receives an auxiliary interface from the created object; must not be null, otherwise creation fails with error -2147467261.</param>
    /// <returns>Returns the same pointer supplied in a1; callers typically read the value written to *a1 instead of using the return value.</returns>
    // _DWORD* __stdcall ClassFactoryPlugin<ClientObjMaintSystem>::CreateInstance(_DWORD*,int,int,_DWORD*) (template type method)
}

