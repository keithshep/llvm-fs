module Haskaleidoscope.Token (Token(..)) where

-- The token type:
data Token =
    -- keywords
    TokDef                  |
    TokExtern               |
    TokIf                   |
    TokThen                 |
    TokElse                 |
    TokFor                  |
    TokIn                   |
    TokBinary               |
    TokUnary                |
    TokVar                  |
    
    -- punctuation
    TokOpenParen            |
    TokCloseParen           |
    TokComma                |
    TokEq                   |
    
    -- numbers, identifiers and operators
    TokNumber Double        |
    TokIdentifier String    |
    TokBinaryOp String deriving (Eq, Show)
