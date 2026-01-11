namespace ACBindings.Internal;

public unsafe struct AlwaysLoaded
{
    // Base Classes
    public ACBindings.Internal.BlockListLoader BaseClass_BlockListLoader; // ACBindings.Internal.BlockListLoader

    // Child Types
    public unsafe struct AlwaysLoaded_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AlwaysLoaded*, void> AlwaysLoaded_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AlwaysLoaded*, sbyte*, int> Reload; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AlwaysLoaded*, uint, int> fEntryInBlockList; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.CQuickTimer m_timerDoUseTime;
    public int fEnableDontTouch_;
    public double lastDontTouchMode_;
    public int fInDontTouchMode_;
    public double timeStartedNotTouchingCurrentBlock_;

    // Methods
}

