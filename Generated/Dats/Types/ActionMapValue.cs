namespace ACBindings;

// ActionMapValue
public unsafe struct ActionMapValue
{
    // Members
    public uint m_eToggleType;
    public ACBindings.UserBindingValue m_userBindingData;

    // Methods
    // char __thiscall ActionMapValue::GetDescriptionValues(int,int,wchar_t*,wchar_t*)
    public sbyte GetDescriptionValues(int a2, System.IntPtr a3, System.IntPtr a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ActionMapValue, int, System.IntPtr, System.IntPtr, sbyte>)0x00685670)(ref this, a2, a3, a4);
    // void __thiscall ActionMapValue::Serialize(ActionMapValue*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ActionMapValue, ACBindings.Archive*, void>)0x00685A80)(ref this, io_archive);
}

