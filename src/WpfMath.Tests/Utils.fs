﻿module WpfMath.Tests.Utils

open WpfMath

let formula (root : Atom) : TexFormula =
    TexFormula(RootAtom = root)

let char (c : char) : CharAtom = CharAtom(c)
let styledChar (c : char, style:string) : CharAtom = CharAtom(c, style)
let op (baseAtom : Atom) (useVertScripts : System.Nullable<bool>)  : BigOperatorAtom = BigOperatorAtom(baseAtom, null, null, useVertScripts)
let opWithScripts (baseAtom : Atom) (subscript : Atom) (superscript : Atom) (useVertScripts : System.Nullable<bool>)
            : BigOperatorAtom = BigOperatorAtom(baseAtom, subscript, superscript, useVertScripts)
let group (groupedAtom: Atom) : TypedAtom = TypedAtom(groupedAtom, TexAtomType.Ordinary, TexAtomType.Ordinary)
let symbol (name : string) : SymbolAtom = SymbolAtom(name, TexAtomType.BinaryOperator, false)
let symbolOp (name : string) : SymbolAtom = SymbolAtom(name, TexAtomType.BigOperator, false)
let row (children : Atom seq) : RowAtom =
    let result = RowAtom()
    result.Elements.AddRange(children)
    result
let fenced left body right : FencedAtom = FencedAtom(body, left, right)

let brace (name : string) (braceType : TexAtomType) : SymbolAtom = SymbolAtom(name, braceType, true)
let openBrace (name : string) : SymbolAtom = brace name TexAtomType.Opening
let closeBrace (name : string) : SymbolAtom = brace name TexAtomType.Closing
