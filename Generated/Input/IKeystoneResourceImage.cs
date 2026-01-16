namespace ACBindings.Internal;


/// <summary>Represents an image resource within the Keystone framework, extending base resource functionality to manage image-specific data.</summary>
public unsafe struct IKeystoneResourceImage
{
    // Base Classes
    public ACBindings.Internal.IKeystoneResource BaseClass_IKeystoneResource; // ACBindings.Internal.IKeystoneResource

    // Child Types
    public unsafe struct IKeystoneResourceImage_vtbl
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
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneResourceImage*, ACBindings.Internal.IKeystoneControl*, System.IntPtr> GetData; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneResourceImage*, uint> GetImageWidth; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneResourceImage*, uint> GetImageHeight; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneResourceImage*, uint, int> SetImageWidth; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneResourceImage*, uint, int> SetImageHeight; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneResourceImage*, int> IsAnimation; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneResourceImage*, uint> GetUpdateTime; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.IKeystoneResourceImage*, uint, ACBindings.Internal.IKeystoneControl*, void> UpdateCounter; // function pointer

        // Methods
    }

    // Methods
}

