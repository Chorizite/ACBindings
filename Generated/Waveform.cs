namespace ACBindings.Internal;

public unsafe struct Waveform
{
    // Members
    public ACBindings.Internal.WaveformType type;
    public float base_;
    public float base_vel;
    public float amplitude;
    public float amplitude_vel;
    public float phase;
    public float phase_vel;
    public float frequency;
    public float frequency_vel;
    public float roughness;
    public float roughness_vel;

    // Generated Constructor
    public Waveform() {
        _ConstructorInternal();
    }
    public Waveform(float base_) {
        _ConstructorInternal(base_);
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x005B1FE0
    /// void __thiscall Waveform::SetDefaults(Waveform*)</code>
    /// </summary>
    public void SetDefaults() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Waveform, void>)0x005B1FE0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005B2010
    /// float __thiscall Waveform::GetValueForPhase(Waveform*,const float,const long double)</code>
    /// </summary>
    public float GetValueForPhase(float p, double time) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Waveform, float, double, float>)0x005B2010)(ref this, p, time);

    /// <summary>
    /// <code>Offset: 0x005B2230
    /// float __thiscall Waveform::GetValue(Waveform*,const long double)</code>
    /// </summary>
    public float GetValue(double time) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Waveform, double, float>)0x005B2230)(ref this, time);

    /// <summary>
    /// <code>Offset: 0x005B2250
    /// void __thiscall Waveform::Waveform(Waveform*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Waveform, void>)0x005B2250)(ref this);

    /// <summary>
    /// <code>Offset: 0x005B2280
    /// void __thiscall Waveform::Waveform(Waveform*,const float)</code>
    /// </summary>
    public void _ConstructorInternal(float base_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Waveform, float, void>)0x005B2280)(ref this, base_);

    /// <summary>
    /// <code>Offset: 0x005B22C0
    /// void __thiscall Waveform::Serialize(Waveform*,Archive*)</code>
    /// </summary>
    public void Serialize(ACBindings.Internal.Archive* ar) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Waveform, ACBindings.Internal.Archive*, void>)0x005B22C0)(ref this, ar);

    /// <summary>
    /// <code>Offset: 0x005B2300
    /// bool __thiscall Waveform::Parse(Waveform*,const PFileNode*)</code>
    /// </summary>
    public byte Parse(ACBindings.Internal.PFileNode* baseNode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Waveform, ACBindings.Internal.PFileNode*, byte>)0x005B2300)(ref this, baseNode);

    /// <summary>
    /// <code>Offset: 0x005B27A0
    /// int* __thiscall Waveform::GetTypeString(int*,int*)</code>
    /// </summary>
    public int* GetTypeString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Waveform, int*, int*>)0x005B27A0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x005B28A0
    /// void __thiscall Waveform::Output(Waveform*,PFileNode*)</code>
    /// </summary>
    public void Output(ACBindings.Internal.PFileNode* baseNode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Waveform, ACBindings.Internal.PFileNode*, void>)0x005B28A0)(ref this, baseNode);

    /// <summary>
    /// <code>Offset: 0x005B2C30
    /// int* __thiscall Waveform::ToString(int,int*)</code>
    /// </summary>
    public int* ToString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Waveform, int*, int*>)0x005B2C30)(ref this, a2);
}

