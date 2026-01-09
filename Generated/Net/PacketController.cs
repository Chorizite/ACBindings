namespace ACBindings;

// PacketController
public unsafe struct PacketController : System.IDisposable
{
    // Statics
    public static ACBindings.PacketController* pcontrol_ = (ACBindings.PacketController*)0x00846F08;

    // Child Types
    // PacketController_vtbl
    public unsafe struct PacketController_vtbl
    {
        // Members
        public System.IntPtr GetNonEphemeralID; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.ClientNet* net_;
    public ACBindings.RecipientData** recipients_;
    public fixed byte netQueues__Raw[12 * 4];
    public System.IntPtr* netQueues_ => (System.IntPtr*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref netQueues__Raw[0]);
    public ACBindings.RecipientData* haveNaks_;
    public ACBindings.PQueueArray__double__void_ptr FlowControlTimers;
    public double lastEmpty_;
    public ulong m_curNonEphemeralID;
    public fixed byte gap68[4];
    public System.IntPtr m_pSendBlobCallsCounter;

    // Generated Constructor
    public PacketController(ACBindings.ClientNet* net) {
        _ConstructorInternal(net);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // PacketController* __cdecl PacketController::Instance()
    public static ACBindings.PacketController* Instance() => ((delegate* unmanaged[Cdecl]<ACBindings.PacketController*>)0x00541770)();
    // int __thiscall PacketController::AddReceiveQueue(_DWORD*,unsigned __int16,int)
    public int AddReceiveQueue(ushort a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PacketController, ushort, int, int>)0x00541780)(ref this, a2, a3);
    // void __thiscall PacketController::EnqueueRecip(PacketController*,RecipientData*)
    public void EnqueueRecip(ACBindings.RecipientData* recip) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PacketController, ACBindings.RecipientData*, void>)0x005417A0)(ref this, recip);
    // bool __thiscall PacketController::SendBlob(PacketController*,NetBlob*,unsigned __int16)
    public byte SendBlob(ACBindings.NetBlob* blob, ushort recip) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PacketController, ACBindings.NetBlob*, ushort, byte>)0x005417D0)(ref this, blob, recip);
    // RecipientData* __thiscall PacketController::GetRecipient(PacketController*,unsigned __int16)
    public ACBindings.RecipientData* GetRecipient(ushort recID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PacketController, ushort, ACBindings.RecipientData*>)0x00541800)(ref this, recID);
    // void __thiscall PacketController::~PacketController(PacketController*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PacketController, void>)0x00541920)(ref this);
    // bool __thiscall PacketController::EnqueueOptionalHeader(PacketController*,unsigned __int16,COptionalHeader*)
    public byte EnqueueOptionalHeader(ushort recID, ACBindings.COptionalHeader* pHdr) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PacketController, ushort, ACBindings.COptionalHeader*, byte>)0x005419F0)(ref this, recID, pHdr);
    // void __thiscall PacketController::CheckFlowControlTimers(PacketController*)
    public void CheckFlowControlTimers() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PacketController, void>)0x00541BD0)(ref this);
    // void __thiscall PacketController::UseTime(PacketController*)
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PacketController, void>)0x00541CB0)(ref this);
    // int __thiscall PacketController::AddRecipient(PacketController*,unsigned __int16,sockaddr_in,int,float,unsigned int,int)
    public int AddRecipient(ushort id, int addr, int noflow, float lineNoise, uint gid, int fIsAdminConnection) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PacketController, ushort, int, int, float, uint, int, int>)0x00541D10)(ref this, id, addr, noflow, lineNoise, gid, fIsAdminConnection);
    // int __thiscall PacketController::DeleteRecipient(PacketController*,unsigned __int16)
    public int DeleteRecipient(ushort id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PacketController, ushort, int>)0x00541E80)(ref this, id);
    // int __thiscall PacketController::AddReceivedBlobToQueue(PacketController*,NetBlob*)
    public int AddReceivedBlobToQueue(ACBindings.NetBlob* blob) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PacketController, ACBindings.NetBlob*, int>)0x00542070)(ref this, blob);
    // void __thiscall PacketController::PacketController(PacketController*,ClientNet*)
    public void _ConstructorInternal(ACBindings.ClientNet* net) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PacketController, ACBindings.ClientNet*, void>)0x00542380)(ref this, net);
}

