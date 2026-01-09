namespace ACBindings;

// TargetInfo
public unsafe struct TargetInfo
{
    // Members
    public uint context_id;
    public uint object_id;
    public float radius;
    public double quantum;
    public ACBindings.Position target_position;
    public ACBindings.Position interpolated_position;
    public ACBindings.AC1Legacy.Vector3 interpolated_heading;
    public ACBindings.AC1Legacy.Vector3 velocity;
    public ACBindings.TargetStatus status;
    public double last_update_time;

    // Generated Constructor
    public TargetInfo(ACBindings.TargetInfo* that) {
        _ConstructorInternal(that);
    }
    public TargetInfo() {
        _ConstructorInternal();
    }

    // Methods
    // void __thiscall TargetInfo::TargetInfo(TargetInfo*,const TargetInfo*)
    public void _ConstructorInternal(ACBindings.TargetInfo* that) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TargetInfo, ACBindings.TargetInfo*, void>)0x00511100)(ref this, that);
    // void __thiscall TargetInfo::TargetInfo(TargetInfo*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.TargetInfo, void>)0x0051AFC0)(ref this);
}

