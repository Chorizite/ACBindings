namespace ACBindings;

// CShadowObj
public unsafe struct CShadowObj
{
    // Base Classes
    public ACBindings.LongHashData BaseClass_LongHashData; // ACBindings.LongHashData

    // Child Types
    // CShadowObj_vtbl
    public unsafe struct CShadowObj_vtbl
    {
        // Members
        public System.IntPtr CShadowObj_dtor_0; // function pointer

        // Methods
    }

    // Members
    public ACBindings.CPhysicsObj* physobj;
    public uint cell_id;
    public ACBindings.CObjCell* cell;

    // Methods
    // void __thiscall CShadowObj::set_physobj(CShadowObj*,CPhysicsObj*)
    public void set_physobj(ACBindings.CPhysicsObj* physobj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CShadowObj, ACBindings.CPhysicsObj*, void>)0x0051C660)(ref this, physobj);
}

