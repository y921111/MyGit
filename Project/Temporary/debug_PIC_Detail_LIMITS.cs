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
public class PIC_Detail_LIMITS:IDynCodeAttachDetach
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
_EventHandler= (EventHandler)PIC_Detail_LIMITS_OnDynInitialize;
CodeDomCommon.AttachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)PIC_Detail_LIMITS_KeyUp;
CodeDomCommon.AttachAreaEventHandler(area,strEventName,_KeyEventHandler);
strObjectName = "ENTER";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)ENTER_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "LIMITS_VALUE";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)LIMITS_VALUE_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "LIMITS_NAME";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)LIMITS_NAME_OnDynAnimation;
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
_EventHandler= (EventHandler)PIC_Detail_LIMITS_OnDynInitialize;
CodeDomCommon.DetachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)PIC_Detail_LIMITS_KeyUp;
CodeDomCommon.DetachAreaEventHandler(area,strEventName,_KeyEventHandler);
strObjectName = "ENTER";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)ENTER_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "LIMITS_VALUE";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)LIMITS_VALUE_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "LIMITS_NAME";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)LIMITS_NAME_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)TB_KeyUp;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);

    return;
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void PIC_Detail_LIMITS_OnDynInitialize(Object sender, EventArgs e)
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
			TB.Visible = true;
			TB.Focus();
		    }
        }

        DrawArea picT = (DrawArea)(Area.Parent);
	Area.Variable[0] = picT.Variable[0];

    return; 
}

//Do not remove or update this comment
//Event Delegate:KeyEventHandler 
//Event Handler:KeyUp 
public void PIC_Detail_LIMITS_KeyUp(Object sender, KeyEventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   
   string tagName = Area.Variable[0] + "/" + Area.Variable[1];
   TextBox TB = (TextBox)Area.GetDrawObj("TB");

     double dbValue = 0;
     int nValue = 0;
     bool bValue = false;
     int nDataType = 0;

     bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
     
     if(ret)
      
           {
		    switch(e.KeyData)
                      {    

                         case Keys.Enter:

	                        {		
                                   CommonFunction.DSI_SetValue(tagName, Convert.ToDouble(TB.Text));
	                        } 
                         Area.Visible = false;
	                 break;
                       
                      } 
                
         }
              
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void ENTER_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle ENTER = (DrawRectangle)dynArgs.sender; 
   
    TextBox TB = (TextBox)Area.GetDrawObj("TB");

    string tagName = Area.Variable[0] + "/" + Area.Variable[1];
    CommonFunction.DSI_SetValue(tagName, Convert.ToDouble(TB.Text));
    Area.Visible = false;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void LIMITS_VALUE_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText LIMITS_VALUE = (DrawText)dynArgs.sender; 
  
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
	
	tagName = Area.Variable[0] + "/" + Area.Variable[1];
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		LIMITS_VALUE.Caption = dbValue.ToString(strDigit);
	}
	else
		LIMITS_VALUE.Caption = "##.#";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void LIMITS_NAME_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText LIMITS_NAME = (DrawText)dynArgs.sender; 
   
    string tagName = Area.Variable[1].ToUpper();

	if(tagName != "")
		LIMITS_NAME.Caption = tagName;
	else
		LIMITS_NAME.Caption = "******";	

    return; 
}
//Do not remove or update this comment
//Event Delegate:KeyEventHandler 
//Event Handler:KeyUp 
public void TB_KeyUp(Object sender, KeyEventArgs e)
{
   TextBox TB = (TextBox)sender; 

   DrawArea Area = CommonFunction.GetThisDrawArea(TB);

     DrawRectangle ENTER = (DrawRectangle)Area.GetDrawObj("ENTER");

     double dbValue = 0;
     int nValue = 0;
     bool bValue = false;
     int nDataType = 0;
     string TagName = Area.Variable[0] + "/" + Area.Variable[1];
     bool ret1 = CommonFunction.GetValueWithType(TagName,ref dbValue,ref nValue,ref bValue,ref nDataType);

	switch ( e.KeyData )
	{
	case Keys.Enter:

		if(TB.Text == "" || TB.Text == null)

		{
			TB.Visible = true;
			TB.Enabled = true;
                        Area.Visible = false;
			return;
		}

		else

		{
			string PVInputValue = TB.Text;
			double dbPVValue = Convert.ToDouble(PVInputValue);

			object obj1 = CommonFunction.GetLabelOfControl(TB);

			if (obj1 != null)

			{
                             
                             CommonFunction.DSI_SetValue(TagName, dbPVValue);
                             
			}  
                        ENTER.Variable[0] = TB.Text;
                        TB.ForeColor = Color.Lime;
			TB.Visible = true;
			TB.Enabled = true;
                        Area.Visible = false;
                        return;
		}
		break;
                
	}

    return; 
}


}
