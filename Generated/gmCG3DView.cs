namespace ACBindings;

// gmCG3DView
public unsafe struct gmCG3DView
{
    // Members
    public ACBindings.CPlayerSystem* m_pPlayerSystem;
    public ACBindings.UIElement_Viewport* m_pViewport;
    public ACBindings.CPhysicsObj* m_pPlayerObject;
    public ACBindings.CPhysicsObj* m_pbgObject;
    public ACBindings.IDClass___tagDataID m_didAnimation;
    public ACBindings.IDClass___tagDataID m_didAnimationRest;
    public fixed byte m_didAnimArray_Raw[20];
    public ACBindings.IDClass___tagDataID* m_didAnimArray => (ACBindings.IDClass___tagDataID*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_didAnimArray_Raw[0]);
    public double m_dLastAnimTime;
    public ACBindings.IDClass___tagDataID m_bgSetupID;
    public ACBindings.IDClass___tagDataID m_alternateSetupID;
    public float m_fHeading;
    public ACBindings.IDClass___tagDataID m_SetupID;
    public ACBindings.Vector3 m_vectPosition;
    public ACBindings.Vector3 m_vectDirection;

    // Generated Constructor
    public gmCG3DView() {
        _ConstructorInternal();
    }

    // Methods
    // void __thiscall gmCG3DView::SetPlayerHeading(gmCG3DView*,float)
    public void SetPlayerHeading(float fHeading) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCG3DView, float, void>)0x004EF220)(ref this, fHeading);
    // void __thiscall gmCG3DView::SetCamera(gmCG3DView*,const AC1Legacy::Vector3*,const AC1Legacy::Vector3*)
    public void SetCamera(ACBindings.AC1Legacy.Vector3* vectPosition, ACBindings.AC1Legacy.Vector3* vectDirection) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCG3DView, ACBindings.AC1Legacy.Vector3*, ACBindings.AC1Legacy.Vector3*, void>)0x004EF240)(ref this, vectPosition, vectDirection);
    // void __thiscall gmCG3DView::StartAnimation(gmCG3DView*)
    public void StartAnimation() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCG3DView, void>)0x004EF290)(ref this);
    // void __thiscall gmCG3DView::StopAnimation(gmCG3DView*)
    public void StopAnimation() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCG3DView, void>)0x004EF2D0)(ref this);
    // void __thiscall gmCG3DView::gmCG3DView(gmCG3DView*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCG3DView, void>)0x004EF310)(ref this);
    // void __thiscall gmCG3DView::Initialize(gmCG3DView*,UIElement_Viewport*)
    public void Initialize(ACBindings.UIElement_Viewport* pViewport) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCG3DView, ACBindings.UIElement_Viewport*, void>)0x004EF3F0)(ref this, pViewport);
    // void __thiscall gmCG3DView::Update(gmCG3DView*)
    public void Update() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCG3DView, void>)0x004EF660)(ref this);
}

