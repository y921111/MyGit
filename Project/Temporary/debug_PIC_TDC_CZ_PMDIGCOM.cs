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
public class PIC_TDC_CZ_PMDIGCOM:IDynCodeAttachDetach
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
_EventHandler= (EventHandler)PIC_TDC_CZ_PMDIGCOM_OnDynInitialize;
CodeDomCommon.AttachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PIC_TDC_CZ_PMDIGCOM_OnDynAnimation;
CodeDomCommon.AttachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)PIC_TDC_CZ_PMDIGCOM_KeyUp;
CodeDomCommon.AttachAreaEventHandler(area,strEventName,_KeyEventHandler);
strObjectName = "Rect_Tag";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect_Tag_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect_ON";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect_ON_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect_OFF";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect_OFF_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect_SPACE";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect_SPACE_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TagComment";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TagComment_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TagName_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Close";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Close_OnDynClick;
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
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PIC_TDC_CZ_PMDIGCOM_OnDynInitialize;
CodeDomCommon.DetachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PIC_TDC_CZ_PMDIGCOM_OnDynAnimation;
CodeDomCommon.DetachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)PIC_TDC_CZ_PMDIGCOM_KeyUp;
CodeDomCommon.DetachAreaEventHandler(area,strEventName,_KeyEventHandler);
strObjectName = "Rect_Tag";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect_Tag_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect_ON";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect_ON_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect_OFF";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect_OFF_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect_SPACE";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect_SPACE_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TagComment";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TagComment_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TagName_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Close";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Close_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);

    return;
}

// =======================================================================
//
// 文件名：CZ_PMDIGCOM.grf（面板）
// 【调用时传入参数】
//		Area.Variable[0] - Tagname
//		Area.Variable[1] - 选中的标志位
//
// 【更新时间】 
//		2013.03.27
// =======================================================================

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void PIC_TDC_CZ_PMDIGCOM_OnDynInitialize(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender;

	Area.Variable[0] = Area.Variable[0].ToUpper();

////////////////////////////////////////////////////////////////////////////////传值
////////////////////////////////////////////////////////////////////////////////传值
	Picture pic = CommonFunction.GetThisPicture(Area);
	if(pic != null)
	{

		if(Area.BReference)//图素
		{
                      Area.Enabled = true;

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

if(Area.BReference)
	{
		Area.Enabled = true;
        }


////////////////////////////////////////////////////////////////////////////////处理变色
////////////////////////////////////////////////////////////////////////////////处理变色

	DrawRectangle Rect_ON = (DrawRectangle)Area.GetDrawObj("Rect_ON");
	DrawRectangle Rect_OFF = (DrawRectangle)Area.GetDrawObj("Rect_OFF");
	DrawRectangle Rect_SPACE = (DrawRectangle)Area.GetDrawObj("Rect_SPACE");
	DrawRectangle Close = (DrawRectangle)Area.GetDrawObj("Close");

	DrawText ON = (DrawText)Area.GetDrawObj("ON");
	DrawText OFF = (DrawText)Area.GetDrawObj("OFF");
	DrawText SPACE = (DrawText)Area.GetDrawObj("SPACE");
	DrawText CLR = (DrawText)Area.GetDrawObj("CLR");

        ON.ForegroundColor = Color.Lime;
        OFF.ForegroundColor = Color.Lime;
        SPACE.ForegroundColor = Color.Lime;
        CLR.ForegroundColor = Color.Lime;
        Rect_ON.EdgeColor = Color.Lime;
        Rect_OFF.EdgeColor = Color.Lime;
        Rect_SPACE.EdgeColor = Color.Lime;
        Close.EdgeColor = Color.Lime;

        CommonFunction._ProjectRelated.Var[0] = "";

	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;
	string tagName = Area.Variable[0] + "/OP";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
        Area.Variable[1] = "0";
	    if(ret)
	    {

		if(nValue == 1)

		   {
                      ON.ForegroundColor = Color.Cyan;
                      Rect_ON.EdgeColor = Color.Cyan;
                    }	
		else if(nValue == 0)

		   {
                      OFF.ForegroundColor = Color.Cyan;
                      Rect_OFF.EdgeColor = Color.Cyan;
                    }
                else if(nValue == 0)

		   {
                      SPACE.ForegroundColor = Color.Lime;
                      Rect_SPACE.EdgeColor = Color.Lime;
                    }
	    }    

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void PIC_TDC_CZ_PMDIGCOM_OnDynAnimation(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 
   
	DrawRectangle Rect_ON = (DrawRectangle)Area.GetDrawObj("Rect_ON");
	DrawRectangle Rect_OFF = (DrawRectangle)Area.GetDrawObj("Rect_OFF");
	DrawRectangle Rect_SPACE = (DrawRectangle)Area.GetDrawObj("Rect_SPACE");
	DrawRectangle Close = (DrawRectangle)Area.GetDrawObj("Close");

	DrawText ON = (DrawText)Area.GetDrawObj("ON");
	DrawText OFF = (DrawText)Area.GetDrawObj("OFF");
	DrawText SPACE = (DrawText)Area.GetDrawObj("SPACE");
	DrawText CLR = (DrawText)Area.GetDrawObj("CLR");

        ON.ForegroundColor = Color.Lime;
        OFF.ForegroundColor = Color.Lime;
        SPACE.ForegroundColor = Color.Lime;
        CLR.ForegroundColor = Color.Lime;
        Rect_ON.EdgeColor = Color.Lime;
        Rect_OFF.EdgeColor = Color.Lime;
        Rect_SPACE.EdgeColor = Color.Lime;
        Close.EdgeColor = Color.Lime;

	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;
	string tagName = Area.Variable[0] + "/OP";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);

   if(ret)
   {		
     if(dbValue == 1)
	 {
			 ON.ForegroundColor = Color.Cyan;
                         Rect_ON.EdgeColor = Color.Cyan;

		 if(Area.Variable[1] == "2")
		 {
			 OFF.ForegroundColor = Color.White;
                         Rect_OFF.EdgeColor = Color.White;
                         CommonFunction._ProjectRelated.Var[0] = "PENTER";
                         CommonFunction._ProjectRelated.Var[1] = "";
		 }
		 else if(Area.Variable[1] == "3")
		 {
			 SPACE.ForegroundColor = Color.White;
                         Rect_SPACE.EdgeColor = Color.White;
                         CommonFunction._ProjectRelated.Var[0] = "PENTER";
                         CommonFunction._ProjectRelated.Var[1] = "";
		 }

	 }
	 if(dbValue == 0)
	 {
			 OFF.ForegroundColor = Color.Cyan;
                         Rect_OFF.EdgeColor = Color.Cyan;

		 if(Area.Variable[1] == "1")
		 {
			 ON.ForegroundColor = Color.White;
                         Rect_ON.EdgeColor = Color.White;
                         CommonFunction._ProjectRelated.Var[0] = "PENTER";
                         CommonFunction._ProjectRelated.Var[1] = "";
		 }
		 else if(Area.Variable[1] == "3")
		 {
			 SPACE.ForegroundColor = Color.White;
                         Rect_SPACE.EdgeColor = Color.White;
                         CommonFunction._ProjectRelated.Var[0] = "PENTER";
                         CommonFunction._ProjectRelated.Var[1] = "";
		 }
	 }
	 if(dbValue == 0)
	 {
			 SPACE.ForegroundColor = Color.Lime;
                         Rect_SPACE.EdgeColor = Color.Lime;

		 if(Area.Variable[1] == "1")
		 {
			 ON.ForegroundColor = Color.White;
                         Rect_ON.EdgeColor = Color.White;
                         CommonFunction._ProjectRelated.Var[0] = "PENTER";
                         CommonFunction._ProjectRelated.Var[1] = "";
		 }
		 else if(Area.Variable[1] == "2")
		 {
			 OFF.ForegroundColor = Color.White;
                         Rect_OFF.EdgeColor = Color.White;
                         CommonFunction._ProjectRelated.Var[0] = "PENTER";
                         CommonFunction._ProjectRelated.Var[1] = "";
		 }
	 }
      }

   return; 
}

//Do not remove or update this comment
//Event Delegate:KeyEventHandler 
//Event Handler:KeyUp 
public void PIC_TDC_CZ_PMDIGCOM_KeyUp(Object sender, KeyEventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   string tagName = Area.Variable[0] + "/OP";

     double dbValue = 0;
     int nValue = 0;
     bool bValue = false;
     int nDataType = 0;

     string OP = Area.Variable[0] + "/OP";
     bool ret = CommonFunction.GetValueWithType(OP,ref dbValue,ref nValue,ref bValue,ref nDataType);
     
     if(ret)
      
           {
		    switch(e.KeyData)
                      {    

                         case Keys.Enter:

                               if(Area.Variable[1] == "1")
	                        {		
                                   CommonFunction.DSI_SetValue(tagName, (double)(1));
	                        }
	                       if(Area.Variable[1] == "2")
	                        {
                                   CommonFunction.DSI_SetValue(tagName, (double)(0));
	                         }
	                       if(Area.Variable[1] == "3")
	                        {
                                   CommonFunction.DSI_SetValue(tagName, (double)(0));
	                        }

                                CommonFunction._ProjectRelated.Var[0] = "NULL";
                                CommonFunction._ProjectRelated.Var[1] = "NULL";

                          Area.Variable[1] = "0";

	                 break;
                      } 
         }
         
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void Rect_Tag_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect_Tag = (DrawRectangle)dynArgs.sender; 
   
	int nLeft = 0;
	int nTop = 0;
	string[] strVariable = new string[1];
	strVariable[0] = Area.Variable[0];
 	CommonFunction.OpenDetail(Area.Variable[0]);

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void Rect_ON_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect_ON = (DrawRectangle)dynArgs.sender; 
   
    DrawArea A = (DrawArea)(Area.Parent.Parent);
             A.RunAnimation();

    Area.Variable[1] = "1";

	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;
	string tagName = Area.Variable[0] + "/OP";

   if(CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType))
   {		
     if(dbValue == 1)
	 {
              Rect_ON.EdgeColor = Color.White;
	      DrawText ON = (DrawText)Area.GetDrawObj("ON");
   	      ON.ForegroundColor = Color.White;
          }
   }

    return; 
}



//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void Rect_OFF_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect_OFF = (DrawRectangle)dynArgs.sender; 
   
    DrawArea A = (DrawArea)(Area.Parent.Parent);
             A.RunAnimation();

    Area.Variable[1] = "2";

	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;
	string tagName = Area.Variable[0] + "/OP";

   if(CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType))
   {		
     if(dbValue == 0)
	 {
              Rect_OFF.EdgeColor = Color.White;
	      DrawText OFF = (DrawText)Area.GetDrawObj("OFF");
   	      OFF.ForegroundColor = Color.White;
          }
   }

    return; 
}



//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void Rect_SPACE_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect_SPACE = (DrawRectangle)dynArgs.sender; 
   
    DrawArea A = (DrawArea)(Area.Parent.Parent);
             A.RunAnimation();

    Area.Variable[1] = "3";

	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;
	string tagName = Area.Variable[0] + "/OP";

   if(CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType))
   {		
     if(dbValue == 0)
	 {
              Rect_SPACE.EdgeColor = Color.White;
	      DrawText SPACE = (DrawText)Area.GetDrawObj("SPACE");
   	      SPACE.ForegroundColor = Color.White;
          }
   }

    return; 
}


//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void TagComment_OnDynAnimation(Object sender, EventArgs e)
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
//Event Handler:OnDynAnimation 
public void TagName_OnDynAnimation(Object sender, EventArgs e)
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
public void Close_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle CLR = (DrawRectangle)dynArgs.sender; 
   
    DrawArea A = (DrawArea)(Area.Parent.Parent);
             A.RunAnimation();

    (Area.Parent).Visible = false;

    CommonFunction._ProjectRelated.Var[0] = "";
    CommonFunction._ProjectRelated.Var[1] = "";

    Area.Variable[1] = "0";

    return; 
}

}
