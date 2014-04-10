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
public class PIC_TDC3000_PMDIGCOM_Detail1:IDynCodeAttachDetach
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
_EventHandler= (EventHandler)PIC_TDC3000_PMDIGCOM_Detail1_OnDynInitialize;
CodeDomCommon.AttachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PIC_TDC3000_PMDIGCOM_Detail1_OnDynAnimation;
CodeDomCommon.AttachAreaEventHandler(area,strEventName,_EventHandler);
strObjectName = "PAGE";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PAGE_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PAGE";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PAGE_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVNORMAL_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVNORMAL_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PV_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PV_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DO1_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DO1_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DO3_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DO3_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DO2_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DO2_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "ALMOPT_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)ALMOPT_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "EVTOPT_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)EVTOPT_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DITYPE_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DITYPE_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "ALPRIOR_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)ALPRIOR_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "INPTDIR_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)INPTDIR_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVSRCOPT_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVSRCOPT_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVSOURCE_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVSOURCE_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "NOSTATES_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)NOSTATES_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TagComment";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)TagComment_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Tag";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Tag_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Tag";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Tag_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "ALMOPT";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)ALMOPT_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "ALMOPT";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)ALMOPT_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "EVTOPT";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)EVTOPT_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "EVTOPT";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)EVTOPT_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DITYPE";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DITYPE_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DITYPE";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DITYPE_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "ALPRIOR";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)ALPRIOR_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "ALPRIOR";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)ALPRIOR_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "INPTDIR";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)INPTDIR_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "INPTDIR";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)INPTDIR_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVSRCOPT";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVSRCOPT_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVSRCOPT";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVSRCOPT_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Detail_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail.Rect_PVON";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Detail_Rect_PVON_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail.OP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Detail_OP_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail.Rect_OFF";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Detail_Rect_OFF_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail.Rect_ON";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Detail_Rect_ON_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail.Unit";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Detail_Unit_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail.TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Detail_TagName_OnDynAnimation;
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
strObjectName = "Detail_PAGE.Rect1_FIRST";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Detail_PAGE_Rect1_FIRST_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail_POINTDATA";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)Detail_POINTDATA_KeyUp;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "Detail_POINTDATA";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Detail_POINTDATA_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail_POINTDATA";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Detail_POINTDATA_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail_POINTDATA.ENTER";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Detail_POINTDATA_ENTER_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail_POINTDATA.D5";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Detail_POINTDATA_D5_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail_POINTDATA.D5";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Detail_POINTDATA_D5_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail_POINTDATA.D4";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Detail_POINTDATA_D4_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail_POINTDATA.D4";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Detail_POINTDATA_D4_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail_POINTDATA.D3";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Detail_POINTDATA_D3_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail_POINTDATA.D3";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Detail_POINTDATA_D3_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail_POINTDATA.Rect3";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Detail_POINTDATA_Rect3_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail_POINTDATA.Rect3";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Detail_POINTDATA_Rect3_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail_POINTDATA.Rect2";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Detail_POINTDATA_Rect2_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail_POINTDATA.Rect2";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Detail_POINTDATA_Rect2_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail_POINTDATA.Rect1";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Detail_POINTDATA_Rect1_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail_POINTDATA.Rect1";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Detail_POINTDATA_Rect1_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail_POINTDATA.D2";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Detail_POINTDATA_D2_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail_POINTDATA.D2";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Detail_POINTDATA_D2_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail_POINTDATA.D1";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Detail_POINTDATA_D1_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail_POINTDATA.D1";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Detail_POINTDATA_D1_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail_POINTDATA.NAME";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Detail_POINTDATA_NAME_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
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
_EventHandler= (EventHandler)PIC_TDC3000_PMDIGCOM_Detail1_OnDynInitialize;
CodeDomCommon.DetachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PIC_TDC3000_PMDIGCOM_Detail1_OnDynAnimation;
CodeDomCommon.DetachAreaEventHandler(area,strEventName,_EventHandler);
strObjectName = "PAGE";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PAGE_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PAGE";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PAGE_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVNORMAL_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVNORMAL_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PV_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PV_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DO1_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DO1_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DO3_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DO3_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DO2_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DO2_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "ALMOPT_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)ALMOPT_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "EVTOPT_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)EVTOPT_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DITYPE_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DITYPE_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "ALPRIOR_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)ALPRIOR_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "INPTDIR_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)INPTDIR_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVSRCOPT_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVSRCOPT_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVSOURCE_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVSOURCE_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "NOSTATES_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)NOSTATES_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TagComment";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)TagComment_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Tag";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Tag_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Tag";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Tag_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "ALMOPT";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)ALMOPT_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "ALMOPT";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)ALMOPT_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "EVTOPT";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)EVTOPT_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "EVTOPT";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)EVTOPT_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DITYPE";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DITYPE_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DITYPE";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DITYPE_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "ALPRIOR";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)ALPRIOR_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "ALPRIOR";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)ALPRIOR_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "INPTDIR";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)INPTDIR_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "INPTDIR";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)INPTDIR_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVSRCOPT";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVSRCOPT_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVSRCOPT";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVSRCOPT_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Detail_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail.Rect_PVON";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Detail_Rect_PVON_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail.OP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Detail_OP_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail.Rect_OFF";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Detail_Rect_OFF_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail.Rect_ON";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Detail_Rect_ON_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail.Unit";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Detail_Unit_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail.TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Detail_TagName_OnDynAnimation;
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
strObjectName = "Detail_PAGE.Rect1_FIRST";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Detail_PAGE_Rect1_FIRST_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail_POINTDATA";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)Detail_POINTDATA_KeyUp;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "Detail_POINTDATA";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Detail_POINTDATA_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail_POINTDATA";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Detail_POINTDATA_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail_POINTDATA.ENTER";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Detail_POINTDATA_ENTER_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail_POINTDATA.D5";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Detail_POINTDATA_D5_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail_POINTDATA.D5";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Detail_POINTDATA_D5_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail_POINTDATA.D4";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Detail_POINTDATA_D4_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail_POINTDATA.D4";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Detail_POINTDATA_D4_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail_POINTDATA.D3";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Detail_POINTDATA_D3_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail_POINTDATA.D3";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Detail_POINTDATA_D3_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail_POINTDATA.Rect3";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Detail_POINTDATA_Rect3_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail_POINTDATA.Rect3";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Detail_POINTDATA_Rect3_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail_POINTDATA.Rect2";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Detail_POINTDATA_Rect2_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail_POINTDATA.Rect2";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Detail_POINTDATA_Rect2_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail_POINTDATA.Rect1";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Detail_POINTDATA_Rect1_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail_POINTDATA.Rect1";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Detail_POINTDATA_Rect1_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail_POINTDATA.D2";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Detail_POINTDATA_D2_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail_POINTDATA.D2";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Detail_POINTDATA_D2_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail_POINTDATA.D1";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Detail_POINTDATA_D1_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail_POINTDATA.D1";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Detail_POINTDATA_D1_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail_POINTDATA.NAME";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Detail_POINTDATA_NAME_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
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
public void PIC_TDC3000_PMDIGCOM_Detail1_OnDynInitialize(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 
 
   DrawArea D = (DrawArea)(Area.GetDrawObj("Detail_POINTDATA"));
   D.Visible = false;

   DrawArea G = (DrawArea)(Area.GetDrawObj("Detail_PAGE"));
   G.Visible = false;
 
////////////////////////////////////////////////////////////////////////////////处理变色
////////////////////////////////////////////////////////////////////////////////处理变色

	DrawText NOSTATES = (DrawText)Area.GetDrawObj("NOSTATES");
	DrawText PVSOURCE = (DrawText)Area.GetDrawObj("PVSOURCE");
	DrawText PVNORMAL = (DrawText)Area.GetDrawObj("PVNORMAL");

	DrawText PV = (DrawText)Area.GetDrawObj("PV");
	DrawText DO2 = (DrawText)Area.GetDrawObj("DO2");
	DrawText DO1 = (DrawText)Area.GetDrawObj("DO1");
	DrawText DO3 = (DrawText)Area.GetDrawObj("DO3");

	DrawText ALPRIOR = (DrawText)Area.GetDrawObj("ALPRIOR");
	DrawText PVSRCOPT = (DrawText)Area.GetDrawObj("PVSRCOPT");
	DrawText INPTDIR = (DrawText)Area.GetDrawObj("INPTDIR");
	DrawText DITYPE = (DrawText)Area.GetDrawObj("DITYPE");
	DrawText EVTOPT = (DrawText)Area.GetDrawObj("EVTOPT");
	DrawText ALMOPT = (DrawText)Area.GetDrawObj("ALMOPT");

	DrawText PAGE = (DrawText)Area.GetDrawObj("PAGE");

	NOSTATES.ForegroundColor = Color.Cyan;
	PVSOURCE.ForegroundColor = Color.Cyan;
	PVNORMAL.ForegroundColor = Color.Cyan;
	PV.ForegroundColor = Color.Cyan;
	DO2.ForegroundColor = Color.Cyan;
	DO1.ForegroundColor = Color.Cyan;
	DO3.ForegroundColor = Color.Cyan;

	ALPRIOR.ForegroundColor = Color.Lime;
	PVSRCOPT.ForegroundColor = Color.Lime;
	INPTDIR.ForegroundColor = Color.Lime;
	DITYPE.ForegroundColor = Color.Lime;
	EVTOPT.ForegroundColor = Color.Lime;
	ALMOPT.ForegroundColor = Color.Lime;

	PAGE.ForegroundColor = Color.Lime;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void PIC_TDC3000_PMDIGCOM_Detail1_OnDynAnimation(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 

   DrawArea D = (DrawArea)(Area.GetDrawObj("Detail_POINTDATA"));
   DrawArea G = (DrawArea)(Area.GetDrawObj("Detail_PAGE"));

   if(G.Visible == true)
      {
         D.Visible = false;
       }
   if(D.Visible == true)
      {
         G.Visible = false;
       }

////////////////////////////////////////////////////////////////////////////////处理变色
////////////////////////////////////////////////////////////////////////////////处理变色


	DrawText NOSTATES = (DrawText)Area.GetDrawObj("NOSTATES");
	DrawText PVSOURCE = (DrawText)Area.GetDrawObj("PVSOURCE");
	DrawText PVNORMAL = (DrawText)Area.GetDrawObj("PVNORMAL");

	DrawText PV = (DrawText)Area.GetDrawObj("PV");
	DrawText DO2 = (DrawText)Area.GetDrawObj("DO2");
	DrawText DO1 = (DrawText)Area.GetDrawObj("DO1");
	DrawText DO3 = (DrawText)Area.GetDrawObj("DO3");

	DrawText ALPRIOR = (DrawText)Area.GetDrawObj("ALPRIOR");
	DrawText PVSRCOPT = (DrawText)Area.GetDrawObj("PVSRCOPT");
	DrawText INPTDIR = (DrawText)Area.GetDrawObj("INPTDIR");
	DrawText DITYPE = (DrawText)Area.GetDrawObj("DITYPE");
	DrawText EVTOPT = (DrawText)Area.GetDrawObj("EVTOPT");
	DrawText ALMOPT = (DrawText)Area.GetDrawObj("ALMOPT");

	DrawText NOSTATES_Value = (DrawText)Area.GetDrawObj("NOSTATES_Value");
	DrawText PVSOURCE_Value = (DrawText)Area.GetDrawObj("PVSOURCE_Value");
	DrawText PVNORMAL_Value = (DrawText)Area.GetDrawObj("PVNORMAL_Value");

	DrawText PV_Value = (DrawText)Area.GetDrawObj("PV_Value");
	DrawText DO2_Value = (DrawText)Area.GetDrawObj("DO2_Value");
	DrawText DO1_Value = (DrawText)Area.GetDrawObj("DO1_Value");
	DrawText DO3_Value = (DrawText)Area.GetDrawObj("DO3_Value");

	DrawText ALPRIOR_Value = (DrawText)Area.GetDrawObj("ALPRIOR_Value");
	DrawText PVSRCOPT_Value = (DrawText)Area.GetDrawObj("PVSRCOPT_Value");
	DrawText INPTDIR_Value = (DrawText)Area.GetDrawObj("INPTDIR_Value");
	DrawText DITYPE_Value = (DrawText)Area.GetDrawObj("DITYPE_Value");
	DrawText EVTOPT_Value = (DrawText)Area.GetDrawObj("EVTOPT_Value");
	DrawText ALMOPT_Value = (DrawText)Area.GetDrawObj("ALMOPT_Value");

	DrawText PAGE = (DrawText)Area.GetDrawObj("PAGE");

	NOSTATES.ForegroundColor = Color.Cyan;
	PVSOURCE.ForegroundColor = Color.Cyan;
	PVNORMAL.ForegroundColor = Color.Cyan;
	PV.ForegroundColor = Color.Cyan;
	DO2.ForegroundColor = Color.Cyan;
	DO1.ForegroundColor = Color.Cyan;
	DO3.ForegroundColor = Color.Cyan;

	ALPRIOR.ForegroundColor = Color.Lime;
	PVSRCOPT.ForegroundColor = Color.Lime;
	INPTDIR.ForegroundColor = Color.Lime;
	DITYPE.ForegroundColor = Color.Lime;
	EVTOPT.ForegroundColor = Color.Lime;
	ALMOPT.ForegroundColor = Color.Lime;

	NOSTATES_Value.ForegroundColor = Color.Cyan;
	PVSOURCE_Value.ForegroundColor = Color.Cyan;
	PVNORMAL_Value.ForegroundColor = Color.Cyan;
	PV_Value.ForegroundColor = Color.Cyan;
	DO2_Value.ForegroundColor = Color.Cyan;
	DO1_Value.ForegroundColor = Color.Cyan;
	DO3_Value.ForegroundColor = Color.Cyan;

	ALPRIOR_Value.ForegroundColor = Color.Lime;
	PVSRCOPT_Value.ForegroundColor = Color.Lime;
	INPTDIR_Value.ForegroundColor = Color.Lime;
	DITYPE_Value.ForegroundColor = Color.Lime;
	EVTOPT_Value.ForegroundColor = Color.Lime;
	ALMOPT_Value.ForegroundColor = Color.Lime;

	PAGE.ForegroundColor = Color.Lime;


        if(Area.Variable[1] == "1")
	    {
               ALPRIOR.ForegroundColor = Color.White;
               ALPRIOR_Value.ForegroundColor = Color.White;
            }
        if(Area.Variable[1] == "2")
	    {
               PVSRCOPT.ForegroundColor = Color.White;
               PVSRCOPT_Value.ForegroundColor = Color.White;
            }

        if(Area.Variable[1] == "3")
	    {
               INPTDIR.ForegroundColor = Color.White;
               INPTDIR_Value.ForegroundColor = Color.White;
            }
        if(Area.Variable[1] == "4")
	    {
               DITYPE.ForegroundColor = Color.White;
               DITYPE_Value.ForegroundColor = Color.White;
            }
        if(Area.Variable[1] == "5")
	    {
               EVTOPT.ForegroundColor = Color.White;
               EVTOPT_Value.ForegroundColor = Color.White;
            }
        if(Area.Variable[1] == "6")
	    {
               ALMOPT.ForegroundColor = Color.White;
               ALMOPT_Value.ForegroundColor = Color.White;
            }
        if(Area.Variable[1] == "7")
	    {
               PAGE.ForegroundColor = Color.White;
            }
 
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void PAGE_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PAGE = (DrawText)dynArgs.sender; 

    DrawArea P = (DrawArea)Area.GetDrawObj("Detail_POINTDATA");
    P.Visible = false;
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_PAGE");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "1";//设置标志位变色

    Area.Variable[1] = "7";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void PAGE_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PAGE = (DrawText)dynArgs.sender; 

    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_PAGE");
    if(L.Visible == false)
       {
             PAGE.ForegroundColor = Color.Lime;
       }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void PVNORMAL_Value_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVNORMAL_Value = (DrawText)dynArgs.sender; 
   
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
	
	tagName = Area.Variable[0] + "/PVNORMAL";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		PVNORMAL_Value.Caption = dbValue.ToString(strDigit);
	}
	else
		PVNORMAL_Value.Caption = "------";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void PV_Value_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PV_Value = (DrawText)dynArgs.sender; 
   
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
	
	tagName = Area.Variable[0] + "/PV";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		PV_Value.Caption = dbValue.ToString(strDigit);
	}
	else
		PV_Value.Caption = "------";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void DO1_Value_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText DO1_Value = (DrawText)dynArgs.sender; 
   
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
	
	tagName = Area.Variable[0] + "/DO1";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		DO1_Value.Caption = dbValue.ToString(strDigit);
	}
	else
		DO1_Value.Caption = "------";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void DO3_Value_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText DO3_Value = (DrawText)dynArgs.sender; 
   
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
	
	tagName = Area.Variable[0] + "/DO3";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		DO3_Value.Caption = dbValue.ToString(strDigit);
	}
	else
		DO3_Value.Caption = "------";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void DO2_Value_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText DO2_Value = (DrawText)dynArgs.sender; 
   
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
	
	tagName = Area.Variable[0] + "/DO2";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		DO2_Value.Caption = dbValue.ToString(strDigit);
	}
	else
		DO2_Value.Caption = "------";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void ALMOPT_Value_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText ALMOPT_Value = (DrawText)dynArgs.sender; 
   
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
	
	tagName = Area.Variable[0] + "/ALMOPT";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		ALMOPT_Value.Caption = dbValue.ToString(strDigit);
	}
	else
		ALMOPT_Value.Caption = "------";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void EVTOPT_Value_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText EVTOPT_Value = (DrawText)dynArgs.sender; 
   
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
	
	tagName = Area.Variable[0] + "/EVTOPT";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		EVTOPT_Value.Caption = dbValue.ToString(strDigit);
	}
	else
		EVTOPT_Value.Caption = "------";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void DITYPE_Value_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText DITYPE_Value = (DrawText)dynArgs.sender; 
   
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
	
	tagName = Area.Variable[0] + "/DITYPE";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		DITYPE_Value.Caption = dbValue.ToString(strDigit);
	}
	else
		DITYPE_Value.Caption = "------";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void ALPRIOR_Value_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText ALPRIOR_Value = (DrawText)dynArgs.sender; 
   
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
	
	tagName = Area.Variable[0] + "/ALPRIOR";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		ALPRIOR_Value.Caption = dbValue.ToString(strDigit);
	}
	else
		ALPRIOR_Value.Caption = "------";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void INPTDIR_Value_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText INPTDIR_Value = (DrawText)dynArgs.sender; 
   
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
	
	tagName = Area.Variable[0] + "/INPTDIR";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		INPTDIR_Value.Caption = dbValue.ToString(strDigit);
	}
	else
		INPTDIR_Value.Caption = "------";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void PVSRCOPT_Value_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVSRCOPT_Value = (DrawText)dynArgs.sender; 
   
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
	
	tagName = Area.Variable[0] + "/PVSRCOPT";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		PVSRCOPT_Value.Caption = dbValue.ToString(strDigit);
	}
	else
		PVSRCOPT_Value.Caption = "------";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void PVSOURCE_Value_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVSOURCE_Value = (DrawText)dynArgs.sender; 
   
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
	
	tagName = Area.Variable[0] + "/PVSOURCE";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
            if(dbValue == 0.00)

                {PVSOURCE_Value.Caption = "MAN";}

            if(dbValue == 1.00)

                {PVSOURCE_Value.Caption = "AUTO";}

            if(dbValue == 2.00)

                {PVSOURCE_Value.Caption = "SUB";}

            if(dbValue == 3.00)

                {PVSOURCE_Value.Caption = "TRACK";}

	}
	else
		PVSOURCE_Value.Caption = "------";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void NOSTATES_Value_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText NOSTATES_Value = (DrawText)dynArgs.sender; 
   
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
	
	tagName = Area.Variable[0] + "/NOSTATES";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		NOSTATES_Value.Caption = dbValue.ToString(strDigit);
	}
	else
		NOSTATES_Value.Caption = "------";

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
//Event Handler:OnDynClick 
public void ALMOPT_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText ALMOPT = (DrawText)dynArgs.sender; 

    DrawArea P = (DrawArea)Area.GetDrawObj("Detail_PAGE");
    P.Visible = false;  
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_POINTDATA");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "ALMOPT";

    L.Variable[3] = "NONE";
    L.Variable[4] = "OFFNORML";
    L.Variable[5] = "N";
    L.Variable[6] = "N";
    L.Variable[7] = "N";

    L.Variable[8] = "0";
    L.Variable[9] = "1";
    L.Variable[10] = "2";
    L.Variable[11] = "3";
    L.Variable[12] = "4";
   
    ALMOPT.ForegroundColor = Color.White;
    DrawText ALMOPT_Value = (DrawText)Area.GetDrawObj("ALMOPT_Value");
    ALMOPT_Value.ForegroundColor = Color.White;

    Area.Variable[1] = "6";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void ALMOPT_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText ALMOPT = (DrawText)dynArgs.sender; 

    DrawText ALMOPT_Value = (DrawText)Area.GetDrawObj("ALMOPT_Value");   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_POINTDATA");
    if(L.Visible == false)
       {
             ALMOPT.ForegroundColor = Color.Lime;
             ALMOPT_Value.ForegroundColor = Color.Lime;
       }
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void EVTOPT_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText EVTOPT = (DrawText)dynArgs.sender; 
 
    DrawArea P = (DrawArea)Area.GetDrawObj("Detail_PAGE");
    P.Visible = false;  
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_POINTDATA");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "EVTOPT";

    L.Variable[3] = "NONE";
    L.Variable[4] = "EIP";
    L.Variable[5] = "EIP_SOE";
    L.Variable[6] = "SOE";
    L.Variable[7] = "N";

    L.Variable[8] = "0";
    L.Variable[9] = "1";
    L.Variable[10] = "2";
    L.Variable[11] = "3";
    L.Variable[12] = "4";
   
    EVTOPT.ForegroundColor = Color.White;
    DrawText EVTOPT_Value = (DrawText)Area.GetDrawObj("EVTOPT_Value");
    EVTOPT_Value.ForegroundColor = Color.White;

    Area.Variable[1] = "5";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void EVTOPT_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText EVTOPT = (DrawText)dynArgs.sender; 

    DrawText EVTOPT_Value = (DrawText)Area.GetDrawObj("EVTOPT_Value");   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_POINTDATA");
    if(L.Visible == false)
       {
             EVTOPT.ForegroundColor = Color.Lime;
             EVTOPT_Value.ForegroundColor = Color.Lime;
       }
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void DITYPE_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText DITYPE = (DrawText)dynArgs.sender; 

    DrawArea P = (DrawArea)Area.GetDrawObj("Detail_PAGE");
    P.Visible = false;  
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_POINTDATA");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "DITYPE";

    L.Variable[3] = "N";
    L.Variable[4] = "N";
    L.Variable[5] = "N";
    L.Variable[6] = "N";
    L.Variable[7] = "N";

    L.Variable[8] = "0";
    L.Variable[9] = "1";
    L.Variable[10] = "2";
    L.Variable[11] = "3";
    L.Variable[12] = "4";
   
    DITYPE.ForegroundColor = Color.White;
    DrawText DITYPE_Value = (DrawText)Area.GetDrawObj("DITYPE_Value");
    DITYPE_Value.ForegroundColor = Color.White;

    Area.Variable[1] = "4";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void DITYPE_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText DITYPE = (DrawText)dynArgs.sender; 

    DrawText DITYPE_Value = (DrawText)Area.GetDrawObj("DITYPE_Value");   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_POINTDATA");
    if(L.Visible == false)
       {
             DITYPE.ForegroundColor = Color.Lime;
             DITYPE_Value.ForegroundColor = Color.Lime;
       }
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void ALPRIOR_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText ALPRIOR = (DrawText)dynArgs.sender; 

    DrawArea P = (DrawArea)Area.GetDrawObj("Detail_PAGE");
    P.Visible = false;  
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_POINTDATA");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "ALPRIOR";

    L.Variable[3] = "NOACTION";
    L.Variable[4] = "JOURNAL";
    L.Variable[5] = "LOW";
    L.Variable[6] = "HIGH";
    L.Variable[7] = "EMERGENCY";

    L.Variable[8] = "0";
    L.Variable[9] = "1";
    L.Variable[10] = "2";
    L.Variable[11] = "3";
    L.Variable[12] = "4";
   
    ALPRIOR.ForegroundColor = Color.White;
    DrawText ALPRIOR_Value = (DrawText)Area.GetDrawObj("ALPRIOR_Value");
    ALPRIOR_Value.ForegroundColor = Color.White;

    Area.Variable[1] = "1";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void ALPRIOR_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText ALPRIOR = (DrawText)dynArgs.sender; 

    DrawText ALPRIOR_Value = (DrawText)Area.GetDrawObj("ALPRIOR_Value");   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_POINTDATA");
    if(L.Visible == false)
       {
             ALPRIOR.ForegroundColor = Color.Lime;
             ALPRIOR_Value.ForegroundColor = Color.Lime;
       }
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void INPTDIR_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText INPTDIR = (DrawText)dynArgs.sender; 

    DrawArea P = (DrawArea)Area.GetDrawObj("Detail_PAGE");
    P.Visible = false;  
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_POINTDATA");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "INPTDIR";

    L.Variable[3] = "DIRECT";
    L.Variable[4] = "REVERSE";
    L.Variable[5] = "N";
    L.Variable[6] = "N";
    L.Variable[7] = "N";

    L.Variable[8] = "0";
    L.Variable[9] = "1";
    L.Variable[10] = "2";
    L.Variable[11] = "3";
    L.Variable[12] = "4";
   
    INPTDIR.ForegroundColor = Color.White;
    DrawText INPTDIR_Value = (DrawText)Area.GetDrawObj("INPTDIR_Value");
    INPTDIR_Value.ForegroundColor = Color.White;

    Area.Variable[1] = "3";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void INPTDIR_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText INPTDIR = (DrawText)dynArgs.sender; 

    DrawText INPTDIR_Value = (DrawText)Area.GetDrawObj("INPTDIR_Value");   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_POINTDATA");
    if(L.Visible == false)
       {
             INPTDIR.ForegroundColor = Color.Lime;
             INPTDIR_Value.ForegroundColor = Color.Lime;
       }
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void PVSRCOPT_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVSRCOPT = (DrawText)dynArgs.sender; 
 
    DrawArea P = (DrawArea)Area.GetDrawObj("Detail_PAGE");
    P.Visible = false;  
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_POINTDATA");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "PVSRCOPT";

    L.Variable[3] = "ONLYAUTO";
    L.Variable[4] = "ALL";
    L.Variable[5] = "N";
    L.Variable[6] = "N";
    L.Variable[7] = "N";

    L.Variable[8] = "0";
    L.Variable[9] = "1";
    L.Variable[10] = "2";
    L.Variable[11] = "3";
    L.Variable[12] = "4";
   
    PVSRCOPT.ForegroundColor = Color.White;
    DrawText PVSRCOPT_Value = (DrawText)Area.GetDrawObj("PVSRCOPT_Value");
    PVSRCOPT_Value.ForegroundColor = Color.White;

    Area.Variable[1] = "2";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void PVSRCOPT_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVSRCOPT = (DrawText)dynArgs.sender; 

    DrawText PVSRCOPT_Value = (DrawText)Area.GetDrawObj("PVSRCOPT_Value");   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_POINTDATA");
    if(L.Visible == false)
       {
             PVSRCOPT.ForegroundColor = Color.Lime;
             PVSRCOPT_Value.ForegroundColor = Color.Lime;
       }
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void Detail_OnDynInitialize(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 
 
	Picture pic = CommonFunction.GetThisPicture(Area);
	if(pic != null)
	{  
	   if(Area.BReference)//图素
		{
		        DrawArea MainArea = pic.GetDrawArea();
			Area.Variable[0] = MainArea.Variable[0];
			ControlLabel lab = (ControlLabel)CommonFunction.GetLabelOfControl(Area);
			lab.Selected = false;
			
		}
		else
		{
			pic.Text = Area.Variable[0];
		}

	}

   if(Area.BReference)
	{
		Area.Enabled = true;
        }	

    return; 
}



//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void Detail_Rect_PVON_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect_PVON = (DrawRectangle)dynArgs.sender; 
  
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
	
	tagName = Area.Variable[0] + "/PV";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
              if(dbValue == 1.00)

		{Rect_PVON.ForegroundColor = Color.Yellow;}

              else if(dbValue == 0.00)

		{Rect_PVON.ForegroundColor = Color.Black;}
	}
	else
		Rect_PVON.ForegroundColor = Color.Black;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void Detail_OP_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText OP = (DrawText)dynArgs.sender; 
  
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
              if(dbValue == 1.00)

		{OP.Caption = "ON";}

              else if(dbValue == 0.00)

		{OP.Caption = "OFF";}
	}
	else
		OP.Caption = "";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void Detail_Rect_OFF_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect_OFF = (DrawRectangle)dynArgs.sender; 
  
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
              if(dbValue == 0.00)

		{Rect_OFF.ForegroundColor = Color.Yellow;}

              else if(dbValue == 1.00)

		{Rect_OFF.ForegroundColor = Color.Black;}
	}
	else
		Rect_OFF.ForegroundColor = Color.Black;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void Detail_Rect_ON_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect_ON = (DrawRectangle)dynArgs.sender; 
  
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
              if(dbValue == 1.00)

		{Rect_ON.ForegroundColor = Color.Yellow;}

              else if(dbValue == 0.00)

		{Rect_ON.ForegroundColor = Color.Black;}
	}
	else
		Rect_ON.ForegroundColor = Color.Black;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void Detail_Unit_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText Unit = (DrawText)dynArgs.sender; 
   
    Unit.Caption = CommonFunction.GetPVUnit(Area.Variable[0]);

    return; 
}


//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void Detail_TagName_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText TagName = (DrawText)dynArgs.sender; 
   
    string tagName = Area.Variable[0].ToUpper();

	if(tagName != "")
		TagName.Caption = tagName;
	else
		TagName.Caption = "******";	

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
	DrawText CTLCONCT = (DrawText)Area.GetDrawObj("CTLCONCT");

	FIRST.ForegroundColor = Color.Lime;
	CTLCONCT.ForegroundColor = Color.Lime;


        if(Area.Variable[1] == "1")
	    {
               FIRST.ForegroundColor = Color.Cyan;
            }
        if(Area.Variable[1] == "2")
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
	string[] strVariable = new string[1];
	strVariable[0] = Area.Variable[0];
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
	CommonFunction.OpenPicture("TDC3000_PMDIGCOM_Detail2.grf", nTop, nLeft, strVariable);
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
	CommonFunction.OpenPicture("TDC3000_PMDIGCOM_Detail1.grf", nTop, nLeft, strVariable);

    Area.Visible = false;

    return; 
}
//Area.Variable[0]-TagName
//Area.Variable[1]-标题名
//Area.Variable[2]-选中变色置值标记
//Area.Variable[3]--Area.Variable[7]可选项的内容
//Area.Variable[8]--Area.Variable[12]可选项的数值

//Do not remove or update this comment
//Event Delegate:KeyEventHandler 
//Event Handler:KeyUp 
public void Detail_POINTDATA_KeyUp(Object sender, KeyEventArgs e)
{
   DrawArea Area = (DrawArea)sender; 

	DrawText D1 = (DrawText)Area.GetDrawObj("D1");
	DrawText D2 = (DrawText)Area.GetDrawObj("D2");
	DrawText D3 = (DrawText)Area.GetDrawObj("D3");
	DrawText D4 = (DrawText)Area.GetDrawObj("D4");
	DrawText D5 = (DrawText)Area.GetDrawObj("D5");
	DrawText NAME = (DrawText)Area.GetDrawObj("NAME");

    DrawRectangle Rect1 = (DrawRectangle)Area.GetDrawObj("Rect1");
    DrawRectangle Rect2 = (DrawRectangle)Area.GetDrawObj("Rect2");
    DrawRectangle Rect3 = (DrawRectangle)Area.GetDrawObj("Rect3");

   string tagName = Area.Variable[0] + "/" + Area.Variable[1];

     double dbValue = 0;
     int nValue = 0;
     bool bValue = false;
     int nDataType = 0;

     string Pam = Area.Variable[0] + "/" + Area.Variable[1];
     bool ret = CommonFunction.GetValueWithType(Pam,ref dbValue,ref nValue,ref bValue,ref nDataType);
     
     if(ret)
      
           {
		    switch(e.KeyData)
                      {    

                         case Keys.Enter:

                               if(Area.Variable[2] == "1")
	                        {		
                                   CommonFunction.DSI_SetValue(tagName, Convert.ToDouble(Area.Variable[8]));
	                        }
	                       if(Area.Variable[2] == "2")
	                        {
                                   CommonFunction.DSI_SetValue(tagName, Convert.ToDouble(Area.Variable[9]));
	                         }
	                       if(Area.Variable[2] == "3")
	                        {
                                   CommonFunction.DSI_SetValue(tagName, Convert.ToDouble(Area.Variable[10]));
	                        }
                               if(Area.Variable[2] == "4")
                                {
	                           CommonFunction.DSI_SetValue(tagName, Convert.ToDouble(Area.Variable[11]));
                                }
                               if(Area.Variable[2] == "5")
                                {
	                           CommonFunction.DSI_SetValue(tagName, Convert.ToDouble(Area.Variable[12]));
                                }

                          Area.Variable[2] = "0";
                          Area.Visible = false;

                          D1.Caption = "";
                          D2.Caption = "";
                          D3.Caption = "";
                          D4.Caption = "";
                          D5.Caption = "";
                          NAME.Caption = "";

                          Rect1.Visible = false;
                          Rect2.Visible = false;
                          Rect3.Visible = false;

	                 break;
                      }               
         }
             
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void Detail_POINTDATA_OnDynInitialize(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 
 
   if(Area.BReference)
     {
        Area.Enabled = true; 
     }  
    Area.Variable[2] = "0";
////////////////////////////////////////////////////////////////////////////////处理变色
////////////////////////////////////////////////////////////////////////////////处理变色

	DrawText D1 = (DrawText)Area.GetDrawObj("D1");
	DrawText D2 = (DrawText)Area.GetDrawObj("D2");
	DrawText D3 = (DrawText)Area.GetDrawObj("D3");
	DrawText D4 = (DrawText)Area.GetDrawObj("D4");
	DrawText D5 = (DrawText)Area.GetDrawObj("D5");

	D1.ForegroundColor = Color.Lime;
	D2.ForegroundColor = Color.Lime;
	D3.ForegroundColor = Color.Lime;
	D4.ForegroundColor = Color.Lime;
	D5.ForegroundColor = Color.Lime;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void Detail_POINTDATA_OnDynAnimation(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 

////////////////////////////////////////////////////////////////////////////////处理变色
////////////////////////////////////////////////////////////////////////////////处理变色

	DrawText D1 = (DrawText)Area.GetDrawObj("D1");
	DrawText D2 = (DrawText)Area.GetDrawObj("D2");
	DrawText D3 = (DrawText)Area.GetDrawObj("D3");
	DrawText D4 = (DrawText)Area.GetDrawObj("D4");
	DrawText D5 = (DrawText)Area.GetDrawObj("D5");

	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;
	string tagName = Area.Variable[0] + "/" + Area.Variable[1];
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);

if(ret)
   {		
     if(dbValue == Convert.ToDouble(Area.Variable[8]))
	 {
           if(Area.Variable[2] == "1")

		{ D1.ForegroundColor = Color.White;}

           else
              {
                  D1.ForegroundColor = Color.Cyan;

		 if(Area.Variable[2] == "2")
		 {
			 D2.ForegroundColor = Color.White;
		 }
		 else if(Area.Variable[2] == "3")
		 {
			 D3.ForegroundColor = Color.White;
		 }
		 else if(Area.Variable[2] == "4")
		 {
			 D4.ForegroundColor = Color.White;
		 }
		 else if(Area.Variable[2] == "5")
		 {
			 D5.ForegroundColor = Color.White;
		 }

              }
	 }
	 if(dbValue == Convert.ToDouble(Area.Variable[9]))
	 {
           if(Area.Variable[2] == "2")

		{ D2.ForegroundColor = Color.White;}

           else
              {
			 D2.ForegroundColor = Color.Cyan;

		 if(Area.Variable[2] == "1")
		 {
			 D1.ForegroundColor = Color.White;
		 }
		 else if(Area.Variable[2] == "3")
		 {
			 D3.ForegroundColor = Color.White;
		 }
		 else if(Area.Variable[2] == "4")
		 {
			 D4.ForegroundColor = Color.White;
		 }
		 else if(Area.Variable[2] == "5")
		 {
			 D5.ForegroundColor = Color.White;
		 }
               }
	 }
	 if(dbValue == Convert.ToDouble(Area.Variable[10]))
	 {
           if(Area.Variable[2] == "3")

		{ D3.ForegroundColor = Color.White;}

           else
              {
			 D3.ForegroundColor = Color.Cyan;

		 if(Area.Variable[2] == "2")
		 {
			 D2.ForegroundColor = Color.White;
		 }
		 else if(Area.Variable[2] == "1")
		 {
			 D1.ForegroundColor = Color.White;
		 }
		 else if(Area.Variable[2] == "4")
		 {
			 D4.ForegroundColor = Color.White;
		 }
		 else if(Area.Variable[2] == "5")
		 {
			 D5.ForegroundColor = Color.White;
		 }
               }
	 }
	 if(dbValue == Convert.ToDouble(Area.Variable[11]))
	 {
           if(Area.Variable[2] == "4")

		{ D4.ForegroundColor = Color.White;}

           else
              {
			 D4.ForegroundColor = Color.Cyan;

		 if(Area.Variable[2] == "2")
		 {
			 D2.ForegroundColor = Color.White;
		 }
		 else if(Area.Variable[2] == "1")
		 {
			 D1.ForegroundColor = Color.White;
		 }
		 else if(Area.Variable[2] == "3")
		 {
			 D3.ForegroundColor = Color.White;
		 }
		 else if(Area.Variable[2] == "5")
		 {
			 D5.ForegroundColor = Color.White;
		 }
               }
	 }
	 if(dbValue == Convert.ToDouble(Area.Variable[12]))
	 {
           if(Area.Variable[2] == "5")

		{ D5.ForegroundColor = Color.White;}

           else
              {
			 D5.ForegroundColor = Color.Cyan;

		 if(Area.Variable[2] == "2")
		 {
			 D2.ForegroundColor = Color.White;
		 }
		 else if(Area.Variable[2] == "1")
		 {
			 D1.ForegroundColor = Color.White;
		 }
		 else if(Area.Variable[2] == "4")
		 {
			 D4.ForegroundColor = Color.White;
		 }
		 else if(Area.Variable[2] == "3")
		 {
			 D3.ForegroundColor = Color.White;
		 }
              }
	 }
     }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void Detail_POINTDATA_ENTER_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle ENTER = (DrawRectangle)dynArgs.sender; 
   
   string tagName = Area.Variable[0] + "/" + Area.Variable[1];

     double dbValue = 0;
     int nValue = 0;
     bool bValue = false;
     int nDataType = 0;

     string Pam = Area.Variable[0] + "/" + Area.Variable[1];
     bool ret = CommonFunction.GetValueWithType(Pam,ref dbValue,ref nValue,ref bValue,ref nDataType);
     
     if(ret)
      
           {
               if(Area.Variable[2] == "1")
	          {		
                       CommonFunction.DSI_SetValue(tagName, Convert.ToDouble(Area.Variable[8]));
	          }
	       if(Area.Variable[2] == "2")
	          {
                       CommonFunction.DSI_SetValue(tagName, Convert.ToDouble(Area.Variable[9]));
	          }
	       if(Area.Variable[2] == "3")
	          {
                       CommonFunction.DSI_SetValue(tagName, Convert.ToDouble(Area.Variable[10]));
	          }
               if(Area.Variable[2] == "4")
                  {
	               CommonFunction.DSI_SetValue(tagName, Convert.ToDouble(Area.Variable[11]));
                  }
               if(Area.Variable[2] == "5")
                  {
	               CommonFunction.DSI_SetValue(tagName, Convert.ToDouble(Area.Variable[12]));
                  }

               Area.Variable[2] = "0";
               Area.Visible = false;
           }
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void Detail_POINTDATA_D5_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText D5 = (DrawText)dynArgs.sender; 
   
    Area.Variable[2] = "5";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void Detail_POINTDATA_D5_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText D5 = (DrawText)dynArgs.sender; 
   
    DrawRectangle Rect3 = (DrawRectangle)Area.GetDrawObj("Rect3");
        string tagName = Area.Variable[7].ToUpper();
	if(tagName != "N")
		D5.Caption = tagName;
	else
           {
		D5.Caption = "";
                Rect3.Visible = false;
            }

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void Detail_POINTDATA_D4_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText D4 = (DrawText)dynArgs.sender; 
   
    Area.Variable[2] = "4";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void Detail_POINTDATA_D4_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText D4 = (DrawText)dynArgs.sender; 
   
    DrawRectangle Rect2 = (DrawRectangle)Area.GetDrawObj("Rect2");
        string tagName = Area.Variable[6].ToUpper();
	if(tagName != "N")
		D4.Caption = tagName;
	else
           {
		D4.Caption = "";
                Rect2.Visible = false;
            }
    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void Detail_POINTDATA_D3_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText D3 = (DrawText)dynArgs.sender; 
   
    Area.Variable[2] = "3";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void Detail_POINTDATA_D3_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText D3 = (DrawText)dynArgs.sender; 
   
    DrawRectangle Rect1 = (DrawRectangle)Area.GetDrawObj("Rect1");
        string tagName = Area.Variable[5].ToUpper();
	if(tagName != "N")
		D3.Caption = tagName;
	else
           {
		D3.Caption = "";
                Rect1.Visible = false;
            }
    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void Detail_POINTDATA_Rect3_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect3 = (DrawRectangle)dynArgs.sender; 
   
    Rect3.Visible = false;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void Detail_POINTDATA_Rect3_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect3 = (DrawRectangle)dynArgs.sender; 
   
    DrawText D5 = (DrawText)Area.GetDrawObj("D5");
    if(D5.Caption == "" )
       {
            Rect3.Visible = false;
       }
    else
       {
            Rect3.Visible = true;
        }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void Detail_POINTDATA_Rect2_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect2 = (DrawRectangle)dynArgs.sender; 
   
    Rect2.Visible = false;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void Detail_POINTDATA_Rect2_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect2 = (DrawRectangle)dynArgs.sender; 
   
    DrawText D4 = (DrawText)Area.GetDrawObj("D4");
    if(D4.Caption == "" )
       {
            Rect2.Visible = false;
       }
    else
       {
            Rect2.Visible = true;
        }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void Detail_POINTDATA_Rect1_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect1 = (DrawRectangle)dynArgs.sender; 
   
    Rect1.Visible = false;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void Detail_POINTDATA_Rect1_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect1 = (DrawRectangle)dynArgs.sender; 
   
    DrawText D3 = (DrawText)Area.GetDrawObj("D3");
    if(D3.Caption == "" )
       {
            Rect1.Visible = false;
       }
    else
       {
            Rect1.Visible = true;
        }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void Detail_POINTDATA_D2_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText D2 = (DrawText)dynArgs.sender; 
   
    Area.Variable[2] = "2";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void Detail_POINTDATA_D2_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText D2 = (DrawText)dynArgs.sender; 
   
        string tagName = Area.Variable[4].ToUpper();
	if(tagName != "")
		D2.Caption = tagName;
	else
		D2.Caption = "";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void Detail_POINTDATA_D1_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText D1 = (DrawText)dynArgs.sender; 
   
    Area.Variable[2] = "1";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void Detail_POINTDATA_D1_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText D1 = (DrawText)dynArgs.sender; 
   
        string tagName = Area.Variable[3].ToUpper();
	if(tagName != "")
		D1.Caption = tagName;
	else
		D1.Caption = "";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void Detail_POINTDATA_NAME_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText NAME = (DrawText)dynArgs.sender; 
   
    string tagName = Area.Variable[1].ToUpper();

	if(tagName != "")
		NAME.Caption = tagName;
	else
		NAME.Caption = "******";	

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
