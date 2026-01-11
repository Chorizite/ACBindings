namespace ACBindings.Internal;

public unsafe struct RadarInfo
{
    // Members
    public ACBindings.Internal.ACCWeenieObject* object_;
    public ACBindings.Internal.RGBAColor color;
    public ACBindings.Internal.RadarBlipShape shape;

    // Generated Constructor
    public RadarInfo(ACBindings.Internal.ACCWeenieObject* obj) {
        _ConstructorInternal(obj);
    }
    public RadarInfo() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x004D8190
    /// void __thiscall RadarInfo::RadarInfo(RadarInfo*,ACCWeenieObject*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.ACCWeenieObject* obj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RadarInfo, ACBindings.Internal.ACCWeenieObject*, void>)0x004D8190)(ref this, obj);

    /// <summary>
    /// <code>Offset: 0x004D81D0
    /// void __thiscall RadarInfo::RadarInfo(RadarInfo*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RadarInfo, void>)0x004D81D0)(ref this);
}

