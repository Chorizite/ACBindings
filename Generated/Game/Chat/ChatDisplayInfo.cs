namespace ACBindings.Internal;


/// <summary>Holds information required to render a chat message, including its timestamp, display text, and a flag controlling whether it should be shown.</summary>
public unsafe struct ChatDisplayInfo
{
    // Members
    public uint m_ltt;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte m_display;
    public int m_doDisplayText;

    // Methods

    /// <summary>Retrieves a reference‑counted pointer to the chat display text and increments its reference count.
    /// <code>Offset: 0x005CE710
    /// _DWORD* __thiscall ChatDisplayInfo::GetDisplayText(_DWORD*,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">Output buffer that receives the pointer to the display string.</param>
    /// <returns>The same pointer as a2, now pointing to the incremented string reference.</returns>
    public int* GetDisplayText(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatDisplayInfo, int*, int*>)0x005CE710)(ref this, a2);
}

