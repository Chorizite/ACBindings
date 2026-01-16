namespace ACBindings.Internal;


/// <summary>Maintains a collection of user interface preference items, offering functionality to attach, detach, query, modify, and validate preferences through key‑based lookup.</summary>
public unsafe struct UIPreferences
{
    // Statics
    public static ACBindings.Internal.HashTable___PStringBase__sbyte___UIPreferenceItem_ptr* m_uiPreferences = (ACBindings.Internal.HashTable___PStringBase__sbyte___UIPreferenceItem_ptr*)0x00825148;

    // Methods

    /// <summary>Retrieves three DWORD preference values associated with the specified key. If the key exists in the preferences table, the values are stored through the provided output pointers and the function returns true; otherwise it returns false.
    /// <code>Offset: 0x005DE940
    /// char __cdecl UIPreferences::InqPreference(char**,_DWORD*,_DWORD*,_DWORD*)</code>
    /// </summary>
    /// <param name="a1">Pointer to a string containing the preference key.</param>
    /// <param name="a2">Output parameter receiving first DWORD value.</param>
    /// <param name="a3">Output parameter receiving second DWORD value.</param>
    /// <param name="a4">Output parameter receiving third DWORD value.</param>
    /// <returns>Non‑zero if the key was found and values were retrieved; zero otherwise.</returns>
    public static sbyte InqPreference(sbyte** a1, int* a2, int* a3, int* a4) => ((delegate* unmanaged[Cdecl]<sbyte**, int*, int*, int*, sbyte>)0x005DE940)(a1, a2, a3, a4);

    /// <summary>Sets numeric range for a UI preference identified by its key.
    /// <code>Offset: 0x005DE990
    /// char __cdecl UIPreferences::SetPreferenceRange(char**,int,int)</code>
    /// </summary>
    /// <param name="a1">Pointer to the C-string key of the preference to modify.</param>
    /// <param name="a2">Minimum allowed value for the preference.</param>
    /// <param name="a3">Maximum allowed value for the preference.</param>
    /// <returns>Non-zero if range was successfully set; zero otherwise.</returns>
    public static sbyte SetPreferenceRange(sbyte** a1, int a2, int a3) => ((delegate* unmanaged[Cdecl]<sbyte**, int, int, sbyte>)0x005DE990)(a1, a2, a3);

    /// <summary>Retrieves the valid range for a specified UI preference by delegating to its associated object. Returns zero when the preference is absent; otherwise forwards the request and yields the object's result (or one if no object is present).
    /// <code>Offset: 0x005DE9E0
    /// char __cdecl UIPreferences::InqPreferenceRange(char**,int,int)</code>
    /// </summary>
    /// <param name="a1">Pointer to the preference identifier string.</param>
    /// <param name="a2">First argument supplied to the preference object's range query method.</param>
    /// <param name="a3">Second argument supplied to the preference object's range query method.</param>
    /// <returns>Zero if the preference is not found; otherwise returns the result of the underlying object's range inquiry, or one when the associated object pointer is null.</returns>
    public static sbyte InqPreferenceRange(sbyte** a1, int a2, int a3) => ((delegate* unmanaged[Cdecl]<sbyte**, int, int, sbyte>)0x005DE9E0)(a1, a2, a3);

    /// <summary>Queries the UI preferences table for an entry identified by the supplied key and, if found, forwards a range check to the associated preference object.
    /// <code>Offset: 0x005DEA30
    /// char __cdecl UIPreferences::InqPreferenceRange_1(char**,int,int)</code>
    /// </summary>
    /// <param name="a1">Pointer to the key string used to look up the preference in the internal hash table.</param>
    /// <param name="a2">Lower bound of the value range to query.</param>
    /// <param name="a3">Upper bound of the value range to query.</param>
    /// <returns>Zero if no matching preference is found; otherwise returns the result of the object's range query method.</returns>
    public static sbyte InqPreferenceRange_1(sbyte** a1, int a2, int a3) => ((delegate* unmanaged[Cdecl]<sbyte**, int, int, sbyte>)0x005DEA30)(a1, a2, a3);

    /// <summary>Sets the selected index for an enumeration preference identified by a key string.
    /// <code>Offset: 0x005DEA80
    /// char __cdecl UIPreferences::SetEnumChoices(char**,int)</code>
    /// </summary>
    /// <param name="a1">Pointer to the key string specifying which enum preference to update.</param>
    /// <param name="a2">Index of the choice to select within the enum.</param>
    /// <returns>Non‑zero if the preference was found and updated; otherwise zero.</returns>
    public static sbyte SetEnumChoices(sbyte** a1, int a2) => ((delegate* unmanaged[Cdecl]<sbyte**, int, sbyte>)0x005DEA80)(a1, a2);

    /// <summary>Retrieves the available choices for an enumerated UI preference identified by a key string.
    /// <code>Offset: 0x005DEAC0
    /// char __cdecl UIPreferences::InqEnumChoices(char**,int)</code>
    /// </summary>
    /// <param name="a1">Pointer to the key that identifies which enumeration to query.</param>
    /// <param name="a2">Argument passed to the underlying enum object, typically used to receive or specify choice information.</param>
    /// <returns>Non‑zero if the enumeration data was found and returned successfully; otherwise zero.</returns>
    public static sbyte InqEnumChoices(sbyte** a1, int a2) => ((delegate* unmanaged[Cdecl]<sbyte**, int, sbyte>)0x005DEAC0)(a1, a2);

    /// <summary>Modifies the UI preference identified by the given key, delegating the change to the associated object if it exists.
    /// <code>Offset: 0x005DEB90
    /// char __cdecl UIPreferences::ModifyPreference(char**,int)</code>
    /// </summary>
    /// <param name="a1">Pointer to the preference key string.</param>
    /// <param name="a2">New value or flag for the preference update.</param>
    /// <returns>Non‑zero if the preference was found and updated; zero otherwise.</returns>
    public static sbyte ModifyPreference(sbyte** a1, int a2) => ((delegate* unmanaged[Cdecl]<sbyte**, int, sbyte>)0x005DEB90)(a1, a2);

    /// <summary>Attempts to apply an integer update to a stored user interface preference identified by the supplied key. If the preference exists, its handler is invoked with the new value; otherwise no action occurs.
    /// <code>Offset: 0x005DEBD0
    /// char __cdecl UIPreferences::ModifyPreference_1(char**,int)</code>
    /// </summary>
    /// <param name="a1">Pointer to the string key that identifies the preference entry.</param>
    /// <param name="a2">Integer value passed to the preference’s update routine.</param>
    /// <returns>Result of the preference’s update method, truncated to a char, or zero if the key cannot be found.</returns>
    public static sbyte ModifyPreference_1(sbyte** a1, int a2) => ((delegate* unmanaged[Cdecl]<sbyte**, int, sbyte>)0x005DEBD0)(a1, a2);

    /// <summary>Modifies a UI preference identified by the key pointed to by the first argument, setting its value to the integer supplied in the second argument.
    /// <code>Offset: 0x005DEC10
    /// char __cdecl UIPreferences::ModifyPreference_2(char**,int)</code>
    /// </summary>
    /// <param name="a1">Pointer to the string representing the preference key.</param>
    /// <param name="a2">New integer value to assign to the preference.</param>
    /// <returns>Non‑zero if the preference was found and updated successfully; otherwise zero.</returns>
    public static sbyte ModifyPreference_2(sbyte** a1, int a2) => ((delegate* unmanaged[Cdecl]<sbyte**, int, sbyte>)0x005DEC10)(a1, a2);

    /// <summary>Attempts to modify an existing UI preference identified by key string, invoking the stored object's update routine with a new integer value.
    /// <code>Offset: 0x005DEC50
    /// char __cdecl UIPreferences::ModifyPreference_3(char**,int)</code>
    /// </summary>
    /// <param name="a1">Pointer to the preference key string used for lookup in the preferences table.</param>
    /// <param name="a2">Integer value supplied to the preference's update method.</param>
    /// <returns>Non‑zero if the preference was found and updated; zero if no matching preference exists.</returns>
    public static sbyte ModifyPreference_3(sbyte** a1, int a2) => ((delegate* unmanaged[Cdecl]<sbyte**, int, sbyte>)0x005DEC50)(a1, a2);

    /// <summary>Retrieves the value of a UI preference identified by key, delegating to the stored preference object.
    /// <code>Offset: 0x005DEC90
    /// char __cdecl UIPreferences::InqPreferenceValue(char**,int)</code>
    /// </summary>
    /// <param name="a1">Pointer to the preference key string.</param>
    /// <param name="a2">Additional argument passed to the preference object's retrieval routine.</param>
    /// <returns>Character representing the retrieved preference value if found; otherwise 0.</returns>
    public static sbyte InqPreferenceValue(sbyte** a1, int a2) => ((delegate* unmanaged[Cdecl]<sbyte**, int, sbyte>)0x005DEC90)(a1, a2);

    /// <summary>Retrieves the stored UI preference value for a given key and returns it as a character, or zero if the key is not present.
    /// <code>Offset: 0x005DECD0
    /// char __cdecl UIPreferences::InqPreferenceValue_1(char**,int)</code>
    /// </summary>
    /// <param name="a1">Pointer to the string that identifies the preference entry.</param>
    /// <param name="a2">Additional parameter passed to the lookup routine (often an index or flag used by the underlying value object).</param>
    /// <returns>The retrieved preference character when found; otherwise zero.</returns>
    public static sbyte InqPreferenceValue_1(sbyte** a1, int a2) => ((delegate* unmanaged[Cdecl]<sbyte**, int, sbyte>)0x005DECD0)(a1, a2);

    /// <summary>Retrieves a UI preference value identified by the key string pointed to by a1 and forwards the request to the associated preference object using a2 as an argument.
    /// <code>Offset: 0x005DED10
    /// char __cdecl UIPreferences::InqPreferenceValue_2(char**,int)</code>
    /// </summary>
    /// <param name="a1">Pointer to the C‑string key used for lookup.</param>
    /// <param name="a2">Argument forwarded to the underlying preference object's query method (often an index or type identifier).</param>
    /// <returns>Non‑zero if the preference exists and was successfully queried; zero otherwise.</returns>
    public static sbyte InqPreferenceValue_2(sbyte** a1, int a2) => ((delegate* unmanaged[Cdecl]<sbyte**, int, sbyte>)0x005DED10)(a1, a2);

    /// <summary>Retrieves the UI preference value identified by its name and an optional index.
    /// <code>Offset: 0x005DED50
    /// char __cdecl UIPreferences::InqPreferenceValue_3(char**,int)</code>
    /// </summary>
    /// <param name="a1">Pointer to the null‑terminated preference name string.</param>
    /// <param name="a2">Index or sub‑identifier specifying which value to request from the matched preference entry.</param>
    /// <returns>On success, returns the value supplied by the matching preference object's retrieval method; zero if no such preference exists.</returns>
    public static sbyte InqPreferenceValue_3(sbyte** a1, int a2) => ((delegate* unmanaged[Cdecl]<sbyte**, int, sbyte>)0x005DED50)(a1, a2);

    /// <summary>Attaches a new UI preference item identified by the supplied name if not already present. The function selects the appropriate preference type based on the second argument, constructs and initializes the item with the remaining parameters, then registers it in the internal preferences table.
    /// <code>Offset: 0x005DEE50
    /// char __cdecl UIPreferences::AttachPreference(char**,int,int,int,int)</code>
    /// </summary>
    /// <param name="a1">Pointer to the name string of the preference to attach.</param>
    /// <param name="a2">Numeric code indicating the preference type (e.g., 1=int, 2=enum, 3=float, 4=bool, 5=string).</param>
    /// <param name="a3">First additional parameter used during item initialization; its meaning depends on the preference type.</param>
    /// <param name="a4">Second additional parameter for initialization; its meaning depends on the preference type.</param>
    /// <param name="a5">Third additional parameter for initialization; its meaning depends on the preference type.</param>
    /// <returns>Non‑zero if the attachment succeeded, or zero if the preference already existed or an error occurred during creation or initialization.</returns>
    public static sbyte AttachPreference(sbyte** a1, int a2, int a3, int a4, int a5) => ((delegate* unmanaged[Cdecl]<sbyte**, int, int, int, int, sbyte>)0x005DEE50)(a1, a2, a3, a4, a5);

    /// <summary>Removes a UI preference identified by the supplied key, freeing its resources and indicating success.
    /// <code>Offset: 0x005DEF70
    /// char __cdecl UIPreferences::DetachPreference(char**)</code>
    /// </summary>
    /// <param name="a1">Pointer to the key string of the preference to detach.</param>
    /// <returns>Non‑zero if a matching preference was found and removed; zero otherwise.</returns>
    public static sbyte DetachPreference(sbyte** a1) => ((delegate* unmanaged[Cdecl]<sbyte**, sbyte>)0x005DEF70)(a1);
}

