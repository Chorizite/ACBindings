namespace ACBindings;

// ACCharGenStartArea
public unsafe struct ACCharGenStartArea : System.IDisposable
{
    // Child Types
    // ACCharGenStartArea_vtbl
    public unsafe struct ACCharGenStartArea_vtbl
    {
        // Members
        public System.IntPtr Serialize; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.PStringBase__sbyte name;
    public ACBindings.SmartArray__Position mPositionList;

    // Generated Constructor
    public ACCharGenStartArea() {
        _ConstructorInternal();
    }
    public ACCharGenStartArea(ACBindings.ACCharGenStartArea* that) {
        _ConstructorInternal(that);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall ACCharGenStartArea::ACCharGenStartArea(ACCharGenStartArea*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCharGenStartArea, void>)0x005BF950)(ref this);
    // void __thiscall ACCharGenStartArea::~ACCharGenStartArea(ACCharGenStartArea*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCharGenStartArea, void>)0x005BF980)(ref this);
    // void __thiscall ACCharGenStartArea::ACCharGenStartArea(ACCharGenStartArea*,const ACCharGenStartArea*)
    public void _ConstructorInternal(ACBindings.ACCharGenStartArea* that) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCharGenStartArea, ACBindings.ACCharGenStartArea*, void>)0x005C1E10)(ref this, that);
    // void __thiscall ACCharGenStartArea::Serialize(ACCharGenStartArea*,Archive*)
    public void Serialize(ACBindings.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ACCharGenStartArea, ACBindings.Archive*, void>)0x005C1E50)(ref this, io_archive);
}

