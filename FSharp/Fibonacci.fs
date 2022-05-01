namespace FSharp

module Fibonacci =

    let next (previous, current) = 
        Some(previous, (current, previous + current))

    let get n = Seq.unfold (next) (0, 1) |> Seq.take n