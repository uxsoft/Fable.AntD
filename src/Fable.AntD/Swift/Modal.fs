namespace Fable.AntD

open System
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Browser.Types

type AntModal() =
    inherit AntElement<AntModal>(ofImport "Modal" "antd")
    member x.afterClose (v: (unit -> unit)) = x.attribute "afterClose" v
    member x.bodyStyle (css: Props.CSSProp list) = x.attribute "bodyStyle" (keyValueList CaseRules.LowerFirst css)
    member x.cancelButtonProps (props: AntButton) = x.attribute "cancelButtonProps" props.JSON
    member x.cancelText (v: ReactElement) = x.attribute "cancelText" v
    member x.centered (?v: bool) = x.attribute "centered" (Option.defaultValue true v)
    member x.closable (?v: bool) = x.attribute "closable" (Option.defaultValue true v)
    member x.closeIcon (v: ReactElement) = x.attribute "closeIcon" v 
    member x.confirmLoading (?v: bool) = x.attribute "confirmLoading" (Option.defaultValue true v)
    member x.destroyOnClose (?v: bool) = x.attribute "destroyOnClose" (Option.defaultValue true v)
    member x.footer (v: ReactElement) = x.attribute "footer" v
    member x.forceRender (?v: bool) = x.attribute "forceRender" (Option.defaultValue true v)
    member x.focusTriggerAfterClose (?v: bool) = x.attribute "focusTriggerAfterClose" (Option.defaultValue true v)
    member x.getContainer (v: (unit -> HTMLElement)) = x.attribute "getContainer" v
    member x.keyboard (?v: bool) = x.attribute "keyboard" (Option.defaultValue true v)
    member x.mask (?v: bool) = x.attribute "mask" (Option.defaultValue true v) 
    member x.maskClosable (?v: bool) = x.attribute "maskClosable" (Option.defaultValue true v) 
    member x.maskStyle (css: Props.CSSProp list) = x.attribute "maskStyle" (keyValueList CaseRules.LowerFirst css)
    member x.modalRender (v: Func<ReactElement, ReactElement>) = x.attribute "modalRender" v
    member x.okButtonProps (props: AntButton) = x.attribute "okButtonProps" props.JSON
    member x.okText (v: ReactElement) = x.attribute "okText" v 
    member x.okType (v: string) = x.attribute "okType" v 
    member x.title (v: ReactElement) = x.attribute "title" v 
    member x.visible (?v: bool) = x.attribute "visible" (Option.defaultValue true v) 
    member x.width (v: string) = x.attribute "width" v 
    member x.wrapClassName (v: string) = x.attribute "wrapClassName" v 
    member x.zIndex (v: int) = x.attribute "zIndex" v 
    member x.onCancel (v: (Event -> unit)) = x.attribute "onCancel" v 
    member x.onOk (v: (Event -> unit)) = x.attribute "onOk" v
    
// TODO API similar to AntNotification