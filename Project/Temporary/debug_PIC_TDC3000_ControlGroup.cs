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
public class PIC_TDC3000_ControlGroup:IDynCodeAttachDetach
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
_EventHandler= (EventHandler)PIC_TDC3000_ControlGroup_OnDynInitialize;
CodeDomCommon.AttachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PIC_TDC3000_ControlGroup_OnDynAnimation;
CodeDomCommon.AttachAreaEventHandler(area,strEventName,_EventHandler);
strObjectName = "PVSOURCE";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PVSOURCE_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVSOURCE";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVSOURCE_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Rect_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Text";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Text_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DA";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)DA_KeyUp;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "DA";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DA_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DA";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DA_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DA.ENTER";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DA_ENTER_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DA.D5";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DA_D5_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DA.D5";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DA_D5_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DA.D4";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DA_D4_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DA.D4";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DA_D4_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DA.D3";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DA_D3_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DA.D3";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DA_D3_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DA.Rect3";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DA_Rect3_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DA.Rect3";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DA_Rect3_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DA.Rect2";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DA_Rect2_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DA.Rect2";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DA_Rect2_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DA.Rect1";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DA_Rect1_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DA.Rect1";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DA_Rect1_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DA.D2";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DA_D2_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DA.D2";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DA_D2_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DA.D1";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DA_D1_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DA.D1";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DA_D1_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DA.NAME";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DA_NAME_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd6_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd6_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6_PMDIGCOM";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd6_PMDIGCOM_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMDIGCOM.Rect_PVON";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd6_PMDIGCOM_Rect_PVON_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMDIGCOM.OP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd6_PMDIGCOM_OP_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMDIGCOM.Rect_OFF";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd6_PMDIGCOM_Rect_OFF_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMDIGCOM.Rect_ON";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd6_PMDIGCOM_Rect_ON_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMDIGCOM.Unit";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd6_PMDIGCOM_Unit_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMDIGCOM.TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd6_PMDIGCOM_TagName_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMDIGCOM.Rect9";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd6_PMDIGCOM_Rect9_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMDIGCOM.Rect9";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd6_PMDIGCOM_Rect9_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMDIGCOM.Rect9";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd6_PMDIGCOM_Rect9_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6_PMANLIN";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd6_PMANLIN_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6_PMANLIN";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd6_PMANLIN_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6_PMANLIN";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)gd6_PMANLIN_KeyUp;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "gd6.PMANLIN.Rect8";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd6_PMANLIN_Rect8_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMANLIN.Line16";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd6_PMANLIN_Line16_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMANLIN.LinePVTV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd6_PMANLIN_LinePVTV_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMANLIN.TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd6_PMANLIN_TagName_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMANLIN.PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd6_PMANLIN_PV_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMANLIN.PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd6_PMANLIN_PV_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMANLIN.PVTV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd6_PMANLIN_PVTV_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMANLIN.PVTV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd6_PMANLIN_PVTV_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMANLIN.Rect9";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd6_PMANLIN_Rect9_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMANLIN.Rect9";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd6_PMANLIN_Rect9_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMANLIN.Rect9";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd6_PMANLIN_Rect9_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMANLIN.Rect10";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd6_PMANLIN_Rect10_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMANLIN.Rect10";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd6_PMANLIN_Rect10_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMANLIN.Rect10";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd6_PMANLIN_Rect10_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMANLIN.Rect11";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd6_PMANLIN_Rect11_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMANLIN.Rect11";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd6_PMANLIN_Rect11_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMANLIN.Rect11";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd6_PMANLIN_Rect11_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMANLIN.TB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)gd6_PMANLIN_TB_KeyUp;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "gd6_PMPID";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd6_PMPID_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6_PMPID";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd6_PMPID_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6_PMPID";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)gd6_PMPID_KeyUp;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "gd6.PMPID.ALM";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd6_PMPID_ALM_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMPID.OPBar";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd6_PMPID_OPBar_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMPID.PVBlack";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd6_PMPID_PVBlack_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMPID.SPLine";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd6_PMPID_SPLine_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMPID.PVBar";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd6_PMPID_PVBar_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMPID.MODE";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd6_PMPID_MODE_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMPID.Rect_MODE";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd6_PMPID_Rect_MODE_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMPID.Unit";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd6_PMPID_Unit_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMPID.TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd6_PMPID_TagName_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMPID.PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd6_PMPID_PV_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMPID.PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd6_PMPID_PV_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMPID.SP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd6_PMPID_SP_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMPID.SP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd6_PMPID_SP_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMPID.OP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd6_PMPID_OP_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMPID.OP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd6_PMPID_OP_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMPID.R_tagname";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd6_PMPID_R_tagname_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMPID.R_tagname";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd6_PMPID_R_tagname_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMPID.R_tagname";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd6_PMPID_R_tagname_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMPID.Rect7";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd6_PMPID_Rect7_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMPID.Rect7";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd6_PMPID_Rect7_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMPID.Rect7";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd6_PMPID_Rect7_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMPID.Rect8";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd6_PMPID_Rect8_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMPID.Rect8";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd6_PMPID_Rect8_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMPID.Rect8";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd6_PMPID_Rect8_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMPID.Rect9";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd6_PMPID_Rect9_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMPID.Rect9";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd6_PMPID_Rect9_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMPID.Rect9";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd6_PMPID_Rect9_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMPID.TB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)gd6_PMPID_TB_KeyUp;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "gd5";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd5_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd5_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5_PMDIGCOM";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd5_PMDIGCOM_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMDIGCOM.Rect_PVON";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd5_PMDIGCOM_Rect_PVON_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMDIGCOM.OP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd5_PMDIGCOM_OP_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMDIGCOM.Rect_OFF";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd5_PMDIGCOM_Rect_OFF_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMDIGCOM.Rect_ON";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd5_PMDIGCOM_Rect_ON_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMDIGCOM.Unit";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd5_PMDIGCOM_Unit_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMDIGCOM.TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd5_PMDIGCOM_TagName_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMDIGCOM.Rect9";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd5_PMDIGCOM_Rect9_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMDIGCOM.Rect9";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd5_PMDIGCOM_Rect9_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMDIGCOM.Rect9";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd5_PMDIGCOM_Rect9_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5_PMANLIN";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd5_PMANLIN_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5_PMANLIN";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd5_PMANLIN_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5_PMANLIN";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)gd5_PMANLIN_KeyUp;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "gd5.PMANLIN.Rect8";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd5_PMANLIN_Rect8_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMANLIN.Line16";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd5_PMANLIN_Line16_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMANLIN.LinePVTV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd5_PMANLIN_LinePVTV_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMANLIN.TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd5_PMANLIN_TagName_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMANLIN.PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd5_PMANLIN_PV_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMANLIN.PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd5_PMANLIN_PV_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMANLIN.PVTV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd5_PMANLIN_PVTV_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMANLIN.PVTV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd5_PMANLIN_PVTV_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMANLIN.Rect9";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd5_PMANLIN_Rect9_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMANLIN.Rect9";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd5_PMANLIN_Rect9_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMANLIN.Rect9";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd5_PMANLIN_Rect9_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMANLIN.Rect10";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd5_PMANLIN_Rect10_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMANLIN.Rect10";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd5_PMANLIN_Rect10_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMANLIN.Rect10";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd5_PMANLIN_Rect10_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMANLIN.Rect11";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd5_PMANLIN_Rect11_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMANLIN.Rect11";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd5_PMANLIN_Rect11_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMANLIN.Rect11";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd5_PMANLIN_Rect11_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMANLIN.TB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)gd5_PMANLIN_TB_KeyUp;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "gd5_PMPID";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd5_PMPID_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5_PMPID";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd5_PMPID_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5_PMPID";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)gd5_PMPID_KeyUp;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "gd5.PMPID.ALM";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd5_PMPID_ALM_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMPID.OPBar";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd5_PMPID_OPBar_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMPID.PVBlack";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd5_PMPID_PVBlack_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMPID.SPLine";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd5_PMPID_SPLine_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMPID.PVBar";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd5_PMPID_PVBar_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMPID.MODE";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd5_PMPID_MODE_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMPID.Rect_MODE";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd5_PMPID_Rect_MODE_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMPID.Unit";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd5_PMPID_Unit_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMPID.TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd5_PMPID_TagName_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMPID.PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd5_PMPID_PV_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMPID.PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd5_PMPID_PV_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMPID.SP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd5_PMPID_SP_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMPID.SP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd5_PMPID_SP_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMPID.OP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd5_PMPID_OP_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMPID.OP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd5_PMPID_OP_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMPID.R_tagname";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd5_PMPID_R_tagname_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMPID.R_tagname";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd5_PMPID_R_tagname_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMPID.R_tagname";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd5_PMPID_R_tagname_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMPID.Rect7";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd5_PMPID_Rect7_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMPID.Rect7";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd5_PMPID_Rect7_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMPID.Rect7";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd5_PMPID_Rect7_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMPID.Rect8";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd5_PMPID_Rect8_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMPID.Rect8";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd5_PMPID_Rect8_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMPID.Rect8";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd5_PMPID_Rect8_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMPID.Rect9";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd5_PMPID_Rect9_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMPID.Rect9";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd5_PMPID_Rect9_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMPID.Rect9";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd5_PMPID_Rect9_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMPID.TB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)gd5_PMPID_TB_KeyUp;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "gd4";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd4_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd4_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4_PMDIGCOM";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd4_PMDIGCOM_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMDIGCOM.Rect_PVON";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd4_PMDIGCOM_Rect_PVON_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMDIGCOM.OP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd4_PMDIGCOM_OP_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMDIGCOM.Rect_OFF";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd4_PMDIGCOM_Rect_OFF_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMDIGCOM.Rect_ON";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd4_PMDIGCOM_Rect_ON_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMDIGCOM.Unit";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd4_PMDIGCOM_Unit_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMDIGCOM.TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd4_PMDIGCOM_TagName_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMDIGCOM.Rect9";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd4_PMDIGCOM_Rect9_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMDIGCOM.Rect9";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd4_PMDIGCOM_Rect9_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMDIGCOM.Rect9";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd4_PMDIGCOM_Rect9_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4_PMANLIN";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd4_PMANLIN_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4_PMANLIN";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd4_PMANLIN_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4_PMANLIN";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)gd4_PMANLIN_KeyUp;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "gd4.PMANLIN.Rect8";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd4_PMANLIN_Rect8_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMANLIN.Line16";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd4_PMANLIN_Line16_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMANLIN.LinePVTV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd4_PMANLIN_LinePVTV_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMANLIN.TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd4_PMANLIN_TagName_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMANLIN.PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd4_PMANLIN_PV_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMANLIN.PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd4_PMANLIN_PV_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMANLIN.PVTV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd4_PMANLIN_PVTV_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMANLIN.PVTV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd4_PMANLIN_PVTV_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMANLIN.Rect9";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd4_PMANLIN_Rect9_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMANLIN.Rect9";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd4_PMANLIN_Rect9_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMANLIN.Rect9";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd4_PMANLIN_Rect9_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMANLIN.Rect10";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd4_PMANLIN_Rect10_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMANLIN.Rect10";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd4_PMANLIN_Rect10_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMANLIN.Rect10";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd4_PMANLIN_Rect10_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMANLIN.Rect11";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd4_PMANLIN_Rect11_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMANLIN.Rect11";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd4_PMANLIN_Rect11_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMANLIN.Rect11";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd4_PMANLIN_Rect11_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMANLIN.TB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)gd4_PMANLIN_TB_KeyUp;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "gd4_PMPID";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd4_PMPID_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4_PMPID";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd4_PMPID_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4_PMPID";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)gd4_PMPID_KeyUp;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "gd4.PMPID.ALM";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd4_PMPID_ALM_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMPID.OPBar";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd4_PMPID_OPBar_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMPID.PVBlack";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd4_PMPID_PVBlack_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMPID.SPLine";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd4_PMPID_SPLine_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMPID.PVBar";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd4_PMPID_PVBar_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMPID.MODE";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd4_PMPID_MODE_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMPID.Rect_MODE";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd4_PMPID_Rect_MODE_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMPID.Unit";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd4_PMPID_Unit_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMPID.TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd4_PMPID_TagName_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMPID.PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd4_PMPID_PV_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMPID.PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd4_PMPID_PV_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMPID.SP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd4_PMPID_SP_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMPID.SP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd4_PMPID_SP_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMPID.OP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd4_PMPID_OP_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMPID.OP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd4_PMPID_OP_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMPID.R_tagname";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd4_PMPID_R_tagname_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMPID.R_tagname";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd4_PMPID_R_tagname_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMPID.R_tagname";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd4_PMPID_R_tagname_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMPID.Rect7";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd4_PMPID_Rect7_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMPID.Rect7";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd4_PMPID_Rect7_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMPID.Rect7";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd4_PMPID_Rect7_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMPID.Rect8";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd4_PMPID_Rect8_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMPID.Rect8";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd4_PMPID_Rect8_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMPID.Rect8";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd4_PMPID_Rect8_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMPID.Rect9";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd4_PMPID_Rect9_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMPID.Rect9";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd4_PMPID_Rect9_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMPID.Rect9";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd4_PMPID_Rect9_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMPID.TB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)gd4_PMPID_TB_KeyUp;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "gd3";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd3_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd3_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3_PMDIGCOM";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd3_PMDIGCOM_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMDIGCOM.Rect_PVON";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd3_PMDIGCOM_Rect_PVON_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMDIGCOM.OP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd3_PMDIGCOM_OP_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMDIGCOM.Rect_OFF";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd3_PMDIGCOM_Rect_OFF_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMDIGCOM.Rect_ON";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd3_PMDIGCOM_Rect_ON_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMDIGCOM.Unit";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd3_PMDIGCOM_Unit_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMDIGCOM.TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd3_PMDIGCOM_TagName_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMDIGCOM.Rect9";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd3_PMDIGCOM_Rect9_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMDIGCOM.Rect9";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd3_PMDIGCOM_Rect9_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMDIGCOM.Rect9";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd3_PMDIGCOM_Rect9_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3_PMANLIN";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd3_PMANLIN_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3_PMANLIN";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd3_PMANLIN_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3_PMANLIN";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)gd3_PMANLIN_KeyUp;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "gd3.PMANLIN.Rect8";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd3_PMANLIN_Rect8_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMANLIN.Line16";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd3_PMANLIN_Line16_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMANLIN.LinePVTV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd3_PMANLIN_LinePVTV_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMANLIN.TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd3_PMANLIN_TagName_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMANLIN.PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd3_PMANLIN_PV_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMANLIN.PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd3_PMANLIN_PV_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMANLIN.PVTV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd3_PMANLIN_PVTV_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMANLIN.PVTV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd3_PMANLIN_PVTV_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMANLIN.Rect9";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd3_PMANLIN_Rect9_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMANLIN.Rect9";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd3_PMANLIN_Rect9_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMANLIN.Rect9";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd3_PMANLIN_Rect9_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMANLIN.Rect10";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd3_PMANLIN_Rect10_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMANLIN.Rect10";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd3_PMANLIN_Rect10_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMANLIN.Rect10";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd3_PMANLIN_Rect10_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMANLIN.Rect11";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd3_PMANLIN_Rect11_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMANLIN.Rect11";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd3_PMANLIN_Rect11_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMANLIN.Rect11";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd3_PMANLIN_Rect11_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMANLIN.TB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)gd3_PMANLIN_TB_KeyUp;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "gd3_PMPID";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd3_PMPID_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3_PMPID";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd3_PMPID_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3_PMPID";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)gd3_PMPID_KeyUp;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "gd3.PMPID.ALM";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd3_PMPID_ALM_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMPID.OPBar";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd3_PMPID_OPBar_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMPID.PVBlack";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd3_PMPID_PVBlack_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMPID.SPLine";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd3_PMPID_SPLine_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMPID.PVBar";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd3_PMPID_PVBar_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMPID.MODE";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd3_PMPID_MODE_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMPID.Rect_MODE";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd3_PMPID_Rect_MODE_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMPID.Unit";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd3_PMPID_Unit_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMPID.TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd3_PMPID_TagName_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMPID.PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd3_PMPID_PV_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMPID.PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd3_PMPID_PV_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMPID.SP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd3_PMPID_SP_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMPID.SP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd3_PMPID_SP_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMPID.OP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd3_PMPID_OP_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMPID.OP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd3_PMPID_OP_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMPID.R_tagname";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd3_PMPID_R_tagname_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMPID.R_tagname";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd3_PMPID_R_tagname_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMPID.R_tagname";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd3_PMPID_R_tagname_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMPID.Rect7";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd3_PMPID_Rect7_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMPID.Rect7";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd3_PMPID_Rect7_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMPID.Rect7";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd3_PMPID_Rect7_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMPID.Rect8";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd3_PMPID_Rect8_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMPID.Rect8";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd3_PMPID_Rect8_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMPID.Rect8";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd3_PMPID_Rect8_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMPID.Rect9";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd3_PMPID_Rect9_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMPID.Rect9";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd3_PMPID_Rect9_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMPID.Rect9";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd3_PMPID_Rect9_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMPID.TB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)gd3_PMPID_TB_KeyUp;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "gd1";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd1_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd1_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1_PMDIGCOM";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd1_PMDIGCOM_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMDIGCOM.Rect_PVON";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd1_PMDIGCOM_Rect_PVON_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMDIGCOM.OP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd1_PMDIGCOM_OP_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMDIGCOM.Rect_OFF";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd1_PMDIGCOM_Rect_OFF_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMDIGCOM.Rect_ON";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd1_PMDIGCOM_Rect_ON_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMDIGCOM.Unit";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd1_PMDIGCOM_Unit_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMDIGCOM.TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd1_PMDIGCOM_TagName_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMDIGCOM.Rect9";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd1_PMDIGCOM_Rect9_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMDIGCOM.Rect9";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd1_PMDIGCOM_Rect9_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMDIGCOM.Rect9";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd1_PMDIGCOM_Rect9_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1_PMANLIN";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd1_PMANLIN_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1_PMANLIN";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd1_PMANLIN_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1_PMANLIN";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)gd1_PMANLIN_KeyUp;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "gd1.PMANLIN.Rect8";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd1_PMANLIN_Rect8_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMANLIN.Line16";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd1_PMANLIN_Line16_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMANLIN.LinePVTV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd1_PMANLIN_LinePVTV_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMANLIN.TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd1_PMANLIN_TagName_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMANLIN.PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd1_PMANLIN_PV_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMANLIN.PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd1_PMANLIN_PV_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMANLIN.PVTV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd1_PMANLIN_PVTV_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMANLIN.PVTV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd1_PMANLIN_PVTV_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMANLIN.Rect9";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd1_PMANLIN_Rect9_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMANLIN.Rect9";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd1_PMANLIN_Rect9_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMANLIN.Rect9";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd1_PMANLIN_Rect9_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMANLIN.Rect10";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd1_PMANLIN_Rect10_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMANLIN.Rect10";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd1_PMANLIN_Rect10_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMANLIN.Rect10";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd1_PMANLIN_Rect10_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMANLIN.Rect11";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd1_PMANLIN_Rect11_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMANLIN.Rect11";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd1_PMANLIN_Rect11_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMANLIN.Rect11";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd1_PMANLIN_Rect11_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMANLIN.TB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)gd1_PMANLIN_TB_KeyUp;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "gd1_PMPID";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd1_PMPID_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1_PMPID";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd1_PMPID_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1_PMPID";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)gd1_PMPID_KeyUp;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "gd1.PMPID.ALM";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd1_PMPID_ALM_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMPID.OPBar";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd1_PMPID_OPBar_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMPID.PVBlack";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd1_PMPID_PVBlack_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMPID.SPLine";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd1_PMPID_SPLine_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMPID.PVBar";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd1_PMPID_PVBar_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMPID.MODE";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd1_PMPID_MODE_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMPID.Rect_MODE";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd1_PMPID_Rect_MODE_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMPID.Unit";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd1_PMPID_Unit_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMPID.TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd1_PMPID_TagName_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMPID.PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd1_PMPID_PV_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMPID.PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd1_PMPID_PV_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMPID.SP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd1_PMPID_SP_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMPID.SP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd1_PMPID_SP_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMPID.OP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd1_PMPID_OP_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMPID.OP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd1_PMPID_OP_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMPID.R_tagname";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd1_PMPID_R_tagname_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMPID.R_tagname";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd1_PMPID_R_tagname_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMPID.R_tagname";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd1_PMPID_R_tagname_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMPID.Rect7";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd1_PMPID_Rect7_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMPID.Rect7";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd1_PMPID_Rect7_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMPID.Rect7";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd1_PMPID_Rect7_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMPID.Rect8";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd1_PMPID_Rect8_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMPID.Rect8";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd1_PMPID_Rect8_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMPID.Rect8";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd1_PMPID_Rect8_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMPID.Rect9";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd1_PMPID_Rect9_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMPID.Rect9";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd1_PMPID_Rect9_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMPID.Rect9";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd1_PMPID_Rect9_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMPID.TB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)gd1_PMPID_TB_KeyUp;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "gd8";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd8_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd8_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8_PMDIGCOM";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd8_PMDIGCOM_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMDIGCOM.Rect_PVON";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd8_PMDIGCOM_Rect_PVON_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMDIGCOM.OP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd8_PMDIGCOM_OP_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMDIGCOM.Rect_OFF";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd8_PMDIGCOM_Rect_OFF_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMDIGCOM.Rect_ON";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd8_PMDIGCOM_Rect_ON_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMDIGCOM.Unit";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd8_PMDIGCOM_Unit_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMDIGCOM.TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd8_PMDIGCOM_TagName_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMDIGCOM.Rect9";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd8_PMDIGCOM_Rect9_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMDIGCOM.Rect9";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd8_PMDIGCOM_Rect9_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMDIGCOM.Rect9";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd8_PMDIGCOM_Rect9_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8_PMANLIN";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd8_PMANLIN_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8_PMANLIN";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd8_PMANLIN_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8_PMANLIN";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)gd8_PMANLIN_KeyUp;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "gd8.PMANLIN.Rect8";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd8_PMANLIN_Rect8_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMANLIN.Line16";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd8_PMANLIN_Line16_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMANLIN.LinePVTV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd8_PMANLIN_LinePVTV_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMANLIN.TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd8_PMANLIN_TagName_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMANLIN.PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd8_PMANLIN_PV_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMANLIN.PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd8_PMANLIN_PV_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMANLIN.PVTV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd8_PMANLIN_PVTV_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMANLIN.PVTV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd8_PMANLIN_PVTV_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMANLIN.Rect9";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd8_PMANLIN_Rect9_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMANLIN.Rect9";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd8_PMANLIN_Rect9_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMANLIN.Rect9";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd8_PMANLIN_Rect9_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMANLIN.Rect10";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd8_PMANLIN_Rect10_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMANLIN.Rect10";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd8_PMANLIN_Rect10_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMANLIN.Rect10";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd8_PMANLIN_Rect10_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMANLIN.Rect11";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd8_PMANLIN_Rect11_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMANLIN.Rect11";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd8_PMANLIN_Rect11_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMANLIN.Rect11";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd8_PMANLIN_Rect11_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMANLIN.TB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)gd8_PMANLIN_TB_KeyUp;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "gd8_PMPID";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd8_PMPID_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8_PMPID";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd8_PMPID_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8_PMPID";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)gd8_PMPID_KeyUp;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "gd8.PMPID.ALM";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd8_PMPID_ALM_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMPID.OPBar";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd8_PMPID_OPBar_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMPID.PVBlack";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd8_PMPID_PVBlack_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMPID.SPLine";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd8_PMPID_SPLine_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMPID.PVBar";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd8_PMPID_PVBar_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMPID.MODE";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd8_PMPID_MODE_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMPID.Rect_MODE";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd8_PMPID_Rect_MODE_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMPID.Unit";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd8_PMPID_Unit_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMPID.TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd8_PMPID_TagName_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMPID.PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd8_PMPID_PV_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMPID.PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd8_PMPID_PV_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMPID.SP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd8_PMPID_SP_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMPID.SP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd8_PMPID_SP_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMPID.OP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd8_PMPID_OP_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMPID.OP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd8_PMPID_OP_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMPID.R_tagname";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd8_PMPID_R_tagname_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMPID.R_tagname";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd8_PMPID_R_tagname_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMPID.R_tagname";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd8_PMPID_R_tagname_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMPID.Rect7";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd8_PMPID_Rect7_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMPID.Rect7";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd8_PMPID_Rect7_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMPID.Rect7";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd8_PMPID_Rect7_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMPID.Rect8";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd8_PMPID_Rect8_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMPID.Rect8";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd8_PMPID_Rect8_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMPID.Rect8";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd8_PMPID_Rect8_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMPID.Rect9";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd8_PMPID_Rect9_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMPID.Rect9";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd8_PMPID_Rect9_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMPID.Rect9";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd8_PMPID_Rect9_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMPID.TB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)gd8_PMPID_TB_KeyUp;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "gd7";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd7_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd7_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7_PMDIGCOM";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd7_PMDIGCOM_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMDIGCOM.Rect_PVON";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd7_PMDIGCOM_Rect_PVON_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMDIGCOM.OP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd7_PMDIGCOM_OP_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMDIGCOM.Rect_OFF";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd7_PMDIGCOM_Rect_OFF_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMDIGCOM.Rect_ON";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd7_PMDIGCOM_Rect_ON_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMDIGCOM.Unit";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd7_PMDIGCOM_Unit_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMDIGCOM.TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd7_PMDIGCOM_TagName_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMDIGCOM.Rect9";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd7_PMDIGCOM_Rect9_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMDIGCOM.Rect9";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd7_PMDIGCOM_Rect9_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMDIGCOM.Rect9";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd7_PMDIGCOM_Rect9_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7_PMANLIN";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd7_PMANLIN_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7_PMANLIN";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd7_PMANLIN_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7_PMANLIN";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)gd7_PMANLIN_KeyUp;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "gd7.PMANLIN.Rect8";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd7_PMANLIN_Rect8_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMANLIN.Line16";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd7_PMANLIN_Line16_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMANLIN.LinePVTV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd7_PMANLIN_LinePVTV_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMANLIN.TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd7_PMANLIN_TagName_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMANLIN.PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd7_PMANLIN_PV_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMANLIN.PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd7_PMANLIN_PV_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMANLIN.PVTV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd7_PMANLIN_PVTV_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMANLIN.PVTV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd7_PMANLIN_PVTV_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMANLIN.Rect9";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd7_PMANLIN_Rect9_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMANLIN.Rect9";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd7_PMANLIN_Rect9_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMANLIN.Rect9";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd7_PMANLIN_Rect9_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMANLIN.Rect10";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd7_PMANLIN_Rect10_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMANLIN.Rect10";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd7_PMANLIN_Rect10_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMANLIN.Rect10";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd7_PMANLIN_Rect10_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMANLIN.Rect11";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd7_PMANLIN_Rect11_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMANLIN.Rect11";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd7_PMANLIN_Rect11_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMANLIN.Rect11";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd7_PMANLIN_Rect11_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMANLIN.TB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)gd7_PMANLIN_TB_KeyUp;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "gd7_PMPID";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd7_PMPID_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7_PMPID";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd7_PMPID_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7_PMPID";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)gd7_PMPID_KeyUp;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "gd7.PMPID.ALM";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd7_PMPID_ALM_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMPID.OPBar";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd7_PMPID_OPBar_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMPID.PVBlack";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd7_PMPID_PVBlack_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMPID.SPLine";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd7_PMPID_SPLine_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMPID.PVBar";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd7_PMPID_PVBar_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMPID.MODE";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd7_PMPID_MODE_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMPID.Rect_MODE";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd7_PMPID_Rect_MODE_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMPID.Unit";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd7_PMPID_Unit_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMPID.TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd7_PMPID_TagName_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMPID.PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd7_PMPID_PV_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMPID.PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd7_PMPID_PV_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMPID.SP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd7_PMPID_SP_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMPID.SP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd7_PMPID_SP_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMPID.OP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd7_PMPID_OP_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMPID.OP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd7_PMPID_OP_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMPID.R_tagname";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd7_PMPID_R_tagname_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMPID.R_tagname";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd7_PMPID_R_tagname_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMPID.R_tagname";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd7_PMPID_R_tagname_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMPID.Rect7";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd7_PMPID_Rect7_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMPID.Rect7";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd7_PMPID_Rect7_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMPID.Rect7";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd7_PMPID_Rect7_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMPID.Rect8";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd7_PMPID_Rect8_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMPID.Rect8";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd7_PMPID_Rect8_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMPID.Rect8";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd7_PMPID_Rect8_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMPID.Rect9";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd7_PMPID_Rect9_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMPID.Rect9";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd7_PMPID_Rect9_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMPID.Rect9";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd7_PMPID_Rect9_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMPID.TB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)gd7_PMPID_TB_KeyUp;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "TDC3000_Groupfaceplate";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)TDC3000_Groupfaceplate_KeyUp;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "TDC3000_Groupfaceplate";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)TDC3000_Groupfaceplate_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_Groupfaceplate";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TDC3000_Groupfaceplate_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_Groupfaceplate.ENTER";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)TDC3000_Groupfaceplate_ENTER_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_Groupfaceplate.NORM";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)TDC3000_Groupfaceplate_NORM_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_Groupfaceplate.MAN";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)TDC3000_Groupfaceplate_MAN_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_Groupfaceplate.PROG";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)TDC3000_Groupfaceplate_PROG_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_Groupfaceplate.CAS";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)TDC3000_Groupfaceplate_CAS_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_Groupfaceplate.AUTO";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)TDC3000_Groupfaceplate_AUTO_OnDynClick;
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
strObjectName = "gd2";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd2_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd2_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2_PMDIGCOM";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd2_PMDIGCOM_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMDIGCOM.Rect_PVON";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd2_PMDIGCOM_Rect_PVON_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMDIGCOM.OP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd2_PMDIGCOM_OP_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMDIGCOM.Rect_OFF";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd2_PMDIGCOM_Rect_OFF_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMDIGCOM.Rect_ON";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd2_PMDIGCOM_Rect_ON_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMDIGCOM.Unit";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd2_PMDIGCOM_Unit_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMDIGCOM.TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd2_PMDIGCOM_TagName_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMDIGCOM.Rect9";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd2_PMDIGCOM_Rect9_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMDIGCOM.Rect9";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd2_PMDIGCOM_Rect9_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMDIGCOM.Rect9";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd2_PMDIGCOM_Rect9_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2_PMANLIN";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd2_PMANLIN_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2_PMANLIN";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd2_PMANLIN_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2_PMANLIN";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)gd2_PMANLIN_KeyUp;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "gd2.PMANLIN.Rect8";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd2_PMANLIN_Rect8_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMANLIN.Line16";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd2_PMANLIN_Line16_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMANLIN.LinePVTV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd2_PMANLIN_LinePVTV_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMANLIN.TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd2_PMANLIN_TagName_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMANLIN.PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd2_PMANLIN_PV_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMANLIN.PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd2_PMANLIN_PV_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMANLIN.PVTV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd2_PMANLIN_PVTV_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMANLIN.PVTV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd2_PMANLIN_PVTV_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMANLIN.Rect9";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd2_PMANLIN_Rect9_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMANLIN.Rect9";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd2_PMANLIN_Rect9_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMANLIN.Rect9";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd2_PMANLIN_Rect9_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMANLIN.Rect10";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd2_PMANLIN_Rect10_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMANLIN.Rect10";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd2_PMANLIN_Rect10_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMANLIN.Rect10";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd2_PMANLIN_Rect10_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMANLIN.Rect11";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd2_PMANLIN_Rect11_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMANLIN.Rect11";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd2_PMANLIN_Rect11_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMANLIN.Rect11";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd2_PMANLIN_Rect11_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMANLIN.TB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)gd2_PMANLIN_TB_KeyUp;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "gd2_PMPID";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd2_PMPID_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2_PMPID";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd2_PMPID_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2_PMPID";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)gd2_PMPID_KeyUp;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "gd2.PMPID.ALM";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd2_PMPID_ALM_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMPID.OPBar";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd2_PMPID_OPBar_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMPID.PVBlack";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd2_PMPID_PVBlack_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMPID.SPLine";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd2_PMPID_SPLine_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMPID.PVBar";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd2_PMPID_PVBar_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMPID.MODE";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd2_PMPID_MODE_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMPID.Rect_MODE";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd2_PMPID_Rect_MODE_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMPID.Unit";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd2_PMPID_Unit_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMPID.TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd2_PMPID_TagName_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMPID.PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd2_PMPID_PV_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMPID.PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd2_PMPID_PV_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMPID.SP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd2_PMPID_SP_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMPID.SP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd2_PMPID_SP_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMPID.OP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd2_PMPID_OP_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMPID.OP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd2_PMPID_OP_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMPID.R_tagname";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd2_PMPID_R_tagname_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMPID.R_tagname";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd2_PMPID_R_tagname_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMPID.R_tagname";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd2_PMPID_R_tagname_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMPID.Rect7";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd2_PMPID_Rect7_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMPID.Rect7";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd2_PMPID_Rect7_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMPID.Rect7";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd2_PMPID_Rect7_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMPID.Rect8";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd2_PMPID_Rect8_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMPID.Rect8";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd2_PMPID_Rect8_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMPID.Rect8";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd2_PMPID_Rect8_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMPID.Rect9";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd2_PMPID_Rect9_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMPID.Rect9";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd2_PMPID_Rect9_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMPID.Rect9";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd2_PMPID_Rect9_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMPID.TB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)gd2_PMPID_TB_KeyUp;
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
_EventHandler= (EventHandler)PIC_TDC3000_ControlGroup_OnDynInitialize;
CodeDomCommon.DetachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PIC_TDC3000_ControlGroup_OnDynAnimation;
CodeDomCommon.DetachAreaEventHandler(area,strEventName,_EventHandler);
strObjectName = "PVSOURCE";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PVSOURCE_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVSOURCE";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVSOURCE_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Rect_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Text";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Text_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DA";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)DA_KeyUp;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "DA";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DA_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DA";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DA_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DA.ENTER";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DA_ENTER_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DA.D5";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DA_D5_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DA.D5";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DA_D5_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DA.D4";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DA_D4_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DA.D4";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DA_D4_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DA.D3";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DA_D3_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DA.D3";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DA_D3_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DA.Rect3";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DA_Rect3_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DA.Rect3";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DA_Rect3_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DA.Rect2";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DA_Rect2_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DA.Rect2";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DA_Rect2_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DA.Rect1";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DA_Rect1_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DA.Rect1";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DA_Rect1_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DA.D2";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DA_D2_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DA.D2";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DA_D2_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DA.D1";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DA_D1_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DA.D1";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DA_D1_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DA.NAME";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DA_NAME_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd6_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd6_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6_PMDIGCOM";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd6_PMDIGCOM_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMDIGCOM.Rect_PVON";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd6_PMDIGCOM_Rect_PVON_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMDIGCOM.OP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd6_PMDIGCOM_OP_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMDIGCOM.Rect_OFF";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd6_PMDIGCOM_Rect_OFF_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMDIGCOM.Rect_ON";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd6_PMDIGCOM_Rect_ON_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMDIGCOM.Unit";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd6_PMDIGCOM_Unit_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMDIGCOM.TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd6_PMDIGCOM_TagName_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMDIGCOM.Rect9";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd6_PMDIGCOM_Rect9_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMDIGCOM.Rect9";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd6_PMDIGCOM_Rect9_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMDIGCOM.Rect9";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd6_PMDIGCOM_Rect9_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6_PMANLIN";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd6_PMANLIN_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6_PMANLIN";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd6_PMANLIN_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6_PMANLIN";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)gd6_PMANLIN_KeyUp;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "gd6.PMANLIN.Rect8";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd6_PMANLIN_Rect8_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMANLIN.Line16";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd6_PMANLIN_Line16_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMANLIN.LinePVTV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd6_PMANLIN_LinePVTV_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMANLIN.TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd6_PMANLIN_TagName_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMANLIN.PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd6_PMANLIN_PV_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMANLIN.PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd6_PMANLIN_PV_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMANLIN.PVTV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd6_PMANLIN_PVTV_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMANLIN.PVTV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd6_PMANLIN_PVTV_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMANLIN.Rect9";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd6_PMANLIN_Rect9_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMANLIN.Rect9";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd6_PMANLIN_Rect9_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMANLIN.Rect9";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd6_PMANLIN_Rect9_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMANLIN.Rect10";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd6_PMANLIN_Rect10_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMANLIN.Rect10";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd6_PMANLIN_Rect10_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMANLIN.Rect10";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd6_PMANLIN_Rect10_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMANLIN.Rect11";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd6_PMANLIN_Rect11_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMANLIN.Rect11";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd6_PMANLIN_Rect11_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMANLIN.Rect11";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd6_PMANLIN_Rect11_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMANLIN.TB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)gd6_PMANLIN_TB_KeyUp;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "gd6_PMPID";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd6_PMPID_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6_PMPID";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd6_PMPID_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6_PMPID";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)gd6_PMPID_KeyUp;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "gd6.PMPID.ALM";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd6_PMPID_ALM_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMPID.OPBar";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd6_PMPID_OPBar_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMPID.PVBlack";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd6_PMPID_PVBlack_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMPID.SPLine";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd6_PMPID_SPLine_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMPID.PVBar";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd6_PMPID_PVBar_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMPID.MODE";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd6_PMPID_MODE_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMPID.Rect_MODE";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd6_PMPID_Rect_MODE_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMPID.Unit";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd6_PMPID_Unit_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMPID.TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd6_PMPID_TagName_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMPID.PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd6_PMPID_PV_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMPID.PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd6_PMPID_PV_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMPID.SP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd6_PMPID_SP_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMPID.SP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd6_PMPID_SP_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMPID.OP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd6_PMPID_OP_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMPID.OP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd6_PMPID_OP_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMPID.R_tagname";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd6_PMPID_R_tagname_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMPID.R_tagname";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd6_PMPID_R_tagname_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMPID.R_tagname";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd6_PMPID_R_tagname_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMPID.Rect7";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd6_PMPID_Rect7_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMPID.Rect7";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd6_PMPID_Rect7_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMPID.Rect7";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd6_PMPID_Rect7_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMPID.Rect8";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd6_PMPID_Rect8_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMPID.Rect8";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd6_PMPID_Rect8_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMPID.Rect8";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd6_PMPID_Rect8_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMPID.Rect9";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd6_PMPID_Rect9_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMPID.Rect9";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd6_PMPID_Rect9_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMPID.Rect9";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd6_PMPID_Rect9_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd6.PMPID.TB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)gd6_PMPID_TB_KeyUp;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "gd5";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd5_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd5_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5_PMDIGCOM";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd5_PMDIGCOM_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMDIGCOM.Rect_PVON";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd5_PMDIGCOM_Rect_PVON_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMDIGCOM.OP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd5_PMDIGCOM_OP_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMDIGCOM.Rect_OFF";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd5_PMDIGCOM_Rect_OFF_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMDIGCOM.Rect_ON";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd5_PMDIGCOM_Rect_ON_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMDIGCOM.Unit";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd5_PMDIGCOM_Unit_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMDIGCOM.TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd5_PMDIGCOM_TagName_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMDIGCOM.Rect9";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd5_PMDIGCOM_Rect9_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMDIGCOM.Rect9";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd5_PMDIGCOM_Rect9_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMDIGCOM.Rect9";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd5_PMDIGCOM_Rect9_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5_PMANLIN";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd5_PMANLIN_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5_PMANLIN";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd5_PMANLIN_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5_PMANLIN";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)gd5_PMANLIN_KeyUp;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "gd5.PMANLIN.Rect8";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd5_PMANLIN_Rect8_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMANLIN.Line16";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd5_PMANLIN_Line16_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMANLIN.LinePVTV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd5_PMANLIN_LinePVTV_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMANLIN.TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd5_PMANLIN_TagName_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMANLIN.PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd5_PMANLIN_PV_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMANLIN.PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd5_PMANLIN_PV_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMANLIN.PVTV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd5_PMANLIN_PVTV_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMANLIN.PVTV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd5_PMANLIN_PVTV_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMANLIN.Rect9";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd5_PMANLIN_Rect9_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMANLIN.Rect9";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd5_PMANLIN_Rect9_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMANLIN.Rect9";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd5_PMANLIN_Rect9_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMANLIN.Rect10";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd5_PMANLIN_Rect10_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMANLIN.Rect10";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd5_PMANLIN_Rect10_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMANLIN.Rect10";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd5_PMANLIN_Rect10_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMANLIN.Rect11";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd5_PMANLIN_Rect11_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMANLIN.Rect11";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd5_PMANLIN_Rect11_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMANLIN.Rect11";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd5_PMANLIN_Rect11_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMANLIN.TB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)gd5_PMANLIN_TB_KeyUp;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "gd5_PMPID";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd5_PMPID_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5_PMPID";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd5_PMPID_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5_PMPID";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)gd5_PMPID_KeyUp;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "gd5.PMPID.ALM";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd5_PMPID_ALM_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMPID.OPBar";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd5_PMPID_OPBar_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMPID.PVBlack";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd5_PMPID_PVBlack_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMPID.SPLine";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd5_PMPID_SPLine_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMPID.PVBar";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd5_PMPID_PVBar_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMPID.MODE";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd5_PMPID_MODE_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMPID.Rect_MODE";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd5_PMPID_Rect_MODE_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMPID.Unit";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd5_PMPID_Unit_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMPID.TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd5_PMPID_TagName_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMPID.PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd5_PMPID_PV_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMPID.PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd5_PMPID_PV_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMPID.SP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd5_PMPID_SP_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMPID.SP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd5_PMPID_SP_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMPID.OP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd5_PMPID_OP_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMPID.OP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd5_PMPID_OP_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMPID.R_tagname";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd5_PMPID_R_tagname_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMPID.R_tagname";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd5_PMPID_R_tagname_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMPID.R_tagname";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd5_PMPID_R_tagname_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMPID.Rect7";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd5_PMPID_Rect7_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMPID.Rect7";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd5_PMPID_Rect7_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMPID.Rect7";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd5_PMPID_Rect7_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMPID.Rect8";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd5_PMPID_Rect8_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMPID.Rect8";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd5_PMPID_Rect8_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMPID.Rect8";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd5_PMPID_Rect8_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMPID.Rect9";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd5_PMPID_Rect9_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMPID.Rect9";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd5_PMPID_Rect9_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMPID.Rect9";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd5_PMPID_Rect9_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd5.PMPID.TB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)gd5_PMPID_TB_KeyUp;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "gd4";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd4_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd4_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4_PMDIGCOM";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd4_PMDIGCOM_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMDIGCOM.Rect_PVON";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd4_PMDIGCOM_Rect_PVON_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMDIGCOM.OP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd4_PMDIGCOM_OP_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMDIGCOM.Rect_OFF";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd4_PMDIGCOM_Rect_OFF_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMDIGCOM.Rect_ON";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd4_PMDIGCOM_Rect_ON_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMDIGCOM.Unit";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd4_PMDIGCOM_Unit_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMDIGCOM.TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd4_PMDIGCOM_TagName_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMDIGCOM.Rect9";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd4_PMDIGCOM_Rect9_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMDIGCOM.Rect9";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd4_PMDIGCOM_Rect9_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMDIGCOM.Rect9";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd4_PMDIGCOM_Rect9_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4_PMANLIN";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd4_PMANLIN_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4_PMANLIN";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd4_PMANLIN_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4_PMANLIN";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)gd4_PMANLIN_KeyUp;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "gd4.PMANLIN.Rect8";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd4_PMANLIN_Rect8_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMANLIN.Line16";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd4_PMANLIN_Line16_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMANLIN.LinePVTV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd4_PMANLIN_LinePVTV_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMANLIN.TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd4_PMANLIN_TagName_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMANLIN.PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd4_PMANLIN_PV_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMANLIN.PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd4_PMANLIN_PV_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMANLIN.PVTV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd4_PMANLIN_PVTV_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMANLIN.PVTV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd4_PMANLIN_PVTV_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMANLIN.Rect9";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd4_PMANLIN_Rect9_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMANLIN.Rect9";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd4_PMANLIN_Rect9_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMANLIN.Rect9";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd4_PMANLIN_Rect9_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMANLIN.Rect10";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd4_PMANLIN_Rect10_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMANLIN.Rect10";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd4_PMANLIN_Rect10_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMANLIN.Rect10";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd4_PMANLIN_Rect10_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMANLIN.Rect11";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd4_PMANLIN_Rect11_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMANLIN.Rect11";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd4_PMANLIN_Rect11_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMANLIN.Rect11";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd4_PMANLIN_Rect11_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMANLIN.TB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)gd4_PMANLIN_TB_KeyUp;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "gd4_PMPID";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd4_PMPID_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4_PMPID";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd4_PMPID_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4_PMPID";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)gd4_PMPID_KeyUp;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "gd4.PMPID.ALM";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd4_PMPID_ALM_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMPID.OPBar";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd4_PMPID_OPBar_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMPID.PVBlack";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd4_PMPID_PVBlack_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMPID.SPLine";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd4_PMPID_SPLine_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMPID.PVBar";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd4_PMPID_PVBar_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMPID.MODE";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd4_PMPID_MODE_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMPID.Rect_MODE";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd4_PMPID_Rect_MODE_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMPID.Unit";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd4_PMPID_Unit_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMPID.TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd4_PMPID_TagName_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMPID.PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd4_PMPID_PV_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMPID.PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd4_PMPID_PV_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMPID.SP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd4_PMPID_SP_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMPID.SP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd4_PMPID_SP_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMPID.OP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd4_PMPID_OP_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMPID.OP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd4_PMPID_OP_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMPID.R_tagname";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd4_PMPID_R_tagname_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMPID.R_tagname";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd4_PMPID_R_tagname_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMPID.R_tagname";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd4_PMPID_R_tagname_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMPID.Rect7";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd4_PMPID_Rect7_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMPID.Rect7";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd4_PMPID_Rect7_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMPID.Rect7";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd4_PMPID_Rect7_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMPID.Rect8";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd4_PMPID_Rect8_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMPID.Rect8";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd4_PMPID_Rect8_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMPID.Rect8";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd4_PMPID_Rect8_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMPID.Rect9";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd4_PMPID_Rect9_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMPID.Rect9";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd4_PMPID_Rect9_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMPID.Rect9";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd4_PMPID_Rect9_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd4.PMPID.TB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)gd4_PMPID_TB_KeyUp;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "gd3";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd3_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd3_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3_PMDIGCOM";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd3_PMDIGCOM_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMDIGCOM.Rect_PVON";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd3_PMDIGCOM_Rect_PVON_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMDIGCOM.OP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd3_PMDIGCOM_OP_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMDIGCOM.Rect_OFF";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd3_PMDIGCOM_Rect_OFF_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMDIGCOM.Rect_ON";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd3_PMDIGCOM_Rect_ON_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMDIGCOM.Unit";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd3_PMDIGCOM_Unit_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMDIGCOM.TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd3_PMDIGCOM_TagName_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMDIGCOM.Rect9";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd3_PMDIGCOM_Rect9_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMDIGCOM.Rect9";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd3_PMDIGCOM_Rect9_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMDIGCOM.Rect9";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd3_PMDIGCOM_Rect9_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3_PMANLIN";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd3_PMANLIN_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3_PMANLIN";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd3_PMANLIN_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3_PMANLIN";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)gd3_PMANLIN_KeyUp;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "gd3.PMANLIN.Rect8";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd3_PMANLIN_Rect8_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMANLIN.Line16";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd3_PMANLIN_Line16_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMANLIN.LinePVTV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd3_PMANLIN_LinePVTV_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMANLIN.TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd3_PMANLIN_TagName_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMANLIN.PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd3_PMANLIN_PV_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMANLIN.PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd3_PMANLIN_PV_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMANLIN.PVTV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd3_PMANLIN_PVTV_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMANLIN.PVTV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd3_PMANLIN_PVTV_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMANLIN.Rect9";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd3_PMANLIN_Rect9_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMANLIN.Rect9";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd3_PMANLIN_Rect9_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMANLIN.Rect9";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd3_PMANLIN_Rect9_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMANLIN.Rect10";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd3_PMANLIN_Rect10_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMANLIN.Rect10";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd3_PMANLIN_Rect10_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMANLIN.Rect10";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd3_PMANLIN_Rect10_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMANLIN.Rect11";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd3_PMANLIN_Rect11_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMANLIN.Rect11";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd3_PMANLIN_Rect11_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMANLIN.Rect11";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd3_PMANLIN_Rect11_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMANLIN.TB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)gd3_PMANLIN_TB_KeyUp;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "gd3_PMPID";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd3_PMPID_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3_PMPID";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd3_PMPID_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3_PMPID";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)gd3_PMPID_KeyUp;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "gd3.PMPID.ALM";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd3_PMPID_ALM_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMPID.OPBar";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd3_PMPID_OPBar_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMPID.PVBlack";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd3_PMPID_PVBlack_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMPID.SPLine";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd3_PMPID_SPLine_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMPID.PVBar";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd3_PMPID_PVBar_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMPID.MODE";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd3_PMPID_MODE_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMPID.Rect_MODE";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd3_PMPID_Rect_MODE_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMPID.Unit";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd3_PMPID_Unit_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMPID.TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd3_PMPID_TagName_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMPID.PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd3_PMPID_PV_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMPID.PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd3_PMPID_PV_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMPID.SP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd3_PMPID_SP_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMPID.SP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd3_PMPID_SP_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMPID.OP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd3_PMPID_OP_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMPID.OP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd3_PMPID_OP_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMPID.R_tagname";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd3_PMPID_R_tagname_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMPID.R_tagname";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd3_PMPID_R_tagname_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMPID.R_tagname";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd3_PMPID_R_tagname_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMPID.Rect7";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd3_PMPID_Rect7_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMPID.Rect7";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd3_PMPID_Rect7_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMPID.Rect7";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd3_PMPID_Rect7_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMPID.Rect8";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd3_PMPID_Rect8_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMPID.Rect8";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd3_PMPID_Rect8_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMPID.Rect8";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd3_PMPID_Rect8_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMPID.Rect9";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd3_PMPID_Rect9_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMPID.Rect9";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd3_PMPID_Rect9_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMPID.Rect9";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd3_PMPID_Rect9_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd3.PMPID.TB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)gd3_PMPID_TB_KeyUp;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "gd1";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd1_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd1_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1_PMDIGCOM";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd1_PMDIGCOM_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMDIGCOM.Rect_PVON";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd1_PMDIGCOM_Rect_PVON_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMDIGCOM.OP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd1_PMDIGCOM_OP_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMDIGCOM.Rect_OFF";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd1_PMDIGCOM_Rect_OFF_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMDIGCOM.Rect_ON";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd1_PMDIGCOM_Rect_ON_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMDIGCOM.Unit";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd1_PMDIGCOM_Unit_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMDIGCOM.TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd1_PMDIGCOM_TagName_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMDIGCOM.Rect9";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd1_PMDIGCOM_Rect9_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMDIGCOM.Rect9";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd1_PMDIGCOM_Rect9_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMDIGCOM.Rect9";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd1_PMDIGCOM_Rect9_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1_PMANLIN";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd1_PMANLIN_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1_PMANLIN";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd1_PMANLIN_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1_PMANLIN";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)gd1_PMANLIN_KeyUp;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "gd1.PMANLIN.Rect8";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd1_PMANLIN_Rect8_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMANLIN.Line16";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd1_PMANLIN_Line16_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMANLIN.LinePVTV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd1_PMANLIN_LinePVTV_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMANLIN.TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd1_PMANLIN_TagName_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMANLIN.PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd1_PMANLIN_PV_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMANLIN.PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd1_PMANLIN_PV_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMANLIN.PVTV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd1_PMANLIN_PVTV_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMANLIN.PVTV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd1_PMANLIN_PVTV_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMANLIN.Rect9";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd1_PMANLIN_Rect9_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMANLIN.Rect9";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd1_PMANLIN_Rect9_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMANLIN.Rect9";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd1_PMANLIN_Rect9_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMANLIN.Rect10";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd1_PMANLIN_Rect10_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMANLIN.Rect10";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd1_PMANLIN_Rect10_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMANLIN.Rect10";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd1_PMANLIN_Rect10_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMANLIN.Rect11";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd1_PMANLIN_Rect11_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMANLIN.Rect11";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd1_PMANLIN_Rect11_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMANLIN.Rect11";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd1_PMANLIN_Rect11_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMANLIN.TB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)gd1_PMANLIN_TB_KeyUp;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "gd1_PMPID";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd1_PMPID_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1_PMPID";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd1_PMPID_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1_PMPID";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)gd1_PMPID_KeyUp;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "gd1.PMPID.ALM";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd1_PMPID_ALM_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMPID.OPBar";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd1_PMPID_OPBar_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMPID.PVBlack";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd1_PMPID_PVBlack_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMPID.SPLine";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd1_PMPID_SPLine_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMPID.PVBar";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd1_PMPID_PVBar_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMPID.MODE";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd1_PMPID_MODE_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMPID.Rect_MODE";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd1_PMPID_Rect_MODE_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMPID.Unit";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd1_PMPID_Unit_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMPID.TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd1_PMPID_TagName_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMPID.PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd1_PMPID_PV_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMPID.PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd1_PMPID_PV_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMPID.SP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd1_PMPID_SP_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMPID.SP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd1_PMPID_SP_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMPID.OP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd1_PMPID_OP_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMPID.OP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd1_PMPID_OP_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMPID.R_tagname";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd1_PMPID_R_tagname_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMPID.R_tagname";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd1_PMPID_R_tagname_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMPID.R_tagname";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd1_PMPID_R_tagname_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMPID.Rect7";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd1_PMPID_Rect7_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMPID.Rect7";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd1_PMPID_Rect7_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMPID.Rect7";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd1_PMPID_Rect7_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMPID.Rect8";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd1_PMPID_Rect8_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMPID.Rect8";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd1_PMPID_Rect8_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMPID.Rect8";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd1_PMPID_Rect8_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMPID.Rect9";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd1_PMPID_Rect9_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMPID.Rect9";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd1_PMPID_Rect9_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMPID.Rect9";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd1_PMPID_Rect9_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd1.PMPID.TB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)gd1_PMPID_TB_KeyUp;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "gd8";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd8_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd8_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8_PMDIGCOM";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd8_PMDIGCOM_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMDIGCOM.Rect_PVON";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd8_PMDIGCOM_Rect_PVON_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMDIGCOM.OP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd8_PMDIGCOM_OP_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMDIGCOM.Rect_OFF";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd8_PMDIGCOM_Rect_OFF_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMDIGCOM.Rect_ON";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd8_PMDIGCOM_Rect_ON_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMDIGCOM.Unit";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd8_PMDIGCOM_Unit_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMDIGCOM.TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd8_PMDIGCOM_TagName_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMDIGCOM.Rect9";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd8_PMDIGCOM_Rect9_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMDIGCOM.Rect9";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd8_PMDIGCOM_Rect9_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMDIGCOM.Rect9";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd8_PMDIGCOM_Rect9_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8_PMANLIN";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd8_PMANLIN_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8_PMANLIN";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd8_PMANLIN_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8_PMANLIN";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)gd8_PMANLIN_KeyUp;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "gd8.PMANLIN.Rect8";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd8_PMANLIN_Rect8_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMANLIN.Line16";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd8_PMANLIN_Line16_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMANLIN.LinePVTV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd8_PMANLIN_LinePVTV_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMANLIN.TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd8_PMANLIN_TagName_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMANLIN.PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd8_PMANLIN_PV_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMANLIN.PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd8_PMANLIN_PV_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMANLIN.PVTV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd8_PMANLIN_PVTV_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMANLIN.PVTV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd8_PMANLIN_PVTV_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMANLIN.Rect9";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd8_PMANLIN_Rect9_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMANLIN.Rect9";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd8_PMANLIN_Rect9_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMANLIN.Rect9";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd8_PMANLIN_Rect9_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMANLIN.Rect10";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd8_PMANLIN_Rect10_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMANLIN.Rect10";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd8_PMANLIN_Rect10_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMANLIN.Rect10";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd8_PMANLIN_Rect10_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMANLIN.Rect11";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd8_PMANLIN_Rect11_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMANLIN.Rect11";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd8_PMANLIN_Rect11_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMANLIN.Rect11";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd8_PMANLIN_Rect11_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMANLIN.TB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)gd8_PMANLIN_TB_KeyUp;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "gd8_PMPID";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd8_PMPID_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8_PMPID";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd8_PMPID_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8_PMPID";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)gd8_PMPID_KeyUp;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "gd8.PMPID.ALM";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd8_PMPID_ALM_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMPID.OPBar";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd8_PMPID_OPBar_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMPID.PVBlack";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd8_PMPID_PVBlack_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMPID.SPLine";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd8_PMPID_SPLine_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMPID.PVBar";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd8_PMPID_PVBar_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMPID.MODE";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd8_PMPID_MODE_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMPID.Rect_MODE";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd8_PMPID_Rect_MODE_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMPID.Unit";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd8_PMPID_Unit_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMPID.TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd8_PMPID_TagName_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMPID.PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd8_PMPID_PV_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMPID.PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd8_PMPID_PV_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMPID.SP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd8_PMPID_SP_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMPID.SP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd8_PMPID_SP_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMPID.OP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd8_PMPID_OP_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMPID.OP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd8_PMPID_OP_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMPID.R_tagname";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd8_PMPID_R_tagname_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMPID.R_tagname";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd8_PMPID_R_tagname_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMPID.R_tagname";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd8_PMPID_R_tagname_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMPID.Rect7";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd8_PMPID_Rect7_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMPID.Rect7";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd8_PMPID_Rect7_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMPID.Rect7";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd8_PMPID_Rect7_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMPID.Rect8";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd8_PMPID_Rect8_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMPID.Rect8";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd8_PMPID_Rect8_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMPID.Rect8";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd8_PMPID_Rect8_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMPID.Rect9";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd8_PMPID_Rect9_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMPID.Rect9";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd8_PMPID_Rect9_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMPID.Rect9";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd8_PMPID_Rect9_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd8.PMPID.TB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)gd8_PMPID_TB_KeyUp;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "gd7";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd7_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd7_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7_PMDIGCOM";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd7_PMDIGCOM_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMDIGCOM.Rect_PVON";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd7_PMDIGCOM_Rect_PVON_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMDIGCOM.OP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd7_PMDIGCOM_OP_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMDIGCOM.Rect_OFF";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd7_PMDIGCOM_Rect_OFF_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMDIGCOM.Rect_ON";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd7_PMDIGCOM_Rect_ON_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMDIGCOM.Unit";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd7_PMDIGCOM_Unit_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMDIGCOM.TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd7_PMDIGCOM_TagName_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMDIGCOM.Rect9";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd7_PMDIGCOM_Rect9_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMDIGCOM.Rect9";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd7_PMDIGCOM_Rect9_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMDIGCOM.Rect9";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd7_PMDIGCOM_Rect9_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7_PMANLIN";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd7_PMANLIN_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7_PMANLIN";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd7_PMANLIN_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7_PMANLIN";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)gd7_PMANLIN_KeyUp;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "gd7.PMANLIN.Rect8";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd7_PMANLIN_Rect8_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMANLIN.Line16";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd7_PMANLIN_Line16_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMANLIN.LinePVTV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd7_PMANLIN_LinePVTV_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMANLIN.TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd7_PMANLIN_TagName_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMANLIN.PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd7_PMANLIN_PV_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMANLIN.PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd7_PMANLIN_PV_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMANLIN.PVTV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd7_PMANLIN_PVTV_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMANLIN.PVTV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd7_PMANLIN_PVTV_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMANLIN.Rect9";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd7_PMANLIN_Rect9_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMANLIN.Rect9";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd7_PMANLIN_Rect9_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMANLIN.Rect9";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd7_PMANLIN_Rect9_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMANLIN.Rect10";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd7_PMANLIN_Rect10_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMANLIN.Rect10";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd7_PMANLIN_Rect10_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMANLIN.Rect10";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd7_PMANLIN_Rect10_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMANLIN.Rect11";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd7_PMANLIN_Rect11_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMANLIN.Rect11";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd7_PMANLIN_Rect11_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMANLIN.Rect11";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd7_PMANLIN_Rect11_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMANLIN.TB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)gd7_PMANLIN_TB_KeyUp;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "gd7_PMPID";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd7_PMPID_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7_PMPID";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd7_PMPID_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7_PMPID";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)gd7_PMPID_KeyUp;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "gd7.PMPID.ALM";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd7_PMPID_ALM_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMPID.OPBar";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd7_PMPID_OPBar_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMPID.PVBlack";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd7_PMPID_PVBlack_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMPID.SPLine";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd7_PMPID_SPLine_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMPID.PVBar";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd7_PMPID_PVBar_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMPID.MODE";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd7_PMPID_MODE_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMPID.Rect_MODE";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd7_PMPID_Rect_MODE_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMPID.Unit";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd7_PMPID_Unit_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMPID.TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd7_PMPID_TagName_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMPID.PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd7_PMPID_PV_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMPID.PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd7_PMPID_PV_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMPID.SP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd7_PMPID_SP_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMPID.SP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd7_PMPID_SP_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMPID.OP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd7_PMPID_OP_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMPID.OP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd7_PMPID_OP_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMPID.R_tagname";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd7_PMPID_R_tagname_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMPID.R_tagname";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd7_PMPID_R_tagname_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMPID.R_tagname";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd7_PMPID_R_tagname_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMPID.Rect7";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd7_PMPID_Rect7_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMPID.Rect7";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd7_PMPID_Rect7_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMPID.Rect7";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd7_PMPID_Rect7_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMPID.Rect8";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd7_PMPID_Rect8_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMPID.Rect8";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd7_PMPID_Rect8_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMPID.Rect8";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd7_PMPID_Rect8_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMPID.Rect9";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd7_PMPID_Rect9_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMPID.Rect9";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd7_PMPID_Rect9_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMPID.Rect9";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd7_PMPID_Rect9_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd7.PMPID.TB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)gd7_PMPID_TB_KeyUp;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "TDC3000_Groupfaceplate";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)TDC3000_Groupfaceplate_KeyUp;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "TDC3000_Groupfaceplate";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)TDC3000_Groupfaceplate_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_Groupfaceplate";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TDC3000_Groupfaceplate_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_Groupfaceplate.ENTER";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)TDC3000_Groupfaceplate_ENTER_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_Groupfaceplate.NORM";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)TDC3000_Groupfaceplate_NORM_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_Groupfaceplate.MAN";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)TDC3000_Groupfaceplate_MAN_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_Groupfaceplate.PROG";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)TDC3000_Groupfaceplate_PROG_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_Groupfaceplate.CAS";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)TDC3000_Groupfaceplate_CAS_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_Groupfaceplate.AUTO";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)TDC3000_Groupfaceplate_AUTO_OnDynClick;
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
strObjectName = "gd2";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd2_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd2_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2_PMDIGCOM";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd2_PMDIGCOM_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMDIGCOM.Rect_PVON";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd2_PMDIGCOM_Rect_PVON_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMDIGCOM.OP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd2_PMDIGCOM_OP_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMDIGCOM.Rect_OFF";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd2_PMDIGCOM_Rect_OFF_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMDIGCOM.Rect_ON";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd2_PMDIGCOM_Rect_ON_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMDIGCOM.Unit";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd2_PMDIGCOM_Unit_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMDIGCOM.TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd2_PMDIGCOM_TagName_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMDIGCOM.Rect9";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd2_PMDIGCOM_Rect9_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMDIGCOM.Rect9";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd2_PMDIGCOM_Rect9_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMDIGCOM.Rect9";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd2_PMDIGCOM_Rect9_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2_PMANLIN";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd2_PMANLIN_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2_PMANLIN";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd2_PMANLIN_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2_PMANLIN";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)gd2_PMANLIN_KeyUp;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "gd2.PMANLIN.Rect8";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd2_PMANLIN_Rect8_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMANLIN.Line16";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd2_PMANLIN_Line16_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMANLIN.LinePVTV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd2_PMANLIN_LinePVTV_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMANLIN.TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd2_PMANLIN_TagName_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMANLIN.PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd2_PMANLIN_PV_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMANLIN.PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd2_PMANLIN_PV_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMANLIN.PVTV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd2_PMANLIN_PVTV_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMANLIN.PVTV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd2_PMANLIN_PVTV_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMANLIN.Rect9";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd2_PMANLIN_Rect9_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMANLIN.Rect9";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd2_PMANLIN_Rect9_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMANLIN.Rect9";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd2_PMANLIN_Rect9_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMANLIN.Rect10";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd2_PMANLIN_Rect10_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMANLIN.Rect10";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd2_PMANLIN_Rect10_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMANLIN.Rect10";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd2_PMANLIN_Rect10_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMANLIN.Rect11";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd2_PMANLIN_Rect11_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMANLIN.Rect11";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd2_PMANLIN_Rect11_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMANLIN.Rect11";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd2_PMANLIN_Rect11_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMANLIN.TB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)gd2_PMANLIN_TB_KeyUp;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "gd2_PMPID";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd2_PMPID_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2_PMPID";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd2_PMPID_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2_PMPID";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)gd2_PMPID_KeyUp;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "gd2.PMPID.ALM";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd2_PMPID_ALM_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMPID.OPBar";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd2_PMPID_OPBar_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMPID.PVBlack";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd2_PMPID_PVBlack_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMPID.SPLine";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd2_PMPID_SPLine_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMPID.PVBar";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd2_PMPID_PVBar_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMPID.MODE";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd2_PMPID_MODE_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMPID.Rect_MODE";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd2_PMPID_Rect_MODE_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMPID.Unit";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd2_PMPID_Unit_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMPID.TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd2_PMPID_TagName_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMPID.PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd2_PMPID_PV_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMPID.PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd2_PMPID_PV_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMPID.SP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd2_PMPID_SP_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMPID.SP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd2_PMPID_SP_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMPID.OP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd2_PMPID_OP_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMPID.OP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd2_PMPID_OP_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMPID.R_tagname";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd2_PMPID_R_tagname_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMPID.R_tagname";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd2_PMPID_R_tagname_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMPID.R_tagname";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd2_PMPID_R_tagname_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMPID.Rect7";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd2_PMPID_Rect7_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMPID.Rect7";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd2_PMPID_Rect7_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMPID.Rect7";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd2_PMPID_Rect7_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMPID.Rect8";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd2_PMPID_Rect8_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMPID.Rect8";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd2_PMPID_Rect8_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMPID.Rect8";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd2_PMPID_Rect8_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMPID.Rect9";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)gd2_PMPID_Rect9_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMPID.Rect9";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)gd2_PMPID_Rect9_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMPID.Rect9";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)gd2_PMPID_Rect9_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "gd2.PMPID.TB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)gd2_PMPID_TB_KeyUp;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);

    return;
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void PIC_TDC3000_ControlGroup_OnDynInitialize(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 

    DrawArea gd1 = (DrawArea)Area.GetDrawObj("gd1");
    gd1.Variable[0] = Area.Variable[0];
    gd1.Visible = false;

    DrawArea gd2 = (DrawArea)Area.GetDrawObj("gd2");
    gd2.Variable[0] = Area.Variable[1];
    gd2.Visible = false;

    DrawArea gd3 = (DrawArea)Area.GetDrawObj("gd3");
    gd3.Variable[0] = Area.Variable[2];
    gd3.Visible = false;

    DrawArea gd4 = (DrawArea)Area.GetDrawObj("gd4");
    gd4.Variable[0] = Area.Variable[3];
    gd4.Visible = false;

    DrawArea gd5 = (DrawArea)Area.GetDrawObj("gd5");
    gd5.Variable[0] = Area.Variable[4];
    gd5.Visible = false;

    DrawArea gd6 = (DrawArea)Area.GetDrawObj("gd6");
    gd6.Variable[0] = Area.Variable[5];
    gd6.Visible = false;

    DrawArea gd7 = (DrawArea)Area.GetDrawObj("gd7");
    gd7.Variable[0] = Area.Variable[6];
    gd7.Visible = false;

    DrawArea gd8 = (DrawArea)Area.GetDrawObj("gd8");
    gd8.Variable[0] = Area.Variable[7];
    gd8.Visible = false;

    DrawArea Group_Detail_1 = (DrawArea)Area.GetDrawObj("TDC3000_Groupfaceplate");
    Group_Detail_1.Visible = false;

    DrawArea DA = (DrawArea)Area.GetDrawObj("DA");
    DA.Visible = false;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void PIC_TDC3000_ControlGroup_OnDynAnimation(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 
   
    DrawArea gd1 = (DrawArea)Area.GetDrawObj("gd1");
    gd1.Visible = true;
    gd1.Variable[0] = Area.Variable[0];

    DrawArea gd2 = (DrawArea)Area.GetDrawObj("gd2");
    gd2.Visible = true;
    gd2.Variable[0] = Area.Variable[1];

    DrawArea gd3 = (DrawArea)Area.GetDrawObj("gd3");
    gd3.Visible = true;
    gd3.Variable[0] = Area.Variable[2];

    DrawArea gd4 = (DrawArea)Area.GetDrawObj("gd4");
    gd4.Visible = true;
    gd4.Variable[0] = Area.Variable[3];

    DrawArea gd5 = (DrawArea)Area.GetDrawObj("gd5");
    gd5.Visible = true;
    gd5.Variable[0] = Area.Variable[4];

    DrawArea gd6 = (DrawArea)Area.GetDrawObj("gd6");
    gd6.Visible = true;
    gd6.Variable[0] = Area.Variable[5];

    DrawArea gd7 = (DrawArea)Area.GetDrawObj("gd7");
    gd7.Visible = true;
    gd7.Variable[0] = Area.Variable[6];

    DrawArea gd8 = (DrawArea)Area.GetDrawObj("gd8");
    gd8.Visible = true;
    gd8.Variable[0] = Area.Variable[7];

       if(Area.Variable[10] == "1")
       {gd1.Variable[1] = "1";
        gd2.Variable[1] = "0";
        gd3.Variable[1] = "0";
        gd4.Variable[1] = "0";
        gd5.Variable[1] = "0";
        gd6.Variable[1] = "0";
        gd7.Variable[1] = "0";
        gd8.Variable[1] = "0";
       }
    if(Area.Variable[10] == "2")
       {gd2.Variable[1] = "1";
        gd1.Variable[1] = "0";
        gd3.Variable[1] = "0";
        gd4.Variable[1] = "0";
        gd5.Variable[1] = "0";
        gd6.Variable[1] = "0";
        gd7.Variable[1] = "0";
        gd8.Variable[1] = "0";
       }
    if(Area.Variable[10] == "3")
       {gd3.Variable[1] = "1";
        gd2.Variable[1] = "0";
        gd1.Variable[1] = "0";
        gd4.Variable[1] = "0";
        gd5.Variable[1] = "0";
        gd6.Variable[1] = "0";
        gd7.Variable[1] = "0";
        gd8.Variable[1] = "0";
        }
    if(Area.Variable[10] == "4")
       {gd4.Variable[1] = "1";
        gd2.Variable[1] = "0";
        gd3.Variable[1] = "0";
        gd1.Variable[1] = "0";
        gd5.Variable[1] = "0";
        gd6.Variable[1] = "0";
        gd7.Variable[1] = "0";
        gd8.Variable[1] = "0";
        }
    if(Area.Variable[10] == "5")
       {gd5.Variable[1] = "1";
        gd2.Variable[1] = "0";
        gd3.Variable[1] = "0";
        gd4.Variable[1] = "0";
        gd1.Variable[1] = "0";
        gd6.Variable[1] = "0";
        gd7.Variable[1] = "0";
        gd8.Variable[1] = "0";
        }
    if(Area.Variable[10] == "6")
       {gd6.Variable[1] = "1";
        gd2.Variable[1] = "0";
        gd3.Variable[1] = "0";
        gd4.Variable[1] = "0";
        gd5.Variable[1] = "0";
        gd1.Variable[1] = "0";
        gd7.Variable[1] = "0";
        gd8.Variable[1] = "0";
       }
    if(Area.Variable[10] == "7")
       {gd7.Variable[1] = "1";
        gd2.Variable[1] = "0";
        gd3.Variable[1] = "0";
        gd4.Variable[1] = "0";
        gd5.Variable[1] = "0";
        gd6.Variable[1] = "0";
        gd1.Variable[1] = "0";
        gd8.Variable[1] = "0";
       }
    if(Area.Variable[10] == "8")
       {gd8.Variable[1] = "1";
        gd2.Variable[1] = "0";
        gd3.Variable[1] = "0";
        gd4.Variable[1] = "0";
        gd5.Variable[1] = "0";
        gd6.Variable[1] = "0";
        gd7.Variable[1] = "0";
        gd1.Variable[1] = "0";
        }

    return; 
}//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void PVSOURCE_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVSOURCE = (DrawText)dynArgs.sender; 
   
    PVSOURCE.Visible = false;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void PVSOURCE_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVSOURCE = (DrawText)dynArgs.sender; 
   
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	int nDigit = 2;
	string tagName = PVSOURCE.Variable[0] + "/PVSOURCE";

	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
            {
                if(dbValue == 0)
                  {
                      PVSOURCE.Caption = "MAN";
                      PVSOURCE.ForegroundColor = Color.Yellow;
                  }
                if(dbValue == 1)
                  {
                      PVSOURCE.Caption = "AUTO";
                      PVSOURCE.ForegroundColor = Color.Yellow;
                  }
                if(dbValue == 2)
                  {
                      PVSOURCE.Caption = "SUB";
                      PVSOURCE.ForegroundColor = Color.Yellow;
                  }
                if(dbValue == 3)
                  {
                      PVSOURCE.Caption = "TRACK";
                      PVSOURCE.ForegroundColor = Color.Yellow;
                  }
            }
       else
            {PVSOURCE.Caption = "###";}

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void Rect_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect = (DrawRectangle)dynArgs.sender; 
   
    Rect.Visible = false;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void Rect_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect = (DrawRectangle)dynArgs.sender; 

    DrawArea L = (DrawArea)Area.GetDrawObj("DA");
    L.Visible = true;
    L.Variable[0] = Rect.Variable[0];
    L.Variable[1] = "PVSOURCE";

    L.Variable[3] = "AUTO";
    L.Variable[4] = "MAN";
    L.Variable[5] = "SUB";
    L.Variable[6] = "TRACK";
    L.Variable[7] = "N";

    L.Variable[8] = "1";
    L.Variable[9] = "0";
    L.Variable[10] = "2";
    L.Variable[11] = "3";
    L.Variable[12] = "4";
   
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void Text_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVSOURCE_Text = (DrawText)dynArgs.sender; 
   
    PVSOURCE_Text.Visible = false;

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
public void DA_KeyUp(Object sender, KeyEventArgs e)
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
public void DA_OnDynInitialize(Object sender, EventArgs e)
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
public void DA_OnDynAnimation(Object sender, EventArgs e)
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
public void DA_ENTER_OnDynClick(Object sender, EventArgs e)
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
public void DA_D5_OnDynClick(Object sender, EventArgs e)
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
public void DA_D5_OnDynAnimation(Object sender, EventArgs e)
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
public void DA_D4_OnDynClick(Object sender, EventArgs e)
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
public void DA_D4_OnDynAnimation(Object sender, EventArgs e)
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
public void DA_D3_OnDynClick(Object sender, EventArgs e)
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
public void DA_D3_OnDynAnimation(Object sender, EventArgs e)
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
public void DA_Rect3_OnDynInitialize(Object sender, EventArgs e)
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
public void DA_Rect3_OnDynAnimation(Object sender, EventArgs e)
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
public void DA_Rect2_OnDynInitialize(Object sender, EventArgs e)
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
public void DA_Rect2_OnDynAnimation(Object sender, EventArgs e)
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
public void DA_Rect1_OnDynInitialize(Object sender, EventArgs e)
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
public void DA_Rect1_OnDynAnimation(Object sender, EventArgs e)
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
public void DA_D2_OnDynClick(Object sender, EventArgs e)
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
public void DA_D2_OnDynAnimation(Object sender, EventArgs e)
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
public void DA_D1_OnDynClick(Object sender, EventArgs e)
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
public void DA_D1_OnDynAnimation(Object sender, EventArgs e)
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
public void DA_NAME_OnDynAnimation(Object sender, EventArgs e)
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
public void gd6_OnDynInitialize(Object sender, EventArgs e)
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
public void gd6_OnDynAnimation(Object sender, EventArgs e)
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

             else 

                {
                     PMDIGCOM.Visible = false;
                     PMPID.Visible = false;
                     PMANLIN.Visible = false;
                }

        }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd6_PMDIGCOM_OnDynInitialize(Object sender, EventArgs e)
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
public void gd6_PMDIGCOM_Rect_PVON_OnDynAnimation(Object sender, EventArgs e)
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
public void gd6_PMDIGCOM_OP_OnDynAnimation(Object sender, EventArgs e)
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
public void gd6_PMDIGCOM_Rect_OFF_OnDynAnimation(Object sender, EventArgs e)
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
public void gd6_PMDIGCOM_Rect_ON_OnDynAnimation(Object sender, EventArgs e)
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
public void gd6_PMDIGCOM_Unit_OnDynAnimation(Object sender, EventArgs e)
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
public void gd6_PMDIGCOM_TagName_OnDynAnimation(Object sender, EventArgs e)
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
//Event Handler:OnDynInitialize 
public void gd6_PMDIGCOM_Rect9_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 
   
    R_tagname.Visible = true;
    R_tagname.ForegroundColor = Color.Black;
    R_tagname.EdgeColor = Color.Black;
           DrawArea p = (DrawArea)(Area.Parent);
           p.Variable[1] = "0";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void gd6_PMDIGCOM_Rect9_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 
   
           DrawArea pic = (DrawArea)(Area.Parent.Parent);

           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd6_PMDIGCOM_Rect9_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 

           DrawArea p = (DrawArea)(Area.Parent);
           if(p.Variable[1] == "1")
              {
                    R_tagname.ForegroundColor = Color.Blue;
                    R_tagname.EdgeColor = Color.White;
              }
           else
              {
                    R_tagname.ForegroundColor = Color.Black;
                    R_tagname.EdgeColor = Color.Black;
              }
 
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd6_PMANLIN_OnDynInitialize(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 
 
	Picture pic = CommonFunction.GetThisPicture(Area);
	if(pic != null)
	{  
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
				TB.Visible = false;
				TB.Focus();
			}
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
//Event Handler:OnDynClick 
public void gd6_PMANLIN_OnDynClick(Object sender, EventArgs e)
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
public void gd6_PMANLIN_KeyUp(Object sender, KeyEventArgs e)
{
   TextBox TB = (TextBox)sender; 

   DrawArea Area = CommonFunction.GetThisDrawArea(TB);

     double dbValue = 0;
     int nValue = 0;
     bool bValue = false;
     int nDataType = 0;

        double PVEXEH = 0;
        double PVEXEL = 0;
        double PVEUHI = 0;
        double PVEULO = 0;

	string tagName = Area.Variable[0] + "/PVEXEH";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEXEH = dbValue;             
	}

	tagName = Area.Variable[0] + "/PVEXEL";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEXEL = dbValue;             
	}

	tagName = Area.Variable[0] + "/PVEUHI";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEUHI = dbValue;        
	}

	tagName = Area.Variable[0] + "/PVEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEULO = dbValue;             
	}

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
		             string tag=lab.Variable[0];
                             bool PV = tagName.Contains("PV");
                             bool PVTV = tagName.Contains("PVTV");
                             if(PV == true)
                               {

                                    if(dbPVValue <= PVEUHI && dbPVValue >= PVEULO)
                                       {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                       }
                                    else
                                       {
				          CommonFunction._ProjectRelated.Var[1] = "LMT";
                                       }
                               }


                             if(PVTV == true)
                               {
	                 	  if(dbPVValue <= PVEXEH && dbPVValue >= PVEXEL)

				   {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                   }
	                	  else 
                                    {
                                        CommonFunction._ProjectRelated.Var[1] = "LMT";
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
CommonFunction._ProjectRelated.Var[1] = "";

    DrawText P1 = (DrawText)Area.GetDrawObj("PV");
    P1.Variable[0] = "0";
    DrawText V1 = (DrawText)Area.GetDrawObj("PVTV");
    V1.Variable[0] = "0";

    return; 
}



//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd6_PMANLIN_Rect8_OnDynAnimation(Object sender, EventArgs e)	//PVBar
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawRectangle PVBar = (DrawRectangle)dynArgs.sender; 
	
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	double PVValue = 0;
        double PVEUHI = 0;
        double PVEULO = 0;

	string tagName = Area.Variable[0] + "/PVEUHI";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEUHI = dbValue;
             
	}

	tagName = Area.Variable[0] + "/PVEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEULO = dbValue;
             
	}
	
	tagName = Area.Variable[0] + "/PV";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
             PVValue = dbValue;

             if(PVEUHI != PVEULO)
                {
                    double PVScale = PVValue/(PVEUHI - PVEULO);
                    PVBar.Height = (334.00 - 58.00) * PVScale;
                    PVBar.VerticalPosition = 334.00 - PVBar.Height;
                }     
	}
	else
        {
             PVBar.VerticalPosition = 334.00;
             PVBar.Height = 0;
        }

	return; 
}//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd6_PMANLIN_Line16_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawLine PVBlack = (DrawLine)dynArgs.sender; 
   
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	double PVValue = 0;
	
	String tagName = Area.Variable[0] + "/PV";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
             if(dbValue == 0)
                {
                    PVBlack.EdgeColor = Color.Cyan;
                }
             else
                {
                    PVBlack.EdgeColor = Color.Black;
                }
	}
	else
        {
             PVBlack.EdgeColor = Color.Black;
        }

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd6_PMANLIN_LinePVTV_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawLine LinePVTV = (DrawLine)dynArgs.sender; 


	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	double PVValue = 0;
        double PVEXEH = 0;
        double PVEXEL = 0;

	string tagName = Area.Variable[0] + "/PVEXEH";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEXEH = dbValue;
             
	}

	tagName = Area.Variable[0] + "/PVEXEL";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEXEL = dbValue;
             
	}
	
	tagName = Area.Variable[0] + "/PVTV";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
             PVValue = dbValue;
             if(PVEXEH != PVEXEL)
                {
                      double PVScale = PVValue/(PVEXEH - PVEXEL);
                      LinePVTV.VerticalPosition = 334 - (334 - 58) * PVScale;
                }   
	}
	else
             LinePVTV.VerticalPosition = 334;
   
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd6_PMANLIN_TagName_OnDynAnimation(Object sender, EventArgs e)
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
public void gd6_PMANLIN_PV_OnDynAnimation(Object sender, EventArgs e)
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

          if(PV.Variable[0] == "1")

            {
                PV.ForegroundColor = Color.White;
            }

          else

            {
                PV.ForegroundColor = Color.Cyan;
            }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd6_PMANLIN_PV_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PV = (DrawText)dynArgs.sender; 
   
    PV.ForegroundColor = Color.Cyan; 
    PV.Variable[0] = "0";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd6_PMANLIN_PVTV_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVTV = (DrawText)dynArgs.sender;
 
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
	
	tagName = Area.Variable[0] + "/PVTV";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		PVTV.Caption = dbValue.ToString(strDigit);
	}
	else
		PVTV.Caption = "##.#";

          if(PVTV.Variable[0] == "1")

            {
                PVTV.ForegroundColor = Color.White;
            }

          else

            {
                PVTV.ForegroundColor = Color.Cyan;
            }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd6_PMANLIN_PVTV_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVTV = (DrawText)dynArgs.sender; 

    PVTV.ForegroundColor = Color.Cyan; 
    PVTV.Variable[0] = "0";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd6_PMANLIN_Rect9_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 
   
    R_tagname.Visible = true;
    R_tagname.ForegroundColor = Color.Black;
    R_tagname.EdgeColor = Color.Black;
           DrawArea p = (DrawArea)(Area.Parent);
           p.Variable[1] = "0";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void gd6_PMANLIN_Rect9_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 

           DrawArea pic = (DrawArea)(Area.Parent.Parent);

           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd6_PMANLIN_Rect9_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 

           DrawArea p = (DrawArea)(Area.Parent);
           if(p.Variable[1] == "1")
              {
                    R_tagname.ForegroundColor = Color.Blue;
                    R_tagname.EdgeColor = Color.White;
              }
           else
              {
                    R_tagname.ForegroundColor = Color.Black;
                    R_tagname.EdgeColor = Color.Black;

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
 
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd6_PMANLIN_Rect10_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect10 = (DrawRectangle)dynArgs.sender; 
   
    Rect10.Visible = true;
    Rect10.ForegroundColor = Color.Black;
    Rect10.EdgeColor = Color.Black;
           DrawArea p = (DrawArea)(Area.Parent);
           p.Variable[1] = "0";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void gd6_PMANLIN_Rect10_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect10 = (DrawRectangle)dynArgs.sender; 

    DrawText PVTV = (DrawText)Area.GetDrawObj("PVTV");
    PVTV.Variable[0] = "1";
    DrawText PV = (DrawText)Area.GetDrawObj("PV");
    PV.Variable[0] = "0";

    if(PVTV.Visible == true)

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
				CommonFunction.MoveControl(Area,TB,(int)(Rect10.VerticalPosition - 40),(int)(Rect10.HorizontalPosition));		
				obj = CommonFunction.GetLabelOfControl(TB);
				if(obj != null)
				{
					ControlLabel lab = (ControlLabel)obj;
					//给TB传递参数：
					lab.Variable[0] = Area.Variable[0] + "/PVTV";
                                      
				}
			}
		}
	}

    DrawArea pic = (DrawArea)(Area.Parent.Parent); 
           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd6_PMANLIN_Rect10_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect10 = (DrawRectangle)dynArgs.sender; 

    DrawText PVTV = (DrawText)Area.GetDrawObj("PVTV");
    DrawArea p = (DrawArea)(Area.Parent);

			if(PVTV.Variable[0] == "1" && p.Variable[1] == "1")
			{
		 		Rect10.ForegroundColor = Color.Blue;
                                Rect10.EdgeColor = Color.White;                                   
			}
                        else
			{
		 		Rect10.ForegroundColor = Color.Black;
                                Rect10.EdgeColor = Color.Black; 
                                PVTV.Variable[0] = "0";                                  
			}


    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd6_PMANLIN_Rect11_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect11 = (DrawRectangle)dynArgs.sender; 
   
    Rect11.Visible = true;
    Rect11.ForegroundColor = Color.Black;
    Rect11.EdgeColor = Color.Black;
           DrawArea p = (DrawArea)(Area.Parent);
           p.Variable[1] = "0";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void gd6_PMANLIN_Rect11_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect11 = (DrawRectangle)dynArgs.sender; 
   
           DrawArea pic = (DrawArea)(Area.Parent.Parent);

           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

    DrawText PV = (DrawText)Area.GetDrawObj("PV");
    PV.Variable[0] = "1";
    DrawText PVTV = (DrawText)Area.GetDrawObj("PVTV");
    PVTV.Variable[0] = "0";
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
				CommonFunction.MoveControl(Area,TB,(int)(Rect11.VerticalPosition)-40,(int)(Rect11.HorizontalPosition));
			
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
public void gd6_PMANLIN_Rect11_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect11 = (DrawRectangle)dynArgs.sender; 

    DrawText PV = (DrawText)Area.GetDrawObj("PV");
    DrawArea p = (DrawArea)(Area.Parent);

			if(PV.Variable[0] == "1" && p.Variable[1] == "1")
			{
		 		Rect11.ForegroundColor = Color.Blue;
                                Rect11.EdgeColor = Color.White;                                   
			}
                        else
			{
		 		Rect11.ForegroundColor = Color.Black;
                                Rect11.EdgeColor = Color.Black;
                                PV.Variable[0] = "0";                                   
			}

    return; 
}
//Do not remove or update this comment
//Event Delegate:KeyEventHandler 
//Event Handler:KeyUp 
public void gd6_PMANLIN_TB_KeyUp(Object sender, KeyEventArgs e)
{
   TextBox TB = (TextBox)sender; 

   DrawArea Area = CommonFunction.GetThisDrawArea(TB);

     double dbValue = 0;
     int nValue = 0;
     bool bValue = false;
     int nDataType = 0;

        double PVEXEH = 0;
        double PVEXEL = 0;
        double PVEUHI = 0;
        double PVEULO = 0;

	string tagName = Area.Variable[0] + "/PVEXEH";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEXEH = dbValue;             
	}

	tagName = Area.Variable[0] + "/PVEXEL";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEXEL = dbValue;             
	}

	tagName = Area.Variable[0] + "/PVEUHI";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEUHI = dbValue;        
	}

	tagName = Area.Variable[0] + "/PVEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEULO = dbValue;             
	}

	switch ( e.KeyData )
	{
	case Keys.Enter:

		if(TB.Text == "" || TB.Text == null)

		{
			TB.Visible = false;
			TB.Enabled = false;
                        DrawText P = (DrawText)Area.GetDrawObj("PV");
                        P.Variable[0] = "0";
                        DrawText V = (DrawText)Area.GetDrawObj("PVTV");
                        V.Variable[0] = "0";
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
		             string tag=lab.Variable[0];
                             bool PV = tagName.Contains("PV");
                             bool PVTV = tagName.Contains("PVTV");
                             if(PV == true)
                               {

                                    if(dbPVValue <= PVEUHI && dbPVValue >= PVEULO)
                                       {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                       }
                                    else
                                       {
				          CommonFunction._ProjectRelated.Var[1] = "LMT";
                                       }
                               }


                             if(PVTV == true)
                               {
	                 	  if(dbPVValue <= PVEXEH && dbPVValue >= PVEXEL)

				   {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                   }
	                	  else 
                                    {
                                        CommonFunction._ProjectRelated.Var[1] = "LMT";
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
CommonFunction._ProjectRelated.Var[1] = "";
    DrawText P1 = (DrawText)Area.GetDrawObj("PV");
    P1.Variable[0] = "0";
    DrawText V1 = (DrawText)Area.GetDrawObj("PVTV");
    V1.Variable[0] = "0";
    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd6_PMPID_OnDynInitialize(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 
 
	Picture pic = CommonFunction.GetThisPicture(Area);
	if(pic != null)
	{  
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
				TB.Visible = false;
				TB.Focus();
			}
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
//Event Handler:OnDynClick 
public void gd6_PMPID_OnDynClick(Object sender, EventArgs e)
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
public void gd6_PMPID_KeyUp(Object sender, KeyEventArgs e)
{
   TextBox TB = (TextBox)sender; 
   DrawArea Area = CommonFunction.GetThisDrawArea(TB);

     double dbValue = 0;
     int nValue = 0;
     bool bValue = false;
     int nDataType = 0;

        double OPHI = 0;
        double OPLO = 0;
        double SPEUHI = 0;
        double SPEULO = 0;
        double PVEUHI = 0;
        double PVEULO = 0;

	string tagName = Area.Variable[0] + "/OPHI";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     OPHI = dbValue;             
	}

	tagName = Area.Variable[0] + "/OPLO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     OPLO = dbValue;             
	}

	tagName = Area.Variable[0] + "/SPEUHI";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     SPEUHI = dbValue;             
	}

	tagName = Area.Variable[0] + "/SPEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     SPEULO = dbValue;             
	}

	tagName = Area.Variable[0] + "/PVEUHI";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEUHI = dbValue;        
	}

	tagName = Area.Variable[0] + "/PVEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEULO = dbValue;             
	}

     double dbValue1 = 0;
     int nValue1 = 0;
     bool bValue1 = false;
     int nDataType1 = 0;
     string MODE = Area.Variable[0] + "/MODE";
     bool ret1 = CommonFunction.GetValueWithType(MODE,ref dbValue1,ref nValue1,ref bValue1,ref nDataType1);

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
		             string tag=lab.Variable[0];

                             //PV值只有在MODE是MAN的时候才可以改变
                             bool V = tag.Contains("PV");
                             bool O = tag.Contains("OP");
                             bool S = tag.Contains("SP");
                             if(V == true && ret1)
                               {
                                    if(dbPVValue<=PVEUHI && dbPVValue>=PVEULO)
                                       {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                       }
                                    else
                                       {
				          CommonFunction._ProjectRelated.Var[1] = "LMT";
                                       }
                               }

                             if(O == true && ret1)
                               {//OP值只有在MODE是MAN的时候才可以改变
	                 	  if(dbValue1==1)
                                   {
                                    if(dbPVValue<=OPHI && dbPVValue>=OPLO)
                                       {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                       }
                                    else
                                      {
				          CommonFunction._ProjectRelated.Var[1] = "LMT";
                                       }
                                    }
	                	  else 
                                    {
                                        CommonFunction._ProjectRelated.Var[1] = "MODE ERROR";

                                    }
                               }

                             if(S == true && ret1)
                               {//SP值只有在MODE是AUTO的时候才可以改变
                                if(dbValue1==2)
                                 {
	                 	  if(dbPVValue<=SPEUHI && dbPVValue>=SPEULO)

				   {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                   }
	                	  else 
                                    {
                                        CommonFunction._ProjectRelated.Var[1] = "LMT";
                                    }
                                  }
	                	  else 
                                    {
                                        CommonFunction._ProjectRelated.Var[1] = "MODE ERROR";

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

CommonFunction._ProjectRelated.Var[1] = "";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd6_PMPID_ALM_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText ALM = (DrawText)dynArgs.sender; 
   
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
	
	tagName = Area.Variable[0] + "/PVHLFL";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
              string alm = dbValue.ToString(strDigit);

		if(alm == "0.00")

                   {ALM.Caption = "";}

		if(alm == "1.00")

                   {ALM.Caption = "HP";}

		if(alm == "2.00")

                   {ALM.Caption = "2HP";}

		if(alm == "-1.00")

                   {ALM.Caption = "LP";}

		if(alm == "-2.00")

                   {ALM.Caption = "2LP";}
	}
	else
		ALM.Caption = "";
        	

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd6_PMPID_OPBar_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawLine OPBar = (DrawLine)dynArgs.sender; 
   
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	double OPValue = 0;
        double OPHI = 0;
        double OPLO = 0;

	string tagName = Area.Variable[0] + "/OPHI";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     OPHI = dbValue;
             
	}

	tagName = Area.Variable[0] + "/OPLO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     OPLO = dbValue;
             
	}
	
	tagName = Area.Variable[0] + "/OP";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
             OPValue = dbValue;
             double OPScale = OPValue/(OPHI - OPLO);
             OPBar.EndY = 334 - (334 - 58) * OPScale;    
	}
	else
             OPBar.EndY = 334;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd6_PMPID_PVBlack_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawLine PVBlack = (DrawLine)dynArgs.sender; 
   
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	double PVValue = 0;
	
	String tagName = Area.Variable[0] + "/PV";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
             if(dbValue == 0)
                {
                    PVBlack.EdgeColor = Color.Cyan;
                }
             else
                {
                    PVBlack.EdgeColor = Color.Black;
                }
	}
	else
        {
             PVBlack.EdgeColor = Color.Black;
        }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd6_PMPID_SPLine_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawLine SPLine = (DrawLine)dynArgs.sender; 

	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	double SPValue = 0;
        double SPEUHI = 0;
        double SPEULO = 0;

	string tagName = Area.Variable[0] + "/SPEUHI";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     SPEUHI = dbValue;
             
	}

	tagName = Area.Variable[0] + "/SPEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     SPEULO = dbValue;
             
	}
	
	tagName = Area.Variable[0] + "/SP";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
             SPValue = dbValue;
             double SPScale = SPValue/(SPEUHI - SPEULO);
             SPLine.VerticalPosition = 334 - (334 - 58) * SPScale;    
	}
	else
             SPLine.VerticalPosition = 334;
   
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd6_PMPID_PVBar_OnDynAnimation(Object sender, EventArgs e)	//PVBar
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawRectangle PVBar = (DrawRectangle)dynArgs.sender; 
	
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	double PVValue = 0;
        double PVEUHI = 0;
        double PVEULO = 0;

	string tagName = Area.Variable[0] + "/PVEUHI";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEUHI = dbValue;
             
	}

	tagName = Area.Variable[0] + "/PVEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEULO = dbValue;
             
	}
	
	tagName = Area.Variable[0] + "/PV";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
             PVValue = dbValue;
             double PVScale = PVValue/(PVEUHI - PVEULO);
             PVBar.Height = (334.00 - 58.00) * PVScale;
             PVBar.VerticalPosition = 334.00 - PVBar.Height;    
	}
	else
        {
             PVBar.VerticalPosition = 334.00;
             PVBar.Height = 0;
        }

	return; 
}//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd6_PMPID_MODE_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText MODE = (DrawText)dynArgs.sender; 

    DrawRectangle Rect = (DrawRectangle)Area.GetDrawObj("Rect_MODE");  
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	int nDigit = 2;
	string tagName = Area.Variable[0] + "/MODE";

	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
            {
                if(dbValue == 1)
                  {
                      MODE.Caption = "MAN";
                      MODE.ForegroundColor = Color.Black;
                      Rect.ForegroundColor = Color.Yellow;
                  }
                if(dbValue == 2)
                  {
                      MODE.Caption = "AUTO";
                      MODE.ForegroundColor = Color.Cyan;
                      Rect.ForegroundColor = Color.Black;
                  }
                if(dbValue == 3)
                  {
                      MODE.Caption = "CAS";
                      MODE.ForegroundColor = Color.Black;
                      Rect.ForegroundColor = Color.Cyan;
                  }
            }
       else
            {MODE.Caption = "###";}

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void gd6_PMPID_Rect_MODE_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect_MODE = (DrawRectangle)dynArgs.sender; 

           DrawArea pic = (DrawArea)(Area.Parent.Parent);

           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

           DrawArea p = (DrawArea)(Area.Parent.Parent);
           DrawArea G = (DrawArea)p.GetDrawObj("TDC3000_Groupfaceplate");
           G.Visible = true;
           G.Variable[0] = Area.Variable[0];

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd6_PMPID_Unit_OnDynAnimation(Object sender, EventArgs e)
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
public void gd6_PMPID_TagName_OnDynAnimation(Object sender, EventArgs e)
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
public void gd6_PMPID_PV_OnDynAnimation(Object sender, EventArgs e)
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


          if(PV.Variable[0] == "1")

            {
                PV.ForegroundColor = Color.White;
            }

          else

            {
                PV.ForegroundColor = Color.Cyan;
            }

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd6_PMPID_PV_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PV = (DrawText)dynArgs.sender; 
   
    PV.ForegroundColor = Color.Cyan;
    PV.Variable[0] = "0";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd6_PMPID_SP_OnDynAnimation(Object sender, EventArgs e)
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

          if(SP.Variable[0] == "1")

            {
                SP.ForegroundColor = Color.White;
            }

          else

            {
                SP.ForegroundColor = Color.Cyan;
            }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd6_PMPID_SP_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText SP = (DrawText)dynArgs.sender; 

    SP.ForegroundColor = Color.Cyan; 
    SP.Variable[0] = "0";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd6_PMPID_OP_OnDynAnimation(Object sender, EventArgs e)
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

          if(OP.Variable[0] == "1")

            {
                OP.ForegroundColor = Color.White;
            }

          else

            {
                OP.ForegroundColor = Color.Yellow;
            }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd6_PMPID_OP_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText OP = (DrawText)dynArgs.sender; 
 
    OP.ForegroundColor = Color.Yellow; 
    OP.Variable[0] = "0";

    return; 
}


//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd6_PMPID_R_tagname_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 
   
    R_tagname.Visible = true;
    R_tagname.ForegroundColor = Color.Black;
    R_tagname.EdgeColor = Color.Black;
           DrawArea p = (DrawArea)(Area.Parent);
           p.Variable[1] = "0";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void gd6_PMPID_R_tagname_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 
   
           DrawArea pic = (DrawArea)(Area.Parent.Parent);

           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd6_PMPID_R_tagname_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 

           DrawArea p = (DrawArea)(Area.Parent);
           if(p.Variable[1] == "1")
              {
                    R_tagname.ForegroundColor = Color.Blue;
                    R_tagname.EdgeColor = Color.White;
              }
           else
              {
                    R_tagname.ForegroundColor = Color.Black;
                    R_tagname.EdgeColor = Color.Black;

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
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd6_PMPID_Rect7_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect7 = (DrawRectangle)dynArgs.sender; 
   
    Rect7.Visible = true;
    Rect7.ForegroundColor = Color.Black;
    Rect7.EdgeColor = Color.Black;
           DrawArea p = (DrawArea)(Area.Parent);
           p.Variable[1] = "0";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void gd6_PMPID_Rect7_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect7 = (DrawRectangle)dynArgs.sender; 
   
           DrawArea pic = (DrawArea)(Area.Parent.Parent);

           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

    DrawText SP = (DrawText)Area.GetDrawObj("SP");
    SP.Variable[0] = "1";
    DrawText PV = (DrawText)Area.GetDrawObj("PV");
    PV.Variable[0] = "0";
    DrawText OP = (DrawText)Area.GetDrawObj("OP");
    OP.Variable[0] = "0";

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
				CommonFunction.MoveControl(Area,TB,(int)(Rect7.VerticalPosition - 40),(int)(Rect7.HorizontalPosition));		
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
public void gd6_PMPID_Rect7_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect7 = (DrawRectangle)dynArgs.sender; 

    DrawText SP = (DrawText)Area.GetDrawObj("SP");
    DrawArea p = (DrawArea)(Area.Parent);

			if(SP.Variable[0] == "1" && p.Variable[1] == "1")
			{
		 		Rect7.ForegroundColor = Color.Blue;
                                Rect7.EdgeColor = Color.White;                                   
			}
                        else
			{
		 		Rect7.ForegroundColor = Color.Black;
                                Rect7.EdgeColor = Color.Black; 
                                SP.Variable[0] = "0";                                  
			}
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd6_PMPID_Rect8_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect8 = (DrawRectangle)dynArgs.sender; 
   
    Rect8.Visible = true;
    Rect8.ForegroundColor = Color.Black;
    Rect8.EdgeColor = Color.Black;
           DrawArea p = (DrawArea)(Area.Parent);
           p.Variable[1] = "0";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void gd6_PMPID_Rect8_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect8 = (DrawRectangle)dynArgs.sender; 
   
           DrawArea pic = (DrawArea)(Area.Parent.Parent);

           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

    DrawText SP = (DrawText)Area.GetDrawObj("SP");
    SP.Variable[0] = "0";
    DrawText PV = (DrawText)Area.GetDrawObj("PV");
    PV.Variable[0] = "1";
    DrawText OP = (DrawText)Area.GetDrawObj("OP");
    OP.Variable[0] = "0";

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
				CommonFunction.MoveControl(Area,TB,(int)(Rect8.VerticalPosition)-40,(int)(Rect8.HorizontalPosition));
			
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
public void gd6_PMPID_Rect8_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect8 = (DrawRectangle)dynArgs.sender; 

    DrawText PV = (DrawText)Area.GetDrawObj("PV");
    DrawArea p = (DrawArea)(Area.Parent);

			if(PV.Variable[0] == "1" && p.Variable[1] == "1")
			{
		 		Rect8.ForegroundColor = Color.Blue;
                                Rect8.EdgeColor = Color.White;                                   
			}
                        else
			{
		 		Rect8.ForegroundColor = Color.Black;
                                Rect8.EdgeColor = Color.Black;  
                                PV.Variable[0] = "0";                                 
			}

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd6_PMPID_Rect9_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect9 = (DrawRectangle)dynArgs.sender; 
   
    Rect9.Visible = true;
    Rect9.ForegroundColor = Color.Black;
    Rect9.EdgeColor = Color.Black;
           DrawArea p = (DrawArea)(Area.Parent);
           p.Variable[1] = "0";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void gd6_PMPID_Rect9_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect9 = (DrawRectangle)dynArgs.sender; 
   
           DrawArea pic = (DrawArea)(Area.Parent.Parent);

           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

    DrawText SP = (DrawText)Area.GetDrawObj("SP");
    SP.Variable[0] = "0";
    DrawText PV = (DrawText)Area.GetDrawObj("PV");
    PV.Variable[0] = "0";
    DrawText OP = (DrawText)Area.GetDrawObj("OP");
    OP.Variable[0] = "1";

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
			        CommonFunction.MoveControl(Area,TB,(int)(Rect9.VerticalPosition)-40,(int)(Rect9.HorizontalPosition));
				
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
public void gd6_PMPID_Rect9_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect9 = (DrawRectangle)dynArgs.sender; 

    DrawText OP = (DrawText)Area.GetDrawObj("OP");
    DrawArea p = (DrawArea)(Area.Parent);

			if(OP.Variable[0] == "1" && p.Variable[1] == "1")
			{
		 		Rect9.ForegroundColor = Color.Blue;
                                Rect9.EdgeColor = Color.White;                                   
			}
                        else
			{
		 		Rect9.ForegroundColor = Color.Black;
                                Rect9.EdgeColor = Color.Black; 
                                OP.Variable[0] = "0";                                  
			}

    return; 
}
//Do not remove or update this comment
//Event Delegate:KeyEventHandler 
//Event Handler:KeyUp 
public void gd6_PMPID_TB_KeyUp(Object sender, KeyEventArgs e)
{
   TextBox TB = (TextBox)sender; 

   DrawArea Area = CommonFunction.GetThisDrawArea(TB);

     double dbValue = 0;
     int nValue = 0;
     bool bValue = false;
     int nDataType = 0;

        double OPHI = 0;
        double OPLO = 0;
        double SPEUHI = 0;
        double SPEULO = 0;
        double PVEUHI = 0;
        double PVEULO = 0;

	string tagName = Area.Variable[0] + "/OPHI";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     OPHI = dbValue;             
	}

	tagName = Area.Variable[0] + "/OPLO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     OPLO = dbValue;             
	}

	tagName = Area.Variable[0] + "/SPEUHI";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     SPEUHI = dbValue;             
	}

	tagName = Area.Variable[0] + "/SPEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     SPEULO = dbValue;             
	}

	tagName = Area.Variable[0] + "/PVEUHI";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEUHI = dbValue;        
	}

	tagName = Area.Variable[0] + "/PVEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEULO = dbValue;             
	}

     double dbValue1 = 0;
     int nValue1 = 0;
     bool bValue1 = false;
     int nDataType1 = 0;
     string MODE = Area.Variable[0] + "/MODE";
     bool ret1 = CommonFunction.GetValueWithType(MODE,ref dbValue1,ref nValue1,ref bValue1,ref nDataType1);

	switch ( e.KeyData )
	{
	case Keys.Enter:

		if(TB.Text == "" || TB.Text == null)

		{
			TB.Visible = false;
			TB.Enabled = false;
                        DrawText P = (DrawText)Area.GetDrawObj("PV");
                        P.Variable[0] = "0";
                        DrawText OP = (DrawText)Area.GetDrawObj("OP");
                        OP.Variable[0] = "0";
                        DrawText SP = (DrawText)Area.GetDrawObj("SP");
                        SP.Variable[0] = "0";
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
		             string tag=lab.Variable[0];

                             //PV值只有在MODE是MAN的时候才可以改变
                             bool V = tag.Contains("PV");
                             bool O = tag.Contains("OP");
                             bool S = tag.Contains("SP");
                             if(V == true && ret1)
                               {
                                    if(dbPVValue<=PVEUHI && dbPVValue>=PVEULO)
                                       {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                       }
                                    else
                                       {
				          CommonFunction._ProjectRelated.Var[1] = "LMT";
                                       }
                               }

                             if(O == true && ret1)
                               {//OP值只有在MODE是MAN的时候才可以改变
	                 	  if(dbValue1==1)
                                   {
                                    if(dbPVValue<=OPHI && dbPVValue>=OPLO)
                                       {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                       }
                                    else
                                      {
				          CommonFunction._ProjectRelated.Var[1] = "LMT";
                                       }
                                    }
	                	  else 
                                    {
                                        CommonFunction._ProjectRelated.Var[1] = "MODE ERROR";

                                    }
                               }

                             if(S == true && ret1)
                               {//SP值只有在MODE是AUTO的时候才可以改变
                                if(dbValue1==2)
                                 {
	                 	  if(dbPVValue<=SPEUHI && dbPVValue>=SPEULO)

				   {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                   }
	                	  else 
                                    {
                                        CommonFunction._ProjectRelated.Var[1] = "LMT";
                                    }
                                  }
	                	  else 
                                    {
                                        CommonFunction._ProjectRelated.Var[1] = "MODE ERROR";

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
CommonFunction._ProjectRelated.Var[1] = "";
    DrawText P1 = (DrawText)Area.GetDrawObj("PV");
    P1.Variable[0] = "0";
    DrawText OP1 = (DrawText)Area.GetDrawObj("OP");
    OP1.Variable[0] = "0";
    DrawText SP1 = (DrawText)Area.GetDrawObj("SP");
    SP1.Variable[0] = "0";
    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd5_OnDynInitialize(Object sender, EventArgs e)
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
public void gd5_OnDynAnimation(Object sender, EventArgs e)
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

             else 

                {
                     PMDIGCOM.Visible = false;
                     PMPID.Visible = false;
                     PMANLIN.Visible = false;
                }

        }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd5_PMDIGCOM_OnDynInitialize(Object sender, EventArgs e)
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
public void gd5_PMDIGCOM_Rect_PVON_OnDynAnimation(Object sender, EventArgs e)
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
public void gd5_PMDIGCOM_OP_OnDynAnimation(Object sender, EventArgs e)
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
public void gd5_PMDIGCOM_Rect_OFF_OnDynAnimation(Object sender, EventArgs e)
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
public void gd5_PMDIGCOM_Rect_ON_OnDynAnimation(Object sender, EventArgs e)
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
public void gd5_PMDIGCOM_Unit_OnDynAnimation(Object sender, EventArgs e)
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
public void gd5_PMDIGCOM_TagName_OnDynAnimation(Object sender, EventArgs e)
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
//Event Handler:OnDynInitialize 
public void gd5_PMDIGCOM_Rect9_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 
   
    R_tagname.Visible = true;
    R_tagname.ForegroundColor = Color.Black;
    R_tagname.EdgeColor = Color.Black;
           DrawArea p = (DrawArea)(Area.Parent);
           p.Variable[1] = "0";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void gd5_PMDIGCOM_Rect9_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 
   
           DrawArea pic = (DrawArea)(Area.Parent.Parent);

           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd5_PMDIGCOM_Rect9_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 

           DrawArea p = (DrawArea)(Area.Parent);
           if(p.Variable[1] == "1")
              {
                    R_tagname.ForegroundColor = Color.Blue;
                    R_tagname.EdgeColor = Color.White;
              }
           else
              {
                    R_tagname.ForegroundColor = Color.Black;
                    R_tagname.EdgeColor = Color.Black;
              }
 
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd5_PMANLIN_OnDynInitialize(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 
 
	Picture pic = CommonFunction.GetThisPicture(Area);
	if(pic != null)
	{  
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
				TB.Visible = false;
				TB.Focus();
			}
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
//Event Handler:OnDynClick 
public void gd5_PMANLIN_OnDynClick(Object sender, EventArgs e)
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
public void gd5_PMANLIN_KeyUp(Object sender, KeyEventArgs e)
{
   TextBox TB = (TextBox)sender; 

   DrawArea Area = CommonFunction.GetThisDrawArea(TB);

     double dbValue = 0;
     int nValue = 0;
     bool bValue = false;
     int nDataType = 0;

        double PVEXEH = 0;
        double PVEXEL = 0;
        double PVEUHI = 0;
        double PVEULO = 0;

	string tagName = Area.Variable[0] + "/PVEXEH";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEXEH = dbValue;             
	}

	tagName = Area.Variable[0] + "/PVEXEL";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEXEL = dbValue;             
	}

	tagName = Area.Variable[0] + "/PVEUHI";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEUHI = dbValue;        
	}

	tagName = Area.Variable[0] + "/PVEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEULO = dbValue;             
	}

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
		             string tag=lab.Variable[0];
                             bool PV = tagName.Contains("PV");
                             bool PVTV = tagName.Contains("PVTV");
                             if(PV == true)
                               {

                                    if(dbPVValue <= PVEUHI && dbPVValue >= PVEULO)
                                       {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                       }
                                    else
                                       {
				          CommonFunction._ProjectRelated.Var[1] = "LMT";
                                       }
                               }


                             if(PVTV == true)
                               {
	                 	  if(dbPVValue <= PVEXEH && dbPVValue >= PVEXEL)

				   {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                   }
	                	  else 
                                    {
                                        CommonFunction._ProjectRelated.Var[1] = "LMT";
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
CommonFunction._ProjectRelated.Var[1] = "";

    DrawText P1 = (DrawText)Area.GetDrawObj("PV");
    P1.Variable[0] = "0";
    DrawText V1 = (DrawText)Area.GetDrawObj("PVTV");
    V1.Variable[0] = "0";

    return; 
}



//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd5_PMANLIN_Rect8_OnDynAnimation(Object sender, EventArgs e)	//PVBar
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawRectangle PVBar = (DrawRectangle)dynArgs.sender; 
	
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	double PVValue = 0;
        double PVEUHI = 0;
        double PVEULO = 0;

	string tagName = Area.Variable[0] + "/PVEUHI";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEUHI = dbValue;
             
	}

	tagName = Area.Variable[0] + "/PVEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEULO = dbValue;
             
	}
	
	tagName = Area.Variable[0] + "/PV";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
             PVValue = dbValue;

             if(PVEUHI != PVEULO)
                {
                    double PVScale = PVValue/(PVEUHI - PVEULO);
                    PVBar.Height = (334.00 - 58.00) * PVScale;
                    PVBar.VerticalPosition = 334.00 - PVBar.Height;
                }     
	}
	else
        {
             PVBar.VerticalPosition = 334.00;
             PVBar.Height = 0;
        }

	return; 
}//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd5_PMANLIN_Line16_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawLine PVBlack = (DrawLine)dynArgs.sender; 
   
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	double PVValue = 0;
	
	String tagName = Area.Variable[0] + "/PV";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
             if(dbValue == 0)
                {
                    PVBlack.EdgeColor = Color.Cyan;
                }
             else
                {
                    PVBlack.EdgeColor = Color.Black;
                }
	}
	else
        {
             PVBlack.EdgeColor = Color.Black;
        }

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd5_PMANLIN_LinePVTV_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawLine LinePVTV = (DrawLine)dynArgs.sender; 


	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	double PVValue = 0;
        double PVEXEH = 0;
        double PVEXEL = 0;

	string tagName = Area.Variable[0] + "/PVEXEH";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEXEH = dbValue;
             
	}

	tagName = Area.Variable[0] + "/PVEXEL";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEXEL = dbValue;
             
	}
	
	tagName = Area.Variable[0] + "/PVTV";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
             PVValue = dbValue;
             if(PVEXEH != PVEXEL)
                {
                      double PVScale = PVValue/(PVEXEH - PVEXEL);
                      LinePVTV.VerticalPosition = 334 - (334 - 58) * PVScale;
                }   
	}
	else
             LinePVTV.VerticalPosition = 334;
   
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd5_PMANLIN_TagName_OnDynAnimation(Object sender, EventArgs e)
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
public void gd5_PMANLIN_PV_OnDynAnimation(Object sender, EventArgs e)
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

          if(PV.Variable[0] == "1")

            {
                PV.ForegroundColor = Color.White;
            }

          else

            {
                PV.ForegroundColor = Color.Cyan;
            }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd5_PMANLIN_PV_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PV = (DrawText)dynArgs.sender; 
   
    PV.ForegroundColor = Color.Cyan; 
    PV.Variable[0] = "0";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd5_PMANLIN_PVTV_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVTV = (DrawText)dynArgs.sender;
 
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
	
	tagName = Area.Variable[0] + "/PVTV";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		PVTV.Caption = dbValue.ToString(strDigit);
	}
	else
		PVTV.Caption = "##.#";

          if(PVTV.Variable[0] == "1")

            {
                PVTV.ForegroundColor = Color.White;
            }

          else

            {
                PVTV.ForegroundColor = Color.Cyan;
            }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd5_PMANLIN_PVTV_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVTV = (DrawText)dynArgs.sender; 

    PVTV.ForegroundColor = Color.Cyan; 
    PVTV.Variable[0] = "0";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd5_PMANLIN_Rect9_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 
   
    R_tagname.Visible = true;
    R_tagname.ForegroundColor = Color.Black;
    R_tagname.EdgeColor = Color.Black;
           DrawArea p = (DrawArea)(Area.Parent);
           p.Variable[1] = "0";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void gd5_PMANLIN_Rect9_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 

           DrawArea pic = (DrawArea)(Area.Parent.Parent);

           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd5_PMANLIN_Rect9_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 

           DrawArea p = (DrawArea)(Area.Parent);
           if(p.Variable[1] == "1")
              {
                    R_tagname.ForegroundColor = Color.Blue;
                    R_tagname.EdgeColor = Color.White;
              }
           else
              {
                    R_tagname.ForegroundColor = Color.Black;
                    R_tagname.EdgeColor = Color.Black;

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
 
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd5_PMANLIN_Rect10_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect10 = (DrawRectangle)dynArgs.sender; 
   
    Rect10.Visible = true;
    Rect10.ForegroundColor = Color.Black;
    Rect10.EdgeColor = Color.Black;
           DrawArea p = (DrawArea)(Area.Parent);
           p.Variable[1] = "0";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void gd5_PMANLIN_Rect10_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect10 = (DrawRectangle)dynArgs.sender; 

    DrawText PVTV = (DrawText)Area.GetDrawObj("PVTV");
    PVTV.Variable[0] = "1";
    DrawText PV = (DrawText)Area.GetDrawObj("PV");
    PV.Variable[0] = "0";

    if(PVTV.Visible == true)

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
				CommonFunction.MoveControl(Area,TB,(int)(Rect10.VerticalPosition - 40),(int)(Rect10.HorizontalPosition));		
				obj = CommonFunction.GetLabelOfControl(TB);
				if(obj != null)
				{
					ControlLabel lab = (ControlLabel)obj;
					//给TB传递参数：
					lab.Variable[0] = Area.Variable[0] + "/PVTV";
                                      
				}
			}
		}
	}

    DrawArea pic = (DrawArea)(Area.Parent.Parent); 
           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd5_PMANLIN_Rect10_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect10 = (DrawRectangle)dynArgs.sender; 

    DrawText PVTV = (DrawText)Area.GetDrawObj("PVTV");
    DrawArea p = (DrawArea)(Area.Parent);

			if(PVTV.Variable[0] == "1" && p.Variable[1] == "1")
			{
		 		Rect10.ForegroundColor = Color.Blue;
                                Rect10.EdgeColor = Color.White;                                   
			}
                        else
			{
		 		Rect10.ForegroundColor = Color.Black;
                                Rect10.EdgeColor = Color.Black; 
                                PVTV.Variable[0] = "0";                                  
			}


    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd5_PMANLIN_Rect11_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect11 = (DrawRectangle)dynArgs.sender; 
   
    Rect11.Visible = true;
    Rect11.ForegroundColor = Color.Black;
    Rect11.EdgeColor = Color.Black;
           DrawArea p = (DrawArea)(Area.Parent);
           p.Variable[1] = "0";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void gd5_PMANLIN_Rect11_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect11 = (DrawRectangle)dynArgs.sender; 
   
           DrawArea pic = (DrawArea)(Area.Parent.Parent);

           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

    DrawText PV = (DrawText)Area.GetDrawObj("PV");
    PV.Variable[0] = "1";
    DrawText PVTV = (DrawText)Area.GetDrawObj("PVTV");
    PVTV.Variable[0] = "0";
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
				CommonFunction.MoveControl(Area,TB,(int)(Rect11.VerticalPosition)-40,(int)(Rect11.HorizontalPosition));
			
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
public void gd5_PMANLIN_Rect11_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect11 = (DrawRectangle)dynArgs.sender; 

    DrawText PV = (DrawText)Area.GetDrawObj("PV");
    DrawArea p = (DrawArea)(Area.Parent);

			if(PV.Variable[0] == "1" && p.Variable[1] == "1")
			{
		 		Rect11.ForegroundColor = Color.Blue;
                                Rect11.EdgeColor = Color.White;                                   
			}
                        else
			{
		 		Rect11.ForegroundColor = Color.Black;
                                Rect11.EdgeColor = Color.Black;
                                PV.Variable[0] = "0";                                   
			}

    return; 
}
//Do not remove or update this comment
//Event Delegate:KeyEventHandler 
//Event Handler:KeyUp 
public void gd5_PMANLIN_TB_KeyUp(Object sender, KeyEventArgs e)
{
   TextBox TB = (TextBox)sender; 

   DrawArea Area = CommonFunction.GetThisDrawArea(TB);

     double dbValue = 0;
     int nValue = 0;
     bool bValue = false;
     int nDataType = 0;

        double PVEXEH = 0;
        double PVEXEL = 0;
        double PVEUHI = 0;
        double PVEULO = 0;

	string tagName = Area.Variable[0] + "/PVEXEH";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEXEH = dbValue;             
	}

	tagName = Area.Variable[0] + "/PVEXEL";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEXEL = dbValue;             
	}

	tagName = Area.Variable[0] + "/PVEUHI";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEUHI = dbValue;        
	}

	tagName = Area.Variable[0] + "/PVEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEULO = dbValue;             
	}

	switch ( e.KeyData )
	{
	case Keys.Enter:

		if(TB.Text == "" || TB.Text == null)

		{
			TB.Visible = false;
			TB.Enabled = false;
                        DrawText P = (DrawText)Area.GetDrawObj("PV");
                        P.Variable[0] = "0";
                        DrawText V = (DrawText)Area.GetDrawObj("PVTV");
                        V.Variable[0] = "0";
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
		             string tag=lab.Variable[0];
                             bool PV = tagName.Contains("PV");
                             bool PVTV = tagName.Contains("PVTV");
                             if(PV == true)
                               {

                                    if(dbPVValue <= PVEUHI && dbPVValue >= PVEULO)
                                       {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                       }
                                    else
                                       {
				          CommonFunction._ProjectRelated.Var[1] = "LMT";
                                       }
                               }


                             if(PVTV == true)
                               {
	                 	  if(dbPVValue <= PVEXEH && dbPVValue >= PVEXEL)

				   {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                   }
	                	  else 
                                    {
                                        CommonFunction._ProjectRelated.Var[1] = "LMT";
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
CommonFunction._ProjectRelated.Var[1] = "";
    DrawText P1 = (DrawText)Area.GetDrawObj("PV");
    P1.Variable[0] = "0";
    DrawText V1 = (DrawText)Area.GetDrawObj("PVTV");
    V1.Variable[0] = "0";
    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd5_PMPID_OnDynInitialize(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 
 
	Picture pic = CommonFunction.GetThisPicture(Area);
	if(pic != null)
	{  
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
				TB.Visible = false;
				TB.Focus();
			}
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
//Event Handler:OnDynClick 
public void gd5_PMPID_OnDynClick(Object sender, EventArgs e)
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
public void gd5_PMPID_KeyUp(Object sender, KeyEventArgs e)
{
   TextBox TB = (TextBox)sender; 
   DrawArea Area = CommonFunction.GetThisDrawArea(TB);

     double dbValue = 0;
     int nValue = 0;
     bool bValue = false;
     int nDataType = 0;

        double OPHI = 0;
        double OPLO = 0;
        double SPEUHI = 0;
        double SPEULO = 0;
        double PVEUHI = 0;
        double PVEULO = 0;

	string tagName = Area.Variable[0] + "/OPHI";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     OPHI = dbValue;             
	}

	tagName = Area.Variable[0] + "/OPLO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     OPLO = dbValue;             
	}

	tagName = Area.Variable[0] + "/SPEUHI";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     SPEUHI = dbValue;             
	}

	tagName = Area.Variable[0] + "/SPEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     SPEULO = dbValue;             
	}

	tagName = Area.Variable[0] + "/PVEUHI";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEUHI = dbValue;        
	}

	tagName = Area.Variable[0] + "/PVEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEULO = dbValue;             
	}

     double dbValue1 = 0;
     int nValue1 = 0;
     bool bValue1 = false;
     int nDataType1 = 0;
     string MODE = Area.Variable[0] + "/MODE";
     bool ret1 = CommonFunction.GetValueWithType(MODE,ref dbValue1,ref nValue1,ref bValue1,ref nDataType1);

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
		             string tag=lab.Variable[0];

                             //PV值只有在MODE是MAN的时候才可以改变
                             bool V = tag.Contains("PV");
                             bool O = tag.Contains("OP");
                             bool S = tag.Contains("SP");
                             if(V == true && ret1)
                               {
                                    if(dbPVValue<=PVEUHI && dbPVValue>=PVEULO)
                                       {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                       }
                                    else
                                       {
				          CommonFunction._ProjectRelated.Var[1] = "LMT";
                                       }
                               }

                             if(O == true && ret1)
                               {//OP值只有在MODE是MAN的时候才可以改变
	                 	  if(dbValue1==1)
                                   {
                                    if(dbPVValue<=OPHI && dbPVValue>=OPLO)
                                       {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                       }
                                    else
                                      {
				          CommonFunction._ProjectRelated.Var[1] = "LMT";
                                       }
                                    }
	                	  else 
                                    {
                                        CommonFunction._ProjectRelated.Var[1] = "MODE ERROR";

                                    }
                               }

                             if(S == true && ret1)
                               {//SP值只有在MODE是AUTO的时候才可以改变
                                if(dbValue1==2)
                                 {
	                 	  if(dbPVValue<=SPEUHI && dbPVValue>=SPEULO)

				   {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                   }
	                	  else 
                                    {
                                        CommonFunction._ProjectRelated.Var[1] = "LMT";
                                    }
                                  }
	                	  else 
                                    {
                                        CommonFunction._ProjectRelated.Var[1] = "MODE ERROR";

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

CommonFunction._ProjectRelated.Var[1] = "";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd5_PMPID_ALM_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText ALM = (DrawText)dynArgs.sender; 
   
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
	
	tagName = Area.Variable[0] + "/PVHLFL";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
              string alm = dbValue.ToString(strDigit);

		if(alm == "0.00")

                   {ALM.Caption = "";}

		if(alm == "1.00")

                   {ALM.Caption = "HP";}

		if(alm == "2.00")

                   {ALM.Caption = "2HP";}

		if(alm == "-1.00")

                   {ALM.Caption = "LP";}

		if(alm == "-2.00")

                   {ALM.Caption = "2LP";}
	}
	else
		ALM.Caption = "";
        	

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd5_PMPID_OPBar_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawLine OPBar = (DrawLine)dynArgs.sender; 
   
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	double OPValue = 0;
        double OPHI = 0;
        double OPLO = 0;

	string tagName = Area.Variable[0] + "/OPHI";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     OPHI = dbValue;
             
	}

	tagName = Area.Variable[0] + "/OPLO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     OPLO = dbValue;
             
	}
	
	tagName = Area.Variable[0] + "/OP";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
             OPValue = dbValue;
             double OPScale = OPValue/(OPHI - OPLO);
             OPBar.EndY = 334 - (334 - 58) * OPScale;    
	}
	else
             OPBar.EndY = 334;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd5_PMPID_PVBlack_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawLine PVBlack = (DrawLine)dynArgs.sender; 
   
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	double PVValue = 0;
	
	String tagName = Area.Variable[0] + "/PV";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
             if(dbValue == 0)
                {
                    PVBlack.EdgeColor = Color.Cyan;
                }
             else
                {
                    PVBlack.EdgeColor = Color.Black;
                }
	}
	else
        {
             PVBlack.EdgeColor = Color.Black;
        }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd5_PMPID_SPLine_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawLine SPLine = (DrawLine)dynArgs.sender; 

	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	double SPValue = 0;
        double SPEUHI = 0;
        double SPEULO = 0;

	string tagName = Area.Variable[0] + "/SPEUHI";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     SPEUHI = dbValue;
             
	}

	tagName = Area.Variable[0] + "/SPEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     SPEULO = dbValue;
             
	}
	
	tagName = Area.Variable[0] + "/SP";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
             SPValue = dbValue;
             double SPScale = SPValue/(SPEUHI - SPEULO);
             SPLine.VerticalPosition = 334 - (334 - 58) * SPScale;    
	}
	else
             SPLine.VerticalPosition = 334;
   
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd5_PMPID_PVBar_OnDynAnimation(Object sender, EventArgs e)	//PVBar
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawRectangle PVBar = (DrawRectangle)dynArgs.sender; 
	
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	double PVValue = 0;
        double PVEUHI = 0;
        double PVEULO = 0;

	string tagName = Area.Variable[0] + "/PVEUHI";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEUHI = dbValue;
             
	}

	tagName = Area.Variable[0] + "/PVEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEULO = dbValue;
             
	}
	
	tagName = Area.Variable[0] + "/PV";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
             PVValue = dbValue;
             double PVScale = PVValue/(PVEUHI - PVEULO);
             PVBar.Height = (334.00 - 58.00) * PVScale;
             PVBar.VerticalPosition = 334.00 - PVBar.Height;    
	}
	else
        {
             PVBar.VerticalPosition = 334.00;
             PVBar.Height = 0;
        }

	return; 
}//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd5_PMPID_MODE_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText MODE = (DrawText)dynArgs.sender; 

    DrawRectangle Rect = (DrawRectangle)Area.GetDrawObj("Rect_MODE");  
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	int nDigit = 2;
	string tagName = Area.Variable[0] + "/MODE";

	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
            {
                if(dbValue == 1)
                  {
                      MODE.Caption = "MAN";
                      MODE.ForegroundColor = Color.Black;
                      Rect.ForegroundColor = Color.Yellow;
                  }
                if(dbValue == 2)
                  {
                      MODE.Caption = "AUTO";
                      MODE.ForegroundColor = Color.Cyan;
                      Rect.ForegroundColor = Color.Black;
                  }
                if(dbValue == 3)
                  {
                      MODE.Caption = "CAS";
                      MODE.ForegroundColor = Color.Black;
                      Rect.ForegroundColor = Color.Cyan;
                  }
            }
       else
            {MODE.Caption = "###";}

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void gd5_PMPID_Rect_MODE_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect_MODE = (DrawRectangle)dynArgs.sender; 

           DrawArea pic = (DrawArea)(Area.Parent.Parent);

           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

           DrawArea p = (DrawArea)(Area.Parent.Parent);
           DrawArea G = (DrawArea)p.GetDrawObj("TDC3000_Groupfaceplate");
           G.Visible = true;
           G.Variable[0] = Area.Variable[0];

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd5_PMPID_Unit_OnDynAnimation(Object sender, EventArgs e)
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
public void gd5_PMPID_TagName_OnDynAnimation(Object sender, EventArgs e)
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
public void gd5_PMPID_PV_OnDynAnimation(Object sender, EventArgs e)
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


          if(PV.Variable[0] == "1")

            {
                PV.ForegroundColor = Color.White;
            }

          else

            {
                PV.ForegroundColor = Color.Cyan;
            }

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd5_PMPID_PV_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PV = (DrawText)dynArgs.sender; 
   
    PV.ForegroundColor = Color.Cyan;
    PV.Variable[0] = "0";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd5_PMPID_SP_OnDynAnimation(Object sender, EventArgs e)
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

          if(SP.Variable[0] == "1")

            {
                SP.ForegroundColor = Color.White;
            }

          else

            {
                SP.ForegroundColor = Color.Cyan;
            }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd5_PMPID_SP_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText SP = (DrawText)dynArgs.sender; 

    SP.ForegroundColor = Color.Cyan; 
    SP.Variable[0] = "0";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd5_PMPID_OP_OnDynAnimation(Object sender, EventArgs e)
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

          if(OP.Variable[0] == "1")

            {
                OP.ForegroundColor = Color.White;
            }

          else

            {
                OP.ForegroundColor = Color.Yellow;
            }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd5_PMPID_OP_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText OP = (DrawText)dynArgs.sender; 
 
    OP.ForegroundColor = Color.Yellow; 
    OP.Variable[0] = "0";

    return; 
}


//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd5_PMPID_R_tagname_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 
   
    R_tagname.Visible = true;
    R_tagname.ForegroundColor = Color.Black;
    R_tagname.EdgeColor = Color.Black;
           DrawArea p = (DrawArea)(Area.Parent);
           p.Variable[1] = "0";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void gd5_PMPID_R_tagname_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 
   
           DrawArea pic = (DrawArea)(Area.Parent.Parent);

           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd5_PMPID_R_tagname_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 

           DrawArea p = (DrawArea)(Area.Parent);
           if(p.Variable[1] == "1")
              {
                    R_tagname.ForegroundColor = Color.Blue;
                    R_tagname.EdgeColor = Color.White;
              }
           else
              {
                    R_tagname.ForegroundColor = Color.Black;
                    R_tagname.EdgeColor = Color.Black;

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
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd5_PMPID_Rect7_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect7 = (DrawRectangle)dynArgs.sender; 
   
    Rect7.Visible = true;
    Rect7.ForegroundColor = Color.Black;
    Rect7.EdgeColor = Color.Black;
           DrawArea p = (DrawArea)(Area.Parent);
           p.Variable[1] = "0";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void gd5_PMPID_Rect7_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect7 = (DrawRectangle)dynArgs.sender; 
   
           DrawArea pic = (DrawArea)(Area.Parent.Parent);

           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

    DrawText SP = (DrawText)Area.GetDrawObj("SP");
    SP.Variable[0] = "1";
    DrawText PV = (DrawText)Area.GetDrawObj("PV");
    PV.Variable[0] = "0";
    DrawText OP = (DrawText)Area.GetDrawObj("OP");
    OP.Variable[0] = "0";

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
				CommonFunction.MoveControl(Area,TB,(int)(Rect7.VerticalPosition - 40),(int)(Rect7.HorizontalPosition));		
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
public void gd5_PMPID_Rect7_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect7 = (DrawRectangle)dynArgs.sender; 

    DrawText SP = (DrawText)Area.GetDrawObj("SP");
    DrawArea p = (DrawArea)(Area.Parent);

			if(SP.Variable[0] == "1" && p.Variable[1] == "1")
			{
		 		Rect7.ForegroundColor = Color.Blue;
                                Rect7.EdgeColor = Color.White;                                   
			}
                        else
			{
		 		Rect7.ForegroundColor = Color.Black;
                                Rect7.EdgeColor = Color.Black; 
                                SP.Variable[0] = "0";                                  
			}
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd5_PMPID_Rect8_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect8 = (DrawRectangle)dynArgs.sender; 
   
    Rect8.Visible = true;
    Rect8.ForegroundColor = Color.Black;
    Rect8.EdgeColor = Color.Black;
           DrawArea p = (DrawArea)(Area.Parent);
           p.Variable[1] = "0";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void gd5_PMPID_Rect8_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect8 = (DrawRectangle)dynArgs.sender; 
   
           DrawArea pic = (DrawArea)(Area.Parent.Parent);

           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

    DrawText SP = (DrawText)Area.GetDrawObj("SP");
    SP.Variable[0] = "0";
    DrawText PV = (DrawText)Area.GetDrawObj("PV");
    PV.Variable[0] = "1";
    DrawText OP = (DrawText)Area.GetDrawObj("OP");
    OP.Variable[0] = "0";

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
				CommonFunction.MoveControl(Area,TB,(int)(Rect8.VerticalPosition)-40,(int)(Rect8.HorizontalPosition));
			
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
public void gd5_PMPID_Rect8_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect8 = (DrawRectangle)dynArgs.sender; 

    DrawText PV = (DrawText)Area.GetDrawObj("PV");
    DrawArea p = (DrawArea)(Area.Parent);

			if(PV.Variable[0] == "1" && p.Variable[1] == "1")
			{
		 		Rect8.ForegroundColor = Color.Blue;
                                Rect8.EdgeColor = Color.White;                                   
			}
                        else
			{
		 		Rect8.ForegroundColor = Color.Black;
                                Rect8.EdgeColor = Color.Black;  
                                PV.Variable[0] = "0";                                 
			}

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd5_PMPID_Rect9_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect9 = (DrawRectangle)dynArgs.sender; 
   
    Rect9.Visible = true;
    Rect9.ForegroundColor = Color.Black;
    Rect9.EdgeColor = Color.Black;
           DrawArea p = (DrawArea)(Area.Parent);
           p.Variable[1] = "0";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void gd5_PMPID_Rect9_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect9 = (DrawRectangle)dynArgs.sender; 
   
           DrawArea pic = (DrawArea)(Area.Parent.Parent);

           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

    DrawText SP = (DrawText)Area.GetDrawObj("SP");
    SP.Variable[0] = "0";
    DrawText PV = (DrawText)Area.GetDrawObj("PV");
    PV.Variable[0] = "0";
    DrawText OP = (DrawText)Area.GetDrawObj("OP");
    OP.Variable[0] = "1";

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
			        CommonFunction.MoveControl(Area,TB,(int)(Rect9.VerticalPosition)-40,(int)(Rect9.HorizontalPosition));
				
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
public void gd5_PMPID_Rect9_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect9 = (DrawRectangle)dynArgs.sender; 

    DrawText OP = (DrawText)Area.GetDrawObj("OP");
    DrawArea p = (DrawArea)(Area.Parent);

			if(OP.Variable[0] == "1" && p.Variable[1] == "1")
			{
		 		Rect9.ForegroundColor = Color.Blue;
                                Rect9.EdgeColor = Color.White;                                   
			}
                        else
			{
		 		Rect9.ForegroundColor = Color.Black;
                                Rect9.EdgeColor = Color.Black; 
                                OP.Variable[0] = "0";                                  
			}

    return; 
}
//Do not remove or update this comment
//Event Delegate:KeyEventHandler 
//Event Handler:KeyUp 
public void gd5_PMPID_TB_KeyUp(Object sender, KeyEventArgs e)
{
   TextBox TB = (TextBox)sender; 

   DrawArea Area = CommonFunction.GetThisDrawArea(TB);

     double dbValue = 0;
     int nValue = 0;
     bool bValue = false;
     int nDataType = 0;

        double OPHI = 0;
        double OPLO = 0;
        double SPEUHI = 0;
        double SPEULO = 0;
        double PVEUHI = 0;
        double PVEULO = 0;

	string tagName = Area.Variable[0] + "/OPHI";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     OPHI = dbValue;             
	}

	tagName = Area.Variable[0] + "/OPLO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     OPLO = dbValue;             
	}

	tagName = Area.Variable[0] + "/SPEUHI";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     SPEUHI = dbValue;             
	}

	tagName = Area.Variable[0] + "/SPEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     SPEULO = dbValue;             
	}

	tagName = Area.Variable[0] + "/PVEUHI";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEUHI = dbValue;        
	}

	tagName = Area.Variable[0] + "/PVEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEULO = dbValue;             
	}

     double dbValue1 = 0;
     int nValue1 = 0;
     bool bValue1 = false;
     int nDataType1 = 0;
     string MODE = Area.Variable[0] + "/MODE";
     bool ret1 = CommonFunction.GetValueWithType(MODE,ref dbValue1,ref nValue1,ref bValue1,ref nDataType1);

	switch ( e.KeyData )
	{
	case Keys.Enter:

		if(TB.Text == "" || TB.Text == null)

		{
			TB.Visible = false;
			TB.Enabled = false;
                        DrawText P = (DrawText)Area.GetDrawObj("PV");
                        P.Variable[0] = "0";
                        DrawText OP = (DrawText)Area.GetDrawObj("OP");
                        OP.Variable[0] = "0";
                        DrawText SP = (DrawText)Area.GetDrawObj("SP");
                        SP.Variable[0] = "0";
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
		             string tag=lab.Variable[0];

                             //PV值只有在MODE是MAN的时候才可以改变
                             bool V = tag.Contains("PV");
                             bool O = tag.Contains("OP");
                             bool S = tag.Contains("SP");
                             if(V == true && ret1)
                               {
                                    if(dbPVValue<=PVEUHI && dbPVValue>=PVEULO)
                                       {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                       }
                                    else
                                       {
				          CommonFunction._ProjectRelated.Var[1] = "LMT";
                                       }
                               }

                             if(O == true && ret1)
                               {//OP值只有在MODE是MAN的时候才可以改变
	                 	  if(dbValue1==1)
                                   {
                                    if(dbPVValue<=OPHI && dbPVValue>=OPLO)
                                       {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                       }
                                    else
                                      {
				          CommonFunction._ProjectRelated.Var[1] = "LMT";
                                       }
                                    }
	                	  else 
                                    {
                                        CommonFunction._ProjectRelated.Var[1] = "MODE ERROR";

                                    }
                               }

                             if(S == true && ret1)
                               {//SP值只有在MODE是AUTO的时候才可以改变
                                if(dbValue1==2)
                                 {
	                 	  if(dbPVValue<=SPEUHI && dbPVValue>=SPEULO)

				   {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                   }
	                	  else 
                                    {
                                        CommonFunction._ProjectRelated.Var[1] = "LMT";
                                    }
                                  }
	                	  else 
                                    {
                                        CommonFunction._ProjectRelated.Var[1] = "MODE ERROR";

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
CommonFunction._ProjectRelated.Var[1] = "";
    DrawText P1 = (DrawText)Area.GetDrawObj("PV");
    P1.Variable[0] = "0";
    DrawText OP1 = (DrawText)Area.GetDrawObj("OP");
    OP1.Variable[0] = "0";
    DrawText SP1 = (DrawText)Area.GetDrawObj("SP");
    SP1.Variable[0] = "0";
    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd4_OnDynInitialize(Object sender, EventArgs e)
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
public void gd4_OnDynAnimation(Object sender, EventArgs e)
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

             else 

                {
                     PMDIGCOM.Visible = false;
                     PMPID.Visible = false;
                     PMANLIN.Visible = false;
                }

        }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd4_PMDIGCOM_OnDynInitialize(Object sender, EventArgs e)
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
public void gd4_PMDIGCOM_Rect_PVON_OnDynAnimation(Object sender, EventArgs e)
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
public void gd4_PMDIGCOM_OP_OnDynAnimation(Object sender, EventArgs e)
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
public void gd4_PMDIGCOM_Rect_OFF_OnDynAnimation(Object sender, EventArgs e)
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
public void gd4_PMDIGCOM_Rect_ON_OnDynAnimation(Object sender, EventArgs e)
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
public void gd4_PMDIGCOM_Unit_OnDynAnimation(Object sender, EventArgs e)
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
public void gd4_PMDIGCOM_TagName_OnDynAnimation(Object sender, EventArgs e)
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
//Event Handler:OnDynInitialize 
public void gd4_PMDIGCOM_Rect9_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 
   
    R_tagname.Visible = true;
    R_tagname.ForegroundColor = Color.Black;
    R_tagname.EdgeColor = Color.Black;
           DrawArea p = (DrawArea)(Area.Parent);
           p.Variable[1] = "0";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void gd4_PMDIGCOM_Rect9_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 
   
           DrawArea pic = (DrawArea)(Area.Parent.Parent);

           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd4_PMDIGCOM_Rect9_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 

           DrawArea p = (DrawArea)(Area.Parent);
           if(p.Variable[1] == "1")
              {
                    R_tagname.ForegroundColor = Color.Blue;
                    R_tagname.EdgeColor = Color.White;
              }
           else
              {
                    R_tagname.ForegroundColor = Color.Black;
                    R_tagname.EdgeColor = Color.Black;
              }
 
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd4_PMANLIN_OnDynInitialize(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 
 
	Picture pic = CommonFunction.GetThisPicture(Area);
	if(pic != null)
	{  
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
				TB.Visible = false;
				TB.Focus();
			}
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
//Event Handler:OnDynClick 
public void gd4_PMANLIN_OnDynClick(Object sender, EventArgs e)
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
public void gd4_PMANLIN_KeyUp(Object sender, KeyEventArgs e)
{
   TextBox TB = (TextBox)sender; 

   DrawArea Area = CommonFunction.GetThisDrawArea(TB);

     double dbValue = 0;
     int nValue = 0;
     bool bValue = false;
     int nDataType = 0;

        double PVEXEH = 0;
        double PVEXEL = 0;
        double PVEUHI = 0;
        double PVEULO = 0;

	string tagName = Area.Variable[0] + "/PVEXEH";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEXEH = dbValue;             
	}

	tagName = Area.Variable[0] + "/PVEXEL";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEXEL = dbValue;             
	}

	tagName = Area.Variable[0] + "/PVEUHI";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEUHI = dbValue;        
	}

	tagName = Area.Variable[0] + "/PVEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEULO = dbValue;             
	}

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
		             string tag=lab.Variable[0];
                             bool PV = tagName.Contains("PV");
                             bool PVTV = tagName.Contains("PVTV");
                             if(PV == true)
                               {

                                    if(dbPVValue <= PVEUHI && dbPVValue >= PVEULO)
                                       {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                       }
                                    else
                                       {
				          CommonFunction._ProjectRelated.Var[1] = "LMT";
                                       }
                               }


                             if(PVTV == true)
                               {
	                 	  if(dbPVValue <= PVEXEH && dbPVValue >= PVEXEL)

				   {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                   }
	                	  else 
                                    {
                                        CommonFunction._ProjectRelated.Var[1] = "LMT";
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
CommonFunction._ProjectRelated.Var[1] = "";

    DrawText P1 = (DrawText)Area.GetDrawObj("PV");
    P1.Variable[0] = "0";
    DrawText V1 = (DrawText)Area.GetDrawObj("PVTV");
    V1.Variable[0] = "0";

    return; 
}



//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd4_PMANLIN_Rect8_OnDynAnimation(Object sender, EventArgs e)	//PVBar
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawRectangle PVBar = (DrawRectangle)dynArgs.sender; 
	
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	double PVValue = 0;
        double PVEUHI = 0;
        double PVEULO = 0;

	string tagName = Area.Variable[0] + "/PVEUHI";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEUHI = dbValue;
             
	}

	tagName = Area.Variable[0] + "/PVEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEULO = dbValue;
             
	}
	
	tagName = Area.Variable[0] + "/PV";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
             PVValue = dbValue;

             if(PVEUHI != PVEULO)
                {
                    double PVScale = PVValue/(PVEUHI - PVEULO);
                    PVBar.Height = (334.00 - 58.00) * PVScale;
                    PVBar.VerticalPosition = 334.00 - PVBar.Height;
                }     
	}
	else
        {
             PVBar.VerticalPosition = 334.00;
             PVBar.Height = 0;
        }

	return; 
}//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd4_PMANLIN_Line16_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawLine PVBlack = (DrawLine)dynArgs.sender; 
   
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	double PVValue = 0;
	
	String tagName = Area.Variable[0] + "/PV";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
             if(dbValue == 0)
                {
                    PVBlack.EdgeColor = Color.Cyan;
                }
             else
                {
                    PVBlack.EdgeColor = Color.Black;
                }
	}
	else
        {
             PVBlack.EdgeColor = Color.Black;
        }

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd4_PMANLIN_LinePVTV_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawLine LinePVTV = (DrawLine)dynArgs.sender; 


	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	double PVValue = 0;
        double PVEXEH = 0;
        double PVEXEL = 0;

	string tagName = Area.Variable[0] + "/PVEXEH";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEXEH = dbValue;
             
	}

	tagName = Area.Variable[0] + "/PVEXEL";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEXEL = dbValue;
             
	}
	
	tagName = Area.Variable[0] + "/PVTV";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
             PVValue = dbValue;
             if(PVEXEH != PVEXEL)
                {
                      double PVScale = PVValue/(PVEXEH - PVEXEL);
                      LinePVTV.VerticalPosition = 334 - (334 - 58) * PVScale;
                }   
	}
	else
             LinePVTV.VerticalPosition = 334;
   
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd4_PMANLIN_TagName_OnDynAnimation(Object sender, EventArgs e)
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
public void gd4_PMANLIN_PV_OnDynAnimation(Object sender, EventArgs e)
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

          if(PV.Variable[0] == "1")

            {
                PV.ForegroundColor = Color.White;
            }

          else

            {
                PV.ForegroundColor = Color.Cyan;
            }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd4_PMANLIN_PV_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PV = (DrawText)dynArgs.sender; 
   
    PV.ForegroundColor = Color.Cyan; 
    PV.Variable[0] = "0";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd4_PMANLIN_PVTV_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVTV = (DrawText)dynArgs.sender;
 
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
	
	tagName = Area.Variable[0] + "/PVTV";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		PVTV.Caption = dbValue.ToString(strDigit);
	}
	else
		PVTV.Caption = "##.#";

          if(PVTV.Variable[0] == "1")

            {
                PVTV.ForegroundColor = Color.White;
            }

          else

            {
                PVTV.ForegroundColor = Color.Cyan;
            }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd4_PMANLIN_PVTV_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVTV = (DrawText)dynArgs.sender; 

    PVTV.ForegroundColor = Color.Cyan; 
    PVTV.Variable[0] = "0";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd4_PMANLIN_Rect9_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 
   
    R_tagname.Visible = true;
    R_tagname.ForegroundColor = Color.Black;
    R_tagname.EdgeColor = Color.Black;
           DrawArea p = (DrawArea)(Area.Parent);
           p.Variable[1] = "0";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void gd4_PMANLIN_Rect9_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 

           DrawArea pic = (DrawArea)(Area.Parent.Parent);

           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd4_PMANLIN_Rect9_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 

           DrawArea p = (DrawArea)(Area.Parent);
           if(p.Variable[1] == "1")
              {
                    R_tagname.ForegroundColor = Color.Blue;
                    R_tagname.EdgeColor = Color.White;
              }
           else
              {
                    R_tagname.ForegroundColor = Color.Black;
                    R_tagname.EdgeColor = Color.Black;

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
 
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd4_PMANLIN_Rect10_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect10 = (DrawRectangle)dynArgs.sender; 
   
    Rect10.Visible = true;
    Rect10.ForegroundColor = Color.Black;
    Rect10.EdgeColor = Color.Black;
           DrawArea p = (DrawArea)(Area.Parent);
           p.Variable[1] = "0";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void gd4_PMANLIN_Rect10_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect10 = (DrawRectangle)dynArgs.sender; 

    DrawText PVTV = (DrawText)Area.GetDrawObj("PVTV");
    PVTV.Variable[0] = "1";
    DrawText PV = (DrawText)Area.GetDrawObj("PV");
    PV.Variable[0] = "0";

    if(PVTV.Visible == true)

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
				CommonFunction.MoveControl(Area,TB,(int)(Rect10.VerticalPosition - 40),(int)(Rect10.HorizontalPosition));		
				obj = CommonFunction.GetLabelOfControl(TB);
				if(obj != null)
				{
					ControlLabel lab = (ControlLabel)obj;
					//给TB传递参数：
					lab.Variable[0] = Area.Variable[0] + "/PVTV";
                                      
				}
			}
		}
	}

    DrawArea pic = (DrawArea)(Area.Parent.Parent); 
           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd4_PMANLIN_Rect10_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect10 = (DrawRectangle)dynArgs.sender; 

    DrawText PVTV = (DrawText)Area.GetDrawObj("PVTV");
    DrawArea p = (DrawArea)(Area.Parent);

			if(PVTV.Variable[0] == "1" && p.Variable[1] == "1")
			{
		 		Rect10.ForegroundColor = Color.Blue;
                                Rect10.EdgeColor = Color.White;                                   
			}
                        else
			{
		 		Rect10.ForegroundColor = Color.Black;
                                Rect10.EdgeColor = Color.Black; 
                                PVTV.Variable[0] = "0";                                  
			}


    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd4_PMANLIN_Rect11_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect11 = (DrawRectangle)dynArgs.sender; 
   
    Rect11.Visible = true;
    Rect11.ForegroundColor = Color.Black;
    Rect11.EdgeColor = Color.Black;
           DrawArea p = (DrawArea)(Area.Parent);
           p.Variable[1] = "0";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void gd4_PMANLIN_Rect11_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect11 = (DrawRectangle)dynArgs.sender; 
   
           DrawArea pic = (DrawArea)(Area.Parent.Parent);

           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

    DrawText PV = (DrawText)Area.GetDrawObj("PV");
    PV.Variable[0] = "1";
    DrawText PVTV = (DrawText)Area.GetDrawObj("PVTV");
    PVTV.Variable[0] = "0";
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
				CommonFunction.MoveControl(Area,TB,(int)(Rect11.VerticalPosition)-40,(int)(Rect11.HorizontalPosition));
			
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
public void gd4_PMANLIN_Rect11_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect11 = (DrawRectangle)dynArgs.sender; 

    DrawText PV = (DrawText)Area.GetDrawObj("PV");
    DrawArea p = (DrawArea)(Area.Parent);

			if(PV.Variable[0] == "1" && p.Variable[1] == "1")
			{
		 		Rect11.ForegroundColor = Color.Blue;
                                Rect11.EdgeColor = Color.White;                                   
			}
                        else
			{
		 		Rect11.ForegroundColor = Color.Black;
                                Rect11.EdgeColor = Color.Black;
                                PV.Variable[0] = "0";                                   
			}

    return; 
}
//Do not remove or update this comment
//Event Delegate:KeyEventHandler 
//Event Handler:KeyUp 
public void gd4_PMANLIN_TB_KeyUp(Object sender, KeyEventArgs e)
{
   TextBox TB = (TextBox)sender; 

   DrawArea Area = CommonFunction.GetThisDrawArea(TB);

     double dbValue = 0;
     int nValue = 0;
     bool bValue = false;
     int nDataType = 0;

        double PVEXEH = 0;
        double PVEXEL = 0;
        double PVEUHI = 0;
        double PVEULO = 0;

	string tagName = Area.Variable[0] + "/PVEXEH";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEXEH = dbValue;             
	}

	tagName = Area.Variable[0] + "/PVEXEL";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEXEL = dbValue;             
	}

	tagName = Area.Variable[0] + "/PVEUHI";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEUHI = dbValue;        
	}

	tagName = Area.Variable[0] + "/PVEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEULO = dbValue;             
	}

	switch ( e.KeyData )
	{
	case Keys.Enter:

		if(TB.Text == "" || TB.Text == null)

		{
			TB.Visible = false;
			TB.Enabled = false;
                        DrawText P = (DrawText)Area.GetDrawObj("PV");
                        P.Variable[0] = "0";
                        DrawText V = (DrawText)Area.GetDrawObj("PVTV");
                        V.Variable[0] = "0";
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
		             string tag=lab.Variable[0];
                             bool PV = tagName.Contains("PV");
                             bool PVTV = tagName.Contains("PVTV");
                             if(PV == true)
                               {

                                    if(dbPVValue <= PVEUHI && dbPVValue >= PVEULO)
                                       {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                       }
                                    else
                                       {
				          CommonFunction._ProjectRelated.Var[1] = "LMT";
                                       }
                               }


                             if(PVTV == true)
                               {
	                 	  if(dbPVValue <= PVEXEH && dbPVValue >= PVEXEL)

				   {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                   }
	                	  else 
                                    {
                                        CommonFunction._ProjectRelated.Var[1] = "LMT";
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
CommonFunction._ProjectRelated.Var[1] = "";
    DrawText P1 = (DrawText)Area.GetDrawObj("PV");
    P1.Variable[0] = "0";
    DrawText V1 = (DrawText)Area.GetDrawObj("PVTV");
    V1.Variable[0] = "0";
    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd4_PMPID_OnDynInitialize(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 
 
	Picture pic = CommonFunction.GetThisPicture(Area);
	if(pic != null)
	{  
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
				TB.Visible = false;
				TB.Focus();
			}
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
//Event Handler:OnDynClick 
public void gd4_PMPID_OnDynClick(Object sender, EventArgs e)
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
public void gd4_PMPID_KeyUp(Object sender, KeyEventArgs e)
{
   TextBox TB = (TextBox)sender; 
   DrawArea Area = CommonFunction.GetThisDrawArea(TB);

     double dbValue = 0;
     int nValue = 0;
     bool bValue = false;
     int nDataType = 0;

        double OPHI = 0;
        double OPLO = 0;
        double SPEUHI = 0;
        double SPEULO = 0;
        double PVEUHI = 0;
        double PVEULO = 0;

	string tagName = Area.Variable[0] + "/OPHI";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     OPHI = dbValue;             
	}

	tagName = Area.Variable[0] + "/OPLO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     OPLO = dbValue;             
	}

	tagName = Area.Variable[0] + "/SPEUHI";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     SPEUHI = dbValue;             
	}

	tagName = Area.Variable[0] + "/SPEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     SPEULO = dbValue;             
	}

	tagName = Area.Variable[0] + "/PVEUHI";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEUHI = dbValue;        
	}

	tagName = Area.Variable[0] + "/PVEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEULO = dbValue;             
	}

     double dbValue1 = 0;
     int nValue1 = 0;
     bool bValue1 = false;
     int nDataType1 = 0;
     string MODE = Area.Variable[0] + "/MODE";
     bool ret1 = CommonFunction.GetValueWithType(MODE,ref dbValue1,ref nValue1,ref bValue1,ref nDataType1);

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
		             string tag=lab.Variable[0];

                             //PV值只有在MODE是MAN的时候才可以改变
                             bool V = tag.Contains("PV");
                             bool O = tag.Contains("OP");
                             bool S = tag.Contains("SP");
                             if(V == true && ret1)
                               {
                                    if(dbPVValue<=PVEUHI && dbPVValue>=PVEULO)
                                       {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                       }
                                    else
                                       {
				          CommonFunction._ProjectRelated.Var[1] = "LMT";
                                       }
                               }

                             if(O == true && ret1)
                               {//OP值只有在MODE是MAN的时候才可以改变
	                 	  if(dbValue1==1)
                                   {
                                    if(dbPVValue<=OPHI && dbPVValue>=OPLO)
                                       {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                       }
                                    else
                                      {
				          CommonFunction._ProjectRelated.Var[1] = "LMT";
                                       }
                                    }
	                	  else 
                                    {
                                        CommonFunction._ProjectRelated.Var[1] = "MODE ERROR";

                                    }
                               }

                             if(S == true && ret1)
                               {//SP值只有在MODE是AUTO的时候才可以改变
                                if(dbValue1==2)
                                 {
	                 	  if(dbPVValue<=SPEUHI && dbPVValue>=SPEULO)

				   {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                   }
	                	  else 
                                    {
                                        CommonFunction._ProjectRelated.Var[1] = "LMT";
                                    }
                                  }
	                	  else 
                                    {
                                        CommonFunction._ProjectRelated.Var[1] = "MODE ERROR";

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

CommonFunction._ProjectRelated.Var[1] = "";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd4_PMPID_ALM_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText ALM = (DrawText)dynArgs.sender; 
   
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
	
	tagName = Area.Variable[0] + "/PVHLFL";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
              string alm = dbValue.ToString(strDigit);

		if(alm == "0.00")

                   {ALM.Caption = "";}

		if(alm == "1.00")

                   {ALM.Caption = "HP";}

		if(alm == "2.00")

                   {ALM.Caption = "2HP";}

		if(alm == "-1.00")

                   {ALM.Caption = "LP";}

		if(alm == "-2.00")

                   {ALM.Caption = "2LP";}
	}
	else
		ALM.Caption = "";
        	

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd4_PMPID_OPBar_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawLine OPBar = (DrawLine)dynArgs.sender; 
   
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	double OPValue = 0;
        double OPHI = 0;
        double OPLO = 0;

	string tagName = Area.Variable[0] + "/OPHI";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     OPHI = dbValue;
             
	}

	tagName = Area.Variable[0] + "/OPLO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     OPLO = dbValue;
             
	}
	
	tagName = Area.Variable[0] + "/OP";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
             OPValue = dbValue;
             double OPScale = OPValue/(OPHI - OPLO);
             OPBar.EndY = 334 - (334 - 58) * OPScale;    
	}
	else
             OPBar.EndY = 334;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd4_PMPID_PVBlack_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawLine PVBlack = (DrawLine)dynArgs.sender; 
   
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	double PVValue = 0;
	
	String tagName = Area.Variable[0] + "/PV";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
             if(dbValue == 0)
                {
                    PVBlack.EdgeColor = Color.Cyan;
                }
             else
                {
                    PVBlack.EdgeColor = Color.Black;
                }
	}
	else
        {
             PVBlack.EdgeColor = Color.Black;
        }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd4_PMPID_SPLine_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawLine SPLine = (DrawLine)dynArgs.sender; 

	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	double SPValue = 0;
        double SPEUHI = 0;
        double SPEULO = 0;

	string tagName = Area.Variable[0] + "/SPEUHI";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     SPEUHI = dbValue;
             
	}

	tagName = Area.Variable[0] + "/SPEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     SPEULO = dbValue;
             
	}
	
	tagName = Area.Variable[0] + "/SP";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
             SPValue = dbValue;
             double SPScale = SPValue/(SPEUHI - SPEULO);
             SPLine.VerticalPosition = 334 - (334 - 58) * SPScale;    
	}
	else
             SPLine.VerticalPosition = 334;
   
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd4_PMPID_PVBar_OnDynAnimation(Object sender, EventArgs e)	//PVBar
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawRectangle PVBar = (DrawRectangle)dynArgs.sender; 
	
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	double PVValue = 0;
        double PVEUHI = 0;
        double PVEULO = 0;

	string tagName = Area.Variable[0] + "/PVEUHI";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEUHI = dbValue;
             
	}

	tagName = Area.Variable[0] + "/PVEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEULO = dbValue;
             
	}
	
	tagName = Area.Variable[0] + "/PV";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
             PVValue = dbValue;
             double PVScale = PVValue/(PVEUHI - PVEULO);
             PVBar.Height = (334.00 - 58.00) * PVScale;
             PVBar.VerticalPosition = 334.00 - PVBar.Height;    
	}
	else
        {
             PVBar.VerticalPosition = 334.00;
             PVBar.Height = 0;
        }

	return; 
}//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd4_PMPID_MODE_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText MODE = (DrawText)dynArgs.sender; 

    DrawRectangle Rect = (DrawRectangle)Area.GetDrawObj("Rect_MODE");  
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	int nDigit = 2;
	string tagName = Area.Variable[0] + "/MODE";

	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
            {
                if(dbValue == 1)
                  {
                      MODE.Caption = "MAN";
                      MODE.ForegroundColor = Color.Black;
                      Rect.ForegroundColor = Color.Yellow;
                  }
                if(dbValue == 2)
                  {
                      MODE.Caption = "AUTO";
                      MODE.ForegroundColor = Color.Cyan;
                      Rect.ForegroundColor = Color.Black;
                  }
                if(dbValue == 3)
                  {
                      MODE.Caption = "CAS";
                      MODE.ForegroundColor = Color.Black;
                      Rect.ForegroundColor = Color.Cyan;
                  }
            }
       else
            {MODE.Caption = "###";}

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void gd4_PMPID_Rect_MODE_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect_MODE = (DrawRectangle)dynArgs.sender; 

           DrawArea pic = (DrawArea)(Area.Parent.Parent);

           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

           DrawArea p = (DrawArea)(Area.Parent.Parent);
           DrawArea G = (DrawArea)p.GetDrawObj("TDC3000_Groupfaceplate");
           G.Visible = true;
           G.Variable[0] = Area.Variable[0];

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd4_PMPID_Unit_OnDynAnimation(Object sender, EventArgs e)
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
public void gd4_PMPID_TagName_OnDynAnimation(Object sender, EventArgs e)
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
public void gd4_PMPID_PV_OnDynAnimation(Object sender, EventArgs e)
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


          if(PV.Variable[0] == "1")

            {
                PV.ForegroundColor = Color.White;
            }

          else

            {
                PV.ForegroundColor = Color.Cyan;
            }

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd4_PMPID_PV_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PV = (DrawText)dynArgs.sender; 
   
    PV.ForegroundColor = Color.Cyan;
    PV.Variable[0] = "0";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd4_PMPID_SP_OnDynAnimation(Object sender, EventArgs e)
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

          if(SP.Variable[0] == "1")

            {
                SP.ForegroundColor = Color.White;
            }

          else

            {
                SP.ForegroundColor = Color.Cyan;
            }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd4_PMPID_SP_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText SP = (DrawText)dynArgs.sender; 

    SP.ForegroundColor = Color.Cyan; 
    SP.Variable[0] = "0";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd4_PMPID_OP_OnDynAnimation(Object sender, EventArgs e)
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

          if(OP.Variable[0] == "1")

            {
                OP.ForegroundColor = Color.White;
            }

          else

            {
                OP.ForegroundColor = Color.Yellow;
            }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd4_PMPID_OP_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText OP = (DrawText)dynArgs.sender; 
 
    OP.ForegroundColor = Color.Yellow; 
    OP.Variable[0] = "0";

    return; 
}


//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd4_PMPID_R_tagname_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 
   
    R_tagname.Visible = true;
    R_tagname.ForegroundColor = Color.Black;
    R_tagname.EdgeColor = Color.Black;
           DrawArea p = (DrawArea)(Area.Parent);
           p.Variable[1] = "0";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void gd4_PMPID_R_tagname_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 
   
           DrawArea pic = (DrawArea)(Area.Parent.Parent);

           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd4_PMPID_R_tagname_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 

           DrawArea p = (DrawArea)(Area.Parent);
           if(p.Variable[1] == "1")
              {
                    R_tagname.ForegroundColor = Color.Blue;
                    R_tagname.EdgeColor = Color.White;
              }
           else
              {
                    R_tagname.ForegroundColor = Color.Black;
                    R_tagname.EdgeColor = Color.Black;

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
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd4_PMPID_Rect7_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect7 = (DrawRectangle)dynArgs.sender; 
   
    Rect7.Visible = true;
    Rect7.ForegroundColor = Color.Black;
    Rect7.EdgeColor = Color.Black;
           DrawArea p = (DrawArea)(Area.Parent);
           p.Variable[1] = "0";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void gd4_PMPID_Rect7_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect7 = (DrawRectangle)dynArgs.sender; 
   
           DrawArea pic = (DrawArea)(Area.Parent.Parent);

           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

    DrawText SP = (DrawText)Area.GetDrawObj("SP");
    SP.Variable[0] = "1";
    DrawText PV = (DrawText)Area.GetDrawObj("PV");
    PV.Variable[0] = "0";
    DrawText OP = (DrawText)Area.GetDrawObj("OP");
    OP.Variable[0] = "0";

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
				CommonFunction.MoveControl(Area,TB,(int)(Rect7.VerticalPosition - 40),(int)(Rect7.HorizontalPosition));		
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
public void gd4_PMPID_Rect7_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect7 = (DrawRectangle)dynArgs.sender; 

    DrawText SP = (DrawText)Area.GetDrawObj("SP");
    DrawArea p = (DrawArea)(Area.Parent);

			if(SP.Variable[0] == "1" && p.Variable[1] == "1")
			{
		 		Rect7.ForegroundColor = Color.Blue;
                                Rect7.EdgeColor = Color.White;                                   
			}
                        else
			{
		 		Rect7.ForegroundColor = Color.Black;
                                Rect7.EdgeColor = Color.Black; 
                                SP.Variable[0] = "0";                                  
			}
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd4_PMPID_Rect8_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect8 = (DrawRectangle)dynArgs.sender; 
   
    Rect8.Visible = true;
    Rect8.ForegroundColor = Color.Black;
    Rect8.EdgeColor = Color.Black;
           DrawArea p = (DrawArea)(Area.Parent);
           p.Variable[1] = "0";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void gd4_PMPID_Rect8_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect8 = (DrawRectangle)dynArgs.sender; 
   
           DrawArea pic = (DrawArea)(Area.Parent.Parent);

           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

    DrawText SP = (DrawText)Area.GetDrawObj("SP");
    SP.Variable[0] = "0";
    DrawText PV = (DrawText)Area.GetDrawObj("PV");
    PV.Variable[0] = "1";
    DrawText OP = (DrawText)Area.GetDrawObj("OP");
    OP.Variable[0] = "0";

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
				CommonFunction.MoveControl(Area,TB,(int)(Rect8.VerticalPosition)-40,(int)(Rect8.HorizontalPosition));
			
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
public void gd4_PMPID_Rect8_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect8 = (DrawRectangle)dynArgs.sender; 

    DrawText PV = (DrawText)Area.GetDrawObj("PV");
    DrawArea p = (DrawArea)(Area.Parent);

			if(PV.Variable[0] == "1" && p.Variable[1] == "1")
			{
		 		Rect8.ForegroundColor = Color.Blue;
                                Rect8.EdgeColor = Color.White;                                   
			}
                        else
			{
		 		Rect8.ForegroundColor = Color.Black;
                                Rect8.EdgeColor = Color.Black;  
                                PV.Variable[0] = "0";                                 
			}

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd4_PMPID_Rect9_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect9 = (DrawRectangle)dynArgs.sender; 
   
    Rect9.Visible = true;
    Rect9.ForegroundColor = Color.Black;
    Rect9.EdgeColor = Color.Black;
           DrawArea p = (DrawArea)(Area.Parent);
           p.Variable[1] = "0";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void gd4_PMPID_Rect9_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect9 = (DrawRectangle)dynArgs.sender; 
   
           DrawArea pic = (DrawArea)(Area.Parent.Parent);

           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

    DrawText SP = (DrawText)Area.GetDrawObj("SP");
    SP.Variable[0] = "0";
    DrawText PV = (DrawText)Area.GetDrawObj("PV");
    PV.Variable[0] = "0";
    DrawText OP = (DrawText)Area.GetDrawObj("OP");
    OP.Variable[0] = "1";

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
			        CommonFunction.MoveControl(Area,TB,(int)(Rect9.VerticalPosition)-40,(int)(Rect9.HorizontalPosition));
				
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
public void gd4_PMPID_Rect9_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect9 = (DrawRectangle)dynArgs.sender; 

    DrawText OP = (DrawText)Area.GetDrawObj("OP");
    DrawArea p = (DrawArea)(Area.Parent);

			if(OP.Variable[0] == "1" && p.Variable[1] == "1")
			{
		 		Rect9.ForegroundColor = Color.Blue;
                                Rect9.EdgeColor = Color.White;                                   
			}
                        else
			{
		 		Rect9.ForegroundColor = Color.Black;
                                Rect9.EdgeColor = Color.Black; 
                                OP.Variable[0] = "0";                                  
			}

    return; 
}
//Do not remove or update this comment
//Event Delegate:KeyEventHandler 
//Event Handler:KeyUp 
public void gd4_PMPID_TB_KeyUp(Object sender, KeyEventArgs e)
{
   TextBox TB = (TextBox)sender; 

   DrawArea Area = CommonFunction.GetThisDrawArea(TB);

     double dbValue = 0;
     int nValue = 0;
     bool bValue = false;
     int nDataType = 0;

        double OPHI = 0;
        double OPLO = 0;
        double SPEUHI = 0;
        double SPEULO = 0;
        double PVEUHI = 0;
        double PVEULO = 0;

	string tagName = Area.Variable[0] + "/OPHI";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     OPHI = dbValue;             
	}

	tagName = Area.Variable[0] + "/OPLO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     OPLO = dbValue;             
	}

	tagName = Area.Variable[0] + "/SPEUHI";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     SPEUHI = dbValue;             
	}

	tagName = Area.Variable[0] + "/SPEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     SPEULO = dbValue;             
	}

	tagName = Area.Variable[0] + "/PVEUHI";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEUHI = dbValue;        
	}

	tagName = Area.Variable[0] + "/PVEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEULO = dbValue;             
	}

     double dbValue1 = 0;
     int nValue1 = 0;
     bool bValue1 = false;
     int nDataType1 = 0;
     string MODE = Area.Variable[0] + "/MODE";
     bool ret1 = CommonFunction.GetValueWithType(MODE,ref dbValue1,ref nValue1,ref bValue1,ref nDataType1);

	switch ( e.KeyData )
	{
	case Keys.Enter:

		if(TB.Text == "" || TB.Text == null)

		{
			TB.Visible = false;
			TB.Enabled = false;
                        DrawText P = (DrawText)Area.GetDrawObj("PV");
                        P.Variable[0] = "0";
                        DrawText OP = (DrawText)Area.GetDrawObj("OP");
                        OP.Variable[0] = "0";
                        DrawText SP = (DrawText)Area.GetDrawObj("SP");
                        SP.Variable[0] = "0";
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
		             string tag=lab.Variable[0];

                             //PV值只有在MODE是MAN的时候才可以改变
                             bool V = tag.Contains("PV");
                             bool O = tag.Contains("OP");
                             bool S = tag.Contains("SP");
                             if(V == true && ret1)
                               {
                                    if(dbPVValue<=PVEUHI && dbPVValue>=PVEULO)
                                       {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                       }
                                    else
                                       {
				          CommonFunction._ProjectRelated.Var[1] = "LMT";
                                       }
                               }

                             if(O == true && ret1)
                               {//OP值只有在MODE是MAN的时候才可以改变
	                 	  if(dbValue1==1)
                                   {
                                    if(dbPVValue<=OPHI && dbPVValue>=OPLO)
                                       {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                       }
                                    else
                                      {
				          CommonFunction._ProjectRelated.Var[1] = "LMT";
                                       }
                                    }
	                	  else 
                                    {
                                        CommonFunction._ProjectRelated.Var[1] = "MODE ERROR";

                                    }
                               }

                             if(S == true && ret1)
                               {//SP值只有在MODE是AUTO的时候才可以改变
                                if(dbValue1==2)
                                 {
	                 	  if(dbPVValue<=SPEUHI && dbPVValue>=SPEULO)

				   {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                   }
	                	  else 
                                    {
                                        CommonFunction._ProjectRelated.Var[1] = "LMT";
                                    }
                                  }
	                	  else 
                                    {
                                        CommonFunction._ProjectRelated.Var[1] = "MODE ERROR";

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
CommonFunction._ProjectRelated.Var[1] = "";
    DrawText P1 = (DrawText)Area.GetDrawObj("PV");
    P1.Variable[0] = "0";
    DrawText OP1 = (DrawText)Area.GetDrawObj("OP");
    OP1.Variable[0] = "0";
    DrawText SP1 = (DrawText)Area.GetDrawObj("SP");
    SP1.Variable[0] = "0";
    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd3_OnDynInitialize(Object sender, EventArgs e)
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
public void gd3_OnDynAnimation(Object sender, EventArgs e)
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

             else 

                {
                     PMDIGCOM.Visible = false;
                     PMPID.Visible = false;
                     PMANLIN.Visible = false;
                }

        }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd3_PMDIGCOM_OnDynInitialize(Object sender, EventArgs e)
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
public void gd3_PMDIGCOM_Rect_PVON_OnDynAnimation(Object sender, EventArgs e)
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
public void gd3_PMDIGCOM_OP_OnDynAnimation(Object sender, EventArgs e)
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
public void gd3_PMDIGCOM_Rect_OFF_OnDynAnimation(Object sender, EventArgs e)
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
public void gd3_PMDIGCOM_Rect_ON_OnDynAnimation(Object sender, EventArgs e)
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
public void gd3_PMDIGCOM_Unit_OnDynAnimation(Object sender, EventArgs e)
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
public void gd3_PMDIGCOM_TagName_OnDynAnimation(Object sender, EventArgs e)
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
//Event Handler:OnDynInitialize 
public void gd3_PMDIGCOM_Rect9_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 
   
    R_tagname.Visible = true;
    R_tagname.ForegroundColor = Color.Black;
    R_tagname.EdgeColor = Color.Black;
           DrawArea p = (DrawArea)(Area.Parent);
           p.Variable[1] = "0";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void gd3_PMDIGCOM_Rect9_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 
   
           DrawArea pic = (DrawArea)(Area.Parent.Parent);

           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd3_PMDIGCOM_Rect9_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 

           DrawArea p = (DrawArea)(Area.Parent);
           if(p.Variable[1] == "1")
              {
                    R_tagname.ForegroundColor = Color.Blue;
                    R_tagname.EdgeColor = Color.White;
              }
           else
              {
                    R_tagname.ForegroundColor = Color.Black;
                    R_tagname.EdgeColor = Color.Black;
              }
 
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd3_PMANLIN_OnDynInitialize(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 
 
	Picture pic = CommonFunction.GetThisPicture(Area);
	if(pic != null)
	{  
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
				TB.Visible = false;
				TB.Focus();
			}
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
//Event Handler:OnDynClick 
public void gd3_PMANLIN_OnDynClick(Object sender, EventArgs e)
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
public void gd3_PMANLIN_KeyUp(Object sender, KeyEventArgs e)
{
   TextBox TB = (TextBox)sender; 

   DrawArea Area = CommonFunction.GetThisDrawArea(TB);

     double dbValue = 0;
     int nValue = 0;
     bool bValue = false;
     int nDataType = 0;

        double PVEXEH = 0;
        double PVEXEL = 0;
        double PVEUHI = 0;
        double PVEULO = 0;

	string tagName = Area.Variable[0] + "/PVEXEH";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEXEH = dbValue;             
	}

	tagName = Area.Variable[0] + "/PVEXEL";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEXEL = dbValue;             
	}

	tagName = Area.Variable[0] + "/PVEUHI";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEUHI = dbValue;        
	}

	tagName = Area.Variable[0] + "/PVEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEULO = dbValue;             
	}

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
		             string tag=lab.Variable[0];
                             bool PV = tagName.Contains("PV");
                             bool PVTV = tagName.Contains("PVTV");
                             if(PV == true)
                               {

                                    if(dbPVValue <= PVEUHI && dbPVValue >= PVEULO)
                                       {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                       }
                                    else
                                       {
				          CommonFunction._ProjectRelated.Var[1] = "LMT";
                                       }
                               }


                             if(PVTV == true)
                               {
	                 	  if(dbPVValue <= PVEXEH && dbPVValue >= PVEXEL)

				   {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                   }
	                	  else 
                                    {
                                        CommonFunction._ProjectRelated.Var[1] = "LMT";
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
CommonFunction._ProjectRelated.Var[1] = "";

    DrawText P1 = (DrawText)Area.GetDrawObj("PV");
    P1.Variable[0] = "0";
    DrawText V1 = (DrawText)Area.GetDrawObj("PVTV");
    V1.Variable[0] = "0";

    return; 
}



//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd3_PMANLIN_Rect8_OnDynAnimation(Object sender, EventArgs e)	//PVBar
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawRectangle PVBar = (DrawRectangle)dynArgs.sender; 
	
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	double PVValue = 0;
        double PVEUHI = 0;
        double PVEULO = 0;

	string tagName = Area.Variable[0] + "/PVEUHI";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEUHI = dbValue;
             
	}

	tagName = Area.Variable[0] + "/PVEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEULO = dbValue;
             
	}
	
	tagName = Area.Variable[0] + "/PV";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
             PVValue = dbValue;

             if(PVEUHI != PVEULO)
                {
                    double PVScale = PVValue/(PVEUHI - PVEULO);
                    PVBar.Height = (334.00 - 58.00) * PVScale;
                    PVBar.VerticalPosition = 334.00 - PVBar.Height;
                }     
	}
	else
        {
             PVBar.VerticalPosition = 334.00;
             PVBar.Height = 0;
        }

	return; 
}//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd3_PMANLIN_Line16_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawLine PVBlack = (DrawLine)dynArgs.sender; 
   
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	double PVValue = 0;
	
	String tagName = Area.Variable[0] + "/PV";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
             if(dbValue == 0)
                {
                    PVBlack.EdgeColor = Color.Cyan;
                }
             else
                {
                    PVBlack.EdgeColor = Color.Black;
                }
	}
	else
        {
             PVBlack.EdgeColor = Color.Black;
        }

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd3_PMANLIN_LinePVTV_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawLine LinePVTV = (DrawLine)dynArgs.sender; 


	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	double PVValue = 0;
        double PVEXEH = 0;
        double PVEXEL = 0;

	string tagName = Area.Variable[0] + "/PVEXEH";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEXEH = dbValue;
             
	}

	tagName = Area.Variable[0] + "/PVEXEL";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEXEL = dbValue;
             
	}
	
	tagName = Area.Variable[0] + "/PVTV";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
             PVValue = dbValue;
             if(PVEXEH != PVEXEL)
                {
                      double PVScale = PVValue/(PVEXEH - PVEXEL);
                      LinePVTV.VerticalPosition = 334 - (334 - 58) * PVScale;
                }   
	}
	else
             LinePVTV.VerticalPosition = 334;
   
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd3_PMANLIN_TagName_OnDynAnimation(Object sender, EventArgs e)
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
public void gd3_PMANLIN_PV_OnDynAnimation(Object sender, EventArgs e)
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

          if(PV.Variable[0] == "1")

            {
                PV.ForegroundColor = Color.White;
            }

          else

            {
                PV.ForegroundColor = Color.Cyan;
            }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd3_PMANLIN_PV_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PV = (DrawText)dynArgs.sender; 
   
    PV.ForegroundColor = Color.Cyan; 
    PV.Variable[0] = "0";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd3_PMANLIN_PVTV_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVTV = (DrawText)dynArgs.sender;
 
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
	
	tagName = Area.Variable[0] + "/PVTV";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		PVTV.Caption = dbValue.ToString(strDigit);
	}
	else
		PVTV.Caption = "##.#";

          if(PVTV.Variable[0] == "1")

            {
                PVTV.ForegroundColor = Color.White;
            }

          else

            {
                PVTV.ForegroundColor = Color.Cyan;
            }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd3_PMANLIN_PVTV_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVTV = (DrawText)dynArgs.sender; 

    PVTV.ForegroundColor = Color.Cyan; 
    PVTV.Variable[0] = "0";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd3_PMANLIN_Rect9_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 
   
    R_tagname.Visible = true;
    R_tagname.ForegroundColor = Color.Black;
    R_tagname.EdgeColor = Color.Black;
           DrawArea p = (DrawArea)(Area.Parent);
           p.Variable[1] = "0";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void gd3_PMANLIN_Rect9_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 

           DrawArea pic = (DrawArea)(Area.Parent.Parent);

           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd3_PMANLIN_Rect9_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 

           DrawArea p = (DrawArea)(Area.Parent);
           if(p.Variable[1] == "1")
              {
                    R_tagname.ForegroundColor = Color.Blue;
                    R_tagname.EdgeColor = Color.White;
              }
           else
              {
                    R_tagname.ForegroundColor = Color.Black;
                    R_tagname.EdgeColor = Color.Black;

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
 
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd3_PMANLIN_Rect10_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect10 = (DrawRectangle)dynArgs.sender; 
   
    Rect10.Visible = true;
    Rect10.ForegroundColor = Color.Black;
    Rect10.EdgeColor = Color.Black;
           DrawArea p = (DrawArea)(Area.Parent);
           p.Variable[1] = "0";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void gd3_PMANLIN_Rect10_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect10 = (DrawRectangle)dynArgs.sender; 

    DrawText PVTV = (DrawText)Area.GetDrawObj("PVTV");
    PVTV.Variable[0] = "1";
    DrawText PV = (DrawText)Area.GetDrawObj("PV");
    PV.Variable[0] = "0";

    if(PVTV.Visible == true)

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
				CommonFunction.MoveControl(Area,TB,(int)(Rect10.VerticalPosition - 40),(int)(Rect10.HorizontalPosition));		
				obj = CommonFunction.GetLabelOfControl(TB);
				if(obj != null)
				{
					ControlLabel lab = (ControlLabel)obj;
					//给TB传递参数：
					lab.Variable[0] = Area.Variable[0] + "/PVTV";
                                      
				}
			}
		}
	}

    DrawArea pic = (DrawArea)(Area.Parent.Parent); 
           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd3_PMANLIN_Rect10_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect10 = (DrawRectangle)dynArgs.sender; 

    DrawText PVTV = (DrawText)Area.GetDrawObj("PVTV");
    DrawArea p = (DrawArea)(Area.Parent);

			if(PVTV.Variable[0] == "1" && p.Variable[1] == "1")
			{
		 		Rect10.ForegroundColor = Color.Blue;
                                Rect10.EdgeColor = Color.White;                                   
			}
                        else
			{
		 		Rect10.ForegroundColor = Color.Black;
                                Rect10.EdgeColor = Color.Black; 
                                PVTV.Variable[0] = "0";                                  
			}


    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd3_PMANLIN_Rect11_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect11 = (DrawRectangle)dynArgs.sender; 
   
    Rect11.Visible = true;
    Rect11.ForegroundColor = Color.Black;
    Rect11.EdgeColor = Color.Black;
           DrawArea p = (DrawArea)(Area.Parent);
           p.Variable[1] = "0";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void gd3_PMANLIN_Rect11_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect11 = (DrawRectangle)dynArgs.sender; 
   
           DrawArea pic = (DrawArea)(Area.Parent.Parent);

           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

    DrawText PV = (DrawText)Area.GetDrawObj("PV");
    PV.Variable[0] = "1";
    DrawText PVTV = (DrawText)Area.GetDrawObj("PVTV");
    PVTV.Variable[0] = "0";
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
				CommonFunction.MoveControl(Area,TB,(int)(Rect11.VerticalPosition)-40,(int)(Rect11.HorizontalPosition));
			
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
public void gd3_PMANLIN_Rect11_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect11 = (DrawRectangle)dynArgs.sender; 

    DrawText PV = (DrawText)Area.GetDrawObj("PV");
    DrawArea p = (DrawArea)(Area.Parent);

			if(PV.Variable[0] == "1" && p.Variable[1] == "1")
			{
		 		Rect11.ForegroundColor = Color.Blue;
                                Rect11.EdgeColor = Color.White;                                   
			}
                        else
			{
		 		Rect11.ForegroundColor = Color.Black;
                                Rect11.EdgeColor = Color.Black;
                                PV.Variable[0] = "0";                                   
			}

    return; 
}
//Do not remove or update this comment
//Event Delegate:KeyEventHandler 
//Event Handler:KeyUp 
public void gd3_PMANLIN_TB_KeyUp(Object sender, KeyEventArgs e)
{
   TextBox TB = (TextBox)sender; 

   DrawArea Area = CommonFunction.GetThisDrawArea(TB);

     double dbValue = 0;
     int nValue = 0;
     bool bValue = false;
     int nDataType = 0;

        double PVEXEH = 0;
        double PVEXEL = 0;
        double PVEUHI = 0;
        double PVEULO = 0;

	string tagName = Area.Variable[0] + "/PVEXEH";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEXEH = dbValue;             
	}

	tagName = Area.Variable[0] + "/PVEXEL";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEXEL = dbValue;             
	}

	tagName = Area.Variable[0] + "/PVEUHI";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEUHI = dbValue;        
	}

	tagName = Area.Variable[0] + "/PVEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEULO = dbValue;             
	}

	switch ( e.KeyData )
	{
	case Keys.Enter:

		if(TB.Text == "" || TB.Text == null)

		{
			TB.Visible = false;
			TB.Enabled = false;
                        DrawText P = (DrawText)Area.GetDrawObj("PV");
                        P.Variable[0] = "0";
                        DrawText V = (DrawText)Area.GetDrawObj("PVTV");
                        V.Variable[0] = "0";
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
		             string tag=lab.Variable[0];
                             bool PV = tagName.Contains("PV");
                             bool PVTV = tagName.Contains("PVTV");
                             if(PV == true)
                               {

                                    if(dbPVValue <= PVEUHI && dbPVValue >= PVEULO)
                                       {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                       }
                                    else
                                       {
				          CommonFunction._ProjectRelated.Var[1] = "LMT";
                                       }
                               }


                             if(PVTV == true)
                               {
	                 	  if(dbPVValue <= PVEXEH && dbPVValue >= PVEXEL)

				   {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                   }
	                	  else 
                                    {
                                        CommonFunction._ProjectRelated.Var[1] = "LMT";
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
CommonFunction._ProjectRelated.Var[1] = "";
    DrawText P1 = (DrawText)Area.GetDrawObj("PV");
    P1.Variable[0] = "0";
    DrawText V1 = (DrawText)Area.GetDrawObj("PVTV");
    V1.Variable[0] = "0";
    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd3_PMPID_OnDynInitialize(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 
 
	Picture pic = CommonFunction.GetThisPicture(Area);
	if(pic != null)
	{  
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
				TB.Visible = false;
				TB.Focus();
			}
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
//Event Handler:OnDynClick 
public void gd3_PMPID_OnDynClick(Object sender, EventArgs e)
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
public void gd3_PMPID_KeyUp(Object sender, KeyEventArgs e)
{
   TextBox TB = (TextBox)sender; 
   DrawArea Area = CommonFunction.GetThisDrawArea(TB);

     double dbValue = 0;
     int nValue = 0;
     bool bValue = false;
     int nDataType = 0;

        double OPHI = 0;
        double OPLO = 0;
        double SPEUHI = 0;
        double SPEULO = 0;
        double PVEUHI = 0;
        double PVEULO = 0;

	string tagName = Area.Variable[0] + "/OPHI";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     OPHI = dbValue;             
	}

	tagName = Area.Variable[0] + "/OPLO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     OPLO = dbValue;             
	}

	tagName = Area.Variable[0] + "/SPEUHI";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     SPEUHI = dbValue;             
	}

	tagName = Area.Variable[0] + "/SPEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     SPEULO = dbValue;             
	}

	tagName = Area.Variable[0] + "/PVEUHI";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEUHI = dbValue;        
	}

	tagName = Area.Variable[0] + "/PVEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEULO = dbValue;             
	}

     double dbValue1 = 0;
     int nValue1 = 0;
     bool bValue1 = false;
     int nDataType1 = 0;
     string MODE = Area.Variable[0] + "/MODE";
     bool ret1 = CommonFunction.GetValueWithType(MODE,ref dbValue1,ref nValue1,ref bValue1,ref nDataType1);

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
		             string tag=lab.Variable[0];

                             //PV值只有在MODE是MAN的时候才可以改变
                             bool V = tag.Contains("PV");
                             bool O = tag.Contains("OP");
                             bool S = tag.Contains("SP");
                             if(V == true && ret1)
                               {
                                    if(dbPVValue<=PVEUHI && dbPVValue>=PVEULO)
                                       {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                       }
                                    else
                                       {
				          CommonFunction._ProjectRelated.Var[1] = "LMT";
                                       }
                               }

                             if(O == true && ret1)
                               {//OP值只有在MODE是MAN的时候才可以改变
	                 	  if(dbValue1==1)
                                   {
                                    if(dbPVValue<=OPHI && dbPVValue>=OPLO)
                                       {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                       }
                                    else
                                      {
				          CommonFunction._ProjectRelated.Var[1] = "LMT";
                                       }
                                    }
	                	  else 
                                    {
                                        CommonFunction._ProjectRelated.Var[1] = "MODE ERROR";

                                    }
                               }

                             if(S == true && ret1)
                               {//SP值只有在MODE是AUTO的时候才可以改变
                                if(dbValue1==2)
                                 {
	                 	  if(dbPVValue<=SPEUHI && dbPVValue>=SPEULO)

				   {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                   }
	                	  else 
                                    {
                                        CommonFunction._ProjectRelated.Var[1] = "LMT";
                                    }
                                  }
	                	  else 
                                    {
                                        CommonFunction._ProjectRelated.Var[1] = "MODE ERROR";

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

CommonFunction._ProjectRelated.Var[1] = "";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd3_PMPID_ALM_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText ALM = (DrawText)dynArgs.sender; 
   
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
	
	tagName = Area.Variable[0] + "/PVHLFL";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
              string alm = dbValue.ToString(strDigit);

		if(alm == "0.00")

                   {ALM.Caption = "";}

		if(alm == "1.00")

                   {ALM.Caption = "HP";}

		if(alm == "2.00")

                   {ALM.Caption = "2HP";}

		if(alm == "-1.00")

                   {ALM.Caption = "LP";}

		if(alm == "-2.00")

                   {ALM.Caption = "2LP";}
	}
	else
		ALM.Caption = "";
        	

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd3_PMPID_OPBar_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawLine OPBar = (DrawLine)dynArgs.sender; 
   
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	double OPValue = 0;
        double OPHI = 0;
        double OPLO = 0;

	string tagName = Area.Variable[0] + "/OPHI";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     OPHI = dbValue;
             
	}

	tagName = Area.Variable[0] + "/OPLO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     OPLO = dbValue;
             
	}
	
	tagName = Area.Variable[0] + "/OP";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
             OPValue = dbValue;
             double OPScale = OPValue/(OPHI - OPLO);
             OPBar.EndY = 334 - (334 - 58) * OPScale;    
	}
	else
             OPBar.EndY = 334;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd3_PMPID_PVBlack_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawLine PVBlack = (DrawLine)dynArgs.sender; 
   
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	double PVValue = 0;
	
	String tagName = Area.Variable[0] + "/PV";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
             if(dbValue == 0)
                {
                    PVBlack.EdgeColor = Color.Cyan;
                }
             else
                {
                    PVBlack.EdgeColor = Color.Black;
                }
	}
	else
        {
             PVBlack.EdgeColor = Color.Black;
        }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd3_PMPID_SPLine_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawLine SPLine = (DrawLine)dynArgs.sender; 

	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	double SPValue = 0;
        double SPEUHI = 0;
        double SPEULO = 0;

	string tagName = Area.Variable[0] + "/SPEUHI";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     SPEUHI = dbValue;
             
	}

	tagName = Area.Variable[0] + "/SPEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     SPEULO = dbValue;
             
	}
	
	tagName = Area.Variable[0] + "/SP";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
             SPValue = dbValue;
             double SPScale = SPValue/(SPEUHI - SPEULO);
             SPLine.VerticalPosition = 334 - (334 - 58) * SPScale;    
	}
	else
             SPLine.VerticalPosition = 334;
   
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd3_PMPID_PVBar_OnDynAnimation(Object sender, EventArgs e)	//PVBar
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawRectangle PVBar = (DrawRectangle)dynArgs.sender; 
	
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	double PVValue = 0;
        double PVEUHI = 0;
        double PVEULO = 0;

	string tagName = Area.Variable[0] + "/PVEUHI";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEUHI = dbValue;
             
	}

	tagName = Area.Variable[0] + "/PVEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEULO = dbValue;
             
	}
	
	tagName = Area.Variable[0] + "/PV";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
             PVValue = dbValue;
             double PVScale = PVValue/(PVEUHI - PVEULO);
             PVBar.Height = (334.00 - 58.00) * PVScale;
             PVBar.VerticalPosition = 334.00 - PVBar.Height;    
	}
	else
        {
             PVBar.VerticalPosition = 334.00;
             PVBar.Height = 0;
        }

	return; 
}//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd3_PMPID_MODE_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText MODE = (DrawText)dynArgs.sender; 

    DrawRectangle Rect = (DrawRectangle)Area.GetDrawObj("Rect_MODE");  
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	int nDigit = 2;
	string tagName = Area.Variable[0] + "/MODE";

	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
            {
                if(dbValue == 1)
                  {
                      MODE.Caption = "MAN";
                      MODE.ForegroundColor = Color.Black;
                      Rect.ForegroundColor = Color.Yellow;
                  }
                if(dbValue == 2)
                  {
                      MODE.Caption = "AUTO";
                      MODE.ForegroundColor = Color.Cyan;
                      Rect.ForegroundColor = Color.Black;
                  }
                if(dbValue == 3)
                  {
                      MODE.Caption = "CAS";
                      MODE.ForegroundColor = Color.Black;
                      Rect.ForegroundColor = Color.Cyan;
                  }
            }
       else
            {MODE.Caption = "###";}

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void gd3_PMPID_Rect_MODE_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect_MODE = (DrawRectangle)dynArgs.sender; 

           DrawArea pic = (DrawArea)(Area.Parent.Parent);

           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

           DrawArea p = (DrawArea)(Area.Parent.Parent);
           DrawArea G = (DrawArea)p.GetDrawObj("TDC3000_Groupfaceplate");
           G.Visible = true;
           G.Variable[0] = Area.Variable[0];

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd3_PMPID_Unit_OnDynAnimation(Object sender, EventArgs e)
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
public void gd3_PMPID_TagName_OnDynAnimation(Object sender, EventArgs e)
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
public void gd3_PMPID_PV_OnDynAnimation(Object sender, EventArgs e)
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


          if(PV.Variable[0] == "1")

            {
                PV.ForegroundColor = Color.White;
            }

          else

            {
                PV.ForegroundColor = Color.Cyan;
            }

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd3_PMPID_PV_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PV = (DrawText)dynArgs.sender; 
   
    PV.ForegroundColor = Color.Cyan;
    PV.Variable[0] = "0";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd3_PMPID_SP_OnDynAnimation(Object sender, EventArgs e)
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

          if(SP.Variable[0] == "1")

            {
                SP.ForegroundColor = Color.White;
            }

          else

            {
                SP.ForegroundColor = Color.Cyan;
            }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd3_PMPID_SP_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText SP = (DrawText)dynArgs.sender; 

    SP.ForegroundColor = Color.Cyan; 
    SP.Variable[0] = "0";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd3_PMPID_OP_OnDynAnimation(Object sender, EventArgs e)
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

          if(OP.Variable[0] == "1")

            {
                OP.ForegroundColor = Color.White;
            }

          else

            {
                OP.ForegroundColor = Color.Yellow;
            }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd3_PMPID_OP_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText OP = (DrawText)dynArgs.sender; 
 
    OP.ForegroundColor = Color.Yellow; 
    OP.Variable[0] = "0";

    return; 
}


//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd3_PMPID_R_tagname_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 
   
    R_tagname.Visible = true;
    R_tagname.ForegroundColor = Color.Black;
    R_tagname.EdgeColor = Color.Black;
           DrawArea p = (DrawArea)(Area.Parent);
           p.Variable[1] = "0";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void gd3_PMPID_R_tagname_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 
   
           DrawArea pic = (DrawArea)(Area.Parent.Parent);

           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd3_PMPID_R_tagname_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 

           DrawArea p = (DrawArea)(Area.Parent);
           if(p.Variable[1] == "1")
              {
                    R_tagname.ForegroundColor = Color.Blue;
                    R_tagname.EdgeColor = Color.White;
              }
           else
              {
                    R_tagname.ForegroundColor = Color.Black;
                    R_tagname.EdgeColor = Color.Black;

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
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd3_PMPID_Rect7_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect7 = (DrawRectangle)dynArgs.sender; 
   
    Rect7.Visible = true;
    Rect7.ForegroundColor = Color.Black;
    Rect7.EdgeColor = Color.Black;
           DrawArea p = (DrawArea)(Area.Parent);
           p.Variable[1] = "0";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void gd3_PMPID_Rect7_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect7 = (DrawRectangle)dynArgs.sender; 
   
           DrawArea pic = (DrawArea)(Area.Parent.Parent);

           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

    DrawText SP = (DrawText)Area.GetDrawObj("SP");
    SP.Variable[0] = "1";
    DrawText PV = (DrawText)Area.GetDrawObj("PV");
    PV.Variable[0] = "0";
    DrawText OP = (DrawText)Area.GetDrawObj("OP");
    OP.Variable[0] = "0";

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
				CommonFunction.MoveControl(Area,TB,(int)(Rect7.VerticalPosition - 40),(int)(Rect7.HorizontalPosition));		
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
public void gd3_PMPID_Rect7_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect7 = (DrawRectangle)dynArgs.sender; 

    DrawText SP = (DrawText)Area.GetDrawObj("SP");
    DrawArea p = (DrawArea)(Area.Parent);

			if(SP.Variable[0] == "1" && p.Variable[1] == "1")
			{
		 		Rect7.ForegroundColor = Color.Blue;
                                Rect7.EdgeColor = Color.White;                                   
			}
                        else
			{
		 		Rect7.ForegroundColor = Color.Black;
                                Rect7.EdgeColor = Color.Black; 
                                SP.Variable[0] = "0";                                  
			}
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd3_PMPID_Rect8_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect8 = (DrawRectangle)dynArgs.sender; 
   
    Rect8.Visible = true;
    Rect8.ForegroundColor = Color.Black;
    Rect8.EdgeColor = Color.Black;
           DrawArea p = (DrawArea)(Area.Parent);
           p.Variable[1] = "0";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void gd3_PMPID_Rect8_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect8 = (DrawRectangle)dynArgs.sender; 
   
           DrawArea pic = (DrawArea)(Area.Parent.Parent);

           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

    DrawText SP = (DrawText)Area.GetDrawObj("SP");
    SP.Variable[0] = "0";
    DrawText PV = (DrawText)Area.GetDrawObj("PV");
    PV.Variable[0] = "1";
    DrawText OP = (DrawText)Area.GetDrawObj("OP");
    OP.Variable[0] = "0";

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
				CommonFunction.MoveControl(Area,TB,(int)(Rect8.VerticalPosition)-40,(int)(Rect8.HorizontalPosition));
			
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
public void gd3_PMPID_Rect8_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect8 = (DrawRectangle)dynArgs.sender; 

    DrawText PV = (DrawText)Area.GetDrawObj("PV");
    DrawArea p = (DrawArea)(Area.Parent);

			if(PV.Variable[0] == "1" && p.Variable[1] == "1")
			{
		 		Rect8.ForegroundColor = Color.Blue;
                                Rect8.EdgeColor = Color.White;                                   
			}
                        else
			{
		 		Rect8.ForegroundColor = Color.Black;
                                Rect8.EdgeColor = Color.Black;  
                                PV.Variable[0] = "0";                                 
			}

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd3_PMPID_Rect9_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect9 = (DrawRectangle)dynArgs.sender; 
   
    Rect9.Visible = true;
    Rect9.ForegroundColor = Color.Black;
    Rect9.EdgeColor = Color.Black;
           DrawArea p = (DrawArea)(Area.Parent);
           p.Variable[1] = "0";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void gd3_PMPID_Rect9_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect9 = (DrawRectangle)dynArgs.sender; 
   
           DrawArea pic = (DrawArea)(Area.Parent.Parent);

           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

    DrawText SP = (DrawText)Area.GetDrawObj("SP");
    SP.Variable[0] = "0";
    DrawText PV = (DrawText)Area.GetDrawObj("PV");
    PV.Variable[0] = "0";
    DrawText OP = (DrawText)Area.GetDrawObj("OP");
    OP.Variable[0] = "1";

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
			        CommonFunction.MoveControl(Area,TB,(int)(Rect9.VerticalPosition)-40,(int)(Rect9.HorizontalPosition));
				
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
public void gd3_PMPID_Rect9_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect9 = (DrawRectangle)dynArgs.sender; 

    DrawText OP = (DrawText)Area.GetDrawObj("OP");
    DrawArea p = (DrawArea)(Area.Parent);

			if(OP.Variable[0] == "1" && p.Variable[1] == "1")
			{
		 		Rect9.ForegroundColor = Color.Blue;
                                Rect9.EdgeColor = Color.White;                                   
			}
                        else
			{
		 		Rect9.ForegroundColor = Color.Black;
                                Rect9.EdgeColor = Color.Black; 
                                OP.Variable[0] = "0";                                  
			}

    return; 
}
//Do not remove or update this comment
//Event Delegate:KeyEventHandler 
//Event Handler:KeyUp 
public void gd3_PMPID_TB_KeyUp(Object sender, KeyEventArgs e)
{
   TextBox TB = (TextBox)sender; 

   DrawArea Area = CommonFunction.GetThisDrawArea(TB);

     double dbValue = 0;
     int nValue = 0;
     bool bValue = false;
     int nDataType = 0;

        double OPHI = 0;
        double OPLO = 0;
        double SPEUHI = 0;
        double SPEULO = 0;
        double PVEUHI = 0;
        double PVEULO = 0;

	string tagName = Area.Variable[0] + "/OPHI";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     OPHI = dbValue;             
	}

	tagName = Area.Variable[0] + "/OPLO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     OPLO = dbValue;             
	}

	tagName = Area.Variable[0] + "/SPEUHI";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     SPEUHI = dbValue;             
	}

	tagName = Area.Variable[0] + "/SPEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     SPEULO = dbValue;             
	}

	tagName = Area.Variable[0] + "/PVEUHI";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEUHI = dbValue;        
	}

	tagName = Area.Variable[0] + "/PVEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEULO = dbValue;             
	}

     double dbValue1 = 0;
     int nValue1 = 0;
     bool bValue1 = false;
     int nDataType1 = 0;
     string MODE = Area.Variable[0] + "/MODE";
     bool ret1 = CommonFunction.GetValueWithType(MODE,ref dbValue1,ref nValue1,ref bValue1,ref nDataType1);

	switch ( e.KeyData )
	{
	case Keys.Enter:

		if(TB.Text == "" || TB.Text == null)

		{
			TB.Visible = false;
			TB.Enabled = false;
                        DrawText P = (DrawText)Area.GetDrawObj("PV");
                        P.Variable[0] = "0";
                        DrawText OP = (DrawText)Area.GetDrawObj("OP");
                        OP.Variable[0] = "0";
                        DrawText SP = (DrawText)Area.GetDrawObj("SP");
                        SP.Variable[0] = "0";
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
		             string tag=lab.Variable[0];

                             //PV值只有在MODE是MAN的时候才可以改变
                             bool V = tag.Contains("PV");
                             bool O = tag.Contains("OP");
                             bool S = tag.Contains("SP");
                             if(V == true && ret1)
                               {
                                    if(dbPVValue<=PVEUHI && dbPVValue>=PVEULO)
                                       {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                       }
                                    else
                                       {
				          CommonFunction._ProjectRelated.Var[1] = "LMT";
                                       }
                               }

                             if(O == true && ret1)
                               {//OP值只有在MODE是MAN的时候才可以改变
	                 	  if(dbValue1==1)
                                   {
                                    if(dbPVValue<=OPHI && dbPVValue>=OPLO)
                                       {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                       }
                                    else
                                      {
				          CommonFunction._ProjectRelated.Var[1] = "LMT";
                                       }
                                    }
	                	  else 
                                    {
                                        CommonFunction._ProjectRelated.Var[1] = "MODE ERROR";

                                    }
                               }

                             if(S == true && ret1)
                               {//SP值只有在MODE是AUTO的时候才可以改变
                                if(dbValue1==2)
                                 {
	                 	  if(dbPVValue<=SPEUHI && dbPVValue>=SPEULO)

				   {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                   }
	                	  else 
                                    {
                                        CommonFunction._ProjectRelated.Var[1] = "LMT";
                                    }
                                  }
	                	  else 
                                    {
                                        CommonFunction._ProjectRelated.Var[1] = "MODE ERROR";

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
CommonFunction._ProjectRelated.Var[1] = "";
    DrawText P1 = (DrawText)Area.GetDrawObj("PV");
    P1.Variable[0] = "0";
    DrawText OP1 = (DrawText)Area.GetDrawObj("OP");
    OP1.Variable[0] = "0";
    DrawText SP1 = (DrawText)Area.GetDrawObj("SP");
    SP1.Variable[0] = "0";
    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd1_OnDynInitialize(Object sender, EventArgs e)
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
public void gd1_OnDynAnimation(Object sender, EventArgs e)
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

             else 

                {
                     PMDIGCOM.Visible = false;
                     PMPID.Visible = false;
                     PMANLIN.Visible = false;
                }

        }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd1_PMDIGCOM_OnDynInitialize(Object sender, EventArgs e)
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
public void gd1_PMDIGCOM_Rect_PVON_OnDynAnimation(Object sender, EventArgs e)
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
public void gd1_PMDIGCOM_OP_OnDynAnimation(Object sender, EventArgs e)
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
public void gd1_PMDIGCOM_Rect_OFF_OnDynAnimation(Object sender, EventArgs e)
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
public void gd1_PMDIGCOM_Rect_ON_OnDynAnimation(Object sender, EventArgs e)
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
public void gd1_PMDIGCOM_Unit_OnDynAnimation(Object sender, EventArgs e)
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
public void gd1_PMDIGCOM_TagName_OnDynAnimation(Object sender, EventArgs e)
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
//Event Handler:OnDynInitialize 
public void gd1_PMDIGCOM_Rect9_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 
   
    R_tagname.Visible = true;
    R_tagname.ForegroundColor = Color.Black;
    R_tagname.EdgeColor = Color.Black;
           DrawArea p = (DrawArea)(Area.Parent);
           p.Variable[1] = "0";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void gd1_PMDIGCOM_Rect9_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 
   
           DrawArea pic = (DrawArea)(Area.Parent.Parent);

           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd1_PMDIGCOM_Rect9_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 

           DrawArea p = (DrawArea)(Area.Parent);
           if(p.Variable[1] == "1")
              {
                    R_tagname.ForegroundColor = Color.Blue;
                    R_tagname.EdgeColor = Color.White;
              }
           else
              {
                    R_tagname.ForegroundColor = Color.Black;
                    R_tagname.EdgeColor = Color.Black;
              }
 
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd1_PMANLIN_OnDynInitialize(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 
 
	Picture pic = CommonFunction.GetThisPicture(Area);
	if(pic != null)
	{  
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
				TB.Visible = false;
				TB.Focus();
			}
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
//Event Handler:OnDynClick 
public void gd1_PMANLIN_OnDynClick(Object sender, EventArgs e)
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
public void gd1_PMANLIN_KeyUp(Object sender, KeyEventArgs e)
{
   TextBox TB = (TextBox)sender; 

   DrawArea Area = CommonFunction.GetThisDrawArea(TB);

     double dbValue = 0;
     int nValue = 0;
     bool bValue = false;
     int nDataType = 0;

        double PVEXEH = 0;
        double PVEXEL = 0;
        double PVEUHI = 0;
        double PVEULO = 0;

	string tagName = Area.Variable[0] + "/PVEXEH";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEXEH = dbValue;             
	}

	tagName = Area.Variable[0] + "/PVEXEL";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEXEL = dbValue;             
	}

	tagName = Area.Variable[0] + "/PVEUHI";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEUHI = dbValue;        
	}

	tagName = Area.Variable[0] + "/PVEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEULO = dbValue;             
	}

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
		             string tag=lab.Variable[0];
                             bool PV = tagName.Contains("PV");
                             bool PVTV = tagName.Contains("PVTV");
                             if(PV == true)
                               {

                                    if(dbPVValue <= PVEUHI && dbPVValue >= PVEULO)
                                       {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                       }
                                    else
                                       {
				          CommonFunction._ProjectRelated.Var[1] = "LMT";
                                       }
                               }


                             if(PVTV == true)
                               {
	                 	  if(dbPVValue <= PVEXEH && dbPVValue >= PVEXEL)

				   {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                   }
	                	  else 
                                    {
                                        CommonFunction._ProjectRelated.Var[1] = "LMT";
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
CommonFunction._ProjectRelated.Var[1] = "";

    DrawText P1 = (DrawText)Area.GetDrawObj("PV");
    P1.Variable[0] = "0";
    DrawText V1 = (DrawText)Area.GetDrawObj("PVTV");
    V1.Variable[0] = "0";

    return; 
}



//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd1_PMANLIN_Rect8_OnDynAnimation(Object sender, EventArgs e)	//PVBar
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawRectangle PVBar = (DrawRectangle)dynArgs.sender; 
	
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	double PVValue = 0;
        double PVEUHI = 0;
        double PVEULO = 0;

	string tagName = Area.Variable[0] + "/PVEUHI";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEUHI = dbValue;
             
	}

	tagName = Area.Variable[0] + "/PVEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEULO = dbValue;
             
	}
	
	tagName = Area.Variable[0] + "/PV";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
             PVValue = dbValue;

             if(PVEUHI != PVEULO)
                {
                    double PVScale = PVValue/(PVEUHI - PVEULO);
                    PVBar.Height = (334.00 - 58.00) * PVScale;
                    PVBar.VerticalPosition = 334.00 - PVBar.Height;
                }     
	}
	else
        {
             PVBar.VerticalPosition = 334.00;
             PVBar.Height = 0;
        }

	return; 
}//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd1_PMANLIN_Line16_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawLine PVBlack = (DrawLine)dynArgs.sender; 
   
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	double PVValue = 0;
	
	String tagName = Area.Variable[0] + "/PV";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
             if(dbValue == 0)
                {
                    PVBlack.EdgeColor = Color.Cyan;
                }
             else
                {
                    PVBlack.EdgeColor = Color.Black;
                }
	}
	else
        {
             PVBlack.EdgeColor = Color.Black;
        }

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd1_PMANLIN_LinePVTV_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawLine LinePVTV = (DrawLine)dynArgs.sender; 


	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	double PVValue = 0;
        double PVEXEH = 0;
        double PVEXEL = 0;

	string tagName = Area.Variable[0] + "/PVEXEH";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEXEH = dbValue;
             
	}

	tagName = Area.Variable[0] + "/PVEXEL";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEXEL = dbValue;
             
	}
	
	tagName = Area.Variable[0] + "/PVTV";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
             PVValue = dbValue;
             if(PVEXEH != PVEXEL)
                {
                      double PVScale = PVValue/(PVEXEH - PVEXEL);
                      LinePVTV.VerticalPosition = 334 - (334 - 58) * PVScale;
                }   
	}
	else
             LinePVTV.VerticalPosition = 334;
   
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd1_PMANLIN_TagName_OnDynAnimation(Object sender, EventArgs e)
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
public void gd1_PMANLIN_PV_OnDynAnimation(Object sender, EventArgs e)
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

          if(PV.Variable[0] == "1")

            {
                PV.ForegroundColor = Color.White;
            }

          else

            {
                PV.ForegroundColor = Color.Cyan;
            }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd1_PMANLIN_PV_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PV = (DrawText)dynArgs.sender; 
   
    PV.ForegroundColor = Color.Cyan; 
    PV.Variable[0] = "0";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd1_PMANLIN_PVTV_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVTV = (DrawText)dynArgs.sender;
 
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
	
	tagName = Area.Variable[0] + "/PVTV";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		PVTV.Caption = dbValue.ToString(strDigit);
	}
	else
		PVTV.Caption = "##.#";

          if(PVTV.Variable[0] == "1")

            {
                PVTV.ForegroundColor = Color.White;
            }

          else

            {
                PVTV.ForegroundColor = Color.Cyan;
            }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd1_PMANLIN_PVTV_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVTV = (DrawText)dynArgs.sender; 

    PVTV.ForegroundColor = Color.Cyan; 
    PVTV.Variable[0] = "0";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd1_PMANLIN_Rect9_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 
   
    R_tagname.Visible = true;
    R_tagname.ForegroundColor = Color.Black;
    R_tagname.EdgeColor = Color.Black;
           DrawArea p = (DrawArea)(Area.Parent);
           p.Variable[1] = "0";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void gd1_PMANLIN_Rect9_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 

           DrawArea pic = (DrawArea)(Area.Parent.Parent);

           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd1_PMANLIN_Rect9_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 

           DrawArea p = (DrawArea)(Area.Parent);
           if(p.Variable[1] == "1")
              {
                    R_tagname.ForegroundColor = Color.Blue;
                    R_tagname.EdgeColor = Color.White;
              }
           else
              {
                    R_tagname.ForegroundColor = Color.Black;
                    R_tagname.EdgeColor = Color.Black;

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
 
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd1_PMANLIN_Rect10_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect10 = (DrawRectangle)dynArgs.sender; 
   
    Rect10.Visible = true;
    Rect10.ForegroundColor = Color.Black;
    Rect10.EdgeColor = Color.Black;
           DrawArea p = (DrawArea)(Area.Parent);
           p.Variable[1] = "0";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void gd1_PMANLIN_Rect10_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect10 = (DrawRectangle)dynArgs.sender; 

    DrawText PVTV = (DrawText)Area.GetDrawObj("PVTV");
    PVTV.Variable[0] = "1";
    DrawText PV = (DrawText)Area.GetDrawObj("PV");
    PV.Variable[0] = "0";

    if(PVTV.Visible == true)

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
				CommonFunction.MoveControl(Area,TB,(int)(Rect10.VerticalPosition - 40),(int)(Rect10.HorizontalPosition));		
				obj = CommonFunction.GetLabelOfControl(TB);
				if(obj != null)
				{
					ControlLabel lab = (ControlLabel)obj;
					//给TB传递参数：
					lab.Variable[0] = Area.Variable[0] + "/PVTV";
                                      
				}
			}
		}
	}

    DrawArea pic = (DrawArea)(Area.Parent.Parent); 
           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd1_PMANLIN_Rect10_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect10 = (DrawRectangle)dynArgs.sender; 

    DrawText PVTV = (DrawText)Area.GetDrawObj("PVTV");
    DrawArea p = (DrawArea)(Area.Parent);

			if(PVTV.Variable[0] == "1" && p.Variable[1] == "1")
			{
		 		Rect10.ForegroundColor = Color.Blue;
                                Rect10.EdgeColor = Color.White;                                   
			}
                        else
			{
		 		Rect10.ForegroundColor = Color.Black;
                                Rect10.EdgeColor = Color.Black; 
                                PVTV.Variable[0] = "0";                                  
			}


    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd1_PMANLIN_Rect11_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect11 = (DrawRectangle)dynArgs.sender; 
   
    Rect11.Visible = true;
    Rect11.ForegroundColor = Color.Black;
    Rect11.EdgeColor = Color.Black;
           DrawArea p = (DrawArea)(Area.Parent);
           p.Variable[1] = "0";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void gd1_PMANLIN_Rect11_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect11 = (DrawRectangle)dynArgs.sender; 
   
           DrawArea pic = (DrawArea)(Area.Parent.Parent);

           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

    DrawText PV = (DrawText)Area.GetDrawObj("PV");
    PV.Variable[0] = "1";
    DrawText PVTV = (DrawText)Area.GetDrawObj("PVTV");
    PVTV.Variable[0] = "0";
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
				CommonFunction.MoveControl(Area,TB,(int)(Rect11.VerticalPosition)-40,(int)(Rect11.HorizontalPosition));
			
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
public void gd1_PMANLIN_Rect11_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect11 = (DrawRectangle)dynArgs.sender; 

    DrawText PV = (DrawText)Area.GetDrawObj("PV");
    DrawArea p = (DrawArea)(Area.Parent);

			if(PV.Variable[0] == "1" && p.Variable[1] == "1")
			{
		 		Rect11.ForegroundColor = Color.Blue;
                                Rect11.EdgeColor = Color.White;                                   
			}
                        else
			{
		 		Rect11.ForegroundColor = Color.Black;
                                Rect11.EdgeColor = Color.Black;
                                PV.Variable[0] = "0";                                   
			}

    return; 
}
//Do not remove or update this comment
//Event Delegate:KeyEventHandler 
//Event Handler:KeyUp 
public void gd1_PMANLIN_TB_KeyUp(Object sender, KeyEventArgs e)
{
   TextBox TB = (TextBox)sender; 

   DrawArea Area = CommonFunction.GetThisDrawArea(TB);

     double dbValue = 0;
     int nValue = 0;
     bool bValue = false;
     int nDataType = 0;

        double PVEXEH = 0;
        double PVEXEL = 0;
        double PVEUHI = 0;
        double PVEULO = 0;

	string tagName = Area.Variable[0] + "/PVEXEH";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEXEH = dbValue;             
	}

	tagName = Area.Variable[0] + "/PVEXEL";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEXEL = dbValue;             
	}

	tagName = Area.Variable[0] + "/PVEUHI";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEUHI = dbValue;        
	}

	tagName = Area.Variable[0] + "/PVEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEULO = dbValue;             
	}

	switch ( e.KeyData )
	{
	case Keys.Enter:

		if(TB.Text == "" || TB.Text == null)

		{
			TB.Visible = false;
			TB.Enabled = false;
                        DrawText P = (DrawText)Area.GetDrawObj("PV");
                        P.Variable[0] = "0";
                        DrawText V = (DrawText)Area.GetDrawObj("PVTV");
                        V.Variable[0] = "0";
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
		             string tag=lab.Variable[0];
                             bool PV = tagName.Contains("PV");
                             bool PVTV = tagName.Contains("PVTV");
                             if(PV == true)
                               {

                                    if(dbPVValue <= PVEUHI && dbPVValue >= PVEULO)
                                       {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                       }
                                    else
                                       {
				          CommonFunction._ProjectRelated.Var[1] = "LMT";
                                       }
                               }


                             if(PVTV == true)
                               {
	                 	  if(dbPVValue <= PVEXEH && dbPVValue >= PVEXEL)

				   {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                   }
	                	  else 
                                    {
                                        CommonFunction._ProjectRelated.Var[1] = "LMT";
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
CommonFunction._ProjectRelated.Var[1] = "";
    DrawText P1 = (DrawText)Area.GetDrawObj("PV");
    P1.Variable[0] = "0";
    DrawText V1 = (DrawText)Area.GetDrawObj("PVTV");
    V1.Variable[0] = "0";
    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd1_PMPID_OnDynInitialize(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 
 
	Picture pic = CommonFunction.GetThisPicture(Area);
	if(pic != null)
	{  
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
				TB.Visible = false;
				TB.Focus();
			}
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
//Event Handler:OnDynClick 
public void gd1_PMPID_OnDynClick(Object sender, EventArgs e)
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
public void gd1_PMPID_KeyUp(Object sender, KeyEventArgs e)
{
   TextBox TB = (TextBox)sender; 
   DrawArea Area = CommonFunction.GetThisDrawArea(TB);

     double dbValue = 0;
     int nValue = 0;
     bool bValue = false;
     int nDataType = 0;

        double OPHI = 0;
        double OPLO = 0;
        double SPEUHI = 0;
        double SPEULO = 0;
        double PVEUHI = 0;
        double PVEULO = 0;

	string tagName = Area.Variable[0] + "/OPHI";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     OPHI = dbValue;             
	}

	tagName = Area.Variable[0] + "/OPLO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     OPLO = dbValue;             
	}

	tagName = Area.Variable[0] + "/SPEUHI";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     SPEUHI = dbValue;             
	}

	tagName = Area.Variable[0] + "/SPEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     SPEULO = dbValue;             
	}

	tagName = Area.Variable[0] + "/PVEUHI";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEUHI = dbValue;        
	}

	tagName = Area.Variable[0] + "/PVEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEULO = dbValue;             
	}

     double dbValue1 = 0;
     int nValue1 = 0;
     bool bValue1 = false;
     int nDataType1 = 0;
     string MODE = Area.Variable[0] + "/MODE";
     bool ret1 = CommonFunction.GetValueWithType(MODE,ref dbValue1,ref nValue1,ref bValue1,ref nDataType1);

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
		             string tag=lab.Variable[0];

                             //PV值只有在MODE是MAN的时候才可以改变
                             bool V = tag.Contains("PV");
                             bool O = tag.Contains("OP");
                             bool S = tag.Contains("SP");
                             if(V == true && ret1)
                               {
                                    if(dbPVValue<=PVEUHI && dbPVValue>=PVEULO)
                                       {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                       }
                                    else
                                       {
				          CommonFunction._ProjectRelated.Var[1] = "LMT";
                                       }
                               }

                             if(O == true && ret1)
                               {//OP值只有在MODE是MAN的时候才可以改变
	                 	  if(dbValue1==1)
                                   {
                                    if(dbPVValue<=OPHI && dbPVValue>=OPLO)
                                       {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                       }
                                    else
                                      {
				          CommonFunction._ProjectRelated.Var[1] = "LMT";
                                       }
                                    }
	                	  else 
                                    {
                                        CommonFunction._ProjectRelated.Var[1] = "MODE ERROR";

                                    }
                               }

                             if(S == true && ret1)
                               {//SP值只有在MODE是AUTO的时候才可以改变
                                if(dbValue1==2)
                                 {
	                 	  if(dbPVValue<=SPEUHI && dbPVValue>=SPEULO)

				   {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                   }
	                	  else 
                                    {
                                        CommonFunction._ProjectRelated.Var[1] = "LMT";
                                    }
                                  }
	                	  else 
                                    {
                                        CommonFunction._ProjectRelated.Var[1] = "MODE ERROR";

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

CommonFunction._ProjectRelated.Var[1] = "";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd1_PMPID_ALM_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText ALM = (DrawText)dynArgs.sender; 
   
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
	
	tagName = Area.Variable[0] + "/PVHLFL";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
              string alm = dbValue.ToString(strDigit);

		if(alm == "0.00")

                   {ALM.Caption = "";}

		if(alm == "1.00")

                   {ALM.Caption = "HP";}

		if(alm == "2.00")

                   {ALM.Caption = "2HP";}

		if(alm == "-1.00")

                   {ALM.Caption = "LP";}

		if(alm == "-2.00")

                   {ALM.Caption = "2LP";}
	}
	else
		ALM.Caption = "";
        	

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd1_PMPID_OPBar_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawLine OPBar = (DrawLine)dynArgs.sender; 
   
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	double OPValue = 0;
        double OPHI = 0;
        double OPLO = 0;

	string tagName = Area.Variable[0] + "/OPHI";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     OPHI = dbValue;
             
	}

	tagName = Area.Variable[0] + "/OPLO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     OPLO = dbValue;
             
	}
	
	tagName = Area.Variable[0] + "/OP";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
             OPValue = dbValue;
             double OPScale = OPValue/(OPHI - OPLO);
             OPBar.EndY = 334 - (334 - 58) * OPScale;    
	}
	else
             OPBar.EndY = 334;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd1_PMPID_PVBlack_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawLine PVBlack = (DrawLine)dynArgs.sender; 
   
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	double PVValue = 0;
	
	String tagName = Area.Variable[0] + "/PV";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
             if(dbValue == 0)
                {
                    PVBlack.EdgeColor = Color.Cyan;
                }
             else
                {
                    PVBlack.EdgeColor = Color.Black;
                }
	}
	else
        {
             PVBlack.EdgeColor = Color.Black;
        }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd1_PMPID_SPLine_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawLine SPLine = (DrawLine)dynArgs.sender; 

	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	double SPValue = 0;
        double SPEUHI = 0;
        double SPEULO = 0;

	string tagName = Area.Variable[0] + "/SPEUHI";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     SPEUHI = dbValue;
             
	}

	tagName = Area.Variable[0] + "/SPEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     SPEULO = dbValue;
             
	}
	
	tagName = Area.Variable[0] + "/SP";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
             SPValue = dbValue;
             double SPScale = SPValue/(SPEUHI - SPEULO);
             SPLine.VerticalPosition = 334 - (334 - 58) * SPScale;    
	}
	else
             SPLine.VerticalPosition = 334;
   
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd1_PMPID_PVBar_OnDynAnimation(Object sender, EventArgs e)	//PVBar
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawRectangle PVBar = (DrawRectangle)dynArgs.sender; 
	
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	double PVValue = 0;
        double PVEUHI = 0;
        double PVEULO = 0;

	string tagName = Area.Variable[0] + "/PVEUHI";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEUHI = dbValue;
             
	}

	tagName = Area.Variable[0] + "/PVEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEULO = dbValue;
             
	}
	
	tagName = Area.Variable[0] + "/PV";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
             PVValue = dbValue;
             double PVScale = PVValue/(PVEUHI - PVEULO);
             PVBar.Height = (334.00 - 58.00) * PVScale;
             PVBar.VerticalPosition = 334.00 - PVBar.Height;    
	}
	else
        {
             PVBar.VerticalPosition = 334.00;
             PVBar.Height = 0;
        }

	return; 
}//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd1_PMPID_MODE_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText MODE = (DrawText)dynArgs.sender; 

    DrawRectangle Rect = (DrawRectangle)Area.GetDrawObj("Rect_MODE");  
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	int nDigit = 2;
	string tagName = Area.Variable[0] + "/MODE";

	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
            {
                if(dbValue == 1)
                  {
                      MODE.Caption = "MAN";
                      MODE.ForegroundColor = Color.Black;
                      Rect.ForegroundColor = Color.Yellow;
                  }
                if(dbValue == 2)
                  {
                      MODE.Caption = "AUTO";
                      MODE.ForegroundColor = Color.Cyan;
                      Rect.ForegroundColor = Color.Black;
                  }
                if(dbValue == 3)
                  {
                      MODE.Caption = "CAS";
                      MODE.ForegroundColor = Color.Black;
                      Rect.ForegroundColor = Color.Cyan;
                  }
            }
       else
            {MODE.Caption = "###";}

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void gd1_PMPID_Rect_MODE_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect_MODE = (DrawRectangle)dynArgs.sender; 

           DrawArea pic = (DrawArea)(Area.Parent.Parent);

           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

           DrawArea p = (DrawArea)(Area.Parent.Parent);
           DrawArea G = (DrawArea)p.GetDrawObj("TDC3000_Groupfaceplate");
           G.Visible = true;
           G.Variable[0] = Area.Variable[0];

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd1_PMPID_Unit_OnDynAnimation(Object sender, EventArgs e)
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
public void gd1_PMPID_TagName_OnDynAnimation(Object sender, EventArgs e)
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
public void gd1_PMPID_PV_OnDynAnimation(Object sender, EventArgs e)
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


          if(PV.Variable[0] == "1")

            {
                PV.ForegroundColor = Color.White;
            }

          else

            {
                PV.ForegroundColor = Color.Cyan;
            }

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd1_PMPID_PV_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PV = (DrawText)dynArgs.sender; 
   
    PV.ForegroundColor = Color.Cyan;
    PV.Variable[0] = "0";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd1_PMPID_SP_OnDynAnimation(Object sender, EventArgs e)
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

          if(SP.Variable[0] == "1")

            {
                SP.ForegroundColor = Color.White;
            }

          else

            {
                SP.ForegroundColor = Color.Cyan;
            }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd1_PMPID_SP_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText SP = (DrawText)dynArgs.sender; 

    SP.ForegroundColor = Color.Cyan; 
    SP.Variable[0] = "0";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd1_PMPID_OP_OnDynAnimation(Object sender, EventArgs e)
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

          if(OP.Variable[0] == "1")

            {
                OP.ForegroundColor = Color.White;
            }

          else

            {
                OP.ForegroundColor = Color.Yellow;
            }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd1_PMPID_OP_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText OP = (DrawText)dynArgs.sender; 
 
    OP.ForegroundColor = Color.Yellow; 
    OP.Variable[0] = "0";

    return; 
}


//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd1_PMPID_R_tagname_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 
   
    R_tagname.Visible = true;
    R_tagname.ForegroundColor = Color.Black;
    R_tagname.EdgeColor = Color.Black;
           DrawArea p = (DrawArea)(Area.Parent);
           p.Variable[1] = "0";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void gd1_PMPID_R_tagname_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 
   
           DrawArea pic = (DrawArea)(Area.Parent.Parent);

           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd1_PMPID_R_tagname_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 

           DrawArea p = (DrawArea)(Area.Parent);
           if(p.Variable[1] == "1")
              {
                    R_tagname.ForegroundColor = Color.Blue;
                    R_tagname.EdgeColor = Color.White;
              }
           else
              {
                    R_tagname.ForegroundColor = Color.Black;
                    R_tagname.EdgeColor = Color.Black;

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
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd1_PMPID_Rect7_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect7 = (DrawRectangle)dynArgs.sender; 
   
    Rect7.Visible = true;
    Rect7.ForegroundColor = Color.Black;
    Rect7.EdgeColor = Color.Black;
           DrawArea p = (DrawArea)(Area.Parent);
           p.Variable[1] = "0";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void gd1_PMPID_Rect7_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect7 = (DrawRectangle)dynArgs.sender; 
   
           DrawArea pic = (DrawArea)(Area.Parent.Parent);

           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

    DrawText SP = (DrawText)Area.GetDrawObj("SP");
    SP.Variable[0] = "1";
    DrawText PV = (DrawText)Area.GetDrawObj("PV");
    PV.Variable[0] = "0";
    DrawText OP = (DrawText)Area.GetDrawObj("OP");
    OP.Variable[0] = "0";

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
				CommonFunction.MoveControl(Area,TB,(int)(Rect7.VerticalPosition - 40),(int)(Rect7.HorizontalPosition));		
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
public void gd1_PMPID_Rect7_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect7 = (DrawRectangle)dynArgs.sender; 

    DrawText SP = (DrawText)Area.GetDrawObj("SP");
    DrawArea p = (DrawArea)(Area.Parent);

			if(SP.Variable[0] == "1" && p.Variable[1] == "1")
			{
		 		Rect7.ForegroundColor = Color.Blue;
                                Rect7.EdgeColor = Color.White;                                   
			}
                        else
			{
		 		Rect7.ForegroundColor = Color.Black;
                                Rect7.EdgeColor = Color.Black; 
                                SP.Variable[0] = "0";                                  
			}
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd1_PMPID_Rect8_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect8 = (DrawRectangle)dynArgs.sender; 
   
    Rect8.Visible = true;
    Rect8.ForegroundColor = Color.Black;
    Rect8.EdgeColor = Color.Black;
           DrawArea p = (DrawArea)(Area.Parent);
           p.Variable[1] = "0";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void gd1_PMPID_Rect8_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect8 = (DrawRectangle)dynArgs.sender; 
   
           DrawArea pic = (DrawArea)(Area.Parent.Parent);

           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

    DrawText SP = (DrawText)Area.GetDrawObj("SP");
    SP.Variable[0] = "0";
    DrawText PV = (DrawText)Area.GetDrawObj("PV");
    PV.Variable[0] = "1";
    DrawText OP = (DrawText)Area.GetDrawObj("OP");
    OP.Variable[0] = "0";

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
				CommonFunction.MoveControl(Area,TB,(int)(Rect8.VerticalPosition)-40,(int)(Rect8.HorizontalPosition));
			
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
public void gd1_PMPID_Rect8_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect8 = (DrawRectangle)dynArgs.sender; 

    DrawText PV = (DrawText)Area.GetDrawObj("PV");
    DrawArea p = (DrawArea)(Area.Parent);

			if(PV.Variable[0] == "1" && p.Variable[1] == "1")
			{
		 		Rect8.ForegroundColor = Color.Blue;
                                Rect8.EdgeColor = Color.White;                                   
			}
                        else
			{
		 		Rect8.ForegroundColor = Color.Black;
                                Rect8.EdgeColor = Color.Black;  
                                PV.Variable[0] = "0";                                 
			}

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd1_PMPID_Rect9_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect9 = (DrawRectangle)dynArgs.sender; 
   
    Rect9.Visible = true;
    Rect9.ForegroundColor = Color.Black;
    Rect9.EdgeColor = Color.Black;
           DrawArea p = (DrawArea)(Area.Parent);
           p.Variable[1] = "0";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void gd1_PMPID_Rect9_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect9 = (DrawRectangle)dynArgs.sender; 
   
           DrawArea pic = (DrawArea)(Area.Parent.Parent);

           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

    DrawText SP = (DrawText)Area.GetDrawObj("SP");
    SP.Variable[0] = "0";
    DrawText PV = (DrawText)Area.GetDrawObj("PV");
    PV.Variable[0] = "0";
    DrawText OP = (DrawText)Area.GetDrawObj("OP");
    OP.Variable[0] = "1";

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
			        CommonFunction.MoveControl(Area,TB,(int)(Rect9.VerticalPosition)-40,(int)(Rect9.HorizontalPosition));
				
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
public void gd1_PMPID_Rect9_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect9 = (DrawRectangle)dynArgs.sender; 

    DrawText OP = (DrawText)Area.GetDrawObj("OP");
    DrawArea p = (DrawArea)(Area.Parent);

			if(OP.Variable[0] == "1" && p.Variable[1] == "1")
			{
		 		Rect9.ForegroundColor = Color.Blue;
                                Rect9.EdgeColor = Color.White;                                   
			}
                        else
			{
		 		Rect9.ForegroundColor = Color.Black;
                                Rect9.EdgeColor = Color.Black; 
                                OP.Variable[0] = "0";                                  
			}

    return; 
}
//Do not remove or update this comment
//Event Delegate:KeyEventHandler 
//Event Handler:KeyUp 
public void gd1_PMPID_TB_KeyUp(Object sender, KeyEventArgs e)
{
   TextBox TB = (TextBox)sender; 

   DrawArea Area = CommonFunction.GetThisDrawArea(TB);

     double dbValue = 0;
     int nValue = 0;
     bool bValue = false;
     int nDataType = 0;

        double OPHI = 0;
        double OPLO = 0;
        double SPEUHI = 0;
        double SPEULO = 0;
        double PVEUHI = 0;
        double PVEULO = 0;

	string tagName = Area.Variable[0] + "/OPHI";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     OPHI = dbValue;             
	}

	tagName = Area.Variable[0] + "/OPLO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     OPLO = dbValue;             
	}

	tagName = Area.Variable[0] + "/SPEUHI";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     SPEUHI = dbValue;             
	}

	tagName = Area.Variable[0] + "/SPEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     SPEULO = dbValue;             
	}

	tagName = Area.Variable[0] + "/PVEUHI";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEUHI = dbValue;        
	}

	tagName = Area.Variable[0] + "/PVEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEULO = dbValue;             
	}

     double dbValue1 = 0;
     int nValue1 = 0;
     bool bValue1 = false;
     int nDataType1 = 0;
     string MODE = Area.Variable[0] + "/MODE";
     bool ret1 = CommonFunction.GetValueWithType(MODE,ref dbValue1,ref nValue1,ref bValue1,ref nDataType1);

	switch ( e.KeyData )
	{
	case Keys.Enter:

		if(TB.Text == "" || TB.Text == null)

		{
			TB.Visible = false;
			TB.Enabled = false;
                        DrawText P = (DrawText)Area.GetDrawObj("PV");
                        P.Variable[0] = "0";
                        DrawText OP = (DrawText)Area.GetDrawObj("OP");
                        OP.Variable[0] = "0";
                        DrawText SP = (DrawText)Area.GetDrawObj("SP");
                        SP.Variable[0] = "0";
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
		             string tag=lab.Variable[0];

                             //PV值只有在MODE是MAN的时候才可以改变
                             bool V = tag.Contains("PV");
                             bool O = tag.Contains("OP");
                             bool S = tag.Contains("SP");
                             if(V == true && ret1)
                               {
                                    if(dbPVValue<=PVEUHI && dbPVValue>=PVEULO)
                                       {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                       }
                                    else
                                       {
				          CommonFunction._ProjectRelated.Var[1] = "LMT";
                                       }
                               }

                             if(O == true && ret1)
                               {//OP值只有在MODE是MAN的时候才可以改变
	                 	  if(dbValue1==1)
                                   {
                                    if(dbPVValue<=OPHI && dbPVValue>=OPLO)
                                       {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                       }
                                    else
                                      {
				          CommonFunction._ProjectRelated.Var[1] = "LMT";
                                       }
                                    }
	                	  else 
                                    {
                                        CommonFunction._ProjectRelated.Var[1] = "MODE ERROR";

                                    }
                               }

                             if(S == true && ret1)
                               {//SP值只有在MODE是AUTO的时候才可以改变
                                if(dbValue1==2)
                                 {
	                 	  if(dbPVValue<=SPEUHI && dbPVValue>=SPEULO)

				   {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                   }
	                	  else 
                                    {
                                        CommonFunction._ProjectRelated.Var[1] = "LMT";
                                    }
                                  }
	                	  else 
                                    {
                                        CommonFunction._ProjectRelated.Var[1] = "MODE ERROR";

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
CommonFunction._ProjectRelated.Var[1] = "";
    DrawText P1 = (DrawText)Area.GetDrawObj("PV");
    P1.Variable[0] = "0";
    DrawText OP1 = (DrawText)Area.GetDrawObj("OP");
    OP1.Variable[0] = "0";
    DrawText SP1 = (DrawText)Area.GetDrawObj("SP");
    SP1.Variable[0] = "0";
    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd8_OnDynInitialize(Object sender, EventArgs e)
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
public void gd8_OnDynAnimation(Object sender, EventArgs e)
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

             else 

                {
                     PMDIGCOM.Visible = false;
                     PMPID.Visible = false;
                     PMANLIN.Visible = false;
                }

        }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd8_PMDIGCOM_OnDynInitialize(Object sender, EventArgs e)
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
public void gd8_PMDIGCOM_Rect_PVON_OnDynAnimation(Object sender, EventArgs e)
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
public void gd8_PMDIGCOM_OP_OnDynAnimation(Object sender, EventArgs e)
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
public void gd8_PMDIGCOM_Rect_OFF_OnDynAnimation(Object sender, EventArgs e)
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
public void gd8_PMDIGCOM_Rect_ON_OnDynAnimation(Object sender, EventArgs e)
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
public void gd8_PMDIGCOM_Unit_OnDynAnimation(Object sender, EventArgs e)
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
public void gd8_PMDIGCOM_TagName_OnDynAnimation(Object sender, EventArgs e)
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
//Event Handler:OnDynInitialize 
public void gd8_PMDIGCOM_Rect9_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 
   
    R_tagname.Visible = true;
    R_tagname.ForegroundColor = Color.Black;
    R_tagname.EdgeColor = Color.Black;
           DrawArea p = (DrawArea)(Area.Parent);
           p.Variable[1] = "0";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void gd8_PMDIGCOM_Rect9_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 
   
           DrawArea pic = (DrawArea)(Area.Parent.Parent);

           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd8_PMDIGCOM_Rect9_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 

           DrawArea p = (DrawArea)(Area.Parent);
           if(p.Variable[1] == "1")
              {
                    R_tagname.ForegroundColor = Color.Blue;
                    R_tagname.EdgeColor = Color.White;
              }
           else
              {
                    R_tagname.ForegroundColor = Color.Black;
                    R_tagname.EdgeColor = Color.Black;
              }
 
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd8_PMANLIN_OnDynInitialize(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 
 
	Picture pic = CommonFunction.GetThisPicture(Area);
	if(pic != null)
	{  
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
				TB.Visible = false;
				TB.Focus();
			}
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
//Event Handler:OnDynClick 
public void gd8_PMANLIN_OnDynClick(Object sender, EventArgs e)
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
public void gd8_PMANLIN_KeyUp(Object sender, KeyEventArgs e)
{
   TextBox TB = (TextBox)sender; 

   DrawArea Area = CommonFunction.GetThisDrawArea(TB);

     double dbValue = 0;
     int nValue = 0;
     bool bValue = false;
     int nDataType = 0;

        double PVEXEH = 0;
        double PVEXEL = 0;
        double PVEUHI = 0;
        double PVEULO = 0;

	string tagName = Area.Variable[0] + "/PVEXEH";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEXEH = dbValue;             
	}

	tagName = Area.Variable[0] + "/PVEXEL";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEXEL = dbValue;             
	}

	tagName = Area.Variable[0] + "/PVEUHI";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEUHI = dbValue;        
	}

	tagName = Area.Variable[0] + "/PVEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEULO = dbValue;             
	}

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
		             string tag=lab.Variable[0];
                             bool PV = tagName.Contains("PV");
                             bool PVTV = tagName.Contains("PVTV");
                             if(PV == true)
                               {

                                    if(dbPVValue <= PVEUHI && dbPVValue >= PVEULO)
                                       {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                       }
                                    else
                                       {
				          CommonFunction._ProjectRelated.Var[1] = "LMT";
                                       }
                               }


                             if(PVTV == true)
                               {
	                 	  if(dbPVValue <= PVEXEH && dbPVValue >= PVEXEL)

				   {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                   }
	                	  else 
                                    {
                                        CommonFunction._ProjectRelated.Var[1] = "LMT";
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
CommonFunction._ProjectRelated.Var[1] = "";

    DrawText P1 = (DrawText)Area.GetDrawObj("PV");
    P1.Variable[0] = "0";
    DrawText V1 = (DrawText)Area.GetDrawObj("PVTV");
    V1.Variable[0] = "0";

    return; 
}



//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd8_PMANLIN_Rect8_OnDynAnimation(Object sender, EventArgs e)	//PVBar
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawRectangle PVBar = (DrawRectangle)dynArgs.sender; 
	
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	double PVValue = 0;
        double PVEUHI = 0;
        double PVEULO = 0;

	string tagName = Area.Variable[0] + "/PVEUHI";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEUHI = dbValue;
             
	}

	tagName = Area.Variable[0] + "/PVEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEULO = dbValue;
             
	}
	
	tagName = Area.Variable[0] + "/PV";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
             PVValue = dbValue;

             if(PVEUHI != PVEULO)
                {
                    double PVScale = PVValue/(PVEUHI - PVEULO);
                    PVBar.Height = (334.00 - 58.00) * PVScale;
                    PVBar.VerticalPosition = 334.00 - PVBar.Height;
                }     
	}
	else
        {
             PVBar.VerticalPosition = 334.00;
             PVBar.Height = 0;
        }

	return; 
}//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd8_PMANLIN_Line16_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawLine PVBlack = (DrawLine)dynArgs.sender; 
   
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	double PVValue = 0;
	
	String tagName = Area.Variable[0] + "/PV";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
             if(dbValue == 0)
                {
                    PVBlack.EdgeColor = Color.Cyan;
                }
             else
                {
                    PVBlack.EdgeColor = Color.Black;
                }
	}
	else
        {
             PVBlack.EdgeColor = Color.Black;
        }

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd8_PMANLIN_LinePVTV_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawLine LinePVTV = (DrawLine)dynArgs.sender; 


	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	double PVValue = 0;
        double PVEXEH = 0;
        double PVEXEL = 0;

	string tagName = Area.Variable[0] + "/PVEXEH";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEXEH = dbValue;
             
	}

	tagName = Area.Variable[0] + "/PVEXEL";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEXEL = dbValue;
             
	}
	
	tagName = Area.Variable[0] + "/PVTV";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
             PVValue = dbValue;
             if(PVEXEH != PVEXEL)
                {
                      double PVScale = PVValue/(PVEXEH - PVEXEL);
                      LinePVTV.VerticalPosition = 334 - (334 - 58) * PVScale;
                }   
	}
	else
             LinePVTV.VerticalPosition = 334;
   
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd8_PMANLIN_TagName_OnDynAnimation(Object sender, EventArgs e)
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
public void gd8_PMANLIN_PV_OnDynAnimation(Object sender, EventArgs e)
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

          if(PV.Variable[0] == "1")

            {
                PV.ForegroundColor = Color.White;
            }

          else

            {
                PV.ForegroundColor = Color.Cyan;
            }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd8_PMANLIN_PV_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PV = (DrawText)dynArgs.sender; 
   
    PV.ForegroundColor = Color.Cyan; 
    PV.Variable[0] = "0";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd8_PMANLIN_PVTV_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVTV = (DrawText)dynArgs.sender;
 
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
	
	tagName = Area.Variable[0] + "/PVTV";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		PVTV.Caption = dbValue.ToString(strDigit);
	}
	else
		PVTV.Caption = "##.#";

          if(PVTV.Variable[0] == "1")

            {
                PVTV.ForegroundColor = Color.White;
            }

          else

            {
                PVTV.ForegroundColor = Color.Cyan;
            }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd8_PMANLIN_PVTV_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVTV = (DrawText)dynArgs.sender; 

    PVTV.ForegroundColor = Color.Cyan; 
    PVTV.Variable[0] = "0";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd8_PMANLIN_Rect9_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 
   
    R_tagname.Visible = true;
    R_tagname.ForegroundColor = Color.Black;
    R_tagname.EdgeColor = Color.Black;
           DrawArea p = (DrawArea)(Area.Parent);
           p.Variable[1] = "0";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void gd8_PMANLIN_Rect9_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 

           DrawArea pic = (DrawArea)(Area.Parent.Parent);

           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd8_PMANLIN_Rect9_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 

           DrawArea p = (DrawArea)(Area.Parent);
           if(p.Variable[1] == "1")
              {
                    R_tagname.ForegroundColor = Color.Blue;
                    R_tagname.EdgeColor = Color.White;
              }
           else
              {
                    R_tagname.ForegroundColor = Color.Black;
                    R_tagname.EdgeColor = Color.Black;

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
 
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd8_PMANLIN_Rect10_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect10 = (DrawRectangle)dynArgs.sender; 
   
    Rect10.Visible = true;
    Rect10.ForegroundColor = Color.Black;
    Rect10.EdgeColor = Color.Black;
           DrawArea p = (DrawArea)(Area.Parent);
           p.Variable[1] = "0";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void gd8_PMANLIN_Rect10_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect10 = (DrawRectangle)dynArgs.sender; 

    DrawText PVTV = (DrawText)Area.GetDrawObj("PVTV");
    PVTV.Variable[0] = "1";
    DrawText PV = (DrawText)Area.GetDrawObj("PV");
    PV.Variable[0] = "0";

    if(PVTV.Visible == true)

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
				CommonFunction.MoveControl(Area,TB,(int)(Rect10.VerticalPosition - 40),(int)(Rect10.HorizontalPosition));		
				obj = CommonFunction.GetLabelOfControl(TB);
				if(obj != null)
				{
					ControlLabel lab = (ControlLabel)obj;
					//给TB传递参数：
					lab.Variable[0] = Area.Variable[0] + "/PVTV";
                                      
				}
			}
		}
	}

    DrawArea pic = (DrawArea)(Area.Parent.Parent); 
           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd8_PMANLIN_Rect10_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect10 = (DrawRectangle)dynArgs.sender; 

    DrawText PVTV = (DrawText)Area.GetDrawObj("PVTV");
    DrawArea p = (DrawArea)(Area.Parent);

			if(PVTV.Variable[0] == "1" && p.Variable[1] == "1")
			{
		 		Rect10.ForegroundColor = Color.Blue;
                                Rect10.EdgeColor = Color.White;                                   
			}
                        else
			{
		 		Rect10.ForegroundColor = Color.Black;
                                Rect10.EdgeColor = Color.Black; 
                                PVTV.Variable[0] = "0";                                  
			}


    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd8_PMANLIN_Rect11_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect11 = (DrawRectangle)dynArgs.sender; 
   
    Rect11.Visible = true;
    Rect11.ForegroundColor = Color.Black;
    Rect11.EdgeColor = Color.Black;
           DrawArea p = (DrawArea)(Area.Parent);
           p.Variable[1] = "0";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void gd8_PMANLIN_Rect11_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect11 = (DrawRectangle)dynArgs.sender; 
   
           DrawArea pic = (DrawArea)(Area.Parent.Parent);

           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

    DrawText PV = (DrawText)Area.GetDrawObj("PV");
    PV.Variable[0] = "1";
    DrawText PVTV = (DrawText)Area.GetDrawObj("PVTV");
    PVTV.Variable[0] = "0";
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
				CommonFunction.MoveControl(Area,TB,(int)(Rect11.VerticalPosition)-40,(int)(Rect11.HorizontalPosition));
			
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
public void gd8_PMANLIN_Rect11_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect11 = (DrawRectangle)dynArgs.sender; 

    DrawText PV = (DrawText)Area.GetDrawObj("PV");
    DrawArea p = (DrawArea)(Area.Parent);

			if(PV.Variable[0] == "1" && p.Variable[1] == "1")
			{
		 		Rect11.ForegroundColor = Color.Blue;
                                Rect11.EdgeColor = Color.White;                                   
			}
                        else
			{
		 		Rect11.ForegroundColor = Color.Black;
                                Rect11.EdgeColor = Color.Black;
                                PV.Variable[0] = "0";                                   
			}

    return; 
}
//Do not remove or update this comment
//Event Delegate:KeyEventHandler 
//Event Handler:KeyUp 
public void gd8_PMANLIN_TB_KeyUp(Object sender, KeyEventArgs e)
{
   TextBox TB = (TextBox)sender; 

   DrawArea Area = CommonFunction.GetThisDrawArea(TB);

     double dbValue = 0;
     int nValue = 0;
     bool bValue = false;
     int nDataType = 0;

        double PVEXEH = 0;
        double PVEXEL = 0;
        double PVEUHI = 0;
        double PVEULO = 0;

	string tagName = Area.Variable[0] + "/PVEXEH";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEXEH = dbValue;             
	}

	tagName = Area.Variable[0] + "/PVEXEL";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEXEL = dbValue;             
	}

	tagName = Area.Variable[0] + "/PVEUHI";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEUHI = dbValue;        
	}

	tagName = Area.Variable[0] + "/PVEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEULO = dbValue;             
	}

	switch ( e.KeyData )
	{
	case Keys.Enter:

		if(TB.Text == "" || TB.Text == null)

		{
			TB.Visible = false;
			TB.Enabled = false;
                        DrawText P = (DrawText)Area.GetDrawObj("PV");
                        P.Variable[0] = "0";
                        DrawText V = (DrawText)Area.GetDrawObj("PVTV");
                        V.Variable[0] = "0";
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
		             string tag=lab.Variable[0];
                             bool PV = tagName.Contains("PV");
                             bool PVTV = tagName.Contains("PVTV");
                             if(PV == true)
                               {

                                    if(dbPVValue <= PVEUHI && dbPVValue >= PVEULO)
                                       {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                       }
                                    else
                                       {
				          CommonFunction._ProjectRelated.Var[1] = "LMT";
                                       }
                               }


                             if(PVTV == true)
                               {
	                 	  if(dbPVValue <= PVEXEH && dbPVValue >= PVEXEL)

				   {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                   }
	                	  else 
                                    {
                                        CommonFunction._ProjectRelated.Var[1] = "LMT";
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
CommonFunction._ProjectRelated.Var[1] = "";
    DrawText P1 = (DrawText)Area.GetDrawObj("PV");
    P1.Variable[0] = "0";
    DrawText V1 = (DrawText)Area.GetDrawObj("PVTV");
    V1.Variable[0] = "0";
    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd8_PMPID_OnDynInitialize(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 
 
	Picture pic = CommonFunction.GetThisPicture(Area);
	if(pic != null)
	{  
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
				TB.Visible = false;
				TB.Focus();
			}
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
//Event Handler:OnDynClick 
public void gd8_PMPID_OnDynClick(Object sender, EventArgs e)
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
public void gd8_PMPID_KeyUp(Object sender, KeyEventArgs e)
{
   TextBox TB = (TextBox)sender; 
   DrawArea Area = CommonFunction.GetThisDrawArea(TB);

     double dbValue = 0;
     int nValue = 0;
     bool bValue = false;
     int nDataType = 0;

        double OPHI = 0;
        double OPLO = 0;
        double SPEUHI = 0;
        double SPEULO = 0;
        double PVEUHI = 0;
        double PVEULO = 0;

	string tagName = Area.Variable[0] + "/OPHI";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     OPHI = dbValue;             
	}

	tagName = Area.Variable[0] + "/OPLO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     OPLO = dbValue;             
	}

	tagName = Area.Variable[0] + "/SPEUHI";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     SPEUHI = dbValue;             
	}

	tagName = Area.Variable[0] + "/SPEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     SPEULO = dbValue;             
	}

	tagName = Area.Variable[0] + "/PVEUHI";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEUHI = dbValue;        
	}

	tagName = Area.Variable[0] + "/PVEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEULO = dbValue;             
	}

     double dbValue1 = 0;
     int nValue1 = 0;
     bool bValue1 = false;
     int nDataType1 = 0;
     string MODE = Area.Variable[0] + "/MODE";
     bool ret1 = CommonFunction.GetValueWithType(MODE,ref dbValue1,ref nValue1,ref bValue1,ref nDataType1);

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
		             string tag=lab.Variable[0];

                             //PV值只有在MODE是MAN的时候才可以改变
                             bool V = tag.Contains("PV");
                             bool O = tag.Contains("OP");
                             bool S = tag.Contains("SP");
                             if(V == true && ret1)
                               {
                                    if(dbPVValue<=PVEUHI && dbPVValue>=PVEULO)
                                       {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                       }
                                    else
                                       {
				          CommonFunction._ProjectRelated.Var[1] = "LMT";
                                       }
                               }

                             if(O == true && ret1)
                               {//OP值只有在MODE是MAN的时候才可以改变
	                 	  if(dbValue1==1)
                                   {
                                    if(dbPVValue<=OPHI && dbPVValue>=OPLO)
                                       {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                       }
                                    else
                                      {
				          CommonFunction._ProjectRelated.Var[1] = "LMT";
                                       }
                                    }
	                	  else 
                                    {
                                        CommonFunction._ProjectRelated.Var[1] = "MODE ERROR";

                                    }
                               }

                             if(S == true && ret1)
                               {//SP值只有在MODE是AUTO的时候才可以改变
                                if(dbValue1==2)
                                 {
	                 	  if(dbPVValue<=SPEUHI && dbPVValue>=SPEULO)

				   {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                   }
	                	  else 
                                    {
                                        CommonFunction._ProjectRelated.Var[1] = "LMT";
                                    }
                                  }
	                	  else 
                                    {
                                        CommonFunction._ProjectRelated.Var[1] = "MODE ERROR";

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

CommonFunction._ProjectRelated.Var[1] = "";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd8_PMPID_ALM_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText ALM = (DrawText)dynArgs.sender; 
   
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
	
	tagName = Area.Variable[0] + "/PVHLFL";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
              string alm = dbValue.ToString(strDigit);

		if(alm == "0.00")

                   {ALM.Caption = "";}

		if(alm == "1.00")

                   {ALM.Caption = "HP";}

		if(alm == "2.00")

                   {ALM.Caption = "2HP";}

		if(alm == "-1.00")

                   {ALM.Caption = "LP";}

		if(alm == "-2.00")

                   {ALM.Caption = "2LP";}
	}
	else
		ALM.Caption = "";
        	

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd8_PMPID_OPBar_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawLine OPBar = (DrawLine)dynArgs.sender; 
   
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	double OPValue = 0;
        double OPHI = 0;
        double OPLO = 0;

	string tagName = Area.Variable[0] + "/OPHI";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     OPHI = dbValue;
             
	}

	tagName = Area.Variable[0] + "/OPLO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     OPLO = dbValue;
             
	}
	
	tagName = Area.Variable[0] + "/OP";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
             OPValue = dbValue;
             double OPScale = OPValue/(OPHI - OPLO);
             OPBar.EndY = 334 - (334 - 58) * OPScale;    
	}
	else
             OPBar.EndY = 334;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd8_PMPID_PVBlack_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawLine PVBlack = (DrawLine)dynArgs.sender; 
   
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	double PVValue = 0;
	
	String tagName = Area.Variable[0] + "/PV";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
             if(dbValue == 0)
                {
                    PVBlack.EdgeColor = Color.Cyan;
                }
             else
                {
                    PVBlack.EdgeColor = Color.Black;
                }
	}
	else
        {
             PVBlack.EdgeColor = Color.Black;
        }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd8_PMPID_SPLine_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawLine SPLine = (DrawLine)dynArgs.sender; 

	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	double SPValue = 0;
        double SPEUHI = 0;
        double SPEULO = 0;

	string tagName = Area.Variable[0] + "/SPEUHI";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     SPEUHI = dbValue;
             
	}

	tagName = Area.Variable[0] + "/SPEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     SPEULO = dbValue;
             
	}
	
	tagName = Area.Variable[0] + "/SP";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
             SPValue = dbValue;
             double SPScale = SPValue/(SPEUHI - SPEULO);
             SPLine.VerticalPosition = 334 - (334 - 58) * SPScale;    
	}
	else
             SPLine.VerticalPosition = 334;
   
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd8_PMPID_PVBar_OnDynAnimation(Object sender, EventArgs e)	//PVBar
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawRectangle PVBar = (DrawRectangle)dynArgs.sender; 
	
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	double PVValue = 0;
        double PVEUHI = 0;
        double PVEULO = 0;

	string tagName = Area.Variable[0] + "/PVEUHI";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEUHI = dbValue;
             
	}

	tagName = Area.Variable[0] + "/PVEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEULO = dbValue;
             
	}
	
	tagName = Area.Variable[0] + "/PV";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
             PVValue = dbValue;
             double PVScale = PVValue/(PVEUHI - PVEULO);
             PVBar.Height = (334.00 - 58.00) * PVScale;
             PVBar.VerticalPosition = 334.00 - PVBar.Height;    
	}
	else
        {
             PVBar.VerticalPosition = 334.00;
             PVBar.Height = 0;
        }

	return; 
}//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd8_PMPID_MODE_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText MODE = (DrawText)dynArgs.sender; 

    DrawRectangle Rect = (DrawRectangle)Area.GetDrawObj("Rect_MODE");  
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	int nDigit = 2;
	string tagName = Area.Variable[0] + "/MODE";

	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
            {
                if(dbValue == 1)
                  {
                      MODE.Caption = "MAN";
                      MODE.ForegroundColor = Color.Black;
                      Rect.ForegroundColor = Color.Yellow;
                  }
                if(dbValue == 2)
                  {
                      MODE.Caption = "AUTO";
                      MODE.ForegroundColor = Color.Cyan;
                      Rect.ForegroundColor = Color.Black;
                  }
                if(dbValue == 3)
                  {
                      MODE.Caption = "CAS";
                      MODE.ForegroundColor = Color.Black;
                      Rect.ForegroundColor = Color.Cyan;
                  }
            }
       else
            {MODE.Caption = "###";}

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void gd8_PMPID_Rect_MODE_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect_MODE = (DrawRectangle)dynArgs.sender; 

           DrawArea pic = (DrawArea)(Area.Parent.Parent);

           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

           DrawArea p = (DrawArea)(Area.Parent.Parent);
           DrawArea G = (DrawArea)p.GetDrawObj("TDC3000_Groupfaceplate");
           G.Visible = true;
           G.Variable[0] = Area.Variable[0];

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd8_PMPID_Unit_OnDynAnimation(Object sender, EventArgs e)
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
public void gd8_PMPID_TagName_OnDynAnimation(Object sender, EventArgs e)
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
public void gd8_PMPID_PV_OnDynAnimation(Object sender, EventArgs e)
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


          if(PV.Variable[0] == "1")

            {
                PV.ForegroundColor = Color.White;
            }

          else

            {
                PV.ForegroundColor = Color.Cyan;
            }

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd8_PMPID_PV_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PV = (DrawText)dynArgs.sender; 
   
    PV.ForegroundColor = Color.Cyan;
    PV.Variable[0] = "0";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd8_PMPID_SP_OnDynAnimation(Object sender, EventArgs e)
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

          if(SP.Variable[0] == "1")

            {
                SP.ForegroundColor = Color.White;
            }

          else

            {
                SP.ForegroundColor = Color.Cyan;
            }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd8_PMPID_SP_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText SP = (DrawText)dynArgs.sender; 

    SP.ForegroundColor = Color.Cyan; 
    SP.Variable[0] = "0";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd8_PMPID_OP_OnDynAnimation(Object sender, EventArgs e)
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

          if(OP.Variable[0] == "1")

            {
                OP.ForegroundColor = Color.White;
            }

          else

            {
                OP.ForegroundColor = Color.Yellow;
            }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd8_PMPID_OP_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText OP = (DrawText)dynArgs.sender; 
 
    OP.ForegroundColor = Color.Yellow; 
    OP.Variable[0] = "0";

    return; 
}


//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd8_PMPID_R_tagname_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 
   
    R_tagname.Visible = true;
    R_tagname.ForegroundColor = Color.Black;
    R_tagname.EdgeColor = Color.Black;
           DrawArea p = (DrawArea)(Area.Parent);
           p.Variable[1] = "0";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void gd8_PMPID_R_tagname_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 
   
           DrawArea pic = (DrawArea)(Area.Parent.Parent);

           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd8_PMPID_R_tagname_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 

           DrawArea p = (DrawArea)(Area.Parent);
           if(p.Variable[1] == "1")
              {
                    R_tagname.ForegroundColor = Color.Blue;
                    R_tagname.EdgeColor = Color.White;
              }
           else
              {
                    R_tagname.ForegroundColor = Color.Black;
                    R_tagname.EdgeColor = Color.Black;

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
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd8_PMPID_Rect7_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect7 = (DrawRectangle)dynArgs.sender; 
   
    Rect7.Visible = true;
    Rect7.ForegroundColor = Color.Black;
    Rect7.EdgeColor = Color.Black;
           DrawArea p = (DrawArea)(Area.Parent);
           p.Variable[1] = "0";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void gd8_PMPID_Rect7_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect7 = (DrawRectangle)dynArgs.sender; 
   
           DrawArea pic = (DrawArea)(Area.Parent.Parent);

           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

    DrawText SP = (DrawText)Area.GetDrawObj("SP");
    SP.Variable[0] = "1";
    DrawText PV = (DrawText)Area.GetDrawObj("PV");
    PV.Variable[0] = "0";
    DrawText OP = (DrawText)Area.GetDrawObj("OP");
    OP.Variable[0] = "0";

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
				CommonFunction.MoveControl(Area,TB,(int)(Rect7.VerticalPosition - 40),(int)(Rect7.HorizontalPosition));		
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
public void gd8_PMPID_Rect7_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect7 = (DrawRectangle)dynArgs.sender; 

    DrawText SP = (DrawText)Area.GetDrawObj("SP");
    DrawArea p = (DrawArea)(Area.Parent);

			if(SP.Variable[0] == "1" && p.Variable[1] == "1")
			{
		 		Rect7.ForegroundColor = Color.Blue;
                                Rect7.EdgeColor = Color.White;                                   
			}
                        else
			{
		 		Rect7.ForegroundColor = Color.Black;
                                Rect7.EdgeColor = Color.Black; 
                                SP.Variable[0] = "0";                                  
			}
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd8_PMPID_Rect8_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect8 = (DrawRectangle)dynArgs.sender; 
   
    Rect8.Visible = true;
    Rect8.ForegroundColor = Color.Black;
    Rect8.EdgeColor = Color.Black;
           DrawArea p = (DrawArea)(Area.Parent);
           p.Variable[1] = "0";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void gd8_PMPID_Rect8_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect8 = (DrawRectangle)dynArgs.sender; 
   
           DrawArea pic = (DrawArea)(Area.Parent.Parent);

           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

    DrawText SP = (DrawText)Area.GetDrawObj("SP");
    SP.Variable[0] = "0";
    DrawText PV = (DrawText)Area.GetDrawObj("PV");
    PV.Variable[0] = "1";
    DrawText OP = (DrawText)Area.GetDrawObj("OP");
    OP.Variable[0] = "0";

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
				CommonFunction.MoveControl(Area,TB,(int)(Rect8.VerticalPosition)-40,(int)(Rect8.HorizontalPosition));
			
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
public void gd8_PMPID_Rect8_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect8 = (DrawRectangle)dynArgs.sender; 

    DrawText PV = (DrawText)Area.GetDrawObj("PV");
    DrawArea p = (DrawArea)(Area.Parent);

			if(PV.Variable[0] == "1" && p.Variable[1] == "1")
			{
		 		Rect8.ForegroundColor = Color.Blue;
                                Rect8.EdgeColor = Color.White;                                   
			}
                        else
			{
		 		Rect8.ForegroundColor = Color.Black;
                                Rect8.EdgeColor = Color.Black;  
                                PV.Variable[0] = "0";                                 
			}

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd8_PMPID_Rect9_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect9 = (DrawRectangle)dynArgs.sender; 
   
    Rect9.Visible = true;
    Rect9.ForegroundColor = Color.Black;
    Rect9.EdgeColor = Color.Black;
           DrawArea p = (DrawArea)(Area.Parent);
           p.Variable[1] = "0";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void gd8_PMPID_Rect9_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect9 = (DrawRectangle)dynArgs.sender; 
   
           DrawArea pic = (DrawArea)(Area.Parent.Parent);

           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

    DrawText SP = (DrawText)Area.GetDrawObj("SP");
    SP.Variable[0] = "0";
    DrawText PV = (DrawText)Area.GetDrawObj("PV");
    PV.Variable[0] = "0";
    DrawText OP = (DrawText)Area.GetDrawObj("OP");
    OP.Variable[0] = "1";

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
			        CommonFunction.MoveControl(Area,TB,(int)(Rect9.VerticalPosition)-40,(int)(Rect9.HorizontalPosition));
				
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
public void gd8_PMPID_Rect9_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect9 = (DrawRectangle)dynArgs.sender; 

    DrawText OP = (DrawText)Area.GetDrawObj("OP");
    DrawArea p = (DrawArea)(Area.Parent);

			if(OP.Variable[0] == "1" && p.Variable[1] == "1")
			{
		 		Rect9.ForegroundColor = Color.Blue;
                                Rect9.EdgeColor = Color.White;                                   
			}
                        else
			{
		 		Rect9.ForegroundColor = Color.Black;
                                Rect9.EdgeColor = Color.Black; 
                                OP.Variable[0] = "0";                                  
			}

    return; 
}
//Do not remove or update this comment
//Event Delegate:KeyEventHandler 
//Event Handler:KeyUp 
public void gd8_PMPID_TB_KeyUp(Object sender, KeyEventArgs e)
{
   TextBox TB = (TextBox)sender; 

   DrawArea Area = CommonFunction.GetThisDrawArea(TB);

     double dbValue = 0;
     int nValue = 0;
     bool bValue = false;
     int nDataType = 0;

        double OPHI = 0;
        double OPLO = 0;
        double SPEUHI = 0;
        double SPEULO = 0;
        double PVEUHI = 0;
        double PVEULO = 0;

	string tagName = Area.Variable[0] + "/OPHI";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     OPHI = dbValue;             
	}

	tagName = Area.Variable[0] + "/OPLO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     OPLO = dbValue;             
	}

	tagName = Area.Variable[0] + "/SPEUHI";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     SPEUHI = dbValue;             
	}

	tagName = Area.Variable[0] + "/SPEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     SPEULO = dbValue;             
	}

	tagName = Area.Variable[0] + "/PVEUHI";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEUHI = dbValue;        
	}

	tagName = Area.Variable[0] + "/PVEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEULO = dbValue;             
	}

     double dbValue1 = 0;
     int nValue1 = 0;
     bool bValue1 = false;
     int nDataType1 = 0;
     string MODE = Area.Variable[0] + "/MODE";
     bool ret1 = CommonFunction.GetValueWithType(MODE,ref dbValue1,ref nValue1,ref bValue1,ref nDataType1);

	switch ( e.KeyData )
	{
	case Keys.Enter:

		if(TB.Text == "" || TB.Text == null)

		{
			TB.Visible = false;
			TB.Enabled = false;
                        DrawText P = (DrawText)Area.GetDrawObj("PV");
                        P.Variable[0] = "0";
                        DrawText OP = (DrawText)Area.GetDrawObj("OP");
                        OP.Variable[0] = "0";
                        DrawText SP = (DrawText)Area.GetDrawObj("SP");
                        SP.Variable[0] = "0";
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
		             string tag=lab.Variable[0];

                             //PV值只有在MODE是MAN的时候才可以改变
                             bool V = tag.Contains("PV");
                             bool O = tag.Contains("OP");
                             bool S = tag.Contains("SP");
                             if(V == true && ret1)
                               {
                                    if(dbPVValue<=PVEUHI && dbPVValue>=PVEULO)
                                       {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                       }
                                    else
                                       {
				          CommonFunction._ProjectRelated.Var[1] = "LMT";
                                       }
                               }

                             if(O == true && ret1)
                               {//OP值只有在MODE是MAN的时候才可以改变
	                 	  if(dbValue1==1)
                                   {
                                    if(dbPVValue<=OPHI && dbPVValue>=OPLO)
                                       {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                       }
                                    else
                                      {
				          CommonFunction._ProjectRelated.Var[1] = "LMT";
                                       }
                                    }
	                	  else 
                                    {
                                        CommonFunction._ProjectRelated.Var[1] = "MODE ERROR";

                                    }
                               }

                             if(S == true && ret1)
                               {//SP值只有在MODE是AUTO的时候才可以改变
                                if(dbValue1==2)
                                 {
	                 	  if(dbPVValue<=SPEUHI && dbPVValue>=SPEULO)

				   {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                   }
	                	  else 
                                    {
                                        CommonFunction._ProjectRelated.Var[1] = "LMT";
                                    }
                                  }
	                	  else 
                                    {
                                        CommonFunction._ProjectRelated.Var[1] = "MODE ERROR";

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
CommonFunction._ProjectRelated.Var[1] = "";
    DrawText P1 = (DrawText)Area.GetDrawObj("PV");
    P1.Variable[0] = "0";
    DrawText OP1 = (DrawText)Area.GetDrawObj("OP");
    OP1.Variable[0] = "0";
    DrawText SP1 = (DrawText)Area.GetDrawObj("SP");
    SP1.Variable[0] = "0";
    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd7_OnDynInitialize(Object sender, EventArgs e)
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
public void gd7_OnDynAnimation(Object sender, EventArgs e)
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

             else 

                {
                     PMDIGCOM.Visible = false;
                     PMPID.Visible = false;
                     PMANLIN.Visible = false;
                }

        }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd7_PMDIGCOM_OnDynInitialize(Object sender, EventArgs e)
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
public void gd7_PMDIGCOM_Rect_PVON_OnDynAnimation(Object sender, EventArgs e)
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
public void gd7_PMDIGCOM_OP_OnDynAnimation(Object sender, EventArgs e)
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
public void gd7_PMDIGCOM_Rect_OFF_OnDynAnimation(Object sender, EventArgs e)
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
public void gd7_PMDIGCOM_Rect_ON_OnDynAnimation(Object sender, EventArgs e)
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
public void gd7_PMDIGCOM_Unit_OnDynAnimation(Object sender, EventArgs e)
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
public void gd7_PMDIGCOM_TagName_OnDynAnimation(Object sender, EventArgs e)
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
//Event Handler:OnDynInitialize 
public void gd7_PMDIGCOM_Rect9_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 
   
    R_tagname.Visible = true;
    R_tagname.ForegroundColor = Color.Black;
    R_tagname.EdgeColor = Color.Black;
           DrawArea p = (DrawArea)(Area.Parent);
           p.Variable[1] = "0";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void gd7_PMDIGCOM_Rect9_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 
   
           DrawArea pic = (DrawArea)(Area.Parent.Parent);

           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd7_PMDIGCOM_Rect9_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 

           DrawArea p = (DrawArea)(Area.Parent);
           if(p.Variable[1] == "1")
              {
                    R_tagname.ForegroundColor = Color.Blue;
                    R_tagname.EdgeColor = Color.White;
              }
           else
              {
                    R_tagname.ForegroundColor = Color.Black;
                    R_tagname.EdgeColor = Color.Black;
              }
 
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd7_PMANLIN_OnDynInitialize(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 
 
	Picture pic = CommonFunction.GetThisPicture(Area);
	if(pic != null)
	{  
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
				TB.Visible = false;
				TB.Focus();
			}
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
//Event Handler:OnDynClick 
public void gd7_PMANLIN_OnDynClick(Object sender, EventArgs e)
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
public void gd7_PMANLIN_KeyUp(Object sender, KeyEventArgs e)
{
   TextBox TB = (TextBox)sender; 

   DrawArea Area = CommonFunction.GetThisDrawArea(TB);

     double dbValue = 0;
     int nValue = 0;
     bool bValue = false;
     int nDataType = 0;

        double PVEXEH = 0;
        double PVEXEL = 0;
        double PVEUHI = 0;
        double PVEULO = 0;

	string tagName = Area.Variable[0] + "/PVEXEH";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEXEH = dbValue;             
	}

	tagName = Area.Variable[0] + "/PVEXEL";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEXEL = dbValue;             
	}

	tagName = Area.Variable[0] + "/PVEUHI";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEUHI = dbValue;        
	}

	tagName = Area.Variable[0] + "/PVEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEULO = dbValue;             
	}

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
		             string tag=lab.Variable[0];
                             bool PV = tagName.Contains("PV");
                             bool PVTV = tagName.Contains("PVTV");
                             if(PV == true)
                               {

                                    if(dbPVValue <= PVEUHI && dbPVValue >= PVEULO)
                                       {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                       }
                                    else
                                       {
				          CommonFunction._ProjectRelated.Var[1] = "LMT";
                                       }
                               }


                             if(PVTV == true)
                               {
	                 	  if(dbPVValue <= PVEXEH && dbPVValue >= PVEXEL)

				   {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                   }
	                	  else 
                                    {
                                        CommonFunction._ProjectRelated.Var[1] = "LMT";
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
CommonFunction._ProjectRelated.Var[1] = "";

    DrawText P1 = (DrawText)Area.GetDrawObj("PV");
    P1.Variable[0] = "0";
    DrawText V1 = (DrawText)Area.GetDrawObj("PVTV");
    V1.Variable[0] = "0";

    return; 
}



//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd7_PMANLIN_Rect8_OnDynAnimation(Object sender, EventArgs e)	//PVBar
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawRectangle PVBar = (DrawRectangle)dynArgs.sender; 
	
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	double PVValue = 0;
        double PVEUHI = 0;
        double PVEULO = 0;

	string tagName = Area.Variable[0] + "/PVEUHI";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEUHI = dbValue;
             
	}

	tagName = Area.Variable[0] + "/PVEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEULO = dbValue;
             
	}
	
	tagName = Area.Variable[0] + "/PV";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
             PVValue = dbValue;

             if(PVEUHI != PVEULO)
                {
                    double PVScale = PVValue/(PVEUHI - PVEULO);
                    PVBar.Height = (334.00 - 58.00) * PVScale;
                    PVBar.VerticalPosition = 334.00 - PVBar.Height;
                }     
	}
	else
        {
             PVBar.VerticalPosition = 334.00;
             PVBar.Height = 0;
        }

	return; 
}//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd7_PMANLIN_Line16_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawLine PVBlack = (DrawLine)dynArgs.sender; 
   
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	double PVValue = 0;
	
	String tagName = Area.Variable[0] + "/PV";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
             if(dbValue == 0)
                {
                    PVBlack.EdgeColor = Color.Cyan;
                }
             else
                {
                    PVBlack.EdgeColor = Color.Black;
                }
	}
	else
        {
             PVBlack.EdgeColor = Color.Black;
        }

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd7_PMANLIN_LinePVTV_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawLine LinePVTV = (DrawLine)dynArgs.sender; 


	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	double PVValue = 0;
        double PVEXEH = 0;
        double PVEXEL = 0;

	string tagName = Area.Variable[0] + "/PVEXEH";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEXEH = dbValue;
             
	}

	tagName = Area.Variable[0] + "/PVEXEL";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEXEL = dbValue;
             
	}
	
	tagName = Area.Variable[0] + "/PVTV";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
             PVValue = dbValue;
             if(PVEXEH != PVEXEL)
                {
                      double PVScale = PVValue/(PVEXEH - PVEXEL);
                      LinePVTV.VerticalPosition = 334 - (334 - 58) * PVScale;
                }   
	}
	else
             LinePVTV.VerticalPosition = 334;
   
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd7_PMANLIN_TagName_OnDynAnimation(Object sender, EventArgs e)
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
public void gd7_PMANLIN_PV_OnDynAnimation(Object sender, EventArgs e)
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

          if(PV.Variable[0] == "1")

            {
                PV.ForegroundColor = Color.White;
            }

          else

            {
                PV.ForegroundColor = Color.Cyan;
            }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd7_PMANLIN_PV_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PV = (DrawText)dynArgs.sender; 
   
    PV.ForegroundColor = Color.Cyan; 
    PV.Variable[0] = "0";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd7_PMANLIN_PVTV_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVTV = (DrawText)dynArgs.sender;
 
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
	
	tagName = Area.Variable[0] + "/PVTV";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		PVTV.Caption = dbValue.ToString(strDigit);
	}
	else
		PVTV.Caption = "##.#";

          if(PVTV.Variable[0] == "1")

            {
                PVTV.ForegroundColor = Color.White;
            }

          else

            {
                PVTV.ForegroundColor = Color.Cyan;
            }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd7_PMANLIN_PVTV_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVTV = (DrawText)dynArgs.sender; 

    PVTV.ForegroundColor = Color.Cyan; 
    PVTV.Variable[0] = "0";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd7_PMANLIN_Rect9_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 
   
    R_tagname.Visible = true;
    R_tagname.ForegroundColor = Color.Black;
    R_tagname.EdgeColor = Color.Black;
           DrawArea p = (DrawArea)(Area.Parent);
           p.Variable[1] = "0";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void gd7_PMANLIN_Rect9_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 

           DrawArea pic = (DrawArea)(Area.Parent.Parent);

           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd7_PMANLIN_Rect9_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 

           DrawArea p = (DrawArea)(Area.Parent);
           if(p.Variable[1] == "1")
              {
                    R_tagname.ForegroundColor = Color.Blue;
                    R_tagname.EdgeColor = Color.White;
              }
           else
              {
                    R_tagname.ForegroundColor = Color.Black;
                    R_tagname.EdgeColor = Color.Black;

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
 
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd7_PMANLIN_Rect10_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect10 = (DrawRectangle)dynArgs.sender; 
   
    Rect10.Visible = true;
    Rect10.ForegroundColor = Color.Black;
    Rect10.EdgeColor = Color.Black;
           DrawArea p = (DrawArea)(Area.Parent);
           p.Variable[1] = "0";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void gd7_PMANLIN_Rect10_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect10 = (DrawRectangle)dynArgs.sender; 

    DrawText PVTV = (DrawText)Area.GetDrawObj("PVTV");
    PVTV.Variable[0] = "1";
    DrawText PV = (DrawText)Area.GetDrawObj("PV");
    PV.Variable[0] = "0";

    if(PVTV.Visible == true)

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
				CommonFunction.MoveControl(Area,TB,(int)(Rect10.VerticalPosition - 40),(int)(Rect10.HorizontalPosition));		
				obj = CommonFunction.GetLabelOfControl(TB);
				if(obj != null)
				{
					ControlLabel lab = (ControlLabel)obj;
					//给TB传递参数：
					lab.Variable[0] = Area.Variable[0] + "/PVTV";
                                      
				}
			}
		}
	}

    DrawArea pic = (DrawArea)(Area.Parent.Parent); 
           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd7_PMANLIN_Rect10_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect10 = (DrawRectangle)dynArgs.sender; 

    DrawText PVTV = (DrawText)Area.GetDrawObj("PVTV");
    DrawArea p = (DrawArea)(Area.Parent);

			if(PVTV.Variable[0] == "1" && p.Variable[1] == "1")
			{
		 		Rect10.ForegroundColor = Color.Blue;
                                Rect10.EdgeColor = Color.White;                                   
			}
                        else
			{
		 		Rect10.ForegroundColor = Color.Black;
                                Rect10.EdgeColor = Color.Black; 
                                PVTV.Variable[0] = "0";                                  
			}


    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd7_PMANLIN_Rect11_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect11 = (DrawRectangle)dynArgs.sender; 
   
    Rect11.Visible = true;
    Rect11.ForegroundColor = Color.Black;
    Rect11.EdgeColor = Color.Black;
           DrawArea p = (DrawArea)(Area.Parent);
           p.Variable[1] = "0";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void gd7_PMANLIN_Rect11_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect11 = (DrawRectangle)dynArgs.sender; 
   
           DrawArea pic = (DrawArea)(Area.Parent.Parent);

           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

    DrawText PV = (DrawText)Area.GetDrawObj("PV");
    PV.Variable[0] = "1";
    DrawText PVTV = (DrawText)Area.GetDrawObj("PVTV");
    PVTV.Variable[0] = "0";
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
				CommonFunction.MoveControl(Area,TB,(int)(Rect11.VerticalPosition)-40,(int)(Rect11.HorizontalPosition));
			
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
public void gd7_PMANLIN_Rect11_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect11 = (DrawRectangle)dynArgs.sender; 

    DrawText PV = (DrawText)Area.GetDrawObj("PV");
    DrawArea p = (DrawArea)(Area.Parent);

			if(PV.Variable[0] == "1" && p.Variable[1] == "1")
			{
		 		Rect11.ForegroundColor = Color.Blue;
                                Rect11.EdgeColor = Color.White;                                   
			}
                        else
			{
		 		Rect11.ForegroundColor = Color.Black;
                                Rect11.EdgeColor = Color.Black;
                                PV.Variable[0] = "0";                                   
			}

    return; 
}
//Do not remove or update this comment
//Event Delegate:KeyEventHandler 
//Event Handler:KeyUp 
public void gd7_PMANLIN_TB_KeyUp(Object sender, KeyEventArgs e)
{
   TextBox TB = (TextBox)sender; 

   DrawArea Area = CommonFunction.GetThisDrawArea(TB);

     double dbValue = 0;
     int nValue = 0;
     bool bValue = false;
     int nDataType = 0;

        double PVEXEH = 0;
        double PVEXEL = 0;
        double PVEUHI = 0;
        double PVEULO = 0;

	string tagName = Area.Variable[0] + "/PVEXEH";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEXEH = dbValue;             
	}

	tagName = Area.Variable[0] + "/PVEXEL";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEXEL = dbValue;             
	}

	tagName = Area.Variable[0] + "/PVEUHI";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEUHI = dbValue;        
	}

	tagName = Area.Variable[0] + "/PVEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEULO = dbValue;             
	}

	switch ( e.KeyData )
	{
	case Keys.Enter:

		if(TB.Text == "" || TB.Text == null)

		{
			TB.Visible = false;
			TB.Enabled = false;
                        DrawText P = (DrawText)Area.GetDrawObj("PV");
                        P.Variable[0] = "0";
                        DrawText V = (DrawText)Area.GetDrawObj("PVTV");
                        V.Variable[0] = "0";
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
		             string tag=lab.Variable[0];
                             bool PV = tagName.Contains("PV");
                             bool PVTV = tagName.Contains("PVTV");
                             if(PV == true)
                               {

                                    if(dbPVValue <= PVEUHI && dbPVValue >= PVEULO)
                                       {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                       }
                                    else
                                       {
				          CommonFunction._ProjectRelated.Var[1] = "LMT";
                                       }
                               }


                             if(PVTV == true)
                               {
	                 	  if(dbPVValue <= PVEXEH && dbPVValue >= PVEXEL)

				   {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                   }
	                	  else 
                                    {
                                        CommonFunction._ProjectRelated.Var[1] = "LMT";
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
CommonFunction._ProjectRelated.Var[1] = "";
    DrawText P1 = (DrawText)Area.GetDrawObj("PV");
    P1.Variable[0] = "0";
    DrawText V1 = (DrawText)Area.GetDrawObj("PVTV");
    V1.Variable[0] = "0";
    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd7_PMPID_OnDynInitialize(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 
 
	Picture pic = CommonFunction.GetThisPicture(Area);
	if(pic != null)
	{  
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
				TB.Visible = false;
				TB.Focus();
			}
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
//Event Handler:OnDynClick 
public void gd7_PMPID_OnDynClick(Object sender, EventArgs e)
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
public void gd7_PMPID_KeyUp(Object sender, KeyEventArgs e)
{
   TextBox TB = (TextBox)sender; 
   DrawArea Area = CommonFunction.GetThisDrawArea(TB);

     double dbValue = 0;
     int nValue = 0;
     bool bValue = false;
     int nDataType = 0;

        double OPHI = 0;
        double OPLO = 0;
        double SPEUHI = 0;
        double SPEULO = 0;
        double PVEUHI = 0;
        double PVEULO = 0;

	string tagName = Area.Variable[0] + "/OPHI";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     OPHI = dbValue;             
	}

	tagName = Area.Variable[0] + "/OPLO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     OPLO = dbValue;             
	}

	tagName = Area.Variable[0] + "/SPEUHI";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     SPEUHI = dbValue;             
	}

	tagName = Area.Variable[0] + "/SPEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     SPEULO = dbValue;             
	}

	tagName = Area.Variable[0] + "/PVEUHI";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEUHI = dbValue;        
	}

	tagName = Area.Variable[0] + "/PVEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEULO = dbValue;             
	}

     double dbValue1 = 0;
     int nValue1 = 0;
     bool bValue1 = false;
     int nDataType1 = 0;
     string MODE = Area.Variable[0] + "/MODE";
     bool ret1 = CommonFunction.GetValueWithType(MODE,ref dbValue1,ref nValue1,ref bValue1,ref nDataType1);

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
		             string tag=lab.Variable[0];

                             //PV值只有在MODE是MAN的时候才可以改变
                             bool V = tag.Contains("PV");
                             bool O = tag.Contains("OP");
                             bool S = tag.Contains("SP");
                             if(V == true && ret1)
                               {
                                    if(dbPVValue<=PVEUHI && dbPVValue>=PVEULO)
                                       {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                       }
                                    else
                                       {
				          CommonFunction._ProjectRelated.Var[1] = "LMT";
                                       }
                               }

                             if(O == true && ret1)
                               {//OP值只有在MODE是MAN的时候才可以改变
	                 	  if(dbValue1==1)
                                   {
                                    if(dbPVValue<=OPHI && dbPVValue>=OPLO)
                                       {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                       }
                                    else
                                      {
				          CommonFunction._ProjectRelated.Var[1] = "LMT";
                                       }
                                    }
	                	  else 
                                    {
                                        CommonFunction._ProjectRelated.Var[1] = "MODE ERROR";

                                    }
                               }

                             if(S == true && ret1)
                               {//SP值只有在MODE是AUTO的时候才可以改变
                                if(dbValue1==2)
                                 {
	                 	  if(dbPVValue<=SPEUHI && dbPVValue>=SPEULO)

				   {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                   }
	                	  else 
                                    {
                                        CommonFunction._ProjectRelated.Var[1] = "LMT";
                                    }
                                  }
	                	  else 
                                    {
                                        CommonFunction._ProjectRelated.Var[1] = "MODE ERROR";

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

CommonFunction._ProjectRelated.Var[1] = "";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd7_PMPID_ALM_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText ALM = (DrawText)dynArgs.sender; 
   
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
	
	tagName = Area.Variable[0] + "/PVHLFL";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
              string alm = dbValue.ToString(strDigit);

		if(alm == "0.00")

                   {ALM.Caption = "";}

		if(alm == "1.00")

                   {ALM.Caption = "HP";}

		if(alm == "2.00")

                   {ALM.Caption = "2HP";}

		if(alm == "-1.00")

                   {ALM.Caption = "LP";}

		if(alm == "-2.00")

                   {ALM.Caption = "2LP";}
	}
	else
		ALM.Caption = "";
        	

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd7_PMPID_OPBar_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawLine OPBar = (DrawLine)dynArgs.sender; 
   
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	double OPValue = 0;
        double OPHI = 0;
        double OPLO = 0;

	string tagName = Area.Variable[0] + "/OPHI";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     OPHI = dbValue;
             
	}

	tagName = Area.Variable[0] + "/OPLO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     OPLO = dbValue;
             
	}
	
	tagName = Area.Variable[0] + "/OP";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
             OPValue = dbValue;
             double OPScale = OPValue/(OPHI - OPLO);
             OPBar.EndY = 334 - (334 - 58) * OPScale;    
	}
	else
             OPBar.EndY = 334;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd7_PMPID_PVBlack_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawLine PVBlack = (DrawLine)dynArgs.sender; 
   
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	double PVValue = 0;
	
	String tagName = Area.Variable[0] + "/PV";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
             if(dbValue == 0)
                {
                    PVBlack.EdgeColor = Color.Cyan;
                }
             else
                {
                    PVBlack.EdgeColor = Color.Black;
                }
	}
	else
        {
             PVBlack.EdgeColor = Color.Black;
        }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd7_PMPID_SPLine_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawLine SPLine = (DrawLine)dynArgs.sender; 

	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	double SPValue = 0;
        double SPEUHI = 0;
        double SPEULO = 0;

	string tagName = Area.Variable[0] + "/SPEUHI";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     SPEUHI = dbValue;
             
	}

	tagName = Area.Variable[0] + "/SPEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     SPEULO = dbValue;
             
	}
	
	tagName = Area.Variable[0] + "/SP";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
             SPValue = dbValue;
             double SPScale = SPValue/(SPEUHI - SPEULO);
             SPLine.VerticalPosition = 334 - (334 - 58) * SPScale;    
	}
	else
             SPLine.VerticalPosition = 334;
   
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd7_PMPID_PVBar_OnDynAnimation(Object sender, EventArgs e)	//PVBar
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawRectangle PVBar = (DrawRectangle)dynArgs.sender; 
	
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	double PVValue = 0;
        double PVEUHI = 0;
        double PVEULO = 0;

	string tagName = Area.Variable[0] + "/PVEUHI";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEUHI = dbValue;
             
	}

	tagName = Area.Variable[0] + "/PVEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEULO = dbValue;
             
	}
	
	tagName = Area.Variable[0] + "/PV";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
             PVValue = dbValue;
             double PVScale = PVValue/(PVEUHI - PVEULO);
             PVBar.Height = (334.00 - 58.00) * PVScale;
             PVBar.VerticalPosition = 334.00 - PVBar.Height;    
	}
	else
        {
             PVBar.VerticalPosition = 334.00;
             PVBar.Height = 0;
        }

	return; 
}//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd7_PMPID_MODE_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText MODE = (DrawText)dynArgs.sender; 

    DrawRectangle Rect = (DrawRectangle)Area.GetDrawObj("Rect_MODE");  
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	int nDigit = 2;
	string tagName = Area.Variable[0] + "/MODE";

	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
            {
                if(dbValue == 1)
                  {
                      MODE.Caption = "MAN";
                      MODE.ForegroundColor = Color.Black;
                      Rect.ForegroundColor = Color.Yellow;
                  }
                if(dbValue == 2)
                  {
                      MODE.Caption = "AUTO";
                      MODE.ForegroundColor = Color.Cyan;
                      Rect.ForegroundColor = Color.Black;
                  }
                if(dbValue == 3)
                  {
                      MODE.Caption = "CAS";
                      MODE.ForegroundColor = Color.Black;
                      Rect.ForegroundColor = Color.Cyan;
                  }
            }
       else
            {MODE.Caption = "###";}

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void gd7_PMPID_Rect_MODE_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect_MODE = (DrawRectangle)dynArgs.sender; 

           DrawArea pic = (DrawArea)(Area.Parent.Parent);

           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

           DrawArea p = (DrawArea)(Area.Parent.Parent);
           DrawArea G = (DrawArea)p.GetDrawObj("TDC3000_Groupfaceplate");
           G.Visible = true;
           G.Variable[0] = Area.Variable[0];

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd7_PMPID_Unit_OnDynAnimation(Object sender, EventArgs e)
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
public void gd7_PMPID_TagName_OnDynAnimation(Object sender, EventArgs e)
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
public void gd7_PMPID_PV_OnDynAnimation(Object sender, EventArgs e)
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


          if(PV.Variable[0] == "1")

            {
                PV.ForegroundColor = Color.White;
            }

          else

            {
                PV.ForegroundColor = Color.Cyan;
            }

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd7_PMPID_PV_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PV = (DrawText)dynArgs.sender; 
   
    PV.ForegroundColor = Color.Cyan;
    PV.Variable[0] = "0";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd7_PMPID_SP_OnDynAnimation(Object sender, EventArgs e)
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

          if(SP.Variable[0] == "1")

            {
                SP.ForegroundColor = Color.White;
            }

          else

            {
                SP.ForegroundColor = Color.Cyan;
            }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd7_PMPID_SP_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText SP = (DrawText)dynArgs.sender; 

    SP.ForegroundColor = Color.Cyan; 
    SP.Variable[0] = "0";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd7_PMPID_OP_OnDynAnimation(Object sender, EventArgs e)
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

          if(OP.Variable[0] == "1")

            {
                OP.ForegroundColor = Color.White;
            }

          else

            {
                OP.ForegroundColor = Color.Yellow;
            }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd7_PMPID_OP_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText OP = (DrawText)dynArgs.sender; 
 
    OP.ForegroundColor = Color.Yellow; 
    OP.Variable[0] = "0";

    return; 
}


//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd7_PMPID_R_tagname_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 
   
    R_tagname.Visible = true;
    R_tagname.ForegroundColor = Color.Black;
    R_tagname.EdgeColor = Color.Black;
           DrawArea p = (DrawArea)(Area.Parent);
           p.Variable[1] = "0";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void gd7_PMPID_R_tagname_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 
   
           DrawArea pic = (DrawArea)(Area.Parent.Parent);

           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd7_PMPID_R_tagname_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 

           DrawArea p = (DrawArea)(Area.Parent);
           if(p.Variable[1] == "1")
              {
                    R_tagname.ForegroundColor = Color.Blue;
                    R_tagname.EdgeColor = Color.White;
              }
           else
              {
                    R_tagname.ForegroundColor = Color.Black;
                    R_tagname.EdgeColor = Color.Black;

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
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd7_PMPID_Rect7_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect7 = (DrawRectangle)dynArgs.sender; 
   
    Rect7.Visible = true;
    Rect7.ForegroundColor = Color.Black;
    Rect7.EdgeColor = Color.Black;
           DrawArea p = (DrawArea)(Area.Parent);
           p.Variable[1] = "0";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void gd7_PMPID_Rect7_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect7 = (DrawRectangle)dynArgs.sender; 
   
           DrawArea pic = (DrawArea)(Area.Parent.Parent);

           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

    DrawText SP = (DrawText)Area.GetDrawObj("SP");
    SP.Variable[0] = "1";
    DrawText PV = (DrawText)Area.GetDrawObj("PV");
    PV.Variable[0] = "0";
    DrawText OP = (DrawText)Area.GetDrawObj("OP");
    OP.Variable[0] = "0";

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
				CommonFunction.MoveControl(Area,TB,(int)(Rect7.VerticalPosition - 40),(int)(Rect7.HorizontalPosition));		
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
public void gd7_PMPID_Rect7_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect7 = (DrawRectangle)dynArgs.sender; 

    DrawText SP = (DrawText)Area.GetDrawObj("SP");
    DrawArea p = (DrawArea)(Area.Parent);

			if(SP.Variable[0] == "1" && p.Variable[1] == "1")
			{
		 		Rect7.ForegroundColor = Color.Blue;
                                Rect7.EdgeColor = Color.White;                                   
			}
                        else
			{
		 		Rect7.ForegroundColor = Color.Black;
                                Rect7.EdgeColor = Color.Black; 
                                SP.Variable[0] = "0";                                  
			}
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd7_PMPID_Rect8_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect8 = (DrawRectangle)dynArgs.sender; 
   
    Rect8.Visible = true;
    Rect8.ForegroundColor = Color.Black;
    Rect8.EdgeColor = Color.Black;
           DrawArea p = (DrawArea)(Area.Parent);
           p.Variable[1] = "0";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void gd7_PMPID_Rect8_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect8 = (DrawRectangle)dynArgs.sender; 
   
           DrawArea pic = (DrawArea)(Area.Parent.Parent);

           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

    DrawText SP = (DrawText)Area.GetDrawObj("SP");
    SP.Variable[0] = "0";
    DrawText PV = (DrawText)Area.GetDrawObj("PV");
    PV.Variable[0] = "1";
    DrawText OP = (DrawText)Area.GetDrawObj("OP");
    OP.Variable[0] = "0";

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
				CommonFunction.MoveControl(Area,TB,(int)(Rect8.VerticalPosition)-40,(int)(Rect8.HorizontalPosition));
			
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
public void gd7_PMPID_Rect8_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect8 = (DrawRectangle)dynArgs.sender; 

    DrawText PV = (DrawText)Area.GetDrawObj("PV");
    DrawArea p = (DrawArea)(Area.Parent);

			if(PV.Variable[0] == "1" && p.Variable[1] == "1")
			{
		 		Rect8.ForegroundColor = Color.Blue;
                                Rect8.EdgeColor = Color.White;                                   
			}
                        else
			{
		 		Rect8.ForegroundColor = Color.Black;
                                Rect8.EdgeColor = Color.Black;  
                                PV.Variable[0] = "0";                                 
			}

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd7_PMPID_Rect9_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect9 = (DrawRectangle)dynArgs.sender; 
   
    Rect9.Visible = true;
    Rect9.ForegroundColor = Color.Black;
    Rect9.EdgeColor = Color.Black;
           DrawArea p = (DrawArea)(Area.Parent);
           p.Variable[1] = "0";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void gd7_PMPID_Rect9_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect9 = (DrawRectangle)dynArgs.sender; 
   
           DrawArea pic = (DrawArea)(Area.Parent.Parent);

           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

    DrawText SP = (DrawText)Area.GetDrawObj("SP");
    SP.Variable[0] = "0";
    DrawText PV = (DrawText)Area.GetDrawObj("PV");
    PV.Variable[0] = "0";
    DrawText OP = (DrawText)Area.GetDrawObj("OP");
    OP.Variable[0] = "1";

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
			        CommonFunction.MoveControl(Area,TB,(int)(Rect9.VerticalPosition)-40,(int)(Rect9.HorizontalPosition));
				
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
public void gd7_PMPID_Rect9_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect9 = (DrawRectangle)dynArgs.sender; 

    DrawText OP = (DrawText)Area.GetDrawObj("OP");
    DrawArea p = (DrawArea)(Area.Parent);

			if(OP.Variable[0] == "1" && p.Variable[1] == "1")
			{
		 		Rect9.ForegroundColor = Color.Blue;
                                Rect9.EdgeColor = Color.White;                                   
			}
                        else
			{
		 		Rect9.ForegroundColor = Color.Black;
                                Rect9.EdgeColor = Color.Black; 
                                OP.Variable[0] = "0";                                  
			}

    return; 
}
//Do not remove or update this comment
//Event Delegate:KeyEventHandler 
//Event Handler:KeyUp 
public void gd7_PMPID_TB_KeyUp(Object sender, KeyEventArgs e)
{
   TextBox TB = (TextBox)sender; 

   DrawArea Area = CommonFunction.GetThisDrawArea(TB);

     double dbValue = 0;
     int nValue = 0;
     bool bValue = false;
     int nDataType = 0;

        double OPHI = 0;
        double OPLO = 0;
        double SPEUHI = 0;
        double SPEULO = 0;
        double PVEUHI = 0;
        double PVEULO = 0;

	string tagName = Area.Variable[0] + "/OPHI";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     OPHI = dbValue;             
	}

	tagName = Area.Variable[0] + "/OPLO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     OPLO = dbValue;             
	}

	tagName = Area.Variable[0] + "/SPEUHI";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     SPEUHI = dbValue;             
	}

	tagName = Area.Variable[0] + "/SPEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     SPEULO = dbValue;             
	}

	tagName = Area.Variable[0] + "/PVEUHI";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEUHI = dbValue;        
	}

	tagName = Area.Variable[0] + "/PVEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEULO = dbValue;             
	}

     double dbValue1 = 0;
     int nValue1 = 0;
     bool bValue1 = false;
     int nDataType1 = 0;
     string MODE = Area.Variable[0] + "/MODE";
     bool ret1 = CommonFunction.GetValueWithType(MODE,ref dbValue1,ref nValue1,ref bValue1,ref nDataType1);

	switch ( e.KeyData )
	{
	case Keys.Enter:

		if(TB.Text == "" || TB.Text == null)

		{
			TB.Visible = false;
			TB.Enabled = false;
                        DrawText P = (DrawText)Area.GetDrawObj("PV");
                        P.Variable[0] = "0";
                        DrawText OP = (DrawText)Area.GetDrawObj("OP");
                        OP.Variable[0] = "0";
                        DrawText SP = (DrawText)Area.GetDrawObj("SP");
                        SP.Variable[0] = "0";
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
		             string tag=lab.Variable[0];

                             //PV值只有在MODE是MAN的时候才可以改变
                             bool V = tag.Contains("PV");
                             bool O = tag.Contains("OP");
                             bool S = tag.Contains("SP");
                             if(V == true && ret1)
                               {
                                    if(dbPVValue<=PVEUHI && dbPVValue>=PVEULO)
                                       {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                       }
                                    else
                                       {
				          CommonFunction._ProjectRelated.Var[1] = "LMT";
                                       }
                               }

                             if(O == true && ret1)
                               {//OP值只有在MODE是MAN的时候才可以改变
	                 	  if(dbValue1==1)
                                   {
                                    if(dbPVValue<=OPHI && dbPVValue>=OPLO)
                                       {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                       }
                                    else
                                      {
				          CommonFunction._ProjectRelated.Var[1] = "LMT";
                                       }
                                    }
	                	  else 
                                    {
                                        CommonFunction._ProjectRelated.Var[1] = "MODE ERROR";

                                    }
                               }

                             if(S == true && ret1)
                               {//SP值只有在MODE是AUTO的时候才可以改变
                                if(dbValue1==2)
                                 {
	                 	  if(dbPVValue<=SPEUHI && dbPVValue>=SPEULO)

				   {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                   }
	                	  else 
                                    {
                                        CommonFunction._ProjectRelated.Var[1] = "LMT";
                                    }
                                  }
	                	  else 
                                    {
                                        CommonFunction._ProjectRelated.Var[1] = "MODE ERROR";

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
CommonFunction._ProjectRelated.Var[1] = "";
    DrawText P1 = (DrawText)Area.GetDrawObj("PV");
    P1.Variable[0] = "0";
    DrawText OP1 = (DrawText)Area.GetDrawObj("OP");
    OP1.Variable[0] = "0";
    DrawText SP1 = (DrawText)Area.GetDrawObj("SP");
    SP1.Variable[0] = "0";
    return; 
}

//Do not remove or update this comment
//Event Delegate:KeyEventHandler 
//Event Handler:KeyUp 
public void TDC3000_Groupfaceplate_KeyUp(Object sender, KeyEventArgs e)
{
   DrawArea Area = (DrawArea)sender; 

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
	                             DrawText NORM = (DrawText)Area.GetDrawObj("NORM");

	                             NORM.ForegroundColor = Color.Lime;
                                }
                               if(Area.Variable[1] == "5")
                                {
	                             DrawText PROG = (DrawText)Area.GetDrawObj("PROG");

	                             PROG.ForegroundColor = Color.Lime;
                                }

                          Area.Variable[1] = "0";
                          Area.Visible = false;
	                 break;
                      } 
         }
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void TDC3000_Groupfaceplate_OnDynInitialize(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 
 
   if(Area.BReference)
     {
        Area.Enabled = true; 
     }  
////////////////////////////////////////////////////////////////////////////////处理变色
////////////////////////////////////////////////////////////////////////////////处理变色

	DrawText MAN1 = (DrawText)Area.GetDrawObj("MAN");
	DrawText AUTO1 = (DrawText)Area.GetDrawObj("AUTO");
	DrawText CAS1 = (DrawText)Area.GetDrawObj("CAS");
	DrawText NORM1 = (DrawText)Area.GetDrawObj("NORM");
	DrawText PROG1 = (DrawText)Area.GetDrawObj("PROG");

	MAN1.ForegroundColor = Color.Lime;
	AUTO1.ForegroundColor = Color.Lime;
	CAS1.ForegroundColor = Color.Lime;
	NORM1.ForegroundColor = Color.Lime;
	PROG1.ForegroundColor = Color.Lime;

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
                      MAN1.ForegroundColor = Color.Cyan;
                    }	
		else if(nValue == 2)

		   {
                      AUTO1.ForegroundColor = Color.Cyan;
                    }
                else if(nValue == 3)

		   {
                      CAS1.ForegroundColor = Color.Cyan;
                    }
	    }    

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void TDC3000_Groupfaceplate_OnDynAnimation(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 

////////////////////////////////////////////////////////////////////////////////处理变色
////////////////////////////////////////////////////////////////////////////////处理变色

	DrawText MAN2 = (DrawText)Area.GetDrawObj("MAN");
	DrawText AUTO2 = (DrawText)Area.GetDrawObj("AUTO");
	DrawText CAS2 = (DrawText)Area.GetDrawObj("CAS");
	DrawText NORM2 = (DrawText)Area.GetDrawObj("NORM");
	DrawText PROG2 = (DrawText)Area.GetDrawObj("PROG");

	MAN2.ForegroundColor = Color.Lime;
	AUTO2.ForegroundColor = Color.Lime;
	CAS2.ForegroundColor = Color.Lime;
	NORM2.ForegroundColor = Color.Lime;
	PROG2.ForegroundColor = Color.Lime;

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
			 MAN2.ForegroundColor = Color.Cyan;

		 if(Area.Variable[1] == "2")
		 {
			 AUTO2.ForegroundColor = Color.White;
		 }
		 else if(Area.Variable[1] == "3")
		 {
			 CAS2.ForegroundColor = Color.White;
		 }

	 }
	 if(dbValue == 2)
	 {
			 AUTO2.ForegroundColor = Color.Cyan;

		 if(Area.Variable[1] == "1")
		 {
			 MAN2.ForegroundColor = Color.White;
		 }
		 else if(Area.Variable[1] == "3")
		 {
			 CAS2.ForegroundColor = Color.White;
		 }
	 }
	 if(dbValue == 3)
	 {
			 CAS2.ForegroundColor = Color.Cyan;

		 if(Area.Variable[1] == "1")
		 {
			 MAN2.ForegroundColor = Color.White;
		 }
		 else if(Area.Variable[1] == "2")
		 {
			 AUTO2.ForegroundColor = Color.White;
		 }
	 }
	 }
     if(Area.Variable[1] == "4")
     {
	 NORM2.ForegroundColor = Color.White;
     }
 
     if(Area.Variable[1] == "5")
     {
	 PROG2.ForegroundColor = Color.White;  
     }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void TDC3000_Groupfaceplate_ENTER_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle ENTER = (DrawRectangle)dynArgs.sender; 
   
   string tagName = Area.Variable[0] + "/MODE";

     double dbValue = 0;
     int nValue = 0;
     bool bValue = false;
     int nDataType = 0;

     string MODE = Area.Variable[0] + "/MODE";
     bool ret = CommonFunction.GetValueWithType(MODE,ref dbValue,ref nValue,ref bValue,ref nDataType);
     
     if(ret)
      
           {
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
	               DrawText NORM = (DrawText)Area.GetDrawObj("NORM");
	               NORM.ForegroundColor = Color.Lime;
                  }
               if(Area.Variable[1] == "5")
                  {
	               DrawText PROG = (DrawText)Area.GetDrawObj("PROG");
	               PROG.ForegroundColor = Color.Lime;
               }

               Area.Variable[1] = "0";
               Area.Visible = false;
         }
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void TDC3000_Groupfaceplate_NORM_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText NORM = (DrawText)dynArgs.sender; 
   
    Area.Variable[1] = "4";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void TDC3000_Groupfaceplate_MAN_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText MAN = (DrawText)dynArgs.sender; 
   
    Area.Variable[1] = "1";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void TDC3000_Groupfaceplate_PROG_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PROG = (DrawText)dynArgs.sender; 
   
    Area.Variable[1] = "5";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void TDC3000_Groupfaceplate_CAS_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText CAS = (DrawText)dynArgs.sender; 
   
    Area.Variable[1] = "3";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void TDC3000_Groupfaceplate_AUTO_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText AUTO = (DrawText)dynArgs.sender; 
   
    Area.Variable[1] = "2";

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

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd2_OnDynInitialize(Object sender, EventArgs e)
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
public void gd2_OnDynAnimation(Object sender, EventArgs e)
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

             else 

                {
                     PMDIGCOM.Visible = false;
                     PMPID.Visible = false;
                     PMANLIN.Visible = false;
                }

        }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd2_PMDIGCOM_OnDynInitialize(Object sender, EventArgs e)
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
public void gd2_PMDIGCOM_Rect_PVON_OnDynAnimation(Object sender, EventArgs e)
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
public void gd2_PMDIGCOM_OP_OnDynAnimation(Object sender, EventArgs e)
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
public void gd2_PMDIGCOM_Rect_OFF_OnDynAnimation(Object sender, EventArgs e)
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
public void gd2_PMDIGCOM_Rect_ON_OnDynAnimation(Object sender, EventArgs e)
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
public void gd2_PMDIGCOM_Unit_OnDynAnimation(Object sender, EventArgs e)
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
public void gd2_PMDIGCOM_TagName_OnDynAnimation(Object sender, EventArgs e)
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
//Event Handler:OnDynInitialize 
public void gd2_PMDIGCOM_Rect9_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 
   
    R_tagname.Visible = true;
    R_tagname.ForegroundColor = Color.Black;
    R_tagname.EdgeColor = Color.Black;
           DrawArea p = (DrawArea)(Area.Parent);
           p.Variable[1] = "0";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void gd2_PMDIGCOM_Rect9_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 
   
           DrawArea pic = (DrawArea)(Area.Parent.Parent);

           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd2_PMDIGCOM_Rect9_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 

           DrawArea p = (DrawArea)(Area.Parent);
           if(p.Variable[1] == "1")
              {
                    R_tagname.ForegroundColor = Color.Blue;
                    R_tagname.EdgeColor = Color.White;
              }
           else
              {
                    R_tagname.ForegroundColor = Color.Black;
                    R_tagname.EdgeColor = Color.Black;
              }
 
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd2_PMANLIN_OnDynInitialize(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 
 
	Picture pic = CommonFunction.GetThisPicture(Area);
	if(pic != null)
	{  
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
				TB.Visible = false;
				TB.Focus();
			}
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
//Event Handler:OnDynClick 
public void gd2_PMANLIN_OnDynClick(Object sender, EventArgs e)
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
public void gd2_PMANLIN_KeyUp(Object sender, KeyEventArgs e)
{
   TextBox TB = (TextBox)sender; 

   DrawArea Area = CommonFunction.GetThisDrawArea(TB);

     double dbValue = 0;
     int nValue = 0;
     bool bValue = false;
     int nDataType = 0;

        double PVEXEH = 0;
        double PVEXEL = 0;
        double PVEUHI = 0;
        double PVEULO = 0;

	string tagName = Area.Variable[0] + "/PVEXEH";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEXEH = dbValue;             
	}

	tagName = Area.Variable[0] + "/PVEXEL";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEXEL = dbValue;             
	}

	tagName = Area.Variable[0] + "/PVEUHI";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEUHI = dbValue;        
	}

	tagName = Area.Variable[0] + "/PVEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEULO = dbValue;             
	}

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
		             string tag=lab.Variable[0];
                             bool PV = tagName.Contains("PV");
                             bool PVTV = tagName.Contains("PVTV");
                             if(PV == true)
                               {

                                    if(dbPVValue <= PVEUHI && dbPVValue >= PVEULO)
                                       {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                       }
                                    else
                                       {
				          CommonFunction._ProjectRelated.Var[1] = "LMT";
                                       }
                               }


                             if(PVTV == true)
                               {
	                 	  if(dbPVValue <= PVEXEH && dbPVValue >= PVEXEL)

				   {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                   }
	                	  else 
                                    {
                                        CommonFunction._ProjectRelated.Var[1] = "LMT";
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
CommonFunction._ProjectRelated.Var[1] = "";

    DrawText P1 = (DrawText)Area.GetDrawObj("PV");
    P1.Variable[0] = "0";
    DrawText V1 = (DrawText)Area.GetDrawObj("PVTV");
    V1.Variable[0] = "0";

    return; 
}



//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd2_PMANLIN_Rect8_OnDynAnimation(Object sender, EventArgs e)	//PVBar
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawRectangle PVBar = (DrawRectangle)dynArgs.sender; 
	
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	double PVValue = 0;
        double PVEUHI = 0;
        double PVEULO = 0;

	string tagName = Area.Variable[0] + "/PVEUHI";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEUHI = dbValue;
             
	}

	tagName = Area.Variable[0] + "/PVEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEULO = dbValue;
             
	}
	
	tagName = Area.Variable[0] + "/PV";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
             PVValue = dbValue;

             if(PVEUHI != PVEULO)
                {
                    double PVScale = PVValue/(PVEUHI - PVEULO);
                    PVBar.Height = (334.00 - 58.00) * PVScale;
                    PVBar.VerticalPosition = 334.00 - PVBar.Height;
                }     
	}
	else
        {
             PVBar.VerticalPosition = 334.00;
             PVBar.Height = 0;
        }

	return; 
}//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd2_PMANLIN_Line16_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawLine PVBlack = (DrawLine)dynArgs.sender; 
   
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	double PVValue = 0;
	
	String tagName = Area.Variable[0] + "/PV";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
             if(dbValue == 0)
                {
                    PVBlack.EdgeColor = Color.Cyan;
                }
             else
                {
                    PVBlack.EdgeColor = Color.Black;
                }
	}
	else
        {
             PVBlack.EdgeColor = Color.Black;
        }

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd2_PMANLIN_LinePVTV_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawLine LinePVTV = (DrawLine)dynArgs.sender; 


	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	double PVValue = 0;
        double PVEXEH = 0;
        double PVEXEL = 0;

	string tagName = Area.Variable[0] + "/PVEXEH";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEXEH = dbValue;
             
	}

	tagName = Area.Variable[0] + "/PVEXEL";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEXEL = dbValue;
             
	}
	
	tagName = Area.Variable[0] + "/PVTV";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
             PVValue = dbValue;
             if(PVEXEH != PVEXEL)
                {
                      double PVScale = PVValue/(PVEXEH - PVEXEL);
                      LinePVTV.VerticalPosition = 334 - (334 - 58) * PVScale;
                }   
	}
	else
             LinePVTV.VerticalPosition = 334;
   
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd2_PMANLIN_TagName_OnDynAnimation(Object sender, EventArgs e)
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
public void gd2_PMANLIN_PV_OnDynAnimation(Object sender, EventArgs e)
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

          if(PV.Variable[0] == "1")

            {
                PV.ForegroundColor = Color.White;
            }

          else

            {
                PV.ForegroundColor = Color.Cyan;
            }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd2_PMANLIN_PV_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PV = (DrawText)dynArgs.sender; 
   
    PV.ForegroundColor = Color.Cyan; 
    PV.Variable[0] = "0";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd2_PMANLIN_PVTV_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVTV = (DrawText)dynArgs.sender;
 
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
	
	tagName = Area.Variable[0] + "/PVTV";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		PVTV.Caption = dbValue.ToString(strDigit);
	}
	else
		PVTV.Caption = "##.#";

          if(PVTV.Variable[0] == "1")

            {
                PVTV.ForegroundColor = Color.White;
            }

          else

            {
                PVTV.ForegroundColor = Color.Cyan;
            }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd2_PMANLIN_PVTV_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVTV = (DrawText)dynArgs.sender; 

    PVTV.ForegroundColor = Color.Cyan; 
    PVTV.Variable[0] = "0";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd2_PMANLIN_Rect9_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 
   
    R_tagname.Visible = true;
    R_tagname.ForegroundColor = Color.Black;
    R_tagname.EdgeColor = Color.Black;
           DrawArea p = (DrawArea)(Area.Parent);
           p.Variable[1] = "0";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void gd2_PMANLIN_Rect9_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 

           DrawArea pic = (DrawArea)(Area.Parent.Parent);

           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd2_PMANLIN_Rect9_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 

           DrawArea p = (DrawArea)(Area.Parent);
           if(p.Variable[1] == "1")
              {
                    R_tagname.ForegroundColor = Color.Blue;
                    R_tagname.EdgeColor = Color.White;
              }
           else
              {
                    R_tagname.ForegroundColor = Color.Black;
                    R_tagname.EdgeColor = Color.Black;

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
 
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd2_PMANLIN_Rect10_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect10 = (DrawRectangle)dynArgs.sender; 
   
    Rect10.Visible = true;
    Rect10.ForegroundColor = Color.Black;
    Rect10.EdgeColor = Color.Black;
           DrawArea p = (DrawArea)(Area.Parent);
           p.Variable[1] = "0";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void gd2_PMANLIN_Rect10_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect10 = (DrawRectangle)dynArgs.sender; 

    DrawText PVTV = (DrawText)Area.GetDrawObj("PVTV");
    PVTV.Variable[0] = "1";
    DrawText PV = (DrawText)Area.GetDrawObj("PV");
    PV.Variable[0] = "0";

    if(PVTV.Visible == true)

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
				CommonFunction.MoveControl(Area,TB,(int)(Rect10.VerticalPosition - 40),(int)(Rect10.HorizontalPosition));		
				obj = CommonFunction.GetLabelOfControl(TB);
				if(obj != null)
				{
					ControlLabel lab = (ControlLabel)obj;
					//给TB传递参数：
					lab.Variable[0] = Area.Variable[0] + "/PVTV";
                                      
				}
			}
		}
	}

    DrawArea pic = (DrawArea)(Area.Parent.Parent); 
           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd2_PMANLIN_Rect10_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect10 = (DrawRectangle)dynArgs.sender; 

    DrawText PVTV = (DrawText)Area.GetDrawObj("PVTV");
    DrawArea p = (DrawArea)(Area.Parent);

			if(PVTV.Variable[0] == "1" && p.Variable[1] == "1")
			{
		 		Rect10.ForegroundColor = Color.Blue;
                                Rect10.EdgeColor = Color.White;                                   
			}
                        else
			{
		 		Rect10.ForegroundColor = Color.Black;
                                Rect10.EdgeColor = Color.Black; 
                                PVTV.Variable[0] = "0";                                  
			}


    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd2_PMANLIN_Rect11_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect11 = (DrawRectangle)dynArgs.sender; 
   
    Rect11.Visible = true;
    Rect11.ForegroundColor = Color.Black;
    Rect11.EdgeColor = Color.Black;
           DrawArea p = (DrawArea)(Area.Parent);
           p.Variable[1] = "0";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void gd2_PMANLIN_Rect11_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect11 = (DrawRectangle)dynArgs.sender; 
   
           DrawArea pic = (DrawArea)(Area.Parent.Parent);

           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

    DrawText PV = (DrawText)Area.GetDrawObj("PV");
    PV.Variable[0] = "1";
    DrawText PVTV = (DrawText)Area.GetDrawObj("PVTV");
    PVTV.Variable[0] = "0";
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
				CommonFunction.MoveControl(Area,TB,(int)(Rect11.VerticalPosition)-40,(int)(Rect11.HorizontalPosition));
			
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
public void gd2_PMANLIN_Rect11_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect11 = (DrawRectangle)dynArgs.sender; 

    DrawText PV = (DrawText)Area.GetDrawObj("PV");
    DrawArea p = (DrawArea)(Area.Parent);

			if(PV.Variable[0] == "1" && p.Variable[1] == "1")
			{
		 		Rect11.ForegroundColor = Color.Blue;
                                Rect11.EdgeColor = Color.White;                                   
			}
                        else
			{
		 		Rect11.ForegroundColor = Color.Black;
                                Rect11.EdgeColor = Color.Black;
                                PV.Variable[0] = "0";                                   
			}

    return; 
}
//Do not remove or update this comment
//Event Delegate:KeyEventHandler 
//Event Handler:KeyUp 
public void gd2_PMANLIN_TB_KeyUp(Object sender, KeyEventArgs e)
{
   TextBox TB = (TextBox)sender; 

   DrawArea Area = CommonFunction.GetThisDrawArea(TB);

     double dbValue = 0;
     int nValue = 0;
     bool bValue = false;
     int nDataType = 0;

        double PVEXEH = 0;
        double PVEXEL = 0;
        double PVEUHI = 0;
        double PVEULO = 0;

	string tagName = Area.Variable[0] + "/PVEXEH";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEXEH = dbValue;             
	}

	tagName = Area.Variable[0] + "/PVEXEL";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEXEL = dbValue;             
	}

	tagName = Area.Variable[0] + "/PVEUHI";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEUHI = dbValue;        
	}

	tagName = Area.Variable[0] + "/PVEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEULO = dbValue;             
	}

	switch ( e.KeyData )
	{
	case Keys.Enter:

		if(TB.Text == "" || TB.Text == null)

		{
			TB.Visible = false;
			TB.Enabled = false;
                        DrawText P = (DrawText)Area.GetDrawObj("PV");
                        P.Variable[0] = "0";
                        DrawText V = (DrawText)Area.GetDrawObj("PVTV");
                        V.Variable[0] = "0";
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
		             string tag=lab.Variable[0];
                             bool PV = tagName.Contains("PV");
                             bool PVTV = tagName.Contains("PVTV");
                             if(PV == true)
                               {

                                    if(dbPVValue <= PVEUHI && dbPVValue >= PVEULO)
                                       {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                       }
                                    else
                                       {
				          CommonFunction._ProjectRelated.Var[1] = "LMT";
                                       }
                               }


                             if(PVTV == true)
                               {
	                 	  if(dbPVValue <= PVEXEH && dbPVValue >= PVEXEL)

				   {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                   }
	                	  else 
                                    {
                                        CommonFunction._ProjectRelated.Var[1] = "LMT";
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
CommonFunction._ProjectRelated.Var[1] = "";
    DrawText P1 = (DrawText)Area.GetDrawObj("PV");
    P1.Variable[0] = "0";
    DrawText V1 = (DrawText)Area.GetDrawObj("PVTV");
    V1.Variable[0] = "0";
    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd2_PMPID_OnDynInitialize(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 
 
	Picture pic = CommonFunction.GetThisPicture(Area);
	if(pic != null)
	{  
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
				TB.Visible = false;
				TB.Focus();
			}
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
//Event Handler:OnDynClick 
public void gd2_PMPID_OnDynClick(Object sender, EventArgs e)
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
public void gd2_PMPID_KeyUp(Object sender, KeyEventArgs e)
{
   TextBox TB = (TextBox)sender; 
   DrawArea Area = CommonFunction.GetThisDrawArea(TB);

     double dbValue = 0;
     int nValue = 0;
     bool bValue = false;
     int nDataType = 0;

        double OPHI = 0;
        double OPLO = 0;
        double SPEUHI = 0;
        double SPEULO = 0;
        double PVEUHI = 0;
        double PVEULO = 0;

	string tagName = Area.Variable[0] + "/OPHI";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     OPHI = dbValue;             
	}

	tagName = Area.Variable[0] + "/OPLO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     OPLO = dbValue;             
	}

	tagName = Area.Variable[0] + "/SPEUHI";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     SPEUHI = dbValue;             
	}

	tagName = Area.Variable[0] + "/SPEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     SPEULO = dbValue;             
	}

	tagName = Area.Variable[0] + "/PVEUHI";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEUHI = dbValue;        
	}

	tagName = Area.Variable[0] + "/PVEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEULO = dbValue;             
	}

     double dbValue1 = 0;
     int nValue1 = 0;
     bool bValue1 = false;
     int nDataType1 = 0;
     string MODE = Area.Variable[0] + "/MODE";
     bool ret1 = CommonFunction.GetValueWithType(MODE,ref dbValue1,ref nValue1,ref bValue1,ref nDataType1);

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
		             string tag=lab.Variable[0];

                             //PV值只有在MODE是MAN的时候才可以改变
                             bool V = tag.Contains("PV");
                             bool O = tag.Contains("OP");
                             bool S = tag.Contains("SP");
                             if(V == true && ret1)
                               {
                                    if(dbPVValue<=PVEUHI && dbPVValue>=PVEULO)
                                       {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                       }
                                    else
                                       {
				          CommonFunction._ProjectRelated.Var[1] = "LMT";
                                       }
                               }

                             if(O == true && ret1)
                               {//OP值只有在MODE是MAN的时候才可以改变
	                 	  if(dbValue1==1)
                                   {
                                    if(dbPVValue<=OPHI && dbPVValue>=OPLO)
                                       {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                       }
                                    else
                                      {
				          CommonFunction._ProjectRelated.Var[1] = "LMT";
                                       }
                                    }
	                	  else 
                                    {
                                        CommonFunction._ProjectRelated.Var[1] = "MODE ERROR";

                                    }
                               }

                             if(S == true && ret1)
                               {//SP值只有在MODE是AUTO的时候才可以改变
                                if(dbValue1==2)
                                 {
	                 	  if(dbPVValue<=SPEUHI && dbPVValue>=SPEULO)

				   {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                   }
	                	  else 
                                    {
                                        CommonFunction._ProjectRelated.Var[1] = "LMT";
                                    }
                                  }
	                	  else 
                                    {
                                        CommonFunction._ProjectRelated.Var[1] = "MODE ERROR";

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

CommonFunction._ProjectRelated.Var[1] = "";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd2_PMPID_ALM_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText ALM = (DrawText)dynArgs.sender; 
   
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
	
	tagName = Area.Variable[0] + "/PVHLFL";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
              string alm = dbValue.ToString(strDigit);

		if(alm == "0.00")

                   {ALM.Caption = "";}

		if(alm == "1.00")

                   {ALM.Caption = "HP";}

		if(alm == "2.00")

                   {ALM.Caption = "2HP";}

		if(alm == "-1.00")

                   {ALM.Caption = "LP";}

		if(alm == "-2.00")

                   {ALM.Caption = "2LP";}
	}
	else
		ALM.Caption = "";
        	

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd2_PMPID_OPBar_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawLine OPBar = (DrawLine)dynArgs.sender; 
   
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	double OPValue = 0;
        double OPHI = 0;
        double OPLO = 0;

	string tagName = Area.Variable[0] + "/OPHI";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     OPHI = dbValue;
             
	}

	tagName = Area.Variable[0] + "/OPLO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     OPLO = dbValue;
             
	}
	
	tagName = Area.Variable[0] + "/OP";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
             OPValue = dbValue;
             double OPScale = OPValue/(OPHI - OPLO);
             OPBar.EndY = 334 - (334 - 58) * OPScale;    
	}
	else
             OPBar.EndY = 334;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd2_PMPID_PVBlack_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawLine PVBlack = (DrawLine)dynArgs.sender; 
   
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	double PVValue = 0;
	
	String tagName = Area.Variable[0] + "/PV";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
             if(dbValue == 0)
                {
                    PVBlack.EdgeColor = Color.Cyan;
                }
             else
                {
                    PVBlack.EdgeColor = Color.Black;
                }
	}
	else
        {
             PVBlack.EdgeColor = Color.Black;
        }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd2_PMPID_SPLine_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawLine SPLine = (DrawLine)dynArgs.sender; 

	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	double SPValue = 0;
        double SPEUHI = 0;
        double SPEULO = 0;

	string tagName = Area.Variable[0] + "/SPEUHI";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     SPEUHI = dbValue;
             
	}

	tagName = Area.Variable[0] + "/SPEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     SPEULO = dbValue;
             
	}
	
	tagName = Area.Variable[0] + "/SP";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
             SPValue = dbValue;
             double SPScale = SPValue/(SPEUHI - SPEULO);
             SPLine.VerticalPosition = 334 - (334 - 58) * SPScale;    
	}
	else
             SPLine.VerticalPosition = 334;
   
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd2_PMPID_PVBar_OnDynAnimation(Object sender, EventArgs e)	//PVBar
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawRectangle PVBar = (DrawRectangle)dynArgs.sender; 
	
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	double PVValue = 0;
        double PVEUHI = 0;
        double PVEULO = 0;

	string tagName = Area.Variable[0] + "/PVEUHI";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEUHI = dbValue;
             
	}

	tagName = Area.Variable[0] + "/PVEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEULO = dbValue;
             
	}
	
	tagName = Area.Variable[0] + "/PV";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
             PVValue = dbValue;
             double PVScale = PVValue/(PVEUHI - PVEULO);
             PVBar.Height = (334.00 - 58.00) * PVScale;
             PVBar.VerticalPosition = 334.00 - PVBar.Height;    
	}
	else
        {
             PVBar.VerticalPosition = 334.00;
             PVBar.Height = 0;
        }

	return; 
}//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd2_PMPID_MODE_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText MODE = (DrawText)dynArgs.sender; 

    DrawRectangle Rect = (DrawRectangle)Area.GetDrawObj("Rect_MODE");  
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	int nDigit = 2;
	string tagName = Area.Variable[0] + "/MODE";

	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
            {
                if(dbValue == 1)
                  {
                      MODE.Caption = "MAN";
                      MODE.ForegroundColor = Color.Black;
                      Rect.ForegroundColor = Color.Yellow;
                  }
                if(dbValue == 2)
                  {
                      MODE.Caption = "AUTO";
                      MODE.ForegroundColor = Color.Cyan;
                      Rect.ForegroundColor = Color.Black;
                  }
                if(dbValue == 3)
                  {
                      MODE.Caption = "CAS";
                      MODE.ForegroundColor = Color.Black;
                      Rect.ForegroundColor = Color.Cyan;
                  }
            }
       else
            {MODE.Caption = "###";}

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void gd2_PMPID_Rect_MODE_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect_MODE = (DrawRectangle)dynArgs.sender; 

           DrawArea pic = (DrawArea)(Area.Parent.Parent);

           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

           DrawArea p = (DrawArea)(Area.Parent.Parent);
           DrawArea G = (DrawArea)p.GetDrawObj("TDC3000_Groupfaceplate");
           G.Visible = true;
           G.Variable[0] = Area.Variable[0];

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd2_PMPID_Unit_OnDynAnimation(Object sender, EventArgs e)
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
public void gd2_PMPID_TagName_OnDynAnimation(Object sender, EventArgs e)
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
public void gd2_PMPID_PV_OnDynAnimation(Object sender, EventArgs e)
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


          if(PV.Variable[0] == "1")

            {
                PV.ForegroundColor = Color.White;
            }

          else

            {
                PV.ForegroundColor = Color.Cyan;
            }

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd2_PMPID_PV_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PV = (DrawText)dynArgs.sender; 
   
    PV.ForegroundColor = Color.Cyan;
    PV.Variable[0] = "0";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd2_PMPID_SP_OnDynAnimation(Object sender, EventArgs e)
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

          if(SP.Variable[0] == "1")

            {
                SP.ForegroundColor = Color.White;
            }

          else

            {
                SP.ForegroundColor = Color.Cyan;
            }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd2_PMPID_SP_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText SP = (DrawText)dynArgs.sender; 

    SP.ForegroundColor = Color.Cyan; 
    SP.Variable[0] = "0";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd2_PMPID_OP_OnDynAnimation(Object sender, EventArgs e)
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

          if(OP.Variable[0] == "1")

            {
                OP.ForegroundColor = Color.White;
            }

          else

            {
                OP.ForegroundColor = Color.Yellow;
            }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd2_PMPID_OP_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText OP = (DrawText)dynArgs.sender; 
 
    OP.ForegroundColor = Color.Yellow; 
    OP.Variable[0] = "0";

    return; 
}


//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd2_PMPID_R_tagname_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 
   
    R_tagname.Visible = true;
    R_tagname.ForegroundColor = Color.Black;
    R_tagname.EdgeColor = Color.Black;
           DrawArea p = (DrawArea)(Area.Parent);
           p.Variable[1] = "0";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void gd2_PMPID_R_tagname_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 
   
           DrawArea pic = (DrawArea)(Area.Parent.Parent);

           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void gd2_PMPID_R_tagname_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 

           DrawArea p = (DrawArea)(Area.Parent);
           if(p.Variable[1] == "1")
              {
                    R_tagname.ForegroundColor = Color.Blue;
                    R_tagname.EdgeColor = Color.White;
              }
           else
              {
                    R_tagname.ForegroundColor = Color.Black;
                    R_tagname.EdgeColor = Color.Black;

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
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd2_PMPID_Rect7_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect7 = (DrawRectangle)dynArgs.sender; 
   
    Rect7.Visible = true;
    Rect7.ForegroundColor = Color.Black;
    Rect7.EdgeColor = Color.Black;
           DrawArea p = (DrawArea)(Area.Parent);
           p.Variable[1] = "0";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void gd2_PMPID_Rect7_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect7 = (DrawRectangle)dynArgs.sender; 
   
           DrawArea pic = (DrawArea)(Area.Parent.Parent);

           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

    DrawText SP = (DrawText)Area.GetDrawObj("SP");
    SP.Variable[0] = "1";
    DrawText PV = (DrawText)Area.GetDrawObj("PV");
    PV.Variable[0] = "0";
    DrawText OP = (DrawText)Area.GetDrawObj("OP");
    OP.Variable[0] = "0";

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
				CommonFunction.MoveControl(Area,TB,(int)(Rect7.VerticalPosition - 40),(int)(Rect7.HorizontalPosition));		
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
public void gd2_PMPID_Rect7_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect7 = (DrawRectangle)dynArgs.sender; 

    DrawText SP = (DrawText)Area.GetDrawObj("SP");
    DrawArea p = (DrawArea)(Area.Parent);

			if(SP.Variable[0] == "1" && p.Variable[1] == "1")
			{
		 		Rect7.ForegroundColor = Color.Blue;
                                Rect7.EdgeColor = Color.White;                                   
			}
                        else
			{
		 		Rect7.ForegroundColor = Color.Black;
                                Rect7.EdgeColor = Color.Black; 
                                SP.Variable[0] = "0";                                  
			}
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd2_PMPID_Rect8_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect8 = (DrawRectangle)dynArgs.sender; 
   
    Rect8.Visible = true;
    Rect8.ForegroundColor = Color.Black;
    Rect8.EdgeColor = Color.Black;
           DrawArea p = (DrawArea)(Area.Parent);
           p.Variable[1] = "0";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void gd2_PMPID_Rect8_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect8 = (DrawRectangle)dynArgs.sender; 
   
           DrawArea pic = (DrawArea)(Area.Parent.Parent);

           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

    DrawText SP = (DrawText)Area.GetDrawObj("SP");
    SP.Variable[0] = "0";
    DrawText PV = (DrawText)Area.GetDrawObj("PV");
    PV.Variable[0] = "1";
    DrawText OP = (DrawText)Area.GetDrawObj("OP");
    OP.Variable[0] = "0";

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
				CommonFunction.MoveControl(Area,TB,(int)(Rect8.VerticalPosition)-40,(int)(Rect8.HorizontalPosition));
			
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
public void gd2_PMPID_Rect8_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect8 = (DrawRectangle)dynArgs.sender; 

    DrawText PV = (DrawText)Area.GetDrawObj("PV");
    DrawArea p = (DrawArea)(Area.Parent);

			if(PV.Variable[0] == "1" && p.Variable[1] == "1")
			{
		 		Rect8.ForegroundColor = Color.Blue;
                                Rect8.EdgeColor = Color.White;                                   
			}
                        else
			{
		 		Rect8.ForegroundColor = Color.Black;
                                Rect8.EdgeColor = Color.Black;  
                                PV.Variable[0] = "0";                                 
			}

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void gd2_PMPID_Rect9_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect9 = (DrawRectangle)dynArgs.sender; 
   
    Rect9.Visible = true;
    Rect9.ForegroundColor = Color.Black;
    Rect9.EdgeColor = Color.Black;
           DrawArea p = (DrawArea)(Area.Parent);
           p.Variable[1] = "0";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void gd2_PMPID_Rect9_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect9 = (DrawRectangle)dynArgs.sender; 
   
           DrawArea pic = (DrawArea)(Area.Parent.Parent);

           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

    DrawText SP = (DrawText)Area.GetDrawObj("SP");
    SP.Variable[0] = "0";
    DrawText PV = (DrawText)Area.GetDrawObj("PV");
    PV.Variable[0] = "0";
    DrawText OP = (DrawText)Area.GetDrawObj("OP");
    OP.Variable[0] = "1";

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
			        CommonFunction.MoveControl(Area,TB,(int)(Rect9.VerticalPosition)-40,(int)(Rect9.HorizontalPosition));
				
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
public void gd2_PMPID_Rect9_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect9 = (DrawRectangle)dynArgs.sender; 

    DrawText OP = (DrawText)Area.GetDrawObj("OP");
    DrawArea p = (DrawArea)(Area.Parent);

			if(OP.Variable[0] == "1" && p.Variable[1] == "1")
			{
		 		Rect9.ForegroundColor = Color.Blue;
                                Rect9.EdgeColor = Color.White;                                   
			}
                        else
			{
		 		Rect9.ForegroundColor = Color.Black;
                                Rect9.EdgeColor = Color.Black; 
                                OP.Variable[0] = "0";                                  
			}

    return; 
}
//Do not remove or update this comment
//Event Delegate:KeyEventHandler 
//Event Handler:KeyUp 
public void gd2_PMPID_TB_KeyUp(Object sender, KeyEventArgs e)
{
   TextBox TB = (TextBox)sender; 

   DrawArea Area = CommonFunction.GetThisDrawArea(TB);

     double dbValue = 0;
     int nValue = 0;
     bool bValue = false;
     int nDataType = 0;

        double OPHI = 0;
        double OPLO = 0;
        double SPEUHI = 0;
        double SPEULO = 0;
        double PVEUHI = 0;
        double PVEULO = 0;

	string tagName = Area.Variable[0] + "/OPHI";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     OPHI = dbValue;             
	}

	tagName = Area.Variable[0] + "/OPLO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     OPLO = dbValue;             
	}

	tagName = Area.Variable[0] + "/SPEUHI";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     SPEUHI = dbValue;             
	}

	tagName = Area.Variable[0] + "/SPEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     SPEULO = dbValue;             
	}

	tagName = Area.Variable[0] + "/PVEUHI";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEUHI = dbValue;        
	}

	tagName = Area.Variable[0] + "/PVEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEULO = dbValue;             
	}

     double dbValue1 = 0;
     int nValue1 = 0;
     bool bValue1 = false;
     int nDataType1 = 0;
     string MODE = Area.Variable[0] + "/MODE";
     bool ret1 = CommonFunction.GetValueWithType(MODE,ref dbValue1,ref nValue1,ref bValue1,ref nDataType1);

	switch ( e.KeyData )
	{
	case Keys.Enter:

		if(TB.Text == "" || TB.Text == null)

		{
			TB.Visible = false;
			TB.Enabled = false;
                        DrawText P = (DrawText)Area.GetDrawObj("PV");
                        P.Variable[0] = "0";
                        DrawText OP = (DrawText)Area.GetDrawObj("OP");
                        OP.Variable[0] = "0";
                        DrawText SP = (DrawText)Area.GetDrawObj("SP");
                        SP.Variable[0] = "0";
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
		             string tag=lab.Variable[0];

                             //PV值只有在MODE是MAN的时候才可以改变
                             bool V = tag.Contains("PV");
                             bool O = tag.Contains("OP");
                             bool S = tag.Contains("SP");
                             if(V == true && ret1)
                               {
                                    if(dbPVValue<=PVEUHI && dbPVValue>=PVEULO)
                                       {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                       }
                                    else
                                       {
				          CommonFunction._ProjectRelated.Var[1] = "LMT";
                                       }
                               }

                             if(O == true && ret1)
                               {//OP值只有在MODE是MAN的时候才可以改变
	                 	  if(dbValue1==1)
                                   {
                                    if(dbPVValue<=OPHI && dbPVValue>=OPLO)
                                       {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                       }
                                    else
                                      {
				          CommonFunction._ProjectRelated.Var[1] = "LMT";
                                       }
                                    }
	                	  else 
                                    {
                                        CommonFunction._ProjectRelated.Var[1] = "MODE ERROR";

                                    }
                               }

                             if(S == true && ret1)
                               {//SP值只有在MODE是AUTO的时候才可以改变
                                if(dbValue1==2)
                                 {
	                 	  if(dbPVValue<=SPEUHI && dbPVValue>=SPEULO)

				   {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                   }
	                	  else 
                                    {
                                        CommonFunction._ProjectRelated.Var[1] = "LMT";
                                    }
                                  }
	                	  else 
                                    {
                                        CommonFunction._ProjectRelated.Var[1] = "MODE ERROR";

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
CommonFunction._ProjectRelated.Var[1] = "";
    DrawText P1 = (DrawText)Area.GetDrawObj("PV");
    P1.Variable[0] = "0";
    DrawText OP1 = (DrawText)Area.GetDrawObj("OP");
    OP1.Variable[0] = "0";
    DrawText SP1 = (DrawText)Area.GetDrawObj("SP");
    SP1.Variable[0] = "0";
    return; 
}


}
