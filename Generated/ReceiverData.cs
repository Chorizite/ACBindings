namespace ACBindings.Internal;

public unsafe struct ReceiverData : System.IDisposable
{
    // Members
    public ushort m_RecID;
    public ushort iteration_;
    public uint highestIDReceived_;
    public ACBindings.Internal.ReceiverData* next_;
    public ACBindings.Internal.ReceiverData* prev_;
    public double timeStamp_;
    public double m_LocalTimeLastGotData;
    public ACBindings.Internal.CryptoSystem* cryptoOutgoing_;
    public ACBindings.Internal.CryptoSystem* cryptoIncoming_;
    public ACBindings.Internal.NetKeyExch* keyExch_;
    public ushort m_NetID;
    public int m_Addr;
    public ushort m_CurrentRemoteInterval;
    public ACBindings.Internal.ReceiverState m_NakState;
    public ACBindings.Internal.ConnectionState m_ConnectionState;
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

    /// <summary>
    /// <code>Offset: 0x005497C0
    /// void __thiscall ReceiverData::AddToQueue(ReceiverData*,ReceiverData**,ReceiverData**)</code>
    /// </summary>
    public void AddToQueue(ACBindings.Internal.ReceiverData** head, ACBindings.Internal.ReceiverData** tail) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ReceiverData, ACBindings.Internal.ReceiverData**, ACBindings.Internal.ReceiverData**, void>)0x005497C0)(ref this, head, tail);

    /// <summary>
    /// <code>Offset: 0x005497F0
    /// void __thiscall ReceiverData::RemoveFromQueue(ReceiverData*,ReceiverData**,ReceiverData**)</code>
    /// </summary>
    public void RemoveFromQueue(ACBindings.Internal.ReceiverData** head, ACBindings.Internal.ReceiverData** tail) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ReceiverData, ACBindings.Internal.ReceiverData**, ACBindings.Internal.ReceiverData**, void>)0x005497F0)(ref this, head, tail);

    /// <summary>
    /// <code>Offset: 0x00549870
    /// unsigned int __thiscall ReceiverData::Encrypt(ReceiverData*,unsigned int,unsigned __int8*,unsigned int,unsigned int*)</code>
    /// </summary>
    public uint Encrypt(uint seqnum, byte* mem, uint len, uint* pEncryptKey) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ReceiverData, uint, byte*, uint, uint*, uint>)0x00549870)(ref this, seqnum, mem, len, pEncryptKey);

    /// <summary>
    /// <code>Offset: 0x00549880
    /// unsigned int __thiscall ReceiverData::Decrypt(ReceiverData*,unsigned int,unsigned __int8*,unsigned int,unsigned int*)</code>
    /// </summary>
    public uint Decrypt(uint seqnum, byte* mem, uint len, uint* pDecryptKey) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ReceiverData, uint, byte*, uint, uint*, uint>)0x00549880)(ref this, seqnum, mem, len, pDecryptKey);

    /// <summary>
    /// <code>Offset: 0x005498D0
    /// void __thiscall ReceiverData::SetConnectionState(ReceiverData*,ConnectionState)</code>
    /// </summary>
    public void SetConnectionState(ACBindings.Internal.ConnectionState NewState) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ReceiverData, ACBindings.Internal.ConnectionState, void>)0x005498D0)(ref this, NewState);

    /// <summary>
    /// <code>Offset: 0x005498F0
    /// long double __thiscall ReceiverData::GetConnectionStateDuration(ReceiverData*)</code>
    /// </summary>
    public double GetConnectionStateDuration() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ReceiverData, double>)0x005498F0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00549900
    /// void __thiscall ReceiverData::InitCrypto(ReceiverData*,unsigned int,unsigned int)</code>
    /// </summary>
    public void InitCrypto(uint seedIncoming, uint seedOutgoing) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ReceiverData, uint, uint, void>)0x00549900)(ref this, seedIncoming, seedOutgoing);

    /// <summary>
    /// <code>Offset: 0x00549990
    /// void __thiscall ReceiverData::ReceiverData(ReceiverData*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ReceiverData, void>)0x00549990)(ref this);

    /// <summary>
    /// <code>Offset: 0x005499D0
    /// void __thiscall ReceiverData::~ReceiverData(ReceiverData*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ReceiverData, void>)0x005499D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00549A50
    /// void __thiscall ReceiverData::SharedInit(ReceiverData*,sockaddr_in*,unsigned int,unsigned __int16,unsigned __int16,unsigned __int16,unsigned __int16,NetKeyExch*,unsigned int,unsigned int)</code>
    /// </summary>
    public void SharedInit(int* addr, uint highest, ushort recID, ushort netID, ushort iteration, ushort remoteInterval, ACBindings.Internal.NetKeyExch* keyExch, uint seedIncoming, uint seedOutgoing) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ReceiverData, int*, uint, ushort, ushort, ushort, ushort, ACBindings.Internal.NetKeyExch*, uint, uint, void>)0x00549A50)(ref this, addr, highest, recID, netID, iteration, remoteInterval, keyExch, seedIncoming, seedOutgoing);

    /// <summary>
    /// <code>Offset: 0x00549B00
    /// void __thiscall ReceiverData::Init(ReceiverData*,sockaddr_in,unsigned int,unsigned __int16,unsigned __int16,unsigned __int16,unsigned __int16,NetKeyExch*,unsigned int,unsigned int)</code>
    /// </summary>
    public void Init(int addr, uint highest, ushort recID, ushort netID, ushort iteration, ushort remoteInterval, ACBindings.Internal.NetKeyExch* keyExch, uint seedIncoming, uint seedOutgoing) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ReceiverData, int, uint, ushort, ushort, ushort, ushort, ACBindings.Internal.NetKeyExch*, uint, uint, void>)0x00549B00)(ref this, addr, highest, recID, netID, iteration, remoteInterval, keyExch, seedIncoming, seedOutgoing);

    /// <summary>
    /// <code>Offset: 0x00549B60
    /// void __thiscall ReceiverData::Clear(ReceiverData*)</code>
    /// </summary>
    public void Clear() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ReceiverData, void>)0x00549B60)(ref this);

    /// <summary>
    /// <code>Offset: 0x00549C20
    /// int __thiscall ReceiverData::GetNaks(ReceiverData*,unsigned int*)</code>
    /// </summary>
    public int GetNaks(uint* naks) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ReceiverData, uint*, int>)0x00549C20)(ref this, naks);

    /// <summary>
    /// <code>Offset: 0x00549DA0
    /// void __thiscall ReceiverData::AddNakked(ReceiverData*,unsigned int,unsigned int*)</code>
    /// </summary>
    public void AddNakked(uint seqNum, uint* pKeyPassed) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ReceiverData, uint, uint*, void>)0x00549DA0)(ref this, seqNum, pKeyPassed);
}

