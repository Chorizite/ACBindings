namespace ACBindings;

// AutonomousPositionPack
public unsafe struct AutonomousPositionPack
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // AutonomousPositionPack_vtbl
    public unsafe struct AutonomousPositionPack_vtbl
    {
        // Members
        public System.IntPtr AutonomousPositionPack_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Position position;
    public int contact;
    public ushort instance_timestamp;
    public ushort server_control_timestamp;
    public ushort teleport_timestamp;
    public ushort force_position_ts;

    // Generated Constructor
    public AutonomousPositionPack(ACBindings.Position* position, int contact, ushort instance_timestamp, ushort server_control_timestamp, ushort teleport_timestamp, ushort force_position_ts) {
        _ConstructorInternal(position, contact, instance_timestamp, server_control_timestamp, teleport_timestamp, force_position_ts);
    }

    // Methods
    // void __thiscall AutonomousPositionPack::AutonomousPositionPack(AutonomousPositionPack*,const Position*,int,unsigned __int16,unsigned __int16,unsigned __int16,unsigned __int16)
    public void _ConstructorInternal(ACBindings.Position* position, int contact, ushort instance_timestamp, ushort server_control_timestamp, ushort teleport_timestamp, ushort force_position_ts) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AutonomousPositionPack, ACBindings.Position*, int, ushort, ushort, ushort, ushort, void>)0x00517570)(ref this, position, contact, instance_timestamp, server_control_timestamp, teleport_timestamp, force_position_ts);
    // unsigned int __thiscall AutonomousPositionPack::Pack(AutonomousPositionPack*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AutonomousPositionPack, void**, uint, uint>)0x005175F0)(ref this, addr, size);
    // int __thiscall AutonomousPositionPack::UnPack(AutonomousPositionPack*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AutonomousPositionPack, void**, uint, int>)0x005176A0)(ref this, addr, size);
}

