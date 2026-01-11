namespace ACBindings.Internal;

public unsafe struct CLostCell
{
    // Base Classes
    public ACBindings.Internal.IntrusiveHashData__uint___CLostCell_ptr BaseClass_IntrusiveHashData; // ACBindings.Internal.IntrusiveHashData__uint___CLostCell_ptr

    // Members
    public uint num_objects;
    public ACBindings.Internal.DArray___CPhysicsObj_ptr objects;

    // Methods

    /// <summary>
    /// <code>Offset: 0x00508420
    /// CPhysicsObj* __thiscall CLostCell::remove_object(CLostCell*,CPhysicsObj*)</code>
    /// </summary>
    public ACBindings.Internal.CPhysicsObj* remove_object(ACBindings.Internal.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLostCell, ACBindings.Internal.CPhysicsObj*, ACBindings.Internal.CPhysicsObj*>)0x00508420)(ref this, object_);
}

