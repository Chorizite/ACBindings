namespace ACBindings.Internal;

public unsafe struct IntermitSound
{
    // Base Classes
    public ACBindings.Internal.AmbientSound BaseClass_AmbientSound; // ACBindings.Internal.AmbientSound

    // Child Types
    public unsafe struct IntermitSound_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IntermitSound*, void> ResetCount; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IntermitSound*, float> GetVolume; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IntermitSound*, int> CanHear; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IntermitSound*, int> PlayNow; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IntermitSound*, float> GetPlayInterval; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IntermitSound*, float, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.LandDefs.Direction, void> AddTo; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IntermitSound*, float, void> UpdateSound; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.IntermitSound*, ACBindings.Internal.Position*, int> GetSoundPos; // function pointer

        // Methods
    }

    // Members
    public float play_chance;
    public fixed float min_dist[8];
    public fixed float max_dist[8];
    public uint num_dir;
    public fixed byte sound_dir_Raw[32];
    public ACBindings.Internal.LandDefs.Direction* sound_dir => (ACBindings.Internal.LandDefs.Direction*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref sound_dir_Raw[0]);

    // Methods

    /// <summary>
    /// <code>Offset: 0x00551910
    /// void __thiscall IntermitSound::AddDir(IntermitSound*,LandDefs::Direction,float,float)</code>
    /// </summary>
    public void AddDir(ACBindings.Internal.LandDefs.Direction dir, float min, float max) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.IntermitSound, ACBindings.Internal.LandDefs.Direction, float, float, void>)0x00551910)(ref this, dir, min, max);

    /// <summary>
    /// <code>Offset: 0x00551BA0
    /// int __thiscall IntermitSound::CanHear(IntermitSound*)</code>
    /// </summary>
    public int CanHear() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.IntermitSound, int>)0x00551BA0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00551BC0
    /// int __thiscall IntermitSound::PlayNow(IntermitSound*)</code>
    /// </summary>
    public int PlayNow() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.IntermitSound, int>)0x00551BC0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00551C90
    /// float __thiscall IntermitSound::GetVolume(IntermitSound*)</code>
    /// </summary>
    public float GetVolume() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.IntermitSound, float>)0x00551C90)(ref this);

    /// <summary>
    /// <code>Offset: 0x00551CA0
    /// float __thiscall IntermitSound::GetPlayInterval(IntermitSound*)</code>
    /// </summary>
    public float GetPlayInterval() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.IntermitSound, float>)0x00551CA0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00551F30
    /// void __thiscall IntermitSound::UpdateSound(IntermitSound*,float)</code>
    /// </summary>
    public void UpdateSound(float total_weight) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.IntermitSound, float, void>)0x00551F30)(ref this, total_weight);

    /// <summary>
    /// <code>Offset: 0x00551F70
    /// int __thiscall IntermitSound::GetSoundPos(IntermitSound*,Position*)</code>
    /// </summary>
    public int GetSoundPos(ACBindings.Internal.Position* base_pos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.IntermitSound, ACBindings.Internal.Position*, int>)0x00551F70)(ref this, base_pos);

    /// <summary>
    /// <code>Offset: 0x00552070
    /// void __thiscall IntermitSound::AddTo(IntermitSound*,float,const AC1Legacy::Vector3*,LandDefs::Direction)</code>
    /// </summary>
    public void AddTo(float weight, ACBindings.Internal.AC1Legacy.Vector3* diff, ACBindings.Internal.LandDefs.Direction dir) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.IntermitSound, float, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.LandDefs.Direction, void>)0x00552070)(ref this, weight, diff, dir);
}

