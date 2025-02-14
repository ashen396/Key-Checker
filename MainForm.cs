/*
 * Created by SharpDevelop.
 * User: Ashen Renon
 * Date: 9/22/2020
 * Time: 10:50 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace KeyCheck
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
		
		void MainFormKeyPress(object sender, KeyPressEventArgs e)
		{
			char x = e.KeyChar;
			char y = char.ToUpper(x);
			switch (y) {
				case 'A':
					lbl_A.Visible = true;
					break;
				case 'S':
					lbl_S.Visible = true;
					break;
				case 'D':
					lbl_D.Visible = true;
					break;
				case 'F':
					lbl_F.Visible = true;
					break;
				case 'G':
					lbl_G.Visible = true;
					break;
				case 'H':
					lbl_H.Visible = true;
					break;
				case 'J':
					lbl_J.Visible = true;
					break;
				case 'K':
					lbl_K.Visible = true;
					break;
				case 'L':
					lbl_L.Visible = true;
					break;
				case 'Q':
					lbl_Q.Visible = true;
					break;
				case 'W':
					lbl_W.Visible = true;
					break;
				case 'E':
					lbl_E.Visible = true;
					break;
				case 'R':
					lbl_R.Visible = true;
					break;
				case 'T':
					lbl_T.Visible = true;
					break;
				case 'Y':
					lbl_Y.Visible = true;
					break;
				case 'U':
					lbl_U.Visible = true;
					break;
				case 'I':
					lbl_I.Visible = true;
					break;
				case 'O':
					lbl_O.Visible = true;
					break;
				case 'P':
					lbl_P.Visible = true;
					break;
				case 'Z':
					lbl_Z.Visible = true;
					break;
				case 'X':
					lbl_X.Visible = true;
					break;
				case 'C':
					lbl_C.Visible = true;
					break;
				case 'V':
					lbl_V.Visible = true;
					break;
				case 'B':
					lbl_B.Visible = true;
					break;
				case 'N':
					lbl_N.Visible = true;
					break;
				case 'M':
					lbl_M.Visible = true;
					break;
				default:
					break;
			}
		}
	}
}
