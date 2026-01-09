namespace ACBindings;

// ParticleType
public enum ParticleType : uint
{
    Unknown_PT = 0x0,
    Still_PT = 0x1,
    LocalVelocity_PT = 0x2,
    ParabolicLVGA_PT = 0x3,
    ParabolicLVGAGR_PT = 0x4,
    Swarm_PT = 0x5,
    Explode_PT = 0x6,
    Implode_PT = 0x7,
    ParabolicLVLA_PT = 0x8,
    ParabolicLVLALR_PT = 0x9,
    ParabolicGVGA_PT = 0xA,
    ParabolicGVGAGR_PT = 0xB,
    GlobalVelocity_PT = 0xC,
    NumParticleType = 0xD,
    FORCE_ParticleType_32_BIT = 0x7FFFFFFF
}

