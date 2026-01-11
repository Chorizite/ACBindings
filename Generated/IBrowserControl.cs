namespace ACBindings.Internal;

public unsafe struct IBrowserControl
{
    // Base Classes
    public ACBindings.Internal.IUnknown BaseClass_IUnknown; // ACBindings.Internal.IUnknown

    // Child Types
    public unsafe struct IBrowserControl_vtbl
    {
        // Members
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, ACBindings.Internal._GUID*, void**, int> QueryInterface; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> AddRef; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> Release; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IBrowserControl*, int*, int, int, int, int, ACBindings.Internal.IBrowserCallback*, byte> Create; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IBrowserControl*, int, int, void> Move; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IBrowserControl*, int, int, void> Resize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IBrowserControl*, byte, void> Show; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IBrowserControl*, int*> GetHWND; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IBrowserControl*, sbyte*, uint, sbyte*, sbyte*, System.IntPtr, uint, int> Navigate; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IBrowserControl*, int> Stop; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IBrowserControl*, int> GoBack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IBrowserControl*, int> GoForward; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IBrowserControl*, int> GoHome; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IBrowserControl*, int> GoSearch; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IBrowserControl*, byte, int> Refresh; // function pointer

        // Methods
    }

    // Methods
}

