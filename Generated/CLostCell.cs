namespace ACBindings.Internal;


/// <summary>Holds physics objects belonging to a cell marked for removal from the spatial partition, providing count and array storage while maintaining hash linkage for efficient lookup.</summary>
public unsafe struct CLostCell
{
    // Base Classes
    public ACBindings.Internal.IntrusiveHashData__uint___CLostCell_ptr BaseClass_IntrusiveHashData; // ACBindings.Internal.IntrusiveHashData__uint___CLostCell_ptr

    // Members
    public uint num_objects;
    public ACBindings.Internal.DArray___CPhysicsObj_ptr objects;

    // Methods

    /// <summary>Removes the specified physics object from the cell, decreasing its count and preserving contiguous storage by swapping with the last element.
    /// <code>Offset: 0x00508420
    /// CPhysicsObj* __thiscall CLostCell::remove_object(CLostCell*,CPhysicsObj*)</code>
    /// </summary>
    /// <param name="object">The physics object to remove from the cell.</param>
    /// <returns>The removed object if it was present; otherwise, nullptr.</returns>
    public ACBindings.Internal.CPhysicsObj* remove_object(ACBindings.Internal.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLostCell, ACBindings.Internal.CPhysicsObj*, ACBindings.Internal.CPhysicsObj*>)0x00508420)(ref this, object_);
}

