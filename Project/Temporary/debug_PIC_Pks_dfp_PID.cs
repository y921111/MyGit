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
public class PIC_Pks_dfp_PID:IDynCodeAttachDetach
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
_EventHandler= (EventHandler)PIC_Pks_dfp_PID_OnDynInitialize;
CodeDomCommon.AttachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PIC_Pks_dfp_PID_OnDynAnimation;
CodeDomCommon.AttachAreaEventHandler(area,strEventName,_EventHandler);
strObjectName = "TabBmp1";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)TabBmp1_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TabBmp2";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)TabBmp2_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TabBmp3";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)TabBmp3_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TabBmp4";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)TabBmp4_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TabBmp5";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)TabBmp5_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea107.Text1";
strEventName = "OnDynFinalize";
_EventHandler= (EventHandler)DrawArea107_Text1_OnDynFinalize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea107.Text1";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea107_Text1_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea5";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea5_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea5";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea5_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea5";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea5_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea5.Text11";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea5_Text11_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea5.Text11";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea5_Text11_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea5.Text11";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea5_Text11_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea5.Text10";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea5_Text10_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea5.Text10";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea5_Text10_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea5.Text10";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea5_Text10_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea5.Text9";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea5_Text9_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea5.Text9";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea5_Text9_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea5.Text9";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea5_Text9_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea5.Text8";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea5_Text8_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea5.Text8";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea5_Text8_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea5.Text8";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea5_Text8_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea5.Text7";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea5_Text7_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea5.Text7";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea5_Text7_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea5.Text7";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea5_Text7_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea5.txtPVHHH";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea5_txtPVHHH_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea5.txtPVHHH";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea5_txtPVHHH_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea5.txtPVHHH";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea5_txtPVHHH_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea5.TB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)DrawArea5_TB_KeyUp;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "DrawArea4";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea4_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea3";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea3_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea3";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea3_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea2";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea2_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea2";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea2_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea2.K";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea2_K_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea2.K";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea2_K_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea2.K";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea2_K_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea2.T2";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea2_T2_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea2.T2";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea2_T2_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea2.T2";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea2_T2_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea2.T1";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea2_T1_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea2.T1";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea2_T1_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea2.T1";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea2_T1_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea2.TB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)DrawArea2_TB_KeyUp;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "DrawArea1";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea1_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea1";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea1_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea100_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100";
strEventName = "OnDynFinalize";
_EventHandler= (EventHandler)DrawArea100_OnDynFinalize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea100_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.PVUnit2";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea100_PVUnit2_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.PVUnit1";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea100_PVUnit1_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.Alm";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea100_Alm_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.Alm";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea100_Alm_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.Ack";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea100_Ack_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.Mode_Combox";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea100_Mode_Combox_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.Mode_Combox";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea100_Mode_Combox_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.SPUp0";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea100_SPUp0_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.SPDown0";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea100_SPDown0_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.OPUp";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea100_OPUp_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.OPDown";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea100_OPDown_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.SPDown";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea100_SPDown_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.SPUp";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea100_SPUp_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.SPBtn";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea100_SPBtn_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.SPBtn";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea100_SPBtn_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.OPBar";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea100_OPBar_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.OPBar";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea100_OPBar_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea100_PV_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea100_PV_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.OP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea100_OP_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.OP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea100_OP_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.OP";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea100_OP_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.SP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea100_SP_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.SP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea100_SP_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.SP";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea100_SP_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.PVBar";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea100_PVBar_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.PVBar";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea100_PVBar_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.PVUnit";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea100_PVUnit_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.SL";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea100_SL_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.SL";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea100_SL_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.SH";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea100_SH_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.SH";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea100_SH_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.TagComment";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea100_TagComment_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.TagComment";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea100_TagComment_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.TagName";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea100_TagName_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.TagName";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea100_TagName_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.Mode";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea100_Mode_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.Mode";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea100_Mode_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.Mode";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea100_Mode_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.TB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)DrawArea100_TB_KeyUp;
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
_EventHandler= (EventHandler)PIC_Pks_dfp_PID_OnDynInitialize;
CodeDomCommon.DetachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PIC_Pks_dfp_PID_OnDynAnimation;
CodeDomCommon.DetachAreaEventHandler(area,strEventName,_EventHandler);
strObjectName = "TabBmp1";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)TabBmp1_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TabBmp2";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)TabBmp2_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TabBmp3";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)TabBmp3_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TabBmp4";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)TabBmp4_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TabBmp5";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)TabBmp5_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea107.Text1";
strEventName = "OnDynFinalize";
_EventHandler= (EventHandler)DrawArea107_Text1_OnDynFinalize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea107.Text1";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea107_Text1_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea5";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea5_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea5";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea5_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea5";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea5_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea5.Text11";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea5_Text11_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea5.Text11";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea5_Text11_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea5.Text11";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea5_Text11_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea5.Text10";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea5_Text10_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea5.Text10";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea5_Text10_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea5.Text10";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea5_Text10_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea5.Text9";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea5_Text9_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea5.Text9";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea5_Text9_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea5.Text9";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea5_Text9_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea5.Text8";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea5_Text8_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea5.Text8";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea5_Text8_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea5.Text8";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea5_Text8_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea5.Text7";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea5_Text7_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea5.Text7";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea5_Text7_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea5.Text7";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea5_Text7_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea5.txtPVHHH";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea5_txtPVHHH_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea5.txtPVHHH";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea5_txtPVHHH_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea5.txtPVHHH";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea5_txtPVHHH_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea5.TB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)DrawArea5_TB_KeyUp;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "DrawArea4";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea4_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea3";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea3_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea3";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea3_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea2";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea2_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea2";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea2_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea2.K";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea2_K_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea2.K";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea2_K_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea2.K";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea2_K_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea2.T2";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea2_T2_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea2.T2";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea2_T2_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea2.T2";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea2_T2_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea2.T1";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea2_T1_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea2.T1";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea2_T1_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea2.T1";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea2_T1_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea2.TB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)DrawArea2_TB_KeyUp;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "DrawArea1";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea1_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea1";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea1_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea100_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100";
strEventName = "OnDynFinalize";
_EventHandler= (EventHandler)DrawArea100_OnDynFinalize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea100_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.PVUnit2";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea100_PVUnit2_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.PVUnit1";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea100_PVUnit1_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.Alm";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea100_Alm_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.Alm";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea100_Alm_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.Ack";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea100_Ack_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.Mode_Combox";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea100_Mode_Combox_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.Mode_Combox";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea100_Mode_Combox_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.SPUp0";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea100_SPUp0_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.SPDown0";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea100_SPDown0_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.OPUp";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea100_OPUp_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.OPDown";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea100_OPDown_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.SPDown";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea100_SPDown_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.SPUp";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea100_SPUp_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.SPBtn";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea100_SPBtn_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.SPBtn";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea100_SPBtn_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.OPBar";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea100_OPBar_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.OPBar";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea100_OPBar_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea100_PV_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea100_PV_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.OP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea100_OP_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.OP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea100_OP_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.OP";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea100_OP_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.SP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea100_SP_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.SP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea100_SP_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.SP";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea100_SP_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.PVBar";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea100_PVBar_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.PVBar";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea100_PVBar_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.PVUnit";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea100_PVUnit_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.SL";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea100_SL_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.SL";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea100_SL_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.SH";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea100_SH_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.SH";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea100_SH_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.TagComment";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea100_TagComment_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.TagComment";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea100_TagComment_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.TagName";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea100_TagName_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.TagName";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea100_TagName_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.Mode";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea100_Mode_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.Mode";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea100_Mode_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.Mode";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea100_Mode_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea100.TB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)DrawArea100_TB_KeyUp;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);

    return;
}

public int nTab = 0;

public void SwitchTab(DrawArea Area, int nNewTab)
{
	string strDA = "DrawArea";
	string tmp = "";
	DrawArea DA = null;
	DrawBitmap Bmp = null;
	for (int i = 1; i < 6; i++)
	{
		tmp = strDA + i.ToString();
		if(i == nNewTab)
		{
			DA = (DrawArea)(Area.GetControlObj(tmp));
			DA.Visible = true;

			Bmp = (DrawBitmap)Area.GetDrawObj("TabBmp" + i.ToString());
			Bmp.ImageFile = "Pks_dfp_PID_TabOn.png";

			nTab = i;//设标志位；
		}
		else
		{
			DA = (DrawArea)(Area.GetControlObj(tmp));
			DA.Visible = false;

			Bmp = (DrawBitmap)Area.GetDrawObj("TabBmp" + i.ToString());
			Bmp.ImageFile = "Pks_dfp_PID_TabOff.png";
		}
	}
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void PIC_Pks_dfp_PID_OnDynInitialize(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawArea drawArea = (DrawArea)dynArgs.sender; 
	
	SwitchTab(Area,1);
	return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void PIC_Pks_dfp_PID_OnDynAnimation(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 

   
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void TabBmp1_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawBitmap Bmp1 = (DrawBitmap)dynArgs.sender; 

	if(nTab != 1)
	{
		SwitchTab(Area,1);
                Area.Refresh();
//		Bmp1.ImageFile = "Pks_dfp_PID_TabOff.png";
	}
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void TabBmp2_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawBitmap Bmp1 = (DrawBitmap)dynArgs.sender; 

	if(nTab != 2)
	{
		SwitchTab(Area,2);
                Area.Refresh();
//		Bmp1.ImageFile = "Pks_dfp_PID_TabOff.png";
                
	}
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void TabBmp3_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawBitmap Bmp1 = (DrawBitmap)dynArgs.sender; 

	if(nTab != 3)
	{
		SwitchTab(Area,3);
                Area.Refresh();
//		Bmp1.ImageFile = "Pks_dfp_PID_TabOff.png";
	}
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void TabBmp4_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawBitmap Bmp1 = (DrawBitmap)dynArgs.sender; 

	if(nTab != 4)
	{
		SwitchTab(Area,4);
                Area.Refresh();
//		Bmp1.ImageFile = "Pks_dfp_PID_TabOff.png";
	}
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void TabBmp5_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawBitmap Bmp1 = (DrawBitmap)dynArgs.sender; 

	if(nTab != 5)
	{
		SwitchTab(Area,5);
                Area.Refresh();
//		Bmp1.ImageFile = "Pks_dfp_PID_TabOff.png";
	}
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynFinalize 
public void DrawArea107_Text1_OnDynFinalize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText Text1 = (DrawText)dynArgs.sender; 

	Area.Visible = true;
    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void DrawArea107_Text1_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText Text1 = (DrawText)dynArgs.sender; 
   
	//===============================================================================
	Area.Visible = false;

	Picture pic = null;
	//===============================================================================
	if(CommonFunction.GetProjectVariable(0) != null)
	{
		object obj = Area.Parent;
		Type type = obj.GetType();
		if( type.Name != "Picture" )
		{
			pic = (Picture)(Area.Parent.Parent);
			pic.Location = new Point(0,0);
		}
	}

//////////////////////////////////////////////////////////////////////////////////////////////////////////	
/*
	//20110324，尝试用动态代码来实现图素的替换：
	//1.修改RefPicName；
	//2.修改大小，将其大小改成目标图素的原始大小，或者在此指定大小；
	//3.立即刷新，查看改后的效果；

	pic = (Picture)(Area.Parent.Parent);
	ArrayList al = CommonFunction.GetDrawAreaByRefPicName(pic,"CtmVP_AI7");
	foreach (object o in al)
	{
		ControlLabel lab = (ControlLabel)o;
		Control ctrl = lab.Ctrl;
		
		if(ctrl != null)
		{
			DrawArea da = (DrawArea)ctrl;
//			da.RefPicName = "CtmVP_AI1.grf";
			
			ctrl.Height = 20;
			ctrl.Width = 75;
			RectangleF newRect = new RectangleF(lab.m_rect.X, lab.m_rect.Y, (float)ctrl.Width, (float)ctrl.Height);
			lab.m_rect = newRect;
		}
	}
	Area.Refresh();
*/


//////////////////////////////////////////////////////////////////////////////////////////////////////////	
/*
	//20110331，川化芳烃：
	pic = (Picture)(Area.Parent.Parent);
	ArrayList al = CommonFunction.GetDrawAreaByRefPicName(pic,"CtmVP_AI7");
	foreach (object o in al)
	{
		ControlLabel lab = (ControlLabel)o;
		Control ctrl = lab.Ctrl;
		
		if(ctrl != null)
		{
			DrawArea da = (DrawArea)ctrl;
			ctrl.Height = 20;
			ctrl.Width = 75;
			RectangleF newRect = new RectangleF(lab.m_rect.X, lab.m_rect.Y, (float)ctrl.Width, (float)ctrl.Height);
			lab.m_rect = newRect;
		}
	}
*/



/*
//////////////////////////////////////////////////////////////////////////////////////////////////////////	
//20110502，川化橡胶：
	pic = (Picture)(Area.Parent.Parent);
	ArrayList al = CommonFunction.GetDrawAreaByRefPicName(pic,"CtmVP_AI5");
	foreach (object o in al)
	{
		ControlLabel lab = (ControlLabel)o;
		Control ctrl = lab.Ctrl;
		
		if(ctrl != null)
		{
			DrawArea da = (DrawArea)ctrl;
			ctrl.Height = 38;
			ctrl.Width = 92;
			RectangleF newRect = new RectangleF(lab.m_rect.X, lab.m_rect.Y, (float)ctrl.Width, (float)ctrl.Height);
			lab.m_rect = newRect;
		}
	}
*/




//////////////////////////////////////////////////////////////////////////////////////////////////////////	
/*
	//20111206，川化乙二醇：
	pic = (Picture)(Area.Parent.Parent);
	ArrayList al = CommonFunction.GetDrawAreaByRefPicName(pic,"CS3000_PID");
	foreach (object o in al)
	{
		ControlLabel lab = (ControlLabel)o;
		Control ctrl = lab.Ctrl;
		
		if(ctrl != null)
		{
			DrawArea da = (DrawArea)ctrl;
			ctrl.Height = 32;
			ctrl.Width = 122;
			RectangleF newRect = new RectangleF(lab.m_rect.X, lab.m_rect.Y, (float)ctrl.Width, (float)ctrl.Height);
			lab.m_rect = newRect;
		}
	}


	al = CommonFunction.GetDrawAreaByRefPicName(pic,"CtmVP_PID");
	foreach (object o in al)
	{
		ControlLabel lab = (ControlLabel)o;
		Control ctrl = lab.Ctrl;
		
		if(ctrl != null)
		{
			DrawArea da = (DrawArea)ctrl;
			ctrl.Height = 33;
			ctrl.Width = 122;
			RectangleF newRect = new RectangleF(lab.m_rect.X, lab.m_rect.Y, (float)ctrl.Width, (float)ctrl.Height);
			lab.m_rect = newRect;
		}
	}

	al = CommonFunction.GetDrawAreaByRefPicName(pic,"CtmVP_AI1");
	foreach (object o in al)
	{
		ControlLabel lab = (ControlLabel)o;
		Control ctrl = lab.Ctrl;
		
		if(ctrl != null)
		{
			DrawArea da = (DrawArea)ctrl;
			ctrl.Height = 32;
			ctrl.Width = 106;
			RectangleF newRect = new RectangleF(lab.m_rect.X, lab.m_rect.Y, (float)ctrl.Width, (float)ctrl.Height);
			lab.m_rect = newRect;
		}
	}

	al = CommonFunction.GetDrawAreaByRefPicName(pic,"CtmVP_AI9");
	foreach (object o in al)
	{
		ControlLabel lab = (ControlLabel)o;
		Control ctrl = lab.Ctrl;
		
		if(ctrl != null)
		{
			DrawArea da = (DrawArea)ctrl;
			ctrl.Height = 49;
			ctrl.Width = 106;
			RectangleF newRect = new RectangleF(lab.m_rect.X, lab.m_rect.Y, (float)ctrl.Width, (float)ctrl.Height);
			lab.m_rect = newRect;
		}
	}

	al = CommonFunction.GetDrawAreaByRefPicName(pic,"CtmVP_AI10");
	foreach (object o in al)
	{
		ControlLabel lab = (ControlLabel)o;
		Control ctrl = lab.Ctrl;
		
		if(ctrl != null)
		{
			DrawArea da = (DrawArea)ctrl;
			ctrl.Height = 48;
			ctrl.Width = 122;
			RectangleF newRect = new RectangleF(lab.m_rect.X, lab.m_rect.Y, (float)ctrl.Width, (float)ctrl.Height);
			lab.m_rect = newRect;
		}
	}
*/
    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler
//Event Handler:OnDynInitialize
public void DrawArea5_OnDynInitialize(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender;
	DynEventArgs dynArgs = (DynEventArgs)e;
	DrawArea drawArea = (DrawArea)dynArgs.sender;

	//=========================
	Area.Enabled = true;

	Picture pic = CommonFunction.GetThisPicture(Area);
	if(pic != null)
	{
		if(Area.BReference)//图素
		{
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
	Area.Variable[0] = Area.Variable[0].ToUpper();


	//=========================
	string almFlg = "PVHLFL";//报警标志位的参数名；
	
	DrawBitmap PVHHH = (DrawBitmap)Area.GetDrawObj("PVHHH"); 
	DrawBitmap PVHH = (DrawBitmap)Area.GetDrawObj("PVHH"); 
	DrawBitmap PVH = (DrawBitmap)Area.GetDrawObj("PVH"); 
	DrawBitmap PVL = (DrawBitmap)Area.GetDrawObj("PVL"); 
	DrawBitmap PVLL = (DrawBitmap)Area.GetDrawObj("PVLL"); 
	DrawBitmap PVLLL = (DrawBitmap)Area.GetDrawObj("PVLLL"); 

	PVHHH.Visible = false;
	PVHH.Visible = false;
	PVH.Visible = false;
	PVL.Visible = false;
	PVLL.Visible = false;
	PVLLL.Visible = false;

	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	string tagName = Area.Variable[0] + "/" + almFlg;
	if(CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType))
	{
		switch (nValue)
		{
			case 1:
				PVH.Visible = true;
				break;
			case -1:
				PVL.Visible = true;
				break;
			case 2:
				PVHH.Visible = true;
				break;
			case -2:
				PVLL.Visible = true;
				break;
			default:
				break;
		}
	}
	return;
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void DrawArea5_OnDynAnimation(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 
   
	//=========================
	string almFlg = "PVHLFL";//报警标志位的参数名；
	
	DrawBitmap PVHHH = (DrawBitmap)Area.GetDrawObj("PVHHH"); 
	DrawBitmap PVHH = (DrawBitmap)Area.GetDrawObj("PVHH"); 
	DrawBitmap PVH = (DrawBitmap)Area.GetDrawObj("PVH"); 
	DrawBitmap PVL = (DrawBitmap)Area.GetDrawObj("PVL"); 
	DrawBitmap PVLL = (DrawBitmap)Area.GetDrawObj("PVLL"); 
	DrawBitmap PVLLL = (DrawBitmap)Area.GetDrawObj("PVLLL"); 

	PVHHH.Visible = false;
	PVHH.Visible = false;
	PVH.Visible = false;
	PVL.Visible = false;
	PVLL.Visible = false;
	PVLLL.Visible = false;

	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	string tagName = Area.Variable[0] + "/" + almFlg;
	if(CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType))
	{
		switch (nValue)
		{
			case 1:
				PVH.Visible = true;
				break;
			case -1:
				PVL.Visible = true;
				break;
			case 2:
				PVHH.Visible = true;
				break;
			case -2:
				PVLL.Visible = true;
				break;
			default:
				break;
		}
	}
    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void DrawArea5_OnDynClick(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 
   
	TextBox TB = (TextBox)Area.GetControlObj("TB"); 
	TB.Visible = false;
	ControlLabel lab = (ControlLabel)CommonFunction.GetLabelOfControl(TB);
	if(lab.Variable[1] != "")
	{
		DrawText obj = (DrawText)Area.GetDrawObj(lab.Variable[1]);
		obj.Visible = true;
	}
    return; 
}

public void Input_AIAlm(DrawArea Area, DrawText T1)
{
	if(T1.Visible == true)
	{
		// 不弹出输入面板，DrawText隐藏，TextBox显示	
		object obj = Area.GetControlObj("TB");

		if(obj != null)
		{
			TextBox TB = (TextBox)obj; 
			if(TB != null)
			{
				TB.Visible = true;
				TB.Text = "";
				TB.Focus();
		
				//调整TB的位置：
				//调整控件的位置不能直接给相关属性赋值，应该调用函数MoveControl()，这样才能真正实现控件的移动；
				CommonFunction.MoveControl(Area,TB,(int)(T1.VerticalPosition-2),(int)(T1.HorizontalPosition));

				obj = CommonFunction.GetLabelOfControl(TB);
				if(obj != null)
				{
					ControlLabel lab = (ControlLabel)obj;
					//给TB传递参数：
					lab.Variable[0] = Area.Variable[0] + "/" + T1.Variable[0];
					lab.Variable[1] = T1.Name;

					//调整TB的宽度：
					lab.m_rect.Width = (float)(T1.Width+1);
				}
			}
		}
		T1.Visible = false;
	}
}

public void ShowV_AIAlm(DrawArea Area, DrawText Txt)
{
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
	
	tagName = Area.Variable[0] + "/" + Txt.Variable[0];
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		Txt.Caption = dbValue.ToString(strDigit);
	}
	else
		Txt.Caption = "#####0.#";
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void DrawArea5_Text11_OnDynInitialize(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawText Txt = (DrawText)dynArgs.sender; 

	ShowV_AIAlm(Area,Txt);

	return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void DrawArea5_Text11_OnDynAnimation(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawText Txt = (DrawText)dynArgs.sender; 

	ShowV_AIAlm(Area,Txt);

	return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void DrawArea5_Text11_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText OP = (DrawText)dynArgs.sender; 
	
	Input_AIAlm(Area,OP);
   
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void DrawArea5_Text10_OnDynInitialize(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawText Txt = (DrawText)dynArgs.sender; 

	ShowV_AIAlm(Area,Txt);

	return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void DrawArea5_Text10_OnDynAnimation(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawText Txt = (DrawText)dynArgs.sender; 

	ShowV_AIAlm(Area,Txt);

	return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void DrawArea5_Text10_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText OP = (DrawText)dynArgs.sender; 
	
	Input_AIAlm(Area,OP);
   
    return; 
}//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void DrawArea5_Text9_OnDynInitialize(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawText Txt = (DrawText)dynArgs.sender; 

	ShowV_AIAlm(Area,Txt);

	return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void DrawArea5_Text9_OnDynAnimation(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawText Txt = (DrawText)dynArgs.sender; 

	ShowV_AIAlm(Area,Txt);

	return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void DrawArea5_Text9_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText OP = (DrawText)dynArgs.sender; 
	
	Input_AIAlm(Area,OP);
   
    return; 
}//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void DrawArea5_Text8_OnDynInitialize(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawText Txt = (DrawText)dynArgs.sender; 

	ShowV_AIAlm(Area,Txt);

	return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void DrawArea5_Text8_OnDynAnimation(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawText Txt = (DrawText)dynArgs.sender; 

	ShowV_AIAlm(Area,Txt);

	return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void DrawArea5_Text8_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText OP = (DrawText)dynArgs.sender; 
	
	Input_AIAlm(Area,OP);
   
    return; 
}//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void DrawArea5_Text7_OnDynInitialize(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawText Txt = (DrawText)dynArgs.sender; 

	ShowV_AIAlm(Area,Txt);

	return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void DrawArea5_Text7_OnDynAnimation(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawText Txt = (DrawText)dynArgs.sender; 

	ShowV_AIAlm(Area,Txt);

	return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void DrawArea5_Text7_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText OP = (DrawText)dynArgs.sender; 
	
	Input_AIAlm(Area,OP);
   
    return; 
}//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void DrawArea5_txtPVHHH_OnDynInitialize(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawText Txt = (DrawText)dynArgs.sender; 

	ShowV_AIAlm(Area,Txt);

	return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void DrawArea5_txtPVHHH_OnDynAnimation(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawText Txt = (DrawText)dynArgs.sender; 

	ShowV_AIAlm(Area,Txt);

	return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void DrawArea5_txtPVHHH_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText OP = (DrawText)dynArgs.sender; 
	
	Input_AIAlm(Area,OP);
   
    return; 
}/*
lab.Variable[0]:模块名/参数名；
lab.Variable[1]：DrawText的对象名；
*/
//Do not remove or update this comment
//Event Delegate:KeyEventHandler
//Event Handler:KeyUp
public void DrawArea5_TB_KeyUp(Object sender, KeyEventArgs e)
{
	TextBox TB = (TextBox)sender;
	switch ( e.KeyData )
	{
		case Keys.Enter:
			string SPInputValue = TB.Text;
			double dbSPValue = Convert.ToDouble(SPInputValue);
			DrawArea Area = CommonFunction.GetThisDrawArea(TB);
	
			object obj = CommonFunction.GetLabelOfControl(TB);
			if (obj != null)
			{
				ControlLabel lab = (ControlLabel)obj;
				string tagName = lab.Variable[0];
				CommonFunction.DSI_SetValue(tagName, dbSPValue);
				TB.Visible = false;
	
				DrawText T1 = (DrawText)Area.GetDrawObj(lab.Variable[1]);
				T1.Visible = true;
			}
			break;
	}
	return;
}
//Do not remove or update this comment
//Event Delegate:EventHandler
//Event Handler:OnDynInitialize
public void DrawArea4_OnDynInitialize(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender;
	DynEventArgs dynArgs = (DynEventArgs)e;
	DrawArea drawArea = (DrawArea)dynArgs.sender;

	Area.Enabled = true;

	Picture pic = CommonFunction.GetThisPicture(Area);
	if(pic != null)
	{

		if(Area.BReference)//图素
		{
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
	Area.Variable[0] = Area.Variable[0].ToUpper();
	return;
}//Do not remove or update this comment
//Event Delegate:EventHandler
//Event Handler:OnDynInitialize
public void DrawArea3_OnDynInitialize(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender;
	DynEventArgs dynArgs = (DynEventArgs)e;
	DrawArea drawArea = (DrawArea)dynArgs.sender;

	Area.Enabled = true;

	Picture pic = CommonFunction.GetThisPicture(Area);
	if(pic != null)
	{

		if(Area.BReference)//图素
		{
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
	Area.Variable[0] = Area.Variable[0].ToUpper();
	return;
}

//Do not remove or update this comment
//Event Delegate:EventHandler
//Event Handler:OnDynClick
public void DrawArea3_OnDynClick(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender;
	DynEventArgs dynArgs = (DynEventArgs)e;
	DrawArea drawArea = (DrawArea)dynArgs.sender;
/*
	object obj = Area.GetControlObj("TB");
	if (obj != null)
	{
		TextBox TB = (TextBox)obj;
		TB.Visible = false;
		DrawText SP = (DrawText)Area.GetDrawObj("SP");
		SP.Visible = true;
		DrawText OP = (DrawText)Area.GetDrawObj("OP");
		OP.Visible = true;
	}
*/
	return;
}
//Do not remove or update this comment
//Event Delegate:EventHandler
//Event Handler:OnDynClick
public void DrawArea2_OnDynClick(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender;
	DynEventArgs dynArgs = (DynEventArgs)e;
	DrawArea drawArea = (DrawArea)dynArgs.sender;
	object obj = Area.GetControlObj("TB");
	if (obj != null)
	{
		TextBox TB = (TextBox)obj;
		TB.Visible = false;
		DrawText T1 = (DrawText)Area.GetDrawObj("T1");
		T1.Visible = true;
		DrawText T2 = (DrawText)Area.GetDrawObj("T2");
		T2.Visible = true;
		DrawText K = (DrawText)Area.GetDrawObj("K");
		K.Visible = true;
	}
	return;
}


//Do not remove or update this comment
//Event Delegate:EventHandler
//Event Handler:OnDynInitialize
public void DrawArea2_OnDynInitialize(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender;
	DynEventArgs dynArgs = (DynEventArgs)e;
	DrawArea drawArea = (DrawArea)dynArgs.sender;

	Area.Enabled = true;

	Picture pic = CommonFunction.GetThisPicture(Area);
	if(pic != null)
	{

		if(Area.BReference)//图素
		{
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
	Area.Variable[0] = Area.Variable[0].ToUpper();
	return;
}//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void DrawArea2_K_OnDynInitialize(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawText SV = (DrawText)dynArgs.sender; 

	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	int nDigit = 2;
	string strDigit = "f" + nDigit.ToString();
	
	string tagName = Area.Variable[0] + "/K";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		SV.Caption = dbValue.ToString(strDigit);
	}
	else
		SV.Caption = "#####0.#";
	return; 
}


//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void DrawArea2_K_OnDynAnimation(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawText SV = (DrawText)dynArgs.sender; 

	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	int nDigit = 2;
	string strDigit = "f" + nDigit.ToString();
	
	string tagName = Area.Variable[0] + "/K";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		SV.Caption = dbValue.ToString(strDigit);
	}
	else
		SV.Caption = "#####0.#";
	return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void DrawArea2_K_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText OP = (DrawText)dynArgs.sender; 
   
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
				TB.Text = "";
				TB.Focus();
		
				//调整TB的位置：
				//调整控件的位置不能直接给相关属性赋值，应该调用函数MoveControl()，这样才能真正实现控件的移动；
				//TB.Left = (int)(OP.HorizontalPosition + OP.Width - TB.Width - 2);
				//TB.Top = (int)(OP.VerticalPosition)-2;
				CommonFunction.MoveControl(Area,TB,(int)(OP.VerticalPosition-2),(int)(OP.HorizontalPosition-1));
	
				obj = CommonFunction.GetLabelOfControl(TB);
				if(obj != null)
				{
					ControlLabel lab = (ControlLabel)obj;
					//给TB传递参数：
					lab.Variable[0] = Area.Variable[0] + "/K";

					//调整TB的宽度：
					lab.m_rect.Width = (float)(OP.Width+2);
				}
			}
		}
		OP.Visible = false;
	}
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void DrawArea2_T2_OnDynInitialize(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawText SV = (DrawText)dynArgs.sender; 

	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	int nDigit = 2;
	string strDigit = "f" + nDigit.ToString();
	
	string tagName = Area.Variable[0] + "/T2";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		SV.Caption = dbValue.ToString(strDigit);
	}
	else
		SV.Caption = "#####0.#";
	return; 
}


//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void DrawArea2_T2_OnDynAnimation(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawText SV = (DrawText)dynArgs.sender; 

	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	int nDigit = 2;
	string strDigit = "f" + nDigit.ToString();
	
	string tagName = Area.Variable[0] + "/T2";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		SV.Caption = dbValue.ToString(strDigit);
	}
	else
		SV.Caption = "#####0.#";
	return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void DrawArea2_T2_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText OP = (DrawText)dynArgs.sender; 
   
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
				TB.Text = "";
				TB.Focus();
		
				//调整TB的位置：
				//调整控件的位置不能直接给相关属性赋值，应该调用函数MoveControl()，这样才能真正实现控件的移动；
				//TB.Left = (int)(OP.HorizontalPosition + OP.Width - TB.Width - 2);
				//TB.Top = (int)(OP.VerticalPosition)-2;
				CommonFunction.MoveControl(Area,TB,(int)(OP.VerticalPosition-2),(int)(OP.HorizontalPosition-1));
	
				obj = CommonFunction.GetLabelOfControl(TB);
				if(obj != null)
				{
					ControlLabel lab = (ControlLabel)obj;
					//给TB传递参数：
					lab.Variable[0] = Area.Variable[0] + "/T2";

					//调整TB的宽度：
					lab.m_rect.Width = (float)(OP.Width+2);
				}
			}
		}
		OP.Visible = false;
	}
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void DrawArea2_T1_OnDynInitialize(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawText SV = (DrawText)dynArgs.sender; 

	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	int nDigit = 2;
	string strDigit = "f" + nDigit.ToString();
	
	string tagName = Area.Variable[0] + "/T1";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		SV.Caption = dbValue.ToString(strDigit);
	}
	else
		SV.Caption = "#####0.#";
	return; 
}


//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void DrawArea2_T1_OnDynAnimation(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawText SV = (DrawText)dynArgs.sender; 

	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	int nDigit = 2;
	string strDigit = "f" + nDigit.ToString();
	
	string tagName = Area.Variable[0] + "/T1";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		SV.Caption = dbValue.ToString(strDigit);
	}
	else
		SV.Caption = "#####0.#";
	return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void DrawArea2_T1_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText OP = (DrawText)dynArgs.sender; 
   
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
				TB.Text = "";
				TB.Focus();
		
				//调整TB的位置：
				//调整控件的位置不能直接给相关属性赋值，应该调用函数MoveControl()，这样才能真正实现控件的移动；
				//TB.Left = (int)(OP.HorizontalPosition + OP.Width - TB.Width - 2);
				//TB.Top = (int)(OP.VerticalPosition)-2;
				CommonFunction.MoveControl(Area,TB,(int)(OP.VerticalPosition-2),(int)(OP.HorizontalPosition-1));
	
				obj = CommonFunction.GetLabelOfControl(TB);
				if(obj != null)
				{
					ControlLabel lab = (ControlLabel)obj;
					//给TB传递参数：
					lab.Variable[0] = Area.Variable[0] + "/T1";

					//调整TB的宽度：
					lab.m_rect.Width = (float)(OP.Width+2);
				}
			}
		}
		OP.Visible = false;
	}
    return; 
}
//Do not remove or update this comment
//Event Delegate:KeyEventHandler
//Event Handler:KeyUp
public void DrawArea2_TB_KeyUp(Object sender, KeyEventArgs e)
{
	TextBox TB = (TextBox)sender;
	switch ( e.KeyData )
	{
	case Keys.Enter:
		string SPInputValue = TB.Text;
		double dbSPValue = Convert.ToDouble(SPInputValue);
		DrawArea Area = CommonFunction.GetThisDrawArea(TB);

		object obj = CommonFunction.GetLabelOfControl(TB);
		if (obj != null)
		{
			ControlLabel lab = (ControlLabel)obj;
			string tagName = lab.Variable[0];
			CommonFunction.DSI_SetValue(tagName, dbSPValue);
		}
		TB.Visible = false;

		DrawText T1 = (DrawText)Area.GetDrawObj("T1");
		T1.Visible = true;
		DrawText T2 = (DrawText)Area.GetDrawObj("T2");
		T2.Visible = true;
		DrawText K = (DrawText)Area.GetDrawObj("K");
		K.Visible = true;
		break;
	}

	/*
		switch ( e.KeyData )
		{
			case Keys.Enter:
				string OPInputValue = TB.Text;
				double dbOPValue = Convert.ToDouble(OPInputValue);
				DrawArea Area = CommonFunction.GetThisDrawArea(TB);
				CommonFunction.DSI_SetValue(Area.Variable[0], dbOPValue);
				break;
		}

		TB.Visible = false;

		DrawText SP = (DrawText)Area.GetDrawObj("SP");
	*/

	return;
}

//Do not remove or update this comment
//Event Delegate:EventHandler
//Event Handler:OnDynInitialize
public void DrawArea1_OnDynInitialize(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender;
	DynEventArgs dynArgs = (DynEventArgs)e;
	DrawArea drawArea = (DrawArea)dynArgs.sender;


	//初始化Combox
	/*object obj = Area.GetControlObj("ComboBox1");
	if(obj != null)
	{
		ComboBox CB = (ComboBox)obj; 
		if(CB != null)
		{
			CB.Enabled = true;
			//MessageBox.Show("CB.Items.AddRange");
			CB.Items.AddRange(new string[] { "MAN", "AUTO", "CAS" });					
		}
	}*/

	Area.Enabled = true;

	Picture pic = CommonFunction.GetThisPicture(Area);
	if(pic != null)
	{
		if(Area.BReference)//图素
		{
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
	Area.Variable[0] = Area.Variable[0].ToUpper();
	
	//==============================
	//报警
	string almFlg = "PVHLFL";//报警标志位的参数名；
	string almFlgOP = "OPHLFL";//OP报警参数

	DrawBitmap Alm = (DrawBitmap)Area.GetDrawObj("ALM"); 
	DrawBitmap PVHH = (DrawBitmap)Area.GetDrawObj("PVHH"); 
	DrawBitmap PVH = (DrawBitmap)Area.GetDrawObj("PVH"); 
	DrawBitmap PVL = (DrawBitmap)Area.GetDrawObj("PVL"); 
	DrawBitmap PVLL = (DrawBitmap)Area.GetDrawObj("PVLL"); 
	DrawBitmap OPH=(DrawBitmap)Area.GetDrawObj("OPH");
	DrawBitmap OPL=(DrawBitmap)Area.GetDrawObj("OPL");
	Alm.Visible = false;
	PVHH.Visible = false;
	PVH.Visible = false;
	PVL.Visible = false;
	PVLL.Visible = false;

	OPH.Visible=false;
	OPL.Visible=false;
	double dbValue = 0;
	int nValue = 0;
	int nValueOP=0;
	bool bValue = false;
	int nDataType = 0;

	string tagName = Area.Variable[0] + "/" + almFlg;
	string tagNameOP = Area.Variable[0] + "/" + almFlgOP;
	if(CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType))
	{
		switch (nValue)
		{
			case 1:
				PVH.Visible = true;
				break;
			case -1:
				PVL.Visible = true;
				break;
			case 2:
				PVHH.Visible = true;
				break;
			case -2:
				PVLL.Visible = true;
				break;
			default:
				break;
		}
		if(nValue != 0)
			Alm.Visible = true;
	}
	if(CommonFunction.GetValueWithType(tagNameOP,ref dbValue,ref nValueOP,ref bValue,ref nDataType))
	{
		switch (nValueOP)
		{
			case 1:
				OPH.Visible=true;
				break;
			case -1:
				OPL.Visible=true;
				break;
			default:
				break;
		}
		if(nValue != 0)
			Alm.Visible = true;
	}
	return;
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void DrawArea1_OnDynAnimation(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawArea drawArea = (DrawArea)dynArgs.sender; 
   
	//==============================
	//报警
	string almFlg = "PVHLFL";//报警标志位的参数名；
	string almFlgOP = "OPHLFL";//OP报警参数
	DrawBitmap Alm = (DrawBitmap)Area.GetDrawObj("ALM"); 
	DrawBitmap PVHH = (DrawBitmap)Area.GetDrawObj("PVHH"); 
	DrawBitmap PVH = (DrawBitmap)Area.GetDrawObj("PVH"); 
	DrawBitmap PVL = (DrawBitmap)Area.GetDrawObj("PVL"); 
	DrawBitmap PVLL = (DrawBitmap)Area.GetDrawObj("PVLL"); 
	DrawBitmap OPH=(DrawBitmap)Area.GetDrawObj("OPH");
	DrawBitmap OPL=(DrawBitmap)Area.GetDrawObj("OPL");

	Alm.Visible = false;
	PVHH.Visible = false;
	PVH.Visible = false;
	PVL.Visible = false;
	PVLL.Visible = false;

	OPH.Visible=false;
	OPL.Visible=false;	
	double dbValue = 0;
	int nValue = 0;
	int nValueOP=0;
	bool bValue = false;
	int nDataType = 0;

	string tagName = Area.Variable[0] + "/" + almFlg;
	string tagNameOP = Area.Variable[0] + "/" + almFlgOP;
	if(CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType))
	{
		switch (nValue)
		{
			case 1:
				PVH.Visible = true;
				break;
			case -1:
				PVL.Visible = true;
				break;
			case 2:
				PVHH.Visible = true;
				break;
			case -2:
				PVLL.Visible = true;
				break;
			default:
				break;
		}
		if(nValue != 0)
			Alm.Visible = true;
	}
	if(CommonFunction.GetValueWithType(tagNameOP,ref dbValue,ref nValueOP,ref bValue,ref nDataType))
	{
		switch (nValueOP)
		{
			case 1:
				OPH.Visible=true;
				break;
			case -1:
				OPL.Visible=true;
				break;
			default:
				break;
		}
		if(nValue != 0)
			Alm.Visible = true;
	}
	return; 
}



// =========================================================================================
//
// Note: For 大连恒利项目，点击TagNmae弹出Detail画面的功能被屏蔽掉
//
// =========================================================================================
//Do not remove or update this comment
//Event Delegate:EventHandler
//Event Handler:OnDynInitialize
public void DrawArea100_OnDynInitialize(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender;
	DynEventArgs dynArgs = (DynEventArgs)e;
	DrawArea drawArea = (DrawArea)dynArgs.sender;

	Area.Enabled = true;

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

	Picture pic = CommonFunction.GetThisPicture(Area);
	if(pic != null)
	{

		if(Area.BReference)//图素
		{
			//将顶级DrawArea的Variable[0]变量传递到图素级DrawArea：
			DrawArea MainArea = pic.GetDrawArea();
			Area.Variable[0] = MainArea.Variable[0];

			ControlLabel lab = (ControlLabel)CommonFunction.GetLabelOfControl(Area);
			lab.Selected = false;
			/*
			//20120312，根据Zoom因子，重置TB的Font.Size：
			PointF sF = Area.GetScaleFactor();
			//float sFX = sF.X;
			float sFY = sF.Y;
			TextBox TB = (TextBox)(Area.GetControlObj("TB"));
			lab = (ControlLabel)(CommonFunction.GetLabelOfControl(TB));
			
			//在修改Size之前，将原始的Size保存，由Run态返回编辑态时再将原始的Size反写回去：
			lab.Variable[1] = TB.Font.Size.ToString();
			
			int nSize = (int)(TB.Font.Size/sFY);
			TB.Font = new Font("Arial", nSize);
			lab.m_rect.Height = nSize;
			*/
		}
		else
		{
			pic.Text = Area.Variable[0];
		}
	}
	Area.Variable[0] = Area.Variable[0].ToUpper();
	return;
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynFinalize 
public void DrawArea100_OnDynFinalize(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 
/*
//	Area.Enabled = false;
	if(Area.BReference)//图素
	{
		TextBox TB = (TextBox)(Area.GetControlObj("TB"));
		ControlLabel lab = (ControlLabel)(CommonFunction.GetLabelOfControl(TB));

		//在修改Size之前，将原始的Size保存，由Run态返回编辑态时再将原始的Size反写回去：
		int nSize = Convert.ToInt32(lab.Variable[1]);
		TB.Font = new Font("Arial", nSize);
		lab.m_rect.Height = nSize;
	}
*/
    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler
//Event Handler:OnDynClick
public void DrawArea100_OnDynClick(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender;
	DynEventArgs dynArgs = (DynEventArgs)e;
	DrawArea drawArea = (DrawArea)dynArgs.sender;
	object obj = Area.GetControlObj("TB");
	if (obj != null)
	{
		TextBox TB = (TextBox)obj;
		//Area.Enabled = false;
		TB.Visible = false;
		TB.Enabled = false;
		DrawText SP = (DrawText)Area.GetDrawObj("SP");
		SP.Visible = true;
		DrawText OP = (DrawText)Area.GetDrawObj("OP");
		OP.Visible = true;
	}
	return;
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void DrawArea100_PVUnit2_OnDynInitialize(Object sender, EventArgs e)
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
public void DrawArea100_PVUnit1_OnDynInitialize(Object sender, EventArgs e)
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
public void DrawArea100_Alm_OnDynInitialize(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawBitmap Alm = (DrawBitmap)dynArgs.sender; 
	DrawText txtAlm = (DrawText)Area.GetDrawObj("txtAlm");

	Alm.Visible = false;
	txtAlm.Caption = "";

	int nAlmSta = CommonFunction.GetTagAlarmStatus( Area.Variable[0] );

	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	string tagName = Area.Variable[0] + "/" + Alm.Variable[0];
	if(CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType))
	{
		if(dbValue == 3)
			txtAlm.Caption = "PV_HiHiHi";
		else if(dbValue == 2)
			txtAlm.Caption = "PV_HiHi";
		else if(dbValue == 1)
			txtAlm.Caption = "PV_High";
		else if(dbValue == -1)
			txtAlm.Caption = "PV_Low";
		else if(dbValue == -2)
			txtAlm.Caption = "PV_LoLo";
		else if(dbValue == -3)
			txtAlm.Caption = "PV_LoLoLo";

		if( dbValue==3 || dbValue==2 || dbValue==-2 || dbValue==-3 )
		{
			if( nAlmSta==2 || nAlmSta==3 )
			{
				Alm.Visible = true;
				Alm.ImageFile = "Pks_fpPID_Alm1_b.png";
			}
		}
		else if( dbValue==1 || dbValue==-1 )
		{
			if( nAlmSta==2 || nAlmSta==3 )
			{
				Alm.Visible = true;
				Alm.ImageFile = "Pks_fpPID_Alm_b.png";
			}
		}
	}
	return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void DrawArea100_Alm_OnDynAnimation(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawBitmap Alm = (DrawBitmap)dynArgs.sender; 
	DrawText txtAlm = (DrawText)Area.GetDrawObj("txtAlm");

	Alm.Visible = false;
	txtAlm.Caption = "";

	int nAlmSta = CommonFunction.GetTagAlarmStatus( Area.Variable[0] );

	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	string tagName = Area.Variable[0] + "/" + Alm.Variable[0];
	if(CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType))
	{
		if(dbValue == 3)
			txtAlm.Caption = "PV_HiHiHi";
		else if(dbValue == 2)
			txtAlm.Caption = "PV_HiHi";
		else if(dbValue == 1)
			txtAlm.Caption = "PV_High";
		else if(dbValue == -1)
			txtAlm.Caption = "PV_Low";
		else if(dbValue == -2)
			txtAlm.Caption = "PV_LoLo";
		else if(dbValue == -3)
			txtAlm.Caption = "PV_LoLoLo";

		if( dbValue==3 || dbValue==2 || dbValue==-2 || dbValue==-3 )
		{
			Alm.Visible = true;
			if( nAlmSta==2 )
			{
				if(Alm.ImageFile == "Pks_fpPID_Alm1_b.png")
					Alm.ImageFile = "Pks_fpPID_Alm1_w.png";
				else
					Alm.ImageFile = "Pks_fpPID_Alm1_b.png";
			}
		}
		else if( dbValue==1 || dbValue==-1 )
		{
			Alm.Visible = true;
			if( nAlmSta==2 )
			{
				Alm.Visible = true;
				if(Alm.ImageFile == "Pks_fpPID_Alm_b.png")
					Alm.ImageFile = "Pks_fpPID_Alm_w.png";
				else
					Alm.ImageFile = "Pks_fpPID_Alm_b.png";
			}
		}
	}
	return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void DrawArea100_Ack_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawButton Ack = (DrawButton)dynArgs.sender; 
   
	CommonFunction.AlarmAckItem(Area.Variable[0]);
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void DrawArea100_Mode_Combox_OnDynInitialize(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawButton Combox= (DrawButton)dynArgs.sender; 
	DrawText Mode = (DrawText)Area.GetDrawObj("Mode");
/*
	PointF sF = Area.GetScaleFactor();
	PointF sF1 = new PointF(1,1);

	//控制组中的面板：
	if(Area.BReference)
	{
		DrawArea TopArea = (DrawArea)(Area.Parent);
		sF1 = TopArea.GetScaleFactor();
		MessageBox.Show(sF1.X.ToString());
	}

	Combox.Variable[0] = Area.Variable[0]+"/MODE";
	Combox.Variable[1] = "MAN-1/AUTO-2/CAS-3";
	Combox.Variable[2] = (Mode.Width/sF.X/sF1.X).ToString();
	Combox.Variable[3] = (Mode.Height*3/sF.Y/sF1.Y).ToString();
*/
	return; 
}


//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void DrawArea100_Mode_Combox_OnDynClick(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawButton Mode_Combox = (DrawButton)dynArgs.sender; 
	DrawText Mode = (DrawText)Area.GetDrawObj("Mode");

	//=====================================
	PointF sF = Area.GetScaleFactor();
	Mode_Combox.Variable[0] = Area.Variable[0]+"/MODE";
	Mode_Combox.Variable[1] = "MAN-1/AUTO-2/CAS-3";
	Mode_Combox.Variable[2] = (Mode.Width/sF.X).ToString();
	Mode_Combox.Variable[3] = (Mode.Height*3/sF.Y).ToString();


	string picName = "Pks_fp_PID_Combox.grf";
	//=====================================
	int nTop = (int)Mode.VerticalPosition + (int)Mode.Height;
	int nLeft = (int)Mode.HorizontalPosition;

	//面板：
	Picture pic = null;
	object obj = Area.Parent;
	Type type = obj.GetType();
	if( type.Name == "Picture" )
	{
		pic = (Picture)(Area.Parent);
		nTop = nTop + pic.Top + 32 - 8; //22为窗口Header的高度；
		nLeft = nLeft + pic.Left + 4; //4为窗口左侧边的宽度；
	} 

	//控制组中的面板：
	if(Area.BReference)
	{
		DrawArea TopArea = (DrawArea)(Area.Parent);
		//PointF sF = Area.GetScaleFactor();
		PointF sFTop = TopArea.GetScaleFactor();

		ControlLabel lab = (ControlLabel)CommonFunction.GetLabelOfControl(Area);
		pic = (Picture)(Area.Parent.Parent);
		nLeft = (int)(nLeft/sF.X + lab.m_rect.X/sFTop.X + pic.Left + 4); //4为窗口左侧边的宽度；
		nTop = (int)(nTop/sF.Y + lab.m_rect.Y/sFTop.Y + pic.Top + 30); //30为窗口Header的高度；
	}

	//=====================================
	string[] strVariable = new string[10];
	for ( int i=0;i<10;i++ )
	{
		strVariable[i] = Mode_Combox.Variable[i];
	}

	//=====================================
	CommonFunction.OpenPicture(picName,nTop,nLeft,strVariable);
	return; 
}//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void DrawArea100_SPUp0_OnDynClick(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawRectangle SPUp = (DrawRectangle)dynArgs.sender; 
  
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;
	
	double dbSpan = 0.01;

 	// get SH SL
 	//================================
	double dbSH = 100;
	double dbSL = 0;

	string tagName = Area.Variable[0] + "/PVEUHI";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
		dbSH = dbValue;

	tagName = Area.Variable[0] + "/PVEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
		dbSL = dbValue;

	dbSpan = ( dbSH - dbSL )*dbSpan;

	tagName = Area.Variable[0] + "/SP";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		double tmp = dbValue+dbSpan;
		if(tmp > dbSH)
			tmp = dbSH;
		if(tmp < dbSL)
			tmp = dbSL;
		CommonFunction.DSI_SetValue(tagName, tmp);
	}
	return; 
}//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void DrawArea100_SPDown0_OnDynClick(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawRectangle SPUp = (DrawRectangle)dynArgs.sender; 
  
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;
	
	double dbSpan = 0.01;

 	// get SH SL
 	//================================
	double dbSH = 100;
	double dbSL = 0;

	string tagName = Area.Variable[0] + "/PVEUHI";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
		dbSH = dbValue;

	tagName = Area.Variable[0] + "/PVEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
		dbSL = dbValue;

	dbSpan = ( dbSH - dbSL )*dbSpan;

	tagName = Area.Variable[0] + "/SP";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		double tmp = dbValue-dbSpan;
		if(tmp > dbSH)
			tmp = dbSH;
		if(tmp < dbSL)
			tmp = dbSL;
		CommonFunction.DSI_SetValue(tagName, tmp);
	}
	return; 
}// =====================================================================
//
// Fast Up Button:  10%   For SP or OP
//
// =====================================================================
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void DrawArea100_OPUp_OnDynClick(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawRectangle SPUp = (DrawRectangle)dynArgs.sender; 
  
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;
	
	double dbSpan = 0.1;	// Fast UP --> 10%

 	// Check updated object is SP or OP
 	//================================
	bool bModifyV = false;
	bool bModifySP = false;
	DrawText txtMode = (DrawText)Area.GetDrawObj("Mode");
	if( txtMode != null)
	{
		if( txtMode.Caption == "AUTO")
		{
			bModifyV = true; 
			bModifySP = true; 
		}
		else if( txtMode.Caption == "MAN")
		{
			bModifyV = true; 			
		}
	}

	if( !bModifyV ) return;	

 	// get SH SL
 	//================================
	double dbSH = 100;
	double dbSL = 0;

	string tagName = "";
	bool ret = true;
	if( bModifySP )
	{
		tagName = Area.Variable[0] + "/PVEUHI";
		ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
		if(ret)
			dbSH = dbValue;

		tagName = Area.Variable[0] + "/PVEULO";
		ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
		if(ret)
			dbSL = dbValue;

		tagName = Area.Variable[0] + "/SP";
	}
	else
	{
		tagName = Area.Variable[0] + "/OP";
	}

	dbSpan = ( dbSH - dbSL )*dbSpan;

	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		double tmp = dbValue+dbSpan;
		if(tmp > dbSH)
			tmp = dbSH;
		if(tmp < dbSL)
			tmp = dbSL;
		CommonFunction.DSI_SetValue(tagName, tmp);
	}
	return; 


}// =====================================================================
//
// Fast Down Button:  10%   For SP or OP
//
// =====================================================================
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void DrawArea100_OPDown_OnDynClick(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawRectangle SPUp = (DrawRectangle)dynArgs.sender; 
  
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;
	
	double dbSpan = 0.1;	// Fast Down --> 10%

 	// Check updated object is SP or OP
 	//================================
	bool bModifyV = false;
	bool bModifySP = false;
	DrawText txtMode = (DrawText)Area.GetDrawObj("Mode");
	if( txtMode != null)
	{
		if( txtMode.Caption == "AUTO")
		{
			bModifyV = true; 
			bModifySP = true; 
		}
		else if( txtMode.Caption == "MAN")
		{
			bModifyV = true; 			
		}
	}

	if( !bModifyV ) return;	

 	// get SH SL
 	//================================
	double dbSH = 100;
	double dbSL = 0;

	string tagName = "";
	bool ret = true;
	if( bModifySP )
	{
		tagName = Area.Variable[0] + "/PVEUHI";
		ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
		if(ret)
			dbSH = dbValue;

		tagName = Area.Variable[0] + "/PVEULO";
		ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
		if(ret)
			dbSL = dbValue;

		tagName = Area.Variable[0] + "/SP";
	}
	else
	{
		tagName = Area.Variable[0] + "/OP";
	}

	dbSpan = ( dbSH - dbSL )*dbSpan;

	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		double tmp = dbValue-dbSpan;
		if(tmp > dbSH)
			tmp = dbSH;
		if(tmp < dbSL)
			tmp = dbSL;
		CommonFunction.DSI_SetValue(tagName, tmp);
	}
	return; 
}// =====================================================================
//
// Down Button:  1%   For SP or OP
//
// =====================================================================
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void DrawArea100_SPDown_OnDynClick(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawRectangle SPUp = (DrawRectangle)dynArgs.sender; 
  
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;
	
	double dbSpan = 0.01;

 	// Check updated object is SP or OP
 	//================================
	bool bModifyV = false;
	bool bModifySP = false;
	DrawText txtMode = (DrawText)Area.GetDrawObj("Mode");
	if( txtMode != null)
	{
		if( txtMode.Caption == "AUTO")
		{
			bModifyV = true; 
			bModifySP = true; 
		}
		else if( txtMode.Caption == "MAN")
		{
			bModifyV = true; 			
		}
	}

	if( !bModifyV ) return;	

 	// get SH SL
 	//================================
	double dbSH = 100;
	double dbSL = 0;

	string tagName = "";
	bool ret = true;
	if( bModifySP )
	{
		tagName = Area.Variable[0] + "/PVEUHI";
		ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
		if(ret)
			dbSH = dbValue;

		tagName = Area.Variable[0] + "/PVEULO";
		ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
		if(ret)
			dbSL = dbValue;

		tagName = Area.Variable[0] + "/SP";
	}
	else
	{
		tagName = Area.Variable[0] + "/OP";
	}

	dbSpan = ( dbSH - dbSL )*dbSpan;

	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		double tmp = dbValue-dbSpan;
		if(tmp > dbSH)
			tmp = dbSH;
		if(tmp < dbSL)
			tmp = dbSL;
		CommonFunction.DSI_SetValue(tagName, tmp);
	}
	return; 
}// =====================================================================
//
// Up Button:  1%   For SP or OP
//
// =====================================================================
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void DrawArea100_SPUp_OnDynClick(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawRectangle SPUp = (DrawRectangle)dynArgs.sender; 
  
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;
	
	double dbSpan = 0.01;

 	// Check updated object is SP or OP
 	//================================
	bool bModifyV = false;
	bool bModifySP = false;
	DrawText txtMode = (DrawText)Area.GetDrawObj("Mode");
	if( txtMode != null)
	{
		if( txtMode.Caption == "AUTO")
		{
			bModifyV = true; 
			bModifySP = true; 
		}
		else if( txtMode.Caption == "MAN")
		{
			bModifyV = true; 			
		}
	}

	if( !bModifyV ) return;	

 	// get SH SL
 	//================================
	double dbSH = 100;
	double dbSL = 0;

	string tagName = "";
	bool ret = true;
	if( bModifySP )
	{
		tagName = Area.Variable[0] + "/PVEUHI";
		ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
		if(ret)
			dbSH = dbValue;

		tagName = Area.Variable[0] + "/PVEULO";
		ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
		if(ret)
			dbSL = dbValue;

		tagName = Area.Variable[0] + "/SP";
	}
	else
	{
		tagName = Area.Variable[0] + "/OP";
	}

	dbSpan = ( dbSH - dbSL )*dbSpan;

	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		double tmp = dbValue+dbSpan;
		if(tmp > dbSH)
			tmp = dbSH;
		if(tmp < dbSL)
			tmp = dbSL;
		CommonFunction.DSI_SetValue(tagName, tmp);
	}
	return; 
}//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void DrawArea100_SPBtn_OnDynInitialize(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawBitmap SVButton = (DrawBitmap)dynArgs.sender; 
   
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	// get L1, StartXY,EndXY
 	//================================
	DrawLine L1 = (DrawLine)Area.GetDrawObj("L1");
	double dbL1StartY = L1.StartY;
	double dbL1EndY = L1.EndY;

 	// get SH SL
 	//================================
	double dbSH = 100;
	double dbSL = 0;

	string tagName = Area.Variable[0] + "/PVEUHI";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
		dbSH = dbValue;

	tagName = Area.Variable[0] + "/PVEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
		dbSL = dbValue;

 	//================================
	tagName = Area.Variable[0] + "/SP";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret && (dbSH>dbSL) && (dbL1EndY>dbL1StartY))
	{
		//当SVButton超出L1的上下限时，做异常情况的处理：
		if(dbValue > dbSH)
			dbValue = dbSH;
		if(dbValue < dbSL)
			dbValue = dbSL;

		float y = (float)SVButton.VerticalPosition;
		SVButton.SetPropertyY((dbL1EndY - (dbL1EndY-dbL1StartY)*(dbValue-dbSL)/(dbSH-dbSL)-SVButton.Height/2));
/*
		SVButton.VerticalPosition = Convert.ToInt32(dbL1EndY - (dbL1EndY-dbL1StartY)*(dbValue-dbSL)/(dbSH-dbSL)-SVButton.Height/2);
		float y1 = (float)SVButton.VerticalPosition;
		float deltaY = y1 - y;
		SVButton.MoveTmp(0,deltaY);
		SVButton.Move(0,deltaY);
*/
	}
	return; 
}


//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void DrawArea100_SPBtn_OnDynAnimation(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawBitmap SVButton = (DrawBitmap)dynArgs.sender; 
   
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	// get L1, StartXY,EndXY
 	//================================
	DrawLine L1 = (DrawLine)Area.GetDrawObj("L1");
	double dbL1StartY = L1.StartY;
	double dbL1EndY = L1.EndY;

 	// get SH SL
 	//================================
	double dbSH = 100;
	double dbSL = 0;

	string tagName = Area.Variable[0] + "/PVEUHI";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
		dbSH = dbValue;

	tagName = Area.Variable[0] + "/PVEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
		dbSL = dbValue;

 	//================================
	tagName = Area.Variable[0] + "/SP";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret && (dbSH>dbSL) && (dbL1EndY>dbL1StartY))
	{
		//当SVButton超出L1的上下限时，做异常情况的处理：
		if(dbValue > dbSH)
			dbValue = dbSH;
		if(dbValue < dbSL)
			dbValue = dbSL;

		float y = (float)SVButton.VerticalPosition;
		SVButton.SetPropertyY((dbL1EndY - (dbL1EndY-dbL1StartY)*(dbValue-dbSL)/(dbSH-dbSL)-SVButton.Height/2));
/*
		SVButton.VerticalPosition = Convert.ToInt32(dbL1EndY - (dbL1EndY-dbL1StartY)*(dbValue-dbSL)/(dbSH-dbSL)-SVButton.Height/2);
		float y1 = (float)SVButton.VerticalPosition;
		float deltaY = y1 - y;
		SVButton.MoveTmp(0,deltaY);
		SVButton.Move(0,deltaY);
*/
	}
	return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void DrawArea100_OPBar_OnDynInitialize(Object sender, EventArgs e)	//PVBar
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawRectangle PVBar = (DrawRectangle)dynArgs.sender; 
	
	PVBar.Variable[0] = Area.Variable[0] + "/OP";
/*
	PVBar.Variable[1] = Area.Variable[0] + "/PVEUHI";
	PVBar.Variable[2] = Area.Variable[0] + "/PVEULO";
*/
	return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void DrawArea100_OPBar_OnDynAnimation(Object sender, EventArgs e)	//PVBar
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawRectangle PVBar = (DrawRectangle)dynArgs.sender; 
	
	string tagName = Area.Variable[0];
	bool bIsAlarm = CommonFunction.IsTagOnAlarm(tagName);
	if(bIsAlarm)
		PVBar.ForegroundColor = Color.FromArgb(255,253,65,2);
	else
		PVBar.ForegroundColor = Color.FromArgb(255,191,191,0);
	return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void DrawArea100_PV_OnDynInitialize(Object sender, EventArgs e)	//SV
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawText SV = (DrawText)dynArgs.sender; 

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
		SV.Caption = dbValue.ToString(strDigit);
	}
	else
		SV.Caption = "#####0.#";
	return; 
}


//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void DrawArea100_PV_OnDynAnimation(Object sender, EventArgs e)	//SV
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawText SV = (DrawText)dynArgs.sender; 

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
		SV.Caption = dbValue.ToString(strDigit);
	}
	else
		SV.Caption = "#####0.#";
	return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void DrawArea100_OP_OnDynInitialize(Object sender, EventArgs e)	//SV
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawText SV = (DrawText)dynArgs.sender; 

	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	int nDigit = 1;
/*
	string tagName = Area.Variable[0] + "/PVFORMAT";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
		nDigit = Convert.ToInt32(dbValue);
*/
	string strDigit = "f" + nDigit.ToString();
	
	string tagName = Area.Variable[0] + "/OP";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		SV.Caption = dbValue.ToString(strDigit);
	}
	else
		SV.Caption = "#####0.#";
	return; 
}


//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void DrawArea100_OP_OnDynAnimation(Object sender, EventArgs e)	//SV
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawText SV = (DrawText)dynArgs.sender; 

	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	int nDigit = 1;
/*
	string tagName = Area.Variable[0] + "/PVFORMAT";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
		nDigit = Convert.ToInt32(dbValue);
*/
	string strDigit = "f" + nDigit.ToString();
	
	string tagName = Area.Variable[0] + "/OP";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		SV.Caption = dbValue.ToString(strDigit);
	}
	else
		SV.Caption = "#####0.#";
	return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void DrawArea100_OP_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText OP = (DrawText)dynArgs.sender; 
   
	if(OP.Visible == true)
	{
		// 不弹出输入面板，DrawText隐藏，TextBox显示	
		object obj = Area.GetControlObj("TB");
		if(obj != null)
		{
			TextBox TB = (TextBox)obj; 
			if(TB != null)
			{
				TB.Enabled = true;
				TB.Visible = true;
				TB.Text = "";
				TB.Focus();
				OP.Visible = false;

				//调整TB的位置：
				//调整控件的位置不能直接给相关属性赋值，应该调用函数MoveControl()，这样才能真正实现控件的移动；
				CommonFunction.MoveControl(Area,TB,(int)(OP.VerticalPosition),(int)(OP.HorizontalPosition));
	
				obj = CommonFunction.GetLabelOfControl(TB);
				if(obj != null)
				{
					ControlLabel lab = (ControlLabel)obj;
					//给TB传递参数：
					lab.Variable[0] = Area.Variable[0] + "/OP";
					//修改宽度：
					lab.m_rect.Width = (float)(OP.Width+1);
				}
			}
		}
	}
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void DrawArea100_SP_OnDynInitialize(Object sender, EventArgs e)	//SV
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawText SV = (DrawText)dynArgs.sender; 

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
		SV.Caption = dbValue.ToString(strDigit);
	}
	else
		SV.Caption = "#####0.#";
	return; 
}


//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void DrawArea100_SP_OnDynAnimation(Object sender, EventArgs e)	//SV
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawText SV = (DrawText)dynArgs.sender; 

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
		SV.Caption = dbValue.ToString(strDigit);
	}
	else
		SV.Caption = "#####0.#";
	return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void DrawArea100_SP_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText OP = (DrawText)dynArgs.sender; 
   
	if(OP.Visible == true)
	{
		// 不弹出输入面板，DrawText隐藏，TextBox显示	
		object obj = Area.GetControlObj("TB");
		if(obj != null)
		{
			TextBox TB = (TextBox)obj; 
			if(TB != null)
			{
				//Area.Enabled = true;
				TB.Visible = true;
				TB.Enabled = true;
				TB.Text = "";
				TB.Focus();
				
				OP.Visible = false;
		
				//调整TB的位置：
				//调整控件的位置不能直接给相关属性赋值，应该调用函数MoveControl()，这样才能真正实现控件的移动；
				CommonFunction.MoveControl(Area,TB,(int)(OP.VerticalPosition),(int)(OP.HorizontalPosition));
	
				obj = CommonFunction.GetLabelOfControl(TB);
				if(obj != null)
				{
					ControlLabel lab = (ControlLabel)obj;
					//给TB传递参数：
					lab.Variable[0] = Area.Variable[0] + "/SP";
					//修改宽度：
					lab.m_rect.Width = (float)(OP.Width+1);
				}
			}
		}
	}
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void DrawArea100_PVBar_OnDynInitialize(Object sender, EventArgs e)	//PVBar
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawRectangle PVBar = (DrawRectangle)dynArgs.sender; 
	
	PVBar.Variable[0] = Area.Variable[0] + "/PV";
	PVBar.Variable[1] = Area.Variable[0] + "/PVEULO";
	PVBar.Variable[2] = Area.Variable[0] + "/PVEUHI";
	return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void DrawArea100_PVBar_OnDynAnimation(Object sender, EventArgs e)	//PVBar
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawRectangle PVBar = (DrawRectangle)dynArgs.sender; 
	
	string tagName = Area.Variable[0];
	bool bIsAlarm = CommonFunction.IsTagOnAlarm(tagName);
	if(bIsAlarm)
		PVBar.ForegroundColor = Color.FromArgb(255,253,65,2);
	else
		PVBar.ForegroundColor = Color.FromArgb(255,0,191,191);
	return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void DrawArea100_PVUnit_OnDynInitialize(Object sender, EventArgs e)
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
public void DrawArea100_SL_OnDynInitialize(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawText SL = (DrawText)dynArgs.sender; 
   
	int nDigit = 2;
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;
	string tagName = Area.Variable[0] + "/PVFORMAT";
	if(CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType))
		nDigit = (int)dbValue;

	string strDigit = "f" + nDigit.ToString();
	double dbSL = 0;
	tagName = Area.Variable[0] + "/PVEULO";
	if(CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType))
		dbSL = dbValue;

	SL.Caption = dbSL.ToString(strDigit);
	return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void DrawArea100_SL_OnDynAnimation(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawText SL = (DrawText)dynArgs.sender; 
   
	int nDigit = 2;
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;
	string tagName = Area.Variable[0] + "/PVFORMAT";
	if(CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType))
		nDigit = (int)dbValue;

	string strDigit = "f" + nDigit.ToString();
	double dbSL = 0;
	tagName = Area.Variable[0] + "/PVEULO";
	if(CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType))
		dbSL = dbValue;

	SL.Caption = dbSL.ToString(strDigit);
	return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void DrawArea100_SH_OnDynInitialize(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawText SL = (DrawText)dynArgs.sender; 
   
	int nDigit = 2;
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;
	string tagName = Area.Variable[0] + "/PVFORMAT";
	if(CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType))
		nDigit = (int)dbValue;

	string strDigit = "f" + nDigit.ToString();
	double dbSL = 0;
	tagName = Area.Variable[0] + "/PVEUHI";
	if(CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType))
		dbSL = dbValue;

	SL.Caption = dbSL.ToString(strDigit);
	return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void DrawArea100_SH_OnDynAnimation(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawText SL = (DrawText)dynArgs.sender; 
   
	int nDigit = 2;
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;
	string tagName = Area.Variable[0] + "/PVFORMAT";
	if(CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType))
		nDigit = (int)dbValue;

	string strDigit = "f" + nDigit.ToString();
	double dbSL = 0;
	tagName = Area.Variable[0] + "/PVEUHI";
	if(CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType))
		dbSL = dbValue;

	SL.Caption = dbSL.ToString(strDigit);
	return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void DrawArea100_TagComment_OnDynInitialize(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawText TagComment = (DrawText)dynArgs.sender; 
	
	string strTagName = Area.Variable[0];
	string strTemp = CommonFunction.GetTagComment(strTagName);
	TagComment.Caption = strTemp;
	return; 
}


//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void DrawArea100_TagComment_OnDynAnimation(Object sender, EventArgs e)	//TagDiscription
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
public void DrawArea100_TagName_OnDynInitialize(Object sender, EventArgs e)	//TagName
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
public void DrawArea100_TagName_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText TagName = (DrawText)dynArgs.sender; 
 
	//CommonFunction.OpenDetail(Area.Variable[0]); 

	int nLeft = 0;
	int nTop = 0;
	string[] strVariable = new string[1];
	strVariable[0] = Area.Variable[0];
	CommonFunction.OpenPicture("Pks_dfp_PID.grf", nTop, nLeft, strVariable);


 
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void DrawArea100_Mode_OnDynInitialize(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawText Mode = (DrawText)dynArgs.sender; 
	
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	string tagName = Area.Variable[0] + "/MODE";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		if(dbValue==1)
			Mode.Caption = "MAN";
		else if(dbValue==2)
			Mode.Caption = "AUTO";
		else if(dbValue==3)
			Mode.Caption = "CAS";
	}
	else
			Mode.Caption = "###";
	return; 
}


//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void DrawArea100_Mode_OnDynAnimation(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawText Mode = (DrawText)dynArgs.sender; 
	
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	string tagName = Area.Variable[0] + "/MODE";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		if(dbValue==1)
			Mode.Caption = "MAN";
		else if(dbValue==2)
			Mode.Caption = "AUTO";
		else if(dbValue==3)
			Mode.Caption = "CAS";
	}
	else
			Mode.Caption = "###";
	return; 
}


//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void DrawArea100_Mode_OnDynClick(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawText Mode = (DrawText)dynArgs.sender; 
	
	return; 
}
//Do not remove or update this comment
//Event Delegate:KeyEventHandler
//Event Handler:KeyUp
public void DrawArea100_TB_KeyUp(Object sender, KeyEventArgs e)
{
	TextBox TB = (TextBox)sender;
	DrawArea Area = CommonFunction.GetThisDrawArea(TB);

	DrawText SP = (DrawText)Area.GetDrawObj("SP");
	DrawText OP = (DrawText)Area.GetDrawObj("OP");

	switch ( e.KeyData )
	{
	case Keys.Enter:
		if(TB.Text == "" || TB.Text == null)
		{
			//Area.Enabled = false;
			TB.Visible = false;
			TB.Enabled = false;
			SP.Visible = true;
			OP.Visible = true;
			return;
		}
		else
		{
			string SPInputValue = TB.Text;
			double dbSPValue = Convert.ToDouble(SPInputValue);

			object obj = CommonFunction.GetLabelOfControl(TB);
			if (obj != null)
			{
				ControlLabel lab = (ControlLabel)obj;
				string tagName = lab.Variable[0];
				CommonFunction.DSI_SetValue(tagName, dbSPValue);
			}
			//Area.Enabled = false;
			TB.Visible = false;
			TB.Enabled = false;
			SP.Visible = true;
			OP.Visible = true;
		}
		break;
	}
	return;
}


}
