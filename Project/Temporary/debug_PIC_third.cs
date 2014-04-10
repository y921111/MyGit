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
public class PIC_third:IDynCodeAttachDetach
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
   strObjectName = "Rect6";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect6_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect4";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect4_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Text1";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Text1_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect2";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect2_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect1";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect1_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CZ_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CZ_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMDIGOUT";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CZ_PMDIGOUT_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMDIGOUT";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)CZ_PMDIGOUT_KeyUp;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "CZ.PMDIGOUT.Rect_Tag";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_PMDIGOUT_Rect_Tag_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMDIGOUT.ON";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CZ_PMDIGOUT_ON_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMDIGOUT.TagComment";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CZ_PMDIGOUT_TagComment_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMDIGOUT.TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CZ_PMDIGOUT_TagName_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMDIGOUT.Close";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_PMDIGOUT_Close_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMDIGOUT.Rect_ON";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CZ_PMDIGOUT_Rect_ON_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMDIGOUT.Rect_ON";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CZ_PMDIGOUT_Rect_ON_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMDIGOUT.Rect_OFF";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CZ_PMDIGOUT_Rect_OFF_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMDIGOUT.Rect_OFF";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CZ_PMDIGOUT_Rect_OFF_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMDIGCOM";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CZ_PMDIGCOM_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMDIGCOM";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CZ_PMDIGCOM_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMDIGCOM";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)CZ_PMDIGCOM_KeyUp;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "CZ.PMDIGCOM.Rect_Tag";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_PMDIGCOM_Rect_Tag_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMDIGCOM.Rect_ON";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_PMDIGCOM_Rect_ON_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMDIGCOM.Rect_OFF";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_PMDIGCOM_Rect_OFF_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMDIGCOM.Rect_SPACE";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_PMDIGCOM_Rect_SPACE_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMDIGCOM.TagComment";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CZ_PMDIGCOM_TagComment_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMDIGCOM.TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CZ_PMDIGCOM_TagName_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMDIGCOM.Close";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_PMDIGCOM_Close_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMANLIN";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CZ_PMANLIN_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMANLIN";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CZ_PMANLIN_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMANLIN";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_PMANLIN_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMANLIN";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)CZ_PMANLIN_KeyUp;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "CZ.PMANLIN.Rect_Tag";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_PMANLIN_Rect_Tag_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMANLIN.Rect_PVEUHI";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_PMANLIN_Rect_PVEUHI_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMANLIN.Rect_PVEULO";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_PMANLIN_Rect_PVEULO_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMANLIN.Rect_PV";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_PMANLIN_Rect_PV_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMANLIN.Text_PVEUHI";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CZ_PMANLIN_Text_PVEUHI_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMANLIN.Text_PVEULO";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CZ_PMANLIN_Text_PVEULO_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMANLIN.Text_PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CZ_PMANLIN_Text_PV_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMANLIN.PA_Rectangle";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_PMANLIN_PA_Rectangle_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMANLIN.PVEUHI";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CZ_PMANLIN_PVEUHI_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMANLIN.PVEUHI";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CZ_PMANLIN_PVEUHI_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMANLIN.PVEULO";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CZ_PMANLIN_PVEULO_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMANLIN.PVEULO";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CZ_PMANLIN_PVEULO_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMANLIN.PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CZ_PMANLIN_PV_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMANLIN.PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CZ_PMANLIN_PV_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMANLIN.TagComment";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CZ_PMANLIN_TagComment_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMANLIN.PVUnit";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CZ_PMANLIN_PVUnit_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMANLIN.TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CZ_PMANLIN_TagName_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMANLIN.Close";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_PMANLIN_Close_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMANLIN.TB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)CZ_PMANLIN_TB_KeyUp;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "CZ_PMPID";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CZ_PMPID_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CZ_PMPID_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_PMPID_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)CZ_PMPID_KeyUp;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "CZ.PMPID.Rect17";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_PMPID_Rect17_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMPID.Rect16";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_PMPID_Rect16_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMPID.Rect15";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_PMPID_Rect15_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMPID.Rect14";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_PMPID_Rect14_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMPID.Text_OP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CZ_PMPID_Text_OP_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMPID.Text_SP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CZ_PMPID_Text_SP_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMPID.Text_PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CZ_PMPID_Text_PV_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMPID.PA_Rectangle";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_PMPID_PA_Rectangle_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMPID.Rect_PROG";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_PMPID_Rect_PROG_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMPID.Rect_MAN";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_PMPID_Rect_MAN_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMPID.Rect_AUTO";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_PMPID_Rect_AUTO_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMPID.Rect_CAS";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_PMPID_Rect_CAS_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMPID.OP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CZ_PMPID_OP_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMPID.OP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CZ_PMPID_OP_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMPID.SP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CZ_PMPID_SP_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMPID.SP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CZ_PMPID_SP_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMPID.PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CZ_PMPID_PV_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMPID.PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CZ_PMPID_PV_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMPID.TagComment";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CZ_PMPID_TagComment_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMPID.PVUnit";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CZ_PMPID_PVUnit_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMPID.TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CZ_PMPID_TagName_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMPID.Close";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_PMPID_Close_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMPID.TB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)CZ_PMPID_TB_KeyUp;
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
strObjectName = "Rect6";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect6_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect4";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect4_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Text1";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Text1_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect2";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect2_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect1";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect1_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CZ_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CZ_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMDIGOUT";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CZ_PMDIGOUT_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMDIGOUT";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)CZ_PMDIGOUT_KeyUp;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "CZ.PMDIGOUT.Rect_Tag";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_PMDIGOUT_Rect_Tag_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMDIGOUT.ON";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CZ_PMDIGOUT_ON_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMDIGOUT.TagComment";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CZ_PMDIGOUT_TagComment_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMDIGOUT.TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CZ_PMDIGOUT_TagName_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMDIGOUT.Close";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_PMDIGOUT_Close_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMDIGOUT.Rect_ON";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CZ_PMDIGOUT_Rect_ON_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMDIGOUT.Rect_ON";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CZ_PMDIGOUT_Rect_ON_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMDIGOUT.Rect_OFF";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CZ_PMDIGOUT_Rect_OFF_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMDIGOUT.Rect_OFF";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CZ_PMDIGOUT_Rect_OFF_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMDIGCOM";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CZ_PMDIGCOM_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMDIGCOM";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CZ_PMDIGCOM_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMDIGCOM";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)CZ_PMDIGCOM_KeyUp;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "CZ.PMDIGCOM.Rect_Tag";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_PMDIGCOM_Rect_Tag_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMDIGCOM.Rect_ON";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_PMDIGCOM_Rect_ON_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMDIGCOM.Rect_OFF";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_PMDIGCOM_Rect_OFF_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMDIGCOM.Rect_SPACE";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_PMDIGCOM_Rect_SPACE_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMDIGCOM.TagComment";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CZ_PMDIGCOM_TagComment_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMDIGCOM.TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CZ_PMDIGCOM_TagName_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMDIGCOM.Close";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_PMDIGCOM_Close_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMANLIN";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CZ_PMANLIN_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMANLIN";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CZ_PMANLIN_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMANLIN";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_PMANLIN_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMANLIN";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)CZ_PMANLIN_KeyUp;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "CZ.PMANLIN.Rect_Tag";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_PMANLIN_Rect_Tag_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMANLIN.Rect_PVEUHI";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_PMANLIN_Rect_PVEUHI_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMANLIN.Rect_PVEULO";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_PMANLIN_Rect_PVEULO_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMANLIN.Rect_PV";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_PMANLIN_Rect_PV_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMANLIN.Text_PVEUHI";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CZ_PMANLIN_Text_PVEUHI_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMANLIN.Text_PVEULO";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CZ_PMANLIN_Text_PVEULO_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMANLIN.Text_PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CZ_PMANLIN_Text_PV_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMANLIN.PA_Rectangle";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_PMANLIN_PA_Rectangle_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMANLIN.PVEUHI";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CZ_PMANLIN_PVEUHI_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMANLIN.PVEUHI";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CZ_PMANLIN_PVEUHI_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMANLIN.PVEULO";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CZ_PMANLIN_PVEULO_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMANLIN.PVEULO";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CZ_PMANLIN_PVEULO_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMANLIN.PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CZ_PMANLIN_PV_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMANLIN.PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CZ_PMANLIN_PV_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMANLIN.TagComment";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CZ_PMANLIN_TagComment_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMANLIN.PVUnit";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CZ_PMANLIN_PVUnit_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMANLIN.TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CZ_PMANLIN_TagName_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMANLIN.Close";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_PMANLIN_Close_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMANLIN.TB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)CZ_PMANLIN_TB_KeyUp;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "CZ_PMPID";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CZ_PMPID_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CZ_PMPID_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_PMPID_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)CZ_PMPID_KeyUp;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "CZ.PMPID.Rect17";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_PMPID_Rect17_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMPID.Rect16";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_PMPID_Rect16_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMPID.Rect15";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_PMPID_Rect15_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMPID.Rect14";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_PMPID_Rect14_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMPID.Text_OP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CZ_PMPID_Text_OP_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMPID.Text_SP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CZ_PMPID_Text_SP_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMPID.Text_PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CZ_PMPID_Text_PV_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMPID.PA_Rectangle";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_PMPID_PA_Rectangle_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMPID.Rect_PROG";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_PMPID_Rect_PROG_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMPID.Rect_MAN";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_PMPID_Rect_MAN_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMPID.Rect_AUTO";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_PMPID_Rect_AUTO_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMPID.Rect_CAS";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_PMPID_Rect_CAS_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMPID.OP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CZ_PMPID_OP_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMPID.OP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CZ_PMPID_OP_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMPID.SP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CZ_PMPID_SP_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMPID.SP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CZ_PMPID_SP_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMPID.PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CZ_PMPID_PV_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMPID.PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CZ_PMPID_PV_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMPID.TagComment";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CZ_PMPID_TagComment_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMPID.PVUnit";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CZ_PMPID_PVUnit_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMPID.TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CZ_PMPID_TagName_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMPID.Close";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_PMPID_Close_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ.PMPID.TB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)CZ_PMPID_TB_KeyUp;
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
//Event Handler:OnDynClick 
public void Rect6_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect1 = (DrawRectangle)dynArgs.sender; 
   
        DrawArea CZ = (DrawArea)Area.GetDrawObj("CZ");
        CZ.Visible = true;
        CZ.Variable[0] = "HS501"; 
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void Rect4_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect1 = (DrawRectangle)dynArgs.sender; 
   
        DrawArea CZ = (DrawArea)Area.GetDrawObj("CZ");
        CZ.Visible = true;
        CZ.Variable[0] = "LIC103"; 
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void Text1_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText Text1 = (DrawText)dynArgs.sender; 
   
        DrawArea CZ = (DrawArea)Area.GetDrawObj("CZ");
        Text1.Caption = CZ.Variable[0]; 

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void Rect2_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect1 = (DrawRectangle)dynArgs.sender; 
   
        DrawArea CZ = (DrawArea)Area.GetDrawObj("CZ");
        CZ.Visible = false; 
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void Rect1_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect1 = (DrawRectangle)dynArgs.sender; 
   
        DrawArea CZ = (DrawArea)Area.GetDrawObj("CZ");
        CZ.Visible = true;
        CZ.Variable[0] = "TI143"; 
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void CZ_OnDynInitialize(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 

   Area.Enabled = true;
    if(Area.BReference)
      {Area.Enabled = true;}//使作为图素时可以使用

    DrawArea PMPID = (DrawArea)Area.GetDrawObj("PMPID");
    if(PMPID != null)
         {PMPID.Visible = false;}

    DrawArea PMANLIN = (DrawArea)Area.GetDrawObj("PMANLIN");
    if(PMANLIN != null)
         {PMANLIN.Visible = false;}

    DrawArea PMDIGCOM = (DrawArea)Area.GetDrawObj("PMDIGCOM");
    if(PMDIGCOM != null)
          {PMDIGCOM.Visible = false;}
 
    DrawArea PMDIGOUT = (DrawArea)Area.GetDrawObj("PMDIGOUT");
    if(PMDIGOUT != null)
          {PMDIGOUT.Visible = false;}   

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void CZ_OnDynAnimation(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 
   
    DrawArea PMPID = (DrawArea)Area.GetDrawObj("PMPID");
    DrawArea PMANLIN = (DrawArea)Area.GetDrawObj("PMANLIN");
    DrawArea PMDIGCOM = (DrawArea)Area.GetDrawObj("PMDIGCOM");
    DrawArea PMDIGOUT = (DrawArea)Area.GetDrawObj("PMDIGOUT");

    String alg = CommonFunction.GetTagAlgName(Area.Variable[0]);

    if(alg != "" || alg != null)

        {
             if(alg == "PMPID")

                {    if(PMPID != null)
                     {PMPID.Variable[0] = Area.Variable[0];
                     PMPID.Visible = true;
                     PMANLIN.Visible = false;
                     PMDIGCOM.Visible = false;
                     PMDIGOUT.Visible = false;}
                }

             else if(alg == "PMANLIN")

                {    if(PMANLIN != null)
                     {PMANLIN.Variable[0] = Area.Variable[0];
                     PMANLIN.Visible = true;
                     PMPID.Visible = false;
                     PMDIGCOM.Visible = false;
                     PMDIGOUT.Visible = false;}
                }

             else if(alg == "PMDIGCOM")

                {    if(PMDIGCOM != null)
                     {PMDIGCOM.Variable[0] = Area.Variable[0];
                     PMDIGCOM.Visible = true;
                     PMPID.Visible = false;
                     PMANLIN.Visible = false;
                     PMDIGOUT.Visible = false;}
                }

             else if(alg == "PMDIGOUT")

                {    if(PMDIGOUT != null)
                     {PMDIGOUT.Variable[0] = Area.Variable[0];
                     PMDIGOUT.Visible = true;
                     PMPID.Visible = false;
                     PMANLIN.Visible = false;
                     PMDIGCOM.Visible = false;}
                }

             else 

                {
                     PMDIGCOM.Visible = false;
                     PMDIGOUT.Visible = false;
                     PMPID.Visible = false;
                     PMANLIN.Visible = false;
                }
        }

    return; 
}


// =======================================================================
//
// 文件名：CZ_PMDIGOUT.grf（面板）
// 【调用时传入参数】
//		Area.Variable[0] - Tagname
//
// 【更新时间】 
//		2013.05.22
// =======================================================================

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void CZ_PMDIGOUT_OnDynInitialize(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender;

	Area.Variable[0] = Area.Variable[0].ToUpper();

if(Area.BReference)
	{
		Area.Enabled = true;
        } 

    return; 
}

//Do not remove or update this comment
//Event Delegate:KeyEventHandler 
//Event Handler:KeyUp 
public void CZ_PMDIGOUT_KeyUp(Object sender, KeyEventArgs e)
{
   DrawArea Area = (DrawArea)sender; 

   string tagName = Area.Variable[0] + "/OP";

     double dbValue = 0;
     int nValue = 0;
     bool bValue = false;
     int nDataType = 0;

     string OP = Area.Variable[0] + "/OP";
     bool ret = CommonFunction.GetValueWithType(OP,ref dbValue,ref nValue,ref bValue,ref nDataType);
     
     if(ret)
      
           {
		    switch(e.KeyData)
                      {    

                         case Keys.Up:

	                        {		
                                   CommonFunction.DSI_SetValue(tagName, (double)(1));
	                        }
	                 break;

                         case Keys.Down:

	                        {		
                                   CommonFunction.DSI_SetValue(tagName, (double)(0));
	                        }
	                       
	                 break;
                      } 
         }
       
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void CZ_PMDIGOUT_Rect_Tag_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect_Tag = (DrawRectangle)dynArgs.sender; 
   
	int nLeft = 0;
	int nTop = 0;
	string[] strVariable = new string[1];
	strVariable[0] = Area.Variable[0];
 	CommonFunction.OpenDetail(Area.Variable[0], nTop, nLeft);

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void CZ_PMDIGOUT_ON_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText ON = (DrawText)dynArgs.sender; 

    ON.Caption = CommonFunction.GetTagSwitchText(Area.Variable[0], 2);

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void CZ_PMDIGOUT_TagComment_OnDynAnimation(Object sender, EventArgs e)
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
//Event Handler:OnDynAnimation 
public void CZ_PMDIGOUT_TagName_OnDynAnimation(Object sender, EventArgs e)
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
//Event Handler:OnDynClick 
public void CZ_PMDIGOUT_Close_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle CLR = (DrawRectangle)dynArgs.sender; 
   
    DrawArea A = (DrawArea)(Area.Parent.Parent);
             A.RunAnimation();

    (Area.Parent).Visible = false;

    CommonFunction._ProjectRelated.Var[0] = "NULL";
    CommonFunction._ProjectRelated.Var[1] = "NULL";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void CZ_PMDIGOUT_Rect_ON_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect_ON = (DrawRectangle)dynArgs.sender; 
   
        Rect_ON.ForegroundColor = Color.Transparent;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void CZ_PMDIGOUT_Rect_ON_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect_ON = (DrawRectangle)dynArgs.sender; 
   
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;
	string tagName = Area.Variable[0] + "/OP";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);

        if(ret)
          {		
             if(dbValue == 1)
	        {
                     Rect_ON.ForegroundColor = Color.Yellow;

	        }
	     else
	        {
                     Rect_ON.ForegroundColor = Color.Transparent;
         	 }
          }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void CZ_PMDIGOUT_Rect_OFF_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect_OFF = (DrawRectangle)dynArgs.sender; 
   
        Rect_OFF.ForegroundColor = Color.Transparent;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void CZ_PMDIGOUT_Rect_OFF_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect_OFF = (DrawRectangle)dynArgs.sender; 
   
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;
	string tagName = Area.Variable[0] + "/OP";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);

        if(ret)
          {		
             if(dbValue == 0)
	        {
                     Rect_OFF.ForegroundColor = Color.Yellow;

	        }
	     else
	        {
                     Rect_OFF.ForegroundColor = Color.Transparent;
         	 }
          }

    return; 
}
// =======================================================================
//
// 文件名：CZ_PMDIGCOM.grf（面板）
// 【调用时传入参数】
//		Area.Variable[0] - Tagname
//		Area.Variable[1] - 选中的标志位
//
// 【更新时间】 
//		2013.03.27
// =======================================================================

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void CZ_PMDIGCOM_OnDynInitialize(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender;

	Area.Variable[0] = Area.Variable[0].ToUpper();

if(Area.BReference)
	{
		Area.Enabled = true;
        }


////////////////////////////////////////////////////////////////////////////////处理变色
////////////////////////////////////////////////////////////////////////////////处理变色

	DrawRectangle Rect_ON = (DrawRectangle)Area.GetDrawObj("Rect_ON");
	DrawRectangle Rect_OFF = (DrawRectangle)Area.GetDrawObj("Rect_OFF");
	DrawRectangle Rect_SPACE = (DrawRectangle)Area.GetDrawObj("Rect_SPACE");
	DrawRectangle Close = (DrawRectangle)Area.GetDrawObj("Close");

	DrawText ON = (DrawText)Area.GetDrawObj("ON");
	DrawText OFF = (DrawText)Area.GetDrawObj("OFF");
	DrawText SPACE = (DrawText)Area.GetDrawObj("SPACE");
	DrawText CLR = (DrawText)Area.GetDrawObj("CLR");

        ON.ForegroundColor = Color.Lime;
        OFF.ForegroundColor = Color.Lime;
        SPACE.ForegroundColor = Color.Lime;
        CLR.ForegroundColor = Color.Lime;
        Rect_ON.EdgeColor = Color.Lime;
        Rect_OFF.EdgeColor = Color.Lime;
        Rect_SPACE.EdgeColor = Color.Lime;
        Close.EdgeColor = Color.Lime;

        CommonFunction._ProjectRelated.Var[0] = "NULL";

	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;
	string tagName = Area.Variable[0] + "/OP";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
        Area.Variable[1] = "0";
	    if(ret)
	    {

		if(nValue == 1)

		   {
                      ON.ForegroundColor = Color.Cyan;
                      Rect_ON.EdgeColor = Color.Cyan;
                    }	
		else if(nValue == 0)

		   {
                      OFF.ForegroundColor = Color.Cyan;
                      Rect_OFF.EdgeColor = Color.Cyan;
                    }
                else if(nValue == 0)

		   {
                      SPACE.ForegroundColor = Color.Lime;
                      Rect_SPACE.EdgeColor = Color.Lime;
                    }
	    }    

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void CZ_PMDIGCOM_OnDynAnimation(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 
   
	DrawRectangle Rect_ON = (DrawRectangle)Area.GetDrawObj("Rect_ON");
	DrawRectangle Rect_OFF = (DrawRectangle)Area.GetDrawObj("Rect_OFF");
	DrawRectangle Rect_SPACE = (DrawRectangle)Area.GetDrawObj("Rect_SPACE");
	DrawRectangle Close = (DrawRectangle)Area.GetDrawObj("Close");

	DrawText ON = (DrawText)Area.GetDrawObj("ON");
	DrawText OFF = (DrawText)Area.GetDrawObj("OFF");
	DrawText SPACE = (DrawText)Area.GetDrawObj("SPACE");
	DrawText CLR = (DrawText)Area.GetDrawObj("CLR");

        ON.ForegroundColor = Color.Lime;
        OFF.ForegroundColor = Color.Lime;
        SPACE.ForegroundColor = Color.Lime;
        CLR.ForegroundColor = Color.Lime;
        Rect_ON.EdgeColor = Color.Lime;
        Rect_OFF.EdgeColor = Color.Lime;
        Rect_SPACE.EdgeColor = Color.Lime;
        Close.EdgeColor = Color.Lime;

	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;
	string tagName = Area.Variable[0] + "/OP";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);

   if(ret)
   {		
     if(dbValue == 1)
	 {
			 ON.ForegroundColor = Color.Cyan;
                         Rect_ON.EdgeColor = Color.Cyan;

		 if(Area.Variable[1] == "2")
		 {
			 OFF.ForegroundColor = Color.White;
                         Rect_OFF.EdgeColor = Color.White;
                         CommonFunction._ProjectRelated.Var[0] = "PENTER";
                         CommonFunction._ProjectRelated.Var[1] = "NULL";
		 }
		 else if(Area.Variable[1] == "3")
		 {
			 SPACE.ForegroundColor = Color.White;
                         Rect_SPACE.EdgeColor = Color.White;
                         CommonFunction._ProjectRelated.Var[0] = "PENTER";
                         CommonFunction._ProjectRelated.Var[1] = "NULL";
		 }

	 }
	 if(dbValue == 0)
	 {
			 OFF.ForegroundColor = Color.Cyan;
                         Rect_OFF.EdgeColor = Color.Cyan;

		 if(Area.Variable[1] == "1")
		 {
			 ON.ForegroundColor = Color.White;
                         Rect_ON.EdgeColor = Color.White;
                         CommonFunction._ProjectRelated.Var[0] = "PENTER";
                         CommonFunction._ProjectRelated.Var[1] = "NULL";
		 }
		 else if(Area.Variable[1] == "3")
		 {
			 SPACE.ForegroundColor = Color.White;
                         Rect_SPACE.EdgeColor = Color.White;
                         CommonFunction._ProjectRelated.Var[0] = "PENTER";
                         CommonFunction._ProjectRelated.Var[1] = "NULL";
		 }
	 }
	 if(dbValue == 0)
	 {
			 SPACE.ForegroundColor = Color.Lime;
                         Rect_SPACE.EdgeColor = Color.Lime;

		 if(Area.Variable[1] == "1")
		 {
			 ON.ForegroundColor = Color.White;
                         Rect_ON.EdgeColor = Color.White;
                         CommonFunction._ProjectRelated.Var[0] = "PENTER";
                         CommonFunction._ProjectRelated.Var[1] = "NULL";
		 }
		 else if(Area.Variable[1] == "2")
		 {
			 OFF.ForegroundColor = Color.White;
                         Rect_OFF.EdgeColor = Color.White;
                         CommonFunction._ProjectRelated.Var[0] = "PENTER";
                         CommonFunction._ProjectRelated.Var[1] = "NULL";
		 }
	 }
      }

   return; 
}

//Do not remove or update this comment
//Event Delegate:KeyEventHandler 
//Event Handler:KeyUp 
public void CZ_PMDIGCOM_KeyUp(Object sender, KeyEventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   string tagName = Area.Variable[0] + "/OP";

     double dbValue = 0;
     int nValue = 0;
     bool bValue = false;
     int nDataType = 0;

     string OP = Area.Variable[0] + "/OP";
     bool ret = CommonFunction.GetValueWithType(OP,ref dbValue,ref nValue,ref bValue,ref nDataType);
     
     if(ret)
      
           {
		    switch(e.KeyData)
                      {    

                         case Keys.Enter:

                               if(Area.Variable[1] == "1")
	                        {		
                                   CommonFunction.DSI_SetValue(tagName, (double)(1));
	                        }
	                       if(Area.Variable[1] == "2")
	                        {
                                   CommonFunction.DSI_SetValue(tagName, (double)(0));
	                         }
	                       if(Area.Variable[1] == "3")
	                        {
                                   CommonFunction.DSI_SetValue(tagName, (double)(0));
	                        }

                                CommonFunction._ProjectRelated.Var[0] = "NULL";
                                CommonFunction._ProjectRelated.Var[1] = "NULL";

                          Area.Variable[1] = "0";

	                 break;
                      } 
         }
         
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void CZ_PMDIGCOM_Rect_Tag_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect_Tag = (DrawRectangle)dynArgs.sender; 
   
	int nLeft = 0;
	int nTop = 0;
	string[] strVariable = new string[1];
	strVariable[0] = Area.Variable[0];
 	CommonFunction.OpenDetail(Area.Variable[0], nTop, nLeft);

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void CZ_PMDIGCOM_Rect_ON_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect_ON = (DrawRectangle)dynArgs.sender; 
   
    DrawArea A = (DrawArea)(Area.Parent.Parent);
             A.RunAnimation();

    Area.Variable[1] = "1";

	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;
	string tagName = Area.Variable[0] + "/OP";

   if(CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType))
   {		
     if(dbValue == 1)
	 {
              Rect_ON.EdgeColor = Color.White;
	      DrawText ON = (DrawText)Area.GetDrawObj("ON");
   	      ON.ForegroundColor = Color.White;
          }
   }

    return; 
}



//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void CZ_PMDIGCOM_Rect_OFF_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect_OFF = (DrawRectangle)dynArgs.sender; 
   
    DrawArea A = (DrawArea)(Area.Parent.Parent);
             A.RunAnimation();

    Area.Variable[1] = "2";

	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;
	string tagName = Area.Variable[0] + "/OP";

   if(CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType))
   {		
     if(dbValue == 0)
	 {
              Rect_OFF.EdgeColor = Color.White;
	      DrawText OFF = (DrawText)Area.GetDrawObj("OFF");
   	      OFF.ForegroundColor = Color.White;
          }
   }

    return; 
}



//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void CZ_PMDIGCOM_Rect_SPACE_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect_SPACE = (DrawRectangle)dynArgs.sender; 
   
    DrawArea A = (DrawArea)(Area.Parent.Parent);
             A.RunAnimation();

    Area.Variable[1] = "3";

	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;
	string tagName = Area.Variable[0] + "/OP";

   if(CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType))
   {		
     if(dbValue == 0)
	 {
              Rect_SPACE.EdgeColor = Color.White;
	      DrawText SPACE = (DrawText)Area.GetDrawObj("SPACE");
   	      SPACE.ForegroundColor = Color.White;
          }
   }

    return; 
}


//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void CZ_PMDIGCOM_TagComment_OnDynAnimation(Object sender, EventArgs e)
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
//Event Handler:OnDynAnimation 
public void CZ_PMDIGCOM_TagName_OnDynAnimation(Object sender, EventArgs e)
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
//Event Handler:OnDynClick 
public void CZ_PMDIGCOM_Close_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle CLR = (DrawRectangle)dynArgs.sender; 
   
    DrawArea A = (DrawArea)(Area.Parent.Parent);
             A.RunAnimation();

    (Area.Parent).Visible = false;

    CommonFunction._ProjectRelated.Var[0] = "NULL";
    CommonFunction._ProjectRelated.Var[1] = "NULL";

    Area.Variable[1] = "0";

    return; 
}
// =======================================================================
//
// 文件名：CZ_AI.grf（面板）
// 【调用时传入参数】
//		Area.Variable[0] - Tagname
//		Area.Variable[1] - 选中的标志位
//
// 【更新时间】 
//		2013.03.25
// =======================================================================

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void CZ_PMANLIN_OnDynInitialize(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender;

	Area.Variable[0] = Area.Variable[0].ToUpper();

if(Area.BReference)
	{
		Area.Enabled = true;
        }


////////////////////////////////////////////////////////////////////////////////处理变色
////////////////////////////////////////////////////////////////////////////////处理变色

	DrawText PTXST = (DrawText)Area.GetDrawObj("PTXST");
	DrawText ACTIVE = (DrawText)Area.GetDrawObj("ACTIVE");
        DrawRectangle PA_Rectangle = (DrawRectangle)Area.GetDrawObj("PA_Rectangle");

	DrawText PV = (DrawText)Area.GetDrawObj("PV");
	DrawText PVEULO = (DrawText)Area.GetDrawObj("PVEULO");
	DrawText PVEUHI = (DrawText)Area.GetDrawObj("PVEUHI");
	DrawText Text_PV = (DrawText)Area.GetDrawObj("Text_PV");
	DrawText Text_PVEULO = (DrawText)Area.GetDrawObj("Text_PVEULO");
	DrawText Text_PVEUHI = (DrawText)Area.GetDrawObj("Text_PVEUHI");

        PTXST.ForegroundColor = Color.Lime;
        ACTIVE.ForegroundColor = Color.Lime;
        PA_Rectangle.EdgeColor = Color.Lime;

	PV.ForegroundColor = Color.Lime;
	PVEULO.ForegroundColor = Color.Lime;
	PVEUHI.ForegroundColor = Color.Lime;
	Text_PV.ForegroundColor = Color.Lime;
	Text_PVEULO.ForegroundColor = Color.Lime;
	Text_PVEUHI.ForegroundColor = Color.Lime;
 
           CommonFunction._ProjectRelated.Var[0] = "NULL";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void CZ_PMANLIN_OnDynAnimation(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 
   
	DrawText PTXST = (DrawText)Area.GetDrawObj("PTXST");
	DrawText ACTIVE = (DrawText)Area.GetDrawObj("ACTIVE");
        DrawRectangle PA_Rectangle = (DrawRectangle)Area.GetDrawObj("PA_Rectangle");

	DrawText PV = (DrawText)Area.GetDrawObj("PV");
	DrawText PVEULO = (DrawText)Area.GetDrawObj("PVEULO");
	DrawText PVEUHI = (DrawText)Area.GetDrawObj("PVEUHI");
	DrawText Text_PV = (DrawText)Area.GetDrawObj("Text_PV");
	DrawText Text_PVEULO = (DrawText)Area.GetDrawObj("Text_PVEULO");
	DrawText Text_PVEUHI = (DrawText)Area.GetDrawObj("Text_PVEUHI");

        PTXST.ForegroundColor = Color.Lime;
        ACTIVE.ForegroundColor = Color.Lime;
        PA_Rectangle.EdgeColor = Color.Lime;

	PV.ForegroundColor = Color.Lime;
	PVEULO.ForegroundColor = Color.Lime;
	PVEUHI.ForegroundColor = Color.Lime;
	Text_PV.ForegroundColor = Color.Lime;
	Text_PVEULO.ForegroundColor = Color.Lime;
	Text_PVEUHI.ForegroundColor = Color.Lime;

     if(Area.Variable[1] == "4")
     {
	 PTXST.ForegroundColor = Color.White;
         ACTIVE.ForegroundColor = Color.White;
         PA_Rectangle.EdgeColor = Color.White; 

               CommonFunction._ProjectRelated.Var[0] = "PENTER"; 
               CommonFunction._ProjectRelated.Var[1] = "NULL";  
     }
 
     if(Area.Variable[1] == "5")
     {  
                 CommonFunction._ProjectRelated.Var[1] = "NOT EMULATION"; 
                 CommonFunction._ProjectRelated.Var[0] = "NULL";  
     }

     if(Area.Variable[1] == "6")
     {
	 PV.ForegroundColor = Color.White;
         Text_PV.ForegroundColor = Color.White;  
     }

     if(Area.Variable[1] == "7")
     {
	 PVEULO.ForegroundColor = Color.White;
         Text_PVEULO.ForegroundColor = Color.White; 
     }

     if(Area.Variable[1] == "8")
     {
	 PVEUHI.ForegroundColor = Color.White;
         Text_PVEUHI.ForegroundColor = Color.White;
     }

   return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void CZ_PMANLIN_OnDynClick(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 
   
    DrawArea A = (DrawArea)(Area.Parent.Parent);
             A.RunAnimation();

   object obj=Area.GetControlObj("TB");
   if(obj!=null)
	{
		TextBox TB=(TextBox)obj;
		TB.Visible=false;
	}

    return; 
}
//Do not remove or update this comment
//Event Delegate:KeyEventHandler 
//Event Handler:KeyUp 
public void CZ_PMANLIN_KeyUp(Object sender, KeyEventArgs e)
{
   DrawArea Area = (DrawArea)sender; 

		    switch(e.KeyData)
                      {    

                         case Keys.Enter:

                               if(Area.Variable[1] == "4")
                                {
	                             DrawText PTXST = (DrawText)Area.GetDrawObj("PTXST");
	                             DrawText ACTIVE = (DrawText)Area.GetDrawObj("ACTIVE");
                                     DrawRectangle PA_Rectangle = (DrawRectangle)Area.GetDrawObj("PA_Rectangle");

	                             PTXST.ForegroundColor = Color.Lime;
                                     ACTIVE.ForegroundColor = Color.Lime;
                                     PA_Rectangle.EdgeColor = Color.Lime;     
                                }

                                CommonFunction._ProjectRelated.Var[0] = "NULL";
                                CommonFunction._ProjectRelated.Var[1] = "NULL";

                          Area.Variable[1] = "0";

	                 break;
                      } 
         
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void CZ_PMANLIN_Rect_Tag_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect_Tag = (DrawRectangle)dynArgs.sender; 

	int nLeft = 0;
	int nTop = 0;
	string[] strVariable = new string[1];
	strVariable[0] = Area.Variable[0];
        CommonFunction.OpenDetail(Area.Variable[0], nTop, nLeft); 

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void CZ_PMANLIN_Rect_PVEUHI_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect_PVEUHI = (DrawRectangle)dynArgs.sender; 
   
    DrawText PVEUHI = (DrawText)Area.GetDrawObj("PVEUHI");

    Area.Variable[1] = "8"; 

    if(Rect_PVEUHI.Visible == true)

	{
		// 不弹出输入面板，DrawText隐藏，TextBox显示	
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

                                //调整TB的位置：
			        CommonFunction.MoveControl(Area,TB,(int)(PVEUHI.VerticalPosition)+30,(int)(PVEUHI.HorizontalPosition)+40);
				
				obj = CommonFunction.GetLabelOfControl(TB);
				if(obj != null)
				{
					ControlLabel lab = (ControlLabel)obj;
					//给TB传递参数：
					lab.Variable[0] = Area.Variable[0] + "/PVEUHI";
				}
			}
		}
	}

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void CZ_PMANLIN_Rect_PVEULO_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect_PVEULO = (DrawRectangle)dynArgs.sender; 
   
    DrawText PVEULO = (DrawText)Area.GetDrawObj("PVEULO");

    Area.Variable[1] = "7"; 

    if(Rect_PVEULO.Visible == true)

	{
		// 不弹出输入面板，DrawText隐藏，TextBox显示	
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
                                //调整TB的位置：
				CommonFunction.MoveControl(Area,TB,(int)(PVEULO.VerticalPosition + 30),(int)(PVEULO.HorizontalPosition)+40);		
				obj = CommonFunction.GetLabelOfControl(TB);
				if(obj != null)
				{
					ControlLabel lab = (ControlLabel)obj;
					//给TB传递参数：
					lab.Variable[0] = Area.Variable[0] + "/PVEULO";
                                      
				}
			}
		}
	}

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void CZ_PMANLIN_Rect_PV_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect_PV = (DrawRectangle)dynArgs.sender; 

    DrawText PV = (DrawText)Area.GetDrawObj("PV");

    Area.Variable[1] = "6"; 

    if(Rect_PV.Visible == true)

	{
		// 不弹出输入面板，DrawText隐藏，TextBox显示	
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
                                //调整TB的位置：
				CommonFunction.MoveControl(Area,TB,(int)(PV.VerticalPosition)+30,(int)(PV.HorizontalPosition)+40);
			
				obj = CommonFunction.GetLabelOfControl(TB);
				if(obj != null)
				{
					ControlLabel lab = (ControlLabel)obj;
					//给TB传递参数：
					lab.Variable[0] = Area.Variable[0] + "/PV";
                                        
				}
			}
		}
	}


    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void CZ_PMANLIN_Text_PVEUHI_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText Text_PVEUHI = (DrawText)dynArgs.sender; 
   
    Text_PVEUHI.ForegroundColor = Color.Lime;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void CZ_PMANLIN_Text_PVEULO_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText Text_PVEULO = (DrawText)dynArgs.sender; 
   
    Text_PVEULO.ForegroundColor = Color.Lime;

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void CZ_PMANLIN_Text_PV_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText Text_PV = (DrawText)dynArgs.sender; 

       Text_PV.ForegroundColor = Color.Lime;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void CZ_PMANLIN_PA_Rectangle_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle PA_Rectangle = (DrawRectangle)dynArgs.sender; 

    DrawArea A = (DrawArea)(Area.Parent.Parent);
             A.RunAnimation();

    Area.Variable[1] = "4";  
 
     return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void CZ_PMANLIN_PVEUHI_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVEUHI = (DrawText)dynArgs.sender; 
   
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	int nDigit = 1;

	string strDigit = "f" + nDigit.ToString();
	
	string tagName = Area.Variable[0] + "/PVEUHI";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		PVEUHI.Caption = dbValue.ToString(strDigit);
	}
	else
		PVEUHI.Caption = "##.#";

    object obj = Area.GetControlObj("TB");
	
	TextBox TB = (TextBox)obj; 

          if(TB.Visible == false)

            {
                PVEUHI.ForegroundColor = Color.Lime;
                DrawText Text_PVEUHI = (DrawText)Area.GetDrawObj("Text_PVEUHI");
                Text_PVEUHI.ForegroundColor = Color.Lime;
            }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void CZ_PMANLIN_PVEUHI_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVEUHI = (DrawText)dynArgs.sender; 
 
    PVEUHI.ForegroundColor = Color.Lime; 

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void CZ_PMANLIN_PVEULO_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVEULO = (DrawText)dynArgs.sender;
 
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
	
	tagName = Area.Variable[0] + "/PVEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		PVEULO.Caption = dbValue.ToString(strDigit);
	}
	else
		PVEULO.Caption = "##.#";

    object obj = Area.GetControlObj("TB");
	
	TextBox TB = (TextBox)obj; 

          if(TB.Visible == false)

            {
                PVEULO.ForegroundColor = Color.Lime;
                DrawText Text_PVEULO = (DrawText)Area.GetDrawObj("Text_PVEULO");
                Text_PVEULO.ForegroundColor = Color.Lime;
            }


    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void CZ_PMANLIN_PVEULO_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVEULO = (DrawText)dynArgs.sender; 

    PVEULO.ForegroundColor = Color.Lime; 

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void CZ_PMANLIN_PV_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PV = (DrawText)dynArgs.sender; 
  
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
		PV.Caption = dbValue.ToString(strDigit);
	}
	else
		PV.Caption = "##.#";

    object obj = Area.GetControlObj("TB");
	
	TextBox TB = (TextBox)obj; 

          if(TB.Visible == false)

            {
                PV.ForegroundColor = Color.Lime;
                DrawText Text_PV = (DrawText)Area.GetDrawObj("Text_PV");
                Text_PV.ForegroundColor = Color.Lime;
            }



    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void CZ_PMANLIN_PV_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PV = (DrawText)dynArgs.sender; 
   
    PV.ForegroundColor = Color.Lime;

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void CZ_PMANLIN_TagComment_OnDynAnimation(Object sender, EventArgs e)
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
//Event Handler:OnDynAnimation 
public void CZ_PMANLIN_PVUnit_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVUnit = (DrawText)dynArgs.sender; 
   
    PVUnit.Caption = CommonFunction.GetPVUnit(Area.Variable[0]);

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void CZ_PMANLIN_TagName_OnDynAnimation(Object sender, EventArgs e)
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
//Event Handler:OnDynClick 
public void CZ_PMANLIN_Close_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle CLR = (DrawRectangle)dynArgs.sender; 
   
    DrawArea A = (DrawArea)(Area.Parent.Parent);
             A.RunAnimation();

    (Area.Parent).Visible = false;

              CommonFunction._ProjectRelated.Var[0] = "NULL";
              CommonFunction._ProjectRelated.Var[1] = "NULL";

    Area.Variable[1] = "0";

    return; 
}
//Do not remove or update this comment
//Event Delegate:KeyEventHandler 
//Event Handler:KeyUp 
public void CZ_PMANLIN_TB_KeyUp(Object sender, KeyEventArgs e)
{
   TextBox TB = (TextBox)sender; 

   DrawArea Area = CommonFunction.GetThisDrawArea(TB);

	switch ( e.KeyData )
	{
	case Keys.Enter:

		if(TB.Text == "" || TB.Text == null)

		{
			TB.Visible = false;
			TB.Enabled = false;
			return;
		}

		else

		{
			string PVInputValue = TB.Text;
			double dbPVValue = Convert.ToDouble(PVInputValue);

			object obj1 = CommonFunction.GetLabelOfControl(TB);

			if (obj1 != null)

			{
		             ControlLabel lab=(ControlLabel)obj1;
		             string tagName=lab.Variable[0];

                             //PV值只有在MODE是MAN的时候才可以改变
                             bool PV = tagName.Contains("PV");
                             bool PVEUHI = tagName.Contains("PVEUHI");
                             bool PVEULO = tagName.Contains("PVEULO");
                             if(PV == true)
                               {
				        CommonFunction.DSI_SetValue(tagName, dbPVValue);
                               }

                             if(PVEUHI == true)
                               {
			                CommonFunction.DSI_SetValue(tagName, dbPVValue);
		
	                        }

                             if(PVEULO == true)
                               {
			                CommonFunction.DSI_SetValue(tagName, dbPVValue);
                               }
			}      
                        TB.ForeColor = Color.Lime;
			TB.Visible = false;
			TB.Enabled = false;
                        return;
		}
		break;
	}

    return; 
}

// =======================================================================
//
// 文件名：CZ_PMPID.grf（面板）
// 【调用时传入参数】
//		Area.Variable[0] - Tagname
//		Area.Variable[1] - 选中的标志位
//
// 【更新时间】 
//		2012.12.26
// =======================================================================

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void CZ_PMPID_OnDynInitialize(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender;

	Area.Variable[0] = Area.Variable[0].ToUpper();

if(Area.BReference)
	{
		Area.Enabled = true;
        }

////////////////////////////////////////////////////////////////////////////////处理变色
////////////////////////////////////////////////////////////////////////////////处理变色

	DrawText MAN = (DrawText)Area.GetDrawObj("MAN");
	DrawText AUTO = (DrawText)Area.GetDrawObj("AUTO");
	DrawText CAS = (DrawText)Area.GetDrawObj("CAS");
	DrawRectangle Rect_MAN = (DrawRectangle)Area.GetDrawObj("Rect_MAN");
	DrawRectangle Rect_AUTO = (DrawRectangle)Area.GetDrawObj("Rect_AUTO");
	DrawRectangle Rect_CAS = (DrawRectangle)Area.GetDrawObj("Rect_CAS");

	DrawText PTXST = (DrawText)Area.GetDrawObj("PTXST");
	DrawText ACTIVE = (DrawText)Area.GetDrawObj("ACTIVE");
        DrawRectangle PA_Rectangle = (DrawRectangle)Area.GetDrawObj("PA_Rectangle");

	DrawText PV = (DrawText)Area.GetDrawObj("PV");
	DrawText SP = (DrawText)Area.GetDrawObj("SP");
	DrawText OP = (DrawText)Area.GetDrawObj("OP");
	DrawText Text_PV = (DrawText)Area.GetDrawObj("Text_PV");
	DrawText Text_SP = (DrawText)Area.GetDrawObj("Text_SP");
	DrawText Text_OP = (DrawText)Area.GetDrawObj("Text_OP");

	MAN.ForegroundColor = Color.Lime;
	AUTO.ForegroundColor = Color.Lime;
	CAS.ForegroundColor = Color.Lime;
	Rect_MAN.EdgeColor = Color.Lime;
	Rect_AUTO.EdgeColor = Color.Lime;
	Rect_CAS.EdgeColor = Color.Lime;

        PTXST.ForegroundColor = Color.Lime;
        ACTIVE.ForegroundColor = Color.Lime;
        PA_Rectangle.EdgeColor = Color.Lime;

	PV.ForegroundColor = Color.Cyan;
	SP.ForegroundColor = Color.Cyan;
	OP.ForegroundColor = Color.Yellow;
	Text_PV.ForegroundColor = Color.Cyan;
	Text_SP.ForegroundColor = Color.Cyan;
	Text_OP.ForegroundColor = Color.Yellow;

    CommonFunction._ProjectRelated.Var[0] = "NULL";

	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;
	string tagName = Area.Variable[0] + "/MODE";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
        Area.Variable[1] = "0";
	    if(ret)
	    {

		if(nValue == 1)

		   {
                      MAN.ForegroundColor = Color.Cyan;
                      Rect_MAN.EdgeColor = Color.Cyan;
                    }	
		else if(nValue == 2)

		   {
                      AUTO.ForegroundColor = Color.Cyan;
                      Rect_AUTO.EdgeColor = Color.Cyan;
                    }
                else if(nValue == 3)

		   {
                      CAS.ForegroundColor = Color.Cyan;
                      Rect_CAS.EdgeColor = Color.Cyan;
                    }
	    }    

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void CZ_PMPID_OnDynAnimation(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 
   
	DrawText MAN = (DrawText)Area.GetDrawObj("MAN");
	DrawText AUTO = (DrawText)Area.GetDrawObj("AUTO");
	DrawText CAS = (DrawText)Area.GetDrawObj("CAS");
	DrawRectangle Rect_MAN = (DrawRectangle)Area.GetDrawObj("Rect_MAN");
	DrawRectangle Rect_AUTO = (DrawRectangle)Area.GetDrawObj("Rect_AUTO");
	DrawRectangle Rect_CAS = (DrawRectangle)Area.GetDrawObj("Rect_CAS");

	DrawText PTXST = (DrawText)Area.GetDrawObj("PTXST");
	DrawText ACTIVE = (DrawText)Area.GetDrawObj("ACTIVE");
        DrawRectangle PA_Rectangle = (DrawRectangle)Area.GetDrawObj("PA_Rectangle");

	DrawText PV = (DrawText)Area.GetDrawObj("PV");
	DrawText SP = (DrawText)Area.GetDrawObj("SP");
	DrawText OP = (DrawText)Area.GetDrawObj("OP");
	DrawText Text_PV = (DrawText)Area.GetDrawObj("Text_PV");
	DrawText Text_SP = (DrawText)Area.GetDrawObj("Text_SP");
	DrawText Text_OP = (DrawText)Area.GetDrawObj("Text_OP");

	MAN.ForegroundColor = Color.Lime;
	AUTO.ForegroundColor = Color.Lime;
	CAS.ForegroundColor = Color.Lime;
	Rect_MAN.EdgeColor = Color.Lime;
	Rect_AUTO.EdgeColor = Color.Lime;
	Rect_CAS.EdgeColor = Color.Lime;

        PTXST.ForegroundColor = Color.Lime;
        ACTIVE.ForegroundColor = Color.Lime;
        PA_Rectangle.EdgeColor = Color.Lime;

	PV.ForegroundColor = Color.Cyan;
	SP.ForegroundColor = Color.Cyan;
	OP.ForegroundColor = Color.Yellow;
	Text_PV.ForegroundColor = Color.Cyan;
	Text_SP.ForegroundColor = Color.Cyan;
	Text_OP.ForegroundColor = Color.Yellow;

	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;
	string tagName = Area.Variable[0] + "/MODE";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);

   if(ret)
   {		
     if(dbValue == 1)
	 {
			 MAN.ForegroundColor = Color.Cyan;
                         Rect_MAN.EdgeColor = Color.Cyan;

		 if(Area.Variable[1] == "2")
		 {
			 AUTO.ForegroundColor = Color.White;
                         Rect_AUTO.EdgeColor = Color.White;

                             CommonFunction._ProjectRelated.Var[0] = "PENTER";
                             CommonFunction._ProjectRelated.Var[1] = "NULL";
		 }
		 else if(Area.Variable[1] == "3")
		 {
			 CAS.ForegroundColor = Color.White;
                         Rect_CAS.EdgeColor = Color.White;

                             CommonFunction._ProjectRelated.Var[0] = "PENTER";
                             CommonFunction._ProjectRelated.Var[1] = "NULL";
		 }

	 }
	 if(dbValue == 2)
	 {
			 AUTO.ForegroundColor = Color.Cyan;
                         Rect_AUTO.EdgeColor = Color.Cyan;

		 if(Area.Variable[1] == "1")
		 {
			 MAN.ForegroundColor = Color.White;
                         Rect_MAN.EdgeColor = Color.White;

                             CommonFunction._ProjectRelated.Var[0] = "PENTER";
                             CommonFunction._ProjectRelated.Var[1] = "NULL";
		 }
		 else if(Area.Variable[1] == "3")
		 {
			 CAS.ForegroundColor = Color.White;
                         Rect_CAS.EdgeColor = Color.White;
                             CommonFunction._ProjectRelated.Var[0] = "PENTER";
                             CommonFunction._ProjectRelated.Var[1] = "NULL";
		 }
	 }
	 if(dbValue == 3)
	 {
			 CAS.ForegroundColor = Color.Cyan;
                         Rect_CAS.EdgeColor = Color.Cyan;

		 if(Area.Variable[1] == "1")
		 {
			 MAN.ForegroundColor = Color.White;
                         Rect_MAN.EdgeColor = Color.White;

                             CommonFunction._ProjectRelated.Var[0] = "PENTER";
                             CommonFunction._ProjectRelated.Var[1] = "NULL";

		 }
		 else if(Area.Variable[1] == "2")
		 {
			 AUTO.ForegroundColor = Color.White;
                         Rect_AUTO.EdgeColor = Color.White;

                             CommonFunction._ProjectRelated.Var[0] = "PENTER";
                             CommonFunction._ProjectRelated.Var[1] = "NULL";
		 }
	 }
	 }
     if(Area.Variable[1] == "4")
     {
	 PTXST.ForegroundColor = Color.White;
         ACTIVE.ForegroundColor = Color.White;
         PA_Rectangle.EdgeColor = Color.White;  

                             CommonFunction._ProjectRelated.Var[0] = "PENTER";
                             CommonFunction._ProjectRelated.Var[1] = "NULL"; 
     }
 
     if(Area.Variable[1] == "5")
     {   
             CommonFunction._ProjectRelated.Var[1] = "NOT EMULATION"; 
             CommonFunction._ProjectRelated.Var[0] = "NULL"; 
     }

     if(Area.Variable[1] == "6")
     {
	 PV.ForegroundColor = Color.White;
         Text_PV.ForegroundColor = Color.White;  
     }

     if(Area.Variable[1] == "7")
     {
	 SP.ForegroundColor = Color.White;
         Text_SP.ForegroundColor = Color.White; 
     }

     if(Area.Variable[1] == "8")
     {
	 OP.ForegroundColor = Color.White;
         Text_OP.ForegroundColor = Color.White;
     }

   return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void CZ_PMPID_OnDynClick(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 

   object obj=Area.GetControlObj("TB");
   if(obj!=null)
	{
		TextBox TB=(TextBox)obj;
		TB.Visible=false;
	}

    return; 
}
//Do not remove or update this comment
//Event Delegate:KeyEventHandler 
//Event Handler:KeyUp 
public void CZ_PMPID_KeyUp(Object sender, KeyEventArgs e)
{
   DrawArea Area = (DrawArea)sender; 

    DrawArea A = (DrawArea)(Area.Parent.Parent);
             A.RunAnimation();

   string tagName = Area.Variable[0] + "/MODE";

     double dbValue = 0;
     int nValue = 0;
     bool bValue = false;
     int nDataType = 0;

     string MODE = Area.Variable[0] + "/MODE";
     bool ret = CommonFunction.GetValueWithType(MODE,ref dbValue,ref nValue,ref bValue,ref nDataType);
     
     if(ret)
      
           {
		    switch(e.KeyData)
                      {    

                         case Keys.Enter:

                               if(Area.Variable[1] == "1")
	                        {		
                                   CommonFunction.DSI_SetValue(tagName, (double)(1));
	                        }
	                       if(Area.Variable[1] == "2")
	                        {
                                   CommonFunction.DSI_SetValue(tagName, (double)(2));
	                         }
	                       if(Area.Variable[1] == "3")
	                        {
                                   CommonFunction.DSI_SetValue(tagName, (double)(3));
	                        }
                               if(Area.Variable[1] == "4")
                                {
	                             DrawText PTXST = (DrawText)Area.GetDrawObj("PTXST");
	                             DrawText ACTIVE = (DrawText)Area.GetDrawObj("ACTIVE");
                                     DrawRectangle PA_Rectangle = (DrawRectangle)Area.GetDrawObj("PA_Rectangle");

	                             PTXST.ForegroundColor = Color.Lime;
                                     ACTIVE.ForegroundColor = Color.Lime;
                                     PA_Rectangle.EdgeColor = Color.Lime;     
                                }
                                CommonFunction._ProjectRelated.Var[0] = "NULL";
                                CommonFunction._ProjectRelated.Var[1] = "NULL";

                          Area.Variable[1] = "0";

	                 break;
                      } 
         }
         
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void CZ_PMPID_Rect17_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect17 = (DrawRectangle)dynArgs.sender; 
   
	int nLeft = 0;
	int nTop = 0;
	string[] strVariable = new string[1];
	strVariable[0] = Area.Variable[0];
 	CommonFunction.OpenDetail(Area.Variable[0], nTop, nLeft);

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void CZ_PMPID_Rect16_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect16 = (DrawRectangle)dynArgs.sender; 

    DrawText PV = (DrawText)Area.GetDrawObj("PV");

    Area.Variable[1] = "6"; 

    if(Rect16.Visible == true)

	{
		// 不弹出输入面板，DrawText隐藏，TextBox显示	
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
                                //调整TB的位置：
				CommonFunction.MoveControl(Area,TB,(int)(PV.VerticalPosition)+30,(int)(PV.HorizontalPosition)+40);
			
				obj = CommonFunction.GetLabelOfControl(TB);
				if(obj != null)
				{
					ControlLabel lab = (ControlLabel)obj;
					//给TB传递参数：
					lab.Variable[0] = Area.Variable[0] + "/PV";
                                        
				}
			}
		}
	}

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void CZ_PMPID_Rect15_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect15 = (DrawRectangle)dynArgs.sender; 

    DrawText SP = (DrawText)Area.GetDrawObj("SP");

    Area.Variable[1] = "7"; 

    if(Rect15.Visible == true)

	{
		// 不弹出输入面板，DrawText隐藏，TextBox显示	
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
                                //调整TB的位置：
				CommonFunction.MoveControl(Area,TB,(int)(SP.VerticalPosition)+30,(int)(SP.HorizontalPosition)+40);
			
				obj = CommonFunction.GetLabelOfControl(TB);
				if(obj != null)
				{
					ControlLabel lab = (ControlLabel)obj;
					//给TB传递参数：
					lab.Variable[0] = Area.Variable[0] + "/SP";
                                        
				}
			}
		}
	}

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void CZ_PMPID_Rect14_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect14 = (DrawRectangle)dynArgs.sender; 

    DrawText OP = (DrawText)Area.GetDrawObj("OP");

    Area.Variable[1] = "8"; 

    if(Rect14.Visible == true)

	{
		// 不弹出输入面板，DrawText隐藏，TextBox显示	
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
                                //调整TB的位置：
				CommonFunction.MoveControl(Area,TB,(int)(OP.VerticalPosition)+30,(int)(OP.HorizontalPosition)+40);
			
				obj = CommonFunction.GetLabelOfControl(TB);
				if(obj != null)
				{
					ControlLabel lab = (ControlLabel)obj;
					//给TB传递参数：
					lab.Variable[0] = Area.Variable[0] + "/OP";
                                        
				}
			}
		}
	}


    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void CZ_PMPID_Text_OP_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText Text_OP = (DrawText)dynArgs.sender; 
   
    Text_OP.ForegroundColor = Color.Yellow;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void CZ_PMPID_Text_SP_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText Text_SP = (DrawText)dynArgs.sender; 
   
    Text_SP.ForegroundColor = Color.Cyan;

    return; 
}


//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void CZ_PMPID_Text_PV_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText Text_PV = (DrawText)dynArgs.sender; 

       Text_PV.ForegroundColor = Color.Cyan;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void CZ_PMPID_PA_Rectangle_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle PA_Rectangle = (DrawRectangle)dynArgs.sender; 

    DrawArea A = (DrawArea)(Area.Parent.Parent);
             A.RunAnimation();

    Area.Variable[1] = "4";  
 
     return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void CZ_PMPID_Rect_PROG_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect_PROG = (DrawRectangle)dynArgs.sender; 
   
    Area.Variable[1] = "5";

               CommonFunction._ProjectRelated.Var[1] = "NOT EMULATION";
               CommonFunction._ProjectRelated.Var[0] = "NULL";

    DrawArea A = (DrawArea)(Area.Parent.Parent);
             A.RunAnimation();
    return; 
}


//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void CZ_PMPID_Rect_MAN_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect_MAN = (DrawRectangle)dynArgs.sender; 
   
    DrawArea A = (DrawArea)(Area.Parent.Parent);
             A.RunAnimation();

    Area.Variable[1] = "1";

	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;
	string tagName = Area.Variable[0] + "/MODE";

   if(CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType))
   {		
     if(dbValue == 1)
	 {
              Rect_MAN.EdgeColor = Color.White;
	      DrawText MAN = (DrawText)Area.GetDrawObj("MAN");
   	      MAN.ForegroundColor = Color.White;
          }
   }

    return; 
}


//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void CZ_PMPID_Rect_AUTO_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect_AUTO = (DrawRectangle)dynArgs.sender; 
   
    DrawArea A = (DrawArea)(Area.Parent.Parent);
             A.RunAnimation();

    Area.Variable[1] = "2";
    
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;
	string tagName = Area.Variable[0] + "/MODE";

   if(CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType))
   {		
     if(dbValue == 2)
	 {
              Rect_AUTO.EdgeColor = Color.White;
	      DrawText AUTO = (DrawText)Area.GetDrawObj("AUTO");
   	      AUTO.ForegroundColor = Color.White;
          }
   }

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void CZ_PMPID_Rect_CAS_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect_CAS = (DrawRectangle)dynArgs.sender; 
 
    DrawArea A = (DrawArea)(Area.Parent.Parent);
             A.RunAnimation();

    Area.Variable[1] = "3";
    
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;
	string tagName = Area.Variable[0] + "/MODE";

   if(CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType))
   {		
     if(dbValue == 3)
	 {
              Rect_CAS.EdgeColor = Color.White;
	      DrawText CAS = (DrawText)Area.GetDrawObj("CAS");
   	      CAS.ForegroundColor = Color.White;
          }
   }

    return; 
}


//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void CZ_PMPID_OP_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText OP = (DrawText)dynArgs.sender; 
   
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	int nDigit = 1;

	string strDigit = "f" + nDigit.ToString();
	
	string tagName = Area.Variable[0] + "/OP";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		OP.Caption = dbValue.ToString(strDigit);
	}
	else
		OP.Caption = "##.#";

    object obj = Area.GetControlObj("TB");
	
	TextBox TB = (TextBox)obj; 

          if(TB.Visible == false)

            {
                OP.ForegroundColor = Color.Yellow;
                DrawText Text_OP = (DrawText)Area.GetDrawObj("Text_OP");
                Text_OP.ForegroundColor = Color.Yellow;
            }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void CZ_PMPID_OP_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText OP = (DrawText)dynArgs.sender; 
 
    OP.ForegroundColor = Color.Yellow; 

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void CZ_PMPID_SP_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText SP = (DrawText)dynArgs.sender;
 
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
		SP.Caption = dbValue.ToString(strDigit);
	}
	else
		SP.Caption = "##.#";

    object obj = Area.GetControlObj("TB");
	
	TextBox TB = (TextBox)obj; 

          if(TB.Visible == false)

            {
                SP.ForegroundColor = Color.Cyan;
                DrawText Text_SP = (DrawText)Area.GetDrawObj("Text_SP");
                Text_SP.ForegroundColor = Color.Cyan;
            }


    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void CZ_PMPID_SP_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText SP = (DrawText)dynArgs.sender; 

    SP.ForegroundColor = Color.Cyan; 

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void CZ_PMPID_PV_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PV = (DrawText)dynArgs.sender; 
  
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
		PV.Caption = dbValue.ToString(strDigit);
	}
	else
		PV.Caption = "##.#";

    object obj = Area.GetControlObj("TB");
	
	TextBox TB = (TextBox)obj; 

          if(TB.Visible == false)

            {
                PV.ForegroundColor = Color.Cyan;
                DrawText Text_PV = (DrawText)Area.GetDrawObj("Text_PV");
                Text_PV.ForegroundColor = Color.Cyan;
            }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void CZ_PMPID_PV_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PV = (DrawText)dynArgs.sender; 
   
    PV.ForegroundColor = Color.Cyan;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void CZ_PMPID_TagComment_OnDynAnimation(Object sender, EventArgs e)
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
//Event Handler:OnDynAnimation 
public void CZ_PMPID_PVUnit_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVUnit = (DrawText)dynArgs.sender; 
   
    PVUnit.Caption = CommonFunction.GetPVUnit(Area.Variable[0]);

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void CZ_PMPID_TagName_OnDynAnimation(Object sender, EventArgs e)
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
//Event Handler:OnDynClick 
public void CZ_PMPID_Close_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle CLR = (DrawRectangle)dynArgs.sender; 
   
    (Area.Parent).Visible = false;

             CommonFunction._ProjectRelated.Var[0] = "NULL";
             CommonFunction._ProjectRelated.Var[1] = "NULL";

    Area.Variable[1] = "0";

    return; 
}
//Do not remove or update this comment
//Event Delegate:KeyEventHandler 
//Event Handler:KeyUp 
public void CZ_PMPID_TB_KeyUp(Object sender, KeyEventArgs e)
{
   TextBox TB = (TextBox)sender; 

   DrawArea Area = CommonFunction.GetThisDrawArea(TB);

     double dbValue = 0;
     int nValue = 0;
     bool bValue = false;
     int nDataType = 0;

     string MODE = Area.Variable[0] + "/MODE";
     bool ret = CommonFunction.GetValueWithType(MODE,ref dbValue,ref nValue,ref bValue,ref nDataType);

	switch ( e.KeyData )
	{
	case Keys.Enter:

		if(TB.Text == "" || TB.Text == null)

		{
			TB.Visible = false;
			TB.Enabled = false;
			return;
		}

		else

		{
			string PVInputValue = TB.Text;
			double dbPVValue = Convert.ToDouble(PVInputValue);

			object obj1 = CommonFunction.GetLabelOfControl(TB);

			if (obj1 != null)

			{
		             ControlLabel lab=(ControlLabel)obj1;
		             string tagName=lab.Variable[0];

                             //PV值只有在MODE是MAN的时候才可以改变
                             bool V = tagName.Contains("PV");
                             bool O = tagName.Contains("OP");
                             bool S = tagName.Contains("SP");
                             if(V == true)
                               {
                                 if(ret)

	                        {
				        CommonFunction.DSI_SetValue(tagName, dbPVValue);

	                        }

                               }

                             if(O == true)
                               {
                                 if(ret)

	                        {//OP值只有在MODE是MAN的时候才可以改变
	                 	  if(dbValue==1)

				    {
				        CommonFunction.DSI_SetValue(tagName, dbPVValue);}

	                	  else 
                                    {
                                             CommonFunction._ProjectRelated.Var[1] = "MODE ERROR";

                                    }
		
	                        }

                               }

                             if(S == true)
                               {
                                 if(ret)

	                        {//SP值只有在MODE是AUTO的时候才可以改变
	                 	  if(dbValue==2)

				    {
				        CommonFunction.DSI_SetValue(tagName, dbPVValue);}

	                	  else 
                                    {
                                            CommonFunction._ProjectRelated.Var[1] = "MODE ERROR";
                                    }
		
	                        }

                               }
			}      
                        TB.ForeColor = Color.Lime;
			TB.Visible = false;
			TB.Enabled = false;
                        return;
		}
		break;
	}

CommonFunction._ProjectRelated.Var[1] = "NULL";
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

    if(Caption1.Variable[0] == "TREND")
       {
        Caption1.Caption = "ENTER TREND NUMBER";
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

                        if(Caption1.Caption == "ENTER TREND NUMBER")

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

                              bool t = CommonFunction.OpenGraphic(Input, nTop, nLeft);
                              if(t == true)
                                  {
                                       CommonFunction.OpenGraphic(Input, nTop, nLeft);
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
                              int nLeft = 0;
                              int nTop = 0;
　                          　ArrayList list = new ArrayList();
                              string Input = TB.Text;
                              String groupnumber = "CG" + string.Format("{0:D4}",Convert.ToInt32(Input));

                              list = CommonFunction.GetGroupItems(groupnumber);

                              if(list == null)
                             {
                                  Caption2.Caption = "INVALID INPUT"; 
                                  return;
                              }
　　                         // string[] strVariable = new string[9];
　　                          string[] strVariable = (string[])list.ToArray(typeof(string));//ArrayList转换为string[]
　　                         CommonFunction._ProjectRelated.Var[2] = Input;//使用CommonFunction._ProjectRelated.Var[2]放置组号

                              bool g = CommonFunction.OpenPicture("TDC3000_ControlGroup", nTop, nLeft, strVariable);

                              if(g == true)

                                  { 
	                               CommonFunction.OpenPicture("TDC3000_ControlGroup", nTop, nLeft, strVariable);
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

                        if(Caption1.Caption == "ENTER TREND NUMBER")

                           {
                              int nLeft = 0;
                              int nTop = 0;
　                          　ArrayList list = new ArrayList();
                              string Input = TB.Text;
                              list = CommonFunction.GetGroupItems(Input);
　　                          string[] strVariable = (string[])list.ToArray(typeof(string));//ArrayList转换为string[]

                              bool g = CommonFunction.OpenPicture("TDC3000_TrendGroup", nTop, nLeft, strVariable);
                              if(g == true)

                                  { 
	                               CommonFunction.OpenPicture("TDC3000_TrendGroup", nTop, nLeft, strVariable);
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
