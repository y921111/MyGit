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
public class PIC_首页:IDynCodeAttachDetach
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
   strObjectName = "CZ_AI";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CZ_AI_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_AI.Text1";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CZ_AI_Text1_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_AI.Text1";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_AI_Text1_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_AI.Text1";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CZ_AI_Text1_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_AI.Rect2";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_AI_Rect2_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_AI.Rect1";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_AI_Rect1_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea7";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea7_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea7.PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea7_PV_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea7.PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea7_PV_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea7.TagName";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea7_TagName_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea6";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea6_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea6.PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea6_PV_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea6.PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea6_PV_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea6.TagName";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea6_TagName_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CZ_PMPID_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.CLR";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_PMPID_CLR_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.Rect_MAN";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CZ_PMPID_Rect_MAN_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.Rect_MAN";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CZ_PMPID_Rect_MAN_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.Rect_MAN";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_PMPID_Rect_MAN_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.Rect_MAN";
strEventName = "OnDynDblClick";
_EventHandler= (EventHandler)CZ_PMPID_Rect_MAN_OnDynDblClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.MAN";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CZ_PMPID_MAN_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.MAN";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CZ_PMPID_MAN_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.MAN";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_PMPID_MAN_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.MAN";
strEventName = "OnDynDblClick";
_EventHandler= (EventHandler)CZ_PMPID_MAN_OnDynDblClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.Rect_AUTO";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CZ_PMPID_Rect_AUTO_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.Rect_AUTO";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CZ_PMPID_Rect_AUTO_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.Rect_AUTO";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_PMPID_Rect_AUTO_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.Rect_AUTO";
strEventName = "OnDynDblClick";
_EventHandler= (EventHandler)CZ_PMPID_Rect_AUTO_OnDynDblClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.AUTO";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CZ_PMPID_AUTO_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.AUTO";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CZ_PMPID_AUTO_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.AUTO";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_PMPID_AUTO_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.AUTO";
strEventName = "OnDynDblClick";
_EventHandler= (EventHandler)CZ_PMPID_AUTO_OnDynDblClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.CAS";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CZ_PMPID_CAS_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.CAS";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CZ_PMPID_CAS_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.CAS";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_PMPID_CAS_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.CAS";
strEventName = "OnDynDblClick";
_EventHandler= (EventHandler)CZ_PMPID_CAS_OnDynDblClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.Rect_CAS";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CZ_PMPID_Rect_CAS_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.Rect_CAS";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CZ_PMPID_Rect_CAS_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.Rect_CAS";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_PMPID_Rect_CAS_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.Rect_CAS";
strEventName = "OnDynDblClick";
_EventHandler= (EventHandler)CZ_PMPID_Rect_CAS_OnDynDblClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.OP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CZ_PMPID_OP_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.OP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CZ_PMPID_OP_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.OP";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_PMPID_OP_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.SP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CZ_PMPID_SP_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.SP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CZ_PMPID_SP_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.SP";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_PMPID_SP_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CZ_PMPID_PV_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CZ_PMPID_PV_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.TagComment";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CZ_PMPID_TagComment_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.PVUnit";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CZ_PMPID_PVUnit_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.TagName";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CZ_PMPID_TagName_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.TagName";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_PMPID_TagName_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CZ_PMPID_TagName_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.Close";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_PMPID_Close_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.OPTB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)CZ_PMPID_OPTB_KeyUp;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "CZ_PMPID.SPTB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)CZ_PMPID_SPTB_KeyUp;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "TDC3000_Top.Text2";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TDC3000_Top_Text2_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);

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
strObjectName = "CZ_AI";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CZ_AI_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_AI.Text1";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CZ_AI_Text1_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_AI.Text1";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_AI_Text1_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_AI.Text1";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CZ_AI_Text1_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_AI.Rect2";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_AI_Rect2_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_AI.Rect1";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_AI_Rect1_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea7";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea7_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea7.PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea7_PV_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea7.PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea7_PV_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea7.TagName";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea7_TagName_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea6";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea6_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea6.PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea6_PV_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea6.PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea6_PV_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea6.TagName";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea6_TagName_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CZ_PMPID_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.CLR";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_PMPID_CLR_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.Rect_MAN";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CZ_PMPID_Rect_MAN_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.Rect_MAN";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CZ_PMPID_Rect_MAN_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.Rect_MAN";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_PMPID_Rect_MAN_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.Rect_MAN";
strEventName = "OnDynDblClick";
_EventHandler= (EventHandler)CZ_PMPID_Rect_MAN_OnDynDblClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.MAN";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CZ_PMPID_MAN_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.MAN";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CZ_PMPID_MAN_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.MAN";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_PMPID_MAN_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.MAN";
strEventName = "OnDynDblClick";
_EventHandler= (EventHandler)CZ_PMPID_MAN_OnDynDblClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.Rect_AUTO";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CZ_PMPID_Rect_AUTO_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.Rect_AUTO";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CZ_PMPID_Rect_AUTO_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.Rect_AUTO";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_PMPID_Rect_AUTO_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.Rect_AUTO";
strEventName = "OnDynDblClick";
_EventHandler= (EventHandler)CZ_PMPID_Rect_AUTO_OnDynDblClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.AUTO";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CZ_PMPID_AUTO_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.AUTO";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CZ_PMPID_AUTO_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.AUTO";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_PMPID_AUTO_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.AUTO";
strEventName = "OnDynDblClick";
_EventHandler= (EventHandler)CZ_PMPID_AUTO_OnDynDblClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.CAS";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CZ_PMPID_CAS_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.CAS";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CZ_PMPID_CAS_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.CAS";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_PMPID_CAS_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.CAS";
strEventName = "OnDynDblClick";
_EventHandler= (EventHandler)CZ_PMPID_CAS_OnDynDblClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.Rect_CAS";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CZ_PMPID_Rect_CAS_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.Rect_CAS";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CZ_PMPID_Rect_CAS_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.Rect_CAS";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_PMPID_Rect_CAS_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.Rect_CAS";
strEventName = "OnDynDblClick";
_EventHandler= (EventHandler)CZ_PMPID_Rect_CAS_OnDynDblClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.OP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CZ_PMPID_OP_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.OP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CZ_PMPID_OP_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.OP";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_PMPID_OP_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.SP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CZ_PMPID_SP_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.SP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CZ_PMPID_SP_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.SP";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_PMPID_SP_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CZ_PMPID_PV_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CZ_PMPID_PV_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.TagComment";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CZ_PMPID_TagComment_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.PVUnit";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CZ_PMPID_PVUnit_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.TagName";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CZ_PMPID_TagName_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.TagName";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_PMPID_TagName_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CZ_PMPID_TagName_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.Close";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_PMPID_Close_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.OPTB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)CZ_PMPID_OPTB_KeyUp;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "CZ_PMPID.SPTB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)CZ_PMPID_SPTB_KeyUp;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "TDC3000_Top.Text2";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TDC3000_Top_Text2_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);

    return;
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void CZ_AI_OnDynInitialize(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 
      
   Picture pic = (Picture)(Area.Parent);
   pic.FormBorderStyle = FormBorderStyle.None;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void CZ_AI_Text1_OnDynInitialize(Object sender, EventArgs e)	//TagName
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawText TagName = (DrawText)dynArgs.sender; 

        
	
	return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void CZ_AI_Text1_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText TagName = (DrawText)dynArgs.sender; 
 
	//CommonFunction.OpenDetail(Area.Variable[0]); 

	int nLeft = 0;
	int nTop = 0;
	string[] strVariable = new string[1];
	strVariable[0] = Area.Variable[0];
//	CommonFunction.OpenPicture("Pks_dfp_PID.grf", nTop, nLeft, strVariable);


 
    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void CZ_AI_Text1_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText TagName = (DrawText)dynArgs.sender; 
   
    string tagName = Area.Variable[0].ToUpper();

//        MessageBox.Show(Area.Variable[0].ToString());

	if(tagName != "")
		TagName.Caption = tagName;
	else
		TagName.Caption = "******";	

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void CZ_AI_Rect2_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect1 = (DrawRectangle)dynArgs.sender; 
   
    Area.Visible = false;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void CZ_AI_Rect1_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect1 = (DrawRectangle)dynArgs.sender; 
   
    Area.Visible = false;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void DrawArea7_OnDynClick(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 

   object obj = Area.Parent;
   
   Type type = obj.GetType();

	if ( type.Name != "Picture" )
	{
		DrawArea pic = (DrawArea)(Area.Parent);
		DrawArea D1 = (DrawArea)pic.GetDrawObj("CZ_PMPID");
                D1.Visible = true;

                D1.Variable[0] = Area.Variable[0];
                D1.Variable[1] = Area.Variable[1];
                D1.Variable[2] = Area.Variable[2];

		DrawArea D2 = (DrawArea)pic.GetDrawObj("CZ_AI");
                D2.Visible = false;

//MessageBox.Show(D1.Variable[0].ToString());
	}
	else
	{
		DrawArea pic = (DrawArea)(Area.Parent);
		DrawArea D1 = (DrawArea)pic.GetDrawObj("CZ_PMPID");
		D1.Visible = false;
	}

/*
   string strTagName = Area.Variable[0];
	CommonFunction.OpenFaceplate(strTagName);
	if(strTagName != "")
	{
		CommonFunction.OpenFaceplate(strTagName);
	}
*/
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void DrawArea7_PV_OnDynInitialize(Object sender, EventArgs e)
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

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void DrawArea7_PV_OnDynAnimation(Object sender, EventArgs e)
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

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void DrawArea7_TagName_OnDynInitialize(Object sender, EventArgs e)
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
public void DrawArea6_OnDynClick(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 

   object obj = Area.Parent;
   
   Type type = obj.GetType();

	if ( type.Name != "Picture" )
	{
		DrawArea pic = (DrawArea)(Area.Parent);
		DrawArea D1 = (DrawArea)pic.GetDrawObj("CZ_PMPID");
                D1.Visible = true;

                D1.Variable[0] = Area.Variable[0];
                D1.Variable[1] = Area.Variable[1];
                D1.Variable[2] = Area.Variable[2];

		DrawArea D2 = (DrawArea)pic.GetDrawObj("CZ_AI");
                D2.Visible = false;

//MessageBox.Show(D1.Variable[0].ToString());
	}
	else
	{
		DrawArea pic = (DrawArea)(Area.Parent);
		DrawArea D1 = (DrawArea)pic.GetDrawObj("CZ_PMPID");
		D1.Visible = false;
	}

/*
   string strTagName = Area.Variable[0];
	CommonFunction.OpenFaceplate(strTagName);
	if(strTagName != "")
	{
		CommonFunction.OpenFaceplate(strTagName);
	}
*/
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void DrawArea6_PV_OnDynInitialize(Object sender, EventArgs e)
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

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void DrawArea6_PV_OnDynAnimation(Object sender, EventArgs e)
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

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void DrawArea6_TagName_OnDynInitialize(Object sender, EventArgs e)
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
// =======================================================================
//
// 文件名：TDC3000_fp_PID.grf（二级面板）
// 
// 说明: PID面板
//
//
// 【调用时传入参数】
//		Area.Variable[0] - Tagname
//		Area.Variable[1] - Unit
//		Area.Variable[2] - communication
//		Area.Variable[3] - MODE
//		Area.Variable[4] - 1/0值
//
// 【更新时间】 
//		2012.08.16 hdd
// =======================================================================
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void CZ_PMPID_OnDynInitialize(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender;
/*
   object obj = Area.Parent;

//   object obj1 = Area.Parent.Parent;

	Type type = obj.GetType();

	if( type.Name == "Picture" )

	{ 
                Picture pic = (Picture)(Area.Parent);
		pic.FormBorderStyle = FormBorderStyle.None;

//                int nLeft = (pic.Parent).Left;
//	        int nTop = (pic.Parent).Top + (1 - Area.Height/(pic.Parent).Height) * (pic.Parent).Height;
                
//               pic.Location = new Point(0, 0);
	} 
*/
//   Area.Enabled = true;

	
	Picture pic = CommonFunction.GetThisPicture(Area);
	if(pic != null)
	{

		if(Area.BReference)//图素
		{
			//将顶级DrawArea的Variable[0]变量传递到图素级DrawArea：
			DrawArea MainArea = pic.GetDrawArea();
			Area.Variable[0] = MainArea.Variable[0];
//MessageBox.Show(Area.Variable[0].ToString());
                        Area.Variable[1] = MainArea.Variable[1];
                        Area.Variable[2] = MainArea.Variable[2];
                        Area.Variable[3] = MainArea.Variable[3];
                        Area.Variable[4] = MainArea.Variable[4];
                        Area.Variable[5] = MainArea.Variable[5];
                        Area.Variable[6] = MainArea.Variable[6];

			ControlLabel lab = (ControlLabel)CommonFunction.GetLabelOfControl(Area);
			lab.Selected = false;
			
		}
		else
		{
			pic.Text = Area.Variable[0];
		}
	}
	Area.Variable[0] = Area.Variable[0].ToUpper();
/*
   object obj = Area.Parent;
   
   Type type = obj.GetType();

	if ( type.Name != "Picture" )
	{
		DrawArea pic1 = (DrawArea)(Area.Parent);
		DrawArea D1 = (DrawArea)pic1.GetDrawObj("PMPID");
                Area.Variable[0] = D1.Variable[0];

		MessageBox.Show(D1.Variable[0].ToString());
	}
	else
	{
		Area.Visible = false;
	}
*/
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void CZ_PMPID_CLR_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText CLR = (DrawText)dynArgs.sender; 

    Area.Visible = false;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void CZ_PMPID_Rect_MAN_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect_MAN = (DrawRectangle)dynArgs.sender; 
   
    Rect_MAN.Variable[0] = "false";
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	string tagName = Area.Variable[0] + "/MODE";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		if(dbValue==1)

			Rect_MAN.EdgeColor = Color.Cyan;

		else 

			Rect_MAN.EdgeColor = Color.Lime;
		
	}
	else
			Rect_MAN.EdgeColor = Color.Lime;


    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void CZ_PMPID_Rect_MAN_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect_MAN = (DrawRectangle)dynArgs.sender; 
   
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	string tagName = Area.Variable[0] + "/MODE";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		if(Rect_MAN.Variable[0] == "false")

                 {
		    if(dbValue==1)

			Rect_MAN.EdgeColor = Color.Cyan;

		    else

			Rect_MAN.EdgeColor = Color.Lime;
                  }

                 else

                  {
                     if(dbValue==1)

			Rect_MAN.EdgeColor = Color.Cyan;

		    else

			Rect_MAN.EdgeColor = Color.White;

                  }
        }
		
	else
	{
           Rect_MAN.EdgeColor = Color.Lime;
        }
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
   
    Rect_MAN.Variable[0] = "true";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynDblClick 
public void CZ_PMPID_Rect_MAN_OnDynDblClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect_MAN = (DrawRectangle)dynArgs.sender; 
   
    string tagName = Area.Variable[0] + "/MODE";
    CommonFunction.DSI_SetValue(tagName, 1);
    Rect_MAN.Variable[0] = "false";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void CZ_PMPID_MAN_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText MAN = (DrawText)dynArgs.sender; 
   
    MAN.Variable[0] = "false";
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	string tagName = Area.Variable[0] + "/MODE";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		if(dbValue==1)

			MAN.ForegroundColor = Color.Cyan;

		else 

			MAN.ForegroundColor = Color.Lime;
		
	}
	else
			MAN.ForegroundColor = Color.Lime;



    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void CZ_PMPID_MAN_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText MAN = (DrawText)dynArgs.sender; 
   
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	string tagName = Area.Variable[0] + "/MODE";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		if(MAN.Variable[0] == "false")

                 {
		    if(dbValue==1)

			MAN.ForegroundColor = Color.Cyan;

		    else

			MAN.ForegroundColor = Color.Lime;
                  }

                 else

                  {
                     if(dbValue==1)

			MAN.ForegroundColor = Color.Cyan;

		    else

			MAN.ForegroundColor = Color.White;

                  }
        }
		
	else
	{
            MAN.ForegroundColor = Color.Lime;
        }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void CZ_PMPID_MAN_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText MAN = (DrawText)dynArgs.sender; 
   
    MAN.Variable[0] = "true";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynDblClick 
public void CZ_PMPID_MAN_OnDynDblClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText MAN = (DrawText)dynArgs.sender; 
   
    string tagName = Area.Variable[0] + "/MODE";
    CommonFunction.DSI_SetValue(tagName, 1);
    MAN.Variable[0] = "false";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void CZ_PMPID_Rect_AUTO_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect_AUTO = (DrawRectangle)dynArgs.sender; 
   
    Rect_AUTO.Variable[0] = "false";
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	string tagName = Area.Variable[0] + "/MODE";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		if(dbValue==2)

			Rect_AUTO.EdgeColor = Color.Cyan;

		else 

			Rect_AUTO.EdgeColor = Color.Lime;
		
	}
	else
			Rect_AUTO.EdgeColor = Color.Lime;


    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void CZ_PMPID_Rect_AUTO_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect_AUTO = (DrawRectangle)dynArgs.sender; 
   
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	string tagName = Area.Variable[0] + "/MODE";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		if(Rect_AUTO.Variable[0] == "false")

                 {
		    if(dbValue==2)

			Rect_AUTO.EdgeColor = Color.Cyan;

		    else

			Rect_AUTO.EdgeColor = Color.Lime;
                  }

                 else

                  {
                     if(dbValue==2)

			Rect_AUTO.EdgeColor = Color.Cyan;

		    else

			Rect_AUTO.EdgeColor = Color.White;

                  }
        }
		
	else
	{
            Rect_AUTO.EdgeColor = Color.Lime;
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
   
    Rect_AUTO.Variable[0] = "true";
 
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynDblClick 
public void CZ_PMPID_Rect_AUTO_OnDynDblClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect_AUTO = (DrawRectangle)dynArgs.sender; 
   
	       string tagName = Area.Variable[0] + "/MODE";
	       CommonFunction.DSI_SetValue(tagName, 2);
               Rect_AUTO.Variable[0] = "false";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void CZ_PMPID_AUTO_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText AUTO = (DrawText)dynArgs.sender; 

    AUTO.Variable[0] = "false";
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	string tagName = Area.Variable[0] + "/MODE";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		if(dbValue==2)

			AUTO.ForegroundColor = Color.Cyan;

		else 

			AUTO.ForegroundColor = Color.Lime;
		
	}
	else
			AUTO.ForegroundColor = Color.Lime;


    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void CZ_PMPID_AUTO_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText AUTO = (DrawText)dynArgs.sender; 
   
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	string tagName = Area.Variable[0] + "/MODE";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		if(AUTO.Variable[0] == "false")

                 {
		    if(dbValue==2)

			AUTO.ForegroundColor = Color.Cyan;

		    else

			AUTO.ForegroundColor = Color.Lime;
                  }

                 else

                  {
                     if(dbValue==2)

			AUTO.ForegroundColor = Color.Cyan;

		    else

			AUTO.ForegroundColor = Color.White;

                  }
        }
		
	else
	{
            AUTO.ForegroundColor = Color.Lime;
        }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void CZ_PMPID_AUTO_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText AUTO = (DrawText)dynArgs.sender; 
   
    AUTO.Variable[0] = "true";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynDblClick 
public void CZ_PMPID_AUTO_OnDynDblClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText AUTO = (DrawText)dynArgs.sender; 
   
	       string tagName = Area.Variable[0] + "/MODE";
	       CommonFunction.DSI_SetValue(tagName, 2);
               AUTO.Variable[0] = "false";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void CZ_PMPID_CAS_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText CAS = (DrawText)dynArgs.sender; 
   
    CAS.Variable[0] = "false";
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	string tagName = Area.Variable[0] + "/MODE";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		if(dbValue==3)

			CAS.ForegroundColor = Color.Cyan;

		else 

			CAS.ForegroundColor = Color.Lime;
		
	}
	else
			CAS.ForegroundColor = Color.Lime;

    return; 
}
 
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void CZ_PMPID_CAS_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText CAS = (DrawText)dynArgs.sender; 
   
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	string tagName = Area.Variable[0] + "/MODE";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
                if(CAS.Variable[0] == "false")

                 {
		    if(dbValue==3)

			CAS.ForegroundColor = Color.Cyan;

		    else

			CAS.ForegroundColor = Color.Lime;
                  }

                 else

                  {
                     if(dbValue==3)

			CAS.ForegroundColor = Color.Cyan;

		    else

			CAS.ForegroundColor = Color.White;

                  }
		
	}
	else
			CAS.ForegroundColor = Color.Lime;

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void CZ_PMPID_CAS_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText CAS = (DrawText)dynArgs.sender; 

    CAS.Variable[0] = "true";
   
    return; 
}
 

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynDblClick 
public void CZ_PMPID_CAS_OnDynDblClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText CAS = (DrawText)dynArgs.sender; 
   
	       string tagName = Area.Variable[0] + "/MODE";
	       CommonFunction.DSI_SetValue(tagName, 3);
               CAS.Variable[0] = "false";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void CZ_PMPID_Rect_CAS_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect_CAS = (DrawRectangle)dynArgs.sender; 

    Rect_CAS.Variable[0] = "false";
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	string tagName = Area.Variable[0] + "/MODE";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		if(dbValue==3)

			Rect_CAS.EdgeColor = Color.Cyan;

		else 

			Rect_CAS.EdgeColor = Color.Lime;
		
	}
	else
			Rect_CAS.EdgeColor = Color.Lime;

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void CZ_PMPID_Rect_CAS_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect_CAS = (DrawRectangle)dynArgs.sender; 
   
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	string tagName = Area.Variable[0] + "/MODE";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		if(Rect_CAS.Variable[0] == "false")

                 {
		    if(dbValue==3)

			Rect_CAS.EdgeColor = Color.Cyan;

		    else

			Rect_CAS.EdgeColor = Color.Lime;
                  }

                 else

                  {
                     if(dbValue==3)

			Rect_CAS.EdgeColor = Color.Cyan;

		    else

			Rect_CAS.EdgeColor = Color.White;

                  }
	}
	else
			Rect_CAS.EdgeColor = Color.Lime;

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
 
    Rect_CAS.Variable[0] = "true";
  
    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynDblClick 
public void CZ_PMPID_Rect_CAS_OnDynDblClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect_CAS = (DrawRectangle)dynArgs.sender; 

	       string tagName = Area.Variable[0] + "/MODE";
	       CommonFunction.DSI_SetValue(tagName, 3);
               Rect_CAS.Variable[0] = "false";
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

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void CZ_PMPID_OP_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText OP = (DrawText)dynArgs.sender; 
   
    if(OP.Visible == true)

	{
		// 不弹出输入面板，DrawText隐藏，TextBox显示	
		object obj = Area.GetControlObj("OPTB");
		if(obj != null)
		{
			TextBox OPTB = (TextBox)obj; 
			if(OPTB != null)
			{
				OPTB.Visible = true;
				OPTB.Enabled = true;
				OPTB.Text = "";
				OPTB.Focus();
				
				obj = CommonFunction.GetLabelOfControl(OPTB);
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
	
	tagName = Area.Variable[0] + "/PV";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		SP.Caption = dbValue.ToString(strDigit);
	}
	else
		SP.Caption = "##.#";


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
		SP.Caption = dbValue.ToString(strDigit);
	}
	else
		SP.Caption = "##.#";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void CZ_PMPID_SP_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText SP = (DrawText)dynArgs.sender; 
   
    if(SP.Visible == true)

	{
		// 不弹出输入面板，DrawText隐藏，TextBox显示	
		object obj = Area.GetControlObj("SPTB");
		if(obj != null)
		{
			TextBox SPTB = (TextBox)obj; 
			if(SPTB != null)
			{
				SPTB.Visible = true;
				SPTB.Enabled = true;
				SPTB.Text = "";
				SPTB.Focus();
				
				obj = CommonFunction.GetLabelOfControl(SPTB);
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
//Event Handler:OnDynInitialize 
public void CZ_PMPID_TagName_OnDynInitialize(Object sender, EventArgs e)	//TagName
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawText TagName = (DrawText)dynArgs.sender; 

        
	
	return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void CZ_PMPID_TagName_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText TagName = (DrawText)dynArgs.sender; 
 
	//CommonFunction.OpenDetail(Area.Variable[0]); 

	int nLeft = 0;
	int nTop = 0;
	string[] strVariable = new string[1];
	strVariable[0] = Area.Variable[0];
//	CommonFunction.OpenPicture("Pks_dfp_PID.grf", nTop, nLeft, strVariable);


 
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

//        MessageBox.Show(Area.Variable[0].ToString());

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
   
    Area.Visible = false;

    return; 
}
//Do not remove or update this comment
//Event Delegate:KeyEventHandler 
//Event Handler:KeyUp 
public void CZ_PMPID_OPTB_KeyUp(Object sender, KeyEventArgs e)
{
   TextBox OPTB = (TextBox)sender; 

	DrawArea Area = CommonFunction.GetThisDrawArea(OPTB);

	DrawText SP = (DrawText)Area.GetDrawObj("SP");
	DrawText OP = (DrawText)Area.GetDrawObj("OP");

	switch ( e.KeyData )
	{
	case Keys.Enter:

		if(OPTB.Text == "" || OPTB.Text == null)

		{
			OPTB.Visible = false;
			OPTB.Enabled = false;
			SP.Visible = true;
			OP.Visible = true;
			return;
		}

		else

		{
			string SPInputValue = OPTB.Text;
			double dbSPValue = Convert.ToDouble(SPInputValue);

			object obj = CommonFunction.GetLabelOfControl(OPTB);

			if (obj != null)

			{
				ControlLabel lab = (ControlLabel)obj;
				string tagName = lab.Variable[0];
				CommonFunction.DSI_SetValue(tagName, dbSPValue);
			}

			OPTB.Visible = false;
			OPTB.Enabled = false;
			SP.Visible = true;
			OP.Visible = true;
		}
		break;
	}
   
    return; 
}
//Do not remove or update this comment
//Event Delegate:KeyEventHandler 
//Event Handler:KeyUp 
public void CZ_PMPID_SPTB_KeyUp(Object sender, KeyEventArgs e)
{
   TextBox SPTB = (TextBox)sender; 
   
DrawArea Area = CommonFunction.GetThisDrawArea(SPTB);

	DrawText SP = (DrawText)Area.GetDrawObj("SP");
	DrawText OP = (DrawText)Area.GetDrawObj("OP");

	switch ( e.KeyData )
	{
	case Keys.Enter:

		if(SPTB.Text == "" || SPTB.Text == null)

		{
			SPTB.Visible = false;
			SPTB.Enabled = false;
			SP.Visible = true;
			OP.Visible = true;
			return;
		}

		else

		{
			string SPInputValue = SPTB.Text;
			double dbSPValue = Convert.ToDouble(SPInputValue);

			object obj = CommonFunction.GetLabelOfControl(SPTB);

			if (obj != null)

			{
				ControlLabel lab = (ControlLabel)obj;
				string tagName = lab.Variable[0];
				CommonFunction.DSI_SetValue(tagName, dbSPValue);
			}

			SPTB.Visible = false;
			SPTB.Enabled = false;
			SP.Visible = true;
			OP.Visible = true;
		}
		break;
	}
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

}
