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
public class PIC_TDC3000-Top:IDynCodeAttachDetach
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
   strObjectName = "Text2";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Text2_OnDynAnimation;
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
strObjectName = "Text2";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Text2_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);

    return;
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void Text2_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText Text2 = (DrawText)dynArgs.sender; 
   
    DateTime now = DateTime.Now;
    Text2.Caption = now.ToString("yy") + " " + now.Month.ToString() +" " + now.Day.ToString() + " " + now.ToString("HH") + ":" +     now.ToString("mm");

    return; 
}

}
c:\Documents and Settings\HDD\Local Settings\Temp\gxhygrcx.0.cs(21,25) : error CS1514: 应输入 {
c:\Documents and Settings\HDD\Local Settings\Temp\gxhygrcx.0.cs(21,25) : error CS1519: 类、结构或接口成员声明中的标记“-”无效
c:\Documents and Settings\HDD\Local Settings\Temp\gxhygrcx.0.cs(21,29) : error CS1519: 类、结构或接口成员声明中的标记“:”无效
c:\Documents and Settings\HDD\Local Settings\Temp\gxhygrcx.0.cs(22,1) : error CS1519: 类、结构或接口成员声明中的标记“{”无效
