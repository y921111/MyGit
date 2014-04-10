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
public class PIC_CZ_PMPID_三个TB:IDynCodeAttachDetach
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
_EventHandler= (EventHandler)PIC_CZ_PMPID_三个TB_OnDynInitialize;
CodeDomCommon.AttachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "Disposed";
_EventHandler= (EventHandler)PIC_CZ_PMPID_三个TB_Disposed;
CodeDomCommon.AttachAreaEventHandler(area,strEventName,_EventHandler);
strObjectName = "Text_SP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Text_SP_OnDynInitialize;
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
strObjectName = "PTXST";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PTXST_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PTXST";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PTXST_OnDynAnimation;
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
strObjectName = "PVTB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)PVTB_KeyUp;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "OPTB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)OPTB_KeyUp;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "SPTB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)SPTB_KeyUp;
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
_EventHandler= (EventHandler)PIC_CZ_PMPID_三个TB_OnDynInitialize;
CodeDomCommon.DetachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "Disposed";
_EventHandler= (EventHandler)PIC_CZ_PMPID_三个TB_Disposed;
CodeDomCommon.DetachAreaEventHandler(area,strEventName,_EventHandler);
strObjectName = "Text_SP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Text_SP_OnDynInitialize;
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
strObjectName = "PTXST";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PTXST_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PTXST";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PTXST_OnDynAnimation;
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
strObjectName = "PVTB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)PVTB_KeyUp;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "OPTB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)OPTB_KeyUp;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "SPTB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)SPTB_KeyUp;
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
public void PIC_CZ_PMPID_三个TB_OnDynInitialize(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender;
	
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
/*                        Area.Variable[3] = MainArea.Variable[3];
                        Area.Variable[4] = MainArea.Variable[4];
                        Area.Variable[5] = MainArea.Variable[5];
                        Area.Variable[6] = MainArea.Variable[6];
*/
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
      TextBox PVTB = (TextBox)Area.GetDrawObj("PVTB");

        if(PVTB.CanFocus)
	{
		PVTB.Focus();
	}
	else
	{
		Area.Enabled = true;	//首先确保PVTB的容器Area的Enabled为True，否则PVTB.CanFocus=false；
		PVTB.Enabled = true;
		PVTB.Visible = true;
		PVTB.Focus();
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
public void PIC_CZ_PMPID_三个TB_Disposed(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 

   TextBox PVTB = (TextBox)Area.GetDrawObj("PVTB");
   PVTB.Enabled = false;
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
   
    PA_Rectangle.EdgeColor = Color.White;

    PA_Rectangle.Variable[0] = "true";
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
//Event Handler:OnDynInitialize 
public void Rect_MAN_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect_MAN = (DrawRectangle)dynArgs.sender; 
   
    Rect_MAN.Variable[0] = "false";
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
		if(Rect_MAN.Variable[0] == "false")

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
   
    Rect_MAN.Variable[0] = "true";
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
	    if(dbValue==1)
               {
		Rect_MAN.EdgeColor = Color.Cyan;
                Rect_MAN.Variable[0] = "false";
   
                }
	    else

            {
                Rect_MAN.EdgeColor = Color.White;    
 
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
   
    string tagName = Area.Variable[0] + "/MODE";
    CommonFunction.DSI_SetValue(tagName, 1);
    Rect_MAN.Variable[0] = "false";

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
		if(dbValue==1)

                 {
                        DrawRectangle Rect_MAN = (DrawRectangle)Area.GetDrawObj("Rect_MAN");

                        if(Rect_MAN.EdgeColor == Color.White)

			   { MAN.ForegroundColor = Color.White; }

                        else

                           { MAN.ForegroundColor = Color.Cyan; }

                  }

                else 

                {
                    DrawRectangle Rect_MAN = (DrawRectangle)Area.GetDrawObj("Rect_MAN");

                        if(Rect_MAN.EdgeColor == Color.White)

			   { MAN.ForegroundColor = Color.White; }

                        else

                           { MAN.ForegroundColor = Color.Lime; }
                 }
		
	}
	else
			MAN.ForegroundColor = Color.Lime;

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
   
    Rect_AUTO.Variable[0] = "false";
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
		if(Rect_AUTO.Variable[0] == "false")

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
   
    Rect_AUTO.Variable[0] = "true";
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
	    if(dbValue==2)
               {
		Rect_AUTO.EdgeColor = Color.Cyan;
                Rect_AUTO.Variable[0] = "false";
   
                }
	    else

            {
                Rect_AUTO.EdgeColor = Color.White;    
 
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
   
	       string tagName = Area.Variable[0] + "/MODE";
	       CommonFunction.DSI_SetValue(tagName, 2);
               Rect_AUTO.Variable[0] = "false";

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

    AUTO.Variable[0] = "false";
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
		if(dbValue==2)

                 {
                        DrawRectangle Rect_AUTO = (DrawRectangle)Area.GetDrawObj("Rect_AUTO");

                        if(Rect_AUTO.EdgeColor == Color.White)

			   { AUTO.ForegroundColor = Color.White; }

                        else

                           { AUTO.ForegroundColor = Color.Cyan; }

                  }

                else 

                {
                    DrawRectangle Rect_AUTO = (DrawRectangle)Area.GetDrawObj("Rect_AUTO");

                        if(Rect_AUTO.EdgeColor == Color.White)

			   { AUTO.ForegroundColor = Color.White; }

                        else

                           { AUTO.ForegroundColor = Color.Lime; }
                 }

		
        }
		
	else
	{
            AUTO.ForegroundColor = Color.Lime;
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

    CAS.Variable[0] = "false";
   

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
                if(dbValue==3)

                 {
                        DrawRectangle Rect_CAS = (DrawRectangle)Area.GetDrawObj("Rect_CAS");

                        if(Rect_CAS.EdgeColor == Color.White)

			   { CAS.ForegroundColor = Color.White; }

                        else

                           { CAS.ForegroundColor = Color.Cyan; }

                  }

                else 

                {
                    DrawRectangle Rect_CAS = (DrawRectangle)Area.GetDrawObj("Rect_CAS");

                        if(Rect_CAS.EdgeColor == Color.White)

			   { CAS.ForegroundColor = Color.White; }

                        else

                           { CAS.ForegroundColor = Color.Lime; }
                 }
		
	}
	else
			CAS.ForegroundColor = Color.Lime;

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

    Rect_CAS.Variable[0] = "false";//有没有选中
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
		if(Rect_CAS.Variable[0] == "false")

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
			Rect_CAS.EdgeColor = Color.Lime;

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
 
    Rect_CAS.Variable[0] = "true";
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
	    if(dbValue==3)
               {
		Rect_CAS.EdgeColor = Color.Cyan;
                Rect_CAS.Variable[0] = "false";
   
                }
	    else

            {
                Rect_CAS.EdgeColor = Color.White;    
 
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

	       string tagName = Area.Variable[0] + "/MODE";
	       CommonFunction.DSI_SetValue(tagName, 3);
               Rect_CAS.Variable[0] = "false";
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
		object obj = Area.GetControlObj("OPTB");
		if(obj != null)
		{
			TextBox OPTB = (TextBox)obj; 
			if(OPTB != null)
			{
				OPTB.Visible = true;
				OPTB.Enabled = true;
				OPTB.Text = "";
				OPTB.Focus();
				
				obj = CommonFunction.GetLabelOfControl(OPTB);
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
		object obj = Area.GetControlObj("SPTB");
		if(obj != null)
		{
			TextBox SPTB = (TextBox)obj; 
			if(SPTB != null)
			{
				SPTB.Visible = true;
				SPTB.Enabled = true;
				SPTB.Text = "";
				SPTB.Focus();
				
				obj = CommonFunction.GetLabelOfControl(SPTB);
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
		object obj = Area.GetControlObj("PVTB");
		if(obj != null)
		{
			TextBox PVTB = (TextBox)obj; 
			if(PVTB != null)
			{
				PVTB.Visible = true;
				PVTB.Enabled = true;
				PVTB.Text = "";
				PVTB.Focus();
				
				obj = CommonFunction.GetLabelOfControl(PVTB);
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
    Top.Variable[3] = "false";

    return; 
}
//Do not remove or update this comment
//Event Delegate:KeyEventHandler 
//Event Handler:KeyUp 
public void PVTB_KeyUp(Object sender, KeyEventArgs e)
{
   TextBox PVTB = (TextBox)sender; 
   
DrawArea Area = CommonFunction.GetThisDrawArea(PVTB);


	DrawText PV = (DrawText)Area.GetDrawObj("PV");
        DrawText Text_PV = (DrawText)Area.GetDrawObj("Text_PV");

	switch ( e.KeyData )
	{
	case Keys.Enter:

		if(PVTB.Text == "" || PVTB.Text == null)

		{
			PVTB.Visible = false;
			PVTB.Enabled = false;
			PV.Visible = true;
			return;
		}

		else

		{
			string PVInputValue = PVTB.Text;
			double dbPVValue = Convert.ToDouble(PVInputValue);

			object obj1 = CommonFunction.GetLabelOfControl(PVTB);

			if (obj1 != null)

			{

                           double dbValue = 0;
	                   int nValue = 0;
	                   bool bValue = false;
	                   int nDataType = 0;

	                   string MODE = Area.Variable[0] + "/MODE";

	          bool ret = CommonFunction.GetValueWithType(MODE,ref dbValue,ref nValue,ref bValue,ref nDataType);

	                       if(ret)

	                      {
	                 	if(dbValue==1)

				    {
                                        ControlLabel lab = (ControlLabel)obj1;
				        string tagName = lab.Variable[0];
				        CommonFunction.DSI_SetValue(tagName, dbPVValue);}

	                	else 
                                    {
			                DrawArea pic = (DrawArea)(Area.Parent);
                                        DrawArea Top = (DrawArea)pic.GetDrawObj("TDC3000_Top");
                                        Area.Variable[4] = "MODE ERROR";

                                    }
		
	                       }
	                       else
                               {
			           DrawArea pic = (DrawArea)(Area.Parent);
                                   DrawArea Top = (DrawArea)pic.GetDrawObj("TDC3000_Top");
                                   Area.Variable[4] = "MODE ERROR";

                                }

			}      
                        PVTB.ForeColor = Color.Lime;
			PVTB.Visible = false;
			PVTB.Enabled = false;
			PV.Visible = true;
                        PV.ForegroundColor = Color.Cyan;
                        Text_PV.ForegroundColor = Color.Cyan;
		}
		break;
	}
    return; 
}

//Do not remove or update this comment
//Event Delegate:KeyEventHandler 
//Event Handler:KeyUp 
public void OPTB_KeyUp(Object sender, KeyEventArgs e)
{
   TextBox OPTB = (TextBox)sender; 

	DrawArea Area = CommonFunction.GetThisDrawArea(OPTB);

	DrawText SP = (DrawText)Area.GetDrawObj("SP");
	DrawText OP = (DrawText)Area.GetDrawObj("OP");
        DrawText Text_SP = (DrawText)Area.GetDrawObj("Text_OP");

	switch ( e.KeyData )
	{
	case Keys.Enter:

		if(OPTB.Text == "" || OPTB.Text == null)

		{
			OPTB.Visible = false;
			OPTB.Enabled = false;
			SP.Visible = true;
			OP.Visible = true;
			return;
		}

		else

		{
			string SPInputValue = OPTB.Text;
			double dbSPValue = Convert.ToDouble(SPInputValue);

			object obj = CommonFunction.GetLabelOfControl(OPTB);

			if (obj != null)

			{
				ControlLabel lab = (ControlLabel)obj;
				string tagName = lab.Variable[0];
				CommonFunction.DSI_SetValue(tagName, dbSPValue);
			}
                        OPTB.ForeColor = Color.Lime;
			OPTB.Visible = false;
			OPTB.Enabled = false;
			SP.Visible = true;
			OP.Visible = true;
                        OP.ForegroundColor = Color.Yellow; 
                        Text_SP.ForegroundColor = Color.Yellow;
		}
		break;
	}
   
    return; 
}
//Do not remove or update this comment
//Event Delegate:KeyEventHandler 
//Event Handler:KeyUp 
public void SPTB_KeyUp(Object sender, KeyEventArgs e)
{
   TextBox SPTB = (TextBox)sender; 
   
DrawArea Area = CommonFunction.GetThisDrawArea(SPTB);

	DrawText SP = (DrawText)Area.GetDrawObj("SP");
	DrawText OP = (DrawText)Area.GetDrawObj("OP");
        DrawText Text_SP = (DrawText)Area.GetDrawObj("Text_SP");

	switch ( e.KeyData )
	{
	case Keys.Enter:

		if(SPTB.Text == "" || SPTB.Text == null)

		{
			SPTB.Visible = false;
			SPTB.Enabled = false;
			SP.Visible = true;
			OP.Visible = true;
			return;
		}

		else

		{
			string SPInputValue = SPTB.Text;
			double dbSPValue = Convert.ToDouble(SPInputValue);

			object obj = CommonFunction.GetLabelOfControl(SPTB);

			if (obj != null)

			{
				ControlLabel lab = (ControlLabel)obj;
				string tagName = lab.Variable[0];
				CommonFunction.DSI_SetValue(tagName, dbSPValue);
			}
                        SPTB.ForeColor = Color.Lime;
			SPTB.Visible = false;
			SPTB.Enabled = false;
			SP.Visible = true;
			OP.Visible = true;
                        SP.ForegroundColor = Color.Cyan;
                        Text_SP.ForegroundColor = Color.Cyan;
		}
		break;
	}
    return; 
}

}
