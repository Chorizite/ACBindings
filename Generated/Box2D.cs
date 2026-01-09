namespace ACBindings;

// Box2D
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
    // void __thiscall Box2D::Box2D(Box2D*,int,int,int,int)
    public void _ConstructorInternal(int x, int y, int width, int height) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Box2D, int, int, int, int, void>)0x0045F940)(ref this, x, y, width, height);
    // bool __thiscall Box2D::IsValid(Box2D*)
    public byte IsValid() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Box2D, byte>)0x004664C0)(ref this);
    // bool __thiscall Box2D::Intersection(Box2D*,const Box2D*,Box2D*)
    public byte Intersection(ACBindings.Box2D* rhs, ACBindings.Box2D* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Box2D, ACBindings.Box2D*, ACBindings.Box2D*, byte>)0x00466680)(ref this, rhs, result);
    // void __thiscall Box2D::Box2D(CTerrainDesc*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Box2D, void>)0x00502F40)(ref this);
    // bool __thiscall Box2D::Includes(Box2D*,const Box2D*)
    public byte Includes(ACBindings.Box2D* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Box2D, ACBindings.Box2D*, byte>)0x0069A1B0)(ref this, rhs);
    // bool __thiscall Box2D::Collide(Box2D*,const Box2D*)
    public byte Collide(ACBindings.Box2D* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Box2D, ACBindings.Box2D*, byte>)0x0069A240)(ref this, rhs);
    // bool __thiscall Box2D::Subtract(Box2D*,Box2D*,_DWORD*)
    public byte Subtract(ACBindings.Box2D* rhs, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Box2D, ACBindings.Box2D*, int*, byte>)0x0069A420)(ref this, rhs, a3);
}

