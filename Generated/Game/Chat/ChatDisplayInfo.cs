namespace ACBindings;

// ChatDisplayInfo
public unsafe struct ChatDisplayInfo
{
    // Members
    public uint m_ltt;
    public ACBindings.AC1Legacy.PStringBase__sbyte m_display;
    public int m_doDisplayText;

    // Methods
    // _DWORD* __thiscall ChatDisplayInfo::GetDisplayText(_DWORD*,_DWORD*)
    public int* GetDisplayText(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ChatDisplayInfo, int*, int*>)0x005CE710)(ref this, a2);
}

