namespace ACBindings.Internal;


/// <summary>Defines a rectangular region in 2‑dimensional integer coordinate space, using two opposite corner points.</summary>
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

    /// <summary>Creates a rectangular bounding box defined by its top-left corner and size, storing inclusive bounds for each side.
    /// <code>Offset: 0x0045F940
    /// void __thiscall Box2D::Box2D(Box2D*,int,int,int,int)</code>
    /// </summary>
    /// <param name="x">The x-coordinate of the left edge of the rectangle.</param>
    /// <param name="y">The y-coordinate of the top edge of the rectangle.</param>
    /// <param name="width">The width of the rectangle in units.</param>
    /// <param name="height">The height of the rectangle in units.</param>
    public void _ConstructorInternal(int x, int y, int width, int height) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Box2D, int, int, int, int, void>)0x0045F940)(ref this, x, y, width, height);

    /// <summary>Determines whether the box defines a non-empty axis-aligned rectangle by checking that its width and height are greater than zero.
    /// <code>Offset: 0x004664C0
    /// bool __thiscall Box2D::IsValid(Box2D*)</code>
    /// </summary>
    /// <returns>True if both dimensions exceed zero; otherwise, false.</returns>
    public byte IsValid() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Box2D, byte>)0x004664C0)(ref this);

    /// <summary>Computes the intersection of two axis-aligned bounding boxes, stores the overlapping region in the supplied result box, and indicates whether an intersection exists.
    /// <code>Offset: 0x00466680
    /// bool __thiscall Box2D::Intersection(Box2D*,const Box2D*,Box2D*)</code>
    /// </summary>
    /// <param name="rhs">The second box to intersect with this instance.</param>
    /// <param name="result">A box that receives the coordinates of the overlapping area when the function returns true.</param>
    /// <returns>True if the boxes overlap; otherwise, false.</returns>
    public byte Intersection(ACBindings.Internal.Box2D* rhs, ACBindings.Internal.Box2D* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Box2D, ACBindings.Internal.Box2D*, ACBindings.Internal.Box2D*, byte>)0x00466680)(ref this, rhs, result);

    /// <summary>Initializes a terrain description by clearing all surface references and resetting the terrain type collection to empty.
    /// <code>Offset: 0x00502F40
    /// void __thiscall Box2D::Box2D(CTerrainDesc*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Box2D, void>)0x00502F40)(ref this);

    /// <summary>Determines whether the rectangle specified by rhs lies completely inside this Box2D instance.
    /// <code>Offset: 0x0069A1B0
    /// bool __thiscall Box2D::Includes(Box2D*,const Box2D*)</code>
    /// </summary>
    /// <param name="rhs">The rectangle to be tested for containment.</param>
    /// <returns>True if rhs is entirely within this box; otherwise, false.</returns>
    public byte Includes(ACBindings.Internal.Box2D* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Box2D, ACBindings.Internal.Box2D*, byte>)0x0069A1B0)(ref this, rhs);

    /// <summary>Determines whether this axis-aligned bounding box intersects with another.
    /// <code>Offset: 0x0069A240
    /// bool __thiscall Box2D::Collide(Box2D*,const Box2D*)</code>
    /// </summary>
    /// <param name="rhs">The other Box2D to compare against.</param>
    /// <returns>True if the boxes overlap; otherwise, false.</returns>
    public byte Collide(ACBindings.Internal.Box2D* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Box2D, ACBindings.Internal.Box2D*, byte>)0x0069A240)(ref this, rhs);

    /// <summary>Subtracts the overlapping area between this box and another, generating resulting sub-boxes in an array.
    /// <code>Offset: 0x0069A420
    /// bool __thiscall Box2D::Subtract(Box2D*,Box2D*,_DWORD*)</code>
    /// </summary>
    /// <param name="rhs">The rectangle to subtract from this one.</param>
    /// <param name="a3">Array receiving resulting boxes after subtraction.</param>
    /// <returns>True if any new boxes were produced; otherwise false.</returns>
    public byte Subtract(ACBindings.Internal.Box2D* rhs, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Box2D, ACBindings.Internal.Box2D*, int*, byte>)0x0069A420)(ref this, rhs, a3);
}

