namespace ACBindings.Internal;


/// <summary>Contains identifiers, positional data, heading, velocity, status, and timing information for a tracked target within the simulation. Serves as the primary data structure for rendering, physics calculations, and state synchronization.</summary>
public unsafe struct TargetInfo
{
    // Members
    public uint context_id;
    public uint object_id;
    public float radius;
    public double quantum;
    public ACBindings.Internal.Position target_position;
    public ACBindings.Internal.Position interpolated_position;
    public ACBindings.Internal.AC1Legacy.Vector3 interpolated_heading;
    public ACBindings.Internal.AC1Legacy.Vector3 velocity;
    public ACBindings.Internal.TargetStatus status;
    public double last_update_time;

    // Generated Constructor
    public TargetInfo(ACBindings.Internal.TargetInfo* that) {
        _ConstructorInternal(that);
    }
    public TargetInfo() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Creates a new TargetInfo by copying all fields from an existing instance, ensuring position objects are properly duplicated.
    /// <code>Offset: 0x00511100
    /// void __thiscall TargetInfo::TargetInfo(TargetInfo*,const TargetInfo*)</code>
    /// </summary>
    /// <param name="that">The TargetInfo instance to copy from.</param>
    public void _ConstructorInternal(ACBindings.Internal.TargetInfo* that) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TargetInfo, ACBindings.Internal.TargetInfo*, void>)0x00511100)(ref this, that);

    /// <summary>Initializes a new TargetInfo instance with default values, setting identifiers to zero, radius and quantum to zero, and establishing neutral position frames with identity orientation and zero origin.
    /// <code>Offset: 0x0051AFC0
    /// void __thiscall TargetInfo::TargetInfo(TargetInfo*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TargetInfo, void>)0x0051AFC0)(ref this);
}

