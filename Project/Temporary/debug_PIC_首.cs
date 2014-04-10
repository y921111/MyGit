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
public class PIC_首:IDynCodeAttachDetach
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
   strObjectName = "CZ_AI";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CZ_AI_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_AI.Text1";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CZ_AI_Text1_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_AI.Text1";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_AI_Text1_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_AI.Text1";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CZ_AI_Text1_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_AI.Rect2";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_AI_Rect2_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_AI.Rect1";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_AI_Rect1_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea5";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea5_OnDynClick;
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
strObjectName = "CZ_PMPID";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_PMPID_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CZ_PMPID_PV_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CZ_PMPID_PV_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.TagName";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CZ_PMPID_TagName_OnDynInitialize;
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
strObjectName = "CZ_AI";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CZ_AI_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_AI.Text1";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CZ_AI_Text1_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_AI.Text1";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_AI_Text1_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_AI.Text1";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CZ_AI_Text1_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_AI.Rect2";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_AI_Rect2_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_AI.Rect1";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_AI_Rect1_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea5";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)DrawArea5_OnDynClick;
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
strObjectName = "CZ_PMPID";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CZ_PMPID_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CZ_PMPID_PV_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CZ_PMPID_PV_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CZ_PMPID.TagName";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CZ_PMPID_TagName_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);

    return;
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void CZ_AI_OnDynInitialize(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 
      
   Picture pic = (Picture)(Area.Parent);
   pic.FormBorderStyle = FormBorderStyle.None;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void CZ_AI_Text1_OnDynInitialize(Object sender, EventArgs e)	//TagName
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawText TagName = (DrawText)dynArgs.sender; 

        
	
	return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void CZ_AI_Text1_OnDynClick(Object sender, EventArgs e)
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
//Event Handler:OnDynAnimation 
public void CZ_AI_Text1_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText TagName = (DrawText)dynArgs.sender; 
   
    string tagName = Area.Variable[0].ToUpper();

//        MessageBox.Show(Area.Variable[0].ToString());

	if(tagName != "")
		TagName.Caption = tagName;
	else
		TagName.Caption = "******";	

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void CZ_AI_Rect2_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect1 = (DrawRectangle)dynArgs.sender; 
   
    Area.Visible = false;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void CZ_AI_Rect1_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect1 = (DrawRectangle)dynArgs.sender; 
   
    Area.Visible = false;

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

/*   object obj = Area.Parent;
   
   Type type = obj.GetType();

	if ( type.Name != "Picture" )
	{
		DrawArea pic = (DrawArea)(Area.Parent);
		DrawArea D1 = (DrawArea)pic.GetDrawObj("CZ_PMPID");
                D1.Visible = true;

                D1.Variable[0] = Area.Variable[0];

	}
	else
	{
		DrawArea pic = (DrawArea)(Area.Parent);
		DrawArea D1 = (DrawArea)pic.GetDrawObj("CZ_PMPID");
		D1.Visible = false;
	}
*/
    int nTop = 0; 
    int nLeft = 0; 
    int nWidth = 0;
    int nHeight = 0;
    DrawArea pic = (DrawArea)(Area.Parent);
    DrawArea ChangeZone = (DrawArea)pic.GetDrawObj("ChangeZone");
    String fp = CommonFunction.GetTagFaceplate(Area.Variable[0]);
    bool add = CommonFunction.AddRefDa(pic, "CZ_PMPID.grf", "ChangeZone", nTop, nLeft, nWidth, nHeight);
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void DrawArea5_PV_OnDynInitialize(Object sender, EventArgs e)
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
public void DrawArea5_PV_OnDynAnimation(Object sender, EventArgs e)
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
public void DrawArea5_TagName_OnDynInitialize(Object sender, EventArgs e)
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
public void CZ_PMPID_OnDynClick(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 

/*   object obj = Area.Parent;
   
   Type type = obj.GetType();

	if ( type.Name != "Picture" )
	{
		DrawArea pic = (DrawArea)(Area.Parent);
		DrawArea D1 = (DrawArea)pic.GetDrawObj("CZ_PMPID");
                D1.Visible = true;

                D1.Variable[0] = Area.Variable[0];

	}
	else
	{
		DrawArea pic = (DrawArea)(Area.Parent);
		DrawArea D1 = (DrawArea)pic.GetDrawObj("CZ_PMPID");
		D1.Visible = false;
	}
*/
    int nTop = 825; 
    int nLeft = 0; 
    int nWidth = 0;
    int nHeight = 0;
    DrawArea pic = (DrawArea)(Area.Parent);
    DrawArea ChangeZone = (DrawArea)pic.GetDrawObj("ChangeZone");
    String fp = CommonFunction.GetTagFaceplate(Area.Variable[0]);
    bool add = CommonFunction.AddRefDa(pic, "CZ_PMPID.grf", "ChangeZone", nTop, nLeft, nWidth, nHeight);
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void CZ_PMPID_PV_OnDynInitialize(Object sender, EventArgs e)
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
public void CZ_PMPID_PV_OnDynAnimation(Object sender, EventArgs e)
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
public void CZ_PMPID_TagName_OnDynInitialize(Object sender, EventArgs e)
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
