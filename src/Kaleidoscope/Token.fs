module Kaleidoscope.Token

// The token type:
type Token =
    // keywords
    | TokDef
    | TokExtern
    | TokIf
    | TokThen
    | TokElse
    | TokFor
    | TokIn
    | TokBinary
    | TokUnary
    | TokVar
    
    // punctuation
    | TokOpenParen
    | TokCloseParen
    | TokComma
    | TokEq
    
    // numbers, identifiers and operators
    | TokNumber of float
    | TokIdentifier of string
    | TokBinaryOp of string

