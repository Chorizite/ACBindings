namespace ACBindings.Internal;

public unsafe struct CSWVertex
{
    // Members
    public ACBindings.Internal._DB07F05AFE1DBE8AF4B8F0A046C9EB4D ___u0;
    public short vert_id;
    public ushort num_uvs;
    public ACBindings.Internal.CVec2Duv* uvs;
    public ACBindings.Internal.AC1Legacy.Vector3 normal;

    // Methods

    /// <summary>
    /// <code>Offset: 0x0053EA90
    /// void __thiscall CSWVertex::Init(CSWVertex*)</code>
    /// </summary>
    public void Init() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSWVertex, void>)0x0053EA90)(ref this);

    /// <summary>
    /// <code>Offset: 0x0053EAA0
    /// unsigned int __thiscall CSWVertex::pack_size(CSWVertex*)</code>
    /// </summary>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSWVertex, uint>)0x0053EAA0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0053EAB0
    /// unsigned int __thiscall CSWVertex::Pack(CSWVertex*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSWVertex, void**, uint, uint>)0x0053EAB0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x0053EB90
    /// void __thiscall CSWVertex::Destroy(CSWVertex*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSWVertex, void>)0x0053EB90)(ref this);

    /// <summary>
    /// <code>Offset: 0x0053EBB0
    /// int __thiscall CSWVertex::UnPack(CSWVertex*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSWVertex, void**, uint, int>)0x0053EBB0)(ref this, addr, size);
}

