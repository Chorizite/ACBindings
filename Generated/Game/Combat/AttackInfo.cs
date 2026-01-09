namespace ACBindings;

// AttackInfo
public unsafe struct AttackInfo
{
    // Members
    public uint attack_id;
    public int part_index;
    public float attack_radius;
    public uint waiting_for_cells;
    public uint num_objects;
    public ACBindings.DArray__ObjectInfo object_list;

    // Generated Constructor
    public AttackInfo(uint attack_id, int part_index, float attack_radius) {
        _ConstructorInternal(attack_id, part_index, attack_radius);
    }

    // Methods
    // void __thiscall AttackInfo::AttackInfo(AttackInfo*,unsigned int,int,float)
    public void _ConstructorInternal(uint attack_id, int part_index, float attack_radius) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AttackInfo, uint, int, float, void>)0x0051ACB0)(ref this, attack_id, part_index, attack_radius);
    // void __thiscall AttackInfo::AddObject(AttackInfo*,unsigned int,unsigned int)
    public void AddObject(uint object_id, uint hit_location) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AttackInfo, uint, uint, void>)0x0051AD00)(ref this, object_id, hit_location);
}

