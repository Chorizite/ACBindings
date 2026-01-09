namespace ACBindings;

// ClassFactoryPlugin<CObjectMaint>
public unsafe struct ClassFactoryPlugin__CObjectMaint
{
    // Base Classes
    public ACBindings.IObjectFactory BaseClass_IObjectFactory; // ACBindings.IObjectFactory

    // Child Types
    // ClassFactoryPlugin_vtbl<CObjectMaint>
    public unsafe struct ClassFactoryPlugin_vtbl__CObjectMaint
    {
        // Members
        public System.IntPtr IUnknown_QueryInterface; // function pointer
        public System.IntPtr IUnknown_AddRef; // function pointer
        public System.IntPtr IUnknown_Release; // function pointer
        public System.IntPtr QueryInterface; // function pointer
        public System.IntPtr AddRef; // function pointer
        public System.IntPtr Release; // function pointer
        public System.IntPtr CreateInstance; // function pointer
        public System.IntPtr You_Must_Not_Have_Multiple_Implementations_Of_AddRef_In_A_Hierarchy;

        // Methods
    }
    // ClassFactoryPlugin_vtbl<ClientObjMaintSystem>
    public unsafe struct ClassFactoryPlugin_vtbl__ClientObjMaintSystem
    {
        // Members
        public System.IntPtr IUnknown_QueryInterface; // function pointer
        public System.IntPtr IUnknown_AddRef; // function pointer
        public System.IntPtr IUnknown_Release; // function pointer
        public System.IntPtr QueryInterface; // function pointer
        public System.IntPtr AddRef; // function pointer
        public System.IntPtr Release; // function pointer
        public System.IntPtr CreateInstance; // function pointer
        public System.IntPtr You_Must_Not_Have_Multiple_Implementations_Of_AddRef_In_A_Hierarchy;

        // Methods
    }
    // ClassFactoryPlugin<CObjectMaint>::Enum3
    public enum Enum3 : uint
    {
    }

    // Members
    public ACBindings.Turbine_RefCount m_cTurbineRefCount;

    // Methods
}

// ClassFactoryPlugin<ClientObjMaintSystem>
public unsafe struct ClassFactoryPlugin__ClientObjMaintSystem
{
    // Base Classes
    public ACBindings.IObjectFactory BaseClass_IObjectFactory; // ACBindings.IObjectFactory

    // Child Types
    // ClassFactoryPlugin<ClientObjMaintSystem>::Enum3
    public enum Enum3 : uint
    {
    }

    // Members
    public ACBindings.Turbine_RefCount m_cTurbineRefCount;

    // Methods
    // ClassFactoryPlugin<ClientObjMaintSystem>::QueryInterface (template type method)
    // ClassFactoryPlugin<ClientObjMaintSystem>::Release (template type method)
    // ClassFactoryPlugin<ClientObjMaintSystem>::CreateInstance (template type method)
}

