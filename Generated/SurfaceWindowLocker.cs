namespace ACBindings.Internal;

public unsafe struct SurfaceWindowLocker
{
    // Members
    public ACBindings.Internal.SurfaceWindow* m_pSurface;
    public byte m_bLocked;

    // Methods

    /// <summary>
    /// <code>Offset: 0x00441240
    /// bool __thiscall SurfaceWindowLocker::Lock(SurfaceWindowLocker*,bool)</code>
    /// </summary>
    public byte Lock(byte i_bReadOnly) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SurfaceWindowLocker, byte, byte>)0x00441240)(ref this, i_bReadOnly);
}

