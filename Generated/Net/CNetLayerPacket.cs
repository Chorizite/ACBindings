namespace ACBindings;

// CNetLayerPacket
public unsafe struct CNetLayerPacket
{
    // Base Classes
    public ACBindings.NetPacket BaseClass_NetPacket; // ACBindings.NetPacket

    // Child Types
    // CNetLayerPacket_vtbl
    public unsafe struct CNetLayerPacket_vtbl
    {
        // Members
        public System.IntPtr CNetLayerPacket_dtor_0; // function pointer

        // Methods
    }

    // Members
    public ACBindings.ProtoHeader m_Hdr;
    public fixed byte m_Data[65484];
    public int m_Addr;
    public ACBindings.CBufferIterator m_Iter;
    public byte m_bValid;
    public ACBindings.ReceiverData* m_pRecv;
    public ACBindings.RecipientData* m_pRecip;
    public uint m_CryptoKey;

    // Methods
    // CNetLayerPacket* __cdecl CNetLayerPacket::Create()
    public static ACBindings.CNetLayerPacket* Create() => ((delegate* unmanaged[Cdecl]<ACBindings.CNetLayerPacket*>)0x005AB6A0)();
    // void __thiscall CNetLayerPacket::Clear(CNetLayerPacket*)
    public void Clear() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CNetLayerPacket, void>)0x005AB6C0)(ref this);
}

