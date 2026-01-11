namespace ACBindings.Internal;

public unsafe struct IQueuedUIEventDeliverer
{
    // Base Classes
    public ACBindings.Internal.Interface BaseClass_Interface; // ACBindings.Internal.Interface

    // Statics
    public static ACBindings.Internal.IQueuedUIEventDeliverer* s_pInstance = (ACBindings.Internal.IQueuedUIEventDeliverer*)0x00842454;

    // Child Types
    public unsafe struct IQueuedUIEventDeliverer_vtbl
    {
        // Members
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, ACBindings.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*> QueryInterface; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> AddRef; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> Release; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IQueuedUIEventDeliverer*, void> OnStartup; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IQueuedUIEventDeliverer*, void> OnShutdown; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IQueuedUIEventDeliverer*, void> UseTime; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IQueuedUIEventDeliverer*, ACBindings.Internal.NetBlob*, void> ProcessOrderedNetBlob; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IQueuedUIEventDeliverer*, ACBindings.Internal.NetBlob*, void> ProcessEphemeralNetBlob; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IQueuedUIEventDeliverer*, void> ResetDeliverySystem; // function pointer

        // Methods
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x004FD160
    /// void __thiscall IQueuedUIEventDeliverer::OnShutdown(IQueuedUIEventDeliverer*)</code>
    /// </summary>
    public void OnShutdown() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.IQueuedUIEventDeliverer, void>)0x004FD160)(ref this);
}

