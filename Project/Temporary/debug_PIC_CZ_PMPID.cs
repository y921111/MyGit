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
public class PIC_CZ_PMPID:IDynCodeAttachDetach
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
_EventHandler= (EventHandler)PIC_CZ_PMPID_OnDynInitialize;
CodeDomCommon.AttachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PIC_CZ_PMPID_OnDynAnimation;
CodeDomCommon.AttachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "Disposed";
_EventHandler= (EventHandler)PIC_CZ_PMPID_Disposed;
CodeDomCommon.AttachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PIC_CZ_PMPID_OnDynClick;
CodeDomCommon.AttachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)PIC_CZ_PMPID_KeyUp;
CodeDomCommon.AttachAreaEventHandler(area,strEventName,_KeyEventHandler);
strObjectName = "Rect17";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect17_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect16";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect16_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect15";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect15_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect14";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect14_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Text_OP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Text_OP_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Text_SP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Text_SP_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Text_PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Text_PV_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PA_Rectangle";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PA_Rectangle_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect_PROG";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect_PROG_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect_MAN";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect_MAN_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect_AUTO";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect_AUTO_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect_CAS";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect_CAS_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)OP_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)OP_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)SP_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)SP_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PV_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PV_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TagComment";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TagComment_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVUnit";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVUnit_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TagName_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Close";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Close_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)TB_KeyUp;
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
_EventHandler= (EventHandler)PIC_CZ_PMPID_OnDynInitialize;
CodeDomCommon.DetachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PIC_CZ_PMPID_OnDynAnimation;
CodeDomCommon.DetachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "Disposed";
_EventHandler= (EventHandler)PIC_CZ_PMPID_Disposed;
CodeDomCommon.DetachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PIC_CZ_PMPID_OnDynClick;
CodeDomCommon.DetachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)PIC_CZ_PMPID_KeyUp;
CodeDomCommon.DetachAreaEventHandler(area,strEventName,_KeyEventHandler);
strObjectName = "Rect17";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect17_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect16";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect16_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect15";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect15_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect14";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect14_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Text_OP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Text_OP_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Text_SP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Text_SP_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Text_PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Text_PV_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PA_Rectangle";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PA_Rectangle_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect_PROG";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect_PROG_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect_MAN";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect_MAN_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect_AUTO";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect_AUTO_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect_CAS";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect_CAS_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)OP_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)OP_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)SP_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)SP_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PV_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PV_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TagComment";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TagComment_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVUnit";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVUnit_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TagName_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Close";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Close_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)TB_KeyUp;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);

    return;
}

// =======================================================================
//
// 文件名：CZ_PMPID.grf（面板）
// 【调用时传入参数】
//		Area.Variable[0] - Tagname
//		Area.Variable[1] - 选中的标志位
//
// 【更新时间】 
//		2012.12.26
// =======================================================================

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void PIC_CZ_PMPID_OnDynInitialize(Object sender, EventArgs e)
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
		      TextBox TB = (TextBox)Area.GetDrawObj("TB");

		        if(TB.CanFocus)
			{
				TB.Focus();
			}
			else
			{
				Area.Enabled = true;	//首先确保PVTB的容器Area的Enabled为True，否则TB.CanFocus=false；
				TB.Enabled = true;
				TB.Visible = false;
				TB.Focus();
			}

			//将顶级DrawArea的Variable[0]变量传递到图素级DrawArea：
			DrawArea MainArea = pic.GetDrawArea();
			Area.Variable[0] = MainArea.Variable[0];
//MessageBox.Show(Area.Variable[0].ToString());

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

	DrawText MAN = (DrawText)Area.GetDrawObj("MAN");
	DrawText AUTO = (DrawText)Area.GetDrawObj("AUTO");
	DrawText CAS = (DrawText)Area.GetDrawObj("CAS");
	DrawRectangle Rect_MAN = (DrawRectangle)Area.GetDrawObj("Rect_MAN");
	DrawRectangle Rect_AUTO = (DrawRectangle)Area.GetDrawObj("Rect_AUTO");
	DrawRectangle Rect_CAS = (DrawRectangle)Area.GetDrawObj("Rect_CAS");

	DrawText PTXST = (DrawText)Area.GetDrawObj("PTXST");
	DrawText ACTIVE = (DrawText)Area.GetDrawObj("ACTIVE");
        DrawRectangle PA_Rectangle = (DrawRectangle)Area.GetDrawObj("PA_Rectangle");

	DrawText PV = (DrawText)Area.GetDrawObj("PV");
	DrawText SP = (DrawText)Area.GetDrawObj("SP");
	DrawText OP = (DrawText)Area.GetDrawObj("OP");
	DrawText Text_PV = (DrawText)Area.GetDrawObj("Text_PV");
	DrawText Text_SP = (DrawText)Area.GetDrawObj("Text_SP");
	DrawText Text_OP = (DrawText)Area.GetDrawObj("Text_OP");

	MAN.ForegroundColor = Color.Lime;
	AUTO.ForegroundColor = Color.Lime;
	CAS.ForegroundColor = Color.Lime;
	Rect_MAN.EdgeColor = Color.Lime;
	Rect_AUTO.EdgeColor = Color.Lime;
	Rect_CAS.EdgeColor = Color.Lime;

        PTXST.ForegroundColor = Color.Lime;
        ACTIVE.ForegroundColor = Color.Lime;
        PA_Rectangle.EdgeColor = Color.Lime;

	PV.ForegroundColor = Color.Cyan;
	SP.ForegroundColor = Color.Cyan;
	OP.ForegroundColor = Color.Yellow;
	Text_PV.ForegroundColor = Color.Cyan;
	Text_SP.ForegroundColor = Color.Cyan;
	Text_OP.ForegroundColor = Color.Yellow;


        DrawArea picT = (DrawArea)(Area.Parent.Parent);
//        DrawArea Top = (DrawArea)picT.GetDrawObj("TDC3000_Top");
//        Top.Variable[3] = "";
    CommonFunction._ProjectRelated.Var[0] = "";


	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;
	string tagName = Area.Variable[0] + "/MODE";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
        Area.Variable[1] = "0";
	    if(ret)
	    {

		if(nValue == 1)

		   {
                      MAN.ForegroundColor = Color.Cyan;
                      Rect_MAN.EdgeColor = Color.Cyan;
                    }	
		else if(nValue == 2)

		   {
                      AUTO.ForegroundColor = Color.Cyan;
                      Rect_AUTO.EdgeColor = Color.Cyan;
                    }
                else if(nValue == 3)

		   {
                      CAS.ForegroundColor = Color.Cyan;
                      Rect_CAS.EdgeColor = Color.Cyan;
                    }
	    }    

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void PIC_CZ_PMPID_OnDynAnimation(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 
   
	DrawText MAN = (DrawText)Area.GetDrawObj("MAN");
	DrawText AUTO = (DrawText)Area.GetDrawObj("AUTO");
	DrawText CAS = (DrawText)Area.GetDrawObj("CAS");
	DrawRectangle Rect_MAN = (DrawRectangle)Area.GetDrawObj("Rect_MAN");
	DrawRectangle Rect_AUTO = (DrawRectangle)Area.GetDrawObj("Rect_AUTO");
	DrawRectangle Rect_CAS = (DrawRectangle)Area.GetDrawObj("Rect_CAS");

	DrawText PTXST = (DrawText)Area.GetDrawObj("PTXST");
	DrawText ACTIVE = (DrawText)Area.GetDrawObj("ACTIVE");
        DrawRectangle PA_Rectangle = (DrawRectangle)Area.GetDrawObj("PA_Rectangle");

	DrawText PV = (DrawText)Area.GetDrawObj("PV");
	DrawText SP = (DrawText)Area.GetDrawObj("SP");
	DrawText OP = (DrawText)Area.GetDrawObj("OP");
	DrawText Text_PV = (DrawText)Area.GetDrawObj("Text_PV");
	DrawText Text_SP = (DrawText)Area.GetDrawObj("Text_SP");
	DrawText Text_OP = (DrawText)Area.GetDrawObj("Text_OP");

	MAN.ForegroundColor = Color.Lime;
	AUTO.ForegroundColor = Color.Lime;
	CAS.ForegroundColor = Color.Lime;
	Rect_MAN.EdgeColor = Color.Lime;
	Rect_AUTO.EdgeColor = Color.Lime;
	Rect_CAS.EdgeColor = Color.Lime;

        PTXST.ForegroundColor = Color.Lime;
        ACTIVE.ForegroundColor = Color.Lime;
        PA_Rectangle.EdgeColor = Color.Lime;

	PV.ForegroundColor = Color.Cyan;
	SP.ForegroundColor = Color.Cyan;
	OP.ForegroundColor = Color.Yellow;
	Text_PV.ForegroundColor = Color.Cyan;
	Text_SP.ForegroundColor = Color.Cyan;
	Text_OP.ForegroundColor = Color.Yellow;

        DrawArea picT = (DrawArea)(Area.Parent.Parent);
//        DrawArea Top = (DrawArea)picT.GetDrawObj("TDC3000_Top");


	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;
	string tagName = Area.Variable[0] + "/MODE";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);

   if(ret)
   {		
     if(dbValue == 1)
	 {
			 MAN.ForegroundColor = Color.Cyan;
                         Rect_MAN.EdgeColor = Color.Cyan;

		 if(Area.Variable[1] == "2")
		 {
			 AUTO.ForegroundColor = Color.White;
                         Rect_AUTO.EdgeColor = Color.White;
                        // if(Top != null)
                        // {
                             CommonFunction._ProjectRelated.Var[0] = "PRESS ENTER TO EXECUTE";
                             CommonFunction._ProjectRelated.Var[1] = "";
                         //}
		 }
		 else if(Area.Variable[1] == "3")
		 {
			 CAS.ForegroundColor = Color.White;
                         Rect_CAS.EdgeColor = Color.White;
                        // if(Top != null)
                        // {
                             CommonFunction._ProjectRelated.Var[0] = "PRESS ENTER TO EXECUTE";
                             CommonFunction._ProjectRelated.Var[1] = "";
                       //  }
		 }

	 }
	 if(dbValue == 2)
	 {
			 AUTO.ForegroundColor = Color.Cyan;
                         Rect_AUTO.EdgeColor = Color.Cyan;

		 if(Area.Variable[1] == "1")
		 {
			 MAN.ForegroundColor = Color.White;
                         Rect_MAN.EdgeColor = Color.White;
                       //  if(Top != null)
                       //  {
                             CommonFunction._ProjectRelated.Var[0] = "PRESS ENTER TO EXECUTE";
                             CommonFunction._ProjectRelated.Var[1] = "";
                        // }
		 }
		 else if(Area.Variable[1] == "3")
		 {
			 CAS.ForegroundColor = Color.White;
                         Rect_CAS.EdgeColor = Color.White;
                       //  if(Top != null)
                       //  {
                             CommonFunction._ProjectRelated.Var[0] = "PRESS ENTER TO EXECUTE";
                             CommonFunction._ProjectRelated.Var[1] = "";
                       //  }
		 }
	 }
	 if(dbValue == 3)
	 {
			 CAS.ForegroundColor = Color.Cyan;
                         Rect_CAS.EdgeColor = Color.Cyan;

		 if(Area.Variable[1] == "1")
		 {
			 MAN.ForegroundColor = Color.White;
                         Rect_MAN.EdgeColor = Color.White;
                        // if(Top != null)
                        // {
                             CommonFunction._ProjectRelated.Var[0] = "PRESS ENTER TO EXECUTE";
                             CommonFunction._ProjectRelated.Var[1] = "";
                        // }
		 }
		 else if(Area.Variable[1] == "2")
		 {
			 AUTO.ForegroundColor = Color.White;
                         Rect_AUTO.EdgeColor = Color.White;
                        // if(Top != null)
                        // {
                             CommonFunction._ProjectRelated.Var[0] = "PRESS ENTER TO EXECUTE";
                             CommonFunction._ProjectRelated.Var[1] = "";
                       //  }
		 }
	 }
	 }
     if(Area.Variable[1] == "4")
     {
	 PTXST.ForegroundColor = Color.White;
         ACTIVE.ForegroundColor = Color.White;
         PA_Rectangle.EdgeColor = Color.White;  
                       //  if(Top != null)
                       //  {
                             CommonFunction._ProjectRelated.Var[0] = "PRESS ENTER TO EXECUTE";
                             CommonFunction._ProjectRelated.Var[1] = "";
                       //  } 
     }
 
     if(Area.Variable[1] == "5")
     {   
       //  if(Top != null)
       //    {
             CommonFunction._ProjectRelated.Var[1] = "NOT EMULATION"; 
             CommonFunction._ProjectRelated.Var[0] = ""; 
        //    } 
     }

     if(Area.Variable[1] == "6")
     {
	 PV.ForegroundColor = Color.White;
         Text_PV.ForegroundColor = Color.White;  
     }

     if(Area.Variable[1] == "7")
     {
	 SP.ForegroundColor = Color.White;
         Text_SP.ForegroundColor = Color.White; 
     }

     if(Area.Variable[1] == "8")
     {
	 OP.ForegroundColor = Color.White;
         Text_OP.ForegroundColor = Color.White;
     }

   return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:Disposed 
public void PIC_CZ_PMPID_Disposed(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 

   TextBox TB = (TextBox)Area.GetDrawObj("TB");
   TB.Enabled = false;
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void PIC_CZ_PMPID_OnDynClick(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 
   
    DrawArea A = (DrawArea)(Area.Parent.Parent);
             A.RunAnimation();

   object obj=Area.GetControlObj("TB");
   if(obj!=null)
	{
		TextBox TB=(TextBox)obj;
		TB.Visible=false;
	}

    return; 
}
//Do not remove or update this comment
//Event Delegate:KeyEventHandler 
//Event Handler:KeyUp 
public void PIC_CZ_PMPID_KeyUp(Object sender, KeyEventArgs e)
{
   DrawArea Area = (DrawArea)sender; 

    DrawArea A = (DrawArea)(Area.Parent.Parent);
             A.RunAnimation();

   string tagName = Area.Variable[0] + "/MODE";

        DrawArea picT = (DrawArea)(Area.Parent.Parent);
//        DrawArea Top = (DrawArea)picT.GetDrawObj("TDC3000_Top");


     double dbValue = 0;
     int nValue = 0;
     bool bValue = false;
     int nDataType = 0;

     string MODE = Area.Variable[0] + "/MODE";
     bool ret = CommonFunction.GetValueWithType(MODE,ref dbValue,ref nValue,ref bValue,ref nDataType);
     
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
                                   CommonFunction.DSI_SetValue(tagName, (double)(2));
	                         }
	                       if(Area.Variable[1] == "3")
	                        {
                                   CommonFunction.DSI_SetValue(tagName, (double)(3));
	                        }
                               if(Area.Variable[1] == "4")
                                {
	                             DrawText PTXST = (DrawText)Area.GetDrawObj("PTXST");
	                             DrawText ACTIVE = (DrawText)Area.GetDrawObj("ACTIVE");
                                     DrawRectangle PA_Rectangle = (DrawRectangle)Area.GetDrawObj("PA_Rectangle");

	                             PTXST.ForegroundColor = Color.Lime;
                                     ACTIVE.ForegroundColor = Color.Lime;
                                     PA_Rectangle.EdgeColor = Color.Lime;     
                                }

                              ////////////////Top的显示
                             //   if(Top != null)
                                     CommonFunction._ProjectRelated.Var[0] = "";

                             ////////////////Top的显示

                          Area.Variable[1] = "0";

	                 break;
                      } 
         }
         
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void Rect17_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect17 = (DrawRectangle)dynArgs.sender; 
   
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
public void Rect16_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect16 = (DrawRectangle)dynArgs.sender; 

    DrawText PV = (DrawText)Area.GetDrawObj("PV");

    Area.Variable[1] = "6"; 

    if(Rect16.Visible == true)

	{
		// 不弹出输入面板，DrawText隐藏，TextBox显示	
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
                                //调整TB的位置：
				CommonFunction.MoveControl(Area,TB,(int)(PV.VerticalPosition)+30,(int)(PV.HorizontalPosition)+40);
			
				obj = CommonFunction.GetLabelOfControl(TB);
				if(obj != null)
				{
					ControlLabel lab = (ControlLabel)obj;
					//给TB传递参数：
					lab.Variable[0] = Area.Variable[0] + "/PV";
                                        
				}
			}
		}
	}

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void Rect15_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect15 = (DrawRectangle)dynArgs.sender; 

    DrawText SP = (DrawText)Area.GetDrawObj("SP");

    Area.Variable[1] = "7"; 

    if(Rect15.Visible == true)

	{
		// 不弹出输入面板，DrawText隐藏，TextBox显示	
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
                                //调整TB的位置：
				CommonFunction.MoveControl(Area,TB,(int)(SP.VerticalPosition)+30,(int)(SP.HorizontalPosition)+40);
			
				obj = CommonFunction.GetLabelOfControl(TB);
				if(obj != null)
				{
					ControlLabel lab = (ControlLabel)obj;
					//给TB传递参数：
					lab.Variable[0] = Area.Variable[0] + "/SP";
                                        
				}
			}
		}
	}

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void Rect14_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect14 = (DrawRectangle)dynArgs.sender; 

    DrawText OP = (DrawText)Area.GetDrawObj("OP");

    Area.Variable[1] = "8"; 

    if(Rect14.Visible == true)

	{
		// 不弹出输入面板，DrawText隐藏，TextBox显示	
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
                                //调整TB的位置：
				CommonFunction.MoveControl(Area,TB,(int)(OP.VerticalPosition)+30,(int)(OP.HorizontalPosition)+40);
			
				obj = CommonFunction.GetLabelOfControl(TB);
				if(obj != null)
				{
					ControlLabel lab = (ControlLabel)obj;
					//给TB传递参数：
					lab.Variable[0] = Area.Variable[0] + "/OP";
                                        
				}
			}
		}
	}


    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void Text_OP_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText Text_OP = (DrawText)dynArgs.sender; 
   
    Text_OP.ForegroundColor = Color.Yellow;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void Text_SP_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText Text_SP = (DrawText)dynArgs.sender; 
   
    Text_SP.ForegroundColor = Color.Cyan;

    return; 
}


//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void Text_PV_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText Text_PV = (DrawText)dynArgs.sender; 

       Text_PV.ForegroundColor = Color.Cyan;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void PA_Rectangle_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle PA_Rectangle = (DrawRectangle)dynArgs.sender; 

    DrawArea A = (DrawArea)(Area.Parent.Parent);
             A.RunAnimation();

    Area.Variable[1] = "4";  
 
     return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void Rect_PROG_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect_PROG = (DrawRectangle)dynArgs.sender; 
   
    Area.Variable[1] = "5";

    DrawArea pic = (DrawArea)(Area.Parent.Parent);
//    DrawArea Top = (DrawArea)pic.GetDrawObj("TDC3000_Top");
//    if(Top != null)
 //       {
               CommonFunction._ProjectRelated.Var[1] = "NOT EMULATION";
               CommonFunction._ProjectRelated.Var[0] = "";
//        }
    DrawArea A = (DrawArea)(Area.Parent.Parent);
             A.RunAnimation();
    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void Rect_MAN_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect_MAN = (DrawRectangle)dynArgs.sender; 
   
    DrawArea A = (DrawArea)(Area.Parent.Parent);
             A.RunAnimation();

    Area.Variable[1] = "1";

	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;
	string tagName = Area.Variable[0] + "/MODE";

   if(CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType))
   {		
     if(dbValue == 1)
	 {
              Rect_MAN.EdgeColor = Color.White;
	      DrawText MAN = (DrawText)Area.GetDrawObj("MAN");
   	      MAN.ForegroundColor = Color.White;
          }
   }

    return; 
}


//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void Rect_AUTO_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect_AUTO = (DrawRectangle)dynArgs.sender; 
   
    DrawArea A = (DrawArea)(Area.Parent.Parent);
             A.RunAnimation();

    Area.Variable[1] = "2";
    
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;
	string tagName = Area.Variable[0] + "/MODE";

   if(CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType))
   {		
     if(dbValue == 2)
	 {
              Rect_AUTO.EdgeColor = Color.White;
	      DrawText AUTO = (DrawText)Area.GetDrawObj("AUTO");
   	      AUTO.ForegroundColor = Color.White;
          }
   }

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void Rect_CAS_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect_CAS = (DrawRectangle)dynArgs.sender; 
 
    DrawArea A = (DrawArea)(Area.Parent.Parent);
             A.RunAnimation();

    Area.Variable[1] = "3";
    
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;
	string tagName = Area.Variable[0] + "/MODE";

   if(CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType))
   {		
     if(dbValue == 3)
	 {
              Rect_CAS.EdgeColor = Color.White;
	      DrawText CAS = (DrawText)Area.GetDrawObj("CAS");
   	      CAS.ForegroundColor = Color.White;
          }
   }

    return; 
}


//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void OP_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText OP = (DrawText)dynArgs.sender; 
   
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	int nDigit = 1;

	string strDigit = "f" + nDigit.ToString();
	
	string tagName = Area.Variable[0] + "/OP";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		OP.Caption = dbValue.ToString(strDigit);
	}
	else
		OP.Caption = "##.#";

    object obj = Area.GetControlObj("TB");
	
	TextBox TB = (TextBox)obj; 

          if(TB.Visible == false)

            {
                OP.ForegroundColor = Color.Yellow;
                DrawText Text_OP = (DrawText)Area.GetDrawObj("Text_OP");
                Text_OP.ForegroundColor = Color.Yellow;
            }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void OP_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText OP = (DrawText)dynArgs.sender; 
 
    OP.ForegroundColor = Color.Yellow; 

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void SP_OnDynAnimation(Object sender, EventArgs e)
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

    object obj = Area.GetControlObj("TB");
	
	TextBox TB = (TextBox)obj; 

          if(TB.Visible == false)

            {
                SP.ForegroundColor = Color.Cyan;
                DrawText Text_SP = (DrawText)Area.GetDrawObj("Text_SP");
                Text_SP.ForegroundColor = Color.Cyan;
            }


    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void SP_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText SP = (DrawText)dynArgs.sender; 

    SP.ForegroundColor = Color.Cyan; 

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

    object obj = Area.GetControlObj("TB");
	
	TextBox TB = (TextBox)obj; 

          if(TB.Visible == false)

            {
                PV.ForegroundColor = Color.Cyan;
                DrawText Text_PV = (DrawText)Area.GetDrawObj("Text_PV");
                Text_PV.ForegroundColor = Color.Cyan;
            }

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
   
    PV.ForegroundColor = Color.Cyan;

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
public void PVUnit_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVUnit = (DrawText)dynArgs.sender; 
   
    PVUnit.Caption = CommonFunction.GetPVUnit(Area.Variable[0]);

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
   
        DrawArea picT = (DrawArea)(Area.Parent.Parent);
//        DrawArea Top = (DrawArea)picT.GetDrawObj("TDC3000_Top");

    (Area.Parent).Visible = false;

//    if(Top != null)
//          {
             CommonFunction._ProjectRelated.Var[0] = "";
             CommonFunction._ProjectRelated.Var[1] = "";
//          }
    Area.Variable[1] = "0";

    return; 
}
//Do not remove or update this comment
//Event Delegate:KeyEventHandler 
//Event Handler:KeyUp 
public void TB_KeyUp(Object sender, KeyEventArgs e)
{
   TextBox TB = (TextBox)sender; 

   DrawArea Area = CommonFunction.GetThisDrawArea(TB);

     double dbValue = 0;
     int nValue = 0;
     bool bValue = false;
     int nDataType = 0;

     string MODE = Area.Variable[0] + "/MODE";
     bool ret = CommonFunction.GetValueWithType(MODE,ref dbValue,ref nValue,ref bValue,ref nDataType);

	switch ( e.KeyData )
	{
	case Keys.Enter:

		if(TB.Text == "" || TB.Text == null)

		{
			TB.Visible = false;
			TB.Enabled = false;
			return;
		}

		else

		{
			string PVInputValue = TB.Text;
			double dbPVValue = Convert.ToDouble(PVInputValue);

			object obj1 = CommonFunction.GetLabelOfControl(TB);

			if (obj1 != null)

			{
		             ControlLabel lab=(ControlLabel)obj1;
		             string tagName=lab.Variable[0];

                             //PV值只有在MODE是MAN的时候才可以改变
                             bool V = tagName.Contains("PV");
                             bool O = tagName.Contains("OP");
                             bool S = tagName.Contains("SP");
                             if(V == true)
                               {
                                 if(ret)

	                        {
				        CommonFunction.DSI_SetValue(tagName, dbPVValue);

	                        }

                               }

                             if(O == true)
                               {
                                 if(ret)

	                        {//OP值只有在MODE是MAN的时候才可以改变
	                 	  if(dbValue==1)

				    {
				        CommonFunction.DSI_SetValue(tagName, dbPVValue);}

	                	  else 
                                    {
			                DrawArea pic = (DrawArea)(Area.Parent.Parent);
                                      //  DrawArea Top = (DrawArea)pic.GetDrawObj("TDC3000_Top");
                                      //  if(Top != null)
                                             CommonFunction._ProjectRelated.Var[1] = "MODE ERROR";

                                    }
		
	                        }

                               }

                             if(S == true)
                               {
                                 if(ret)

	                        {//SP值只有在MODE是AUTO的时候才可以改变
	                 	  if(dbValue==2)

				    {
				        CommonFunction.DSI_SetValue(tagName, dbPVValue);}

	                	  else 
                                    {
			                DrawArea pic = (DrawArea)(Area.Parent.Parent);
                                        DrawArea Top = (DrawArea)pic.GetDrawObj("TDC3000_Top");
                                       // if(Top != null)
                                            CommonFunction._ProjectRelated.Var[1] = "MODE ERROR";
                                    }
		
	                        }

                               }
			}      
                        TB.ForeColor = Color.Lime;
			TB.Visible = false;
			TB.Enabled = false;
                        return;
		}
		break;
	}
DrawArea pic0 = (DrawArea)(Area.Parent.Parent);
//DrawArea Top0 = (DrawArea)pic0.GetDrawObj("TDC3000_Top");
//if(Top0 != null)
CommonFunction._ProjectRelated.Var[1] = "";
    return; 
}


}
