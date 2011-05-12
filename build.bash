#!/bin/bash

# exit on error and don't allow the use of unset variables
set -o errexit
set -o nounset
set -x

rm -f \
    src/FSExternHelper/Parser.fs \
    src/FSExternHelper/Parser.fsi \
    src/FSExternHelper/Lexer.fs

fslex --unicode src/FSExternHelper/Lexer.fsl
fsyacc --module FSExternHelper.Parser src/FSExternHelper/Parser.fsy

fsc \
    src/ParseUtil/Lexing.fs \
    src/ParseUtil/Parsing.fs \
    src/FSExternHelper/HeaderSyntax.fs \
    src/FSExternHelper/Parser.fs \
    src/FSExternHelper/Lexer.fs \
    src/fsexternhelper.fs

