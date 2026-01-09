namespace ACBindings;

// Interface
public unsafe struct Interface
{
    // Child Types
    // Interface_vtbl
    public unsafe struct Interface_vtbl
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

    // Members
    public System.IntPtr __vftable; // vtable pointer

    // Methods
    // unsigned int __stdcall Interface::IUnknown_QueryInterface(Interface*,const _GUID*,void**)
    public static uint IUnknown_QueryInterface(ACBindings.Interface* this_, ACBindings._GUID* iid, void** ppvObject) => ((delegate* unmanaged[Stdcall]<ACBindings.Interface*, ACBindings._GUID*, void**, uint>)0x00401BF0)(this_, iid, ppvObject);
    // unsigned int __stdcall Interface::IUnknown_AddRef(Interface*)
    public static uint IUnknown_AddRef(ACBindings.Interface* this_) => ((delegate* unmanaged[Stdcall]<ACBindings.Interface*, uint>)0x00401C10)(this_);
    // unsigned int __stdcall Interface::IUnknown_Release(Interface*)
    public static uint IUnknown_Release(ACBindings.Interface* this_) => ((delegate* unmanaged[Stdcall]<ACBindings.Interface*, uint>)0x00401C20)(this_);
}

