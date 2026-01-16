namespace ACBindings.Internal;


/// <summary>Stores pointers and counts describing a single animation frame, including its base frame data, associated hooks, and affected parts.</summary>
public unsafe struct AnimFrame
{
    // Members
    public ACBindings.Internal.AFrame* frame;
    public uint num_frame_hooks;
    public ACBindings.Internal.CAnimHook* hooks;
    public uint num_parts;

    // Methods

    /// <summary>Calculates the number of bytes required to pack an AnimFrame, accounting for its hook list and a base size derived from the supplied part count.
    /// <code>Offset: 0x00520150
    /// unsigned int __thiscall AnimFrame::pack_size(AnimFrame*,unsigned int)</code>
    /// </summary>
    /// <param name="num_parts">Number of parts associated with the frame; contributes to the initial base size calculation.</param>
    /// <returns>The total byte count needed to serialize the frame and its hooks.</returns>
    public uint pack_size(uint num_parts) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AnimFrame, uint, uint>)0x00520150)(ref this, num_parts);

    /// <summary>Releases resources owned by an AnimFrame instance, freeing its frame data and destroying all attached hooks.
    /// <code>Offset: 0x005202F0
    /// void __thiscall AnimFrame::Destroy(AnimFrame*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AnimFrame, void>)0x005202F0)(ref this);

    /// <summary>Packs animation frame data and its hooks into a contiguous memory block, returning the total byte count required.
    /// <code>Offset: 0x00520340
    /// unsigned int __thiscall AnimFrame::Pack(AnimFrame*,unsigned int,void**,unsigned int)</code>
    /// </summary>
    /// <param name="num_parts">Number of parts within this AnimFrame that will be packed.</param>
    /// <param name="addr">Pointer to the buffer location where packed data should be written; updated to point after the written data.</param>
    /// <param name="size">Maximum number of bytes available at *addr. If less than required, no data is written and the function returns the needed size.</param>
    /// <returns>The total number of bytes necessary to store the packed frame data and all associated animation hooks.</returns>
    public uint Pack(uint num_parts, void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AnimFrame, uint, void**, uint, uint>)0x00520340)(ref this, num_parts, addr, size);

    /// <summary>Unpacks an animation frame from a binary data stream into the current AnimFrame instance, allocating frames and hooks as needed.
    /// <code>Offset: 0x005203F0
    /// int __thiscall AnimFrame::UnPack(AnimFrame*,unsigned int,void**,unsigned int)</code>
    /// </summary>
    /// <param name="num_parts">The number of parts to unpack.</param>
    /// <param name="addr">Pointer to the data buffer; advanced past the packed data during processing.</param>
    /// <param name="size">Total size of the data buffer (provided for consistency but unused in this implementation).</param>
    /// <returns>Integer value 1 indicating successful unpacking.</returns>
    public int UnPack(uint num_parts, void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AnimFrame, uint, void**, uint, int>)0x005203F0)(ref this, num_parts, addr, size);
}

