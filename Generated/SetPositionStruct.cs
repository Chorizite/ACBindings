namespace ACBindings.Internal;

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

    /// <summary>
    /// <code>Offset: 0x0051C670
    /// void __thiscall SetPositionStruct::SetFlags(SetPositionStruct*,const unsigned int)</code>
    /// </summary>
    public void SetFlags(uint new_flags) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SetPositionStruct, uint, void>)0x0051C670)(ref this, new_flags);

    /// <summary>
    /// <code>Offset: 0x0051C680
    /// void __thiscall SetPositionStruct::SetPositionStruct(SetPositionStruct*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SetPositionStruct, void>)0x0051C680)(ref this);

    /// <summary>
    /// <code>Offset: 0x0051C6D0
    /// void __thiscall SetPositionStruct::SetPosition(SetPositionStruct*,const Position*)</code>
    /// </summary>
    public void SetPosition(ACBindings.Internal.Position* new_pos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SetPositionStruct, ACBindings.Internal.Position*, void>)0x0051C6D0)(ref this, new_pos);
}

