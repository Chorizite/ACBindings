namespace ACBindings;

// ClassFactoryForceUIFlow_ClassType
public unsafe struct ClassFactoryForceUIFlow_ClassType
{
    // Base Classes
    public ACBindings.IObjectFactory BaseClass_IObjectFactory; // ACBindings.IObjectFactory

    // Child Types
    // ClassFactoryForceUIFlow_ClassType_vtbl
    public unsafe struct ClassFactoryForceUIFlow_ClassType_vtbl
    {
        // Members
        public System.IntPtr IUnknown_QueryInterface; // function pointer
        public System.IntPtr IUnknown_AddRef; // function pointer
        public System.IntPtr IUnknown_Release; // function pointer
        public System.IntPtr QueryInterface; // function pointer
        public System.IntPtr AddRef; // function pointer
        public System.IntPtr Release; // function pointer
        public System.IntPtr CreateInstance; // function pointer
        public System.IntPtr You_Must_Not_Have_Multiple_Implementations_Of_AddRef_In_A_Hierarchy; // function pointer

        // Methods
    }
    // ClassFactoryForceUIFlow_ClassType::Enum20
    public enum Enum20 : uint
    {
    }
    // ClassFactoryForceUIFlow_ClassType::Enum21
    public enum Enum21 : uint
    {
    }
    // ClassFactoryForceUIFlow_ClassType::Enum5
    public enum Enum5 : uint
    {
    }
    // ClassFactoryForceUIFlow_ClassType::Enum7
    public enum Enum7 : uint
    {
    }

    // Members
    public ACBindings.Turbine_RefCount m_cTurbineRefCount;

    // Methods
    // TResult* __thiscall ClassFactoryForceUIFlow_ClassType::QueryInterface(ClassFactoryForceUIFlow_ClassType*,TResult*,const Turbine_GUID*,void**)
    public ACBindings.TResult* QueryInterface(ACBindings.TResult* result, ACBindings.Turbine_GUID* rInterfaceType, void** ppOutInterface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClassFactoryForceUIFlow_ClassType, ACBindings.TResult*, ACBindings.Turbine_GUID*, void**, ACBindings.TResult*>)0x0047AE30)(ref this, result, rInterfaceType, ppOutInterface);
    // TResult* __thiscall ClassFactoryForceUIFlow_ClassType::CreateInstance(ClassFactoryForceUIFlow_ClassType*,TResult*,Interface*,const Turbine_GUID*,void**)
    public ACBindings.TResult* CreateInstance(ACBindings.TResult* result, ACBindings.Interface* pOuterInterface, ACBindings.Turbine_GUID* rInterfaceType, void** ppvObject) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClassFactoryForceUIFlow_ClassType, ACBindings.TResult*, ACBindings.Interface*, ACBindings.Turbine_GUID*, void**, ACBindings.TResult*>)0x0047AEC0)(ref this, result, pOuterInterface, rInterfaceType, ppvObject);
}

