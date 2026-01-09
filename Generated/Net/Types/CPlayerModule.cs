namespace ACBindings;

// CPlayerModule
public unsafe struct CPlayerModule : System.IDisposable
{
    // Base Classes
    public ACBindings.Interface BaseClass_Interface; // ACBindings.Interface
    public ACBindings.PlayerModule BaseClass_PlayerModule; // ACBindings.PlayerModule

    // Child Types
    // CPlayerModule_vtbl
    public unsafe struct CPlayerModule_vtbl
    {
        // Members
        public System.IntPtr IUnknown_QueryInterface; // function pointer
        public System.IntPtr IUnknown_AddRef; // function pointer
        public System.IntPtr IUnknown_Release; // function pointer
        public System.IntPtr QueryInterface; // function pointer
        public System.IntPtr AddRef; // function pointer
        public System.IntPtr Release; // function pointer
        public System.IntPtr You_Must_Not_Have_Multiple_Implementations_Of_AddRef_In_A_Hierarchy; // function pointer

        // Methods
    }
    // CPlayerModule::Enum3
    public enum Enum3 : uint
    {
    }
    // CPlayerModule::Enum4
    public enum Enum4 : uint
    {
    }
    // CPlayerModule::Enum5
    public enum Enum5 : uint
    {
    }
    // CPlayerModule::Enum6
    public enum Enum6 : uint
    {
    }
    // CPlayerModule::Enum7
    public enum Enum7 : uint
    {
    }

    // Members
    public byte m_bDirty;
    public double m_timeFirstDirtied;

    // Generated Constructor
    public CPlayerModule() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall CPlayerModule::~CPlayerModule(CPlayerModule*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerModule, void>)0x0059B5E0)(ref this);
    // bool __thiscall CPlayerModule::IsAutoSaveOption(CPlayerModule*,PlayerOption)
    public byte IsAutoSaveOption(ACBindings.PlayerOption i_po) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerModule, ACBindings.PlayerOption, byte>)0x0059B600)(ref this, i_po);
    // void __thiscall CPlayerModule::SaveToServer(CPlayerModule*,bool)
    public void SaveToServer(byte i_bForceUpdate) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerModule, byte, void>)0x0059B670)(ref this, i_bForceUpdate);
    // void __thiscall CPlayerModule::OnInitialize(CPlayerModule*)
    public void OnInitialize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerModule, void>)0x0059B6A0)(ref this);
    // void __thiscall CPlayerModule::UseTime(CPlayerModule*)
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerModule, void>)0x0059B720)(ref this);
    // void __thiscall CPlayerModule::CPlayerModule(CPlayerModule*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerModule, void>)0x0059B760)(ref this);
    // TResult* __thiscall CPlayerModule::QueryInterface(CPlayerModule*,TResult*,const Turbine_GUID*,void**)
    public ACBindings.TResult* QueryInterface(ACBindings.TResult* result, ACBindings.Turbine_GUID* i_rcInterface, void** o_ppvInterface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerModule, ACBindings.TResult*, ACBindings.Turbine_GUID*, void**, ACBindings.TResult*>)0x0059B7E0)(ref this, result, i_rcInterface, o_ppvInterface);
    // void __thiscall CPlayerModule::OnChanged(CPlayerModule*,const BaseProperty*,unsigned int)
    public void OnChanged(ACBindings.BaseProperty* i_prop, uint i_nUserData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerModule, ACBindings.BaseProperty*, uint, void>)0x0059B8A0)(ref this, i_prop, i_nUserData);
    // void __thiscall CPlayerModule::OnChanged(CPlayerModule*,PlayerOption)
    public void OnChanged(ACBindings.PlayerOption i_po) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPlayerModule, ACBindings.PlayerOption, void>)0x0059B8F0)(ref this, i_po);
}

