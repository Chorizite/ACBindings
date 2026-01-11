namespace ACBindings.Internal;

public unsafe struct AmbientSound
{
    // Child Types
    public unsafe struct AmbientSound_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AmbientSound*, void> ResetCount; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AmbientSound*, float> GetVolume; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AmbientSound*, int> CanHear; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AmbientSound*, int> PlayNow; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AmbientSound*, float> GetPlayInterval; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AmbientSound*, float, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.LandDefs.Direction, void> AddTo; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AmbientSound*, float, void> UpdateSound; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AmbientSound*, ACBindings.Internal.Position*, int> GetSoundPos; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public int on_queue;
    public float sound_count;
    public ACBindings.Internal.AmbientSTBDesc* desc;
    public uint ambient_sound_id;
    public int constant_sound;

    // Methods

    /// <summary>
    /// <code>Offset: 0x005518E0
    /// float __thiscall AmbientSound::GetVolume(AmbientSound*)</code>
    /// </summary>
    public float GetVolume() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AmbientSound, float>)0x005518E0)(ref this);
}

