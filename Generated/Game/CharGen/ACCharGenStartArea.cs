namespace ACBindings.Internal;

public unsafe struct ACCharGenStartArea : System.IDisposable
{
    // Child Types
    public unsafe struct ACCharGenStartArea_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCharGenStartArea*, ACBindings.Internal.Archive*, void> Serialize; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.Internal.PStringBase__sbyte name;
    public ACBindings.Internal.SmartArray___Position mPositionList;

    // Generated Constructor
    public ACCharGenStartArea() {
        _ConstructorInternal();
    }
    public ACCharGenStartArea(ACBindings.Internal.ACCharGenStartArea* that) {
        _ConstructorInternal(that);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x005BF950
    /// void __thiscall ACCharGenStartArea::ACCharGenStartArea(ACCharGenStartArea*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCharGenStartArea, void>)0x005BF950)(ref this);

    /// <summary>
    /// <code>Offset: 0x005BF980
    /// void __thiscall ACCharGenStartArea::~ACCharGenStartArea(ACCharGenStartArea*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCharGenStartArea, void>)0x005BF980)(ref this);

    /// <summary>
    /// <code>Offset: 0x005C1E10
    /// void __thiscall ACCharGenStartArea::ACCharGenStartArea(ACCharGenStartArea*,const ACCharGenStartArea*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.ACCharGenStartArea* that) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCharGenStartArea, ACBindings.Internal.ACCharGenStartArea*, void>)0x005C1E10)(ref this, that);

    /// <summary>
    /// <code>Offset: 0x005C1E50
    /// void __thiscall ACCharGenStartArea::Serialize(ACCharGenStartArea*,Archive*)</code>
    /// </summary>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCharGenStartArea, ACBindings.Internal.Archive*, void>)0x005C1E50)(ref this, io_archive);
}

