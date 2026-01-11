namespace ACBindings.Internal;

public unsafe struct RecipientData : System.IDisposable
{
    // Members
    public double lastTouched_;
    public double timeAllocated_;
    public ACBindings.Internal.ConnectionState m_ConnectionState;
    public ACBindings.Internal.NIList___NetBlob_ptr waitingBlobs_;
    public ACBindings.Internal.ClientFlowQueue flowQueue_;
    public ACBindings.Internal.RecipientData* next_;
    public ushort recID_;
    public int onQueue_;
    public ACBindings.Internal.Indicator* dependencies_;
    public uint gidPlayer_;
    public uint flushNum_;

    // Generated Constructor
    public RecipientData(ushort recID, int addr, int noflow, float lineNoise) {
        _ConstructorInternal(recID, addr, noflow, lineNoise);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00547990
    /// void __thiscall RecipientData::TouchConnection(RecipientData*)</code>
    /// </summary>
    public void TouchConnection() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RecipientData, void>)0x00547990)(ref this);

    /// <summary>
    /// <code>Offset: 0x005479B0
    /// int __thiscall RecipientData::IndicateReceivedPacket(RecipientData*,const NetPacket*,unsigned int)</code>
    /// </summary>
    public int IndicateReceivedPacket(ACBindings.Internal.NetPacket* pPacket, uint priority) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RecipientData, ACBindings.Internal.NetPacket*, uint, int>)0x005479B0)(ref this, pPacket, priority);

    /// <summary>
    /// <code>Offset: 0x005479E0
    /// void __thiscall RecipientData::EnqueueBlob(RecipientData*,NetBlob*)</code>
    /// </summary>
    public void EnqueueBlob(ACBindings.Internal.NetBlob* newGuy) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RecipientData, ACBindings.Internal.NetBlob*, void>)0x005479E0)(ref this, newGuy);

    /// <summary>
    /// <code>Offset: 0x00547A00
    /// void __thiscall RecipientData::UseTime(RecipientData*)</code>
    /// </summary>
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RecipientData, void>)0x00547A00)(ref this);

    /// <summary>
    /// <code>Offset: 0x00547A40
    /// void __thiscall RecipientData::RecipientData(RecipientData*,unsigned __int16,sockaddr_in,int,float)</code>
    /// </summary>
    public void _ConstructorInternal(ushort recID, int addr, int noflow, float lineNoise) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RecipientData, ushort, int, int, float, void>)0x00547A40)(ref this, recID, addr, noflow, lineNoise);

    /// <summary>
    /// <code>Offset: 0x00547B00
    /// void __thiscall RecipientData::~RecipientData(RecipientData*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RecipientData, void>)0x00547B00)(ref this);

    /// <summary>
    /// <code>Offset: 0x00547B90
    /// void __thiscall RecipientData::QueueFlush(RecipientData*,unsigned int)</code>
    /// </summary>
    public void QueueFlush(uint num) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RecipientData, uint, void>)0x00547B90)(ref this, num);

    /// <summary>
    /// <code>Offset: 0x00547BD0
    /// void __thiscall RecipientData::ProcessNaks(RecipientData*,int,const unsigned int*)</code>
    /// </summary>
    public void ProcessNaks(int numNaks, uint* seqIDs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RecipientData, int, uint*, void>)0x00547BD0)(ref this, numNaks, seqIDs);
}

