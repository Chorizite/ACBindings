namespace ACBindings.Internal;

public unsafe struct RefCountInterface___GlobalRegistryCommands
{
    // Base Classes
    public ACBindings.Internal.GlobalRegistryCommands BaseClass_GlobalRegistryCommands; // ACBindings.Internal.GlobalRegistryCommands
    public ACBindings.Internal.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.Internal.ReferenceCountTemplate

    // Child Types
    public unsafe struct RefCountInterface_vtbl___GlobalRegistryCommands
    {
        // Members
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, ACBindings.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*> QueryInterface; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> AddRef; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> Release; // function pointer
        public System.IntPtr You_Must_Not_Have_Multiple_Implementations_Of_AddRef_In_A_Hierarchy;

        // Methods
    }
    // RefCountInterface<GlobalRegistryCommands>::Enum0
    public enum Enum0 : uint
    {
    }

    // Methods

    /// <summary>Increments the Turbine reference counter of the specified UIQueueManager and returns the updated count.
    /// <code>Offset: 0x00402620
    /// LONG __thiscall RefCountInterface&lt;GlobalRegistryCommands&gt;::AddRef(UIQueueManager*)</code>
    /// </summary>
    /// <param name="this">The UIQueueManager instance whose reference count will be incremented.</param>
    /// <returns>The new reference count after the increment operation.</returns>
    // LONG __thiscall RefCountInterface<GlobalRegistryCommands>::AddRef(UIQueueManager*) (template type method)

    /// <summary>Releases a reference to the object, decrementing its internal reference counter.
    /// <code>Offset: 0x00435210
    /// int __thiscall RefCountInterface&lt;GlobalRegistryCommands&gt;::Release(volatile LONG*)</code>
    /// </summary>
    /// <returns>The remaining reference count after the release operation.</returns>
    // int __thiscall RefCountInterface<GlobalRegistryCommands>::Release(volatile LONG*) (template type method)

    /// <summary>Destroys a RefCountInterface&lt;GlobalRegistryCommands&gt; instance, resetting its virtual tables and invoking the GlobalRegistryCommands destructor.
    /// <code>Offset: 0x00435250
    /// void __fastcall RefCountInterface&lt;GlobalRegistryCommands&gt;::~RefCountInterface&lt;GlobalRegistryCommands&gt;(GlobalRegistryCommands*)</code>
    /// </summary>
    /// <param name="a1">The RefCountInterface instance to destroy.</param>
    // void __fastcall RefCountInterface<GlobalRegistryCommands>::~RefCountInterface<GlobalRegistryCommands>(GlobalRegistryCommands*) (template type method)
}

