namespace ACBindings.Internal;

public unsafe struct ClientCharGenState : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.CharGenState BaseClass_CharGenState; // ACBindings.Internal.CharGenState

    // Child Types
    public unsafe struct ClientCharGenState_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientCharGenState*, void> UpdateTrueFacePal; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientCharGenState*, int, int> GetRandomInt; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientCharGenState*, double> GetRandomReal; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.Palette* grayFacePal;
    public ACBindings.Internal.Palette* trueFacePal;
    public int trueFacePalChangeNum;

    // Generated Constructor
    public ClientCharGenState() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00564660
    /// void __thiscall ClientCharGenState::ClientCharGenState(ClientCharGenState*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCharGenState, void>)0x00564660)(ref this);

    /// <summary>
    /// <code>Offset: 0x00564700
    /// void __thiscall ClientCharGenState::~ClientCharGenState(ClientCharGenState*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCharGenState, void>)0x00564700)(ref this);

    /// <summary>
    /// <code>Offset: 0x00564730
    /// unsigned int __stdcall ClientCharGenState::GetColorFromPal(int,unsigned int)</code>
    /// </summary>
    public static uint GetColorFromPal(int ArgList, uint color_index) => ((delegate* unmanaged[Stdcall]<int, uint, uint>)0x00564730)(ArgList, color_index);

    /// <summary>
    /// <code>Offset: 0x005647C0
    /// void __thiscall ClientCharGenState::UpdateTrueFacePal(ClientCharGenState*)</code>
    /// </summary>
    public void UpdateTrueFacePal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCharGenState, void>)0x005647C0)(ref this);
}

