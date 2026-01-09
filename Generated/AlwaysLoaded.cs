namespace ACBindings;

// AlwaysLoaded
public unsafe struct AlwaysLoaded
{
    // Base Classes
    public ACBindings.BlockListLoader BaseClass_BlockListLoader; // ACBindings.BlockListLoader

    // Child Types
    // AlwaysLoaded_vtbl
    public unsafe struct AlwaysLoaded_vtbl
    {
        // Members
        public System.IntPtr AlwaysLoaded_dtor_0; // function pointer
        public System.IntPtr Reload; // function pointer
        public System.IntPtr fEntryInBlockList; // function pointer

        // Methods
    }

    // Members
    public ACBindings.CQuickTimer m_timerDoUseTime;
    public int fEnableDontTouch_;
    public double lastDontTouchMode_;
    public int fInDontTouchMode_;
    public double timeStartedNotTouchingCurrentBlock_;

    // Methods
}

