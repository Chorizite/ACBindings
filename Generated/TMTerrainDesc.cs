namespace ACBindings.Internal;


/// <summary>Represents a terrain definition, storing its type and an array of texture descriptors used for rendering the terrain in the game world.</summary>
public unsafe struct TMTerrainDesc : System.IDisposable
{
    // Members
    public ACBindings.Internal.LandDefs.TerrainType terrain_type;
    public ACBindings.Internal.AC1Legacy.SmartArray___TerrainTex_ptr terrain_tex;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Releases all terrain textures owned by a TMTerrainDesc instance, deleting each TerrainTex and clearing its internal array of pointers.
    /// <code>Offset: 0x005046B0
    /// void __thiscall TMTerrainDesc::~TMTerrainDesc(TMTerrainDesc*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TMTerrainDesc, void>)0x005046B0)(ref this);

    /// <summary>Unpacks terrain description data from a binary buffer into the TMTerrainDesc object, initializing terrain_type and loading associated TerrainTex instances.
    /// <code>Offset: 0x00504CC0
    /// int __thiscall TMTerrainDesc::UnPack(TMTerrainDesc*,void**,unsigned int*)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current position in the input buffer; updated to point after the read data.</param>
    /// <param name="size">Pointer to the remaining size of the buffer; decreased by the number of bytes consumed during unpacking.</param>
    /// <returns>Non‑zero value indicating successful unpacking (always 1).</returns>
    public int UnPack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TMTerrainDesc, void**, uint*, int>)0x00504CC0)(ref this, addr, size);
}

