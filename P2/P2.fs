module P2

// (Note) Do NOT change the definition of the following type and exception.
type Exp =
    Num of int
  | Add of Exp * Exp
  | Sub of Exp * Exp
  | Mul of Exp * Exp
  | Div of Exp * Exp

exception DivByZero

/// Return the integer value represented by the expression 'e'. If there is any
/// division-by-zero case, raise the 'DivByZero' exception.

// Evaluate the integer balue represented by the expression 'e'
let rec eval (e: Exp) : int =
  match e with
        | Num n -> n
        | Add (x,y) -> eval x + eval y
        | Sub (x,y) -> eval x - eval y
        | Mul (x,y) -> eval x * eval y
        | Div (x,y) -> 
                // division by zero case -> raise the 'DivByzero' exception
                if (eval y) = 0 then
                        raise DivByZero 
                else
                        eval x / eval y
