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
public class PIC_TDC3000_PMANLIN_Detail1:IDynCodeAttachDetach
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
_EventHandler= (EventHandler)PIC_TDC3000_PMANLIN_Detail1_OnDynInitialize;
CodeDomCommon.AttachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PIC_TDC3000_PMANLIN_Detail1_OnDynAnimation;
CodeDomCommon.AttachAreaEventHandler(area,strEventName,_EventHandler);
strObjectName = "PAGE";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PAGE_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TF_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TF_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "LASTPV_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)LASTPV_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "LASTPV";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)LASTPV_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVCALC";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVCALC_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVCALC_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVCALC_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PTEXECST_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PTEXECST_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVRAW_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVRAW_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PNTFORM_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PNTFORM_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "ALENBST_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)ALENBST_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVRAWLO_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVRAWLO_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVRAWHI_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVRAWHI_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVEXEL_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVEXEL_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVEXEH_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVEXEH_Value_OnDynAnimation;
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
strObjectName = "PVROCNFL_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVROCNFL_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVROCPFL_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVROCPFL_Value_OnDynAnimation;
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
strObjectName = "TF";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)TF_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVROCNFL";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVROCNFL_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVROCPFL";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVROCPFL_OnDynClick;
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
strObjectName = "PVRAWLO";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVRAWLO_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVRAWHI";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVRAWHI_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVEXEL";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVEXEL_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVEXEH";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVEXEH_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVEULO";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVEULO_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVEUHI";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVEUHI_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVRAW";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVRAW_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PNTFORM";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PNTFORM_OnDynClick;
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
strObjectName = "PVAUTO";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVAUTO_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Detail_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Detail_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)Detail_KeyUp;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "Detail.Rect8";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Detail_Rect8_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail.Line16";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Detail_Line16_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail.LinePVTV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Detail_LinePVTV_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail.TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Detail_TagName_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail.PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Detail_PV_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail.PV";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Detail_PV_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail.PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Detail_PV_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail.PVTV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Detail_PVTV_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail.PVTV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Detail_PVTV_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail.PVTV";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Detail_PVTV_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail.TB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)Detail_TB_KeyUp;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "TDC3000_faceplate_PAGE_PMANLIN";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TDC3000_faceplate_PAGE_PMANLIN_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_PAGE_PMANLIN.Rect4_GROUP";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)TDC3000_faceplate_PAGE_PMANLIN_Rect4_GROUP_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_PAGE_PMANLIN.Rect3_CTLCONCT";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)TDC3000_faceplate_PAGE_PMANLIN_Rect3_CTLCONCT_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_PAGE_PMANLIN.Rect1_FIRST";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)TDC3000_faceplate_PAGE_PMANLIN_Rect1_FIRST_OnDynClick;
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
_EventHandler= (EventHandler)PIC_TDC3000_PMANLIN_Detail1_OnDynInitialize;
CodeDomCommon.DetachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PIC_TDC3000_PMANLIN_Detail1_OnDynAnimation;
CodeDomCommon.DetachAreaEventHandler(area,strEventName,_EventHandler);
strObjectName = "PAGE";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PAGE_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TF_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TF_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "LASTPV_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)LASTPV_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "LASTPV";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)LASTPV_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVCALC";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVCALC_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVCALC_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVCALC_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PTEXECST_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PTEXECST_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVRAW_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVRAW_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PNTFORM_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PNTFORM_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "ALENBST_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)ALENBST_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVRAWLO_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVRAWLO_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVRAWHI_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVRAWHI_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVEXEL_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVEXEL_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVEXEH_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVEXEH_Value_OnDynAnimation;
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
strObjectName = "PVROCNFL_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVROCNFL_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVROCPFL_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVROCPFL_Value_OnDynAnimation;
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
strObjectName = "TF";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)TF_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVROCNFL";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVROCNFL_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVROCPFL";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVROCPFL_OnDynClick;
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
strObjectName = "PVRAWLO";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVRAWLO_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVRAWHI";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVRAWHI_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVEXEL";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVEXEL_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVEXEH";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVEXEH_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVEULO";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVEULO_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVEUHI";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVEUHI_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVRAW";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVRAW_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PNTFORM";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PNTFORM_OnDynClick;
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
strObjectName = "PVAUTO";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVAUTO_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Detail_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Detail_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)Detail_KeyUp;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "Detail.Rect8";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Detail_Rect8_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail.Line16";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Detail_Line16_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail.LinePVTV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Detail_LinePVTV_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail.TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Detail_TagName_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail.PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Detail_PV_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail.PV";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Detail_PV_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail.PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Detail_PV_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail.PVTV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Detail_PVTV_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail.PVTV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Detail_PVTV_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail.PVTV";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Detail_PVTV_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail.TB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)Detail_TB_KeyUp;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "TDC3000_faceplate_PAGE_PMANLIN";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TDC3000_faceplate_PAGE_PMANLIN_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_PAGE_PMANLIN.Rect4_GROUP";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)TDC3000_faceplate_PAGE_PMANLIN_Rect4_GROUP_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_PAGE_PMANLIN.Rect3_CTLCONCT";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)TDC3000_faceplate_PAGE_PMANLIN_Rect3_CTLCONCT_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_faceplate_PAGE_PMANLIN.Rect1_FIRST";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)TDC3000_faceplate_PAGE_PMANLIN_Rect1_FIRST_OnDynClick;
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
public void PIC_TDC3000_PMANLIN_Detail1_OnDynInitialize(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 

   DrawArea L = (DrawArea)(Area.GetDrawObj("TDC3000_faceplate_LIMITS"));
   DrawArea D = (DrawArea)(Area.GetDrawObj("TDC3000_faceplate_POINTDATA"));
   DrawArea G = (DrawArea)(Area.GetDrawObj("TDC3000_faceplate_PAGE_PMANLIN"));
         G.Visible = false;
         L.Visible = false;
         D.Visible = false;

   Picture P = (Picture)(Area.Parent);
   P.Location = new Point(0,0);
////////////////////////////////////////////////////////////////////////////////处理变色
////////////////////////////////////////////////////////////////////////////////处理变色

	DrawText PVAUTO = (DrawText)Area.GetDrawObj("PVAUTO");
	DrawText PVSOURCE = (DrawText)Area.GetDrawObj("PVSOURCE");
	DrawText PVCALC = (DrawText)Area.GetDrawObj("PVCALC");
	DrawText LASTPV = (DrawText)Area.GetDrawObj("LASTPV");
	DrawText PVHHTPEU = (DrawText)Area.GetDrawObj("PVHHTPEU");
	DrawText PVHITPEU = (DrawText)Area.GetDrawObj("PVHITPEU");
	DrawText PVLOTPEU = (DrawText)Area.GetDrawObj("PVLOTPEU");
	DrawText PVLLTPEU = (DrawText)Area.GetDrawObj("PVLLTPEU");
	DrawText PVROCPFL = (DrawText)Area.GetDrawObj("PVROCPFL");
	DrawText PVROCNFL = (DrawText)Area.GetDrawObj("PVROCNFL");
	DrawText PVEXEH = (DrawText)Area.GetDrawObj("PVEXEH");
	DrawText PVEUHI = (DrawText)Area.GetDrawObj("PVEUHI");
	DrawText PVEULO = (DrawText)Area.GetDrawObj("PVEULO");
	DrawText PVEXEL = (DrawText)Area.GetDrawObj("PVEXEL");
	DrawText PVRAWHI = (DrawText)Area.GetDrawObj("PVRAWHI");
	DrawText PVRAWLO = (DrawText)Area.GetDrawObj("PVRAWLO");
	DrawText URL = (DrawText)Area.GetDrawObj("URL");
	DrawText URV = (DrawText)Area.GetDrawObj("URV");
	DrawText LRL = (DrawText)Area.GetDrawObj("LRL");
	DrawText LRV = (DrawText)Area.GetDrawObj("LRV");
	DrawText PTEXECST = (DrawText)Area.GetDrawObj("PTEXECST");
	DrawText ALENBST = (DrawText)Area.GetDrawObj("ALENBST");
	DrawText OVERVAL = (DrawText)Area.GetDrawObj("OVERVAL");
	DrawText PNTFORM = (DrawText)Area.GetDrawObj("PNTFORM");
	DrawText PVRAW = (DrawText)Area.GetDrawObj("PVRAW");
	DrawText TF = (DrawText)Area.GetDrawObj("TF");
	DrawText C1 = (DrawText)Area.GetDrawObj("C1");
	DrawText C2 = (DrawText)Area.GetDrawObj("C2");
	DrawText PAGE = (DrawText)Area.GetDrawObj("PAGE");

	PVAUTO.ForegroundColor = Color.Cyan;
	PVSOURCE.ForegroundColor = Color.Cyan;
	PVCALC.ForegroundColor = Color.Cyan;
	LASTPV.ForegroundColor = Color.Cyan;
	PVHHTPEU.ForegroundColor = Color.Yellow;
	PVHITPEU.ForegroundColor = Color.Yellow;
	PVLOTPEU.ForegroundColor = Color.Yellow;
	PVLLTPEU.ForegroundColor = Color.Yellow;
	PVROCPFL.ForegroundColor = Color.Yellow;
	PVROCNFL.ForegroundColor = Color.Yellow;
	PVEXEH.ForegroundColor = Color.Yellow;
	PVEUHI.ForegroundColor = Color.Yellow;
	PVEULO.ForegroundColor = Color.Yellow;
	PVEXEL.ForegroundColor = Color.Yellow;
	PVRAWHI.ForegroundColor = Color.Yellow;
	PVRAWLO.ForegroundColor = Color.Yellow;
	URL.ForegroundColor = Color.Yellow;
	URV.ForegroundColor = Color.Yellow;
	LRL.ForegroundColor = Color.Yellow;
	LRV.ForegroundColor = Color.Yellow;
	PTEXECST.ForegroundColor = Color.Cyan;
	ALENBST.ForegroundColor = Color.Cyan;
	OVERVAL.ForegroundColor = Color.Cyan;
	PNTFORM.ForegroundColor = Color.Cyan;
	PVRAW.ForegroundColor = Color.Cyan;  
	TF.ForegroundColor = Color.Cyan; 
	C1.ForegroundColor = Color.Cyan;
	C2.ForegroundColor = Color.Cyan;
	PAGE.ForegroundColor = Color.Lime;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void PIC_TDC3000_PMANLIN_Detail1_OnDynAnimation(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 

   DrawArea L = (DrawArea)(Area.GetDrawObj("TDC3000_faceplate_LIMITS"));
   DrawArea D = (DrawArea)(Area.GetDrawObj("TDC3000_faceplate_POINTDATA"));
   DrawArea G = (DrawArea)(Area.GetDrawObj("TDC3000_faceplate_PAGE_PMANLIN"));
   switch(Area.Variable[2])
     {
      case "0":
         G.Visible = false;
         L.Visible = false;
         D.Visible = false;
      break;
      case "1":
         G.Visible = true;
         L.Visible = false;
         D.Visible = false;
      break;
      case "2":
         D.Visible = true;
         L.Visible = false;
         G.Visible = false;
      break;
      case "3":
         L.Visible = true;
         G.Visible = false;
         D.Visible = false;
      break;
     }
////////////////////////////////////////////////////////////////////////////////处理变色
////////////////////////////////////////////////////////////////////////////////处理变色

	DrawText PVAUTO = (DrawText)Area.GetDrawObj("PVAUTO");
	DrawText PVSOURCE = (DrawText)Area.GetDrawObj("PVSOURCE");
	DrawText PVCALC = (DrawText)Area.GetDrawObj("PVCALC");
	DrawText LASTPV = (DrawText)Area.GetDrawObj("LASTPV");
	DrawText PVHHTPEU = (DrawText)Area.GetDrawObj("PVHHTPEU");
	DrawText PVHITPEU = (DrawText)Area.GetDrawObj("PVHITPEU");
	DrawText PVLOTPEU = (DrawText)Area.GetDrawObj("PVLOTPEU");
	DrawText PVLLTPEU = (DrawText)Area.GetDrawObj("PVLLTPEU");
	DrawText PVROCPFL = (DrawText)Area.GetDrawObj("PVROCPFL");
	DrawText PVROCNFL = (DrawText)Area.GetDrawObj("PVROCNFL");
	DrawText PVEXEH = (DrawText)Area.GetDrawObj("PVEXEH");
	DrawText PVEUHI = (DrawText)Area.GetDrawObj("PVEUHI");
	DrawText PVEULO = (DrawText)Area.GetDrawObj("PVEULO");
	DrawText PVEXEL = (DrawText)Area.GetDrawObj("PVEXEL");
	DrawText PVRAWHI = (DrawText)Area.GetDrawObj("PVRAWHI");
	DrawText PVRAWLO = (DrawText)Area.GetDrawObj("PVRAWLO");
	DrawText URL = (DrawText)Area.GetDrawObj("URL");
	DrawText URV = (DrawText)Area.GetDrawObj("URV");
	DrawText LRL = (DrawText)Area.GetDrawObj("LRL");
	DrawText LRV = (DrawText)Area.GetDrawObj("LRV");
	DrawText PTEXECST = (DrawText)Area.GetDrawObj("PTEXECST");
	DrawText ALENBST = (DrawText)Area.GetDrawObj("ALENBST");
	DrawText OVERVAL = (DrawText)Area.GetDrawObj("OVERVAL");
	DrawText PNTFORM = (DrawText)Area.GetDrawObj("PNTFORM");
	DrawText PVRAW = (DrawText)Area.GetDrawObj("PVRAW");
	DrawText TF = (DrawText)Area.GetDrawObj("TF");
	DrawText C1 = (DrawText)Area.GetDrawObj("C1");
	DrawText C2 = (DrawText)Area.GetDrawObj("C2");
	DrawText PAGE = (DrawText)Area.GetDrawObj("PAGE");

	DrawText PVAUTO_Value = (DrawText)Area.GetDrawObj("PVAUTO_Value");
	DrawText PVSOURCE_Value = (DrawText)Area.GetDrawObj("PVSOURCE_Value");
	DrawText PVCALC_Value = (DrawText)Area.GetDrawObj("PVCALC_Value");
	DrawText LASTPV_Value = (DrawText)Area.GetDrawObj("LASTPV_Value");
	DrawText PVHHTPEU_Value = (DrawText)Area.GetDrawObj("PVHHTPEU_Value");
	DrawText PVHITPEU_Value = (DrawText)Area.GetDrawObj("PVHITPEU_Value");
	DrawText PVLOTPEU_Value = (DrawText)Area.GetDrawObj("PVLOTPEU_Value");
	DrawText PVLLTPEU_Value = (DrawText)Area.GetDrawObj("PVLLTPEU_Value");
	DrawText PVROCPFL_Value = (DrawText)Area.GetDrawObj("PVROCPFL_Value");
	DrawText PVROCNFL_Value = (DrawText)Area.GetDrawObj("PVROCNFL_Value");
	DrawText PVEXEH_Value = (DrawText)Area.GetDrawObj("PVEXEH_Value");
	DrawText PVEUHI_Value = (DrawText)Area.GetDrawObj("PVEUHI_Value");
	DrawText PVEULO_Value = (DrawText)Area.GetDrawObj("PVEULO_Value");
	DrawText PVEXEL_Value = (DrawText)Area.GetDrawObj("PVEXEL_Value");
	DrawText PVRAWHI_Value = (DrawText)Area.GetDrawObj("PVRAWHI_Value");
	DrawText PVRAWLO_Value = (DrawText)Area.GetDrawObj("PVRAWLO_Value");
	DrawText URL_Value = (DrawText)Area.GetDrawObj("URL_Value");
	DrawText URV_Value = (DrawText)Area.GetDrawObj("URV_Value");
	DrawText LRL_Value = (DrawText)Area.GetDrawObj("LRL_Value");
	DrawText LRV_Value = (DrawText)Area.GetDrawObj("LRV_Value");
	DrawText PTEXECST_Value = (DrawText)Area.GetDrawObj("PTEXECST_Value");
	DrawText ALENBST_Value = (DrawText)Area.GetDrawObj("ALENBST_Value");
	DrawText OVERVAL_Value = (DrawText)Area.GetDrawObj("OVERVAL_Value");
	DrawText PNTFORM_Value = (DrawText)Area.GetDrawObj("PNTFORM_Value");
	DrawText PVRAW_Value = (DrawText)Area.GetDrawObj("PVRAW_Value");
	DrawText TF_Value = (DrawText)Area.GetDrawObj("TF_Value");
	DrawText C1_Value = (DrawText)Area.GetDrawObj("C1_Value");
	DrawText C2_Value = (DrawText)Area.GetDrawObj("C2_Value");

	PVAUTO.ForegroundColor = Color.Cyan;
	PVSOURCE.ForegroundColor = Color.Cyan;
	PVCALC.ForegroundColor = Color.Cyan;
	LASTPV.ForegroundColor = Color.Cyan;
	PVHHTPEU.ForegroundColor = Color.Yellow;
	PVHITPEU.ForegroundColor = Color.Yellow;
	PVLOTPEU.ForegroundColor = Color.Yellow;
	PVLLTPEU.ForegroundColor = Color.Yellow;
	PVROCPFL.ForegroundColor = Color.Yellow;
	PVROCNFL.ForegroundColor = Color.Yellow;
	PVEXEH.ForegroundColor = Color.Yellow;
	PVEUHI.ForegroundColor = Color.Yellow;
	PVEULO.ForegroundColor = Color.Yellow;
	PVEXEL.ForegroundColor = Color.Yellow;
	PVRAWHI.ForegroundColor = Color.Yellow;
	PVRAWLO.ForegroundColor = Color.Yellow;
	URL.ForegroundColor = Color.Yellow;
	URV.ForegroundColor = Color.Yellow;
	LRL.ForegroundColor = Color.Yellow;
	LRV.ForegroundColor = Color.Yellow;
	PTEXECST.ForegroundColor = Color.Cyan;
	ALENBST.ForegroundColor = Color.Cyan;
	OVERVAL.ForegroundColor = Color.Cyan;
	PNTFORM.ForegroundColor = Color.Cyan;
	PVRAW.ForegroundColor = Color.Cyan;  
	TF.ForegroundColor = Color.Cyan; 
	C1.ForegroundColor = Color.Cyan;
	C2.ForegroundColor = Color.Cyan;
	PAGE.ForegroundColor = Color.Lime;

	PVAUTO_Value.ForegroundColor = Color.Cyan;
	PVSOURCE_Value.ForegroundColor = Color.Cyan;
	PVCALC_Value.ForegroundColor = Color.Cyan;
	LASTPV_Value.ForegroundColor = Color.Cyan;
	PVHHTPEU_Value.ForegroundColor = Color.Yellow;
	PVHITPEU_Value.ForegroundColor = Color.Yellow;
	PVLOTPEU_Value.ForegroundColor = Color.Yellow;
	PVLLTPEU_Value.ForegroundColor = Color.Yellow;
	PVROCPFL_Value.ForegroundColor = Color.Yellow;
	PVROCNFL_Value.ForegroundColor = Color.Yellow;
	PVEXEH_Value.ForegroundColor = Color.Yellow;
	PVEUHI_Value.ForegroundColor = Color.Yellow;
	PVEULO_Value.ForegroundColor = Color.Yellow;
	PVEXEL_Value.ForegroundColor = Color.Yellow;
	PVRAWHI_Value.ForegroundColor = Color.Yellow;
	PVRAWLO_Value.ForegroundColor = Color.Yellow;
	URL_Value.ForegroundColor = Color.Yellow;
	URV_Value.ForegroundColor = Color.Yellow;
	LRL_Value.ForegroundColor = Color.Yellow;
	LRV_Value.ForegroundColor = Color.Yellow;
	PTEXECST_Value.ForegroundColor = Color.Cyan;
	ALENBST_Value.ForegroundColor = Color.Cyan;
	OVERVAL_Value.ForegroundColor = Color.Cyan;
	PNTFORM_Value.ForegroundColor = Color.Cyan;
	PVRAW_Value.ForegroundColor = Color.Cyan;  
	TF_Value.ForegroundColor = Color.Cyan; 
	C1_Value.ForegroundColor = Color.Cyan;
	C2_Value.ForegroundColor = Color.Cyan;

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
               PVCALC.ForegroundColor = Color.White;
               PVCALC_Value.ForegroundColor = Color.White;
      break;
      case "4":
               LASTPV.ForegroundColor = Color.White;
               LASTPV_Value.ForegroundColor = Color.White;
      break;
      case "5":
               PVHHTPEU.ForegroundColor = Color.White;
               PVHHTPEU_Value.ForegroundColor = Color.White;
      break;
      case "6":
               PVHITPEU.ForegroundColor = Color.White;
               PVHITPEU_Value.ForegroundColor = Color.White;
      break;
      case "7":
               PVLOTPEU.ForegroundColor = Color.White;
               PVLOTPEU_Value.ForegroundColor = Color.White;
      break;
      case "8":
               PVLLTPEU.ForegroundColor = Color.White;
               PVLLTPEU_Value.ForegroundColor = Color.White;
      break;
      case "9":
               PVROCPFL.ForegroundColor = Color.White;
               PVROCPFL_Value.ForegroundColor = Color.White;
      break;
      case "10":
               PVROCNFL.ForegroundColor = Color.White;
               PVROCNFL_Value.ForegroundColor = Color.White;
      break;
      case "11":
               PVEXEH.ForegroundColor = Color.White;
               PVEXEH_Value.ForegroundColor = Color.White;
      break;
      case "12":
               PVEUHI.ForegroundColor = Color.White;
               PVEUHI_Value.ForegroundColor = Color.White;
      break;
      case "13":
               PVEULO.ForegroundColor = Color.White;
               PVEULO_Value.ForegroundColor = Color.White;
      break;
      case "14":
               PVEXEL.ForegroundColor = Color.White;
               PVEXEL_Value.ForegroundColor = Color.White;
      break;
      case "15":
               PVRAWHI.ForegroundColor = Color.White;
               PVRAWHI_Value.ForegroundColor = Color.White;
      break;
      case "16":
               PVRAWLO.ForegroundColor = Color.White;
               PVRAWLO_Value.ForegroundColor = Color.White;
      break;
      case "17":
               URL.ForegroundColor = Color.White;
               URL_Value.ForegroundColor = Color.White;
      break;
      case "18":
               URV.ForegroundColor = Color.White;
               URV_Value.ForegroundColor = Color.White;
      break;
      case "19":
               LRL.ForegroundColor = Color.White;
               LRL_Value.ForegroundColor = Color.White;
      break;
      case "20":
               LRV.ForegroundColor = Color.White;
               LRV_Value.ForegroundColor = Color.White;
      break;
      case "21":
               PTEXECST.ForegroundColor = Color.White;
               PTEXECST_Value.ForegroundColor = Color.White;  
      break;
      case "22":
               ALENBST.ForegroundColor = Color.White;
               ALENBST_Value.ForegroundColor = Color.White;  
      break;
      case "23":
               OVERVAL.ForegroundColor = Color.White;
               OVERVAL_Value.ForegroundColor = Color.White;  
      break;
      case "24":
               PNTFORM.ForegroundColor = Color.White;
               PNTFORM_Value.ForegroundColor = Color.White;  
      break;
      case "25":
               PVRAW.ForegroundColor = Color.White;
               PVRAW_Value.ForegroundColor = Color.White;  
      break;
      case "26":
               TF.ForegroundColor = Color.White;
               TF_Value.ForegroundColor = Color.White; 
      break;
      case "27":
               C1.ForegroundColor = Color.White;
               C1_Value.ForegroundColor = Color.White; 
      break;
      case "28":
               C2.ForegroundColor = Color.White;
               C2_Value.ForegroundColor = Color.White; 
      break;
      case "29":
               PAGE.ForegroundColor = Color.White; 
      break;
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

    DrawArea L = (DrawArea)Area.GetDrawObj("TDC3000_faceplate_PAGE_PMANLIN");
    Area.Variable[2] = "1";
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "1";//设置标志位变色
    Area.Variable[1] = "29";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void TF_Value_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText TF_Value = (DrawText)dynArgs.sender; 

    GetValue(sender,e,Area.Variable[0],"TF","PVFORMAT");
    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void LASTPV_Value_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText LASTPV_Value = (DrawText)dynArgs.sender; 
   
    GetValue(sender,e,Area.Variable[0],"LASTPV","PVFORMAT");
    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void LASTPV_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText LASTPV = (DrawText)dynArgs.sender; 
   
    DrawArea L = (DrawArea)Area.GetDrawObj("TDC3000_faceplate_LIMITS");
    Area.Variable[2] = "3";
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "LASTPV";   
    Area.Variable[1] = "4";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void PVCALC_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVCALC = (DrawText)dynArgs.sender; 
   
    DrawArea L = (DrawArea)Area.GetDrawObj("TDC3000_faceplate_LIMITS");
    Area.Variable[2] = "3";
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "PVCALC";
    Area.Variable[1] = "3";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void PVCALC_Value_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVCALC_Value = (DrawText)dynArgs.sender; 
   
    GetValue(sender,e,Area.Variable[0],"PVCALC","PVFORMAT");
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
public void PVRAW_Value_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVRAW_Value = (DrawText)dynArgs.sender; 

    GetValue(sender,e,Area.Variable[0],"PVRAW","PVFORMAT");
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
public void PVRAWLO_Value_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVRAWLO_Value = (DrawText)dynArgs.sender; 

    GetValue(sender,e,Area.Variable[0],"PVRAWLO","PVFORMAT");
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void PVRAWHI_Value_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVRAWHI_Value = (DrawText)dynArgs.sender; 

    GetValue(sender,e,Area.Variable[0],"PVRAWHI","PVFORMAT");
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void PVEXEL_Value_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVEXEL_Value = (DrawText)dynArgs.sender; 

    GetValue(sender,e,Area.Variable[0],"PVEXEL","PVFORMAT");
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void PVEXEH_Value_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVEXEH_Value = (DrawText)dynArgs.sender; 

    GetValue(sender,e,Area.Variable[0],"PVEXEH","PVFORMAT");
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
public void PVROCNFL_Value_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVROCNFL_Value = (DrawText)dynArgs.sender; 

    GetValue(sender,e,Area.Variable[0],"PVROCNFL","PVFORMAT");
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void PVROCPFL_Value_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVROCPFL_Value = (DrawText)dynArgs.sender; 

    GetValue(sender,e,Area.Variable[0],"PVROCPFL","PVFORMAT");
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

    GetValue(sender,e,Area.Variable[0],"PVLLTPEU","PVFORMAT");
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

    GetValue(sender,e,Area.Variable[0],"PVLOTPEU","PVFORMAT");
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

    GetValue(sender,e,Area.Variable[0],"PVHITPEU","PVFORMAT");
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

    GetValue(sender,e,Area.Variable[0],"PVHHTPEU","PVFORMAT");
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
public void TF_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText TF = (DrawText)dynArgs.sender; 
   
    DrawArea L = (DrawArea)Area.GetDrawObj("TDC3000_faceplate_LIMITS");
    Area.Variable[2] = "3";
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "TF";
    Area.Variable[1] = "26";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void PVROCNFL_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVROCNFL = (DrawText)dynArgs.sender; 
   
    DrawArea L = (DrawArea)Area.GetDrawObj("TDC3000_faceplate_LIMITS");
    Area.Variable[2] = "3";
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "PVROCNFL";
    Area.Variable[1] = "10";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void PVROCPFL_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVROCPFL = (DrawText)dynArgs.sender; 
   
    DrawArea L = (DrawArea)Area.GetDrawObj("TDC3000_faceplate_LIMITS");
    Area.Variable[2] = "3";
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "PVROCPFL";
    Area.Variable[1] = "9";

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
    L.Variable[1] = "PVLLTPEU";
    Area.Variable[1] = "8";

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
    L.Variable[1] = "PVLOTPEU";
    Area.Variable[1] = "7";

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
    L.Variable[1] = "PVHITPEU";
    Area.Variable[1] = "6";

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
    L.Variable[1] = "PVHHTPEU";
    Area.Variable[1] = "5";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void PVRAWLO_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVRAWLO = (DrawText)dynArgs.sender; 
   
    DrawArea L = (DrawArea)Area.GetDrawObj("TDC3000_faceplate_LIMITS");
    Area.Variable[2] = "3";
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "PVRAWLO";
    Area.Variable[1] = "16";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void PVRAWHI_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVRAWHI = (DrawText)dynArgs.sender; 
   
    DrawArea L = (DrawArea)Area.GetDrawObj("TDC3000_faceplate_LIMITS");
    Area.Variable[2] = "3";
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "PVRAWHI";
    Area.Variable[1] = "15";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void PVEXEL_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVEXEL = (DrawText)dynArgs.sender; 
   
    DrawArea L = (DrawArea)Area.GetDrawObj("TDC3000_faceplate_LIMITS");
    Area.Variable[2] = "3";
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "PVEXEL";
    Area.Variable[1] = "14";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void PVEXEH_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVEXEH = (DrawText)dynArgs.sender; 
   
    DrawArea L = (DrawArea)Area.GetDrawObj("TDC3000_faceplate_LIMITS");
    Area.Variable[2] = "3";
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "PVEXEH";
    Area.Variable[1] = "11";

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
    Area.Variable[1] = "13";

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
    Area.Variable[1] = "12";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void PVRAW_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVRAW = (DrawText)dynArgs.sender; 
   
    DrawArea L = (DrawArea)Area.GetDrawObj("TDC3000_faceplate_LIMITS");
    Area.Variable[2] = "3";
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "PVRAW";
    Area.Variable[1] = "25";

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
    L.Variable[10] = "2";
    L.Variable[11] = "2";
    L.Variable[12] = "2";
    Area.Variable[1] = "24";

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
    Area.Variable[1] = "22";

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
    Area.Variable[1] = "21";

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
//Event Handler:OnDynClick 
public void PVAUTO_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVAUTO = (DrawText)dynArgs.sender; 
   
    DrawArea L = (DrawArea)Area.GetDrawObj("TDC3000_faceplate_LIMITS");
    Area.Variable[2] = "3";
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "PVAUTO";
    Area.Variable[1] = "1";

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
public void Detail_OnDynClick(Object sender, EventArgs e)
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
public void Detail_KeyUp(Object sender, KeyEventArgs e)
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
    return; 
}



//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void Detail_Rect8_OnDynAnimation(Object sender, EventArgs e)	//PVBar
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
public void Detail_Line16_OnDynAnimation(Object sender, EventArgs e)
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
public void Detail_LinePVTV_OnDynAnimation(Object sender, EventArgs e)
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
public void Detail_PV_OnDynAnimation(Object sender, EventArgs e)
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
public void Detail_PV_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PV = (DrawText)dynArgs.sender; 
  
    PV.Variable[0] = "1";
    DrawText P1 = (DrawText)Area.GetDrawObj("PVTV");
    P1.Variable[0] = "0";

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
public void Detail_PV_OnDynInitialize(Object sender, EventArgs e)
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
public void Detail_PVTV_OnDynAnimation(Object sender, EventArgs e)
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
public void Detail_PVTV_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVTV = (DrawText)dynArgs.sender; 

    PVTV.Variable[0] = "0"; 

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void Detail_PVTV_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVTV = (DrawText)dynArgs.sender; 
   
    PVTV.Variable[0] = "1";
    DrawText P1 = (DrawText)Area.GetDrawObj("PV");
    P1.Variable[0] = "0";

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
				CommonFunction.MoveControl(Area,TB,(int)(PVTV.VerticalPosition - 40),(int)(PVTV.HorizontalPosition)+40);		
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

    return; 
}

//Do not remove or update this comment
//Event Delegate:KeyEventHandler 
//Event Handler:KeyUp 
public void Detail_TB_KeyUp(Object sender, KeyEventArgs e)
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
public void TDC3000_faceplate_PAGE_PMANLIN_OnDynAnimation(Object sender, EventArgs e)
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
public void TDC3000_faceplate_PAGE_PMANLIN_Rect4_GROUP_OnDynClick(Object sender, EventArgs e)
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
public void TDC3000_faceplate_PAGE_PMANLIN_Rect3_CTLCONCT_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect3_CTLCONCT = (DrawRectangle)dynArgs.sender; 

	int nLeft = 0;
	int nTop = 0;
	string[] strVariable = new string[1];
	strVariable[0] = Area.Variable[0];
	CommonFunction.OpenPicture("TDC3000_PMANLIN_Detail2.grf", nTop, nLeft, strVariable);
        DrawArea pic = (DrawArea)(Area.Parent);
        pic.Variable[1] = "0";
        pic.Variable[2] = "0";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void TDC3000_faceplate_PAGE_PMANLIN_Rect1_FIRST_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect1_FIRST = (DrawRectangle)dynArgs.sender; 
   
	int nLeft = 0;
	int nTop = 0;
	string[] strVariable = new string[1];
	strVariable[0] = Area.Variable[0];
	CommonFunction.OpenPicture("TDC3000_PMANLIN_Detail1.grf", nTop, nLeft, strVariable);
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
c:\Users\haodongdong\AppData\Local\Temp\hyttcb1l.0.cs(29,23) : warning CS0168: 声明了变量“_MouseEventHandler”，但从未使用过
c:\Users\haodongdong\AppData\Local\Temp\hyttcb1l.0.cs(31,24) : warning CS0168: 声明了变量“_CancelEventHandler”，但从未使用过
c:\Users\haodongdong\AppData\Local\Temp\hyttcb1l.0.cs(32,24) : warning CS0168: 声明了变量“_ScrollEventHandler”，但从未使用过
c:\Users\haodongdong\AppData\Local\Temp\hyttcb1l.0.cs(465,23) : warning CS0168: 声明了变量“_MouseEventHandler”，但从未使用过
c:\Users\haodongdong\AppData\Local\Temp\hyttcb1l.0.cs(467,24) : warning CS0168: 声明了变量“_CancelEventHandler”，但从未使用过
c:\Users\haodongdong\AppData\Local\Temp\hyttcb1l.0.cs(468,24) : warning CS0168: 声明了变量“_ScrollEventHandler”，但从未使用过
c:\Users\haodongdong\AppData\Local\Temp\hyttcb1l.0.cs(2220,3) : warning CS0162: 检测到无法访问的代码
c:\Users\haodongdong\AppData\Local\Temp\hyttcb1l.0.cs(2297,9) : warning CS0219: 变量“PVValue”已赋值，但其值从未使用过
c:\Users\haodongdong\AppData\Local\Temp\hyttcb1l.0.cs(2697,3) : warning CS0162: 检测到无法访问的代码
c:\Users\haodongdong\AppData\Local\Temp\hyttcb1l.0.cs(2740,41) : error CS0117: “DrawTools.CommonFunction”并不包含“GetControlGroupNameByTag”的定义
c:\Users\haodongdong\AppData\Local\Temp\hyttcb1l.0.cs(3926,3) : warning CS0162: 检测到无法访问的代码
