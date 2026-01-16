namespace ACBindings.Internal;


/// <summary>Represents a movie theatre component that manages UI ownership, flags, playback state, and associated graphics, media, and renderer resources.</summary>
public unsafe struct MovieTheatre : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.Internal.ReferenceCountTemplate

    // Child Types
    public unsafe struct MovieTheatre_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.MovieTheatre*, void> MovieTheatre_dtor_0; // function pointer

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

    /// <summary>Releases all COM interfaces owned by the MovieTheatre instance, including media control, event, position, graph builder, renderer, and base reference count objects, then restores the base class vtable pointer to its original state.
    /// <code>Offset: 0x006BD3B0
    /// void __thiscall MovieTheatre::~MovieTheatre(MovieTheatre*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MovieTheatre, void>)0x006BD3B0)(ref this);

    /// <summary>Determines whether the associated media has finished playing, taking into account whether playback has been stopped or no media event interface is available.
    /// <code>Offset: 0x006BD480
    /// bool __thiscall MovieTheatre::HasFinishedPlaying(MovieTheatre*)</code>
    /// </summary>
    /// <returns>True if playback has completed or was already stopped; otherwise false.</returns>
    public byte HasFinishedPlaying() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MovieTheatre, byte>)0x006BD480)(ref this);

    /// <summary>Initializes the movie theatre by creating a DirectShow graph, adding a texture renderer and loading the media file specified by acp. Connects filters to prepare for playback.
    /// <code>Offset: 0x006BD530
    /// char __thiscall MovieTheatre::Init(int,LPCSTR*,int,int)</code>
    /// </summary>
    /// <param name="acp">Pointer to a null‑terminated string containing the path of the media file to load.</param>
    /// <param name="a3">Output parameter that temporarily receives the source filter interface; it is released before the function returns.</param>
    /// <param name="a4">Temporary COM interface pointer used during initialization; it is released before the function returns.</param>
    /// <returns>Non‑zero if initialization succeeded, zero otherwise.</returns>
    public sbyte Init(sbyte** acp, int a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MovieTheatre, sbyte**, int, int, sbyte>)0x006BD530)(ref this, acp, a3, a4);

    /// <summary>Creates a new MovieTheatre instance, initializes it with the supplied movie data and parameters, and stores its address in *a5. On success assigns zero to *a1; on failure sets an error code and releases any allocated resources.
    /// <code>Offset: 0x006BD780
    /// _DWORD* __cdecl MovieTheatre::CreateTheatreForMovie(_DWORD*,LPCSTR*,int,int,int*)</code>
    /// </summary>
    /// <param name="a1">Pointer to a status variable that will be set to 0 on success or an HRESULT-like error code on failure.</param>
    /// <param name="a2">Array of string pointers providing movie-related data used during initialization.</param>
    /// <param name="a3">Integer value passed to the Init routine, representing one dimension (e.g., width).</param>
    /// <param name="a4">Integer value passed to the Init routine, representing another dimension (e.g., height).</param>
    /// <param name="a5">Pointer that receives the allocated MovieTheatre object's address as an int; set to 0 if creation fails.</param>
    /// <returns>Returns the original pointer provided in a1; callers should inspect *a1 for success status.</returns>
    public static int* CreateTheatreForMovie(int* a1, sbyte** a2, int a3, int a4, int* a5) => ((delegate* unmanaged[Cdecl]<int*, sbyte**, int, int, int*, int*>)0x006BD780)(a1, a2, a3, a4, a5);
}

