namespace ACBindings;

// GraphicsResource
public unsafe struct GraphicsResource : System.IDisposable
{
    // Statics
    public static ACBindings.SmartArray__GraphicsResource_ptr* s_Resources = (ACBindings.SmartArray__GraphicsResource_ptr*)0x008398CC;

    // Child Types
    // GraphicsResource_vtbl
    public unsafe struct GraphicsResource_vtbl
    {
        // Members
        public System.IntPtr GraphicsResource_dtor_0; // function pointer
        public System.IntPtr CopyInto; // function pointer
        public System.IntPtr PurgeResource; // function pointer
        public System.IntPtr RestoreResource; // function pointer

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
    // bool __thiscall GraphicsResource::CopyInto(GraphicsResource*,GraphicsResource*)
    public byte CopyInto(ACBindings.GraphicsResource* Target) => ((delegate* unmanaged[Thiscall]<ref ACBindings.GraphicsResource, ACBindings.GraphicsResource*, byte>)0x00446B90)(ref this, Target);
    // void __thiscall GraphicsResource::SetResourceSize(GraphicsResource*,const unsigned int)
    public void SetResourceSize(uint nNewSize) => ((delegate* unmanaged[Thiscall]<ref ACBindings.GraphicsResource, uint, void>)0x00446BD0)(ref this, nNewSize);
    // void __thiscall GraphicsResource::SetResourceIsThrashable(GraphicsResource*,const bool)
    public void SetResourceIsThrashable(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.GraphicsResource, byte, void>)0x00446BE0)(ref this, b);
    // void __thiscall GraphicsResource::SetAutoRestore(GraphicsResource*,const bool)
    public void SetAutoRestore(byte b) => ((delegate* unmanaged[Thiscall]<ref ACBindings.GraphicsResource, byte, void>)0x00446BF0)(ref this, b);
    // void __thiscall GraphicsResource::MarkResourceAsNotLost(GraphicsResource*)
    public void MarkResourceAsNotLost() => ((delegate* unmanaged[Thiscall]<ref ACBindings.GraphicsResource, void>)0x00446C00)(ref this);
    // void __thiscall GraphicsResource::MarkResourceAsLost(GraphicsResource*)
    public void MarkResourceAsLost() => ((delegate* unmanaged[Thiscall]<ref ACBindings.GraphicsResource, void>)0x00446C10)(ref this);
    // bool __thiscall GraphicsResource::RestoreResource(GraphicsResource*)
    public byte RestoreResource() => ((delegate* unmanaged[Thiscall]<ref ACBindings.GraphicsResource, byte>)0x00446C20)(ref this);
    // void __cdecl GraphicsResource::UnlinkResource(GraphicsResource*)
    public static void UnlinkResource(ACBindings.GraphicsResource* pResource) => ((delegate* unmanaged[Cdecl]<ACBindings.GraphicsResource*, void>)0x00446CD0)(pResource);
    // bool __cdecl GraphicsResource::PurgeResources()
    public static byte PurgeResources() => ((delegate* unmanaged[Cdecl]<byte>)0x00446D30)();
    // bool __cdecl GraphicsResource::RestoreLostResources()
    public static byte RestoreLostResources() => ((delegate* unmanaged[Cdecl]<byte>)0x00446D80)();
    // void __cdecl GraphicsResource::PurgeOldResources(const long double)
    public static void PurgeOldResources(double dAge) => ((delegate* unmanaged[Cdecl]<double, void>)0x00446DC0)(dAge);
    // void __thiscall GraphicsResource::~GraphicsResource(GraphicsResource*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.GraphicsResource, void>)0x00446F00)(ref this);
    // void __cdecl GraphicsResource::ShutdownResourceManager()
    public static void ShutdownResourceManager() => ((delegate* unmanaged[Cdecl]<void>)0x00446FF0)();
    // void __cdecl GraphicsResource::LinkResource(GraphicsResource*)
    public static void LinkResource(ACBindings.GraphicsResource* pResource) => ((delegate* unmanaged[Cdecl]<ACBindings.GraphicsResource*, void>)0x004470F0)(pResource);
    // void __thiscall GraphicsResource::GraphicsResource(GraphicsResource*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.GraphicsResource, void>)0x00447220)(ref this);
    // bool __cdecl GraphicsResource::DiscardResourceBytes(const unsigned int)
    public static byte DiscardResourceBytes(uint nBytesToDiscard) => ((delegate* unmanaged[Cdecl]<uint, byte>)0x004473D0)(nBytesToDiscard);
}

