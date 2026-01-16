namespace ACBindings.Internal;


/// <summary>Maps a device type to its unique turbine GUID, enabling identification and lookup of devices within the system.</summary>
public unsafe struct DeviceKeyMapEntry
{
    // Members
    public ACBindings.Internal.DeviceType dt;
    public ACBindings.Internal.Turbine_GUID guid;

    // Methods
}

