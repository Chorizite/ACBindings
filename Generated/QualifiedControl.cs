namespace ACBindings.Internal;


/// <summary>Represents a qualified input control that associates a key specification with metamode and activation flags used in the input system.</summary>
public unsafe struct QualifiedControl
{
    // Members
    public ACBindings.Internal.ControlSpecification m_key;
    public uint m_metamode;
    public uint m_activation;

    // Methods

    /// <summary>Serializes the three float components of a Vector3 into an archive, performing either write or read based on the archive’s mode flag.
    /// <code>Offset: 0x006855E0
    /// void __thiscall QualifiedControl::Serialize(AC1Legacy::Vector3*,Archive*)</code>
    /// </summary>
    /// <param name="io_archive">The Archive object used for serialization; its flags indicate whether data should be written to or loaded from the buffer.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QualifiedControl, ACBindings.Internal.Archive*, void>)0x006855E0)(ref this, io_archive);

    /// <summary>Compares two QualifiedControl instances for identical key identifier and settings.
    /// <code>Offset: 0x0068B160
    /// bool __thiscall QualifiedControl::IsExactlyEqual(QualifiedControl*,const QualifiedControl*)</code>
    /// </summary>
    /// <param name="rhs">The control to compare against the current instance.</param>
    /// <returns>True when both controls share the same key ID, metamode, and activation; otherwise false.</returns>
    public byte IsExactlyEqual(ACBindings.Internal.QualifiedControl* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QualifiedControl, ACBindings.Internal.QualifiedControl*, byte>)0x0068B160)(ref this, rhs);

    /// <summary>Checks whether another qualified control conflicts with this instance by comparing key, meta-mode, and overlapping activation flags.
    /// <code>Offset: 0x0068B190
    /// bool __thiscall QualifiedControl::IsConflicting(QualifiedControl*,const QualifiedControl*)</code>
    /// </summary>
    /// <param name="rhs">Qualified control to compare against.</param>
    /// <returns>True if the two controls share the same key and meta‑mode and have at least one common active flag; otherwise false.</returns>
    public byte IsConflicting(ACBindings.Internal.QualifiedControl* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QualifiedControl, ACBindings.Internal.QualifiedControl*, byte>)0x0068B190)(ref this, rhs);

    /// <summary>Determines whether the control represented by <paramref name="rhs"/> is a more specific or preferable match to the current control than <paramref name="lhs"/>, based on key equality, metamode compatibility, activation overlap, and bit‑count heuristics.
    /// <code>Offset: 0x0068B300
    /// bool __thiscall QualifiedControl::IsBetterMatch(QualifiedControl*,const QualifiedControl*,const QualifiedControl*)</code>
    /// </summary>
    /// <param name="lhs">The first candidate QualifiedControl to compare against.</param>
    /// <param name="rhs">The second candidate QualifiedControl whose suitability is evaluated relative to the first.</param>
    /// <returns>True if <paramref name="rhs"/> provides a better match than <paramref name="lhs"/> for the current control; otherwise false.</returns>
    public byte IsBetterMatch(ACBindings.Internal.QualifiedControl* lhs, ACBindings.Internal.QualifiedControl* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QualifiedControl, ACBindings.Internal.QualifiedControl*, ACBindings.Internal.QualifiedControl*, byte>)0x0068B300)(ref this, lhs, rhs);
}

