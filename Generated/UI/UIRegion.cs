namespace ACBindings;

// UIRegion
public unsafe struct UIRegion : System.IDisposable
{
    // Base Classes
    public ACBindings.UIListener BaseClass_UIListener; // ACBindings.UIListener

    // Child Types
    // UIRegion_vtbl
    public unsafe struct UIRegion_vtbl
    {
        // Members
        public System.IntPtr UIListener_dtor_0; // function pointer
        public System.IntPtr OnAction; // function pointer
        public System.IntPtr OnLoseFocus; // function pointer
        public fixed byte gapC[4];
        public System.IntPtr ListenToElementMessage; // function pointer
        public System.IntPtr ListenToGlobalMessage; // function pointer
        public System.IntPtr SetVisible; // function pointer
        public System.IntPtr SetShouldBlockClicks; // function pointer
        public System.IntPtr SetShouldEraseBackground; // function pointer
        public System.IntPtr SetClampGameViewEdge; // function pointer
        public System.IntPtr CheckOverOverride; // function pointer
        public System.IntPtr MoveTo; // function pointer
        public System.IntPtr ResizeTo; // function pointer
        public System.IntPtr GetSurfaceBox; // function pointer
        public System.IntPtr CompareZLevel; // function pointer
        public System.IntPtr DrawHere;
        public System.IntPtr EraseSelf;
        public System.IntPtr SetParent; // function pointer
        public fixed byte gap48[4];
        public System.IntPtr MouseMove; // function pointer
        public System.IntPtr MouseOver; // function pointer
        public System.IntPtr MouseOverTop; // function pointer
        public System.IntPtr MouseHover; // function pointer
        public System.IntPtr MouseUnhover; // function pointer
        public System.IntPtr MouseDown; // function pointer
        public System.IntPtr MouseUp; // function pointer
        public System.IntPtr HasCursor; // function pointer
        public System.IntPtr AddChild; // function pointer
        public System.IntPtr RemoveChild; // function pointer
        public System.IntPtr DrawStart; // function pointer
        public System.IntPtr EraseBackground; // function pointer
        public System.IntPtr PreBlit; // function pointer
        public System.IntPtr DrawSelf;
        public System.IntPtr PostBlit; // function pointer
        public System.IntPtr DrawChildren;
        public System.IntPtr DrawDone; // function pointer
        public System.IntPtr MouseTap; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Box2D m_box;
    public ACBindings.tagPOINT m_ptTilingOffset;
    public int m_zlevel;
    public ACBindings.Graphic* m_image;
    public ACBindings.Graphic* m_alphaImage;
    public float m_alphaBlendMod;
    public sbyte _bf_a4;
    public fixed byte _padding_a5[3];
    public ACBindings.BlitMode m_eBlitMode;
    public ACBindings.UIRegion* m_parent;
    public ACBindings.UIObject* m_object;
    public ACBindings.HashList__UIRegion_ptr__UIRegion_ptr m_children;
    public ACBindings.HashSet__uint m_mouseDownTable;

    // Generated Constructor
    public UIRegion(ACBindings.UIRegion* parent, int x, int y, int width, int height) {
        _ConstructorInternal(parent, x, y, width, height);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // UIObject* __thiscall UIRegion::GetObjectA(UIRegion*)
    public ACBindings.UIObject* GetObjectA() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIRegion, ACBindings.UIObject*>)0x004592B0)(ref this);
    // void __thiscall UIRegion::MouseOver(UIRegion*,bool)
    public void MouseOver(byte over) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIRegion, byte, void>)0x0045F970)(ref this, over);
    // void __thiscall UIRegion::MouseOverTop(UIRegion*,bool)
    public void MouseOverTop(byte overTop) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIRegion, byte, void>)0x0045F990)(ref this, overTop);
    // void __thiscall UIRegion::SetTooltipOn(UIRegion*,bool)
    public void SetTooltipOn(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIRegion, byte, void>)0x0045F9B0)(ref this, on);
    // bool __thiscall UIRegion::IsMouseDown(UIRegion*,unsigned int)
    public byte IsMouseDown(uint button) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIRegion, uint, byte>)0x004637F0)(ref this, button);
    // void __thiscall UIRegion::SetShouldEraseBackground(UIRegion*,bool)
    public void SetShouldEraseBackground(byte i_bErase) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIRegion, byte, void>)0x00464A80)(ref this, i_bErase);
    // void __thiscall UIRegion::ClearAlphaImage(UIRegion*)
    public void ClearAlphaImage() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIRegion, void>)0x0069FBD0)(ref this);
    // void __thiscall UIRegion::EraseBackground(UIRegion*,const Box2D*,UISurface*)
    public void EraseBackground(ACBindings.Box2D* i_boxObject, ACBindings.UISurface* i_pSurface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIRegion, ACBindings.Box2D*, ACBindings.UISurface*, void>)0x0069FBF0)(ref this, i_boxObject, i_pSurface);
    // void __thiscall UIRegion::SetShouldBlockClicks(UIRegion*,bool)
    public void SetShouldBlockClicks(byte i_bBlockClicks) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIRegion, byte, void>)0x0069FC50)(ref this, i_bBlockClicks);
    // void __thiscall UIRegion::SetClampGameViewEdge(UIRegion*,unsigned int)
    public void SetClampGameViewEdge(uint i_eEdge) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIRegion, uint, void>)0x0069FC70)(ref this, i_eEdge);
    // void __thiscall UIRegion::BringToFront(UIRegion*)
    public void BringToFront() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIRegion, void>)0x0069FCA0)(ref this);
    // bool __thiscall UIRegion::PointIsOverRegion(UIRegion*,int,int)
    public byte PointIsOverRegion(int i_xParent, int i_yParent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIRegion, int, int, byte>)0x0069FCC0)(ref this, i_xParent, i_yParent);
    // void __thiscall UIRegion::NotifyMouseMove(UIRegion*,int,int)
    public void NotifyMouseMove(int xWindow, int yWindow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIRegion, int, int, void>)0x0069FD20)(ref this, xWindow, yWindow);
    // void __thiscall UIRegion::NotifyMouseTap(UIRegion*,unsigned int,unsigned int,unsigned int)
    public void NotifyMouseTap(uint x, uint y, uint button) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIRegion, uint, uint, uint, void>)0x0069FD30)(ref this, x, y, button);
    // int __thiscall UIRegion::GetObjectX0(UIRegion*)
    public int GetObjectX0() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIRegion, int>)0x0069FD40)(ref this);
    // int __thiscall UIRegion::GetObjectY0(UIRegion*)
    public int GetObjectY0() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIRegion, int>)0x0069FD70)(ref this);
    // Box2D* __thiscall UIRegion::GetSurfaceBox(UIRegion*,Box2D*)
    public ACBindings.Box2D* GetSurfaceBox(ACBindings.Box2D* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIRegion, ACBindings.Box2D*, ACBindings.Box2D*>)0x0069FDA0)(ref this, result);
    // int __thiscall UIRegion::GetScreenX0(UIRegion*)
    public int GetScreenX0() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIRegion, int>)0x0069FE00)(ref this);
    // int __thiscall UIRegion::GetScreenY0(UIRegion*)
    public int GetScreenY0() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIRegion, int>)0x0069FE30)(ref this);
    // int __thiscall UIRegion::GetWidth(UIRegion*)
    public int GetWidth() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIRegion, int>)0x0069FE60)(ref this);
    // int __thiscall UIRegion::GetHeight(UIRegion*)
    public int GetHeight() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIRegion, int>)0x0069FE70)(ref this);
    // int __thiscall UIRegion::CompareZLevel(UIRegion*,const UIRegion*)
    public int CompareZLevel(ACBindings.UIRegion* i_pRegion) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIRegion, ACBindings.UIRegion*, int>)0x0069FE80)(ref this, i_pRegion);
    // Graphic* __thiscall UIRegion::SetAlphaImageByDID(_DWORD*,unsigned int)
    public ACBindings.Graphic* SetAlphaImageByDID(uint a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIRegion, uint, ACBindings.Graphic*>)0x0069FEB0)(ref this, a2);
    // void __thiscall UIRegion::AddDirtyRect(UIRegion*,const Box2D*)
    public void AddDirtyRect(ACBindings.Box2D* rect) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIRegion, ACBindings.Box2D*, void>)0x0069FF00)(ref this, rect);
    // int __thiscall UIRegion::EraseSelf(void*,int,int,_DWORD*,int)
    public int EraseSelf(int a2, int a3, int* a4, int a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIRegion, int, int, int*, int, int>)0x0069FFE0)(ref this, a2, a3, a4, a5);
    // void __thiscall UIRegion::DrawSelf(int,Box2D*,int,_DWORD*,UISurface*)
    public void DrawSelf(ACBindings.Box2D* bounds, int a3, int* a4, ACBindings.UISurface* surface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIRegion, ACBindings.Box2D*, int, int*, ACBindings.UISurface*, void>)0x006A0020)(ref this, bounds, a3, a4, surface);
    // Box2D* __thiscall UIRegion::GetObjectBox(UIRegion*,Box2D*)
    public ACBindings.Box2D* GetObjectBox(ACBindings.Box2D* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIRegion, ACBindings.Box2D*, ACBindings.Box2D*>)0x006A0100)(ref this, result);
    // int __thiscall UIRegion::GetScreenX1(UIRegion*)
    public int GetScreenX1() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIRegion, int>)0x006A0190)(ref this);
    // int __thiscall UIRegion::GetScreenY1(UIRegion*)
    public int GetScreenY1() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIRegion, int>)0x006A01E0)(ref this);
    // Box2D* __thiscall UIRegion::GetClipBox(UIRegion*,Box2D*)
    public ACBindings.Box2D* GetClipBox(ACBindings.Box2D* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIRegion, ACBindings.Box2D*, ACBindings.Box2D*>)0x006A0240)(ref this, result);
    // Box2D* __thiscall UIRegion::GetScreenClipBox(UIRegion*,Box2D*)
    public ACBindings.Box2D* GetScreenClipBox(ACBindings.Box2D* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIRegion, ACBindings.Box2D*, ACBindings.Box2D*>)0x006A0340)(ref this, result);
    // void __thiscall UIRegion::MakeRootDirtyHere(UIRegion*)
    public void MakeRootDirtyHere() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIRegion, void>)0x006A0430)(ref this);
    // void __thiscall UIRegion::SetAlphaBlendMod(UIRegion*,float)
    public void SetAlphaBlendMod(float mod) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIRegion, float, void>)0x006A0460)(ref this, mod);
    // void __thiscall UIRegion::SetParent(UIRegion*,UIRegion*)
    public void SetParent(ACBindings.UIRegion* parent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIRegion, ACBindings.UIRegion*, void>)0x006A04E0)(ref this, parent);
    // void __thiscall UIRegion::SetBlitMode(UIRegion*,BlitMode)
    public void SetBlitMode(ACBindings.BlitMode i_eBlitMode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIRegion, ACBindings.BlitMode, void>)0x006A0570)(ref this, i_eBlitMode);
    // void __thiscall UIRegion::SetTilingOffset(UIRegion*,const tagPOINT*)
    public void SetTilingOffset(ACBindings.tagPOINT* i_pt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIRegion, ACBindings.tagPOINT*, void>)0x006A05B0)(ref this, i_pt);
    // void __thiscall UIRegion::SetImage(UIRegion*,Graphic*)
    public void SetImage(ACBindings.Graphic* image) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIRegion, ACBindings.Graphic*, void>)0x006A0610)(ref this, image);
    // void __thiscall UIRegion::ClearImage(UIRegion*)
    public void ClearImage() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIRegion, void>)0x006A0660)(ref this);
    // void __thiscall UIRegion::MoveTo(UIRegion*,const int,const int)
    public void MoveTo(int x, int y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIRegion, int, int, void>)0x006A06B0)(ref this, x, y);
    // void __thiscall UIRegion::ResizeTo(UIRegion*,const int,const int)
    public void ResizeTo(int width, int height) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIRegion, int, int, void>)0x006A0740)(ref this, width, height);
    // void __thiscall UIRegion::SetImageByDID(UIRegion*,unsigned int,int)
    public void SetImageByDID(uint a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIRegion, uint, int, void>)0x006A07E0)(ref this, a2, a3);
    // void __thiscall UIRegion::DrawHere(_DWORD*,int*,Box2D*,_DWORD*,int)
    public void DrawHere(int* a2, ACBindings.Box2D* a3, int* a4, int a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIRegion, int*, ACBindings.Box2D*, int*, int, void>)0x006A08B0)(ref this, a2, a3, a4, a5);
    // int __thiscall UIRegion::DrawChildren(_DWORD*,_DWORD*,Box2D*,int,int)
    public int DrawChildren(int* a2, ACBindings.Box2D* a3, int a4, int a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIRegion, int*, ACBindings.Box2D*, int, int, int>)0x006A0B20)(ref this, a2, a3, a4, a5);
    // void __thiscall UIRegion::ForceUpdate(UIRegion*,unsigned int)
    public void ForceUpdate(uint i_updateFlags) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIRegion, uint, void>)0x006A0C10)(ref this, i_updateFlags);
    // void __thiscall UIRegion::NotifyMouseDown(UIRegion*,unsigned int,unsigned int,unsigned int)
    public void NotifyMouseDown(uint xWindow, uint yWindow, uint button) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIRegion, uint, uint, uint, void>)0x006A0CA0)(ref this, xWindow, yWindow, button);
    // void __thiscall UIRegion::NotifyMouseUp(UIRegion*,unsigned int,unsigned int,unsigned int)
    public void NotifyMouseUp(uint xWindow, uint yWindow, uint button) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIRegion, uint, uint, uint, void>)0x006A0D00)(ref this, xWindow, yWindow, button);
    // void __thiscall UIRegion::SetVisible(UIRegion*,bool)
    public void SetVisible(byte visible) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIRegion, byte, void>)0x006A0D50)(ref this, visible);
    // void __thiscall UIRegion::MouseDown(UIRegion*,unsigned int,unsigned int,unsigned int)
    public void MouseDown(uint xWindow, uint yWindow, uint button) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIRegion, uint, uint, uint, void>)0x006A0EA0)(ref this, xWindow, yWindow, button);
    // void __thiscall UIRegion::MouseUp(UIRegion*,unsigned int,unsigned int,unsigned int)
    public void MouseUp(uint xWindow, uint yWindow, uint button) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIRegion, uint, uint, uint, void>)0x006A0EC0)(ref this, xWindow, yWindow, button);
    // void __thiscall UIRegion::UIRegion(UIRegion*,UIRegion*,int,int,int,int)
    public void _ConstructorInternal(ACBindings.UIRegion* parent, int x, int y, int width, int height) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIRegion, ACBindings.UIRegion*, int, int, int, int, void>)0x006A0F70)(ref this, parent, x, y, width, height);
    // void __thiscall UIRegion::~UIRegion(UIRegion*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIRegion, void>)0x006A1070)(ref this);
    // void __thiscall UIRegion::RemoveChild(UIRegion*,UIRegion*)
    public void RemoveChild(ACBindings.UIRegion* child) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIRegion, ACBindings.UIRegion*, void>)0x006A1150)(ref this, child);
    // void __thiscall UIRegion::AddChild(UIRegion*,UIRegion*)
    public void AddChild(ACBindings.UIRegion* child) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIRegion, ACBindings.UIRegion*, void>)0x006A1580)(ref this, child);
    // void __thiscall UIRegion::BringToFront(UIRegion*,UIRegion*)
    public void BringToFront(ACBindings.UIRegion* child) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIRegion, ACBindings.UIRegion*, void>)0x006A1610)(ref this, child);
}

