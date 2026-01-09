namespace ACBindings;

// RefCountInterface<GlobalRegistryCommands>
public unsafe struct RefCountInterface__GlobalRegistryCommands
{
    // Base Classes
    public ACBindings.GlobalRegistryCommands BaseClass_GlobalRegistryCommands; // ACBindings.GlobalRegistryCommands
    public ACBindings.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.ReferenceCountTemplate

    // Child Types
    // RefCountInterface_vtbl<GlobalRegistryCommands>
    public unsafe struct RefCountInterface_vtbl__GlobalRegistryCommands
    {
        // Members
        public System.IntPtr IUnknown_QueryInterface; // function pointer
        public System.IntPtr IUnknown_AddRef; // function pointer
        public System.IntPtr IUnknown_Release; // function pointer
        public System.IntPtr QueryInterface; // function pointer
        public System.IntPtr AddRef; // function pointer
        public System.IntPtr Release; // function pointer
        public System.IntPtr You_Must_Not_Have_Multiple_Implementations_Of_AddRef_In_A_Hierarchy;

        // Methods
    }
    // RefCountInterface<GlobalRegistryCommands>::Enum0
    public enum Enum0 : uint
    {
    }

    // Methods
    // RefCountInterface<GlobalRegistryCommands>::AddRef (template type method)
    // RefCountInterface<GlobalRegistryCommands>::Release (template type method)
    // RefCountInterface<GlobalRegistryCommands>::~RefCountInterface<GlobalRegistryCommands> (template type method)
}

