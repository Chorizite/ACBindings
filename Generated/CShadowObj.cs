namespace ACBindings.Internal;

public unsafe struct CShadowObj
{
    // Base Classes
    public ACBindings.Internal.LongHashData BaseClass_LongHashData; // ACBindings.Internal.LongHashData

    // Child Types
    public unsafe struct CShadowObj_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CShadowObj*, void> CShadowObj_dtor_0; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.CPhysicsObj* physobj;
    public uint cell_id;
    public ACBindings.Internal.CObjCell* cell;

    // Methods

    /// <summary>
    /// <code>Offset: 0x0051C660
    /// void __thiscall CShadowObj::set_physobj(CShadowObj*,CPhysicsObj*)</code>
    /// </summary>
    public void set_physobj(ACBindings.Internal.CPhysicsObj* physobj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CShadowObj, ACBindings.Internal.CPhysicsObj*, void>)0x0051C660)(ref this, physobj);
}

