namespace ACBindings.Internal;

public unsafe struct CPartCell : System.IDisposable
{
    // Child Types
    public unsafe struct CPartCell_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CPartCell*, ACBindings.Internal.CPhysicsPart*, ACBindings.Internal.ClipPlaneList**, ACBindings.Internal.Frame*, uint, void> add_part; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CPartCell*, ACBindings.Internal.CPhysicsPart*, void> remove_part; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CPartCell*, void> CPartCell_dtor_8; // function pointer

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

    /// <summary>
    /// <code>Offset: 0x0052F250
    /// void __thiscall CPartCell::CPartCell(CPartCell*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartCell, void>)0x0052F250)(ref this);

    /// <summary>
    /// <code>Offset: 0x0052F270
    /// void __thiscall CPartCell::~CPartCell(CPartCell*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartCell, void>)0x0052F270)(ref this);

    /// <summary>
    /// <code>Offset: 0x0052F290
    /// void __thiscall CPartCell::remove_part(CPartCell*,CPhysicsPart*)</code>
    /// </summary>
    public void remove_part(ACBindings.Internal.CPhysicsPart* part) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartCell, ACBindings.Internal.CPhysicsPart*, void>)0x0052F290)(ref this, part);

    /// <summary>
    /// <code>Offset: 0x0052F310
    /// void __thiscall CPartCell::remove_shadows(CPartCell*,int)</code>
    /// </summary>
    public void remove_shadows(int del_flag) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartCell, int, void>)0x0052F310)(ref this, del_flag);

    /// <summary>
    /// <code>Offset: 0x0052F3A0
    /// void __thiscall CPartCell::add_part(CPartCell*,CPhysicsPart*,ClipPlaneList**,const Frame*,unsigned int)</code>
    /// </summary>
    public void add_part(ACBindings.Internal.CPhysicsPart* part, ACBindings.Internal.ClipPlaneList** planes, ACBindings.Internal.Frame* frame, uint num_shadow_parts) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPartCell, ACBindings.Internal.CPhysicsPart*, ACBindings.Internal.ClipPlaneList**, ACBindings.Internal.Frame*, uint, void>)0x0052F3A0)(ref this, part, planes, frame, num_shadow_parts);
}

