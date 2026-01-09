namespace ACBindings;

// JumpPack
public unsafe struct JumpPack
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // JumpPack_vtbl
    public unsafe struct JumpPack_vtbl
    {
        // Members
        public System.IntPtr JumpPack_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public float extent;
    public ACBindings.AC1Legacy.Vector3 velocity;
    public ACBindings.Position position;
    public ushort instance_timestamp;
    public ushort server_control_timestamp;
    public ushort teleport_timestamp;
    public ushort force_position_ts;

    // Generated Constructor
    public JumpPack(float extent, ACBindings.AC1Legacy.Vector3* velocity, ACBindings.Position* position, ushort instance_timestamp, ushort server_control_timestamp, ushort teleport_timestamp, ushort force_position_ts) {
        _ConstructorInternal(extent, velocity, position, instance_timestamp, server_control_timestamp, teleport_timestamp, force_position_ts);
    }

    // Methods
    // void __thiscall JumpPack::JumpPack(JumpPack*,float,const AC1Legacy::Vector3*,const Position*,unsigned __int16,unsigned __int16,unsigned __int16,unsigned __int16)
    public void _ConstructorInternal(float extent, ACBindings.AC1Legacy.Vector3* velocity, ACBindings.Position* position, ushort instance_timestamp, ushort server_control_timestamp, ushort teleport_timestamp, ushort force_position_ts) => ((delegate* unmanaged[Thiscall]<ref ACBindings.JumpPack, float, ACBindings.AC1Legacy.Vector3*, ACBindings.Position*, ushort, ushort, ushort, ushort, void>)0x00517770)(ref this, extent, velocity, position, instance_timestamp, server_control_timestamp, teleport_timestamp, force_position_ts);
    // unsigned int __thiscall JumpPack::Pack(JumpPack*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.JumpPack, void**, uint, uint>)0x00517810)(ref this, addr, size);
    // int __thiscall JumpPack::UnPack(JumpPack*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.JumpPack, void**, uint, int>)0x005178F0)(ref this, addr, size);
}

