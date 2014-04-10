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
public class PIC_Group_Detail :IDynCodeAttachDetach
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
_EventHandler= (EventHandler)PIC_Group_Detail _OnDynInitialize;
CodeDomCommon.AttachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PIC_Group_Detail _OnDynClick;
CodeDomCommon.AttachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "Disposed";
_EventHandler= (EventHandler)PIC_Group_Detail _Disposed;
CodeDomCommon.AttachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)PIC_Group_Detail _KeyUp;
CodeDomCommon.AttachAreaEventHandler(area,strEventName,_KeyEventHandler);
strObjectName = "ALM";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)ALM_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "ALM";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)ALM_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OPBar";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)OPBar_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OPBar";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)OPBar_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVBlack";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVBlack_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVBlack";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PVBlack_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SPLine";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)SPLine_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SPLine";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)SPLine_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVBar";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PVBar_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVBar";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVBar_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "MODE";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)MODE_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "MODE";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)MODE_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect_MODE";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect_MODE_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Unit";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Unit_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Unit";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Unit_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TagName";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)TagName_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TagName_OnDynAnimation;
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
_EventHandler= (EventHandler)PIC_Group_Detail _OnDynInitialize;
CodeDomCommon.DetachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PIC_Group_Detail _OnDynClick;
CodeDomCommon.DetachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "Disposed";
_EventHandler= (EventHandler)PIC_Group_Detail _Disposed;
CodeDomCommon.DetachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)PIC_Group_Detail _KeyUp;
CodeDomCommon.DetachAreaEventHandler(area,strEventName,_KeyEventHandler);
strObjectName = "ALM";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)ALM_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "ALM";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)ALM_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OPBar";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)OPBar_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OPBar";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)OPBar_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVBlack";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVBlack_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVBlack";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PVBlack_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SPLine";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)SPLine_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SPLine";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)SPLine_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVBar";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PVBar_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVBar";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVBar_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "MODE";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)MODE_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "MODE";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)MODE_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect_MODE";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect_MODE_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Unit";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Unit_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Unit";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Unit_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TagName";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)TagName_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TagName_OnDynAnimation;
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
strObjectName = "TB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)TB_KeyUp;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);

    return;
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void PIC_Group_Detail _OnDynInitialize(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 
/* 
	Picture pic = CommonFunction.GetThisPicture(Area);
	if(pic != null)
	{  
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
				TB.Visible = false;
				TB.Focus();
			}
                        DrawArea MainArea = pic.GetDrawArea();
			Area.Variable[0] = MainArea.Variable[0];
			ControlLabel lab = (ControlLabel)CommonFunction.GetLabelOfControl(Area);
			lab.Selected = false;
			
		}
		else
		{
			pic.Text = Area.Variable[0];
		}

        Picture picT = (Picture)(Area.Parent.Parent);
	Area.Variable[0] = picT.Variable[0];	
	Area.Enabled = true;


	}
*/

    Type type = (Area.Parent).GetType();

      if (type.Name == "DrawArea" || type.Name == "Picture")
       { 
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
				TB.Visible = false;
				TB.Focus();
			}
//                        DrawArea MainArea = pic.GetDrawArea();
//			Area.Variable[0] = MainArea.Variable[0];
			ControlLabel lab = (ControlLabel)CommonFunction.GetLabelOfControl(Area);
			lab.Selected = false;

			Area.Enabled = true;	
		}
	Area.Enabled = true;
      }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void PIC_Group_Detail _OnDynClick(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 

    Type type = (Area.Parent).GetType();

      if (type.Name == "DrawArea")
       {    
          DrawArea pic = (DrawArea)(Area.Parent.Parent);

         object obj = Area.GetControlObj("TB");
           if(obj!=null)
	      {
		TextBox TB=(TextBox)obj;
		TB.Visible=false;
	       }
        }
      if (type.Name == "Picture")
       { 
          Picture pic = (Picture)(Area.Parent); 
  
          object obj = Area.GetControlObj("TB");
           if(obj!=null)
	      {
		TextBox TB=(TextBox)obj;
		TB.Visible=false;
	       }
      }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:Disposed 
public void PIC_Group_Detail _Disposed(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 

    Type type = (Area.Parent).GetType();

      if (type.Name == "DrawArea")
       { 

             DrawArea pic = (DrawArea)(Area.Parent.Parent);
             TextBox TB = (TextBox)pic.GetDrawObj("TB");
             TB.Enabled = false;
        }
      if (type.Name == "Picture")
       { 

             Picture pic = (Picture)(Area.Parent);
             TextBox TB = (TextBox)pic.GetDrawObj("TB");
             TB.Enabled = false;
        }

    return; 
}
//Do not remove or update this comment
//Event Delegate:KeyEventHandler 
//Event Handler:KeyUp 
public void PIC_Group_Detail _KeyUp(Object sender, KeyEventArgs e)
{
   TextBox TB = (TextBox)sender; 
   DrawArea Area = CommonFunction.GetThisDrawArea(TB);

    Type type = (Area.Parent).GetType();

      if (type.Name == "DrawArea")
       { 

   DrawArea pic = (DrawArea)(Area.Parent.Parent);
   DrawArea Top = (DrawArea)pic.GetDrawObj("TDC3000_Top");

     double dbValue = 0;
     int nValue = 0;
     bool bValue = false;
     int nDataType = 0;

        double OPHI = 0;
        double OPLO = 0;
        double SPEUHI = 0;
        double SPEULO = 0;
        double PVEUHI = 0;
        double PVEULO = 0;

	string tagName = Area.Variable[0] + "/OPHI";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     OPHI = dbValue;             
	}

	tagName = Area.Variable[0] + "/OPLO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     OPLO = dbValue;             
	}

	tagName = Area.Variable[0] + "/SPEUHI";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     SPEUHI = dbValue;             
	}

	tagName = Area.Variable[0] + "/SPEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     SPEULO = dbValue;             
	}

	tagName = Area.Variable[0] + "/PVEUHI";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEUHI = dbValue;        
	}

	tagName = Area.Variable[0] + "/PVEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEULO = dbValue;             
	}

     double dbValue1 = 0;
     int nValue1 = 0;
     bool bValue1 = false;
     int nDataType1 = 0;
     string MODE = Area.Variable[0] + "/MODE";
     bool ret1 = CommonFunction.GetValueWithType(MODE,ref dbValue1,ref nValue1,ref bValue1,ref nDataType1);

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
			string PVInputValue = TB.Text;
			double dbPVValue = Convert.ToDouble(PVInputValue);

			object obj1 = CommonFunction.GetLabelOfControl(TB);

			if (obj1 != null)

			{
		             ControlLabel lab=(ControlLabel)obj1;
		             string tag=lab.Variable[0];

                             //PV值只有在MODE是MAN的时候才可以改变
                             bool V = tag.Contains("PV");
                             bool O = tag.Contains("OP");
                             bool S = tag.Contains("SP");
                             if(V == true && ret1)
                               {
                                    if(dbPVValue<=PVEUHI && dbPVValue>=PVEULO)
                                       {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                       }
                                    else
                                       {
				          Top.Variable[4] = "LMT OR RANGE ERROR";
                                       }
                               }

                             if(O == true && ret1)
                               {//OP值只有在MODE是MAN的时候才可以改变
	                 	  if(dbValue1==1)
                                   {
                                    if(dbPVValue<=OPHI && dbPVValue>=OPLO)
                                       {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                       }
                                    else
                                      {
				          Top.Variable[4] = "LMT OR RANGE ERROR";
                                       }
                                    }
	                	  else 
                                    {
                                        Top.Variable[4] = "MODE ERROR";

                                    }
                               }

                             if(S == true && ret1)
                               {//SP值只有在MODE是AUTO的时候才可以改变
                                if(dbValue1==2)
                                 {
	                 	  if(dbPVValue<=SPEUHI && dbPVValue>=SPEULO)

				   {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                   }
	                	  else 
                                    {
                                        Top.Variable[4] = "LMT OR RANGE ERROR";
                                    }
                                  }
	                	  else 
                                    {
                                        Top.Variable[4] = "MODE ERROR";

                                    }
                               }
			}      
                        TB.ForeColor = Color.Lime;
			TB.Visible = false;
			TB.Enabled = false;
                        return;
		}
		break;
                
	}

Top.Variable[4] = "";
     }

      if (type.Name == "Picture")
       { 

   Picture pic = (Picture)(Area.Parent);
   DrawArea Top = (DrawArea)pic.GetDrawObj("TDC3000_Top");

     double dbValue = 0;
     int nValue = 0;
     bool bValue = false;
     int nDataType = 0;

        double OPHI = 0;
        double OPLO = 0;
        double SPEUHI = 0;
        double SPEULO = 0;
        double PVEUHI = 0;
        double PVEULO = 0;

	string tagName = Area.Variable[0] + "/OPHI";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     OPHI = dbValue;             
	}

	tagName = Area.Variable[0] + "/OPLO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     OPLO = dbValue;             
	}

	tagName = Area.Variable[0] + "/SPEUHI";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     SPEUHI = dbValue;             
	}

	tagName = Area.Variable[0] + "/SPEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     SPEULO = dbValue;             
	}

	tagName = Area.Variable[0] + "/PVEUHI";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEUHI = dbValue;        
	}

	tagName = Area.Variable[0] + "/PVEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEULO = dbValue;             
	}

     double dbValue1 = 0;
     int nValue1 = 0;
     bool bValue1 = false;
     int nDataType1 = 0;
     string MODE = Area.Variable[0] + "/MODE";
     bool ret1 = CommonFunction.GetValueWithType(MODE,ref dbValue1,ref nValue1,ref bValue1,ref nDataType1);

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
			string PVInputValue = TB.Text;
			double dbPVValue = Convert.ToDouble(PVInputValue);

			object obj1 = CommonFunction.GetLabelOfControl(TB);

			if (obj1 != null)

			{
		             ControlLabel lab=(ControlLabel)obj1;
		             string tag=lab.Variable[0];

                             //PV值只有在MODE是MAN的时候才可以改变
                             bool V = tag.Contains("PV");
                             bool O = tag.Contains("OP");
                             bool S = tag.Contains("SP");
                             if(V == true && ret1)
                               {
                                    if(dbPVValue<=PVEUHI && dbPVValue>=PVEULO)
                                       {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                       }
                                    else
                                       {
				          Top.Variable[4] = "LMT OR RANGE ERROR";
                                       }
                               }

                             if(O == true && ret1)
                               {//OP值只有在MODE是MAN的时候才可以改变
	                 	  if(dbValue1==1)
                                   {
                                    if(dbPVValue<=OPHI && dbPVValue>=OPLO)
                                       {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                       }
                                    else
                                      {
				          Top.Variable[4] = "LMT OR RANGE ERROR";
                                       }
                                    }
	                	  else 
                                    {
                                        Top.Variable[4] = "MODE ERROR";

                                    }
                               }

                             if(S == true && ret1)
                               {//SP值只有在MODE是AUTO的时候才可以改变
                                if(dbValue1==2)
                                 {
	                 	  if(dbPVValue<=SPEUHI && dbPVValue>=SPEULO)

				   {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                   }
	                	  else 
                                    {
                                        Top.Variable[4] = "LMT OR RANGE ERROR";
                                    }
                                  }
	                	  else 
                                    {
                                        Top.Variable[4] = "MODE ERROR";

                                    }
                               }
			}      
                        TB.ForeColor = Color.Lime;
			TB.Visible = false;
			TB.Enabled = false;
                        return;
		}
		break;
                
	}

Top.Variable[4] = "";
     }
    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void ALM_OnDynInitialize(Object sender, EventArgs e)	//TagName
{
	DrawArea Area = (DrawArea)sender; 
	DynEventArgs dynArgs = (DynEventArgs)e; 
	DrawText ALM = (DrawText)dynArgs.sender; 

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
	
	tagName = Area.Variable[0] + "/PVHLFL";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
               string alm = dbValue.ToString(strDigit);

		if(alm == "0.00")

                   {ALM.Caption = "";}

		if(alm == "1.00")

                   {ALM.Caption = "HP";}

		if(alm == "2.00")

                   {ALM.Caption = "2HP";}

		if(alm == "-1.00")

                   {ALM.Caption = "LP";}

		if(alm == "-2.00")

                   {ALM.Caption = "2LP";}
	}
	else
		ALM.Caption = "";
        	
	return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void ALM_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText ALM = (DrawText)dynArgs.sender; 
   
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
	
	tagName = Area.Variable[0] + "/PVHLFL";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
              string alm = dbValue.ToString(strDigit);

		if(alm == "0.00")

                   {ALM.Caption = "";}

		if(alm == "1.00")

                   {ALM.Caption = "HP";}

		if(alm == "2.00")

                   {ALM.Caption = "2HP";}

		if(alm == "-1.00")

                   {ALM.Caption = "LP";}

		if(alm == "-2.00")

                   {ALM.Caption = "2LP";}
	}
	else
		ALM.Caption = "";
        	

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void OPBar_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawLine OPBar = (DrawLine)dynArgs.sender; 
   
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	double OPValue = 0;
        double OPHI = 0;
        double OPLO = 0;

	string tagName = Area.Variable[0] + "/OPHI";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     OPHI = dbValue;
             
	}

	tagName = Area.Variable[0] + "/OPLO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     OPLO = dbValue;
             
	}
	
	tagName = Area.Variable[0] + "/OP";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
             OPValue = dbValue;
             double OPScale = OPValue/(OPHI - OPLO);
             OPBar.EndY = 334 - (334 - 58) * OPScale;    
	}
	else
             OPBar.EndY = 334;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void OPBar_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawLine OPBar = (DrawLine)dynArgs.sender; 
   
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	double OPValue = 0;
        double OPHI = 0;
        double OPLO = 0;

	string tagName = Area.Variable[0] + "/OPHI";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     OPHI = dbValue;
             
	}

	tagName = Area.Variable[0] + "/OPLO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     OPLO = dbValue;
             
	}
	
	tagName = Area.Variable[0] + "/OP";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
             OPValue = dbValue;
             double OPScale = OPValue/(OPHI - OPLO);
             OPBar.EndY = 334 - (334 - 58) * OPScale;    
	}
	else
             OPBar.EndY = 334;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void PVBlack_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawLine PVBlack = (DrawLine)dynArgs.sender; 
   
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	double PVValue = 0;
	
	String tagName = Area.Variable[0] + "/PV";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
             if(dbValue == 0)
                {
                    PVBlack.EdgeColor = Color.Cyan;
                }
             else
                {
                    PVBlack.EdgeColor = Color.Black;
                }
	}
	else
        {
             PVBlack.EdgeColor = Color.Black;
        }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void PVBlack_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawLine PVBlack = (DrawLine)dynArgs.sender; 
   
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	double PVValue = 0;
	
	String tagName = Area.Variable[0] + "/PV";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
             if(dbValue == 0)
                {
                    PVBlack.EdgeColor = Color.Cyan;
                }
             else
                {
                    PVBlack.EdgeColor = Color.Black;
                }
	}
	else
        {
             PVBlack.EdgeColor = Color.Black;
        }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void SPLine_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawLine SPLine = (DrawLine)dynArgs.sender; 

	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	double SPValue = 0;
        double SPEUHI = 0;
        double SPEULO = 0;

	string tagName = Area.Variable[0] + "/SPEUHI";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     SPEUHI = dbValue;
             
	}

	tagName = Area.Variable[0] + "/SPEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     SPEULO = dbValue;
             
	}
	
	tagName = Area.Variable[0] + "/SP";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
             SPValue = dbValue;
             double SPScale = SPValue/(SPEUHI - SPEULO);
             SPLine.VerticalPosition = 334 - (334 - 58) * SPScale;    
	}
	else
             SPLine.VerticalPosition = 334;
   
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void SPLine_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawLine SPLine = (DrawLine)dynArgs.sender; 

	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	double SPValue = 0;
        double SPEUHI = 0;
        double SPEULO = 0;

	string tagName = Area.Variable[0] + "/SPEUHI";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     SPEUHI = dbValue;
             
	}

	tagName = Area.Variable[0] + "/SPEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     SPEULO = dbValue;
             
	}
	
	tagName = Area.Variable[0] + "/SP";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
             SPValue = dbValue;
             double SPScale = SPValue/(SPEUHI - SPEULO);
             SPLine.VerticalPosition = 334 - (334 - 58) * SPScale;    
	}
	else
             SPLine.VerticalPosition = 334;
   
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
	
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	double PVValue = 0;
        double PVEUHI = 0;
        double PVEULO = 0;

	string tagName = Area.Variable[0] + "/PVEUHI";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEUHI = dbValue;
             
	}

	tagName = Area.Variable[0] + "/PVEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEULO = dbValue;
             
	}
	
	tagName = Area.Variable[0] + "/PV";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
             PVValue = dbValue;
             double PVScale = PVValue/(PVEUHI - PVEULO);
             PVBar.Height = (334.00 - 58.00) * PVScale;
             PVBar.VerticalPosition = 334.00 - PVBar.Height;    
	}
	else
        {
             PVBar.VerticalPosition = 334.00;
             PVBar.Height = 0;
        }

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
	
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	double PVValue = 0;
        double PVEUHI = 0;
        double PVEULO = 0;

	string tagName = Area.Variable[0] + "/PVEUHI";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEUHI = dbValue;
             
	}

	tagName = Area.Variable[0] + "/PVEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEULO = dbValue;
             
	}
	
	tagName = Area.Variable[0] + "/PV";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
             PVValue = dbValue;
             double PVScale = PVValue/(PVEUHI - PVEULO);
             PVBar.Height = (334.00 - 58.00) * PVScale;
             PVBar.VerticalPosition = 334.00 - PVBar.Height;    
	}
	else
        {
             PVBar.VerticalPosition = 334.00;
             PVBar.Height = 0;
        }

	return; 
}//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void MODE_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText MODE = (DrawText)dynArgs.sender; 

    DrawRectangle Rect = (DrawRectangle)Area.GetDrawObj("Rect_MODE");  
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	int nDigit = 2;
	string tagName = Area.Variable[0] + "/MODE";

	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
            {
                if(dbValue == 1)
                  {
                      MODE.Caption = "MAN";
                      MODE.ForegroundColor = Color.Black;
                      Rect.ForegroundColor = Color.Yellow;
                  }
                if(dbValue == 2)
                  {
                      MODE.Caption = "AUTO";
                      MODE.ForegroundColor = Color.Cyan;
                      Rect.ForegroundColor = Color.Black;
                  }
                if(dbValue == 3)
                  {
                      MODE.Caption = "CAS";
                      MODE.ForegroundColor = Color.Black;
                      Rect.ForegroundColor = Color.Cyan;
                  }
            }
       else
            {MODE.Caption = "###";}

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void MODE_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText MODE = (DrawText)dynArgs.sender; 
   
    DrawRectangle Rect = (DrawRectangle)Area.GetDrawObj("Rect_MODE");  
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	int nDigit = 2;
	string tagName = Area.Variable[0] + "/MODE";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
            {
                if(dbValue == 1)
                  {
                      MODE.Caption = "MAN";
                      MODE.ForegroundColor = Color.Black;
                      Rect.ForegroundColor = Color.Yellow;
                  }
                if(dbValue == 2)
                  {
                      MODE.Caption = "AUTO";
                      MODE.ForegroundColor = Color.Cyan;
                      Rect.ForegroundColor = Color.Black;
                  }
                if(dbValue == 3)
                  {
                      MODE.Caption = "CAS";
                      MODE.ForegroundColor = Color.Black;
                      Rect.ForegroundColor = Color.Cyan;
                  }
            }
       else
            {MODE.Caption = "###";}
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void Rect_MODE_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect_MODE = (DrawRectangle)dynArgs.sender; 

       Type type = (Area.Parent).GetType();

      if (type.Name == "DrawArea")
       {
           DrawArea pic = (DrawArea)(Area.Parent.Parent);
           DrawArea G = (DrawArea)pic.GetDrawObj("Group_Detail_1");
           G.Visible = true;
           G.Variable[0] = Area.Variable[0];
       }
      if (type.Name == "Picture")
       {
           Picture pic = (Picture)(Area.Parent);
           DrawArea G = (DrawArea)pic.GetDrawObj("Group_Detail_1");
           G.Visible = true;
           G.Variable[0] = Area.Variable[0];
       }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void Unit_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText Unit = (DrawText)dynArgs.sender; 
   
    Unit.Caption = CommonFunction.GetPVUnit(Area.Variable[0]);

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void Unit_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText Unit = (DrawText)dynArgs.sender; 
   
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
//Event Handler:OnDynAnimation 
public void TagName_OnDynAnimation(Object sender, EventArgs e)
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

    object obj = Area.GetControlObj("TB");
	
	TextBox TB = (TextBox)obj; 

          if(TB.Visible == false)

            {
                PV.ForegroundColor = Color.Cyan;
//                DrawText Text_PV = (DrawText)Area.GetDrawObj("Text_PV");
//                Text_PV.ForegroundColor = Color.Cyan;
            }



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
//    DrawText Text_PV = (DrawText)Area.GetDrawObj("Text_PV");
//    Text_PV.ForegroundColor = Color.White;

    if(PV.Visible == true)

	{
		// 不弹出输入面板，DrawText隐藏，TextBox显示	
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
                                //调整TB的位置：
				CommonFunction.MoveControl(Area,TB,(int)(PV.VerticalPosition)-40,(int)(PV.HorizontalPosition)+40);
			
				obj = CommonFunction.GetLabelOfControl(TB);
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
	
	tagName = Area.Variable[0] + "/SP";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		SP.Caption = dbValue.ToString(strDigit);
	}
	else
		SP.Caption = "##.#";

    object obj = Area.GetControlObj("TB");
	
	TextBox TB = (TextBox)obj; 

          if(TB.Visible == false)

            {
                SP.ForegroundColor = Color.Cyan;
            }


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
	
	tagName = Area.Variable[0] + "/SP";
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
//    DrawText Text_SP = (DrawText)Area.GetDrawObj("Text_SP");
//    Text_SP.ForegroundColor = Color.White;

    if(SP.Visible == true)

	{
		// 不弹出输入面板，DrawText隐藏，TextBox显示	
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
                                //调整TB的位置：
				CommonFunction.MoveControl(Area,TB,(int)(SP.VerticalPosition - 40),(int)(SP.HorizontalPosition)+40);		
				obj = CommonFunction.GetLabelOfControl(TB);
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

    object obj = Area.GetControlObj("TB");
	
	TextBox TB = (TextBox)obj; 

          if(TB.Visible == false)

            {
                OP.ForegroundColor = Color.Yellow;
            }

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
//    DrawText Text_OP = (DrawText)Area.GetDrawObj("Text_OP");
//    Text_OP.ForegroundColor = Color.White;

    if(OP.Visible == true)

	{
		// 不弹出输入面板，DrawText隐藏，TextBox显示	
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

                                //调整TB的位置：
			        CommonFunction.MoveControl(Area,TB,(int)(OP.VerticalPosition)-40,(int)(OP.HorizontalPosition)+40);
				
				obj = CommonFunction.GetLabelOfControl(TB);
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
//Event Delegate:KeyEventHandler 
//Event Handler:KeyUp 
public void TB_KeyUp(Object sender, KeyEventArgs e)
{
   TextBox TB = (TextBox)sender; 

   DrawArea Area = CommonFunction.GetThisDrawArea(TB);

    Type type = (Area.Parent).GetType();

      if (type.Name == "Picture")
       { 
   Picture pic = (Picture)(Area.Parent);
   DrawArea Top = (DrawArea)pic.GetDrawObj("TDC3000_Top");

     double dbValue = 0;
     int nValue = 0;
     bool bValue = false;
     int nDataType = 0;

        double OPHI = 0;
        double OPLO = 0;
        double SPEUHI = 0;
        double SPEULO = 0;
        double PVEUHI = 0;
        double PVEULO = 0;

	string tagName = Area.Variable[0] + "/OPHI";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     OPHI = dbValue;             
	}

	tagName = Area.Variable[0] + "/OPLO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     OPLO = dbValue;             
	}

	tagName = Area.Variable[0] + "/SPEUHI";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     SPEUHI = dbValue;             
	}

	tagName = Area.Variable[0] + "/SPEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     SPEULO = dbValue;             
	}

	tagName = Area.Variable[0] + "/PVEUHI";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEUHI = dbValue;        
	}

	tagName = Area.Variable[0] + "/PVEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEULO = dbValue;             
	}

     double dbValue1 = 0;
     int nValue1 = 0;
     bool bValue1 = false;
     int nDataType1 = 0;
     string MODE = Area.Variable[0] + "/MODE";
     bool ret1 = CommonFunction.GetValueWithType(MODE,ref dbValue1,ref nValue1,ref bValue1,ref nDataType1);

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
			string PVInputValue = TB.Text;
			double dbPVValue = Convert.ToDouble(PVInputValue);

			object obj1 = CommonFunction.GetLabelOfControl(TB);

			if (obj1 != null)

			{
		             ControlLabel lab=(ControlLabel)obj1;
		             string tag=lab.Variable[0];

                             //PV值只有在MODE是MAN的时候才可以改变
                             bool V = tag.Contains("PV");
                             bool O = tag.Contains("OP");
                             bool S = tag.Contains("SP");
                             if(V == true && ret1)
                               {
                                    if(dbPVValue<=PVEUHI && dbPVValue>=PVEULO)
                                       {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                       }
                                    else
                                       {
				          Top.Variable[4] = "LMT OR RANGE ERROR";
                                       }
                               }

                             if(O == true && ret1)
                               {//OP值只有在MODE是MAN的时候才可以改变
	                 	  if(dbValue1==1)
                                   {
                                    if(dbPVValue<=OPHI && dbPVValue>=OPLO)
                                       {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                       }
                                    else
                                      {
				          Top.Variable[4] = "LMT OR RANGE ERROR";
                                       }
                                    }
	                	  else 
                                    {
                                        Top.Variable[4] = "MODE ERROR";

                                    }
                               }

                             if(S == true && ret1)
                               {//SP值只有在MODE是AUTO的时候才可以改变
                                if(dbValue1==2)
                                 {
	                 	  if(dbPVValue<=SPEUHI && dbPVValue>=SPEULO)

				   {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                   }
	                	  else 
                                    {
                                        Top.Variable[4] = "LMT OR RANGE ERROR";
                                    }
                                  }
	                	  else 
                                    {
                                        Top.Variable[4] = "MODE ERROR";

                                    }
                               }
			}      
                        TB.ForeColor = Color.Lime;
			TB.Visible = false;
			TB.Enabled = false;
                        return;
		}
		break;
                
	}
Top.Variable[4] = "";
    }

      if (type.Name == "DrawArea")
       { 
   DrawArea pic = (DrawArea)(Area.Parent.Parent);
   DrawArea Top = (DrawArea)pic.GetDrawObj("TDC3000_Top");

     double dbValue = 0;
     int nValue = 0;
     bool bValue = false;
     int nDataType = 0;

        double OPHI = 0;
        double OPLO = 0;
        double SPEUHI = 0;
        double SPEULO = 0;
        double PVEUHI = 0;
        double PVEULO = 0;

	string tagName = Area.Variable[0] + "/OPHI";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     OPHI = dbValue;             
	}

	tagName = Area.Variable[0] + "/OPLO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     OPLO = dbValue;             
	}

	tagName = Area.Variable[0] + "/SPEUHI";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     SPEUHI = dbValue;             
	}

	tagName = Area.Variable[0] + "/SPEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     SPEULO = dbValue;             
	}

	tagName = Area.Variable[0] + "/PVEUHI";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEUHI = dbValue;        
	}

	tagName = Area.Variable[0] + "/PVEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEULO = dbValue;             
	}

     double dbValue1 = 0;
     int nValue1 = 0;
     bool bValue1 = false;
     int nDataType1 = 0;
     string MODE = Area.Variable[0] + "/MODE";
     bool ret1 = CommonFunction.GetValueWithType(MODE,ref dbValue1,ref nValue1,ref bValue1,ref nDataType1);

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
			string PVInputValue = TB.Text;
			double dbPVValue = Convert.ToDouble(PVInputValue);

			object obj1 = CommonFunction.GetLabelOfControl(TB);

			if (obj1 != null)

			{
		             ControlLabel lab=(ControlLabel)obj1;
		             string tag=lab.Variable[0];

                             //PV值只有在MODE是MAN的时候才可以改变
                             bool V = tag.Contains("PV");
                             bool O = tag.Contains("OP");
                             bool S = tag.Contains("SP");
                             if(V == true && ret1)
                               {
                                    if(dbPVValue<=PVEUHI && dbPVValue>=PVEULO)
                                       {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                       }
                                    else
                                       {
				          Top.Variable[4] = "LMT OR RANGE ERROR";
                                       }
                               }

                             if(O == true && ret1)
                               {//OP值只有在MODE是MAN的时候才可以改变
	                 	  if(dbValue1==1)
                                   {
                                    if(dbPVValue<=OPHI && dbPVValue>=OPLO)
                                       {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                       }
                                    else
                                      {
				          Top.Variable[4] = "LMT OR RANGE ERROR";
                                       }
                                    }
	                	  else 
                                    {
                                        Top.Variable[4] = "MODE ERROR";

                                    }
                               }

                             if(S == true && ret1)
                               {//SP值只有在MODE是AUTO的时候才可以改变
                                if(dbValue1==2)
                                 {
	                 	  if(dbPVValue<=SPEUHI && dbPVValue>=SPEULO)

				   {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                   }
	                	  else 
                                    {
                                        Top.Variable[4] = "LMT OR RANGE ERROR";
                                    }
                                  }
	                	  else 
                                    {
                                        Top.Variable[4] = "MODE ERROR";

                                    }
                               }
			}      
                        TB.ForeColor = Color.Lime;
			TB.Visible = false;
			TB.Enabled = false;
                        return;
		}
		break;
                
	}
Top.Variable[4] = "";
    }
    return; 
}


}
warning CS1668: “LIB 环境变量”中指定的搜索路径“C:\Program Files (x86)\Microsoft Visual Studio\VC98\mfc\lib”无效 --“系统找不到指定的路径。 ”
warning CS1668: “LIB 环境变量”中指定的搜索路径“C:\Program Files (x86)\Microsoft Visual Studio\VC98\lib”无效 --“系统找不到指定的路径。 ”
c:\Users\haodongdong\AppData\Local\Temp\bzkv5ypd.0.cs(294,30) : error CS1002: 应输入 ;
c:\Users\haodongdong\AppData\Local\Temp\bzkv5ypd.0.cs(371,30) : error CS1002: 应输入 ;
c:\Users\haodongdong\AppData\Local\Temp\bzkv5ypd.0.cs(407,30) : error CS1002: 应输入 ;
c:\Users\haodongdong\AppData\Local\Temp\bzkv5ypd.0.cs(435,30) : error CS1002: 应输入 ;
