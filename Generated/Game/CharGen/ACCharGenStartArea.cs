namespace ACBindings.Internal;


/// <summary>Defines a named start area for character generation, storing its identifier string and a dynamic list of positions that delineate the area's bounds.</summary>
public unsafe struct ACCharGenStartArea : System.IDisposable
{
    // Child Types

    /// <summary>Defines the virtual function table for ACCharGenStartArea, exposing a Serialize method to persist or restore object state.</summary>
    public unsafe struct ACCharGenStartArea_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ACCharGenStartArea*, ACBindings.Internal.Archive*, void> Serialize; // function pointer

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

    /// <summary>Initializes a new ACCharGenStartArea instance, setting its name to an empty string and preparing an empty position list.
    /// <code>Offset: 0x005BF950
    /// void __thiscall ACCharGenStartArea::ACCharGenStartArea(ACCharGenStartArea*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCharGenStartArea, void>)0x005BF950)(ref this);

    /// <summary>Destroys an ACCharGenStartArea object by freeing its position list and decrementing the reference count of its name string, releasing associated memory when no longer needed.
    /// <code>Offset: 0x005BF980
    /// void __thiscall ACCharGenStartArea::~ACCharGenStartArea(ACCharGenStartArea*)</code>
    /// </summary>
    /// <param name="this">The instance to be destroyed.</param>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCharGenStartArea, void>)0x005BF980)(ref this);

    /// <summary>Creates a new ACCharGenStartArea by copying the name and position list from an existing instance, managing reference counts appropriately.
    /// <code>Offset: 0x005C1E10
    /// void __thiscall ACCharGenStartArea::ACCharGenStartArea(ACCharGenStartArea*,const ACCharGenStartArea*)</code>
    /// </summary>
    /// <param name="this">The newly constructed object.</param>
    /// <param name="that">Source instance to copy data from.</param>
    public void _ConstructorInternal(ACBindings.Internal.ACCharGenStartArea* that) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCharGenStartArea, ACBindings.Internal.ACCharGenStartArea*, void>)0x005C1E10)(ref this, that);

    /// <summary>Serializes the area's name and position list to or from an archive, enabling persistent storage of start area data.
    /// <code>Offset: 0x005C1E50
    /// void __thiscall ACCharGenStartArea::Serialize(ACCharGenStartArea*,Archive*)</code>
    /// </summary>
    /// <param name="io_archive">Archive used for input or output during serialization.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ACCharGenStartArea, ACBindings.Internal.Archive*, void>)0x005C1E50)(ref this, io_archive);
}

