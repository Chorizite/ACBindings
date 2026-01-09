namespace ACBindings;

// IDataObjectVtbl
public unsafe struct IDataObjectVtbl
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

