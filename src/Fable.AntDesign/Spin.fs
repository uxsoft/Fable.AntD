module Fable.AntDesign.Spin

open Fable.AntDesign.Common
open Fable.React
open Fable.Core.JsInterop

type SpinBuilder()  =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Spin" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("delay")>] member inline _.delay (x: DSLElement, v: int) = x.attr "delay" v
    [<CustomOperation("indicator")>] member inline _.indicator (x: DSLElement, v: ReactElement) = x.attr "indicator" v
    [<CustomOperation("size")>] member inline _.size (x: DSLElement, v: Size) = x.attr "size" v
    [<CustomOperation("spinning")>] member inline _.spinning (x: DSLElement, v: bool) = x.attr "spinning" v
    [<CustomOperation("tip")>] member inline _.tip (x: DSLElement, v: string) = x.attr "tip" v
    [<CustomOperation("wrapperClassName")>] member inline _.wrapperClassName (x: DSLElement, v: string ) = x.attr "wrapperClassName" v
    