namespace ACBindings;

// ClassFactoryForceClient_ClassType
public unsafe struct ClassFactoryForceClient_ClassType
{
    // Base Classes
    public ACBindings.IObjectFactory BaseClass_IObjectFactory; // ACBindings.IObjectFactory

    // Child Types
    // ClassFactoryForceClient_ClassType_vtbl
    public unsafe struct ClassFactoryForceClient_ClassType_vtbl
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
    // ClassFactoryForceClient_ClassType::Enum19
    public enum Enum19 : uint
    {
    }

    // Members
    public ACBindings.Turbine_RefCount m_cTurbineRefCount;

    // Methods
    // TResult* __thiscall ClassFactoryForceClient_ClassType::QueryInterface(ClassFactoryForceClient_ClassType*,TResult*,const Turbine_GUID*,void**)
    public ACBindings.TResult* QueryInterface(ACBindings.TResult* result, ACBindings.Turbine_GUID* rInterfaceType, void** ppOutInterface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClassFactoryForceClient_ClassType, ACBindings.TResult*, ACBindings.Turbine_GUID*, void**, ACBindings.TResult*>)0x00402590)(ref this, result, rInterfaceType, ppOutInterface);
    // unsigned int __thiscall ClassFactoryForceClient_ClassType::Release(ClassFactoryForceUIFlow_ClassType*)
    public uint Release() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClassFactoryForceClient_ClassType, uint>)0x004027D0)(ref this);
    // TResult* __thiscall ClassFactoryForceClient_ClassType::CreateInstance(ClassFactoryForceClient_ClassType*,TResult*,Interface*,const Turbine_GUID*,void**)
    public ACBindings.TResult* CreateInstance(ACBindings.TResult* result, ACBindings.Interface* pOuterInterface, ACBindings.Turbine_GUID* rInterfaceType, void** ppvObject) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ClassFactoryForceClient_ClassType, ACBindings.TResult*, ACBindings.Interface*, ACBindings.Turbine_GUID*, void**, ACBindings.TResult*>)0x00403600)(ref this, result, pOuterInterface, rInterfaceType, ppvObject);
}

