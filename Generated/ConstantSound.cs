namespace ACBindings;

// ConstantSound
public unsafe struct ConstantSound
{
    // Base Classes
    public ACBindings.AmbientSound BaseClass_AmbientSound; // ACBindings.AmbientSound

    // Child Types
    // ConstantSound_vtbl
    public unsafe struct ConstantSound_vtbl
    {
        // Members
        public System.IntPtr ResetCount; // function pointer
        public System.IntPtr GetVolume; // function pointer
        public System.IntPtr CanHear; // function pointer
        public System.IntPtr PlayNow; // function pointer
        public System.IntPtr GetPlayInterval; // function pointer
        public System.IntPtr AddTo; // function pointer
        public System.IntPtr UpdateSound; // function pointer
        public System.IntPtr GetSoundPos; // function pointer

        // Methods
    }

    // Members
    public float current_volume;

    // Methods
    // float __thiscall ConstantSound::GetVolume(ConstantSound*)
    public float GetVolume() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ConstantSound, float>)0x005519A0)(ref this);
    // int __thiscall ConstantSound::CanHear(ConstantSound*)
    public int CanHear() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ConstantSound, int>)0x00551BF0)(ref this);
    // void __thiscall ConstantSound::AddTo(ConstantSound*,float,const AC1Legacy::Vector3*,LandDefs::Direction)
    public void AddTo(float weight, ACBindings.AC1Legacy.Vector3* diff, ACBindings.LandDefs.Direction dir) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ConstantSound, float, ACBindings.AC1Legacy.Vector3*, ACBindings.LandDefs.Direction, void>)0x00551C20)(ref this, weight, diff, dir);
    // float __thiscall ConstantSound::GetPlayInterval(ConstantSound*)
    public float GetPlayInterval() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ConstantSound, float>)0x00551CC0)(ref this);
    // void __thiscall ConstantSound::UpdateSound(ConstantSound*,float)
    public void UpdateSound(float total_weight) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ConstantSound, float, void>)0x00552160)(ref this, total_weight);
}

