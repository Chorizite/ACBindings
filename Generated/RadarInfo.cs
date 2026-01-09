namespace ACBindings;

// RadarInfo
public unsafe struct RadarInfo
{
    // Members
    public ACBindings.ACCWeenieObject* object_;
    public ACBindings.RGBAColor color;
    public ACBindings.RadarBlipShape shape;

    // Generated Constructor
    public RadarInfo(ACBindings.ACCWeenieObject* obj) {
        _ConstructorInternal(obj);
    }
    public RadarInfo() {
        _ConstructorInternal();
    }

    // Methods
    // void __thiscall RadarInfo::RadarInfo(RadarInfo*,ACCWeenieObject*)
    public void _ConstructorInternal(ACBindings.ACCWeenieObject* obj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RadarInfo, ACBindings.ACCWeenieObject*, void>)0x004D8190)(ref this, obj);
    // void __thiscall RadarInfo::RadarInfo(RadarInfo*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.RadarInfo, void>)0x004D81D0)(ref this);
}

