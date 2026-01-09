namespace ACBindings;

// ServerCharGenState
public unsafe struct ServerCharGenState
{
    // Base Classes
    public ACBindings.CharGenState BaseClass_CharGenState; // ACBindings.CharGenState

    // Child Types
    // ServerCharGenState_vtbl
    public unsafe struct ServerCharGenState_vtbl
    {
        // Members
        public System.IntPtr UpdateTrueFacePal; // function pointer
        public System.IntPtr GetRandomInt; // function pointer
        public System.IntPtr GetRandomReal; // function pointer

        // Methods
    }

    // Members
    public uint m_seed1;
    public uint m_seed2;
    public uint m_cPulls;

    // Methods
}

