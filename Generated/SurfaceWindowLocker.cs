namespace ACBindings.Internal;


/// <summary>Manages exclusive access to a SurfaceWindow instance, storing the target surface and whether it is currently locked.</summary>
public unsafe struct SurfaceWindowLocker
{
    // Members
    public ACBindings.Internal.SurfaceWindow* m_pSurface;
    public byte m_bLocked;

    // Methods

    /// <summary>Locks the associated surface window, optionally in read‑only mode.
    /// <code>Offset: 0x00441240
    /// bool __thiscall SurfaceWindowLocker::Lock(SurfaceWindowLocker*,bool)</code>
    /// </summary>
    /// <param name="i_bReadOnly">If true, attempts a read‑only lock; otherwise requests exclusive access.</param>
    /// <returns>True when the surface is successfully locked or was already locked; false if locking failed.</returns>
    public byte Lock(byte i_bReadOnly) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SurfaceWindowLocker, byte, byte>)0x00441240)(ref this, i_bReadOnly);
}

