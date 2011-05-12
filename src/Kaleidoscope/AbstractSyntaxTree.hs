module Haskaleidoscope.AbstractSyntaxTree (
    Def(..),
    Expr(..)) where

data Def =
    FuncDef {
        funcName :: String,
        funcArgs :: [String],
        funcExpr :: Maybe Expr} deriving Show

data Expr =
    FuncExpr String [Expr] |
    VariableExpr String |
    NumExpr Double |
    ParenExpr Expr |
    IfThenElseExpr {
        ifExpr :: Expr,
        thenExpr :: Expr,
        elseExpr :: Expr} |
    ForExpr {
        iterId :: String,
        iterStart :: Double,
        iterCondition :: Expr,
        iterIncrement :: Double,
        iterExpr :: Expr} deriving Show
