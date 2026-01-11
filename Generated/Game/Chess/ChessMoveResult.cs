namespace ACBindings.Internal;

// ChessMoveResult
public enum ChessMoveResult : uint
{
    NoMoveResult = 0x0,
    OKMoveToEmptySquare = 0x1,
    OKMoveToOccupiedSquare = 0x2,
    OKMoveEnPassant = 0x3,
    OKMoveMask = 0x3FF,
    OKMoveCHECK = 0x400,
    OKMoveToEmptySquareCHECK = 0x401,
    OKMoveToOccupiedSquareCHECK = 0x402,
    OKMoveEnPassantCHECK = 0x403,
    OKMoveCHECKMATE = 0x800,
    OKMoveToEmptySquareCHECKMATE = 0x801,
    OKMoveToOccupiedSquareCHECKMATE = 0x802,
    OKMoveEnPassantCHECKMATE = 0x803,
    OKMovePromotion = 0x1000,
    OKMovePromotionCHECK = 0x1400,
    OKMovePromotionCHECKMATE = 0x1800,
    ForceChessMoveResult32Bit = 0x7FFFFFFF,
    BadMoveInvalidBoardState = 0xFFFFFF91,
    BadMoveCantCastleAfterMoving = 0xFFFFFF92,
    BadMoveCantCastleThroughCheck = 0xFFFFFF93,
    BadMoveCantCastleOutOfCheck = 0xFFFFFF94,
    BadMoveWouldCollide = 0xFFFFFF95,
    BadMoveSelfCheck = 0xFFFFFF96,
    BadMoveWouldClobber = 0xFFFFFF97,
    BadMoveDestination = 0xFFFFFF98,
    BadMoveNotYours = 0xFFFFFF99,
    BadMoveNoPiece = 0xFFFFFF9A,
    BadMoveDistance = 0xFFFFFF9B,
    BadMoveDirection = 0xFFFFFF9C,
    BadMoveNotYourTurn = 0xFFFFFFFD,
    BadMoveNotPlaying = 0xFFFFFFFE,
    BadMoveInvalidCommand = 0xFFFFFFFF
}

