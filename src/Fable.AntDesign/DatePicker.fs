module Fable.AntDesign.DatePicker

open Browser.Types
open Fable.AntDesign.Common
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Fable.MomentJs
open System

[<StringEnum; RequireQualifiedAccess>]
type DatePickerMode =
    | Time
    | Date
    | Month
    | Year
    | Decade

[<StringEnum; RequireQualifiedAccess>]
type DatePickerPicker =
    | Date
    | Week
    | Month
    | Year

type DatePickerBase() =
    inherit ReactBuilder()
    [<CustomOperation("allowClear")>] member inline _.allowClear (x: DSLElement, v: bool) = x.attr "allowClear" v
    [<CustomOperation("autoFocus")>] member inline _.autoFocus (x: DSLElement, v: bool) = x.attr "autoFocus" v
    [<CustomOperation("dateRender")>] member inline _.dateRender (x: DSLElement, v: Func<Moment, Moment, ReactElement>) = x.attr "dateRender" v
    [<CustomOperation("disabled")>] member inline _.disabled (x: DSLElement, v: bool) = x.attr "disabled" v
    [<CustomOperation("disabledDate")>] member inline _.disabledDate (x: DSLElement, v: Moment -> bool) = x.attr "disabledDate" v
    [<CustomOperation("dropdownClassName")>] member inline _.dropdownClassName (x: DSLElement, v: string) = x.attr "dropdownClassName" v
    [<CustomOperation("getPopupContainer")>] member inline _.getPopupContainer (x: DSLElement, v: string -> HTMLElement) = x.attr "getPopupContainer" v
    [<CustomOperation("locale")>] member inline _.locale (x: DSLElement, v: obj) = x.attr "locale" v
    [<CustomOperation("mode")>] member inline _.mode (x: DSLElement, v: DatePickerMode) = x.attr "mode" v
    [<CustomOperation("isOpen")>] member inline _.isOpen (x: DSLElement, v: bool) = x.attr "open" v
    [<CustomOperation("picker")>] member inline _.picker (x: DSLElement, v: DatePickerPicker) = x.attr "picker" v
    [<CustomOperation("placeholder")>] member inline _.placeholder (x: DSLElement, v: string) = x.attr "placeholder" v
    [<CustomOperation("popupStyle")>] member inline _.popupStyle(x: DSLElement, css: Props.CSSProp list) = x.attr "popupStyle" (keyValueList CaseRules.LowerFirst css)
    [<CustomOperation("size")>] member inline _.size (x: DSLElement, v: Size) = x.attr "size" v
    [<CustomOperation("bordered")>] member inline _.bordered (x: DSLElement, v: bool) = x.attr "bordered" v
    [<CustomOperation("suffixIcon")>] member inline _.suffixIcon (x: DSLElement, v: ReactElement) = x.attr "suffixIcon" v
    [<CustomOperation("onOpenChange")>] member inline _.onOpenChange (x: DSLElement, v: bool -> unit) = x.attr "onOpenChange" v
    [<CustomOperation("onPanelChange")>] member inline _.onPanelChange (x: DSLElement, v: Func<Moment, DatePickerMode, unit>) = x.attr "onPanelChange" v
    [<CustomOperation("inputReadOnly")>] member inline _.inputReadOnly (x: DSLElement, v: bool) = x.attr "inputReadOnly" v

type DatePickerBuilder() =
    inherit DatePickerBase()
    member x.Run(s: DSLElement) = ofImport "DatePicker" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("defaultValue")>] member inline _.defaultValue (x: DSLElement, v: Moment) = x.attr "defaultValue" v
    [<CustomOperation("defaultPickerValue")>] member inline _.defaultPickerValue (x: DSLElement, v: Moment) = x.attr "defaultPickerValue" v
    [<CustomOperation("disabledTime")>] member inline _.disabledTime (x: DSLElement, v: Moment -> bool) = x.attr "disabledTime" v
    [<CustomOperation("format")>] member inline _.format (x: DSLElement, v: string array) = x.attr "format" v
    [<CustomOperation("renderExtraFooter")>] member inline _.renderExtraFooter (x: DSLElement, v: DatePickerMode -> ReactElement) = x.attr "renderExtraFooter" v
    [<CustomOperation("showTime")>] member inline _.showTime (x: DSLElement, v: bool) = x.attr "showTime" v
    [<CustomOperation("showToday")>] member inline _.showToday (x: DSLElement, v: bool) = x.attr "showToday" v
    [<CustomOperation("value")>] member inline _.value (x: DSLElement, v: Moment) = x.attr "value" v
    [<CustomOperation("onChange")>] member inline _.onChange (x: DSLElement, v: Func<Moment, string, unit>) = x.attr "onChange" v
    [<CustomOperation("onOk")>] member inline _.onOk (x: DSLElement, v: unit -> unit) = x.attr "onOk" v
    [<CustomOperation("onPanelChange")>] member inline _.onPanelChange (x: DSLElement, v: Func<Moment, DatePickerMode, unit>) = x.attr "onPanelChange" v

type YearPickerBuilder() =
    inherit DatePickerBase()
    member x.Run(s: DSLElement) = ofImport "DatePicker.YearPicker" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("defaultValue")>] member inline _.defaultValue (x: DSLElement, v: Moment) = x.attr "defaultValue" v
    [<CustomOperation("defaultPickerValue")>] member inline _.defaultPickerValue (x: DSLElement, v: Moment) = x.attr "defaultPickerValue" v
    [<CustomOperation("format")>] member inline _.format (x: DSLElement, v: string) = x.attr "format" v
    [<CustomOperation("renderExtraFooter")>] member inline _.renderExtraFooter (x: DSLElement, v: unit -> ReactElement) = x.attr "renderExtraFooter" v
    [<CustomOperation("value")>] member inline _.value (x: DSLElement, v: Moment) = x.attr "value" v
    [<CustomOperation("onChange")>] member inline _.onChange (x: DSLElement, v: Func<Moment, string, unit>) = x.attr "onChange" v

type QuarterPickerBuilder() =
    inherit DatePickerBase()
    member x.Run(s: DSLElement) = ofImport "DatePicker.QuarterPicker" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("defaultValue")>] member inline _.defaultValue (x: DSLElement, v: Moment) = x.attr "defaultValue" v
    [<CustomOperation("defaultPickerValue")>] member inline _.defaultPickerValue (x: DSLElement, v: Moment) = x.attr "defaultPickerValue" v
    [<CustomOperation("format")>] member inline _.format (x: DSLElement, v: string) = x.attr "format" v
    [<CustomOperation("renderExtraFooter")>] member inline _.renderExtraFooter (x: DSLElement, v: unit -> ReactElement) = x.attr "renderExtraFooter" v
    [<CustomOperation("value")>] member inline _.value (x: DSLElement, v: Moment) = x.attr "value" v
    [<CustomOperation("onChange")>] member inline _.onChange (x: DSLElement, v: Func<Moment, string, unit>) = x.attr "onChange" v

type MonthPickerBuilder() =
    inherit DatePickerBase()
    member x.Run(s: DSLElement) = ofImport "DatePicker.MonthPicker" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("defaultValue")>] member inline _.defaultValue (x: DSLElement, v: Moment) = x.attr "defaultValue" v
    [<CustomOperation("defaultPickerValue")>] member inline _.defaultPickerValue (x: DSLElement, v: Moment) = x.attr "defaultPickerValue" v
    [<CustomOperation("format")>] member inline _.format (x: DSLElement, v: string) = x.attr "format" v
    [<CustomOperation("monthCellContentRender")>] member inline _.monthCellContentRender (x: DSLElement, v: Func<string, string, ReactElement>) = x.attr "monthCellContentRender" v
    [<CustomOperation("renderExtraFooter")>] member inline _.renderExtraFooter (x: DSLElement, v: unit -> ReactElement) = x.attr "renderExtraFooter" v
    [<CustomOperation("value")>] member inline _.value (x: DSLElement, v: Moment) = x.attr "value" v
    [<CustomOperation("onChange")>] member inline _.onChange (x: DSLElement, v: Func<Moment, string, unit>) = x.attr "onChange" v

type WeekPickerBuilder() =
    inherit DatePickerBase()
    member x.Run(s: DSLElement) = ofImport "DatePicker.WeekPicker" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("defaultValue")>] member inline _.defaultValue (x: DSLElement, v: Moment) = x.attr "defaultValue" v
    [<CustomOperation("defaultPickerValue")>] member inline _.defaultPickerValue (x: DSLElement, v: Moment) = x.attr "defaultPickerValue" v
    [<CustomOperation("format")>] member inline _.format (x: DSLElement, v: string) = x.attr "format" v
    [<CustomOperation("value")>] member inline _.value (x: DSLElement, v: Moment) = x.attr "value" v
    [<CustomOperation("onChange")>] member inline _.onChange (x: DSLElement, v: Func<Moment, string, unit>) = x.attr "onChange" v
    [<CustomOperation("renderExtraFooter")>] member inline _.renderExtraFooter (x: DSLElement, v: DatePickerMode -> ReactElement) = x.attr "renderExtraFooter" v

type DateRangePickerBuilder() =
    inherit DatePickerBase()
    member x.Run(s: DSLElement) = ofImport "DatePicker.RangePicker" "antd" (createObj s.Attributes) s.Children

    [<CustomOperation("allowEmpty")>] member inline _.allowEmpty (x: DSLElement, v: bool array) = x.attr "allowEmpty" v
    [<CustomOperation("dateRender")>] member inline _.dateRender (x: DSLElement, v: Func<Moment, Moment, obj, ReactElement>) = x.attr "dateRender" v
    [<CustomOperation("defaultValue")>] member inline _.defaultValue (x: DSLElement, v: Moment array) = x.attr "defaultValue" v
    [<CustomOperation("defaultPickerValue")>] member inline _.defaultPickerValue (x: DSLElement, v: Moment array) = x.attr "defaultPickerValue" v
    [<CustomOperation("disabled")>] member inline _.disabled (x: DSLElement, v: bool array) = x.attr "disabled" v
    [<CustomOperation("disabledTime")>] member inline _.disabledTime (x: DSLElement, v: Moment array * string -> bool) = x.attr "disabledTime" v
    [<CustomOperation("format")>] member inline _.format (x: DSLElement, v: string array) = x.attr "Format" v
    [<CustomOperation("ranges")>] member inline _.ranges (x: DSLElement, v: obj) = x.attr "ranges" v
    [<CustomOperation("renderExtraFooter")>] member inline _.renderExtraFooter (x: DSLElement, v: unit -> ReactElement) = x.attr "renderExtraFooter" v
    [<CustomOperation("separator")>] member inline _.separator (x: DSLElement, v: string) = x.attr "separator" v
    [<CustomOperation("showTime")>] member inline _.showTime (x: DSLElement, v: bool) = x.attr "showTime" v
    [<CustomOperation("value")>] member inline _.value (x: DSLElement, v: Moment array) = x.attr "value" v
    [<CustomOperation("onCalendarChange")>] member inline _.onCalendarChange (x: DSLElement, v: Func<Moment array, string array, unit>) = x.attr "onCalendarChange" v
    [<CustomOperation("onChange")>] member inline _.onChange (x: DSLElement, v: Func<Moment array, string array, unit>) = x.attr "onChange" v