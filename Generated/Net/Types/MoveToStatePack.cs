namespace ACBindings;

// MoveToStatePack
public unsafe struct MoveToStatePack
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // MoveToStatePack_vtbl
    public unsafe struct MoveToStatePack_vtbl
    {
        // Members
        public System.IntPtr MoveToStatePack_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.RawMotionState raw_motion_state;
    public ACBindings.Position position;
    public int contact;
    public int longjump_mode;
    public ushort instance_timestamp;
    public ushort server_control_timestamp;
    public ushort teleport_timestamp;
    public ushort force_position_ts;

    // Generated Constructor
    public MoveToStatePack(ACBindings.RawMotionState* raw_motion_state, ACBindings.Position* position, int contact, int longjump_mode, ushort instance_timestamp, ushort server_control_timestamp, ushort teleport_timestamp, ushort force_position_ts) {
        _ConstructorInternal(raw_motion_state, position, contact, longjump_mode, instance_timestamp, server_control_timestamp, teleport_timestamp, force_position_ts);
    }

    // Methods
    // unsigned int __thiscall MoveToStatePack::pack_size(MoveToStatePack*)
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MoveToStatePack, uint>)0x005173A0)(ref this);
    // unsigned int __thiscall MoveToStatePack::Pack(MoveToStatePack*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MoveToStatePack, void**, uint, uint>)0x005173F0)(ref this, addr, size);
    // int __thiscall MoveToStatePack::UnPack(MoveToStatePack*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MoveToStatePack, void**, uint, int>)0x005174B0)(ref this, addr, size);
    // void __thiscall MoveToStatePack::MoveToStatePack(MoveToStatePack*,const RawMotionState*,const Position*,int,int,unsigned __int16,unsigned __int16,unsigned __int16,unsigned __int16)
    public void _ConstructorInternal(ACBindings.RawMotionState* raw_motion_state, ACBindings.Position* position, int contact, int longjump_mode, ushort instance_timestamp, ushort server_control_timestamp, ushort teleport_timestamp, ushort force_position_ts) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MoveToStatePack, ACBindings.RawMotionState*, ACBindings.Position*, int, int, ushort, ushort, ushort, ushort, void>)0x00517AF0)(ref this, raw_motion_state, position, contact, longjump_mode, instance_timestamp, server_control_timestamp, teleport_timestamp, force_position_ts);
}

