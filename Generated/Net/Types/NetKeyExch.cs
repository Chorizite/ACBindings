namespace ACBindings.Internal;


/// <summary>Facilitates Diffie‑Hellman key exchange by storing a private random number and an initialization flag. Holds a reference to shared DH parameters via PortalDH and supports serialization through Pack/UnPack.</summary>
public unsafe struct NetKeyExch
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct NetKeyExch_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.NetKeyExch*, void> NetKeyExch_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.NetKeyExch*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.NetKeyExch*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.NetKeyExch*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.PortalDH* dh_;
    public ACBindings.Internal.AC1Legacy.vlong rnum_;
    public int fInitialized_;

    // Generated Constructor
    public NetKeyExch(ACBindings.Internal.PortalDH* dh) {
        _ConstructorInternal(dh);
    }

    // Methods

    /// <summary>Stores the supplied private random number for the key exchange and marks the object as initialized.
    /// <code>Offset: 0x0054A440
    /// void __thiscall NetKeyExch::SetPrivateRandom(NetKeyExch*,const AC1Legacy::vlong*)</code>
    /// </summary>
    /// <param name="rnum">The random value to assign to the object's internal state.</param>
    public void SetPrivateRandom(ACBindings.Internal.AC1Legacy.vlong* rnum) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NetKeyExch, ACBindings.Internal.AC1Legacy.vlong*, void>)0x0054A440)(ref this, rnum);

    /// <summary>Serializes NetKeyExch state into the supplied buffer and returns required byte count.
    /// <code>Offset: 0x0054A460
    /// unsigned int __thiscall NetKeyExch::Pack(NetKeyExch*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Address of a memory location where serialized data will be written; updated to point after the written block if successful.</param>
    /// <param name="size">Number of bytes available at *addr for serialization.</param>
    /// <returns>Byte size needed to serialize NetKeyExch, including the 4‑byte fInitialized field.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NetKeyExch, void**, uint, uint>)0x0054A460)(ref this, addr, size);

    /// <summary>Deserializes key‑exchange data into the object, initializing its random number and state flag.
    /// <code>Offset: 0x0054A4B0
    /// int __thiscall NetKeyExch::UnPack(NetKeyExch*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to a buffer containing serialized data; updated to point after the consumed bytes.</param>
    /// <param name="size">Maximum number of bytes available in the buffer.</param>
    /// <returns>Non‑zero if unpacking succeeds; otherwise returns the error code from the underlying unpack operation.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NetKeyExch, void**, uint, int>)0x0054A4B0)(ref this, addr, size);

    /// <summary>Constructs a NetKeyExch instance, storing the supplied Diffie‑Hellman parameters and resetting internal state.
    /// <code>Offset: 0x0054A4F0
    /// void __thiscall NetKeyExch::NetKeyExch(NetKeyExch*,PortalDH*)</code>
    /// </summary>
    /// <param name="dh">The PortalDH containing shared base and prime values used for key generation.</param>
    public void _ConstructorInternal(ACBindings.Internal.PortalDH* dh) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NetKeyExch, ACBindings.Internal.PortalDH*, void>)0x0054A4F0)(ref this, dh);

    /// <summary>Computes the number of bytes required to serialize this NetKeyExch by invoking the Pack method on its internal vlong base object and adding a four‑byte overhead.
    /// <code>Offset: 0x0054A520
    /// unsigned int __thiscall NetKeyExch::GetPackSize(NetKeyExch*)</code>
    /// </summary>
    /// <returns>The total packet size in bytes.</returns>
    public uint GetPackSize() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.NetKeyExch, uint>)0x0054A520)(ref this);
}

