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
public class PIC_projectval:IDynCodeAttachDetach
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
   strObjectName = "Rect3";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect3_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "INPOINT";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)INPOINT_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PENTER";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PENTER_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "INDISP";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)INDISP_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "NOTCOMP";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)NOTCOMP_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "NOTEMUL";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)NOTEMUL_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "UNITALMSUMM";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)UNITALMSUMM_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "UNITTREND";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)UNITTREND_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DETAIL";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DETAIL_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "GROUP";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)GROUP_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SCHEM";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)SCHEM_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect1";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect1_OnDynClick;
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
strObjectName = "Rect3";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect3_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "INPOINT";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)INPOINT_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PENTER";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PENTER_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "INDISP";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)INDISP_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "NOTCOMP";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)NOTCOMP_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "NOTEMUL";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)NOTEMUL_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "UNITALMSUMM";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)UNITALMSUMM_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "UNITTREND";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)UNITTREND_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DETAIL";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DETAIL_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "GROUP";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)GROUP_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SCHEM";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)SCHEM_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect1";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect1_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);

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
   
	int nLeft = 0;
	int nTop = 0;
	string[] strVariable = new string[1];
	strVariable[0] = "LIC103";
	CommonFunction.OpenPicture("TDC_ChangeZone.grf", nTop, nLeft, strVariable);
	CommonFunction.OpenPicture("TDC_CZ_PMPID.grf", nTop, nLeft, strVariable);
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void INPOINT_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText INPOINT = (DrawText)dynArgs.sender; 
   
    CommonFunction._ProjectRelated.Var[1] = "MODE ERROR";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void PENTER_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PENTER = (DrawText)dynArgs.sender; 
   
    CommonFunction._ProjectRelated.Var[0] = "PENTER";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void INDISP_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText INDISP = (DrawText)dynArgs.sender; 
   
    CommonFunction._ProjectRelated.Var[0] = "8";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void NOTCOMP_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText NOTCOMP = (DrawText)dynArgs.sender; 
   
    CommonFunction._ProjectRelated.Var[0] = "9";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void NOTEMUL_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText UNITALMSUMM = (DrawText)dynArgs.sender; 
   
    CommonFunction._ProjectRelated.Var[0] = "5";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void UNITALMSUMM_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText UNITALMSUMM = (DrawText)dynArgs.sender; 
   
    CommonFunction._ProjectRelated.Var[0] = "UNITALMSUMM";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void UNITTREND_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText UNITTREND = (DrawText)dynArgs.sender; 
   
    CommonFunction._ProjectRelated.Var[0] = "UNITTREND";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void DETAIL_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText DETAIL = (DrawText)dynArgs.sender; 
   
    CommonFunction._ProjectRelated.Var[0] = "DETAIL";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void GROUP_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText GROUP = (DrawText)dynArgs.sender; 
   
    CommonFunction._ProjectRelated.Var[0] = "GROUP";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void SCHEM_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText SCHEM = (DrawText)dynArgs.sender; 
   
    CommonFunction._ProjectRelated.Var[0] = "SCHEM";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void Rect1_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect1 = (DrawRectangle)dynArgs.sender; 
   
    CommonFunction._ProjectRelated.Var[0] = "11";
    CommonFunction._ProjectRelated.Var[1] = "TDC3000_Top";

    return; 
}

}
