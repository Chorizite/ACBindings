namespace ACBindings;

// RecipientData
public unsafe struct RecipientData : System.IDisposable
{
    // Members
    public double lastTouched_;
    public double timeAllocated_;
    public ACBindings.ConnectionState m_ConnectionState;
    public ACBindings.NIList__NetBlob_ptr waitingBlobs_;
    public ACBindings.ClientFlowQueue flowQueue_;
    public ACBindings.RecipientData* next_;
    public ushort recID_;
    public int onQueue_;
    public ACBindings.Indicator* dependencies_;
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
    // void __thiscall RecipientData::TouchConnection(RecipientData*)
    public void TouchConnection() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RecipientData, void>)0x00547990)(ref this);
    // int __thiscall RecipientData::IndicateReceivedPacket(RecipientData*,const NetPacket*,unsigned int)
    public int IndicateReceivedPacket(ACBindings.NetPacket* pPacket, uint priority) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RecipientData, ACBindings.NetPacket*, uint, int>)0x005479B0)(ref this, pPacket, priority);
    // void __thiscall RecipientData::EnqueueBlob(RecipientData*,NetBlob*)
    public void EnqueueBlob(ACBindings.NetBlob* newGuy) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RecipientData, ACBindings.NetBlob*, void>)0x005479E0)(ref this, newGuy);
    // void __thiscall RecipientData::UseTime(RecipientData*)
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RecipientData, void>)0x00547A00)(ref this);
    // void __thiscall RecipientData::RecipientData(RecipientData*,unsigned __int16,sockaddr_in,int,float)
    public void _ConstructorInternal(ushort recID, int addr, int noflow, float lineNoise) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RecipientData, ushort, int, int, float, void>)0x00547A40)(ref this, recID, addr, noflow, lineNoise);
    // void __thiscall RecipientData::~RecipientData(RecipientData*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RecipientData, void>)0x00547B00)(ref this);
    // void __thiscall RecipientData::QueueFlush(RecipientData*,unsigned int)
    public void QueueFlush(uint num) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RecipientData, uint, void>)0x00547B90)(ref this, num);
    // void __thiscall RecipientData::ProcessNaks(RecipientData*,int,const unsigned int*)
    public void ProcessNaks(int numNaks, uint* seqIDs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RecipientData, int, uint*, void>)0x00547BD0)(ref this, numNaks, seqIDs);
}

