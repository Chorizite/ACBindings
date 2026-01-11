namespace ACBindings.Internal;

public unsafe struct GraphicsResource : System.IDisposable
{
    // Child Types
    public unsafe struct GraphicsResource_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.GraphicsResource*, void> GraphicsResource_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.GraphicsResource*, ACBindings.Internal.GraphicsResource*, byte> CopyInto; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.GraphicsResource*, byte> PurgeResource; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.GraphicsResource*, byte> RestoreResource; // function pointer

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

    /// <summary>
    /// <code>Offset: 0x00446B90
    /// bool __thiscall GraphicsResource::CopyInto(GraphicsResource*,GraphicsResource*)</code>
    /// </summary>
    public byte CopyInto(ACBindings.Internal.GraphicsResource* Target) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GraphicsResource, ACBindings.Internal.GraphicsResource*, byte>)0x00446B90)(ref this, Target);

    /// <summary>
    /// <code>Offset: 0x00446BD0
    /// void __thiscall GraphicsResource::SetResourceSize(GraphicsResource*,const unsigned int)</code>
    /// </summary>
    public void SetResourceSize(uint nNewSize) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GraphicsResource, uint, void>)0x00446BD0)(ref this, nNewSize);

    /// <summary>
    /// <code>Offset: 0x00446BE0
    /// void __thiscall GraphicsResource::SetResourceIsThrashable(GraphicsResource*,const bool)</code>
    /// </summary>
    public void SetResourceIsThrashable(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GraphicsResource, byte, void>)0x00446BE0)(ref this, b);

    /// <summary>
    /// <code>Offset: 0x00446BF0
    /// void __thiscall GraphicsResource::SetAutoRestore(GraphicsResource*,const bool)</code>
    /// </summary>
    public void SetAutoRestore(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GraphicsResource, byte, void>)0x00446BF0)(ref this, b);

    /// <summary>
    /// <code>Offset: 0x00446C00
    /// void __thiscall GraphicsResource::MarkResourceAsNotLost(GraphicsResource*)</code>
    /// </summary>
    public void MarkResourceAsNotLost() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GraphicsResource, void>)0x00446C00)(ref this);

    /// <summary>
    /// <code>Offset: 0x00446C10
    /// void __thiscall GraphicsResource::MarkResourceAsLost(GraphicsResource*)</code>
    /// </summary>
    public void MarkResourceAsLost() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GraphicsResource, void>)0x00446C10)(ref this);

    /// <summary>
    /// <code>Offset: 0x00446C20
    /// bool __thiscall GraphicsResource::RestoreResource(GraphicsResource*)</code>
    /// </summary>
    public byte RestoreResource() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GraphicsResource, byte>)0x00446C20)(ref this);

    /// <summary>
    /// <code>Offset: 0x00446CD0
    /// void __cdecl GraphicsResource::UnlinkResource(GraphicsResource*)</code>
    /// </summary>
    public static void UnlinkResource(ACBindings.Internal.GraphicsResource* pResource) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.GraphicsResource*, void>)0x00446CD0)(pResource);

    /// <summary>
    /// <code>Offset: 0x00446D30
    /// bool __cdecl GraphicsResource::PurgeResources()</code>
    /// </summary>
    public static byte PurgeResources() => ((delegate* unmanaged[Cdecl]<byte>)0x00446D30)();

    /// <summary>
    /// <code>Offset: 0x00446D80
    /// bool __cdecl GraphicsResource::RestoreLostResources()</code>
    /// </summary>
    public static byte RestoreLostResources() => ((delegate* unmanaged[Cdecl]<byte>)0x00446D80)();

    /// <summary>
    /// <code>Offset: 0x00446DC0
    /// void __cdecl GraphicsResource::PurgeOldResources(const long double)</code>
    /// </summary>
    public static void PurgeOldResources(double dAge) => ((delegate* unmanaged[Cdecl]<double, void>)0x00446DC0)(dAge);

    /// <summary>
    /// <code>Offset: 0x00446F00
    /// void __thiscall GraphicsResource::~GraphicsResource(GraphicsResource*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GraphicsResource, void>)0x00446F00)(ref this);

    /// <summary>
    /// <code>Offset: 0x00446FF0
    /// void __cdecl GraphicsResource::ShutdownResourceManager()</code>
    /// </summary>
    public static void ShutdownResourceManager() => ((delegate* unmanaged[Cdecl]<void>)0x00446FF0)();

    /// <summary>
    /// <code>Offset: 0x004470F0
    /// void __cdecl GraphicsResource::LinkResource(GraphicsResource*)</code>
    /// </summary>
    public static void LinkResource(ACBindings.Internal.GraphicsResource* pResource) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.GraphicsResource*, void>)0x004470F0)(pResource);

    /// <summary>
    /// <code>Offset: 0x00447220
    /// void __thiscall GraphicsResource::GraphicsResource(GraphicsResource*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GraphicsResource, void>)0x00447220)(ref this);

    /// <summary>
    /// <code>Offset: 0x004473D0
    /// bool __cdecl GraphicsResource::DiscardResourceBytes(const unsigned int)</code>
    /// </summary>
    public static byte DiscardResourceBytes(uint nBytesToDiscard) => ((delegate* unmanaged[Cdecl]<uint, byte>)0x004473D0)(nBytesToDiscard);
}

