{

-- this turns off warnings for happy generated code
{-# OPTIONS_GHC -w #-}

module Haskaleidoscope.Parser (parseKaleidoscope) where

import Haskaleidoscope.AbstractSyntaxTree
import Haskaleidoscope.Token

}

%name parseKaleidoscope Code
%tokentype {Token}
%error {parseError}

%token

    def     { TokDef }
    extern  { TokExtern }
    if      { TokIf }
    then    { TokThen }
    else    { TokElse }
    for     { TokFor }
    in      { TokIn }
    binary  { TokBinary }
    unary   { TokUnary }
    var     { TokVar }
    
    '('     { TokOpenParen }
    ')'     { TokCloseParen }
    ','     { TokComma }
    '='     { TokEq }
    
    num     { TokNumber $$ }
    id      { TokIdentifier $$ }
    binOp   { TokBinaryOp $$ }

%%

Code : Def Code     { Left $1 : $2 }
     | Expr Code    { Right $1 : $2 }
     | {- empty -}  { [] }

Def : def id '(' ParamList ')' Expr { FuncDef $2 $4 (Just $6) }
    | extern id '(' ParamList ')'   { FuncDef $2 $4 Nothing }

ParamList : id ParamList    { $1 : $2 }
          | {- empty -}     { [] }

Expr : id '(' ExprList ')'          { FuncExpr $1 $3 }
     | if Expr then Expr else Expr  { IfThenElseExpr $2 $4 $6 }
     | for id '=' num ',' Expr in Expr
                                    { ForExpr $2 $4 $6  1.0 $8 }
     | for id '=' num ',' Expr ',' num in Expr
                                    { ForExpr $2 $4 $6  $8 $10 }
     | '(' Expr ')'                 { ParenExpr $2 }
     | Expr binOp Expr              { FuncExpr $2 [$1, $3] }
     | id                           { VariableExpr $1 }
     | num                          { NumExpr $1 }

ExprList : Expr ',' ExprList { $1 : $3 }
         | Expr              { [$1] }
         | {- empty -}       { [] }

{

parseError :: [Token] -> a
parseError tokens = error $ "Parse error: " ++ show tokens

}
