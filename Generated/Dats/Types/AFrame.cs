namespace ACBindings.Internal;


/// <summary>Defines a coordinate frame with an origin and orientation represented by a quaternion.</summary>
public unsafe struct AFrame
{
    // Child Types
    // AFrame::FrameInitializationEnum
    public enum FrameInitializationEnum : byte
    {
        FRAME_NO_INITIALIZATION = 0x0
    }

    // Members
    public ACBindings.Internal.AC1Legacy.Vector3 m_fOrigin;
    public float qw;
    public float qx;
    public float qy;
    public float qz;

    // Generated Constructor
    public AFrame() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Initializes the frame at the world origin with an identity rotation.
    /// <code>Offset: 0x00520180
    /// void __thiscall AFrame::AFrame(AFrame*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AFrame, void>)0x00520180)(ref this);

    /// <summary>Validates an AFrame instance by ensuring its origin coordinates and quaternion components are finite and that the quaternion’s magnitude equals one within a small tolerance.
    /// <code>Offset: 0x005AAEE0
    /// int __thiscall AFrame::IsValid(AFrame*)</code>
    /// </summary>
    /// <returns>1 if the frame is valid; 0 otherwise.</returns>
    public int IsValid() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AFrame, int>)0x005AAEE0)(ref this);

    /// <summary>Serializes an AFrame's origin and quaternion components into a contiguous memory block starting at *addr, advancing the pointer as it writes.
    /// <code>Offset: 0x005AAFF0
    /// unsigned int __thiscall AFrame::Pack(AFrame*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the destination buffer; updated to point past the written data.</param>
    /// <param name="size">Remaining size of the buffer in bytes; serialization occurs only if at least 28 bytes are available.</param>
    /// <returns>The number of bytes written (always 28).</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AFrame, void**, uint, uint>)0x005AAFF0)(ref this, addr, size);

    /// <summary>Extracts a frame's position and orientation from a byte buffer, advancing the pointer as data is consumed.
    /// <code>Offset: 0x005AB060
    /// int __thiscall AFrame::UnPack(AFrame*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current read location; updated to point after the extracted values.</param>
    /// <param name="size">Number of bytes remaining in the buffer at the time of call; used to determine whether origin data should be read.</param>
    /// <returns>Non‑zero if the resulting frame passes validity checks, zero otherwise.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AFrame, void**, uint, int>)0x005AB060)(ref this, addr, size);
}

