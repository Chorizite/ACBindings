namespace ACBindings.Internal;

// MoveType
public enum MoveType : byte
{
    MoveType_Invalid = 0x0,
    MoveType_Pass = 0x1,
    MoveType_Resign = 0x2,
    MoveType_Stalemate = 0x3,
    MoveType_Grid = 0x4,
    MoveType_FromTo = 0x5,
    MoveType_SelectedPiece = 0x6
}

