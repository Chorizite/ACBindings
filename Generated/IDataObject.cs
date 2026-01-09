namespace ACBindings;

// IDataObject
public unsafe struct IDataObject
{
    // Child Types
    // IDataObject_vtbl
    public unsafe struct IDataObject_vtbl
    {
        // Members
        public System.IntPtr QueryInterface; // function pointer
        public System.IntPtr AddRef; // function pointer
        public System.IntPtr Release; // function pointer
        public System.IntPtr GetData; // function pointer
        public System.IntPtr GetDataHere; // function pointer
        public System.IntPtr QueryGetData; // function pointer
        public System.IntPtr GetCanonicalFormatEtc; // function pointer
        public System.IntPtr SetData; // function pointer
        public System.IntPtr EnumFormatEtc; // function pointer
        public System.IntPtr DAdvise; // function pointer
        public System.IntPtr DUnadvise; // function pointer
        public System.IntPtr EnumDAdvise; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr lpVtbl; // vtable pointer

    // Methods
}

