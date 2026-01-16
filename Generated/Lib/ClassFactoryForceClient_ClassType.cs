namespace ACBindings.Internal;


/// <summary>
/// Provides a reference‑counted factory for creating ForceClient instances via COM‑style interfaces.
/// Implements IObjectFactory and exposes QueryInterface, CreateInstance, Release to manage lifetime and aggregation.
/// </summary>
public unsafe struct ClassFactoryForceClient_ClassType
{
    // Base Classes
    public ACBindings.Internal.IObjectFactory BaseClass_IObjectFactory; // ACBindings.Internal.IObjectFactory

    // Child Types
    public unsafe struct ClassFactoryForceClient_ClassType_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, ACBindings.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*> QueryInterface; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.IObjectFactory*, ACBindings.Internal.TResult*, ACBindings.Internal.Interface*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*> CreateInstance; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClassFactoryForceClient_ClassType*, ACBindings.Internal.ClassFactoryForceClient_ClassType.Enum19> You_Must_Not_Have_Multiple_Implementations_Of_AddRef_In_A_Hierarchy; // function pointer

        // Methods
    }
    // ClassFactoryForceClient_ClassType::Enum19
    public enum Enum19 : uint
    {
    }

    // Members
    public ACBindings.Internal.Turbine_RefCount m_cTurbineRefCount;

    // Methods

    /// <summary>Attempts to obtain a requested interface from this object, incrementing its reference count on success.
    /// <code>Offset: 0x00402590
    /// TResult* __thiscall ClassFactoryForceClient_ClassType::QueryInterface(ClassFactoryForceClient_ClassType*,TResult*,const Turbine_GUID*,void**)</code>
    /// </summary>
    /// <param name="this">The ClassFactoryForceClient_ClassType instance requesting the interface.</param>
    /// <param name="result">Pointer to a TResult structure where the HRESULT is stored.</param>
    /// <param name="rInterfaceType">GUID identifying the desired interface type.</param>
    /// <param name="ppOutInterface">Receives the pointer to the requested interface on success.</param>
    /// <returns>Returns the result parameter containing 0 for success or an error code if the interface is unsupported.</returns>
    public ACBindings.Internal.TResult* QueryInterface(ACBindings.Internal.TResult* result, ACBindings.Internal.Turbine_GUID* rInterfaceType, void** ppOutInterface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClassFactoryForceClient_ClassType, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*>)0x00402590)(ref this, result, rInterfaceType, ppOutInterface);

    /// <summary>Releases a reference to the object by decrementing its reference count; deletes the object when the count reaches zero.
    /// <code>Offset: 0x004027D0
    /// unsigned int __thiscall ClassFactoryForceClient_ClassType::Release(ClassFactoryForceUIFlow_ClassType*)</code>
    /// </summary>
    /// <returns>The remaining reference count after release, or 0 if the object was deleted.</returns>
    public uint Release() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClassFactoryForceClient_ClassType, uint>)0x004027D0)(ref this);

    /// <summary>Create an instance of the specified interface type via this factory, returning a status code through the provided TResult object and placing the created interface pointer into ppvObject on success.
    /// <code>Offset: 0x00403600
    /// TResult* __thiscall ClassFactoryForceClient_ClassType::CreateInstance(ClassFactoryForceClient_ClassType*,TResult*,Interface*,const Turbine_GUID*,void**)</code>
    /// </summary>
    /// <param name="this">The ClassFactoryForceClient_ClassType instance used to create objects.</param>
    /// <param name="result">Pointer to a TResult structure that receives the operation status code.</param>
    /// <param name="pOuterInterface">If non‑null, aggregation is attempted; the function fails with an error indicating aggregation not supported.</param>
    /// <param name="rInterfaceType">GUID of the interface requested for the new instance.</param>
    /// <param name="ppvObject">Output pointer that receives the created interface object on success.</param>
    /// <returns>Always returns the same TResult* passed in; callers should examine result->m_val for the operation outcome.</returns>
    public ACBindings.Internal.TResult* CreateInstance(ACBindings.Internal.TResult* result, ACBindings.Internal.Interface* pOuterInterface, ACBindings.Internal.Turbine_GUID* rInterfaceType, void** ppvObject) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClassFactoryForceClient_ClassType, ACBindings.Internal.TResult*, ACBindings.Internal.Interface*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*>)0x00403600)(ref this, result, pOuterInterface, rInterfaceType, ppvObject);
}

