namespace ACBindings;

// DatIDStamp
public unsafe struct DatIDStamp
{
    // Members
    public ACBindings._GUID _maj_vnum;
    public uint _min_vnum;

    // Generated Constructor
    public DatIDStamp() {
        _ConstructorInternal();
    }
    public DatIDStamp(ACBindings.DatIDStamp* rhs) {
        _ConstructorInternal(rhs);
    }

    // Methods
    // void __thiscall DatIDStamp::Clear(DatIDStamp*)
    public void Clear() => ((delegate* unmanaged[Thiscall]<ref ACBindings.DatIDStamp, void>)0x00413960)(ref this);
    // void __thiscall DatIDStamp::DatIDStamp(DatIDStamp*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.DatIDStamp, void>)0x00413980)(ref this);
    // void __thiscall DatIDStamp::DatIDStamp(DatIDStamp*,const DatIDStamp*)
    public void _ConstructorInternal(ACBindings.DatIDStamp* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DatIDStamp, ACBindings.DatIDStamp*, void>)0x004139A0)(ref this, rhs);
}

