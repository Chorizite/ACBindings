namespace ACBindings.Internal;


/// <summary>Central repository for resolving character titles across races, genders, and rank levels within the allegiance system.</summary>
/// <remarks>All methods are static and operate by mapping numeric indices to predefined title strings used throughout the game’s UI and data files.</remarks>
public unsafe struct AllegianceSystem
{
    // Methods

    /// <summary>Retrieves the Aluvian male title for a specified rank, storing it in the supplied buffer.
    /// <code>Offset: 0x005B8D00
    /// int __cdecl AllegianceSystem::GetAluvianMaleTitle(int,int*)</code>
    /// </summary>
    /// <param name="a1">The rank index (1–10) whose title is requested.</param>
    /// <param name="a2">Pointer to a string buffer that receives the title; updated only when the rank is valid.</param>
    /// <returns>Non‑zero if the rank was within 1–10 and the title was set; zero otherwise.</returns>
    public static int GetAluvianMaleTitle(int a1, int* a2) => ((delegate* unmanaged[Cdecl]<int, int*, int>)0x005B8D00)(a1, a2);

    /// <summary>Retrieves the Aluvian female title corresponding to the supplied rank index and writes it into the provided string buffer.
    /// <code>Offset: 0x005B8E10
    /// int __cdecl AllegianceSystem::GetAluvianFemaleTitle(int,int*)</code>
    /// </summary>
    /// <param name="a1">The rank index (1–10) for which to obtain a title.</param>
    /// <param name="a2">Pointer to a string buffer that will receive the title text.</param>
    /// <returns>Non‑zero if the rank was recognized and the title written; zero otherwise.</returns>
    public static int GetAluvianFemaleTitle(int a1, int* a2) => ((delegate* unmanaged[Cdecl]<int, int*, int>)0x005B8E10)(a1, a2);

    /// <summary>Retrieves the male title for a Gharundim based on rank and writes it into the provided string buffer.
    /// <code>Offset: 0x005B8F20
    /// int __cdecl AllegianceSystem::GetGharundimMaleTitle(int,int*)</code>
    /// </summary>
    /// <param name="a1">Rank identifier (1–10) determining the title to return.</param>
    /// <param name="a2">Pointer to a string where the resulting title will be stored.</param>
    /// <returns>Returns 1 if the rank is valid and a title was set; otherwise returns 0.</returns>
    public static int GetGharundimMaleTitle(int a1, int* a2) => ((delegate* unmanaged[Cdecl]<int, int*, int>)0x005B8F20)(a1, a2);

    /// <summary>Retrieves a Gharundim female title for the specified index and writes it into the supplied string buffer.
    /// <code>Offset: 0x005B9030
    /// int __cdecl AllegianceSystem::GetGharundimFemaleTitle(int,int*)</code>
    /// </summary>
    /// <param name="a1">Index of desired title (valid values 1–10).</param>
    /// <param name="a2">Pointer to a string where the resulting title will be stored.</param>
    /// <returns>Integer indicating success (1) or failure (0) due to an invalid index.</returns>
    public static int GetGharundimFemaleTitle(int a1, int* a2) => ((delegate* unmanaged[Cdecl]<int, int*, int>)0x005B9030)(a1, a2);

    /// <summary>Returns the male title associated with a numeric identifier, writing it into the provided string buffer if valid.
    /// <code>Offset: 0x005B9140
    /// int __cdecl AllegianceSystem::GetShoMaleTitle(int,int*)</code>
    /// </summary>
    /// <param name="a1">The numeric code representing the desired title.</param>
    /// <param name="a2">Pointer to a string where the title will be stored on success.</param>
    /// <returns>Non‑zero (typically 1) when the identifier is found and the title is set; zero if the identifier does not match any known title.</returns>
    public static int GetShoMaleTitle(int a1, int* a2) => ((delegate* unmanaged[Cdecl]<int, int*, int>)0x005B9140)(a1, a2);

    /// <summary>Retrieves the female title string for the Sho race based on an identifier.
    /// <code>Offset: 0x005B9250
    /// int __cdecl AllegianceSystem::GetShoFemaleTitle(int,int*)</code>
    /// </summary>
    /// <param name="a1">The numeric identifier representing the desired title.</param>
    /// <param name="a2">Pointer to a string that receives the resolved title (e.g., "Jinin", "Jo-chueh").</param>
    /// <returns>Non‑zero if the identifier was recognized; zero otherwise.</returns>
    public static int GetShoFemaleTitle(int a1, int* a2) => ((delegate* unmanaged[Cdecl]<int, int*, int>)0x005B9250)(a1, a2);

    /// <summary>Retrieves the Viamontian male title for a given rank, storing it in the supplied string buffer.
    /// <code>Offset: 0x005B9360
    /// int __cdecl AllegianceSystem::GetViamontianMaleTitle(int,int*)</code>
    /// </summary>
    /// <param name="a1">Rank of the title (1-10).</param>
    /// <param name="a2">Pointer to a string where the title will be written.</param>
    /// <returns>Returns 1 if the rank is valid and the title has been set; otherwise returns 0.</returns>
    public static int GetViamontianMaleTitle(int a1, int* a2) => ((delegate* unmanaged[Cdecl]<int, int*, int>)0x005B9360)(a1, a2);

    /// <summary>Retrieves the Viamontian female noble title corresponding to the supplied rank and writes it into the provided string buffer.
    /// <code>Offset: 0x005B9470
    /// int __cdecl AllegianceSystem::GetViamontianFemaleTitle(int,int*)</code>
    /// </summary>
    /// <param name="a1">The rank identifier (1–10) determining which title to return.</param>
    /// <param name="a2">Pointer to a string buffer that will receive the title text.</param>
    /// <returns>Non‑zero if a valid rank was supplied and the title was written; zero otherwise.</returns>
    public static int GetViamontianFemaleTitle(int a1, int* a2) => ((delegate* unmanaged[Cdecl]<int, int*, int>)0x005B9470)(a1, a2);

    /// <summary>
    /// Retrieves the male Shadowbound title for the given rank index, storing it in the supplied string buffer.
    /// 
    /// <code>Offset: 0x005B9580
    /// int __cdecl AllegianceSystem::GetShadowboundMaleTitle(int,int*)</code>
    /// </summary>
    /// <param name="a1">
    /// Index of the Shadowbound rank (1 = Tenebrous, 2 = Shade, …, 10 = King).
    /// </param>
    /// <param name="a2">
    /// Pointer to a character buffer where the title will be written. The function sets the appropriate string into this location.
    /// </param>
    /// <returns>
    /// An integer: 1 if a valid rank was provided and the title written; otherwise 0 for an invalid rank index.
    /// </returns>
    public static int GetShadowboundMaleTitle(int a1, int* a2) => ((delegate* unmanaged[Cdecl]<int, int*, int>)0x005B9580)(a1, a2);

    /// <summary>Retrieves the female shadowbound title for the specified rank and writes it into the provided string buffer.
    /// <code>Offset: 0x005B9690
    /// int __cdecl AllegianceSystem::GetShadowboundFemaleTitle(int,int*)</code>
    /// </summary>
    /// <param name="a1">Rank identifier (valid values: 1–10).</param>
    /// <param name="a2">Pointer to a string object where the resulting title will be stored.</param>
    /// <returns>Returns 1 if the rank is recognized and the title was set; otherwise returns 0.</returns>
    public static int GetShadowboundFemaleTitle(int a1, int* a2) => ((delegate* unmanaged[Cdecl]<int, int*, int>)0x005B9690)(a1, a2);

    /// <summary>Retrieves the male Gearknight title corresponding to the specified rank index and writes it into the supplied string buffer.
    /// <code>Offset: 0x005B97A0
    /// int __cdecl AllegianceSystem::GetGearknightMaleTitle(int,int*)</code>
    /// </summary>
    /// <param name="a1">Index of the desired title (valid values 1 through 10).</param>
    /// <param name="a2">Pointer to a character array that receives the resulting title text.</param>
    /// <returns>Returns 1 when a valid index is provided and the title is written; returns 0 if the index is outside the supported range.</returns>
    public static int GetGearknightMaleTitle(int a1, int* a2) => ((delegate* unmanaged[Cdecl]<int, int*, int>)0x005B97A0)(a1, a2);

    /// <summary>Retrieves a Tumerok male title corresponding to the specified index and places it into the provided PStringBase&lt;char&gt; instance.
    /// <code>Offset: 0x005B98B0
    /// int __cdecl AllegianceSystem::GetTumerokMaleTitle(int,int*)</code>
    /// </summary>
    /// <param name="a1">The ordinal position (1‑10) of the desired Tumerok male title.</param>
    /// <param name="a2">Pointer to an AC1Legacy::PStringBase&lt;char&gt; object that will receive the title string; must be valid for the duration of the call.</param>
    /// <returns>Non‑zero if the index is within range (1–10); zero when the index is invalid.</returns>
    public static int GetTumerokMaleTitle(int a1, int* a2) => ((delegate* unmanaged[Cdecl]<int, int*, int>)0x005B98B0)(a1, a2);

    /// <summary>Retrieves the name of a Lugian male title corresponding to a given numeric ID.
    /// <code>Offset: 0x005B99C0
    /// int __cdecl AllegianceSystem::GetLugianMaleTitle(int,int*)</code>
    /// </summary>
    /// <param name="a1">The 1‑based identifier of the desired title (valid values are 1 through 10).</param>
    /// <param name="a2">A pointer to a string buffer that will receive the title text when found.</param>
    /// <returns>Non‑zero if the ID matched a known title and the string was set; zero if the ID is out of range.</returns>
    public static int GetLugianMaleTitle(int a1, int* a2) => ((delegate* unmanaged[Cdecl]<int, int*, int>)0x005B99C0)(a1, a2);

    /// <summary>
    /// Returns the Empyrean male title corresponding to the supplied rank identifier and writes it into the provided string buffer.
    /// 
    /// <code>Offset: 0x005B9AD0
    /// int __cdecl AllegianceSystem::GetEmpyreanMaleTitle(int,int*)</code>
    /// </summary>
    /// <param name="a1">The numeric rank identifier for an Empyrean male rank.</param>
    /// <param name="a2">Pointer to a string buffer that receives the resolved title text.</param>
    /// <returns>Non‑zero if the rank is valid and the title was written; zero otherwise.</returns>
    public static int GetEmpyreanMaleTitle(int a1, int* a2) => ((delegate* unmanaged[Cdecl]<int, int*, int>)0x005B9AD0)(a1, a2);

    /// <summary>Selects the female title for an Empyrean rank, writes it into a2, and indicates success.
    /// <code>Offset: 0x005B9BE0
    /// int __cdecl AllegianceSystem::GetEmpyreanFemaleTitle(int,int*)</code>
    /// </summary>
    /// <param name="a1">The rank index (1–10) mapping to specific titles.</param>
    /// <param name="a2">Pointer to a string buffer that receives the chosen title.</param>
    /// <returns>Non‑zero if a valid rank was provided and the title was set; zero otherwise.</returns>
    public static int GetEmpyreanFemaleTitle(int a1, int* a2) => ((delegate* unmanaged[Cdecl]<int, int*, int>)0x005B9BE0)(a1, a2);

    /// <summary>Assigns an undead male title based on the supplied rank and writes it into the provided string buffer.
    /// <code>Offset: 0x005B9CF0
    /// int __cdecl AllegianceSystem::GetUndeadMaleTitle(int,int*)</code>
    /// </summary>
    /// <param name="a1">The rank identifier (1–10) for which the title is requested.</param>
    /// <param name="a2">Pointer to a string object that will receive the resulting title text.</param>
    /// <returns>Non‑zero if the rank was recognized and a title was set; zero otherwise.</returns>
    public static int GetUndeadMaleTitle(int a1, int* a2) => ((delegate* unmanaged[Cdecl]<int, int*, int>)0x005B9CF0)(a1, a2);

    /// <summary>Assigns an undead female title string based on the provided rank identifier.
    /// <code>Offset: 0x005B9E00
    /// int __cdecl AllegianceSystem::GetUndeadFemaleTitle(int,int*)</code>
    /// </summary>
    /// <param name="a1">Identifier representing the character's rank level (e.g., 1 for Neophyte, 10 for Annointed).</param>
    /// <param name="a2">Output parameter that receives the corresponding title text.</param>
    /// <returns>Non-zero if a valid rank was supplied and the title string was set; otherwise zero.</returns>
    public static int GetUndeadFemaleTitle(int a1, int* a2) => ((delegate* unmanaged[Cdecl]<int, int*, int>)0x005B9E00)(a1, a2);

    /// <summary>Retrieves a character's title identifier based on gender and race/class, optionally returning additional data through an output pointer.
    /// <code>Offset: 0x005B9F10
    /// int __cdecl AllegianceSystem::GetTitle(int,int,int,int*)</code>
    /// </summary>
    /// <param name="a1">The unique identifier of the character requesting the title.</param>
    /// <param name="a2">Race or class identifier used to determine the specific title category.</param>
    /// <param name="a3">Gender indicator (1 for male, 2 for female).</param>
    /// <param name="a4">Pointer to an integer that receives additional information about the selected title.</param>
    /// <returns>Identifier of the chosen title; zero if no matching title is found.</returns>
    public static int GetTitle(int a1, int a2, int a3, int* a4) => ((delegate* unmanaged[Cdecl]<int, int, int, int*, int>)0x005B9F10)(a1, a2, a3, a4);
}

