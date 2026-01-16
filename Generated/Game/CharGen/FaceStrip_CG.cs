namespace ACBindings.Internal;


/// <summary>Defines a visual element for face strips, encapsulating an icon image identifier and its associated object descriptor used during rendering.</summary>
/// <remarks>Supports serialization of icon data via Archive mechanisms within the graphics subsystem.</remarks>
public unsafe struct FaceStrip_CG
{
    // Child Types

    /// <summary>
    /// Defines the virtual function table for FaceStrip_CG, providing a pointer to its serialization routine.
    /// The sole entry serializes the object's state into an Archive, enabling persistence and network transmission.
    /// </summary>
    public unsafe struct FaceStrip_CG_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.FaceStrip_CG*, ACBindings.Internal.Archive*, void> Serialize; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.Internal.IDClass____tagDataID iconImage;
    public ACBindings.Internal.ObjDesc objDesc;

    // Methods

    /// <summary>Serializes the FaceStrip_CG object's icon image identifier and associated object descriptor into the provided archive, handling alignment and read/write based on archive flags.
    /// <code>Offset: 0x005BECA0
    /// void __thiscall FaceStrip_CG::Serialize(FaceStrip_CG*,Archive*)</code>
    /// </summary>
    /// <param name="io_archive">Archive used for reading or writing the object's data.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FaceStrip_CG, ACBindings.Internal.Archive*, void>)0x005BECA0)(ref this, io_archive);
}

