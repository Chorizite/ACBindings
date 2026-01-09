namespace ACBindings;

// CSWVertex
public unsafe struct CSWVertex
{
    // Members
    public ACBindings._DB07F05AFE1DBE8AF4B8F0A046C9EB4D ___u0;
    public short vert_id;
    public ushort num_uvs;
    public ACBindings.CVec2Duv* uvs;
    public ACBindings.AC1Legacy.Vector3 normal;

    // Methods
    // void __thiscall CSWVertex::Init(CSWVertex*)
    public void Init() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSWVertex, void>)0x0053EA90)(ref this);
    // unsigned int __thiscall CSWVertex::pack_size(CSWVertex*)
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSWVertex, uint>)0x0053EAA0)(ref this);
    // unsigned int __thiscall CSWVertex::Pack(CSWVertex*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSWVertex, void**, uint, uint>)0x0053EAB0)(ref this, addr, size);
    // void __thiscall CSWVertex::Destroy(CSWVertex*)
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSWVertex, void>)0x0053EB90)(ref this);
    // int __thiscall CSWVertex::UnPack(CSWVertex*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CSWVertex, void**, uint, int>)0x0053EBB0)(ref this, addr, size);
}

