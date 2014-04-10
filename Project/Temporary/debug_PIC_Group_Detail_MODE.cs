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
public class PIC_Group_Detail_MODE:IDynCodeAttachDetach
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
   strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)PIC_Group_Detail_MODE_KeyUp;
CodeDomCommon.AttachAreaEventHandler(area,strEventName,_KeyEventHandler);
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PIC_Group_Detail_MODE_OnDynInitialize;
CodeDomCommon.AttachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PIC_Group_Detail_MODE_OnDynAnimation;
CodeDomCommon.AttachAreaEventHandler(area,strEventName,_EventHandler);
strObjectName = "ENTER";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)ENTER_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "NORM";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)NORM_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "MAN";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)MAN_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PROG";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PROG_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CAS";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CAS_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "AUTO";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)AUTO_OnDynClick;
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
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)PIC_Group_Detail_MODE_KeyUp;
CodeDomCommon.DetachAreaEventHandler(area,strEventName,_KeyEventHandler);
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PIC_Group_Detail_MODE_OnDynInitialize;
CodeDomCommon.DetachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PIC_Group_Detail_MODE_OnDynAnimation;
CodeDomCommon.DetachAreaEventHandler(area,strEventName,_EventHandler);
strObjectName = "ENTER";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)ENTER_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "NORM";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)NORM_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "MAN";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)MAN_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PROG";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PROG_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CAS";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CAS_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "AUTO";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)AUTO_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);

    return;
}

//Do not remove or update this comment
//Event Delegate:KeyEventHandler 
//Event Handler:KeyUp 
public void PIC_Group_Detail_MODE_KeyUp(Object sender, KeyEventArgs e)
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
public void PIC_Group_Detail_MODE_OnDynInitialize(Object sender, EventArgs e)
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
public void PIC_Group_Detail_MODE_OnDynAnimation(Object sender, EventArgs e)
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
public void ENTER_OnDynClick(Object sender, EventArgs e)
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
public void NORM_OnDynClick(Object sender, EventArgs e)
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
public void MAN_OnDynClick(Object sender, EventArgs e)
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
public void PROG_OnDynClick(Object sender, EventArgs e)
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
public void CAS_OnDynClick(Object sender, EventArgs e)
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
public void AUTO_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText AUTO = (DrawText)dynArgs.sender; 
   
    Area.Variable[1] = "2";

    return; 
}

}
