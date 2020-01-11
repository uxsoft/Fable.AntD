namespace Fable.AntD

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props

[<AutoOpen>]
module Typography =
    
    [<StringEnum>]
    [<RequireQualifiedAccess>]
    type TypographyType = Secondary | Warning | Danger
    
    [<RequireQualifiedAccess>]
    type AntText =
        | Code of bool
        | Copyable of bool
        | Delete of bool
        | Disabled of bool
        | Editable of bool
        | Ellipsis of bool
        | Mark of bool
        | Underline of bool
        | OnChange of (string -> unit)
        | Strong of bool
        | Type of TypographyType
        static member Custom (key: string, value: obj): AntText = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntText = unbox ("style", keyValueList CaseRules.LowerFirst css)
        
    [<RequireQualifiedAccess>]
    type AntTitle =
        | Code of bool
        | Copyable of bool
        | Delete of bool
        | Disabled of bool
        | Editable of bool
        | Ellipsis of bool
        | Level of int
        | Mark of bool
        | Underline of bool
        | OnChange of (string -> unit)
        | Strong of bool
        | Type of TypographyType
        static member Custom (key: string, value: obj): AntTitle = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntTitle = unbox ("style", keyValueList CaseRules.LowerFirst css)

    [<RequireQualifiedAccess>]
    type AntParagraph =
        | Code of bool
        | Copyable of bool
        | Delete of bool
        | Disabled of bool
        | Editable of bool
        | Ellipsis of bool
        | Mark of bool
        | Underline of bool
        | OnChange of (string -> unit)
        | Strong of bool
        | Type of TypographyType
        static member Custom (key: string, value: obj): AntParagraph = unbox (key, value)
        static member Style (css: Props.CSSProp list): AntParagraph = unbox ("style", keyValueList CaseRules.LowerFirst css)
    
    let inline antText (props: AntText list) (children: ReactElement list): ReactElement =
       ofImport "Typography.Text" "antd" (keyValueList CaseRules.LowerFirst props) children
       
    let inline antTitle (props: AntTitle list) (children: ReactElement list): ReactElement =
       ofImport "Typography.Title" "antd" (keyValueList CaseRules.LowerFirst props) children
       
    let inline antParagraph (props: AntParagraph list) (children: ReactElement list): ReactElement =
       ofImport "Typography.Paragraph" "antd" (keyValueList CaseRules.LowerFirst props) children
      