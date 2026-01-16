namespace ACBindings.Internal;


/// <summary>Encapsulates a clickable button within the UI, leveraging QuickWindow for geometry while tracking press and check states and rendering its label.</summary>
public unsafe struct QuickButton : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.QuickWindow BaseClass_QuickWindow; // ACBindings.Internal.QuickWindow

    // Child Types
    public unsafe struct QuickButton_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.QuickButton*, void> QuickButton_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.QuickButton*, void> Render; // function pointer

        // Methods
    }

    // Members
    public byte m_IsPressed;
    public byte m_IsChecked;
    public ACBindings.Internal.PStringBase__sbyte m_ButtonLabel;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Detects a left‑mouse click inside the button’s rectangle; if the point lies within the bounds, records the press and returns true.
    /// <code>Offset: 0x00699C40
    /// bool __thiscall QuickButton::LeftMouseButtonPressed(QuickButton*,const int,const int)</code>
    /// </summary>
    /// <param name="X">The X coordinate of the mouse click.</param>
    /// <param name="Y">The Y coordinate of the mouse click.</param>
    /// <returns>True when the click is inside the button area; otherwise false.</returns>
    public byte LeftMouseButtonPressed(int X, int Y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QuickButton, int, int, byte>)0x00699C40)(ref this, X, Y);

    /// <summary>Handles left‑mouse‑button release for a QuickButton, resetting the pressed state and determining if the release occurred within the button’s bounds.
    /// <code>Offset: 0x00699C80
    /// bool __thiscall QuickButton::LeftMouseButtonReleased(QuickButton*,const int,const int)</code>
    /// </summary>
    /// <param name="X">The X coordinate of the mouse cursor at release time.</param>
    /// <param name="Y">The Y coordinate of the mouse cursor at release time.</param>
    /// <returns>True when the button was previously pressed and the cursor is inside its area; otherwise false.</returns>
    public byte LeftMouseButtonReleased(int X, int Y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QuickButton, int, int, byte>)0x00699C80)(ref this, X, Y);

    /// <summary>Renders the QuickButton’s appearance by applying color adjustments based on its pressed or checked state and drawing its background and label text.
    /// <code>Offset: 0x00699CE0
    /// void __thiscall QuickButton::Render(QuickButton*)</code>
    /// </summary>
    public void Render() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QuickButton, void>)0x00699CE0)(ref this);

    /// <summary>Destroys a QuickButton, releasing its button label string and background texture resources while resetting the pressed and checked flags.
    /// <code>Offset: 0x00699FE0
    /// void __thiscall QuickButton::~QuickButton(QuickButton*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QuickButton, void>)0x00699FE0)(ref this);

    /// <summary>Initializes the button with position, size, and border dimensions while synchronizing its internal reference counter with an external value.
    /// <code>Offset: 0x0069A060
    /// char __thiscall QuickButton::InitButton(QuickWindow*,int,int,unsigned int,unsigned int,unsigned int,unsigned int,unsigned int*)</code>
    /// </summary>
    /// <param name="this">Pointer to the QuickButton instance being initialized.</param>
    /// <param name="X">The X coordinate of the button's top-left corner.</param>
    /// <param name="Y">The Y coordinate of the button's top-left corner.</param>
    /// <param name="Width">The width of the button.</param>
    /// <param name="Height">The height of the button.</param>
    /// <param name="BorderWidth">The width of the button's border.</param>
    /// <param name="BorderHeight">The height of the button's border.</param>
    /// <param name="a8">Pointer to an unsigned integer containing a reference count value that will be used to update the button's internal counter.</param>
    /// <returns>Non-zero if initialization succeeds; zero if QuickWindow::Init fails or any error occurs during reference count adjustment.</returns>
    public sbyte InitButton(int X, int Y, uint Width, uint Height, uint BorderWidth, uint BorderHeight, uint* a8) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QuickButton, int, int, uint, uint, uint, uint, uint*, sbyte>)0x0069A060)(ref this, X, Y, Width, Height, BorderWidth, BorderHeight, a8);

    /// <summary>Creates a QuickButton instance, initializes it with the supplied geometry and properties, and reports status via the first argument while returning the created object through the second argument.
    /// <code>Offset: 0x0069A100
    /// _DWORD* __cdecl QuickButton::Create(_DWORD*,QuickWindow**,int,int,unsigned int,unsigned int,unsigned int,unsigned int,unsigned int*)</code>
    /// </summary>
    /// <param name="a1">Pointer to a DWORD where the result code is stored; 0 indicates success, negative values indicate failure.</param>
    /// <param name="a2">Output parameter that receives the newly constructed QuickWindow instance (or null on failure).</param>
    /// <param name="a3">X coordinate passed to InitButton for button placement.</param>
    /// <param name="a4">Y coordinate passed to InitButton for button placement.</param>
    /// <param name="a5">Width value forwarded to InitButton.</param>
    /// <param name="a6">Height value forwarded to InitButton.</param>
    /// <param name="a7">Border width value forwarded to InitButton.</param>
    /// <param name="a8">Border height value forwarded to InitButton.</param>
    /// <param name="a9">Pointer to an unsigned integer passed to InitButton for additional configuration.</param>
    /// <returns>The same pointer as supplied via a1, containing 0 on success or an error code otherwise.</returns>
    public static int* Create(int* a1, ACBindings.Internal.QuickWindow** a2, int a3, int a4, uint a5, uint a6, uint a7, uint a8, uint* a9) => ((delegate* unmanaged[Cdecl]<int*, ACBindings.Internal.QuickWindow**, int, int, uint, uint, uint, uint, uint*, int*>)0x0069A100)(a1, a2, a3, a4, a5, a6, a7, a8, a9);
}

