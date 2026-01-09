namespace ACBindings;

// MovieTheatre
public unsafe struct MovieTheatre : System.IDisposable
{
    // Base Classes
    public ACBindings.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.ReferenceCountTemplate

    // Child Types
    // MovieTheatre_vtbl
    public unsafe struct MovieTheatre_vtbl
    {
        // Members
        public System.IntPtr MovieTheatre_dtor_0; // function pointer

        // Methods
    }

    // Members
    public ACBindings.UIElement* m_pOwner;
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
    // void __thiscall MovieTheatre::~MovieTheatre(MovieTheatre*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MovieTheatre, void>)0x006BD3B0)(ref this);
    // bool __thiscall MovieTheatre::HasFinishedPlaying(MovieTheatre*)
    public byte HasFinishedPlaying() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MovieTheatre, byte>)0x006BD480)(ref this);
    // char __thiscall MovieTheatre::Init(int,LPCSTR*,int,int)
    public sbyte Init(sbyte** acp, int a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MovieTheatre, sbyte**, int, int, sbyte>)0x006BD530)(ref this, acp, a3, a4);
    // _DWORD* __cdecl MovieTheatre::CreateTheatreForMovie(_DWORD*,LPCSTR*,int,int,int*)
    public static int* CreateTheatreForMovie(int* a1, sbyte** a2, int a3, int a4, int* a5) => ((delegate* unmanaged[Cdecl]<int*, sbyte**, int, int, int*, int*>)0x006BD780)(a1, a2, a3, a4, a5);
}

