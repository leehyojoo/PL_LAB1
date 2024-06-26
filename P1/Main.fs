open P1

let test inp ans =
  try if reverse inp = ans then "O" else "X" with _ -> "E"

let r1 = test [] []
let r2 = test ["a"; "b"; "c"] ["c"; "b"; "a"]
let r3 = test ["v"] ["v"]
let r4 = test [10; 20] [20; 10]
let r5 = test [4; 3; 2; 1] [1; 2; 3; 4]
let _ = printfn "%s%s%s%s%s" r1 r2 r3 r4 r5
