namespace ACBindings.Internal;

public unsafe struct ActionMapValue
{
    // Members
    public uint m_eToggleType;
    public ACBindings.Internal.UserBindingValue m_userBindingData;

    // Methods

    /// <summary>
    /// <code>Offset: 0x00685670
    /// char __thiscall ActionMapValue::GetDescriptionValues(int,int,wchar_t*,wchar_t*)</code>
    /// </summary>
    public sbyte GetDescriptionValues(int a2, System.IntPtr a3, System.IntPtr a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ActionMapValue, int, System.IntPtr, System.IntPtr, sbyte>)0x00685670)(ref this, a2, a3, a4);

    /// <summary>
    /// <code>Offset: 0x00685A80
    /// void __thiscall ActionMapValue::Serialize(ActionMapValue*,Archive*)</code>
    /// </summary>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ActionMapValue, ACBindings.Internal.Archive*, void>)0x00685A80)(ref this, io_archive);
}

