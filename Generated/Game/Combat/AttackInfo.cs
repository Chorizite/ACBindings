namespace ACBindings.Internal;


/// <summary>Captures details for an attack: identifier, target body part index, effective radius, pending cell update counter, and a dynamic list of affected objects.</summary>
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

    /// <summary>Initializes an AttackInfo instance with a specific ID, part index, and radius, resetting cell wait counters and preparing an empty object list.
    /// <code>Offset: 0x0051ACB0
    /// void __thiscall AttackInfo::AttackInfo(AttackInfo*,unsigned int,int,float)</code>
    /// </summary>
    /// <param name="attack_id">Unique identifier for the attack type.</param>
    /// <param name="part_index">Index of the body part or component affected by the attack.</param>
    /// <param name="attack_radius">Radius within which objects will be considered affected.</param>
    public void _ConstructorInternal(uint attack_id, int part_index, float attack_radius) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AttackInfo, uint, int, float, void>)0x0051ACB0)(ref this, attack_id, part_index, attack_radius);

    /// <summary>Adds an object with the given ID and hit location to the attack's object list unless it already exists; expands the internal array when needed.
    /// <code>Offset: 0x0051AD00
    /// void __thiscall AttackInfo::AddObject(AttackInfo*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="object_id">The unique identifier of the object involved in the attack.</param>
    /// <param name="hit_location">A code indicating where on the target the attack struck.</param>
    public void AddObject(uint object_id, uint hit_location) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AttackInfo, uint, uint, void>)0x0051AD00)(ref this, object_id, hit_location);
}

