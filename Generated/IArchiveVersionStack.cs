namespace ACBindings.Internal;


/// <summary>Represents an archive version stack interface containing only a base class reference for type identification and internal handling.</summary>
public unsafe struct IArchiveVersionStack
{
    // Base Classes
    public ACBindings.Internal.Interface BaseClass_Interface; // ACBindings.Internal.Interface

    // Child Types
    public unsafe struct IArchiveVersionStack_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, ACBindings.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*> QueryInterface; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.IArchiveVersionStack*, uint, uint> GetVersionByToken; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.IArchiveVersionStack*, uint, uint, byte> SetVersion; // function pointer
        public fixed byte gap20[4];
        public System.IntPtr PushVersionRow;
        public System.IntPtr PopVersionRow;
        public System.IntPtr GetRowByHandle;
        public System.IntPtr GetCurrentVersionHandle;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.IArchiveVersionStack*, void> Reset; // function pointer

        // Methods
    }

    // Methods
}

