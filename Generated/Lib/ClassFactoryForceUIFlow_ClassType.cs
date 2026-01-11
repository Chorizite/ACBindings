namespace ACBindings.Internal;

public unsafe struct ClassFactoryForceUIFlow_ClassType
{
    // Base Classes
    public ACBindings.Internal.IObjectFactory BaseClass_IObjectFactory; // ACBindings.Internal.IObjectFactory

    // Child Types
    public unsafe struct ClassFactoryForceUIFlow_ClassType_vtbl
    {
        // Members
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, ACBindings.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*> QueryInterface; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> AddRef; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> Release; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IObjectFactory*, ACBindings.Internal.TResult*, ACBindings.Internal.Interface*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*> CreateInstance; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ClassFactoryForceUIFlow_ClassType*, ACBindings.Internal.ClassFactoryForceUIFlow_ClassType.Enum20> You_Must_Not_Have_Multiple_Implementations_Of_AddRef_In_A_Hierarchy; // function pointer

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
    public ACBindings.Internal.Turbine_RefCount m_cTurbineRefCount;

    // Methods

    /// <summary>
    /// <code>Offset: 0x0047AE30
    /// TResult* __thiscall ClassFactoryForceUIFlow_ClassType::QueryInterface(ClassFactoryForceUIFlow_ClassType*,TResult*,const Turbine_GUID*,void**)</code>
    /// </summary>
    public ACBindings.Internal.TResult* QueryInterface(ACBindings.Internal.TResult* result, ACBindings.Internal.Turbine_GUID* rInterfaceType, void** ppOutInterface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClassFactoryForceUIFlow_ClassType, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*>)0x0047AE30)(ref this, result, rInterfaceType, ppOutInterface);

    /// <summary>
    /// <code>Offset: 0x0047AEC0
    /// TResult* __thiscall ClassFactoryForceUIFlow_ClassType::CreateInstance(ClassFactoryForceUIFlow_ClassType*,TResult*,Interface*,const Turbine_GUID*,void**)</code>
    /// </summary>
    public ACBindings.Internal.TResult* CreateInstance(ACBindings.Internal.TResult* result, ACBindings.Internal.Interface* pOuterInterface, ACBindings.Internal.Turbine_GUID* rInterfaceType, void** ppvObject) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClassFactoryForceUIFlow_ClassType, ACBindings.Internal.TResult*, ACBindings.Internal.Interface*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*>)0x0047AEC0)(ref this, result, pOuterInterface, rInterfaceType, ppvObject);
}

