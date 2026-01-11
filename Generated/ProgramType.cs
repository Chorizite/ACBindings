namespace ACBindings.Internal;

// ProgramType
public enum ProgramType : uint
{
    Undef_ProgramType = 0x0,
    Client_ProgramType = 0x1,
    Server_ProgramType = 0x2,
    PathMap_ProgramType = 0x100,
    RuntimeProgram_ProgramType = 0x40000000,
    GameClient_ProgramType = 0x40000001,
    GameServer_ProgramType = 0x40000002,
    PreprocProgram_ProgramType = 0x80000000,
    ClientAdder_ProgramType = 0x80000001,
    ServerAdder_ProgramType = 0x80000002,
    WorldBuilder_ProgramType = 0x80000011,
    PathGen_ProgramType = 0x80000102
}

