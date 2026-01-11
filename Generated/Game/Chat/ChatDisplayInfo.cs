namespace ACBindings.Internal;

public unsafe struct ChatDisplayInfo
{
    // Members
    public uint m_ltt;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte m_display;
    public int m_doDisplayText;

    // Methods

    /// <summary>
    /// <code>Offset: 0x005CE710
    /// _DWORD* __thiscall ChatDisplayInfo::GetDisplayText(_DWORD*,_DWORD*)</code>
    /// </summary>
    public int* GetDisplayText(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ChatDisplayInfo, int*, int*>)0x005CE710)(ref this, a2);
}

