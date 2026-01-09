namespace ACBindings;

// IQueuedUIEventDeliverer
public unsafe struct IQueuedUIEventDeliverer
{
    // Base Classes
    public ACBindings.Interface BaseClass_Interface; // ACBindings.Interface

    // Statics
    public static ACBindings.IQueuedUIEventDeliverer* s_pInstance = (ACBindings.IQueuedUIEventDeliverer*)0x00842454;

    // Child Types
    // IQueuedUIEventDeliverer_vtbl
    public unsafe struct IQueuedUIEventDeliverer_vtbl
    {
        // Members
        public System.IntPtr IUnknown_QueryInterface; // function pointer
        public System.IntPtr IUnknown_AddRef; // function pointer
        public System.IntPtr IUnknown_Release; // function pointer
        public System.IntPtr QueryInterface; // function pointer
        public System.IntPtr AddRef; // function pointer
        public System.IntPtr Release; // function pointer
        public System.IntPtr OnStartup; // function pointer
        public System.IntPtr OnShutdown; // function pointer
        public System.IntPtr UseTime; // function pointer
        public System.IntPtr ProcessOrderedNetBlob; // function pointer
        public System.IntPtr ProcessEphemeralNetBlob; // function pointer
        public System.IntPtr ResetDeliverySystem; // function pointer

        // Methods
    }

    // Methods
    // void __thiscall IQueuedUIEventDeliverer::OnShutdown(IQueuedUIEventDeliverer*)
    public void OnShutdown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.IQueuedUIEventDeliverer, void>)0x004FD160)(ref this);
}

