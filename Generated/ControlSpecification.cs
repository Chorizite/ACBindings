namespace ACBindings.Internal;


/// <summary>Encapsulates data defining a control specification within the system.</summary>
public unsafe struct ControlSpecification
{
    // Members
    public ACBindings.Internal._E8DC79759AA0AA4C5121FAB9DA332741 ___u0;

    // Methods

    /// <summary>Serializes or deserializes the object's key field using an Archive instance. If the archive's flags indicate write mode, the current key value is written; otherwise the key is read from the archive.
    /// <code>Offset: 0x0068B220
    /// void __thiscall ControlSpecification::Serialize(ControlSpecification*,Archive*)</code>
    /// </summary>
    /// <param name="io_archive">The Archive used for reading or writing the key value.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ControlSpecification, ACBindings.Internal.Archive*, void>)0x0068B220)(ref this, io_archive);

    /// <summary>Serializes this control specification into the supplied file node structure, recording its key, semantic name, and optional sub‑control index for the specified device type.
    /// <code>Offset: 0x0068BB80
    /// bool __thiscall ControlSpecification::ToFileNode(ControlSpecification*,PFileNode*,DeviceType)</code>
    /// </summary>
    /// <param name="i_pNode">The PFileNode that receives the serialized representation of this control specification.</param>
    /// <param name="i_dt">Device type used to determine the semantic name and whether a sub‑control index should be added.</param>
    /// <returns>True if the control specification was fully serialized into the file node; otherwise false if SubControlIndexToString fails.</returns>
    public byte ToFileNode(ACBindings.Internal.PFileNode* i_pNode, ACBindings.Internal.DeviceType i_dt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ControlSpecification, ACBindings.Internal.PFileNode*, ACBindings.Internal.DeviceType, byte>)0x0068BB80)(ref this, i_pNode, i_dt);

    /// <summary>Retrieves the DirectInput keyboard (DIK) name for this control specification and stores it in the supplied string buffer.
    /// <code>Offset: 0x0068BCB0
    /// PStringBase&lt;char&gt;* __thiscall ControlSpecification::GetDIKName(unsigned __int16*,PStringBase&lt;char&gt;*)</code>
    /// </summary>
    /// <param name="this">The current ControlSpecification object.</param>
    /// <param name="a2">String buffer to receive the DIK name; may be set to an empty string if no mapping is available.</param>
    /// <returns>The same string buffer that was passed in, now containing the resolved DIK name or an empty string.</returns>
    public ACBindings.Internal.PStringBase__sbyte* GetDIKName(ACBindings.Internal.PStringBase__sbyte* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ControlSpecification, ACBindings.Internal.PStringBase__sbyte*, ACBindings.Internal.PStringBase__sbyte*>)0x0068BCB0)(ref this, a2);

    /// <summary>Populates the ControlSpecification object from a file node representing a control definition. Expects 2 or 3 sub‑nodes: device index (numeric), semantic name, and optional sub‑control index.
    /// <code>Offset: 0x0068C2B0
    /// bool __thiscall ControlSpecification::FromFileNode(ControlSpecification*,const PFileNode*)</code>
    /// </summary>
    /// <param name="i_pNode">The PFileNode containing the control specification to parse.</param>
    /// <returns>True if parsing succeeded and the object was populated; otherwise false.</returns>
    public byte FromFileNode(ACBindings.Internal.PFileNode* i_pNode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ControlSpecification, ACBindings.Internal.PFileNode*, byte>)0x0068C2B0)(ref this, i_pNode);
}

