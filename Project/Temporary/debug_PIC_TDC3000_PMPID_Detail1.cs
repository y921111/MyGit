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
public class PIC_TDC3000_PMPID_Detail1:IDynCodeAttachDetach
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
_EventHandler= (EventHandler)PIC_TDC3000_PMPID_Detail1_OnDynInitialize;
CodeDomCommon.AttachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PIC_TDC3000_PMPID_Detail1_OnDynAnimation;
CodeDomCommon.AttachAreaEventHandler(area,strEventName,_EventHandler);
strObjectName = "PTEXECST_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PTEXECST_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Text74";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Text74_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Text73";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Text73_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PNTFORM_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PNTFORM_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "NMODE_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)NMODE_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "NMODATTR_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)NMODATTR_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "ALENBST_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)ALENBST_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OPLO_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)OPLO_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OPHI_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)OPHI_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SPEULO_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)SPEULO_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SPEUHI_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)SPEUHI_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CVEULO_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CVEULO_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CVEUHI_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CVEUHI_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVEULO_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVEULO_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVEUHI_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVEUHI_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVSOURCE_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVSOURCE_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVAUTO_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVAUTO_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVROCNTP_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVROCNTP_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVROCPTP_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVROCPTP_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DEVLO_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DEVLO_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DEVHI_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DEVHI_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVLLTPEU_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVLLTPEU_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVLOTPEU_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVLOTPEU_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVHITPEU_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVHITPEU_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVHHTPEU_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVHHTPEU_Value_OnDynAnimation;
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
strObjectName = "PAGE";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PAGE_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DEVLO";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DEVLO_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DEVHI";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DEVHI_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVROCNTP";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVROCNTP_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVROCPTP";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVROCPTP_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVLLTPEU";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVLLTPEU_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVLOTPEU";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVLOTPEU_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVHITPEU";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVHITPEU_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVHHTPEU";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVHHTPEU_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OPLO";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)OPLO_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OPHI";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)OPHI_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SPEULO";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)SPEULO_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SPEUHI";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)SPEUHI_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CVEULO";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CVEULO_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CVEUHI";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CVEUHI_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVEULO";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVEULO_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVEUHI";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVEUHI_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PNTFORM";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PNTFORM_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "NMODATTR";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)NMODATTR_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "NMODE";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)NMODE_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "ALENBST";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)ALENBST_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PTEXECST";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PTEXECST_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVSOURCE";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVSOURCE_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_PAGE_PMPID";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TDC3000_faceplate_PAGE_PMPID_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_PAGE_PMPID.Rect4_GROUP";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)TDC3000_faceplate_PAGE_PMPID_Rect4_GROUP_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_PAGE_PMPID.Rect3_CTLCONCT";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)TDC3000_faceplate_PAGE_PMPID_Rect3_CTLCONCT_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_PAGE_PMPID.Rect2_CTLALGO";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)TDC3000_faceplate_PAGE_PMPID_Rect2_CTLALGO_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_PAGE_PMPID.Rect1_FIRST";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)TDC3000_faceplate_PAGE_PMPID_Rect1_FIRST_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_POINTDATA";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)TDC3000_faceplate_POINTDATA_KeyUp;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "TDC3000_faceplate_POINTDATA";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)TDC3000_faceplate_POINTDATA_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_POINTDATA";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TDC3000_faceplate_POINTDATA_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_POINTDATA.ENTER";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)TDC3000_faceplate_POINTDATA_ENTER_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_POINTDATA.D5";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)TDC3000_faceplate_POINTDATA_D5_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_POINTDATA.D5";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TDC3000_faceplate_POINTDATA_D5_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_POINTDATA.D5";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)TDC3000_faceplate_POINTDATA_D5_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_POINTDATA.D4";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)TDC3000_faceplate_POINTDATA_D4_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_POINTDATA.D4";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TDC3000_faceplate_POINTDATA_D4_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_POINTDATA.D4";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)TDC3000_faceplate_POINTDATA_D4_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_POINTDATA.D3";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)TDC3000_faceplate_POINTDATA_D3_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_POINTDATA.D3";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TDC3000_faceplate_POINTDATA_D3_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_POINTDATA.D3";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)TDC3000_faceplate_POINTDATA_D3_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_POINTDATA.Rect3";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)TDC3000_faceplate_POINTDATA_Rect3_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_POINTDATA.Rect3";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TDC3000_faceplate_POINTDATA_Rect3_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_POINTDATA.Rect2";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)TDC3000_faceplate_POINTDATA_Rect2_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_POINTDATA.Rect2";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TDC3000_faceplate_POINTDATA_Rect2_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_POINTDATA.Rect1";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)TDC3000_faceplate_POINTDATA_Rect1_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_POINTDATA.Rect1";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TDC3000_faceplate_POINTDATA_Rect1_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_POINTDATA.D2";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)TDC3000_faceplate_POINTDATA_D2_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_POINTDATA.D2";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TDC3000_faceplate_POINTDATA_D2_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_POINTDATA.D2";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)TDC3000_faceplate_POINTDATA_D2_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_POINTDATA.D1";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)TDC3000_faceplate_POINTDATA_D1_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_POINTDATA.D1";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TDC3000_faceplate_POINTDATA_D1_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_POINTDATA.D1";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)TDC3000_faceplate_POINTDATA_D1_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_POINTDATA.NAME";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)TDC3000_faceplate_POINTDATA_NAME_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_POINTDATA.NAME";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TDC3000_faceplate_POINTDATA_NAME_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_LIMITS";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)TDC3000_faceplate_LIMITS_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_LIMITS";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)TDC3000_faceplate_LIMITS_KeyUp;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "TDC3000_faceplate_LIMITS.ENTER";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)TDC3000_faceplate_LIMITS_ENTER_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_LIMITS.LIMITS_VALUE";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TDC3000_faceplate_LIMITS_LIMITS_VALUE_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_LIMITS.LIMITS_NAME";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TDC3000_faceplate_LIMITS_LIMITS_NAME_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_LIMITS.TB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)TDC3000_faceplate_LIMITS_TB_KeyUp;
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
strObjectName = "TDC3000_DetailItem_PMPID";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)TDC3000_DetailItem_PMPID_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_DetailItem_PMPID";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)TDC3000_DetailItem_PMPID_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_DetailItem_PMPID";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)TDC3000_DetailItem_PMPID_KeyUp;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "TDC3000_DetailItem_PMPID.ALM";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TDC3000_DetailItem_PMPID_ALM_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_DetailItem_PMPID.OPBar";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TDC3000_DetailItem_PMPID_OPBar_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_DetailItem_PMPID.PVBlack";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TDC3000_DetailItem_PMPID_PVBlack_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_DetailItem_PMPID.SPLine";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TDC3000_DetailItem_PMPID_SPLine_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_DetailItem_PMPID.PVBar";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TDC3000_DetailItem_PMPID_PVBar_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_DetailItem_PMPID.MODE";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TDC3000_DetailItem_PMPID_MODE_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_DetailItem_PMPID.Rect_MODE";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)TDC3000_DetailItem_PMPID_Rect_MODE_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_DetailItem_PMPID.Unit";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TDC3000_DetailItem_PMPID_Unit_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_DetailItem_PMPID.TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TDC3000_DetailItem_PMPID_TagName_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_DetailItem_PMPID.PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TDC3000_DetailItem_PMPID_PV_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_DetailItem_PMPID.PV";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)TDC3000_DetailItem_PMPID_PV_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_DetailItem_PMPID.PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)TDC3000_DetailItem_PMPID_PV_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_DetailItem_PMPID.SP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TDC3000_DetailItem_PMPID_SP_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_DetailItem_PMPID.SP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)TDC3000_DetailItem_PMPID_SP_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_DetailItem_PMPID.SP";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)TDC3000_DetailItem_PMPID_SP_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_DetailItem_PMPID.OP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TDC3000_DetailItem_PMPID_OP_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_DetailItem_PMPID.OP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)TDC3000_DetailItem_PMPID_OP_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_DetailItem_PMPID.OP";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)TDC3000_DetailItem_PMPID_OP_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_DetailItem_PMPID.TB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)TDC3000_DetailItem_PMPID_TB_KeyUp;
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
_EventHandler= (EventHandler)PIC_TDC3000_PMPID_Detail1_OnDynInitialize;
CodeDomCommon.DetachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PIC_TDC3000_PMPID_Detail1_OnDynAnimation;
CodeDomCommon.DetachAreaEventHandler(area,strEventName,_EventHandler);
strObjectName = "PTEXECST_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PTEXECST_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Text74";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Text74_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Text73";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Text73_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PNTFORM_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PNTFORM_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "NMODE_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)NMODE_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "NMODATTR_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)NMODATTR_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "ALENBST_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)ALENBST_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OPLO_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)OPLO_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OPHI_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)OPHI_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SPEULO_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)SPEULO_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SPEUHI_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)SPEUHI_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CVEULO_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CVEULO_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CVEUHI_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CVEUHI_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVEULO_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVEULO_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVEUHI_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVEUHI_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVSOURCE_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVSOURCE_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVAUTO_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVAUTO_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVROCNTP_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVROCNTP_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVROCPTP_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVROCPTP_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DEVLO_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DEVLO_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DEVHI_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DEVHI_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVLLTPEU_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVLLTPEU_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVLOTPEU_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVLOTPEU_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVHITPEU_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVHITPEU_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVHHTPEU_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVHHTPEU_Value_OnDynAnimation;
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
strObjectName = "PAGE";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PAGE_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DEVLO";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DEVLO_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DEVHI";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DEVHI_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVROCNTP";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVROCNTP_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVROCPTP";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVROCPTP_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVLLTPEU";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVLLTPEU_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVLOTPEU";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVLOTPEU_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVHITPEU";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVHITPEU_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVHHTPEU";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVHHTPEU_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OPLO";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)OPLO_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OPHI";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)OPHI_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SPEULO";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)SPEULO_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SPEUHI";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)SPEUHI_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CVEULO";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CVEULO_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CVEUHI";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CVEUHI_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVEULO";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVEULO_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVEUHI";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVEUHI_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PNTFORM";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PNTFORM_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "NMODATTR";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)NMODATTR_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "NMODE";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)NMODE_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "ALENBST";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)ALENBST_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PTEXECST";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PTEXECST_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVSOURCE";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVSOURCE_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_PAGE_PMPID";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TDC3000_faceplate_PAGE_PMPID_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_PAGE_PMPID.Rect4_GROUP";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)TDC3000_faceplate_PAGE_PMPID_Rect4_GROUP_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_PAGE_PMPID.Rect3_CTLCONCT";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)TDC3000_faceplate_PAGE_PMPID_Rect3_CTLCONCT_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_PAGE_PMPID.Rect2_CTLALGO";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)TDC3000_faceplate_PAGE_PMPID_Rect2_CTLALGO_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_PAGE_PMPID.Rect1_FIRST";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)TDC3000_faceplate_PAGE_PMPID_Rect1_FIRST_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_POINTDATA";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)TDC3000_faceplate_POINTDATA_KeyUp;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "TDC3000_faceplate_POINTDATA";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)TDC3000_faceplate_POINTDATA_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_POINTDATA";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TDC3000_faceplate_POINTDATA_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_POINTDATA.ENTER";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)TDC3000_faceplate_POINTDATA_ENTER_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_POINTDATA.D5";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)TDC3000_faceplate_POINTDATA_D5_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_POINTDATA.D5";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TDC3000_faceplate_POINTDATA_D5_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_POINTDATA.D5";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)TDC3000_faceplate_POINTDATA_D5_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_POINTDATA.D4";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)TDC3000_faceplate_POINTDATA_D4_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_POINTDATA.D4";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TDC3000_faceplate_POINTDATA_D4_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_POINTDATA.D4";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)TDC3000_faceplate_POINTDATA_D4_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_POINTDATA.D3";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)TDC3000_faceplate_POINTDATA_D3_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_POINTDATA.D3";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TDC3000_faceplate_POINTDATA_D3_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_POINTDATA.D3";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)TDC3000_faceplate_POINTDATA_D3_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_POINTDATA.Rect3";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)TDC3000_faceplate_POINTDATA_Rect3_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_POINTDATA.Rect3";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TDC3000_faceplate_POINTDATA_Rect3_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_POINTDATA.Rect2";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)TDC3000_faceplate_POINTDATA_Rect2_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_POINTDATA.Rect2";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TDC3000_faceplate_POINTDATA_Rect2_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_POINTDATA.Rect1";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)TDC3000_faceplate_POINTDATA_Rect1_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_POINTDATA.Rect1";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TDC3000_faceplate_POINTDATA_Rect1_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_POINTDATA.D2";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)TDC3000_faceplate_POINTDATA_D2_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_POINTDATA.D2";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TDC3000_faceplate_POINTDATA_D2_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_POINTDATA.D2";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)TDC3000_faceplate_POINTDATA_D2_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_POINTDATA.D1";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)TDC3000_faceplate_POINTDATA_D1_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_POINTDATA.D1";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TDC3000_faceplate_POINTDATA_D1_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_POINTDATA.D1";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)TDC3000_faceplate_POINTDATA_D1_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_POINTDATA.NAME";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)TDC3000_faceplate_POINTDATA_NAME_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_POINTDATA.NAME";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TDC3000_faceplate_POINTDATA_NAME_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_LIMITS";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)TDC3000_faceplate_LIMITS_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_LIMITS";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)TDC3000_faceplate_LIMITS_KeyUp;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "TDC3000_faceplate_LIMITS.ENTER";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)TDC3000_faceplate_LIMITS_ENTER_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_LIMITS.LIMITS_VALUE";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TDC3000_faceplate_LIMITS_LIMITS_VALUE_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_LIMITS.LIMITS_NAME";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TDC3000_faceplate_LIMITS_LIMITS_NAME_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_LIMITS.TB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)TDC3000_faceplate_LIMITS_TB_KeyUp;
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
strObjectName = "TDC3000_DetailItem_PMPID";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)TDC3000_DetailItem_PMPID_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_DetailItem_PMPID";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)TDC3000_DetailItem_PMPID_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_DetailItem_PMPID";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)TDC3000_DetailItem_PMPID_KeyUp;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "TDC3000_DetailItem_PMPID.ALM";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TDC3000_DetailItem_PMPID_ALM_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_DetailItem_PMPID.OPBar";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TDC3000_DetailItem_PMPID_OPBar_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_DetailItem_PMPID.PVBlack";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TDC3000_DetailItem_PMPID_PVBlack_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_DetailItem_PMPID.SPLine";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TDC3000_DetailItem_PMPID_SPLine_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_DetailItem_PMPID.PVBar";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TDC3000_DetailItem_PMPID_PVBar_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_DetailItem_PMPID.MODE";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TDC3000_DetailItem_PMPID_MODE_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_DetailItem_PMPID.Rect_MODE";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)TDC3000_DetailItem_PMPID_Rect_MODE_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_DetailItem_PMPID.Unit";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TDC3000_DetailItem_PMPID_Unit_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_DetailItem_PMPID.TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TDC3000_DetailItem_PMPID_TagName_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_DetailItem_PMPID.PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TDC3000_DetailItem_PMPID_PV_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_DetailItem_PMPID.PV";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)TDC3000_DetailItem_PMPID_PV_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_DetailItem_PMPID.PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)TDC3000_DetailItem_PMPID_PV_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_DetailItem_PMPID.SP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TDC3000_DetailItem_PMPID_SP_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_DetailItem_PMPID.SP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)TDC3000_DetailItem_PMPID_SP_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_DetailItem_PMPID.SP";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)TDC3000_DetailItem_PMPID_SP_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_DetailItem_PMPID.OP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TDC3000_DetailItem_PMPID_OP_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_DetailItem_PMPID.OP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)TDC3000_DetailItem_PMPID_OP_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_DetailItem_PMPID.OP";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)TDC3000_DetailItem_PMPID_OP_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_DetailItem_PMPID.TB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)TDC3000_DetailItem_PMPID_TB_KeyUp;
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

//===================================================================================
//    Area.Variable[0] 存放TagName
//    Area.Variable[1] 参数选中标志
//    Area.Variable[2] picture中的DrawArea的显示标志
//
//===================================================================================
public void GetValue(Object sender, EventArgs e, string TagName, string ParaName, string FormatPara)
{
	DrawArea Area = (DrawArea)sender;
	DynEventArgs dynArgs = (DynEventArgs)e;
	DrawText Text = (DrawText)dynArgs.sender;

	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	string strDigit = "f2";
	string TagPara = TagName + "/" + FormatPara;
	if (CommonFunction.GetValueWithType(TagPara,ref dbValue,ref nValue,ref bValue,ref nDataType))
		strDigit = "f" + nValue.ToString();

	TagPara = TagName + "/" + ParaName;
	if (CommonFunction.GetValueWithType(TagPara,ref dbValue,ref nValue,ref bValue,ref nDataType))
		Text.Caption = dbValue.ToString(strDigit);
	else
		Text.Caption = "------";
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void PIC_TDC3000_PMPID_Detail1_OnDynInitialize(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 
 
   DrawArea P = (DrawArea)(Area.GetDrawObj("TDC3000_Groupfaceplate"));
   DrawArea L = (DrawArea)(Area.GetDrawObj("TDC3000_faceplate_LIMITS"));
   DrawArea D = (DrawArea)(Area.GetDrawObj("TDC3000_faceplate_POINTDATA"));
   DrawArea G = (DrawArea)(Area.GetDrawObj("TDC3000_faceplate_PAGE_PMPID"));
         P.Visible = false;
         G.Visible = false;
         L.Visible = false;
         D.Visible = false;

   Picture PP = (Picture)(Area.Parent);
   PP.Location = new Point(0,0);
////////////////////////////////////////////////////////////////////////////////处理变色
////////////////////////////////////////////////////////////////////////////////处理变色

	DrawText PVAUTO = (DrawText)Area.GetDrawObj("PVAUTO");
	DrawText PVSOURCE = (DrawText)Area.GetDrawObj("PVSOURCE");
	DrawText PVHHTPEU = (DrawText)Area.GetDrawObj("PVHHTPEU");
	DrawText PVHITPEU = (DrawText)Area.GetDrawObj("PVHITPEU");
	DrawText PVLOTPEU = (DrawText)Area.GetDrawObj("PVLOTPEU");
	DrawText PVLLTPEU = (DrawText)Area.GetDrawObj("PVLLTPEU");
	DrawText PVROCPTP = (DrawText)Area.GetDrawObj("PVROCPTP");
	DrawText PVROCNTP = (DrawText)Area.GetDrawObj("PVROCNTP");
	DrawText DEVHI = (DrawText)Area.GetDrawObj("DEVHI");
	DrawText DEVLO = (DrawText)Area.GetDrawObj("DEVLO");
	DrawText PVEUHI = (DrawText)Area.GetDrawObj("PVEUHI");
	DrawText PVEULO = (DrawText)Area.GetDrawObj("PVEULO");
	DrawText CVEUHI = (DrawText)Area.GetDrawObj("CVEUHI");
	DrawText CVEULO = (DrawText)Area.GetDrawObj("CVEULO");
	DrawText SPEUHI = (DrawText)Area.GetDrawObj("SPEUHI");
	DrawText SPEULO = (DrawText)Area.GetDrawObj("SPEULO");
	DrawText OPHI = (DrawText)Area.GetDrawObj("OPHI");
	DrawText OPLO = (DrawText)Area.GetDrawObj("OPLO");
	DrawText PTEXECST = (DrawText)Area.GetDrawObj("PTEXECST");
	DrawText ALENBST = (DrawText)Area.GetDrawObj("ALENBST");
	DrawText NMODE = (DrawText)Area.GetDrawObj("NMODE");
	DrawText NMODATTR = (DrawText)Area.GetDrawObj("NMODATTR");
	DrawText PNTFORM = (DrawText)Area.GetDrawObj("PNTFORM");

	PVAUTO.ForegroundColor = Color.Cyan;
	PVSOURCE.ForegroundColor = Color.Cyan;
	PVHHTPEU.ForegroundColor = Color.Yellow;
	PVHITPEU.ForegroundColor = Color.Yellow;
	PVLOTPEU.ForegroundColor = Color.Yellow;
	PVLLTPEU.ForegroundColor = Color.Yellow;
	PVROCPTP.ForegroundColor = Color.Yellow;
	PVROCNTP.ForegroundColor = Color.Yellow;
	DEVHI.ForegroundColor = Color.Yellow;
	DEVLO.ForegroundColor = Color.Yellow;
	PVEUHI.ForegroundColor = Color.Yellow;
	PVEULO.ForegroundColor = Color.Yellow;
	CVEUHI.ForegroundColor = Color.Yellow;
	CVEULO.ForegroundColor = Color.Yellow;
	SPEUHI.ForegroundColor = Color.Yellow;
	SPEULO.ForegroundColor = Color.Yellow;
	OPHI.ForegroundColor = Color.Yellow;
	OPLO.ForegroundColor = Color.Yellow;
	PTEXECST.ForegroundColor = Color.Cyan;
	ALENBST.ForegroundColor = Color.Cyan;
	NMODE.ForegroundColor = Color.Cyan;
	NMODATTR.ForegroundColor = Color.Cyan;
	PNTFORM.ForegroundColor = Color.Cyan;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void PIC_TDC3000_PMPID_Detail1_OnDynAnimation(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 

   DrawArea P = (DrawArea)(Area.GetDrawObj("TDC3000_Groupfaceplate"));
   DrawArea L = (DrawArea)(Area.GetDrawObj("TDC3000_faceplate_LIMITS"));
   DrawArea D = (DrawArea)(Area.GetDrawObj("TDC3000_faceplate_POINTDATA"));
   DrawArea G = (DrawArea)(Area.GetDrawObj("TDC3000_faceplate_PAGE_PMPID"));

   switch(Area.Variable[2])
     {
      case "0":
         G.Visible = false;
         P.Visible = false;
         L.Visible = false;
         D.Visible = false;
      break;
      case "1":
         G.Visible = true;
         P.Visible = false;
         L.Visible = false;
         D.Visible = false;
      break;
      case "2":
         D.Visible = true;
         P.Visible = false;
         L.Visible = false;
         G.Visible = false;
      break;
      case "3":
         L.Visible = true;
         P.Visible = false;
         G.Visible = false;
         D.Visible = false;
      break;
      case "4":
         P.Visible = true;
         G.Visible = false;
         L.Visible = false;
         D.Visible = false;
      break;
     }

////////////////////////////////////////////////////////////////////////////////处理变色
////////////////////////////////////////////////////////////////////////////////处理变色
	DrawText PVAUTO = (DrawText)Area.GetDrawObj("PVAUTO");
	DrawText PVSOURCE = (DrawText)Area.GetDrawObj("PVSOURCE");
	DrawText PVHHTPEU = (DrawText)Area.GetDrawObj("PVHHTPEU");
	DrawText PVHITPEU = (DrawText)Area.GetDrawObj("PVHITPEU");
	DrawText PVLOTPEU = (DrawText)Area.GetDrawObj("PVLOTPEU");
	DrawText PVLLTPEU = (DrawText)Area.GetDrawObj("PVLLTPEU");
	DrawText PVROCPTP = (DrawText)Area.GetDrawObj("PVROCPTP");
	DrawText PVROCNTP = (DrawText)Area.GetDrawObj("PVROCNTP");
	DrawText DEVHI = (DrawText)Area.GetDrawObj("DEVHI");
	DrawText DEVLO = (DrawText)Area.GetDrawObj("DEVLO");
	DrawText PVEUHI = (DrawText)Area.GetDrawObj("PVEUHI");
	DrawText PVEULO = (DrawText)Area.GetDrawObj("PVEULO");
	DrawText CVEUHI = (DrawText)Area.GetDrawObj("CVEUHI");
	DrawText CVEULO = (DrawText)Area.GetDrawObj("CVEULO");
	DrawText SPEUHI = (DrawText)Area.GetDrawObj("SPEUHI");
	DrawText SPEULO = (DrawText)Area.GetDrawObj("SPEULO");
	DrawText OPHI = (DrawText)Area.GetDrawObj("OPHI");
	DrawText OPLO = (DrawText)Area.GetDrawObj("OPLO");
	DrawText PTEXECST = (DrawText)Area.GetDrawObj("PTEXECST");
	DrawText ALENBST = (DrawText)Area.GetDrawObj("ALENBST");
	DrawText NMODE = (DrawText)Area.GetDrawObj("NMODE");
	DrawText NMODATTR = (DrawText)Area.GetDrawObj("NMODATTR");
	DrawText PNTFORM = (DrawText)Area.GetDrawObj("PNTFORM");
	DrawText PAGE = (DrawText)Area.GetDrawObj("PAGE");

	DrawText PVAUTO_Value = (DrawText)Area.GetDrawObj("PVAUTO_Value");
	DrawText PVSOURCE_Value = (DrawText)Area.GetDrawObj("PVSOURCE_Value");
	DrawText PVHHTPEU_Value = (DrawText)Area.GetDrawObj("PVHHTPEU_Value");
	DrawText PVHITPEU_Value = (DrawText)Area.GetDrawObj("PVHITPEU_Value");
	DrawText PVLOTPEU_Value = (DrawText)Area.GetDrawObj("PVLOTPEU_Value");
	DrawText PVLLTPEU_Value = (DrawText)Area.GetDrawObj("PVLLTPEU_Value");
	DrawText PVROCPTP_Value = (DrawText)Area.GetDrawObj("PVROCPTP_Value");
	DrawText PVROCNTP_Value = (DrawText)Area.GetDrawObj("PVROCNTP_Value");
	DrawText DEVHI_Value = (DrawText)Area.GetDrawObj("DEVHI_Value");
	DrawText DEVLO_Value = (DrawText)Area.GetDrawObj("DEVLO_Value");
	DrawText PVEUHI_Value = (DrawText)Area.GetDrawObj("PVEUHI_Value");
	DrawText PVEULO_Value = (DrawText)Area.GetDrawObj("PVEULO_Value");
	DrawText CVEUHI_Value = (DrawText)Area.GetDrawObj("CVEUHI_Value");
	DrawText CVEULO_Value = (DrawText)Area.GetDrawObj("CVEULO_Value");
	DrawText SPEUHI_Value = (DrawText)Area.GetDrawObj("SPEUHI_Value");
	DrawText SPEULO_Value = (DrawText)Area.GetDrawObj("SPEULO_Value");
	DrawText OPHI_Value = (DrawText)Area.GetDrawObj("OPHI_Value");
	DrawText OPLO_Value = (DrawText)Area.GetDrawObj("OPLO_Value");
	DrawText PTEXECST_Value = (DrawText)Area.GetDrawObj("PTEXECST_Value");
	DrawText ALENBST_Value = (DrawText)Area.GetDrawObj("ALENBST_Value");
	DrawText NMODE_Value = (DrawText)Area.GetDrawObj("NMODE_Value");
	DrawText NMODATTR_Value = (DrawText)Area.GetDrawObj("NMODATTR_Value");
	DrawText PNTFORM_Value = (DrawText)Area.GetDrawObj("PNTFORM_Value");

	PVAUTO.ForegroundColor = Color.Cyan;
	PVSOURCE.ForegroundColor = Color.Cyan;
	PVHHTPEU.ForegroundColor = Color.Yellow;
	PVHITPEU.ForegroundColor = Color.Yellow;
	PVLOTPEU.ForegroundColor = Color.Yellow;
	PVLLTPEU.ForegroundColor = Color.Yellow;
	PVROCPTP.ForegroundColor = Color.Yellow;
	PVROCNTP.ForegroundColor = Color.Yellow;
	DEVHI.ForegroundColor = Color.Yellow;
	DEVLO.ForegroundColor = Color.Yellow;
	PVEUHI.ForegroundColor = Color.Yellow;
	PVEULO.ForegroundColor = Color.Yellow;
	CVEUHI.ForegroundColor = Color.Yellow;
	CVEULO.ForegroundColor = Color.Yellow;
	SPEUHI.ForegroundColor = Color.Yellow;
	SPEULO.ForegroundColor = Color.Yellow;
	OPHI.ForegroundColor = Color.Yellow;
	OPLO.ForegroundColor = Color.Yellow;
	PTEXECST.ForegroundColor = Color.Cyan;
	ALENBST.ForegroundColor = Color.Cyan;
	NMODE.ForegroundColor = Color.Cyan;
	NMODATTR.ForegroundColor = Color.Cyan;
	PNTFORM.ForegroundColor = Color.Cyan;
	PAGE.ForegroundColor = Color.Lime;

	PVAUTO_Value.ForegroundColor = Color.Cyan;
	PVSOURCE_Value.ForegroundColor = Color.Cyan;
	PVHHTPEU_Value.ForegroundColor = Color.Yellow;
	PVHITPEU_Value.ForegroundColor = Color.Yellow;
	PVLOTPEU_Value.ForegroundColor = Color.Yellow;
	PVLLTPEU_Value.ForegroundColor = Color.Yellow;
	PVROCPTP_Value.ForegroundColor = Color.Yellow;
	PVROCNTP_Value.ForegroundColor = Color.Yellow;
	DEVHI_Value.ForegroundColor = Color.Yellow;
	DEVLO_Value.ForegroundColor = Color.Yellow;
	PVEUHI_Value.ForegroundColor = Color.Yellow;
	PVEULO_Value.ForegroundColor = Color.Yellow;
	CVEUHI_Value.ForegroundColor = Color.Yellow;
	CVEULO_Value.ForegroundColor = Color.Yellow;
	SPEUHI_Value.ForegroundColor = Color.Yellow;
	SPEULO_Value.ForegroundColor = Color.Yellow;
	OPHI_Value.ForegroundColor = Color.Yellow;
	OPLO_Value.ForegroundColor = Color.Yellow;
	PTEXECST_Value.ForegroundColor = Color.Cyan;
	ALENBST_Value.ForegroundColor = Color.Cyan;
	NMODE_Value.ForegroundColor = Color.Cyan;
	NMODATTR_Value.ForegroundColor = Color.Cyan;
	PNTFORM_Value.ForegroundColor = Color.Cyan;

    switch(Area.Variable[1])
     {
      case "1":
               PVAUTO.ForegroundColor = Color.White;
               PVAUTO_Value.ForegroundColor = Color.White;
      break;
      case "2":
               PVSOURCE.ForegroundColor = Color.White;
               PVSOURCE_Value.ForegroundColor = Color.White;
      break;
      case "3":
               PVHHTPEU.ForegroundColor = Color.White;
               PVHHTPEU_Value.ForegroundColor = Color.White;
      break;
      case "4":
               PVHITPEU.ForegroundColor = Color.White;
               PVHITPEU_Value.ForegroundColor = Color.White;
      break;
      case "5":
               PVLOTPEU.ForegroundColor = Color.White;
               PVLOTPEU_Value.ForegroundColor = Color.White;
      break;
      case "6":
               PVLLTPEU.ForegroundColor = Color.White;
               PVLLTPEU_Value.ForegroundColor = Color.White;
      break;
      case "7":
               PVROCPTP.ForegroundColor = Color.White;
               PVROCPTP_Value.ForegroundColor = Color.White;
      break;
      case "8":
               PVROCNTP.ForegroundColor = Color.White;
               PVROCNTP_Value.ForegroundColor = Color.White;
      break;
      case "9":
               DEVHI.ForegroundColor = Color.White;
               DEVHI_Value.ForegroundColor = Color.White;
      break;
      case "10":
               DEVLO.ForegroundColor = Color.White;
               DEVLO_Value.ForegroundColor = Color.White;
      break;
      case "11":
               PVEUHI.ForegroundColor = Color.White;
               PVEUHI_Value.ForegroundColor = Color.White;
      break;
      case "12":
               PVEULO.ForegroundColor = Color.White;
               PVEULO_Value.ForegroundColor = Color.White;
      break;
      case "13":
               CVEUHI.ForegroundColor = Color.White;
               CVEUHI_Value.ForegroundColor = Color.White;
      break;
      case "14":
               CVEULO.ForegroundColor = Color.White;
               CVEULO_Value.ForegroundColor = Color.White;
      break;
      case "15":
               SPEUHI.ForegroundColor = Color.White;
               SPEUHI_Value.ForegroundColor = Color.White;
      break;
      case "16":
               SPEULO.ForegroundColor = Color.White;
               SPEULO_Value.ForegroundColor = Color.White;
      break;
      case "17":
               OPHI.ForegroundColor = Color.White;
               OPHI_Value.ForegroundColor = Color.White;
      break;
      case "18":
               OPLO.ForegroundColor = Color.White;
               OPLO_Value.ForegroundColor = Color.White;
      break;
      case "19":
               PTEXECST.ForegroundColor = Color.White;
               PTEXECST_Value.ForegroundColor = Color.White; 
      break;
      case "20":
               ALENBST.ForegroundColor = Color.White;
               ALENBST_Value.ForegroundColor = Color.White;
      break;
      case "21":
               NMODE.ForegroundColor = Color.White;
               NMODE_Value.ForegroundColor = Color.White;
      break;
      case "22":
               NMODATTR.ForegroundColor = Color.White;
               NMODATTR_Value.ForegroundColor = Color.White;
      break;
      case "23":
               PNTFORM.ForegroundColor = Color.White;
               PNTFORM_Value.ForegroundColor = Color.White; 
      break;
      case "24":
               PAGE.ForegroundColor = Color.White;  
      break;
    }
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void PTEXECST_Value_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PTEXECST_Value = (DrawText)dynArgs.sender; 
 
    GetValue(sender,e,Area.Variable[0],"PTEXECST","PVFORMAT");

  return;
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void Text74_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PTEXECST_Value = (DrawText)dynArgs.sender; 
   
    GetValue(sender,e,Area.Variable[0],"PTEXECST","PVFORMAT");
    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void Text73_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PTEXECST_Value = (DrawText)dynArgs.sender; 
   
    GetValue(sender,e,Area.Variable[0],"PTEXECST","PVFORMAT");
    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void PNTFORM_Value_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PNTFORM_Value = (DrawText)dynArgs.sender; 
   
    GetValue(sender,e,Area.Variable[0],"PNTFORM","PVFORMAT");
    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void NMODE_Value_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText NMODE_Value = (DrawText)dynArgs.sender; 
   
    GetValue(sender,e,Area.Variable[0],"NMODE","PVFORMAT");
    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void NMODATTR_Value_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText NMODATTR_Value = (DrawText)dynArgs.sender; 
   
    GetValue(sender,e,Area.Variable[0],"NMODATTR","PVFORMAT");
    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void ALENBST_Value_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText ALENBST_Value = (DrawText)dynArgs.sender; 

    GetValue(sender,e,Area.Variable[0],"ALENBST","PVFORMAT");
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
   
    GetValue(sender,e,Area.Variable[0],"OPLO","PVFORMAT");
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

    GetValue(sender,e,Area.Variable[0],"OPHI","PVFORMAT");
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

    GetValue(sender,e,Area.Variable[0],"SPEULO","PVFORMAT");
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

    GetValue(sender,e,Area.Variable[0],"SPEUHI","PVFORMAT");
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void CVEULO_Value_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText CVEULO_Value = (DrawText)dynArgs.sender; 
   
    GetValue(sender,e,Area.Variable[0],"CVEULO","PVFORMAT");
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void CVEUHI_Value_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText CVEUHI_Value = (DrawText)dynArgs.sender; 

    GetValue(sender,e,Area.Variable[0],"CVEUHI","PVFORMAT");
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void PVEULO_Value_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVEULO_Value = (DrawText)dynArgs.sender; 
   
    GetValue(sender,e,Area.Variable[0],"PVEULO","PVFORMAT");
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void PVEUHI_Value_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVEUHI_Value = (DrawText)dynArgs.sender; 

    GetValue(sender,e,Area.Variable[0],"PVEUHI","PVFORMAT");
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

    GetValue(sender,e,Area.Variable[0],"PVSOURCE","PVFORMAT");
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

    GetValue(sender,e,Area.Variable[0],"PVAUTO","PVFORMAT");
    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void PVROCNTP_Value_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVROCNTP_Value = (DrawText)dynArgs.sender; 

    GetValue(sender,e,Area.Variable[0],"PVRN","PVFORMAT");
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void PVROCPTP_Value_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVROCPTP_Value = (DrawText)dynArgs.sender; 

    GetValue(sender,e,Area.Variable[0],"PVRP","PVFORMAT");
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void DEVLO_Value_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText DEVLO_Value = (DrawText)dynArgs.sender; 

    GetValue(sender,e,Area.Variable[0],"DEVLO","PVFORMAT");
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void DEVHI_Value_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText DEVHI_Value = (DrawText)dynArgs.sender; 

    GetValue(sender,e,Area.Variable[0],"DEVHI","PVFORMAT");
    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void PVLLTPEU_Value_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVLLTPEU_Value = (DrawText)dynArgs.sender; 

    GetValue(sender,e,Area.Variable[0],"PVLL","PVFORMAT");
    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void PVLOTPEU_Value_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVLOTPEU_Value = (DrawText)dynArgs.sender; 

    GetValue(sender,e,Area.Variable[0],"PVLO","PVFORMAT");
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void PVHITPEU_Value_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVHITPEU_Value = (DrawText)dynArgs.sender; 

    GetValue(sender,e,Area.Variable[0],"PVHI","PVFORMAT");
    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void PVHHTPEU_Value_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVHHTPEU_Value = (DrawText)dynArgs.sender; 
   
    GetValue(sender,e,Area.Variable[0],"PVHH","PVFORMAT");
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
public void PAGE_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PAGE = (DrawText)dynArgs.sender; 

    DrawArea L = (DrawArea)Area.GetDrawObj("TDC3000_faceplate_PAGE_PMPID");
    Area.Variable[2] = "1";
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "1";//设置标志位变色
    Area.Variable[1] = "24";
//    DrawArea A = (DrawArea)(Area.Parent);
//             A.RunAnimation();
    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void DEVLO_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText DEVLO = (DrawText)dynArgs.sender; 
   
    DrawArea L = (DrawArea)Area.GetDrawObj("TDC3000_faceplate_LIMITS");
    Area.Variable[2] = "3";
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "DEVLO";
    Area.Variable[1] = "10";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void DEVHI_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText DEVHI = (DrawText)dynArgs.sender; 

    DrawArea L = (DrawArea)Area.GetDrawObj("TDC3000_faceplate_LIMITS");
    Area.Variable[2] = "3";
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "DEVHI";
    Area.Variable[1] = "9";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void PVROCNTP_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVROCNTP = (DrawText)dynArgs.sender; 
   
    DrawArea L = (DrawArea)Area.GetDrawObj("TDC3000_faceplate_LIMITS");
    Area.Variable[2] = "3";
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "PVRN";
    Area.Variable[1] = "8";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void PVROCPTP_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVROCPTP = (DrawText)dynArgs.sender; 
   
    DrawArea L = (DrawArea)Area.GetDrawObj("TDC3000_faceplate_LIMITS");
    Area.Variable[2] = "3";
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "PVRP";
    Area.Variable[1] = "7";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void PVLLTPEU_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVLLTPEU = (DrawText)dynArgs.sender; 
   
    DrawArea L = (DrawArea)Area.GetDrawObj("TDC3000_faceplate_LIMITS");
    Area.Variable[2] = "3";
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "PVLL";
    Area.Variable[1] = "6";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void PVLOTPEU_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVLOTPEU = (DrawText)dynArgs.sender; 
   
    DrawArea L = (DrawArea)Area.GetDrawObj("TDC3000_faceplate_LIMITS");
    Area.Variable[2] = "3";
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "PVLO";
    Area.Variable[1] = "5";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void PVHITPEU_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVHITPEU = (DrawText)dynArgs.sender; 

    DrawArea L = (DrawArea)Area.GetDrawObj("TDC3000_faceplate_LIMITS");
    Area.Variable[2] = "3";
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "PVHI";
    Area.Variable[1] = "4";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void PVHHTPEU_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVHHTPEU = (DrawText)dynArgs.sender; 

    DrawArea L = (DrawArea)Area.GetDrawObj("TDC3000_faceplate_LIMITS");
    Area.Variable[2] = "3";
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "PVHH";
    Area.Variable[1] = "3";

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

    DrawArea L = (DrawArea)Area.GetDrawObj("TDC3000_faceplate_LIMITS");
    Area.Variable[2] = "3";
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "OPLO"; 
    Area.Variable[1] = "18";

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

    DrawArea L = (DrawArea)Area.GetDrawObj("TDC3000_faceplate_LIMITS");
    Area.Variable[2] = "3";
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "OPHI";
    Area.Variable[1] = "17";

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

    DrawArea L = (DrawArea)Area.GetDrawObj("TDC3000_faceplate_LIMITS");
    Area.Variable[2] = "3";
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "SPEULO";
    Area.Variable[1] = "16";

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
   
    DrawArea L = (DrawArea)Area.GetDrawObj("TDC3000_faceplate_LIMITS");
    Area.Variable[2] = "3";
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "SPEUHI";
    Area.Variable[1] = "15";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void CVEULO_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText CVEULO = (DrawText)dynArgs.sender; 
   
    DrawArea L = (DrawArea)Area.GetDrawObj("TDC3000_faceplate_LIMITS");
    Area.Variable[2] = "3";
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "CVEULO";
    Area.Variable[1] = "14";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void CVEUHI_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText CVEUHI = (DrawText)dynArgs.sender; 
   
    DrawArea L = (DrawArea)Area.GetDrawObj("TDC3000_faceplate_LIMITS");
    Area.Variable[2] = "3";
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "CVEUHI";
    Area.Variable[1] = "13";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void PVEULO_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVEULO = (DrawText)dynArgs.sender; 
   
    DrawArea L = (DrawArea)Area.GetDrawObj("TDC3000_faceplate_LIMITS");
    Area.Variable[2] = "3";
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "PVEULO";
    Area.Variable[1] = "12";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void PVEUHI_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVEUHI = (DrawText)dynArgs.sender; 

    DrawArea L = (DrawArea)Area.GetDrawObj("TDC3000_faceplate_LIMITS");
    Area.Variable[2] = "3";
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "PVEUHI";
    Area.Variable[1] = "11";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void PNTFORM_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PNTFORM = (DrawText)dynArgs.sender; 
  
    DrawArea L = (DrawArea)Area.GetDrawObj("TDC3000_faceplate_POINTDATA");
    Area.Variable[2] = "2";
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "PNTFORM";
    L.Variable[3] = "FULL";
    L.Variable[4] = "COMPOINT";
    L.Variable[5] = "N";
    L.Variable[6] = "N";
    L.Variable[7] = "N";
    L.Variable[8] = "0";
    L.Variable[9] = "1";
    L.Variable[10] = "1";
    L.Variable[11] = "1";
    L.Variable[12] = "1";
    Area.Variable[1] = "23";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void NMODATTR_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText NMODATTR = (DrawText)dynArgs.sender; 

    DrawArea L = (DrawArea)Area.GetDrawObj("TDC3000_faceplate_POINTDATA");
    Area.Variable[2] = "2";
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "NMODATTR";
    L.Variable[3] = "OPERATOR";
    L.Variable[4] = "PROGRAM";
    L.Variable[5] = "NORMAL";
    L.Variable[6] = "NONE";
    L.Variable[7] = "N";
    L.Variable[8] = "0";
    L.Variable[9] = "1";
    L.Variable[10] = "2";
    L.Variable[11] = "3";
    L.Variable[12] = "4";   
    Area.Variable[1] = "22";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void NMODE_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText NMODE = (DrawText)dynArgs.sender; 
  
    DrawArea L = (DrawArea)Area.GetDrawObj("TDC3000_faceplate_POINTDATA");
    Area.Variable[2] = "2";
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "NMODE";
    L.Variable[3] = "MAN";
    L.Variable[4] = "AUTO";
    L.Variable[5] = "CAS";
    L.Variable[6] = "BCAS";
    L.Variable[7] = "NONE";
    L.Variable[8] = "1";
    L.Variable[9] = "2";
    L.Variable[10] = "3";
    L.Variable[11] = "4";
    L.Variable[12] = "5";
    Area.Variable[1] = "21";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void ALENBST_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText ALENBST = (DrawText)dynArgs.sender; 
   
    DrawArea L = (DrawArea)Area.GetDrawObj("TDC3000_faceplate_POINTDATA");
    Area.Variable[2] = "2";
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "ALENBST";
    L.Variable[3] = "ENABLE";
    L.Variable[4] = "DISENABLE";
    L.Variable[5] = "INHIBIT";
    L.Variable[6] = "N";
    L.Variable[7] = "N";
    L.Variable[8] = "0";
    L.Variable[9] = "1";
    L.Variable[10] = "3";
    L.Variable[11] = "2";
    L.Variable[12] = "2";
    Area.Variable[1] = "20";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void PTEXECST_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PTEXECST = (DrawText)dynArgs.sender; 

    DrawArea L = (DrawArea)Area.GetDrawObj("TDC3000_faceplate_POINTDATA");
    Area.Variable[2] = "2";
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "PTEXECST";
    L.Variable[3] = "INACTIVE";
    L.Variable[4] = "ACTIVE";
    L.Variable[5] = "N";
    L.Variable[6] = "N";
    L.Variable[7] = "N";
    L.Variable[8] = "0";
    L.Variable[9] = "1";
    L.Variable[10] = "2";
    L.Variable[11] = "2";
    L.Variable[12] = "2";
    Area.Variable[1] = "19";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void PVSOURCE_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVSOURCE = (DrawText)dynArgs.sender; 

    DrawArea L = (DrawArea)Area.GetDrawObj("TDC3000_faceplate_POINTDATA");
    Area.Variable[2] = "2";
    L.Variable[0] = Area.Variable[0];
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
    Area.Variable[1] = "2";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void TDC3000_faceplate_PAGE_PMPID_OnDynAnimation(Object sender, EventArgs e)
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
public void TDC3000_faceplate_PAGE_PMPID_Rect4_GROUP_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect4_GROUP = (DrawRectangle)dynArgs.sender; 

    String groupnumber = CommonFunction.GetControlGroupNameByTag(Area.Variable[0]);
    String groupname = groupnumber.Substring(2);
    groupname = string.Format("{0:G}",Convert.ToInt32(groupname));
	int nLeft = 0;
	int nTop = 0;
　      ArrayList list = new ArrayList();
        list = CommonFunction.GetGroupItems(groupnumber);
　　    string[] strVariable_new = new string[9];
　　    string[] strVariable = (string[])list.ToArray(typeof(string));//ArrayList转换为string[]
        for(int i=0; i<=7; i++)
        {
           strVariable_new[i+1] = strVariable[i];
        }
        strVariable_new[0] = groupname;
        bool g = CommonFunction.OpenPicture("TDC3000_ControlGroup.grf", nTop, nLeft, strVariable_new);
        if(g == true)
        { 
	  CommonFunction.OpenPicture("TDC3000_ControlGroup.grf", nTop, nLeft, strVariable_new);
         }

        DrawArea pic = (DrawArea)(Area.Parent);
        pic.Variable[1] = "0";
        pic.Variable[2] = "0";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void TDC3000_faceplate_PAGE_PMPID_Rect3_CTLCONCT_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect3_CTLCONCT = (DrawRectangle)dynArgs.sender; 

	int nLeft = 0;
	int nTop = 0;
	string[] strVariable = new string[1];
	strVariable[0] = Area.Variable[0];
	CommonFunction.OpenPicture("TDC3000_PMPID_Detail3.grf", nTop, nLeft, strVariable);
        DrawArea pic = (DrawArea)(Area.Parent);
        pic.Variable[1] = "0";
        pic.Variable[2] = "0";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void TDC3000_faceplate_PAGE_PMPID_Rect2_CTLALGO_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect2_CTLALGO = (DrawRectangle)dynArgs.sender; 
   
	int nLeft = 0;
	int nTop = 0;
	string[] strVariable = new string[1];
	strVariable[0] = Area.Variable[0];
	CommonFunction.OpenPicture("TDC3000_PMPID_Detail2.grf", nTop, nLeft, strVariable);
        DrawArea pic = (DrawArea)(Area.Parent);
        pic.Variable[1] = "0";
        pic.Variable[2] = "0";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void TDC3000_faceplate_PAGE_PMPID_Rect1_FIRST_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect1_FIRST = (DrawRectangle)dynArgs.sender; 
   
	int nLeft = 0;
	int nTop = 0;
	string[] strVariable = new string[1];
	strVariable[0] = Area.Variable[0];
	CommonFunction.OpenPicture("TDC3000_PMPID_Detail1.grf", nTop, nLeft, strVariable);
        DrawArea pic = (DrawArea)(Area.Parent);
        pic.Variable[1] = "0";
        pic.Variable[2] = "0";
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
public void TDC3000_faceplate_POINTDATA_KeyUp(Object sender, KeyEventArgs e)
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
public void TDC3000_faceplate_POINTDATA_OnDynInitialize(Object sender, EventArgs e)
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
/*
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;
	string tagName = Area.Variable[0] + "/" + Area.Variable[1];
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
        Area.Variable[2] = "0";//是否选中
	    if(ret)
	    {
		if(nValue == Convert.ToDouble(Area.Variable[8]))

		   {
		        D1.ForegroundColor = Color.Cyan;
                   }	
		else if(nValue == Convert.ToDouble(Area.Variable[9]))

		   {
		       D2.ForegroundColor = Color.Cyan;
                    }
                else if(nValue == Convert.ToDouble(Area.Variable[10]))

		    {
		       D3.ForegroundColor = Color.Cyan;
                    }
                else if(nValue == Convert.ToDouble(Area.Variable[11]))

		   {
		       D4.ForegroundColor = Color.Cyan;
                    }
                else if(nValue == Convert.ToDouble(Area.Variable[12]))
		   {
		       D5.ForegroundColor = Color.Cyan;
                    }
	    }    
*/
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
//Event Handler:OnDynAnimation 
public void TDC3000_faceplate_POINTDATA_OnDynAnimation(Object sender, EventArgs e)
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

	D1.ForegroundColor = Color.Lime;
	D2.ForegroundColor = Color.Lime;
	D3.ForegroundColor = Color.Lime;
	D4.ForegroundColor = Color.Lime;
	D5.ForegroundColor = Color.Lime;

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
public void TDC3000_faceplate_POINTDATA_ENTER_OnDynClick(Object sender, EventArgs e)
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
public void TDC3000_faceplate_POINTDATA_D5_OnDynClick(Object sender, EventArgs e)
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
public void TDC3000_faceplate_POINTDATA_D5_OnDynAnimation(Object sender, EventArgs e)
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
//Event Handler:OnDynInitialize 
public void TDC3000_faceplate_POINTDATA_D5_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText D5 = (DrawText)dynArgs.sender; 
           string tagName = Area.Variable[7].ToUpper();
	if(tagName != "N")
		D5.Caption = tagName;
	else
		D5.Caption = "";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void TDC3000_faceplate_POINTDATA_D4_OnDynClick(Object sender, EventArgs e)
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
public void TDC3000_faceplate_POINTDATA_D4_OnDynAnimation(Object sender, EventArgs e)
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
//Event Handler:OnDynInitialize 
public void TDC3000_faceplate_POINTDATA_D4_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText D4 = (DrawText)dynArgs.sender; 
         string tagName = Area.Variable[6].ToUpper();
	if(tagName != "N")
		D4.Caption = tagName;
	else
		D4.Caption = "";  
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void TDC3000_faceplate_POINTDATA_D3_OnDynClick(Object sender, EventArgs e)
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
public void TDC3000_faceplate_POINTDATA_D3_OnDynAnimation(Object sender, EventArgs e)
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
public void TDC3000_faceplate_POINTDATA_D3_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText D3 = (DrawText)dynArgs.sender; 
        string tagName = Area.Variable[5].ToUpper();
	if(tagName != "N")
		D3.Caption = tagName;
	else
		D3.Caption = "";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void TDC3000_faceplate_POINTDATA_Rect3_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect3 = (DrawRectangle)dynArgs.sender; 
   
    Rect3.Visible = false;
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
//Event Handler:OnDynAnimation 
public void TDC3000_faceplate_POINTDATA_Rect3_OnDynAnimation(Object sender, EventArgs e)
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
public void TDC3000_faceplate_POINTDATA_Rect2_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect2 = (DrawRectangle)dynArgs.sender; 
   
    Rect2.Visible = false;
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
//Event Handler:OnDynAnimation 
public void TDC3000_faceplate_POINTDATA_Rect2_OnDynAnimation(Object sender, EventArgs e)
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
public void TDC3000_faceplate_POINTDATA_Rect1_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect1 = (DrawRectangle)dynArgs.sender; 
   
    Rect1.Visible = false;
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
//Event Handler:OnDynAnimation 
public void TDC3000_faceplate_POINTDATA_Rect1_OnDynAnimation(Object sender, EventArgs e)
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
public void TDC3000_faceplate_POINTDATA_D2_OnDynClick(Object sender, EventArgs e)
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
public void TDC3000_faceplate_POINTDATA_D2_OnDynAnimation(Object sender, EventArgs e)
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
//Event Handler:OnDynInitialize 
public void TDC3000_faceplate_POINTDATA_D2_OnDynInitialize(Object sender, EventArgs e)
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
public void TDC3000_faceplate_POINTDATA_D1_OnDynClick(Object sender, EventArgs e)
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
public void TDC3000_faceplate_POINTDATA_D1_OnDynAnimation(Object sender, EventArgs e)
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
//Event Handler:OnDynInitialize 
public void TDC3000_faceplate_POINTDATA_D1_OnDynInitialize(Object sender, EventArgs e)
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
//Event Handler:OnDynInitialize 
public void TDC3000_faceplate_POINTDATA_NAME_OnDynInitialize(Object sender, EventArgs e)	//TagName
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
//Event Handler:OnDynAnimation 
public void TDC3000_faceplate_POINTDATA_NAME_OnDynAnimation(Object sender, EventArgs e)
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
public void TDC3000_faceplate_LIMITS_OnDynInitialize(Object sender, EventArgs e)
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
public void TDC3000_faceplate_LIMITS_KeyUp(Object sender, KeyEventArgs e)
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
public void TDC3000_faceplate_LIMITS_ENTER_OnDynClick(Object sender, EventArgs e)
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
public void TDC3000_faceplate_LIMITS_LIMITS_VALUE_OnDynAnimation(Object sender, EventArgs e)
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
public void TDC3000_faceplate_LIMITS_LIMITS_NAME_OnDynAnimation(Object sender, EventArgs e)
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
public void TDC3000_faceplate_LIMITS_TB_KeyUp(Object sender, KeyEventArgs e)
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
public void TDC3000_DetailItem_PMPID_OnDynInitialize(Object sender, EventArgs e)
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
public void TDC3000_DetailItem_PMPID_OnDynClick(Object sender, EventArgs e)
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
public void TDC3000_DetailItem_PMPID_KeyUp(Object sender, KeyEventArgs e)
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
public void TDC3000_DetailItem_PMPID_ALM_OnDynAnimation(Object sender, EventArgs e)
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
public void TDC3000_DetailItem_PMPID_OPBar_OnDynAnimation(Object sender, EventArgs e)
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
public void TDC3000_DetailItem_PMPID_PVBlack_OnDynAnimation(Object sender, EventArgs e)
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
public void TDC3000_DetailItem_PMPID_SPLine_OnDynAnimation(Object sender, EventArgs e)
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
public void TDC3000_DetailItem_PMPID_PVBar_OnDynAnimation(Object sender, EventArgs e)	//PVBar
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
public void TDC3000_DetailItem_PMPID_MODE_OnDynAnimation(Object sender, EventArgs e)
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
public void TDC3000_DetailItem_PMPID_Rect_MODE_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect_MODE = (DrawRectangle)dynArgs.sender; 

           DrawArea pic = (DrawArea)(Area.Parent);
           DrawArea G = (DrawArea)pic.GetDrawObj("TDC3000_Groupfaceplate");
           G.Visible = true;
           G.Variable[0] = Area.Variable[0];

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void TDC3000_DetailItem_PMPID_Unit_OnDynAnimation(Object sender, EventArgs e)
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
public void TDC3000_DetailItem_PMPID_TagName_OnDynAnimation(Object sender, EventArgs e)
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
public void TDC3000_DetailItem_PMPID_PV_OnDynAnimation(Object sender, EventArgs e)
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
//Event Handler:OnDynClick 
public void TDC3000_DetailItem_PMPID_PV_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PV = (DrawText)dynArgs.sender; 
  
    PV.Variable[0] = "1";
    DrawText SP = (DrawText)Area.GetDrawObj("SP");
    SP.Variable[0] = "0";
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
				CommonFunction.MoveControl(Area,TB,(int)(PV.VerticalPosition)-40,(int)(PV.HorizontalPosition)+40);
			
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
public void TDC3000_DetailItem_PMPID_PV_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PV = (DrawText)dynArgs.sender; 

    PV.Variable[0] = "0";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void TDC3000_DetailItem_PMPID_SP_OnDynAnimation(Object sender, EventArgs e)
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
public void TDC3000_DetailItem_PMPID_SP_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText SP = (DrawText)dynArgs.sender; 

    SP.Variable[0] = "0";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void TDC3000_DetailItem_PMPID_SP_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText SP = (DrawText)dynArgs.sender; 
   
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
				CommonFunction.MoveControl(Area,TB,(int)(SP.VerticalPosition - 40),(int)(SP.HorizontalPosition)+40);		
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
public void TDC3000_DetailItem_PMPID_OP_OnDynAnimation(Object sender, EventArgs e)
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
public void TDC3000_DetailItem_PMPID_OP_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText OP = (DrawText)dynArgs.sender; 
 
    OP.Variable[0] = "0";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void TDC3000_DetailItem_PMPID_OP_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText OP = (DrawText)dynArgs.sender; 
   
    OP.Variable[0] = "1";
    DrawText SP = (DrawText)Area.GetDrawObj("SP");
    SP.Variable[0] = "0";
    DrawText PV = (DrawText)Area.GetDrawObj("PV");
    PV.Variable[0] = "0";

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
			        CommonFunction.MoveControl(Area,TB,(int)(OP.VerticalPosition)-40,(int)(OP.HorizontalPosition)+40);
				
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
//Event Delegate:KeyEventHandler 
//Event Handler:KeyUp 
public void TDC3000_DetailItem_PMPID_TB_KeyUp(Object sender, KeyEventArgs e)
{
   TextBox TB = (TextBox)sender; 

   DrawArea Area = CommonFunction.GetThisDrawArea(TB);

    DrawText SP = (DrawText)Area.GetDrawObj("SP");
    SP.Variable[0] = "0";
    DrawText PV = (DrawText)Area.GetDrawObj("PV");
    PV.Variable[0] = "0";
    DrawText OP = (DrawText)Area.GetDrawObj("OP");
    OP.Variable[0] = "0";

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
warning CS1668: “LIB 环境变量”中指定的搜索路径“C:\Program Files (x86)\Microsoft Visual Studio\VC98\mfc\lib”无效 --“系统找不到指定的路径。 ”
warning CS1668: “LIB 环境变量”中指定的搜索路径“C:\Program Files (x86)\Microsoft Visual Studio\VC98\lib”无效 --“系统找不到指定的路径。 ”
c:\Users\haodongdong\AppData\Local\Temp\-esp3bpl.0.cs(29,23) : warning CS0168: 声明了变量“_MouseEventHandler”，但从未使用过
c:\Users\haodongdong\AppData\Local\Temp\-esp3bpl.0.cs(31,24) : warning CS0168: 声明了变量“_CancelEventHandler”，但从未使用过
c:\Users\haodongdong\AppData\Local\Temp\-esp3bpl.0.cs(32,24) : warning CS0168: 声明了变量“_ScrollEventHandler”，但从未使用过
c:\Users\haodongdong\AppData\Local\Temp\-esp3bpl.0.cs(557,23) : warning CS0168: 声明了变量“_MouseEventHandler”，但从未使用过
c:\Users\haodongdong\AppData\Local\Temp\-esp3bpl.0.cs(559,24) : warning CS0168: 声明了变量“_CancelEventHandler”，但从未使用过
c:\Users\haodongdong\AppData\Local\Temp\-esp3bpl.0.cs(560,24) : warning CS0168: 声明了变量“_ScrollEventHandler”，但从未使用过
c:\Users\haodongdong\AppData\Local\Temp\-esp3bpl.0.cs(2300,41) : error CS0117: “DrawTools.CommonFunction”并不包含“GetControlGroupNameByTag”的定义
c:\Users\haodongdong\AppData\Local\Temp\-esp3bpl.0.cs(3503,3) : warning CS0162: 检测到无法访问的代码
c:\Users\haodongdong\AppData\Local\Temp\-esp3bpl.0.cs(4047,3) : warning CS0162: 检测到无法访问的代码
c:\Users\haodongdong\AppData\Local\Temp\-esp3bpl.0.cs(4170,9) : warning CS0219: 变量“PVValue”已赋值，但其值从未使用过
c:\Users\haodongdong\AppData\Local\Temp\-esp3bpl.0.cs(4305,6) : warning CS0219: 变量“nDigit”已赋值，但其值从未使用过
c:\Users\haodongdong\AppData\Local\Temp\-esp3bpl.0.cs(4856,3) : warning CS0162: 检测到无法访问的代码
