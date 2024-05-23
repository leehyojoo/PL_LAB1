module P6

/// From list 'l', find the element that appears most frequently in the list,
/// and return how many times it appears. If the input list is empty, return 0.

let rec count E l : int =
        match l with
        |[] -> 0
        | head :: tail ->
                let cur = if E = head then 1 else 0
                let rest = count E tail
                cur + rest
                   

let rec maxi x y : int =
        if (x>=y) then x else y


let rec countMostFrequent (l: List<'a>) : int =
        match l with
        |[] -> 0
        |head::tail ->
                let x = count head l
                let y = countMostFrequent tail
                maxi x y
