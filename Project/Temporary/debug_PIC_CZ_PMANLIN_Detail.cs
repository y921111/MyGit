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
public class PIC_CZ_PMANLIN_Detail:IDynCodeAttachDetach
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
_EventHandler= (EventHandler)PIC_CZ_PMANLIN_Detail_OnDynInitialize;
CodeDomCommon.AttachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PIC_CZ_PMANLIN_Detail_OnDynAnimation;
CodeDomCommon.AttachAreaEventHandler(area,strEventName,_EventHandler);
strObjectName = "PAGE";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PAGE_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PAGE";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PAGE_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TF_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TF_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "LASTPV_Value";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)LASTPV_Value_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "LASTPV_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)LASTPV_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "LASTPV";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)LASTPV_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "LASTPV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)LASTPV_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVCALC";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVCALC_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVCALC";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVCALC_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVCALC_Value";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVCALC_Value_OnDynClick;
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
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVRAWLO_Value_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVRAWLO_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVRAWLO_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVRAWHI_Value";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVRAWHI_Value_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVRAWHI_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVRAWHI_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVEXEL_Value";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVEXEL_Value_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVEXEL_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVEXEL_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVEXEH_Value";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVEXEH_Value_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVEXEH_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVEXEH_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVEULO_Value";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVEULO_Value_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVEULO_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVEULO_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVEUHI_Value";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVEUHI_Value_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVEUHI_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVEUHI_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVSOURCE_Value";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVSOURCE_Value_OnDynClick;
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
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVROCNFL_Value_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVROCNFL_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVROCNFL_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVROCPFL_Value";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVROCPFL_Value_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVROCPFL_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVROCPFL_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVLLTPEU_Value";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVLLTPEU_Value_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVLLTPEU_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVLLTPEU_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVLOTPEU_Value";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVLOTPEU_Value_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVLOTPEU_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVLOTPEU_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVHITPEU_Value";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVHITPEU_Value_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVHITPEU_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVHITPEU_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVHHTPEU_Value";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVHHTPEU_Value_OnDynClick;
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
strObjectName = "TF";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TF_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVROCNFL";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVROCNFL_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVROCNFL";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVROCNFL_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVROCPFL";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVROCPFL_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVROCPFL";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVROCPFL_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVLLTPEU";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVLLTPEU_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVLLTPEU";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVLLTPEU_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVLOTPEU";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVLOTPEU_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVLOTPEU";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVLOTPEU_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVHITPEU";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVHITPEU_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVHITPEU";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVHITPEU_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVHHTPEU";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVHHTPEU_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVHHTPEU";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVHHTPEU_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVRAWLO";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVRAWLO_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVRAWLO";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVRAWLO_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVRAWHI";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVRAWHI_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVRAWHI";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVRAWHI_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVEXEL";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVEXEL_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVEXEL";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVEXEL_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVEXEH";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVEXEH_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVEXEH";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVEXEH_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVEULO";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVEULO_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVEULO";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVEULO_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVEUHI";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVEUHI_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVEUHI";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVEUHI_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVRAW";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVRAW_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVRAW";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVRAW_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PNTFORM";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PNTFORM_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PNTFORM";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PNTFORM_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "ALENBST";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)ALENBST_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "ALENBST";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)ALENBST_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PTEXECST";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PTEXECST_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PTEXECST";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PTEXECST_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVSOURCE";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVSOURCE_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVSOURCE";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVSOURCE_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVAUTO";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVAUTO_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVAUTO";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVAUTO_OnDynAnimation;
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
strEventName = "Disposed";
_EventHandler= (EventHandler)Detail_Disposed;
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
_EventHandler= (EventHandler)PIC_CZ_PMANLIN_Detail_OnDynInitialize;
CodeDomCommon.DetachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PIC_CZ_PMANLIN_Detail_OnDynAnimation;
CodeDomCommon.DetachAreaEventHandler(area,strEventName,_EventHandler);
strObjectName = "PAGE";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PAGE_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PAGE";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PAGE_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TF_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TF_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "LASTPV_Value";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)LASTPV_Value_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "LASTPV_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)LASTPV_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "LASTPV";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)LASTPV_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "LASTPV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)LASTPV_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVCALC";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVCALC_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVCALC";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVCALC_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVCALC_Value";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVCALC_Value_OnDynClick;
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
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVRAWLO_Value_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVRAWLO_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVRAWLO_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVRAWHI_Value";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVRAWHI_Value_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVRAWHI_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVRAWHI_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVEXEL_Value";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVEXEL_Value_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVEXEL_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVEXEL_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVEXEH_Value";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVEXEH_Value_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVEXEH_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVEXEH_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVEULO_Value";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVEULO_Value_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVEULO_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVEULO_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVEUHI_Value";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVEUHI_Value_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVEUHI_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVEUHI_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVSOURCE_Value";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVSOURCE_Value_OnDynClick;
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
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVROCNFL_Value_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVROCNFL_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVROCNFL_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVROCPFL_Value";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVROCPFL_Value_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVROCPFL_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVROCPFL_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVLLTPEU_Value";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVLLTPEU_Value_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVLLTPEU_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVLLTPEU_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVLOTPEU_Value";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVLOTPEU_Value_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVLOTPEU_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVLOTPEU_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVHITPEU_Value";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVHITPEU_Value_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVHITPEU_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVHITPEU_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVHHTPEU_Value";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVHHTPEU_Value_OnDynClick;
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
strObjectName = "TF";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TF_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVROCNFL";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVROCNFL_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVROCNFL";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVROCNFL_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVROCPFL";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVROCPFL_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVROCPFL";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVROCPFL_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVLLTPEU";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVLLTPEU_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVLLTPEU";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVLLTPEU_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVLOTPEU";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVLOTPEU_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVLOTPEU";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVLOTPEU_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVHITPEU";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVHITPEU_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVHITPEU";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVHITPEU_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVHHTPEU";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVHHTPEU_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVHHTPEU";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVHHTPEU_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVRAWLO";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVRAWLO_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVRAWLO";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVRAWLO_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVRAWHI";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVRAWHI_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVRAWHI";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVRAWHI_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVEXEL";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVEXEL_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVEXEL";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVEXEL_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVEXEH";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVEXEH_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVEXEH";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVEXEH_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVEULO";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVEULO_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVEULO";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVEULO_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVEUHI";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVEUHI_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVEUHI";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVEUHI_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVRAW";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVRAW_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVRAW";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVRAW_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PNTFORM";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PNTFORM_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PNTFORM";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PNTFORM_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "ALENBST";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)ALENBST_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "ALENBST";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)ALENBST_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PTEXECST";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PTEXECST_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PTEXECST";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PTEXECST_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVSOURCE";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVSOURCE_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVSOURCE";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVSOURCE_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVAUTO";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVAUTO_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVAUTO";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVAUTO_OnDynAnimation;
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
strEventName = "Disposed";
_EventHandler= (EventHandler)Detail_Disposed;
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
public void PIC_CZ_PMANLIN_Detail_OnDynInitialize(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 
 
   DrawArea L = (DrawArea)(Area.GetDrawObj("Detail_LIMITS"));
   L.Visible = false;

   DrawArea D = (DrawArea)(Area.GetDrawObj("Detail_POINTDATA"));
   D.Visible = false;

   DrawArea G = (DrawArea)(Area.GetDrawObj("Detail_PAGE"));
   G.Visible = false;
 
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
public void PIC_CZ_PMANLIN_Detail_OnDynAnimation(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 

   DrawArea L = (DrawArea)(Area.GetDrawObj("Detail_LIMITS"));
   DrawArea D = (DrawArea)(Area.GetDrawObj("Detail_POINTDATA"));
   DrawArea G = (DrawArea)(Area.GetDrawObj("Detail_PAGE"));

   if(G.Visible == true)
      {
         L.Visible = false;
         D.Visible = false;
       }
   if(D.Visible == true)
      {
         L.Visible = false;
         G.Visible = false;
       }
   if(L.Visible == true)
      {
         D.Visible = false;
         G.Visible = false;
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

        if(Area.Variable[1] == "1")
	    {
               PVAUTO.ForegroundColor = Color.White;
               PVAUTO_Value.ForegroundColor = Color.White;
            }
        if(Area.Variable[1] == "2")
	    {
               PVSOURCE.ForegroundColor = Color.White;
               PVSOURCE_Value.ForegroundColor = Color.White;
            }

        if(Area.Variable[1] == "3")
	    {
               PVCALC.ForegroundColor = Color.White;
               PVCALC_Value.ForegroundColor = Color.White;
            }
        if(Area.Variable[1] == "4")
	    {
               LASTPV.ForegroundColor = Color.White;
               LASTPV_Value.ForegroundColor = Color.White;
            }
        if(Area.Variable[1] == "5")
	    {
               PVHHTPEU.ForegroundColor = Color.White;
               PVHHTPEU_Value.ForegroundColor = Color.White;
            }
        if(Area.Variable[1] == "6")
	    {
               PVHITPEU.ForegroundColor = Color.White;
               PVHITPEU_Value.ForegroundColor = Color.White;
            }
        if(Area.Variable[1] == "7")
	    {
               PVLOTPEU.ForegroundColor = Color.White;
               PVLOTPEU_Value.ForegroundColor = Color.White;
            }
        if(Area.Variable[1] == "8")
	    {
               PVLLTPEU.ForegroundColor = Color.White;
               PVLLTPEU_Value.ForegroundColor = Color.White;
            }
        if(Area.Variable[1] == "9")
	    {
               PVROCPFL.ForegroundColor = Color.White;
               PVROCPFL_Value.ForegroundColor = Color.White;
            }
        if(Area.Variable[1] == "10")
	    {
               PVROCNFL.ForegroundColor = Color.White;
               PVROCNFL_Value.ForegroundColor = Color.White;
            }
        if(Area.Variable[1] == "11")
	    {
               PVEXEH.ForegroundColor = Color.White;
               PVEXEH_Value.ForegroundColor = Color.White;
            }
        if(Area.Variable[1] == "12")
	    {
               PVEUHI.ForegroundColor = Color.White;
               PVEUHI_Value.ForegroundColor = Color.White;
            }
        if(Area.Variable[1] == "13")
	    {
               PVEULO.ForegroundColor = Color.White;
               PVEULO_Value.ForegroundColor = Color.White;
            }
        if(Area.Variable[1] == "14")
	    {
               PVEXEL.ForegroundColor = Color.White;
               PVEXEL_Value.ForegroundColor = Color.White;
            }
        if(Area.Variable[1] == "15")
	    {
               PVRAWHI.ForegroundColor = Color.White;
               PVRAWHI_Value.ForegroundColor = Color.White;
            }
        if(Area.Variable[1] == "16")
	    {
               PVRAWLO.ForegroundColor = Color.White;
               PVRAWLO_Value.ForegroundColor = Color.White;
            }
        if(Area.Variable[1] == "17")
	    {
               URL.ForegroundColor = Color.White;
               URL_Value.ForegroundColor = Color.White;
            }
        if(Area.Variable[1] == "18")
	    {
               URV.ForegroundColor = Color.White;
               URV_Value.ForegroundColor = Color.White;
            }
        if(Area.Variable[1] == "19")
	    {
               LRL.ForegroundColor = Color.White;
               LRL_Value.ForegroundColor = Color.White;
            }
        if(Area.Variable[1] == "20")
	    {
               LRV.ForegroundColor = Color.White;
               LRV_Value.ForegroundColor = Color.White;
            }
        if(Area.Variable[1] == "21")
	    {
               PTEXECST.ForegroundColor = Color.White;
               PTEXECST_Value.ForegroundColor = Color.White;               
            }
        if(Area.Variable[1] == "22")
	    {
               ALENBST.ForegroundColor = Color.White;
               ALENBST_Value.ForegroundColor = Color.White;
            }
        if(Area.Variable[1] == "23")
	    {
               OVERVAL.ForegroundColor = Color.White;
               OVERVAL_Value.ForegroundColor = Color.White;
            }
        if(Area.Variable[1] == "24")
	    {
               PNTFORM.ForegroundColor = Color.White;
               PNTFORM_Value.ForegroundColor = Color.White;
            }
        if(Area.Variable[1] == "25")
	    {
               PVRAW.ForegroundColor = Color.White;
               PVRAW_Value.ForegroundColor = Color.White;               
            }
        if(Area.Variable[1] == "26")
	    {
               TF.ForegroundColor = Color.White;
               TF_Value.ForegroundColor = Color.White;               
            }
        if(Area.Variable[1] == "27")
	    {
               C1.ForegroundColor = Color.White;
               C1_Value.ForegroundColor = Color.White;                
            }
        if(Area.Variable[1] == "28")
	    {
               C2.ForegroundColor = Color.White;
               C2_Value.ForegroundColor = Color.White;                
            }
        if(Area.Variable[1] == "29")
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

    DrawArea D = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    D.Visible = false;   
    DrawArea P = (DrawArea)Area.GetDrawObj("Detail_POINTDATA");
    P.Visible = false;
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_PAGE");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "1";//设置标志位变色

    Area.Variable[1] = "29";

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
public void TF_Value_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText TF_Value = (DrawText)dynArgs.sender; 
   
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
	
	tagName = Area.Variable[0] + "/TF";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		TF_Value.Caption = dbValue.ToString(strDigit);
	}
	else
		TF_Value.Caption = "------";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void LASTPV_Value_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText LASTPV_Value = (DrawText)dynArgs.sender; 
   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "LASTPV";

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
	
	tagName = Area.Variable[0] + "/LASTPV";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		LASTPV_Value.Caption = dbValue.ToString(strDigit);
	}
	else
		LASTPV_Value.Caption = "------";

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
   
    DrawArea P = (DrawArea)Area.GetDrawObj("Detail_PAGE");
    P.Visible = false; 
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "LASTPV";
    DrawArea D = (DrawArea)(Area.GetDrawObj("Detail_POINTDATA"));
    D.Visible = false;
   
    LASTPV.ForegroundColor = Color.White;
    DrawText LASTPV_Value = (DrawText)Area.GetDrawObj("LASTPV_Value");
    LASTPV_Value.ForegroundColor = Color.White;

    Area.Variable[1] = "4";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void LASTPV_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText LASTPV = (DrawText)dynArgs.sender; 

    DrawText LASTPV_Value = (DrawText)Area.GetDrawObj("LASTPV_Value");   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    if(L.Visible == false)
       {
             LASTPV.ForegroundColor = Color.Cyan;
             LASTPV_Value.ForegroundColor = Color.Cyan;
       }
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
   
    DrawArea P = (DrawArea)Area.GetDrawObj("Detail_PAGE");
    P.Visible = false; 
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "PVCALC";
    DrawArea D = (DrawArea)(Area.GetDrawObj("Detail_POINTDATA"));
    D.Visible = false;
   
    PVCALC.ForegroundColor = Color.White;
    DrawText PVCALC_Value = (DrawText)Area.GetDrawObj("PVCALC_Value");
    PVCALC_Value.ForegroundColor = Color.White;

    Area.Variable[1] = "3";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void PVCALC_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVCALC = (DrawText)dynArgs.sender; 

    DrawText PVCALC_Value = (DrawText)Area.GetDrawObj("PVCALC_Value");   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    if(L.Visible == false)
       {
             PVCALC.ForegroundColor = Color.Cyan;
             PVCALC_Value.ForegroundColor = Color.Cyan;
       }
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void PVCALC_Value_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVCALC_Value = (DrawText)dynArgs.sender; 
   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "PVCALC";

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
	
	tagName = Area.Variable[0] + "/PVCALC";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		PVCALC_Value.Caption = dbValue.ToString(strDigit);
	}
	else
		PVCALC_Value.Caption = "------";

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
	
	tagName = Area.Variable[0] + "/PTEXECST";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		PTEXECST_Value.Caption = dbValue.ToString(strDigit);
	}
	else
		PTEXECST_Value.Caption = "------";

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
	
	tagName = Area.Variable[0] + "/PVRAW";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		PVRAW_Value.Caption = dbValue.ToString(strDigit);
	}
	else
		PVRAW_Value.Caption = "------";

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
	
	tagName = Area.Variable[0] + "/PNTFORM";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		PNTFORM_Value.Caption = dbValue.ToString(strDigit);
	}
	else
		PNTFORM_Value.Caption = "------";

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
	
	tagName = Area.Variable[0] + "/ALENBST";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		ALENBST_Value.Caption = dbValue.ToString(strDigit);
	}
	else
		ALENBST_Value.Caption = "------";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void PVRAWLO_Value_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVRAWLO_Value = (DrawText)dynArgs.sender; 
   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "PVRAWLO";

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
	
	tagName = Area.Variable[0] + "/PVRAWLO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		PVRAWLO_Value.Caption = dbValue.ToString(strDigit);
	}
	else
		PVRAWLO_Value.Caption = "------";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void PVRAWHI_Value_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVRAWHI_Value = (DrawText)dynArgs.sender; 
   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "PVRAWHI";

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
	
	tagName = Area.Variable[0] + "/PVRAWHI";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		PVRAWHI_Value.Caption = dbValue.ToString(strDigit);
	}
	else
		PVRAWHI_Value.Caption = "------";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void PVEXEL_Value_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVEXEL_Value = (DrawText)dynArgs.sender; 
   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "PVEXEL";

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
	
	tagName = Area.Variable[0] + "/PVEXEL";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		PVEXEL_Value.Caption = dbValue.ToString(strDigit);
	}
	else
		PVEXEL_Value.Caption = "------";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void PVEXEH_Value_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVEXEH_Value = (DrawText)dynArgs.sender; 
   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "PVEXEH";

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
	
	tagName = Area.Variable[0] + "/PVEXEH";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		PVEXEH_Value.Caption = dbValue.ToString(strDigit);
	}
	else
		PVEXEH_Value.Caption = "------";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void PVEULO_Value_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVEULO_Value = (DrawText)dynArgs.sender; 
   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "PVEULO";

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
		PVEULO_Value.Caption = dbValue.ToString(strDigit);
	}
	else
		PVEULO_Value.Caption = "------";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void PVEUHI_Value_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVEUHI_Value = (DrawText)dynArgs.sender; 
   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "PVEUHI";

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
	
	tagName = Area.Variable[0] + "/PVEUHI";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		PVEUHI_Value.Caption = dbValue.ToString(strDigit);
	}
	else
		PVEUHI_Value.Caption = "------";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void PVSOURCE_Value_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVSOURCE_Value = (DrawText)dynArgs.sender; 
   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "PVSOURCE";

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
public void PVROCNFL_Value_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVROCNFL_Value = (DrawText)dynArgs.sender; 
   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "PVROCNFL";

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
	
	tagName = Area.Variable[0] + "/PVROCNFL";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		PVROCNFL_Value.Caption = dbValue.ToString(strDigit);
	}
	else
		PVROCNFL_Value.Caption = "------";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void PVROCPFL_Value_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVROCPFL_Value = (DrawText)dynArgs.sender; 
   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "PVROCPFL";

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
	
	tagName = Area.Variable[0] + "/PVROCPFL";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		PVROCPFL_Value.Caption = dbValue.ToString(strDigit);
	}
	else
		PVROCPFL_Value.Caption = "------";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void PVLLTPEU_Value_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVLLTPEU_Value = (DrawText)dynArgs.sender; 
   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "PVLLTPEU";

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
	
	tagName = Area.Variable[0] + "/PVLLTPEU";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		PVLLTPEU_Value.Caption = dbValue.ToString(strDigit);
	}
	else
		PVLLTPEU_Value.Caption = "------";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void PVLOTPEU_Value_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVLOTPEU_Value = (DrawText)dynArgs.sender; 
   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "PVLOTPEU";

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
	
	tagName = Area.Variable[0] + "/PVLOTPEU";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		PVLOTPEU_Value.Caption = dbValue.ToString(strDigit);
	}
	else
		PVLOTPEU_Value.Caption = "------";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void PVHITPEU_Value_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVHITPEU_Value = (DrawText)dynArgs.sender; 
   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "PVHITPEU";

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
	
	tagName = Area.Variable[0] + "/PVHITPEU";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		PVHITPEU_Value.Caption = dbValue.ToString(strDigit);
	}
	else
		PVHITPEU_Value.Caption = "------";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void PVHHTPEU_Value_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVHHTPEU_Value = (DrawText)dynArgs.sender; 
   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "PVHHTPEU";

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
	
	tagName = Area.Variable[0] + "/PVHHTPEU";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		PVHHTPEU_Value.Caption = dbValue.ToString(strDigit);
	}
	else
		PVHHTPEU_Value.Caption = "------";

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
   
    DrawArea P = (DrawArea)Area.GetDrawObj("Detail_PAGE");
    P.Visible = false; 
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "TF";
    DrawArea D = (DrawArea)(Area.GetDrawObj("Detail_POINTDATA"));
    D.Visible = false;
   
    TF.ForegroundColor = Color.White;
    DrawText TF_Value = (DrawText)Area.GetDrawObj("TF_Value");
    TF_Value.ForegroundColor = Color.White;

    Area.Variable[1] = "26";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void TF_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText TF = (DrawText)dynArgs.sender; 

    DrawText TF_Value = (DrawText)Area.GetDrawObj("TF_Value");   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    if(L.Visible == false)
       {
             TF.ForegroundColor = Color.Cyan;
             TF_Value.ForegroundColor = Color.Cyan;
       }
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
   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "PVROCNFL";
   DrawArea D = (DrawArea)(Area.GetDrawObj("Detail_POINTDATA"));
   D.Visible = false;
    DrawArea P = (DrawArea)Area.GetDrawObj("Detail_PAGE");
    P.Visible = false; 
   
    PVROCNFL.ForegroundColor = Color.White;
    DrawText PVROCNFL_Value = (DrawText)Area.GetDrawObj("PVROCNFL_Value");
    PVROCNFL_Value.ForegroundColor = Color.White;

    Area.Variable[1] = "10";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void PVROCNFL_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVROCNFL = (DrawText)dynArgs.sender; 

    DrawText PVROCNFL_Value = (DrawText)Area.GetDrawObj("PVROCNFL_Value");   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    if(L.Visible == false)
       {
             PVROCNFL.ForegroundColor = Color.Yellow;
             PVROCNFL_Value.ForegroundColor = Color.Yellow;
       }
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
   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "PVROCPFL";
   DrawArea D = (DrawArea)(Area.GetDrawObj("Detail_POINTDATA"));
   D.Visible = false;
    DrawArea P = (DrawArea)Area.GetDrawObj("Detail_PAGE");
    P.Visible = false; 
   
    PVROCPFL.ForegroundColor = Color.White;
    DrawText PVROCPFL_Value = (DrawText)Area.GetDrawObj("PVROCPFL_Value");
    PVROCPFL_Value.ForegroundColor = Color.White;

    Area.Variable[1] = "9";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void PVROCPFL_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVROCPFL = (DrawText)dynArgs.sender; 

    DrawText PVROCPFL_Value = (DrawText)Area.GetDrawObj("PVROCPFL_Value");   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    if(L.Visible == false)
       {
             PVROCPFL.ForegroundColor = Color.Yellow;
             PVROCPFL_Value.ForegroundColor = Color.Yellow;
       }
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
   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "PVLLTPEU";
   DrawArea D = (DrawArea)(Area.GetDrawObj("Detail_POINTDATA"));
   D.Visible = false;
    DrawArea P = (DrawArea)Area.GetDrawObj("Detail_PAGE");
    P.Visible = false; 
   
    PVLLTPEU.ForegroundColor = Color.White;
    DrawText PVLLTPEU_Value = (DrawText)Area.GetDrawObj("PVLLTPEU_Value");
    PVLLTPEU_Value.ForegroundColor = Color.White;

    Area.Variable[1] = "8";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void PVLLTPEU_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVLLTPEU = (DrawText)dynArgs.sender; 

    DrawText PVLLTPEU_Value = (DrawText)Area.GetDrawObj("PVLLTPEU_Value");   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    if(L.Visible == false)
       {
             PVLLTPEU.ForegroundColor = Color.Yellow;
             PVLLTPEU_Value.ForegroundColor = Color.Yellow;
       }
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
   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "PVLOTPEU";
   DrawArea D = (DrawArea)(Area.GetDrawObj("Detail_POINTDATA"));
   D.Visible = false;
    DrawArea P = (DrawArea)Area.GetDrawObj("Detail_PAGE");
    P.Visible = false; 
   
    PVLOTPEU.ForegroundColor = Color.White;
    DrawText PVLOTPEU_Value = (DrawText)Area.GetDrawObj("PVLOTPEU_Value");
    PVLOTPEU_Value.ForegroundColor = Color.White;

    Area.Variable[1] = "7";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void PVLOTPEU_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVLOTPEU = (DrawText)dynArgs.sender; 

    DrawText PVLOTPEU_Value = (DrawText)Area.GetDrawObj("PVLOTPEU_Value");   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    if(L.Visible == false)
       {
             PVLOTPEU.ForegroundColor = Color.Yellow;
             PVLOTPEU_Value.ForegroundColor = Color.Yellow;
       }
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
   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "PVHITPEU";
   DrawArea D = (DrawArea)(Area.GetDrawObj("Detail_POINTDATA"));
   D.Visible = false;
    DrawArea P = (DrawArea)Area.GetDrawObj("Detail_PAGE");
    P.Visible = false; 
   
    PVHITPEU.ForegroundColor = Color.White;
    DrawText PVHITPEU_Value = (DrawText)Area.GetDrawObj("PVHITPEU_Value");
    PVHITPEU_Value.ForegroundColor = Color.White;

    Area.Variable[1] = "6";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void PVHITPEU_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVHITPEU = (DrawText)dynArgs.sender; 

    DrawText PVHITPEU_Value = (DrawText)Area.GetDrawObj("PVHITPEU_Value");   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    if(L.Visible == false)
       {
             PVHITPEU.ForegroundColor = Color.Yellow;
             PVHITPEU_Value.ForegroundColor = Color.Yellow;
       }
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
   
    DrawArea P = (DrawArea)Area.GetDrawObj("Detail_PAGE");
    P.Visible = false; 
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "PVHHTPEU";
    DrawArea D = (DrawArea)(Area.GetDrawObj("Detail_POINTDATA"));
    D.Visible = false;
   
    PVHHTPEU.ForegroundColor = Color.White;
    DrawText PVHHTPEU_Value = (DrawText)Area.GetDrawObj("PVHHTPEU_Value");
    PVHHTPEU_Value.ForegroundColor = Color.White;

    Area.Variable[1] = "5";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void PVHHTPEU_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVHHTPEU = (DrawText)dynArgs.sender; 

    DrawText PVHHTPEU_Value = (DrawText)Area.GetDrawObj("PVHHTPEU_Value");   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    if(L.Visible == false)
       {
             PVHHTPEU.ForegroundColor = Color.Yellow;
             PVHHTPEU_Value.ForegroundColor = Color.Yellow;
       }
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
   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "PVRAWLO";
   DrawArea D = (DrawArea)(Area.GetDrawObj("Detail_POINTDATA"));
   D.Visible = false;
    DrawArea P = (DrawArea)Area.GetDrawObj("Detail_PAGE");
    P.Visible = false; 
   
    PVRAWLO.ForegroundColor = Color.White;
    DrawText PVRAWLO_Value = (DrawText)Area.GetDrawObj("PVRAWLO_Value");
    PVRAWLO_Value.ForegroundColor = Color.White;

    Area.Variable[1] = "16";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void PVRAWLO_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVRAWLO = (DrawText)dynArgs.sender; 

    DrawText PVRAWLO_Value = (DrawText)Area.GetDrawObj("PVRAWLO_Value");   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    if(L.Visible == false)
       {
             PVRAWLO.ForegroundColor = Color.Yellow;
             PVRAWLO_Value.ForegroundColor = Color.Yellow;
       }
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
   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "PVRAWHI";
   DrawArea D = (DrawArea)(Area.GetDrawObj("Detail_POINTDATA"));
   D.Visible = false;
    DrawArea P = (DrawArea)Area.GetDrawObj("Detail_PAGE");
    P.Visible = false; 
   
    PVRAWHI.ForegroundColor = Color.White;
    DrawText PVRAWHI_Value = (DrawText)Area.GetDrawObj("PVRAWHI_Value");
    PVRAWHI_Value.ForegroundColor = Color.White;

    Area.Variable[1] = "15";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void PVRAWHI_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVRAWHI = (DrawText)dynArgs.sender; 

    DrawText PVRAWHI_Value = (DrawText)Area.GetDrawObj("PVRAWHI_Value");   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    if(L.Visible == false)
       {
             PVRAWHI.ForegroundColor = Color.Yellow;
             PVRAWHI_Value.ForegroundColor = Color.Yellow;
       }
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
   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "PVEXEL";
   DrawArea D = (DrawArea)(Area.GetDrawObj("Detail_POINTDATA"));
   D.Visible = false;
    DrawArea P = (DrawArea)Area.GetDrawObj("Detail_PAGE");
    P.Visible = false; 
   
    PVEXEL.ForegroundColor = Color.White;
    DrawText PVEXEL_Value = (DrawText)Area.GetDrawObj("PVEXEL_Value");
    PVEXEL_Value.ForegroundColor = Color.White;

    Area.Variable[1] = "14";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void PVEXEL_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVEXEL = (DrawText)dynArgs.sender; 

    DrawText PVEXEL_Value = (DrawText)Area.GetDrawObj("PVEXEL_Value");   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    if(L.Visible == false)
       {
             PVEXEL.ForegroundColor = Color.Yellow;
             PVEXEL_Value.ForegroundColor = Color.Yellow;
       }
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
   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "PVEXEH";
   DrawArea D = (DrawArea)(Area.GetDrawObj("Detail_POINTDATA"));
   D.Visible = false;
    DrawArea P = (DrawArea)Area.GetDrawObj("Detail_PAGE");
    P.Visible = false; 
   
    PVEXEH.ForegroundColor = Color.White;
    DrawText PVEXEH_Value = (DrawText)Area.GetDrawObj("PVEXEH_Value");
    PVEXEH_Value.ForegroundColor = Color.White;

    Area.Variable[1] = "11";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void PVEXEH_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVEXEH = (DrawText)dynArgs.sender; 

    DrawText PVEXEH_Value = (DrawText)Area.GetDrawObj("PVEXEH_Value");   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    if(L.Visible == false)
       {
             PVEXEH.ForegroundColor = Color.Yellow;
             PVEXEH_Value.ForegroundColor = Color.Yellow;
       }
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
   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "PVEULO";
   DrawArea D = (DrawArea)(Area.GetDrawObj("Detail_POINTDATA"));
   D.Visible = false;
    DrawArea P = (DrawArea)Area.GetDrawObj("Detail_PAGE");
    P.Visible = false; 
   
    PVEULO.ForegroundColor = Color.White;
    DrawText PVEULO_Value = (DrawText)Area.GetDrawObj("PVEULO_Value");
    PVEULO_Value.ForegroundColor = Color.White;

    Area.Variable[1] = "13";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void PVEULO_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVEULO = (DrawText)dynArgs.sender; 

    DrawText PVEULO_Value = (DrawText)Area.GetDrawObj("PVEULO_Value");   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    if(L.Visible == false)
       {
             PVEULO.ForegroundColor = Color.Yellow;
             PVEULO_Value.ForegroundColor = Color.Yellow;
       }
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
   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "PVEUHI";
   DrawArea D = (DrawArea)(Area.GetDrawObj("Detail_POINTDATA"));
   D.Visible = false;
    DrawArea P = (DrawArea)Area.GetDrawObj("Detail_PAGE");
    P.Visible = false; 
   
    PVEUHI.ForegroundColor = Color.White;
    DrawText PVEUHI_Value = (DrawText)Area.GetDrawObj("PVEUHI_Value");
    PVEUHI_Value.ForegroundColor = Color.White;

    Area.Variable[1] = "12";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void PVEUHI_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVEUHI = (DrawText)dynArgs.sender; 

    DrawText PVEUHI_Value = (DrawText)Area.GetDrawObj("PVEUHI_Value");   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    if(L.Visible == false)
       {
             PVEUHI.ForegroundColor = Color.Yellow;
             PVEUHI_Value.ForegroundColor = Color.Yellow;
       }
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
   
    DrawArea P = (DrawArea)Area.GetDrawObj("Detail_PAGE");
    P.Visible = false; 
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "PVRAW";
    DrawArea D = (DrawArea)(Area.GetDrawObj("Detail_POINTDATA"));
    D.Visible = false;
   
    PVRAW.ForegroundColor = Color.White;
    DrawText PVRAW_Value = (DrawText)Area.GetDrawObj("PVRAW_Value");
    PVRAW_Value.ForegroundColor = Color.White;

    Area.Variable[1] = "25";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void PVRAW_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVRAW = (DrawText)dynArgs.sender; 

    DrawText PVRAW_Value = (DrawText)Area.GetDrawObj("PVRAW_Value");   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    if(L.Visible == false)
       {
             PVRAW.ForegroundColor = Color.Cyan;
             PVRAW_Value.ForegroundColor = Color.Cyan;
       }
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
  
    DrawArea P = (DrawArea)Area.GetDrawObj("Detail_PAGE");
    P.Visible = false; 
    DrawArea D = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    D.Visible = false;   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_POINTDATA");
    L.Visible = true;
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
   
    PNTFORM.ForegroundColor = Color.White;
    DrawText PNTFORM_Value = (DrawText)Area.GetDrawObj("PNTFORM_Value");
    PNTFORM_Value.ForegroundColor = Color.White;

    Area.Variable[1] = "24";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void PNTFORM_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PNTFORM = (DrawText)dynArgs.sender; 

    DrawText PNTFORM_Value = (DrawText)Area.GetDrawObj("PNTFORM_Value");   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_POINTDATA");
    if(L.Visible == false)
       {
             PNTFORM.ForegroundColor = Color.Cyan;
             PNTFORM_Value.ForegroundColor = Color.Cyan;
       }
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

    DrawArea P = (DrawArea)Area.GetDrawObj("Detail_PAGE");
    P.Visible = false; 
    DrawArea D = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    D.Visible = false;     
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_POINTDATA");
    L.Visible = true;

    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "ALENBST";

    L.Variable[3] = "ENABLE";
    L.Variable[4] = "DISENABLE";
    L.Variable[5] = "INHIBIT";
    L.Variable[6] = "N";
    L.Variable[7] = "N";

    L.Variable[8] = "1";
    L.Variable[9] = "2";
    L.Variable[10] = "3";
    L.Variable[11] = "0";
    L.Variable[12] = "0";
   
    ALENBST.ForegroundColor = Color.White;
    DrawText ALENBST_Value = (DrawText)Area.GetDrawObj("ALENBST_Value");
    ALENBST_Value.ForegroundColor = Color.White;

    Area.Variable[1] = "22";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void ALENBST_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText ALENBST = (DrawText)dynArgs.sender; 

    DrawText ALENBST_Value = (DrawText)Area.GetDrawObj("ALENBST_Value");   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_POINTDATA");
    if(L.Visible == false)
       {
             ALENBST.ForegroundColor = Color.Cyan;
             ALENBST_Value.ForegroundColor = Color.Cyan;
       }
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

    DrawArea D = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    D.Visible = false; 
    DrawArea P = (DrawArea)Area.GetDrawObj("Detail_PAGE");
    P.Visible = false;  
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_POINTDATA");
    L.Visible = true;
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
   
    PTEXECST.ForegroundColor = Color.White;
    DrawText PTEXECST_Value = (DrawText)Area.GetDrawObj("PTEXECST_Value");
    PTEXECST_Value.ForegroundColor = Color.White;

    Area.Variable[1] = "21";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void PTEXECST_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PTEXECST = (DrawText)dynArgs.sender; 

    DrawText PTEXECST_Value = (DrawText)Area.GetDrawObj("PTEXECST_Value");   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_POINTDATA");
    if(L.Visible == false)
       {
             PTEXECST.ForegroundColor = Color.Cyan;
             PTEXECST_Value.ForegroundColor = Color.Cyan;
       }
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
   
    DrawArea P = (DrawArea)Area.GetDrawObj("Detail_PAGE");
    P.Visible = false; 
    DrawArea D = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    D.Visible = false; 
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_POINTDATA");
    L.Visible = true;
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
   
    PVSOURCE.ForegroundColor = Color.White;
    DrawText PVSOURCE_Value = (DrawText)Area.GetDrawObj("PVSOURCE_Value");
    PVSOURCE_Value.ForegroundColor = Color.White;

    Area.Variable[1] = "2";

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

    DrawText PVSOURCE_Value = (DrawText)Area.GetDrawObj("PVSOURCE_Value");   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_POINTDATA");
    if(L.Visible == false)
       {
             PVSOURCE.ForegroundColor = Color.Cyan;
             PVSOURCE_Value.ForegroundColor = Color.Cyan;
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
   DrawArea D = (DrawArea)(Area.GetDrawObj("Detail_POINTDATA"));
   D.Visible = false;
    DrawArea P = (DrawArea)Area.GetDrawObj("Detail_PAGE");
    P.Visible = false; 
   
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
             PVAUTO.ForegroundColor = Color.Yellow;
             PVAUTO_Value.ForegroundColor = Color.Yellow;
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

/*        DrawArea picT = (DrawArea)(Area.Parent);
	Area.Variable[0] = picT.Variable[0];	
	Area.Enabled = true;
*/

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
//Event Delegate:EventHandler 
//Event Handler:Disposed 
public void Detail_Disposed(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 

   TextBox TB = (TextBox)Area.GetDrawObj("TB");
   TB.Enabled = false;
    return; 
}
//Do not remove or update this comment
//Event Delegate:KeyEventHandler 
//Event Handler:KeyUp 
public void Detail_KeyUp(Object sender, KeyEventArgs e)
{
   TextBox TB = (TextBox)sender; 

   DrawArea Area = CommonFunction.GetThisDrawArea(TB);

   DrawArea pic = (DrawArea)(Area.Parent);
   DrawArea Top = (DrawArea)pic.GetDrawObj("TDC3000_Top");

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
				          Top.Variable[4] = "LMT OR RANGE ERROR";
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
                                        Top.Variable[4] = "LMT OR RANGE ERROR";
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
Top.Variable[4] = "";
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

    object obj = Area.GetControlObj("TB");
	
	TextBox TB = (TextBox)obj; 

          if(TB.Visible == false)

            {
                PV.ForegroundColor = Color.Cyan;
//                DrawText Text_PV = (DrawText)Area.GetDrawObj("Text_PV");
//                Text_PV.ForegroundColor = Color.Cyan;
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
  
    PV.ForegroundColor = Color.White;
//    DrawText Text_PV = (DrawText)Area.GetDrawObj("Text_PV");
//    Text_PV.ForegroundColor = Color.White;

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

    object obj = Area.GetControlObj("TB");
	
	TextBox TB = (TextBox)obj; 

          if(TB.Visible == false)

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

    PVTV.ForegroundColor = Color.Cyan; 

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
   
    PVTV.ForegroundColor = Color.White;
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

   DrawArea pic = (DrawArea)(Area.Parent);
   DrawArea Top = (DrawArea)pic.GetDrawObj("TDC3000_Top");

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
				          Top.Variable[4] = "LMT OR RANGE ERROR";
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
                                        Top.Variable[4] = "LMT OR RANGE ERROR";
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
Top.Variable[4] = "";
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
	CommonFunction.OpenPicture("GROUP.grf", nTop, nLeft, strVariable);
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
	CommonFunction.OpenPicture("CZ_PMANLIN_Detail2.grf", nTop, nLeft, strVariable);
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
	CommonFunction.OpenPicture("CZ_PMANLIN_Detail.grf", nTop, nLeft, strVariable);

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
//MessageBox.Show(TB.Text);
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

//   DrawArea pic = (DrawArea)(Area.Parent);
//   DrawArea Top = (DrawArea)pic.GetDrawObj("TDC3000_Top");

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
                             //ENTER.Variable[0] = TB.Text;
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

/*          
          DrawText Caption2 = (DrawText)Area.GetDrawObj("Caption2");
          Caption2.Caption = "";
*/
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
