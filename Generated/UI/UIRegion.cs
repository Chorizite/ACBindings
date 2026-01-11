namespace ACBindings.Internal;

public unsafe struct UIRegion : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.UIListener BaseClass_UIListener; // ACBindings.Internal.UIListener

    // Child Types
    public unsafe struct UIRegion_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, void> UIListener_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, ACBindings.Internal.InputEvent*, byte> OnAction; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, uint, uint, uint, ACBindings.Internal.CallbackLoseFocusResult> OnLoseFocus; // function pointer
        public fixed byte gapC[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, uint, ACBindings.Internal.UIElement*, uint, int, ACBindings.Internal.UIElementMessageListenResult> ListenToElementMessage; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIListener*, uint, int, void> ListenToGlobalMessage; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> SetVisible; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> SetShouldBlockClicks; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> SetShouldEraseBackground; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, uint, void> SetClampGameViewEdge; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte> CheckOverOverride; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, int, int, void> MoveTo; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, int, int, void> ResizeTo; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.Box2D*, ACBindings.Internal.Box2D*> GetSurfaceBox; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.UIRegion*, int> CompareZLevel; // function pointer
        public System.IntPtr DrawHere;
        public System.IntPtr EraseSelf;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.UIRegion*, void> SetParent; // function pointer
        public fixed byte gap48[4];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, int, int, void> MouseMove; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> MouseOver; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte, void> MouseOverTop; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, int, int, byte> MouseHover; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, void> MouseUnhover; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, uint, uint, uint, void> MouseDown; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, uint, uint, uint, void> MouseUp; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, byte> HasCursor; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.UIRegion*, void> AddChild; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.UIRegion*, void> RemoveChild; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, void> DrawStart; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.Box2D*, ACBindings.Internal.UISurface*, void> EraseBackground; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.Box2D*, ACBindings.Internal.UISurface*, void> PreBlit; // function pointer
        public System.IntPtr DrawSelf;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, ACBindings.Internal.Box2D*, ACBindings.Internal.UISurface*, void> PostBlit; // function pointer
        public System.IntPtr DrawChildren;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, void> DrawDone; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIRegion*, uint, uint, uint, void> MouseTap; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.Box2D m_box;
    public ACBindings.Internal.tagPOINT m_ptTilingOffset;
    public int m_zlevel;
    public ACBindings.Internal.Graphic* m_image;
    public ACBindings.Internal.Graphic* m_alphaImage;
    public float m_alphaBlendMod;
    public sbyte _bf_a4;
    public fixed byte _padding_a5[3];
    public ACBindings.Internal.BlitMode m_eBlitMode;
    public ACBindings.Internal.UIRegion* m_parent;
    public ACBindings.Internal.UIObject* m_object;
    public ACBindings.Internal.HashList___UIRegion_ptr___UIRegion_ptr m_children;
    public ACBindings.Internal.HashSet__uint m_mouseDownTable;

    // Generated Constructor
    public UIRegion(ACBindings.Internal.UIRegion* parent, int x, int y, int width, int height) {
        _ConstructorInternal(parent, x, y, width, height);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x004592B0
    /// UIObject* __thiscall UIRegion::GetObjectA(UIRegion*)</code>
    /// </summary>
    public ACBindings.Internal.UIObject* GetObjectA() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, ACBindings.Internal.UIObject*>)0x004592B0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0045F970
    /// void __thiscall UIRegion::MouseOver(UIRegion*,bool)</code>
    /// </summary>
    public void MouseOver(byte over) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, byte, void>)0x0045F970)(ref this, over);

    /// <summary>
    /// <code>Offset: 0x0045F990
    /// void __thiscall UIRegion::MouseOverTop(UIRegion*,bool)</code>
    /// </summary>
    public void MouseOverTop(byte overTop) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, byte, void>)0x0045F990)(ref this, overTop);

    /// <summary>
    /// <code>Offset: 0x0045F9B0
    /// void __thiscall UIRegion::SetTooltipOn(UIRegion*,bool)</code>
    /// </summary>
    public void SetTooltipOn(byte on) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, byte, void>)0x0045F9B0)(ref this, on);

    /// <summary>
    /// <code>Offset: 0x004637F0
    /// bool __thiscall UIRegion::IsMouseDown(UIRegion*,unsigned int)</code>
    /// </summary>
    public byte IsMouseDown(uint button) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, uint, byte>)0x004637F0)(ref this, button);

    /// <summary>
    /// <code>Offset: 0x00464A80
    /// void __thiscall UIRegion::SetShouldEraseBackground(UIRegion*,bool)</code>
    /// </summary>
    public void SetShouldEraseBackground(byte i_bErase) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, byte, void>)0x00464A80)(ref this, i_bErase);

    /// <summary>
    /// <code>Offset: 0x0069FBD0
    /// void __thiscall UIRegion::ClearAlphaImage(UIRegion*)</code>
    /// </summary>
    public void ClearAlphaImage() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, void>)0x0069FBD0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0069FBF0
    /// void __thiscall UIRegion::EraseBackground(UIRegion*,const Box2D*,UISurface*)</code>
    /// </summary>
    public void EraseBackground(ACBindings.Internal.Box2D* i_boxObject, ACBindings.Internal.UISurface* i_pSurface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, ACBindings.Internal.Box2D*, ACBindings.Internal.UISurface*, void>)0x0069FBF0)(ref this, i_boxObject, i_pSurface);

    /// <summary>
    /// <code>Offset: 0x0069FC50
    /// void __thiscall UIRegion::SetShouldBlockClicks(UIRegion*,bool)</code>
    /// </summary>
    public void SetShouldBlockClicks(byte i_bBlockClicks) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, byte, void>)0x0069FC50)(ref this, i_bBlockClicks);

    /// <summary>
    /// <code>Offset: 0x0069FC70
    /// void __thiscall UIRegion::SetClampGameViewEdge(UIRegion*,unsigned int)</code>
    /// </summary>
    public void SetClampGameViewEdge(uint i_eEdge) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, uint, void>)0x0069FC70)(ref this, i_eEdge);

    /// <summary>
    /// <code>Offset: 0x0069FCA0
    /// void __thiscall UIRegion::BringToFront(UIRegion*)</code>
    /// </summary>
    public void BringToFront() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, void>)0x0069FCA0)(ref this);

    /// <summary>
    /// <code>Offset: 0x0069FCC0
    /// bool __thiscall UIRegion::PointIsOverRegion(UIRegion*,int,int)</code>
    /// </summary>
    public byte PointIsOverRegion(int i_xParent, int i_yParent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, int, int, byte>)0x0069FCC0)(ref this, i_xParent, i_yParent);

    /// <summary>
    /// <code>Offset: 0x0069FD20
    /// void __thiscall UIRegion::NotifyMouseMove(UIRegion*,int,int)</code>
    /// </summary>
    public void NotifyMouseMove(int xWindow, int yWindow) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, int, int, void>)0x0069FD20)(ref this, xWindow, yWindow);

    /// <summary>
    /// <code>Offset: 0x0069FD30
    /// void __thiscall UIRegion::NotifyMouseTap(UIRegion*,unsigned int,unsigned int,unsigned int)</code>
    /// </summary>
    public void NotifyMouseTap(uint x, uint y, uint button) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, uint, uint, uint, void>)0x0069FD30)(ref this, x, y, button);

    /// <summary>
    /// <code>Offset: 0x0069FD40
    /// int __thiscall UIRegion::GetObjectX0(UIRegion*)</code>
    /// </summary>
    public int GetObjectX0() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, int>)0x0069FD40)(ref this);

    /// <summary>
    /// <code>Offset: 0x0069FD70
    /// int __thiscall UIRegion::GetObjectY0(UIRegion*)</code>
    /// </summary>
    public int GetObjectY0() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, int>)0x0069FD70)(ref this);

    /// <summary>
    /// <code>Offset: 0x0069FDA0
    /// Box2D* __thiscall UIRegion::GetSurfaceBox(UIRegion*,Box2D*)</code>
    /// </summary>
    public ACBindings.Internal.Box2D* GetSurfaceBox(ACBindings.Internal.Box2D* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, ACBindings.Internal.Box2D*, ACBindings.Internal.Box2D*>)0x0069FDA0)(ref this, result);

    /// <summary>
    /// <code>Offset: 0x0069FE00
    /// int __thiscall UIRegion::GetScreenX0(UIRegion*)</code>
    /// </summary>
    public int GetScreenX0() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, int>)0x0069FE00)(ref this);

    /// <summary>
    /// <code>Offset: 0x0069FE30
    /// int __thiscall UIRegion::GetScreenY0(UIRegion*)</code>
    /// </summary>
    public int GetScreenY0() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, int>)0x0069FE30)(ref this);

    /// <summary>
    /// <code>Offset: 0x0069FE60
    /// int __thiscall UIRegion::GetWidth(UIRegion*)</code>
    /// </summary>
    public int GetWidth() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, int>)0x0069FE60)(ref this);

    /// <summary>
    /// <code>Offset: 0x0069FE70
    /// int __thiscall UIRegion::GetHeight(UIRegion*)</code>
    /// </summary>
    public int GetHeight() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, int>)0x0069FE70)(ref this);

    /// <summary>
    /// <code>Offset: 0x0069FE80
    /// int __thiscall UIRegion::CompareZLevel(UIRegion*,const UIRegion*)</code>
    /// </summary>
    public int CompareZLevel(ACBindings.Internal.UIRegion* i_pRegion) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, ACBindings.Internal.UIRegion*, int>)0x0069FE80)(ref this, i_pRegion);

    /// <summary>
    /// <code>Offset: 0x0069FEB0
    /// Graphic* __thiscall UIRegion::SetAlphaImageByDID(_DWORD*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.Graphic* SetAlphaImageByDID(uint a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, uint, ACBindings.Internal.Graphic*>)0x0069FEB0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x0069FF00
    /// void __thiscall UIRegion::AddDirtyRect(UIRegion*,const Box2D*)</code>
    /// </summary>
    public void AddDirtyRect(ACBindings.Internal.Box2D* rect) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, ACBindings.Internal.Box2D*, void>)0x0069FF00)(ref this, rect);

    /// <summary>
    /// <code>Offset: 0x0069FFE0
    /// int __thiscall UIRegion::EraseSelf(void*,int,int,_DWORD*,int)</code>
    /// </summary>
    public int EraseSelf(int a2, int a3, int* a4, int a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, int, int, int*, int, int>)0x0069FFE0)(ref this, a2, a3, a4, a5);

    /// <summary>
    /// <code>Offset: 0x006A0020
    /// void __thiscall UIRegion::DrawSelf(int,Box2D*,int,_DWORD*,UISurface*)</code>
    /// </summary>
    public void DrawSelf(ACBindings.Internal.Box2D* bounds, int a3, int* a4, ACBindings.Internal.UISurface* surface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, ACBindings.Internal.Box2D*, int, int*, ACBindings.Internal.UISurface*, void>)0x006A0020)(ref this, bounds, a3, a4, surface);

    /// <summary>
    /// <code>Offset: 0x006A0100
    /// Box2D* __thiscall UIRegion::GetObjectBox(UIRegion*,Box2D*)</code>
    /// </summary>
    public ACBindings.Internal.Box2D* GetObjectBox(ACBindings.Internal.Box2D* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, ACBindings.Internal.Box2D*, ACBindings.Internal.Box2D*>)0x006A0100)(ref this, result);

    /// <summary>
    /// <code>Offset: 0x006A0190
    /// int __thiscall UIRegion::GetScreenX1(UIRegion*)</code>
    /// </summary>
    public int GetScreenX1() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, int>)0x006A0190)(ref this);

    /// <summary>
    /// <code>Offset: 0x006A01E0
    /// int __thiscall UIRegion::GetScreenY1(UIRegion*)</code>
    /// </summary>
    public int GetScreenY1() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, int>)0x006A01E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x006A0240
    /// Box2D* __thiscall UIRegion::GetClipBox(UIRegion*,Box2D*)</code>
    /// </summary>
    public ACBindings.Internal.Box2D* GetClipBox(ACBindings.Internal.Box2D* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, ACBindings.Internal.Box2D*, ACBindings.Internal.Box2D*>)0x006A0240)(ref this, result);

    /// <summary>
    /// <code>Offset: 0x006A0340
    /// Box2D* __thiscall UIRegion::GetScreenClipBox(UIRegion*,Box2D*)</code>
    /// </summary>
    public ACBindings.Internal.Box2D* GetScreenClipBox(ACBindings.Internal.Box2D* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, ACBindings.Internal.Box2D*, ACBindings.Internal.Box2D*>)0x006A0340)(ref this, result);

    /// <summary>
    /// <code>Offset: 0x006A0430
    /// void __thiscall UIRegion::MakeRootDirtyHere(UIRegion*)</code>
    /// </summary>
    public void MakeRootDirtyHere() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, void>)0x006A0430)(ref this);

    /// <summary>
    /// <code>Offset: 0x006A0460
    /// void __thiscall UIRegion::SetAlphaBlendMod(UIRegion*,float)</code>
    /// </summary>
    public void SetAlphaBlendMod(float mod) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, float, void>)0x006A0460)(ref this, mod);

    /// <summary>
    /// <code>Offset: 0x006A04E0
    /// void __thiscall UIRegion::SetParent(UIRegion*,UIRegion*)</code>
    /// </summary>
    public void SetParent(ACBindings.Internal.UIRegion* parent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, ACBindings.Internal.UIRegion*, void>)0x006A04E0)(ref this, parent);

    /// <summary>
    /// <code>Offset: 0x006A0570
    /// void __thiscall UIRegion::SetBlitMode(UIRegion*,BlitMode)</code>
    /// </summary>
    public void SetBlitMode(ACBindings.Internal.BlitMode i_eBlitMode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, ACBindings.Internal.BlitMode, void>)0x006A0570)(ref this, i_eBlitMode);

    /// <summary>
    /// <code>Offset: 0x006A05B0
    /// void __thiscall UIRegion::SetTilingOffset(UIRegion*,const tagPOINT*)</code>
    /// </summary>
    public void SetTilingOffset(ACBindings.Internal.tagPOINT* i_pt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, ACBindings.Internal.tagPOINT*, void>)0x006A05B0)(ref this, i_pt);

    /// <summary>
    /// <code>Offset: 0x006A0610
    /// void __thiscall UIRegion::SetImage(UIRegion*,Graphic*)</code>
    /// </summary>
    public void SetImage(ACBindings.Internal.Graphic* image) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, ACBindings.Internal.Graphic*, void>)0x006A0610)(ref this, image);

    /// <summary>
    /// <code>Offset: 0x006A0660
    /// void __thiscall UIRegion::ClearImage(UIRegion*)</code>
    /// </summary>
    public void ClearImage() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, void>)0x006A0660)(ref this);

    /// <summary>
    /// <code>Offset: 0x006A06B0
    /// void __thiscall UIRegion::MoveTo(UIRegion*,const int,const int)</code>
    /// </summary>
    public void MoveTo(int x, int y) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, int, int, void>)0x006A06B0)(ref this, x, y);

    /// <summary>
    /// <code>Offset: 0x006A0740
    /// void __thiscall UIRegion::ResizeTo(UIRegion*,const int,const int)</code>
    /// </summary>
    public void ResizeTo(int width, int height) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, int, int, void>)0x006A0740)(ref this, width, height);

    /// <summary>
    /// <code>Offset: 0x006A07E0
    /// void __thiscall UIRegion::SetImageByDID(UIRegion*,unsigned int,int)</code>
    /// </summary>
    public void SetImageByDID(uint a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, uint, int, void>)0x006A07E0)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x006A08B0
    /// void __thiscall UIRegion::DrawHere(_DWORD*,int*,Box2D*,_DWORD*,int)</code>
    /// </summary>
    public void DrawHere(int* a2, ACBindings.Internal.Box2D* a3, int* a4, int a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, int*, ACBindings.Internal.Box2D*, int*, int, void>)0x006A08B0)(ref this, a2, a3, a4, a5);

    /// <summary>
    /// <code>Offset: 0x006A0B20
    /// int __thiscall UIRegion::DrawChildren(_DWORD*,_DWORD*,Box2D*,int,int)</code>
    /// </summary>
    public int DrawChildren(int* a2, ACBindings.Internal.Box2D* a3, int a4, int a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, int*, ACBindings.Internal.Box2D*, int, int, int>)0x006A0B20)(ref this, a2, a3, a4, a5);

    /// <summary>
    /// <code>Offset: 0x006A0C10
    /// void __thiscall UIRegion::ForceUpdate(UIRegion*,unsigned int)</code>
    /// </summary>
    public void ForceUpdate(uint i_updateFlags) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, uint, void>)0x006A0C10)(ref this, i_updateFlags);

    /// <summary>
    /// <code>Offset: 0x006A0CA0
    /// void __thiscall UIRegion::NotifyMouseDown(UIRegion*,unsigned int,unsigned int,unsigned int)</code>
    /// </summary>
    public void NotifyMouseDown(uint xWindow, uint yWindow, uint button) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, uint, uint, uint, void>)0x006A0CA0)(ref this, xWindow, yWindow, button);

    /// <summary>
    /// <code>Offset: 0x006A0D00
    /// void __thiscall UIRegion::NotifyMouseUp(UIRegion*,unsigned int,unsigned int,unsigned int)</code>
    /// </summary>
    public void NotifyMouseUp(uint xWindow, uint yWindow, uint button) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, uint, uint, uint, void>)0x006A0D00)(ref this, xWindow, yWindow, button);

    /// <summary>
    /// <code>Offset: 0x006A0D50
    /// void __thiscall UIRegion::SetVisible(UIRegion*,bool)</code>
    /// </summary>
    public void SetVisible(byte visible) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, byte, void>)0x006A0D50)(ref this, visible);

    /// <summary>
    /// <code>Offset: 0x006A0EA0
    /// void __thiscall UIRegion::MouseDown(UIRegion*,unsigned int,unsigned int,unsigned int)</code>
    /// </summary>
    public void MouseDown(uint xWindow, uint yWindow, uint button) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, uint, uint, uint, void>)0x006A0EA0)(ref this, xWindow, yWindow, button);

    /// <summary>
    /// <code>Offset: 0x006A0EC0
    /// void __thiscall UIRegion::MouseUp(UIRegion*,unsigned int,unsigned int,unsigned int)</code>
    /// </summary>
    public void MouseUp(uint xWindow, uint yWindow, uint button) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, uint, uint, uint, void>)0x006A0EC0)(ref this, xWindow, yWindow, button);

    /// <summary>
    /// <code>Offset: 0x006A0F70
    /// void __thiscall UIRegion::UIRegion(UIRegion*,UIRegion*,int,int,int,int)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.UIRegion* parent, int x, int y, int width, int height) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, ACBindings.Internal.UIRegion*, int, int, int, int, void>)0x006A0F70)(ref this, parent, x, y, width, height);

    /// <summary>
    /// <code>Offset: 0x006A1070
    /// void __thiscall UIRegion::~UIRegion(UIRegion*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, void>)0x006A1070)(ref this);

    /// <summary>
    /// <code>Offset: 0x006A1150
    /// void __thiscall UIRegion::RemoveChild(UIRegion*,UIRegion*)</code>
    /// </summary>
    public void RemoveChild(ACBindings.Internal.UIRegion* child) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, ACBindings.Internal.UIRegion*, void>)0x006A1150)(ref this, child);

    /// <summary>
    /// <code>Offset: 0x006A1580
    /// void __thiscall UIRegion::AddChild(UIRegion*,UIRegion*)</code>
    /// </summary>
    public void AddChild(ACBindings.Internal.UIRegion* child) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, ACBindings.Internal.UIRegion*, void>)0x006A1580)(ref this, child);

    /// <summary>
    /// <code>Offset: 0x006A1610
    /// void __thiscall UIRegion::BringToFront(UIRegion*,UIRegion*)</code>
    /// </summary>
    public void BringToFront(ACBindings.Internal.UIRegion* child) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIRegion, ACBindings.Internal.UIRegion*, void>)0x006A1610)(ref this, child);
}

