module P5

/// For int list 'l' that contains decimal digits (0~9), return the integer that
/// is represented by this list. For example, "digitsToInt [1; 3; 2]" must
/// return 132 as a result. When the input list is empty, just return 0. 

let rec mul (acc: int) (lst: List<int>) : int =
        match lst with
        |[] -> acc
        |head :: tail -> mul (acc*10 + head) tail
        

let rec digitsToInt (l: int list) : int =
        mul 0 l
