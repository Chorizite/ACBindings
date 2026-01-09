namespace ACBindings;

// ArrivedEphInfo
public unsafe struct ArrivedEphInfo
{
    // Base Classes
    public ACBindings.UI64HashData BaseClass_UI64HashData; // ACBindings.UI64HashData

    // Child Types
    // ArrivedEphInfo_vtbl
    public unsafe struct ArrivedEphInfo_vtbl
    {
        // Members
        public System.IntPtr ArrivedEphInfo_dtor_0; // function pointer

        // Methods
    }

    // Members
    public ACBindings.ArrivedEphInfo* m_next;
    public ulong m_latestNetBlobID;
    public double m_timeStamp;

    // Generated Constructor
    public ArrivedEphInfo(ulong sequence, ulong netBlobID) {
        _ConstructorInternal(sequence, netBlobID);
    }

    // Methods
    // void __thiscall ArrivedEphInfo::ArrivedEphInfo(ArrivedEphInfo*,unsigned __int64,unsigned __int64)
    public void _ConstructorInternal(ulong sequence, ulong netBlobID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ArrivedEphInfo, ulong, ulong, void>)0x0054B9C0)(ref this, sequence, netBlobID);
    // void __thiscall ArrivedEphInfo::UpdateNetBlobID(ArrivedEphInfo*,unsigned __int64)
    public void UpdateNetBlobID(ulong netBlobID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ArrivedEphInfo, ulong, void>)0x0054BA10)(ref this, netBlobID);
    // bool __thiscall ArrivedEphInfo::fTimedOut(ArrivedEphInfo*)
    public byte fTimedOut() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ArrivedEphInfo, byte>)0x0054BA40)(ref this);
}

