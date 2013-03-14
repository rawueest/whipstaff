﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MS.WindowsAPICodePack.Internal
{
    internal enum WindowMessage
    {
        Null = 0x00,
        Create = 0x01,
        Destroy = 0x02,
        Move = 0x03,
        Size = 0x05,
        Activate = 0x06,
        SetFocus = 0x07,
        KillFocus = 0x08,
        Enable = 0x0A,
        SetRedraw = 0x0B,
        SetText = 0x0C,
        GetText = 0x0D,
        GetTextLength = 0x0E,
        Paint = 0x0F,
        Close = 0x10,
        QueryEndSession = 0x11,
        Quit = 0x12,
        QueryOpen = 0x13,
        EraseBackground = 0x14,
        SystemColorChange = 0x15,
        EndSession = 0x16,
        SystemError = 0x17,
        ShowWindow = 0x18,
        ControlColor = 0x19,
        WinIniChange = 0x1A,
        SettingChange = 0x1A,
        DevModeChange = 0x1B,
        ActivateApplication = 0x1C,
        FontChange = 0x1D,
        TimeChange = 0x1E,
        CancelMode = 0x1F,
        SetCursor = 0x20,
        MouseActivate = 0x21,
        ChildActivate = 0x22,
        QueueSync = 0x23,
        GetMinMaxInfo = 0x24,
        PaintIcon = 0x26,
        IconEraseBackground = 0x27,
        NextDialogControl = 0x28,
        SpoolerStatus = 0x2A,
        DrawItem = 0x2B,
        MeasureItem = 0x2C,
        DeleteItem = 0x2D,
        VKeyToItem = 0x2E,
        CharToItem = 0x2F,

        SetFont = 0x30,
        GetFont = 0x31,
        SetHotkey = 0x32,
        GetHotkey = 0x33,
        QueryDragIcon = 0x37,
        CompareItem = 0x39,
        Compacting = 0x41,
        WindowPositionChanging = 0x46,
        WindowPositionChanged = 0x47,
        Power = 0x48,
        CopyData = 0x4A,
        CancelJournal = 0x4B,
        Notify = 0x4E,
        InputLanguageChangeRequest = 0x50,
        InputLanguageChange = 0x51,
        TCard = 0x52,
        Help = 0x53,
        UserChanged = 0x54,
        NotifyFormat = 0x55,
        ContextMenu = 0x7B,
        StyleChanging = 0x7C,
        StyleChanged = 0x7D,
        DisplayChange = 0x7E,
        GetIcon = 0x7F,
        SetIcon = 0x80,

        NCCreate = 0x81,
        NCDestroy = 0x82,
        NCCalculateSize = 0x83,
        NCHitTest = 0x84,
        NCPaint = 0x85,
        NCActivate = 0x86,
        GetDialogCode = 0x87,
        NCMouseMove = 0xA0,
        NCLeftButtonDown = 0xA1,
        NCLeftButtonUp = 0xA2,
        NCLeftButtonDoubleClick = 0xA3,
        NCRightButtonDown = 0xA4,
        NCRightButtonUp = 0xA5,
        NCRightButtonDoubleClick = 0xA6,
        NCMiddleButtonDown = 0xA7,
        NCMiddleButtonUp = 0xA8,
        NCMiddleButtonDoubleClick = 0xA9,

        KeyFirst = 0x100,
        KeyDown = 0x100,
        KeyUp = 0x101,
        Char = 0x102,
        DeadChar = 0x103,
        SystemKeyDown = 0x104,
        SystemKeyUp = 0x105,
        SystemChar = 0x106,
        SystemDeadChar = 0x107,
        KeyLast = 0x108,

        IMEStartComposition = 0x10D,
        IMEEndComposition = 0x10E,
        IMEComposition = 0x10F,
        IMEKeyLast = 0x10F,

        InitializeDialog = 0x110,
        Command = 0x111,
        SystemCommand = 0x112,
        Timer = 0x113,
        HorizontalScroll = 0x114,
        VerticalScroll = 0x115,
        InitializeMenu = 0x116,
        InitializeMenuPopup = 0x117,
        MenuSelect = 0x11F,
        MenuChar = 0x120,
        EnterIdle = 0x121,

        CTLColorMessageBox = 0x132,
        CTLColorEdit = 0x133,
        CTLColorListbox = 0x134,
        CTLColorButton = 0x135,
        CTLColorDialog = 0x136,
        CTLColorScrollBar = 0x137,
        CTLColorStatic = 0x138,

        MouseFirst = 0x200,
        MouseMove = 0x200,
        LeftButtonDown = 0x201,
        LeftButtonUp = 0x202,
        LeftButtonDoubleClick = 0x203,
        RightButtonDown = 0x204,
        RightButtonUp = 0x205,
        RightButtonDoubleClick = 0x206,
        MiddleButtonDown = 0x207,
        MiddleButtonUp = 0x208,
        MiddleButtonDoubleClick = 0x209,
        MouseWheel = 0x20A,
        MouseHorizontalWheel = 0x20E,

        ParentNotify = 0x210,
        EnterMenuLoop = 0x211,
        ExitMenuLoop = 0x212,
        NextMenu = 0x213,
        Sizing = 0x214,
        CaptureChanged = 0x215,
        Moving = 0x216,
        PowerBroadcast = 0x218,
        DeviceChange = 0x219,

        MDICreate = 0x220,
        MDIDestroy = 0x221,
        MDIActivate = 0x222,
        MDIRestore = 0x223,
        MDINext = 0x224,
        MDIMaximize = 0x225,
        MDITile = 0x226,
        MDICascade = 0x227,
        MDIIconArrange = 0x228,
        MDIGetActive = 0x229,
        MDISetMenu = 0x230,
        EnterSizeMove = 0x231,
        ExitSizeMove = 0x232,
        DropFiles = 0x233,
        MDIRefreshMenu = 0x234,

        IMESetContext = 0x281,
        IMENotify = 0x282,
        IMEControl = 0x283,
        IMECompositionFull = 0x284,
        IMESelect = 0x285,
        IMEChar = 0x286,
        IMEKeyDown = 0x290,
        IMEKeyUp = 0x291,

        MouseHover = 0x2A1,
        NCMouseLeave = 0x2A2,
        MouseLeave = 0x2A3,

        Cut = 0x300,
        Copy = 0x301,
        Paste = 0x302,
        Clear = 0x303,
        Undo = 0x304,

        RenderFormat = 0x305,
        RenderAllFormats = 0x306,
        DestroyClipboard = 0x307,
        DrawClipbard = 0x308,
        PaintClipbard = 0x309,
        VerticalScrollClipBoard = 0x30A,
        SizeClipbard = 0x30B,
        AskClipboardFormatname = 0x30C,
        ChangeClipboardChain = 0x30D,
        HorizontalScrollClipboard = 0x30E,
        QueryNewPalette = 0x30F,
        PaletteIsChanging = 0x310,
        PaletteChanged = 0x311,

        Hotkey = 0x312,
        Print = 0x317,
        PrintClient = 0x318,

        HandHeldFirst = 0x358,
        HandHeldlast = 0x35F,
        PenWinFirst = 0x380,
        PenWinLast = 0x38F,
        CoalesceFirst = 0x390,
        CoalesceLast = 0x39F,
        DDE_First = 0x3E0,
        DDE_Initiate = 0x3E0,
        DDE_Terminate = 0x3E1,
        DDE_Advise = 0x3E2,
        DDE_Unadvise = 0x3E3,
        DDE_Ack = 0x3E4,
        DDE_Data = 0x3E5,
        DDE_Request = 0x3E6,
        DDE_Poke = 0x3E7,
        DDE_Execute = 0x3E8,
        DDE_Last = 0x3E8,

        User = 0x400,
        App = 0x8000,
    }
}