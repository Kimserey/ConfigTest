namespace ConfigTest

open WebSharper
open WebSharper.UI.Next
open WebSharper.UI.Next.Client
open WebSharper.UI.Next.Html
open WebSharper.JavaScript

[<JavaScript>]
module Client =

    [<Inline "Config">]
    let config = X<obj>

    let Main =
        let hello = config?hello
        let test = config?test

        div 
            [ text hello
              text test ]
        |> Doc.RunById "main"
