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
public class PIC_Untitled:IDynCodeAttachDetach
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
   strObjectName = "DrawArea1";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)DrawArea1_KeyUp;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "DrawArea1";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea1_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea1.Text3";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea1_Text3_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea1.Text2";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea1_Text2_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea1.Text1";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea1_Text1_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea1.Text1";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea1_Text1_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea1.TB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)DrawArea1_TB_KeyUp;
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
strObjectName = "DrawArea1";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)DrawArea1_KeyUp;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);
strObjectName = "DrawArea1";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea1_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea1.Text3";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea1_Text3_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea1.Text2";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea1_Text2_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea1.Text1";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)DrawArea1_Text1_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea1.Text1";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)DrawArea1_Text1_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "DrawArea1.TB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)DrawArea1_TB_KeyUp;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);

    return;
}

//Do not remove or update this comment
//Event Delegate:KeyEventHandler 
//Event Handler:KeyUp 
public void DrawArea1_KeyUp(Object sender, KeyEventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   
     DrawText Text1 = (DrawText)Area.GetDrawObj("Text1");
     DrawText Text2 = (DrawText)Area.GetDrawObj("Text2");

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
                        if(Text1.Caption == "ENTER SCHEMATIC NAME")

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
public void DrawArea1_OnDynInitialize(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 
   
     object obj=Area.GetControlObj("TB");
     TextBox TB=(TextBox)obj;
     TB.Visible = false;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void DrawArea1_Text3_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText Text3 = (DrawText)dynArgs.sender;
 
        object obj=Area.GetControlObj("TB");

		TextBox TB=(TextBox)obj;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void DrawArea1_Text2_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText Text2 = (DrawText)dynArgs.sender;
 
    Text2.Caption = "";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void DrawArea1_Text1_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText Text1 = (DrawText)dynArgs.sender; 
 
        Text1.Caption = "";	
        Text1.Variable[1] = "";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void DrawArea1_Text1_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText Text1 = (DrawText)dynArgs.sender; 
   
    Text1.Variable[0] = CommonFunction._ProjectRelated.Var[0];

    if(Text1.Variable[0] == "11")
       {
        Text1.Caption = "";	
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
  
    if(Text1.Variable[0] == "1")
       {
        Text1.Caption = "ENTER SCHEMATIC NAME";	
        Text1.ForegroundColor = Color.Lime;

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
  

    if(Text1.Variable[0] == "2")
       {
        Text1.Caption = "ENTER GROUP NUMBER";
        Text1.ForegroundColor = Color.Lime;
	
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

    if(Text1.Variable[0] == "3")
       {
        Text1.Caption = "ENTER TAG NAME";
        Text1.ForegroundColor = Color.Lime;
	
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

    if(Text1.Variable[0] == "4")
       {
        Text1.Caption = "ENTER UNIT NUMBER";
        Text1.ForegroundColor = Color.Lime;
	
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

    if(Text1.Variable[0] == "5")
       {
        Text1.Caption = "SELECT UNIT";
        Text1.ForegroundColor = Color.Lime;
	
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

    if(Text1.Variable[0] == "6")
       {
        Text1.Caption = "PRESS ENTER TO EXECUTE";	
        Text1.ForegroundColor = Color.Yellow;

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

    if(Text1.Variable[0] != Text1.Variable[1])
      
      {
          DrawText Text2 = (DrawText)Area.GetDrawObj("Text2");
          Text2.Caption = "";
       }
    Text1.Variable[1] = Text1.Variable[0]; 

    CommonFunction._ProjectRelated.Var[0] = "";
    CommonFunction._ProjectRelated.Var[1] = "";

    return; 
}
//Do not remove or update this comment
//Event Delegate:KeyEventHandler 
//Event Handler:KeyUp 
public void DrawArea1_TB_KeyUp(Object sender, KeyEventArgs e)
{
   TextBox TB = (TextBox)sender; 

     DrawArea Area = CommonFunction.GetThisDrawArea(TB);
     DrawText Text1 = (DrawText)Area.GetDrawObj("Text1");
     DrawText Text2 = (DrawText)Area.GetDrawObj("Text2");
     DrawText Text3 = (DrawText)Area.GetDrawObj("Text3");
	switch ( e.KeyData )
	{
	case Keys.Enter:

		if(TB.Text == "" || TB.Text == null)

		{
                       if(Text1.Caption == "ENTER SCHEMATIC NAME")

                           {
                              Text2.Caption = "INVALID";
                           }

                        if(Text1.Caption == "ENTER GROUP NUMBER")

                           {
                              Text2.Caption = "INVALID INPUT";
                           }
			
                        if(Text1.Caption == "ENTER TAG NAME")

                           {
                               Text2.Caption = "INVALID";                                 
                           }
		}

		else

		{
                        if(Text1.Caption == "ENTER SCHEMATIC NAME")

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
                                       Text1.Caption = "";
			               Text2.Caption = "";
			               TB.Visible = false;
			               TB.Enabled = false;
                                   }
                              else
                                  {
	                               Text2.Caption = "INVALID";
                                   }                            
                              Text3.Caption = t.ToString();

                           }

                        if(Text1.Caption == "ENTER GROUP NUMBER")

                           {
                              string Input = TB.Text;
                              int nLeft = 0;
	                      int nTop = 0;
	                      string[] strVariable = new string[1];
	                      strVariable[0] = TB.Text;
	                      //CommonFunction.OpenPicture("GROUP.grf", nTop, nLeft, strVariable);
                              CommonFunction.OpenControlGroup(TB.Text, nTop, nLeft, "GROUP.grf");
                           }
			
                        if(Text1.Caption == "ENTER TAG NAME")

                           {
                              string Input = TB.Text;
                              bool dt = CommonFunction.OpenDetail(Input);
                              if(dt == true)

                                  { 
                                       CommonFunction.OpenDetail(Input);
                                       Text1.Caption = "";
			               Text2.Caption = "";
			               TB.Visible = false;
			               TB.Enabled = false;
                                  }

                              else 

                                  {
	                               Text2.Caption = "INVALID";
                                  }  
                                     Text3.Caption = dt.ToString();                              
                           }

                        TB.ForeColor = Color.Lime;
                        return;
		}

		break;
	}



    return; 
}


}
