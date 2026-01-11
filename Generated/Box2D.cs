namespace ACBindings.Internal;

public unsafe struct Box2D
{
    // Members
    public int m_x0;
    public int m_y0;
    public int m_x1;
    public int m_y1;

    // Generated Constructor
    public Box2D(int x, int y, int width, int height) {
        _ConstructorInternal(x, y, width, height);
    }
    public Box2D() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0045F940
    /// void __thiscall Box2D::Box2D(Box2D*,int,int,int,int)</code>
    /// </summary>
    public void _ConstructorInternal(int x, int y, int width, int height) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Box2D, int, int, int, int, void>)0x0045F940)(ref this, x, y, width, height);

    /// <summary>
    /// <code>Offset: 0x004664C0
    /// bool __thiscall Box2D::IsValid(Box2D*)</code>
    /// </summary>
    public byte IsValid() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Box2D, byte>)0x004664C0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00466680
    /// bool __thiscall Box2D::Intersection(Box2D*,const Box2D*,Box2D*)</code>
    /// </summary>
    public byte Intersection(ACBindings.Internal.Box2D* rhs, ACBindings.Internal.Box2D* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Box2D, ACBindings.Internal.Box2D*, ACBindings.Internal.Box2D*, byte>)0x00466680)(ref this, rhs, result);

    /// <summary>
    /// <code>Offset: 0x00502F40
    /// void __thiscall Box2D::Box2D(CTerrainDesc*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Box2D, void>)0x00502F40)(ref this);

    /// <summary>
    /// <code>Offset: 0x0069A1B0
    /// bool __thiscall Box2D::Includes(Box2D*,const Box2D*)</code>
    /// </summary>
    public byte Includes(ACBindings.Internal.Box2D* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Box2D, ACBindings.Internal.Box2D*, byte>)0x0069A1B0)(ref this, rhs);

    /// <summary>
    /// <code>Offset: 0x0069A240
    /// bool __thiscall Box2D::Collide(Box2D*,const Box2D*)</code>
    /// </summary>
    public byte Collide(ACBindings.Internal.Box2D* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Box2D, ACBindings.Internal.Box2D*, byte>)0x0069A240)(ref this, rhs);

    /// <summary>
    /// <code>Offset: 0x0069A420
    /// bool __thiscall Box2D::Subtract(Box2D*,Box2D*,_DWORD*)</code>
    /// </summary>
    public byte Subtract(ACBindings.Internal.Box2D* rhs, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Box2D, ACBindings.Internal.Box2D*, int*, byte>)0x0069A420)(ref this, rhs, a3);
}

