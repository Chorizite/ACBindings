namespace ACBindings.Internal;


/// <summary>Provides notification support for Keystone resources, exposing the IResourceNotify interface to handle resource events within the system.</summary>
public unsafe struct IKeystoneResource
{
    // Base Classes
    public ACBindings.Internal.IResourceNotify BaseClass_IResourceNotify; // ACBindings.Internal.IResourceNotify

    // Child Types
    public unsafe struct IKeystoneResource_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, ACBindings.Internal._GUID*, void**, int> QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.IUnknown*, uint> Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.IResourceNotify*, ACBindings.Internal.IResourceNotify*, ACBindings.Internal.KS_STATUS, int> NotifyResourceStatus; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.IResourceNotify*, ushort*> GetName; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneResource*, ushort*> GetType; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneResource*, System.IntPtr, int> DecodeData; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneResource*, ACBindings.Internal.IResourceNotify*, int> AddOwner; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneResource*, ACBindings.Internal.IResourceNotify*, int> RemoveOwner; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneResource*, ACBindings.Internal.KS_STATUS, int> SetStatus; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneResource*, ACBindings.Internal.KS_STATUS> GetStatus; // function pointer

        // Methods
    }

    // Methods
}

