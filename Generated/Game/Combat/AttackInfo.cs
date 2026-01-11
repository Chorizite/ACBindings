namespace ACBindings.Internal;

public unsafe struct AttackInfo
{
    // Members
    public uint attack_id;
    public int part_index;
    public float attack_radius;
    public uint waiting_for_cells;
    public uint num_objects;
    public ACBindings.Internal.DArray___ObjectInfo object_list;

    // Generated Constructor
    public AttackInfo(uint attack_id, int part_index, float attack_radius) {
        _ConstructorInternal(attack_id, part_index, attack_radius);
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0051ACB0
    /// void __thiscall AttackInfo::AttackInfo(AttackInfo*,unsigned int,int,float)</code>
    /// </summary>
    public void _ConstructorInternal(uint attack_id, int part_index, float attack_radius) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AttackInfo, uint, int, float, void>)0x0051ACB0)(ref this, attack_id, part_index, attack_radius);

    /// <summary>
    /// <code>Offset: 0x0051AD00
    /// void __thiscall AttackInfo::AddObject(AttackInfo*,unsigned int,unsigned int)</code>
    /// </summary>
    public void AddObject(uint object_id, uint hit_location) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AttackInfo, uint, uint, void>)0x0051AD00)(ref this, object_id, hit_location);
}

