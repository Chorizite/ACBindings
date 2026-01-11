namespace ACBindings.Internal;

public unsafe struct ClassFactoryPlugin___CObjectMaint
{
    // Base Classes
    public ACBindings.Internal.IObjectFactory BaseClass_IObjectFactory; // ACBindings.Internal.IObjectFactory

    // Child Types
    public unsafe struct ClassFactoryPlugin_vtbl___CObjectMaint
    {
        // Members
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, ACBindings.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*> QueryInterface; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> AddRef; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> Release; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IObjectFactory*, ACBindings.Internal.TResult*, ACBindings.Internal.Interface*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*> CreateInstance; // function pointer
        public System.IntPtr You_Must_Not_Have_Multiple_Implementations_Of_AddRef_In_A_Hierarchy;

        // Methods
    }
    public unsafe struct ClassFactoryPlugin_vtbl___ClientObjMaintSystem
    {
        // Members
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, ACBindings.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*> QueryInterface; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> AddRef; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> Release; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IObjectFactory*, ACBindings.Internal.TResult*, ACBindings.Internal.Interface*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*> CreateInstance; // function pointer
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

    /// <summary>
    /// <code>Offset: 0x00558020
    /// _DWORD* __thiscall ClassFactoryPlugin&lt;ClientObjMaintSystem&gt;::QueryInterface(void*,_DWORD*,_DWORD*,_DWORD*)</code>
    /// </summary>
    // _DWORD* __thiscall ClassFactoryPlugin<ClientObjMaintSystem>::QueryInterface(void*,_DWORD*,_DWORD*,_DWORD*) (template type method)

    /// <summary>
    /// <code>Offset: 0x005580B0
    /// LONG __thiscall ClassFactoryPlugin&lt;ClientObjMaintSystem&gt;::Release(volatile LONG*)</code>
    /// </summary>
    // LONG __thiscall ClassFactoryPlugin<ClientObjMaintSystem>::Release(volatile LONG*) (template type method)

    /// <summary>
    /// <code>Offset: 0x005580E0
    /// _DWORD* __stdcall ClassFactoryPlugin&lt;ClientObjMaintSystem&gt;::CreateInstance(_DWORD*,int,int,_DWORD*)</code>
    /// </summary>
    // _DWORD* __stdcall ClassFactoryPlugin<ClientObjMaintSystem>::CreateInstance(_DWORD*,int,int,_DWORD*) (template type method)
}

