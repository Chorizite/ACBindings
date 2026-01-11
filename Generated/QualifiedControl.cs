namespace ACBindings.Internal;

public unsafe struct QualifiedControl
{
    // Members
    public ACBindings.Internal.ControlSpecification m_key;
    public uint m_metamode;
    public uint m_activation;

    // Methods

    /// <summary>
    /// <code>Offset: 0x006855E0
    /// void __thiscall QualifiedControl::Serialize(AC1Legacy::Vector3*,Archive*)</code>
    /// </summary>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QualifiedControl, ACBindings.Internal.Archive*, void>)0x006855E0)(ref this, io_archive);

    /// <summary>
    /// <code>Offset: 0x0068B160
    /// bool __thiscall QualifiedControl::IsExactlyEqual(QualifiedControl*,const QualifiedControl*)</code>
    /// </summary>
    public byte IsExactlyEqual(ACBindings.Internal.QualifiedControl* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QualifiedControl, ACBindings.Internal.QualifiedControl*, byte>)0x0068B160)(ref this, rhs);

    /// <summary>
    /// <code>Offset: 0x0068B190
    /// bool __thiscall QualifiedControl::IsConflicting(QualifiedControl*,const QualifiedControl*)</code>
    /// </summary>
    public byte IsConflicting(ACBindings.Internal.QualifiedControl* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QualifiedControl, ACBindings.Internal.QualifiedControl*, byte>)0x0068B190)(ref this, rhs);

    /// <summary>
    /// <code>Offset: 0x0068B300
    /// bool __thiscall QualifiedControl::IsBetterMatch(QualifiedControl*,const QualifiedControl*,const QualifiedControl*)</code>
    /// </summary>
    public byte IsBetterMatch(ACBindings.Internal.QualifiedControl* lhs, ACBindings.Internal.QualifiedControl* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QualifiedControl, ACBindings.Internal.QualifiedControl*, ACBindings.Internal.QualifiedControl*, byte>)0x0068B300)(ref this, lhs, rhs);
}

