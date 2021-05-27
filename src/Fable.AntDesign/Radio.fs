module Fable.AntDesign.Radio

open Browser.Types
open Fable.AntDesign.Common
open Fable.Core
open Fable.React
open Fable.Core.JsInterop
  
type RadioOption = {
    label: string
    value: string
    disabled: bool
}

[<StringEnum; RequireQualifiedAccess>]
type RadioButtonStyle = Outline | Solid

type RadioBase<'T>() =
    inherit ReactBuilder()

    [<CustomOperation("autoFocus")>] member _.autoFocus (x: DSLElement, v: bool) = x.attr "autoFocus" v 
    [<CustomOperation("isChecked")>] member _.isChecked (x: DSLElement, v: bool) = x.attr "checked" v 
    [<CustomOperation("defaultChecked")>] member _.defaultChecked (x: DSLElement, v: bool) = x.attr "defaultChecked" v 
    [<CustomOperation("disabled")>] member _.disabled (x: DSLElement, v: bool) = x.attr "disabled" v 
    [<CustomOperation("value")>] member _.value (x: DSLElement, v: 'T) = x.attr "value" v 

type RadioBuilder<'T>() =
    inherit RadioBase<'T>()
    member x.Run(s: DSLElement) = ofImport "Radio" "antd" (createObj s.Attributes) s.Children

type RadioButtonBuilder<'T>() =
    inherit RadioBase<'T>()
    member x.Run(s: DSLElement) = ofImport "Radio.Button" "antd" (createObj s.Attributes) s.Children

type RadioGroupBuilder<'T>() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Radio.Group" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("defaultValue")>] member _.defaultValue (x: DSLElement, v: 'T) = x.attr "defaultValue" v 
    [<CustomOperation("disabled")>] member _.disabled (x: DSLElement, v: bool) = x.attr "disabled" v 
    [<CustomOperation("name")>] member _.name (x: DSLElement, v: string) = x.attr "name" v 
    [<CustomOperation("options")>] member _.options (x: DSLElement, v: RadioOption array) = x.attr "options" v 
    [<CustomOperation("size")>] member _.size (x: DSLElement, v: Size) = x.attr "size" v 
    [<CustomOperation("value")>] member _.value (x: DSLElement, v: 'T) = x.attr "value" v 
    [<CustomOperation("onChange")>] member _.onChange (x: DSLElement, v: Event -> unit) = x.attr "onChange" v 
    [<CustomOperation("buttonStyle")>] member _.buttonStyle (x: DSLElement, v: RadioButtonStyle) = x.attr "buttonStyle" v 