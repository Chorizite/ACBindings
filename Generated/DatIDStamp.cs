namespace ACBindings.Internal;

public unsafe struct DatIDStamp
{
    // Members
    public ACBindings.Internal._GUID _maj_vnum;
    public uint _min_vnum;

    // Generated Constructor
    public DatIDStamp() {
        _ConstructorInternal();
    }
    public DatIDStamp(ACBindings.Internal.DatIDStamp* rhs) {
        _ConstructorInternal(rhs);
    }

    // Methods

    /// <summary>Resets the DatIDStamp instance to an empty state by clearing its GUID components and setting the minor version to zero.
    /// <code>Offset: 0x00413960
    /// void __thiscall DatIDStamp::Clear(DatIDStamp*)</code>
    /// </summary>
    public void Clear() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DatIDStamp, void>)0x00413960)(ref this);

    /// <summary>Initializes the DatIDStamp instance, clearing all GUID components and setting the minor version to zero.
    /// <code>Offset: 0x00413980
    /// void __thiscall DatIDStamp::DatIDStamp(DatIDStamp*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DatIDStamp, void>)0x00413980)(ref this);

    /// <summary>Creates a new DatIDStamp by copying the values of an existing instance.
    /// <code>Offset: 0x004139A0
    /// void __thiscall DatIDStamp::DatIDStamp(DatIDStamp*,const DatIDStamp*)</code>
    /// </summary>
    /// <param name="rhs">The source DatIDStamp to copy from.</param>
    public void _ConstructorInternal(ACBindings.Internal.DatIDStamp* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DatIDStamp, ACBindings.Internal.DatIDStamp*, void>)0x004139A0)(ref this, rhs);
}

