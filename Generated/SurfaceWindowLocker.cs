namespace ACBindings;

// SurfaceWindowLocker
public unsafe struct SurfaceWindowLocker
{
    // Members
    public ACBindings.SurfaceWindow* m_pSurface;
    public byte m_bLocked;

    // Methods
    // bool __thiscall SurfaceWindowLocker::Lock(SurfaceWindowLocker*,bool)
    public byte Lock(byte i_bReadOnly) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SurfaceWindowLocker, byte, byte>)0x00441240)(ref this, i_bReadOnly);
}

