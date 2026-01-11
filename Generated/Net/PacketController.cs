namespace ACBindings.Internal;

public unsafe struct PacketController : System.IDisposable
{
    // Child Types
    public unsafe struct PacketController_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PacketController*, ulong> GetNonEphemeralID; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.Internal.ClientNet* net_;
    public ACBindings.Internal.RecipientData** recipients_;
    public fixed byte netQueues__Raw[12 * 4];
    public System.IntPtr* netQueues_ => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref netQueues__Raw[0]);
    public ACBindings.Internal.RecipientData* haveNaks_;
    public ACBindings.Internal.PQueueArray__double__void_ptr FlowControlTimers;
    public double lastEmpty_;
    public ulong m_curNonEphemeralID;
    public fixed byte gap68[4];
    public System.IntPtr m_pSendBlobCallsCounter;

    // Generated Constructor
    public PacketController(ACBindings.Internal.ClientNet* net) {
        _ConstructorInternal(net);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00541770
    /// PacketController* __cdecl PacketController::Instance()</code>
    /// </summary>
    public static ACBindings.Internal.PacketController* Instance() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.PacketController*>)0x00541770)();

    /// <summary>
    /// <code>Offset: 0x00541780
    /// int __thiscall PacketController::AddReceiveQueue(_DWORD*,unsigned __int16,int)</code>
    /// </summary>
    public int AddReceiveQueue(ushort a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PacketController, ushort, int, int>)0x00541780)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x005417A0
    /// void __thiscall PacketController::EnqueueRecip(PacketController*,RecipientData*)</code>
    /// </summary>
    public void EnqueueRecip(ACBindings.Internal.RecipientData* recip) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PacketController, ACBindings.Internal.RecipientData*, void>)0x005417A0)(ref this, recip);

    /// <summary>
    /// <code>Offset: 0x005417D0
    /// bool __thiscall PacketController::SendBlob(PacketController*,NetBlob*,unsigned __int16)</code>
    /// </summary>
    public byte SendBlob(ACBindings.Internal.NetBlob* blob, ushort recip) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PacketController, ACBindings.Internal.NetBlob*, ushort, byte>)0x005417D0)(ref this, blob, recip);

    /// <summary>
    /// <code>Offset: 0x00541800
    /// RecipientData* __thiscall PacketController::GetRecipient(PacketController*,unsigned __int16)</code>
    /// </summary>
    public ACBindings.Internal.RecipientData* GetRecipient(ushort recID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PacketController, ushort, ACBindings.Internal.RecipientData*>)0x00541800)(ref this, recID);

    /// <summary>
    /// <code>Offset: 0x00541920
    /// void __thiscall PacketController::~PacketController(PacketController*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PacketController, void>)0x00541920)(ref this);

    /// <summary>
    /// <code>Offset: 0x005419F0
    /// bool __thiscall PacketController::EnqueueOptionalHeader(PacketController*,unsigned __int16,COptionalHeader*)</code>
    /// </summary>
    public byte EnqueueOptionalHeader(ushort recID, ACBindings.Internal.COptionalHeader* pHdr) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PacketController, ushort, ACBindings.Internal.COptionalHeader*, byte>)0x005419F0)(ref this, recID, pHdr);

    /// <summary>
    /// <code>Offset: 0x00541BD0
    /// void __thiscall PacketController::CheckFlowControlTimers(PacketController*)</code>
    /// </summary>
    public void CheckFlowControlTimers() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PacketController, void>)0x00541BD0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00541CB0
    /// void __thiscall PacketController::UseTime(PacketController*)</code>
    /// </summary>
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PacketController, void>)0x00541CB0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00541D10
    /// int __thiscall PacketController::AddRecipient(PacketController*,unsigned __int16,sockaddr_in,int,float,unsigned int,int)</code>
    /// </summary>
    public int AddRecipient(ushort id, int addr, int noflow, float lineNoise, uint gid, int fIsAdminConnection) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PacketController, ushort, int, int, float, uint, int, int>)0x00541D10)(ref this, id, addr, noflow, lineNoise, gid, fIsAdminConnection);

    /// <summary>
    /// <code>Offset: 0x00541E80
    /// int __thiscall PacketController::DeleteRecipient(PacketController*,unsigned __int16)</code>
    /// </summary>
    public int DeleteRecipient(ushort id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PacketController, ushort, int>)0x00541E80)(ref this, id);

    /// <summary>
    /// <code>Offset: 0x00542070
    /// int __thiscall PacketController::AddReceivedBlobToQueue(PacketController*,NetBlob*)</code>
    /// </summary>
    public int AddReceivedBlobToQueue(ACBindings.Internal.NetBlob* blob) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PacketController, ACBindings.Internal.NetBlob*, int>)0x00542070)(ref this, blob);

    /// <summary>
    /// <code>Offset: 0x00542380
    /// void __thiscall PacketController::PacketController(PacketController*,ClientNet*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.ClientNet* net) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PacketController, ACBindings.Internal.ClientNet*, void>)0x00542380)(ref this, net);
}

