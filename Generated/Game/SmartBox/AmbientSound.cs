namespace ACBindings;

// AmbientSound
public unsafe struct AmbientSound
{
    // Child Types
    // AmbientSound_vtbl
    public unsafe struct AmbientSound_vtbl
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
    public System.IntPtr __vftable; // vtable pointer
    public int on_queue;
    public float sound_count;
    public ACBindings.AmbientSTBDesc* desc;
    public uint ambient_sound_id;
    public int constant_sound;

    // Methods
    // float __thiscall AmbientSound::GetVolume(AmbientSound*)
    public float GetVolume() => ((delegate* unmanaged[Thiscall]<ref ACBindings.AmbientSound, float>)0x005518E0)(ref this);
}

