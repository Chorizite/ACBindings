namespace ACBindings.Internal;

public unsafe struct QuickButton : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.QuickWindow BaseClass_QuickWindow; // ACBindings.Internal.QuickWindow

    // Child Types
    public unsafe struct QuickButton_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.QuickButton*, void> QuickButton_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.QuickButton*, void> Render; // function pointer

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

    /// <summary>
    /// <code>Offset: 0x00699C40
    /// bool __thiscall QuickButton::LeftMouseButtonPressed(QuickButton*,const int,const int)</code>
    /// </summary>
    public byte LeftMouseButtonPressed(int X, int Y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QuickButton, int, int, byte>)0x00699C40)(ref this, X, Y);

    /// <summary>
    /// <code>Offset: 0x00699C80
    /// bool __thiscall QuickButton::LeftMouseButtonReleased(QuickButton*,const int,const int)</code>
    /// </summary>
    public byte LeftMouseButtonReleased(int X, int Y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QuickButton, int, int, byte>)0x00699C80)(ref this, X, Y);

    /// <summary>
    /// <code>Offset: 0x00699CE0
    /// void __thiscall QuickButton::Render(QuickButton*)</code>
    /// </summary>
    public void Render() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QuickButton, void>)0x00699CE0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00699FE0
    /// void __thiscall QuickButton::~QuickButton(QuickButton*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QuickButton, void>)0x00699FE0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0069A060
    /// char __thiscall QuickButton::InitButton(QuickWindow*,int,int,unsigned int,unsigned int,unsigned int,unsigned int,unsigned int*)</code>
    /// </summary>
    public sbyte InitButton(int X, int Y, uint Width, uint Height, uint BorderWidth, uint BorderHeight, uint* a8) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QuickButton, int, int, uint, uint, uint, uint, uint*, sbyte>)0x0069A060)(ref this, X, Y, Width, Height, BorderWidth, BorderHeight, a8);

    /// <summary>
    /// <code>Offset: 0x0069A100
    /// _DWORD* __cdecl QuickButton::Create(_DWORD*,QuickWindow**,int,int,unsigned int,unsigned int,unsigned int,unsigned int,unsigned int*)</code>
    /// </summary>
    public static int* Create(int* a1, ACBindings.Internal.QuickWindow** a2, int a3, int a4, uint a5, uint a6, uint a7, uint a8, uint* a9) => ((delegate* unmanaged[Cdecl]<int*, ACBindings.Internal.QuickWindow**, int, int, uint, uint, uint, uint, uint*, int*>)0x0069A100)(a1, a2, a3, a4, a5, a6, a7, a8, a9);
}

