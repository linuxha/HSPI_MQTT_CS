//
/*
  Not sure where this came from (but it's from the homeseer board)
  I'm working on who to get the proper credit for (Kirby Howell).

  http://board.homeseer.com/showthread.php?p=1143507

  Kerby converted the HSPI_SAMPLE_BASIC to HSPI_SAMPLE_CS
*/

using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Text;
using System.Web;
using Scheduler;

namespace HSPI_MQTT_CS {

    public class WebPageAddDevice : PageBuilderAndMenu.clsPageBuilder {

	public WebPageAddDevice(string pagename) : base(pagename) {
	}

	#if NJC
	public override string postBackProc(string page, string data, string user, int userRights) {
	    System.Collections.Specialized.NameValueCollection parts = null;
	    parts = HttpUtility.ParseQueryString(data);

	    return base.postBackProc(page, data, user, userRights);
	}
	#endif

	// build and return the actual page
	public string GetPagePlugin(string pageName, string user, int userRights, string queryString) {
	    StringBuilder stb = new StringBuilder();

	    try {
		this.reset();

		stb.Append("This is the add device config");

		return stb.ToString();
	    } catch (Exception) {
		//WriteMon("Error", "Building page: " & ex.Message)
		return "error";
	    }
	}
    }
}
