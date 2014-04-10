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
public class PIC_Pks_fp_PID:IDynCodeAttachDetach
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
_EventHandler= (EventHandler)PIC_Pks_fp_PID_OnDynInitialize;
CodeDomCommon.AttachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "OnDynFinalize";
_EventHandler= (EventHandler)PIC_Pks_fp_PID_OnDynFinalize;
CodeDomCommon.AttachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PIC_Pks_fp_PID_OnDynClick;
CodeDomCommon.AttachAreaEventHandler(area,strEventName,_EventHandler);
strObjectName = "PVUnit2";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PVUnit2_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVUnit1";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PVUnit1_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Alm";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Alm_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Alm";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Alm_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Ack";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Ack_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Mode_Combox";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Mode_Combox_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Mode_Combox";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Mode_Combox_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SPUp0";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)SPUp0_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SPDown0";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)SPDown0_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OPUp";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)OPUp_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OPDown";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)OPDown_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SPDown";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)SPDown_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SPUp";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)SPUp_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SPBtn";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)SPBtn_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SPBtn";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)SPBtn_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OPBar";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)OPBar_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OPBar";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)OPBar_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PV_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PV_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)OP_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)OP_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OP";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)OP_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)SP_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)SP_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SP";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)SP_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVBar";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PVBar_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVBar";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVBar_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVUnit";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PVUnit_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SL";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)SL_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SL";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)SL_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SH";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)SH_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SH";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)SH_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TagComment";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)TagComment_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TagComment";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TagComment_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TagName";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)TagName_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TagName";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)TagName_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Mode";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Mode_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Mode";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Mode_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Mode";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Mode_OnDynClick;
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
_EventHandler= (EventHandler)PIC_Pks_fp_PID_OnDynInitialize;
CodeDomCommon.DetachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "OnDynFinalize";
_EventHandler= (EventHandler)PIC_Pks_fp_PID_OnDynFinalize;
CodeDomCommon.DetachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PIC_Pks_fp_PID_OnDynClick;
CodeDomCommon.DetachAreaEventHandler(area,strEventName,_EventHandler);
strObjectName = "PVUnit2";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PVUnit2_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVUnit1";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PVUnit1_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Alm";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Alm_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Alm";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Alm_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Ack";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Ack_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Mode_Combox";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Mode_Combox_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Mode_Combox";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Mode_Combox_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SPUp0";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)SPUp0_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SPDown0";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)SPDown0_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OPUp";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)OPUp_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OPDown";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)OPDown_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SPDown";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)SPDown_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SPUp";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)SPUp_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SPBtn";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)SPBtn_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SPBtn";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)SPBtn_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OPBar";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)OPBar_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OPBar";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)OPBar_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PV_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PV_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)OP_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)OP_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OP";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)OP_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)SP_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)SP_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SP";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)SP_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVBar";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PVBar_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVBar";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVBar_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVUnit";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PVUnit_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SL";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)SL_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SL";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)SL_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SH";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)SH_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SH";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)SH_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TagComment";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)TagComment_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TagComment";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TagComment_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TagName";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)TagName_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TagName";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)TagName_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Mode";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Mode_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Mode";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Mode_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Mode";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Mode_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)TB_KeyUp;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);

    return;
}

// =========================================================================================
//
// Note: For 大连恒利项目，点击TagNmae弹出Detail画面的功能被屏蔽掉
//
// =========================================================================================
//Do not remove or update this comment
//Event Delegate:EventHandler
//Event Handler:OnDynInitialize
public void PIC_Pks_fp_PID_OnDynInitialize(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender;
	DynEventArgs dynArgs = (DynEventArgs)e;
	DrawArea drawArea = (DrawArea)dynArgs.sender;

	Area.Enabled = true;

	object obj = Area.GetControlObj("TB");
	if(obj != null)
	{
		TextBox TB = (TextBox)obj; 
		if(TB != null)
		{
			TB.Visible = false;
			TB.Enabled = false;
		}
	}

	Picture pic = CommonFunction.GetThisPicture(Area);
	if(pic != null)
	{

		if(Area.BReference)//图素
		{
			//将顶级DrawArea的Variable[0]变量传递到图素级DrawArea：
			DrawArea MainArea = pic.GetDrawArea();
			Area.Variable[0] = MainArea.Variable[0];

			ControlLabel lab = (ControlLabel)CommonFunction.GetLabelOfControl(Area);
			lab.Selected = false;
			/*
			//20120312，根据Zoom因子，重置TB的Font.Size：
			PointF sF = Area.GetScaleFactor();
			//float sFX = sF.X;
			float sFY = sF.Y;
			TextBox TB = (TextBox)(Area.GetControlObj("TB"));
			lab = (ControlLabel)(CommonFunction.GetLabelOfControl(TB));
			
			//在修改Size之前，将原始的Size保存，由Run态返回编辑态时再将原始的Size反写回去：
			lab.Variable[1] = TB.Font.Size.ToString();
			
			int nSize = (int)(TB.Font.Size/sFY);
			TB.Font = new Font("Arial", nSize);
			lab.m_rect.Height = nSize;
			*/
		}
		else
		{
			pic.Text = Area.Variable[0];
		}
	}
	Area.Variable[0] = Area.Variable[0].ToUpper();
	return;
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynFinalize 
public void PIC_Pks_fp_PID_OnDynFinalize(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 
/*
//	Area.Enabled = false;
	if(Area.BReference)//图素
	{
		TextBox TB = (TextBox)(Area.GetControlObj("TB"));
		ControlLabel lab = (ControlLabel)(CommonFunction.GetLabelOfControl(TB));

		//在修改Size之前，将原始的Size保存，由Run态返回编辑态时再将原始的Size反写回去：
		int nSize = Convert.ToInt32(lab.Variable[1]);
		TB.Font = new Font("Arial", nSize);
		lab.m_rect.Height = nSize;
	}
*/
    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler
//Event Handler:OnDynClick
public void PIC_Pks_fp_PID_OnDynClick(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender;
	DynEventArgs dynArgs = (DynEventArgs)e;
	DrawArea drawArea = (DrawArea)dynArgs.sender;
	object obj = Area.GetControlObj("TB");
	if (obj != null)
	{
		TextBox TB = (TextBox)obj;
		//Area.Enabled = false;
		TB.Visible = false;
		TB.Enabled = false;
		DrawText SP = (DrawText)Area.GetDrawObj("SP");
		SP.Visible = true;
		DrawText OP = (DrawText)Area.GetDrawObj("OP");
		OP.Visible = true;
	}
	return;
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void PVUnit2_OnDynInitialize(Object sender, EventArgs e)
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
public void PVUnit1_OnDynInitialize(Object sender, EventArgs e)
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
public void Alm_OnDynInitialize(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawBitmap Alm = (DrawBitmap)dynArgs.sender; 
	DrawText txtAlm = (DrawText)Area.GetDrawObj("txtAlm");

	Alm.Visible = false;
	txtAlm.Caption = "";

	int nAlmSta = CommonFunction.GetTagAlarmStatus( Area.Variable[0] );

	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	string tagName = Area.Variable[0] + "/" + Alm.Variable[0];
	if(CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType))
	{
		if(dbValue == 3)
			txtAlm.Caption = "PV_HiHiHi";
		else if(dbValue == 2)
			txtAlm.Caption = "PV_HiHi";
		else if(dbValue == 1)
			txtAlm.Caption = "PV_High";
		else if(dbValue == -1)
			txtAlm.Caption = "PV_Low";
		else if(dbValue == -2)
			txtAlm.Caption = "PV_LoLo";
		else if(dbValue == -3)
			txtAlm.Caption = "PV_LoLoLo";

		if( dbValue==3 || dbValue==2 || dbValue==-2 || dbValue==-3 )
		{
			if( nAlmSta==2 || nAlmSta==3 )
			{
				Alm.Visible = true;
				Alm.ImageFile = "Pks_fpPID_Alm1_b.png";
			}
		}
		else if( dbValue==1 || dbValue==-1 )
		{
			if( nAlmSta==2 || nAlmSta==3 )
			{
				Alm.Visible = true;
				Alm.ImageFile = "Pks_fpPID_Alm_b.png";
			}
		}
	}
	return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void Alm_OnDynAnimation(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawBitmap Alm = (DrawBitmap)dynArgs.sender; 
	DrawText txtAlm = (DrawText)Area.GetDrawObj("txtAlm");

	Alm.Visible = false;
	txtAlm.Caption = "";

	int nAlmSta = CommonFunction.GetTagAlarmStatus( Area.Variable[0] );

	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	string tagName = Area.Variable[0] + "/" + Alm.Variable[0];
	if(CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType))
	{
		if(dbValue == 3)
			txtAlm.Caption = "PV_HiHiHi";
		else if(dbValue == 2)
			txtAlm.Caption = "PV_HiHi";
		else if(dbValue == 1)
			txtAlm.Caption = "PV_High";
		else if(dbValue == -1)
			txtAlm.Caption = "PV_Low";
		else if(dbValue == -2)
			txtAlm.Caption = "PV_LoLo";
		else if(dbValue == -3)
			txtAlm.Caption = "PV_LoLoLo";

		if( dbValue==3 || dbValue==2 || dbValue==-2 || dbValue==-3 )
		{
			Alm.Visible = true;
			if( nAlmSta==2 )
			{
				if(Alm.ImageFile == "Pks_fpPID_Alm1_b.png")
					Alm.ImageFile = "Pks_fpPID_Alm1_w.png";
				else
					Alm.ImageFile = "Pks_fpPID_Alm1_b.png";
			}
		}
		else if( dbValue==1 || dbValue==-1 )
		{
			Alm.Visible = true;
			if( nAlmSta==2 )
			{
				Alm.Visible = true;
				if(Alm.ImageFile == "Pks_fpPID_Alm_b.png")
					Alm.ImageFile = "Pks_fpPID_Alm_w.png";
				else
					Alm.ImageFile = "Pks_fpPID_Alm_b.png";
			}
		}
	}
	return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void Ack_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawButton Ack = (DrawButton)dynArgs.sender; 
   
	CommonFunction.AlarmAckItem(Area.Variable[0]);
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void Mode_Combox_OnDynInitialize(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawButton Combox= (DrawButton)dynArgs.sender; 
	DrawText Mode = (DrawText)Area.GetDrawObj("Mode");
/*
	PointF sF = Area.GetScaleFactor();
	PointF sF1 = new PointF(1,1);

	//控制组中的面板：
	if(Area.BReference)
	{
		DrawArea TopArea = (DrawArea)(Area.Parent);
		sF1 = TopArea.GetScaleFactor();
		MessageBox.Show(sF1.X.ToString());
	}

	Combox.Variable[0] = Area.Variable[0]+"/MODE";
	Combox.Variable[1] = "MAN-1/AUTO-2/CAS-3";
	Combox.Variable[2] = (Mode.Width/sF.X/sF1.X).ToString();
	Combox.Variable[3] = (Mode.Height*3/sF.Y/sF1.Y).ToString();
*/
	return; 
}


//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void Mode_Combox_OnDynClick(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawButton Mode_Combox = (DrawButton)dynArgs.sender; 
	DrawText Mode = (DrawText)Area.GetDrawObj("Mode");

	//=====================================
	PointF sF = Area.GetScaleFactor();
	Mode_Combox.Variable[0] = Area.Variable[0]+"/MODE";
	Mode_Combox.Variable[1] = "MAN-1/AUTO-2/CAS-3";
	Mode_Combox.Variable[2] = (Mode.Width/sF.X).ToString();
	Mode_Combox.Variable[3] = (Mode.Height*3/sF.Y).ToString();


	string picName = "Pks_fp_PID_Combox.grf";
	//=====================================
	int nTop = (int)Mode.VerticalPosition + (int)Mode.Height;
	int nLeft = (int)Mode.HorizontalPosition;

	//面板：
	Picture pic = null;
	object obj = Area.Parent;
	Type type = obj.GetType();
	if( type.Name == "Picture" )
	{
		pic = (Picture)(Area.Parent);
		nTop = nTop + pic.Top + 32 - 8; //22为窗口Header的高度；
		nLeft = nLeft + pic.Left + 4; //4为窗口左侧边的宽度；
	} 

	//控制组中的面板：
	if(Area.BReference)
	{
		DrawArea TopArea = (DrawArea)(Area.Parent);
		//PointF sF = Area.GetScaleFactor();
		PointF sFTop = TopArea.GetScaleFactor();

		ControlLabel lab = (ControlLabel)CommonFunction.GetLabelOfControl(Area);
		pic = (Picture)(Area.Parent.Parent);
		nLeft = (int)(nLeft/sF.X + lab.m_rect.X/sFTop.X + pic.Left + 4); //4为窗口左侧边的宽度；
		nTop = (int)(nTop/sF.Y + lab.m_rect.Y/sFTop.Y + pic.Top + 30); //30为窗口Header的高度；
	}

	//=====================================
	string[] strVariable = new string[10];
	for ( int i=0;i<10;i++ )
	{
		strVariable[i] = Mode_Combox.Variable[i];
	}

	//=====================================
	CommonFunction.OpenPicture(picName,nTop,nLeft,strVariable);
	return; 
}//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void SPUp0_OnDynClick(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawRectangle SPUp = (DrawRectangle)dynArgs.sender; 
  
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;
	
	double dbSpan = 0.01;

 	// get SH SL
 	//================================
	double dbSH = 100;
	double dbSL = 0;

	string tagName = Area.Variable[0] + "/PVEUHI";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
		dbSH = dbValue;

	tagName = Area.Variable[0] + "/PVEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
		dbSL = dbValue;

	dbSpan = ( dbSH - dbSL )*dbSpan;

	tagName = Area.Variable[0] + "/SP";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		double tmp = dbValue+dbSpan;
		if(tmp > dbSH)
			tmp = dbSH;
		if(tmp < dbSL)
			tmp = dbSL;
		CommonFunction.DSI_SetValue(tagName, tmp);
	}
	return; 
}//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void SPDown0_OnDynClick(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawRectangle SPUp = (DrawRectangle)dynArgs.sender; 
  
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;
	
	double dbSpan = 0.01;

 	// get SH SL
 	//================================
	double dbSH = 100;
	double dbSL = 0;

	string tagName = Area.Variable[0] + "/PVEUHI";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
		dbSH = dbValue;

	tagName = Area.Variable[0] + "/PVEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
		dbSL = dbValue;

	dbSpan = ( dbSH - dbSL )*dbSpan;

	tagName = Area.Variable[0] + "/SP";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		double tmp = dbValue-dbSpan;
		if(tmp > dbSH)
			tmp = dbSH;
		if(tmp < dbSL)
			tmp = dbSL;
		CommonFunction.DSI_SetValue(tagName, tmp);
	}
	return; 
}// =====================================================================
//
// Fast Up Button:  10%   For SP or OP
//
// =====================================================================
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void OPUp_OnDynClick(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawRectangle SPUp = (DrawRectangle)dynArgs.sender; 
  
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;
	
	double dbSpan = 0.1;	// Fast UP --> 10%

 	// Check updated object is SP or OP
 	//================================
	bool bModifyV = false;
	bool bModifySP = false;
	DrawText txtMode = (DrawText)Area.GetDrawObj("Mode");
	if( txtMode != null)
	{
		if( txtMode.Caption == "AUTO")
		{
			bModifyV = true; 
			bModifySP = true; 
		}
		else if( txtMode.Caption == "MAN")
		{
			bModifyV = true; 			
		}
	}

	if( !bModifyV ) return;	

 	// get SH SL
 	//================================
	double dbSH = 100;
	double dbSL = 0;

	string tagName = "";
	bool ret = true;
	if( bModifySP )
	{
		tagName = Area.Variable[0] + "/PVEUHI";
		ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
		if(ret)
			dbSH = dbValue;

		tagName = Area.Variable[0] + "/PVEULO";
		ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
		if(ret)
			dbSL = dbValue;

		tagName = Area.Variable[0] + "/SP";
	}
	else
	{
		tagName = Area.Variable[0] + "/OP";
	}

	dbSpan = ( dbSH - dbSL )*dbSpan;

	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		double tmp = dbValue+dbSpan;
		if(tmp > dbSH)
			tmp = dbSH;
		if(tmp < dbSL)
			tmp = dbSL;
		CommonFunction.DSI_SetValue(tagName, tmp);
	}
	return; 


}// =====================================================================
//
// Fast Down Button:  10%   For SP or OP
//
// =====================================================================
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void OPDown_OnDynClick(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawRectangle SPUp = (DrawRectangle)dynArgs.sender; 
  
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;
	
	double dbSpan = 0.1;	// Fast Down --> 10%

 	// Check updated object is SP or OP
 	//================================
	bool bModifyV = false;
	bool bModifySP = false;
	DrawText txtMode = (DrawText)Area.GetDrawObj("Mode");
	if( txtMode != null)
	{
		if( txtMode.Caption == "AUTO")
		{
			bModifyV = true; 
			bModifySP = true; 
		}
		else if( txtMode.Caption == "MAN")
		{
			bModifyV = true; 			
		}
	}

	if( !bModifyV ) return;	

 	// get SH SL
 	//================================
	double dbSH = 100;
	double dbSL = 0;

	string tagName = "";
	bool ret = true;
	if( bModifySP )
	{
		tagName = Area.Variable[0] + "/PVEUHI";
		ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
		if(ret)
			dbSH = dbValue;

		tagName = Area.Variable[0] + "/PVEULO";
		ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
		if(ret)
			dbSL = dbValue;

		tagName = Area.Variable[0] + "/SP";
	}
	else
	{
		tagName = Area.Variable[0] + "/OP";
	}

	dbSpan = ( dbSH - dbSL )*dbSpan;

	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		double tmp = dbValue-dbSpan;
		if(tmp > dbSH)
			tmp = dbSH;
		if(tmp < dbSL)
			tmp = dbSL;
		CommonFunction.DSI_SetValue(tagName, tmp);
	}
	return; 
}// =====================================================================
//
// Down Button:  1%   For SP or OP
//
// =====================================================================
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void SPDown_OnDynClick(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawRectangle SPUp = (DrawRectangle)dynArgs.sender; 
  
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;
	
	double dbSpan = 0.01;

 	// Check updated object is SP or OP
 	//================================
	bool bModifyV = false;
	bool bModifySP = false;
	DrawText txtMode = (DrawText)Area.GetDrawObj("Mode");
	if( txtMode != null)
	{
		if( txtMode.Caption == "AUTO")
		{
			bModifyV = true; 
			bModifySP = true; 
		}
		else if( txtMode.Caption == "MAN")
		{
			bModifyV = true; 			
		}
	}

	if( !bModifyV ) return;	

 	// get SH SL
 	//================================
	double dbSH = 100;
	double dbSL = 0;

	string tagName = "";
	bool ret = true;
	if( bModifySP )
	{
		tagName = Area.Variable[0] + "/PVEUHI";
		ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
		if(ret)
			dbSH = dbValue;

		tagName = Area.Variable[0] + "/PVEULO";
		ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
		if(ret)
			dbSL = dbValue;

		tagName = Area.Variable[0] + "/SP";
	}
	else
	{
		tagName = Area.Variable[0] + "/OP";
	}

	dbSpan = ( dbSH - dbSL )*dbSpan;

	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		double tmp = dbValue-dbSpan;
		if(tmp > dbSH)
			tmp = dbSH;
		if(tmp < dbSL)
			tmp = dbSL;
		CommonFunction.DSI_SetValue(tagName, tmp);
	}
	return; 
}// =====================================================================
//
// Up Button:  1%   For SP or OP
//
// =====================================================================
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void SPUp_OnDynClick(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawRectangle SPUp = (DrawRectangle)dynArgs.sender; 
  
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;
	
	double dbSpan = 0.01;

 	// Check updated object is SP or OP
 	//================================
	bool bModifyV = false;
	bool bModifySP = false;
	DrawText txtMode = (DrawText)Area.GetDrawObj("Mode");
	if( txtMode != null)
	{
		if( txtMode.Caption == "AUTO")
		{
			bModifyV = true; 
			bModifySP = true; 
		}
		else if( txtMode.Caption == "MAN")
		{
			bModifyV = true; 			
		}
	}

	if( !bModifyV ) return;	

 	// get SH SL
 	//================================
	double dbSH = 100;
	double dbSL = 0;

	string tagName = "";
	bool ret = true;
	if( bModifySP )
	{
		tagName = Area.Variable[0] + "/PVEUHI";
		ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
		if(ret)
			dbSH = dbValue;

		tagName = Area.Variable[0] + "/PVEULO";
		ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
		if(ret)
			dbSL = dbValue;

		tagName = Area.Variable[0] + "/SP";
	}
	else
	{
		tagName = Area.Variable[0] + "/OP";
	}

	dbSpan = ( dbSH - dbSL )*dbSpan;

	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		double tmp = dbValue+dbSpan;
		if(tmp > dbSH)
			tmp = dbSH;
		if(tmp < dbSL)
			tmp = dbSL;
		CommonFunction.DSI_SetValue(tagName, tmp);
	}
	return; 
}//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void SPBtn_OnDynInitialize(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawBitmap SVButton = (DrawBitmap)dynArgs.sender; 
   
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	// get L1, StartXY,EndXY
 	//================================
	DrawLine L1 = (DrawLine)Area.GetDrawObj("L1");
	double dbL1StartY = L1.StartY;
	double dbL1EndY = L1.EndY;

 	// get SH SL
 	//================================
	double dbSH = 100;
	double dbSL = 0;

	string tagName = Area.Variable[0] + "/PVEUHI";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
		dbSH = dbValue;

	tagName = Area.Variable[0] + "/PVEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
		dbSL = dbValue;

 	//================================
	tagName = Area.Variable[0] + "/SP";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret && (dbSH>dbSL) && (dbL1EndY>dbL1StartY))
	{
		//当SVButton超出L1的上下限时，做异常情况的处理：
		if(dbValue > dbSH)
			dbValue = dbSH;
		if(dbValue < dbSL)
			dbValue = dbSL;

		float y = (float)SVButton.VerticalPosition;
		SVButton.SetPropertyY((dbL1EndY - (dbL1EndY-dbL1StartY)*(dbValue-dbSL)/(dbSH-dbSL)-SVButton.Height/2));
/*
		SVButton.VerticalPosition = Convert.ToInt32(dbL1EndY - (dbL1EndY-dbL1StartY)*(dbValue-dbSL)/(dbSH-dbSL)-SVButton.Height/2);
		float y1 = (float)SVButton.VerticalPosition;
		float deltaY = y1 - y;
		SVButton.MoveTmp(0,deltaY);
		SVButton.Move(0,deltaY);
*/
	}
	return; 
}


//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void SPBtn_OnDynAnimation(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawBitmap SVButton = (DrawBitmap)dynArgs.sender; 
   
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	// get L1, StartXY,EndXY
 	//================================
	DrawLine L1 = (DrawLine)Area.GetDrawObj("L1");
	double dbL1StartY = L1.StartY;
	double dbL1EndY = L1.EndY;

 	// get SH SL
 	//================================
	double dbSH = 100;
	double dbSL = 0;

	string tagName = Area.Variable[0] + "/PVEUHI";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
		dbSH = dbValue;

	tagName = Area.Variable[0] + "/PVEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
		dbSL = dbValue;

 	//================================
	tagName = Area.Variable[0] + "/SP";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret && (dbSH>dbSL) && (dbL1EndY>dbL1StartY))
	{
		//当SVButton超出L1的上下限时，做异常情况的处理：
		if(dbValue > dbSH)
			dbValue = dbSH;
		if(dbValue < dbSL)
			dbValue = dbSL;

		float y = (float)SVButton.VerticalPosition;
		SVButton.SetPropertyY((dbL1EndY - (dbL1EndY-dbL1StartY)*(dbValue-dbSL)/(dbSH-dbSL)-SVButton.Height/2));
/*
		SVButton.VerticalPosition = Convert.ToInt32(dbL1EndY - (dbL1EndY-dbL1StartY)*(dbValue-dbSL)/(dbSH-dbSL)-SVButton.Height/2);
		float y1 = (float)SVButton.VerticalPosition;
		float deltaY = y1 - y;
		SVButton.MoveTmp(0,deltaY);
		SVButton.Move(0,deltaY);
*/
	}
	return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void OPBar_OnDynInitialize(Object sender, EventArgs e)	//PVBar
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawRectangle PVBar = (DrawRectangle)dynArgs.sender; 
	
	PVBar.Variable[0] = Area.Variable[0] + "/OP";
/*
	PVBar.Variable[1] = Area.Variable[0] + "/PVEUHI";
	PVBar.Variable[2] = Area.Variable[0] + "/PVEULO";
*/
	return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void OPBar_OnDynAnimation(Object sender, EventArgs e)	//PVBar
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawRectangle PVBar = (DrawRectangle)dynArgs.sender; 
	
	string tagName = Area.Variable[0];
	bool bIsAlarm = CommonFunction.IsTagOnAlarm(tagName);
	if(bIsAlarm)
		PVBar.ForegroundColor = Color.FromArgb(255,253,65,2);
	else
		PVBar.ForegroundColor = Color.FromArgb(255,191,191,0);
	return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void PV_OnDynInitialize(Object sender, EventArgs e)	//SV
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawText SV = (DrawText)dynArgs.sender; 

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
		SV.Caption = dbValue.ToString(strDigit);
	}
	else
		SV.Caption = "#####0.#";
	return; 
}


//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void PV_OnDynAnimation(Object sender, EventArgs e)	//SV
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawText SV = (DrawText)dynArgs.sender; 

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
		SV.Caption = dbValue.ToString(strDigit);
	}
	else
		SV.Caption = "#####0.#";
	return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void OP_OnDynInitialize(Object sender, EventArgs e)	//SV
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawText SV = (DrawText)dynArgs.sender; 

	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	int nDigit = 1;
/*
	string tagName = Area.Variable[0] + "/PVFORMAT";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
		nDigit = Convert.ToInt32(dbValue);
*/
	string strDigit = "f" + nDigit.ToString();
	
	string tagName = Area.Variable[0] + "/OP";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		SV.Caption = dbValue.ToString(strDigit);
	}
	else
		SV.Caption = "#####0.#";
	return; 
}


//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void OP_OnDynAnimation(Object sender, EventArgs e)	//SV
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawText SV = (DrawText)dynArgs.sender; 

	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	int nDigit = 1;
/*
	string tagName = Area.Variable[0] + "/PVFORMAT";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
		nDigit = Convert.ToInt32(dbValue);
*/
	string strDigit = "f" + nDigit.ToString();
	
	string tagName = Area.Variable[0] + "/OP";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		SV.Caption = dbValue.ToString(strDigit);
	}
	else
		SV.Caption = "#####0.#";
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
   
	if(OP.Visible == true)
	{
		// 不弹出输入面板，DrawText隐藏，TextBox显示	
		object obj = Area.GetControlObj("TB");
		if(obj != null)
		{
			TextBox TB = (TextBox)obj; 
			if(TB != null)
			{
				TB.Enabled = true;
				TB.Visible = true;
				TB.Text = "";
				TB.Focus();
				OP.Visible = false;

				//调整TB的位置：
				//调整控件的位置不能直接给相关属性赋值，应该调用函数MoveControl()，这样才能真正实现控件的移动；
				CommonFunction.MoveControl(Area,TB,(int)(OP.VerticalPosition),(int)(OP.HorizontalPosition));
	
				obj = CommonFunction.GetLabelOfControl(TB);
				if(obj != null)
				{
					ControlLabel lab = (ControlLabel)obj;
					//给TB传递参数：
					lab.Variable[0] = Area.Variable[0] + "/OP";
					//修改宽度：
					lab.m_rect.Width = (float)(OP.Width+1);
				}
			}
		}
	}
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void SP_OnDynInitialize(Object sender, EventArgs e)	//SV
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawText SV = (DrawText)dynArgs.sender; 

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
		SV.Caption = dbValue.ToString(strDigit);
	}
	else
		SV.Caption = "#####0.#";
	return; 
}


//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void SP_OnDynAnimation(Object sender, EventArgs e)	//SV
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawText SV = (DrawText)dynArgs.sender; 

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
		SV.Caption = dbValue.ToString(strDigit);
	}
	else
		SV.Caption = "#####0.#";
	return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void SP_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText OP = (DrawText)dynArgs.sender; 
   
	if(OP.Visible == true)
	{
		// 不弹出输入面板，DrawText隐藏，TextBox显示	
		object obj = Area.GetControlObj("TB");
		if(obj != null)
		{
			TextBox TB = (TextBox)obj; 
			if(TB != null)
			{
				//Area.Enabled = true;
				TB.Visible = true;
				TB.Enabled = true;
				TB.Text = "";
				TB.Focus();
				
				OP.Visible = false;
		
				//调整TB的位置：
				//调整控件的位置不能直接给相关属性赋值，应该调用函数MoveControl()，这样才能真正实现控件的移动；
				CommonFunction.MoveControl(Area,TB,(int)(OP.VerticalPosition),(int)(OP.HorizontalPosition));
	
				obj = CommonFunction.GetLabelOfControl(TB);
				if(obj != null)
				{
					ControlLabel lab = (ControlLabel)obj;
					//给TB传递参数：
					lab.Variable[0] = Area.Variable[0] + "/SP";
					//修改宽度：
					lab.m_rect.Width = (float)(OP.Width+1);
				}
			}
		}
	}
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void PVBar_OnDynInitialize(Object sender, EventArgs e)	//PVBar
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawRectangle PVBar = (DrawRectangle)dynArgs.sender; 
	
	PVBar.Variable[0] = Area.Variable[0] + "/PV";
	PVBar.Variable[1] = Area.Variable[0] + "/PVEULO";
	PVBar.Variable[2] = Area.Variable[0] + "/PVEUHI";
	return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void PVBar_OnDynAnimation(Object sender, EventArgs e)	//PVBar
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawRectangle PVBar = (DrawRectangle)dynArgs.sender; 
	
	string tagName = Area.Variable[0];
	bool bIsAlarm = CommonFunction.IsTagOnAlarm(tagName);
	if(bIsAlarm)
		PVBar.ForegroundColor = Color.FromArgb(255,253,65,2);
	else
		PVBar.ForegroundColor = Color.FromArgb(255,0,191,191);
	return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void PVUnit_OnDynInitialize(Object sender, EventArgs e)
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
public void SL_OnDynInitialize(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawText SL = (DrawText)dynArgs.sender; 
   
	int nDigit = 2;
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;
	string tagName = Area.Variable[0] + "/PVFORMAT";
	if(CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType))
		nDigit = (int)dbValue;

	string strDigit = "f" + nDigit.ToString();
	double dbSL = 0;
	tagName = Area.Variable[0] + "/PVEULO";
	if(CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType))
		dbSL = dbValue;

	SL.Caption = dbSL.ToString(strDigit);
	return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void SL_OnDynAnimation(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawText SL = (DrawText)dynArgs.sender; 
   
	int nDigit = 2;
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;
	string tagName = Area.Variable[0] + "/PVFORMAT";
	if(CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType))
		nDigit = (int)dbValue;

	string strDigit = "f" + nDigit.ToString();
	double dbSL = 0;
	tagName = Area.Variable[0] + "/PVEULO";
	if(CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType))
		dbSL = dbValue;

	SL.Caption = dbSL.ToString(strDigit);
	return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void SH_OnDynInitialize(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawText SL = (DrawText)dynArgs.sender; 
   
	int nDigit = 2;
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;
	string tagName = Area.Variable[0] + "/PVFORMAT";
	if(CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType))
		nDigit = (int)dbValue;

	string strDigit = "f" + nDigit.ToString();
	double dbSL = 0;
	tagName = Area.Variable[0] + "/PVEUHI";
	if(CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType))
		dbSL = dbValue;

	SL.Caption = dbSL.ToString(strDigit);
	return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void SH_OnDynAnimation(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawText SL = (DrawText)dynArgs.sender; 
   
	int nDigit = 2;
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;
	string tagName = Area.Variable[0] + "/PVFORMAT";
	if(CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType))
		nDigit = (int)dbValue;

	string strDigit = "f" + nDigit.ToString();
	double dbSL = 0;
	tagName = Area.Variable[0] + "/PVEUHI";
	if(CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType))
		dbSL = dbValue;

	SL.Caption = dbSL.ToString(strDigit);
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
	string strTemp = CommonFunction.GetTagComment(strTagName);
	TagComment.Caption = strTemp;
	return; 
}


//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void TagComment_OnDynAnimation(Object sender, EventArgs e)	//TagDiscription
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
public void TagName_OnDynInitialize(Object sender, EventArgs e)	//TagName
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
	CommonFunction.OpenPicture("Pks_dfp_PID.grf", nTop, nLeft, strVariable);


 
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void Mode_OnDynInitialize(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawText Mode = (DrawText)dynArgs.sender; 
	
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	string tagName = Area.Variable[0] + "/MODE";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		if(dbValue==1)
			Mode.Caption = "MAN";
		else if(dbValue==2)
			Mode.Caption = "AUTO";
		else if(dbValue==3)
			Mode.Caption = "CAS";
	}
	else
			Mode.Caption = "###";
	return; 
}


//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void Mode_OnDynAnimation(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawText Mode = (DrawText)dynArgs.sender; 
	
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	string tagName = Area.Variable[0] + "/MODE";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		if(dbValue==1)
			Mode.Caption = "MAN";
		else if(dbValue==2)
			Mode.Caption = "AUTO";
		else if(dbValue==3)
			Mode.Caption = "CAS";
	}
	else
			Mode.Caption = "###";
	return; 
}


//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void Mode_OnDynClick(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawText Mode = (DrawText)dynArgs.sender; 
	
	return; 
}
//Do not remove or update this comment
//Event Delegate:KeyEventHandler
//Event Handler:KeyUp
public void TB_KeyUp(Object sender, KeyEventArgs e)
{
	TextBox TB = (TextBox)sender;
	DrawArea Area = CommonFunction.GetThisDrawArea(TB);

	DrawText SP = (DrawText)Area.GetDrawObj("SP");
	DrawText OP = (DrawText)Area.GetDrawObj("OP");

	switch ( e.KeyData )
	{
	case Keys.Enter:
		if(TB.Text == "" || TB.Text == null)
		{
			//Area.Enabled = false;
			TB.Visible = false;
			TB.Enabled = false;
			SP.Visible = true;
			OP.Visible = true;
			return;
		}
		else
		{
			string SPInputValue = TB.Text;
			double dbSPValue = Convert.ToDouble(SPInputValue);

			object obj = CommonFunction.GetLabelOfControl(TB);
			if (obj != null)
			{
				ControlLabel lab = (ControlLabel)obj;
				string tagName = lab.Variable[0];
				CommonFunction.DSI_SetValue(tagName, dbSPValue);
			}
			//Area.Enabled = false;
			TB.Visible = false;
			TB.Enabled = false;
			SP.Visible = true;
			OP.Visible = true;
		}
		break;
	}
	return;
}


}
