namespace ACBindings.Internal;

public unsafe struct InterfaceSystem : System.IDisposable
{
    // Members
    public ACBindings.Internal.AutoGrowHashTable___Turbine_GUID___Interface_ptr m_classTable;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Obtains an interface instance for a class identified by its GUID from the system's hash table, incrementing the reference count and reporting status via the supplied TResult structure.
    /// <code>Offset: 0x00406570
    /// TResult* __thiscall InterfaceSystem::GetClass(InterfaceSystem*,TResult*,const Turbine_GUID*,Interface**)</code>
    /// </summary>
    /// <param name="result">Pointer to a TResult object that receives the operation status; on success m_val is set to 0.</param>
    /// <param name="rClassType">GUID of the class type to look up in the hash table.</param>
    /// <param name="rpInterface">Output pointer that receives the found Interface*; remains null if no matching entry exists.</param>
    /// <returns>Pointer to the supplied TResult structure.</returns>
    public ACBindings.Internal.TResult* GetClass(ACBindings.Internal.TResult* result, ACBindings.Internal.Turbine_GUID* rClassType, ACBindings.Internal.Interface** rpInterface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InterfaceSystem, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, ACBindings.Internal.Interface**, ACBindings.Internal.TResult*>)0x00406570)(ref this, result, rClassType, rpInterface);

    /// <summary>Retrieves a registered class instance by its GUID and verifies it implements the specified interface type, returning success or an error code.
    /// <code>Offset: 0x004065D0
    /// TResult* __thiscall InterfaceSystem::GetClass(InterfaceSystem*,TResult*,const Turbine_GUID*,Interface*,void**)</code>
    /// </summary>
    /// <param name="result">Container for the operation's HRESULT-like status code.</param>
    /// <param name="rClassType">GUID of the desired class to locate in the system.</param>
    /// <param name="rInterfaceType">Interface type that the located class must support.</param>
    /// <param name="ppOutInterface">Receives a pointer to the interface instance when the lookup succeeds.</param>
    /// <returns>Pointer to the result object, whose m_val member indicates success (0) or an error code such as CLASS_NOT_FOUND (-2147221164) or TYPE_MISMATCH (-2147467262).</returns>
    public ACBindings.Internal.TResult* GetClass(ACBindings.Internal.TResult* result, ACBindings.Internal.Turbine_GUID* rClassType, ACBindings.Internal.Interface* rInterfaceType, void** ppOutInterface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InterfaceSystem, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, ACBindings.Internal.Interface*, void**, ACBindings.Internal.TResult*>)0x004065D0)(ref this, result, rClassType, rInterfaceType, ppOutInterface);

    /// <summary>Creates an instance of a class identified by the supplied GUID using the system's factory registry, returning a status code and optionally providing the new instance pointer.
    /// <code>Offset: 0x00406650
    /// TResult* __thiscall InterfaceSystem::CreateInstance(InterfaceSystem*,TResult*,Turbine_GUID*,Interface*,Interface*,void**)</code>
    /// </summary>
    /// <param name="result">Output parameter to receive the operation result status.</param>
    /// <param name="rClassType">GUID specifying the class type to instantiate.</param>
    /// <param name="rInterfaceType">Expected interface type for the newly created object.</param>
    /// <param name="pOuterInterface">Optional outer interface used during creation.</param>
    /// <param name="ppNewInstance">Out parameter that receives a pointer to the created instance on success.</param>
    /// <returns>Pointer to the result structure containing the status code of the operation.</returns>
    public ACBindings.Internal.TResult* CreateInstance(ACBindings.Internal.TResult* result, ACBindings.Internal.Turbine_GUID* rClassType, ACBindings.Internal.Interface* rInterfaceType, ACBindings.Internal.Interface* pOuterInterface, void** ppNewInstance) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InterfaceSystem, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, ACBindings.Internal.Interface*, ACBindings.Internal.Interface*, void**, ACBindings.Internal.TResult*>)0x00406650)(ref this, result, rClassType, rInterfaceType, pOuterInterface, ppNewInstance);

    /// <summary>Registers an Interface instance for a specified class GUID in the system's class table, optionally returning any previously registered object and updating its reference count.
    /// <code>Offset: 0x00406A90
    /// TResult* __thiscall InterfaceSystem::RegisterClassA(InterfaceSystem*,TResult*,const Turbine_GUID*,Interface*,Interface**)</code>
    /// </summary>
    /// <param name="result">Structure to receive the operation status; on success its m_val is set to 0, otherwise it contains an error code (e.g., -2147467259).</param>
    /// <param name="rClassType">GUID identifying the class type being registered.</param>
    /// <param name="pClassObject">Interface instance to register; must not be null or registration fails.</param>
    /// <param name="ppOldClassObject">Optional pointer that receives the previously registered Interface for this GUID, if any; may be NULL.</param>
    /// <returns>Pointer to the result structure passed in.</returns>
    public ACBindings.Internal.TResult* RegisterClassA(ACBindings.Internal.TResult* result, ACBindings.Internal.Turbine_GUID* rClassType, ACBindings.Internal.Interface* pClassObject, ACBindings.Internal.Interface** ppOldClassObject) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InterfaceSystem, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, ACBindings.Internal.Interface*, ACBindings.Internal.Interface**, ACBindings.Internal.TResult*>)0x00406A90)(ref this, result, rClassType, pClassObject, ppOldClassObject);

    /// <summary>Destroys all registered interfaces and releases their resources, then clears and deallocates the internal hash table used for interface lookup.
    /// <code>Offset: 0x00406BF0
    /// void __thiscall InterfaceSystem::~InterfaceSystem(InterfaceSystem*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InterfaceSystem, void>)0x00406BF0)(ref this);

    /// <summary>Unregisters a class identified by its GUID from the interface system, optionally returning and releasing the previously registered interface if the supplied current object is null or matches the stored instance.
    /// <code>Offset: 0x00406C90
    /// TResult* __thiscall InterfaceSystem::UnregisterClassA(InterfaceSystem*,TResult*,const Turbine_GUID*,Interface*,Interface**)</code>
    /// </summary>
    /// <param name="result">Pointer to a TResult object used for status reporting; its m_val field is set to zero upon completion.</param>
    /// <param name="rClassType">GUID of the class to be unregistered.</param>
    /// <param name="pCurClassObject">Current interface instance; if null or equal to the registered instance, removal occurs.</param>
    /// <param name="ppOldClassObject">Receives a pointer to the previously registered interface instance, if any. The function AddRefs this object before returning it.</param>
    /// <returns>The original result pointer with its status field updated.</returns>
    public ACBindings.Internal.TResult* UnregisterClassA(ACBindings.Internal.TResult* result, ACBindings.Internal.Turbine_GUID* rClassType, ACBindings.Internal.Interface* pCurClassObject, ACBindings.Internal.Interface** ppOldClassObject) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.InterfaceSystem, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, ACBindings.Internal.Interface*, ACBindings.Internal.Interface**, ACBindings.Internal.TResult*>)0x00406C90)(ref this, result, rClassType, pCurClassObject, ppOldClassObject);

    /// <summary>Provides access to the global InterfaceSystem instance, creating it lazily on first request unless the system has been destroyed.
    /// <code>Offset: 0x00406D10
    /// InterfaceSystem* __cdecl InterfaceSystem::GetInstance()</code>
    /// </summary>
    /// <returns>A pointer to the InterfaceSystem singleton, or nullptr when the system is destroyed or instantiation fails.</returns>
    public static ACBindings.Internal.InterfaceSystem* GetInstance() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.InterfaceSystem*>)0x00406D10)();
}

