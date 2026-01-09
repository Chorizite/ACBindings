namespace ACBindings;

// PositionPack
public unsafe struct PositionPack
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // PositionPack_vtbl
    public unsafe struct PositionPack_vtbl
    {
        // Members
        public System.IntPtr PositionPack_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public ushort instance_timestamp;
    public ushort position_timestamp;
    public ushort teleport_timestamp;
    public ushort force_position_timestamp;
    public ACBindings.Position position;
    public ACBindings.AC1Legacy.Vector3 velocity;
    public uint placement_id;
    public int has_contact;

    // Generated Constructor
    public PositionPack() {
        _ConstructorInternal();
    }

    // Methods
    // unsigned int __cdecl PositionPack::GetPackSize(unsigned int*,const Position*,const AC1Legacy::Vector3*,unsigned int,int,unsigned __int16,unsigned __int16,unsigned __int16,unsigned __int16)
    public static uint GetPackSize(uint* bitfield, ACBindings.Position* p, ACBindings.AC1Legacy.Vector3* velocity, uint placement_id, int has_contact, ushort instance_timestamp, ushort position_timestamp, ushort teleport_timestamp, ushort force_position_timestamp) => ((delegate* unmanaged[Cdecl]<uint*, ACBindings.Position*, ACBindings.AC1Legacy.Vector3*, uint, int, ushort, ushort, ushort, ushort, uint>)0x00516F40)(bitfield, p, velocity, placement_id, has_contact, instance_timestamp, position_timestamp, teleport_timestamp, force_position_timestamp);
    // void __thiscall PositionPack::PositionPack(PositionPack*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PositionPack, void>)0x00517080)(ref this);
    // void __cdecl PositionPack::PackPosition(void**,unsigned int,unsigned int,const Position*,const AC1Legacy::Vector3*,unsigned int,int,unsigned __int16,unsigned __int16,unsigned __int16,unsigned __int16)
    public static void PackPosition(void** addr, uint size, uint bitfield, ACBindings.Position* p, ACBindings.AC1Legacy.Vector3* velocity, uint placement_id, int has_contact, ushort instance_timestamp, ushort position_timestamp, ushort teleport_timestamp, ushort force_position_timestamp) => ((delegate* unmanaged[Cdecl]<void**, uint, uint, ACBindings.Position*, ACBindings.AC1Legacy.Vector3*, uint, int, ushort, ushort, ushort, ushort, void>)0x005170C0)(addr, size, bitfield, p, velocity, placement_id, has_contact, instance_timestamp, position_timestamp, teleport_timestamp, force_position_timestamp);
    // unsigned int __thiscall PositionPack::Pack(PositionPack*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PositionPack, void**, uint, uint>)0x005171B0)(ref this, addr, size);
    // int __thiscall PositionPack::UnPack(PositionPack*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.PositionPack, void**, uint, int>)0x00517240)(ref this, addr, size);
}

