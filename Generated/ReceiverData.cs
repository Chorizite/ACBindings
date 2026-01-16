namespace ACBindings.Internal;


/// <summary>Receives and manages incoming network packets for a remote endpoint, tracking packet identifiers, connection status, cryptographic contexts, and timing information.</summary>
/// <remarks>Maintains an AVL tree of NAKed sequence IDs, uses CryptoSystem instances for encryption/decryption, and records timestamps for connection state changes and data receipt.</remarks>
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

    /// <summary>Adds the current ReceiverData instance to the end of a doubly linked list referenced by head and tail pointers, updating the list links appropriately.
    /// <code>Offset: 0x005497C0
    /// void __thiscall ReceiverData::AddToQueue(ReceiverData*,ReceiverData**,ReceiverData**)</code>
    /// </summary>
    /// <param name="head">Pointer to the first element in the queue; may be null if the queue is empty.</param>
    /// <param name="tail">Pointer to the last element in the queue; updated to point to this instance after insertion.</param>
    public void AddToQueue(ACBindings.Internal.ReceiverData** head, ACBindings.Internal.ReceiverData** tail) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ReceiverData, ACBindings.Internal.ReceiverData**, ACBindings.Internal.ReceiverData**, void>)0x005497C0)(ref this, head, tail);

    /// <summary>
    /// Removes the current ReceiverData instance from a doubly linked list and updates head and tail pointers accordingly.
    /// 
    /// <code>Offset: 0x005497F0
    /// void __thiscall ReceiverData::RemoveFromQueue(ReceiverData*,ReceiverData**,ReceiverData**)</code>
    /// </summary>
    /// <param name="head">Pointer to the first node in the queue; updated if the removed node was the head.</param>
    /// <param name="tail">Pointer to the last node in the queue; updated if the removed node was the tail.</param>
    public void RemoveFromQueue(ACBindings.Internal.ReceiverData** head, ACBindings.Internal.ReceiverData** tail) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ReceiverData, ACBindings.Internal.ReceiverData**, ACBindings.Internal.ReceiverData**, void>)0x005497F0)(ref this, head, tail);

    /// <summary>Encrypts a data buffer in-place using a key from the outgoing crypto system or an externally supplied key, returning the key used.
    /// <code>Offset: 0x00549870
    /// unsigned int __thiscall ReceiverData::Encrypt(ReceiverData*,unsigned int,unsigned __int8*,unsigned int,unsigned int*)</code>
    /// </summary>
    /// <param name="seqnum">Sequence number of the message; unused by this routine.</param>
    /// <param name="mem">Pointer to the memory block that will be XOR‑encrypted.</param>
    /// <param name="len">Length in bytes of the data block. The function processes 4‑byte words up to the nearest multiple of four.</param>
    /// <param name="pEncryptKey">Optional pointer to a key; if non‑null its value is used, otherwise a new key is generated from the crypto system.</param>
    /// <returns>The encryption key applied to the buffer.</returns>
    public uint Encrypt(uint seqnum, byte* mem, uint len, uint* pEncryptKey) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ReceiverData, uint, byte*, uint, uint*, uint>)0x00549870)(ref this, seqnum, mem, len, pEncryptKey);

    /// <summary>Decrypts data in place by XORing each 4‑byte block with an incoming cryptographic key, generating or using a supplied key.
    /// <code>Offset: 0x00549880
    /// unsigned int __thiscall ReceiverData::Decrypt(ReceiverData*,unsigned int,unsigned __int8*,unsigned int,unsigned int*)</code>
    /// </summary>
    /// <param name="seqnum">Sequence number of the packet being processed (currently unused).</param>
    /// <param name="mem">Pointer to the buffer that will be decrypted.</param>
    /// <param name="len">Length of the buffer in bytes.</param>
    /// <param name="pDecryptKey">Optional pointer to an externally supplied decryption key; if null, a new key is generated from the internal crypto state.</param>
    /// <returns>The unsigned integer key used for XOR decryption.</returns>
    public uint Decrypt(uint seqnum, byte* mem, uint len, uint* pDecryptKey) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ReceiverData, uint, byte*, uint, uint*, uint>)0x00549880)(ref this, seqnum, mem, len, pDecryptKey);

    /// <summary>Updates the connection state and records the change timestamp using the current local time.
    /// <code>Offset: 0x005498D0
    /// void __thiscall ReceiverData::SetConnectionState(ReceiverData*,ConnectionState)</code>
    /// </summary>
    /// <param name="NewState">The new connection state to assign to the receiver.</param>
    public void SetConnectionState(ACBindings.Internal.ConnectionState NewState) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ReceiverData, ACBindings.Internal.ConnectionState, void>)0x005498D0)(ref this, NewState);

    /// <summary>Calculates how long the current connection state has persisted by subtracting the timestamp of the last state change from the current local time.
    /// <code>Offset: 0x005498F0
    /// long double __thiscall ReceiverData::GetConnectionStateDuration(ReceiverData*)</code>
    /// </summary>
    /// <returns>The elapsed time, in the same units as Timer::local_time, since the connection state was last changed.</returns>
    public double GetConnectionStateDuration() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ReceiverData, double>)0x005498F0)(ref this);

    /// <summary>Initializes the receiver's cryptographic systems using the provided seeds, disposing of any previously allocated instances.
    /// <code>Offset: 0x00549900
    /// void __thiscall ReceiverData::InitCrypto(ReceiverData*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="seedIncoming">Seed value for the incoming crypto system.</param>
    /// <param name="seedOutgoing">Seed value for the outgoing crypto system.</param>
    public void InitCrypto(uint seedIncoming, uint seedOutgoing) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ReceiverData, uint, uint, void>)0x00549900)(ref this, seedIncoming, seedOutgoing);

    /// <summary>Constructs a new ReceiverData instance, initializing all internal fields to default values and marking the connection as disconnected.
    /// <code>Offset: 0x00549990
    /// void __thiscall ReceiverData::ReceiverData(ReceiverData*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ReceiverData, void>)0x00549990)(ref this);

    /// <summary>Destroys a ReceiverData instance by releasing its incoming and outgoing cryptographic systems, clearing the sequence‑ID tracking structure, and freeing associated resources.
    /// <code>Offset: 0x005499D0
    /// void __thiscall ReceiverData::~ReceiverData(ReceiverData*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ReceiverData, void>)0x005499D0)(ref this);

    /// <summary>Initializes receiver data, assigning network identifiers, timestamps, and cryptographic parameters while replacing any existing key‑exchange object.
    /// <code>Offset: 0x00549A50
    /// void __thiscall ReceiverData::SharedInit(ReceiverData*,sockaddr_in*,unsigned int,unsigned __int16,unsigned __int16,unsigned __int16,unsigned __int16,NetKeyExch*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Remote socket address to associate with the receiver.</param>
    /// <param name="highest">Highest packet identifier expected from this remote source.</param>
    /// <param name="recID">Receiver identifier assigned by the network layer.</param>
    /// <param name="netID">Network identifier for the receiver instance.</param>
    /// <param name="iteration">Session or iteration counter used during communication.</param>
    /// <param name="remoteInterval">Remote update interval value supplied to the receiver.</param>
    /// <param name="keyExch">Key‑exchange object that provides encryption parameters; an existing instance is destroyed before assignment.</param>
    /// <param name="seedIncoming">Seed used to initialize the incoming cryptographic stream.</param>
    /// <param name="seedOutgoing">Seed used to initialize the outgoing cryptographic stream.</param>
    public void SharedInit(int* addr, uint highest, ushort recID, ushort netID, ushort iteration, ushort remoteInterval, ACBindings.Internal.NetKeyExch* keyExch, uint seedIncoming, uint seedOutgoing) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ReceiverData, int*, uint, ushort, ushort, ushort, ushort, ACBindings.Internal.NetKeyExch*, uint, uint, void>)0x00549A50)(ref this, addr, highest, recID, netID, iteration, remoteInterval, keyExch, seedIncoming, seedOutgoing);

    /// <summary>Initializes a ReceiverData instance with network address, identification parameters, timing intervals, cryptographic key exchange, and random seeds; records the current local time for synchronization.
    /// <code>Offset: 0x00549B00
    /// void __thiscall ReceiverData::Init(ReceiverData*,sockaddr_in,unsigned int,unsigned __int16,unsigned __int16,unsigned __int16,unsigned __int16,NetKeyExch*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Network socket address of the remote endpoint.</param>
    /// <param name="highest">Highest packet ID previously received from this source.</param>
    /// <param name="recID">Receiver identifier assigned locally.</param>
    /// <param name="netID">Network identifier for this connection.</param>
    /// <param name="iteration">Current iteration count used for sequence handling.</param>
    /// <param name="remoteInterval">Expected interval between remote packets.</param>
    /// <param name="keyExch">Pointer to the key exchange object providing cryptographic keys.</param>
    /// <param name="seedIncoming">Seed value for incoming packet randomization or encryption.</param>
    /// <param name="seedOutgoing">Seed value for outgoing packet randomization or encryption.</param>
    public void Init(int addr, uint highest, ushort recID, ushort netID, ushort iteration, ushort remoteInterval, ACBindings.Internal.NetKeyExch* keyExch, uint seedIncoming, uint seedOutgoing) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ReceiverData, int, uint, ushort, ushort, ushort, ushort, ACBindings.Internal.NetKeyExch*, uint, uint, void>)0x00549B00)(ref this, addr, highest, recID, netID, iteration, remoteInterval, keyExch, seedIncoming, seedOutgoing);

    /// <summary>Resets all internal state of a ReceiverData instance to its default configuration, clearing identifiers, timestamps, connection status, and deallocating any associated cryptographic objects and key‑exchange data.
    /// <code>Offset: 0x00549B60
    /// void __thiscall ReceiverData::Clear(ReceiverData*)</code>
    /// </summary>
    public void Clear() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ReceiverData, void>)0x00549B60)(ref this);

    /// <summary>Copies sequence identifiers of packets that have been NAKed into the supplied array, potentially writing up to 115 entries.
    /// <code>Offset: 0x00549C20
    /// int __thiscall ReceiverData::GetNaks(ReceiverData*,unsigned int*)</code>
    /// </summary>
    /// <param name="naks">Buffer to receive the NAKed sequence IDs; allocate space for at least 115 elements.</param>
    /// <returns>The number of identifiers written and returned, capped at a maximum of 114 even if more than 114 were copied into the array.</returns>
    public int GetNaks(uint* naks) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ReceiverData, uint*, int>)0x00549C20)(ref this, naks);

    /// <summary>Records that a given sequence number has been NAKed, updating the receiver's state and storing it in an AVL tree of NAKed IDs. If no key is supplied, generates a new cryptographic seed for the incoming channel.
    /// <code>Offset: 0x00549DA0
    /// void __thiscall ReceiverData::AddNakked(ReceiverData*,unsigned int,unsigned int*)</code>
    /// </summary>
    /// <param name="seqNum">The sequence number to mark as NAKed.</param>
    /// <param name="pKeyPassed">Pointer to a pre‑generated crypto seed; if null, a new seed is obtained from CryptoSystem.</param>
    public void AddNakked(uint seqNum, uint* pKeyPassed) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ReceiverData, uint, uint*, void>)0x00549DA0)(ref this, seqNum, pKeyPassed);
}

