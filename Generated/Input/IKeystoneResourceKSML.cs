namespace ACBindings.Internal;

public unsafe struct IKeystoneResourceKSML
{
    // Base Classes
    public ACBindings.Internal.IKeystoneResource BaseClass_IKeystoneResource; // ACBindings.Internal.IKeystoneResource

    // Child Types
    public unsafe struct IKeystoneResourceKSML_vtbl
    {
        // Members
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, ACBindings.Internal._GUID*, void**, int> QueryInterface; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> AddRef; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> Release; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IResourceNotify*, ACBindings.Internal.IResourceNotify*, ACBindings.Internal.KS_STATUS, int> NotifyResourceStatus; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IResourceNotify*, ushort*> GetName; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneResource*, ushort*> GetType; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneResource*, System.IntPtr, int> DecodeData; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneResource*, ACBindings.Internal.IResourceNotify*, int> AddOwner; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneResource*, ACBindings.Internal.IResourceNotify*, int> RemoveOwner; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneResource*, ACBindings.Internal.KS_STATUS, int> SetStatus; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneResource*, ACBindings.Internal.KS_STATUS> GetStatus; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneResourceKSML*, ushort*> GetData; // function pointer

        // Methods
    }

    // Methods
}

