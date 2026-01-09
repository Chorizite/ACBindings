namespace ACBindings;

// IKeystoneResource
public unsafe struct IKeystoneResource
{
    // Base Classes
    public ACBindings.IResourceNotify BaseClass_IResourceNotify; // ACBindings.IResourceNotify

    // Child Types
    // IKeystoneResource_vtbl
    public unsafe struct IKeystoneResource_vtbl
    {
        // Members
        public System.IntPtr QueryInterface; // function pointer
        public System.IntPtr AddRef; // function pointer
        public System.IntPtr Release; // function pointer
        public System.IntPtr NotifyResourceStatus; // function pointer
        public System.IntPtr GetName; // function pointer
        public System.IntPtr GetType; // function pointer
        public System.IntPtr DecodeData; // function pointer
        public System.IntPtr AddOwner; // function pointer
        public System.IntPtr RemoveOwner; // function pointer
        public System.IntPtr SetStatus; // function pointer
        public System.IntPtr GetStatus; // function pointer

        // Methods
    }

    // Methods
}

