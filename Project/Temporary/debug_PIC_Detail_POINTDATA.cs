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
public class PIC_Detail_POINTDATA:IDynCodeAttachDetach
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
_KeyEventHandler= (KeyEventHandler)PIC_Detail_POINTDATA_KeyUp;
CodeDomCommon.AttachAreaEventHandler(area,strEventName,_KeyEventHandler);
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PIC_Detail_POINTDATA_OnDynInitialize;
CodeDomCommon.AttachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PIC_Detail_POINTDATA_OnDynAnimation;
CodeDomCommon.AttachAreaEventHandler(area,strEventName,_EventHandler);
strObjectName = "ENTER";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)ENTER_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "D5";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)D5_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "D5";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)D5_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "D4";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)D4_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "D4";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)D4_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "D3";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)D3_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "D3";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)D3_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect3";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Rect3_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect3";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Rect3_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect2";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Rect2_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect2";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Rect2_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect1";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Rect1_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect1";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Rect1_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "D2";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)D2_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "D2";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)D2_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "D1";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)D1_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "D1";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)D1_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "NAME";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)NAME_OnDynAnimation;
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
_KeyEventHandler= (KeyEventHandler)PIC_Detail_POINTDATA_KeyUp;
CodeDomCommon.DetachAreaEventHandler(area,strEventName,_KeyEventHandler);
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PIC_Detail_POINTDATA_OnDynInitialize;
CodeDomCommon.DetachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PIC_Detail_POINTDATA_OnDynAnimation;
CodeDomCommon.DetachAreaEventHandler(area,strEventName,_EventHandler);
strObjectName = "ENTER";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)ENTER_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "D5";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)D5_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "D5";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)D5_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "D4";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)D4_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "D4";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)D4_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "D3";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)D3_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "D3";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)D3_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect3";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Rect3_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect3";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Rect3_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect2";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Rect2_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect2";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Rect2_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect1";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Rect1_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect1";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Rect1_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "D2";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)D2_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "D2";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)D2_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "D1";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)D1_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "D1";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)D1_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "NAME";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)NAME_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);

    return;
}

//Area.Variable[0]-TagName
//Area.Variable[1]-标题名
//Area.Variable[2]-选中变色置值标记
//Area.Variable[3]--Area.Variable[7]可选项的内容
//Area.Variable[8]--Area.Variable[12]可选项的数值

//Do not remove or update this comment
//Event Delegate:KeyEventHandler 
//Event Handler:KeyUp 
public void PIC_Detail_POINTDATA_KeyUp(Object sender, KeyEventArgs e)
{
   DrawArea Area = (DrawArea)sender; 

	DrawText D1 = (DrawText)Area.GetDrawObj("D1");
	DrawText D2 = (DrawText)Area.GetDrawObj("D2");
	DrawText D3 = (DrawText)Area.GetDrawObj("D3");
	DrawText D4 = (DrawText)Area.GetDrawObj("D4");
	DrawText D5 = (DrawText)Area.GetDrawObj("D5");
	DrawText NAME = (DrawText)Area.GetDrawObj("NAME");

    DrawRectangle Rect1 = (DrawRectangle)Area.GetDrawObj("Rect1");
    DrawRectangle Rect2 = (DrawRectangle)Area.GetDrawObj("Rect2");
    DrawRectangle Rect3 = (DrawRectangle)Area.GetDrawObj("Rect3");

   string tagName = Area.Variable[0] + "/" + Area.Variable[1];

     double dbValue = 0;
     int nValue = 0;
     bool bValue = false;
     int nDataType = 0;

     string Pam = Area.Variable[0] + "/" + Area.Variable[1];
     bool ret = CommonFunction.GetValueWithType(Pam,ref dbValue,ref nValue,ref bValue,ref nDataType);
     
     if(ret)
      
           {
		    switch(e.KeyData)
                      {    

                         case Keys.Enter:

                               if(Area.Variable[2] == "1")
	                        {		
                                   CommonFunction.DSI_SetValue(tagName, Convert.ToDouble(Area.Variable[8]));
	                        }
	                       if(Area.Variable[2] == "2")
	                        {
                                   CommonFunction.DSI_SetValue(tagName, Convert.ToDouble(Area.Variable[9]));
	                         }
	                       if(Area.Variable[2] == "3")
	                        {
                                   CommonFunction.DSI_SetValue(tagName, Convert.ToDouble(Area.Variable[10]));
	                        }
                               if(Area.Variable[2] == "4")
                                {
	                           CommonFunction.DSI_SetValue(tagName, Convert.ToDouble(Area.Variable[11]));
                                }
                               if(Area.Variable[2] == "5")
                                {
	                           CommonFunction.DSI_SetValue(tagName, Convert.ToDouble(Area.Variable[12]));
                                }

                          Area.Variable[2] = "0";
                          Area.Visible = false;

                          D1.Caption = "";
                          D2.Caption = "";
                          D3.Caption = "";
                          D4.Caption = "";
                          D5.Caption = "";
                          NAME.Caption = "";

                          Rect1.Visible = false;
                          Rect2.Visible = false;
                          Rect3.Visible = false;

	                 break;
                      }               
         }
             
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void PIC_Detail_POINTDATA_OnDynInitialize(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 
 
   if(Area.BReference)
     {
        Area.Enabled = true; 
     }  
    Area.Variable[2] = "0";
////////////////////////////////////////////////////////////////////////////////处理变色
////////////////////////////////////////////////////////////////////////////////处理变色

	DrawText D1 = (DrawText)Area.GetDrawObj("D1");
	DrawText D2 = (DrawText)Area.GetDrawObj("D2");
	DrawText D3 = (DrawText)Area.GetDrawObj("D3");
	DrawText D4 = (DrawText)Area.GetDrawObj("D4");
	DrawText D5 = (DrawText)Area.GetDrawObj("D5");

	D1.ForegroundColor = Color.Lime;
	D2.ForegroundColor = Color.Lime;
	D3.ForegroundColor = Color.Lime;
	D4.ForegroundColor = Color.Lime;
	D5.ForegroundColor = Color.Lime;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void PIC_Detail_POINTDATA_OnDynAnimation(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 

////////////////////////////////////////////////////////////////////////////////处理变色
////////////////////////////////////////////////////////////////////////////////处理变色

	DrawText D1 = (DrawText)Area.GetDrawObj("D1");
	DrawText D2 = (DrawText)Area.GetDrawObj("D2");
	DrawText D3 = (DrawText)Area.GetDrawObj("D3");
	DrawText D4 = (DrawText)Area.GetDrawObj("D4");
	DrawText D5 = (DrawText)Area.GetDrawObj("D5");

	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;
	string tagName = Area.Variable[0] + "/" + Area.Variable[1];
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);

if(ret)
   {		
     if(dbValue == Convert.ToDouble(Area.Variable[8]))
	 {
           if(Area.Variable[2] == "1")

		{ D1.ForegroundColor = Color.White;}

           else
              {
                  D1.ForegroundColor = Color.Cyan;

		 if(Area.Variable[2] == "2")
		 {
			 D2.ForegroundColor = Color.White;
		 }
		 else if(Area.Variable[2] == "3")
		 {
			 D3.ForegroundColor = Color.White;
		 }
		 else if(Area.Variable[2] == "4")
		 {
			 D4.ForegroundColor = Color.White;
		 }
		 else if(Area.Variable[2] == "5")
		 {
			 D5.ForegroundColor = Color.White;
		 }

              }
	 }
	 if(dbValue == Convert.ToDouble(Area.Variable[9]))
	 {
           if(Area.Variable[2] == "2")

		{ D2.ForegroundColor = Color.White;}

           else
              {
			 D2.ForegroundColor = Color.Cyan;

		 if(Area.Variable[2] == "1")
		 {
			 D1.ForegroundColor = Color.White;
		 }
		 else if(Area.Variable[2] == "3")
		 {
			 D3.ForegroundColor = Color.White;
		 }
		 else if(Area.Variable[2] == "4")
		 {
			 D4.ForegroundColor = Color.White;
		 }
		 else if(Area.Variable[2] == "5")
		 {
			 D5.ForegroundColor = Color.White;
		 }
               }
	 }
	 if(dbValue == Convert.ToDouble(Area.Variable[10]))
	 {
           if(Area.Variable[2] == "3")

		{ D3.ForegroundColor = Color.White;}

           else
              {
			 D3.ForegroundColor = Color.Cyan;

		 if(Area.Variable[2] == "2")
		 {
			 D2.ForegroundColor = Color.White;
		 }
		 else if(Area.Variable[2] == "1")
		 {
			 D1.ForegroundColor = Color.White;
		 }
		 else if(Area.Variable[2] == "4")
		 {
			 D4.ForegroundColor = Color.White;
		 }
		 else if(Area.Variable[2] == "5")
		 {
			 D5.ForegroundColor = Color.White;
		 }
               }
	 }
	 if(dbValue == Convert.ToDouble(Area.Variable[11]))
	 {
           if(Area.Variable[2] == "4")

		{ D4.ForegroundColor = Color.White;}

           else
              {
			 D4.ForegroundColor = Color.Cyan;

		 if(Area.Variable[2] == "2")
		 {
			 D2.ForegroundColor = Color.White;
		 }
		 else if(Area.Variable[2] == "1")
		 {
			 D1.ForegroundColor = Color.White;
		 }
		 else if(Area.Variable[2] == "3")
		 {
			 D3.ForegroundColor = Color.White;
		 }
		 else if(Area.Variable[2] == "5")
		 {
			 D5.ForegroundColor = Color.White;
		 }
               }
	 }
	 if(dbValue == Convert.ToDouble(Area.Variable[12]))
	 {
           if(Area.Variable[2] == "5")

		{ D5.ForegroundColor = Color.White;}

           else
              {
			 D5.ForegroundColor = Color.Cyan;

		 if(Area.Variable[2] == "2")
		 {
			 D2.ForegroundColor = Color.White;
		 }
		 else if(Area.Variable[2] == "1")
		 {
			 D1.ForegroundColor = Color.White;
		 }
		 else if(Area.Variable[2] == "4")
		 {
			 D4.ForegroundColor = Color.White;
		 }
		 else if(Area.Variable[2] == "3")
		 {
			 D3.ForegroundColor = Color.White;
		 }
              }
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
   
   string tagName = Area.Variable[0] + "/" + Area.Variable[1];

     double dbValue = 0;
     int nValue = 0;
     bool bValue = false;
     int nDataType = 0;

     string Pam = Area.Variable[0] + "/" + Area.Variable[1];
     bool ret = CommonFunction.GetValueWithType(Pam,ref dbValue,ref nValue,ref bValue,ref nDataType);
     
     if(ret)
      
           {
               if(Area.Variable[2] == "1")
	          {		
                       CommonFunction.DSI_SetValue(tagName, Convert.ToDouble(Area.Variable[8]));
	          }
	       if(Area.Variable[2] == "2")
	          {
                       CommonFunction.DSI_SetValue(tagName, Convert.ToDouble(Area.Variable[9]));
	          }
	       if(Area.Variable[2] == "3")
	          {
                       CommonFunction.DSI_SetValue(tagName, Convert.ToDouble(Area.Variable[10]));
	          }
               if(Area.Variable[2] == "4")
                  {
	               CommonFunction.DSI_SetValue(tagName, Convert.ToDouble(Area.Variable[11]));
                  }
               if(Area.Variable[2] == "5")
                  {
	               CommonFunction.DSI_SetValue(tagName, Convert.ToDouble(Area.Variable[12]));
                  }

               Area.Variable[2] = "0";
               Area.Visible = false;
           }
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void D5_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText D5 = (DrawText)dynArgs.sender; 
   
    Area.Variable[2] = "5";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void D5_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText D5 = (DrawText)dynArgs.sender; 
   
    DrawRectangle Rect3 = (DrawRectangle)Area.GetDrawObj("Rect3");
        string tagName = Area.Variable[7].ToUpper();
	if(tagName != "N")
		D5.Caption = tagName;
	else
           {
		D5.Caption = "";
                Rect3.Visible = false;
            }

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void D4_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText D4 = (DrawText)dynArgs.sender; 
   
    Area.Variable[2] = "4";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void D4_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText D4 = (DrawText)dynArgs.sender; 
   
    DrawRectangle Rect2 = (DrawRectangle)Area.GetDrawObj("Rect2");
        string tagName = Area.Variable[6].ToUpper();
	if(tagName != "N")
		D4.Caption = tagName;
	else
           {
		D4.Caption = "";
                Rect2.Visible = false;
            }
    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void D3_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText D3 = (DrawText)dynArgs.sender; 
   
    Area.Variable[2] = "3";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void D3_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText D3 = (DrawText)dynArgs.sender; 
   
    DrawRectangle Rect1 = (DrawRectangle)Area.GetDrawObj("Rect1");
        string tagName = Area.Variable[5].ToUpper();
	if(tagName != "N")
		D3.Caption = tagName;
	else
           {
		D3.Caption = "";
                Rect1.Visible = false;
            }
    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void Rect3_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect3 = (DrawRectangle)dynArgs.sender; 
   
    Rect3.Visible = false;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void Rect3_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect3 = (DrawRectangle)dynArgs.sender; 
   
    DrawText D5 = (DrawText)Area.GetDrawObj("D5");
    if(D5.Caption == "" )
       {
            Rect3.Visible = false;
       }
    else
       {
            Rect3.Visible = true;
        }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void Rect2_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect2 = (DrawRectangle)dynArgs.sender; 
   
    Rect2.Visible = false;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void Rect2_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect2 = (DrawRectangle)dynArgs.sender; 
   
    DrawText D4 = (DrawText)Area.GetDrawObj("D4");
    if(D4.Caption == "" )
       {
            Rect2.Visible = false;
       }
    else
       {
            Rect2.Visible = true;
        }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void Rect1_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect1 = (DrawRectangle)dynArgs.sender; 
   
    Rect1.Visible = false;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void Rect1_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect1 = (DrawRectangle)dynArgs.sender; 
   
    DrawText D3 = (DrawText)Area.GetDrawObj("D3");
    if(D3.Caption == "" )
       {
            Rect1.Visible = false;
       }
    else
       {
            Rect1.Visible = true;
        }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void D2_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText D2 = (DrawText)dynArgs.sender; 
   
    Area.Variable[2] = "2";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void D2_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText D2 = (DrawText)dynArgs.sender; 
   
        string tagName = Area.Variable[4].ToUpper();
	if(tagName != "")
		D2.Caption = tagName;
	else
		D2.Caption = "";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void D1_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText D1 = (DrawText)dynArgs.sender; 
   
    Area.Variable[2] = "1";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void D1_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText D1 = (DrawText)dynArgs.sender; 
   
        string tagName = Area.Variable[3].ToUpper();
	if(tagName != "")
		D1.Caption = tagName;
	else
		D1.Caption = "";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void NAME_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText NAME = (DrawText)dynArgs.sender; 
   
    string tagName = Area.Variable[1].ToUpper();

	if(tagName != "")
		NAME.Caption = tagName;
	else
		NAME.Caption = "******";	

    return; 
}

}
