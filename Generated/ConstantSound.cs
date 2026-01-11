namespace ACBindings.Internal;

public unsafe struct ConstantSound
{
    // Base Classes
    public ACBindings.Internal.AmbientSound BaseClass_AmbientSound; // ACBindings.Internal.AmbientSound

    // Child Types
    public unsafe struct ConstantSound_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ConstantSound*, void> ResetCount; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ConstantSound*, float> GetVolume; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ConstantSound*, int> CanHear; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ConstantSound*, int> PlayNow; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ConstantSound*, float> GetPlayInterval; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ConstantSound*, float, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.LandDefs.Direction, void> AddTo; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ConstantSound*, float, void> UpdateSound; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ConstantSound*, ACBindings.Internal.Position*, int> GetSoundPos; // function pointer

        // Methods
    }

    // Members
    public float current_volume;

    // Methods

    /// <summary>
    /// <code>Offset: 0x005519A0
    /// float __thiscall ConstantSound::GetVolume(ConstantSound*)</code>
    /// </summary>
    public float GetVolume() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ConstantSound, float>)0x005519A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00551BF0
    /// int __thiscall ConstantSound::CanHear(ConstantSound*)</code>
    /// </summary>
    public int CanHear() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ConstantSound, int>)0x00551BF0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00551C20
    /// void __thiscall ConstantSound::AddTo(ConstantSound*,float,const AC1Legacy::Vector3*,LandDefs::Direction)</code>
    /// </summary>
    public void AddTo(float weight, ACBindings.Internal.AC1Legacy.Vector3* diff, ACBindings.Internal.LandDefs.Direction dir) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ConstantSound, float, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.LandDefs.Direction, void>)0x00551C20)(ref this, weight, diff, dir);

    /// <summary>
    /// <code>Offset: 0x00551CC0
    /// float __thiscall ConstantSound::GetPlayInterval(ConstantSound*)</code>
    /// </summary>
    public float GetPlayInterval() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ConstantSound, float>)0x00551CC0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00552160
    /// void __thiscall ConstantSound::UpdateSound(ConstantSound*,float)</code>
    /// </summary>
    public void UpdateSound(float total_weight) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ConstantSound, float, void>)0x00552160)(ref this, total_weight);
}

