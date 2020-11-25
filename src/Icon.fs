namespace Fable.AntD
   
open Fable.React
open Browser.Types
   
type AntIcon(icon) =
    inherit AntElement<AntIcon>(icon)
    
    member x.spin (?v: bool) = x.attribute "spin" (Option.defaultValue true v) 
    member x.rotate (v: float) = x.attribute "rotate" v 
    member x.twoToneColor (v: string) = x.attribute "twoToneColor" v
    member x.onClick (v: Event -> unit) = x.attribute "onClick" v

    static member ArrowUpOutlined = ofImport "ArrowUpOutlined" "@ant-design/icons"
    static member ArrowDownOutlined = ofImport "ArrowDownOutlined" "@ant-design/icons"
    static member ArrowLeftOutlined = ofImport "ArrowLeftOutlined" "@ant-design/icons"
    static member ArrowRightOutlined = ofImport "ArrowRightOutlined" "@ant-design/icons"
    static member PlayCircleOutlined = ofImport "PlayCircleOutlined" "@ant-design/icons"
    static member UpSquareOutlined = ofImport "UpSquareOutlined" "@ant-design/icons"
    static member DownSquareOutlined = ofImport "DownSquareOutlined" "@ant-design/icons"
    static member LeftSquareOutlined = ofImport "LeftSquareOutlined" "@ant-design/icons"
    static member RightSquareOutlined = ofImport "RightSquareOutlined" "@ant-design/icons"
    static member LoginOutlined = ofImport "LoginOutlined" "@ant-design/icons"
    static member LogoutOutlined = ofImport "LogoutOutlined" "@ant-design/icons"
    static member MenuFoldOutlined = ofImport "MenuFoldOutlined" "@ant-design/icons"
    static member MenuUnfoldOutlined = ofImport "MenuUnfoldOutlined" "@ant-design/icons"
    static member BorderBottomOutlined = ofImport "BorderBottomOutlined" "@ant-design/icons"
    static member BorderHorizontalOutlined = ofImport "BorderHorizontalOutlined" "@ant-design/icons"
    static member BorderInnerOutlined = ofImport "BorderInnerOutlined" "@ant-design/icons"
    static member BorderOuterOutlined = ofImport "BorderOuterOutlined" "@ant-design/icons"
    static member BorderLeftOutlined = ofImport "BorderLeftOutlined" "@ant-design/icons"
    static member BorderRightOutlined = ofImport "BorderRightOutlined" "@ant-design/icons"
    static member BorderTopOutlined = ofImport "BorderTopOutlined" "@ant-design/icons"
    static member BorderVerticleOutlined = ofImport "BorderVerticleOutlined" "@ant-design/icons"
    static member PicCenterOutlined = ofImport "PicCenterOutlined" "@ant-design/icons"
    static member PicLeftOutlined = ofImport "PicLeftOutlined" "@ant-design/icons"
    static member PicRightOutlined = ofImport "PicRightOutlined" "@ant-design/icons"
    static member RadiusBottomleftOutlined = ofImport "RadiusBottomleftOutlined" "@ant-design/icons"
    static member RadiusBottomrightOutlined = ofImport "RadiusBottomrightOutlined" "@ant-design/icons"
    static member RadiusUpleftOutlined = ofImport "RadiusUpleftOutlined" "@ant-design/icons"
    static member RadiusUprightOutlined = ofImport "RadiusUprightOutlined" "@ant-design/icons"
    static member FullscreenOutlined = ofImport "FullscreenOutlined" "@ant-design/icons"
    static member FullscreenExitOutlined = ofImport "FullscreenExitOutlined" "@ant-design/icons"
    static member QuestionOutlined = ofImport "QuestionOutlined" "@ant-design/icons"
    static member QuestionCircleOutlined = ofImport "QuestionCircleOutlined" "@ant-design/icons"
    static member PlusOutlined = ofImport "PlusOutlined" "@ant-design/icons"
    static member PlusCircleOutlined = ofImport "PlusCircleOutlined" "@ant-design/icons"
    static member PauseOutlined = ofImport "PauseOutlined" "@ant-design/icons"
    static member PauseCircleOutlined = ofImport "PauseCircleOutlined" "@ant-design/icons"
    static member MinusOutlined = ofImport "MinusOutlined" "@ant-design/icons"
    static member MinusCircleOutlined = ofImport "MinusCircleOutlined" "@ant-design/icons"
    static member PlusSquareOutlined = ofImport "PlusSquareOutlined" "@ant-design/icons"
    static member MinusSquareOutlined = ofImport "MinusSquareOutlined" "@ant-design/icons"
    static member InfoOutlined = ofImport "InfoOutlined" "@ant-design/icons"
    static member InfoCircleOutlined = ofImport "InfoCircleOutlined" "@ant-design/icons"
    static member ExclamationOutlined = ofImport "ExclamationOutlined" "@ant-design/icons"
    static member ExclamationCircleOutlined = ofImport "ExclamationCircleOutlined" "@ant-design/icons"
    static member CloseOutlined = ofImport "CloseOutlined" "@ant-design/icons"
    static member CloseCircleOutlined = ofImport "CloseCircleOutlined" "@ant-design/icons"
    static member CloseSquareOutlined = ofImport "CloseSquareOutlined" "@ant-design/icons"
    static member CheckOutlined = ofImport "CheckOutlined" "@ant-design/icons"
    static member CheckCircleOutlined = ofImport "CheckCircleOutlined" "@ant-design/icons"
    static member CheckSquareOutlined = ofImport "CheckSquareOutlined" "@ant-design/icons"
    static member ClockCircleOutlined = ofImport "ClockCircleOutlined" "@ant-design/icons"
    static member WarningOutlined = ofImport "WarningOutlined" "@ant-design/icons"
    static member IssuesCloseOutlined = ofImport "IssuesCloseOutlined" "@ant-design/icons"
    static member StopOutlined = ofImport "StopOutlined" "@ant-design/icons"
    static member EditOutlined = ofImport "EditOutlined" "@ant-design/icons"
    static member FormOutlined = ofImport "FormOutlined" "@ant-design/icons"
    static member CopyOutlined = ofImport "CopyOutlined" "@ant-design/icons"
    static member ScissorOutlined = ofImport "ScissorOutlined" "@ant-design/icons"
    static member DeleteOutlined = ofImport "DeleteOutlined" "@ant-design/icons"
    static member SnippetsOutlined = ofImport "SnippetsOutlined" "@ant-design/icons"
    static member DiffOutlined = ofImport "DiffOutlined" "@ant-design/icons"
    static member HighlightOutlined = ofImport "HighlightOutlined" "@ant-design/icons"
    static member AlignCenterOutlined = ofImport "AlignCenterOutlined" "@ant-design/icons"
    static member AlignLeftOutlined = ofImport "AlignLeftOutlined" "@ant-design/icons"
    static member AlignRightOutlined = ofImport "AlignRightOutlined" "@ant-design/icons"
    static member BgColorsOutlined = ofImport "BgColorsOutlined" "@ant-design/icons"
    static member BoldOutlined = ofImport "BoldOutlined" "@ant-design/icons"
    static member ItalicOutlined = ofImport "ItalicOutlined" "@ant-design/icons"
    static member UnderlineOutlined = ofImport "UnderlineOutlined" "@ant-design/icons"
    static member StrikethroughOutlined = ofImport "StrikethroughOutlined" "@ant-design/icons"
    static member RedoOutlined = ofImport "RedoOutlined" "@ant-design/icons"
    static member UndoOutlined = ofImport "UndoOutlined" "@ant-design/icons"
    static member ZoomInOutlined = ofImport "ZoomInOutlined" "@ant-design/icons"
    static member ZoomOutOutlined = ofImport "ZoomOutOutlined" "@ant-design/icons"
    static member FontColorsOutlined = ofImport "FontColorsOutlined" "@ant-design/icons"
    static member FontSizeOutlined = ofImport "FontSizeOutlined" "@ant-design/icons"
    static member LineHeightOutlined = ofImport "LineHeightOutlined" "@ant-design/icons"
    static member DashOutlined = ofImport "DashOutlined" "@ant-design/icons"
    static member SmallDashOutlined = ofImport "SmallDashOutlined" "@ant-design/icons"
    static member SortAscendingOutlined = ofImport "SortAscendingOutlined" "@ant-design/icons"
    static member SortDescendingOutlined = ofImport "SortDescendingOutlined" "@ant-design/icons"
    static member DragOutlined = ofImport "DragOutlined" "@ant-design/icons"
    static member OrderedListOutlined = ofImport "OrderedListOutlined" "@ant-design/icons"
    static member UnorderedListOutlined = ofImport "UnorderedListOutlined" "@ant-design/icons"
    static member RadiusSettingOutlined = ofImport "RadiusSettingOutlined" "@ant-design/icons"
    static member ColumnWidthOutlined = ofImport "ColumnWidthOutlined" "@ant-design/icons"
    static member ColumnHeightOutlined = ofImport "ColumnHeightOutlined" "@ant-design/icons"
    static member AreaChartOutlined = ofImport "AreaChartOutlined" "@ant-design/icons"
    static member PieChartOutlined = ofImport "PieChartOutlined" "@ant-design/icons"
    static member BarChartOutlined = ofImport "BarChartOutlined" "@ant-design/icons"
    static member DotChartOutlined = ofImport "DotChartOutlined" "@ant-design/icons"
    static member LineChartOutlined = ofImport "LineChartOutlined" "@ant-design/icons"
    static member RadarChartOutlined = ofImport "RadarChartOutlined" "@ant-design/icons"
    static member HeatMapOutlined = ofImport "HeatMapOutlined" "@ant-design/icons"
    static member FallOutlined = ofImport "FallOutlined" "@ant-design/icons"
    static member RiseOutlined = ofImport "RiseOutlined" "@ant-design/icons"
    static member StockOutlined = ofImport "StockOutlined" "@ant-design/icons"
    static member BoxPlotOutlined = ofImport "BoxPlotOutlined" "@ant-design/icons"
    static member FundOutlined = ofImport "FundOutlined" "@ant-design/icons"
    static member SlidersOutlined = ofImport "SlidersOutlined" "@ant-design/icons"
    static member AndroidOutlined = ofImport "AndroidOutlined" "@ant-design/icons"
    static member AppleOutlined = ofImport "AppleOutlined" "@ant-design/icons"
    static member WindowsOutlined = ofImport "WindowsOutlined" "@ant-design/icons"
    static member IeOutlined = ofImport "IeOutlined" "@ant-design/icons"
    static member ChromeOutlined = ofImport "ChromeOutlined" "@ant-design/icons"
    static member GithubOutlined = ofImport "GithubOutlined" "@ant-design/icons"
    static member AliwangwangOutlined = ofImport "AliwangwangOutlined" "@ant-design/icons"
    static member DingdingOutlined = ofImport "DingdingOutlined" "@ant-design/icons"
    static member WeiboSquareOutlined = ofImport "WeiboSquareOutlined" "@ant-design/icons"
    static member WeiboCircleOutlined = ofImport "WeiboCircleOutlined" "@ant-design/icons"
    static member TaobaoCircleOutlined = ofImport "TaobaoCircleOutlined" "@ant-design/icons"
    static member Html5Outlined = ofImport "Html5Outlined" "@ant-design/icons"
    static member WeiboOutlined = ofImport "WeiboOutlined" "@ant-design/icons"
    static member TwitterOutlined = ofImport "TwitterOutlined" "@ant-design/icons"
    static member WechatOutlined = ofImport "WechatOutlined" "@ant-design/icons"
    static member YoutubeOutlined = ofImport "YoutubeOutlined" "@ant-design/icons"
    static member AlipayCircleOutlined = ofImport "AlipayCircleOutlined" "@ant-design/icons"
    static member TaobaoOutlined = ofImport "TaobaoOutlined" "@ant-design/icons"
    static member SkypeOutlined = ofImport "SkypeOutlined" "@ant-design/icons"
    static member QqOutlined = ofImport "QqOutlined" "@ant-design/icons"
    static member MediumWorkmarkOutlined = ofImport "MediumWorkmarkOutlined" "@ant-design/icons"
    static member GitlabOutlined = ofImport "GitlabOutlined" "@ant-design/icons"
    static member MediumOutlined = ofImport "MediumOutlined" "@ant-design/icons"
    static member LinkedinOutlined = ofImport "LinkedinOutlined" "@ant-design/icons"
    static member GooglePlusOutlined = ofImport "GooglePlusOutlined" "@ant-design/icons"
    static member DropboxOutlined = ofImport "DropboxOutlined" "@ant-design/icons"
    static member FacebookOutlined = ofImport "FacebookOutlined" "@ant-design/icons"
    static member CodepenOutlined = ofImport "CodepenOutlined" "@ant-design/icons"
    static member CodeSandboxOutlined = ofImport "CodeSandboxOutlined" "@ant-design/icons"
    static member AmazonOutlined = ofImport "AmazonOutlined" "@ant-design/icons"
    static member GoogleOutlined = ofImport "GoogleOutlined" "@ant-design/icons"
    static member CodepenCircleOutlined = ofImport "CodepenCircleOutlined" "@ant-design/icons"
    static member AlipayOutlined = ofImport "AlipayOutlined" "@ant-design/icons"
    static member AntDesignOutlined = ofImport "AntDesignOutlined" "@ant-design/icons"
    static member AntCloudOutlined = ofImport "AntCloudOutlined" "@ant-design/icons"
    static member AliyunOutlined = ofImport "AliyunOutlined" "@ant-design/icons"
    static member ZhihuOutlined = ofImport "ZhihuOutlined" "@ant-design/icons"
    static member SlackOutlined = ofImport "SlackOutlined" "@ant-design/icons"
    static member SlackSquareOutlined = ofImport "SlackSquareOutlined" "@ant-design/icons"
    static member BehanceOutlined = ofImport "BehanceOutlined" "@ant-design/icons"
    static member BehanceSquareOutlined = ofImport "BehanceSquareOutlined" "@ant-design/icons"
    static member DribbbleOutlined = ofImport "DribbbleOutlined" "@ant-design/icons"
    static member DribbbleSquareOutlined = ofImport "DribbbleSquareOutlined" "@ant-design/icons"
    static member InstagramOutlined = ofImport "InstagramOutlined" "@ant-design/icons"
    static member YuqueOutlined = ofImport "YuqueOutlined" "@ant-design/icons"
    static member AlibabaOutlined = ofImport "AlibabaOutlined" "@ant-design/icons"
    static member YahooOutlined = ofImport "YahooOutlined" "@ant-design/icons"
    static member RedditOutlined = ofImport "RedditOutlined" "@ant-design/icons"
    static member SketchOutlined = ofImport "SketchOutlined" "@ant-design/icons"
    static member AccountBookOutlined = ofImport "AccountBookOutlined" "@ant-design/icons"
    static member AimOutlined = ofImport "AimOutlined" "@ant-design/icons"
    static member AlertOutlined = ofImport "AlertOutlined" "@ant-design/icons"
    static member ApartmentOutlined = ofImport "ApartmentOutlined" "@ant-design/icons"
    static member ApiOutlined = ofImport "ApiOutlined" "@ant-design/icons"
    static member AppstoreAddOutlined = ofImport "AppstoreAddOutlined" "@ant-design/icons"
    static member AppstoreOutlined = ofImport "AppstoreOutlined" "@ant-design/icons"
    static member AudioOutlined = ofImport "AudioOutlined" "@ant-design/icons"
    static member AudioMutedOutlined = ofImport "AudioMutedOutlined" "@ant-design/icons"
    static member AuditOutlined = ofImport "AuditOutlined" "@ant-design/icons"
    static member BankOutlined = ofImport "BankOutlined" "@ant-design/icons"
    static member BarcodeOutlined = ofImport "BarcodeOutlined" "@ant-design/icons"
    static member BarsOutlined = ofImport "BarsOutlined" "@ant-design/icons"
    static member BellOutlined = ofImport "BellOutlined" "@ant-design/icons"
    static member BlockOutlined = ofImport "BlockOutlined" "@ant-design/icons"
    static member BookOutlined = ofImport "BookOutlined" "@ant-design/icons"
    static member BorderOutlined = ofImport "BorderOutlined" "@ant-design/icons"
    static member BorderlessTableOutlined = ofImport "BorderlessTableOutlined" "@ant-design/icons"
    static member BranchesOutlined = ofImport "BranchesOutlined" "@ant-design/icons"
    static member BugOutlined = ofImport "BugOutlined" "@ant-design/icons"
    static member BuildOutlined = ofImport "BuildOutlined" "@ant-design/icons"
    static member BulbOutlined = ofImport "BulbOutlined" "@ant-design/icons"
    static member CalculatorOutlined = ofImport "CalculatorOutlined" "@ant-design/icons"
    static member CalendarOutlined = ofImport "CalendarOutlined" "@ant-design/icons"
    static member CameraOutlined = ofImport "CameraOutlined" "@ant-design/icons"
    static member CarOutlined = ofImport "CarOutlined" "@ant-design/icons"
    static member CarryOutOutlined = ofImport "CarryOutOutlined" "@ant-design/icons"
    static member CiCircleOutlined = ofImport "CiCircleOutlined" "@ant-design/icons"
    static member CiOutlined = ofImport "CiOutlined" "@ant-design/icons"
    static member ClearOutlined = ofImport "ClearOutlined" "@ant-design/icons"
    static member CloudDownloadOutlined = ofImport "CloudDownloadOutlined" "@ant-design/icons"
    static member CloudOutlined = ofImport "CloudOutlined" "@ant-design/icons"
    static member CloudServerOutlined = ofImport "CloudServerOutlined" "@ant-design/icons"
    static member CloudSyncOutlined = ofImport "CloudSyncOutlined" "@ant-design/icons"
    static member CloudUploadOutlined = ofImport "CloudUploadOutlined" "@ant-design/icons"
    static member ClusterOutlined = ofImport "ClusterOutlined" "@ant-design/icons"
    static member CodeOutlined = ofImport "CodeOutlined" "@ant-design/icons"
    static member CoffeeOutlined = ofImport "CoffeeOutlined" "@ant-design/icons"
    static member CommentOutlined = ofImport "CommentOutlined" "@ant-design/icons"
    static member CompassOutlined = ofImport "CompassOutlined" "@ant-design/icons"
    static member CompressOutlined = ofImport "CompressOutlined" "@ant-design/icons"
    static member ConsoleSqlOutlined = ofImport "ConsoleSqlOutlined" "@ant-design/icons"
    static member ContactsOutlined = ofImport "ContactsOutlined" "@ant-design/icons"
    static member ContainerOutlined = ofImport "ContainerOutlined" "@ant-design/icons"
    static member ControlOutlined = ofImport "ControlOutlined" "@ant-design/icons"
    static member CopyrightCircleOutlined = ofImport "CopyrightCircleOutlined" "@ant-design/icons"
    static member CopyrightOutlined = ofImport "CopyrightOutlined" "@ant-design/icons"
    static member CreditCardOutlined = ofImport "CreditCardOutlined" "@ant-design/icons"
    static member CrownOutlined = ofImport "CrownOutlined" "@ant-design/icons"
    static member CustomerServiceOutlined = ofImport "CustomerServiceOutlined" "@ant-design/icons"
    static member DashboardOutlined = ofImport "DashboardOutlined" "@ant-design/icons"
    static member DatabaseOutlined = ofImport "DatabaseOutlined" "@ant-design/icons"
    static member DeleteColumnOutlined = ofImport "DeleteColumnOutlined" "@ant-design/icons"
    static member DeleteRowOutlined = ofImport "DeleteRowOutlined" "@ant-design/icons"
    static member DeliveredProcedureOutlined = ofImport "DeliveredProcedureOutlined" "@ant-design/icons"
    static member DeploymentUnitOutlined = ofImport "DeploymentUnitOutlined" "@ant-design/icons"
    static member DesktopOutlined = ofImport "DesktopOutlined" "@ant-design/icons"
    static member DingtalkOutlined = ofImport "DingtalkOutlined" "@ant-design/icons"
    static member DisconnectOutlined = ofImport "DisconnectOutlined" "@ant-design/icons"
    static member DislikeOutlined = ofImport "DislikeOutlined" "@ant-design/icons"
    static member DollarCircleOutlined = ofImport "DollarCircleOutlined" "@ant-design/icons"
    static member DollarOutlined = ofImport "DollarOutlined" "@ant-design/icons"
    static member DownloadOutlined = ofImport "DownloadOutlined" "@ant-design/icons"
    static member EllipsisOutlined = ofImport "EllipsisOutlined" "@ant-design/icons"
    static member EnvironmentOutlined = ofImport "EnvironmentOutlined" "@ant-design/icons"
    static member EuroCircleOutlined = ofImport "EuroCircleOutlined" "@ant-design/icons"
    static member EuroOutlined = ofImport "EuroOutlined" "@ant-design/icons"
    static member ExceptionOutlined = ofImport "ExceptionOutlined" "@ant-design/icons"
    static member ExpandAltOutlined = ofImport "ExpandAltOutlined" "@ant-design/icons"
    static member ExpandOutlined = ofImport "ExpandOutlined" "@ant-design/icons"
    static member ExperimentOutlined = ofImport "ExperimentOutlined" "@ant-design/icons"
    static member ExportOutlined = ofImport "ExportOutlined" "@ant-design/icons"
    static member EyeOutlined = ofImport "EyeOutlined" "@ant-design/icons"
    static member EyeInvisibleOutlined = ofImport "EyeInvisibleOutlined" "@ant-design/icons"
    static member FieldBinaryOutlined = ofImport "FieldBinaryOutlined" "@ant-design/icons"
    static member FieldNumberOutlined = ofImport "FieldNumberOutlined" "@ant-design/icons"
    static member FieldStringOutlined = ofImport "FieldStringOutlined" "@ant-design/icons"
    static member FieldTimeOutlined = ofImport "FieldTimeOutlined" "@ant-design/icons"
    static member FileAddOutlined = ofImport "FileAddOutlined" "@ant-design/icons"
    static member FileDoneOutlined = ofImport "FileDoneOutlined" "@ant-design/icons"
    static member FileExcelOutlined = ofImport "FileExcelOutlined" "@ant-design/icons"
    static member FileExclamationOutlined = ofImport "FileExclamationOutlined" "@ant-design/icons"
    static member FileOutlined = ofImport "FileOutlined" "@ant-design/icons"
    static member FileGifOutlined = ofImport "FileGifOutlined" "@ant-design/icons"
    static member FileImageOutlined = ofImport "FileImageOutlined" "@ant-design/icons"
    static member FileJpgOutlined = ofImport "FileJpgOutlined" "@ant-design/icons"
    static member FileMarkdownOutlined = ofImport "FileMarkdownOutlined" "@ant-design/icons"
    static member FilePdfOutlined = ofImport "FilePdfOutlined" "@ant-design/icons"
    static member FilePptOutlined = ofImport "FilePptOutlined" "@ant-design/icons"
    static member FileProtectOutlined = ofImport "FileProtectOutlined" "@ant-design/icons"
    static member FileSearchOutlined = ofImport "FileSearchOutlined" "@ant-design/icons"
    static member FileSyncOutlined = ofImport "FileSyncOutlined" "@ant-design/icons"
    static member FileTextOutlined = ofImport "FileTextOutlined" "@ant-design/icons"
    static member FileUnknownOutlined = ofImport "FileUnknownOutlined" "@ant-design/icons"
    static member FileWordOutlined = ofImport "FileWordOutlined" "@ant-design/icons"
    static member FileZipOutlined = ofImport "FileZipOutlined" "@ant-design/icons"
    static member FilterOutlined = ofImport "FilterOutlined" "@ant-design/icons"
    static member FireOutlined = ofImport "FireOutlined" "@ant-design/icons"
    static member FlagOutlined = ofImport "FlagOutlined" "@ant-design/icons"
    static member FolderAddOutlined = ofImport "FolderAddOutlined" "@ant-design/icons"
    static member FolderOutlined = ofImport "FolderOutlined" "@ant-design/icons"
    static member FolderOpenOutlined = ofImport "FolderOpenOutlined" "@ant-design/icons"
    static member FolderViewOutlined = ofImport "FolderViewOutlined" "@ant-design/icons"
    static member ForkOutlined = ofImport "ForkOutlined" "@ant-design/icons"
    static member FormatPainterOutlined = ofImport "FormatPainterOutlined" "@ant-design/icons"
    static member FrownOutlined = ofImport "FrownOutlined" "@ant-design/icons"
    static member FunctionOutlined = ofImport "FunctionOutlined" "@ant-design/icons"
    static member FundProjectionScreenOutlined = ofImport "FundProjectionScreenOutlined" "@ant-design/icons"
    static member FundViewOutlined = ofImport "FundViewOutlined" "@ant-design/icons"
    static member FunnelPlotOutlined = ofImport "FunnelPlotOutlined" "@ant-design/icons"
    static member GatewayOutlined = ofImport "GatewayOutlined" "@ant-design/icons"
    static member GifOutlined = ofImport "GifOutlined" "@ant-design/icons"
    static member GiftOutlined = ofImport "GiftOutlined" "@ant-design/icons"
    static member GlobalOutlined = ofImport "GlobalOutlined" "@ant-design/icons"
    static member GoldOutlined = ofImport "GoldOutlined" "@ant-design/icons"
    static member GroupOutlined = ofImport "GroupOutlined" "@ant-design/icons"
    static member HddOutlined = ofImport "HddOutlined" "@ant-design/icons"
    static member HeartOutlined = ofImport "HeartOutlined" "@ant-design/icons"
    static member HistoryOutlined = ofImport "HistoryOutlined" "@ant-design/icons"
    static member HomeOutlined = ofImport "HomeOutlined" "@ant-design/icons"
    static member HourglassOutlined = ofImport "HourglassOutlined" "@ant-design/icons"
    static member IdcardOutlined = ofImport "IdcardOutlined" "@ant-design/icons"
    static member ImportOutlined = ofImport "ImportOutlined" "@ant-design/icons"
    static member InboxOutlined = ofImport "InboxOutlined" "@ant-design/icons"
    static member InsertRowAboveOutlined = ofImport "InsertRowAboveOutlined" "@ant-design/icons"
    static member InsertRowBelowOutlined = ofImport "InsertRowBelowOutlined" "@ant-design/icons"
    static member InsertRowLeftOutlined = ofImport "InsertRowLeftOutlined" "@ant-design/icons"
    static member InsertRowRightOutlined = ofImport "InsertRowRightOutlined" "@ant-design/icons"
    static member InsuranceOutlined = ofImport "InsuranceOutlined" "@ant-design/icons"
    static member InteractionOutlined = ofImport "InteractionOutlined" "@ant-design/icons"
    static member KeyOutlined = ofImport "KeyOutlined" "@ant-design/icons"
    static member LaptopOutlined = ofImport "LaptopOutlined" "@ant-design/icons"
    static member LayoutOutlined = ofImport "LayoutOutlined" "@ant-design/icons"
    static member LikeOutlined = ofImport "LikeOutlined" "@ant-design/icons"
    static member LineOutlined = ofImport "LineOutlined" "@ant-design/icons"
    static member LinkOutlined = ofImport "LinkOutlined" "@ant-design/icons"
    static member Loading3QuartersOutlined = ofImport "Loading3QuartersOutlined" "@ant-design/icons"
    static member LoadingOutlined = ofImport "LoadingOutlined" "@ant-design/icons"
    static member LockOutlined = ofImport "LockOutlined" "@ant-design/icons"
    static member MacCommandOutlined = ofImport "MacCommandOutlined" "@ant-design/icons"
    static member MailOutlined = ofImport "MailOutlined" "@ant-design/icons"
    static member ManOutlined = ofImport "ManOutlined" "@ant-design/icons"
    static member MedicineBoxOutlined = ofImport "MedicineBoxOutlined" "@ant-design/icons"
    static member MehOutlined = ofImport "MehOutlined" "@ant-design/icons"
    static member MenuOutlined = ofImport "MenuOutlined" "@ant-design/icons"
    static member MergeCellsOutlined = ofImport "MergeCellsOutlined" "@ant-design/icons"
    static member MessageOutlined = ofImport "MessageOutlined" "@ant-design/icons"
    static member MobileOutlined = ofImport "MobileOutlined" "@ant-design/icons"
    static member MoneyCollectOutlined = ofImport "MoneyCollectOutlined" "@ant-design/icons"
    static member MonitorOutlined = ofImport "MonitorOutlined" "@ant-design/icons"
    static member MoreOutlined = ofImport "MoreOutlined" "@ant-design/icons"
    static member NodeCollapseOutlined = ofImport "NodeCollapseOutlined" "@ant-design/icons"
    static member NodeExpandOutlined = ofImport "NodeExpandOutlined" "@ant-design/icons"
    static member NodeIndexOutlined = ofImport "NodeIndexOutlined" "@ant-design/icons"
    static member NotificationOutlined = ofImport "NotificationOutlined" "@ant-design/icons"
    static member NumberOutlined = ofImport "NumberOutlined" "@ant-design/icons"
    static member OneToOneOutlined = ofImport "OneToOneOutlined" "@ant-design/icons"
    static member PaperClipOutlined = ofImport "PaperClipOutlined" "@ant-design/icons"
    static member PartitionOutlined = ofImport "PartitionOutlined" "@ant-design/icons"
    static member PayCircleOutlined = ofImport "PayCircleOutlined" "@ant-design/icons"
    static member PercentageOutlined = ofImport "PercentageOutlined" "@ant-design/icons"
    static member PhoneOutlined = ofImport "PhoneOutlined" "@ant-design/icons"
    static member PictureOutlined = ofImport "PictureOutlined" "@ant-design/icons"
    static member PlaySquareOutlined = ofImport "PlaySquareOutlined" "@ant-design/icons"
    static member PoundCircleOutlined = ofImport "PoundCircleOutlined" "@ant-design/icons"
    static member PoundOutlined = ofImport "PoundOutlined" "@ant-design/icons"
    static member PoweroffOutlined = ofImport "PoweroffOutlined" "@ant-design/icons"
    static member PrinterOutlined = ofImport "PrinterOutlined" "@ant-design/icons"
    static member ProfileOutlined = ofImport "ProfileOutlined" "@ant-design/icons"
    static member ProjectOutlined = ofImport "ProjectOutlined" "@ant-design/icons"
    static member PropertySafetyOutlined = ofImport "PropertySafetyOutlined" "@ant-design/icons"
    static member PullRequestOutlined = ofImport "PullRequestOutlined" "@ant-design/icons"
    static member PushpinOutlined = ofImport "PushpinOutlined" "@ant-design/icons"
    static member QrcodeOutlined = ofImport "QrcodeOutlined" "@ant-design/icons"
    static member ReadOutlined = ofImport "ReadOutlined" "@ant-design/icons"
    static member ReconciliationOutlined = ofImport "ReconciliationOutlined" "@ant-design/icons"
    static member RedEnvelopeOutlined = ofImport "RedEnvelopeOutlined" "@ant-design/icons"
    static member ReloadOutlined = ofImport "ReloadOutlined" "@ant-design/icons"
    static member RestOutlined = ofImport "RestOutlined" "@ant-design/icons"
    static member RobotOutlined = ofImport "RobotOutlined" "@ant-design/icons"
    static member RocketOutlined = ofImport "RocketOutlined" "@ant-design/icons"
    static member RotateLeftOutlined = ofImport "RotateLeftOutlined" "@ant-design/icons"
    static member RotateRightOutlined = ofImport "RotateRightOutlined" "@ant-design/icons"
    static member SafetyCertificateOutlined = ofImport "SafetyCertificateOutlined" "@ant-design/icons"
    static member SafetyOutlined = ofImport "SafetyOutlined" "@ant-design/icons"
    static member SaveOutlined = ofImport "SaveOutlined" "@ant-design/icons"
    static member ScanOutlined = ofImport "ScanOutlined" "@ant-design/icons"
    static member ScheduleOutlined = ofImport "ScheduleOutlined" "@ant-design/icons"
    static member SearchOutlined = ofImport "SearchOutlined" "@ant-design/icons"
    static member SecurityScanOutlined = ofImport "SecurityScanOutlined" "@ant-design/icons"
    static member SelectOutlined = ofImport "SelectOutlined" "@ant-design/icons"
    static member SendOutlined = ofImport "SendOutlined" "@ant-design/icons"
    static member SettingOutlined = ofImport "SettingOutlined" "@ant-design/icons"
    static member ShakeOutlined = ofImport "ShakeOutlined" "@ant-design/icons"
    static member ShareAltOutlined = ofImport "ShareAltOutlined" "@ant-design/icons"
    static member ShopOutlined = ofImport "ShopOutlined" "@ant-design/icons"
    static member ShoppingCartOutlined = ofImport "ShoppingCartOutlined" "@ant-design/icons"
    static member ShoppingOutlined = ofImport "ShoppingOutlined" "@ant-design/icons"
    static member SisternodeOutlined = ofImport "SisternodeOutlined" "@ant-design/icons"
    static member SkinOutlined = ofImport "SkinOutlined" "@ant-design/icons"
    static member SmileOutlined = ofImport "SmileOutlined" "@ant-design/icons"
    static member SolutionOutlined = ofImport "SolutionOutlined" "@ant-design/icons"
    static member SoundOutlined = ofImport "SoundOutlined" "@ant-design/icons"
    static member SplitCellsOutlined = ofImport "SplitCellsOutlined" "@ant-design/icons"
    static member StarOutlined = ofImport "StarOutlined" "@ant-design/icons"
    static member SubnodeOutlined = ofImport "SubnodeOutlined" "@ant-design/icons"
    static member SwitcherOutlined = ofImport "SwitcherOutlined" "@ant-design/icons"
    static member SyncOutlined = ofImport "SyncOutlined" "@ant-design/icons"
    static member TableOutlined = ofImport "TableOutlined" "@ant-design/icons"
    static member TabletOutlined = ofImport "TabletOutlined" "@ant-design/icons"
    static member TagOutlined = ofImport "TagOutlined" "@ant-design/icons"
    static member TagsOutlined = ofImport "TagsOutlined" "@ant-design/icons"
    static member TeamOutlined = ofImport "TeamOutlined" "@ant-design/icons"
    static member ThunderboltOutlined = ofImport "ThunderboltOutlined" "@ant-design/icons"
    static member ToTopOutlined = ofImport "ToTopOutlined" "@ant-design/icons"
    static member ToolOutlined = ofImport "ToolOutlined" "@ant-design/icons"
    static member TrademarkCircleOutlined = ofImport "TrademarkCircleOutlined" "@ant-design/icons"
    static member TrademarkOutlined = ofImport "TrademarkOutlined" "@ant-design/icons"
    static member TransactionOutlined = ofImport "TransactionOutlined" "@ant-design/icons"
    static member TranslationOutlined = ofImport "TranslationOutlined" "@ant-design/icons"
    static member TrophyOutlined = ofImport "TrophyOutlined" "@ant-design/icons"
    static member UngroupOutlined = ofImport "UngroupOutlined" "@ant-design/icons"
    static member UnlockOutlined = ofImport "UnlockOutlined" "@ant-design/icons"
    static member UploadOutlined = ofImport "UploadOutlined" "@ant-design/icons"
    static member UsbOutlined = ofImport "UsbOutlined" "@ant-design/icons"
    static member UserAddOutlined = ofImport "UserAddOutlined" "@ant-design/icons"
    static member UserDeleteOutlined = ofImport "UserDeleteOutlined" "@ant-design/icons"
    static member UserOutlined = ofImport "UserOutlined" "@ant-design/icons"
    static member UserSwitchOutlined = ofImport "UserSwitchOutlined" "@ant-design/icons"
    static member UsergroupAddOutlined = ofImport "UsergroupAddOutlined" "@ant-design/icons"
    static member UsergroupDeleteOutlined = ofImport "UsergroupDeleteOutlined" "@ant-design/icons"
    static member VerifiedOutlined = ofImport "VerifiedOutlined" "@ant-design/icons"
    static member VideoCameraAddOutlined = ofImport "VideoCameraAddOutlined" "@ant-design/icons"
    static member VideoCameraOutlined = ofImport "VideoCameraOutlined" "@ant-design/icons"
    static member WalletOutlined = ofImport "WalletOutlined" "@ant-design/icons"
    static member WhatsAppOutlined = ofImport "WhatsAppOutlined" "@ant-design/icons"
    static member WifiOutlined = ofImport "WifiOutlined" "@ant-design/icons"
    static member WomanOutlined = ofImport "WomanOutlined" "@ant-design/icons"
    static member StepBackwardFilled = ofImport "StepBackwardFilled" "@ant-design/icons"
    static member StepForwardFilled = ofImport "StepForwardFilled" "@ant-design/icons"
    static member FastBackwardFilled = ofImport "FastBackwardFilled" "@ant-design/icons"
    static member FastForwardFilled = ofImport "FastForwardFilled" "@ant-design/icons"
    static member CaretUpFilled = ofImport "CaretUpFilled" "@ant-design/icons"
    static member CaretDownFilled = ofImport "CaretDownFilled" "@ant-design/icons"
    static member CaretLeftFilled = ofImport "CaretLeftFilled" "@ant-design/icons"
    static member CaretRightFilled = ofImport "CaretRightFilled" "@ant-design/icons"
    static member UpCircleFilled = ofImport "UpCircleFilled" "@ant-design/icons"
    static member DownCircleFilled = ofImport "DownCircleFilled" "@ant-design/icons"
    static member LeftCircleFilled = ofImport "LeftCircleFilled" "@ant-design/icons"
    static member RightCircleFilled = ofImport "RightCircleFilled" "@ant-design/icons"
    static member ForwardFilled = ofImport "ForwardFilled" "@ant-design/icons"
    static member BackwardFilled = ofImport "BackwardFilled" "@ant-design/icons"
    static member PlayCircleFilled = ofImport "PlayCircleFilled" "@ant-design/icons"
    static member UpSquareFilled = ofImport "UpSquareFilled" "@ant-design/icons"
    static member DownSquareFilled = ofImport "DownSquareFilled" "@ant-design/icons"
    static member LeftSquareFilled = ofImport "LeftSquareFilled" "@ant-design/icons"
    static member RightSquareFilled = ofImport "RightSquareFilled" "@ant-design/icons"
    static member QuestionCircleFilled = ofImport "QuestionCircleFilled" "@ant-design/icons"
    static member PlusCircleFilled = ofImport "PlusCircleFilled" "@ant-design/icons"
    static member PauseCircleFilled = ofImport "PauseCircleFilled" "@ant-design/icons"
    static member MinusCircleFilled = ofImport "MinusCircleFilled" "@ant-design/icons"
    static member PlusSquareFilled = ofImport "PlusSquareFilled" "@ant-design/icons"
    static member MinusSquareFilled = ofImport "MinusSquareFilled" "@ant-design/icons"
    static member InfoCircleFilled = ofImport "InfoCircleFilled" "@ant-design/icons"
    static member ExclamationCircleFilled = ofImport "ExclamationCircleFilled" "@ant-design/icons"
    static member CloseCircleFilled = ofImport "CloseCircleFilled" "@ant-design/icons"
    static member CloseSquareFilled = ofImport "CloseSquareFilled" "@ant-design/icons"
    static member CheckCircleFilled = ofImport "CheckCircleFilled" "@ant-design/icons"
    static member CheckSquareFilled = ofImport "CheckSquareFilled" "@ant-design/icons"
    static member ClockCircleFilled = ofImport "ClockCircleFilled" "@ant-design/icons"
    static member WarningFilled = ofImport "WarningFilled" "@ant-design/icons"
    static member StopFilled = ofImport "StopFilled" "@ant-design/icons"
    static member EditFilled = ofImport "EditFilled" "@ant-design/icons"
    static member CopyFilled = ofImport "CopyFilled" "@ant-design/icons"
    static member DeleteFilled = ofImport "DeleteFilled" "@ant-design/icons"
    static member SnippetsFilled = ofImport "SnippetsFilled" "@ant-design/icons"
    static member DiffFilled = ofImport "DiffFilled" "@ant-design/icons"
    static member HighlightFilled = ofImport "HighlightFilled" "@ant-design/icons"
    static member PieChartFilled = ofImport "PieChartFilled" "@ant-design/icons"
    static member BoxPlotFilled = ofImport "BoxPlotFilled" "@ant-design/icons"
    static member FundFilled = ofImport "FundFilled" "@ant-design/icons"
    static member SlidersFilled = ofImport "SlidersFilled" "@ant-design/icons"
    static member AndroidFilled = ofImport "AndroidFilled" "@ant-design/icons"
    static member AppleFilled = ofImport "AppleFilled" "@ant-design/icons"
    static member WindowsFilled = ofImport "WindowsFilled" "@ant-design/icons"
    static member ChromeFilled = ofImport "ChromeFilled" "@ant-design/icons"
    static member GithubFilled = ofImport "GithubFilled" "@ant-design/icons"
    static member AliwangwangFilled = ofImport "AliwangwangFilled" "@ant-design/icons"
    static member WeiboSquareFilled = ofImport "WeiboSquareFilled" "@ant-design/icons"
    static member WeiboCircleFilled = ofImport "WeiboCircleFilled" "@ant-design/icons"
    static member TaobaoCircleFilled = ofImport "TaobaoCircleFilled" "@ant-design/icons"
    static member Html5Filled = ofImport "Html5Filled" "@ant-design/icons"
    static member WechatFilled = ofImport "WechatFilled" "@ant-design/icons"
    static member YoutubeFilled = ofImport "YoutubeFilled" "@ant-design/icons"
    static member AlipayCircleFilled = ofImport "AlipayCircleFilled" "@ant-design/icons"
    static member SkypeFilled = ofImport "SkypeFilled" "@ant-design/icons"
    static member GitlabFilled = ofImport "GitlabFilled" "@ant-design/icons"
    static member LinkedinFilled = ofImport "LinkedinFilled" "@ant-design/icons"
    static member FacebookFilled = ofImport "FacebookFilled" "@ant-design/icons"
    static member CodeSandboxCircleFilled = ofImport "CodeSandboxCircleFilled" "@ant-design/icons"
    static member CodepenCircleFilled = ofImport "CodepenCircleFilled" "@ant-design/icons"
    static member SlackSquareFilled = ofImport "SlackSquareFilled" "@ant-design/icons"
    static member BehanceSquareFilled = ofImport "BehanceSquareFilled" "@ant-design/icons"
    static member DribbbleSquareFilled = ofImport "DribbbleSquareFilled" "@ant-design/icons"
    static member InstagramFilled = ofImport "InstagramFilled" "@ant-design/icons"
    static member YuqueFilled = ofImport "YuqueFilled" "@ant-design/icons"
    static member YahooFilled = ofImport "YahooFilled" "@ant-design/icons"
    static member AccountBookFilled = ofImport "AccountBookFilled" "@ant-design/icons"
    static member AlertFilled = ofImport "AlertFilled" "@ant-design/icons"
    static member AlipaySquareFilled = ofImport "AlipaySquareFilled" "@ant-design/icons"
    static member AmazonCircleFilled = ofImport "AmazonCircleFilled" "@ant-design/icons"
    static member AmazonSquareFilled = ofImport "AmazonSquareFilled" "@ant-design/icons"
    static member ApiFilled = ofImport "ApiFilled" "@ant-design/icons"
    static member AppstoreFilled = ofImport "AppstoreFilled" "@ant-design/icons"
    static member AudioFilled = ofImport "AudioFilled" "@ant-design/icons"
    static member BankFilled = ofImport "BankFilled" "@ant-design/icons"
    static member BehanceCircleFilled = ofImport "BehanceCircleFilled" "@ant-design/icons"
    static member BellFilled = ofImport "BellFilled" "@ant-design/icons"
    static member BookFilled = ofImport "BookFilled" "@ant-design/icons"
    static member BugFilled = ofImport "BugFilled" "@ant-design/icons"
    static member BuildFilled = ofImport "BuildFilled" "@ant-design/icons"
    static member BulbFilled = ofImport "BulbFilled" "@ant-design/icons"
    static member CalculatorFilled = ofImport "CalculatorFilled" "@ant-design/icons"
    static member CalendarFilled = ofImport "CalendarFilled" "@ant-design/icons"
    static member CameraFilled = ofImport "CameraFilled" "@ant-design/icons"
    static member CarFilled = ofImport "CarFilled" "@ant-design/icons"
    static member CarryOutFilled = ofImport "CarryOutFilled" "@ant-design/icons"
    static member CiCircleFilled = ofImport "CiCircleFilled" "@ant-design/icons"
    static member CloudFilled = ofImport "CloudFilled" "@ant-design/icons"
    static member CodeFilled = ofImport "CodeFilled" "@ant-design/icons"
    static member CodeSandboxSquareFilled = ofImport "CodeSandboxSquareFilled" "@ant-design/icons"
    static member CodepenSquareFilled = ofImport "CodepenSquareFilled" "@ant-design/icons"
    static member CompassFilled = ofImport "CompassFilled" "@ant-design/icons"
    static member ContactsFilled = ofImport "ContactsFilled" "@ant-design/icons"
    static member ContainerFilled = ofImport "ContainerFilled" "@ant-design/icons"
    static member ControlFilled = ofImport "ControlFilled" "@ant-design/icons"
    static member CopyrightCircleFilled = ofImport "CopyrightCircleFilled" "@ant-design/icons"
    static member CreditCardFilled = ofImport "CreditCardFilled" "@ant-design/icons"
    static member CrownFilled = ofImport "CrownFilled" "@ant-design/icons"
    static member CustomerServiceFilled = ofImport "CustomerServiceFilled" "@ant-design/icons"
    static member DashboardFilled = ofImport "DashboardFilled" "@ant-design/icons"
    static member DatabaseFilled = ofImport "DatabaseFilled" "@ant-design/icons"
    static member DingtalkCircleFilled = ofImport "DingtalkCircleFilled" "@ant-design/icons"
    static member DingtalkSquareFilled = ofImport "DingtalkSquareFilled" "@ant-design/icons"
    static member DislikeFilled = ofImport "DislikeFilled" "@ant-design/icons"
    static member DollarCircleFilled = ofImport "DollarCircleFilled" "@ant-design/icons"
    static member DribbbleCircleFilled = ofImport "DribbbleCircleFilled" "@ant-design/icons"
    static member DropboxCircleFilled = ofImport "DropboxCircleFilled" "@ant-design/icons"
    static member DropboxSquareFilled = ofImport "DropboxSquareFilled" "@ant-design/icons"
    static member EnvironmentFilled = ofImport "EnvironmentFilled" "@ant-design/icons"
    static member EuroCircleFilled = ofImport "EuroCircleFilled" "@ant-design/icons"
    static member ExperimentFilled = ofImport "ExperimentFilled" "@ant-design/icons"
    static member EyeFilled = ofImport "EyeFilled" "@ant-design/icons"
    static member EyeInvisibleFilled = ofImport "EyeInvisibleFilled" "@ant-design/icons"
    static member FileAddFilled = ofImport "FileAddFilled" "@ant-design/icons"
    static member FileExcelFilled = ofImport "FileExcelFilled" "@ant-design/icons"
    static member FileExclamationFilled = ofImport "FileExclamationFilled" "@ant-design/icons"
    static member FileFilled = ofImport "FileFilled" "@ant-design/icons"
    static member FileImageFilled = ofImport "FileImageFilled" "@ant-design/icons"
    static member FileMarkdownFilled = ofImport "FileMarkdownFilled" "@ant-design/icons"
    static member FilePdfFilled = ofImport "FilePdfFilled" "@ant-design/icons"
    static member FilePptFilled = ofImport "FilePptFilled" "@ant-design/icons"
    static member FileTextFilled = ofImport "FileTextFilled" "@ant-design/icons"
    static member FileUnknownFilled = ofImport "FileUnknownFilled" "@ant-design/icons"
    static member FileWordFilled = ofImport "FileWordFilled" "@ant-design/icons"
    static member FileZipFilled = ofImport "FileZipFilled" "@ant-design/icons"
    static member FilterFilled = ofImport "FilterFilled" "@ant-design/icons"
    static member FireFilled = ofImport "FireFilled" "@ant-design/icons"
    static member FlagFilled = ofImport "FlagFilled" "@ant-design/icons"
    static member FolderAddFilled = ofImport "FolderAddFilled" "@ant-design/icons"
    static member FolderFilled = ofImport "FolderFilled" "@ant-design/icons"
    static member FolderOpenFilled = ofImport "FolderOpenFilled" "@ant-design/icons"
    static member FormatPainterFilled = ofImport "FormatPainterFilled" "@ant-design/icons"
    static member FrownFilled = ofImport "FrownFilled" "@ant-design/icons"
    static member FunnelPlotFilled = ofImport "FunnelPlotFilled" "@ant-design/icons"
    static member GiftFilled = ofImport "GiftFilled" "@ant-design/icons"
    static member GoldFilled = ofImport "GoldFilled" "@ant-design/icons"
    static member GoldenFilled = ofImport "GoldenFilled" "@ant-design/icons"
    static member GoogleCircleFilled = ofImport "GoogleCircleFilled" "@ant-design/icons"
    static member GooglePlusCircleFilled = ofImport "GooglePlusCircleFilled" "@ant-design/icons"
    static member GooglePlusSquareFilled = ofImport "GooglePlusSquareFilled" "@ant-design/icons"
    static member GoogleSquareFilled = ofImport "GoogleSquareFilled" "@ant-design/icons"
    static member HddFilled = ofImport "HddFilled" "@ant-design/icons"
    static member HeartFilled = ofImport "HeartFilled" "@ant-design/icons"
    static member HomeFilled = ofImport "HomeFilled" "@ant-design/icons"
    static member HourglassFilled = ofImport "HourglassFilled" "@ant-design/icons"
    static member IdcardFilled = ofImport "IdcardFilled" "@ant-design/icons"
    static member IeCircleFilled = ofImport "IeCircleFilled" "@ant-design/icons"
    static member IeSquareFilled = ofImport "IeSquareFilled" "@ant-design/icons"
    static member InsuranceFilled = ofImport "InsuranceFilled" "@ant-design/icons"
    static member InteractionFilled = ofImport "InteractionFilled" "@ant-design/icons"
    static member LayoutFilled = ofImport "LayoutFilled" "@ant-design/icons"
    static member LikeFilled = ofImport "LikeFilled" "@ant-design/icons"
    static member LockFilled = ofImport "LockFilled" "@ant-design/icons"
    static member MacCommandFilled = ofImport "MacCommandFilled" "@ant-design/icons"
    static member MailFilled = ofImport "MailFilled" "@ant-design/icons"
    static member MedicineBoxFilled = ofImport "MedicineBoxFilled" "@ant-design/icons"
    static member MediumCircleFilled = ofImport "MediumCircleFilled" "@ant-design/icons"
    static member MediumSquareFilled = ofImport "MediumSquareFilled" "@ant-design/icons"
    static member MehFilled = ofImport "MehFilled" "@ant-design/icons"
    static member MessageFilled = ofImport "MessageFilled" "@ant-design/icons"
    static member MobileFilled = ofImport "MobileFilled" "@ant-design/icons"
    static member MoneyCollectFilled = ofImport "MoneyCollectFilled" "@ant-design/icons"
    static member NotificationFilled = ofImport "NotificationFilled" "@ant-design/icons"
    static member PayCircleFilled = ofImport "PayCircleFilled" "@ant-design/icons"
    static member PhoneFilled = ofImport "PhoneFilled" "@ant-design/icons"
    static member PictureFilled = ofImport "PictureFilled" "@ant-design/icons"
    static member PlaySquareFilled = ofImport "PlaySquareFilled" "@ant-design/icons"
    static member PoundCircleFilled = ofImport "PoundCircleFilled" "@ant-design/icons"
    static member PrinterFilled = ofImport "PrinterFilled" "@ant-design/icons"
    static member ProfileFilled = ofImport "ProfileFilled" "@ant-design/icons"
    static member ProjectFilled = ofImport "ProjectFilled" "@ant-design/icons"
    static member PropertySafetyFilled = ofImport "PropertySafetyFilled" "@ant-design/icons"
    static member PushpinFilled = ofImport "PushpinFilled" "@ant-design/icons"
    static member QqCircleFilled = ofImport "QqCircleFilled" "@ant-design/icons"
    static member QqSquareFilled = ofImport "QqSquareFilled" "@ant-design/icons"
    static member ReadFilled = ofImport "ReadFilled" "@ant-design/icons"
    static member ReconciliationFilled = ofImport "ReconciliationFilled" "@ant-design/icons"
    static member RedEnvelopeFilled = ofImport "RedEnvelopeFilled" "@ant-design/icons"
    static member RedditCircleFilled = ofImport "RedditCircleFilled" "@ant-design/icons"
    static member RedditSquareFilled = ofImport "RedditSquareFilled" "@ant-design/icons"
    static member RestFilled = ofImport "RestFilled" "@ant-design/icons"
    static member RobotFilled = ofImport "RobotFilled" "@ant-design/icons"
    static member RocketFilled = ofImport "RocketFilled" "@ant-design/icons"
    static member SafetyCertificateFilled = ofImport "SafetyCertificateFilled" "@ant-design/icons"
    static member SaveFilled = ofImport "SaveFilled" "@ant-design/icons"
    static member ScheduleFilled = ofImport "ScheduleFilled" "@ant-design/icons"
    static member SecurityScanFilled = ofImport "SecurityScanFilled" "@ant-design/icons"
    static member SettingFilled = ofImport "SettingFilled" "@ant-design/icons"
    static member ShopFilled = ofImport "ShopFilled" "@ant-design/icons"
    static member ShoppingFilled = ofImport "ShoppingFilled" "@ant-design/icons"
    static member SignalFilled = ofImport "SignalFilled" "@ant-design/icons"
    static member SketchCircleFilled = ofImport "SketchCircleFilled" "@ant-design/icons"
    static member SketchSquareFilled = ofImport "SketchSquareFilled" "@ant-design/icons"
    static member SkinFilled = ofImport "SkinFilled" "@ant-design/icons"
    static member SlackCircleFilled = ofImport "SlackCircleFilled" "@ant-design/icons"
    static member SmileFilled = ofImport "SmileFilled" "@ant-design/icons"
    static member SoundFilled = ofImport "SoundFilled" "@ant-design/icons"
    static member StarFilled = ofImport "StarFilled" "@ant-design/icons"
    static member SwitcherFilled = ofImport "SwitcherFilled" "@ant-design/icons"
    static member TabletFilled = ofImport "TabletFilled" "@ant-design/icons"
    static member TagFilled = ofImport "TagFilled" "@ant-design/icons"
    static member TagsFilled = ofImport "TagsFilled" "@ant-design/icons"
    static member TaobaoSquareFilled = ofImport "TaobaoSquareFilled" "@ant-design/icons"
    static member ThunderboltFilled = ofImport "ThunderboltFilled" "@ant-design/icons"
    static member ToolFilled = ofImport "ToolFilled" "@ant-design/icons"
    static member TrademarkCircleFilled = ofImport "TrademarkCircleFilled" "@ant-design/icons"
    static member TrophyFilled = ofImport "TrophyFilled" "@ant-design/icons"
    static member TwitterCircleFilled = ofImport "TwitterCircleFilled" "@ant-design/icons"
    static member TwitterSquareFilled = ofImport "TwitterSquareFilled" "@ant-design/icons"
    static member UnlockFilled = ofImport "UnlockFilled" "@ant-design/icons"
    static member UsbFilled = ofImport "UsbFilled" "@ant-design/icons"
    static member VideoCameraFilled = ofImport "VideoCameraFilled" "@ant-design/icons"
    static member WalletFilled = ofImport "WalletFilled" "@ant-design/icons"
    static member ZhihuCircleFilled = ofImport "ZhihuCircleFilled" "@ant-design/icons"
    static member ZhihuSquareFilled = ofImport "ZhihuSquareFilled" "@ant-design/icons"
    static member UpCircleTwoTone = ofImport "UpCircleTwoTone" "@ant-design/icons"
    static member DownCircleTwoTone = ofImport "DownCircleTwoTone" "@ant-design/icons"
    static member LeftCircleTwoTone = ofImport "LeftCircleTwoTone" "@ant-design/icons"
    static member RightCircleTwoTone = ofImport "RightCircleTwoTone" "@ant-design/icons"
    static member PlayCircleTwoTone = ofImport "PlayCircleTwoTone" "@ant-design/icons"
    static member UpSquareTwoTone = ofImport "UpSquareTwoTone" "@ant-design/icons"
    static member DownSquareTwoTone = ofImport "DownSquareTwoTone" "@ant-design/icons"
    static member LeftSquareTwoTone = ofImport "LeftSquareTwoTone" "@ant-design/icons"
    static member RightSquareTwoTone = ofImport "RightSquareTwoTone" "@ant-design/icons"
    static member QuestionCircleTwoTone = ofImport "QuestionCircleTwoTone" "@ant-design/icons"
    static member PlusCircleTwoTone = ofImport "PlusCircleTwoTone" "@ant-design/icons"
    static member PauseCircleTwoTone = ofImport "PauseCircleTwoTone" "@ant-design/icons"
    static member MinusCircleTwoTone = ofImport "MinusCircleTwoTone" "@ant-design/icons"
    static member PlusSquareTwoTone = ofImport "PlusSquareTwoTone" "@ant-design/icons"
    static member MinusSquareTwoTone = ofImport "MinusSquareTwoTone" "@ant-design/icons"
    static member InfoCircleTwoTone = ofImport "InfoCircleTwoTone" "@ant-design/icons"
    static member ExclamationCircleTwoTone = ofImport "ExclamationCircleTwoTone" "@ant-design/icons"
    static member CloseCircleTwoTone = ofImport "CloseCircleTwoTone" "@ant-design/icons"
    static member CloseSquareTwoTone = ofImport "CloseSquareTwoTone" "@ant-design/icons"
    static member CheckCircleTwoTone = ofImport "CheckCircleTwoTone" "@ant-design/icons"
    static member CheckSquareTwoTone = ofImport "CheckSquareTwoTone" "@ant-design/icons"
    static member ClockCircleTwoTone = ofImport "ClockCircleTwoTone" "@ant-design/icons"
    static member WarningTwoTone = ofImport "WarningTwoTone" "@ant-design/icons"
    static member StopTwoTone = ofImport "StopTwoTone" "@ant-design/icons"
    static member EditTwoTone = ofImport "EditTwoTone" "@ant-design/icons"
    static member CopyTwoTone = ofImport "CopyTwoTone" "@ant-design/icons"
    static member DeleteTwoTone = ofImport "DeleteTwoTone" "@ant-design/icons"
    static member SnippetsTwoTone = ofImport "SnippetsTwoTone" "@ant-design/icons"
    static member DiffTwoTone = ofImport "DiffTwoTone" "@ant-design/icons"
    static member HighlightTwoTone = ofImport "HighlightTwoTone" "@ant-design/icons"
    static member PieChartTwoTone = ofImport "PieChartTwoTone" "@ant-design/icons"
    static member BoxPlotTwoTone = ofImport "BoxPlotTwoTone" "@ant-design/icons"
    static member FundTwoTone = ofImport "FundTwoTone" "@ant-design/icons"
    static member SlidersTwoTone = ofImport "SlidersTwoTone" "@ant-design/icons"
    static member Html5TwoTone = ofImport "Html5TwoTone" "@ant-design/icons"
    static member AccountBookTwoTone = ofImport "AccountBookTwoTone" "@ant-design/icons"
    static member AlertTwoTone = ofImport "AlertTwoTone" "@ant-design/icons"
    static member ApiTwoTone = ofImport "ApiTwoTone" "@ant-design/icons"
    static member AppstoreTwoTone = ofImport "AppstoreTwoTone" "@ant-design/icons"
    static member AudioTwoTone = ofImport "AudioTwoTone" "@ant-design/icons"
    static member BankTwoTone = ofImport "BankTwoTone" "@ant-design/icons"
    static member BellTwoTone = ofImport "BellTwoTone" "@ant-design/icons"
    static member BookTwoTone = ofImport "BookTwoTone" "@ant-design/icons"
    static member BugTwoTone = ofImport "BugTwoTone" "@ant-design/icons"
    static member BuildTwoTone = ofImport "BuildTwoTone" "@ant-design/icons"
    static member BulbTwoTone = ofImport "BulbTwoTone" "@ant-design/icons"
    static member CalculatorTwoTone = ofImport "CalculatorTwoTone" "@ant-design/icons"
    static member CalendarTwoTone = ofImport "CalendarTwoTone" "@ant-design/icons"
    static member CameraTwoTone = ofImport "CameraTwoTone" "@ant-design/icons"
    static member CarTwoTone = ofImport "CarTwoTone" "@ant-design/icons"
    static member CarryOutTwoTone = ofImport "CarryOutTwoTone" "@ant-design/icons"
    static member CiCircleTwoTone = ofImport "CiCircleTwoTone" "@ant-design/icons"
    static member CiTwoTone = ofImport "CiTwoTone" "@ant-design/icons"
    static member CloudTwoTone = ofImport "CloudTwoTone" "@ant-design/icons"
    static member CodeTwoTone = ofImport "CodeTwoTone" "@ant-design/icons"
    static member CompassTwoTone = ofImport "CompassTwoTone" "@ant-design/icons"
    static member ContactsTwoTone = ofImport "ContactsTwoTone" "@ant-design/icons"
    static member ContainerTwoTone = ofImport "ContainerTwoTone" "@ant-design/icons"
    static member ControlTwoTone = ofImport "ControlTwoTone" "@ant-design/icons"
    static member CopyrightCircleTwoTone = ofImport "CopyrightCircleTwoTone" "@ant-design/icons"
    static member CopyrightTwoTone = ofImport "CopyrightTwoTone" "@ant-design/icons"
    static member CreditCardTwoTone = ofImport "CreditCardTwoTone" "@ant-design/icons"
    static member CrownTwoTone = ofImport "CrownTwoTone" "@ant-design/icons"
    static member CustomerServiceTwoTone = ofImport "CustomerServiceTwoTone" "@ant-design/icons"
    static member DashboardTwoTone = ofImport "DashboardTwoTone" "@ant-design/icons"
    static member DatabaseTwoTone = ofImport "DatabaseTwoTone" "@ant-design/icons"
    static member DislikeTwoTone = ofImport "DislikeTwoTone" "@ant-design/icons"
    static member DollarCircleTwoTone = ofImport "DollarCircleTwoTone" "@ant-design/icons"
    static member DollarTwoTone = ofImport "DollarTwoTone" "@ant-design/icons"
    static member EnvironmentTwoTone = ofImport "EnvironmentTwoTone" "@ant-design/icons"
    static member EuroCircleTwoTone = ofImport "EuroCircleTwoTone" "@ant-design/icons"
    static member EuroTwoTone = ofImport "EuroTwoTone" "@ant-design/icons"
    static member ExperimentTwoTone = ofImport "ExperimentTwoTone" "@ant-design/icons"
    static member EyeTwoTone = ofImport "EyeTwoTone" "@ant-design/icons"
    static member EyeInvisibleTwoTone = ofImport "EyeInvisibleTwoTone" "@ant-design/icons"
    static member FileAddTwoTone = ofImport "FileAddTwoTone" "@ant-design/icons"
    static member FileExcelTwoTone = ofImport "FileExcelTwoTone" "@ant-design/icons"
    static member FileExclamationTwoTone = ofImport "FileExclamationTwoTone" "@ant-design/icons"
    static member FileTwoTone = ofImport "FileTwoTone" "@ant-design/icons"
    static member FileImageTwoTone = ofImport "FileImageTwoTone" "@ant-design/icons"
    static member FileMarkdownTwoTone = ofImport "FileMarkdownTwoTone" "@ant-design/icons"
    static member FilePdfTwoTone = ofImport "FilePdfTwoTone" "@ant-design/icons"
    static member FilePptTwoTone = ofImport "FilePptTwoTone" "@ant-design/icons"
    static member FileTextTwoTone = ofImport "FileTextTwoTone" "@ant-design/icons"
    static member FileUnknownTwoTone = ofImport "FileUnknownTwoTone" "@ant-design/icons"
    static member FileWordTwoTone = ofImport "FileWordTwoTone" "@ant-design/icons"
    static member FileZipTwoTone = ofImport "FileZipTwoTone" "@ant-design/icons"
    static member FilterTwoTone = ofImport "FilterTwoTone" "@ant-design/icons"
    static member FireTwoTone = ofImport "FireTwoTone" "@ant-design/icons"
    static member FlagTwoTone = ofImport "FlagTwoTone" "@ant-design/icons"
    static member FolderAddTwoTone = ofImport "FolderAddTwoTone" "@ant-design/icons"
    static member FolderTwoTone = ofImport "FolderTwoTone" "@ant-design/icons"
    static member FolderOpenTwoTone = ofImport "FolderOpenTwoTone" "@ant-design/icons"
    static member FrownTwoTone = ofImport "FrownTwoTone" "@ant-design/icons"
    static member FunnelPlotTwoTone = ofImport "FunnelPlotTwoTone" "@ant-design/icons"
    static member GiftTwoTone = ofImport "GiftTwoTone" "@ant-design/icons"
    static member GoldTwoTone = ofImport "GoldTwoTone" "@ant-design/icons"
    static member HddTwoTone = ofImport "HddTwoTone" "@ant-design/icons"
    static member HeartTwoTone = ofImport "HeartTwoTone" "@ant-design/icons"
    static member HomeTwoTone = ofImport "HomeTwoTone" "@ant-design/icons"
    static member HourglassTwoTone = ofImport "HourglassTwoTone" "@ant-design/icons"
    static member IdcardTwoTone = ofImport "IdcardTwoTone" "@ant-design/icons"
    static member InsuranceTwoTone = ofImport "InsuranceTwoTone" "@ant-design/icons"
    static member InteractionTwoTone = ofImport "InteractionTwoTone" "@ant-design/icons"
    static member LayoutTwoTone = ofImport "LayoutTwoTone" "@ant-design/icons"
    static member LikeTwoTone = ofImport "LikeTwoTone" "@ant-design/icons"
    static member LockTwoTone = ofImport "LockTwoTone" "@ant-design/icons"
    static member MailTwoTone = ofImport "MailTwoTone" "@ant-design/icons"
    static member MedicineBoxTwoTone = ofImport "MedicineBoxTwoTone" "@ant-design/icons"
    static member MehTwoTone = ofImport "MehTwoTone" "@ant-design/icons"
    static member MessageTwoTone = ofImport "MessageTwoTone" "@ant-design/icons"
    static member MobileTwoTone = ofImport "MobileTwoTone" "@ant-design/icons"
    static member MoneyCollectTwoTone = ofImport "MoneyCollectTwoTone" "@ant-design/icons"
    static member NotificationTwoTone = ofImport "NotificationTwoTone" "@ant-design/icons"
    static member PhoneTwoTone = ofImport "PhoneTwoTone" "@ant-design/icons"
    static member PictureTwoTone = ofImport "PictureTwoTone" "@ant-design/icons"
    static member PlaySquareTwoTone = ofImport "PlaySquareTwoTone" "@ant-design/icons"
    static member PoundCircleTwoTone = ofImport "PoundCircleTwoTone" "@ant-design/icons"
    static member PrinterTwoTone = ofImport "PrinterTwoTone" "@ant-design/icons"
    static member ProfileTwoTone = ofImport "ProfileTwoTone" "@ant-design/icons"
    static member ProjectTwoTone = ofImport "ProjectTwoTone" "@ant-design/icons"
    static member PropertySafetyTwoTone = ofImport "PropertySafetyTwoTone" "@ant-design/icons"
    static member PushpinTwoTone = ofImport "PushpinTwoTone" "@ant-design/icons"
    static member ReconciliationTwoTone = ofImport "ReconciliationTwoTone" "@ant-design/icons"
    static member RedEnvelopeTwoTone = ofImport "RedEnvelopeTwoTone" "@ant-design/icons"
    static member RestTwoTone = ofImport "RestTwoTone" "@ant-design/icons"
    static member RocketTwoTone = ofImport "RocketTwoTone" "@ant-design/icons"
    static member SafetyCertificateTwoTone = ofImport "SafetyCertificateTwoTone" "@ant-design/icons"
    static member SaveTwoTone = ofImport "SaveTwoTone" "@ant-design/icons"
    static member ScheduleTwoTone = ofImport "ScheduleTwoTone" "@ant-design/icons"
    static member SecurityScanTwoTone = ofImport "SecurityScanTwoTone" "@ant-design/icons"
    static member SettingTwoTone = ofImport "SettingTwoTone" "@ant-design/icons"
    static member ShopTwoTone = ofImport "ShopTwoTone" "@ant-design/icons"
    static member ShoppingTwoTone = ofImport "ShoppingTwoTone" "@ant-design/icons"
    static member SkinTwoTone = ofImport "SkinTwoTone" "@ant-design/icons"
    static member SmileTwoTone = ofImport "SmileTwoTone" "@ant-design/icons"
    static member SoundTwoTone = ofImport "SoundTwoTone" "@ant-design/icons"
    static member StarTwoTone = ofImport "StarTwoTone" "@ant-design/icons"
    static member SwitcherTwoTone = ofImport "SwitcherTwoTone" "@ant-design/icons"
    static member TabletTwoTone = ofImport "TabletTwoTone" "@ant-design/icons"
    static member TagTwoTone = ofImport "TagTwoTone" "@ant-design/icons"
    static member TagsTwoTone = ofImport "TagsTwoTone" "@ant-design/icons"
    static member ThunderboltTwoTone = ofImport "ThunderboltTwoTone" "@ant-design/icons"
    static member ToolTwoTone = ofImport "ToolTwoTone" "@ant-design/icons"
    static member TrademarkCircleTwoTone = ofImport "TrademarkCircleTwoTone" "@ant-design/icons"
    static member TrophyTwoTone = ofImport "TrophyTwoTone" "@ant-design/icons"
    static member UnlockTwoTone = ofImport "UnlockTwoTone" "@ant-design/icons"
    static member UsbTwoTone = ofImport "UsbTwoTone" "@ant-design/icons"
    static member VideoCameraTwoTone = ofImport "VideoCameraTwoTone" "@ant-design/icons"
    static member WalletTwoTone = ofImport "WalletTwoTone" "@ant-design/icons"

    static member IconMap =
        [|
            "ArrowUpOutlined", AntIcon.ArrowUpOutlined;
            "ArrowDownOutlined", AntIcon.ArrowDownOutlined;
            "ArrowLeftOutlined", AntIcon.ArrowLeftOutlined;
            "PlayCircleOutlined", AntIcon.PlayCircleOutlined;
            "UpSquareOutlined", AntIcon.UpSquareOutlined;
            "DownSquareOutlined", AntIcon.DownSquareOutlined;
            "LeftSquareOutlined", AntIcon.LeftSquareOutlined;
            "RightSquareOutlined", AntIcon.RightSquareOutlined;
            "LoginOutlined", AntIcon.LoginOutlined;
            "LogoutOutlined", AntIcon.LogoutOutlined;
            "MenuFoldOutlined", AntIcon.MenuFoldOutlined;
            "MenuUnfoldOutlined", AntIcon.MenuUnfoldOutlined;
            "BorderBottomOutlined", AntIcon.BorderBottomOutlined;
            "BorderHorizontalOutlined", AntIcon.BorderHorizontalOutlined;
            "BorderInnerOutlined", AntIcon.BorderInnerOutlined;
            "BorderOuterOutlined", AntIcon.BorderOuterOutlined;
            "BorderLeftOutlined", AntIcon.BorderLeftOutlined;
            "BorderRightOutlined", AntIcon.BorderRightOutlined;
            "BorderTopOutlined", AntIcon.BorderTopOutlined;
            "BorderVerticleOutlined", AntIcon.BorderVerticleOutlined;
            "PicCenterOutlined", AntIcon.PicCenterOutlined;
            "PicLeftOutlined", AntIcon.PicLeftOutlined;
            "PicRightOutlined", AntIcon.PicRightOutlined;
            "RadiusBottomleftOutlined", AntIcon.RadiusBottomleftOutlined;
            "ArrowRightOutlined", AntIcon.ArrowRightOutlined;
            "RadiusBottomrightOutlined", AntIcon.RadiusBottomrightOutlined;
            "RadiusUpleftOutlined", AntIcon.RadiusUpleftOutlined;
            "RadiusUprightOutlined", AntIcon.RadiusUprightOutlined;
            "FullscreenOutlined", AntIcon.FullscreenOutlined;
            "FullscreenExitOutlined", AntIcon.FullscreenExitOutlined;
            "QuestionOutlined", AntIcon.QuestionOutlined;
            "QuestionCircleOutlined", AntIcon.QuestionCircleOutlined;
            "PlusOutlined", AntIcon.PlusOutlined;
            "PlusCircleOutlined", AntIcon.PlusCircleOutlined;
            "PauseOutlined", AntIcon.PauseOutlined;
            "PauseCircleOutlined", AntIcon.PauseCircleOutlined;
            "MinusOutlined", AntIcon.MinusOutlined;
            "MinusCircleOutlined", AntIcon.MinusCircleOutlined;
            "PlusSquareOutlined", AntIcon.PlusSquareOutlined;
            "MinusSquareOutlined", AntIcon.MinusSquareOutlined;
            "InfoOutlined", AntIcon.InfoOutlined;
            "InfoCircleOutlined", AntIcon.InfoCircleOutlined;
            "ExclamationOutlined", AntIcon.ExclamationOutlined;
            "ExclamationCircleOutlined", AntIcon.ExclamationCircleOutlined;
            "CloseOutlined", AntIcon.CloseOutlined;
            "CloseCircleOutlined", AntIcon.CloseCircleOutlined;
            "CloseSquareOutlined", AntIcon.CloseSquareOutlined;
            "CheckOutlined", AntIcon.CheckOutlined;
            "CheckCircleOutlined", AntIcon.CheckCircleOutlined;
            "CheckSquareOutlined", AntIcon.CheckSquareOutlined;
            "ClockCircleOutlined", AntIcon.ClockCircleOutlined;
            "WarningOutlined", AntIcon.WarningOutlined;
            "IssuesCloseOutlined", AntIcon.IssuesCloseOutlined;
            "StopOutlined", AntIcon.StopOutlined;
            "EditOutlined", AntIcon.EditOutlined;
            "FormOutlined", AntIcon.FormOutlined;
            "CopyOutlined", AntIcon.CopyOutlined;
            "ScissorOutlined", AntIcon.ScissorOutlined;
            "DeleteOutlined", AntIcon.DeleteOutlined;
            "SnippetsOutlined", AntIcon.SnippetsOutlined;
            "DiffOutlined", AntIcon.DiffOutlined;
            "HighlightOutlined", AntIcon.HighlightOutlined;
            "AlignCenterOutlined", AntIcon.AlignCenterOutlined;
            "AlignLeftOutlined", AntIcon.AlignLeftOutlined;
            "AlignRightOutlined", AntIcon.AlignRightOutlined;
            "BgColorsOutlined", AntIcon.BgColorsOutlined;
            "BoldOutlined", AntIcon.BoldOutlined;
            "ItalicOutlined", AntIcon.ItalicOutlined;
            "UnderlineOutlined", AntIcon.UnderlineOutlined;
            "StrikethroughOutlined", AntIcon.StrikethroughOutlined;
            "RedoOutlined", AntIcon.RedoOutlined;
            "UndoOutlined", AntIcon.UndoOutlined;
            "ZoomInOutlined", AntIcon.ZoomInOutlined;
            "ZoomOutOutlined", AntIcon.ZoomOutOutlined;
            "FontColorsOutlined", AntIcon.FontColorsOutlined;
            "FontSizeOutlined", AntIcon.FontSizeOutlined;
            "LineHeightOutlined", AntIcon.LineHeightOutlined;
            "DashOutlined", AntIcon.DashOutlined;
            "SmallDashOutlined", AntIcon.SmallDashOutlined;
            "SortAscendingOutlined", AntIcon.SortAscendingOutlined;
            "SortDescendingOutlined", AntIcon.SortDescendingOutlined;
            "DragOutlined", AntIcon.DragOutlined;
            "OrderedListOutlined", AntIcon.OrderedListOutlined;
            "UnorderedListOutlined", AntIcon.UnorderedListOutlined;
            "RadiusSettingOutlined", AntIcon.RadiusSettingOutlined;
            "ColumnWidthOutlined", AntIcon.ColumnWidthOutlined;
            "ColumnHeightOutlined", AntIcon.ColumnHeightOutlined;
            "AreaChartOutlined", AntIcon.AreaChartOutlined;
            "PieChartOutlined", AntIcon.PieChartOutlined;
            "BarChartOutlined", AntIcon.BarChartOutlined;
            "DotChartOutlined", AntIcon.DotChartOutlined;
            "LineChartOutlined", AntIcon.LineChartOutlined;
            "RadarChartOutlined", AntIcon.RadarChartOutlined;
            "HeatMapOutlined", AntIcon.HeatMapOutlined;
            "FallOutlined", AntIcon.FallOutlined;
            "RiseOutlined", AntIcon.RiseOutlined;
            "StockOutlined", AntIcon.StockOutlined;
            "BoxPlotOutlined", AntIcon.BoxPlotOutlined;
            "FundOutlined", AntIcon.FundOutlined;
            "SlidersOutlined", AntIcon.SlidersOutlined;
            "AndroidOutlined", AntIcon.AndroidOutlined;
            "AppleOutlined", AntIcon.AppleOutlined;
            "WindowsOutlined", AntIcon.WindowsOutlined;
            "IeOutlined", AntIcon.IeOutlined;
            "ChromeOutlined", AntIcon.ChromeOutlined;
            "GithubOutlined", AntIcon.GithubOutlined;
            "AliwangwangOutlined", AntIcon.AliwangwangOutlined;
            "DingdingOutlined", AntIcon.DingdingOutlined;
            "WeiboSquareOutlined", AntIcon.WeiboSquareOutlined;
            "WeiboCircleOutlined", AntIcon.WeiboCircleOutlined;
            "TaobaoCircleOutlined", AntIcon.TaobaoCircleOutlined;
            "Html5Outlined", AntIcon.Html5Outlined;
            "WeiboOutlined", AntIcon.WeiboOutlined;
            "TwitterOutlined", AntIcon.TwitterOutlined;
            "WechatOutlined", AntIcon.WechatOutlined;
            "YoutubeOutlined", AntIcon.YoutubeOutlined;
            "AlipayCircleOutlined", AntIcon.AlipayCircleOutlined;
            "TaobaoOutlined", AntIcon.TaobaoOutlined;
            "SkypeOutlined", AntIcon.SkypeOutlined;
            "QqOutlined", AntIcon.QqOutlined;
            "MediumWorkmarkOutlined", AntIcon.MediumWorkmarkOutlined;
            "GitlabOutlined", AntIcon.GitlabOutlined;
            "MediumOutlined", AntIcon.MediumOutlined;
            "LinkedinOutlined", AntIcon.LinkedinOutlined;
            "GooglePlusOutlined", AntIcon.GooglePlusOutlined;
            "DropboxOutlined", AntIcon.DropboxOutlined;
            "FacebookOutlined", AntIcon.FacebookOutlined;
            "CodepenOutlined", AntIcon.CodepenOutlined;
            "CodeSandboxOutlined", AntIcon.CodeSandboxOutlined;
            "AmazonOutlined", AntIcon.AmazonOutlined;
            "GoogleOutlined", AntIcon.GoogleOutlined;
            "CodepenCircleOutlined", AntIcon.CodepenCircleOutlined;
            "AlipayOutlined", AntIcon.AlipayOutlined;
            "AntDesignOutlined", AntIcon.AntDesignOutlined;
            "AntCloudOutlined", AntIcon.AntCloudOutlined;
            "AliyunOutlined", AntIcon.AliyunOutlined;
            "ZhihuOutlined", AntIcon.ZhihuOutlined;
            "SlackOutlined", AntIcon.SlackOutlined;
            "SlackSquareOutlined", AntIcon.SlackSquareOutlined;
            "BehanceOutlined", AntIcon.BehanceOutlined;
            "BehanceSquareOutlined", AntIcon.BehanceSquareOutlined;
            "DribbbleOutlined", AntIcon.DribbbleOutlined;
            "DribbbleSquareOutlined", AntIcon.DribbbleSquareOutlined;
            "InstagramOutlined", AntIcon.InstagramOutlined;
            "YuqueOutlined", AntIcon.YuqueOutlined;
            "AlibabaOutlined", AntIcon.AlibabaOutlined;
            "YahooOutlined", AntIcon.YahooOutlined;
            "RedditOutlined", AntIcon.RedditOutlined;
            "SketchOutlined", AntIcon.SketchOutlined;
            "AccountBookOutlined", AntIcon.AccountBookOutlined;
            "AimOutlined", AntIcon.AimOutlined;
            "AlertOutlined", AntIcon.AlertOutlined;
            "ApartmentOutlined", AntIcon.ApartmentOutlined;
            "ApiOutlined", AntIcon.ApiOutlined;
            "AppstoreAddOutlined", AntIcon.AppstoreAddOutlined;
            "AppstoreOutlined", AntIcon.AppstoreOutlined;
            "AudioOutlined", AntIcon.AudioOutlined;
            "AudioMutedOutlined", AntIcon.AudioMutedOutlined;
            "AuditOutlined", AntIcon.AuditOutlined;
            "BankOutlined", AntIcon.BankOutlined;
            "BarcodeOutlined", AntIcon.BarcodeOutlined;
            "BarsOutlined", AntIcon.BarsOutlined;
            "BellOutlined", AntIcon.BellOutlined;
            "BlockOutlined", AntIcon.BlockOutlined;
            "BookOutlined", AntIcon.BookOutlined;
            "BorderOutlined", AntIcon.BorderOutlined;
            "BorderlessTableOutlined", AntIcon.BorderlessTableOutlined;
            "BranchesOutlined", AntIcon.BranchesOutlined;
            "BugOutlined", AntIcon.BugOutlined;
            "BuildOutlined", AntIcon.BuildOutlined;
            "BulbOutlined", AntIcon.BulbOutlined;
            "CalculatorOutlined", AntIcon.CalculatorOutlined;
            "CalendarOutlined", AntIcon.CalendarOutlined;
            "CameraOutlined", AntIcon.CameraOutlined;
            "CarOutlined", AntIcon.CarOutlined;
            "CarryOutOutlined", AntIcon.CarryOutOutlined;
            "CiCircleOutlined", AntIcon.CiCircleOutlined;
            "CiOutlined", AntIcon.CiOutlined;
            "ClearOutlined", AntIcon.ClearOutlined;
            "CloudDownloadOutlined", AntIcon.CloudDownloadOutlined;
            "CloudOutlined", AntIcon.CloudOutlined;
            "CloudServerOutlined", AntIcon.CloudServerOutlined;
            "CloudSyncOutlined", AntIcon.CloudSyncOutlined;
            "CloudUploadOutlined", AntIcon.CloudUploadOutlined;
            "ClusterOutlined", AntIcon.ClusterOutlined;
            "CodeOutlined", AntIcon.CodeOutlined;
            "CoffeeOutlined", AntIcon.CoffeeOutlined;
            "CommentOutlined", AntIcon.CommentOutlined;
            "CompassOutlined", AntIcon.CompassOutlined;
            "CompressOutlined", AntIcon.CompressOutlined;
            "ConsoleSqlOutlined", AntIcon.ConsoleSqlOutlined;
            "ContactsOutlined", AntIcon.ContactsOutlined;
            "ContainerOutlined", AntIcon.ContainerOutlined;
            "ControlOutlined", AntIcon.ControlOutlined;
            "CopyrightCircleOutlined", AntIcon.CopyrightCircleOutlined;
            "CopyrightOutlined", AntIcon.CopyrightOutlined;
            "CreditCardOutlined", AntIcon.CreditCardOutlined;
            "CrownOutlined", AntIcon.CrownOutlined;
            "CustomerServiceOutlined", AntIcon.CustomerServiceOutlined;
            "DashboardOutlined", AntIcon.DashboardOutlined;
            "DatabaseOutlined", AntIcon.DatabaseOutlined;
            "DeleteColumnOutlined", AntIcon.DeleteColumnOutlined;
            "DeleteRowOutlined", AntIcon.DeleteRowOutlined;
            "DeliveredProcedureOutlined", AntIcon.DeliveredProcedureOutlined;
            "DeploymentUnitOutlined", AntIcon.DeploymentUnitOutlined;
            "DesktopOutlined", AntIcon.DesktopOutlined;
            "DingtalkOutlined", AntIcon.DingtalkOutlined;
            "DisconnectOutlined", AntIcon.DisconnectOutlined;
            "DislikeOutlined", AntIcon.DislikeOutlined;
            "DollarCircleOutlined", AntIcon.DollarCircleOutlined;
            "DollarOutlined", AntIcon.DollarOutlined;
            "DownloadOutlined", AntIcon.DownloadOutlined;
            "EllipsisOutlined", AntIcon.EllipsisOutlined;
            "EnvironmentOutlined", AntIcon.EnvironmentOutlined;
            "EuroCircleOutlined", AntIcon.EuroCircleOutlined;
            "EuroOutlined", AntIcon.EuroOutlined;
            "ExceptionOutlined", AntIcon.ExceptionOutlined;
            "ExpandAltOutlined", AntIcon.ExpandAltOutlined;
            "ExpandOutlined", AntIcon.ExpandOutlined;
            "ExperimentOutlined", AntIcon.ExperimentOutlined;
            "ExportOutlined", AntIcon.ExportOutlined;
            "EyeOutlined", AntIcon.EyeOutlined;
            "EyeInvisibleOutlined", AntIcon.EyeInvisibleOutlined;
            "FieldBinaryOutlined", AntIcon.FieldBinaryOutlined;
            "FieldNumberOutlined", AntIcon.FieldNumberOutlined;
            "FieldStringOutlined", AntIcon.FieldStringOutlined;
            "FieldTimeOutlined", AntIcon.FieldTimeOutlined;
            "FileAddOutlined", AntIcon.FileAddOutlined;
            "FileDoneOutlined", AntIcon.FileDoneOutlined;
            "FileExcelOutlined", AntIcon.FileExcelOutlined;
            "FileExclamationOutlined", AntIcon.FileExclamationOutlined;
            "FileOutlined", AntIcon.FileOutlined;
            "FileGifOutlined", AntIcon.FileGifOutlined;
            "FileImageOutlined", AntIcon.FileImageOutlined;
            "FileJpgOutlined", AntIcon.FileJpgOutlined;
            "FileMarkdownOutlined", AntIcon.FileMarkdownOutlined;
            "FilePdfOutlined", AntIcon.FilePdfOutlined;
            "FilePptOutlined", AntIcon.FilePptOutlined;
            "FileProtectOutlined", AntIcon.FileProtectOutlined;
            "FileSearchOutlined", AntIcon.FileSearchOutlined;
            "FileSyncOutlined", AntIcon.FileSyncOutlined;
            "FileTextOutlined", AntIcon.FileTextOutlined;
            "FileUnknownOutlined", AntIcon.FileUnknownOutlined;
            "FileWordOutlined", AntIcon.FileWordOutlined;
            "FileZipOutlined", AntIcon.FileZipOutlined;
            "FilterOutlined", AntIcon.FilterOutlined;
            "FireOutlined", AntIcon.FireOutlined;
            "FlagOutlined", AntIcon.FlagOutlined;
            "FolderAddOutlined", AntIcon.FolderAddOutlined;
            "FolderOutlined", AntIcon.FolderOutlined;
            "FolderOpenOutlined", AntIcon.FolderOpenOutlined;
            "FolderViewOutlined", AntIcon.FolderViewOutlined;
            "ForkOutlined", AntIcon.ForkOutlined;
            "FormatPainterOutlined", AntIcon.FormatPainterOutlined;
            "FrownOutlined", AntIcon.FrownOutlined;
            "FunctionOutlined", AntIcon.FunctionOutlined;
            "FundProjectionScreenOutlined", AntIcon.FundProjectionScreenOutlined;
            "FundViewOutlined", AntIcon.FundViewOutlined;
            "FunnelPlotOutlined", AntIcon.FunnelPlotOutlined;
            "GatewayOutlined", AntIcon.GatewayOutlined;
            "GifOutlined", AntIcon.GifOutlined;
            "GiftOutlined", AntIcon.GiftOutlined;
            "GlobalOutlined", AntIcon.GlobalOutlined;
            "GoldOutlined", AntIcon.GoldOutlined;
            "GroupOutlined", AntIcon.GroupOutlined;
            "HddOutlined", AntIcon.HddOutlined;
            "HeartOutlined", AntIcon.HeartOutlined;
            "HistoryOutlined", AntIcon.HistoryOutlined;
            "HomeOutlined", AntIcon.HomeOutlined;
            "HourglassOutlined", AntIcon.HourglassOutlined;
            "IdcardOutlined", AntIcon.IdcardOutlined;
            "ImportOutlined", AntIcon.ImportOutlined;
            "InboxOutlined", AntIcon.InboxOutlined;
            "InsertRowAboveOutlined", AntIcon.InsertRowAboveOutlined;
            "InsertRowBelowOutlined", AntIcon.InsertRowBelowOutlined;
            "InsertRowLeftOutlined", AntIcon.InsertRowLeftOutlined;
            "InsertRowRightOutlined", AntIcon.InsertRowRightOutlined;
            "InsuranceOutlined", AntIcon.InsuranceOutlined;
            "InteractionOutlined", AntIcon.InteractionOutlined;
            "KeyOutlined", AntIcon.KeyOutlined;
            "LaptopOutlined", AntIcon.LaptopOutlined;
            "LayoutOutlined", AntIcon.LayoutOutlined;
            "LikeOutlined", AntIcon.LikeOutlined;
            "LineOutlined", AntIcon.LineOutlined;
            "LinkOutlined", AntIcon.LinkOutlined;
            "Loading3QuartersOutlined", AntIcon.Loading3QuartersOutlined;
            "LoadingOutlined", AntIcon.LoadingOutlined;
            "LockOutlined", AntIcon.LockOutlined;
            "MacCommandOutlined", AntIcon.MacCommandOutlined;
            "MailOutlined", AntIcon.MailOutlined;
            "ManOutlined", AntIcon.ManOutlined;
            "MedicineBoxOutlined", AntIcon.MedicineBoxOutlined;
            "MehOutlined", AntIcon.MehOutlined;
            "MenuOutlined", AntIcon.MenuOutlined;
            "MergeCellsOutlined", AntIcon.MergeCellsOutlined;
            "MessageOutlined", AntIcon.MessageOutlined;
            "MobileOutlined", AntIcon.MobileOutlined;
            "MoneyCollectOutlined", AntIcon.MoneyCollectOutlined;
            "MonitorOutlined", AntIcon.MonitorOutlined;
            "MoreOutlined", AntIcon.MoreOutlined;
            "NodeCollapseOutlined", AntIcon.NodeCollapseOutlined;
            "NodeExpandOutlined", AntIcon.NodeExpandOutlined;
            "NodeIndexOutlined", AntIcon.NodeIndexOutlined;
            "NotificationOutlined", AntIcon.NotificationOutlined;
            "NumberOutlined", AntIcon.NumberOutlined;
            "OneToOneOutlined", AntIcon.OneToOneOutlined;
            "PaperClipOutlined", AntIcon.PaperClipOutlined;
            "PartitionOutlined", AntIcon.PartitionOutlined;
            "PayCircleOutlined", AntIcon.PayCircleOutlined;
            "PercentageOutlined", AntIcon.PercentageOutlined;
            "PhoneOutlined", AntIcon.PhoneOutlined;
            "PictureOutlined", AntIcon.PictureOutlined;
            "PlaySquareOutlined", AntIcon.PlaySquareOutlined;
            "PoundCircleOutlined", AntIcon.PoundCircleOutlined;
            "PoundOutlined", AntIcon.PoundOutlined;
            "PoweroffOutlined", AntIcon.PoweroffOutlined;
            "PrinterOutlined", AntIcon.PrinterOutlined;
            "ProfileOutlined", AntIcon.ProfileOutlined;
            "ProjectOutlined", AntIcon.ProjectOutlined;
            "PropertySafetyOutlined", AntIcon.PropertySafetyOutlined;
            "PullRequestOutlined", AntIcon.PullRequestOutlined;
            "PushpinOutlined", AntIcon.PushpinOutlined;
            "QrcodeOutlined", AntIcon.QrcodeOutlined;
            "ReadOutlined", AntIcon.ReadOutlined;
            "ReconciliationOutlined", AntIcon.ReconciliationOutlined;
            "RedEnvelopeOutlined", AntIcon.RedEnvelopeOutlined;
            "ReloadOutlined", AntIcon.ReloadOutlined;
            "RestOutlined", AntIcon.RestOutlined;
            "RobotOutlined", AntIcon.RobotOutlined;
            "RocketOutlined", AntIcon.RocketOutlined;
            "RotateLeftOutlined", AntIcon.RotateLeftOutlined;
            "RotateRightOutlined", AntIcon.RotateRightOutlined;
            "SafetyCertificateOutlined", AntIcon.SafetyCertificateOutlined;
            "SafetyOutlined", AntIcon.SafetyOutlined;
            "SaveOutlined", AntIcon.SaveOutlined;
            "ScanOutlined", AntIcon.ScanOutlined;
            "ScheduleOutlined", AntIcon.ScheduleOutlined;
            "SearchOutlined", AntIcon.SearchOutlined;
            "SecurityScanOutlined", AntIcon.SecurityScanOutlined;
            "SelectOutlined", AntIcon.SelectOutlined;
            "SendOutlined", AntIcon.SendOutlined;
            "SettingOutlined", AntIcon.SettingOutlined;
            "ShakeOutlined", AntIcon.ShakeOutlined;
            "ShareAltOutlined", AntIcon.ShareAltOutlined;
            "ShopOutlined", AntIcon.ShopOutlined;
            "ShoppingCartOutlined", AntIcon.ShoppingCartOutlined;
            "ShoppingOutlined", AntIcon.ShoppingOutlined;
            "SisternodeOutlined", AntIcon.SisternodeOutlined;
            "SkinOutlined", AntIcon.SkinOutlined;
            "SmileOutlined", AntIcon.SmileOutlined;
            "SolutionOutlined", AntIcon.SolutionOutlined;
            "SoundOutlined", AntIcon.SoundOutlined;
            "SplitCellsOutlined", AntIcon.SplitCellsOutlined;
            "StarOutlined", AntIcon.StarOutlined;
            "SubnodeOutlined", AntIcon.SubnodeOutlined;
            "SwitcherOutlined", AntIcon.SwitcherOutlined;
            "SyncOutlined", AntIcon.SyncOutlined;
            "TableOutlined", AntIcon.TableOutlined;
            "TabletOutlined", AntIcon.TabletOutlined;
            "TagOutlined", AntIcon.TagOutlined;
            "TagsOutlined", AntIcon.TagsOutlined;
            "TeamOutlined", AntIcon.TeamOutlined;
            "ThunderboltOutlined", AntIcon.ThunderboltOutlined;
            "ToTopOutlined", AntIcon.ToTopOutlined;
            "ToolOutlined", AntIcon.ToolOutlined;
            "TrademarkCircleOutlined", AntIcon.TrademarkCircleOutlined;
            "TrademarkOutlined", AntIcon.TrademarkOutlined;
            "TransactionOutlined", AntIcon.TransactionOutlined;
            "TranslationOutlined", AntIcon.TranslationOutlined;
            "TrophyOutlined", AntIcon.TrophyOutlined;
            "UngroupOutlined", AntIcon.UngroupOutlined;
            "UnlockOutlined", AntIcon.UnlockOutlined;
            "UploadOutlined", AntIcon.UploadOutlined;
            "UsbOutlined", AntIcon.UsbOutlined;
            "UserAddOutlined", AntIcon.UserAddOutlined;
            "UserDeleteOutlined", AntIcon.UserDeleteOutlined;
            "UserOutlined", AntIcon.UserOutlined;
            "UserSwitchOutlined", AntIcon.UserSwitchOutlined;
            "UsergroupAddOutlined", AntIcon.UsergroupAddOutlined;
            "UsergroupDeleteOutlined", AntIcon.UsergroupDeleteOutlined;
            "VerifiedOutlined", AntIcon.VerifiedOutlined;
            "VideoCameraAddOutlined", AntIcon.VideoCameraAddOutlined;
            "VideoCameraOutlined", AntIcon.VideoCameraOutlined;
            "WalletOutlined", AntIcon.WalletOutlined;
            "WhatsAppOutlined", AntIcon.WhatsAppOutlined;
            "WifiOutlined", AntIcon.WifiOutlined;
            "WomanOutlined", AntIcon.WomanOutlined;
            "StepBackwardFilled", AntIcon.StepBackwardFilled;
            "StepForwardFilled", AntIcon.StepForwardFilled;
            "FastBackwardFilled", AntIcon.FastBackwardFilled;
            "FastForwardFilled", AntIcon.FastForwardFilled;
            "CaretUpFilled", AntIcon.CaretUpFilled;
            "CaretDownFilled", AntIcon.CaretDownFilled;
            "CaretLeftFilled", AntIcon.CaretLeftFilled;
            "CaretRightFilled", AntIcon.CaretRightFilled;
            "UpCircleFilled", AntIcon.UpCircleFilled;
            "DownCircleFilled", AntIcon.DownCircleFilled;
            "LeftCircleFilled", AntIcon.LeftCircleFilled;
            "RightCircleFilled", AntIcon.RightCircleFilled;
            "ForwardFilled", AntIcon.ForwardFilled;
            "BackwardFilled", AntIcon.BackwardFilled;
            "PlayCircleFilled", AntIcon.PlayCircleFilled;
            "UpSquareFilled", AntIcon.UpSquareFilled;
            "DownSquareFilled", AntIcon.DownSquareFilled;
            "LeftSquareFilled", AntIcon.LeftSquareFilled;
            "RightSquareFilled", AntIcon.RightSquareFilled;
            "QuestionCircleFilled", AntIcon.QuestionCircleFilled;
            "PlusCircleFilled", AntIcon.PlusCircleFilled;
            "PauseCircleFilled", AntIcon.PauseCircleFilled;
            "MinusCircleFilled", AntIcon.MinusCircleFilled;
            "PlusSquareFilled", AntIcon.PlusSquareFilled;
            "MinusSquareFilled", AntIcon.MinusSquareFilled;
            "InfoCircleFilled", AntIcon.InfoCircleFilled;
            "ExclamationCircleFilled", AntIcon.ExclamationCircleFilled;
            "CloseCircleFilled", AntIcon.CloseCircleFilled;
            "CloseSquareFilled", AntIcon.CloseSquareFilled;
            "CheckCircleFilled", AntIcon.CheckCircleFilled;
            "CheckSquareFilled", AntIcon.CheckSquareFilled;
            "ClockCircleFilled", AntIcon.ClockCircleFilled;
            "WarningFilled", AntIcon.WarningFilled;
            "StopFilled", AntIcon.StopFilled;
            "EditFilled", AntIcon.EditFilled;
            "CopyFilled", AntIcon.CopyFilled;
            "DeleteFilled", AntIcon.DeleteFilled;
            "SnippetsFilled", AntIcon.SnippetsFilled;
            "DiffFilled", AntIcon.DiffFilled;
            "HighlightFilled", AntIcon.HighlightFilled;
            "PieChartFilled", AntIcon.PieChartFilled;
            "BoxPlotFilled", AntIcon.BoxPlotFilled;
            "FundFilled", AntIcon.FundFilled;
            "SlidersFilled", AntIcon.SlidersFilled;
            "AndroidFilled", AntIcon.AndroidFilled;
            "AppleFilled", AntIcon.AppleFilled;
            "WindowsFilled", AntIcon.WindowsFilled;
            "ChromeFilled", AntIcon.ChromeFilled;
            "GithubFilled", AntIcon.GithubFilled;
            "AliwangwangFilled", AntIcon.AliwangwangFilled;
            "WeiboSquareFilled", AntIcon.WeiboSquareFilled;
            "WeiboCircleFilled", AntIcon.WeiboCircleFilled;
            "TaobaoCircleFilled", AntIcon.TaobaoCircleFilled;
            "Html5Filled", AntIcon.Html5Filled;
            "WechatFilled", AntIcon.WechatFilled;
            "YoutubeFilled", AntIcon.YoutubeFilled;
            "AlipayCircleFilled", AntIcon.AlipayCircleFilled;
            "SkypeFilled", AntIcon.SkypeFilled;
            "GitlabFilled", AntIcon.GitlabFilled;
            "LinkedinFilled", AntIcon.LinkedinFilled;
            "FacebookFilled", AntIcon.FacebookFilled;
            "CodeSandboxCircleFilled", AntIcon.CodeSandboxCircleFilled;
            "CodepenCircleFilled", AntIcon.CodepenCircleFilled;
            "SlackSquareFilled", AntIcon.SlackSquareFilled;
            "BehanceSquareFilled", AntIcon.BehanceSquareFilled;
            "DribbbleSquareFilled", AntIcon.DribbbleSquareFilled;
            "InstagramFilled", AntIcon.InstagramFilled;
            "YuqueFilled", AntIcon.YuqueFilled;
            "YahooFilled", AntIcon.YahooFilled;
            "AccountBookFilled", AntIcon.AccountBookFilled;
            "AlertFilled", AntIcon.AlertFilled;
            "AlipaySquareFilled", AntIcon.AlipaySquareFilled;
            "AmazonCircleFilled", AntIcon.AmazonCircleFilled;
            "AmazonSquareFilled", AntIcon.AmazonSquareFilled;
            "ApiFilled", AntIcon.ApiFilled;
            "AppstoreFilled", AntIcon.AppstoreFilled;
            "AudioFilled", AntIcon.AudioFilled;
            "BankFilled", AntIcon.BankFilled;
            "BehanceCircleFilled", AntIcon.BehanceCircleFilled;
            "BellFilled", AntIcon.BellFilled;
            "BookFilled", AntIcon.BookFilled;
            "BugFilled", AntIcon.BugFilled;
            "BuildFilled", AntIcon.BuildFilled;
            "BulbFilled", AntIcon.BulbFilled;
            "CalculatorFilled", AntIcon.CalculatorFilled;
            "CalendarFilled", AntIcon.CalendarFilled;
            "CameraFilled", AntIcon.CameraFilled;
            "CarFilled", AntIcon.CarFilled;
            "CarryOutFilled", AntIcon.CarryOutFilled;
            "CiCircleFilled", AntIcon.CiCircleFilled;
            "CloudFilled", AntIcon.CloudFilled;
            "CodeFilled", AntIcon.CodeFilled;
            "CodeSandboxSquareFilled", AntIcon.CodeSandboxSquareFilled;
            "CodepenSquareFilled", AntIcon.CodepenSquareFilled;
            "CompassFilled", AntIcon.CompassFilled;
            "ContactsFilled", AntIcon.ContactsFilled;
            "ContainerFilled", AntIcon.ContainerFilled;
            "ControlFilled", AntIcon.ControlFilled;
            "CopyrightCircleFilled", AntIcon.CopyrightCircleFilled;
            "CreditCardFilled", AntIcon.CreditCardFilled;
            "CrownFilled", AntIcon.CrownFilled;
            "CustomerServiceFilled", AntIcon.CustomerServiceFilled;
            "DashboardFilled", AntIcon.DashboardFilled;
            "DatabaseFilled", AntIcon.DatabaseFilled;
            "DingtalkCircleFilled", AntIcon.DingtalkCircleFilled;
            "DingtalkSquareFilled", AntIcon.DingtalkSquareFilled;
            "DislikeFilled", AntIcon.DislikeFilled;
            "DollarCircleFilled", AntIcon.DollarCircleFilled;
            "DribbbleCircleFilled", AntIcon.DribbbleCircleFilled;
            "DropboxCircleFilled", AntIcon.DropboxCircleFilled;
            "DropboxSquareFilled", AntIcon.DropboxSquareFilled;
            "EnvironmentFilled", AntIcon.EnvironmentFilled;
            "EuroCircleFilled", AntIcon.EuroCircleFilled;
            "ExperimentFilled", AntIcon.ExperimentFilled;
            "EyeFilled", AntIcon.EyeFilled;
            "EyeInvisibleFilled", AntIcon.EyeInvisibleFilled;
            "FileAddFilled", AntIcon.FileAddFilled;
            "FileExcelFilled", AntIcon.FileExcelFilled;
            "FileExclamationFilled", AntIcon.FileExclamationFilled;
            "FileFilled", AntIcon.FileFilled;
            "FileImageFilled", AntIcon.FileImageFilled;
            "FileMarkdownFilled", AntIcon.FileMarkdownFilled;
            "FilePdfFilled", AntIcon.FilePdfFilled;
            "FilePptFilled", AntIcon.FilePptFilled;
            "FileTextFilled", AntIcon.FileTextFilled;
            "FileUnknownFilled", AntIcon.FileUnknownFilled;
            "FileWordFilled", AntIcon.FileWordFilled;
            "FileZipFilled", AntIcon.FileZipFilled;
            "FilterFilled", AntIcon.FilterFilled;
            "FireFilled", AntIcon.FireFilled;
            "FlagFilled", AntIcon.FlagFilled;
            "FolderAddFilled", AntIcon.FolderAddFilled;
            "FolderFilled", AntIcon.FolderFilled;
            "FolderOpenFilled", AntIcon.FolderOpenFilled;
            "FormatPainterFilled", AntIcon.FormatPainterFilled;
            "FrownFilled", AntIcon.FrownFilled;
            "FunnelPlotFilled", AntIcon.FunnelPlotFilled;
            "GiftFilled", AntIcon.GiftFilled;
            "GoldFilled", AntIcon.GoldFilled;
            "GoldenFilled", AntIcon.GoldenFilled;
            "GoogleCircleFilled", AntIcon.GoogleCircleFilled;
            "GooglePlusCircleFilled", AntIcon.GooglePlusCircleFilled;
            "GooglePlusSquareFilled", AntIcon.GooglePlusSquareFilled;
            "GoogleSquareFilled", AntIcon.GoogleSquareFilled;
            "HddFilled", AntIcon.HddFilled;
            "HeartFilled", AntIcon.HeartFilled;
            "HomeFilled", AntIcon.HomeFilled;
            "HourglassFilled", AntIcon.HourglassFilled;
            "IdcardFilled", AntIcon.IdcardFilled;
            "IeCircleFilled", AntIcon.IeCircleFilled;
            "IeSquareFilled", AntIcon.IeSquareFilled;
            "InsuranceFilled", AntIcon.InsuranceFilled;
            "InteractionFilled", AntIcon.InteractionFilled;
            "LayoutFilled", AntIcon.LayoutFilled;
            "LikeFilled", AntIcon.LikeFilled;
            "LockFilled", AntIcon.LockFilled;
            "MacCommandFilled", AntIcon.MacCommandFilled;
            "MailFilled", AntIcon.MailFilled;
            "MedicineBoxFilled", AntIcon.MedicineBoxFilled;
            "MediumCircleFilled", AntIcon.MediumCircleFilled;
            "MediumSquareFilled", AntIcon.MediumSquareFilled;
            "MehFilled", AntIcon.MehFilled;
            "MessageFilled", AntIcon.MessageFilled;
            "MobileFilled", AntIcon.MobileFilled;
            "MoneyCollectFilled", AntIcon.MoneyCollectFilled;
            "NotificationFilled", AntIcon.NotificationFilled;
            "PayCircleFilled", AntIcon.PayCircleFilled;
            "PhoneFilled", AntIcon.PhoneFilled;
            "PictureFilled", AntIcon.PictureFilled;
            "PlaySquareFilled", AntIcon.PlaySquareFilled;
            "PoundCircleFilled", AntIcon.PoundCircleFilled;
            "PrinterFilled", AntIcon.PrinterFilled;
            "ProfileFilled", AntIcon.ProfileFilled;
            "ProjectFilled", AntIcon.ProjectFilled;
            "PropertySafetyFilled", AntIcon.PropertySafetyFilled;
            "PushpinFilled", AntIcon.PushpinFilled;
            "QqCircleFilled", AntIcon.QqCircleFilled;
            "QqSquareFilled", AntIcon.QqSquareFilled;
            "ReadFilled", AntIcon.ReadFilled;
            "ReconciliationFilled", AntIcon.ReconciliationFilled;
            "RedEnvelopeFilled", AntIcon.RedEnvelopeFilled;
            "RedditCircleFilled", AntIcon.RedditCircleFilled;
            "RedditSquareFilled", AntIcon.RedditSquareFilled;
            "RestFilled", AntIcon.RestFilled;
            "RobotFilled", AntIcon.RobotFilled;
            "RocketFilled", AntIcon.RocketFilled;
            "SafetyCertificateFilled", AntIcon.SafetyCertificateFilled;
            "SaveFilled", AntIcon.SaveFilled;
            "ScheduleFilled", AntIcon.ScheduleFilled;
            "SecurityScanFilled", AntIcon.SecurityScanFilled;
            "SettingFilled", AntIcon.SettingFilled;
            "ShopFilled", AntIcon.ShopFilled;
            "ShoppingFilled", AntIcon.ShoppingFilled;
            "SignalFilled", AntIcon.SignalFilled;
            "SketchCircleFilled", AntIcon.SketchCircleFilled;
            "SketchSquareFilled", AntIcon.SketchSquareFilled;
            "SkinFilled", AntIcon.SkinFilled;
            "SlackCircleFilled", AntIcon.SlackCircleFilled;
            "SmileFilled", AntIcon.SmileFilled;
            "SoundFilled", AntIcon.SoundFilled;
            "StarFilled", AntIcon.StarFilled;
            "SwitcherFilled", AntIcon.SwitcherFilled;
            "TabletFilled", AntIcon.TabletFilled;
            "TagFilled", AntIcon.TagFilled;
            "TagsFilled", AntIcon.TagsFilled;
            "TaobaoSquareFilled", AntIcon.TaobaoSquareFilled;
            "ThunderboltFilled", AntIcon.ThunderboltFilled;
            "ToolFilled", AntIcon.ToolFilled;
            "TrademarkCircleFilled", AntIcon.TrademarkCircleFilled;
            "TrophyFilled", AntIcon.TrophyFilled;
            "TwitterCircleFilled", AntIcon.TwitterCircleFilled;
            "TwitterSquareFilled", AntIcon.TwitterSquareFilled;
            "UnlockFilled", AntIcon.UnlockFilled;
            "UsbFilled", AntIcon.UsbFilled;
            "VideoCameraFilled", AntIcon.VideoCameraFilled;
            "WalletFilled", AntIcon.WalletFilled;
            "ZhihuCircleFilled", AntIcon.ZhihuCircleFilled;
            "ZhihuSquareFilled", AntIcon.ZhihuSquareFilled;
            "UpCircleTwoTone", AntIcon.UpCircleTwoTone;
            "DownCircleTwoTone", AntIcon.DownCircleTwoTone;
            "LeftCircleTwoTone", AntIcon.LeftCircleTwoTone;
            "RightCircleTwoTone", AntIcon.RightCircleTwoTone;
            "PlayCircleTwoTone", AntIcon.PlayCircleTwoTone;
            "UpSquareTwoTone", AntIcon.UpSquareTwoTone;
            "DownSquareTwoTone", AntIcon.DownSquareTwoTone;
            "LeftSquareTwoTone", AntIcon.LeftSquareTwoTone;
            "RightSquareTwoTone", AntIcon.RightSquareTwoTone;
            "QuestionCircleTwoTone", AntIcon.QuestionCircleTwoTone;
            "PlusCircleTwoTone", AntIcon.PlusCircleTwoTone;
            "PauseCircleTwoTone", AntIcon.PauseCircleTwoTone;
            "MinusCircleTwoTone", AntIcon.MinusCircleTwoTone;
            "PlusSquareTwoTone", AntIcon.PlusSquareTwoTone;
            "MinusSquareTwoTone", AntIcon.MinusSquareTwoTone;
            "InfoCircleTwoTone", AntIcon.InfoCircleTwoTone;
            "ExclamationCircleTwoTone", AntIcon.ExclamationCircleTwoTone;
            "CloseCircleTwoTone", AntIcon.CloseCircleTwoTone;
            "CloseSquareTwoTone", AntIcon.CloseSquareTwoTone;
            "CheckCircleTwoTone", AntIcon.CheckCircleTwoTone;
            "CheckSquareTwoTone", AntIcon.CheckSquareTwoTone;
            "ClockCircleTwoTone", AntIcon.ClockCircleTwoTone;
            "WarningTwoTone", AntIcon.WarningTwoTone;
            "StopTwoTone", AntIcon.StopTwoTone;
            "EditTwoTone", AntIcon.EditTwoTone;
            "CopyTwoTone", AntIcon.CopyTwoTone;
            "DeleteTwoTone", AntIcon.DeleteTwoTone;
            "SnippetsTwoTone", AntIcon.SnippetsTwoTone;
            "DiffTwoTone", AntIcon.DiffTwoTone;
            "HighlightTwoTone", AntIcon.HighlightTwoTone;
            "PieChartTwoTone", AntIcon.PieChartTwoTone;
            "BoxPlotTwoTone", AntIcon.BoxPlotTwoTone;
            "FundTwoTone", AntIcon.FundTwoTone;
            "SlidersTwoTone", AntIcon.SlidersTwoTone;
            "Html5TwoTone", AntIcon.Html5TwoTone;
            "AccountBookTwoTone", AntIcon.AccountBookTwoTone;
            "AlertTwoTone", AntIcon.AlertTwoTone;
            "ApiTwoTone", AntIcon.ApiTwoTone;
            "AppstoreTwoTone", AntIcon.AppstoreTwoTone;
            "AudioTwoTone", AntIcon.AudioTwoTone;
            "BankTwoTone", AntIcon.BankTwoTone;
            "BellTwoTone", AntIcon.BellTwoTone;
            "BookTwoTone", AntIcon.BookTwoTone;
            "BugTwoTone", AntIcon.BugTwoTone;
            "BuildTwoTone", AntIcon.BuildTwoTone;
            "BulbTwoTone", AntIcon.BulbTwoTone;
            "CalculatorTwoTone", AntIcon.CalculatorTwoTone;
            "CalendarTwoTone", AntIcon.CalendarTwoTone;
            "CameraTwoTone", AntIcon.CameraTwoTone;
            "CarTwoTone", AntIcon.CarTwoTone;
            "CarryOutTwoTone", AntIcon.CarryOutTwoTone;
            "CiCircleTwoTone", AntIcon.CiCircleTwoTone;
            "CiTwoTone", AntIcon.CiTwoTone;
            "CloudTwoTone", AntIcon.CloudTwoTone;
            "CodeTwoTone", AntIcon.CodeTwoTone;
            "CompassTwoTone", AntIcon.CompassTwoTone;
            "ContactsTwoTone", AntIcon.ContactsTwoTone;
            "ContainerTwoTone", AntIcon.ContainerTwoTone;
            "ControlTwoTone", AntIcon.ControlTwoTone;
            "CopyrightCircleTwoTone", AntIcon.CopyrightCircleTwoTone;
            "CopyrightTwoTone", AntIcon.CopyrightTwoTone;
            "CreditCardTwoTone", AntIcon.CreditCardTwoTone;
            "CrownTwoTone", AntIcon.CrownTwoTone;
            "CustomerServiceTwoTone", AntIcon.CustomerServiceTwoTone;
            "DashboardTwoTone", AntIcon.DashboardTwoTone;
            "DatabaseTwoTone", AntIcon.DatabaseTwoTone;
            "DislikeTwoTone", AntIcon.DislikeTwoTone;
            "DollarCircleTwoTone", AntIcon.DollarCircleTwoTone;
            "DollarTwoTone", AntIcon.DollarTwoTone;
            "EnvironmentTwoTone", AntIcon.EnvironmentTwoTone;
            "EuroCircleTwoTone", AntIcon.EuroCircleTwoTone;
            "EuroTwoTone", AntIcon.EuroTwoTone;
            "ExperimentTwoTone", AntIcon.ExperimentTwoTone;
            "EyeTwoTone", AntIcon.EyeTwoTone;
            "EyeInvisibleTwoTone", AntIcon.EyeInvisibleTwoTone;
            "FileAddTwoTone", AntIcon.FileAddTwoTone;
            "FileExcelTwoTone", AntIcon.FileExcelTwoTone;
            "FileExclamationTwoTone", AntIcon.FileExclamationTwoTone;
            "FileTwoTone", AntIcon.FileTwoTone;
            "FileImageTwoTone", AntIcon.FileImageTwoTone;
            "FileMarkdownTwoTone", AntIcon.FileMarkdownTwoTone;
            "FilePdfTwoTone", AntIcon.FilePdfTwoTone;
            "FilePptTwoTone", AntIcon.FilePptTwoTone;
            "FileTextTwoTone", AntIcon.FileTextTwoTone;
            "FileUnknownTwoTone", AntIcon.FileUnknownTwoTone;
            "FileWordTwoTone", AntIcon.FileWordTwoTone;
            "FileZipTwoTone", AntIcon.FileZipTwoTone;
            "FilterTwoTone", AntIcon.FilterTwoTone;
            "FireTwoTone", AntIcon.FireTwoTone;
            "FlagTwoTone", AntIcon.FlagTwoTone;
            "FolderAddTwoTone", AntIcon.FolderAddTwoTone;
            "FolderTwoTone", AntIcon.FolderTwoTone;
            "FolderOpenTwoTone", AntIcon.FolderOpenTwoTone;
            "FrownTwoTone", AntIcon.FrownTwoTone;
            "FunnelPlotTwoTone", AntIcon.FunnelPlotTwoTone;
            "GiftTwoTone", AntIcon.GiftTwoTone;
            "GoldTwoTone", AntIcon.GoldTwoTone;
            "HddTwoTone", AntIcon.HddTwoTone;
            "HeartTwoTone", AntIcon.HeartTwoTone;
            "HomeTwoTone", AntIcon.HomeTwoTone;
            "HourglassTwoTone", AntIcon.HourglassTwoTone;
            "IdcardTwoTone", AntIcon.IdcardTwoTone;
            "InsuranceTwoTone", AntIcon.InsuranceTwoTone;
            "InteractionTwoTone", AntIcon.InteractionTwoTone;
            "LayoutTwoTone", AntIcon.LayoutTwoTone;
            "LikeTwoTone", AntIcon.LikeTwoTone;
            "LockTwoTone", AntIcon.LockTwoTone;
            "MailTwoTone", AntIcon.MailTwoTone;
            "MedicineBoxTwoTone", AntIcon.MedicineBoxTwoTone;
            "MehTwoTone", AntIcon.MehTwoTone;
            "MessageTwoTone", AntIcon.MessageTwoTone;
            "MobileTwoTone", AntIcon.MobileTwoTone;
            "MoneyCollectTwoTone", AntIcon.MoneyCollectTwoTone;
            "NotificationTwoTone", AntIcon.NotificationTwoTone;
            "PhoneTwoTone", AntIcon.PhoneTwoTone;
            "PictureTwoTone", AntIcon.PictureTwoTone;
            "PlaySquareTwoTone", AntIcon.PlaySquareTwoTone;
            "PoundCircleTwoTone", AntIcon.PoundCircleTwoTone;
            "PrinterTwoTone", AntIcon.PrinterTwoTone;
            "ProfileTwoTone", AntIcon.ProfileTwoTone;
            "ProjectTwoTone", AntIcon.ProjectTwoTone;
            "PropertySafetyTwoTone", AntIcon.PropertySafetyTwoTone;
            "PushpinTwoTone", AntIcon.PushpinTwoTone;
            "ReconciliationTwoTone", AntIcon.ReconciliationTwoTone;
            "RedEnvelopeTwoTone", AntIcon.RedEnvelopeTwoTone;
            "RestTwoTone", AntIcon.RestTwoTone;
            "RocketTwoTone", AntIcon.RocketTwoTone;
            "SafetyCertificateTwoTone", AntIcon.SafetyCertificateTwoTone;
            "SaveTwoTone", AntIcon.SaveTwoTone;
            "ScheduleTwoTone", AntIcon.ScheduleTwoTone;
            "SecurityScanTwoTone", AntIcon.SecurityScanTwoTone;
            "SettingTwoTone", AntIcon.SettingTwoTone;
            "ShopTwoTone", AntIcon.ShopTwoTone;
            "ShoppingTwoTone", AntIcon.ShoppingTwoTone;
            "SkinTwoTone", AntIcon.SkinTwoTone;
            "SmileTwoTone", AntIcon.SmileTwoTone;
            "SoundTwoTone", AntIcon.SoundTwoTone;
            "StarTwoTone", AntIcon.StarTwoTone;
            "SwitcherTwoTone", AntIcon.SwitcherTwoTone;
            "TabletTwoTone", AntIcon.TabletTwoTone;
            "TagTwoTone", AntIcon.TagTwoTone;
            "TagsTwoTone", AntIcon.TagsTwoTone;
            "ThunderboltTwoTone", AntIcon.ThunderboltTwoTone;
            "ToolTwoTone", AntIcon.ToolTwoTone;
            "TrademarkCircleTwoTone", AntIcon.TrademarkCircleTwoTone;
            "TrophyTwoTone", AntIcon.TrophyTwoTone;
            "UnlockTwoTone", AntIcon.UnlockTwoTone;
            "UsbTwoTone", AntIcon.UsbTwoTone;
            "VideoCameraTwoTone", AntIcon.VideoCameraTwoTone;
            "WalletTwoTone", AntIcon.WalletTwoTone;
        |] |> Map.ofArray