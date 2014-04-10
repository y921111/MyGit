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
public class PIC_Pks_fp_MOTOR_ST:IDynCodeAttachDetach
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
_EventHandler= (EventHandler)PIC_Pks_fp_MOTOR_ST_OnDynInitialize;
CodeDomCommon.AttachAreaEventHandler(area,strEventName,_EventHandler);
strObjectName = "CLICKSTOP";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CLICKSTOP_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CLICKOPEN";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CLICKOPEN_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Bitmap4";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Bitmap4_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Bitmap4";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Bitmap4_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Bitmap5";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Bitmap5_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Bitmap5";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Bitmap5_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Bitmap2";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Bitmap2_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Bitmap2";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Bitmap2_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Bitmap3";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Bitmap3_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Bitmap3";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Bitmap3_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Text5";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Text5_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Text5";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Text5_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Text6";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Text6_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Text6";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Text6_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Text7";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Text7_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Text7";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Text7_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "State_Combox";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)State_Combox_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "State_Combox";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)State_Combox_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "State";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)State_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "State";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)State_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "State";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)State_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "attr_Combox";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)attr_Combox_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "attr_Combox";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)attr_Combox_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "attr";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)attr_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "attr";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)attr_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "attr";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)attr_OnDynClick;
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
_EventHandler= (EventHandler)PIC_Pks_fp_MOTOR_ST_OnDynInitialize;
CodeDomCommon.DetachAreaEventHandler(area,strEventName,_EventHandler);
strObjectName = "CLICKSTOP";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CLICKSTOP_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CLICKOPEN";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CLICKOPEN_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Bitmap4";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Bitmap4_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Bitmap4";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Bitmap4_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Bitmap5";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Bitmap5_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Bitmap5";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Bitmap5_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Bitmap2";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Bitmap2_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Bitmap2";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Bitmap2_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Bitmap3";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Bitmap3_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Bitmap3";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Bitmap3_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Text5";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Text5_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Text5";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Text5_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Text6";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Text6_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Text6";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Text6_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Text7";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Text7_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Text7";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Text7_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "State_Combox";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)State_Combox_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "State_Combox";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)State_Combox_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "State";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)State_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "State";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)State_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "State";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)State_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "attr_Combox";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)attr_Combox_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "attr_Combox";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)attr_Combox_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "attr";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)attr_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "attr";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)attr_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "attr";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)attr_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);

    return;
}

// =========================================================================================
//
// 文件名：Pks_fp_MOTOR_ST.grf
// 
// 说明: 算法“MOTOR”对应的面板，参数为“MOTOR_ST”，点击“OP”下面的圆点可以对参数置1/0
//
// 点击点名弹出Detail页面还没做
//
//
// 【更新时间】 
//		2012.08.16 hdd
//
// =========================================================================================
//Do not remove or update this comment
//Event Delegate:EventHandler
//Event Handler:OnDynInitialize
public void PIC_Pks_fp_MOTOR_ST_OnDynInitialize(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender;
	DynEventArgs dynArgs = (DynEventArgs)e;
	DrawArea drawArea = (DrawArea)dynArgs.sender;

	Area.Enabled = true;


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
//Event Handler:OnDynClick 
public void CLICKSTOP_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawEllipse click = (DrawEllipse)dynArgs.sender; 

    DrawText State = (DrawText)Area.GetDrawObj("State");

    double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	string tagName = Area.Variable[0] + "/MOTOR_ST";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		
                if(dbValue != 0 )
			{CommonFunction.DSI_SetValue(tagName, 0);}
		else 
			{}
	}
	

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void CLICKOPEN_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawEllipse click = (DrawEllipse)dynArgs.sender; 

    DrawText State = (DrawText)Area.GetDrawObj("State");

    double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	string tagName = Area.Variable[0] + "/MOTOR_ST";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		
                if(dbValue == 0 )
			{CommonFunction.DSI_SetValue(tagName, 1);}
		else 
			{}
	}
	

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void Bitmap4_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawBitmap Bitmap2 = (DrawBitmap)dynArgs.sender; 
    DrawText SV = (DrawText)Area.GetDrawObj("Text5");  
    
    double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	string tagName = Area.Variable[0] + "/MOTOR_ST";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
                
                if( dbValue == 0 )

                {Bitmap2.Visible = false;}

                else

                {Bitmap2.Visible = true;}
      	}
	else
		Bitmap2.Visible = true;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void Bitmap4_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawBitmap Bitmap2 = (DrawBitmap)dynArgs.sender; 
    DrawText SV = (DrawText)Area.GetDrawObj("Text5");  

    double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	string tagName = Area.Variable[0] + "/MOTOR_ST";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
                
                if( dbValue == 0 )

                {Bitmap2.Visible = false;}

                else

                {Bitmap2.Visible = true;}
      	}
	else
		Bitmap2.Visible = false;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void Bitmap5_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawBitmap Bitmap3 = (DrawBitmap)dynArgs.sender; 
    DrawText SV = (DrawText)Area.GetDrawObj("Text5");  
    
    double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	string tagName = Area.Variable[0] + "/MOTOR_ST";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
                
                if( dbValue == 0 )
                {Bitmap3.Visible = false;}
                else
                {Bitmap3.Visible = true;}
      	}
	else
		Bitmap3.Visible = true;
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void Bitmap5_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawBitmap Bitmap3 = (DrawBitmap)dynArgs.sender;
    DrawText SV = (DrawText)Area.GetDrawObj("Text5");  
 
    double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	string tagName = Area.Variable[0] + "/MOTOR_ST";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
                
                if( dbValue == 0 )
                {Bitmap3.Visible = false;}
                else
                {Bitmap3.Visible = true;}
      	}
	else
		Bitmap3.Visible = true;
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void Bitmap2_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawBitmap Bitmap4 = (DrawBitmap)dynArgs.sender;
    DrawText SV = (DrawText)Area.GetDrawObj("Text5"); 

    double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	string tagName = Area.Variable[0] + "/MOTOR_ST";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
                
                if( dbValue == 0 )
                {Bitmap4.Visible = false;}
                else
                {Bitmap4.Visible = true;}
      	}
	else
		Bitmap4.Visible = true;
 
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void Bitmap2_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawBitmap Bitmap4 = (DrawBitmap)dynArgs.sender; 
    DrawText SV = (DrawText)Area.GetDrawObj("Text5"); 

    double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	string tagName = Area.Variable[0] + "/MOTOR_ST";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
                
                if( dbValue == 0 )
                {Bitmap4.Visible = false;}
                else
                {Bitmap4.Visible = true;}
      	}
	else
		Bitmap4.Visible = true;
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void Bitmap3_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawBitmap Bitmap5 = (DrawBitmap)dynArgs.sender; 
    DrawText SV = (DrawText)Area.GetDrawObj("Text5"); 

    double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	string tagName = Area.Variable[0] + "/MOTOR_ST";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
                
                if( dbValue == 0 )
                {Bitmap5.Visible = false;}
                else
                {Bitmap5.Visible = true;}
      	}
	else
		Bitmap5.Visible = true;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void Bitmap3_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawBitmap Bitmap5 = (DrawBitmap)dynArgs.sender; 
    DrawText SV = (DrawText)Area.GetDrawObj("Text5"); 

    double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	string tagName = Area.Variable[0] + "/MOTOR_ST";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
                
                if( dbValue == 0 )
                {Bitmap5.Visible = false;}
                else
                {Bitmap5.Visible = true;}
      	}
	else
		Bitmap5.Visible = true;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void Text5_OnDynInitialize(Object sender, EventArgs e)	//SV
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawText SV = (DrawText)dynArgs.sender; 

	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	int nDigit = 0;
	string tagName = Area.Variable[0] + "/PVFORMAT";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
		nDigit = Convert.ToInt32(dbValue);
	string strDigit = "f" + nDigit.ToString();
	
	tagName = Area.Variable[0] + "/MOTOR_ST";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		SV.Caption = dbValue.ToString(strDigit);
                if(SV.Caption == "1" )
                {SV.Caption = "RUN" ;}
                else
		{SV.Caption = "STOP";}
	}
	else
		SV.Caption = "STOP";
	return; 
}


//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void Text5_OnDynAnimation(Object sender, EventArgs e)	//SV
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawText SV = (DrawText)dynArgs.sender; 

	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	int nDigit = 0;
	string tagName = Area.Variable[0] + "/PVFORMAT";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
		nDigit = Convert.ToInt32(dbValue);
	string strDigit = "f" + nDigit.ToString();
	
	tagName = Area.Variable[0] + "/MOTOR_ST";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		SV.Caption = dbValue.ToString(strDigit);
                 if(SV.Caption == "1" )
                {SV.Caption = "RUN" ;}
                else
		{SV.Caption = "STOP";}
	}
	else
		SV.Caption = "STOP";
	return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void Text6_OnDynInitialize(Object sender, EventArgs e)	//TagName
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
public void Text6_OnDynClick(Object sender, EventArgs e)
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
//Event Handler:OnDynInitialize 
public void Text7_OnDynInitialize(Object sender, EventArgs e)
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
public void Text7_OnDynAnimation(Object sender, EventArgs e)	//TagDiscription
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
public void State_Combox_OnDynInitialize(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawButton Combox= (DrawButton)dynArgs.sender; 
	DrawText State = (DrawText)Area.GetDrawObj("State");
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

	Combox.Variable[0] = Area.Variable[0]+"/MOTOR_ST";
	Combox.Variable[1] = "RUN-1/STOP-0";
	Combox.Variable[2] = (State.Width/sF.X/sF1.X).ToString();
	Combox.Variable[3] = (State.Height*2/sF.Y/sF1.Y).ToString();
*/
	return; 
}


//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void State_Combox_OnDynClick(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawButton State_Combox = (DrawButton)dynArgs.sender; 
	DrawText State = (DrawText)Area.GetDrawObj("State");

	//=====================================
	PointF sF = Area.GetScaleFactor();
	State_Combox.Variable[0] = Area.Variable[0]+"/MOTOR_ST";
	State_Combox.Variable[1] = "RUN-1/STOP-0";
	State_Combox.Variable[2] = (State.Width/sF.X).ToString();
	State_Combox.Variable[3] = (State.Height*2/sF.Y).ToString();


	string picName = "Pks_fp_PID_Combox.grf";
	//=====================================
	int nTop = (int)State.VerticalPosition + (int)State.Height;
	int nLeft = (int)State.HorizontalPosition;

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
		strVariable[i] = State_Combox.Variable[i];
	}

	//=====================================
	CommonFunction.OpenPicture(picName,nTop,nLeft,strVariable);
	return; 
}//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void State_OnDynInitialize(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawText Mode = (DrawText)dynArgs.sender; 
	
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	string tagName = Area.Variable[0] + "/MOTOR_ST";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		if(dbValue==1)
			Mode.Caption = "RUN";
		else 
			Mode.Caption = "STOP";
	}
	else
			Mode.Caption = " ";
	return; 
}


//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void State_OnDynAnimation(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawText Mode = (DrawText)dynArgs.sender; 
	
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	string tagName = Area.Variable[0] + "/MOTOR_ST";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		if(dbValue==1)
			Mode.Caption = "RUN";
		else 
			Mode.Caption = "STOP";
	}
	else
			Mode.Caption = " ";
	return; 
}


//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void State_OnDynClick(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawText Mode = (DrawText)dynArgs.sender; 
	
	return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void attr_Combox_OnDynInitialize(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawButton Combox0= (DrawButton)dynArgs.sender; 
	DrawText attr = (DrawText)Area.GetDrawObj("attr");
/*
	PointF asF = Area.GetScaleFactor();
	PointF asF1 = new PointF(1,1);

	//控制组中的面板：
	if(Area.BReference)
	{
		DrawArea TopArea = (DrawArea)(Area.Parent);
		asF1 = TopArea.GetScaleFactor();
		MessageBox.Show(asF1.X.ToString());
	}

	Combox0.Variable[0] = Area.Variable[0]+"/START";
	Combox0.Variable[1] = "OPEARATOR-1/ENGINNER-0";
	Combox0.Variable[2] = (attr.Width/asF.X/asF1.X).ToString();
	Combox0.Variable[3] = (attr.Height*2/asF.Y/asF1.Y).ToString();
*/
	return; 
}


//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void attr_Combox_OnDynClick(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawButton attr_Combox = (DrawButton)dynArgs.sender; 
	DrawText attr = (DrawText)Area.GetDrawObj("attr");

	//=====================================
	PointF asF = Area.GetScaleFactor();
	attr_Combox.Variable[0] = Area.Variable[0]+"/START";
	attr_Combox.Variable[1] = "OPEARATOR-1/ENGINNER-0";
	attr_Combox.Variable[2] = (attr.Width/asF.X).ToString();
	attr_Combox.Variable[3] = (attr.Height*2/asF.Y).ToString();


	string picName = "Pks_fp_PID_Combox.grf";
	//=====================================
	int nTop = (int)attr.VerticalPosition + (int)attr.Height;
	int nLeft = (int)attr.HorizontalPosition;

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
		nLeft = (int)(nLeft/asF.X + lab.m_rect.X/sFTop.X + pic.Left + 4); //4为窗口左侧边的宽度；
		nTop = (int)(nTop/asF.Y + lab.m_rect.Y/sFTop.Y + pic.Top + 30); //30为窗口Header的高度；
	}

	//=====================================
	string[] strVariable = new string[10];
	for ( int i=0;i<10;i++ )
	{
		strVariable[i] = attr_Combox.Variable[i];
	}

	//=====================================
	CommonFunction.OpenPicture(picName,nTop,nLeft,strVariable);
	return; 
}//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void attr_OnDynInitialize(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawText attr = (DrawText)dynArgs.sender; 
	
	double adbValue = 0;
	int anValue = 0;
	bool abValue = false;
	int anDataType = 0;

	string Name = Area.Variable[0] + "/START";
	bool aret = CommonFunction.GetValueWithType(Name,ref adbValue,ref anValue,ref abValue,ref anDataType);
	if(aret)
	{
		if(adbValue==1)
			{attr.Caption = "OPEARATOR";}
		else 
			{attr.Caption = "ENGINNER";}
	}
	return; 
}


//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void attr_OnDynAnimation(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawText attr  = (DrawText)dynArgs.sender; 
	
	double adbValue = 0;
	int anValue = 0;
	bool abValue = false;
	int anDataType = 0;

	string Name = Area.Variable[0] + "/START";
	bool aret = CommonFunction.GetValueWithType(Name,ref adbValue,ref anValue,ref abValue,ref anDataType);
	if(aret)
	{
		if(adbValue==1)
			{attr.Caption = "OPEARATOR";}
		else 
			{attr.Caption = "ENGINNER";}
	}
	return; 
}


//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void attr_OnDynClick(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawText attr  = (DrawText)dynArgs.sender; 
	
	return; 
}

}
