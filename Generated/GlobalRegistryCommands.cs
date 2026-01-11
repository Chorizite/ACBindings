namespace ACBindings.Internal;

public unsafe struct GlobalRegistryCommands : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.Interface BaseClass_Interface; // ACBindings.Internal.Interface

    // Child Types
    public unsafe struct GlobalRegistryCommands_vtbl
    {
        // Members
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, ACBindings.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*> QueryInterface; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> AddRef; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> Release; // function pointer

        // Methods
    }

    // Generated Constructor
    public GlobalRegistryCommands() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// Attempts to locate an interface implementation matching a specified GUID within the global registry and provides the interface pointer via an output parameter. On success, sets result->m_val to 0; otherwise sets it to –2147467262.
    /// 
    /// <code>Offset: 0x00432990
    /// TResult* __thiscall GlobalRegistryCommands::QueryInterface(GlobalRegistryCommands*,TResult*,const Turbine_GUID*,void**)</code>
    /// </summary>
    /// <param name="result">Pointer to a TResult object used for status reporting.</param>
    /// <param name="i_rcInterface">GUID identifying the desired interface.</param>
    /// <param name="o_ppvInterface">Output parameter that receives the requested interface pointer if found.</param>
    /// <returns>Returns the same TResult pointer passed in, with its m_val field set to indicate success or failure.</returns>
    public ACBindings.Internal.TResult* QueryInterface(ACBindings.Internal.TResult* result, ACBindings.Internal.Turbine_GUID* i_rcInterface, void** o_ppvInterface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GlobalRegistryCommands, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*>)0x00432990)(ref this, result, i_rcInterface, o_ppvInterface);

    /// <summary>
    /// Unregisters all previously registered GlobalRegistry commands (Toggle, Set, Dump, Help, ListObjects, ListCommands) when the GlobalRegistryCommands instance is destroyed.
    /// 
    /// <code>Offset: 0x004332E0
    /// void __thiscall GlobalRegistryCommands::~GlobalRegistryCommands(GlobalRegistryCommands*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GlobalRegistryCommands, void>)0x004332E0)(ref this);

    /// <summary>Initializes the global registry command interface, registers core console commands, and displays a startup message.
    /// <code>Offset: 0x00434E60
    /// void __thiscall GlobalRegistryCommands::GlobalRegistryCommands(GlobalRegistryCommands*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GlobalRegistryCommands, void>)0x00434E60)(ref this);
}

