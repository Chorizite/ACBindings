namespace ACBindings.Internal;

public unsafe struct JumpPack
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct JumpPack_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.JumpPack*, void> JumpPack_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.JumpPack*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.JumpPack*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.JumpPack*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public float extent;
    public ACBindings.Internal.AC1Legacy.Vector3 velocity;
    public ACBindings.Internal.Position position;
    public ushort instance_timestamp;
    public ushort server_control_timestamp;
    public ushort teleport_timestamp;
    public ushort force_position_ts;

    // Generated Constructor
    public JumpPack(float extent, ACBindings.Internal.AC1Legacy.Vector3* velocity, ACBindings.Internal.Position* position, ushort instance_timestamp, ushort server_control_timestamp, ushort teleport_timestamp, ushort force_position_ts) {
        _ConstructorInternal(extent, velocity, position, instance_timestamp, server_control_timestamp, teleport_timestamp, force_position_ts);
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00517770
    /// void __thiscall JumpPack::JumpPack(JumpPack*,float,const AC1Legacy::Vector3*,const Position*,unsigned __int16,unsigned __int16,unsigned __int16,unsigned __int16)</code>
    /// </summary>
    public void _ConstructorInternal(float extent, ACBindings.Internal.AC1Legacy.Vector3* velocity, ACBindings.Internal.Position* position, ushort instance_timestamp, ushort server_control_timestamp, ushort teleport_timestamp, ushort force_position_ts) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.JumpPack, float, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.Position*, ushort, ushort, ushort, ushort, void>)0x00517770)(ref this, extent, velocity, position, instance_timestamp, server_control_timestamp, teleport_timestamp, force_position_ts);

    /// <summary>
    /// <code>Offset: 0x00517810
    /// unsigned int __thiscall JumpPack::Pack(JumpPack*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.JumpPack, void**, uint, uint>)0x00517810)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005178F0
    /// int __thiscall JumpPack::UnPack(JumpPack*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.JumpPack, void**, uint, int>)0x005178F0)(ref this, addr, size);
}

