namespace ACBindings;

// ReceiverData
public unsafe struct ReceiverData : System.IDisposable
{
    // Members
    public ushort m_RecID;
    public ushort iteration_;
    public uint highestIDReceived_;
    public ACBindings.ReceiverData* next_;
    public ACBindings.ReceiverData* prev_;
    public double timeStamp_;
    public double m_LocalTimeLastGotData;
    public ACBindings.CryptoSystem* cryptoOutgoing_;
    public ACBindings.CryptoSystem* cryptoIncoming_;
    public ACBindings.NetKeyExch* keyExch_;
    public ushort m_NetID;
    public int m_Addr;
    public ushort m_CurrentRemoteInterval;
    public ACBindings.ReceiverState m_NakState;
    public ACBindings.ConnectionState m_ConnectionState;
    public double m_SeqIDsWeNAKed;
    public double m_TimeLastConnectionStateChanged;
    public double lastSentHandshake_;
    public uint m_BytesReceived;
    public ulong m_qwReferralCookie;

    // Generated Constructor
    public ReceiverData() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall ReceiverData::AddToQueue(ReceiverData*,ReceiverData**,ReceiverData**)
    public void AddToQueue(ACBindings.ReceiverData** head, ACBindings.ReceiverData** tail) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ReceiverData, ACBindings.ReceiverData**, ACBindings.ReceiverData**, void>)0x005497C0)(ref this, head, tail);
    // void __thiscall ReceiverData::RemoveFromQueue(ReceiverData*,ReceiverData**,ReceiverData**)
    public void RemoveFromQueue(ACBindings.ReceiverData** head, ACBindings.ReceiverData** tail) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ReceiverData, ACBindings.ReceiverData**, ACBindings.ReceiverData**, void>)0x005497F0)(ref this, head, tail);
    // unsigned int __thiscall ReceiverData::Encrypt(ReceiverData*,unsigned int,unsigned __int8*,unsigned int,unsigned int*)
    public uint Encrypt(uint seqnum, byte* mem, uint len, uint* pEncryptKey) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ReceiverData, uint, byte*, uint, uint*, uint>)0x00549870)(ref this, seqnum, mem, len, pEncryptKey);
    // unsigned int __thiscall ReceiverData::Decrypt(ReceiverData*,unsigned int,unsigned __int8*,unsigned int,unsigned int*)
    public uint Decrypt(uint seqnum, byte* mem, uint len, uint* pDecryptKey) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ReceiverData, uint, byte*, uint, uint*, uint>)0x00549880)(ref this, seqnum, mem, len, pDecryptKey);
    // void __thiscall ReceiverData::SetConnectionState(ReceiverData*,ConnectionState)
    public void SetConnectionState(ACBindings.ConnectionState NewState) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ReceiverData, ACBindings.ConnectionState, void>)0x005498D0)(ref this, NewState);
    // long double __thiscall ReceiverData::GetConnectionStateDuration(ReceiverData*)
    public double GetConnectionStateDuration() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ReceiverData, double>)0x005498F0)(ref this);
    // void __thiscall ReceiverData::InitCrypto(ReceiverData*,unsigned int,unsigned int)
    public void InitCrypto(uint seedIncoming, uint seedOutgoing) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ReceiverData, uint, uint, void>)0x00549900)(ref this, seedIncoming, seedOutgoing);
    // void __thiscall ReceiverData::ReceiverData(ReceiverData*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ReceiverData, void>)0x00549990)(ref this);
    // void __thiscall ReceiverData::~ReceiverData(ReceiverData*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ReceiverData, void>)0x005499D0)(ref this);
    // void __thiscall ReceiverData::SharedInit(ReceiverData*,sockaddr_in*,unsigned int,unsigned __int16,unsigned __int16,unsigned __int16,unsigned __int16,NetKeyExch*,unsigned int,unsigned int)
    public void SharedInit(int* addr, uint highest, ushort recID, ushort netID, ushort iteration, ushort remoteInterval, ACBindings.NetKeyExch* keyExch, uint seedIncoming, uint seedOutgoing) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ReceiverData, int*, uint, ushort, ushort, ushort, ushort, ACBindings.NetKeyExch*, uint, uint, void>)0x00549A50)(ref this, addr, highest, recID, netID, iteration, remoteInterval, keyExch, seedIncoming, seedOutgoing);
    // void __thiscall ReceiverData::Init(ReceiverData*,sockaddr_in,unsigned int,unsigned __int16,unsigned __int16,unsigned __int16,unsigned __int16,NetKeyExch*,unsigned int,unsigned int)
    public void Init(int addr, uint highest, ushort recID, ushort netID, ushort iteration, ushort remoteInterval, ACBindings.NetKeyExch* keyExch, uint seedIncoming, uint seedOutgoing) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ReceiverData, int, uint, ushort, ushort, ushort, ushort, ACBindings.NetKeyExch*, uint, uint, void>)0x00549B00)(ref this, addr, highest, recID, netID, iteration, remoteInterval, keyExch, seedIncoming, seedOutgoing);
    // void __thiscall ReceiverData::Clear(ReceiverData*)
    public void Clear() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ReceiverData, void>)0x00549B60)(ref this);
    // int __thiscall ReceiverData::GetNaks(ReceiverData*,unsigned int*)
    public int GetNaks(uint* naks) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ReceiverData, uint*, int>)0x00549C20)(ref this, naks);
    // void __thiscall ReceiverData::AddNakked(ReceiverData*,unsigned int,unsigned int*)
    public void AddNakked(uint seqNum, uint* pKeyPassed) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ReceiverData, uint, uint*, void>)0x00549DA0)(ref this, seqNum, pKeyPassed);
}

