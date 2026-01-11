namespace ACBindings.Internal;

public unsafe struct QuestProfile
{
    // Base Classes
    public ACBindings.Internal.PackObj BaseClass_PackObj; // ACBindings.Internal.PackObj

    // Child Types
    public unsafe struct QuestProfile_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.QuestProfile*, void> QuestProfile_dtor_0; // function pointer
        public fixed byte gap4[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.QuestProfile*, uint> GetPackSize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.QuestProfile*, void**, uint, uint> Pack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.QuestProfile*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public double _last_update;
    public int _real_time;
    public uint _num_completions;

    // Methods
}

