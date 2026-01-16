namespace ACBindings.Internal;


/// <summary>
/// Captures all information required to adjust an object's placement, including its position, orientation frame, movement direction, and status flags. It also records rotational radii and the count of retry attempts for positioning logic.
/// </summary>
public unsafe struct SetPositionStruct
{
    // Members
    public ACBindings.Internal.Position pos;
    public uint flags;
    public ACBindings.Internal.AC1Legacy.Vector3 line;
    public float xrad;
    public float yrad;
    public uint num_tries;

    // Generated Constructor
    public SetPositionStruct() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Assigns the specified flag value to a SetPositionStruct instance.
    /// <code>Offset: 0x0051C670
    /// void __thiscall SetPositionStruct::SetFlags(SetPositionStruct*,const unsigned int)</code>
    /// </summary>
    /// <param name="new_flags">The new flags value to store in the structure.</param>
    public void SetFlags(uint new_flags) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SetPositionStruct, uint, void>)0x0051C670)(ref this, new_flags);

    /// <summary>Initializes a SetPositionStruct instance with default values: sets the position frame to an identity transform, zeroes the line vector, resets rotation radii and attempt counter, and clears flags.
    /// <code>Offset: 0x0051C680
    /// void __thiscall SetPositionStruct::SetPositionStruct(SetPositionStruct*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SetPositionStruct, void>)0x0051C680)(ref this);

    /// <summary>Updates the SetPositionStruct's internal Position with a new cell identifier and frame state from the supplied Position.
    /// <code>Offset: 0x0051C6D0
    /// void __thiscall SetPositionStruct::SetPosition(SetPositionStruct*,const Position*)</code>
    /// </summary>
    /// <param name="new_pos">The Position containing the updated object cell ID and frame data to apply.</param>
    public void SetPosition(ACBindings.Internal.Position* new_pos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SetPositionStruct, ACBindings.Internal.Position*, void>)0x0051C6D0)(ref this, new_pos);
}

