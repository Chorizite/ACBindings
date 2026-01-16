namespace ACBindings.Internal;


/// <summary>Maintains shared state for server‑side character generation, extending the core CharGenState with RNG seeds and pull counters to support deterministic generation across multiple requests.</summary>
public unsafe struct ServerCharGenState
{
    // Base Classes
    public ACBindings.Internal.CharGenState BaseClass_CharGenState; // ACBindings.Internal.CharGenState

    // Child Types
    public unsafe struct ServerCharGenState_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ServerCharGenState*, void> UpdateTrueFacePal; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ServerCharGenState*, int, int> GetRandomInt; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ServerCharGenState*, double> GetRandomReal; // function pointer

        // Methods
    }

    // Members
    public uint m_seed1;
    public uint m_seed2;
    public uint m_cPulls;

    // Methods
}

