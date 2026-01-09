namespace ACBindings;

// QualifiedControl
public unsafe struct QualifiedControl
{
    // Members
    public ACBindings.ControlSpecification m_key;
    public uint m_metamode;
    public uint m_activation;

    // Methods
    // void __thiscall QualifiedControl::Serialize(AC1Legacy::Vector3*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.QualifiedControl, ACBindings.Archive*, void>)0x006855E0)(ref this, io_archive);
    // bool __thiscall QualifiedControl::IsExactlyEqual(QualifiedControl*,const QualifiedControl*)
    public byte IsExactlyEqual(ACBindings.QualifiedControl* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.QualifiedControl, ACBindings.QualifiedControl*, byte>)0x0068B160)(ref this, rhs);
    // bool __thiscall QualifiedControl::IsConflicting(QualifiedControl*,const QualifiedControl*)
    public byte IsConflicting(ACBindings.QualifiedControl* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.QualifiedControl, ACBindings.QualifiedControl*, byte>)0x0068B190)(ref this, rhs);
    // bool __thiscall QualifiedControl::IsBetterMatch(QualifiedControl*,const QualifiedControl*,const QualifiedControl*)
    public byte IsBetterMatch(ACBindings.QualifiedControl* lhs, ACBindings.QualifiedControl* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.QualifiedControl, ACBindings.QualifiedControl*, ACBindings.QualifiedControl*, byte>)0x0068B300)(ref this, lhs, rhs);
}

