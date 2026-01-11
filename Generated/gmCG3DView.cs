namespace ACBindings.Internal;

public unsafe struct gmCG3DView
{
    // Members
    public ACBindings.Internal.CPlayerSystem* m_pPlayerSystem;
    public ACBindings.Internal.UIElement_Viewport* m_pViewport;
    public ACBindings.Internal.CPhysicsObj* m_pPlayerObject;
    public ACBindings.Internal.CPhysicsObj* m_pbgObject;
    public ACBindings.Internal.IDClass____tagDataID m_didAnimation;
    public ACBindings.Internal.IDClass____tagDataID m_didAnimationRest;
    public fixed byte m_didAnimArray_Raw[20];
    public ACBindings.Internal.IDClass____tagDataID* m_didAnimArray => (ACBindings.Internal.IDClass____tagDataID*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_didAnimArray_Raw[0]);
    public double m_dLastAnimTime;
    public ACBindings.Internal.IDClass____tagDataID m_bgSetupID;
    public ACBindings.Internal.IDClass____tagDataID m_alternateSetupID;
    public float m_fHeading;
    public ACBindings.Internal.IDClass____tagDataID m_SetupID;
    public ACBindings.Internal.Vector3 m_vectPosition;
    public ACBindings.Internal.Vector3 m_vectDirection;

    // Generated Constructor
    public gmCG3DView() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x004EF220
    /// void __thiscall gmCG3DView::SetPlayerHeading(gmCG3DView*,float)</code>
    /// </summary>
    public void SetPlayerHeading(float fHeading) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCG3DView, float, void>)0x004EF220)(ref this, fHeading);

    /// <summary>
    /// <code>Offset: 0x004EF240
    /// void __thiscall gmCG3DView::SetCamera(gmCG3DView*,const AC1Legacy::Vector3*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    public void SetCamera(ACBindings.Internal.AC1Legacy.Vector3* vectPosition, ACBindings.Internal.AC1Legacy.Vector3* vectDirection) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCG3DView, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*, void>)0x004EF240)(ref this, vectPosition, vectDirection);

    /// <summary>
    /// <code>Offset: 0x004EF290
    /// void __thiscall gmCG3DView::StartAnimation(gmCG3DView*)</code>
    /// </summary>
    public void StartAnimation() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCG3DView, void>)0x004EF290)(ref this);

    /// <summary>
    /// <code>Offset: 0x004EF2D0
    /// void __thiscall gmCG3DView::StopAnimation(gmCG3DView*)</code>
    /// </summary>
    public void StopAnimation() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCG3DView, void>)0x004EF2D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004EF310
    /// void __thiscall gmCG3DView::gmCG3DView(gmCG3DView*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCG3DView, void>)0x004EF310)(ref this);

    /// <summary>
    /// <code>Offset: 0x004EF3F0
    /// void __thiscall gmCG3DView::Initialize(gmCG3DView*,UIElement_Viewport*)</code>
    /// </summary>
    public void Initialize(ACBindings.Internal.UIElement_Viewport* pViewport) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCG3DView, ACBindings.Internal.UIElement_Viewport*, void>)0x004EF3F0)(ref this, pViewport);

    /// <summary>
    /// <code>Offset: 0x004EF660
    /// void __thiscall gmCG3DView::Update(gmCG3DView*)</code>
    /// </summary>
    public void Update() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCG3DView, void>)0x004EF660)(ref this);
}

