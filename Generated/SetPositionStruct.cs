namespace ACBindings;

// SetPositionStruct
public unsafe struct SetPositionStruct
{
    // Members
    public ACBindings.Position pos;
    public uint flags;
    public ACBindings.AC1Legacy.Vector3 line;
    public float xrad;
    public float yrad;
    public uint num_tries;

    // Generated Constructor
    public SetPositionStruct() {
        _ConstructorInternal();
    }

    // Methods
    // void __thiscall SetPositionStruct::SetFlags(SetPositionStruct*,const unsigned int)
    public void SetFlags(uint new_flags) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SetPositionStruct, uint, void>)0x0051C670)(ref this, new_flags);
    // void __thiscall SetPositionStruct::SetPositionStruct(SetPositionStruct*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SetPositionStruct, void>)0x0051C680)(ref this);
    // void __thiscall SetPositionStruct::SetPosition(SetPositionStruct*,const Position*)
    public void SetPosition(ACBindings.Position* new_pos) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SetPositionStruct, ACBindings.Position*, void>)0x0051C6D0)(ref this, new_pos);
}

