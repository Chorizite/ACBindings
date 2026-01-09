namespace ACBindings;

// GlobalRegistryCommands
public unsafe struct GlobalRegistryCommands : System.IDisposable
{
    // Base Classes
    public ACBindings.Interface BaseClass_Interface; // ACBindings.Interface

    // Child Types
    // GlobalRegistryCommands_vtbl
    public unsafe struct GlobalRegistryCommands_vtbl
    {
        // Members
        public System.IntPtr IUnknown_QueryInterface; // function pointer
        public System.IntPtr IUnknown_AddRef; // function pointer
        public System.IntPtr IUnknown_Release; // function pointer
        public System.IntPtr QueryInterface; // function pointer
        public System.IntPtr AddRef; // function pointer
        public System.IntPtr Release; // function pointer

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
    // TResult* __thiscall GlobalRegistryCommands::QueryInterface(GlobalRegistryCommands*,TResult*,const Turbine_GUID*,void**)
    public ACBindings.TResult* QueryInterface(ACBindings.TResult* result, ACBindings.Turbine_GUID* i_rcInterface, void** o_ppvInterface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.GlobalRegistryCommands, ACBindings.TResult*, ACBindings.Turbine_GUID*, void**, ACBindings.TResult*>)0x00432990)(ref this, result, i_rcInterface, o_ppvInterface);
    // void __thiscall GlobalRegistryCommands::~GlobalRegistryCommands(GlobalRegistryCommands*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.GlobalRegistryCommands, void>)0x004332E0)(ref this);
    // void __thiscall GlobalRegistryCommands::GlobalRegistryCommands(GlobalRegistryCommands*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.GlobalRegistryCommands, void>)0x00434E60)(ref this);
}

