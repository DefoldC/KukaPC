/******************************************************************************
;// This material is the exclusive property of KUKA Roboter GmbH.
;// Except as expressly permitted by separate agreement, this material may only
;// be used by members of the development department of KUKA Roboter GmbH for
;// internal development purposes of KUKA Roboter GmbH.
;//
;// Copyright (C) 2016
;// KUKA Roboter GmbH, Germany. All Rights Reserved.
;//
/*****************************************************************************/

using System;
using System.Windows.Forms;

namespace MxAutomation_Example{
	static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>

        [STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainView());
        }
	}
}
