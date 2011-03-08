open System.Collections.Generic

let rec transpose = function
    | (_::_)::_ as M -> List.map List.head M :: transpose (List.map List.tail M)
    | _ -> []

let GetRows = id
let GetCols = transpose
let GetBoxes = id // Homework

let isAllUnique numbers = 
    let set = new HashSet<_>()
    numbers
    |> Seq.filter ((<>) 0)
    |> Seq.forall set.Add

let isMatrixValid matrix =
    let rows = GetRows matrix 
    let cols = GetCols matrix
    let boxes = GetBoxes matrix

    rows @ cols @ boxes
      |> Seq.forall isAllUnique

let listContainsZero = List.forall ((<>) 0)

let isComplete matrix =
    matrix
      |> Seq.exists listContainsZero

let fillFirstEmptyPosition matrix =  [matrix] // TODO: Homework

let rec solve matrix =
    if isComplete matrix then [matrix] else
    matrix
      |> fillFirstEmptyPosition
      |> List.filter isMatrixValid
      |> List.map solve
      |> List.concat
























