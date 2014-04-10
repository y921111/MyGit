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
public class PIC_TrendGroup:IDynCodeAttachDetach
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
_EventHandler= (EventHandler)PIC_TrendGroup_OnDynInitialize;
CodeDomCommon.AttachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PIC_TrendGroup_OnDynAnimation;
CodeDomCommon.AttachAreaEventHandler(area,strEventName,_EventHandler);
strObjectName = "PenAssignment";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PenAssignment_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Button3";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Button3_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Button3";
strEventName = "OnDynMouseIn";
_EventHandler= (EventHandler)Button3_OnDynMouseIn;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "setDefault";
strEventName = "OnDynMouseIn";
_EventHandler= (EventHandler)setDefault_OnDynMouseIn;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "setDefault";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)setDefault_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "ZoomB";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)ZoomB_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "ZoomB";
strEventName = "OnDynMouseIn";
_EventHandler= (EventHandler)ZoomB_OnDynMouseIn;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Bitmap1";
strEventName = "OnDynMouseIn";
_EventHandler= (EventHandler)Bitmap1_OnDynMouseIn;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "ZoomS";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)ZoomS_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "ZoomS";
strEventName = "OnDynMouseIn";
_EventHandler= (EventHandler)ZoomS_OnDynMouseIn;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Bitmap2";
strEventName = "OnDynMouseIn";
_EventHandler= (EventHandler)Bitmap2_OnDynMouseIn;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "linesNo";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)linesNo_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "linesNo";
strEventName = "OnDynMouseIn";
_EventHandler= (EventHandler)linesNo_OnDynMouseIn;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "ZoomDateB";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)ZoomDateB_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "ZoomDateB";
strEventName = "OnDynMouseIn";
_EventHandler= (EventHandler)ZoomDateB_OnDynMouseIn;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "ZoomDateS";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)ZoomDateS_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "ZoomDateS";
strEventName = "OnDynMouseIn";
_EventHandler= (EventHandler)ZoomDateS_OnDynMouseIn;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Bitmap3";
strEventName = "OnDynMouseIn";
_EventHandler= (EventHandler)Bitmap3_OnDynMouseIn;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Bitmap4";
strEventName = "OnDynMouseIn";
_EventHandler= (EventHandler)Bitmap4_OnDynMouseIn;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "leftArrow";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)leftArrow_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "rightArrow";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)rightArrow_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "moveArrowBackGround";
strEventName = "OnDynMouseUp";
_EventHandler= (EventHandler)moveArrowBackGround_OnDynMouseUp;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "line1GroupClickLeft";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)line1GroupClickLeft_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "line1GroupClickLeft";
strEventName = "OnDynDblClick";
_EventHandler= (EventHandler)line1GroupClickLeft_OnDynDblClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "line2GroupClickLeft";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)line2GroupClickLeft_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "line2GroupClickLeft";
strEventName = "OnDynDblClick";
_EventHandler= (EventHandler)line2GroupClickLeft_OnDynDblClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "line3GroupClickLeft";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)line3GroupClickLeft_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "line3GroupClickLeft";
strEventName = "OnDynDblClick";
_EventHandler= (EventHandler)line3GroupClickLeft_OnDynDblClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "line4GroupClickLeft";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)line4GroupClickLeft_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "line4GroupClickLeft";
strEventName = "OnDynDblClick";
_EventHandler= (EventHandler)line4GroupClickLeft_OnDynDblClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "line5GroupClickLeft";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)line5GroupClickLeft_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "line5GroupClickLeft";
strEventName = "OnDynDblClick";
_EventHandler= (EventHandler)line5GroupClickLeft_OnDynDblClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "line6GroupClickLeft";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)line6GroupClickLeft_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "line6GroupClickLeft";
strEventName = "OnDynDblClick";
_EventHandler= (EventHandler)line6GroupClickLeft_OnDynDblClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "line1GroupClickRight";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)line1GroupClickRight_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "line1GroupClickRight";
strEventName = "OnDynDblClick";
_EventHandler= (EventHandler)line1GroupClickRight_OnDynDblClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "line2GroupClickRight";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)line2GroupClickRight_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "line2GroupClickRight";
strEventName = "OnDynDblClick";
_EventHandler= (EventHandler)line2GroupClickRight_OnDynDblClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "line3GroupClickRight";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)line3GroupClickRight_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "line3GroupClickRight";
strEventName = "OnDynDblClick";
_EventHandler= (EventHandler)line3GroupClickRight_OnDynDblClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "line4GroupClickRight";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)line4GroupClickRight_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "line4GroupClickRight";
strEventName = "OnDynDblClick";
_EventHandler= (EventHandler)line4GroupClickRight_OnDynDblClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "line5GroupClickRight";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)line5GroupClickRight_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "line5GroupClickRight";
strEventName = "OnDynDblClick";
_EventHandler= (EventHandler)line5GroupClickRight_OnDynDblClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "line6GroupClickRight";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)line6GroupClickRight_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "line6GroupClickRight";
strEventName = "OnDynDblClick";
_EventHandler= (EventHandler)line6GroupClickRight_OnDynDblClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "line7GroupClickLeft";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)line7GroupClickLeft_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "line7GroupClickLeft";
strEventName = "OnDynDblClick";
_EventHandler= (EventHandler)line7GroupClickLeft_OnDynDblClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "line7GroupClickRight";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)line7GroupClickRight_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "line7GroupClickRight";
strEventName = "OnDynDblClick";
_EventHandler= (EventHandler)line7GroupClickRight_OnDynDblClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "line8GroupClickLeft";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)line8GroupClickLeft_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "line8GroupClickLeft";
strEventName = "OnDynDblClick";
_EventHandler= (EventHandler)line8GroupClickLeft_OnDynDblClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "line8GroupClickRight";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)line8GroupClickRight_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "line8GroupClickRight";
strEventName = "OnDynDblClick";
_EventHandler= (EventHandler)line8GroupClickRight_OnDynDblClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "HScrollBar1";
strEventName = "Scroll";
_ScrollEventHandler= (ScrollEventHandler)HScrollBar1_Scroll;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_ScrollEventHandler);
strObjectName = "VScrollBar1";
strEventName = "Scroll";
_ScrollEventHandler= (ScrollEventHandler)VScrollBar1_Scroll;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_ScrollEventHandler);

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
_EventHandler= (EventHandler)PIC_TrendGroup_OnDynInitialize;
CodeDomCommon.DetachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PIC_TrendGroup_OnDynAnimation;
CodeDomCommon.DetachAreaEventHandler(area,strEventName,_EventHandler);
strObjectName = "PenAssignment";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PenAssignment_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Button3";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Button3_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Button3";
strEventName = "OnDynMouseIn";
_EventHandler= (EventHandler)Button3_OnDynMouseIn;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "setDefault";
strEventName = "OnDynMouseIn";
_EventHandler= (EventHandler)setDefault_OnDynMouseIn;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "setDefault";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)setDefault_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "ZoomB";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)ZoomB_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "ZoomB";
strEventName = "OnDynMouseIn";
_EventHandler= (EventHandler)ZoomB_OnDynMouseIn;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Bitmap1";
strEventName = "OnDynMouseIn";
_EventHandler= (EventHandler)Bitmap1_OnDynMouseIn;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "ZoomS";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)ZoomS_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "ZoomS";
strEventName = "OnDynMouseIn";
_EventHandler= (EventHandler)ZoomS_OnDynMouseIn;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Bitmap2";
strEventName = "OnDynMouseIn";
_EventHandler= (EventHandler)Bitmap2_OnDynMouseIn;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "linesNo";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)linesNo_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "linesNo";
strEventName = "OnDynMouseIn";
_EventHandler= (EventHandler)linesNo_OnDynMouseIn;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "ZoomDateB";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)ZoomDateB_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "ZoomDateB";
strEventName = "OnDynMouseIn";
_EventHandler= (EventHandler)ZoomDateB_OnDynMouseIn;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "ZoomDateS";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)ZoomDateS_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "ZoomDateS";
strEventName = "OnDynMouseIn";
_EventHandler= (EventHandler)ZoomDateS_OnDynMouseIn;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Bitmap3";
strEventName = "OnDynMouseIn";
_EventHandler= (EventHandler)Bitmap3_OnDynMouseIn;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Bitmap4";
strEventName = "OnDynMouseIn";
_EventHandler= (EventHandler)Bitmap4_OnDynMouseIn;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "leftArrow";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)leftArrow_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "rightArrow";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)rightArrow_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "moveArrowBackGround";
strEventName = "OnDynMouseUp";
_EventHandler= (EventHandler)moveArrowBackGround_OnDynMouseUp;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "line1GroupClickLeft";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)line1GroupClickLeft_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "line1GroupClickLeft";
strEventName = "OnDynDblClick";
_EventHandler= (EventHandler)line1GroupClickLeft_OnDynDblClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "line2GroupClickLeft";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)line2GroupClickLeft_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "line2GroupClickLeft";
strEventName = "OnDynDblClick";
_EventHandler= (EventHandler)line2GroupClickLeft_OnDynDblClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "line3GroupClickLeft";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)line3GroupClickLeft_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "line3GroupClickLeft";
strEventName = "OnDynDblClick";
_EventHandler= (EventHandler)line3GroupClickLeft_OnDynDblClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "line4GroupClickLeft";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)line4GroupClickLeft_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "line4GroupClickLeft";
strEventName = "OnDynDblClick";
_EventHandler= (EventHandler)line4GroupClickLeft_OnDynDblClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "line5GroupClickLeft";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)line5GroupClickLeft_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "line5GroupClickLeft";
strEventName = "OnDynDblClick";
_EventHandler= (EventHandler)line5GroupClickLeft_OnDynDblClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "line6GroupClickLeft";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)line6GroupClickLeft_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "line6GroupClickLeft";
strEventName = "OnDynDblClick";
_EventHandler= (EventHandler)line6GroupClickLeft_OnDynDblClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "line1GroupClickRight";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)line1GroupClickRight_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "line1GroupClickRight";
strEventName = "OnDynDblClick";
_EventHandler= (EventHandler)line1GroupClickRight_OnDynDblClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "line2GroupClickRight";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)line2GroupClickRight_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "line2GroupClickRight";
strEventName = "OnDynDblClick";
_EventHandler= (EventHandler)line2GroupClickRight_OnDynDblClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "line3GroupClickRight";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)line3GroupClickRight_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "line3GroupClickRight";
strEventName = "OnDynDblClick";
_EventHandler= (EventHandler)line3GroupClickRight_OnDynDblClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "line4GroupClickRight";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)line4GroupClickRight_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "line4GroupClickRight";
strEventName = "OnDynDblClick";
_EventHandler= (EventHandler)line4GroupClickRight_OnDynDblClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "line5GroupClickRight";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)line5GroupClickRight_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "line5GroupClickRight";
strEventName = "OnDynDblClick";
_EventHandler= (EventHandler)line5GroupClickRight_OnDynDblClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "line6GroupClickRight";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)line6GroupClickRight_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "line6GroupClickRight";
strEventName = "OnDynDblClick";
_EventHandler= (EventHandler)line6GroupClickRight_OnDynDblClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "line7GroupClickLeft";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)line7GroupClickLeft_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "line7GroupClickLeft";
strEventName = "OnDynDblClick";
_EventHandler= (EventHandler)line7GroupClickLeft_OnDynDblClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "line7GroupClickRight";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)line7GroupClickRight_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "line7GroupClickRight";
strEventName = "OnDynDblClick";
_EventHandler= (EventHandler)line7GroupClickRight_OnDynDblClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "line8GroupClickLeft";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)line8GroupClickLeft_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "line8GroupClickLeft";
strEventName = "OnDynDblClick";
_EventHandler= (EventHandler)line8GroupClickLeft_OnDynDblClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "line8GroupClickRight";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)line8GroupClickRight_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "line8GroupClickRight";
strEventName = "OnDynDblClick";
_EventHandler= (EventHandler)line8GroupClickRight_OnDynDblClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "HScrollBar1";
strEventName = "Scroll";
_ScrollEventHandler= (ScrollEventHandler)HScrollBar1_Scroll;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_ScrollEventHandler);
strObjectName = "VScrollBar1";
strEventName = "Scroll";
_ScrollEventHandler= (ScrollEventHandler)VScrollBar1_Scroll;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_ScrollEventHandler);

    return;
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void PIC_TrendGroup_OnDynInitialize(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 

	//MessageBox.Show(""+CommonFunction.GetTagComment("TICA21624"));

	this.InitializeCustom(Area);
	this.SetLimitAverageGroup(Area);
	this.SetLinesLimitsGroup(Area);
	this.SetPercent(Area);
	this.SetPointTimeString(Area);
	this.SetLinesInfoGroup(Area);
	this.SetStatusParamGroup(Area);
	this.dArea = Area;

	

    return; 
}


public string[,] LinesInfo;
public string[] LimitAverage;
public string[] Percent;
public string getPointTimeString;
public string[,] LinesLimit;
public string[] StatusParamValue;
public string[] LinesUnit;
public int SelectNo = 1;
public DrawArea dArea;

private void InitializeCustom(DrawArea Area)
{
	this.SetLinsGroupClick(Area,Color.Transparent,Color.Transparent,111,65);
	//this.SetLinsGroupClick(Area,Color.Pink,Color.Blue,111,65);





/********************************************************************************/
	
	//Set Paramaters Name
	DvChart dv = (DvChart)Area.GetControlObj("TrendControl");
	int arraySize = 8;

	dv._LinesTagNameAndParamName = new string[arraySize];
	for( int i=0;i<arraySize;i++ )
	dv._LinesTagNameAndParamName[i] = Area.Variable[i];


	//Set Limits Array
	if( LinesLimit == null || LinesLimit.Length<8 )
	LinesLimit = new string[8,2];
	dv.GetDateLimits(dv._LinesTagNameAndParamName);
	for( int i=0;i<arraySize;i++ )
	{
		LinesLimit[i,0] = dv.DataLimits[i,0].ToString();
		LinesLimit[i,1] = dv.DataLimits[i,1].ToString();
	}

	//Set LinesInfo Array
	if( LinesInfo == null || LinesInfo.Length<8 )
	LinesInfo = new string[8,3];
	dv.GetLinesInfo(dv._LinesTagNameAndParamName);
	for( int i=0;i<arraySize;i++ )
	{
	  LinesInfo[i,0] = dv.linesInfo[i,0];
	  string[] tStr = (Area.Variable[i]).Split('/');
	  LinesInfo[i,1] = CommonFunction.GetTagComment(tStr[0]);
	  LinesInfo[i,2] = dv.linesInfo[i,2];
	}
	//Set LinesUnit
	LinesUnit = new string[8];
	for(int i=0;i<8;i++)
	{
	   string[] tStr = (Area.Variable[i]).Split('/');
	   LinesUnit[i] = CommonFunction.GetPVUnit(tStr[0]);
	}

	//set LimitAverage
	double uLimit = 100;
	double lLimit = 0;

	for(int i=0;i<arraySize;i++)
	  if( dv.DataLimits[i,0] != 0 ){
	    uLimit = dv.DataLimits[i,0];
	    lLimit = dv.DataLimits[i,1];
	    break;
	  }

	double jz = (uLimit-lLimit)/5;
	LimitAverage = new string[6]{uLimit.ToString("0.00"),(jz*4).ToString("0.00"),(jz*3).ToString("0.00"),(jz*2).ToString("0.00"),jz.ToString("0.00"),lLimit.ToString("0.00"),};


	
	Percent = new string[2]{"100","0"};

	getPointTimeString = dv.GetCurrentModelDateTime(dv.GetCurrentModelTime()).ToString();
	
	StatusParamValue = new string[4]{"Ready","Gathering",dv.GetCurrentModelDateTime(dv.GetCurrentModelTime()).ToString(),"100%"};

/*************************************************************************************/












/********************************







	LimitAverage = new string[6]{"100.00","80.00","60.00","40.00","20.00","0.00"};
	LinesLimit = new string[,]{
			{"100","0"},
			{"200","100"},
			{"200","100"},
			{"200","100"},
			{"200","100"},
			{"200","100"},
			{"200","100"},
			{"200","100"}		
		};

*********************************/
	
	//==============================================
//Init MoveArrow Position
	DrawBitmap moveArrow = (DrawBitmap) Area.GetDrawObj("moveArrow");
	DrawButton rightArrow = (DrawButton) Area.GetDrawObj("rightArrow");
	moveArrow.VerticalPosition = rightArrow.VerticalPosition;
	moveArrow.HorizontalPosition = rightArrow.HorizontalPosition-(moveArrow.Width/2)-3;
	dv.MoveHLine((int)(moveArrow.HorizontalPosition-moveArrow.Width/2-4));

	//VScrollBar
	SetVScrollBar(1,Area);
	//HScrollBar
	//HScrollBar1[HScrollBar]
	HScrollBar hscroll = (HScrollBar)Area.GetControlObj("HScrollBar1");
	dv.GetGpresTotalTime(Fresh_Interval);
	hscroll.Maximum = dv.HTotalCount;
        hscroll.Minimum = 0;
        hscroll.SmallChange = dv.HSmallChange;
        hscroll.LargeChange = dv.HLargeChange;
        hscroll.Value = hscroll.Maximum;
/*
this.HTotalCount = (int)dModelTime;
this.HSmallChange = 15;
this.HLargeChange
*/
	



	//DateS and DateB Zoom Init
	DrawButton zoomDateS = (DrawButton)Area.GetDrawObj("ZoomDateS");
	DrawButton zoomDateB = (DrawButton)Area.GetDrawObj("ZoomDateB");
	if( zoomDateS.VerticalPosition > 0 )
		zoomDateS.Move(0,-100);	
	if( zoomDateB.VerticalPosition < 0 )
		zoomDateB.Move(0,(float)System.Math.Abs(zoomDateB.VerticalPosition)+5);
	DrawButton zoomS = (DrawButton)Area.GetDrawObj("ZoomS");
	DrawButton zoomB = (DrawButton)Area.GetDrawObj("ZoomB");
	if( zoomS.VerticalPosition < 0 )
		zoomS.Move(0,(float)System.Math.Abs(zoomS.VerticalPosition)+5);	
	if( zoomB.VerticalPosition > 0 )
		zoomB.Move(0,-100);

	//Init The First Select
	this.InitFirstSelect(Area);

}

private void SetStatusParamGroup(DrawArea Area)
{
	//statusGroup
	//trendStatus Gathering timeZoomStatus dateZoomStatus
	DrawText trendStatusText = (DrawText)Area.GetDrawObj("statusGroup.trendStatus");
	DrawText GatheringText = (DrawText)Area.GetDrawObj("statusGroup.Gathering");
	DrawText timeZoomStatusText = (DrawText)Area.GetDrawObj("statusGroup.timeZoomStatus");
	DrawText dateZoomStatusText = (DrawText)Area.GetDrawObj("statusGroup.dateZoomStatus");


	if( "" == StatusParamValue[0] || null == StatusParamValue[0] )
		trendStatusText.Caption = "";
	else
		trendStatusText.Caption =  StatusParamValue[0];
		
	if( "" == StatusParamValue[1] || null == StatusParamValue[1] )
		GatheringText.Caption = "";
	else
		GatheringText.Caption =  StatusParamValue[1];
		
	if( "" == StatusParamValue[2] || null == StatusParamValue[2] )
		timeZoomStatusText.Caption = "";
	else
		timeZoomStatusText.Caption =  StatusParamValue[2];	

	if( "" == StatusParamValue[3] || null == StatusParamValue[3] )
		dateZoomStatusText.Caption = "";
	else
		dateZoomStatusText.Caption =  StatusParamValue[3];	
	
}

private void SetLinesInfoGroup(DrawArea Area)
{
	for( int i=0; i<8;i++ )
	{
		string tagNameParam = "lineInfoGroup"+(i+1)+".tagNameParam";
		string tagNameITRD = "lineInfoGroup"+(i+1)+".tagNameITRD";
		string varParam = "lineInfoGroup"+(i+1)+".var_Param";
		string pvUnit = "lineInfoGroup"+(i+1)+".pvUnit";
		DrawText tagNameParamText = (DrawText)Area.GetDrawObj(tagNameParam);
		DrawText tagNameITRDText = (DrawText)Area.GetDrawObj(tagNameITRD);
		DrawText varParamText = (DrawText)Area.GetDrawObj(varParam);
		DrawText pvUnitText = (DrawText)Area.GetDrawObj(pvUnit);


		if( "" == LinesInfo[i,0] || null == LinesInfo[i,0] )
			tagNameParamText.Caption = "";
		else
			tagNameParamText.Caption =  LinesInfo[i,0];
		
		if( "" == LinesInfo[i,1] || null == LinesInfo[i,1] )
			tagNameITRDText.Caption = "";
		else
			tagNameITRDText.Caption =  LinesInfo[i,1];
		
		if( "" == LinesInfo[i,2] || null == LinesInfo[i,2] )
			varParamText.Caption = "";
		else
			varParamText.Caption =  LinesInfo[i,2];	

		if( "" != LinesUnit[i] && null != LinesUnit[i])
			pvUnitText.Caption = LinesUnit[i];
		else
			pvUnitText.Caption = "";

	}		
}

private void SetPointTimeString(DrawArea Area)
{
	DrawText PointTimeString = (DrawText)Area.GetDrawObj("getPointTimeString");

	if( "" == getPointTimeString || null == getPointTimeString )
		PointTimeString.Caption  = "";
	else
		PointTimeString.Caption = getPointTimeString;	
}

private void SetPercent(DrawArea Area)
{
	DrawText percent1 = (DrawText)Area.GetDrawObj("limitAverageGroup.percent1");
	DrawText percent2 = (DrawText)Area.GetDrawObj("limitAverageGroup.percent2");

	if( "" == Percent[0] || null == Percent[0] )
			percent1.Caption = "";
		else
			percent1.Caption =  "( " + Percent[0] + "% )";
		
		if( "" == Percent[1] || null == Percent[1] )
			percent2.Caption = "";
		else
			percent2.Caption =  "( " + Percent[1] + "% )";

}


private void SetLinesLimitsGroup(DrawArea Area)
{
	for( int i=0; i<8;i++ )
	{
		string paramUpName = "linesUpGroup.line"+(i+1)+"Up";
		string paramLowName = "linesLowGroup.line"+(i+1)+"Low";
		DrawText tempUp = (DrawText)Area.GetDrawObj(paramUpName);
		DrawText tempLow = (DrawText)Area.GetDrawObj(paramLowName);


		if( "" == LinesLimit[i,0] || null == LinesLimit[i,0] )
			tempUp.Caption = "";
		else
			tempUp.Caption =  LinesLimit[i,0];
		
		if( "" == LinesLimit[i,1] || null == LinesLimit[i,1] )
			tempLow.Caption = "";
		else
			tempLow.Caption =  LinesLimit[i,1];	

	}		
}

private void SetLimitAverageGroup(DrawArea Area)
{
	for( int i=0; i<6; i++ )
	{
		string paramName = "limitAverageGroup.limitValue"+(i+1);
		DrawText temp = (DrawText)Area.GetDrawObj(paramName);
		if( "" == LimitAverage[i] || null == LimitAverage[i] )
			temp.Caption = "";
		else
			temp.Caption = LimitAverage[i];	
	}
}

private void SetLinsGroupClick(DrawArea Area,Color leftColor,Color rightColor,int width,int height)
{
	for(int i=1;i<=8;i++)
	{
	   DrawRectangle lineGroupClickLeft = (DrawRectangle)Area.GetDrawObj("line"+i+"GroupClickLeft");
	   DrawRectangle lineGroupClickRight = (DrawRectangle)Area.GetDrawObj("line"+i+"GroupClickRight");
	   //DrawGroup lineInfoGroup = (DrawGroup)Area.GetDrawObj("lineInfoGroup"+1);
	   lineGroupClickLeft.BackgroundColor=leftColor;
	   lineGroupClickRight.BackgroundColor=rightColor;
	   if( width != 0 ){
	   lineGroupClickLeft.Width=width;
	   lineGroupClickRight.Width=width;
	   }
	   if( height != 0 ){
	   lineGroupClickLeft.Height=height;
	   lineGroupClickRight.Height=height;
	   }	   	
	}
}
private void InitFirstSelect(DrawArea Area)
{
	DrawRectangle line1GroupClick = (DrawRectangle)Area.GetDrawObj("line1GroupClickLeft");

DrawBitmap doubleClickedArrow = (DrawBitmap) Area.GetDrawObj("doubleClickedArrow");
doubleClickedArrow.Move(0,3000);
DrawBitmap clickArrow = (DrawBitmap) Area.GetDrawObj("clickedArrow");
Point point = new Point((int)line1GroupClick.HorizontalPosition,(int)line1GroupClick.VerticalPosition);

clickArrow.Move(point.X-(int)clickArrow.HorizontalPosition-20,point.Y-(int)clickArrow.VerticalPosition);
DvChart dv1 = (DvChart)Area.GetControlObj("TrendControl");
double uLimit = dv1.DataLimits[0,0];
double lLimit = dv1.DataLimits[0,1];

double jz = uLimit/5;


//limitAverageGroup[DrawGroup]
DrawText limitvalue1 = (DrawText)Area.GetDrawObj("limitAverageGroup.limitValue1");
DrawText limitvalue2 = (DrawText)Area.GetDrawObj("limitAverageGroup.limitValue2");
DrawText limitvalue3 = (DrawText)Area.GetDrawObj("limitAverageGroup.limitValue3");
DrawText limitvalue4 = (DrawText)Area.GetDrawObj("limitAverageGroup.limitValue4");
DrawText limitvalue5 = (DrawText)Area.GetDrawObj("limitAverageGroup.limitValue5");
DrawText limitvalue6 = (DrawText)Area.GetDrawObj("limitAverageGroup.limitValue6");

limitvalue1.Caption = uLimit.ToString("0.00");
limitvalue1.ForegroundColor = Color.Red;
limitvalue2.Caption = (jz*4).ToString("0.00");
limitvalue2.ForegroundColor = Color.Red;
limitvalue3.Caption = (jz*3).ToString("0.00");
limitvalue3.ForegroundColor = Color.Red;
limitvalue4.Caption = (jz*2).ToString("0.00");
limitvalue4.ForegroundColor = Color.Red;
limitvalue5.Caption = jz.ToString("0.00");
limitvalue5.ForegroundColor = Color.Red;
limitvalue6.Caption = lLimit.ToString("0.00");
limitvalue6.ForegroundColor = Color.Red;

}

private void InitializeControl()
{
		
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void PIC_TrendGroup_OnDynAnimation(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 
	DvChart dv = (DvChart)Area.GetControlObj("TrendControl");
	if(dv.RefreshDate)
	{
   		//this.InitializeCustom(Area);
		this.SetPointTimeString(Area);
		this.SetLinesInfoGroup(Area);
		this.SetStatusParamGroup(Area);
		dv.RefreshDate = false;
	}

for( int i=0;i<8;i++ )
{
   LinesInfo[i,0] = dv.linesInfo[i,0];
   string[] tStr = (Area.Variable[i]).Split('/');
   LinesInfo[i,1] = CommonFunction.GetTagComment(tStr[0]);
   LinesInfo[i,2] = dv.linesInfo[i,2];
}
this.SetLinesInfoGroup(Area);
this.getPointTimeString = dv.GetPointTimeString;
this.SetPointTimeString(Area);
	
if( !PauseOrNot )
{
	//HScrollBar1[HScrollBar]
	HScrollBar hscroll = (HScrollBar)Area.GetControlObj("HScrollBar1");
	dv.GetGpresTotalTime(Fresh_Interval);
	hscroll.Maximum = dv.HTotalCount;
        hscroll.Minimum = 0;
        hscroll.SmallChange = dv.HSmallChange;
        hscroll.LargeChange = dv.HLargeChange;
        hscroll.Value = hscroll.Maximum;
}



    return; 
}



/*************************************************************/

private void SetVScrollBar(int zoomDateLeve,DrawArea Area)
{
	VScrollBar vscroll = (VScrollBar)Area.GetControlObj("VScrollBar1");
	switch (zoomDateLeve)
        {
	   case 1:vscroll.Maximum = 19;break;
           case 2:vscroll.Maximum = 29;break;
           case 4:vscroll.Maximum = 59;break;
           case 8:vscroll.Maximum = 109;break;
        }
	vscroll.Minimum = 0;
	vscroll.LargeChange = 10;
	vscroll.SmallChange = 1;
        vscroll.Value = (vscroll.Maximum+1-vscroll.LargeChange)/2;
}


/*************************************************************/

private double[] ScrollFunction(double lLimit,double uLimit,int vScrollBarValue,int zoomDateLevel)
        {
            	double MaxValue = 0;
                double TopValue = 0;
                double LimitValue = 0;
                double LevelValue = 0;
                double[] ParamsList = new double[6];
                double lowLimit = lLimit;
                double upLimit = uLimit;
                LimitValue = upLimit - lowLimit;
                switch (zoomDateLevel)
                {
                    case 1:
                        MaxValue = LimitValue * (1 + 0.5);
                        TopValue = MaxValue - LimitValue * 0.1 * vScrollBarValue;
                        LevelValue = LimitValue / 5;
                        break;
                    case 2:
                        MaxValue = LimitValue * (1 + 0.25);
                        TopValue = MaxValue - LimitValue * 0.05 * vScrollBarValue;
                        LevelValue = LimitValue / 10;
                        break;
                    case 4:
                        MaxValue = LimitValue * (1 + 0.1);
                        TopValue = MaxValue - LimitValue * 0.02 * vScrollBarValue;
                        LevelValue = LimitValue / 25;
                        break;
                    case 8:
                        MaxValue = LimitValue * (1 + 0.05);
                        TopValue = MaxValue - LimitValue * 0.01 * vScrollBarValue;
                        LevelValue = LimitValue /50;
                        break;
                }
                for (int i = 0; i < 6; i++)
                {
                    ParamsList[i] = TopValue - LevelValue * i;
                }

                    return ParamsList;
        }


/***************************************************************************/

private double[] GetPercentValue(int vScrollBarValue,int zoomDateLevel)
{
	double[] result = new double[2];
		switch (zoomDateLevel)
                {
                    case 1:
                        result[0] = 150-vScrollBarValue*10;
			result[1] = result[0] - 100;
                        break;
                    case 2:
                        result[0] = 125-vScrollBarValue*5;
			result[1] = result[0] - 50;                        
                        break;
                    case 4:
                        result[0] = 110-vScrollBarValue*2;
			result[1] = result[0] - 20;                      
                        break;
                    case 8:
                        result[0] = 105-vScrollBarValue*1;
			result[1] = result[0] - 10;                       
                        break;
                }
	return result;
}
/************************************************************/


private void SelectLines()
{
	
   	DrawButton zoomDateB = (DrawButton)dArea.GetDrawObj("ZoomDateB");
   	DrawButton ZoomDateS = (DrawButton)dArea.GetDrawObj("ZoomDateS");

	
	DrawText dateState = (DrawText)dArea.GetDrawObj("statusGroup.dateZoomStatus");
	VScrollBar vScrollBar1 = (VScrollBar)dArea.GetControlObj("VScrollBar1");


	DvChart dv = (DvChart)dArea.GetControlObj("TrendControl");


double[] perent = GetPercentValue(vScrollBar1.Value,ZoomDateLevel);
Percent = new string[2]{perent[0].ToString("0.00"),perent[1].ToString("0.00")};
this.SetPercent(dArea);


double uLimit = dv.DataLimits[SelectNo-1,0];
double lLimit = dv.DataLimits[SelectNo-1,1];


switch(ZoomDateLevel)
{
	case 1: dv.ModifyPointPosition(5,vScrollBar1.Value);break;
	case 2: dv.ModifyPointPosition(10,vScrollBar1.Value);break;
	case 4: dv.ModifyPointPosition(25,vScrollBar1.Value);break;
	case 8: dv.ModifyPointPosition(50,vScrollBar1.Value);break;
}


double[] limitAverage = ScrollFunction(lLimit,uLimit,vScrollBar1.Value,ZoomDateLevel);

//limitAverageGroup[DrawGroup]
DrawText limitvalue1 = (DrawText)dArea.GetDrawObj("limitAverageGroup.limitValue1");
DrawText limitvalue2 = (DrawText)dArea.GetDrawObj("limitAverageGroup.limitValue2");
DrawText limitvalue3 = (DrawText)dArea.GetDrawObj("limitAverageGroup.limitValue3");
DrawText limitvalue4 = (DrawText)dArea.GetDrawObj("limitAverageGroup.limitValue4");
DrawText limitvalue5 = (DrawText)dArea.GetDrawObj("limitAverageGroup.limitValue5");
DrawText limitvalue6 = (DrawText)dArea.GetDrawObj("limitAverageGroup.limitValue6");

limitvalue1.Caption = limitAverage[0].ToString("0.000");
limitvalue2.Caption = limitAverage[1].ToString("0.000");
limitvalue3.Caption = limitAverage[2].ToString("0.000");
limitvalue4.Caption = limitAverage[3].ToString("0.000");
limitvalue5.Caption = limitAverage[4].ToString("0.000");
limitvalue6.Caption = limitAverage[5].ToString("0.000");
limitvalue1.ForegroundColor = dv.TT_TrendLinesColor[SelectNo-1];
limitvalue2.ForegroundColor = dv.TT_TrendLinesColor[SelectNo-1];
limitvalue3.ForegroundColor = dv.TT_TrendLinesColor[SelectNo-1];
limitvalue4.ForegroundColor = dv.TT_TrendLinesColor[SelectNo-1];
limitvalue5.ForegroundColor = dv.TT_TrendLinesColor[SelectNo-1];
limitvalue6.ForegroundColor = dv.TT_TrendLinesColor[SelectNo-1];

//Set Limits Array
for( int i=0;i<8;i++ )
{
double tlLimit = dv.DataLimits[i,1];
double tuLimit = dv.DataLimits[i,0];
double[] limitAverage1 = ScrollFunction(tlLimit,tuLimit,vScrollBar1.Value,ZoomDateLevel);
LinesLimit[i,0] = limitAverage1[0].ToString("0.00");
LinesLimit[i,1] = limitAverage1[5].ToString("0.00");
}
this.SetLinesLimitsGroup(dArea);
}

/***********************************************************/
public void MoveArrow(DrawRectangle line1GroupClick,int who)
{
DrawBitmap clickArrow = (DrawBitmap) dArea.GetDrawObj("clickedArrow");
DrawBitmap doubleClickedArrow = (DrawBitmap) dArea.GetDrawObj("doubleClickedArrow");
doubleClickedArrow.Move(0,3000);
DrawRectangle lineGroupClick = (DrawRectangle) dArea.GetDrawObj("line1GroupClickLeft");
Point point = new Point((int)line1GroupClick.HorizontalPosition,(int)line1GroupClick.VerticalPosition);
if( 1 == who)
clickArrow.Move(point.X-(int)clickArrow.HorizontalPosition-20,point.Y-(int)clickArrow.VerticalPosition);
else
clickArrow.Move(point.X-(int)clickArrow.HorizontalPosition-20-((int)lineGroupClick.Width),point.Y-(int)clickArrow.VerticalPosition);
}

/**********************************************************///Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void PenAssignment_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawButton PenAssignment = (DrawButton)dynArgs.sender; 
   Picture p = (Picture)Area.Parent;
	string[] varStr = new string[9]{Area.Variable[0],Area.Variable[1],Area.Variable[2],Area.Variable[3],Area.Variable[4],Area.Variable[5],Area.Variable[6],Area.Variable[7],p.Text};

	CommonFunction.OpenPicture("PenAssignment.grf",200,200,varStr);


    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
private static bool PauseOrNot = true;
public void Button3_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawButton Button2000 = (DrawButton)dynArgs.sender; 

	DvChart dv = (DvChart)Area.GetControlObj("TrendControl");
	
	if( PauseOrNot )
{
		dv.TrendPause();
DrawText state = (DrawText)Area.GetDrawObj("statusGroup.trendStatus");

	state.Caption = "Stop.";
}
	else{
		dv.TrendStart();
DrawText state = (DrawText)Area.GetDrawObj("statusGroup.trendStatus");

	state.Caption = "Resume.";
}

	PauseOrNot = (!PauseOrNot);

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynMouseIn 
public void Button3_OnDynMouseIn(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawButton Button2000 = (DrawButton)dynArgs.sender; 
	
	DrawText state = (DrawText)Area.GetDrawObj("statusGroup.trendStatus");

	state.Caption = "Stop/Resume The Data Display.";
    return; 
}


//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynMouseIn 
public void setDefault_OnDynMouseIn(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawButton setDefault = (DrawButton)dynArgs.sender; 
   DrawText state = (DrawText)Area.GetDrawObj("statusGroup.trendStatus");

	state.Caption = "Display Initialization.";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void setDefault_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawButton setDefault = (DrawButton)dynArgs.sender; 


   this.ToDefault();

    return; 
}


public void ToDefault()
{

ZoomDateLevel = 1;
SetVScrollBar(1,dArea);
Percent = new string[2]{"100","0"};
this.SetPercent(dArea);

this.InitializeCustom(dArea);
this.SetLinesLimitsGroup(dArea);


DvChart dv = (DvChart)dArea.GetControlObj("TrendControl");


dv.HisTrend = false;

dv.PointDefaultY = 0;
dv.CommonHeight = dv.BackGridPictureBox.Height*2;

Fresh_Interval=1;
ZoomDateLevel = 1;
dv.SetZoomLevel(1);
dv.DrawLinesNo = false;

PauseOrNot = false;
isDateTime = false;
dv.TrendStart();



dv.SetDataZoomLevel(ZoomDateLevel);
this.InitializeCustom(dArea);







double uLimit = dv.DataLimits[SelectNo-1,0];
double lLimit = dv.DataLimits[SelectNo-1,1];

double jz = (uLimit-lLimit)/5;


//limitAverageGroup[DrawGroup]
DrawText limitvalue1 = (DrawText)dArea.GetDrawObj("limitAverageGroup.limitValue1");
DrawText limitvalue2 = (DrawText)dArea.GetDrawObj("limitAverageGroup.limitValue2");
DrawText limitvalue3 = (DrawText)dArea.GetDrawObj("limitAverageGroup.limitValue3");
DrawText limitvalue4 = (DrawText)dArea.GetDrawObj("limitAverageGroup.limitValue4");
DrawText limitvalue5 = (DrawText)dArea.GetDrawObj("limitAverageGroup.limitValue5");
DrawText limitvalue6 = (DrawText)dArea.GetDrawObj("limitAverageGroup.limitValue6");

limitvalue1.Caption = uLimit.ToString("0.00");
limitvalue1.ForegroundColor = dv.TT_TrendLinesColor[SelectNo-1];
limitvalue2.Caption = (jz*4).ToString("0.00");
limitvalue2.ForegroundColor = dv.TT_TrendLinesColor[SelectNo-1];
limitvalue3.Caption = (jz*3).ToString("0.00");
limitvalue3.ForegroundColor = dv.TT_TrendLinesColor[SelectNo-1];
limitvalue4.Caption = (jz*2).ToString("0.00");
limitvalue4.ForegroundColor = dv.TT_TrendLinesColor[SelectNo-1];
limitvalue5.Caption = jz.ToString("0.00");
limitvalue5.ForegroundColor = dv.TT_TrendLinesColor[SelectNo-1];
limitvalue6.Caption = lLimit.ToString("0.00");
limitvalue6.ForegroundColor = dv.TT_TrendLinesColor[SelectNo-1];

VScrollBar vScrollBar1 = (VScrollBar)dArea.GetControlObj("VScrollBar1");

switch(ZoomDateLevel)
{
	case 1: dv.ModifyPointPosition(5,vScrollBar1.Value);break;
	case 2: dv.ModifyPointPosition(10,vScrollBar1.Value);break;
	case 4: dv.ModifyPointPosition(25,vScrollBar1.Value);break;
	case 8: dv.ModifyPointPosition(50,vScrollBar1.Value);break;
}
//Set Limits Array
for( int i=0;i<8;i++ )
{
double tlLimit = dv.DataLimits[i,1];
double tuLimit = dv.DataLimits[i,0];
double[] limitAverage1 = ScrollFunction(tlLimit,tuLimit,vScrollBar1.Value,ZoomDateLevel);
LinesLimit[i,0] = limitAverage1[0].ToString("0.00");
LinesLimit[i,1] = limitAverage1[5].ToString("0.00");
}
this.SetLinesLimitsGroup(dArea);

}//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void ZoomB_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawButton zoomB = (DrawButton)dynArgs.sender; 
	DrawButton zoomS = (DrawButton)Area.GetDrawObj("ZoomS");
	
	DrawText timeState = (DrawText)Area.GetDrawObj("statusGroup.timeZoomStatus");
  
	Fresh_Interval /= 2;
	switch(Fresh_Interval)
	{
		case 1 : timeState.Caption = "00:15:00";FinalInterval=1;break;
		case 2 : timeState.Caption = "00:30:00";FinalInterval=2;break;
		case 4 : timeState.Caption = "01:00:00";FinalInterval=3;break;
		case 8 : timeState.Caption = "02:00:00";FinalInterval=4;break;
		case 16 : timeState.Caption = "04:00:00";FinalInterval=5;break;
		case 32 : timeState.Caption = "08:00:00";FinalInterval=6;break;
	}
		

   	if( Fresh_Interval == 1 )
	zoomB.Move(0,-100);

	if( zoomS.VerticalPosition < 0 )
	{
		
		zoomS.Move(0,100);
	}

	//MessageBox.Show("FreshInterval : " + Fresh_Interval);

	DvChart dv = (DvChart)Area.GetControlObj("TrendControl");

	VScrollBar vScrollBar1 = (VScrollBar)Area.GetControlObj("VScrollBar1");
	int RowHeight = (int)(dv.BackGridPictureBox.Height / dv.TT_BackGroundRow);


	dv.SetZoomLevel(FinalInterval);

	//HScrollBar1[HScrollBar]
	HScrollBar hscroll = (HScrollBar)Area.GetControlObj("HScrollBar1");
	dv.GetGpresTotalTime(Fresh_Interval);
	hscroll.Maximum = dv.HTotalCount;
        hscroll.Minimum = 0;
        hscroll.SmallChange = dv.HSmallChange;
        hscroll.LargeChange = dv.HLargeChange;
        hscroll.Value = hscroll.Maximum;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynMouseIn 
public void ZoomB_OnDynMouseIn(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawButton ZoomB = (DrawButton)dynArgs.sender; 
	
	DrawText state = (DrawText)Area.GetDrawObj("statusGroup.trendStatus");

	state.Caption = "Enlarge Time - Axis Span.";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynMouseIn 
public void Bitmap1_OnDynMouseIn(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawBitmap Bitmap1 = (DrawBitmap)dynArgs.sender; 
	
	DrawText state = (DrawText)Area.GetDrawObj("statusGroup.trendStatus");

	state.Caption = "Enlarge Time - Axis Span.";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
private static int Fresh_Interval = 1;
private static int FinalInterval = 1;
private static bool MoveSwitch = true;
public void ZoomS_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawButton ZoomS = (DrawButton)dynArgs.sender; 
	
	DrawText timeState = (DrawText)Area.GetDrawObj("statusGroup.timeZoomStatus");
  	
	Fresh_Interval *= 2;
	switch(Fresh_Interval)
	{
		case 1 : timeState.Caption = "00:15:00"; FinalInterval = 1;break;
		case 2 : timeState.Caption = "00:30:00"; FinalInterval = 2;break;
		case 4 : timeState.Caption = "01:00:00"; FinalInterval = 3;break;
		case 8 : timeState.Caption = "02:00:00"; FinalInterval = 4;break;
		case 16 : timeState.Caption = "04:00:00"; FinalInterval = 5;break;
		case 32 : timeState.Caption = "08:00:00"; FinalInterval = 6;break;
	}

        
	DrawButton zoomB = (DrawButton)Area.GetDrawObj("ZoomB");
		if( zoomB.VerticalPosition < 0 )
		{
			zoomB.Move(0,100);

		}

	if( Fresh_Interval == 32 )
	{
	ZoomS.Move(0,-100);
	}

	//MessageBox.Show("FreshInterval : " + Fresh_Interval);	

	DvChart dv = (DvChart)Area.GetControlObj("TrendControl");

	VScrollBar vScrollBar1 = (VScrollBar)Area.GetControlObj("VScrollBar1");
	int RowHeight = (int)(dv.BackGridPictureBox.Height / dv.TT_BackGroundRow);

	dv.SetZoomLevel(FinalInterval);

	//HScrollBar1[HScrollBar]
	HScrollBar hscroll = (HScrollBar)Area.GetControlObj("HScrollBar1");
	dv.GetGpresTotalTime(Fresh_Interval);
	hscroll.Maximum = dv.HTotalCount;
        hscroll.Minimum = 0;
        hscroll.SmallChange = dv.HSmallChange;
        hscroll.LargeChange = dv.HLargeChange;
        hscroll.Value = hscroll.Maximum;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynMouseIn 
public void ZoomS_OnDynMouseIn(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawButton ZoomS = (DrawButton)dynArgs.sender; 
   
	
	DrawText state = (DrawText)Area.GetDrawObj("statusGroup.trendStatus");

	state.Caption = "Reduce Time - Axis Span.";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynMouseIn 
public void Bitmap2_OnDynMouseIn(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawBitmap Bitmap2 = (DrawBitmap)dynArgs.sender; 
	
	DrawText state = (DrawText)Area.GetDrawObj("statusGroup.trendStatus");

	state.Caption = "Reduce Time - Axis Span.";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void linesNo_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawButton linesNo = (DrawButton)dynArgs.sender; 
   DvChart dv = (DvChart)Area.GetControlObj("TrendControl");
	
	if( dv.DrawLinesNo )
		dv.DrawLinesNo = !dv.DrawLinesNo;
	else
		dv.DrawLinesNo = !dv.DrawLinesNo;
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynMouseIn 
public void linesNo_OnDynMouseIn(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawButton linesNo = (DrawButton)dynArgs.sender; 
   DrawText state = (DrawText)Area.GetDrawObj("statusGroup.trendStatus");

	state.Caption = "Display/Delete Pen Number.";
    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
private static int ZoomDateLevel = 1;
private static bool MoveDateSwitch = true;
public void ZoomDateB_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawButton ZoomDateB = (DrawButton)dynArgs.sender; 
	
	DrawText dateState = (DrawText)Area.GetDrawObj("statusGroup.dateZoomStatus");
   	VScrollBar vScrollBar1 = (VScrollBar)Area.GetControlObj("VScrollBar1");
	
	ZoomDateLevel *= 2;

	DvChart dv = (DvChart)Area.GetControlObj("TrendControl");



	
double[] perent = GetPercentValue(vScrollBar1.Value,ZoomDateLevel);
Percent = new string[2]{perent[0].ToString("0.00"),perent[1].ToString("0.00")};
this.SetPercent(dArea);


	double uLimit = 100;
	double lLimit = 0;
	switch(ZoomDateLevel)
	{
		case 1 : dateState.Caption = "100%";
			Percent = new string[2]{"100","0"};this.SetPercent(dArea);
			break;
		case 2 : dateState.Caption = "50%";
			Percent = new string[2]{"75","25"};this.SetPercent(dArea);
			break;
		case 4 : dateState.Caption = "20%";
			Percent = new string[2]{"60","40"};this.SetPercent(dArea);
			break;
		case 8 : dateState.Caption = "10%";
			Percent = new string[2]{"55","45"};this.SetPercent(dArea);
			break;
	}
	uLimit = dv.DataLimits[SelectNo-1,0];
	lLimit = dv.DataLimits[SelectNo-1,1];
SetVScrollBar(ZoomDateLevel,dArea);

double[] limitAverage = ScrollFunction(lLimit,uLimit,vScrollBar1.Value,ZoomDateLevel);

SetVScrollBar(ZoomDateLevel,dArea);

//limitAverageGroup[DrawGroup]
DrawText limitvalue1 = (DrawText)dArea.GetDrawObj("limitAverageGroup.limitValue1");
DrawText limitvalue2 = (DrawText)dArea.GetDrawObj("limitAverageGroup.limitValue2");
DrawText limitvalue3 = (DrawText)dArea.GetDrawObj("limitAverageGroup.limitValue3");
DrawText limitvalue4 = (DrawText)dArea.GetDrawObj("limitAverageGroup.limitValue4");
DrawText limitvalue5 = (DrawText)dArea.GetDrawObj("limitAverageGroup.limitValue5");
DrawText limitvalue6 = (DrawText)dArea.GetDrawObj("limitAverageGroup.limitValue6");

limitvalue1.Caption = limitAverage[0].ToString("0.000");
limitvalue2.Caption = limitAverage[1].ToString("0.000");
limitvalue3.Caption = limitAverage[2].ToString("0.000");
limitvalue4.Caption = limitAverage[3].ToString("0.000");
limitvalue5.Caption = limitAverage[4].ToString("0.000");
limitvalue6.Caption = limitAverage[5].ToString("0.000");

	DrawButton zoomDateS = (DrawButton)Area.GetDrawObj("ZoomDateS");

	if( zoomDateS.VerticalPosition < 0 )
		zoomDateS.Move(0,100);
	if( ZoomDateLevel == 8 )
		ZoomDateB.Move(0,-100);
	
	int RowHeight = (int)(dv.BackGridPictureBox.Height / dv.TT_BackGroundRow);
	dv.SetDataZoomLevel(ZoomDateLevel);

switch(ZoomDateLevel)
{
	case 1: dv.ModifyPointPosition(5,vScrollBar1.Value);break;
	case 2: dv.ModifyPointPosition(10,vScrollBar1.Value);break;
	case 4: dv.ModifyPointPosition(25,vScrollBar1.Value);break;
	case 8: dv.ModifyPointPosition(50,vScrollBar1.Value);break;
}

//Set Limits Array
for( int i=0;i<8;i++ )
{
double tlLimit = dv.DataLimits[i,1];
double tuLimit = dv.DataLimits[i,0];
double[] limitAverage1 = ScrollFunction(tlLimit,tuLimit,vScrollBar1.Value,ZoomDateLevel);
LinesLimit[i,0] = limitAverage1[0].ToString("0.00");
LinesLimit[i,1] = limitAverage1[5].ToString("0.00");
}
this.SetLinesLimitsGroup(dArea);
	
    return; 
}//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynMouseIn 
public void ZoomDateB_OnDynMouseIn(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawButton ZoomDateB = (DrawButton)dynArgs.sender; 
   
	
	DrawText state = (DrawText)Area.GetDrawObj("statusGroup.trendStatus");

	state.Caption = "Enlarge Graphic Display.";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void ZoomDateS_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawButton ZoomDateS = (DrawButton)dynArgs.sender; 
   	DrawButton zoomDateB = (DrawButton)Area.GetDrawObj("ZoomDateB");

	
	DrawText dateState = (DrawText)Area.GetDrawObj("statusGroup.dateZoomStatus");
	VScrollBar vScrollBar1 = (VScrollBar)Area.GetControlObj("VScrollBar1");
	ZoomDateLevel /= 2;


	DvChart dv = (DvChart)Area.GetControlObj("TrendControl");




double[] perent = GetPercentValue(vScrollBar1.Value,ZoomDateLevel);
Percent = new string[2]{perent[0].ToString("0.00"),perent[1].ToString("0.00")};
this.SetPercent(dArea);


	double uLimit = 100;
	double lLimit = 0;
	switch(ZoomDateLevel)
	{
		case 1 : dateState.Caption = "100%";
			Percent = new string[2]{"100","0"};this.SetPercent(dArea);
			break;
		case 2 : dateState.Caption = "50%";
			Percent = new string[2]{"75","25"};this.SetPercent(dArea);
			break;
		case 4 : dateState.Caption = "20%";
			Percent = new string[2]{"60","40"};this.SetPercent(dArea);
			break;
		case 8 : dateState.Caption = "10%";
			Percent = new string[2]{"55","45"};this.SetPercent(dArea);
			break;
	}

uLimit = dv.DataLimits[SelectNo-1,0];
lLimit = dv.DataLimits[SelectNo-1,1];
SetVScrollBar(ZoomDateLevel,dArea);

double[] limitAverage = ScrollFunction(lLimit,uLimit,vScrollBar1.Value,ZoomDateLevel);

SetVScrollBar(ZoomDateLevel,dArea);

//limitAverageGroup[DrawGroup]
DrawText limitvalue1 = (DrawText)dArea.GetDrawObj("limitAverageGroup.limitValue1");
DrawText limitvalue2 = (DrawText)dArea.GetDrawObj("limitAverageGroup.limitValue2");
DrawText limitvalue3 = (DrawText)dArea.GetDrawObj("limitAverageGroup.limitValue3");
DrawText limitvalue4 = (DrawText)dArea.GetDrawObj("limitAverageGroup.limitValue4");
DrawText limitvalue5 = (DrawText)dArea.GetDrawObj("limitAverageGroup.limitValue5");
DrawText limitvalue6 = (DrawText)dArea.GetDrawObj("limitAverageGroup.limitValue6");

limitvalue1.Caption = limitAverage[0].ToString("0.000");
limitvalue2.Caption = limitAverage[1].ToString("0.000");
limitvalue3.Caption = limitAverage[2].ToString("0.000");
limitvalue4.Caption = limitAverage[3].ToString("0.000");
limitvalue5.Caption = limitAverage[4].ToString("0.000");
limitvalue6.Caption = limitAverage[5].ToString("0.000");


	if( ZoomDateLevel == 1 )
		ZoomDateS.Move(0,-100);

	if( zoomDateB.VerticalPosition < 0 )
		zoomDateB.Move(0,100);


	int RowHeight = (int)(dv.BackGridPictureBox.Height / dv.TT_BackGroundRow);

	dv.SetDataZoomLevel(ZoomDateLevel);


switch(ZoomDateLevel)
{
	case 1: dv.ModifyPointPosition(5,vScrollBar1.Value);break;
	case 2: dv.ModifyPointPosition(10,vScrollBar1.Value);break;
	case 4: dv.ModifyPointPosition(25,vScrollBar1.Value);break;
	case 8: dv.ModifyPointPosition(50,vScrollBar1.Value);break;
}

//Set Limits Array
for( int i=0;i<8;i++ )
{
double tlLimit = dv.DataLimits[i,1];
double tuLimit = dv.DataLimits[i,0];
double[] limitAverage1 = ScrollFunction(tlLimit,tuLimit,vScrollBar1.Value,ZoomDateLevel);
LinesLimit[i,0] = limitAverage1[0].ToString("0.00");
LinesLimit[i,1] = limitAverage1[5].ToString("0.00");
}
this.SetLinesLimitsGroup(dArea);


    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynMouseIn 
public void ZoomDateS_OnDynMouseIn(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawButton ZoomDateS = (DrawButton)dynArgs.sender; 

	
	DrawText state = (DrawText)Area.GetDrawObj("statusGroup.trendStatus");

	state.Caption = "Reduce Graphic Dispaly.";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynMouseIn 
public void Bitmap3_OnDynMouseIn(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawBitmap Bitmap3 = (DrawBitmap)dynArgs.sender; 
   

	
	DrawText state = (DrawText)Area.GetDrawObj("statusGroup.trendStatus");

	state.Caption = "Enlarge Graphic Display.";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynMouseIn 
public void Bitmap4_OnDynMouseIn(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawBitmap Bitmap4 = (DrawBitmap)dynArgs.sender; 

	
	DrawText state =(DrawText)Area.GetDrawObj("statusGroup.trendStatus");

	state.Caption = "Reduce Graphic Dispaly.";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void leftArrow_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawButton leftArrow = (DrawButton)dynArgs.sender; 
   
	//moveArrow[DrawBitmap]HorizontalPosition
	DrawBitmap moveArrow = (DrawBitmap) Area.GetDrawObj("moveArrow");
DvChart dv = (DvChart)Area.GetControlObj("TrendControl");
	moveArrow.VerticalPosition = leftArrow.VerticalPosition;;
	if( moveArrow.HorizontalPosition > (leftArrow.HorizontalPosition+ leftArrow.Width)-(moveArrow.Width/2)+4){
		moveArrow.HorizontalPosition -= 2;
dv.MoveHLine((int)(moveArrow.HorizontalPosition-moveArrow.Width/2-4));
if( isDateTime )
dv.GetGpresInfoByPosition((int)(moveArrow.HorizontalPosition-moveArrow.Width/2-4),dateTime);
else
dv.GetGpresInfoByPosition((int)(moveArrow.HorizontalPosition-moveArrow.Width/2-4),dv.GetCurrentModelDateTime(dv.GetCurrentModelTime()));
			for( int i=0;i<8;i++ )
			{
	  		  LinesInfo[i,0] = dv.linesInfo[i,0];
	  		  LinesInfo[i,1] = dv.linesInfo[i,1];
	  		  LinesInfo[i,2] = dv.linesInfo[i,2];
			}
			this.SetLinesInfoGroup(Area);
this.getPointTimeString = dv.GetPointTimeString;
			this.SetPointTimeString(Area);
}
	else{
		moveArrow.HorizontalPosition = leftArrow.HorizontalPosition+ leftArrow.Width-moveArrow.Width/2+3;
dv.MoveHLine((int)(moveArrow.HorizontalPosition-moveArrow.Width/2-4));
if( isDateTime )
dv.GetGpresInfoByPosition((int)(moveArrow.HorizontalPosition-moveArrow.Width/2-4),dateTime);
else
dv.GetGpresInfoByPosition((int)(moveArrow.HorizontalPosition-moveArrow.Width/2-4),dv.GetCurrentModelDateTime(dv.GetCurrentModelTime()));
			for( int i=0;i<8;i++ )
			{
	  		  LinesInfo[i,0] = dv.linesInfo[i,0];
	  		  LinesInfo[i,1] = dv.linesInfo[i,1];
	  		  LinesInfo[i,2] = dv.linesInfo[i,2];
			}
			this.SetLinesInfoGroup(Area);
this.getPointTimeString = dv.GetPointTimeString;
			this.SetPointTimeString(Area);
}
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void rightArrow_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawButton rightArrow = (DrawButton)dynArgs.sender; 
   //moveArrow[DrawBitmap]HorizontalPosition
	DrawBitmap moveArrow = (DrawBitmap) Area.GetDrawObj("moveArrow");
DvChart dv = (DvChart)Area.GetControlObj("TrendControl");
	moveArrow.VerticalPosition = rightArrow.VerticalPosition;
	if( moveArrow.HorizontalPosition < rightArrow.HorizontalPosition-moveArrow.Width ){
		moveArrow.HorizontalPosition += 2;
dv.MoveHLine((int)(moveArrow.HorizontalPosition-moveArrow.Width/2-4));
if( isDateTime )
dv.GetGpresInfoByPosition((int)(moveArrow.HorizontalPosition-moveArrow.Width/2-4),dateTime);
else
dv.GetGpresInfoByPosition((int)(moveArrow.HorizontalPosition-moveArrow.Width/2-4),dv.GetCurrentModelDateTime(dv.GetCurrentModelTime()));
			for( int i=0;i<8;i++ )
			{
	  		  LinesInfo[i,0] = dv.linesInfo[i,0];
	  		  LinesInfo[i,1] = dv.linesInfo[i,1];
	  		  LinesInfo[i,2] = dv.linesInfo[i,2];
			}
			this.SetLinesInfoGroup(Area);
this.getPointTimeString = dv.GetPointTimeString;
			this.SetPointTimeString(Area);
}
	else{
		moveArrow.HorizontalPosition = rightArrow.HorizontalPosition-(moveArrow.Width/2)-3;
dv.MoveHLine((int)(moveArrow.HorizontalPosition-moveArrow.Width/2-4));
if( isDateTime )
dv.GetGpresInfoByPosition((int)(moveArrow.HorizontalPosition-moveArrow.Width/2-4),dateTime);
else
dv.GetGpresInfoByPosition((int)(moveArrow.HorizontalPosition-moveArrow.Width/2-4),dv.GetCurrentModelDateTime(dv.GetCurrentModelTime()));
			for( int i=0;i<8;i++ )
			{
	  		  LinesInfo[i,0] = dv.linesInfo[i,0];
	  		  LinesInfo[i,1] = dv.linesInfo[i,1];
	  		  LinesInfo[i,2] = dv.linesInfo[i,2];
			}
			this.SetLinesInfoGroup(Area);
this.getPointTimeString = dv.GetPointTimeString;
			this.SetPointTimeString(Area);
}
    return; 
}

/*
public void OnDynMouseMove(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawBitmap moveArrow = (DrawBitmap)dynArgs.sender; 

   DvChart dv = (DvChart)Area.GetControlObj("TrendControl");
   DrawButton rightArrow = (DrawButton)Area.GetDrawObj("rightArrow");
	moveArrow.VerticalPosition = rightArrow.VerticalPosition;

	int PX = Cursor.Position.X;
	int PY = Cursor.Position.Y;

	Picture pic = ((Picture)Area.Parent);
	int picX = pic.Left;

	if( (PX-picX)>=15 && (PX-picX) <= rightArrow.HorizontalPosition -(moveArrow.HorizontalPosition/2+1) )
	{
		if((PX%2 > 0)){
			moveArrow.HorizontalPosition = (PX+1)-picX-12;
dv.MoveHLine((PX+1)-picX-24);
if( isDateTime )
dv.GetGpresInfoByPosition((PX+1)-picX-24,dateTime);
else
dv.GetGpresInfoByPosition((PX+1)-picX-24,DateTime.Now);

this.SetLinesInfoGroup(Area);
this.getPointTimeString = dv.GetPointTimeString;
			this.SetPointTimeString(Area);
}
		else{
			moveArrow.HorizontalPosition = PX-picX-12;
dv.MoveHLine(PX-picX-24);
if( isDateTime )
dv.GetGpresInfoByPosition(PX-picX-24,dateTime);
else
dv.GetGpresInfoByPosition(PX-picX-24,DateTime.Now);
this.SetLinesInfoGroup(Area);
this.getPointTimeString = dv.GetPointTimeString;
			this.SetPointTimeString(Area);
}

	}
    return; 
}

//*///Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynMouseUp 
public void moveArrowBackGround_OnDynMouseUp(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle moveArrowBackGround = (DrawRectangle)dynArgs.sender; 

	DrawBitmap moveArrow = (DrawBitmap) Area.GetDrawObj("moveArrow");
	DrawButton rightArrow = (DrawButton) Area.GetDrawObj("rightArrow");
	DvChart dv = (DvChart)Area.GetControlObj("TrendControl");
	moveArrow.VerticalPosition = rightArrow.VerticalPosition;

	PointF scaleSize = Area.GetScaleFactor();

	int PX = Cursor.Position.X;
	int PY = Cursor.Position.Y;
	int dynPX = dynArgs.X;
	int dynPY = dynArgs.Y;
	int ctrlX;

	Picture pic = ((Picture)Area.Parent);
	int picX = pic.Left;

//	MessageBox.Show( "dynArgs: " + dynArgs.X.ToString() + "         arrow.X: " + moveArrow.HorizontalPosition.ToString() );

//	if( (PX-picX)>=15 && (PX-picX) <= 707 )
	{
		if((PX%2 > 0)){

			// ------------------ Old Code;
			//moveArrow.HorizontalPosition = (PX+1)-picX-12;
			//dv.MoveHLine((PX+1)-24);	
			//if( isDateTime )
			//dv.GetGpresInfoByPosition((PX+1)-picX-24,dateTime);
			//else
			//dv.GetGpresInfoByPosition((PX+1)-picX-24,dv.GetCurrentModelDateTime(dv.GetCurrentModelTime()));

			// ------------------ New Code, Support Resizing
			moveArrow.HorizontalPosition = (dynPX+1)-12;
			ctrlX = (int)( ((dynPX+1)-24)/scaleSize.X );
			dv.MoveHLine( ctrlX );	
			if( isDateTime )
			dv.GetGpresInfoByPosition( ctrlX,dateTime);
			else
			dv.GetGpresInfoByPosition( ctrlX,dv.GetCurrentModelDateTime(dv.GetCurrentModelTime()));

			for( int i=0;i<8;i++ )
			{
	  		  LinesInfo[i,0] = dv.linesInfo[i,0];
	  		  LinesInfo[i,1] = dv.linesInfo[i,1];
	  		  LinesInfo[i,2] = dv.linesInfo[i,2];
			}
			this.SetLinesInfoGroup(Area);
			this.getPointTimeString = dv.GetPointTimeString;
			this.SetPointTimeString(Area);
		}
		else{
			// ------------------ Old Code;
			//moveArrow.HorizontalPosition = PX-picX-12;
			//dv.MoveHLine(PX-24);
			//dv.MoveHLine( (int)( ((dynPX)-25)/scaleSize.X ) );	
			//if( isDateTime )
			//dv.GetGpresInfoByPosition(PX-picX-24,dateTime);
			//else
			//dv.GetGpresInfoByPosition(PX-picX-24,dv.GetCurrentModelDateTime(dv.GetCurrentModelTime()));

			// ------------------ New Code, Support Resizing
			moveArrow.HorizontalPosition = dynPX-12;
			ctrlX = (int)( ((dynPX)-24)/scaleSize.X );
			dv.MoveHLine( ctrlX );	
			if( isDateTime )
			dv.GetGpresInfoByPosition( ctrlX, dateTime);
			else
			dv.GetGpresInfoByPosition( ctrlX, dv.GetCurrentModelDateTime(dv.GetCurrentModelTime()));
			for( int i=0;i<8;i++ )
			{
	  		  LinesInfo[i,0] = dv.linesInfo[i,0];
	  		  LinesInfo[i,1] = dv.linesInfo[i,1];
	  		  LinesInfo[i,2] = dv.linesInfo[i,2];
			}
			this.SetLinesInfoGroup(Area);
			this.getPointTimeString = dv.GetPointTimeString;
			this.SetPointTimeString(Area);	
		}
	}
	
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void line1GroupClickLeft_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle line1GroupClick = (DrawRectangle)dynArgs.sender; 

	SelectNo = 1;
	this.MoveArrow(line1GroupClick,1);
	this.SelectLines();
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynDblClick 
public void line1GroupClickLeft_OnDynDblClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle line1GroupClick = (DrawRectangle)dynArgs.sender; 
   //doubleClickedArrow
DrawBitmap clickArrow = (DrawBitmap) Area.GetDrawObj("clickedArrow");
clickArrow.Move(0,3000);

DrawBitmap doubleClickedArrow = (DrawBitmap) Area.GetDrawObj("doubleClickedArrow");
Point point = new Point((int)line1GroupClick.HorizontalPosition,(int)line1GroupClick.VerticalPosition);

doubleClickedArrow.Move(point.X-(int)doubleClickedArrow.HorizontalPosition-20,point.Y-(int)doubleClickedArrow.VerticalPosition);

SelectNo = 1;

//CommonFunction.OpenPicture("subTrend.grf");
string[] varStr = new string[]{Area.Variable[0],"0","0"};
CommonFunction.OpenDataEntryInput("../Picture/subTrend.grf",varStr,new Point(200,200));
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void line2GroupClickLeft_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle line1GroupClick = (DrawRectangle)dynArgs.sender; 


SelectNo = 2;
	this.MoveArrow(line1GroupClick,1);
this.SelectLines();


    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynDblClick 
public void line2GroupClickLeft_OnDynDblClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle line1GroupClick = (DrawRectangle)dynArgs.sender; 
   //doubleClickedArrow
DrawBitmap clickArrow = (DrawBitmap) Area.GetDrawObj("clickedArrow");
clickArrow.Move(0,3000);

DrawBitmap doubleClickedArrow = (DrawBitmap) Area.GetDrawObj("doubleClickedArrow");
Point point = new Point((int)line1GroupClick.HorizontalPosition,(int)line1GroupClick.VerticalPosition);

doubleClickedArrow.Move(point.X-(int)doubleClickedArrow.HorizontalPosition-20,point.Y-(int)doubleClickedArrow.VerticalPosition);
SelectNo = 2;

string[] varStr = new string[]{Area.Variable[1],"1","0"};
CommonFunction.OpenDataEntryInput("../Picture/subTrend.grf",varStr,new Point(200,200));


    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void line3GroupClickLeft_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle line1GroupClick = (DrawRectangle)dynArgs.sender; 




SelectNo = 3;
	this.MoveArrow(line1GroupClick,1);
this.SelectLines();
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynDblClick 
public void line3GroupClickLeft_OnDynDblClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle line1GroupClick = (DrawRectangle)dynArgs.sender; 
   //doubleClickedArrow
DrawBitmap clickArrow = (DrawBitmap) Area.GetDrawObj("clickedArrow");
clickArrow.Move(0,3000);

DrawBitmap doubleClickedArrow = (DrawBitmap) Area.GetDrawObj("doubleClickedArrow");
Point point = new Point((int)line1GroupClick.HorizontalPosition,(int)line1GroupClick.VerticalPosition);

doubleClickedArrow.Move(point.X-(int)doubleClickedArrow.HorizontalPosition-20,point.Y-(int)doubleClickedArrow.VerticalPosition);
SelectNo = 3;
string[] varStr = new string[]{Area.Variable[2],"2","0"};
CommonFunction.OpenDataEntryInput("../Picture/subTrend.grf",varStr,new Point(200,200));
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void line4GroupClickLeft_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle line1GroupClick = (DrawRectangle)dynArgs.sender; 


SelectNo = 4;
	this.MoveArrow(line1GroupClick,1);
this.SelectLines();

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynDblClick 
public void line4GroupClickLeft_OnDynDblClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle line1GroupClick = (DrawRectangle)dynArgs.sender; 
   //doubleClickedArrow
DrawBitmap clickArrow = (DrawBitmap) Area.GetDrawObj("clickedArrow");
clickArrow.Move(0,3000);

DrawBitmap doubleClickedArrow = (DrawBitmap) Area.GetDrawObj("doubleClickedArrow");
Point point = new Point((int)line1GroupClick.HorizontalPosition,(int)line1GroupClick.VerticalPosition);

doubleClickedArrow.Move(point.X-(int)doubleClickedArrow.HorizontalPosition-20,point.Y-(int)doubleClickedArrow.VerticalPosition);
SelectNo = 4;
string[] varStr = new string[]{Area.Variable[3],"3","0"};
CommonFunction.OpenDataEntryInput("../Picture/subTrend.grf",varStr,new Point(200,200));
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void line5GroupClickLeft_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle line1GroupClick = (DrawRectangle)dynArgs.sender;



SelectNo = 5;
	this.MoveArrow(line1GroupClick,1);
this.SelectLines();
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynDblClick 
public void line5GroupClickLeft_OnDynDblClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle line1GroupClick = (DrawRectangle)dynArgs.sender; 
   //doubleClickedArrow
DrawBitmap clickArrow = (DrawBitmap) Area.GetDrawObj("clickedArrow");
clickArrow.Move(0,3000);

DrawBitmap doubleClickedArrow = (DrawBitmap) Area.GetDrawObj("doubleClickedArrow");
Point point = new Point((int)line1GroupClick.HorizontalPosition,(int)line1GroupClick.VerticalPosition);

doubleClickedArrow.Move(point.X-(int)doubleClickedArrow.HorizontalPosition-20,point.Y-(int)doubleClickedArrow.VerticalPosition);
SelectNo = 5;
string[] varStr = new string[]{Area.Variable[4],"4","0"};
CommonFunction.OpenDataEntryInput("../Picture/subTrend.grf",varStr,new Point(200,200));
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void line6GroupClickLeft_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle line1GroupClick = (DrawRectangle)dynArgs.sender; 





SelectNo = 6;
	this.MoveArrow(line1GroupClick,1);
this.SelectLines();

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynDblClick 
public void line6GroupClickLeft_OnDynDblClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle line1GroupClick = (DrawRectangle)dynArgs.sender; 
   //doubleClickedArrow
DrawBitmap clickArrow = (DrawBitmap) Area.GetDrawObj("clickedArrow");
clickArrow.Move(0,3000);

DrawBitmap doubleClickedArrow = (DrawBitmap) Area.GetDrawObj("doubleClickedArrow");
Point point = new Point((int)line1GroupClick.HorizontalPosition,(int)line1GroupClick.VerticalPosition);

doubleClickedArrow.Move(point.X-(int)doubleClickedArrow.HorizontalPosition-20,point.Y-(int)doubleClickedArrow.VerticalPosition);
SelectNo = 6;
string[] varStr = new string[]{Area.Variable[5],"5","0"};
CommonFunction.OpenDataEntryInput("../Picture/subTrend.grf",varStr,new Point(200,200));
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void line1GroupClickRight_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle line1GroupClick = (DrawRectangle)dynArgs.sender; 

SelectNo = 1;
	this.MoveArrow(line1GroupClick,2);
this.SelectLines();
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynDblClick 
public void line1GroupClickRight_OnDynDblClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle line1GroupClick = (DrawRectangle)dynArgs.sender; 
   //doubleClickedArrow
DrawBitmap clickArrow = (DrawBitmap) Area.GetDrawObj("clickedArrow");
DrawRectangle lineGroupClickLeft = (DrawRectangle)Area.GetDrawObj("line1GroupClickLeft");
int width = (int)lineGroupClickLeft.Width+20;
clickArrow.Move(0,3000);

DrawBitmap doubleClickedArrow = (DrawBitmap) Area.GetDrawObj("doubleClickedArrow");
Point point = new Point((int)line1GroupClick.HorizontalPosition,(int)line1GroupClick.VerticalPosition);

doubleClickedArrow.Move(point.X-(int)doubleClickedArrow.HorizontalPosition-width,point.Y-(int)doubleClickedArrow.VerticalPosition);

SelectNo = 1;
string[] tStringArray = (Area.Variable[0]).Split('/');
CommonFunction.OpenFaceplate(tStringArray[0]);

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void line2GroupClickRight_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle line1GroupClick = (DrawRectangle)dynArgs.sender; 

SelectNo = 2;
	this.MoveArrow(line1GroupClick,2);
this.SelectLines();



    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynDblClick 
public void line2GroupClickRight_OnDynDblClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle line1GroupClick = (DrawRectangle)dynArgs.sender; 
   //doubleClickedArrow
DrawBitmap clickArrow = (DrawBitmap) Area.GetDrawObj("clickedArrow");
DrawRectangle lineGroupClickLeft = (DrawRectangle)Area.GetDrawObj("line2GroupClickLeft");
int width = (int)lineGroupClickLeft.Width+20;
clickArrow.Move(0,3000);

DrawBitmap doubleClickedArrow = (DrawBitmap) Area.GetDrawObj("doubleClickedArrow");
Point point = new Point((int)line1GroupClick.HorizontalPosition,(int)line1GroupClick.VerticalPosition);

doubleClickedArrow.Move(point.X-(int)doubleClickedArrow.HorizontalPosition-width,point.Y-(int)doubleClickedArrow.VerticalPosition);

SelectNo = 2;


string[] tStringArray = (Area.Variable[1]).Split('/');
CommonFunction.OpenFaceplate(tStringArray[0]);

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void line3GroupClickRight_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle line1GroupClick = (DrawRectangle)dynArgs.sender; 




SelectNo = 3;
	this.MoveArrow(line1GroupClick,2);
this.SelectLines();

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynDblClick 
public void line3GroupClickRight_OnDynDblClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle line1GroupClick = (DrawRectangle)dynArgs.sender; 
   //doubleClickedArrow
DrawBitmap clickArrow = (DrawBitmap) Area.GetDrawObj("clickedArrow");
DrawRectangle lineGroupClickLeft = (DrawRectangle)Area.GetDrawObj("line3GroupClickLeft");
int width = (int)lineGroupClickLeft.Width+20;
clickArrow.Move(0,3000);

DrawBitmap doubleClickedArrow = (DrawBitmap) Area.GetDrawObj("doubleClickedArrow");
Point point = new Point((int)line1GroupClick.HorizontalPosition,(int)line1GroupClick.VerticalPosition);

doubleClickedArrow.Move(point.X-(int)doubleClickedArrow.HorizontalPosition-width,point.Y-(int)doubleClickedArrow.VerticalPosition);

SelectNo = 3;


string[] tStringArray = (Area.Variable[2]).Split('/');
CommonFunction.OpenFaceplate(tStringArray[0]);
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void line4GroupClickRight_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle line1GroupClick = (DrawRectangle)dynArgs.sender; 




SelectNo = 4;
	this.MoveArrow(line1GroupClick,2);

this.SelectLines();
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynDblClick 
public void line4GroupClickRight_OnDynDblClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle line1GroupClick = (DrawRectangle)dynArgs.sender; 
   //doubleClickedArrow
DrawBitmap clickArrow = (DrawBitmap) Area.GetDrawObj("clickedArrow");
DrawRectangle lineGroupClickLeft = (DrawRectangle)Area.GetDrawObj("line4GroupClickLeft");
int width = (int)lineGroupClickLeft.Width+20;
clickArrow.Move(0,3000);

DrawBitmap doubleClickedArrow = (DrawBitmap) Area.GetDrawObj("doubleClickedArrow");
Point point = new Point((int)line1GroupClick.HorizontalPosition,(int)line1GroupClick.VerticalPosition);

doubleClickedArrow.Move(point.X-(int)doubleClickedArrow.HorizontalPosition-width,point.Y-(int)doubleClickedArrow.VerticalPosition);
SelectNo = 4;


string[] tStringArray = (Area.Variable[3]).Split('/');
CommonFunction.OpenFaceplate(tStringArray[0]);

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void line5GroupClickRight_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle line1GroupClick = (DrawRectangle)dynArgs.sender; 



SelectNo = 5;
	this.MoveArrow(line1GroupClick,2);
this.SelectLines();
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynDblClick 
public void line5GroupClickRight_OnDynDblClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle line1GroupClick = (DrawRectangle)dynArgs.sender; 
   //doubleClickedArrow
DrawBitmap clickArrow = (DrawBitmap) Area.GetDrawObj("clickedArrow");
DrawRectangle lineGroupClickLeft = (DrawRectangle)Area.GetDrawObj("line5GroupClickLeft");
int width = (int)lineGroupClickLeft.Width+20;
clickArrow.Move(0,3000);

DrawBitmap doubleClickedArrow = (DrawBitmap) Area.GetDrawObj("doubleClickedArrow");
Point point = new Point((int)line1GroupClick.HorizontalPosition,(int)line1GroupClick.VerticalPosition);

doubleClickedArrow.Move(point.X-(int)doubleClickedArrow.HorizontalPosition-width,point.Y-(int)doubleClickedArrow.VerticalPosition);

SelectNo = 5;
string[] tStringArray = (Area.Variable[4]).Split('/');
CommonFunction.OpenFaceplate(tStringArray[0]);
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void line6GroupClickRight_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle line1GroupClick = (DrawRectangle)dynArgs.sender; 



SelectNo = 6;
	this.MoveArrow(line1GroupClick,2);

this.SelectLines();
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynDblClick 
public void line6GroupClickRight_OnDynDblClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle line1GroupClick = (DrawRectangle)dynArgs.sender; 
   //doubleClickedArrow
DrawBitmap clickArrow = (DrawBitmap) Area.GetDrawObj("clickedArrow");
DrawRectangle lineGroupClickLeft = (DrawRectangle)Area.GetDrawObj("line6GroupClickLeft");
int width = (int)lineGroupClickLeft.Width+20;
clickArrow.Move(0,3000);

DrawBitmap doubleClickedArrow = (DrawBitmap) Area.GetDrawObj("doubleClickedArrow");
Point point = new Point((int)line1GroupClick.HorizontalPosition,(int)line1GroupClick.VerticalPosition);

doubleClickedArrow.Move(point.X-(int)doubleClickedArrow.HorizontalPosition-width,point.Y-(int)doubleClickedArrow.VerticalPosition);

SelectNo = 6;
string[] tStringArray = (Area.Variable[5]).Split('/');
CommonFunction.OpenFaceplate(tStringArray[0]);
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void line7GroupClickLeft_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle line1GroupClick = (DrawRectangle)dynArgs.sender; 

SelectNo = 7;
	this.MoveArrow(line1GroupClick,1);
this.SelectLines();


    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynDblClick 
public void line7GroupClickLeft_OnDynDblClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle line1GroupClick = (DrawRectangle)dynArgs.sender; 
   //doubleClickedArrow
DrawBitmap clickArrow = (DrawBitmap) Area.GetDrawObj("clickedArrow");
clickArrow.Move(0,3000);

DrawBitmap doubleClickedArrow = (DrawBitmap) Area.GetDrawObj("doubleClickedArrow");
Point point = new Point((int)line1GroupClick.HorizontalPosition,(int)line1GroupClick.VerticalPosition);

doubleClickedArrow.Move(point.X-(int)doubleClickedArrow.HorizontalPosition-20,point.Y-(int)doubleClickedArrow.VerticalPosition);
SelectNo = 7;
string[] varStr = new string[]{Area.Variable[6],"6","0"};
CommonFunction.OpenDataEntryInput("../Picture/subTrend.grf",varStr,new Point(200,200));
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void line7GroupClickRight_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle line1GroupClick = (DrawRectangle)dynArgs.sender; 


SelectNo = 7;
	this.MoveArrow(line1GroupClick,2);
this.SelectLines();

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynDblClick 
public void line7GroupClickRight_OnDynDblClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle line1GroupClick = (DrawRectangle)dynArgs.sender; 
   //doubleClickedArrow
DrawBitmap clickArrow = (DrawBitmap) Area.GetDrawObj("clickedArrow");
DrawRectangle lineGroupClickLeft = (DrawRectangle)Area.GetDrawObj("line7GroupClickLeft");
int width = (int)lineGroupClickLeft.Width+20;
clickArrow.Move(0,3000);

DrawBitmap doubleClickedArrow = (DrawBitmap) Area.GetDrawObj("doubleClickedArrow");
Point point = new Point((int)line1GroupClick.HorizontalPosition,(int)line1GroupClick.VerticalPosition);

doubleClickedArrow.Move(point.X-(int)doubleClickedArrow.HorizontalPosition-width,point.Y-(int)doubleClickedArrow.VerticalPosition);

SelectNo = 7;

string[] tStringArray = (Area.Variable[6]).Split('/');
CommonFunction.OpenFaceplate(tStringArray[0]);
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void line8GroupClickLeft_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle line1GroupClick = (DrawRectangle)dynArgs.sender;


SelectNo = 8;

	this.MoveArrow(line1GroupClick,1);
this.SelectLines();
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynDblClick 
public void line8GroupClickLeft_OnDynDblClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle line1GroupClick = (DrawRectangle)dynArgs.sender; 
   //doubleClickedArrow
DrawBitmap clickArrow = (DrawBitmap) Area.GetDrawObj("clickedArrow");
clickArrow.Move(0,3000);

DrawBitmap doubleClickedArrow = (DrawBitmap) Area.GetDrawObj("doubleClickedArrow");
Point point = new Point((int)line1GroupClick.HorizontalPosition,(int)line1GroupClick.VerticalPosition);

doubleClickedArrow.Move(point.X-(int)doubleClickedArrow.HorizontalPosition-20,point.Y-(int)doubleClickedArrow.VerticalPosition);
SelectNo = 8;
string[] varStr = new string[]{Area.Variable[7],"7","0"};
CommonFunction.OpenDataEntryInput("../Picture/subTrend.grf",varStr,new Point(200,200));
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void line8GroupClickRight_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle line1GroupClick = (DrawRectangle)dynArgs.sender; 





SelectNo = 8;
	this.MoveArrow(line1GroupClick,2);
this.SelectLines();
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynDblClick 
public void line8GroupClickRight_OnDynDblClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle line1GroupClick = (DrawRectangle)dynArgs.sender; 
   //doubleClickedArrow
DrawBitmap clickArrow = (DrawBitmap) Area.GetDrawObj("clickedArrow");
DrawRectangle lineGroupClickLeft = (DrawRectangle)Area.GetDrawObj("line8GroupClickLeft");
int width = (int)lineGroupClickLeft.Width+20;
clickArrow.Move(0,3000);

DrawBitmap doubleClickedArrow = (DrawBitmap) Area.GetDrawObj("doubleClickedArrow");
Point point = new Point((int)line1GroupClick.HorizontalPosition,(int)line1GroupClick.VerticalPosition);

doubleClickedArrow.Move(point.X-(int)doubleClickedArrow.HorizontalPosition-width,point.Y-(int)doubleClickedArrow.VerticalPosition);
SelectNo = 8;
string[] tStringArray = (Area.Variable[7]).Split('/');
CommonFunction.OpenFaceplate(tStringArray[0]);
    return; 
}
//Do not remove or update this comment
//Event Delegate:ScrollEventHandler 
//Event Handler:Scroll 
private DateTime dateTime;
private bool isDateTime = false;
public void HScrollBar1_Scroll(Object sender, ScrollEventArgs e)
{
   HScrollBar HScrollBar1 = (HScrollBar)sender; 
DvChart dv = (DvChart)dArea.GetControlObj("TrendControl");

int aaa = HScrollBar1.Maximum - HScrollBar1.Value;
dv.isMove = false;
DateTime dt = DateTime.Now;

if(  (HScrollBar1.Value + dv.HLargeChange+3) >= HScrollBar1.Maximum ){
	PauseOrNot = false;
	dv.TrendStart();
	dv.HisTrend = true;
	dv.isMove = false;
	dv.LoadTrendDateFromDateSource();
	DrawText state = (DrawText)dArea.GetDrawObj("statusGroup.trendStatus");
	isDateTime = false;
	state.Caption = "Resume.";
}
else
{
	PauseOrNot = true;
	dv.HisTrend = true;
	dv.isMove = false;
	dv.TrendPause();
	DrawText state = (DrawText)dArea.GetDrawObj("statusGroup.trendStatus");
	dv.GetCurrentTimeString(dt.AddSeconds(-(aaa*dv._nInterval/1000)));
	dateTime = dt.AddSeconds(-(aaa*dv._nInterval/1000+60));
	isDateTime = true;
	state.Caption = "Stop." + -(aaa*dv._nInterval/1000) ;
}

dv.isMove = false;

dv.SetSelectTime(-(aaa*dv._nInterval/1000 +130));



    return; 
}
//Do not remove or update this comment
//Event Delegate:ScrollEventHandler 
//Event Handler:Scroll 
string aaa = "";
public void VScrollBar1_Scroll(Object sender, ScrollEventArgs e)
{
   VScrollBar VScrollBar1 = (VScrollBar)sender; 



DvChart dv = (DvChart)dArea.GetControlObj("TrendControl");
//set LimitAverage
double lLimit = dv.DataLimits[SelectNo-1,1];
double uLimit = dv.DataLimits[SelectNo-1,0];

double[] perent = GetPercentValue(VScrollBar1.Value,ZoomDateLevel);
Percent = new string[2]{perent[0].ToString("0.00"),perent[1].ToString("0.00")};
this.SetPercent(dArea);

switch(ZoomDateLevel)
{
	case 1: dv.ModifyPointPosition(5,VScrollBar1.Value);break;
	case 2: dv.ModifyPointPosition(10,VScrollBar1.Value);break;
	case 4: dv.ModifyPointPosition(25,VScrollBar1.Value);break;
	case 8: dv.ModifyPointPosition(50,VScrollBar1.Value);break;
}

//Set Limits Array
for( int i=0;i<8;i++ )
{
double tlLimit = dv.DataLimits[i,1];
double tuLimit = dv.DataLimits[i,0];
double[] limitAverage1 = ScrollFunction(tlLimit,tuLimit,VScrollBar1.Value,ZoomDateLevel);
LinesLimit[i,0] = limitAverage1[0].ToString("0.00");
LinesLimit[i,1] = limitAverage1[5].ToString("0.00");
}
this.SetLinesLimitsGroup(dArea);




double[] limitAverage = ScrollFunction(lLimit,uLimit,VScrollBar1.Value,ZoomDateLevel);

SetVScrollBar(ZoomDateLevel,dArea);

//limitAverageGroup[DrawGroup]
DrawText limitvalue1 = (DrawText)dArea.GetDrawObj("limitAverageGroup.limitValue1");
DrawText limitvalue2 = (DrawText)dArea.GetDrawObj("limitAverageGroup.limitValue2");
DrawText limitvalue3 = (DrawText)dArea.GetDrawObj("limitAverageGroup.limitValue3");
DrawText limitvalue4 = (DrawText)dArea.GetDrawObj("limitAverageGroup.limitValue4");
DrawText limitvalue5 = (DrawText)dArea.GetDrawObj("limitAverageGroup.limitValue5");
DrawText limitvalue6 = (DrawText)dArea.GetDrawObj("limitAverageGroup.limitValue6");

limitvalue1.Caption = limitAverage[0].ToString("0.000");
limitvalue2.Caption = limitAverage[1].ToString("0.000");
limitvalue3.Caption = limitAverage[2].ToString("0.000");
limitvalue4.Caption = limitAverage[3].ToString("0.000");
limitvalue5.Caption = limitAverage[4].ToString("0.000");
limitvalue6.Caption = limitAverage[5].ToString("0.000");

    return; 
}

}
