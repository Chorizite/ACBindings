namespace ACBindings;

// Waveform
public unsafe struct Waveform
{
    // Members
    public ACBindings.WaveformType type;
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
    // void __thiscall Waveform::SetDefaults(Waveform*)
    public void SetDefaults() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Waveform, void>)0x005B1FE0)(ref this);
    // float __thiscall Waveform::GetValueForPhase(Waveform*,const float,const long double)
    public float GetValueForPhase(float p, double time) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Waveform, float, double, float>)0x005B2010)(ref this, p, time);
    // float __thiscall Waveform::GetValue(Waveform*,const long double)
    public float GetValue(double time) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Waveform, double, float>)0x005B2230)(ref this, time);
    // void __thiscall Waveform::Waveform(Waveform*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Waveform, void>)0x005B2250)(ref this);
    // void __thiscall Waveform::Waveform(Waveform*,const float)
    public void _ConstructorInternal(float base_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Waveform, float, void>)0x005B2280)(ref this, base_);
    // void __thiscall Waveform::Serialize(Waveform*,Archive*)
    public void Serialize(ACBindings.Archive* ar) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Waveform, ACBindings.Archive*, void>)0x005B22C0)(ref this, ar);
    // bool __thiscall Waveform::Parse(Waveform*,const PFileNode*)
    public byte Parse(ACBindings.PFileNode* baseNode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Waveform, ACBindings.PFileNode*, byte>)0x005B2300)(ref this, baseNode);
    // int* __thiscall Waveform::GetTypeString(int*,int*)
    public int* GetTypeString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Waveform, int*, int*>)0x005B27A0)(ref this, a2);
    // void __thiscall Waveform::Output(Waveform*,PFileNode*)
    public void Output(ACBindings.PFileNode* baseNode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Waveform, ACBindings.PFileNode*, void>)0x005B28A0)(ref this, baseNode);
    // int* __thiscall Waveform::ToString(int,int*)
    public int* ToString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Waveform, int*, int*>)0x005B2C30)(ref this, a2);
}

