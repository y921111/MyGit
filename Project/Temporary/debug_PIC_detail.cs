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
public class PIC_detail:IDynCodeAttachDetach
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
   strObjectName = "dtxtAlm";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)dtxtAlm_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SPBar";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)SPBar_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVBar";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PVBar_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OPBar";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)OPBar_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "txtPVHH";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)txtPVHH_OnDynAnimation;
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
strObjectName = "dtxtAlm";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)dtxtAlm_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SPBar";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)SPBar_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVBar";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PVBar_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OPBar";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)OPBar_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "txtPVHH";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)txtPVHH_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);

    return;
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void dtxtAlm_OnDynInitialize(Object sender, EventArgs e)
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawText dtxtAlm = (DrawText)dynArgs.sender; 
	
	dtxtAlm.Visible=false;
	int nAlmSta=GetTagAlarmStatus(Area.Variable[0]);
	
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	string tagName=Area.Variable[0]+"/"+dtxtAlm.Variable[0];
	if(CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDateType));
	{
		if(dbValue==3)
		{
			
		}
	}
	return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void SPBar_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle SPBar = (DrawRectangle)dynArgs.sender; 
    
    SPBar.Variable[0]=Area.Variable[0]+"/SP";
    SPBar.Variable[1]=Area.Variable[0]+"/SPLO";
    SPBar.Variable[2]=Area.Variable[0]+"/SPHI";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void PVBar_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle PVBar = (DrawRectangle)dynArgs.sender; 
    
    PVBar.Variable[0]=Area.Variable[0]+"/PV";
    PVBar.Variable[1]=Area.Variable[0]+"/PVEULO";
    PVBar.Variable[2]=Area.Variable[0]+"/PVEUHI";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void OPBar_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle OPBar = (DrawRectangle)dynArgs.sender; 
    
    OPBar.Variable[0]=Area.Variable[0]+"/OP";
    OPBar.Variable[1]=Area.Variable[0]+"/OPLO";
    OPBar.Variable[2]=Area.Variable[0]+"/OPHI";
    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void txtPVHH_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText txtPVHH = (DrawText)dynArgs.sender; 
    
    double dbValue=0;
    int nValue=0;
    bool bValue=false;
    int nDataType=0;

    int nDigit=2;
    string tagName=Area.Variable[0]+"/PVHHFORMAT";
    bool ret=CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
    if(ret)
	   nDigit=Convert.ToInt32(dbValue);
    string strDigit="f"+nDigit.ToString();

    tagName=Area.Variable[0]+"/PVHH";
    ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		txtPVHH.Caption = dbValue.ToString(strDigit);
	}
	else
		txtPVHH.Caption = "#####0.#";
    return; 
}

}
c:\Documents and Settings\HDD\Local Settings\Temp\pgqpnqgi.0.cs(29,23) : warning CS0168: 声明了变量“_MouseEventHandler”，但从未使用过
c:\Documents and Settings\HDD\Local Settings\Temp\pgqpnqgi.0.cs(30,21) : warning CS0168: 声明了变量“_KeyEventHandler”，但从未使用过
c:\Documents and Settings\HDD\Local Settings\Temp\pgqpnqgi.0.cs(31,24) : warning CS0168: 声明了变量“_CancelEventHandler”，但从未使用过
c:\Documents and Settings\HDD\Local Settings\Temp\pgqpnqgi.0.cs(32,24) : warning CS0168: 声明了变量“_ScrollEventHandler”，但从未使用过
c:\Documents and Settings\HDD\Local Settings\Temp\pgqpnqgi.0.cs(63,23) : warning CS0168: 声明了变量“_MouseEventHandler”，但从未使用过
c:\Documents and Settings\HDD\Local Settings\Temp\pgqpnqgi.0.cs(64,21) : warning CS0168: 声明了变量“_KeyEventHandler”，但从未使用过
c:\Documents and Settings\HDD\Local Settings\Temp\pgqpnqgi.0.cs(65,24) : warning CS0168: 声明了变量“_CancelEventHandler”，但从未使用过
c:\Documents and Settings\HDD\Local Settings\Temp\pgqpnqgi.0.cs(66,24) : warning CS0168: 声明了变量“_ScrollEventHandler”，但从未使用过
c:\Documents and Settings\HDD\Local Settings\Temp\pgqpnqgi.0.cs(109,94) : warning CS0642: 空语句可能有错误
c:\Documents and Settings\HDD\Local Settings\Temp\pgqpnqgi.0.cs(101,14) : error CS0103: 当前上下文中不存在名称“GetTagAlarmStatus”
c:\Documents and Settings\HDD\Local Settings\Temp\pgqpnqgi.0.cs(109,83) : error CS0103: 当前上下文中不存在名称“nDateType”
