namespace ACBindings.Internal;

public unsafe struct CPlayerModule : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.Interface BaseClass_Interface; // ACBindings.Internal.Interface
    public ACBindings.Internal.PlayerModule BaseClass_PlayerModule; // ACBindings.Internal.PlayerModule

    // Child Types
    public unsafe struct CPlayerModule_vtbl
    {
        // Members
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, ACBindings.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*> QueryInterface; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> AddRef; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> Release; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CPlayerModule*, ACBindings.Internal.CPlayerModule.Enum3> You_Must_Not_Have_Multiple_Implementations_Of_AddRef_In_A_Hierarchy; // function pointer

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

    /// <summary>
    /// <code>Offset: 0x0059B5E0
    /// void __thiscall CPlayerModule::~CPlayerModule(CPlayerModule*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerModule, void>)0x0059B5E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0059B600
    /// bool __thiscall CPlayerModule::IsAutoSaveOption(CPlayerModule*,PlayerOption)</code>
    /// </summary>
    public byte IsAutoSaveOption(ACBindings.Internal.PlayerOption i_po) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerModule, ACBindings.Internal.PlayerOption, byte>)0x0059B600)(ref this, i_po);

    /// <summary>
    /// <code>Offset: 0x0059B670
    /// void __thiscall CPlayerModule::SaveToServer(CPlayerModule*,bool)</code>
    /// </summary>
    public void SaveToServer(byte i_bForceUpdate) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerModule, byte, void>)0x0059B670)(ref this, i_bForceUpdate);

    /// <summary>
    /// <code>Offset: 0x0059B6A0
    /// void __thiscall CPlayerModule::OnInitialize(CPlayerModule*)</code>
    /// </summary>
    public void OnInitialize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerModule, void>)0x0059B6A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0059B720
    /// void __thiscall CPlayerModule::UseTime(CPlayerModule*)</code>
    /// </summary>
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerModule, void>)0x0059B720)(ref this);

    /// <summary>
    /// <code>Offset: 0x0059B760
    /// void __thiscall CPlayerModule::CPlayerModule(CPlayerModule*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerModule, void>)0x0059B760)(ref this);

    /// <summary>
    /// <code>Offset: 0x0059B7E0
    /// TResult* __thiscall CPlayerModule::QueryInterface(CPlayerModule*,TResult*,const Turbine_GUID*,void**)</code>
    /// </summary>
    public ACBindings.Internal.TResult* QueryInterface(ACBindings.Internal.TResult* result, ACBindings.Internal.Turbine_GUID* i_rcInterface, void** o_ppvInterface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerModule, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*>)0x0059B7E0)(ref this, result, i_rcInterface, o_ppvInterface);

    /// <summary>
    /// <code>Offset: 0x0059B8A0
    /// void __thiscall CPlayerModule::OnChanged(CPlayerModule*,const BaseProperty*,unsigned int)</code>
    /// </summary>
    public void OnChanged(ACBindings.Internal.BaseProperty* i_prop, uint i_nUserData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerModule, ACBindings.Internal.BaseProperty*, uint, void>)0x0059B8A0)(ref this, i_prop, i_nUserData);

    /// <summary>
    /// <code>Offset: 0x0059B8F0
    /// void __thiscall CPlayerModule::OnChanged(CPlayerModule*,PlayerOption)</code>
    /// </summary>
    public void OnChanged(ACBindings.Internal.PlayerOption i_po) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerModule, ACBindings.Internal.PlayerOption, void>)0x0059B8F0)(ref this, i_po);
}

