namespace ACBindings.Internal;

public unsafe struct CNetLayerPacket
{
    // Base Classes
    public ACBindings.Internal.NetPacket BaseClass_NetPacket; // ACBindings.Internal.NetPacket

    // Child Types
    public unsafe struct CNetLayerPacket_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CNetLayerPacket*, void> CNetLayerPacket_dtor_0; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.ProtoHeader m_Hdr;
    public fixed byte m_Data[65484];
    public int m_Addr;
    public ACBindings.Internal.CBufferIterator m_Iter;
    public byte m_bValid;
    public ACBindings.Internal.ReceiverData* m_pRecv;
    public ACBindings.Internal.RecipientData* m_pRecip;
    public uint m_CryptoKey;

    // Methods

    /// <summary>
    /// <code>Offset: 0x005AB6A0
    /// CNetLayerPacket* __cdecl CNetLayerPacket::Create()</code>
    /// </summary>
    public static ACBindings.Internal.CNetLayerPacket* Create() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CNetLayerPacket*>)0x005AB6A0)();

    /// <summary>
    /// <code>Offset: 0x005AB6C0
    /// void __thiscall CNetLayerPacket::Clear(CNetLayerPacket*)</code>
    /// </summary>
    public void Clear() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CNetLayerPacket, void>)0x005AB6C0)(ref this);
}

