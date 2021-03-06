module Fable.AntDesign.Anchor

open Browser.Types
open Fable.AntDesign.Common
open Fable.React
open Fable.Core.JsInterop

type AnchorBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Anchor" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("affix")>] member inline _.affix (x: DSLElement, v: bool) = x.attr "affix" v
    [<CustomOperation("bounds")>] member inline _.bounds (x: DSLElement, v: int) = x.attr "bounds" v 
    [<CustomOperation("getContainer")>] member inline _.getContainer (x: DSLElement, v: unit -> HTMLElement) = x.attr "getContainer" v 
    [<CustomOperation("offsetBottom")>] member inline _.offsetBottom (x: DSLElement, v: int) = x.attr "offsetBottom" v 
    [<CustomOperation("offsetTop")>] member inline _.offsetTop (x: DSLElement, v: int) = x.attr "offsetTop" v 
    [<CustomOperation("showInkInFixed")>] member inline _.showInkInFixed (x: DSLElement, v: bool) = x.attr "showInkInFixed" v
    [<CustomOperation("onClick")>] member inline _.onClick (x: DSLElement, v: Event -> obj -> unit) = x.attr "onClick" v 
    [<CustomOperation("getCurrentAnchor")>] member inline _.getCurrentAnchor (x: DSLElement, v: unit -> string) = x.attr "getCurrentAnchor" v 
    [<CustomOperation("targetOffset")>] member inline _.targetOffset (x: DSLElement, v: int) = x.attr "targetOffset" v 
    [<CustomOperation("onChange")>] member inline _.onChange (x: DSLElement, v: string -> unit) = x.attr "onChange" v 
   
type AnchorLinkBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Anchor.Link" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("href")>] member inline _.href (x: DSLElement, v: string) = x.attr "href" v 
    [<CustomOperation("title")>] member inline _.title (x: DSLElement, v: ReactElement) = x.attr "title" v 
    [<CustomOperation("target")>] member inline _.target (x: DSLElement, v: string) = x.attr "target" v 