namespace ACBindings.Internal;

public unsafe struct TSRecv : System.IDisposable
{
    // Members
    public int receivedFirstEntry_;
    public ACBindings.Internal.TSRecvMode mode_;
    public uint overflowLimit_;
    public uint highestStamp_;
    public ACBindings.Internal.TSBlockedEntry head_;
    public int numBlockedStamps_;
    public double blockedSince_;

    // Generated Constructor
    public TSRecv(ACBindings.Internal.TSRecvMode mode, uint TSOverflowLimit) {
        _ConstructorInternal(mode, TSOverflowLimit);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x005B0F00
    /// void __thiscall TSRecv::TSRecv(TSRecv*,TSRecvMode,unsigned int)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.TSRecvMode mode, uint TSOverflowLimit) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TSRecv, ACBindings.Internal.TSRecvMode, uint, void>)0x005B0F00)(ref this, mode, TSOverflowLimit);

    /// <summary>
    /// <code>Offset: 0x005B0F30
    /// int __thiscall TSRecv::GetNextReadyEntry(_DWORD*,_DWORD*,_DWORD*)</code>
    /// </summary>
    public int GetNextReadyEntry(int* a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TSRecv, int*, int*, int>)0x005B0F30)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x005B0FF0
    /// void __thiscall TSRecv::~TSRecv(TSRecv*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TSRecv, void>)0x005B0FF0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005B1060
    /// int __thiscall TSRecv::AddEntryLatest(_DWORD*,unsigned int,int,unsigned int*,_DWORD*)</code>
    /// </summary>
    public int AddEntryLatest(uint a2, int a3, uint* a4, int* a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TSRecv, uint, int, uint*, int*, int>)0x005B1060)(ref this, a2, a3, a4, a5);

    /// <summary>
    /// <code>Offset: 0x005B10E0
    /// int __thiscall TSRecv::AddEntry(_DWORD*,int,int,int)</code>
    /// </summary>
    public int AddEntry(int a2, int a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TSRecv, int, int, int, int>)0x005B10E0)(ref this, a2, a3, a4);

    /// <summary>
    /// <code>Offset: 0x005B11A0
    /// int __thiscall TSRecv::AddEntryBlocking(int,unsigned int,int,unsigned int*,int*)</code>
    /// </summary>
    public int AddEntryBlocking(uint a2, int a3, uint* a4, int* a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TSRecv, uint, int, uint*, int*, int>)0x005B11A0)(ref this, a2, a3, a4, a5);

    /// <summary>
    /// <code>Offset: 0x005B12D0
    /// int __thiscall TSRecv::AddAndCheck(_DWORD*,unsigned int,int,unsigned int*,int*)</code>
    /// </summary>
    public int AddAndCheck(uint a2, int a3, uint* a4, int* a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TSRecv, uint, int, uint*, int*, int>)0x005B12D0)(ref this, a2, a3, a4, a5);
}

