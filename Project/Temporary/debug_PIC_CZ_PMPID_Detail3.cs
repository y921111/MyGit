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
public class PIC_CZ_PMPID_Detail3:IDynCodeAttachDetach
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
_EventHandler= (EventHandler)PIC_CZ_PMPID_Detail3_OnDynInitialize;
CodeDomCommon.AttachAreaEventHandler(area,strEventName,_EventHandler);
strObjectName = "CTL";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CTL_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CTL";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CTL_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Tag";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Tag_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Tag";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Tag_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TagComment";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)TagComment_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail_PAGE";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Detail_PAGE_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail_PAGE";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Detail_PAGE_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail_PAGE.Rect4_GROUP";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Detail_PAGE_Rect4_GROUP_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail_PAGE.Rect3_CTLCONCT";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Detail_PAGE_Rect3_CTLCONCT_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail_PAGE.Rect2_CTLALGO";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Detail_PAGE_Rect2_CTLALGO_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail_PAGE.Rect1_FIRST";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Detail_PAGE_Rect1_FIRST_OnDynClick;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_Top.Caption1";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)TDC3000_Top_Caption1_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_Top.Caption1";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TDC3000_Top_Caption1_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_Top.Caption2";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)TDC3000_Top_Caption2_OnDynInitialize;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_Top.Caption2";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TDC3000_Top_Caption2_OnDynAnimation;
CodeDomCommon.AttachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_Top.Text2";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TDC3000_Top_Text2_OnDynAnimation;
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
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)PIC_CZ_PMPID_Detail3_OnDynInitialize;
CodeDomCommon.DetachAreaEventHandler(area,strEventName,_EventHandler);
strObjectName = "CTL";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)CTL_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "CTL";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)CTL_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Tag";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Tag_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Tag";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Tag_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TagComment";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)TagComment_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail_PAGE";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)Detail_PAGE_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail_PAGE";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)Detail_PAGE_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail_PAGE.Rect4_GROUP";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Detail_PAGE_Rect4_GROUP_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail_PAGE.Rect3_CTLCONCT";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Detail_PAGE_Rect3_CTLCONCT_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail_PAGE.Rect2_CTLALGO";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Detail_PAGE_Rect2_CTLALGO_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "Detail_PAGE.Rect1_FIRST";
strEventName = "OnDynClick";
_EventHandler= (EventHandler)Detail_PAGE_Rect1_FIRST_OnDynClick;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_Top.Caption1";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)TDC3000_Top_Caption1_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_Top.Caption1";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TDC3000_Top_Caption1_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_Top.Caption2";
strEventName = "OnDynInitialize";
_EventHandler= (EventHandler)TDC3000_Top_Caption2_OnDynInitialize;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_Top.Caption2";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TDC3000_Top_Caption2_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);
strObjectName = "TDC3000_Top.Text2";
strEventName = "OnDynAnimation";
_EventHandler= (EventHandler)TDC3000_Top_Text2_OnDynAnimation;
CodeDomCommon.DetachEventHandler(area,strObjectName,strEventName,_EventHandler);

    return;
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void PIC_CZ_PMPID_Detail3_OnDynInitialize(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 
   
   DrawArea G = (DrawArea)(Area.GetDrawObj("Detail_PAGE"));
   G.Visible = false;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void CTL_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText CTL = (DrawText)dynArgs.sender; 
  
    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_PAGE");
    L.Visible = true;
    L.Variable[0] = Area.Variable[0];
    L.Variable[1] = "3";//设置标志位变色

    CTL.ForegroundColor = Color.White;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void CTL_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText CTL = (DrawText)dynArgs.sender; 

    DrawArea L = (DrawArea)Area.GetDrawObj("Detail_PAGE");
    if(L.Visible == false)
       {
             CTL.ForegroundColor = Color.Lime;
       }

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void Tag_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText Tag = (DrawText)dynArgs.sender; 
   
        string tagName = Area.Variable[0].ToUpper();

	if(tagName != "")
		Tag.Caption = tagName;
	else
		Tag.Caption = "******";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void Tag_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText Tag = (DrawText)dynArgs.sender; 
   
        string tagName = Area.Variable[0].ToUpper();

	if(tagName != "")

		Tag.Caption = tagName;
	else
		Tag.Caption = "******";

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void TagComment_OnDynInitialize(Object sender, EventArgs e)
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
//Event Handler:OnDynInitialize 
public void Detail_PAGE_OnDynInitialize(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 
   
    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void Detail_PAGE_OnDynAnimation(Object sender, EventArgs e)
{
   DrawArea Area = (DrawArea)sender; 
   DynEventArgs dynArgs = (DynEventArgs)e; 
   DrawArea drawArea = (DrawArea)dynArgs.sender; 
   
	DrawText FIRST = (DrawText)Area.GetDrawObj("FIRST");
	DrawText CTLALGO = (DrawText)Area.GetDrawObj("CTLALGO");
	DrawText CTLCONCT = (DrawText)Area.GetDrawObj("CTLCONCT");

	FIRST.ForegroundColor = Color.Lime;
	CTLALGO.ForegroundColor = Color.Lime;
	CTLCONCT.ForegroundColor = Color.Lime;


        if(Area.Variable[1] == "1")
	    {
               FIRST.ForegroundColor = Color.Cyan;
            }
        if(Area.Variable[1] == "2")
	    {
               CTLALGO.ForegroundColor = Color.Cyan;
            }
        if(Area.Variable[1] == "3")
	    {
               CTLCONCT.ForegroundColor = Color.Cyan;
            }


    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void Detail_PAGE_Rect4_GROUP_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect4_GROUP = (DrawRectangle)dynArgs.sender; 

	int nLeft = 0;
	int nTop = 0;
	string[] strVariable = new string[1];
	strVariable[0] = Area.Variable[0];
	CommonFunction.OpenPicture("GROUP.grf", nTop, nLeft, strVariable);
    Area.Visible = false;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void Detail_PAGE_Rect3_CTLCONCT_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect3_CTLCONCT = (DrawRectangle)dynArgs.sender; 

	int nLeft = 0;
	int nTop = 0;
	string[] strVariable = new string[1];
	strVariable[0] = Area.Variable[0];
	CommonFunction.OpenPicture("CZ_PMPID_Detail3.grf", nTop, nLeft, strVariable);
    Area.Visible = false;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void Detail_PAGE_Rect2_CTLALGO_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect2_CTLALGO = (DrawRectangle)dynArgs.sender; 
   
	int nLeft = 0;
	int nTop = 0;
	string[] strVariable = new string[1];
	strVariable[0] = Area.Variable[0];
	CommonFunction.OpenPicture("CZ_PMPID_Detail2.grf", nTop, nLeft, strVariable);
    Area.Visible = false;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynClick 
public void Detail_PAGE_Rect1_FIRST_OnDynClick(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawRectangle Rect1_FIRST = (DrawRectangle)dynArgs.sender; 
   
	int nLeft = 0;
	int nTop = 0;
	string[] strVariable = new string[1];
	strVariable[0] = Area.Variable[0];
	CommonFunction.OpenPicture("CZ_PMPID_Detail.grf", nTop, nLeft, strVariable);

    Area.Visible = false;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void TDC3000_Top_Caption1_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText Caption1 = (DrawText)dynArgs.sender; 

    Caption1.Visible = false;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void TDC3000_Top_Caption1_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText Caption1 = (DrawText)dynArgs.sender; 

	if(Area.BReference)
	{
          Caption1.Visible = true;
          Caption1.Caption = Area.Variable[3];
	}

    return; 
}

//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynInitialize 
public void TDC3000_Top_Caption2_OnDynInitialize(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText Caption2 = (DrawText)dynArgs.sender; 
   
    Caption2.Visible = false;

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void TDC3000_Top_Caption2_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText Caption2 = (DrawText)dynArgs.sender; 

	if(Area.BReference)
	{
          Caption2.Visible = true;
          Caption2.Caption = Area.Variable[4];
	}

    return; 
}
//Do not remove or update this comment
//Event Delegate:EventHandler 
//Event Handler:OnDynAnimation 
public void TDC3000_Top_Text2_OnDynAnimation(Object sender, EventArgs e)
{
    DrawArea Area = (DrawArea)sender; 
    DynEventArgs dynArgs = (DynEventArgs)e; 
    DrawText Text2 = (DrawText)dynArgs.sender; 
   
    DateTime now = DateTime.Now;
    Text2.Caption = now.Day.ToString() + "  " + now.Month.ToString() + "  " + "20" + now.ToString("yy") +  "  " + now.ToString("HH") + ":" +     now.ToString("mm")+ ":" +  now.ToString("ss");

    return; 
}

}
