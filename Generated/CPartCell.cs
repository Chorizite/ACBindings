namespace ACBindings.Internal;


/// <summary>Collection of shadow parts managed by the system, storing a virtual function table pointer, count of parts, and an array of pointers to individual shadow part objects.</summary>
public unsafe struct CPartCell : System.IDisposable
{
    // Child Types

    /// <summary>Virtual function table for CPartCell, exposing callbacks to add or remove a physics part and handle object destruction.</summary>
    public unsafe struct CPartCell_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CPartCell*, ACBindings.Internal.CPhysicsPart*, ACBindings.Internal.ClipPlaneList**, ACBindings.Internal.Frame*, uint, void> add_part; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CPartCell*, ACBindings.Internal.CPhysicsPart*, void> remove_part; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CPartCell*, void> CPartCell_dtor_8; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public uint num_shadow_parts;
    public ACBindings.Internal.DArray___CShadowPart_ptr shadow_part_list;

    // Generated Constructor
    public CPartCell() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Initializes a CPartCell instance by setting up its virtual table, resetting the shadow part counter, and preparing an empty shadow part list with default block size.
    /// <code>Offset: 0x0052F250
    /// void __thiscall CPartCell::CPartCell(CPartCell*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartCell, void>)0x0052F250)(ref this);

    /// <summary>Destroys a CPartCell instance by resetting its virtual table pointer and freeing memory allocated for the shadow part list.
    /// <code>Offset: 0x0052F270
    /// void __thiscall CPartCell::~CPartCell(CPartCell*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartCell, void>)0x0052F270)(ref this);

    /// <summary>Removes the shadow part linked to the specified physics part from the cell, freeing resources and maintaining internal array integrity.
    /// <code>Offset: 0x0052F290
    /// void __thiscall CPartCell::remove_part(CPartCell*,CPhysicsPart*)</code>
    /// </summary>
    /// <param name="part">The physics part whose corresponding shadow part should be removed.</param>
    public void remove_part(ACBindings.Internal.CPhysicsPart* part) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartCell, ACBindings.Internal.CPhysicsPart*, void>)0x0052F290)(ref this, part);

    /// <summary>Removes shadow parts from a cell, optionally deallocating them based on a flag.
    /// <code>Offset: 0x0052F310
    /// void __thiscall CPartCell::remove_shadows(CPartCell*,int)</code>
    /// </summary>
    /// <param name="del_flag">If non-zero, destroys each shadow part and frees its memory; otherwise only clears the count.</param>
    public void remove_shadows(int del_flag) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartCell, int, void>)0x0052F310)(ref this, del_flag);

    /// <summary>Adds a shadow representation of the specified physics part into this cell’s collection, optionally applying clip planes and coordinate transforms from the supplied frame. Expands the underlying array when needed.
    /// <code>Offset: 0x0052F3A0
    /// void __thiscall CPartCell::add_part(CPartCell*,CPhysicsPart*,ClipPlaneList**,const Frame*,unsigned int)</code>
    /// </summary>
    /// <param name="part">Physics part for which to create a shadow instance.</param>
    /// <param name="planes">Optional list of clip planes; may be null.</param>
    /// <param name="frame">Optional transformation frame for positioning the shadow; may be null.</param>
    public void add_part(ACBindings.Internal.CPhysicsPart* part, ACBindings.Internal.ClipPlaneList** planes, ACBindings.Internal.Frame* frame, uint num_shadow_parts) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartCell, ACBindings.Internal.CPhysicsPart*, ACBindings.Internal.ClipPlaneList**, ACBindings.Internal.Frame*, uint, void>)0x0052F3A0)(ref this, part, planes, frame, num_shadow_parts);
}

