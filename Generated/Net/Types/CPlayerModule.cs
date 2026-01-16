namespace ACBindings.Internal;


/// <summary>Represents a player module in the game client, combining core interface functionality with gameplay settings while tracking modification state and timestamp.</summary>
/// <remarks>Holds an Interface base class for COM‑style interaction, a PlayerModule containing option flags, a dirty flag indicating pending changes, and a high‑precision timestamp marking when the module first became dirty. Used by the engine to detect configuration changes and trigger serialization or UI updates.</remarks>
public unsafe struct CPlayerModule : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.Interface BaseClass_Interface; // ACBindings.Internal.Interface
    public ACBindings.Internal.PlayerModule BaseClass_PlayerModule; // ACBindings.Internal.PlayerModule

    // Child Types
    public unsafe struct CPlayerModule_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, ACBindings.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*> QueryInterface; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CPlayerModule*, ACBindings.Internal.CPlayerModule.Enum3> You_Must_Not_Have_Multiple_Implementations_Of_AddRef_In_A_Hierarchy; // function pointer

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

    /// <summary>Clears resources associated with a CPlayerModule instance by calling its base class destructors and ensuring the object’s vtable entries are correctly restored before destruction completes.
    /// <code>Offset: 0x0059B5E0
    /// void __thiscall CPlayerModule::~CPlayerModule(CPlayerModule*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerModule, void>)0x0059B5E0)(ref this);

    /// <summary>Evaluates whether a given player option should be automatically persisted.
    /// <code>Offset: 0x0059B600
    /// bool __thiscall CPlayerModule::IsAutoSaveOption(CPlayerModule*,PlayerOption)</code>
    /// </summary>
    /// <param name="i_po">The PlayerOption to check.</param>
    /// <returns>True if the option is marked for auto‑save; otherwise, false.</returns>
    public byte IsAutoSaveOption(ACBindings.Internal.PlayerOption i_po) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerModule, ACBindings.Internal.PlayerOption, byte>)0x0059B600)(ref this, i_po);

    /// <summary>Sends current player options to server when changes are pending or a force flag is set; then clears dirty state.
    /// <code>Offset: 0x0059B670
    /// void __thiscall CPlayerModule::SaveToServer(CPlayerModule*,bool)</code>
    /// </summary>
    /// <param name="i_bForceUpdate">If true forces an update regardless of the dirty flag.</param>
    public void SaveToServer(byte i_bForceUpdate) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerModule, byte, void>)0x0059B670)(ref this, i_bForceUpdate);

    /// <summary>Initializes the player module by clearing its dirty state, resetting the first dirtied timestamp, configuring environmental effects (fog and weather) according to persistent settings, and starting to track the current combat target.
    /// <code>Offset: 0x0059B6A0
    /// void __thiscall CPlayerModule::OnInitialize(CPlayerModule*)</code>
    /// </summary>
    public void OnInitialize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerModule, void>)0x0059B6A0)(ref this);

    /// <summary>Saves or applies pending player option changes after a 480‑second delay if the module is marked dirty.
    /// <code>Offset: 0x0059B720
    /// void __thiscall CPlayerModule::UseTime(CPlayerModule*)</code>
    /// </summary>
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerModule, void>)0x0059B720)(ref this);

    /// <summary>Constructs a CPlayerModule instance, initializing its PlayerModule and Interface base classes, clearing the dirty flag, and setting m_timeFirstDirtied to a predefined value (high word −1074790400, low word 0).
    /// <code>Offset: 0x0059B760
    /// void __thiscall CPlayerModule::CPlayerModule(CPlayerModule*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerModule, void>)0x0059B760)(ref this);

    /// <summary>Retrieves a requested interface from the player module if supported. If successful, writes the interface pointer to o_ppvInterface and sets the result value to 0; otherwise returns an error code in result.
    /// <code>Offset: 0x0059B7E0
    /// TResult* __thiscall CPlayerModule::QueryInterface(CPlayerModule*,TResult*,const Turbine_GUID*,void**)</code>
    /// </summary>
    /// <param name="i_rcInterface">GUID of the interface being queried.</param>
    /// <param name="o_ppvInterface">Receives a pointer to the requested interface on success.</param>
    /// <param name="result">Holds the status code of the operation; zero indicates success, negative values indicate failure.</param>
    /// <returns>Returns the same result pointer passed in for chaining.</returns>
    public ACBindings.Internal.TResult* QueryInterface(ACBindings.Internal.TResult* result, ACBindings.Internal.Turbine_GUID* i_rcInterface, void** o_ppvInterface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerModule, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*>)0x0059B7E0)(ref this, result, i_rcInterface, o_ppvInterface);

    /// <summary>Handles updates to player module properties by notifying the UI of gameplay option changes and marking the module as dirty with a timestamp when first modified.
    /// <code>Offset: 0x0059B8A0
    /// void __thiscall CPlayerModule::OnChanged(CPlayerModule*,const BaseProperty*,unsigned int)</code>
    /// </summary>
    /// <param name="i_prop">The property that changed.</param>
    /// <param name="i_nUserData">Additional user data associated with the change event.</param>
    public void OnChanged(ACBindings.Internal.BaseProperty* i_prop, uint i_nUserData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerModule, ACBindings.Internal.BaseProperty*, uint, void>)0x0059B8A0)(ref this, i_prop, i_nUserData);

    /// <summary>Handles updates triggered by a change to a player option. Sends UI notification, applies effect changes such as weather, day persistence, combat targeting, fellowship request handling, and fog settings, and triggers auto‑save related events when appropriate.
    /// <code>Offset: 0x0059B8F0
    /// void __thiscall CPlayerModule::OnChanged(CPlayerModule*,PlayerOption)</code>
    /// </summary>
    /// <param name="i_po">The player option that changed.</param>
    public void OnChanged(ACBindings.Internal.PlayerOption i_po) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPlayerModule, ACBindings.Internal.PlayerOption, void>)0x0059B8F0)(ref this, i_po);
}

