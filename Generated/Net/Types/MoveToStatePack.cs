namespace ACBindings.Internal;

public unsafe struct MoveToStatePack
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct MoveToStatePack_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.MoveToStatePack*, void> MoveToStatePack_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.MoveToStatePack*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.MoveToStatePack*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.MoveToStatePack*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.RawMotionState raw_motion_state;
    public ACBindings.Internal.Position position;
    public int contact;
    public int longjump_mode;
    public ushort instance_timestamp;
    public ushort server_control_timestamp;
    public ushort teleport_timestamp;
    public ushort force_position_ts;

    // Generated Constructor
    public MoveToStatePack(ACBindings.Internal.RawMotionState* raw_motion_state, ACBindings.Internal.Position* position, int contact, int longjump_mode, ushort instance_timestamp, ushort server_control_timestamp, ushort teleport_timestamp, ushort force_position_ts) {
        _ConstructorInternal(raw_motion_state, position, contact, longjump_mode, instance_timestamp, server_control_timestamp, teleport_timestamp, force_position_ts);
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x005173A0
    /// unsigned int __thiscall MoveToStatePack::pack_size(MoveToStatePack*)</code>
    /// </summary>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MoveToStatePack, uint>)0x005173A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005173F0
    /// unsigned int __thiscall MoveToStatePack::Pack(MoveToStatePack*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MoveToStatePack, void**, uint, uint>)0x005173F0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005174B0
    /// int __thiscall MoveToStatePack::UnPack(MoveToStatePack*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MoveToStatePack, void**, uint, int>)0x005174B0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x00517AF0
    /// void __thiscall MoveToStatePack::MoveToStatePack(MoveToStatePack*,const RawMotionState*,const Position*,int,int,unsigned __int16,unsigned __int16,unsigned __int16,unsigned __int16)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.RawMotionState* raw_motion_state, ACBindings.Internal.Position* position, int contact, int longjump_mode, ushort instance_timestamp, ushort server_control_timestamp, ushort teleport_timestamp, ushort force_position_ts) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MoveToStatePack, ACBindings.Internal.RawMotionState*, ACBindings.Internal.Position*, int, int, ushort, ushort, ushort, ushort, void>)0x00517AF0)(ref this, raw_motion_state, position, contact, longjump_mode, instance_timestamp, server_control_timestamp, teleport_timestamp, force_position_ts);
}

