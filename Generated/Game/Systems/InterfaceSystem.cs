namespace ACBindings;

// InterfaceSystem
public unsafe struct InterfaceSystem : System.IDisposable
{
    // Statics
    public static ACBindings.InterfaceSystem* s_pInterfaceSystem = (ACBindings.InterfaceSystem*)0x00837740;
    public static byte* s_bInterfaceSystemDestroyed = (byte*)0x00837744;

    // Members
    public ACBindings.AutoGrowHashTable__Turbine_GUID__Interface_ptr m_classTable;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // TResult* __thiscall InterfaceSystem::GetClass(InterfaceSystem*,TResult*,const Turbine_GUID*,Interface**)
    public ACBindings.TResult* GetClass(ACBindings.TResult* result, ACBindings.Turbine_GUID* rClassType, ACBindings.Interface** rpInterface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.InterfaceSystem, ACBindings.TResult*, ACBindings.Turbine_GUID*, ACBindings.Interface**, ACBindings.TResult*>)0x00406570)(ref this, result, rClassType, rpInterface);
    // TResult* __thiscall InterfaceSystem::GetClass(InterfaceSystem*,TResult*,const Turbine_GUID*,Interface*,void**)
    public ACBindings.TResult* GetClass(ACBindings.TResult* result, ACBindings.Turbine_GUID* rClassType, ACBindings.Interface* rInterfaceType, void** ppOutInterface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.InterfaceSystem, ACBindings.TResult*, ACBindings.Turbine_GUID*, ACBindings.Interface*, void**, ACBindings.TResult*>)0x004065D0)(ref this, result, rClassType, rInterfaceType, ppOutInterface);
    // TResult* __thiscall InterfaceSystem::CreateInstance(InterfaceSystem*,TResult*,Turbine_GUID*,Interface*,Interface*,void**)
    public ACBindings.TResult* CreateInstance(ACBindings.TResult* result, ACBindings.Turbine_GUID* rClassType, ACBindings.Interface* rInterfaceType, ACBindings.Interface* pOuterInterface, void** ppNewInstance) => ((delegate* unmanaged[Thiscall]<ref ACBindings.InterfaceSystem, ACBindings.TResult*, ACBindings.Turbine_GUID*, ACBindings.Interface*, ACBindings.Interface*, void**, ACBindings.TResult*>)0x00406650)(ref this, result, rClassType, rInterfaceType, pOuterInterface, ppNewInstance);
    // TResult* __thiscall InterfaceSystem::RegisterClassA(InterfaceSystem*,TResult*,const Turbine_GUID*,Interface*,Interface**)
    public ACBindings.TResult* RegisterClassA(ACBindings.TResult* result, ACBindings.Turbine_GUID* rClassType, ACBindings.Interface* pClassObject, ACBindings.Interface** ppOldClassObject) => ((delegate* unmanaged[Thiscall]<ref ACBindings.InterfaceSystem, ACBindings.TResult*, ACBindings.Turbine_GUID*, ACBindings.Interface*, ACBindings.Interface**, ACBindings.TResult*>)0x00406A90)(ref this, result, rClassType, pClassObject, ppOldClassObject);
    // void __thiscall InterfaceSystem::~InterfaceSystem(InterfaceSystem*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.InterfaceSystem, void>)0x00406BF0)(ref this);
    // TResult* __thiscall InterfaceSystem::UnregisterClassA(InterfaceSystem*,TResult*,const Turbine_GUID*,Interface*,Interface**)
    public ACBindings.TResult* UnregisterClassA(ACBindings.TResult* result, ACBindings.Turbine_GUID* rClassType, ACBindings.Interface* pCurClassObject, ACBindings.Interface** ppOldClassObject) => ((delegate* unmanaged[Thiscall]<ref ACBindings.InterfaceSystem, ACBindings.TResult*, ACBindings.Turbine_GUID*, ACBindings.Interface*, ACBindings.Interface**, ACBindings.TResult*>)0x00406C90)(ref this, result, rClassType, pCurClassObject, ppOldClassObject);
    // InterfaceSystem* __cdecl InterfaceSystem::GetInstance()
    public static ACBindings.InterfaceSystem* GetInstance() => ((delegate* unmanaged[Cdecl]<ACBindings.InterfaceSystem*>)0x00406D10)();
}

