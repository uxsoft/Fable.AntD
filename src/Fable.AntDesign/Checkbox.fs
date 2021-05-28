module Fable.AntDesign.Checkbox

open Browser.Types
open Fable.AntDesign.Common
open Fable.React
open Fable.Core.JsInterop

type CheckboxBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Checkbox" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("autofocus")>] member inline _.autofocus (x: DSLElement, v: bool) = x.attr "autofocus" v 
    [<CustomOperation("isChecked")>] member inline _.isChecked (x: DSLElement, v: bool) = x.attr "checked" v 
    [<CustomOperation("defaultChecked")>] member inline _.defaultChecked (x: DSLElement, v: bool) = x.attr "defaultChecked" v 
    [<CustomOperation("disabled")>] member inline _.disabled (x: DSLElement, v: bool) = x.attr "disabled" v 
    [<CustomOperation("indeterminate")>] member inline _.indeterminate (x: DSLElement, v: bool) = x.attr "indeterminate" v 
    [<CustomOperation("onChange")>] member inline _.onChange (x: DSLElement, v: Event -> unit) = x.attr "onChange" v 

type CheckboxGroupBuilder() =
    inherit ReactBuilder()
    member x.Run(s: DSLElement) = ofImport "Checkbox.Group" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("defaultValue")>] member inline _.defaultValue (x: DSLElement, v: string array) = x.attr "defaultValue" v 
    [<CustomOperation("disabled")>] member inline _.disabled (x: DSLElement, v: bool) = x.attr "disabled" v  
    [<CustomOperation("name")>] member inline _.name (x: DSLElement, v: string) = x.attr "name" v 
    [<CustomOperation("options")>] member inline _.options (x: DSLElement, v: string array) = x.attr "options" v 
    [<CustomOperation("value")>] member inline _.value (x: DSLElement, v: string array) = x.attr "value" v 
    [<CustomOperation("onChange")>] member inline _.onChange (x: DSLElement, v: bool -> unit) = x.attr "onChange" v 
