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
public class PIC_projectval2:IDynCodeAttachDetach
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
_KeyEventHandler= (KeyEventHandler)PIC_projectval2_KeyUp;
CodeDomCommon.AttachAreaEventHandler(area,strEventName,_KeyEventHandler);
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PIC_projectval2_OnDynInitialize;
CodeDomCommon.AttachAreaEventHandler(area,strEventName,_EventHandler);
strObjectName = "Text4";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Text4_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Caption3";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Caption3_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Caption2";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Caption2_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Caption1";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Caption1_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Caption1";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Caption1_OnDynAnimation;
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
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)PIC_projectval2_KeyUp;
CodeDomCommon.DetachAreaEventHandler(area,strEventName,_KeyEventHandler);
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PIC_projectval2_OnDynInitialize;
CodeDomCommon.DetachAreaEventHandler(area,strEventName,_EventHandler);
strObjectName = "Text4";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Text4_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Caption3";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Caption3_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Caption2";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Caption2_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Caption1";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Caption1_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Caption1";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Caption1_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)TB_KeyUp;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);

    return;
}

//Do not remove or update this comment
//Event Delegate:KeyEventHandler 
//Event Handler:KeyUp 
public void PIC_projectval2_KeyUp(Object sender, KeyEventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   
     DrawText Caption1 = (DrawText)Area.GetDrawObj("Caption1");
     DrawText Caption2 = (DrawText)Area.GetDrawObj("Caption2");

     object obj=Area.GetControlObj("TB");

		TextBox TB=(TextBox)obj;

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
                        if(Caption1.Caption == "ENTER SCHEMATIC NAME")

                           {
                              string Input = TB.Text;
                              int nLeft = 0;
	                      int nTop = 0;
	                      string[] strVariable = new string[1];
	                      strVariable[0] = "";
	                      CommonFunction.OpenPicture(Input + ".grf", nTop, nLeft, strVariable);

                           }
			
			
                        TB.ForeColor = Color.Lime;
			TB.Visible = false;
			TB.Enabled = false;
                        return;
		}
		break;
	}



    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void PIC_projectval2_OnDynInitialize(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 
   
   if(Area.BReference)

	{
	    Area.Enabled = true;
        }

     object obj=Area.GetControlObj("TB");
     TextBox TB=(TextBox)obj;
     TB.Visible = false;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void Text4_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText Text2 = (DrawText)dynArgs.sender; 
   
    DateTime now = DateTime.Now;
    Text2.Caption = now.Day.ToString() + "  " + now.Month.ToString() + "  " + "20" + now.ToString("yy") +  "  " + now.ToString("HH") + ":" +     now.ToString("mm")+ ":" +  now.ToString("ss");

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void Caption3_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText Caption3 = (DrawText)dynArgs.sender;
 
        object obj=Area.GetControlObj("TB");

		TextBox TB=(TextBox)obj;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void Caption2_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText Caption2 = (DrawText)dynArgs.sender;
 
    Caption2.Caption = "";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void Caption1_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText Caption1 = (DrawText)dynArgs.sender; 
 
        Caption1.Caption = "";	
        Caption1.Variable[1] = "";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void Caption1_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText Caption1 = (DrawText)dynArgs.sender; 
   
    Caption1.Variable[0] = CommonFunction._ProjectRelated.Var[0];

    if(Caption1.Variable[0] == "11")
       {
        Caption1.Caption = "";	
        int nLeft = 0;
	int nTop = 0;
	string[] strVariable = new string[1];
	strVariable[0] = "";
	CommonFunction.OpenPicture(CommonFunction._ProjectRelated.Var[1] + ".grf", nTop, nLeft, strVariable);

        object obj = Area.GetControlObj("TB");
		if(obj != null)
		{
			TextBox TB = (TextBox)obj; 
			if(TB != null)
			{
				TB.Visible = false;
				TB.Enabled = true;	
			}
		}

       }
  
    if(Caption1.Variable[0] == "SCHEM")
       {
        Caption1.Caption = "ENTER SCHEMATIC NAME";	
        Caption1.ForegroundColor = Color.Lime;

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
			}
		}
       }
  

    if(Caption1.Variable[0] == "GROUP")
       {
        Caption1.Caption = "ENTER GROUP NUMBER";
        Caption1.ForegroundColor = Color.Lime;
	
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
			}
		}
       }  

    if(Caption1.Variable[0] == "DETAIL")
       {
        Caption1.Caption = "ENTER TAG NAME";
        Caption1.ForegroundColor = Color.Lime;
	
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
			}
		}
       }

    if(Caption1.Variable[0] == "UNITTREND")
       {
        Caption1.Caption = "ENTER UNIT NUMBER";
        Caption1.ForegroundColor = Color.Lime;
	
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
			}
		}
       }

    if(Caption1.Variable[0] == "UNITALMSUMM")
       {
        Caption1.Caption = "SELECT UNIT";
        Caption1.ForegroundColor = Color.Lime;
	
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
			}
		}
       }

    if(Caption1.Variable[0] == "PENTER")
       {
        Caption1.Caption = "PRESS ENTER TO EXECUTE";	
        Caption1.ForegroundColor = Color.Yellow;

        object obj = Area.GetControlObj("TB");
		if(obj != null)
		{
			TextBox TB = (TextBox)obj; 
			if(TB != null)
			{
				TB.Visible = false;
				TB.Enabled = true;	
			}
		}

       }

    if(Caption1.Variable[0] != Caption1.Variable[1])
      
      {
          DrawText Caption2 = (DrawText)Area.GetDrawObj("Caption2");
          Caption2.Caption = "";
       }
    Caption1.Variable[1] = Caption1.Variable[0]; 

    CommonFunction._ProjectRelated.Var[0] = "";
    CommonFunction._ProjectRelated.Var[1] = "";

    return; 
}
//Do not remove or update this comment
//Event Delegate:KeyEventHandler 
//Event Handler:KeyUp 
public void TB_KeyUp(Object sender, KeyEventArgs e)
{
   TextBox TB = (TextBox)sender; 

     DrawArea Area = CommonFunction.GetThisDrawArea(TB);
     DrawText Caption1 = (DrawText)Area.GetDrawObj("Caption1");
     DrawText Caption2 = (DrawText)Area.GetDrawObj("Caption2");
     DrawText Caption3 = (DrawText)Area.GetDrawObj("Caption3");
	switch ( e.KeyData )
	{
	case Keys.Enter:

		if(TB.Text == "" || TB.Text == null)

		{
                       if(Caption1.Caption == "ENTER SCHEMATIC NAME")

                           {
                              Caption2.Caption = "INVALID";
                           }

                        if(Caption1.Caption == "ENTER GROUP NUMBER")

                           {
                              Caption2.Caption = "INVALID INPUT";
                           }
			
                        if(Caption1.Caption == "ENTER TAG NAME")

                           {
                               Caption2.Caption = "INVALID";                                 
                           }
		}

		else

		{
                        if(Caption1.Caption == "ENTER SCHEMATIC NAME")

                           {
                              string Input = TB.Text;
                              int nLeft = 0;
	                      int nTop = 0;
	                      string[] strVariable = new string[1];
	                      strVariable[0] = "";
	                      bool t = CommonFunction.OpenPicture(Input + ".grf", nTop, nLeft, strVariable);
                              if(t == true)
                                  {
	                               CommonFunction.OpenPicture(Input + ".grf", nTop, nLeft, strVariable);
                                       Caption1.Caption = "";
			               Caption2.Caption = "";
			               TB.Visible = false;
			               TB.Enabled = false;
                                   }
                              else
                                  {
	                               Caption2.Caption = "INVALID";
                                   }                            
                              Caption3.Caption = t.ToString();

                           }

                        if(Caption1.Caption == "ENTER GROUP NUMBER")

                           {
                              string Input = TB.Text;
                              int nLeft = 0;
	                      int nTop = 0;
	                      string[] strVariable = new string[1];
	                      strVariable[0] = TB.Text;
	                      //CommonFunction.OpenPicture("GROUP.grf", nTop, nLeft, strVariable);
                              CommonFunction.OpenControlGroup(TB.Text, nTop, nLeft, "GROUP.grf");
                           }
			
                        if(Caption1.Caption == "ENTER TAG NAME")

                           {
                              string Input = TB.Text;
                              bool dt = CommonFunction.OpenDetail(Input);
                              if(dt == true)

                                  { 
                                       CommonFunction.OpenDetail(Input);
                                       Caption1.Caption = "";
			               Caption2.Caption = "";
			               TB.Visible = false;
			               TB.Enabled = false;
                                  }

                              else 

                                  {
	                               Caption2.Caption = "INVALID";
                                  }  
                                     Caption3.Caption = dt.ToString();                              
                           }

                        TB.ForeColor = Color.Lime;
                        return;
		}

		break;
	}



    return; 
}


}
