module P1

// (Note) In this problem, you are NOT allowed to use the pre-defined library
// function, 'List.rev'.

/// Return a list reversed from the argument 'l'.


// Function to add an element 'v' at the end of the list 'l'
let rec add_last (l: List<'a>)(v: 'a) : List<'a> =
  match l with
  | [] -> [v]
  | head :: tail -> head :: add_last tail v

// Function to reverse a list 'l'
let rec reverse (l: List<'a>) : List<'a> =
  match l with
  | [] -> []
  | head :: tail -> add_last (reverse tail) head
