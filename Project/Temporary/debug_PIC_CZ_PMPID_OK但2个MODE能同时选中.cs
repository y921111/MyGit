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
public class PIC_CZ_PMPID_OK但2个MODE能同时选中:IDynCodeAttachDetach
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
_EventHandler= (EventHandler)PIC_CZ_PMPID_OK但2个MODE能同时选中_OnDynInitialize;
CodeDomCommon.AttachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "Disposed";
_EventHandler= (EventHandler)PIC_CZ_PMPID_OK但2个MODE能同时选中_Disposed;
CodeDomCommon.AttachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PIC_CZ_PMPID_OK但2个MODE能同时选中_OnDynClick;
CodeDomCommon.AttachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)PIC_CZ_PMPID_OK但2个MODE能同时选中_KeyUp;
CodeDomCommon.AttachAreaEventHandler(area,strEventName,_KeyEventHandler);
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
strObjectName = "CLR";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CLR_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "ACTIVE";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)ACTIVE_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "ACTIVE";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)ACTIVE_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PA_Rectangle";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PA_Rectangle_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PA_Rectangle";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PA_Rectangle_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PA_Rectangle";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PA_Rectangle_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PA_Rectangle";
strEventName = "OnDynDblClick";
_EventHandler= (EventHandler)PA_Rectangle_OnDynDblClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PTXST";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PTXST_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PTXST";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PTXST_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PROG";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PROG_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect_MAN";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Rect_MAN_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect_MAN";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Rect_MAN_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect_MAN";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect_MAN_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect_MAN";
strEventName = "OnDynDblClick";
_EventHandler= (EventHandler)Rect_MAN_OnDynDblClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "MAN";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)MAN_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "MAN";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)MAN_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect_AUTO";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Rect_AUTO_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect_AUTO";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Rect_AUTO_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect_AUTO";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect_AUTO_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect_AUTO";
strEventName = "OnDynDblClick";
_EventHandler= (EventHandler)Rect_AUTO_OnDynDblClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "AUTO";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)AUTO_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "AUTO";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)AUTO_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CAS";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CAS_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CAS";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CAS_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect_CAS";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Rect_CAS_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect_CAS";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Rect_CAS_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect_CAS";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect_CAS_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect_CAS";
strEventName = "OnDynDblClick";
_EventHandler= (EventHandler)Rect_CAS_OnDynDblClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)OP_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)OP_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OP";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)OP_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)SP_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)SP_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SP";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)SP_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PV_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PV_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PV";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PV_OnDynClick;
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
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)TagName_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TagName";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)TagName_OnDynClick;
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
_EventHandler= (EventHandler)PIC_CZ_PMPID_OK但2个MODE能同时选中_OnDynInitialize;
CodeDomCommon.DetachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "Disposed";
_EventHandler= (EventHandler)PIC_CZ_PMPID_OK但2个MODE能同时选中_Disposed;
CodeDomCommon.DetachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PIC_CZ_PMPID_OK但2个MODE能同时选中_OnDynClick;
CodeDomCommon.DetachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)PIC_CZ_PMPID_OK但2个MODE能同时选中_KeyUp;
CodeDomCommon.DetachAreaEventHandler(area,strEventName,_KeyEventHandler);
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
strObjectName = "CLR";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CLR_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "ACTIVE";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)ACTIVE_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "ACTIVE";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)ACTIVE_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PA_Rectangle";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PA_Rectangle_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PA_Rectangle";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PA_Rectangle_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PA_Rectangle";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PA_Rectangle_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PA_Rectangle";
strEventName = "OnDynDblClick";
_EventHandler= (EventHandler)PA_Rectangle_OnDynDblClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PTXST";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PTXST_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PTXST";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PTXST_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PROG";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PROG_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect_MAN";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Rect_MAN_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect_MAN";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Rect_MAN_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect_MAN";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect_MAN_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect_MAN";
strEventName = "OnDynDblClick";
_EventHandler= (EventHandler)Rect_MAN_OnDynDblClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "MAN";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)MAN_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "MAN";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)MAN_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect_AUTO";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Rect_AUTO_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect_AUTO";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Rect_AUTO_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect_AUTO";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect_AUTO_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect_AUTO";
strEventName = "OnDynDblClick";
_EventHandler= (EventHandler)Rect_AUTO_OnDynDblClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "AUTO";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)AUTO_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "AUTO";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)AUTO_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CAS";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)CAS_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CAS";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CAS_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect_CAS";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Rect_CAS_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect_CAS";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Rect_CAS_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect_CAS";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect_CAS_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect_CAS";
strEventName = "OnDynDblClick";
_EventHandler= (EventHandler)Rect_CAS_OnDynDblClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)OP_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)OP_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OP";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)OP_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)SP_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)SP_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SP";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)SP_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PV_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PV_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PV";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PV_OnDynClick;
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
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)TagName_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TagName";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)TagName_OnDynClick;
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
// 
// 说明: PID面板
//
//
// 【调用时传入参数】
//		Area.Variable[0] - Tagname
//		Area.Variable[1] - Unit
//		Area.Variable[2] - communication
//		Area.Variable[3] - MODE
//		Area.Variable[4] - 1/0值
//
// 【更新时间】 
//		2012.08.16 hdd
// =======================================================================
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void PIC_CZ_PMPID_OK但2个MODE能同时选中_OnDynInitialize(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender;
	
   Area.Variable[1] = "0";

	Picture pic = CommonFunction.GetThisPicture(Area);
	if(pic != null)
	{

		if(Area.BReference)//图素
		{
			//将顶级DrawArea的Variable[0]变量传递到图素级DrawArea：
			DrawArea MainArea = pic.GetDrawArea();
			Area.Variable[0] = MainArea.Variable[0];
//MessageBox.Show(Area.Variable[0].ToString());
                        Area.Variable[1] = MainArea.Variable[1];
                        Area.Variable[2] = MainArea.Variable[2];
                        Area.Variable[3] = MainArea.Variable[3];
                        Area.Variable[4] = MainArea.Variable[4];
                        Area.Variable[5] = MainArea.Variable[5];
                        Area.Variable[6] = MainArea.Variable[6];

			ControlLabel lab = (ControlLabel)CommonFunction.GetLabelOfControl(Area);
			lab.Selected = false;
			
		}
		else
		{
			pic.Text = Area.Variable[0];
		}
	}
	Area.Variable[0] = Area.Variable[0].ToUpper();


   object obj = Area.Parent;

   Type type = obj.GetType();

   if( type.Name != "Picture" )

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
		TB.Visible = true;
		TB.Focus();
	}
   } 
//TB的初始化
   object objTB = Area.GetControlObj("TB");
	if(objTB != null)
	{
		TextBox TB = (TextBox)objTB; 
		if(TB != null)
		{
			TB.Visible = false;
			TB.Enabled = false;
		}
	}




/*
   object obj = Area.Parent;
   
   Type type = obj.GetType();

	if ( type.Name != "Picture" )
	{
		DrawArea pic1 = (DrawArea)(Area.Parent);
		DrawArea D1 = (DrawArea)pic1.GetDrawObj("PMPID");
                Area.Variable[0] = D1.Variable[0];

		MessageBox.Show(D1.Variable[0].ToString());
	}
	else
	{
		Area.Visible = false;
	}
*/

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:Disposed 
public void PIC_CZ_PMPID_OK但2个MODE能同时选中_Disposed(Object sender, EventArgs e)
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
public void PIC_CZ_PMPID_OK但2个MODE能同时选中_OnDynClick(Object sender, EventArgs e)
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
//Event Delegate:KeyEventHandler 
//Event Handler:KeyUp 
public void PIC_CZ_PMPID_OK但2个MODE能同时选中_KeyUp(Object sender, KeyEventArgs e)
{
   DrawArea Area = (DrawArea)sender; 

  
	switch ( e.KeyData )
	{
		case Keys.Enter:

/*                           DrawRectangle Rect_CAS = (DrawRectangle)Area.GetDrawObj("Rect_CAS");
			    string tagName = Area.Variable[0] + "/MODE";
                            CommonFunction.DSI_SetValue(tagName, 3);
                            Rect_CAS.Variable[0] = "";
                            DrawText CAS = (DrawText)Area.GetDrawObj("CAS");
                            CAS.Variable[0] = "";

                            DrawArea pic = (DrawArea)(Area.Parent);
                            DrawArea Top = (DrawArea)pic.GetDrawObj("TDC3000_Top");
                            Top.Variable[3] = "";
*/
MessageBox.Show("Keyup");
			break;
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
public void CLR_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText CLR = (DrawText)dynArgs.sender; 

    Area.Visible = false;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void ACTIVE_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText ACTIVE = (DrawText)dynArgs.sender; 

    ACTIVE.ForegroundColor = Color.Lime;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void ACTIVE_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText ACTIVE = (DrawText)dynArgs.sender; 
   
    DrawRectangle PA_Rectangle = (DrawRectangle)Area.GetDrawObj("PA_Rectangle");

      if(PA_Rectangle.EdgeColor == Color.White)

	   { ACTIVE.ForegroundColor = Color.White; }

      else

           { ACTIVE.ForegroundColor = Color.Lime; }
  

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void PA_Rectangle_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle PA_Rectangle = (DrawRectangle)dynArgs.sender;
 
    PA_Rectangle.EdgeColor = Color.Lime; 

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

    Area.Variable[1] = "4";  
 
    PA_Rectangle.EdgeColor = Color.White;

    PA_Rectangle.Variable[0] = "PRESS ENTER TO EXECUTE";
    Area.Variable[3] = PA_Rectangle.Variable[0];

    DrawArea pic = (DrawArea)(Area.Parent);
    DrawArea Top = (DrawArea)pic.GetDrawObj("TDC3000_Top");
    Top.Variable[3] = PA_Rectangle.Variable[0];

    DrawText PTXST = (DrawText)Area.GetDrawObj("PTXST");
    PTXST.ForegroundColor = Color.White;

    DrawText ACTIVE = (DrawText)Area.GetDrawObj("ACTIVE");
    ACTIVE.ForegroundColor = Color.White;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void PA_Rectangle_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle PA_Rectangle = (DrawRectangle)dynArgs.sender; 
   
if(Area.Visible == false)

   {
    PA_Rectangle.EdgeColor = Color.Lime;

    DrawText PTXST = (DrawText)Area.GetDrawObj("PTXST");
    PTXST.ForegroundColor = Color.Lime;

    DrawText ACTIVE = (DrawText)Area.GetDrawObj("ACTIVE");
    ACTIVE.ForegroundColor = Color.Lime;
   }
    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynDblClick 
public void PA_Rectangle_OnDynDblClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle PA_Rectangle = (DrawRectangle)dynArgs.sender; 
   
    PA_Rectangle.EdgeColor = Color.Lime;
    DrawText PTXST = (DrawText)Area.GetDrawObj("PTXST");
    PTXST.ForegroundColor = Color.Lime;

    DrawText ACTIVE = (DrawText)Area.GetDrawObj("ACTIVE");
    ACTIVE.ForegroundColor = Color.Lime;

    DrawArea pic = (DrawArea)(Area.Parent);
    DrawArea Top = (DrawArea)pic.GetDrawObj("TDC3000_Top");
    Top.Variable[3] = "";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void PTXST_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PTXST = (DrawText)dynArgs.sender;
 
    PTXST.ForegroundColor = Color.Lime;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void PTXST_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PTXST = (DrawText)dynArgs.sender; 
 
    DrawRectangle PA_Rectangle = (DrawRectangle)Area.GetDrawObj("PA_Rectangle");

      if(PA_Rectangle.EdgeColor == Color.White)

	   { PTXST.ForegroundColor = Color.White; }

      else

           { PTXST.ForegroundColor = Color.Lime; }
  
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void PROG_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PROG = (DrawText)dynArgs.sender; 
   
    Area.Variable[4] = "NOT EMULATION";

    DrawArea pic = (DrawArea)(Area.Parent);
    DrawArea Top = (DrawArea)pic.GetDrawObj("TDC3000_Top");
    Top.Variable[4] = Area.Variable[4];

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void Rect_MAN_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect_MAN = (DrawRectangle)dynArgs.sender; 
   
    Rect_MAN.Variable[0] = "";
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	string tagName = Area.Variable[0] + "/MODE";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		if(dbValue==1)

			Rect_MAN.EdgeColor = Color.Cyan;

		else 

			Rect_MAN.EdgeColor = Color.Lime;
		
	}
	else
			Rect_MAN.EdgeColor = Color.Lime;


    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void Rect_MAN_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect_MAN = (DrawRectangle)dynArgs.sender; 
   
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	string tagName = Area.Variable[0] + "/MODE";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		if(Rect_MAN.Variable[0] == "")

                 {
		    if(dbValue==1)

			Rect_MAN.EdgeColor = Color.Cyan;

		    else

			Rect_MAN.EdgeColor = Color.Lime;
                  }

                 else

                  {
                     if(dbValue==1)

			Rect_MAN.EdgeColor = Color.Cyan;

		    else

			Rect_MAN.EdgeColor = Color.White;

                  }
        }
		
	else
	{
           Rect_MAN.EdgeColor = Color.Lime;
        }


if(Area.Visible == false)

   {
	Rect_MAN.EdgeColor = Color.Lime;
        Rect_MAN.Variable[0] = "";
   }

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
   
    Rect_MAN.Variable[0] = "PRESS ENTER TO EXECUTE";
    Area.Variable[3] = Rect_MAN.Variable[0];

    DrawArea pic = (DrawArea)(Area.Parent);
    DrawArea Top = (DrawArea)pic.GetDrawObj("TDC3000_Top");
    Top.Variable[3] = Rect_MAN.Variable[0];
 
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	string tagName = Area.Variable[0] + "/MODE";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
//            Area.Variable[1] = "1";
	    if(dbValue==1)
               {
		Rect_MAN.EdgeColor = Color.White;
                Rect_MAN.Variable[0] = "";
                DrawText MAN1 = (DrawText)Area.GetDrawObj("MAN");
                MAN1.ForegroundColor = Color.White;
                MAN1.Variable[0] = "";
   
                }
	    else

            {
                Rect_MAN.EdgeColor = Color.White; 
                DrawText MAN2 = (DrawText)Area.GetDrawObj("MAN");
                MAN2.ForegroundColor = Color.White; 
                MAN2.Variable[0] = "true";  
 
             }

	}

	else
             
           Rect_MAN.EdgeColor = Color.Lime;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynDblClick 
public void Rect_MAN_OnDynDblClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect_MAN = (DrawRectangle)dynArgs.sender; 
  
    Area.Variable[1] = "0";
 
    string tagName = Area.Variable[0] + "/MODE";
    CommonFunction.DSI_SetValue(tagName, 1);
    Rect_MAN.Variable[0] = "";
    DrawText MAN = (DrawText)Area.GetDrawObj("MAN");
    MAN.Variable[0] = "";

    DrawArea pic = (DrawArea)(Area.Parent);
    DrawArea Top = (DrawArea)pic.GetDrawObj("TDC3000_Top");
    Top.Variable[3] = "";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void MAN_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText MAN = (DrawText)dynArgs.sender; 

    MAN.Variable[0] = "";  
 
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	string tagName = Area.Variable[0] + "/MODE";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		if(dbValue==1)

			MAN.ForegroundColor = Color.Cyan;

		else 

			MAN.ForegroundColor = Color.Lime;
		
	}
	else
			MAN.ForegroundColor = Color.Lime;



    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void MAN_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText MAN = (DrawText)dynArgs.sender; 
   
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	string tagName = Area.Variable[0] + "/MODE";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);

        if(ret)
	{
		if(MAN.Variable[0] == "")

                 {
		    if(dbValue==1)

			MAN.ForegroundColor = Color.Cyan;

		    else

			MAN.ForegroundColor = Color.Lime;
                  }

                 else

                  {
                     if(dbValue==1)

			MAN.ForegroundColor = Color.Cyan;

		    else

			MAN.ForegroundColor = Color.White;
 
                  }		
		
	}
	else
			MAN.ForegroundColor = Color.Lime;

if(Area.Visible == false)

   {
    MAN.ForegroundColor = Color.Lime;
    MAN.Variable[0] = "";
   }
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void Rect_AUTO_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect_AUTO = (DrawRectangle)dynArgs.sender; 
   
    Rect_AUTO.Variable[0] = "";
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	string tagName = Area.Variable[0] + "/MODE";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		if(dbValue==2)

			Rect_AUTO.EdgeColor = Color.Cyan;

		else 

			Rect_AUTO.EdgeColor = Color.Lime;
		
	}
	else
			Rect_AUTO.EdgeColor = Color.Lime;


    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void Rect_AUTO_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect_AUTO = (DrawRectangle)dynArgs.sender; 
   
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	string tagName = Area.Variable[0] + "/MODE";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		if(Rect_AUTO.Variable[0] == "")

                 {
		    if(dbValue==2)

			Rect_AUTO.EdgeColor = Color.Cyan;

		    else

			Rect_AUTO.EdgeColor = Color.Lime;
                  }

                 else

                  {
                     if(dbValue==2)

			Rect_AUTO.EdgeColor = Color.Cyan;

		    else

			Rect_AUTO.EdgeColor = Color.White;

                  }
        }
		
	else
	{
            Rect_AUTO.EdgeColor = Color.Lime;
        }

if(Area.Visible == false)

   {
	Rect_AUTO.EdgeColor = Color.Lime;
        Rect_AUTO.Variable[0] = "";
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
   
    Rect_AUTO.Variable[0] = "PRESS ENTER TO EXECUTE";
    Area.Variable[3] = Rect_AUTO.Variable[0];

    DrawArea pic = (DrawArea)(Area.Parent);
    DrawArea Top = (DrawArea)pic.GetDrawObj("TDC3000_Top");
    Top.Variable[3] = Rect_AUTO.Variable[0];

	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	string tagName = Area.Variable[0] + "/MODE";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
//            Area.Variable[1] = "2";

	    if(dbValue==2)
               {
		Rect_AUTO.EdgeColor = Color.White;
                Rect_AUTO.Variable[0] = "";
                DrawText AUTO1 = (DrawText)Area.GetDrawObj("AUTO");
                AUTO1.ForegroundColor = Color.White;
                AUTO1.Variable[0] = "";
   
                }
	    else

            {
                Rect_AUTO.EdgeColor = Color.White;
                DrawText AUTO2 = (DrawText)Area.GetDrawObj("AUTO");
                AUTO2.ForegroundColor = Color.White; 
                AUTO2.Variable[0] = "true";   
 
             }

	}

	else
             
           Rect_AUTO.EdgeColor = Color.Lime;
    
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynDblClick 
public void Rect_AUTO_OnDynDblClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect_AUTO = (DrawRectangle)dynArgs.sender; 
   
    Area.Variable[1] = "0";

       string tagName = Area.Variable[0] + "/MODE";
       CommonFunction.DSI_SetValue(tagName, 2);
       Rect_AUTO.Variable[0] = "";
       DrawText AUTO = (DrawText)Area.GetDrawObj("AUTO");
       AUTO.Variable[0] = "";

    DrawArea pic = (DrawArea)(Area.Parent);
    DrawArea Top = (DrawArea)pic.GetDrawObj("TDC3000_Top");
    Top.Variable[3] = "";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void AUTO_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText AUTO = (DrawText)dynArgs.sender; 

    AUTO.Variable[0] = "";
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	string tagName = Area.Variable[0] + "/MODE";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		if(dbValue==2)

			AUTO.ForegroundColor = Color.Cyan;

		else 

			AUTO.ForegroundColor = Color.Lime;
		
	}
	else
			AUTO.ForegroundColor = Color.Lime;


    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void AUTO_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText AUTO = (DrawText)dynArgs.sender; 
   
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	string tagName = Area.Variable[0] + "/MODE";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		if(AUTO.Variable[0] == "")

                 {
		    if(dbValue==2)

			AUTO.ForegroundColor = Color.Cyan;

		    else

			AUTO.ForegroundColor = Color.Lime;
                  }

                 else

                  {
                     if(dbValue==2)

			AUTO.ForegroundColor = Color.Cyan;

		    else

			AUTO.ForegroundColor = Color.White;
 
                  }		
        }
		
	else
	{
            AUTO.ForegroundColor = Color.Lime;
        }
if(Area.Visible == false)

   {
    AUTO.ForegroundColor = Color.Lime;
    AUTO.Variable[0] = "";
   }
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void CAS_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText CAS = (DrawText)dynArgs.sender; 

    CAS.Variable[0] = "";
   

	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	string tagName = Area.Variable[0] + "/MODE";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		if(dbValue==3)

			CAS.ForegroundColor = Color.Cyan;

		else 

			CAS.ForegroundColor = Color.Lime;
		
	}
	else
			CAS.ForegroundColor = Color.Lime;

    return; 
}
 
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void CAS_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText CAS = (DrawText)dynArgs.sender; 
   
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	string tagName = Area.Variable[0] + "/MODE";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		if(CAS.Variable[0] == "")

                 {
		    if(dbValue==3)

			CAS.ForegroundColor = Color.Cyan;

		    else

			CAS.ForegroundColor = Color.Lime;
                  }

                 else

                  {
                     if(dbValue==3)

			CAS.ForegroundColor = Color.Cyan;

		    else

			CAS.ForegroundColor = Color.White;
 
                  }

	}
	else
			CAS.ForegroundColor = Color.Lime;

if(Area.Visible == false)

   {
    CAS.ForegroundColor = Color.Lime;
    CAS.Variable[0] = "";
   }
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void Rect_CAS_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect_CAS = (DrawRectangle)dynArgs.sender; 

    Rect_CAS.Variable[0] = "";
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	string tagName = Area.Variable[0] + "/MODE";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		if(dbValue==3)

			Rect_CAS.EdgeColor = Color.Cyan;

		else 

			Rect_CAS.EdgeColor = Color.Lime;
		
	}
	else
			Rect_CAS.EdgeColor = Color.Lime;

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void Rect_CAS_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect_CAS = (DrawRectangle)dynArgs.sender; 
   
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	string tagName = Area.Variable[0] + "/MODE";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		if(Rect_CAS.Variable[0] == "")

                 {
		    if(dbValue==3)

			Rect_CAS.EdgeColor = Color.Cyan;

		    else

			Rect_CAS.EdgeColor = Color.Lime;
                  }

                 else

                  {
                     if(dbValue==3)

			Rect_CAS.EdgeColor = Color.Cyan;

		    else

			Rect_CAS.EdgeColor = Color.White;
 
                  }
	}
	else
		{Rect_CAS.EdgeColor = Color.Lime;}

if(Area.Visible == false)

   {
	Rect_CAS.EdgeColor = Color.Lime;
        Rect_CAS.Variable[0] = "";
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
 
    Rect_CAS.Variable[0] = "PRESS ENTER TO EXECUTE";
    Area.Variable[3] = Rect_CAS.Variable[0];

    DrawArea pic = (DrawArea)(Area.Parent);
    DrawArea Top = (DrawArea)pic.GetDrawObj("TDC3000_Top");
    Top.Variable[3] = Rect_CAS.Variable[0];

	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	string tagName = Area.Variable[0] + "/MODE";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
//            Area.Variable[1] = "3";

	    if(dbValue==3)
               {
                Rect_CAS.EdgeColor = Color.White;
                Rect_CAS.Variable[0] = "";
                DrawText CAS0 = (DrawText)Area.GetDrawObj("CAS");
                CAS0.ForegroundColor = Color.White;
                CAS0.Variable[0] = "";
   
                }
	    else

            {
                Rect_CAS.EdgeColor = Color.White;
                DrawText CAS1 = (DrawText)Area.GetDrawObj("CAS");
                CAS1.ForegroundColor = Color.White; 
                CAS1.Variable[0] = "true";
             }
		
	}

	else
             
           Rect_CAS.EdgeColor = Color.Lime;

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynDblClick 
public void Rect_CAS_OnDynDblClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect_CAS = (DrawRectangle)dynArgs.sender; 

//    Area.Variable[1] = "0";

    string tagName = Area.Variable[0] + "/MODE";
    CommonFunction.DSI_SetValue(tagName, 3);
    Rect_CAS.Variable[0] = "";
    DrawText CAS = (DrawText)Area.GetDrawObj("CAS");
    CAS.Variable[0] = "";

    DrawArea pic = (DrawArea)(Area.Parent);
    DrawArea Top = (DrawArea)pic.GetDrawObj("TDC3000_Top");
    Top.Variable[3] = "";

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
public void OP_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText OP = (DrawText)dynArgs.sender; 
   
    OP.ForegroundColor = Color.White;
    DrawText Text_OP = (DrawText)Area.GetDrawObj("Text_OP");
    Text_OP.ForegroundColor = Color.White;

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
	
	tagName = Area.Variable[0] + "/PV";
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
		SP.Caption = dbValue.ToString(strDigit);
	}
	else
		SP.Caption = "##.#";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void SP_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText SP = (DrawText)dynArgs.sender; 
   
    SP.ForegroundColor = Color.White;
    DrawText Text_SP = (DrawText)Area.GetDrawObj("Text_SP");
    Text_SP.ForegroundColor = Color.White;

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
				CommonFunction.MoveControl(Area,TB,(int)(SP.VerticalPosition + 30),(int)(SP.HorizontalPosition)+40);		
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
public void PV_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PV = (DrawText)dynArgs.sender; 
  
    PV.ForegroundColor = Color.White;
    DrawText Text_PV = (DrawText)Area.GetDrawObj("Text_PV");
    Text_PV.ForegroundColor = Color.White;

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
//Event Handler:OnDynInitialize 
public void TagName_OnDynInitialize(Object sender, EventArgs e)	//TagName
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawText TagName = (DrawText)dynArgs.sender; 

        
	
	return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void TagName_OnDynClick(Object sender, EventArgs e)
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
public void TagName_OnDynAnimation(Object sender, EventArgs e)
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
public void Close_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle CLR = (DrawRectangle)dynArgs.sender; 
   
    Area.Visible = false;

    DrawArea pic = (DrawArea)(Area.Parent);
    DrawArea Top = (DrawArea)pic.GetDrawObj("TDC3000_Top");
    Top.Variable[3] = "";
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


}
