namespace ACBindings.Internal;


/// <summary>Sky configuration data for a game world, containing tick sizes, day groups, and the current day group index.</summary>
public unsafe struct SkyDesc : System.IDisposable
{
    // Members
    public uint present_day_group;
    public double tick_size;
    public double light_tick_size;
    public ACBindings.Internal.AC1Legacy.SmartArray___DayGroup_ptr day_groups;

    // Generated Constructor
    public SkyDesc() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Initializes a new SkyDesc instance with default values for the present day group, tick sizes, and an empty collection of day groups.
    /// <code>Offset: 0x005015D0
    /// void __thiscall SkyDesc::SkyDesc(SkyDesc*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkyDesc, void>)0x005015D0)(ref this);

    /// <summary>Computes the current sky lighting based on a specified time of day, producing ambient intensity and color as well as directional light direction and color.
    /// <code>Offset: 0x00501600
    /// void __thiscall SkyDesc::GetLighting(SkyDesc*,float,float*,RGBAUnion*,AC1Legacy::Vector3*,RGBAUnion*)</code>
    /// </summary>
    /// <param name="time_of_day">The time of day used for interpolation within the current day group.</param>
    /// <param name="ambient">Receives the interpolated ambient brightness value.</param>
    /// <param name="amb_color">Receives the interpolated ambient RGB color.</param>
    /// <param name="directional">Receives the computed direction vector for the directional light.</param>
    /// <param name="dir_color">Receives the interpolated directional light RGB color.</param>
    public void GetLighting(float time_of_day, float* ambient, ACBindings.Internal.RGBAUnion* amb_color, ACBindings.Internal.AC1Legacy.Vector3* directional, ACBindings.Internal.RGBAUnion* dir_color) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkyDesc, float, float*, ACBindings.Internal.RGBAUnion*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.RGBAUnion*, void>)0x00501600)(ref this, time_of_day, ambient, amb_color, directional, dir_color);

    /// <summary>Interpolates world fog parameters (minimum, maximum, and color) for the given time of day within the current day group.
    /// <code>Offset: 0x00501860
    /// int __thiscall SkyDesc::GetWorldFog(SkyDesc*,float,float*,float*,RGBAUnion*)</code>
    /// </summary>
    /// <param name="time_of_day">Normalized time of day used to select and blend fog settings.</param>
    /// <param name="min">Output parameter that receives the interpolated minimum fog value.</param>
    /// <param name="max">Output parameter that receives the interpolated maximum fog value.</param>
    /// <param name="color">Output parameter that receives the interpolated RGBA world fog color.</param>
    /// <returns>1 if fog parameters were successfully retrieved and blended; 0 otherwise (e.g., no applicable day group or missing data).</returns>
    public int GetWorldFog(float time_of_day, float* min, float* max, ACBindings.Internal.RGBAUnion* color) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkyDesc, float, float*, float*, ACBindings.Internal.RGBAUnion*, int>)0x00501860)(ref this, time_of_day, min, max, color);

    /// <summary>Calculates the present day group index from the current game time and updates present_day_group, setting it to zero when the computed value exceeds the number of available day groups.
    /// <code>Offset: 0x00501990
    /// void __thiscall SkyDesc::CalcPresentDayGroup(SkyDesc*)</code>
    /// </summary>
    public void CalcPresentDayGroup() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkyDesc, void>)0x00501990)(ref this);

    /// <summary>Collects all valid graphical data IDs from the sky description's day groups and time‑based object replacements into the supplied array.
    /// <code>Offset: 0x00501F50
    /// void __thiscall SkyDesc::GetSubDataIDs(SkyDesc*,QualifiedDataIDArray*)</code>
    /// </summary>
    /// <param name="id_array">The QualifiedDataIDArray to populate with collected identifiers.</param>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkyDesc, ACBindings.Internal.QualifiedDataIDArray*, void>)0x00501F50)(ref this, id_array);

    /// <summary>Computes the number of bytes required to serialize a SkyDesc object, including its day groups, and rounds the result up to a multiple of four.
    /// <code>Offset: 0x00502500
    /// unsigned int __thiscall SkyDesc::pack_size(SkyDesc*)</code>
    /// </summary>
    /// <returns>The total packed size in bytes.</returns>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkyDesc, uint>)0x00502500)(ref this);

    /// <summary>Serializes the SkyDesc object into a binary buffer, writing tick sizes, aligning the pointer, recording the number of day groups, and packing each DayGroup.
    /// <code>Offset: 0x00502540
    /// unsigned int __thiscall SkyDesc::Pack(SkyDesc*,void**,unsigned int*)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current write location in the buffer; updated as data is written.</param>
    /// <param name="size">Pointer to the remaining buffer size; decremented by the amount written.</param>
    /// <returns>Number of bytes left in the buffer after serialization completes.</returns>
    public uint Pack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkyDesc, void**, uint*, uint>)0x00502540)(ref this, addr, size);

    /// <summary>Deserializes sky description data from the supplied buffer, updating this instance's tick sizes and populating its day‑group collection.
    /// <code>Offset: 0x00502820
    /// int __thiscall SkyDesc::UnPack(SkyDesc*,void**,unsigned int*)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current read position in the input buffer; advanced as fields are extracted.</param>
    /// <param name="size">Number of bytes remaining in the buffer; decreased during unpacking. Must be at least 8 for the tick sizes.</param>
    /// <returns>Non‑zero if all data was successfully unpacked; zero if an error occurs while reading day groups or the buffer is exhausted.</returns>
    public int UnPack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkyDesc, void**, uint*, int>)0x00502820)(ref this, addr, size);

    /// <summary>Destroys a SkyDesc object by releasing all allocated DayGroup resources and resetting its internal counters and sizes to zero.
    /// <code>Offset: 0x00502970
    /// void __thiscall SkyDesc::Destroy(SkyDesc*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkyDesc, void>)0x00502970)(ref this);

    /// <summary>Computes the sky state for a specified time of day, filling an array of celestial positions with object identities, angles, texture velocities and lighting parameters.
    /// <code>Offset: 0x00502A10
    /// int __thiscall SkyDesc::GetSky(_DWORD*,float,float)</code>
    /// </summary>
    /// <param name="time_of_day">The fractional hour within the current day (0–24).</param>
    /// <param name="ratio">A pointer to a SmartArray&lt;CelestialPosition&gt; that receives the computed sky data; its size is resized automatically to match the number of sky objects for that time.</param>
    /// <returns>Always 1, indicating successful calculation of the sky state.</returns>
    public int GetSky(float time_of_day, float ratio) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkyDesc, float, float, int>)0x00502A10)(ref this, time_of_day, ratio);

    /// <summary>Destroys a SkyDesc instance, freeing its resources and deleting the underlying day group array.
    /// <code>Offset: 0x00502DA0
    /// void __thiscall SkyDesc::~SkyDesc(SkyDesc*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkyDesc, void>)0x00502DA0)(ref this);
}

