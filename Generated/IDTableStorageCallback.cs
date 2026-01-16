namespace ACBindings.Internal;


/// <summary>Enables polymorphic callbacks in ID table storage by holding a pointer to the virtual function table.</summary>
public unsafe struct IDTableStorageCallback
{
    // Child Types
    public unsafe struct IDTableStorageCallback_vtbl
    {
        // Members
        public System.IntPtr ProcessTypeData;
        public System.IntPtr ProcessMapping;

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer

    // Methods
}

