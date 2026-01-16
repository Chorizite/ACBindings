namespace ACBindings.Internal;


/// <summary>Manages a graphics resource's lifecycle, tracking usage time, frame usage, size, and restoration state for efficient memory handling.</summary>
public unsafe struct GraphicsResource : System.IDisposable
{
    // Statics
    public static ACBindings.Internal.SmartArray___GraphicsResource_ptr* s_Resources = (ACBindings.Internal.SmartArray___GraphicsResource_ptr*)0x008398C4;

    // Child Types

    /// <summary>Defines the virtual function table for graphics resources, enabling lifecycle operations such as destruction, copying, purging, and restoring.</summary>
    public unsafe struct GraphicsResource_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.GraphicsResource*, void> GraphicsResource_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.GraphicsResource*, ACBindings.Internal.GraphicsResource*, byte> CopyInto; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.GraphicsResource*, byte> PurgeResource; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.GraphicsResource*, byte> RestoreResource; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public byte m_bIsLost;
    public double m_TimeUsed;
    public uint m_FrameUsed;
    public byte m_bIsThrashable;
    public byte m_AutoRestore;
    public uint m_nResourceSize;
    public uint m_ListIndex;

    // Generated Constructor
    public GraphicsResource() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Copies resource metadata and usage statistics from this graphics resource into the specified target, mirroring state such as loss status, thrashability, auto‑restore flag, size, time used, and frame used.
    /// <code>Offset: 0x00446B90
    /// bool __thiscall GraphicsResource::CopyInto(GraphicsResource*,GraphicsResource*)</code>
    /// </summary>
    /// <param name="Target">The destination graphics resource to receive the copied state.</param>
    /// <returns>True when the copy succeeds; always true in this implementation.</returns>
    public byte CopyInto(ACBindings.Internal.GraphicsResource* Target) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GraphicsResource, ACBindings.Internal.GraphicsResource*, byte>)0x00446B90)(ref this, Target);

    /// <summary>Updates the internal resource size field of a graphics resource.
    /// <code>Offset: 0x00446BD0
    /// void __thiscall GraphicsResource::SetResourceSize(GraphicsResource*,const unsigned int)</code>
    /// </summary>
    /// <param name="nNewSize">The new size value to assign to the resource.</param>
    public void SetResourceSize(uint nNewSize) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GraphicsResource, uint, void>)0x00446BD0)(ref this, nNewSize);

    /// <summary>Sets the thrashable state of the graphics resource.
    /// <code>Offset: 0x00446BE0
    /// void __thiscall GraphicsResource::SetResourceIsThrashable(GraphicsResource*,const bool)</code>
    /// </summary>
    /// <param name="b">If true marks the resource as thrashable; if false marks it non‑thrashable.</param>
    public void SetResourceIsThrashable(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GraphicsResource, byte, void>)0x00446BE0)(ref this, b);

    /// <summary>Configures whether the graphics resource automatically restores after it has been lost.
    /// <code>Offset: 0x00446BF0
    /// void __thiscall GraphicsResource::SetAutoRestore(GraphicsResource*,const bool)</code>
    /// </summary>
    /// <param name="b">A boolean value that enables or disables auto‑restore functionality for this resource.</param>
    public void SetAutoRestore(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GraphicsResource, byte, void>)0x00446BF0)(ref this, b);

    /// <summary>Marks the graphics resource as not lost by clearing its loss flag.
    /// <code>Offset: 0x00446C00
    /// void __thiscall GraphicsResource::MarkResourceAsNotLost(GraphicsResource*)</code>
    /// </summary>
    public void MarkResourceAsNotLost() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GraphicsResource, void>)0x00446C00)(ref this);

    /// <summary>Marks this graphics resource as lost, preventing further use until it can be restored.
    /// <code>Offset: 0x00446C10
    /// void __thiscall GraphicsResource::MarkResourceAsLost(GraphicsResource*)</code>
    /// </summary>
    public void MarkResourceAsLost() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GraphicsResource, void>)0x00446C10)(ref this);

    /// <summary>Determines whether the graphics resource is currently lost.
    /// <code>Offset: 0x00446C20
    /// bool __thiscall GraphicsResource::RestoreResource(GraphicsResource*)</code>
    /// </summary>
    /// <returns>True if the resource has been marked as lost; otherwise false.</returns>
    public byte RestoreResource() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GraphicsResource, byte>)0x00446C20)(ref this);

    /// <summary>Detaches the specified resource from the global resource pool, maintaining list contiguity by moving the last entry into its slot and updating indices.
    /// <code>Offset: 0x00446CD0
    /// void __cdecl GraphicsResource::UnlinkResource(GraphicsResource*)</code>
    /// </summary>
    /// <param name="pResource">The graphics resource to remove from the global collection.</param>
    public static void UnlinkResource(ACBindings.Internal.GraphicsResource* pResource) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.GraphicsResource*, void>)0x00446CD0)(pResource);

    /// <summary>Purges graphics resources that are not yet marked as lost by invoking each resource's purge logic and marking them as lost upon success.
    /// <code>Offset: 0x00446D30
    /// bool __cdecl GraphicsResource::PurgeResources()</code>
    /// </summary>
    /// <returns>True after attempting to purge all resources; currently always returns true.</returns>
    public static byte PurgeResources() => ((delegate* unmanaged[Cdecl]<byte>)0x00446D30)();

    /// <summary>Attempts to restore all graphics resources marked as lost and configured for automatic restoration, restarting the scan whenever a resource is successfully restored.
    /// <code>Offset: 0x00446D80
    /// bool __cdecl GraphicsResource::RestoreLostResources()</code>
    /// </summary>
    /// <returns>Indicates that the restore operation was attempted; always returns true in the current implementation.</returns>
    public static byte RestoreLostResources() => ((delegate* unmanaged[Cdecl]<byte>)0x00446D80)();

    /// <summary>Purges thrashable graphics resources that have not been used in the current frame and whose age exceeds the specified threshold, marking them as lost when successfully removed. The scan restarts after each successful purge to ensure all eligible resources are processed.
    /// <code>Offset: 0x00446DC0
    /// void __cdecl GraphicsResource::PurgeOldResources(const long double)</code>
    /// </summary>
    /// <param name="dAge">The maximum allowed age (in seconds) before a resource becomes eligible for purging.</param>
    public static void PurgeOldResources(double dAge) => ((delegate* unmanaged[Cdecl]<double, void>)0x00446DC0)(dAge);

    /// <summary>Restores the resource’s virtual table and removes it from internal tracking structures during destruction.
    /// <code>Offset: 0x00446F00
    /// void __thiscall GraphicsResource::~GraphicsResource(GraphicsResource*)</code>
    /// </summary>
    /// <param name="this">The graphics resource instance being destroyed.</param>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GraphicsResource, void>)0x00446F00)(ref this);

    /// <summary>Resets the graphics resource manager by clearing all managed profiler UI windows and releasing associated resources.
    /// <code>Offset: 0x00446FF0
    /// void __cdecl GraphicsResource::ShutdownResourceManager()</code>
    /// </summary>
    public static void ShutdownResourceManager() => ((delegate* unmanaged[Cdecl]<void>)0x00446FF0)();

    /// <summary>Adds a graphics resource to the global resource registry, assigning it an index in the internal list.
    /// <code>Offset: 0x004470F0
    /// void __cdecl GraphicsResource::LinkResource(GraphicsResource*)</code>
    /// </summary>
    /// <param name="pResource">The graphics resource to link into the registry.</param>
    public static void LinkResource(ACBindings.Internal.GraphicsResource* pResource) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.GraphicsResource*, void>)0x004470F0)(pResource);

    /// <summary>Initializes a new graphics resource instance, setting default flags, recording creation time and current rendering frame if available, then registers the resource in the global tracking system.
    /// <code>Offset: 0x00447220
    /// void __thiscall GraphicsResource::GraphicsResource(GraphicsResource*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GraphicsResource, void>)0x00447220)(ref this);

    /// <summary>Attempts to free at least the specified number of bytes by purging thrashable graphics resources, sorted by recent usage.
    /// <code>Offset: 0x004473D0
    /// bool __cdecl GraphicsResource::DiscardResourceBytes(const unsigned int)</code>
    /// </summary>
    /// <param name="nBytesToDiscard">The target amount, in bytes, to discard from the resource pool.</param>
    /// <returns>True if the requested size was cleared or exceeded; otherwise false.</returns>
    public static byte DiscardResourceBytes(uint nBytesToDiscard) => ((delegate* unmanaged[Cdecl]<uint, byte>)0x004473D0)(nBytesToDiscard);
}

