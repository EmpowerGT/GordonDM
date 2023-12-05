namespace GordonsDM_1
{
	using System;
	using System.Collections.Generic;
	using System.Globalization;
	using System.Text;
	using Skyline.DataMiner.Automation;
    using Skyline.DataMiner.Net.ReportsAndDashboards;

    /// <summary>
    /// Represents a DataMiner Automation script.
    /// </summary>
    public class Script
	{
		/// <summary>
		/// The script entry point.
		/// </summary>
		/// <param name="engine">Link with SLAutomation process.</param>
		public void Run(IEngine engine)
		{
			engine.GenerateInformation("HelloWorld");
		}
	}
}