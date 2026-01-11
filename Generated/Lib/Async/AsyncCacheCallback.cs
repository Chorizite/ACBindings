namespace ACBindings.Internal;

public unsafe struct AsyncCacheCallback
{
    // Child Types
    public unsafe struct AsyncCacheCallback_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AsyncCacheCallback*, ACBindings.Internal.AsyncContext, ACBindings.Internal.AsyncResult, uint, void> OnContextFinished; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AsyncCacheCallback*, ACBindings.Internal.AsyncContext, ACBindings.Internal.QualifiedDataID, ACBindings.Internal.AsyncResult, uint, int, System.IntPtr, void> OnTopLevelRequestFinished; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer

    // Methods
}

