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
public class PIC_ChangeZone:IDynCodeAttachDetach
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
_EventHandler= (EventHandler)PIC_ChangeZone_OnDynInitialize;
CodeDomCommon.AttachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PIC_ChangeZone_OnDynAnimation;
CodeDomCommon.AttachAreaEventHandler(area,strEventName,_EventHandler);
strObjectName = "PMDIGCOM";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PMDIGCOM_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMDIGCOM";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PMDIGCOM_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMDIGCOM";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)PMDIGCOM_KeyUp;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "PMDIGCOM.Rect_ON";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PMDIGCOM_Rect_ON_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMDIGCOM.Rect_OFF";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PMDIGCOM_Rect_OFF_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMDIGCOM.Rect_SPACE";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PMDIGCOM_Rect_SPACE_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMDIGCOM.TagComment";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PMDIGCOM_TagComment_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMDIGCOM.TagComment";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PMDIGCOM_TagComment_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMDIGCOM.TagName";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PMDIGCOM_TagName_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMDIGCOM.TagName";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PMDIGCOM_TagName_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMDIGCOM.TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PMDIGCOM_TagName_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMDIGCOM.Close";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PMDIGCOM_Close_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMANLIN";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PMANLIN_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMANLIN";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PMANLIN_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMANLIN";
strEventName = "Disposed";
_EventHandler= (EventHandler)PMANLIN_Disposed;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMANLIN";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PMANLIN_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMANLIN";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)PMANLIN_KeyUp;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "PMANLIN.Text_PVEUHI";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PMANLIN_Text_PVEUHI_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMANLIN.Text_PVEUHI";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PMANLIN_Text_PVEUHI_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMANLIN.Text_PVEULO";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PMANLIN_Text_PVEULO_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMANLIN.Text_PVEULO";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PMANLIN_Text_PVEULO_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMANLIN.Text_PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PMANLIN_Text_PV_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMANLIN.Text_PV";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PMANLIN_Text_PV_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMANLIN.PA_Rectangle";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PMANLIN_PA_Rectangle_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMANLIN.PVEUHI";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PMANLIN_PVEUHI_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMANLIN.PVEUHI";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PMANLIN_PVEUHI_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMANLIN.PVEUHI";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PMANLIN_PVEUHI_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMANLIN.PVEULO";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PMANLIN_PVEULO_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMANLIN.PVEULO";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PMANLIN_PVEULO_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMANLIN.PVEULO";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PMANLIN_PVEULO_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMANLIN.PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PMANLIN_PV_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMANLIN.PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PMANLIN_PV_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMANLIN.PV";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PMANLIN_PV_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMANLIN.TagComment";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PMANLIN_TagComment_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMANLIN.TagComment";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PMANLIN_TagComment_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMANLIN.PVUnit";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PMANLIN_PVUnit_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMANLIN.PVUnit";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PMANLIN_PVUnit_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMANLIN.PVUnit";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PMANLIN_PVUnit_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMANLIN.TagName";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PMANLIN_TagName_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMANLIN.TagName";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PMANLIN_TagName_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMANLIN.TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PMANLIN_TagName_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMANLIN.Close";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PMANLIN_Close_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMANLIN.TB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)PMANLIN_TB_KeyUp;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "PMPID";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PMPID_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMPID";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PMPID_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMPID";
strEventName = "Disposed";
_EventHandler= (EventHandler)PMPID_Disposed;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMPID";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PMPID_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMPID";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)PMPID_KeyUp;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "PMPID.Text_OP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PMPID_Text_OP_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMPID.Text_OP";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PMPID_Text_OP_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMPID.Text_SP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PMPID_Text_SP_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMPID.Text_SP";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PMPID_Text_SP_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMPID.Text_PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PMPID_Text_PV_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMPID.Text_PV";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PMPID_Text_PV_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMPID.PA_Rectangle";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PMPID_PA_Rectangle_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMPID.Rect_PROG";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PMPID_Rect_PROG_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMPID.Rect_MAN";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PMPID_Rect_MAN_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMPID.Rect_AUTO";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PMPID_Rect_AUTO_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMPID.Rect_CAS";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PMPID_Rect_CAS_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMPID.OP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PMPID_OP_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMPID.OP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PMPID_OP_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMPID.OP";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PMPID_OP_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMPID.SP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PMPID_SP_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMPID.SP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PMPID_SP_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMPID.SP";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PMPID_SP_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMPID.PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PMPID_PV_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMPID.PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PMPID_PV_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMPID.PV";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PMPID_PV_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMPID.TagComment";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PMPID_TagComment_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMPID.TagComment";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PMPID_TagComment_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMPID.PVUnit";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PMPID_PVUnit_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMPID.PVUnit";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PMPID_PVUnit_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMPID.PVUnit";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PMPID_PVUnit_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMPID.TagName";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PMPID_TagName_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMPID.TagName";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PMPID_TagName_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMPID.TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PMPID_TagName_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMPID.Close";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PMPID_Close_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMPID.TB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)PMPID_TB_KeyUp;
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
_EventHandler= (EventHandler)PIC_ChangeZone_OnDynInitialize;
CodeDomCommon.DetachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PIC_ChangeZone_OnDynAnimation;
CodeDomCommon.DetachAreaEventHandler(area,strEventName,_EventHandler);
strObjectName = "PMDIGCOM";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PMDIGCOM_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMDIGCOM";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PMDIGCOM_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMDIGCOM";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)PMDIGCOM_KeyUp;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "PMDIGCOM.Rect_ON";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PMDIGCOM_Rect_ON_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMDIGCOM.Rect_OFF";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PMDIGCOM_Rect_OFF_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMDIGCOM.Rect_SPACE";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PMDIGCOM_Rect_SPACE_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMDIGCOM.TagComment";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PMDIGCOM_TagComment_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMDIGCOM.TagComment";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PMDIGCOM_TagComment_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMDIGCOM.TagName";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PMDIGCOM_TagName_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMDIGCOM.TagName";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PMDIGCOM_TagName_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMDIGCOM.TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PMDIGCOM_TagName_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMDIGCOM.Close";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PMDIGCOM_Close_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMANLIN";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PMANLIN_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMANLIN";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PMANLIN_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMANLIN";
strEventName = "Disposed";
_EventHandler= (EventHandler)PMANLIN_Disposed;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMANLIN";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PMANLIN_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMANLIN";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)PMANLIN_KeyUp;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "PMANLIN.Text_PVEUHI";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PMANLIN_Text_PVEUHI_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMANLIN.Text_PVEUHI";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PMANLIN_Text_PVEUHI_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMANLIN.Text_PVEULO";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PMANLIN_Text_PVEULO_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMANLIN.Text_PVEULO";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PMANLIN_Text_PVEULO_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMANLIN.Text_PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PMANLIN_Text_PV_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMANLIN.Text_PV";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PMANLIN_Text_PV_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMANLIN.PA_Rectangle";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PMANLIN_PA_Rectangle_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMANLIN.PVEUHI";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PMANLIN_PVEUHI_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMANLIN.PVEUHI";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PMANLIN_PVEUHI_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMANLIN.PVEUHI";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PMANLIN_PVEUHI_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMANLIN.PVEULO";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PMANLIN_PVEULO_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMANLIN.PVEULO";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PMANLIN_PVEULO_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMANLIN.PVEULO";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PMANLIN_PVEULO_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMANLIN.PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PMANLIN_PV_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMANLIN.PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PMANLIN_PV_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMANLIN.PV";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PMANLIN_PV_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMANLIN.TagComment";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PMANLIN_TagComment_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMANLIN.TagComment";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PMANLIN_TagComment_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMANLIN.PVUnit";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PMANLIN_PVUnit_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMANLIN.PVUnit";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PMANLIN_PVUnit_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMANLIN.PVUnit";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PMANLIN_PVUnit_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMANLIN.TagName";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PMANLIN_TagName_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMANLIN.TagName";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PMANLIN_TagName_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMANLIN.TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PMANLIN_TagName_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMANLIN.Close";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PMANLIN_Close_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMANLIN.TB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)PMANLIN_TB_KeyUp;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "PMPID";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PMPID_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMPID";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PMPID_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMPID";
strEventName = "Disposed";
_EventHandler= (EventHandler)PMPID_Disposed;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMPID";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PMPID_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMPID";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)PMPID_KeyUp;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "PMPID.Text_OP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PMPID_Text_OP_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMPID.Text_OP";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PMPID_Text_OP_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMPID.Text_SP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PMPID_Text_SP_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMPID.Text_SP";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PMPID_Text_SP_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMPID.Text_PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PMPID_Text_PV_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMPID.Text_PV";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PMPID_Text_PV_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMPID.PA_Rectangle";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PMPID_PA_Rectangle_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMPID.Rect_PROG";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PMPID_Rect_PROG_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMPID.Rect_MAN";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PMPID_Rect_MAN_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMPID.Rect_AUTO";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PMPID_Rect_AUTO_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMPID.Rect_CAS";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PMPID_Rect_CAS_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMPID.OP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PMPID_OP_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMPID.OP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PMPID_OP_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMPID.OP";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PMPID_OP_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMPID.SP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PMPID_SP_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMPID.SP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PMPID_SP_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMPID.SP";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PMPID_SP_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMPID.PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PMPID_PV_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMPID.PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PMPID_PV_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMPID.PV";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PMPID_PV_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMPID.TagComment";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PMPID_TagComment_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMPID.TagComment";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PMPID_TagComment_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMPID.PVUnit";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PMPID_PVUnit_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMPID.PVUnit";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PMPID_PVUnit_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMPID.PVUnit";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PMPID_PVUnit_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMPID.TagName";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PMPID_TagName_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMPID.TagName";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PMPID_TagName_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMPID.TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PMPID_TagName_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMPID.Close";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PMPID_Close_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PMPID.TB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)PMPID_TB_KeyUp;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);

    return;
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void PIC_ChangeZone_OnDynInitialize(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 

    if(Area.BReference)
      {Area.Enabled = true;}//使作为图素时可以使用

    DrawArea PMPID = (DrawArea)Area.GetDrawObj("PMPID");
    PMPID.Visible = false;

    DrawArea PMANLIN = (DrawArea)Area.GetDrawObj("PMANLIN");
    PMANLIN.Visible = false;

    DrawArea PMDIGCOM = (DrawArea)Area.GetDrawObj("PMDIGCOM");
    PMANLIN.Visible = false;
 
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void PIC_ChangeZone_OnDynAnimation(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 
   
    DrawArea PMPID = (DrawArea)Area.GetDrawObj("PMPID");
    DrawArea PMANLIN = (DrawArea)Area.GetDrawObj("PMANLIN");
    DrawArea PMDIGCOM = (DrawArea)Area.GetDrawObj("PMDIGCOM");



    String alg = CommonFunction.GetTagAlgName(Area.Variable[0]);

    if(alg != "" || alg != null)

        {
             if(alg == "PMPID")

                {
                     PMPID.Variable[0] = Area.Variable[0];
                     PMPID.Visible = true;
                     PMANLIN.Visible = false;
                     PMDIGCOM.Visible = false;
                }

             else if(alg == "PMANLIN")

                {
                     PMANLIN.Variable[0] = Area.Variable[0];
                     PMANLIN.Visible = true;
                     PMPID.Visible = false;
                     PMDIGCOM.Visible = false;
                }

             else if(alg == "PMDIGCOM")

                {
                     PMDIGCOM.Variable[0] = Area.Variable[0];
                     PMDIGCOM.Visible = true;
                     PMPID.Visible = false;
                     PMANLIN.Visible = false;
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
public void PMDIGCOM_OnDynInitialize(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender;

	Area.Variable[0] = Area.Variable[0].ToUpper();

////////////////////////////////////////////////////////////////////////////////传值
////////////////////////////////////////////////////////////////////////////////传值
	Picture pic = CommonFunction.GetThisPicture(Area);
	if(pic != null)
	{

		if(Area.BReference)//图素
		{
                      Area.Enabled = true;

			//将顶级DrawArea的Variable[0]变量传递到图素级DrawArea：
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

        DrawArea picT = (DrawArea)(Area.Parent.Parent);
        DrawArea Top = (DrawArea)picT.GetDrawObj("TDC3000_Top");
        Top.Variable[3] = "";

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
public void PMDIGCOM_OnDynAnimation(Object sender, EventArgs e)
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

        DrawArea picT = (DrawArea)(Area.Parent.Parent);
        DrawArea Top = (DrawArea)picT.GetDrawObj("TDC3000_Top");

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
                         Top.Variable[3] = "PRESS ENTER TO EXECUTE";
                         Top.Variable[4] = "";
		 }
		 else if(Area.Variable[1] == "3")
		 {
			 SPACE.ForegroundColor = Color.White;
                         Rect_SPACE.EdgeColor = Color.White;
                         Top.Variable[3] = "PRESS ENTER TO EXECUTE";
                         Top.Variable[4] = "";
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
                         Top.Variable[3] = "PRESS ENTER TO EXECUTE";
                         Top.Variable[4] = "";
		 }
		 else if(Area.Variable[1] == "3")
		 {
			 SPACE.ForegroundColor = Color.White;
                         Rect_SPACE.EdgeColor = Color.White;
                         Top.Variable[3] = "PRESS ENTER TO EXECUTE";
                         Top.Variable[4] = "";
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
                         Top.Variable[3] = "PRESS ENTER TO EXECUTE";
                         Top.Variable[4] = "";
		 }
		 else if(Area.Variable[1] == "2")
		 {
			 OFF.ForegroundColor = Color.White;
                         Rect_OFF.EdgeColor = Color.White;
                         Top.Variable[3] = "PRESS ENTER TO EXECUTE";
                         Top.Variable[4] = "";
		 }
	 }
      }

   return; 
}

//Do not remove or update this comment
//Event Delegate:KeyEventHandler 
//Event Handler:KeyUp 
public void PMDIGCOM_KeyUp(Object sender, KeyEventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   string tagName = Area.Variable[0] + "/OP";

        DrawArea picT = (DrawArea)(Area.Parent.Parent);
        DrawArea Top = (DrawArea)picT.GetDrawObj("TDC3000_Top");


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

                              ////////////////Top的显示

                                     Top.Variable[3] = "";
                                     //Top.Variable[4] = "";

                             ////////////////Top的显示

                          Area.Variable[1] = "0";

	                 break;
                      } 
         }
         
    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void PMDIGCOM_Rect_ON_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect_ON = (DrawRectangle)dynArgs.sender; 
   
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
public void PMDIGCOM_Rect_OFF_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect_OFF = (DrawRectangle)dynArgs.sender; 
   
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
public void PMDIGCOM_Rect_SPACE_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect_SPACE = (DrawRectangle)dynArgs.sender; 
   
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
public void PMDIGCOM_TagComment_OnDynAnimation(Object sender, EventArgs e)
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
public void PMDIGCOM_TagComment_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText TagComment = (DrawText)dynArgs.sender; 
   
	int nLeft = 0;
	int nTop = 0;
	string[] strVariable = new string[1];
	strVariable[0] = Area.Variable[0];
	CommonFunction.OpenPicture("CZ_PMPID_Detail.grf", nTop, nLeft, strVariable);

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void PMDIGCOM_TagName_OnDynInitialize(Object sender, EventArgs e)	//TagName
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
public void PMDIGCOM_TagName_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText TagName = (DrawText)dynArgs.sender; 
 
	//CommonFunction.OpenDetail(Area.Variable[0]); 

	int nLeft = 0;
	int nTop = 0;
	string[] strVariable = new string[1];
	strVariable[0] = Area.Variable[0];
	CommonFunction.OpenPicture("CZ_PMDIGCOM_Detail.grf", nTop, nLeft, strVariable);
 	//CommonFunction.OpenDetail(Area.Variable[0]);
    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void PMDIGCOM_TagName_OnDynAnimation(Object sender, EventArgs e)
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
public void PMDIGCOM_Close_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle CLR = (DrawRectangle)dynArgs.sender; 
   
        DrawArea picT = (DrawArea)(Area.Parent.Parent);
        DrawArea Top = (DrawArea)picT.GetDrawObj("TDC3000_Top");

    (Area.Parent).Visible = false;

    Top.Variable[3] = "";
    Top.Variable[4] = "";

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
public void PMANLIN_OnDynInitialize(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender;

	Area.Variable[0] = Area.Variable[0].ToUpper();

////////////////////////////////////////////////////////////////////////////////传值
////////////////////////////////////////////////////////////////////////////////传值
	Picture pic = CommonFunction.GetThisPicture(Area);
	if(pic != null)
	{

		if(Area.BReference)//图素
		{
                      Area.Enabled = true;
		      TextBox TB = (TextBox)Area.GetDrawObj("TB");

		        if(TB.CanFocus)
			{
				TB.Focus();
			}
			else
			{
				Area.Enabled = true;	//首先确保PVTB的容器Area的Enabled为True，否则TB.CanFocus=false；
				TB.Enabled = true;
				TB.Visible = false;
				TB.Focus();
			}

			//将顶级DrawArea的Variable[0]变量传递到图素级DrawArea：
			DrawArea MainArea = pic.GetDrawArea();
			Area.Variable[0] = MainArea.Variable[0];
//MessageBox.Show(Area.Variable[0].ToString());

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


        DrawArea picT = (DrawArea)(Area.Parent.Parent);
        DrawArea Top = (DrawArea)picT.GetDrawObj("TDC3000_Top");
        Top.Variable[3] = "";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void PMANLIN_OnDynAnimation(Object sender, EventArgs e)
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

        DrawArea picT = (DrawArea)(Area.Parent.Parent);
        DrawArea Top = (DrawArea)picT.GetDrawObj("TDC3000_Top");

     if(Area.Variable[1] == "4")
     {
	 PTXST.ForegroundColor = Color.White;
         ACTIVE.ForegroundColor = Color.White;
         PA_Rectangle.EdgeColor = Color.White;  
         Top.Variable[3] = "PRESS ENTER TO EXECUTE"; 
         Top.Variable[4] = "";  
     }
 
     if(Area.Variable[1] == "5")
     {
         Top.Variable[4] = "NOT EMULATION"; 
         Top.Variable[3] = "";  
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
//Event Handler:Disposed 
public void PMANLIN_Disposed(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 

   TextBox TB = (TextBox)Area.GetDrawObj("TB");
   TB.Enabled = false;
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void PMANLIN_OnDynClick(Object sender, EventArgs e)
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
public void PMANLIN_KeyUp(Object sender, KeyEventArgs e)
{
   DrawArea Area = (DrawArea)sender; 

        DrawArea picT = (DrawArea)(Area.Parent.Parent);
        DrawArea Top = (DrawArea)picT.GetDrawObj("TDC3000_Top");

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

                              ////////////////Top的显示

                                     Top.Variable[3] = "";
                                     //Top.Variable[4] = "";

                             ////////////////Top的显示

                          Area.Variable[1] = "0";

	                 break;
                      } 
         
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void PMANLIN_Text_PVEUHI_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText Text_PVEUHI = (DrawText)dynArgs.sender; 
   
    Text_PVEUHI.ForegroundColor = Color.Lime;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void PMANLIN_Text_PVEUHI_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText Text_PVEUHI = (DrawText)dynArgs.sender; 
   
    DrawText PVEUHI = (DrawText)Area.GetDrawObj("PVEUHI");

    Area.Variable[1] = "8"; 

    if(Text_PVEUHI.Visible == true)

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
//Event Handler:OnDynInitialize 
public void PMANLIN_Text_PVEULO_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText Text_PVEULO = (DrawText)dynArgs.sender; 
   
    Text_PVEULO.ForegroundColor = Color.Lime;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void PMANLIN_Text_PVEULO_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText Text_PVEULO = (DrawText)dynArgs.sender; 
   
    DrawText PVEULO = (DrawText)Area.GetDrawObj("PVEULO");

    Area.Variable[1] = "7"; 

    if(Text_PVEULO.Visible == true)

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
				CommonFunction.MoveControl(Area,TB,(int)(PVEULO.VerticalPosition)+30,(int)(PVEULO.HorizontalPosition)+40);
			
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
//Event Handler:OnDynInitialize 
public void PMANLIN_Text_PV_OnDynInitialize(Object sender, EventArgs e)
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
public void PMANLIN_Text_PV_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText Text_PV = (DrawText)dynArgs.sender; 
   
    DrawText PV = (DrawText)Area.GetDrawObj("PV");

    Area.Variable[1] = "6"; 

    if(Text_PV.Visible == true)

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
public void PMANLIN_PA_Rectangle_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle PA_Rectangle = (DrawRectangle)dynArgs.sender; 

    Area.Variable[1] = "4";  
 
     return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void PMANLIN_PVEUHI_OnDynAnimation(Object sender, EventArgs e)
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
public void PMANLIN_PVEUHI_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVEUHI = (DrawText)dynArgs.sender; 
 
    PVEUHI.ForegroundColor = Color.Lime; 
  
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

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void PMANLIN_PVEUHI_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVEUHI = (DrawText)dynArgs.sender; 
   
    Area.Variable[1] = "8"; 

    if(PVEUHI.Visible == true)

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
//Event Handler:OnDynAnimation 
public void PMANLIN_PVEULO_OnDynAnimation(Object sender, EventArgs e)
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
public void PMANLIN_PVEULO_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVEULO = (DrawText)dynArgs.sender; 

    PVEULO.ForegroundColor = Color.Lime; 
   
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

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void PMANLIN_PVEULO_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVEULO = (DrawText)dynArgs.sender; 
   
    Area.Variable[1] = "7"; 

    if(PVEULO.Visible == true)

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
//Event Handler:OnDynAnimation 
public void PMANLIN_PV_OnDynAnimation(Object sender, EventArgs e)
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
public void PMANLIN_PV_OnDynInitialize(Object sender, EventArgs e)
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
//Event Handler:OnDynClick 
public void PMANLIN_PV_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PV = (DrawText)dynArgs.sender; 

    Area.Variable[1] = "6"; 

    if(PV.Visible == true)

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
//Event Handler:OnDynAnimation 
public void PMANLIN_TagComment_OnDynAnimation(Object sender, EventArgs e)
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
public void PMANLIN_TagComment_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText TagComment = (DrawText)dynArgs.sender; 
   
	int nLeft = 0;
	int nTop = 0;
	string[] strVariable = new string[1];
	strVariable[0] = Area.Variable[0];
	CommonFunction.OpenDetail(Area.Variable[0]); 

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void PMANLIN_PVUnit_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVUnit = (DrawText)dynArgs.sender; 
   
    PVUnit.Caption = CommonFunction.GetPVUnit(Area.Variable[0]);

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void PMANLIN_PVUnit_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVUnit = (DrawText)dynArgs.sender; 
   
	int nLeft = 0;
	int nTop = 0;
	string[] strVariable = new string[1];
	strVariable[0] = Area.Variable[0];
        CommonFunction.OpenDetail(Area.Variable[0]); 

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void PMANLIN_PVUnit_OnDynInitialize(Object sender, EventArgs e)
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
public void PMANLIN_TagName_OnDynInitialize(Object sender, EventArgs e)	//TagName
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
public void PMANLIN_TagName_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText TagName = (DrawText)dynArgs.sender; 

	int nLeft = 0;
	int nTop = 0;
	string[] strVariable = new string[1];
	strVariable[0] = Area.Variable[0];
//        CommonFunction.OpenDetail(Area.Variable[0]); 
	CommonFunction.OpenPicture("CZ_PMANLIN_Detail.grf", nTop, nLeft, strVariable);
 
    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void PMANLIN_TagName_OnDynAnimation(Object sender, EventArgs e)
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
public void PMANLIN_Close_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle CLR = (DrawRectangle)dynArgs.sender; 
   
        DrawArea picT = (DrawArea)(Area.Parent.Parent);
        DrawArea Top = (DrawArea)picT.GetDrawObj("TDC3000_Top");

    (Area.Parent).Visible = false;

    Top.Variable[3] = "";
    Top.Variable[4] = "";

    Area.Variable[1] = "0";

    return; 
}
//Do not remove or update this comment
//Event Delegate:KeyEventHandler 
//Event Handler:KeyUp 
public void PMANLIN_TB_KeyUp(Object sender, KeyEventArgs e)
{
   TextBox TB = (TextBox)sender; 

   DrawArea Area = CommonFunction.GetThisDrawArea(TB);

/*     double dbValue = 0;
     int nValue = 0;
     bool bValue = false;
     int nDataType = 0;

     string MODE = Area.Variable[0] + "/MODE";
     bool ret = CommonFunction.GetValueWithType(MODE,ref dbValue,ref nValue,ref bValue,ref nDataType);
*/
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
public void PMPID_OnDynInitialize(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender;

	Area.Variable[0] = Area.Variable[0].ToUpper();

////////////////////////////////////////////////////////////////////////////////传值
////////////////////////////////////////////////////////////////////////////////传值
	Picture pic = CommonFunction.GetThisPicture(Area);
	if(pic != null)
	{

		if(Area.BReference)//图素
		{
                      Area.Enabled = true;
		      TextBox TB = (TextBox)Area.GetDrawObj("TB");

		        if(TB.CanFocus)
			{
				TB.Focus();
			}
			else
			{
				Area.Enabled = true;	//首先确保PVTB的容器Area的Enabled为True，否则TB.CanFocus=false；
				TB.Enabled = true;
				TB.Visible = false;
				TB.Focus();
			}

			//将顶级DrawArea的Variable[0]变量传递到图素级DrawArea：
			DrawArea MainArea = pic.GetDrawArea();
			Area.Variable[0] = MainArea.Variable[0];
//MessageBox.Show(Area.Variable[0].ToString());

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


        DrawArea picT = (DrawArea)(Area.Parent.Parent);
        DrawArea Top = (DrawArea)picT.GetDrawObj("TDC3000_Top");
        Top.Variable[3] = "";


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
public void PMPID_OnDynAnimation(Object sender, EventArgs e)
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

        DrawArea picT = (DrawArea)(Area.Parent.Parent);
        DrawArea Top = (DrawArea)picT.GetDrawObj("TDC3000_Top");


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
                         Top.Variable[3] = "PRESS ENTER TO EXECUTE";
                         Top.Variable[4] = "";
		 }
		 else if(Area.Variable[1] == "3")
		 {
			 CAS.ForegroundColor = Color.White;
                         Rect_CAS.EdgeColor = Color.White;
                         Top.Variable[3] = "PRESS ENTER TO EXECUTE";
                         Top.Variable[4] = "";
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
                         Top.Variable[3] = "PRESS ENTER TO EXECUTE";
                         Top.Variable[4] = "";
		 }
		 else if(Area.Variable[1] == "3")
		 {
			 CAS.ForegroundColor = Color.White;
                         Rect_CAS.EdgeColor = Color.White;
                         Top.Variable[3] = "PRESS ENTER TO EXECUTE";
                         Top.Variable[4] = "";
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
                         Top.Variable[3] = "PRESS ENTER TO EXECUTE";
                         Top.Variable[4] = "";
		 }
		 else if(Area.Variable[1] == "2")
		 {
			 AUTO.ForegroundColor = Color.White;
                         Rect_AUTO.EdgeColor = Color.White;
                         Top.Variable[3] = "PRESS ENTER TO EXECUTE";
                         Top.Variable[4] = "";
		 }
	 }
	 }
     if(Area.Variable[1] == "4")
     {
	 PTXST.ForegroundColor = Color.White;
         ACTIVE.ForegroundColor = Color.White;
         PA_Rectangle.EdgeColor = Color.White;  
         Top.Variable[3] = "PRESS ENTER TO EXECUTE"; 
         Top.Variable[4] = "";  
     }
 
     if(Area.Variable[1] == "5")
     {
         Top.Variable[4] = "NOT EMULATION"; 
         Top.Variable[3] = "";  
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
//Event Handler:Disposed 
public void PMPID_Disposed(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 

   TextBox TB = (TextBox)Area.GetDrawObj("TB");
   TB.Enabled = false;
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void PMPID_OnDynClick(Object sender, EventArgs e)
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
public void PMPID_KeyUp(Object sender, KeyEventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   string tagName = Area.Variable[0] + "/MODE";

        DrawArea picT = (DrawArea)(Area.Parent.Parent);
        DrawArea Top = (DrawArea)picT.GetDrawObj("TDC3000_Top");


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

                              ////////////////Top的显示

                                     Top.Variable[3] = "";
                                     //Top.Variable[4] = "";

                             ////////////////Top的显示

                          Area.Variable[1] = "0";

	                 break;
                      } 
         }
         
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void PMPID_Text_OP_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText Text_OP = (DrawText)dynArgs.sender; 
   
    Text_OP.ForegroundColor = Color.Yellow;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void PMPID_Text_OP_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText Text_OP = (DrawText)dynArgs.sender; 
   
    DrawText OP = (DrawText)Area.GetDrawObj("OP");

    Area.Variable[1] = "8"; 

    if(Text_OP.Visible == true)

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
public void PMPID_Text_SP_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText Text_SP = (DrawText)dynArgs.sender; 
   
    Text_SP.ForegroundColor = Color.Cyan;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void PMPID_Text_SP_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText Text_SP = (DrawText)dynArgs.sender; 
   
    DrawText SP = (DrawText)Area.GetDrawObj("SP");

    Area.Variable[1] = "7"; 

    if(Text_SP.Visible == true)

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
//Event Handler:OnDynInitialize 
public void PMPID_Text_PV_OnDynInitialize(Object sender, EventArgs e)
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
public void PMPID_Text_PV_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText Text_PV = (DrawText)dynArgs.sender; 
   
    DrawText PV = (DrawText)Area.GetDrawObj("PV");

    Area.Variable[1] = "6"; 

    if(Text_PV.Visible == true)

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
public void PMPID_PA_Rectangle_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle PA_Rectangle = (DrawRectangle)dynArgs.sender; 

    Area.Variable[1] = "4";  
 
     return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void PMPID_Rect_PROG_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect_PROG = (DrawRectangle)dynArgs.sender; 
   
    Area.Variable[1] = "5";

    DrawArea pic = (DrawArea)(Area.Parent.Parent);
    DrawArea Top = (DrawArea)pic.GetDrawObj("TDC3000_Top");
    Top.Variable[4] = "NOT EMULATION";
    Top.Variable[3] = "";

    DrawArea A = (DrawArea)(Area.Parent);
             A.RunAnimation();
    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void PMPID_Rect_MAN_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect_MAN = (DrawRectangle)dynArgs.sender; 
   
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
public void PMPID_Rect_AUTO_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect_AUTO = (DrawRectangle)dynArgs.sender; 
   
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
public void PMPID_Rect_CAS_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect_CAS = (DrawRectangle)dynArgs.sender; 
 
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
public void PMPID_OP_OnDynAnimation(Object sender, EventArgs e)
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
public void PMPID_OP_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText OP = (DrawText)dynArgs.sender; 
 
    OP.ForegroundColor = Color.Yellow; 
  
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
public void PMPID_OP_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText OP = (DrawText)dynArgs.sender; 
   
    Area.Variable[1] = "8"; 

    if(OP.Visible == true)

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
//Event Handler:OnDynAnimation 
public void PMPID_SP_OnDynAnimation(Object sender, EventArgs e)
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
public void PMPID_SP_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText SP = (DrawText)dynArgs.sender; 

    SP.ForegroundColor = Color.Cyan; 
   
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

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void PMPID_SP_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText SP = (DrawText)dynArgs.sender; 
   
    Area.Variable[1] = "7"; 

    if(SP.Visible == true)

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
				CommonFunction.MoveControl(Area,TB,(int)(SP.VerticalPosition + 30),(int)(SP.HorizontalPosition)+40);		
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
//Event Handler:OnDynAnimation 
public void PMPID_PV_OnDynAnimation(Object sender, EventArgs e)
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
public void PMPID_PV_OnDynInitialize(Object sender, EventArgs e)
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
//Event Handler:OnDynClick 
public void PMPID_PV_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PV = (DrawText)dynArgs.sender; 

    Area.Variable[1] = "6"; 

    if(PV.Visible == true)

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
//Event Handler:OnDynAnimation 
public void PMPID_TagComment_OnDynAnimation(Object sender, EventArgs e)
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
public void PMPID_TagComment_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText TagComment = (DrawText)dynArgs.sender; 
   
	int nLeft = 0;
	int nTop = 0;
	string[] strVariable = new string[1];
	strVariable[0] = Area.Variable[0];
	CommonFunction.OpenPicture("CZ_PMPID_Detail.grf", nTop, nLeft, strVariable);

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void PMPID_PVUnit_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVUnit = (DrawText)dynArgs.sender; 
   
    PVUnit.Caption = CommonFunction.GetPVUnit(Area.Variable[0]);

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void PMPID_PVUnit_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVUnit = (DrawText)dynArgs.sender; 
   
	int nLeft = 0;
	int nTop = 0;
	string[] strVariable = new string[1];
	strVariable[0] = Area.Variable[0];
	CommonFunction.OpenPicture("CZ_PMPID_Detail.grf", nTop, nLeft, strVariable);

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void PMPID_PVUnit_OnDynInitialize(Object sender, EventArgs e)
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
public void PMPID_TagName_OnDynInitialize(Object sender, EventArgs e)	//TagName
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
public void PMPID_TagName_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText TagName = (DrawText)dynArgs.sender; 
 
	//CommonFunction.OpenDetail(Area.Variable[0]); 

	int nLeft = 0;
	int nTop = 0;
	string[] strVariable = new string[1];
	strVariable[0] = Area.Variable[0];
	//CommonFunction.OpenPicture("CZ_PMPID_Detail.grf", nTop, nLeft, strVariable);
 	CommonFunction.OpenDetail(Area.Variable[0]);
    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void PMPID_TagName_OnDynAnimation(Object sender, EventArgs e)
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
public void PMPID_Close_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle CLR = (DrawRectangle)dynArgs.sender; 
   
        DrawArea picT = (DrawArea)(Area.Parent.Parent);
        DrawArea Top = (DrawArea)picT.GetDrawObj("TDC3000_Top");

    (Area.Parent).Visible = false;

    Top.Variable[3] = "";
    Top.Variable[4] = "";

    Area.Variable[1] = "0";

    return; 
}
//Do not remove or update this comment
//Event Delegate:KeyEventHandler 
//Event Handler:KeyUp 
public void PMPID_TB_KeyUp(Object sender, KeyEventArgs e)
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
			                DrawArea pic = (DrawArea)(Area.Parent.Parent);
                                        DrawArea Top = (DrawArea)pic.GetDrawObj("TDC3000_Top");
                                        Top.Variable[4] = "MODE ERROR";

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
			                DrawArea pic = (DrawArea)(Area.Parent.Parent);
                                        DrawArea Top = (DrawArea)pic.GetDrawObj("TDC3000_Top");
                                        Top.Variable[4] = "MODE ERROR";
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
DrawArea pic0 = (DrawArea)(Area.Parent.Parent);
DrawArea Top0 = (DrawArea)pic0.GetDrawObj("TDC3000_Top");
Top0.Variable[4] = "";
    return; 
}


}
