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
public class PIC_Group_Detail_group:IDynCodeAttachDetach
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
_EventHandler= (EventHandler)PIC_Group_Detail_group_OnDynInitialize;
CodeDomCommon.AttachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PIC_Group_Detail_group_OnDynClick;
CodeDomCommon.AttachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "Disposed";
_EventHandler= (EventHandler)PIC_Group_Detail_group_Disposed;
CodeDomCommon.AttachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)PIC_Group_Detail_group_KeyUp;
CodeDomCommon.AttachAreaEventHandler(area,strEventName,_KeyEventHandler);
strObjectName = "ALM";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)ALM_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OPBar";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)OPBar_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVBlack";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVBlack_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SPLine";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)SPLine_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVBar";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVBar_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "MODE";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)MODE_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect_MODE";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect_MODE_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Unit";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Unit_OnDynAnimation;
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
strObjectName = "SP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)SP_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)SP_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)OP_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)OP_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "R_tagname";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)R_tagname_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "R_tagname";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)R_tagname_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "R_tagname";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)R_tagname_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect7";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Rect7_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect7";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect7_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect7";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Rect7_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect8";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Rect8_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect8";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect8_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect8";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Rect8_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect9";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Rect9_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect9";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect9_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect9";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Rect9_OnDynAnimation;
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
_EventHandler= (EventHandler)PIC_Group_Detail_group_OnDynInitialize;
CodeDomCommon.DetachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PIC_Group_Detail_group_OnDynClick;
CodeDomCommon.DetachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "Disposed";
_EventHandler= (EventHandler)PIC_Group_Detail_group_Disposed;
CodeDomCommon.DetachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)PIC_Group_Detail_group_KeyUp;
CodeDomCommon.DetachAreaEventHandler(area,strEventName,_KeyEventHandler);
strObjectName = "ALM";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)ALM_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OPBar";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)OPBar_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVBlack";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVBlack_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SPLine";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)SPLine_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVBar";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVBar_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "MODE";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)MODE_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect_MODE";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect_MODE_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Unit";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Unit_OnDynAnimation;
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
strObjectName = "SP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)SP_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "SP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)SP_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OP";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)OP_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "OP";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)OP_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "R_tagname";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)R_tagname_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "R_tagname";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)R_tagname_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "R_tagname";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)R_tagname_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect7";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Rect7_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect7";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect7_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect7";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Rect7_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect8";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Rect8_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect8";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect8_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect8";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Rect8_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect9";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Rect9_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect9";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect9_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect9";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Rect9_OnDynAnimation;
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
public void PIC_Group_Detail_group_OnDynInitialize(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 
 
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

	}

   if(Area.BReference)
	{
		Area.Enabled = true;
        }	

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void PIC_Group_Detail_group_OnDynClick(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 
   
   object obj=Area.GetControlObj("TB");
   if(obj!=null)
	{
		TextBox TB=(TextBox)obj;
		TB.Visible=false;
	}

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:Disposed 
public void PIC_Group_Detail_group_Disposed(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 

   TextBox TB = (TextBox)Area.GetDrawObj("TB");
   TB.Enabled = false;
    return; 
}
//Do not remove or update this comment
//Event Delegate:KeyEventHandler 
//Event Handler:KeyUp 
public void PIC_Group_Detail_group_KeyUp(Object sender, KeyEventArgs e)
{
   TextBox TB = (TextBox)sender; 
   DrawArea Area = CommonFunction.GetThisDrawArea(TB);

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
				          CommonFunction._ProjectRelated.Var[1] = "LMT";
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
				          CommonFunction._ProjectRelated.Var[1] = "LMT";
                                       }
                                    }
	                	  else 
                                    {
                                        CommonFunction._ProjectRelated.Var[1] = "MODE ERROR";

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
                                        CommonFunction._ProjectRelated.Var[1] = "LMT";
                                    }
                                  }
	                	  else 
                                    {
                                        CommonFunction._ProjectRelated.Var[1] = "MODE ERROR";

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

CommonFunction._ProjectRelated.Var[1] = "";

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
//Event Handler:OnDynClick 
public void Rect_MODE_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect_MODE = (DrawRectangle)dynArgs.sender; 

           DrawArea pic = (DrawArea)(Area.Parent.Parent);

           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

           DrawArea p = (DrawArea)(Area.Parent.Parent);
           DrawArea G = (DrawArea)p.GetDrawObj("Group_Detail_1");
           G.Visible = true;
           G.Variable[0] = Area.Variable[0];

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


          if(PV.Variable[0] == "1")

            {
                PV.ForegroundColor = Color.White;
            }

          else

            {
                PV.ForegroundColor = Color.Cyan;
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
   
    PV.ForegroundColor = Color.Cyan;
    PV.Variable[0] = "0";

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

          if(SP.Variable[0] == "1")

            {
                SP.ForegroundColor = Color.White;
            }

          else

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
    SP.Variable[0] = "0";

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

          if(OP.Variable[0] == "1")

            {
                OP.ForegroundColor = Color.White;
            }

          else

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
    OP.Variable[0] = "0";

    return; 
}


//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void R_tagname_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 
   
    R_tagname.Visible = true;
    R_tagname.ForegroundColor = Color.Black;
    R_tagname.EdgeColor = Color.Black;
           DrawArea p = (DrawArea)(Area.Parent);
           p.Variable[1] = "0";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void R_tagname_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 
   
           DrawArea pic = (DrawArea)(Area.Parent.Parent);

           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void R_tagname_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 
/*  
       DrawArea pic = (DrawArea)(Area.Parent.Parent);
       DrawArea gd1 = (DrawArea)pic.GetDrawObj("gd1");
       DrawArea gd2 = (DrawArea)pic.GetDrawObj("gd2");
       DrawArea gd3 = (DrawArea)pic.GetDrawObj("gd3");
       DrawArea gd4 = (DrawArea)pic.GetDrawObj("gd4");
       DrawArea gd5 = (DrawArea)pic.GetDrawObj("gd5");
       DrawArea gd6 = (DrawArea)pic.GetDrawObj("gd6");
       DrawArea gd7 = (DrawArea)pic.GetDrawObj("gd7");
       DrawArea gd8 = (DrawArea)pic.GetDrawObj("gd8");

       if(pic.Variable[10] == "1")
       {gd1.Variable[1] = "1";
        gd2.Variable[1] = "0";
        gd3.Variable[1] = "0";
        gd4.Variable[1] = "0";
        gd5.Variable[1] = "0";
        gd6.Variable[1] = "0";
        gd7.Variable[1] = "0";
        gd8.Variable[1] = "0";
       }
    if(pic.Variable[10] == "2")
       {gd2.Variable[1] = "1";
        gd1.Variable[1] = "0";
        gd3.Variable[1] = "0";
        gd4.Variable[1] = "0";
        gd5.Variable[1] = "0";
        gd6.Variable[1] = "0";
        gd7.Variable[1] = "0";
        gd8.Variable[1] = "0";
       }
    if(pic.Variable[10] == "3")
       {gd3.Variable[1] = "1";
        gd2.Variable[1] = "0";
        gd1.Variable[1] = "0";
        gd4.Variable[1] = "0";
        gd5.Variable[1] = "0";
        gd6.Variable[1] = "0";
        gd7.Variable[1] = "0";
        gd8.Variable[1] = "0";
        }
    if(pic.Variable[10] == "4")
       {gd4.Variable[1] = "1";
        gd2.Variable[1] = "0";
        gd3.Variable[1] = "0";
        gd1.Variable[1] = "0";
        gd5.Variable[1] = "0";
        gd6.Variable[1] = "0";
        gd7.Variable[1] = "0";
        gd8.Variable[1] = "0";
        }
    if(pic.Variable[10] == "5")
       {gd5.Variable[1] = "1";
        gd2.Variable[1] = "0";
        gd3.Variable[1] = "0";
        gd4.Variable[1] = "0";
        gd1.Variable[1] = "0";
        gd6.Variable[1] = "0";
        gd7.Variable[1] = "0";
        gd8.Variable[1] = "0";
        }
    if(pic.Variable[10] == "6")
       {gd6.Variable[1] = "1";
        gd2.Variable[1] = "0";
        gd3.Variable[1] = "0";
        gd4.Variable[1] = "0";
        gd5.Variable[1] = "0";
        gd1.Variable[1] = "0";
        gd7.Variable[1] = "0";
        gd8.Variable[1] = "0";
       }
    if(pic.Variable[10] == "7")
       {gd7.Variable[1] = "1";
        gd2.Variable[1] = "0";
        gd3.Variable[1] = "0";
        gd4.Variable[1] = "0";
        gd5.Variable[1] = "0";
        gd6.Variable[1] = "0";
        gd1.Variable[1] = "0";
        gd8.Variable[1] = "0";
       }
    if(pic.Variable[10] == "8")
       {gd8.Variable[1] = "1";
        gd2.Variable[1] = "0";
        gd3.Variable[1] = "0";
        gd4.Variable[1] = "0";
        gd5.Variable[1] = "0";
        gd6.Variable[1] = "0";
        gd7.Variable[1] = "0";
        gd1.Variable[1] = "0";
        }
*/
           DrawArea p = (DrawArea)(Area.Parent);
           if(p.Variable[1] == "1")
              {
                    R_tagname.ForegroundColor = Color.Blue;
                    R_tagname.EdgeColor = Color.White;
              }
           else
              {
                    R_tagname.ForegroundColor = Color.Black;
                    R_tagname.EdgeColor = Color.Black;

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
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void Rect7_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect7 = (DrawRectangle)dynArgs.sender; 
   
    Rect7.Visible = true;
    Rect7.ForegroundColor = Color.Black;
    Rect7.EdgeColor = Color.Black;
           DrawArea p = (DrawArea)(Area.Parent);
           p.Variable[1] = "0";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void Rect7_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect7 = (DrawRectangle)dynArgs.sender; 
   
           DrawArea pic = (DrawArea)(Area.Parent.Parent);

           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

    DrawText SP = (DrawText)Area.GetDrawObj("SP");
    SP.Variable[0] = "1";
    DrawText PV = (DrawText)Area.GetDrawObj("PV");
    PV.Variable[0] = "0";
    DrawText OP = (DrawText)Area.GetDrawObj("OP");
    OP.Variable[0] = "0";

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
				CommonFunction.MoveControl(Area,TB,(int)(Rect7.VerticalPosition - 40),(int)(Rect7.HorizontalPosition));		
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
public void Rect7_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect7 = (DrawRectangle)dynArgs.sender; 

    DrawText SP = (DrawText)Area.GetDrawObj("SP");
    DrawArea p = (DrawArea)(Area.Parent);

			if(SP.Variable[0] == "1" && p.Variable[1] == "1")
			{
		 		Rect7.ForegroundColor = Color.Blue;
                                Rect7.EdgeColor = Color.White;                                   
			}
                        else
			{
		 		Rect7.ForegroundColor = Color.Black;
                                Rect7.EdgeColor = Color.Black;                                   
			}
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void Rect8_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect8 = (DrawRectangle)dynArgs.sender; 
   
    Rect8.Visible = true;
    Rect8.ForegroundColor = Color.Black;
    Rect8.EdgeColor = Color.Black;
           DrawArea p = (DrawArea)(Area.Parent);
           p.Variable[1] = "0";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void Rect8_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect8 = (DrawRectangle)dynArgs.sender; 
   
           DrawArea pic = (DrawArea)(Area.Parent.Parent);

           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

    DrawText SP = (DrawText)Area.GetDrawObj("SP");
    SP.Variable[0] = "0";
    DrawText PV = (DrawText)Area.GetDrawObj("PV");
    PV.Variable[0] = "1";
    DrawText OP = (DrawText)Area.GetDrawObj("OP");
    OP.Variable[0] = "0";

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
				CommonFunction.MoveControl(Area,TB,(int)(Rect8.VerticalPosition)-40,(int)(Rect8.HorizontalPosition));
			
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
public void Rect8_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect8 = (DrawRectangle)dynArgs.sender; 

    DrawText PV = (DrawText)Area.GetDrawObj("PV");
    DrawArea p = (DrawArea)(Area.Parent);

			if(PV.Variable[0] == "1" && p.Variable[1] == "1")
			{
		 		Rect8.ForegroundColor = Color.Blue;
                                Rect8.EdgeColor = Color.White;                                   
			}
                        else
			{
		 		Rect8.ForegroundColor = Color.Black;
                                Rect8.EdgeColor = Color.Black;                                   
			}

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void Rect9_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect9 = (DrawRectangle)dynArgs.sender; 
   
    Rect9.Visible = true;
    Rect9.ForegroundColor = Color.Black;
    Rect9.EdgeColor = Color.Black;
           DrawArea p = (DrawArea)(Area.Parent);
           p.Variable[1] = "0";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void Rect9_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect9 = (DrawRectangle)dynArgs.sender; 
   
           DrawArea pic = (DrawArea)(Area.Parent.Parent);

           if(Area.Variable[0] == pic.Variable[0])
              {pic.Variable[10] = "1";}
           if(Area.Variable[0] == pic.Variable[1])
              {pic.Variable[10] = "2";}
           if(Area.Variable[0] == pic.Variable[2])
              {pic.Variable[10] = "3";}
           if(Area.Variable[0] == pic.Variable[3])
              {pic.Variable[10] = "4";}
           if(Area.Variable[0] == pic.Variable[4])
              {pic.Variable[10] = "5";}
           if(Area.Variable[0] == pic.Variable[5])
              {pic.Variable[10] = "6";}
           if(Area.Variable[0] == pic.Variable[6])
              {pic.Variable[10] = "7";}
           if(Area.Variable[0] == pic.Variable[7])
              {pic.Variable[10] = "8";}

           DrawText Name = (DrawText)pic.GetDrawObj("Tag");
           Name.Visible = true;
           Name.Caption = Area.Variable[0];

           DrawText PVSOURCE = (DrawText)pic.GetDrawObj("PVSOURCE");
           PVSOURCE.Visible = true;
           PVSOURCE.Variable[0] = Area.Variable[0];

           DrawText Text = (DrawText)pic.GetDrawObj("Text");
           Text.Visible = true;

           DrawRectangle Rect = (DrawRectangle)pic.GetDrawObj("Rect");
           Rect.Visible = true;
           Rect.Variable[0] = Area.Variable[0];

    DrawText SP = (DrawText)Area.GetDrawObj("SP");
    SP.Variable[0] = "0";
    DrawText PV = (DrawText)Area.GetDrawObj("PV");
    PV.Variable[0] = "0";
    DrawText OP = (DrawText)Area.GetDrawObj("OP");
    OP.Variable[0] = "1";

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
			        CommonFunction.MoveControl(Area,TB,(int)(Rect9.VerticalPosition)-40,(int)(Rect9.HorizontalPosition));
				
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
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void Rect9_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect9 = (DrawRectangle)dynArgs.sender; 

    DrawText OP = (DrawText)Area.GetDrawObj("OP");
    DrawArea p = (DrawArea)(Area.Parent);

			if(OP.Variable[0] == "1" && p.Variable[1] == "1")
			{
		 		Rect9.ForegroundColor = Color.Blue;
                                Rect9.EdgeColor = Color.White;                                   
			}
                        else
			{
		 		Rect9.ForegroundColor = Color.Black;
                                Rect9.EdgeColor = Color.Black;                                   
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
                        DrawText P = (DrawText)Area.GetDrawObj("PV");
                        P.Variable[0] = "0";
                        DrawText OP = (DrawText)Area.GetDrawObj("OP");
                        OP.Variable[0] = "0";
                        DrawText SP = (DrawText)Area.GetDrawObj("SP");
                        SP.Variable[0] = "0";
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
				          CommonFunction._ProjectRelated.Var[1] = "LMT";
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
				          CommonFunction._ProjectRelated.Var[1] = "LMT";
                                       }
                                    }
	                	  else 
                                    {
                                        CommonFunction._ProjectRelated.Var[1] = "MODE ERROR";

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
                                        CommonFunction._ProjectRelated.Var[1] = "LMT";
                                    }
                                  }
	                	  else 
                                    {
                                        CommonFunction._ProjectRelated.Var[1] = "MODE ERROR";

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
CommonFunction._ProjectRelated.Var[1] = "";
    DrawText P1 = (DrawText)Area.GetDrawObj("PV");
    P1.Variable[0] = "0";
    DrawText OP1 = (DrawText)Area.GetDrawObj("OP");
    OP1.Variable[0] = "0";
    DrawText SP1 = (DrawText)Area.GetDrawObj("SP");
    SP1.Variable[0] = "0";
    return; 
}


}
