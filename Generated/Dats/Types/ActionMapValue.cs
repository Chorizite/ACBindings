namespace ACBindings.Internal;


/// <summary>Associates an action toggle with a specific user binding, enabling the system to map input events to in‑game actions.</summary>
public unsafe struct ActionMapValue
{
    // Members
    public uint m_eToggleType;
    public ACBindings.Internal.UserBindingValue m_userBindingData;

    // Methods

    /// <summary>Retrieves description strings associated with an action map entry, loading the primary text into a3 and an optional secondary text into a4 if defined.
    /// <code>Offset: 0x00685670
    /// char __thiscall ActionMapValue::GetDescriptionValues(int,int,wchar_t*,wchar_t*)</code>
    /// </summary>
    /// <param name="a2">Identifier for the desired description within the action map (e.g., string table index).</param>
    /// <param name="a3">Buffer to receive the primary description as a wide‑character string.</param>
    /// <param name="a4">Buffer to receive an alternate or secondary description, if available; otherwise remains unchanged.</param>
    /// <returns>Non‑zero when strings are successfully retrieved; zero if no matching entry exists.</returns>
    public sbyte GetDescriptionValues(int a2, System.IntPtr a3, System.IntPtr a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ActionMapValue, int, System.IntPtr, System.IntPtr, sbyte>)0x00685670)(ref this, a2, a3, a4);

    /// <summary>Serializes an ActionMapValue to or from the given archive. Writes a magic number, checks alignment, optionally reads a version byte, stores or retrieves the toggle type, serializes a list of unsigned long identifiers and user binding data, then flushes any pending SkillRecord pointers.
    /// <code>Offset: 0x00685A80
    /// void __thiscall ActionMapValue::Serialize(ActionMapValue*,Archive*)</code>
    /// </summary>
    /// <param name="io_archive">The archive used for serialization or deserialization.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ActionMapValue, ACBindings.Internal.Archive*, void>)0x00685A80)(ref this, io_archive);
}

