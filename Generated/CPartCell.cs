namespace ACBindings;

// CPartCell
public unsafe struct CPartCell : System.IDisposable
{
    // Child Types
    // CPartCell_vtbl
    public unsafe struct CPartCell_vtbl
    {
        // Members
        public System.IntPtr add_part; // function pointer
        public System.IntPtr remove_part; // function pointer
        public System.IntPtr CPartCell_dtor_8; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public uint num_shadow_parts;
    public ACBindings.DArray__CShadowPart_ptr shadow_part_list;

    // Generated Constructor
    public CPartCell() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall CPartCell::CPartCell(CPartCell*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPartCell, void>)0x0052F250)(ref this);
    // void __thiscall CPartCell::~CPartCell(CPartCell*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPartCell, void>)0x0052F270)(ref this);
    // void __thiscall CPartCell::remove_part(CPartCell*,CPhysicsPart*)
    public void remove_part(ACBindings.CPhysicsPart* part) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPartCell, ACBindings.CPhysicsPart*, void>)0x0052F290)(ref this, part);
    // void __thiscall CPartCell::remove_shadows(CPartCell*,int)
    public void remove_shadows(int del_flag) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPartCell, int, void>)0x0052F310)(ref this, del_flag);
    // void __thiscall CPartCell::add_part(CPartCell*,CPhysicsPart*,ClipPlaneList**,const Frame*,unsigned int)
    public void add_part(ACBindings.CPhysicsPart* part, ACBindings.ClipPlaneList** planes, ACBindings.Frame* frame, uint num_shadow_parts) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPartCell, ACBindings.CPhysicsPart*, ACBindings.ClipPlaneList**, ACBindings.Frame*, uint, void>)0x0052F3A0)(ref this, part, planes, frame, num_shadow_parts);
}

