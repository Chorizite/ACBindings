namespace ACBindings.Internal;


/// <summary>Represents the client‑side character generation state, extending CharGenState with face palette handling and change tracking.</summary>
/// <remarks>Maintains separate gray and true‑color palettes for rendering and increments trueFacePalChangeNum whenever the palette is updated during customization.</remarks>
public unsafe struct ClientCharGenState : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.CharGenState BaseClass_CharGenState; // ACBindings.Internal.CharGenState

    // Child Types
    public unsafe struct ClientCharGenState_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientCharGenState*, void> UpdateTrueFacePal; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientCharGenState*, int, int> GetRandomInt; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ClientCharGenState*, double> GetRandomReal; // function pointer

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

    /// <summary>Constructs a client character generation state, initializing the base CharGenState and setting up face palettes for gray and true colors.
    /// <code>Offset: 0x00564660
    /// void __thiscall ClientCharGenState::ClientCharGenState(ClientCharGenState*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCharGenState, void>)0x00564660)(ref this);

    /// <summary>Destroys a ClientCharGenState instance, releasing its gray and true face palettes and cleaning up inherited resources.
    /// <code>Offset: 0x00564700
    /// void __thiscall ClientCharGenState::~ClientCharGenState(ClientCharGenState*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCharGenState, void>)0x00564700)(ref this);

    /// <summary>Retrieves a 32‑bit color from the palette identified by ArgList, returning the specified entry or zero when the palette cannot be loaded.
    /// <code>Offset: 0x00564730
    /// unsigned int __stdcall ClientCharGenState::GetColorFromPal(int,unsigned int)</code>
    /// </summary>
    /// <param name="ArgList">Identifier used to locate the desired Palette object in the database.</param>
    /// <param name="color_index">Index of the color within the found Palette to retrieve.</param>
    /// <returns>32‑bit ARGB color value if successful; otherwise zero after logging an error message.</returns>
    public static uint GetColorFromPal(int ArgList, uint color_index) => ((delegate* unmanaged[Stdcall]<int, uint, uint>)0x00564730)(ArgList, color_index);

    /// <summary>
    /// Updates the character's face palette to reflect the current heritage group, gender, skin shade, hair color/shade, and eye color selections. If any component changes from the previously applied palette, the trueFacePal is modified and the change counter is incremented.
    /// 
    /// <code>Offset: 0x005647C0
    /// void __thiscall ClientCharGenState::UpdateTrueFacePal(ClientCharGenState*)</code>
    /// </summary>
    public void UpdateTrueFacePal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ClientCharGenState, void>)0x005647C0)(ref this);
}

