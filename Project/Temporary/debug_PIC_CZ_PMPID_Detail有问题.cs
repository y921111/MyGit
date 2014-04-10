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
public class PIC_CZ_PMPID_Detail有问题:IDynCodeAttachDetach
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
_EventHandler= (EventHandler)PIC_CZ_PMPID_Detail有问题_OnDynInitialize;
CodeDomCommon.AttachAreaEventHandler(area,strEventName,_EventHandler);
strObjectName = "TagComment";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)TagComment_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Tag";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Tag_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Tag";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Tag_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Group_Detail_1";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)Group_Detail_1_KeyUp;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "Group_Detail_1";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Group_Detail_1_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Group_Detail_1";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Group_Detail_1_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Group_Detail_1.ENTER";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Group_Detail_1_ENTER_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Group_Detail_1.NORM";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Group_Detail_1_NORM_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Group_Detail_1.MAN";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Group_Detail_1_MAN_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Group_Detail_1.PROG";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Group_Detail_1_PROG_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Group_Detail_1.CAS";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Group_Detail_1_CAS_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Group_Detail_1.AUTO";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Group_Detail_1_AUTO_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Group_Detail";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Group_Detail_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Group_Detail";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Group_Detail_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Group_Detail.Rect_MODE";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Group_Detail_Rect_MODE_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Group_Detail.MODE";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Group_Detail_MODE_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Group_Detail.MODE";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Group_Detail_MODE_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Group_Detail.Unit";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Group_Detail_Unit_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Group_Detail.Unit";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Group_Detail_Unit_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Group_Detail.TagName";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Group_Detail_TagName_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Group_Detail.TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Group_Detail_TagName_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Group_Detail.PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Group_Detail_PV_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Group_Detail.PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Group_Detail_PV_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Group_Detail.PV";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Group_Detail_PV_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Group_Detail.SP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Group_Detail_SP_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Group_Detail.SP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Group_Detail_SP_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Group_Detail.SP";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Group_Detail_SP_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Group_Detail.OP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Group_Detail_OP_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Group_Detail.OP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Group_Detail_OP_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Group_Detail.OP";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Group_Detail_OP_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Group_Detail.TB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)Group_Detail_TB_KeyUp;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "TDC3000_Top.Caption1";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)TDC3000_Top_Caption1_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_Top.Caption1";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TDC3000_Top_Caption1_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_Top.Caption2";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)TDC3000_Top_Caption2_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_Top.Caption2";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TDC3000_Top_Caption2_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_Top.Text2";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TDC3000_Top_Text2_OnDynAnimation;
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
_EventHandler= (EventHandler)PIC_CZ_PMPID_Detail有问题_OnDynInitialize;
CodeDomCommon.DetachAreaEventHandler(area,strEventName,_EventHandler);
strObjectName = "TagComment";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)TagComment_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Tag";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Tag_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Tag";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Tag_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Group_Detail_1";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)Group_Detail_1_KeyUp;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "Group_Detail_1";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Group_Detail_1_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Group_Detail_1";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Group_Detail_1_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Group_Detail_1.ENTER";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Group_Detail_1_ENTER_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Group_Detail_1.NORM";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Group_Detail_1_NORM_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Group_Detail_1.MAN";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Group_Detail_1_MAN_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Group_Detail_1.PROG";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Group_Detail_1_PROG_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Group_Detail_1.CAS";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Group_Detail_1_CAS_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Group_Detail_1.AUTO";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Group_Detail_1_AUTO_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Group_Detail";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Group_Detail_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Group_Detail";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Group_Detail_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Group_Detail.Rect_MODE";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Group_Detail_Rect_MODE_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Group_Detail.MODE";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Group_Detail_MODE_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Group_Detail.MODE";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Group_Detail_MODE_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Group_Detail.Unit";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Group_Detail_Unit_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Group_Detail.Unit";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Group_Detail_Unit_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Group_Detail.TagName";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Group_Detail_TagName_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Group_Detail.TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Group_Detail_TagName_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Group_Detail.PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Group_Detail_PV_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Group_Detail.PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Group_Detail_PV_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Group_Detail.PV";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Group_Detail_PV_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Group_Detail.SP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Group_Detail_SP_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Group_Detail.SP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Group_Detail_SP_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Group_Detail.SP";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Group_Detail_SP_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Group_Detail.OP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Group_Detail_OP_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Group_Detail.OP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Group_Detail_OP_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Group_Detail.OP";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Group_Detail_OP_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Group_Detail.TB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)Group_Detail_TB_KeyUp;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "TDC3000_Top.Caption1";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)TDC3000_Top_Caption1_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_Top.Caption1";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TDC3000_Top_Caption1_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_Top.Caption2";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)TDC3000_Top_Caption2_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_Top.Caption2";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TDC3000_Top_Caption2_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_Top.Text2";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TDC3000_Top_Text2_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);

    return;
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void PIC_CZ_PMPID_Detail有问题_OnDynInitialize(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 

   DrawArea P = (DrawArea)(Area.GetDrawObj("Group_Detail_1"));
   P.Visible = false;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void TagComment_OnDynInitialize(Object sender, EventArgs e)
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
public void Tag_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText Tag = (DrawText)dynArgs.sender; 
   
        string tagName = Area.Variable[0].ToUpper();

	if(tagName != "")
		Tag.Caption = tagName;
	else
		Tag.Caption = "******";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void Tag_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText Tag = (DrawText)dynArgs.sender; 
   
        string tagName = Area.Variable[0].ToUpper();

	if(tagName != "")

		Tag.Caption = tagName;
	else
		Tag.Caption = "******";

    return; 
}
//Do not remove or update this comment
//Event Delegate:KeyEventHandler 
//Event Handler:KeyUp 
public void Group_Detail_1_KeyUp(Object sender, KeyEventArgs e)
{
   DrawArea Area = (DrawArea)sender; 

   string tagName = Area.Variable[0] + "/MODE";

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
	                             DrawText NORM = (DrawText)Area.GetDrawObj("NORM");

	                             NORM.ForegroundColor = Color.Lime;
                                }
                               if(Area.Variable[1] == "5")
                                {
	                             DrawText PROG = (DrawText)Area.GetDrawObj("PROG");

	                             PROG.ForegroundColor = Color.Lime;
                                }

                          Area.Variable[1] = "0";
                          Area.Visible = false;
	                 break;
                      } 
         }
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void Group_Detail_1_OnDynInitialize(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 
   
////////////////////////////////////////////////////////////////////////////////处理变色
////////////////////////////////////////////////////////////////////////////////处理变色

	DrawText MAN1 = (DrawText)Area.GetDrawObj("MAN");
	DrawText AUTO1 = (DrawText)Area.GetDrawObj("AUTO");
	DrawText CAS1 = (DrawText)Area.GetDrawObj("CAS");
	DrawText NORM1 = (DrawText)Area.GetDrawObj("NORM");
	DrawText PROG1 = (DrawText)Area.GetDrawObj("PROG");

	MAN1.ForegroundColor = Color.Lime;
	AUTO1.ForegroundColor = Color.Lime;
	CAS1.ForegroundColor = Color.Lime;
	NORM1.ForegroundColor = Color.Lime;
	PROG1.ForegroundColor = Color.Lime;

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
                      MAN1.ForegroundColor = Color.Cyan;
                    }	
		else if(nValue == 2)

		   {
                      AUTO1.ForegroundColor = Color.Cyan;
                    }
                else if(nValue == 3)

		   {
                      CAS1.ForegroundColor = Color.Cyan;
                    }
	    }    

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void Group_Detail_1_OnDynAnimation(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 

////////////////////////////////////////////////////////////////////////////////处理变色
////////////////////////////////////////////////////////////////////////////////处理变色

	DrawText MAN2 = (DrawText)Area.GetDrawObj("MAN");
	DrawText AUTO2 = (DrawText)Area.GetDrawObj("AUTO");
	DrawText CAS2 = (DrawText)Area.GetDrawObj("CAS");
	DrawText NORM2 = (DrawText)Area.GetDrawObj("NORM");
	DrawText PROG2 = (DrawText)Area.GetDrawObj("PROG");

	MAN2.ForegroundColor = Color.Lime;
	AUTO2.ForegroundColor = Color.Lime;
	CAS2.ForegroundColor = Color.Lime;
	NORM2.ForegroundColor = Color.Lime;
	PROG2.ForegroundColor = Color.Lime;

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
			 MAN2.ForegroundColor = Color.Cyan;

		 if(Area.Variable[1] == "2")
		 {
			 AUTO2.ForegroundColor = Color.White;
		 }
		 else if(Area.Variable[1] == "3")
		 {
			 CAS2.ForegroundColor = Color.White;
		 }

	 }
	 if(dbValue == 2)
	 {
			 AUTO2.ForegroundColor = Color.Cyan;

		 if(Area.Variable[1] == "1")
		 {
			 MAN2.ForegroundColor = Color.White;
		 }
		 else if(Area.Variable[1] == "3")
		 {
			 CAS2.ForegroundColor = Color.White;
		 }
	 }
	 if(dbValue == 3)
	 {
			 CAS2.ForegroundColor = Color.Cyan;

		 if(Area.Variable[1] == "1")
		 {
			 MAN2.ForegroundColor = Color.White;
		 }
		 else if(Area.Variable[1] == "2")
		 {
			 AUTO2.ForegroundColor = Color.White;
		 }
	 }
	 }
     if(Area.Variable[1] == "4")
     {
	 NORM2.ForegroundColor = Color.White;
     }
 
     if(Area.Variable[1] == "5")
     {
	 PROG2.ForegroundColor = Color.White;  
     }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void Group_Detail_1_ENTER_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText ENTER = (DrawText)dynArgs.sender; 
   
   string tagName = Area.Variable[0] + "/MODE";

     double dbValue = 0;
     int nValue = 0;
     bool bValue = false;
     int nDataType = 0;

     string MODE = Area.Variable[0] + "/MODE";
     bool ret = CommonFunction.GetValueWithType(MODE,ref dbValue,ref nValue,ref bValue,ref nDataType);
     
     if(ret)
      
           {
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
	               DrawText NORM = (DrawText)Area.GetDrawObj("NORM");
	               NORM.ForegroundColor = Color.Lime;
                  }
               if(Area.Variable[1] == "5")
                  {
	               DrawText PROG = (DrawText)Area.GetDrawObj("PROG");
	               PROG.ForegroundColor = Color.Lime;
               }

               Area.Variable[1] = "0";
               Area.Visible = false;
         }
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void Group_Detail_1_NORM_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText NORM = (DrawText)dynArgs.sender; 
   
    Area.Variable[1] = "4";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void Group_Detail_1_MAN_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText MAN = (DrawText)dynArgs.sender; 
   
    Area.Variable[1] = "1";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void Group_Detail_1_PROG_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PROG = (DrawText)dynArgs.sender; 
   
    Area.Variable[1] = "5";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void Group_Detail_1_CAS_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText CAS = (DrawText)dynArgs.sender; 
   
    Area.Variable[1] = "3";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void Group_Detail_1_AUTO_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText AUTO = (DrawText)dynArgs.sender; 
   
    Area.Variable[1] = "2";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void Group_Detail_OnDynInitialize(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 
   
	if(Area.BReference)//图素
		{
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

/*			Area.Variable[0] = (Area.Parent).Variable[0];
//MessageBox.Show(Area.Variable[0].ToString());

			ControlLabel lab = (ControlLabel)CommonFunction.GetLabelOfControl(Area);
			lab.Selected = false;
*/
        DrawArea picT = (DrawArea)(Area.Parent);
	Area.Variable[0] = picT.Variable[0];			
		}

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void Group_Detail_OnDynClick(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 
   
   object obj=Area.GetControlObj("TB");
   if(obj!=null)
	{
		TextBox TB=(TextBox)obj;
		TB.Visible=false;
	}

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void Group_Detail_Rect_MODE_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect_MODE = (DrawRectangle)dynArgs.sender; 
   
    DrawArea pic = (DrawArea)(Area.Parent);
    DrawArea G = (DrawArea)pic.GetDrawObj("Group_Detail_1");
    G.Visible = true;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void Group_Detail_MODE_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText MODE = (DrawText)dynArgs.sender; 

    DrawRectangle Rect = (DrawRectangle)Area.GetDrawObj("Rect_MODE");  
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	int nDigit = 2;
	string tagName = Area.Variable[0] + "/PVFORMAT";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
            {
                if(dbValue == 1)
                  {
                      MODE.Caption = "MAN";
                      MODE.ForegroundColor = Color.Black;
                      Rect.ForegroundColor = Color.Yellow;
                  }
                if(dbValue == 2)
                  {
                      MODE.Caption = "AUTO";
                      MODE.ForegroundColor = Color.Cyan;
                      Rect.ForegroundColor = Color.Black;
                  }
                if(dbValue == 3)
                  {
                      MODE.Caption = "CAS";
                      MODE.ForegroundColor = Color.Black;
                      Rect.ForegroundColor = Color.Cyan;
                  }
            }

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void Group_Detail_MODE_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText MODE = (DrawText)dynArgs.sender; 
   
    DrawRectangle Rect = (DrawRectangle)Area.GetDrawObj("Rect_MODE");  
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	int nDigit = 2;
	string tagName = Area.Variable[0] + "/PVFORMAT";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
            {
                if(dbValue == 1)
                  {
                      MODE.Caption = "MAN";
                      MODE.ForegroundColor = Color.Black;
                      Rect.ForegroundColor = Color.Yellow;
                  }
                if(dbValue == 2)
                  {
                      MODE.Caption = "AUTO";
                      MODE.ForegroundColor = Color.Cyan;
                      Rect.ForegroundColor = Color.Black;
                  }
                if(dbValue == 3)
                  {
                      MODE.Caption = "CAS";
                      MODE.ForegroundColor = Color.Black;
                      Rect.ForegroundColor = Color.Cyan;
                  }
            }
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void Group_Detail_Unit_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText Unit = (DrawText)dynArgs.sender; 
   
    Unit.Caption = CommonFunction.GetPVUnit(Area.Variable[0]);

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void Group_Detail_Unit_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText Unit = (DrawText)dynArgs.sender; 
   
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void Group_Detail_TagName_OnDynInitialize(Object sender, EventArgs e)	//TagName
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
//Event Handler:OnDynAnimation 
public void Group_Detail_TagName_OnDynAnimation(Object sender, EventArgs e)
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
//Event Handler:OnDynAnimation 
public void Group_Detail_PV_OnDynAnimation(Object sender, EventArgs e)
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
//                DrawText Text_PV = (DrawText)Area.GetDrawObj("Text_PV");
//                Text_PV.ForegroundColor = Color.Cyan;
            }



    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void Group_Detail_PV_OnDynInitialize(Object sender, EventArgs e)
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
//Event Handler:OnDynClick 
public void Group_Detail_PV_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PV = (DrawText)dynArgs.sender; 
  
    PV.ForegroundColor = Color.White;
//    DrawText Text_PV = (DrawText)Area.GetDrawObj("Text_PV");
//    Text_PV.ForegroundColor = Color.White;

    if(PV.Visible == true)

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
				CommonFunction.MoveControl(Area,TB,(int)(PV.VerticalPosition)-60,(int)(PV.HorizontalPosition)+40);
			
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
//Event Handler:OnDynAnimation 
public void Group_Detail_SP_OnDynAnimation(Object sender, EventArgs e)
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
            }


    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void Group_Detail_SP_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText SP = (DrawText)dynArgs.sender; 

    SP.ForegroundColor = Color.Cyan; 
   
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
//Event Handler:OnDynClick 
public void Group_Detail_SP_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText SP = (DrawText)dynArgs.sender; 
   
    SP.ForegroundColor = Color.White;
//    DrawText Text_SP = (DrawText)Area.GetDrawObj("Text_SP");
//    Text_SP.ForegroundColor = Color.White;

    if(SP.Visible == true)

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
				CommonFunction.MoveControl(Area,TB,(int)(SP.VerticalPosition - 60),(int)(SP.HorizontalPosition)+40);		
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
//Event Handler:OnDynAnimation 
public void Group_Detail_OP_OnDynAnimation(Object sender, EventArgs e)
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
            }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void Group_Detail_OP_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText OP = (DrawText)dynArgs.sender; 
 
    OP.ForegroundColor = Color.Yellow; 
  
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

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void Group_Detail_OP_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText OP = (DrawText)dynArgs.sender; 
   
    OP.ForegroundColor = Color.White;
//    DrawText Text_OP = (DrawText)Area.GetDrawObj("Text_OP");
//    Text_OP.ForegroundColor = Color.White;

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
				TB.Enabled = true;
				TB.Text = "";
				TB.Focus();

                                //调整TB的位置：
			        CommonFunction.MoveControl(Area,TB,(int)(OP.VerticalPosition)-60,(int)(OP.HorizontalPosition)+40);
				
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
//Event Delegate:KeyEventHandler 
//Event Handler:KeyUp 
public void Group_Detail_TB_KeyUp(Object sender, KeyEventArgs e)
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
			                DrawArea pic = (DrawArea)(Area.Parent);
                                        DrawArea Top = (DrawArea)pic.GetDrawObj("TDC3000_Top");
                                        Top.Variable[4] = "MODE ERROR";

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
			                DrawArea pic = (DrawArea)(Area.Parent);
                                        DrawArea Top = (DrawArea)pic.GetDrawObj("TDC3000_Top");
                                        Top.Variable[4] = "MODE ERROR";
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
DrawArea pic0 = (DrawArea)(Area.Parent);
DrawArea Top0 = (DrawArea)pic0.GetDrawObj("TDC3000_Top");
Top0.Variable[4] = "";
    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void TDC3000_Top_Caption1_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText Caption1 = (DrawText)dynArgs.sender; 

    Caption1.Visible = false;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void TDC3000_Top_Caption1_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText Caption1 = (DrawText)dynArgs.sender; 

	if(Area.BReference)
	{
          Caption1.Visible = true;
          Caption1.Caption = Area.Variable[3];
	}

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void TDC3000_Top_Caption2_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText Caption2 = (DrawText)dynArgs.sender; 
   
    Caption2.Visible = false;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void TDC3000_Top_Caption2_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText Caption2 = (DrawText)dynArgs.sender; 

	if(Area.BReference)
	{
          Caption2.Visible = true;
          Caption2.Caption = Area.Variable[4];
	}

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void TDC3000_Top_Text2_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText Text2 = (DrawText)dynArgs.sender; 
   
    DateTime now = DateTime.Now;
    Text2.Caption = now.Day.ToString() + "  " + now.Month.ToString() + "  " + "20" + now.ToString("yy") +  "  " + now.ToString("HH") + ":" +     now.ToString("mm")+ ":" +  now.ToString("ss");

    return; 
}

}
