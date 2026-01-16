namespace ACBindings.Internal;


/// <summary>Represents an interface abstraction that holds a pointer to its virtual function table, enabling dynamic method invocation.</summary>
/// <remarks>Typically used in COM interop or other systems requiring runtime polymorphism without full class overhead.</remarks>
public unsafe struct Interface
{
    // Child Types

    /// <summary>Represents the virtual method table for an interface, storing function pointers to IUnknown and custom query, reference count, and release operations used by COM‑like implementations.</summary>
    public unsafe struct Interface_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, ACBindings.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*> QueryInterface; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> Release; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer

    // Methods

    /// <summary>Retrieves the address of an interface specified by IID, returning an HRESULT status.
    /// <code>Offset: 0x00401BF0
    /// unsigned int __stdcall Interface::IUnknown_QueryInterface(Interface*,const _GUID*,void**)</code>
    /// </summary>
    /// <param name="iid">Identifier of the desired interface.</param>
    /// <param name="ppvObject">Receives the interface pointer on success.</param>
    /// <returns>An unsigned int representing the operation result (HRESULT).</returns>
    public static uint IUnknown_QueryInterface(ACBindings.Internal.Interface* this_, ACBindings.Internal._GUID* iid, void** ppvObject) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, ACBindings.Internal._GUID*, void**, uint>)0x00401BF0)(this_, iid, ppvObject);

    /// <summary>Increments the object's reference count and returns the new count.
    /// <code>Offset: 0x00401C10
    /// unsigned int __stdcall Interface::IUnknown_AddRef(Interface*)</code>
    /// </summary>
    /// <param name="this">The interface instance whose reference count is increased.</param>
    /// <returns>The updated reference count after incrementing.</returns>
    public static uint IUnknown_AddRef(ACBindings.Internal.Interface* this_) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint>)0x00401C10)(this_);

    /// <summary>Decrements the object's reference count and frees associated resources when the count drops to zero.
    /// <code>Offset: 0x00401C20
    /// unsigned int __stdcall Interface::IUnknown_Release(Interface*)</code>
    /// </summary>
    /// <param name="this">The interface instance whose reference count is being decreased.</param>
    /// <returns>The updated reference count after release.</returns>
    public static uint IUnknown_Release(ACBindings.Internal.Interface* this_) => ((delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint>)0x00401C20)(this_);
}

