namespace ACBindings;

// QuestProfile
public unsafe struct QuestProfile
{
    // Base Classes
    public ACBindings.PackObj BaseClass_PackObj; // ACBindings.PackObj

    // Child Types
    // QuestProfile_vtbl
    public unsafe struct QuestProfile_vtbl
    {
        // Members
        public System.IntPtr QuestProfile_dtor_0; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr GetPackSize; // function pointer
        public System.IntPtr Pack; // function pointer
        public System.IntPtr UnPack; // function pointer

        // Methods
    }

    // Members
    public double _last_update;
    public int _real_time;
    public uint _num_completions;

    // Methods
}

