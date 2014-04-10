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
public class PIC_CZ_PMANLIN:IDynCodeAttachDetach
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
_EventHandler= (EventHandler)PIC_CZ_PMANLIN_OnDynInitialize;
CodeDomCommon.AttachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PIC_CZ_PMANLIN_OnDynAnimation;
CodeDomCommon.AttachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "Disposed";
_EventHandler= (EventHandler)PIC_CZ_PMANLIN_Disposed;
CodeDomCommon.AttachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PIC_CZ_PMANLIN_OnDynClick;
CodeDomCommon.AttachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)PIC_CZ_PMANLIN_KeyUp;
CodeDomCommon.AttachAreaEventHandler(area,strEventName,_KeyEventHandler);
strObjectName = "Rect_Tag";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect_Tag_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect_PVEUHI";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect_PVEUHI_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect_PVEULO";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect_PVEULO_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect_PV";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect_PV_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Text_PVEUHI";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Text_PVEUHI_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Text_PVEULO";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Text_PVEULO_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Text_PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Text_PV_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PA_Rectangle";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PA_Rectangle_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVEUHI";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVEUHI_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVEUHI";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PVEUHI_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVEULO";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVEULO_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVEULO";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PVEULO_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PV_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PV_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TagComment";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TagComment_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVUnit";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVUnit_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TagName_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Close";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Close_OnDynClick;
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
_EventHandler= (EventHandler)PIC_CZ_PMANLIN_OnDynInitialize;
CodeDomCommon.DetachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PIC_CZ_PMANLIN_OnDynAnimation;
CodeDomCommon.DetachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "Disposed";
_EventHandler= (EventHandler)PIC_CZ_PMANLIN_Disposed;
CodeDomCommon.DetachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PIC_CZ_PMANLIN_OnDynClick;
CodeDomCommon.DetachAreaEventHandler(area,strEventName,_EventHandler);
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)PIC_CZ_PMANLIN_KeyUp;
CodeDomCommon.DetachAreaEventHandler(area,strEventName,_KeyEventHandler);
strObjectName = "Rect_Tag";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect_Tag_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect_PVEUHI";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect_PVEUHI_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect_PVEULO";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect_PVEULO_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Rect_PV";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Rect_PV_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Text_PVEUHI";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Text_PVEUHI_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Text_PVEULO";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Text_PVEULO_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Text_PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Text_PV_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PA_Rectangle";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)PA_Rectangle_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVEUHI";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVEUHI_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVEUHI";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PVEUHI_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVEULO";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVEULO_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVEULO";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PVEULO_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PV";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PV_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PV";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PV_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TagComment";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TagComment_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "PVUnit";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)PVUnit_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TagName";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TagName_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Close";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Close_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TB";
strEventName = "KeyUp";
_KeyEventHandler= (KeyEventHandler)TB_KeyUp;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_KeyEventHandler);

    return;
}

// =======================================================================
//
// 文件名：CZ_AI.grf（面板）
// 【调用时传入参数】
//		Area.Variable[0] - Tagname
//		Area.Variable[1] - 选中的标志位
//
// 【更新时间】 
//		2013.03.25
// =======================================================================

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void PIC_CZ_PMANLIN_OnDynInitialize(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender;

	Area.Variable[0] = Area.Variable[0].ToUpper();

////////////////////////////////////////////////////////////////////////////////传值
////////////////////////////////////////////////////////////////////////////////传值
	Picture pic = CommonFunction.GetThisPicture(Area);
	if(pic != null)
	{

		if(Area.BReference)//图素
		{
                      Area.Enabled = true;
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

			//将顶级DrawArea的Variable[0]变量传递到图素级DrawArea：
			DrawArea MainArea = pic.GetDrawArea();
			Area.Variable[0] = MainArea.Variable[0];
//MessageBox.Show(Area.Variable[0].ToString());

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


////////////////////////////////////////////////////////////////////////////////处理变色
////////////////////////////////////////////////////////////////////////////////处理变色

	DrawText PTXST = (DrawText)Area.GetDrawObj("PTXST");
	DrawText ACTIVE = (DrawText)Area.GetDrawObj("ACTIVE");
        DrawRectangle PA_Rectangle = (DrawRectangle)Area.GetDrawObj("PA_Rectangle");

	DrawText PV = (DrawText)Area.GetDrawObj("PV");
	DrawText PVEULO = (DrawText)Area.GetDrawObj("PVEULO");
	DrawText PVEUHI = (DrawText)Area.GetDrawObj("PVEUHI");
	DrawText Text_PV = (DrawText)Area.GetDrawObj("Text_PV");
	DrawText Text_PVEULO = (DrawText)Area.GetDrawObj("Text_PVEULO");
	DrawText Text_PVEUHI = (DrawText)Area.GetDrawObj("Text_PVEUHI");

        PTXST.ForegroundColor = Color.Lime;
        ACTIVE.ForegroundColor = Color.Lime;
        PA_Rectangle.EdgeColor = Color.Lime;

	PV.ForegroundColor = Color.Lime;
	PVEULO.ForegroundColor = Color.Lime;
	PVEUHI.ForegroundColor = Color.Lime;
	Text_PV.ForegroundColor = Color.Lime;
	Text_PVEULO.ForegroundColor = Color.Lime;
	Text_PVEUHI.ForegroundColor = Color.Lime;

/*
        DrawArea picT = (DrawArea)(Area.Parent.Parent);
        DrawArea Top = (DrawArea)picT.GetDrawObj("TDC3000_Top");
        if(Top != null)
*/  
           CommonFunction._ProjectRelated.Var[0] = "";

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void PIC_CZ_PMANLIN_OnDynAnimation(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 
   
	DrawText PTXST = (DrawText)Area.GetDrawObj("PTXST");
	DrawText ACTIVE = (DrawText)Area.GetDrawObj("ACTIVE");
        DrawRectangle PA_Rectangle = (DrawRectangle)Area.GetDrawObj("PA_Rectangle");

	DrawText PV = (DrawText)Area.GetDrawObj("PV");
	DrawText PVEULO = (DrawText)Area.GetDrawObj("PVEULO");
	DrawText PVEUHI = (DrawText)Area.GetDrawObj("PVEUHI");
	DrawText Text_PV = (DrawText)Area.GetDrawObj("Text_PV");
	DrawText Text_PVEULO = (DrawText)Area.GetDrawObj("Text_PVEULO");
	DrawText Text_PVEUHI = (DrawText)Area.GetDrawObj("Text_PVEUHI");

        PTXST.ForegroundColor = Color.Lime;
        ACTIVE.ForegroundColor = Color.Lime;
        PA_Rectangle.EdgeColor = Color.Lime;

	PV.ForegroundColor = Color.Lime;
	PVEULO.ForegroundColor = Color.Lime;
	PVEUHI.ForegroundColor = Color.Lime;
	Text_PV.ForegroundColor = Color.Lime;
	Text_PVEULO.ForegroundColor = Color.Lime;
	Text_PVEUHI.ForegroundColor = Color.Lime;
/*
        DrawArea picT = (DrawArea)(Area.Parent.Parent);
        DrawArea Top = (DrawArea)picT.GetDrawObj("TDC3000_Top");
*/
     if(Area.Variable[1] == "4")
     {
	 PTXST.ForegroundColor = Color.White;
         ACTIVE.ForegroundColor = Color.White;
         PA_Rectangle.EdgeColor = Color.White; 
//         if(Top != null) 
//           {
               CommonFunction._ProjectRelated.Var[0] = "PENTER"; 
               CommonFunction._ProjectRelated.Var[1] = "";  
//           }
     }
 
     if(Area.Variable[1] == "5")
     {  
//           if(Top != null)
//             {
                 CommonFunction._ProjectRelated.Var[1] = "NOT EMULATION"; 
                 CommonFunction._ProjectRelated.Var[0] = "";  
//              }
     }

     if(Area.Variable[1] == "6")
     {
	 PV.ForegroundColor = Color.White;
         Text_PV.ForegroundColor = Color.White;  
     }

     if(Area.Variable[1] == "7")
     {
	 PVEULO.ForegroundColor = Color.White;
         Text_PVEULO.ForegroundColor = Color.White; 
     }

     if(Area.Variable[1] == "8")
     {
	 PVEUHI.ForegroundColor = Color.White;
         Text_PVEUHI.ForegroundColor = Color.White;
     }

   return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:Disposed 
public void PIC_CZ_PMANLIN_Disposed(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 

   TextBox TB = (TextBox)Area.GetDrawObj("TB");
   TB.Enabled = false;
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void PIC_CZ_PMANLIN_OnDynClick(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 
   
    DrawArea A = (DrawArea)(Area.Parent.Parent);
             A.RunAnimation();

   object obj=Area.GetControlObj("TB");
   if(obj!=null)
	{
		TextBox TB=(TextBox)obj;
		TB.Visible=false;
	}

    return; 
}
//Do not remove or update this comment
//Event Delegate:KeyEventHandler 
//Event Handler:KeyUp 
public void PIC_CZ_PMANLIN_KeyUp(Object sender, KeyEventArgs e)
{
   DrawArea Area = (DrawArea)sender; 

//        DrawArea picT = (DrawArea)(Area.Parent.Parent);
//        DrawArea Top = (DrawArea)picT.GetDrawObj("TDC3000_Top");

		    switch(e.KeyData)
                      {    

                         case Keys.Enter:

                               if(Area.Variable[1] == "4")
                                {
	                             DrawText PTXST = (DrawText)Area.GetDrawObj("PTXST");
	                             DrawText ACTIVE = (DrawText)Area.GetDrawObj("ACTIVE");
                                     DrawRectangle PA_Rectangle = (DrawRectangle)Area.GetDrawObj("PA_Rectangle");

	                             PTXST.ForegroundColor = Color.Lime;
                                     ACTIVE.ForegroundColor = Color.Lime;
                                     PA_Rectangle.EdgeColor = Color.Lime;     
                                }

                              ////////////////Top的显示
                                 //    if(Top != null)
                                         CommonFunction._ProjectRelated.Var[0] = "";

                             ////////////////Top的显示

                          Area.Variable[1] = "0";

	                 break;
                      } 
         
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void Rect_Tag_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect_Tag = (DrawRectangle)dynArgs.sender; 

	int nLeft = 0;
	int nTop = 0;
	string[] strVariable = new string[1];
	strVariable[0] = Area.Variable[0];
        CommonFunction.OpenDetail(Area.Variable[0]); 

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void Rect_PVEUHI_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect_PVEUHI = (DrawRectangle)dynArgs.sender; 
   
    DrawText PVEUHI = (DrawText)Area.GetDrawObj("PVEUHI");

    Area.Variable[1] = "8"; 

    if(Rect_PVEUHI.Visible == true)

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
			        CommonFunction.MoveControl(Area,TB,(int)(PVEUHI.VerticalPosition)+30,(int)(PVEUHI.HorizontalPosition)+40);
				
				obj = CommonFunction.GetLabelOfControl(TB);
				if(obj != null)
				{
					ControlLabel lab = (ControlLabel)obj;
					//给TB传递参数：
					lab.Variable[0] = Area.Variable[0] + "/PVEUHI";
				}
			}
		}
	}

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void Rect_PVEULO_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect_PVEULO = (DrawRectangle)dynArgs.sender; 
   
    DrawText PVEULO = (DrawText)Area.GetDrawObj("PVEULO");

    Area.Variable[1] = "7"; 

    if(Rect_PVEULO.Visible == true)

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
				CommonFunction.MoveControl(Area,TB,(int)(PVEULO.VerticalPosition + 30),(int)(PVEULO.HorizontalPosition)+40);		
				obj = CommonFunction.GetLabelOfControl(TB);
				if(obj != null)
				{
					ControlLabel lab = (ControlLabel)obj;
					//给TB传递参数：
					lab.Variable[0] = Area.Variable[0] + "/PVEULO";
                                      
				}
			}
		}
	}

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void Rect_PV_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect_PV = (DrawRectangle)dynArgs.sender; 

    DrawText PV = (DrawText)Area.GetDrawObj("PV");

    Area.Variable[1] = "6"; 

    if(Rect_PV.Visible == true)

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
				CommonFunction.MoveControl(Area,TB,(int)(PV.VerticalPosition)+30,(int)(PV.HorizontalPosition)+40);
			
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
//Event Handler:OnDynInitialize 
public void Text_PVEUHI_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText Text_PVEUHI = (DrawText)dynArgs.sender; 
   
    Text_PVEUHI.ForegroundColor = Color.Lime;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void Text_PVEULO_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText Text_PVEULO = (DrawText)dynArgs.sender; 
   
    Text_PVEULO.ForegroundColor = Color.Lime;

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void Text_PV_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText Text_PV = (DrawText)dynArgs.sender; 

       Text_PV.ForegroundColor = Color.Lime;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void PA_Rectangle_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle PA_Rectangle = (DrawRectangle)dynArgs.sender; 

    DrawArea A = (DrawArea)(Area.Parent.Parent);
             A.RunAnimation();

    Area.Variable[1] = "4";  
 
     return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void PVEUHI_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVEUHI = (DrawText)dynArgs.sender; 
   
	double dbValue = 0;
	int nValue = 0;
	bool bValue = false;
	int nDataType = 0;

	int nDigit = 1;

	string strDigit = "f" + nDigit.ToString();
	
	string tagName = Area.Variable[0] + "/PVEUHI";
	bool ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		PVEUHI.Caption = dbValue.ToString(strDigit);
	}
	else
		PVEUHI.Caption = "##.#";

    object obj = Area.GetControlObj("TB");
	
	TextBox TB = (TextBox)obj; 

          if(TB.Visible == false)

            {
                PVEUHI.ForegroundColor = Color.Lime;
                DrawText Text_PVEUHI = (DrawText)Area.GetDrawObj("Text_PVEUHI");
                Text_PVEUHI.ForegroundColor = Color.Lime;
            }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void PVEUHI_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVEUHI = (DrawText)dynArgs.sender; 
 
    PVEUHI.ForegroundColor = Color.Lime; 

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void PVEULO_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVEULO = (DrawText)dynArgs.sender;
 
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
	
	tagName = Area.Variable[0] + "/PVEULO";
	ret = CommonFunction.GetValueWithType(tagName,ref dbValue,ref nValue,ref bValue,ref nDataType);
	if(ret)
	{
		PVEULO.Caption = dbValue.ToString(strDigit);
	}
	else
		PVEULO.Caption = "##.#";

    object obj = Area.GetControlObj("TB");
	
	TextBox TB = (TextBox)obj; 

          if(TB.Visible == false)

            {
                PVEULO.ForegroundColor = Color.Lime;
                DrawText Text_PVEULO = (DrawText)Area.GetDrawObj("Text_PVEULO");
                Text_PVEULO.ForegroundColor = Color.Lime;
            }


    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void PVEULO_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVEULO = (DrawText)dynArgs.sender; 

    PVEULO.ForegroundColor = Color.Lime; 

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
                PV.ForegroundColor = Color.Lime;
                DrawText Text_PV = (DrawText)Area.GetDrawObj("Text_PV");
                Text_PV.ForegroundColor = Color.Lime;
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
   
    PV.ForegroundColor = Color.Lime;

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void TagComment_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText TagComment = (DrawText)dynArgs.sender; 
   
	string strTagName = Area.Variable[0];
	TagComment.Caption = CommonFunction.GetTagComment(strTagName);	

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void PVUnit_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText PVUnit = (DrawText)dynArgs.sender; 
   
    PVUnit.Caption = CommonFunction.GetPVUnit(Area.Variable[0]);

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
//Event Handler:OnDynClick 
public void Close_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle CLR = (DrawRectangle)dynArgs.sender; 
   
    DrawArea A = (DrawArea)(Area.Parent.Parent);
             A.RunAnimation();

    (Area.Parent).Visible = false;

/*        DrawArea picT = (DrawArea)(Area.Parent.Parent);
        DrawArea Top = (DrawArea)picT.GetDrawObj("TDC3000_Top");

    if(Top != null)
        {
*/
              CommonFunction._ProjectRelated.Var[0] = "";
              CommonFunction._ProjectRelated.Var[1] = "";
//         }

    Area.Variable[1] = "0";

    return; 
}
//Do not remove or update this comment
//Event Delegate:KeyEventHandler 
//Event Handler:KeyUp 
public void TB_KeyUp(Object sender, KeyEventArgs e)
{
   TextBox TB = (TextBox)sender; 

   DrawArea Area = CommonFunction.GetThisDrawArea(TB);

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
		             string tagName=lab.Variable[0];

                             //PV值只有在MODE是MAN的时候才可以改变
                             bool PV = tagName.Contains("PV");
                             bool PVEUHI = tagName.Contains("PVEUHI");
                             bool PVEULO = tagName.Contains("PVEULO");
                             if(PV == true)
                               {
				        CommonFunction.DSI_SetValue(tagName, dbPVValue);
                               }

                             if(PVEUHI == true)
                               {
			                CommonFunction.DSI_SetValue(tagName, dbPVValue);
		
	                        }

                             if(PVEULO == true)
                               {
			                CommonFunction.DSI_SetValue(tagName, dbPVValue);
                               }
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


}
