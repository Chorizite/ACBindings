namespace ACBindings.Internal;

public unsafe struct MovieTheatre : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.Internal.ReferenceCountTemplate

    // Child Types
    public unsafe struct MovieTheatre_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.MovieTheatre*, void> MovieTheatre_dtor_0; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.UIElement* m_pOwner;
    public uint m_Flags;
    public byte m_bStopped;
    public System.IntPtr m_pGB;
    public System.IntPtr m_pMC;
    public System.IntPtr m_pMP;
    public System.IntPtr m_pME;
    public System.IntPtr m_pRenderer;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x006BD3B0
    /// void __thiscall MovieTheatre::~MovieTheatre(MovieTheatre*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MovieTheatre, void>)0x006BD3B0)(ref this);

    /// <summary>
    /// <code>Offset: 0x006BD480
    /// bool __thiscall MovieTheatre::HasFinishedPlaying(MovieTheatre*)</code>
    /// </summary>
    public byte HasFinishedPlaying() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MovieTheatre, byte>)0x006BD480)(ref this);

    /// <summary>
    /// <code>Offset: 0x006BD530
    /// char __thiscall MovieTheatre::Init(int,LPCSTR*,int,int)</code>
    /// </summary>
    public sbyte Init(sbyte** acp, int a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MovieTheatre, sbyte**, int, int, sbyte>)0x006BD530)(ref this, acp, a3, a4);

    /// <summary>
    /// <code>Offset: 0x006BD780
    /// _DWORD* __cdecl MovieTheatre::CreateTheatreForMovie(_DWORD*,LPCSTR*,int,int,int*)</code>
    /// </summary>
    public static int* CreateTheatreForMovie(int* a1, sbyte** a2, int a3, int a4, int* a5) => ((delegate* unmanaged[Cdecl]<int*, sbyte**, int, int, int*, int*>)0x006BD780)(a1, a2, a3, a4, a5);
}

