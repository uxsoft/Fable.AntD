module Fable.AntDesign.Tooltip

open Browser.Types
open Fable.AntDesign.Common
open Fable.AntDesign.Button
open Fable.AntDesign.Slider
open Fable.Core
open Fable.React
open Fable.Core.JsInterop

[<StringEnum; RequireQualifiedAccess>]
type TooltipTrigger = Hover | Focus | Click | ContextMenu 

type TooltipBaseBuilder() =
    inherit ReactBuilder()
    [<CustomOperation("align")>] member inline _.align (x: DSLElement, v: obj) = x.attr "align" v
    [<CustomOperation("arrowPointAtCenter")>] member inline _.arrowPointAtCenter (x: DSLElement, ?v: bool) = x.attr "arrowPointAtCenter" (Option.defaultValue true v)
    [<CustomOperation("autoAdjustOverflow")>] member inline _.autoAdjustOverflow (x: DSLElement, ?v: bool) = x.attr "autoAdjustOverflow" (Option.defaultValue true v)
    [<CustomOperation("color")>] member inline _.color (x: DSLElement, v: string) = x.attr "color" v
    [<CustomOperation("defaultVisible")>] member inline _.defaultVisible (x: DSLElement, ?v: bool) = x.attr "defaultVisible" (Option.defaultValue true v)
    [<CustomOperation("destroyTooltipOnHide")>] member inline _.destroyTooltipOnHide (x: DSLElement, v: bool) = x.attr "destroyTooltipOnHide" v
    [<CustomOperation("getPopupContainer")>] member inline _.getPopupContainer (x: DSLElement, v: (unit -> HTMLElement)) = x.attr "getPopupContainer" v 
    [<CustomOperation("mouseEnterDelay")>] member inline _.mouseEnterDelay (x: DSLElement, v: float) = x.attr "mouseEnterDelay" v 
    [<CustomOperation("mouseLeaveDelay")>] member inline _.mouseLeaveDelay (x: DSLElement, v: float) = x.attr "mouseLeaveDelay" v 
    [<CustomOperation("overlayClassName")>] member inline _.overlayClassName (x: DSLElement, v: string) = x.attr "overlayClassName" v
    [<CustomOperation("overlayStyle")>] member inline _.overlayStyle (x: DSLElement, css: Props.CSSProp list) =  x.attr "overlayStyle" (keyValueList CaseRules.LowerFirst css)
    [<CustomOperation("placement")>] member inline _.placement (x: DSLElement, v: TooltipPlacement) = x.attr "placement" v 
    [<CustomOperation("trigger")>] member inline _.trigger (x: DSLElement, v: TooltipTrigger) = x.attr "trigger" v 
    [<CustomOperation("visible")>] member inline _.visible (x: DSLElement, ?v: bool) = x.attr "visible" (Option.defaultValue true v) 
    [<CustomOperation("onVisibleChange")>] member inline _.onVisibleChange (x: DSLElement, v: (bool -> unit)) = x.attr "onVisibleChange" v 

type PopoverBuilder() =
    inherit TooltipBaseBuilder()

    member x.Run(s: DSLElement) =
        ofImport "Popover" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("content")>] member inline _.content (x: DSLElement, v: ReactElement) = x.attr "content" v
    [<CustomOperation("title")>] member inline _.title (x: DSLElement, v: ReactElement) = x.attr "title" v

type PopconfirmBuilder() =
    inherit TooltipBaseBuilder()

    member x.Run(s: DSLElement) =
        ofImport "Popconfirm" "antd" (createObj s.Attributes) s.Children

    //TODO better type
    [<CustomOperation("cancelButtonProps")>] member inline _.cancelButtonProps (x: DSLElement, v: DSLElement) = x.attr "cancelButtonProps" (createObj v.Attributes)
    [<CustomOperation("cancelText")>] member inline _.cancelText (x: DSLElement, v: string) = x.attr "cancelText" v
    [<CustomOperation("disabled")>] member inline _.disabled (x: DSLElement, v: bool) = x.attr "disabled" v
    [<CustomOperation("icon")>] member inline _.icon (x: DSLElement, v: ReactElement) = x.attr "icon" v
    
    //TODO better type
    [<CustomOperation("okButtonProps")>] member inline _.okButtonProps (x: DSLElement, v: DSLElement) = x.attr "okButtonProps" (createObj v.Attributes)
    [<CustomOperation("okText")>] member inline _.okText (x: DSLElement, v: string) = x.attr "okText" v
    [<CustomOperation("okType")>] member inline _.okType (x: DSLElement, v: ButtonType) = x.attr "okType" v
    [<CustomOperation("title")>] member inline _.title (x: DSLElement, v: ReactElement) = x.attr "title" v
    [<CustomOperation("onCancel")>] member inline _.onCancel (x: DSLElement, v: unit -> unit) = x.attr "onCancel" v
    [<CustomOperation("onConfirm")>] member inline _.onConfirm (x: DSLElement, v: unit -> unit) = x.attr "onConfirm" v

type TooltipBuilder() =
    inherit TooltipBaseBuilder()

    member x.Run(s: DSLElement) =
        ofImport "Tooltip" "antd" (createObj s.Attributes) s.Children
    [<CustomOperation("title")>] member inline _.title (x: DSLElement, v: string) = x.attr "title" v