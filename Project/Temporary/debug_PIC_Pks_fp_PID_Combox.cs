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
public class PIC_Pks_fp_PID_Combox:IDynCodeAttachDetach
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
_EventHandler= (EventHandler)PIC_Pks_fp_PID_Combox_OnDynInitialize;
CodeDomCommon.AttachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "OnDynLeave";
_EventHandler= (EventHandler)PIC_Pks_fp_PID_Combox_OnDynLeave;
CodeDomCommon.AttachAreaEventHandler(area,strEventName,_EventHandler);
strObjectName = "T3";
strEventName = "OnDynMouseIn";
_EventHandler= (EventHandler)T3_OnDynMouseIn;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "T3";
strEventName = "OnDynMouseOut";
_EventHandler= (EventHandler)T3_OnDynMouseOut;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "T3";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)T3_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "T2";
strEventName = "OnDynMouseIn";
_EventHandler= (EventHandler)T2_OnDynMouseIn;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "T2";
strEventName = "OnDynMouseOut";
_EventHandler= (EventHandler)T2_OnDynMouseOut;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "T2";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)T2_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "T1";
strEventName = "OnDynMouseIn";
_EventHandler= (EventHandler)T1_OnDynMouseIn;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "T1";
strEventName = "OnDynMouseOut";
_EventHandler= (EventHandler)T1_OnDynMouseOut;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "T1";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)T1_OnDynClick;
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
_EventHandler= (EventHandler)PIC_Pks_fp_PID_Combox_OnDynInitialize;
CodeDomCommon.DetachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "OnDynLeave";
_EventHandler= (EventHandler)PIC_Pks_fp_PID_Combox_OnDynLeave;
CodeDomCommon.DetachAreaEventHandler(area,strEventName,_EventHandler);
strObjectName = "T3";
strEventName = "OnDynMouseIn";
_EventHandler= (EventHandler)T3_OnDynMouseIn;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "T3";
strEventName = "OnDynMouseOut";
_EventHandler= (EventHandler)T3_OnDynMouseOut;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "T3";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)T3_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "T2";
strEventName = "OnDynMouseIn";
_EventHandler= (EventHandler)T2_OnDynMouseIn;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "T2";
strEventName = "OnDynMouseOut";
_EventHandler= (EventHandler)T2_OnDynMouseOut;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "T2";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)T2_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "T1";
strEventName = "OnDynMouseIn";
_EventHandler= (EventHandler)T1_OnDynMouseIn;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "T1";
strEventName = "OnDynMouseOut";
_EventHandler= (EventHandler)T1_OnDynMouseOut;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "T1";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)T1_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);

    return;
}

/*
【输入参数】
Area.Var[1]模块名/参数名;
Area.Var[2]str1-v1/str2-v2/str3-v3/str4-v4;(下拉款显示的项-对应的值)
Area.Var[3]pic.width;由此Pic的调用者来确定其Size
Area.Var[4]pic.height;

【更新时间】 
20120302, Lyy, PKS
20120321,lyy
20120801，hdd，add
*/
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void PIC_Pks_fp_PID_Combox_OnDynInitialize(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawArea drawArea = (DrawArea)dynArgs.sender; 

	DrawRectangle R1 = (DrawRectangle)Area.GetDrawObj("R1"); 
	DrawText T1 = (DrawText)Area.GetDrawObj("T1"); 
	DrawText T2 = (DrawText)Area.GetDrawObj("T2"); 
	DrawText T3 = (DrawText)Area.GetDrawObj("T3"); 


	int nCount = 0;

	//初始化下拉框：（先只考虑2、3下来选项的）
	//=================================
	string strTemp = Area.Variable[1];
	int myIdx;

	if (strTemp.Length > 0)
	{
		strTemp = strTemp.TrimEnd();
		string[] split = strTemp.Split(new Char[] { '/' });
		nCount = split.Length;
		string[] split1;
		if(nCount > 1)
		{
			split1 = split[0].Split(new Char[] { '-' });
			T1.Caption = split1[0];
			T1.Variable[0] = split1[1];

			split1 = split[1].Split(new Char[] { '-' });
			T2.Caption = split1[0];
			T2.Variable[0] = split1[1];

		}
		if(nCount == 3)
		{
			split1 = split[2].Split(new Char[] { '-' });
			T3.Caption = split1[0];
			T3.Variable[0] = split1[1];
		}
	}
	
	//当前选中项：=================================
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;
	string tagName = Area.Variable[0];

	T1.BackgroundColor = Color.White;
	T2.BackgroundColor = Color.White;
	T3.BackgroundColor = Color.White;
        
	if(CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType))
	{
		if( dbValue == Convert.ToDouble(T1.Variable[0]) )
			T1.BackgroundColor = Color.FromArgb(255,49,106,197);
		if( dbValue == Convert.ToDouble(T2.Variable[0]) )
			T2.BackgroundColor = Color.FromArgb(255,49,106,197);
		if( dbValue == Convert.ToDouble(T3.Variable[0]) )
			T3.BackgroundColor = Color.FromArgb(255,49,106,197);
       	}

	//Zoom：=================================
	double dbWidth = Convert.ToDouble(Area.Variable[2]);
	double dbHeight = Convert.ToDouble(Area.Variable[3]);

	int nWidth = (int)dbWidth; 
	int nHeight = (int)dbHeight; 

	T1.SetPropertyWidth(nWidth);
	T2.SetPropertyWidth(T1.Width);
	T3.SetPropertyWidth(T1.Width);
	
	T1.SetPropertyHeight(nHeight/nCount);
	T2.SetPropertyHeight(T1.Height);
	T3.SetPropertyHeight(T1.Height);

	R1.HorizontalPosition = 0;
	R1.VerticalPosition = 0;

	T2.SetPropertyY(T1.VerticalPosition + T1.Height); //2为间隔；
	T3.SetPropertyY(T2.VerticalPosition + T2.Height); //2为间隔；
       
	R1.SetPropertyWidth(nWidth);
	R1.SetPropertyHeight(nHeight);

	object obj = Area.Parent;
	Type type = obj.GetType();
	if( type.Name == "Picture" )
	{
		Picture pic = (Picture)(Area.Parent);
		pic.FormBorderStyle = FormBorderStyle.None;
		pic.ShowInTaskbar = false;
		pic.Text = "";
		pic.Width = nWidth;
		pic.Height = nHeight;
	} 
	return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynLeave 
public void PIC_Pks_fp_PID_Combox_OnDynLeave(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawArea drawArea = (DrawArea)dynArgs.sender; 
	DrawText T2 = (DrawText)Area.GetDrawObj("T2"); 
	CommonFunction.CloseThisPicture(T2);
	return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynMouseIn 
public void T3_OnDynMouseIn(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText T3 = (DrawText)dynArgs.sender; 
	DrawText T1 = (DrawText)Area.GetDrawObj("T1"); 
	DrawText T2 = (DrawText)Area.GetDrawObj("T2"); 
   
	T3.BackgroundColor = Color.FromArgb(255,49,106,197);
	T1.BackgroundColor = Color.White;
	T2.BackgroundColor = Color.White;
     return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynMouseOut 
public void T3_OnDynMouseOut(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText T1 = (DrawText)dynArgs.sender; 
   
	T1.BackgroundColor = Color.FromArgb(255,255,255,255);
    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void T3_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText T1 = (DrawText)dynArgs.sender; 

	string tagName = Area.Variable[0];
	double dbValue = Convert.ToDouble(T1.Variable[0]);
	CommonFunction.DSI_SetValue(tagName, dbValue);
	CommonFunction.CloseThisPicture(T1);
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynMouseIn 
public void T2_OnDynMouseIn(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText T2 = (DrawText)dynArgs.sender; 
	DrawText T1 = (DrawText)Area.GetDrawObj("T1"); 
	DrawText T3 = (DrawText)Area.GetDrawObj("T3"); 
   
	T2.BackgroundColor = Color.FromArgb(255,49,106,197);
	T1.BackgroundColor = Color.White;
	T3.BackgroundColor = Color.White;
     return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynMouseOut 
public void T2_OnDynMouseOut(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText T1 = (DrawText)dynArgs.sender; 
   
	T1.BackgroundColor = Color.FromArgb(255,255,255,255);
    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void T2_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText T1 = (DrawText)dynArgs.sender; 

	string tagName = Area.Variable[0];
	double dbValue = Convert.ToDouble(T1.Variable[0]);
	CommonFunction.DSI_SetValue(tagName, dbValue);
	CommonFunction.CloseThisPicture(T1);
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynMouseIn 
public void T1_OnDynMouseIn(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText T1 = (DrawText)dynArgs.sender; 
	DrawText T2 = (DrawText)Area.GetDrawObj("T2"); 
	DrawText T3 = (DrawText)Area.GetDrawObj("T3"); 
   
	T1.BackgroundColor = Color.FromArgb(255,49,106,197);
	T2.BackgroundColor = Color.White;
	T3.BackgroundColor = Color.White;
    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynMouseOut 
public void T1_OnDynMouseOut(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText T1 = (DrawText)dynArgs.sender; 
   
	T1.BackgroundColor = Color.FromArgb(255,255,255,255);
    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void T1_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText T1 = (DrawText)dynArgs.sender; 

	string tagName = Area.Variable[0];
	double dbValue = Convert.ToDouble(T1.Variable[0]);
	CommonFunction.DSI_SetValue(tagName, dbValue);
	CommonFunction.CloseThisPicture(T1);
    return; 
}

}
