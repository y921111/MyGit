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
public class PIC_TEST:IDynCodeAttachDetach
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
strObjectName = "Rect6";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Rect6_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect5";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect5_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect5";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Rect5_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect4";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect4_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect4";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Rect4_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect3";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect3_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect3";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Rect3_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Button1";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Button1_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Ellipse1";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Ellipse1_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea26";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea26_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea26.Text3";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea26_Text3_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea26.Text3";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea26_Text3_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea26.Text2";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea26_Text2_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea26.Text2";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea26_Text2_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea26.Text1";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea26_Text1_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea25";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea25_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea25.Text3";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea25_Text3_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea25.Text3";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea25_Text3_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea25.Text2";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea25_Text2_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea25.Text2";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea25_Text2_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea25.Text1";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea25_Text1_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea24";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea24_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea24.Text3";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea24_Text3_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea24.Text3";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea24_Text3_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea24.Text2";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea24_Text2_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea24.Text2";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea24_Text2_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea24.Text1";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea24_Text1_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea23";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea23_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea23.Text3";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea23_Text3_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea23.Text3";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea23_Text3_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea23.Text2";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea23_Text2_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea23.Text2";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea23_Text2_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea23.Text1";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea23_Text1_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea22";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea22_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea22.Text3";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea22_Text3_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea22.Text3";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea22_Text3_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea22.Text2";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea22_Text2_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea22.Text2";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea22_Text2_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea22.Text1";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea22_Text1_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea21";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea21_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea21";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea21_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea21.rectClick";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea21_rectClick_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea18";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea18_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea18.Mode";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea18_Mode_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea18.Mode";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea18_Mode_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea18.Mode";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea18_Mode_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea18.PVUnit";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea18_PVUnit_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea18.SP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea18_SP_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea18.SP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea18_SP_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea18.PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea18_PV_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea18.PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea18_PV_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea18.TagName";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea18_TagName_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea18.TagName";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea18_TagName_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea17";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea17_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea17.Mode";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea17_Mode_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea17.Mode";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea17_Mode_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea17.Mode";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea17_Mode_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea17.PVUnit";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea17_PVUnit_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea17.SP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea17_SP_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea17.SP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea17_SP_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea17.PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea17_PV_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea17.PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea17_PV_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea17.TagName";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea17_TagName_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea17.TagName";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea17_TagName_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea16";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea16_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea16.Mode";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea16_Mode_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea16.Mode";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea16_Mode_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea16.Mode";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea16_Mode_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea16.PVUnit";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea16_PVUnit_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea16.SP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea16_SP_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea16.SP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea16_SP_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea16.PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea16_PV_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea16.PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea16_PV_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea16.TagName";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea16_TagName_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea16.TagName";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea16_TagName_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea13";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea13_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea13.Text3";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea13_Text3_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea13.Text3";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea13_Text3_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea13.Text2";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea13_Text2_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea13.Text2";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea13_Text2_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea13.Text1";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea13_Text1_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea12";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea12_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea12.Text3";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea12_Text3_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea12.Text3";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea12_Text3_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea12.Text2";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea12_Text2_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea12.Text2";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea12_Text2_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea12.Text1";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea12_Text1_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea7";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea7_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea7.Text3";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea7_Text3_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea7.Text3";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea7_Text3_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea7.Text2";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea7_Text2_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea7.Text2";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea7_Text2_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea7.Text1";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea7_Text1_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea6";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea6_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea6.Text2";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea6_Text2_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea6.Text2";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea6_Text2_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea5";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea5_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea5.Mode";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea5_Mode_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea5.Mode";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea5_Mode_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea5.Mode";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea5_Mode_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea5.PVUnit";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea5_PVUnit_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea5.SP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea5_SP_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea5.SP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea5_SP_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea5.PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea5_PV_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea5.PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea5_PV_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea5.TagName";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea5_TagName_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea5.TagName";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea5_TagName_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea4";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea4_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea4.Mode";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea4_Mode_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea4.Mode";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea4_Mode_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea4.Mode";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea4_Mode_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea4.PVUnit";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea4_PVUnit_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea4.SP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea4_SP_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea4.SP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea4_SP_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea4.PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea4_PV_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea4.PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea4_PV_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea4.TagName";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea4_TagName_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea4.TagName";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea4_TagName_OnDynClick;
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
strObjectName = "Rect6";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect6_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect6";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Rect6_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect5";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect5_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect5";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Rect5_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect4";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect4_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect4";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Rect4_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect3";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect3_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect3";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Rect3_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Button1";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Button1_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Ellipse1";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Ellipse1_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea26";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea26_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea26.Text3";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea26_Text3_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea26.Text3";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea26_Text3_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea26.Text2";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea26_Text2_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea26.Text2";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea26_Text2_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea26.Text1";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea26_Text1_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea25";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea25_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea25.Text3";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea25_Text3_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea25.Text3";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea25_Text3_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea25.Text2";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea25_Text2_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea25.Text2";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea25_Text2_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea25.Text1";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea25_Text1_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea24";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea24_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea24.Text3";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea24_Text3_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea24.Text3";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea24_Text3_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea24.Text2";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea24_Text2_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea24.Text2";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea24_Text2_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea24.Text1";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea24_Text1_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea23";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea23_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea23.Text3";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea23_Text3_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea23.Text3";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea23_Text3_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea23.Text2";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea23_Text2_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea23.Text2";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea23_Text2_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea23.Text1";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea23_Text1_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea22";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea22_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea22.Text3";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea22_Text3_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea22.Text3";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea22_Text3_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea22.Text2";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea22_Text2_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea22.Text2";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea22_Text2_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea22.Text1";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea22_Text1_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea21";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea21_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea21";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea21_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea21.rectClick";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea21_rectClick_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea18";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea18_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea18.Mode";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea18_Mode_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea18.Mode";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea18_Mode_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea18.Mode";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea18_Mode_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea18.PVUnit";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea18_PVUnit_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea18.SP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea18_SP_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea18.SP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea18_SP_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea18.PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea18_PV_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea18.PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea18_PV_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea18.TagName";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea18_TagName_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea18.TagName";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea18_TagName_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea17";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea17_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea17.Mode";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea17_Mode_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea17.Mode";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea17_Mode_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea17.Mode";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea17_Mode_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea17.PVUnit";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea17_PVUnit_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea17.SP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea17_SP_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea17.SP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea17_SP_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea17.PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea17_PV_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea17.PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea17_PV_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea17.TagName";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea17_TagName_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea17.TagName";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea17_TagName_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea16";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea16_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea16.Mode";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea16_Mode_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea16.Mode";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea16_Mode_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea16.Mode";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea16_Mode_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea16.PVUnit";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea16_PVUnit_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea16.SP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea16_SP_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea16.SP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea16_SP_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea16.PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea16_PV_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea16.PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea16_PV_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea16.TagName";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea16_TagName_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea16.TagName";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea16_TagName_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea13";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea13_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea13.Text3";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea13_Text3_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea13.Text3";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea13_Text3_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea13.Text2";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea13_Text2_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea13.Text2";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea13_Text2_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea13.Text1";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea13_Text1_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea12";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea12_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea12.Text3";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea12_Text3_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea12.Text3";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea12_Text3_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea12.Text2";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea12_Text2_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea12.Text2";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea12_Text2_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea12.Text1";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea12_Text1_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea7";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea7_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea7.Text3";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea7_Text3_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea7.Text3";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea7_Text3_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea7.Text2";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea7_Text2_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea7.Text2";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea7_Text2_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea7.Text1";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea7_Text1_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea6";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea6_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea6.Text2";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea6_Text2_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea6.Text2";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea6_Text2_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea5";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea5_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea5.Mode";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea5_Mode_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea5.Mode";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea5_Mode_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea5.Mode";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea5_Mode_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea5.PVUnit";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea5_PVUnit_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea5.SP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea5_SP_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea5.SP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea5_SP_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea5.PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea5_PV_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea5.PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea5_PV_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea5.TagName";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea5_TagName_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea5.TagName";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea5_TagName_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea4";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea4_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea4.Mode";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea4_Mode_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea4.Mode";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea4_Mode_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea4.Mode";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea4_Mode_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea4.PVUnit";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea4_PVUnit_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea4.SP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea4_SP_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea4.SP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea4_SP_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea4.PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea4_PV_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea4.PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea4_PV_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea4.TagName";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea4_TagName_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea4.TagName";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea4_TagName_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);

    return;
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void Rect6_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect3 = (DrawRectangle)dynArgs.sender; 

    /*    int nLeft = 0;
	int nTop = 0;
	string[] strVariable = new string[10];
	strVariable[0] = Area.Variable[0];
        strVariable[1] = Area.Variable[1];
	strVariable[2] = Area.Variable[2];
        strVariable[3] = Area.Variable[3];
        strVariable[4] = Area.Variable[4];


	CommonFunction.OpenPicture("Pks_fp_MOTORHS_checkOK.grf", nTop, nLeft, strVariable);
  */
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void Rect6_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect3 = (DrawRectangle)dynArgs.sender; 

      /*  int nLeft = 0;
	int nTop = 0;
	string[] strVariable = new string[10];
	strVariable[0] = Area.Variable[0];
        strVariable[1] = Area.Variable[1];
	strVariable[2] = Area.Variable[2];
        strVariable[3] = Area.Variable[3];
        strVariable[4] = Area.Variable[4];
	strVariable[5] = Area.Variable[5];
        strVariable[6] = Area.Variable[6];
        strVariable[7] = Area.Variable[7];
  */ 
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void Rect5_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect3 = (DrawRectangle)dynArgs.sender; 

        int nLeft = 0;
	int nTop = 0;
	string[] strVariable = new string[10];
	strVariable[0] = Area.Variable[0];
        strVariable[1] = Area.Variable[1];
	strVariable[2] = Area.Variable[2];
        strVariable[3] = Area.Variable[3];
        //strVariable[4] = Area.Variable[4];
	//strVariable[5] = Area.Variable[5];
        //strVariable[6] = Area.Variable[6];
        //strVariable[7] = Area.Variable[7];

	CommonFunction.OpenPicture("Pks_fp_MOTORSELECT2非标准.grf", nTop, nLeft, strVariable);
 
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void Rect5_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect3 = (DrawRectangle)dynArgs.sender; 

      /*  int nLeft = 0;
	int nTop = 0;
	string[] strVariable = new string[10];
	strVariable[0] = Area.Variable[0];
        strVariable[1] = Area.Variable[1];
	strVariable[2] = Area.Variable[2];
        strVariable[3] = Area.Variable[3];
        strVariable[4] = Area.Variable[4];
	strVariable[5] = Area.Variable[5];
        strVariable[6] = Area.Variable[6];
        strVariable[7] = Area.Variable[7];
  */ 
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void Rect4_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect3 = (DrawRectangle)dynArgs.sender; 

        int nLeft = 0;
	int nTop = 0;
	string[] strVariable = new string[10];
	strVariable[0] = Area.Variable[0];
        strVariable[1] = Area.Variable[1];
	strVariable[2] = Area.Variable[2];
        strVariable[3] = Area.Variable[3];
        //strVariable[4] = Area.Variable[4];
	//strVariable[5] = Area.Variable[5];
        //strVariable[6] = Area.Variable[6];
        //strVariable[7] = Area.Variable[7];

	CommonFunction.OpenPicture("Pks_fp_MOTORSELECT2非标准.grf", nTop, nLeft, strVariable);
 
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void Rect4_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect3 = (DrawRectangle)dynArgs.sender; 

      /*  int nLeft = 0;
	int nTop = 0;
	string[] strVariable = new string[10];
	strVariable[0] = Area.Variable[0];
        strVariable[1] = Area.Variable[1];
	strVariable[2] = Area.Variable[2];
        strVariable[3] = Area.Variable[3];
        strVariable[4] = Area.Variable[4];
	strVariable[5] = Area.Variable[5];
        strVariable[6] = Area.Variable[6];
        strVariable[7] = Area.Variable[7];
  */ 
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void Rect3_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect3 = (DrawRectangle)dynArgs.sender; 

    /*    int nLeft = 0;
	int nTop = 0;
	string[] strVariable = new string[10];
	strVariable[0] = Area.Variable[0];
        strVariable[1] = Area.Variable[1];
	strVariable[2] = Area.Variable[2];
        strVariable[3] = Area.Variable[3];
        strVariable[4] = Area.Variable[4];


	CommonFunction.OpenPicture("Pks_fp_MOTORHS_checkOK.grf", nTop, nLeft, strVariable);
  */
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void Rect3_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect3 = (DrawRectangle)dynArgs.sender; 

      /*  int nLeft = 0;
	int nTop = 0;
	string[] strVariable = new string[10];
	strVariable[0] = Area.Variable[0];
        strVariable[1] = Area.Variable[1];
	strVariable[2] = Area.Variable[2];
        strVariable[3] = Area.Variable[3];
        strVariable[4] = Area.Variable[4];
	strVariable[5] = Area.Variable[5];
        strVariable[6] = Area.Variable[6];
        strVariable[7] = Area.Variable[7];
  */ 
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void Button1_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawButton Button1 = (DrawButton)dynArgs.sender; 
    double dbPV = 1;	
	CommonFunction.DSI_SetValue("PIC32014", "MODE", dbPV);

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void Ellipse1_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawEllipse Ellipse1 = (DrawEllipse)dynArgs.sender;

    //double dbPV = 3;	
    //CommonFunction.DSI_SetValue("PIC32014", "MODE", dbPV);
    //string[] str = new string[]{Area.Variable[0],"",""};
    //CommonFunction.OpenDataEntryInput("PKS_checkOK.grf",Area.Variable[0],str,new Point(300,450));

    return; 
}
//2012.07.25添加显示点图素
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void DrawArea26_OnDynClick(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 
   
   string strTagName = Area.Variable[0];
	CommonFunction.OpenFaceplate(strTagName);
	if(strTagName != "")
	{
		CommonFunction.OpenFaceplate(strTagName);
	}

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void DrawArea26_Text3_OnDynInitialize(Object sender, EventArgs e)	//TagName
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
public void DrawArea26_Text3_OnDynClick(Object sender, EventArgs e)
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
//Event Handler:OnDynInitialize 
public void DrawArea26_Text2_OnDynInitialize(Object sender, EventArgs e)	//SV
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
public void DrawArea26_Text2_OnDynAnimation(Object sender, EventArgs e)	//SV
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
public void DrawArea26_Text1_OnDynInitialize(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawText PVUnit = (DrawText)dynArgs.sender; 
	PVUnit.Caption = CommonFunction.GetPVUnit(Area.Variable[0]);
	return; 
}
//2012.07.25添加显示点图素
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void DrawArea25_OnDynClick(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 
   
   string strTagName = Area.Variable[0];
	CommonFunction.OpenFaceplate(strTagName);
	if(strTagName != "")
	{
		CommonFunction.OpenFaceplate(strTagName);
	}

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void DrawArea25_Text3_OnDynInitialize(Object sender, EventArgs e)	//TagName
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
public void DrawArea25_Text3_OnDynClick(Object sender, EventArgs e)
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
//Event Handler:OnDynInitialize 
public void DrawArea25_Text2_OnDynInitialize(Object sender, EventArgs e)	//SV
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
public void DrawArea25_Text2_OnDynAnimation(Object sender, EventArgs e)	//SV
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
public void DrawArea25_Text1_OnDynInitialize(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawText PVUnit = (DrawText)dynArgs.sender; 
	PVUnit.Caption = CommonFunction.GetPVUnit(Area.Variable[0]);
	return; 
}
//2012.07.25添加显示点图素
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void DrawArea24_OnDynClick(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 
   
   string strTagName = Area.Variable[0];
	CommonFunction.OpenFaceplate(strTagName);
	if(strTagName != "")
	{
		CommonFunction.OpenFaceplate(strTagName);
	}

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void DrawArea24_Text3_OnDynInitialize(Object sender, EventArgs e)	//TagName
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
public void DrawArea24_Text3_OnDynClick(Object sender, EventArgs e)
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
//Event Handler:OnDynInitialize 
public void DrawArea24_Text2_OnDynInitialize(Object sender, EventArgs e)	//SV
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
public void DrawArea24_Text2_OnDynAnimation(Object sender, EventArgs e)	//SV
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
public void DrawArea24_Text1_OnDynInitialize(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawText PVUnit = (DrawText)dynArgs.sender; 
	PVUnit.Caption = CommonFunction.GetPVUnit(Area.Variable[0]);
	return; 
}
//2012.07.25添加显示点图素
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void DrawArea23_OnDynClick(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 
   
   string strTagName = Area.Variable[0];
	CommonFunction.OpenFaceplate(strTagName);
	if(strTagName != "")
	{
		CommonFunction.OpenFaceplate(strTagName);
	}

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void DrawArea23_Text3_OnDynInitialize(Object sender, EventArgs e)	//TagName
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
public void DrawArea23_Text3_OnDynClick(Object sender, EventArgs e)
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
//Event Handler:OnDynInitialize 
public void DrawArea23_Text2_OnDynInitialize(Object sender, EventArgs e)	//SV
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
public void DrawArea23_Text2_OnDynAnimation(Object sender, EventArgs e)	//SV
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
public void DrawArea23_Text1_OnDynInitialize(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawText PVUnit = (DrawText)dynArgs.sender; 
	PVUnit.Caption = CommonFunction.GetPVUnit(Area.Variable[0]);
	return; 
}
//2012.07.25添加显示点图素
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void DrawArea22_OnDynClick(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 
   
   string strTagName = Area.Variable[0];
	CommonFunction.OpenFaceplate(strTagName);
	if(strTagName != "")
	{
		CommonFunction.OpenFaceplate(strTagName);
	}

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void DrawArea22_Text3_OnDynInitialize(Object sender, EventArgs e)	//TagName
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
public void DrawArea22_Text3_OnDynClick(Object sender, EventArgs e)
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
//Event Handler:OnDynInitialize 
public void DrawArea22_Text2_OnDynInitialize(Object sender, EventArgs e)	//SV
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
public void DrawArea22_Text2_OnDynAnimation(Object sender, EventArgs e)	//SV
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
public void DrawArea22_Text1_OnDynInitialize(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawText PVUnit = (DrawText)dynArgs.sender; 
	PVUnit.Caption = CommonFunction.GetPVUnit(Area.Variable[0]);
	return; 
}
/*
【功能】
开关变色
开--绿色；
关--红色；（<2红色，>=2绿色）
点击弹出面板

【输入参数】
*Var[1]模块名（Valve）
Var[2]参数名，默认CTRL_V_OP
Var[3]模块名（弹出面板）

【更新时间】 
110613, Lyy, 扬子-芳烃
*/

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void DrawArea21_OnDynInitialize(Object sender, EventArgs e)	//drawArea
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawArea drawArea = (DrawArea)dynArgs.sender; 
   
	DrawRectangle Rect1 = (DrawRectangle)Area.GetDrawObj("Rect1");
	DrawRectangle Rect2 = (DrawRectangle)Area.GetDrawObj("Rect2");
	DrawPolygon Polygon1 = (DrawPolygon)Area.GetDrawObj("Polygon1"); 
	DrawPolygon Polygon2 = (DrawPolygon)Area.GetDrawObj("Polygon2"); 
	DrawPolygon Polygon3 = (DrawPolygon)Area.GetDrawObj("Polygon3"); 
	
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	string tagName = Area.Variable[0] + "/CTRL_V_OP";
	if(Area.Variable[1] != "")
		tagName = Area.Variable[0] + "/" + Area.Variable[1];
	
	if(CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType))
	{
		switch(nDataType)
		{
			case 1:
				if(dbValue < 2)
				{
					Rect1.ForegroundColor = Color.Red;
					Rect2.ForegroundColor = Color.Red;
					Polygon1.ForegroundColor = Color.Red;
					Polygon2.ForegroundColor = Color.Red;
					Polygon3.ForegroundColor = Color.Red;
				}
				else
				{
					Rect1.ForegroundColor = Color.Lime;
					Rect2.ForegroundColor = Color.Lime;
					Polygon1.ForegroundColor = Color.Lime;
					Polygon2.ForegroundColor = Color.Lime;
					Polygon3.ForegroundColor = Color.Lime;
				}
				break;
		}
	}
	else
	{
		Rect1.ForegroundColor = Color.Gray;
		Rect2.ForegroundColor = Color.Gray;
		Polygon1.ForegroundColor = Color.Gray;
		Polygon2.ForegroundColor = Color.Gray;
		Polygon3.ForegroundColor = Color.Gray;
	}

/*
	//=======================================================
	tagName = Area.Variable[0] + "/AIR_FAIL";
	if(CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType))
	{
		if(nDataType == 1)
		{
			if(dbValue == -1)
			{
				Polygon2.Visible = true;
				Polygon3.Visible = false;
				Rect2.VerticalPosition = 42;
				Rect2.Height = 20;
				return;
			}
			else if(dbValue == 1)
			{
				Polygon2.Visible = false;
				Polygon3.Visible = true;
				Rect2.VerticalPosition = 26;
				Rect2.Height = 20;
				return;
			}
		}
	}
	Polygon2.Visible = false;
	Polygon3.Visible = false;
	Rect2.Height = 35;
	Rect2.VerticalPosition = 26;
*/
	return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void DrawArea21_OnDynAnimation(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawArea drawArea = (DrawArea)dynArgs.sender; 
   
	DrawRectangle Rect1 = (DrawRectangle)Area.GetDrawObj("Rect1");
	DrawRectangle Rect2 = (DrawRectangle)Area.GetDrawObj("Rect2");
	DrawPolygon Polygon1 = (DrawPolygon)Area.GetDrawObj("Polygon1"); 
	DrawPolygon Polygon2 = (DrawPolygon)Area.GetDrawObj("Polygon2"); 
	DrawPolygon Polygon3 = (DrawPolygon)Area.GetDrawObj("Polygon3"); 
	
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	string tagName = Area.Variable[0] + "/CTRL_V_OP";
	if(Area.Variable[1] != "")
		tagName = Area.Variable[0] + "/" + Area.Variable[1];
	
	if(CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType))
	{
		switch(nDataType)
		{
			case 1:
				if(dbValue < 2)
				{
					Rect1.ForegroundColor = Color.Red;
					Rect2.ForegroundColor = Color.Red;
					Polygon1.ForegroundColor = Color.Red;
					Polygon2.ForegroundColor = Color.Red;
					Polygon3.ForegroundColor = Color.Red;
				}
				else
				{
					Rect1.ForegroundColor = Color.Lime;
					Rect2.ForegroundColor = Color.Lime;
					Polygon1.ForegroundColor = Color.Lime;
					Polygon2.ForegroundColor = Color.Lime;
					Polygon3.ForegroundColor = Color.Lime;
				}
				break;
		}
	}
	else
	{
		Rect1.ForegroundColor = Color.Gray;
		Rect2.ForegroundColor = Color.Gray;
		Polygon1.ForegroundColor = Color.Gray;
		Polygon2.ForegroundColor = Color.Gray;
		Polygon3.ForegroundColor = Color.Gray;
	}

/*
	//=======================================================
	tagName = Area.Variable[0] + "/AIR_FAIL";
	if(CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType))
	{
		if(nDataType == 1)
		{
			if(dbValue == -1)
			{
				Polygon2.Visible = true;
				Polygon3.Visible = false;
				Rect2.VerticalPosition = 42;
				Rect2.Height = 20;
				return;
			}
			else if(dbValue == 1)
			{
				Polygon2.Visible = false;
				Polygon3.Visible = true;
				Rect2.VerticalPosition = 26;
				Rect2.Height = 20;
				return;
			}
		}
	}
	Polygon2.Visible = false;
	Polygon3.Visible = false;
	Rect2.Height = 35;
	Rect2.VerticalPosition = 26;
*/
	return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void DrawArea21_rectClick_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle rectClick = (DrawRectangle)dynArgs.sender; 
   
	string tagName = Area.Variable[2];
	if( tagName.Trim() != "")
		CommonFunction.OpenFaceplate( tagName.ToUpper() );
    return; 
}
//2012.07.25添加PKS_PID
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void DrawArea18_OnDynClick(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 
   
   string strTagName = Area.Variable[0];
	CommonFunction.OpenFaceplate(strTagName);
	if(strTagName != "")
	{
		CommonFunction.OpenFaceplate(strTagName);
	}
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void DrawArea18_Mode_OnDynInitialize(Object sender, EventArgs e)
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
			Mode.Caption = "M";
		else if(dbValue==2)
			Mode.Caption = "A";
		else if(dbValue==3)
			Mode.Caption = "C";
	}
	else
			Mode.Caption = "#";
	return; 
}


//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void DrawArea18_Mode_OnDynAnimation(Object sender, EventArgs e)
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
			Mode.Caption = "M";
		else if(dbValue==2)
			Mode.Caption = "A";
		else if(dbValue==3)
			Mode.Caption = "C";
	}
	else
			Mode.Caption = "#";
	return; 
}


//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void DrawArea18_Mode_OnDynClick(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawText Mode = (DrawText)dynArgs.sender; 
	
	return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void DrawArea18_PVUnit_OnDynInitialize(Object sender, EventArgs e)
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
public void DrawArea18_SP_OnDynInitialize(Object sender, EventArgs e)	//SV
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
	return; 
}


//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void DrawArea18_SP_OnDynAnimation(Object sender, EventArgs e)	//SV
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
	return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void DrawArea18_PV_OnDynInitialize(Object sender, EventArgs e)	//SV
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
public void DrawArea18_PV_OnDynAnimation(Object sender, EventArgs e)	//SV
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
public void DrawArea18_TagName_OnDynInitialize(Object sender, EventArgs e)	//TagName
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
public void DrawArea18_TagName_OnDynClick(Object sender, EventArgs e)
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
//2012.07.25添加PKS_PID
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void DrawArea17_OnDynClick(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 
   
   string strTagName = Area.Variable[0];
	CommonFunction.OpenFaceplate(strTagName);
	if(strTagName != "")
	{
		CommonFunction.OpenFaceplate(strTagName);
	}
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void DrawArea17_Mode_OnDynInitialize(Object sender, EventArgs e)
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
			Mode.Caption = "M";
		else if(dbValue==2)
			Mode.Caption = "A";
		else if(dbValue==3)
			Mode.Caption = "C";
	}
	else
			Mode.Caption = "#";
	return; 
}


//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void DrawArea17_Mode_OnDynAnimation(Object sender, EventArgs e)
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
			Mode.Caption = "M";
		else if(dbValue==2)
			Mode.Caption = "A";
		else if(dbValue==3)
			Mode.Caption = "C";
	}
	else
			Mode.Caption = "#";
	return; 
}


//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void DrawArea17_Mode_OnDynClick(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawText Mode = (DrawText)dynArgs.sender; 
	
	return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void DrawArea17_PVUnit_OnDynInitialize(Object sender, EventArgs e)
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
public void DrawArea17_SP_OnDynInitialize(Object sender, EventArgs e)	//SV
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
	return; 
}


//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void DrawArea17_SP_OnDynAnimation(Object sender, EventArgs e)	//SV
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
	return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void DrawArea17_PV_OnDynInitialize(Object sender, EventArgs e)	//SV
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
public void DrawArea17_PV_OnDynAnimation(Object sender, EventArgs e)	//SV
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
public void DrawArea17_TagName_OnDynInitialize(Object sender, EventArgs e)	//TagName
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
public void DrawArea17_TagName_OnDynClick(Object sender, EventArgs e)
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
//2012.07.25添加PKS_PID
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void DrawArea16_OnDynClick(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 
   
   string strTagName = Area.Variable[0];
	CommonFunction.OpenFaceplate(strTagName);
	if(strTagName != "")
	{
		CommonFunction.OpenFaceplate(strTagName);
	}
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void DrawArea16_Mode_OnDynInitialize(Object sender, EventArgs e)
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
			Mode.Caption = "M";
		else if(dbValue==2)
			Mode.Caption = "A";
		else if(dbValue==3)
			Mode.Caption = "C";
	}
	else
			Mode.Caption = "#";
	return; 
}


//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void DrawArea16_Mode_OnDynAnimation(Object sender, EventArgs e)
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
			Mode.Caption = "M";
		else if(dbValue==2)
			Mode.Caption = "A";
		else if(dbValue==3)
			Mode.Caption = "C";
	}
	else
			Mode.Caption = "#";
	return; 
}


//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void DrawArea16_Mode_OnDynClick(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawText Mode = (DrawText)dynArgs.sender; 
	
	return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void DrawArea16_PVUnit_OnDynInitialize(Object sender, EventArgs e)
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
public void DrawArea16_SP_OnDynInitialize(Object sender, EventArgs e)	//SV
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
	return; 
}


//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void DrawArea16_SP_OnDynAnimation(Object sender, EventArgs e)	//SV
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
	return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void DrawArea16_PV_OnDynInitialize(Object sender, EventArgs e)	//SV
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
public void DrawArea16_PV_OnDynAnimation(Object sender, EventArgs e)	//SV
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
public void DrawArea16_TagName_OnDynInitialize(Object sender, EventArgs e)	//TagName
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
public void DrawArea16_TagName_OnDynClick(Object sender, EventArgs e)
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
//2012.07.25添加显示点图素
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void DrawArea13_OnDynClick(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 
   
   string strTagName = Area.Variable[0];
	CommonFunction.OpenFaceplate(strTagName);
	if(strTagName != "")
	{
		CommonFunction.OpenFaceplate(strTagName);
	}

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void DrawArea13_Text3_OnDynInitialize(Object sender, EventArgs e)	//TagName
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
public void DrawArea13_Text3_OnDynClick(Object sender, EventArgs e)
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
//Event Handler:OnDynInitialize 
public void DrawArea13_Text2_OnDynInitialize(Object sender, EventArgs e)	//SV
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
public void DrawArea13_Text2_OnDynAnimation(Object sender, EventArgs e)	//SV
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
public void DrawArea13_Text1_OnDynInitialize(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawText PVUnit = (DrawText)dynArgs.sender; 
	PVUnit.Caption = CommonFunction.GetPVUnit(Area.Variable[0]);
	return; 
}
//2012.07.25添加显示点图素
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void DrawArea12_OnDynClick(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 
   
   string strTagName = Area.Variable[0];
	CommonFunction.OpenFaceplate(strTagName);
	if(strTagName != "")
	{
		CommonFunction.OpenFaceplate(strTagName);
	}

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void DrawArea12_Text3_OnDynInitialize(Object sender, EventArgs e)	//TagName
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
public void DrawArea12_Text3_OnDynClick(Object sender, EventArgs e)
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
//Event Handler:OnDynInitialize 
public void DrawArea12_Text2_OnDynInitialize(Object sender, EventArgs e)	//SV
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
public void DrawArea12_Text2_OnDynAnimation(Object sender, EventArgs e)	//SV
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
public void DrawArea12_Text1_OnDynInitialize(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawText PVUnit = (DrawText)dynArgs.sender; 
	PVUnit.Caption = CommonFunction.GetPVUnit(Area.Variable[0]);
	return; 
}
//2012.07.25添加显示点图素
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void DrawArea7_OnDynClick(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 
   
   string strTagName = Area.Variable[0];
	CommonFunction.OpenFaceplate(strTagName);
	if(strTagName != "")
	{
		CommonFunction.OpenFaceplate(strTagName);
	}

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void DrawArea7_Text3_OnDynInitialize(Object sender, EventArgs e)	//TagName
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
public void DrawArea7_Text3_OnDynClick(Object sender, EventArgs e)
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
//Event Handler:OnDynInitialize 
public void DrawArea7_Text2_OnDynInitialize(Object sender, EventArgs e)	//SV
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
public void DrawArea7_Text2_OnDynAnimation(Object sender, EventArgs e)	//SV
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
public void DrawArea7_Text1_OnDynInitialize(Object sender, EventArgs e)
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
public void DrawArea6_OnDynClick(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 
   
string strTagName = Area.Variable[0];
	CommonFunction.OpenFaceplate(strTagName);
	if(strTagName != "")
	{
		CommonFunction.OpenFaceplate(strTagName);
	}
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void DrawArea6_Text2_OnDynInitialize(Object sender, EventArgs e)	//SV
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
public void DrawArea6_Text2_OnDynAnimation(Object sender, EventArgs e)	//SV
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
//2012.07.25添加PKS_PID
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void DrawArea5_OnDynClick(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 
   
   string strTagName = Area.Variable[0];
	CommonFunction.OpenFaceplate(strTagName);
	if(strTagName != "")
	{
		CommonFunction.OpenFaceplate(strTagName);
	}
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void DrawArea5_Mode_OnDynInitialize(Object sender, EventArgs e)
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
			Mode.Caption = "M";
		else if(dbValue==2)
			Mode.Caption = "A";
		else if(dbValue==3)
			Mode.Caption = "C";
	}
	else
			Mode.Caption = "#";
	return; 
}


//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void DrawArea5_Mode_OnDynAnimation(Object sender, EventArgs e)
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
			Mode.Caption = "M";
		else if(dbValue==2)
			Mode.Caption = "A";
		else if(dbValue==3)
			Mode.Caption = "C";
	}
	else
			Mode.Caption = "#";
	return; 
}


//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void DrawArea5_Mode_OnDynClick(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawText Mode = (DrawText)dynArgs.sender; 
	
	return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void DrawArea5_PVUnit_OnDynInitialize(Object sender, EventArgs e)
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
public void DrawArea5_SP_OnDynInitialize(Object sender, EventArgs e)	//SV
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
	return; 
}


//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void DrawArea5_SP_OnDynAnimation(Object sender, EventArgs e)	//SV
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
	return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void DrawArea5_PV_OnDynInitialize(Object sender, EventArgs e)	//SV
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
public void DrawArea5_PV_OnDynAnimation(Object sender, EventArgs e)	//SV
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
public void DrawArea5_TagName_OnDynInitialize(Object sender, EventArgs e)	//TagName
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
public void DrawArea5_TagName_OnDynClick(Object sender, EventArgs e)
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
//2012.07.25添加PKS_PID
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void DrawArea4_OnDynClick(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 
   
   string strTagName = Area.Variable[0];
	CommonFunction.OpenFaceplate(strTagName);
	if(strTagName != "")
	{
		CommonFunction.OpenFaceplate(strTagName);
	}
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void DrawArea4_Mode_OnDynInitialize(Object sender, EventArgs e)
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
			Mode.Caption = "M";
		else if(dbValue==2)
			Mode.Caption = "A";
		else if(dbValue==3)
			Mode.Caption = "C";
	}
	else
			Mode.Caption = "#";
	return; 
}


//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void DrawArea4_Mode_OnDynAnimation(Object sender, EventArgs e)
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
			Mode.Caption = "M";
		else if(dbValue==2)
			Mode.Caption = "A";
		else if(dbValue==3)
			Mode.Caption = "C";
	}
	else
			Mode.Caption = "#";
	return; 
}


//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void DrawArea4_Mode_OnDynClick(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawText Mode = (DrawText)dynArgs.sender; 
	
	return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void DrawArea4_PVUnit_OnDynInitialize(Object sender, EventArgs e)
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
public void DrawArea4_SP_OnDynInitialize(Object sender, EventArgs e)	//SV
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
	return; 
}


//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void DrawArea4_SP_OnDynAnimation(Object sender, EventArgs e)	//SV
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
	return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void DrawArea4_PV_OnDynInitialize(Object sender, EventArgs e)	//SV
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
public void DrawArea4_PV_OnDynAnimation(Object sender, EventArgs e)	//SV
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
public void DrawArea4_TagName_OnDynInitialize(Object sender, EventArgs e)	//TagName
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
public void DrawArea4_TagName_OnDynClick(Object sender, EventArgs e)
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

}
