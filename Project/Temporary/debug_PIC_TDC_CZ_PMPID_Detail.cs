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
public class PIC_TDC_CZ_PMPID_Detail:IDynCodeAttachDetach
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
_EventHandler= (EventHandler)PIC_TDC_CZ_PMPID_Detail_OnDynInitialize;
CodeDomCommon.AttachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PIC_TDC_CZ_PMPID_Detail_OnDynAnimation;
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
strEventName = "OnDynClick";
_EventHandler= (EventHandler)OPLO_Value_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OPLO_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)OPLO_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OPHI_Value";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)OPHI_Value_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OPHI_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)OPHI_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SPEULO_Value";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)SPEULO_Value_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SPEULO_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)SPEULO_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SPEUHI_Value";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)SPEUHI_Value_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SPEUHI_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)SPEUHI_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CVEULO_Value";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CVEULO_Value_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CVEULO_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CVEULO_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CVEUHI_Value";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CVEUHI_Value_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CVEUHI_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CVEUHI_Value_OnDynAnimation;
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
strObjectName = "PVROCNTP_Value";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVROCNTP_Value_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVROCNTP_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVROCNTP_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVROCPTP_Value";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVROCPTP_Value_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVROCPTP_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVROCPTP_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DEVLO_Value";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DEVLO_Value_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DEVLO_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DEVLO_Value_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DEVHI_Value";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DEVHI_Value_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DEVHI_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DEVHI_Value_OnDynAnimation;
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
strObjectName = "PAGE";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PAGE_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PAGE";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PAGE_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DEVLO";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DEVLO_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DEVLO";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DEVLO_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DEVHI";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DEVHI_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DEVHI";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DEVHI_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVROCNTP";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVROCNTP_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVROCNTP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVROCNTP_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVROCPTP";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVROCPTP_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVROCPTP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVROCPTP_OnDynAnimation;
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
strObjectName = "OPLO";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)OPLO_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OPLO";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)OPLO_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OPHI";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)OPHI_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OPHI";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)OPHI_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SPEULO";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)SPEULO_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SPEULO";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)SPEULO_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SPEUHI";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)SPEUHI_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SPEUHI";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)SPEUHI_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CVEULO";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CVEULO_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CVEULO";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CVEULO_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CVEUHI";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CVEUHI_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CVEUHI";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CVEUHI_OnDynAnimation;
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
strObjectName = "PNTFORM";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PNTFORM_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PNTFORM";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PNTFORM_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "NMODATTR";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)NMODATTR_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "NMODATTR";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)NMODATTR_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "NMODE";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)NMODE_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "NMODE";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)NMODE_OnDynAnimation;
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
_EventHandler= (EventHandler)PIC_TDC_CZ_PMPID_Detail_OnDynInitialize;
CodeDomCommon.DetachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PIC_TDC_CZ_PMPID_Detail_OnDynAnimation;
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
strEventName = "OnDynClick";
_EventHandler= (EventHandler)OPLO_Value_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OPLO_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)OPLO_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OPHI_Value";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)OPHI_Value_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OPHI_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)OPHI_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SPEULO_Value";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)SPEULO_Value_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SPEULO_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)SPEULO_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SPEUHI_Value";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)SPEUHI_Value_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SPEUHI_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)SPEUHI_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CVEULO_Value";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CVEULO_Value_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CVEULO_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CVEULO_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CVEUHI_Value";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CVEUHI_Value_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CVEUHI_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CVEUHI_Value_OnDynAnimation;
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
strObjectName = "PVROCNTP_Value";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVROCNTP_Value_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVROCNTP_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVROCNTP_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVROCPTP_Value";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVROCPTP_Value_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVROCPTP_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVROCPTP_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DEVLO_Value";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DEVLO_Value_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DEVLO_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DEVLO_Value_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DEVHI_Value";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DEVHI_Value_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DEVHI_Value";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DEVHI_Value_OnDynAnimation;
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
strObjectName = "PAGE";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PAGE_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PAGE";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PAGE_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DEVLO";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DEVLO_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DEVLO";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DEVLO_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DEVHI";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DEVHI_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DEVHI";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DEVHI_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVROCNTP";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVROCNTP_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVROCNTP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVROCNTP_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVROCPTP";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PVROCPTP_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVROCPTP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVROCPTP_OnDynAnimation;
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
strObjectName = "OPLO";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)OPLO_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OPLO";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)OPLO_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OPHI";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)OPHI_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OPHI";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)OPHI_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SPEULO";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)SPEULO_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SPEULO";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)SPEULO_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SPEUHI";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)SPEUHI_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SPEUHI";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)SPEUHI_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CVEULO";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CVEULO_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CVEULO";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CVEULO_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CVEUHI";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CVEUHI_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CVEUHI";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CVEUHI_OnDynAnimation;
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
strObjectName = "PNTFORM";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PNTFORM_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PNTFORM";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PNTFORM_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "NMODATTR";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)NMODATTR_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "NMODATTR";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)NMODATTR_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "NMODE";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)NMODE_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "NMODE";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)NMODE_OnDynAnimation;
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
public void PIC_TDC_CZ_PMPID_Detail_OnDynInitialize(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 
 
   DrawArea P = (DrawArea)(Area.GetDrawObj("Group_Detail_1"));
   P.Visible = false;

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
public void PIC_TDC_CZ_PMPID_Detail_OnDynAnimation(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 

   DrawArea P = (DrawArea)(Area.GetDrawObj("Group_Detail_1"));
   DrawArea L = (DrawArea)(Area.GetDrawObj("Detail_LIMITS"));
   DrawArea D = (DrawArea)(Area.GetDrawObj("Detail_POINTDATA"));
   DrawArea G = (DrawArea)(Area.GetDrawObj("Detail_PAGE"));

   if(G.Visible == true)
      {
         P.Visible = false;
         L.Visible = false;
         D.Visible = false;
       }
   if(D.Visible == true)
      {
         P.Visible = false;
         L.Visible = false;
         G.Visible = false;
       }
   if(L.Visible == true)
      {
         P.Visible = false;
         D.Visible = false;
         G.Visible = false;
       }
   if(P.Visible == true)
      {
         L.Visible = false;
         D.Visible = false;
         G.Visible = false;
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
	ALENBST_Value.ForegroundColor = Color.Cyan;
	NMODE_Value.ForegroundColor = Color.Cyan;
	NMODATTR_Value.ForegroundColor = Color.Cyan;
	PNTFORM_Value.ForegroundColor = Color.Cyan;


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
               PVHHTPEU.ForegroundColor = Color.White;
               PVHHTPEU_Value.ForegroundColor = Color.White;
            }
        if(Area.Variable[1] == "4")
	    {
               PVHITPEU.ForegroundColor = Color.White;
               PVHITPEU_Value.ForegroundColor = Color.White;
            }
        if(Area.Variable[1] == "5")
	    {
               PVLOTPEU.ForegroundColor = Color.White;
               PVLOTPEU_Value.ForegroundColor = Color.White;
            }
        if(Area.Variable[1] == "6")
	    {
               PVLLTPEU.ForegroundColor = Color.White;
               PVLLTPEU_Value.ForegroundColor = Color.White;
            }
        if(Area.Variable[1] == "7")
	    {
               PVROCPTP.ForegroundColor = Color.White;
               PVROCPTP_Value.ForegroundColor = Color.White;
            }
        if(Area.Variable[1] == "8")
	    {
               PVROCNTP.ForegroundColor = Color.White;
               PVROCNTP_Value.ForegroundColor = Color.White;
            }
        if(Area.Variable[1] == "9")
	    {
               DEVHI.ForegroundColor = Color.White;
               DEVHI_Value.ForegroundColor = Color.White;
            }
        if(Area.Variable[1] == "10")
	    {
               DEVLO.ForegroundColor = Color.White;
               DEVLO_Value.ForegroundColor = Color.White;
            }
        if(Area.Variable[1] == "11")
	    {
               PVEUHI.ForegroundColor = Color.White;
               PVEUHI_Value.ForegroundColor = Color.White;
            }
        if(Area.Variable[1] == "12")
	    {
               PVEULO.ForegroundColor = Color.White;
               PVEULO_Value.ForegroundColor = Color.White;
            }
        if(Area.Variable[1] == "13")
	    {
               CVEUHI.ForegroundColor = Color.White;
               CVEUHI_Value.ForegroundColor = Color.White;
            }
        if(Area.Variable[1] == "14")
	    {
               CVEULO.ForegroundColor = Color.White;
               CVEULO_Value.ForegroundColor = Color.White;
            }
        if(Area.Variable[1] == "15")
	    {
               SPEUHI.ForegroundColor = Color.White;
               SPEUHI_Value.ForegroundColor = Color.White;
            }
        if(Area.Variable[1] == "16")
	    {
               SPEULO.ForegroundColor = Color.White;
               SPEULO_Value.ForegroundColor = Color.White;
            }
        if(Area.Variable[1] == "17")
	    {
               OPHI.ForegroundColor = Color.White;
               OPHI_Value.ForegroundColor = Color.White;
            }
        if(Area.Variable[1] == "18")
	    {
               OPLO.ForegroundColor = Color.White;
               OPLO_Value.ForegroundColor = Color.White;
            }
        if(Area.Variable[1] == "19")
	    {
               PTEXECST.ForegroundColor = Color.White;
               PTEXECST_Value.ForegroundColor = Color.White;               
            }
        if(Area.Variable[1] == "20")
	    {
               ALENBST.ForegroundColor = Color.White;
               ALENBST_Value.ForegroundColor = Color.White;
            }
        if(Area.Variable[1] == "21")
	    {
               NMODE.ForegroundColor = Color.White;
               NMODE_Value.ForegroundColor = Color.White;
            }
        if(Area.Variable[1] == "22")
	    {
               NMODATTR.ForegroundColor = Color.White;
               NMODATTR_Value.ForegroundColor = Color.White;
            }
        if(Area.Variable[1] == "23")
	    {
               PNTFORM.ForegroundColor = Color.White;
               PNTFORM_Value.ForegroundColor = Color.White;               
            }
        if(Area.Variable[1] == "24")
	    {
               PAGE.ForegroundColor = Color.White;               
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
public void Text74_OnDynAnimation(Object sender, EventArgs e)
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
public void Text73_OnDynAnimation(Object sender, EventArgs e)
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
public void NMODE_Value_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText NMODE_Value = (DrawText)dynArgs.sender; 
   
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
	
	tagName = Area.Variable[0] + "/NMODE";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		NMODE_Value.Caption = dbValue.ToString(strDigit);
	}
	else
		NMODE_Value.Caption = "------";

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
	
	tagName = Area.Variable[0] + "/NMODATTR";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		NMODATTR_Value.Caption = dbValue.ToString(strDigit);
	}
	else
		NMODATTR_Value.Caption = "------";

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
public void OPLO_Value_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText OPLO_Value = (DrawText)dynArgs.sender; 
   
    DrawArea A = (DrawArea)(Area.Parent);
             A.RunAnimation();

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
public void CVEULO_Value_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText CVEULO_Value = (DrawText)dynArgs.sender; 

    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "CVEULO";

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
	
	tagName = Area.Variable[0] + "/CVEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		CVEULO_Value.Caption = dbValue.ToString(strDigit);
	}
	else
		CVEULO_Value.Caption = "------";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void CVEUHI_Value_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText CVEUHI_Value = (DrawText)dynArgs.sender; 

    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "CVEUHI";

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
	
	tagName = Area.Variable[0] + "/CVEUHI";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		CVEUHI_Value.Caption = dbValue.ToString(strDigit);
	}
	else
		CVEUHI_Value.Caption = "------";

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
		PVSOURCE_Value.Caption = dbValue.ToString(strDigit);
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
public void PVROCNTP_Value_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVROCNTP_Value = (DrawText)dynArgs.sender; 

    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "PVRN";

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
	
	tagName = Area.Variable[0] + "/PVRN";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		PVROCNTP_Value.Caption = dbValue.ToString(strDigit);
	}
	else
		PVROCNTP_Value.Caption = "------";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void PVROCPTP_Value_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVROCPTP_Value = (DrawText)dynArgs.sender; 

    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "PVRP";

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
	
	tagName = Area.Variable[0] + "/PVRP";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		PVROCPTP_Value.Caption = dbValue.ToString(strDigit);
	}
	else
		PVROCPTP_Value.Caption = "------";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void DEVLO_Value_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText DEVLO_Value = (DrawText)dynArgs.sender; 
   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "DEVLO";

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
	
	tagName = Area.Variable[0] + "/DEVLO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		DEVLO_Value.Caption = dbValue.ToString(strDigit);
	}
	else
		DEVLO_Value.Caption = "------";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void DEVHI_Value_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText DEVHI_Value = (DrawText)dynArgs.sender; 
   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "DEVHI";

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
	
	tagName = Area.Variable[0] + "/DEVHI";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		DEVHI_Value.Caption = dbValue.ToString(strDigit);
	}
	else
		DEVHI_Value.Caption = "------";

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
    L.Variable[1] = "PVLL";

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
	
	tagName = Area.Variable[0] + "/PVLL";
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
    L.Variable[1] = "PVLO";

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
	
	tagName = Area.Variable[0] + "/PVLO";
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
    L.Variable[1] = "PVHI";

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
	
	tagName = Area.Variable[0] + "/PVHI";
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
    L.Variable[1] = "PVHH";

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
	
	tagName = Area.Variable[0] + "/PVHH";
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

    Area.Variable[1] = "24";

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
//Event Handler:OnDynClick 
public void DEVLO_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText DEVLO = (DrawText)dynArgs.sender; 
   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "DEVLO";
   DrawArea D = (DrawArea)(Area.GetDrawObj("Detail_POINTDATA"));
   D.Visible = false;
    DrawArea P = (DrawArea)Area.GetDrawObj("Detail_PAGE");
    P.Visible = false; 

    DrawText DEVLO_Value = (DrawText)Area.GetDrawObj("DEVLO_Value");
    DEVLO_Value.ForegroundColor = Color.White;

    Area.Variable[1] = "10";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void DEVLO_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText DEVLO = (DrawText)dynArgs.sender; 

    DrawText DEVLO_Value = (DrawText)Area.GetDrawObj("DEVLO_Value");   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    if(L.Visible == false)
       {
             DEVLO.ForegroundColor = Color.Yellow;
             DEVLO_Value.ForegroundColor = Color.Yellow;
       }
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

    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "DEVHI";
   DrawArea D = (DrawArea)(Area.GetDrawObj("Detail_POINTDATA"));
   D.Visible = false;
    DrawArea P = (DrawArea)Area.GetDrawObj("Detail_PAGE");
    P.Visible = false; 

    DrawText DEVHI_Value = (DrawText)Area.GetDrawObj("DEVHI_Value");
    DEVHI_Value.ForegroundColor = Color.White;

    Area.Variable[1] = "9";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void DEVHI_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText DEVHI = (DrawText)dynArgs.sender; 

    DrawText DEVHI_Value = (DrawText)Area.GetDrawObj("DEVHI_Value");   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    if(L.Visible == false)
       {
             DEVHI.ForegroundColor = Color.Yellow;
             DEVHI_Value.ForegroundColor = Color.Yellow;
       }
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
   

    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "PVRN";
   DrawArea D = (DrawArea)(Area.GetDrawObj("Detail_POINTDATA"));
   D.Visible = false;
    DrawArea P = (DrawArea)Area.GetDrawObj("Detail_PAGE");
    P.Visible = false; 
   
    PVROCNTP.ForegroundColor = Color.White;
    DrawText PVROCNTP_Value = (DrawText)Area.GetDrawObj("PVROCNTP_Value");
    PVROCNTP_Value.ForegroundColor = Color.White;

    Area.Variable[1] = "8";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void PVROCNTP_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVROCNTP = (DrawText)dynArgs.sender; 

    DrawText PVROCNTP_Value = (DrawText)Area.GetDrawObj("PVROCNTP_Value");   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    if(L.Visible == false)
       {
             PVROCNTP.ForegroundColor = Color.Yellow;
             PVROCNTP_Value.ForegroundColor = Color.Yellow;
       }
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
   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "PVRP";
   DrawArea D = (DrawArea)(Area.GetDrawObj("Detail_POINTDATA"));
   D.Visible = false;
    DrawArea P = (DrawArea)Area.GetDrawObj("Detail_PAGE");
    P.Visible = false; 
   
    PVROCPTP.ForegroundColor = Color.White;
    DrawText PVROCPTP_Value = (DrawText)Area.GetDrawObj("PVROCPTP_Value");
    PVROCPTP_Value.ForegroundColor = Color.White;

    Area.Variable[1] = "7";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void PVROCPTP_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVROCPTP = (DrawText)dynArgs.sender; 

    DrawText PVROCPTP_Value = (DrawText)Area.GetDrawObj("PVROCPTP_Value");   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    if(L.Visible == false)
       {
             PVROCPTP.ForegroundColor = Color.Yellow;
             PVROCPTP_Value.ForegroundColor = Color.Yellow;
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
    L.Variable[1] = "PVLL";
   DrawArea D = (DrawArea)(Area.GetDrawObj("Detail_POINTDATA"));
   D.Visible = false;
    DrawArea P = (DrawArea)Area.GetDrawObj("Detail_PAGE");
    P.Visible = false; 
   
    PVLLTPEU.ForegroundColor = Color.White;
    DrawText PVLLTPEU_Value = (DrawText)Area.GetDrawObj("PVLLTPEU_Value");
    PVLLTPEU_Value.ForegroundColor = Color.White;

    Area.Variable[1] = "6";

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
    L.Variable[1] = "PVLO";
   DrawArea D = (DrawArea)(Area.GetDrawObj("Detail_POINTDATA"));
   D.Visible = false;
    DrawArea P = (DrawArea)Area.GetDrawObj("Detail_PAGE");
    P.Visible = false; 
   
    PVLOTPEU.ForegroundColor = Color.White;
    DrawText PVLOTPEU_Value = (DrawText)Area.GetDrawObj("PVLOTPEU_Value");
    PVLOTPEU_Value.ForegroundColor = Color.White;

    Area.Variable[1] = "5";

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
    L.Variable[1] = "PVHI";
   DrawArea D = (DrawArea)(Area.GetDrawObj("Detail_POINTDATA"));
   D.Visible = false;
    DrawArea P = (DrawArea)Area.GetDrawObj("Detail_PAGE");
    P.Visible = false; 
   
    PVHITPEU.ForegroundColor = Color.White;
    DrawText PVHITPEU_Value = (DrawText)Area.GetDrawObj("PVHITPEU_Value");
    PVHITPEU_Value.ForegroundColor = Color.White;

    Area.Variable[1] = "4";

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
    L.Variable[1] = "PVHH";
    DrawArea D = (DrawArea)(Area.GetDrawObj("Detail_POINTDATA"));
    D.Visible = false;
   
    PVHHTPEU.ForegroundColor = Color.White;
    DrawText PVHHTPEU_Value = (DrawText)Area.GetDrawObj("PVHHTPEU_Value");
    PVHHTPEU_Value.ForegroundColor = Color.White;

    Area.Variable[1] = "3";

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
public void OPLO_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText OPLO = (DrawText)dynArgs.sender; 

    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "OPLO";
   DrawArea D = (DrawArea)(Area.GetDrawObj("Detail_POINTDATA"));
   D.Visible = false;
    DrawArea P = (DrawArea)Area.GetDrawObj("Detail_PAGE");
    P.Visible = false; 
   
    OPLO.ForegroundColor = Color.White;
    DrawText OPLO_Value = (DrawText)Area.GetDrawObj("OPLO_Value");
    OPLO_Value.ForegroundColor = Color.White;

    Area.Variable[1] = "18";

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
public void OPHI_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText OPHI = (DrawText)dynArgs.sender; 

    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "OPHI";
   DrawArea D = (DrawArea)(Area.GetDrawObj("Detail_POINTDATA"));
   D.Visible = false;
    DrawArea P = (DrawArea)Area.GetDrawObj("Detail_PAGE");
    P.Visible = false; 
   
    OPHI.ForegroundColor = Color.White;
    DrawText OPHI_Value = (DrawText)Area.GetDrawObj("OPHI_Value");
    OPHI_Value.ForegroundColor = Color.White;

    Area.Variable[1] = "17";

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
public void SPEULO_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText SPEULO = (DrawText)dynArgs.sender; 

    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "SPEULO";
   DrawArea D = (DrawArea)(Area.GetDrawObj("Detail_POINTDATA"));
   D.Visible = false;
    DrawArea P = (DrawArea)Area.GetDrawObj("Detail_PAGE");
    P.Visible = false; 
   
    SPEULO.ForegroundColor = Color.White;
    DrawText SPEULO_Value = (DrawText)Area.GetDrawObj("SPEULO_Value");
    SPEULO_Value.ForegroundColor = Color.White;

    Area.Variable[1] = "16";

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
public void SPEUHI_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText SPEUHI = (DrawText)dynArgs.sender; 
   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "SPEUHI";
   DrawArea D = (DrawArea)(Area.GetDrawObj("Detail_POINTDATA"));
   D.Visible = false;
    DrawArea P = (DrawArea)Area.GetDrawObj("Detail_PAGE");
    P.Visible = false; 
   
    SPEUHI.ForegroundColor = Color.White;
    DrawText SPEUHI_Value = (DrawText)Area.GetDrawObj("SPEUHI_Value");
    SPEUHI_Value.ForegroundColor = Color.White;

    Area.Variable[1] = "15";

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
public void CVEULO_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText CVEULO = (DrawText)dynArgs.sender; 
   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "CVEULO";
   DrawArea D = (DrawArea)(Area.GetDrawObj("Detail_POINTDATA"));
   D.Visible = false;
    DrawArea P = (DrawArea)Area.GetDrawObj("Detail_PAGE");
    P.Visible = false; 
   
    CVEULO.ForegroundColor = Color.White;
    DrawText CVEULO_Value = (DrawText)Area.GetDrawObj("CVEULO_Value");
    CVEULO_Value.ForegroundColor = Color.White;

    Area.Variable[1] = "14";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void CVEULO_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText CVEULO = (DrawText)dynArgs.sender; 

    DrawText CVEULO_Value = (DrawText)Area.GetDrawObj("CVEULO_Value");   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    if(L.Visible == false)
       {
             CVEULO.ForegroundColor = Color.Yellow;
             CVEULO_Value.ForegroundColor = Color.Yellow;
       }
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
   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "CVEUHI";
   DrawArea D = (DrawArea)(Area.GetDrawObj("Detail_POINTDATA"));
   D.Visible = false;
    DrawArea P = (DrawArea)Area.GetDrawObj("Detail_PAGE");
    P.Visible = false; 
   
    CVEUHI.ForegroundColor = Color.White;
    DrawText CVEUHI_Value = (DrawText)Area.GetDrawObj("CVEUHI_Value");
    CVEUHI_Value.ForegroundColor = Color.White;

    Area.Variable[1] = "13";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void CVEUHI_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText CVEUHI = (DrawText)dynArgs.sender; 

    DrawText CVEUHI_Value = (DrawText)Area.GetDrawObj("CVEUHI_Value");   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    if(L.Visible == false)
       {
             CVEUHI.ForegroundColor = Color.Yellow;
             CVEUHI_Value.ForegroundColor = Color.Yellow;
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

    Area.Variable[1] = "12";

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

    Area.Variable[1] = "11";

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

    Area.Variable[1] = "23";

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
public void NMODATTR_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText NMODATTR = (DrawText)dynArgs.sender; 

    DrawArea P = (DrawArea)Area.GetDrawObj("Detail_PAGE");
    P.Visible = false; 
    DrawArea D = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    D.Visible = false;   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_POINTDATA");
    L.Visible = true;
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
    L.Variable[12] = "3";
   
    NMODATTR.ForegroundColor = Color.White;
    DrawText NMODATTR_Value = (DrawText)Area.GetDrawObj("NMODATTR_Value");
    NMODATTR_Value.ForegroundColor = Color.White;

    Area.Variable[1] = "22";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void NMODATTR_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText NMODATTR = (DrawText)dynArgs.sender; 

    DrawText NMODATTR_Value = (DrawText)Area.GetDrawObj("NMODATTR_Value");   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_POINTDATA");
    if(L.Visible == false)
       {
             NMODATTR.ForegroundColor = Color.Cyan;
             NMODATTR_Value.ForegroundColor = Color.Cyan;
       }
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

    DrawArea P = (DrawArea)Area.GetDrawObj("Detail_PAGE");
    P.Visible = false; 
    DrawArea D = (DrawArea)Area.GetDrawObj("Detail_LIMITS");
    D.Visible = false;    
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_POINTDATA");
    L.Visible = true;
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
   
    NMODE.ForegroundColor = Color.White;
    DrawText NMODE_Value = (DrawText)Area.GetDrawObj("NMODE_Value");
    NMODE_Value.ForegroundColor = Color.White;

    Area.Variable[1] = "21";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void NMODE_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText NMODE = (DrawText)dynArgs.sender; 

    DrawText NMODE_Value = (DrawText)Area.GetDrawObj("NMODE_Value");   
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_POINTDATA");
    if(L.Visible == false)
       {
             NMODE.ForegroundColor = Color.Cyan;
             NMODE_Value.ForegroundColor = Color.Cyan;
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

    Area.Variable[1] = "20";

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

    Area.Variable[1] = "19";

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
