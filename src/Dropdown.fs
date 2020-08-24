namespace Fable.AntD

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React

[<StringEnum; RequireQualifiedAccess>]
type DropdownPlacement = BottomLeft | BottomCenter | BottomRight | TopLeft | TopCenter | TopRight

[<StringEnum; RequireQualifiedAccess>]
type DropdownTrigger = Click | Hover | ContextMenu

type AntDropdown() =
    inherit AntElement<AntDropdown>(ofImport "Dropdown" "antd")
    member x.disabled (v: bool) = x.attribute "disabled" v 
    member x.getPopupContainer (v: (unit -> HTMLElement)) = x.attribute "getPopupContainer" v 
    member x.overlay (v: ReactElement) = x.attribute "overlay" v 
    member x.overlayClassName (v: string) = x.attribute "overlayClassName" v
    member x.overlayStyle (css: Props.CSSProp list) = x.attribute "overlayStyle" (keyValueList CaseRules.LowerFirst css)
    member x.placement (v: DropdownPlacement) = x.attribute "placement" v 
    member x.trigger (v: DropdownTrigger array) = x.attribute "trigger" v 
    member x.visible (v: bool) = x.attribute "visible" v 
    member x.onVisibleChange (v: (bool -> unit)) = x.attribute "onVisibleChange" v 
    
type AntDropdownButton() =
    inherit AntElement<AntDropdownButton>(ofImport "Dropdown.Button" "antd")
    member x.disabled (v: bool) = x.attribute "disabled" v
    member x.icon (v: bool) = x.attribute "icon" v
    member x.overlay (v: ReactElement) = x.attribute "disabled" v 
    member x.placement (v: DropdownPlacement) = x.attribute "disabled" v 
    member x.size (v: Size) = x.attribute "size" v
    member x.trigger (v: DropdownTrigger array) = x.attribute "trigger" v
    member x.buttonType (v: ButtonType) = x.attribute "type" v
    member x.visible (v: bool) = x.attribute "visible" v
    member x.onClick (v: Event -> unit) = x.attribute "onClick" v 
    member x.onVisibleChange (v: (bool -> unit)) = x.attribute "onVisibleChange" v 
    member x.buttonsRender (v: ReactElement array array -> ReactElement) = x.attribute "buttonsRender" v