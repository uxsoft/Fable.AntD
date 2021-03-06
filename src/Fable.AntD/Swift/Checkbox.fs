namespace Fable.AntD

open Browser.Types
open Fable.React

type AntCheckbox() =
    inherit AntElement<AntCheckbox>(ofImport "Checkbox" "antd")
    member x.autofocus (?v: bool) = x.attribute "autofocus" (Option.defaultValue true v) 
    member x.isChecked (?v: bool) = x.attribute "checked" (Option.defaultValue true v) 
    member x.defaultChecked (?v: bool) = x.attribute "defaultChecked" (Option.defaultValue true v) 
    member x.disabled (?v: bool) = x.attribute "disabled" (Option.defaultValue true v) 
    member x.indeterminate (?v: bool) = x.attribute "indeterminate" (Option.defaultValue true v) 
    member x.onChange (v: (Event -> unit)) = x.attribute "onChange" v 

type AntCheckboxGroup() =
    inherit AntElement<AntCheckboxGroup>(ofImport "Checkbox.Group" "antd")
    member x.defaultValue (v: string array) = x.attribute "defaultValue" v 
    member x.disabled (?v: bool) = x.attribute "disabled" (Option.defaultValue true v)  
    member x.name (v: string) = x.attribute "name" v 
    member x.options (v: string array) = x.attribute "options" v 
    member x.value (v: string array) = x.attribute "value" v 
    member x.onChange (v: (bool -> unit)) = x.attribute "onChange" v 
