namespace ACBindings;

// IntermitSound
public unsafe struct IntermitSound
{
    // Base Classes
    public ACBindings.AmbientSound BaseClass_AmbientSound; // ACBindings.AmbientSound

    // Child Types
    // IntermitSound_vtbl
    public unsafe struct IntermitSound_vtbl
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
    public float play_chance;
    public fixed float min_dist[8];
    public fixed float max_dist[8];
    public uint num_dir;
    public fixed byte sound_dir_Raw[32];
    public ACBindings.LandDefs.Direction* sound_dir => (ACBindings.LandDefs.Direction*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref sound_dir_Raw[0]);

    // Methods
    // void __thiscall IntermitSound::AddDir(IntermitSound*,LandDefs::Direction,float,float)
    public void AddDir(ACBindings.LandDefs.Direction dir, float min, float max) => ((delegate* unmanaged[Thiscall]<ref ACBindings.IntermitSound, ACBindings.LandDefs.Direction, float, float, void>)0x00551910)(ref this, dir, min, max);
    // int __thiscall IntermitSound::CanHear(IntermitSound*)
    public int CanHear() => ((delegate* unmanaged[Thiscall]<ref ACBindings.IntermitSound, int>)0x00551BA0)(ref this);
    // int __thiscall IntermitSound::PlayNow(IntermitSound*)
    public int PlayNow() => ((delegate* unmanaged[Thiscall]<ref ACBindings.IntermitSound, int>)0x00551BC0)(ref this);
    // float __thiscall IntermitSound::GetVolume(IntermitSound*)
    public float GetVolume() => ((delegate* unmanaged[Thiscall]<ref ACBindings.IntermitSound, float>)0x00551C90)(ref this);
    // float __thiscall IntermitSound::GetPlayInterval(IntermitSound*)
    public float GetPlayInterval() => ((delegate* unmanaged[Thiscall]<ref ACBindings.IntermitSound, float>)0x00551CA0)(ref this);
    // void __thiscall IntermitSound::UpdateSound(IntermitSound*,float)
    public void UpdateSound(float total_weight) => ((delegate* unmanaged[Thiscall]<ref ACBindings.IntermitSound, float, void>)0x00551F30)(ref this, total_weight);
    // int __thiscall IntermitSound::GetSoundPos(IntermitSound*,Position*)
    public int GetSoundPos(ACBindings.Position* base_pos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.IntermitSound, ACBindings.Position*, int>)0x00551F70)(ref this, base_pos);
    // void __thiscall IntermitSound::AddTo(IntermitSound*,float,const AC1Legacy::Vector3*,LandDefs::Direction)
    public void AddTo(float weight, ACBindings.AC1Legacy.Vector3* diff, ACBindings.LandDefs.Direction dir) => ((delegate* unmanaged[Thiscall]<ref ACBindings.IntermitSound, float, ACBindings.AC1Legacy.Vector3*, ACBindings.LandDefs.Direction, void>)0x00552070)(ref this, weight, diff, dir);
}

