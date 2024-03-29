﻿namespace FSharpConstructorSample

module Say =
    let hello name =
        printfn "Hello %s" name

    type MyClass2(x : int) =
        member this.X = x
        new() as this = MyClass2(0) then printfn "Initializing with X = %d" this.X