namespace ACBindings;

// CLostCell
public unsafe struct CLostCell
{
    // Base Classes
    public ACBindings.IntrusiveHashData__uint__CLostCell_ptr BaseClass_IntrusiveHashData; // ACBindings.IntrusiveHashData__uint__CLostCell_ptr

    // Members
    public uint num_objects;
    public ACBindings.DArray__CPhysicsObj_ptr objects;

    // Methods
    // CPhysicsObj* __thiscall CLostCell::remove_object(CLostCell*,CPhysicsObj*)
    public ACBindings.CPhysicsObj* remove_object(ACBindings.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLostCell, ACBindings.CPhysicsObj*, ACBindings.CPhysicsObj*>)0x00508420)(ref this, object_);
}

