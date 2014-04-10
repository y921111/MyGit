using System;
using System.IO;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using System.CodeDom;
using System.CodeDom.Compiler;
using Microsoft.CSharp;
using System.Reflection;
using System.Security;
using DrawTools;
using DrawTools.DynInterface;

using DeltavControlLib;
public class PIC_TDC3000_PMPID_Detail2:IDynCodeAttachDetach
{
 //The below function is create by system automaticly
public void  AttachPictureEventHandler(DrawArea area)
{
    string strObjectName;
    string strEventName;
    EventHandler _EventHandler;
    MouseEventHandler _MouseEventHandler;
    KeyEventHandler _KeyEventHandler;
    CancelEventHandler _CancelEventHandler;
    ScrollEventHandler _ScrollEventHandler;
   strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PIC_TDC3000_PMPID_Detail2_OnDynInitialize;
CodeDomCommon.AttachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PIC_TDC3000_PMPID_Detail2_OnDynAnimation;
CodeDomCommon.AttachAreaEventHandler(area,strEventName,_EventHandler);
strObjectName = "CTL";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CTL_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CTL";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CTL_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Tag";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Tag_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Tag";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Tag_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TagComment";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)TagComment_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "INITVAL";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)INITVAL_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "INITVAL";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)INITVAL_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "INITVAL_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)INITVAL_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "T2_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)T2_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "T2";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)T2_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "T2";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)T2_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "T1";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)T1_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "T1";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)T1_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "T1_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)T1_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "K_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)K_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "K";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)K_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "K";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)K_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OPEU";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)OPEU_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OPEU";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)OPEU_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OPEU_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)OPEU_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OP_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)OP_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OP";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)OP_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)OP_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CV";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CV_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CV_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CV_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CV_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SP_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)SP_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SP";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)SP_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)SP_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OPROC_Value";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)OPROC_Value_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OPROC_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)OPROC_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OPMCH_Value";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)OPMCH_Value_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OPMCH_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)OPMCH_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OPROC";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)OPROC_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OPROC";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)OPROC_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OPMCH";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)OPMCH_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OPMCH";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)OPMCH_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVAUTO";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVAUTO_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVAUTO";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVAUTO_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVAUTO_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVAUTO_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SPEUHI";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)SPEUHI_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SPEUHI";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)SPEUHI_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SPEULO";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)SPEULO_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SPEULO";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)SPEULO_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OPHI";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)OPHI_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OPHI";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)OPHI_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OPLO";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)OPLO_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OPLO";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)OPLO_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SPEUHI_Value";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)SPEUHI_Value_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SPEUHI_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)SPEUHI_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SPEULO_Value";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)SPEULO_Value_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SPEULO_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)SPEULO_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OPHI_Value";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)OPHI_Value_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OPHI_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)OPHI_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OPLO_Value";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)OPLO_Value_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OPLO_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)OPLO_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail_PAGE";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Detail_PAGE_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail_PAGE.Rect4_GROUP";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Detail_PAGE_Rect4_GROUP_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail_PAGE.Rect3_CTLCONCT";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Detail_PAGE_Rect3_CTLCONCT_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail_PAGE.Rect2_CTLALGO";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Detail_PAGE_Rect2_CTLALGO_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail_PAGE.Rect1_FIRST";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Detail_PAGE_Rect1_FIRST_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail_LIMITS";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Detail_LIMITS_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail_LIMITS";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)Detail_LIMITS_KeyUp;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "Detail_LIMITS.ENTER";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Detail_LIMITS_ENTER_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail_LIMITS.LIMITS_VALUE";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Detail_LIMITS_LIMITS_VALUE_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail_LIMITS.LIMITS_NAME";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Detail_LIMITS_LIMITS_NAME_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail_LIMITS.TB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)Detail_LIMITS_TB_KeyUp;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "TDC3000_Top";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)TDC3000_Top_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_Top.Caption1";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)TDC3000_Top_Caption1_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_Top.Caption1";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TDC3000_Top_Caption1_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_Top.Caption2";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)TDC3000_Top_Caption2_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_Top.Caption2";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TDC3000_Top_Caption2_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_Top.Text2";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TDC3000_Top_Text2_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_Top.TB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)TDC3000_Top_TB_KeyUp;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);

    return;
}

//The below function is create by system automaticly
public void  DetachPictureEventHandler(DrawArea area)
{
    string strObjectName;
    string strEventName;
    EventHandler _EventHandler;
    MouseEventHandler _MouseEventHandler;
    KeyEventHandler _KeyEventHandler;
    CancelEventHandler _CancelEventHandler;
    ScrollEventHandler _ScrollEventHandler;
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PIC_TDC3000_PMPID_Detail2_OnDynInitialize;
CodeDomCommon.DetachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PIC_TDC3000_PMPID_Detail2_OnDynAnimation;
CodeDomCommon.DetachAreaEventHandler(area,strEventName,_EventHandler);
strObjectName = "CTL";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CTL_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CTL";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CTL_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Tag";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Tag_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Tag";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Tag_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TagComment";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)TagComment_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "INITVAL";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)INITVAL_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "INITVAL";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)INITVAL_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "INITVAL_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)INITVAL_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "T2_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)T2_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "T2";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)T2_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "T2";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)T2_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "T1";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)T1_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "T1";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)T1_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "T1_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)T1_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "K_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)K_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "K";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)K_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "K";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)K_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OPEU";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)OPEU_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OPEU";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)OPEU_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OPEU_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)OPEU_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OP_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)OP_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OP";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)OP_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)OP_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CV";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CV_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CV_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CV_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CV_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SP_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)SP_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SP";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)SP_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)SP_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OPROC_Value";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)OPROC_Value_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OPROC_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)OPROC_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OPMCH_Value";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)OPMCH_Value_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OPMCH_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)OPMCH_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OPROC";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)OPROC_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OPROC";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)OPROC_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OPMCH";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)OPMCH_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OPMCH";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)OPMCH_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVAUTO";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVAUTO_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVAUTO";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVAUTO_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVAUTO_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVAUTO_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SPEUHI";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)SPEUHI_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SPEUHI";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)SPEUHI_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SPEULO";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)SPEULO_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SPEULO";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)SPEULO_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OPHI";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)OPHI_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OPHI";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)OPHI_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OPLO";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)OPLO_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OPLO";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)OPLO_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SPEUHI_Value";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)SPEUHI_Value_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SPEUHI_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)SPEUHI_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SPEULO_Value";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)SPEULO_Value_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SPEULO_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)SPEULO_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OPHI_Value";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)OPHI_Value_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OPHI_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)OPHI_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OPLO_Value";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)OPLO_Value_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OPLO_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)OPLO_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail_PAGE";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Detail_PAGE_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail_PAGE.Rect4_GROUP";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Detail_PAGE_Rect4_GROUP_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail_PAGE.Rect3_CTLCONCT";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Detail_PAGE_Rect3_CTLCONCT_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail_PAGE.Rect2_CTLALGO";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Detail_PAGE_Rect2_CTLALGO_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail_PAGE.Rect1_FIRST";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Detail_PAGE_Rect1_FIRST_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail_LIMITS";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Detail_LIMITS_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail_LIMITS";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)Detail_LIMITS_KeyUp;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "Detail_LIMITS.ENTER";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Detail_LIMITS_ENTER_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail_LIMITS.LIMITS_VALUE";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Detail_LIMITS_LIMITS_VALUE_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail_LIMITS.LIMITS_NAME";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Detail_LIMITS_LIMITS_NAME_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail_LIMITS.TB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)Detail_LIMITS_TB_KeyUp;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "TDC3000_Top";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)TDC3000_Top_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_Top.Caption1";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)TDC3000_Top_Caption1_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_Top.Caption1";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TDC3000_Top_Caption1_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_Top.Caption2";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)TDC3000_Top_Caption2_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_Top.Caption2";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TDC3000_Top_Caption2_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_Top.Text2";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TDC3000_Top_Text2_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_Top.TB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)TDC3000_Top_TB_KeyUp;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);

    return;
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void PIC_TDC3000_PMPID_Detail2_OnDynInitialize(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 

   DrawArea L = (DrawArea)(Area.GetDrawObj("Detail_LIMITS"));
   L.Visible = false;

   DrawArea G = (DrawArea)(Area.GetDrawObj("Detail_PAGE"));
   G.Visible = false;
 
////////////////////////////////////////////////////////////////////////////////处理变色
////////////////////////////////////////////////////////////////////////////////处理变色

	DrawText PVAUTO = (DrawText)Area.GetDrawObj("PVAUTO");
	DrawText SP = (DrawText)Area.GetDrawObj("SP");
	DrawText CV = (DrawText)Area.GetDrawObj("CV");
	DrawText OP = (DrawText)Area.GetDrawObj("OP");
	DrawText OPEU = (DrawText)Area.GetDrawObj("OPEU");
	DrawText SPEUHI = (DrawText)Area.GetDrawObj("SPEUHI");
	DrawText SPEULO = (DrawText)Area.GetDrawObj("SPEULO");
	DrawText OPHI = (DrawText)Area.GetDrawObj("OPHI");
	DrawText OPLO = (DrawText)Area.GetDrawObj("OPLO");
	DrawText OPMCH = (DrawText)Area.GetDrawObj("OPMCH");
	DrawText OPROC = (DrawText)Area.GetDrawObj("OPROC");
	DrawText K = (DrawText)Area.GetDrawObj("K");
	DrawText T1 = (DrawText)Area.GetDrawObj("T1");
	DrawText T2 = (DrawText)Area.GetDrawObj("T2");
	DrawText INITVAL = (DrawText)Area.GetDrawObj("INITVAL");

	PVAUTO.ForegroundColor = Color.Cyan;
	SP.ForegroundColor = Color.Cyan;
	CV.ForegroundColor = Color.Cyan;
	OP.ForegroundColor = Color.Cyan;
	OPEU.ForegroundColor = Color.Cyan;
	SPEUHI.ForegroundColor = Color.Yellow;
	SPEULO.ForegroundColor = Color.Yellow;
	OPHI.ForegroundColor = Color.Yellow;
	OPLO.ForegroundColor = Color.Yellow;
	OPMCH.ForegroundColor = Color.Yellow;
	OPROC.ForegroundColor = Color.Yellow;
	K.ForegroundColor = Color.Cyan;
	T1.ForegroundColor = Color.Cyan;
	T2.ForegroundColor = Color.Cyan;
	INITVAL.ForegroundColor = Color.Cyan;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void PIC_TDC3000_PMPID_Detail2_OnDynAnimation(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 

   DrawArea L = (DrawArea)(Area.GetDrawObj("Detail_LIMITS"));
   DrawArea G = (DrawArea)(Area.GetDrawObj("Detail_PAGE"));

   if(G.Visible == true)
      {
         L.Visible = false;
       }
   if(L.Visible == true)
      {
         G.Visible = false;
       }

////////////////////////////////////////////////////////////////////////////////处理变色
////////////////////////////////////////////////////////////////////////////////处理变色


	DrawText PVAUTO = (DrawText)Area.GetDrawObj("PVAUTO");
	DrawText SP = (DrawText)Area.GetDrawObj("SP");
	DrawText CV = (DrawText)Area.GetDrawObj("CV");
	DrawText OP = (DrawText)Area.GetDrawObj("OP");
	DrawText OPEU = (DrawText)Area.GetDrawObj("OPEU");
	DrawText SPEUHI = (DrawText)Area.GetDrawObj("SPEUHI");
	DrawText SPEULO = (DrawText)Area.GetDrawObj("SPEULO");
	DrawText OPHI = (DrawText)Area.GetDrawObj("OPHI");
	DrawText OPLO = (DrawText)Area.GetDrawObj("OPLO");
	DrawText OPMCH = (DrawText)Area.GetDrawObj("OPMCH");
	DrawText OPROC = (DrawText)Area.GetDrawObj("OPROC");
	DrawText K = (DrawText)Area.GetDrawObj("K");
	DrawText T1 = (DrawText)Area.GetDrawObj("T1");
	DrawText T2 = (DrawText)Area.GetDrawObj("T2");
	DrawText INITVAL = (DrawText)Area.GetDrawObj("INITVAL");
	DrawText CTL = (DrawText)Area.GetDrawObj("CTL");

	PVAUTO.ForegroundColor = Color.Cyan;
	SP.ForegroundColor = Color.Cyan;
	CV.ForegroundColor = Color.Cyan;
	OP.ForegroundColor = Color.Cyan;
	OPEU.ForegroundColor = Color.Cyan;
	SPEUHI.ForegroundColor = Color.Yellow;
	SPEULO.ForegroundColor = Color.Yellow;
	OPHI.ForegroundColor = Color.Yellow;
	OPLO.ForegroundColor = Color.Yellow;
	OPMCH.ForegroundColor = Color.Yellow;
	OPROC.ForegroundColor = Color.Yellow;
	K.ForegroundColor = Color.Cyan;
	T1.ForegroundColor = Color.Cyan;
	T2.ForegroundColor = Color.Cyan;
	INITVAL.ForegroundColor = Color.Cyan;

	DrawText PVAUTO_Value = (DrawText)Area.GetDrawObj("PVAUTO_Value");
	DrawText SP_Value = (DrawText)Area.GetDrawObj("SP_Value");
	DrawText CV_Value = (DrawText)Area.GetDrawObj("CV_Value");
	DrawText OP_Value = (DrawText)Area.GetDrawObj("OP_Value");
	DrawText OPEU_Value = (DrawText)Area.GetDrawObj("OPEU_Value");
	DrawText SPEUHI_Value = (DrawText)Area.GetDrawObj("SPEUHI_Value");
	DrawText SPEULO_Value = (DrawText)Area.GetDrawObj("SPEULO_Value");
	DrawText OPHI_Value = (DrawText)Area.GetDrawObj("OPHI_Value");
	DrawText OPLO_Value = (DrawText)Area.GetDrawObj("OPLO_Value");
	DrawText OPMCH_Value = (DrawText)Area.GetDrawObj("OPMCH_Value");
	DrawText OPROC_Value = (DrawText)Area.GetDrawObj("OPROC_Value");
	DrawText K_Value = (DrawText)Area.GetDrawObj("K_Value");
	DrawText T1_Value = (DrawText)Area.GetDrawObj("T1_Value");
	DrawText T2_Value = (DrawText)Area.GetDrawObj("T2_Value");
	DrawText INITVAL_Value = (DrawText)Area.GetDrawObj("INITVAL_Value");

	PVAUTO_Value.ForegroundColor = Color.Cyan;
	SP_Value.ForegroundColor = Color.Cyan;
	CV_Value.ForegroundColor = Color.Cyan;
	OP_Value.ForegroundColor = Color.Cyan;
	OPEU_Value.ForegroundColor = Color.Cyan;
	SPEUHI_Value.ForegroundColor = Color.Yellow;
	SPEULO_Value.ForegroundColor = Color.Yellow;
	OPHI_Value.ForegroundColor = Color.Yellow;
	OPLO_Value.ForegroundColor = Color.Yellow;
	OPMCH_Value.ForegroundColor = Color.Yellow;
	OPROC_Value.ForegroundColor = Color.Yellow;
	K_Value.ForegroundColor = Color.Cyan;
	T1_Value.ForegroundColor = Color.Cyan;
	T2_Value.ForegroundColor = Color.Cyan;
	INITVAL_Value.ForegroundColor = Color.Cyan;

        if(Area.Variable[1] == "1")
	    {
               PVAUTO.ForegroundColor = Color.White;
               PVAUTO_Value.ForegroundColor = Color.White;
            }
        if(Area.Variable[1] == "2")
	    {
               SP.ForegroundColor = Color.White;
               SP_Value.ForegroundColor = Color.White;
            }
        if(Area.Variable[1] == "3")
	    {
               CV.ForegroundColor = Color.White;
               CV_Value.ForegroundColor = Color.White;
            }
        if(Area.Variable[1] == "4")
	    {
               OP.ForegroundColor = Color.White;
               OP_Value.ForegroundColor = Color.White;
            }
        if(Area.Variable[1] == "5")
	    {
               OPEU.ForegroundColor = Color.White;
               OPEU_Value.ForegroundColor = Color.White;
            }
        if(Area.Variable[1] == "6")
	    {
               SPEUHI.ForegroundColor = Color.White;
               SPEUHI_Value.ForegroundColor = Color.White;
            }
        if(Area.Variable[1] == "7")
	    {
               SPEULO.ForegroundColor = Color.White;
               SPEULO_Value.ForegroundColor = Color.White;
            }
        if(Area.Variable[1] == "8")
	    {
               OPHI.ForegroundColor = Color.White;
               OPHI_Value.ForegroundColor = Color.White;
            }
        if(Area.Variable[1] == "9")
	    {
               OPLO.ForegroundColor = Color.White;
               OPLO_Value.ForegroundColor = Color.White;
            }
        if(Area.Variable[1] == "10")
	    {
               OPMCH.ForegroundColor = Color.White;
               OPMCH_Value.ForegroundColor = Color.White;
            }
        if(Area.Variable[1] == "11")
	    {
               OPROC.ForegroundColor = Color.White;
               OPROC_Value.ForegroundColor = Color.White;
            }
        if(Area.Variable[1] == "12")
	    {
               K.ForegroundColor = Color.White;
               K_Value.ForegroundColor = Color.White;
            }
        if(Area.Variable[1] == "13")
	    {
               T1.ForegroundColor = Color.White;
               T1_Value.ForegroundColor = Color.White;
            }
        if(Area.Variable[1] == "14")
	    {
               T2.ForegroundColor = Color.White;
               T2_Value.ForegroundColor = Color.White;
            }
        if(Area.Variable[1] == "15")
	    {
               INITVAL.ForegroundColor = Color.White;
               INITVAL_Value.ForegroundColor = Color.White;
            }
        if(Area.Variable[1] == "16")
	    {
               CTL.ForegroundColor = Color.White;
            }
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void CTL_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText CTL = (DrawText)dynArgs.sender; 

    DrawArea D = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    D.Visible = false;   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_PAGE");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "2";//设置标志位变色

    Area.Variable[1] = "16";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void CTL_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText CTL = (DrawText)dynArgs.sender; 

    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_PAGE");
    if(L.Visible == false)
       {
             CTL.ForegroundColor = Color.Lime;
       }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void Tag_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText Tag = (DrawText)dynArgs.sender; 
   
        string tagName = Area.Variable[0].ToUpper();

	if(tagName != "")
		Tag.Caption = tagName;
	else
		Tag.Caption = "******";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void Tag_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText Tag = (DrawText)dynArgs.sender; 
   
        string tagName = Area.Variable[0].ToUpper();

	if(tagName != "")

		Tag.Caption = tagName;
	else
		Tag.Caption = "******";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void TagComment_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText TagComment = (DrawText)dynArgs.sender; 
   
	string strTagName = Area.Variable[0];
	TagComment.Caption = CommonFunction.GetTagComment(strTagName);

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void INITVAL_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText T2 = (DrawText)dynArgs.sender; 
   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "T2";
   
    T2.ForegroundColor = Color.White;
    DrawText T2_Value = (DrawText)Area.GetDrawObj("T2_Value");
    T2_Value.ForegroundColor = Color.White;

    Area.Variable[1] = "15";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void INITVAL_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText T2 = (DrawText)dynArgs.sender; 

    DrawText T2_Value = (DrawText)Area.GetDrawObj("T2_Value");   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    if(L.Visible == false)
       {
             T2.ForegroundColor = Color.Cyan;
             T2_Value.ForegroundColor = Color.Cyan;
       }
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void INITVAL_Value_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText T2_Value = (DrawText)dynArgs.sender; 
   
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	int nDigit = 2;
	string tagName = Area.Variable[0] + "/PVFORMAT";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
		nDigit = Convert.ToInt32(dbValue);
	string strDigit = "f" + nDigit.ToString();
	
	tagName = Area.Variable[0] + "/T2";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		T2_Value.Caption = dbValue.ToString(strDigit);
	}
	else
		T2_Value.Caption = "------";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void T2_Value_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText T2_Value = (DrawText)dynArgs.sender; 
   
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	int nDigit = 2;
	string tagName = Area.Variable[0] + "/PVFORMAT";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
		nDigit = Convert.ToInt32(dbValue);
	string strDigit = "f" + nDigit.ToString();
	
	tagName = Area.Variable[0] + "/T2";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		T2_Value.Caption = dbValue.ToString(strDigit);
	}
	else
		T2_Value.Caption = "------";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void T2_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText T2 = (DrawText)dynArgs.sender; 
   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "T2";
   
    T2.ForegroundColor = Color.White;
    DrawText T2_Value = (DrawText)Area.GetDrawObj("T2_Value");
    T2_Value.ForegroundColor = Color.White;

    Area.Variable[1] = "14";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void T2_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText T2 = (DrawText)dynArgs.sender; 

    DrawText T2_Value = (DrawText)Area.GetDrawObj("T2_Value");   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    if(L.Visible == false)
       {
             T2.ForegroundColor = Color.Cyan;
             T2_Value.ForegroundColor = Color.Cyan;
       }
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void T1_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText T1 = (DrawText)dynArgs.sender; 
   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "T1";
   
    T1.ForegroundColor = Color.White;
    DrawText T1_Value = (DrawText)Area.GetDrawObj("T1_Value");
    T1_Value.ForegroundColor = Color.White;

    Area.Variable[1] = "13";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void T1_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText T1 = (DrawText)dynArgs.sender; 

    DrawText T1_Value = (DrawText)Area.GetDrawObj("T1_Value");   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    if(L.Visible == false)
       {
             T1.ForegroundColor = Color.Cyan;
             T1_Value.ForegroundColor = Color.Cyan;
       }
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void T1_Value_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText T1_Value = (DrawText)dynArgs.sender; 
   
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	int nDigit = 2;
	string tagName = Area.Variable[0] + "/PVFORMAT";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
		nDigit = Convert.ToInt32(dbValue);
	string strDigit = "f" + nDigit.ToString();
	
	tagName = Area.Variable[0] + "/T1";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		T1_Value.Caption = dbValue.ToString(strDigit);
	}
	else
		T1_Value.Caption = "------";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void K_Value_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText CV_Value = (DrawText)dynArgs.sender; 
   
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	int nDigit = 2;
	string tagName = Area.Variable[0] + "/PVFORMAT";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
		nDigit = Convert.ToInt32(dbValue);
	string strDigit = "f" + nDigit.ToString();
	
	tagName = Area.Variable[0] + "/CV";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		CV_Value.Caption = dbValue.ToString(strDigit);
	}
	else
		CV_Value.Caption = "------";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void K_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText K = (DrawText)dynArgs.sender; 
   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "K";
   
    K.ForegroundColor = Color.White;
    DrawText K_Value = (DrawText)Area.GetDrawObj("K_Value");
    K_Value.ForegroundColor = Color.White;

    Area.Variable[1] = "12";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void K_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText K = (DrawText)dynArgs.sender; 

    DrawText K_Value = (DrawText)Area.GetDrawObj("K_Value");   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    if(L.Visible == false)
       {
             K.ForegroundColor = Color.Cyan;
             K_Value.ForegroundColor = Color.Cyan;
       }
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void OPEU_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText OPEU = (DrawText)dynArgs.sender; 
   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "OPEU";
   
    OPEU.ForegroundColor = Color.White;
    DrawText OPEU_Value = (DrawText)Area.GetDrawObj("OPEU_Value");
    OPEU_Value.ForegroundColor = Color.White;

    Area.Variable[1] = "5";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void OPEU_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText OPEU = (DrawText)dynArgs.sender; 

    DrawText OPEU_Value = (DrawText)Area.GetDrawObj("OPEU_Value");   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    if(L.Visible == false)
       {
             OPEU.ForegroundColor = Color.Cyan;
             OPEU_Value.ForegroundColor = Color.Cyan;
       }
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void OPEU_Value_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText OPEU_Value = (DrawText)dynArgs.sender; 
   
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	int nDigit = 2;
	string tagName = Area.Variable[0] + "/PVFORMAT";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
		nDigit = Convert.ToInt32(dbValue);
	string strDigit = "f" + nDigit.ToString();
	
	tagName = Area.Variable[0] + "/OPEU";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		OPEU_Value.Caption = dbValue.ToString(strDigit);
	}
	else
		OPEU_Value.Caption = "------";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void OP_Value_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText OP_Value = (DrawText)dynArgs.sender; 
   
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	int nDigit = 2;
	string tagName = Area.Variable[0] + "/PVFORMAT";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
		nDigit = Convert.ToInt32(dbValue);
	string strDigit = "f" + nDigit.ToString();
	
	tagName = Area.Variable[0] + "/OP";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		OP_Value.Caption = dbValue.ToString(strDigit);
	}
	else
		OP_Value.Caption = "------";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void OP_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText OP = (DrawText)dynArgs.sender; 
   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "OP";
   
    OP.ForegroundColor = Color.White;
    DrawText OP_Value = (DrawText)Area.GetDrawObj("OP_Value");
    OP_Value.ForegroundColor = Color.White;

    Area.Variable[1] = "4";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void OP_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText OP = (DrawText)dynArgs.sender; 

    DrawText OP_Value = (DrawText)Area.GetDrawObj("OP_Value");   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    if(L.Visible == false)
       {
             OP.ForegroundColor = Color.Cyan;
             OP_Value.ForegroundColor = Color.Cyan;
       }
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void CV_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText CV = (DrawText)dynArgs.sender; 
   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "CV";
   
    CV.ForegroundColor = Color.White;
    DrawText CV_Value = (DrawText)Area.GetDrawObj("CV_Value");
    CV_Value.ForegroundColor = Color.White;

    Area.Variable[1] = "3";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void CV_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText CV = (DrawText)dynArgs.sender; 

    DrawText CV_Value = (DrawText)Area.GetDrawObj("CV_Value");   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    if(L.Visible == false)
       {
             CV.ForegroundColor = Color.Cyan;
             CV_Value.ForegroundColor = Color.Cyan;
       }
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void CV_Value_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText CV_Value = (DrawText)dynArgs.sender; 
   
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	int nDigit = 2;
	string tagName = Area.Variable[0] + "/PVFORMAT";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
		nDigit = Convert.ToInt32(dbValue);
	string strDigit = "f" + nDigit.ToString();
	
	tagName = Area.Variable[0] + "/CV";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		CV_Value.Caption = dbValue.ToString(strDigit);
	}
	else
		CV_Value.Caption = "------";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void SP_Value_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText SP_Value = (DrawText)dynArgs.sender; 
   
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	int nDigit = 2;
	string tagName = Area.Variable[0] + "/PVFORMAT";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
		nDigit = Convert.ToInt32(dbValue);
	string strDigit = "f" + nDigit.ToString();
	
	tagName = Area.Variable[0] + "/SP";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		SP_Value.Caption = dbValue.ToString(strDigit);
	}
	else
		SP_Value.Caption = "------";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void SP_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText SP = (DrawText)dynArgs.sender; 
   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "SP";
   
    SP.ForegroundColor = Color.White;
    DrawText SP_Value = (DrawText)Area.GetDrawObj("SP_Value");
    SP_Value.ForegroundColor = Color.White;

    Area.Variable[1] = "2";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void SP_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText SP = (DrawText)dynArgs.sender; 

    DrawText SP_Value = (DrawText)Area.GetDrawObj("SP_Value");   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    if(L.Visible == false)
       {
             SP.ForegroundColor = Color.Cyan;
             SP_Value.ForegroundColor = Color.Cyan;
       }
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void OPROC_Value_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText OPROC_Value = (DrawText)dynArgs.sender; 
   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "OPROC";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void OPROC_Value_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText OPROC_Value = (DrawText)dynArgs.sender; 
   
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	int nDigit = 2;
	string tagName = Area.Variable[0] + "/PVFORMAT";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
		nDigit = Convert.ToInt32(dbValue);
	string strDigit = "f" + nDigit.ToString();
	
	tagName = Area.Variable[0] + "/OPROC";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		OPROC_Value.Caption = dbValue.ToString(strDigit);
	}
	else
		OPROC_Value.Caption = "------";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void OPMCH_Value_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText OPMCH_Value = (DrawText)dynArgs.sender; 
   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "OPMCH";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void OPMCH_Value_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText OPMCH_Value = (DrawText)dynArgs.sender; 
   
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	int nDigit = 2;
	string tagName = Area.Variable[0] + "/PVFORMAT";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
		nDigit = Convert.ToInt32(dbValue);
	string strDigit = "f" + nDigit.ToString();
	
	tagName = Area.Variable[0] + "/OPMCH";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		OPMCH_Value.Caption = dbValue.ToString(strDigit);
	}
	else
		OPMCH_Value.Caption = "------";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void OPROC_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText OPROC = (DrawText)dynArgs.sender; 
   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "OPROC";
   
    OPROC.ForegroundColor = Color.White;
    DrawText OPROC_Value = (DrawText)Area.GetDrawObj("OPROC_Value");
    OPROC_Value.ForegroundColor = Color.White;

    Area.Variable[1] = "11";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void OPROC_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText OPROC = (DrawText)dynArgs.sender; 

    DrawText OPROC_Value = (DrawText)Area.GetDrawObj("OPROC_Value");   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    if(L.Visible == false)
       {
             OPROC.ForegroundColor = Color.Yellow;
             OPROC_Value.ForegroundColor = Color.Yellow;
       }
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void OPMCH_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText OPMCH = (DrawText)dynArgs.sender; 
   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "OPMCH";
   
    OPMCH.ForegroundColor = Color.White;
    DrawText OPMCH_Value = (DrawText)Area.GetDrawObj("OPMCH_Value");
    OPMCH_Value.ForegroundColor = Color.White;

    Area.Variable[1] = "10";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void OPMCH_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText OPMCH = (DrawText)dynArgs.sender; 

    DrawText OPMCH_Value = (DrawText)Area.GetDrawObj("OPMCH_Value");   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    if(L.Visible == false)
       {
             OPMCH.ForegroundColor = Color.Yellow;
             OPMCH_Value.ForegroundColor = Color.Yellow;
       }
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void PVAUTO_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVAUTO = (DrawText)dynArgs.sender; 
   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "PVAUTO";
   
    PVAUTO.ForegroundColor = Color.White;
    DrawText PVAUTO_Value = (DrawText)Area.GetDrawObj("PVAUTO_Value");
    PVAUTO_Value.ForegroundColor = Color.White;

    Area.Variable[1] = "1";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void PVAUTO_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVAUTO = (DrawText)dynArgs.sender; 

    DrawText PVAUTO_Value = (DrawText)Area.GetDrawObj("PVAUTO_Value");   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    if(L.Visible == false)
       {
             PVAUTO.ForegroundColor = Color.Cyan;
             PVAUTO_Value.ForegroundColor = Color.Cyan;
       }
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void PVAUTO_Value_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVAUTO_Value = (DrawText)dynArgs.sender; 
   
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	int nDigit = 2;
	string tagName = Area.Variable[0] + "/PVFORMAT";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
		nDigit = Convert.ToInt32(dbValue);
	string strDigit = "f" + nDigit.ToString();
	
	tagName = Area.Variable[0] + "/PVAUTO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		PVAUTO_Value.Caption = dbValue.ToString(strDigit);
	}
	else
		PVAUTO_Value.Caption = "------";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void SPEUHI_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText SPEUHI = (DrawText)dynArgs.sender; 
   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "SPEUHI";
   
    SPEUHI.ForegroundColor = Color.White;
    DrawText SPEUHI_Value = (DrawText)Area.GetDrawObj("SPEUHI_Value");
    SPEUHI_Value.ForegroundColor = Color.White;

    Area.Variable[1] = "6";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void SPEUHI_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText SPEUHI = (DrawText)dynArgs.sender; 

    DrawText SPEUHI_Value = (DrawText)Area.GetDrawObj("SPEUHI_Value");   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    if(L.Visible == false)
       {
             SPEUHI.ForegroundColor = Color.Yellow;
             SPEUHI_Value.ForegroundColor = Color.Yellow;
       }
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void SPEULO_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText SPEULO = (DrawText)dynArgs.sender; 
   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "SPEULO";
   
    SPEULO.ForegroundColor = Color.White;
    DrawText SPEULO_Value = (DrawText)Area.GetDrawObj("SPEULO_Value");
    SPEULO_Value.ForegroundColor = Color.White;

    Area.Variable[1] = "7";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void SPEULO_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText SPEULO = (DrawText)dynArgs.sender; 

    DrawText SPEULO_Value = (DrawText)Area.GetDrawObj("SPEULO_Value");   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    if(L.Visible == false)
       {
             SPEULO.ForegroundColor = Color.Yellow;
             SPEULO_Value.ForegroundColor = Color.Yellow;
       }
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void OPHI_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText OPHI = (DrawText)dynArgs.sender; 
   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "OPHI";
   
    OPHI.ForegroundColor = Color.White;
    DrawText OPHI_Value = (DrawText)Area.GetDrawObj("OPHI_Value");
    OPHI_Value.ForegroundColor = Color.White;

    Area.Variable[1] = "8";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void OPHI_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText OPHI = (DrawText)dynArgs.sender; 

    DrawText OPHI_Value = (DrawText)Area.GetDrawObj("OPHI_Value");   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    if(L.Visible == false)
       {
             OPHI.ForegroundColor = Color.Yellow;
             OPHI_Value.ForegroundColor = Color.Yellow;
       }
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void OPLO_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText OPLO = (DrawText)dynArgs.sender; 
   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "OPLO";
   
    OPLO.ForegroundColor = Color.White;
    DrawText OPLO_Value = (DrawText)Area.GetDrawObj("OPLO_Value");
    OPLO_Value.ForegroundColor = Color.White;

    Area.Variable[1] = "9";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void OPLO_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText OPLO = (DrawText)dynArgs.sender; 

    DrawText OPLO_Value = (DrawText)Area.GetDrawObj("OPLO_Value");   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    if(L.Visible == false)
       {
             OPLO.ForegroundColor = Color.Yellow;
             OPLO_Value.ForegroundColor = Color.Yellow;
       }
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void SPEUHI_Value_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText SPEUHI_Value = (DrawText)dynArgs.sender; 
   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "SPEUHI";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void SPEUHI_Value_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText SPEUHI_Value = (DrawText)dynArgs.sender; 
   
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	int nDigit = 2;
	string tagName = Area.Variable[0] + "/PVFORMAT";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
		nDigit = Convert.ToInt32(dbValue);
	string strDigit = "f" + nDigit.ToString();
	
	tagName = Area.Variable[0] + "/SPEUHI";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		SPEUHI_Value.Caption = dbValue.ToString(strDigit);
	}
	else
		SPEUHI_Value.Caption = "------";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void SPEULO_Value_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText SPEULO_Value = (DrawText)dynArgs.sender; 
   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "SPEULO";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void SPEULO_Value_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText SPEULO_Value = (DrawText)dynArgs.sender; 
   
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	int nDigit = 2;
	string tagName = Area.Variable[0] + "/PVFORMAT";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
		nDigit = Convert.ToInt32(dbValue);
	string strDigit = "f" + nDigit.ToString();
	
	tagName = Area.Variable[0] + "/SPEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		SPEULO_Value.Caption = dbValue.ToString(strDigit);
	}
	else
		SPEULO_Value.Caption = "------";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void OPHI_Value_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText OPHI_Value = (DrawText)dynArgs.sender; 
   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "OPHI";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void OPHI_Value_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText OPHI_Value = (DrawText)dynArgs.sender; 
   
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	int nDigit = 2;
	string tagName = Area.Variable[0] + "/PVFORMAT";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
		nDigit = Convert.ToInt32(dbValue);
	string strDigit = "f" + nDigit.ToString();
	
	tagName = Area.Variable[0] + "/OPHI";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		OPHI_Value.Caption = dbValue.ToString(strDigit);
	}
	else
		OPHI_Value.Caption = "------";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void OPLO_Value_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText OPLO_Value = (DrawText)dynArgs.sender; 
   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "OPLO";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void OPLO_Value_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText OPLO_Value = (DrawText)dynArgs.sender; 
   
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	int nDigit = 2;
	string tagName = Area.Variable[0] + "/PVFORMAT";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
		nDigit = Convert.ToInt32(dbValue);
	string strDigit = "f" + nDigit.ToString();
	
	tagName = Area.Variable[0] + "/OPLO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		OPLO_Value.Caption = dbValue.ToString(strDigit);
	}
	else
		OPLO_Value.Caption = "------";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void Detail_PAGE_OnDynAnimation(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 
   
	DrawText FIRST = (DrawText)Area.GetDrawObj("FIRST");
	DrawText CTLALGO = (DrawText)Area.GetDrawObj("CTLALGO");
	DrawText CTLCONCT = (DrawText)Area.GetDrawObj("CTLCONCT");

	FIRST.ForegroundColor = Color.Lime;
	CTLALGO.ForegroundColor = Color.Lime;
	CTLCONCT.ForegroundColor = Color.Lime;


        if(Area.Variable[1] == "1")
	    {
               FIRST.ForegroundColor = Color.Cyan;
            }
        if(Area.Variable[1] == "2")
	    {
               CTLALGO.ForegroundColor = Color.Cyan;
            }
        if(Area.Variable[1] == "3")
	    {
               CTLCONCT.ForegroundColor = Color.Cyan;
            }


    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void Detail_PAGE_Rect4_GROUP_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect4_GROUP = (DrawRectangle)dynArgs.sender; 

	int nLeft = 0;
	int nTop = 0;
	string[] strVariable = new string[2];
	strVariable[0] = Area.Variable[0];
	strVariable[1] = "PI107";
	CommonFunction.OpenPicture("TDC3000_ControlGroup.grf", nTop, nLeft, strVariable);
    Area.Visible = false;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void Detail_PAGE_Rect3_CTLCONCT_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect3_CTLCONCT = (DrawRectangle)dynArgs.sender; 

	int nLeft = 0;
	int nTop = 0;
	string[] strVariable = new string[1];
	strVariable[0] = Area.Variable[0];
	CommonFunction.OpenPicture("TDC3000_PMPID_Detail3.grf", nTop, nLeft, strVariable);
    Area.Visible = false;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void Detail_PAGE_Rect2_CTLALGO_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect2_CTLALGO = (DrawRectangle)dynArgs.sender; 
   
	int nLeft = 0;
	int nTop = 0;
	string[] strVariable = new string[1];
	strVariable[0] = Area.Variable[0];
	CommonFunction.OpenPicture("TDC3000_PMPID_Detail2.grf", nTop, nLeft, strVariable);
    Area.Visible = false;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void Detail_PAGE_Rect1_FIRST_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect1_FIRST = (DrawRectangle)dynArgs.sender; 
   
	int nLeft = 0;
	int nTop = 0;
	string[] strVariable = new string[1];
	strVariable[0] = Area.Variable[0];
	CommonFunction.OpenPicture("TDC3000_PMPID_Detail1.grf", nTop, nLeft, strVariable);

    Area.Visible = false;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void Detail_LIMITS_OnDynInitialize(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 
   
   if(Area.BReference)//图素
	{
	   TextBox TB = (TextBox)Area.GetDrawObj("TB");

		if(TB.CanFocus)
		    {
			TB.Focus();
		    }
		else
		    {
			Area.Enabled = true;	//首先确保PVTB的容器Area的Enabled为True，否则TB.CanFocus=false；
			TB.Enabled = true;
			TB.Visible = true;
			TB.Focus();
		    }
        }

        DrawArea picT = (DrawArea)(Area.Parent);
	Area.Variable[0] = picT.Variable[0];

    return; 
}

//Do not remove or update this comment
//Event Delegate:KeyEventHandler 
//Event Handler:KeyUp 
public void Detail_LIMITS_KeyUp(Object sender, KeyEventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   
   string tagName = Area.Variable[0] + "/" + Area.Variable[1];
   TextBox TB = (TextBox)Area.GetDrawObj("TB");

     double dbValue = 0;
     int nValue = 0;
     bool bValue = false;
     int nDataType = 0;

     bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
     
     if(ret)
      
           {
		    switch(e.KeyData)
                      {    

                         case Keys.Enter:

	                        {		
                                   CommonFunction.DSI_SetValue(tagName, Convert.ToDouble(TB.Text));
	                        } 
                         Area.Visible = false;
	                 break;
                       
                      } 
                
         }
              
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void Detail_LIMITS_ENTER_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle ENTER = (DrawRectangle)dynArgs.sender; 
   
    TextBox TB = (TextBox)Area.GetDrawObj("TB");

    string tagName = Area.Variable[0] + "/" + Area.Variable[1];
    CommonFunction.DSI_SetValue(tagName, Convert.ToDouble(TB.Text));
    Area.Visible = false;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void Detail_LIMITS_LIMITS_VALUE_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText LIMITS_VALUE = (DrawText)dynArgs.sender; 
  
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	int nDigit = 2;
	string tagName = Area.Variable[0] + "/PVFORMAT";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
		nDigit = Convert.ToInt32(dbValue);
	string strDigit = "f" + nDigit.ToString();
	
	tagName = Area.Variable[0] + "/" + Area.Variable[1];
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		LIMITS_VALUE.Caption = dbValue.ToString(strDigit);
	}
	else
		LIMITS_VALUE.Caption = "##.#";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void Detail_LIMITS_LIMITS_NAME_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText LIMITS_NAME = (DrawText)dynArgs.sender; 
   
    string tagName = Area.Variable[1].ToUpper();

	if(tagName != "")
		LIMITS_NAME.Caption = tagName;
	else
		LIMITS_NAME.Caption = "******";	

    return; 
}
//Do not remove or update this comment
//Event Delegate:KeyEventHandler 
//Event Handler:KeyUp 
public void Detail_LIMITS_TB_KeyUp(Object sender, KeyEventArgs e)
{
   TextBox TB = (TextBox)sender; 

   DrawArea Area = CommonFunction.GetThisDrawArea(TB);

     DrawRectangle ENTER = (DrawRectangle)Area.GetDrawObj("ENTER");

     double dbValue = 0;
     int nValue = 0;
     bool bValue = false;
     int nDataType = 0;
     string TagName = Area.Variable[0] + "/" + Area.Variable[1];
     bool ret1 = CommonFunction.GetValueWithType(TagName,ref dbValue,ref nValue,ref bValue,ref nDataType);

	switch ( e.KeyData )
	{
	case Keys.Enter:

		if(TB.Text == "" || TB.Text == null)

		{
			TB.Visible = true;
			TB.Enabled = true;
                        Area.Visible = false;
			return;
		}

		else

		{
			string PVInputValue = TB.Text;
			double dbPVValue = Convert.ToDouble(PVInputValue);

			object obj1 = CommonFunction.GetLabelOfControl(TB);

			if (obj1 != null)

			{
                             
                             CommonFunction.DSI_SetValue(TagName, dbPVValue);
                             
			}  
                        ENTER.Variable[0] = TB.Text;
                        TB.ForeColor = Color.Lime;
			TB.Visible = true;
			TB.Enabled = true;
                        Area.Visible = false;
                        return;
		}
		break;
                
	}

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void TDC3000_Top_OnDynInitialize(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 
   
   if(Area.BReference)

	{
	    Area.Enabled = true;
        }

     object obj=Area.GetControlObj("TB");
     TextBox TB=(TextBox)obj;
     TB.Visible = false;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void TDC3000_Top_Caption1_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText Caption1 = (DrawText)dynArgs.sender; 
 
        Caption1.Caption = "";	
        Caption1.Variable[1] = "";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void TDC3000_Top_Caption1_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText Caption1 = (DrawText)dynArgs.sender; 
   
    Caption1.Variable[0] = CommonFunction._ProjectRelated.Var[0];

    if(Caption1.Variable[0] == "11")
       {
        Caption1.Caption = "";	
        int nLeft = 0;
	int nTop = 0;
	string[] strVariable = new string[1];
	strVariable[0] = "";
	CommonFunction.OpenPicture(CommonFunction._ProjectRelated.Var[1] + ".grf", nTop, nLeft, strVariable);

        object obj = Area.GetControlObj("TB");
		if(obj != null)
		{
			TextBox TB = (TextBox)obj; 
			if(TB != null)
			{
				TB.Visible = false;
				TB.Enabled = true;	
			}
		}

       }
  
    if(Caption1.Variable[0] == "SCHEM")
       {
        Caption1.Caption = "ENTER SCHEMATIC NAME";	
        Caption1.ForegroundColor = Color.Lime;

        object obj = Area.GetControlObj("TB");
		if(obj != null)
		{
			TextBox TB = (TextBox)obj; 
			if(TB != null)
			{
				TB.Visible = true;
				TB.Enabled = true;
				TB.Text = "";
				TB.Focus();				
			}
		}
       }
  

    if(Caption1.Variable[0] == "GROUP")
       {
        Caption1.Caption = "ENTER GROUP NUMBER";
        Caption1.ForegroundColor = Color.Lime;
	
        object obj = Area.GetControlObj("TB");
		if(obj != null)
		{
			TextBox TB = (TextBox)obj; 
			if(TB != null)
			{
				TB.Visible = true;
				TB.Enabled = true;
				TB.Text = "";
				TB.Focus();				
			}
		}
       }  

    if(Caption1.Variable[0] == "DETAIL")
       {
        Caption1.Caption = "ENTER TAG NAME";
        Caption1.ForegroundColor = Color.Lime;
	
        object obj = Area.GetControlObj("TB");
		if(obj != null)
		{
			TextBox TB = (TextBox)obj; 
			if(TB != null)
			{
				TB.Visible = true;
				TB.Enabled = true;
				TB.Text = "";
				TB.Focus();				
			}
		}
       }

    if(Caption1.Variable[0] == "UNITTREND")
       {
        Caption1.Caption = "ENTER UNIT NUMBER";
        Caption1.ForegroundColor = Color.Lime;
	
        object obj = Area.GetControlObj("TB");
		if(obj != null)
		{
			TextBox TB = (TextBox)obj; 
			if(TB != null)
			{
				TB.Visible = true;
				TB.Enabled = true;
				TB.Text = "";
				TB.Focus();				
			}
		}
       }

    if(Caption1.Variable[0] == "UNITALMSUMM")
       {
        Caption1.Caption = "SELECT UNIT";
        Caption1.ForegroundColor = Color.Lime;
	
        object obj = Area.GetControlObj("TB");
		if(obj != null)
		{
			TextBox TB = (TextBox)obj; 
			if(TB != null)
			{
				TB.Visible = true;
				TB.Enabled = true;
				TB.Text = "";
				TB.Focus();				
			}
		}
       }

    if(Caption1.Variable[0] == "PENTER")
       {
         Caption1.Caption = "PRESS ENTER TO EXECUTE";	
         Caption1.ForegroundColor = Color.Yellow;
         object obj = Area.GetControlObj("TB");
		if(obj != null)
		{
			TextBox TB = (TextBox)obj; 
			if(TB != null)
			{
	                    TB.Visible = false;
	                    TB.Enabled = false;
                         }
                }				
       }

    if(Caption1.Variable[0] == "NULL")
       {
         Caption1.Caption = "";					
       }

    if(Caption1.Variable[0] != Caption1.Variable[1])
      
      {
           Caption1.Variable[1] = Caption1.Variable[0];

       }

    CommonFunction._ProjectRelated.Var[0] = "";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void TDC3000_Top_Caption2_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText Caption2 = (DrawText)dynArgs.sender;
 
    Caption2.Caption = "";
    Caption2.ForegroundColor = Color.Red;
    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void TDC3000_Top_Caption2_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText Caption2 = (DrawText)dynArgs.sender; 
   
    Caption2.Variable[0] = CommonFunction._ProjectRelated.Var[1];
  
    if(Caption2.Variable[0] == "MODE ERROR")

       {
           Caption2.Caption = "MODE ERROR";	
       }

    if(Caption2.Variable[0] == "NOT EMULATION")

       {
           Caption2.Caption = "NOT EMULATION";	
       }

    if(Caption2.Variable[0] == "LMT")

       {
           Caption2.Caption = "LMT OR RANGE ERROR";	
       }

    if(Caption2.Variable[0] == "NULL")

       {
           Caption2.Caption = "";	
       }

    CommonFunction._ProjectRelated.Var[1] = "";  

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void TDC3000_Top_Text2_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText Text2 = (DrawText)dynArgs.sender; 
   
    DateTime now = DateTime.Now;
    Text2.Caption = now.Day.ToString() + "  " + now.Month.ToString() + "  " + "20" + now.ToString("yy") +  "  " + now.ToString("HH") + ":" +     now.ToString("mm")+ ":" +  now.ToString("ss");

    return; 
}
//Do not remove or update this comment
//Event Delegate:KeyEventHandler 
//Event Handler:KeyUp 
public void TDC3000_Top_TB_KeyUp(Object sender, KeyEventArgs e)
{
   TextBox TB = (TextBox)sender; 

     DrawArea Area = CommonFunction.GetThisDrawArea(TB);
     DrawText Caption1 = (DrawText)Area.GetDrawObj("Caption1");
     DrawText Caption2 = (DrawText)Area.GetDrawObj("Caption2");

	switch ( e.KeyData )
	{
	case Keys.Enter:

		if(TB.Text == "" || TB.Text == null)

		{
                       if(Caption1.Caption == "ENTER SCHEMATIC NAME")

                           {
                              Caption2.Caption = "INVALID";
                           }

                        if(Caption1.Caption == "ENTER GROUP NUMBER")

                           {
                              Caption2.Caption = "INVALID INPUT";
                           }
			
                        if(Caption1.Caption == "ENTER TAG NAME")

                           {
                               Caption2.Caption = "INVALID";                                 
                           }
		}

		else

		{
                        if(Caption1.Caption == "ENTER SCHEMATIC NAME")

                           {
                              string Input = TB.Text;
                              int nLeft = 0;
	                      int nTop = 0;
	                      string[] strVariable = new string[1];
	                      strVariable[0] = "";
	                      bool t = CommonFunction.OpenPicture(Input + ".grf", nTop, nLeft, strVariable);
                              if(t == true)
                                  {
	                               CommonFunction.OpenPicture(Input + ".grf", nTop, nLeft, strVariable);
                                       Caption1.Caption = "";
			               Caption2.Caption = "";
			               TB.Visible = false;
			               TB.Enabled = false;
                                   }
                              else
                                  {
	                               Caption2.Caption = "INVALID";
                                   }                            
                       

                           }

                        if(Caption1.Caption == "ENTER GROUP NUMBER")

                           {
                              string Input = TB.Text;
                              int nLeft = 0;
	                      int nTop = 0;
	                      string[] strVariable = new string[1];
	                      strVariable[0] = TB.Text;
                              bool g = CommonFunction.OpenPicture("GROUP.grf", nTop, nLeft, strVariable);
                              if(g == true)

                                  { 
	                               CommonFunction.OpenPicture("GROUP.grf", nTop, nLeft, strVariable);
                                       Caption1.Caption = "";
			               Caption2.Caption = "";
			               TB.Visible = false;
			               TB.Enabled = false;
                                  }   

                              else 

                                  {
	                               Caption2.Caption = "INVALID";
                                  }                            
                           }
			
                        if(Caption1.Caption == "ENTER TAG NAME")

                           {
                              string Input = TB.Text;
                              bool dt = CommonFunction.OpenDetail(Input);
                              if(dt == true)

                                  { 
                                       CommonFunction.OpenDetail(Input);
                                       Caption1.Caption = "";
			               Caption2.Caption = "";
			               TB.Visible = false;
			               TB.Enabled = false;
                                  }

                              else 

                                  {
	                               Caption2.Caption = "INVALID";
                                  }  
                             
                           }

                        if(Caption1.Caption == "PRESS ENTER TO EXECUTE")

                           {
                                       Caption1.Caption = "PRESS ENTER TO EXECUTE";
			               Caption2.Caption = "";                             
                           }

                        TB.ForeColor = Color.Lime;
                        return;
		}

		break;
	}



    return; 
}


}
