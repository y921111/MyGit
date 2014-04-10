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
public class PIC_TDC3000首页:IDynCodeAttachDetach
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
   strObjectName = "Rect2";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect2_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect1";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect1_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea1.Rect1";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea1_Rect1_OnDynClick;
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
strObjectName = "Rect2";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect2_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect1";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect1_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea1.Rect1";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea1_Rect1_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);

    return;
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void Rect2_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect2 = (DrawRectangle)dynArgs.sender; 
   
    DrawArea DA1 = (DrawArea)Area.GetDrawObj("DrawArea3");
    DA1.Visible = true;
    
    DrawArea A1 = (DrawArea)Area.GetDrawObj("DrawArea1");
if(DA1.Visible == true)
    {A1.Visible = false;}
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
   
    DrawArea DA = (DrawArea)Area.GetDrawObj("DrawArea1");
    DA.Visible = true;
    
    DrawArea A = (DrawArea)Area.GetDrawObj("DrawArea3");
if(DA.Visible == true)
    {A.Visible = false;}
   
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void DrawArea1_Rect1_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect1 = (DrawRectangle)dynArgs.sender; 
   
    Area.Visible = false;

    return; 
}

}
