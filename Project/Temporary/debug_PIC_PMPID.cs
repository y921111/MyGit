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
public class PIC_PMPID:IDynCodeAttachDetach
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
   strEventName = "OnDynClick";
_EventHandler= (EventHandler)PIC_PMPID_OnDynClick;
CodeDomCommon.AttachAreaEventHandler(area,strEventName,_EventHandler);
strObjectName = "PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PV_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PV_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TagName";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)TagName_OnDynInitialize;
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
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PIC_PMPID_OnDynClick;
CodeDomCommon.DetachAreaEventHandler(area,strEventName,_EventHandler);
strObjectName = "PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PV_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PV_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TagName";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)TagName_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);

    return;
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void PIC_PMPID_OnDynClick(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 

   object obj = Area.Parent;
   
   Type type = obj.GetType();

	if ( type.Name != "Picture" )
	{
		DrawArea pic = (DrawArea)(Area.Parent);
		DrawArea D1 = (DrawArea)pic.GetDrawObj("ChangeZone");
                D1.Visible = true;

                D1.Variable[0] = Area.Variable[0];

	}
	else
	{
		DrawArea pic = (DrawArea)(Area.Parent);
		DrawArea D1 = (DrawArea)pic.GetDrawObj("ChangeZone");
		D1.Visible = false;
	}

/*    DrawArea MainArea = (DrawArea)(Area.Parent);
    //DrawArea ChangeZone = (DrawArea)MainArea.GetDrawObj("ChangeZone");
    int nLeft = 0;
    int nTop = 825;
    int nWidth = 0;
    int nHeight = 0;
   // String fp = CommonFunction.GetTagFaceplate(Area.Variable[0]);
   // if(fp != "" || fp != null)
      // {
	   CommonFunction.AddRefDa(MainArea, "CZ_PMPID.grf", "CZ", nTop, nLeft, nWidth, nHeight);
       // }
    MainArea.Variable[0] = Area.Variable[0];
*/
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void PV_OnDynInitialize(Object sender, EventArgs e)
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
public void PV_OnDynAnimation(Object sender, EventArgs e)
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
public void TagName_OnDynInitialize(Object sender, EventArgs e)
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

}
