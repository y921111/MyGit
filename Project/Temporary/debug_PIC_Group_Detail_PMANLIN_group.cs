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
public class PIC_Group_Detail_PMANLIN_group:IDynCodeAttachDetach
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
_EventHandler= (EventHandler)PIC_Group_Detail_PMANLIN_group_OnDynInitialize;
CodeDomCommon.AttachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PIC_Group_Detail_PMANLIN_group_OnDynClick;
CodeDomCommon.AttachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "Disposed";
_EventHandler= (EventHandler)PIC_Group_Detail_PMANLIN_group_Disposed;
CodeDomCommon.AttachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)PIC_Group_Detail_PMANLIN_group_KeyUp;
CodeDomCommon.AttachAreaEventHandler(area,strEventName,_KeyEventHandler);
strObjectName = "Rect8";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Rect8_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Line16";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Line16_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "LinePVTV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)LinePVTV_OnDynAnimation;
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
strObjectName = "PVTV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVTV_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVTV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PVTV_OnDynInitialize;
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
strObjectName = "Rect10";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Rect10_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect10";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect10_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect10";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Rect10_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect11";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Rect11_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect11";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect11_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect11";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Rect11_OnDynAnimation;
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
_EventHandler= (EventHandler)PIC_Group_Detail_PMANLIN_group_OnDynInitialize;
CodeDomCommon.DetachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PIC_Group_Detail_PMANLIN_group_OnDynClick;
CodeDomCommon.DetachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "Disposed";
_EventHandler= (EventHandler)PIC_Group_Detail_PMANLIN_group_Disposed;
CodeDomCommon.DetachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)PIC_Group_Detail_PMANLIN_group_KeyUp;
CodeDomCommon.DetachAreaEventHandler(area,strEventName,_KeyEventHandler);
strObjectName = "Rect8";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Rect8_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Line16";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Line16_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "LinePVTV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)LinePVTV_OnDynAnimation;
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
strObjectName = "PVTV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVTV_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVTV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PVTV_OnDynInitialize;
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
strObjectName = "Rect10";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Rect10_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect10";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect10_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect10";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Rect10_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect11";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Rect11_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect11";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect11_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect11";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Rect11_OnDynAnimation;
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
public void PIC_Group_Detail_PMANLIN_group_OnDynInitialize(Object sender, EventArgs e)
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
public void PIC_Group_Detail_PMANLIN_group_OnDynClick(Object sender, EventArgs e)
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
public void PIC_Group_Detail_PMANLIN_group_Disposed(Object sender, EventArgs e)
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
public void PIC_Group_Detail_PMANLIN_group_KeyUp(Object sender, KeyEventArgs e)
{
   TextBox TB = (TextBox)sender; 

   DrawArea Area = CommonFunction.GetThisDrawArea(TB);

     double dbValue = 0;
     int nValue = 0;
     bool bValue = false;
     int nDataType = 0;

        double PVEXEH = 0;
        double PVEXEL = 0;
        double PVEUHI = 0;
        double PVEULO = 0;

	string tagName = Area.Variable[0] + "/PVEXEH";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEXEH = dbValue;             
	}

	tagName = Area.Variable[0] + "/PVEXEL";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEXEL = dbValue;             
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
                             bool PV = tagName.Contains("PV");
                             bool PVTV = tagName.Contains("PVTV");
                             if(PV == true)
                               {

                                    if(dbPVValue <= PVEUHI && dbPVValue >= PVEULO)
                                       {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                       }
                                    else
                                       {
				          CommonFunction._ProjectRelated.Var[1] = "LMT";
                                       }
                               }


                             if(PVTV == true)
                               {
	                 	  if(dbPVValue <= PVEXEH && dbPVValue >= PVEXEL)

				   {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                   }
	                	  else 
                                    {
                                        CommonFunction._ProjectRelated.Var[1] = "LMT";
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
    DrawText V1 = (DrawText)Area.GetDrawObj("PVTV");
    V1.Variable[0] = "0";

    return; 
}



//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void Rect8_OnDynAnimation(Object sender, EventArgs e)	//PVBar
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

             if(PVEUHI != PVEULO)
                {
                    double PVScale = PVValue/(PVEUHI - PVEULO);
                    PVBar.Height = (334.00 - 58.00) * PVScale;
                    PVBar.VerticalPosition = 334.00 - PVBar.Height;
                }     
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
public void Line16_OnDynAnimation(Object sender, EventArgs e)
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
public void LinePVTV_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawLine LinePVTV = (DrawLine)dynArgs.sender; 


	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	double PVValue = 0;
        double PVEXEH = 0;
        double PVEXEL = 0;

	string tagName = Area.Variable[0] + "/PVEXEH";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEXEH = dbValue;
             
	}

	tagName = Area.Variable[0] + "/PVEXEL";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEXEL = dbValue;
             
	}
	
	tagName = Area.Variable[0] + "/PVTV";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
             PVValue = dbValue;
             if(PVEXEH != PVEXEL)
                {
                      double PVScale = PVValue/(PVEXEH - PVEXEL);
                      LinePVTV.VerticalPosition = 334 - (334 - 58) * PVScale;
                }   
	}
	else
             LinePVTV.VerticalPosition = 334;
   
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
public void PVTV_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVTV = (DrawText)dynArgs.sender;
 
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
	
	tagName = Area.Variable[0] + "/PVTV";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		PVTV.Caption = dbValue.ToString(strDigit);
	}
	else
		PVTV.Caption = "##.#";

          if(PVTV.Variable[0] == "1")

            {
                PVTV.ForegroundColor = Color.White;
            }

          else

            {
                PVTV.ForegroundColor = Color.Cyan;
            }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void PVTV_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVTV = (DrawText)dynArgs.sender; 

    PVTV.ForegroundColor = Color.Cyan; 
    PVTV.Variable[0] = "0";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void Rect9_OnDynInitialize(Object sender, EventArgs e)
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
public void Rect9_OnDynClick(Object sender, EventArgs e)
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
public void Rect9_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle R_tagname = (DrawRectangle)dynArgs.sender; 

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
public void Rect10_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect10 = (DrawRectangle)dynArgs.sender; 
   
    Rect10.Visible = true;
    Rect10.ForegroundColor = Color.Black;
    Rect10.EdgeColor = Color.Black;
           DrawArea p = (DrawArea)(Area.Parent);
           p.Variable[1] = "0";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void Rect10_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect10 = (DrawRectangle)dynArgs.sender; 

    DrawText PVTV = (DrawText)Area.GetDrawObj("PVTV");
    PVTV.Variable[0] = "1";
    DrawText PV = (DrawText)Area.GetDrawObj("PV");
    PV.Variable[0] = "0";

    if(PVTV.Visible == true)

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
				CommonFunction.MoveControl(Area,TB,(int)(Rect10.VerticalPosition - 40),(int)(Rect10.HorizontalPosition));		
				obj = CommonFunction.GetLabelOfControl(TB);
				if(obj != null)
				{
					ControlLabel lab = (ControlLabel)obj;
					//给TB传递参数：
					lab.Variable[0] = Area.Variable[0] + "/PVTV";
                                      
				}
			}
		}
	}

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
public void Rect10_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect10 = (DrawRectangle)dynArgs.sender; 

    DrawText PVTV = (DrawText)Area.GetDrawObj("PVTV");
    DrawArea p = (DrawArea)(Area.Parent);

			if(PVTV.Variable[0] == "1" && p.Variable[1] == "1")
			{
		 		Rect10.ForegroundColor = Color.Blue;
                                Rect10.EdgeColor = Color.White;                                   
			}
                        else
			{
		 		Rect10.ForegroundColor = Color.Black;
                                Rect10.EdgeColor = Color.Black; 
                                PVTV.Variable[0] = "0";                                  
			}


    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void Rect11_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect11 = (DrawRectangle)dynArgs.sender; 
   
    Rect11.Visible = true;
    Rect11.ForegroundColor = Color.Black;
    Rect11.EdgeColor = Color.Black;
           DrawArea p = (DrawArea)(Area.Parent);
           p.Variable[1] = "0";
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void Rect11_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect11 = (DrawRectangle)dynArgs.sender; 
   
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

    DrawText PV = (DrawText)Area.GetDrawObj("PV");
    PV.Variable[0] = "1";
    DrawText PVTV = (DrawText)Area.GetDrawObj("PVTV");
    PVTV.Variable[0] = "0";
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
				CommonFunction.MoveControl(Area,TB,(int)(Rect11.VerticalPosition)-40,(int)(Rect11.HorizontalPosition));
			
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
public void Rect11_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect11 = (DrawRectangle)dynArgs.sender; 

    DrawText PV = (DrawText)Area.GetDrawObj("PV");
    DrawArea p = (DrawArea)(Area.Parent);

			if(PV.Variable[0] == "1" && p.Variable[1] == "1")
			{
		 		Rect11.ForegroundColor = Color.Blue;
                                Rect11.EdgeColor = Color.White;                                   
			}
                        else
			{
		 		Rect11.ForegroundColor = Color.Black;
                                Rect11.EdgeColor = Color.Black;
                                PV.Variable[0] = "0";                                   
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

        double PVEXEH = 0;
        double PVEXEL = 0;
        double PVEUHI = 0;
        double PVEULO = 0;

	string tagName = Area.Variable[0] + "/PVEXEH";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEXEH = dbValue;             
	}

	tagName = Area.Variable[0] + "/PVEXEL";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
	     PVEXEL = dbValue;             
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

	switch ( e.KeyData )
	{
	case Keys.Enter:

		if(TB.Text == "" || TB.Text == null)

		{
			TB.Visible = false;
			TB.Enabled = false;
                        DrawText P = (DrawText)Area.GetDrawObj("PV");
                        P.Variable[0] = "0";
                        DrawText V = (DrawText)Area.GetDrawObj("PVTV");
                        V.Variable[0] = "0";
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
                             bool PV = tagName.Contains("PV");
                             bool PVTV = tagName.Contains("PVTV");
                             if(PV == true)
                               {

                                    if(dbPVValue <= PVEUHI && dbPVValue >= PVEULO)
                                       {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                       }
                                    else
                                       {
				          CommonFunction._ProjectRelated.Var[1] = "LMT";
                                       }
                               }


                             if(PVTV == true)
                               {
	                 	  if(dbPVValue <= PVEXEH && dbPVValue >= PVEXEL)

				   {
				          CommonFunction.DSI_SetValue(tag, dbPVValue);
                                   }
	                	  else 
                                    {
                                        CommonFunction._ProjectRelated.Var[1] = "LMT";
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
    DrawText V1 = (DrawText)Area.GetDrawObj("PVTV");
    V1.Variable[0] = "0";
    return; 
}


}
