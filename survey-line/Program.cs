/*
 * Created by SharpDevelop.
 * User: SamsungNC108
 * Date: 2/13/2014
 * Time: 10:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Reflection;
using System.Windows.Forms;
using SurveyLine.util;

namespace SurveyLine
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
		    var resource1 = "SurveyLine.ZedGraph.dll";
		    EmbeddedAssembly.Load(resource1, "ZedGraph.dll");
            AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(CurrentDomain_AssemblyResolve);


			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainUI());
		}

	    private static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
	    {
            return EmbeddedAssembly.Get(args.Name);
	    }
	}
}
