using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class phoneEmailWeb : MonoBehaviour {

	/* ------------------------------------------------------------------------- */
	// open facebook page
	public void openTechandBeerFacebookPage ()
	{
		float startTime;
		startTime = Time.timeSinceLevelLoad;

		// open the facebook app in IOS
		Application.OpenURL("fb://page/?id=350989365287405");
		// open the facebook app in Andorid
		Application.OpenURL ("fb://page/350989365287405");

		if (Time.timeSinceLevelLoad - startTime <= 1f)
		{
			//fail. Open safari.
			Application.OpenURL("https://www.facebook.com/Orlandotechandbeer/");
		}
	}

	/* ------------------------------------------------------------------------- */
	// open webpage 
	public void openLaunchableWebPage ()
	{
		Application.OpenURL("https://teamlaunchable.com/");
	}

	public void openPanderaWebPage ()
	{
		Application.OpenURL ("http://panderasystems.com/");
	}

	public void TeamLaunchableSite ()
	{
		Application.OpenURL ("https://TeamLaunchable.com");
	}



	/* ------------------------------------------------------------------------- */
	// phone call

	public void Phone_Launchable ()
	{
		Application.OpenURL ("tel://4079063034");
	}

	public void Phone_Dollar ()
	{
		Application.OpenURL ("tel://5613058898");
	}

	public void Phone_Salus()
	{
		Application.OpenURL ("tel://9546083230");
	}
	
	public void Phone_IsaccYi()
	{
		Application.OpenURL ("tel://9045687171");
	}

	public void Phone_StopSign()
	{
		Application.OpenURL("tel://4079063034");
	}
		
	/* ------------------------------------------------------------------------- */
//	 open email 
	public void Email_Launchable ()
	{
		string email = "Alfred@TeamLaunchable.com";
		string subject = MyEscapeURL(" ");
		string body = MyEscapeURL(" ");
		Application.OpenURL("mailto:" + email + "?subject=" + subject + "&body=" + body);
	}

	public void Email_Dollar ()
	{
		string email = "Joe@TeamLaunchable.com";
		string subject = MyEscapeURL(" ");
		string body = MyEscapeURL(" ");
		Application.OpenURL("mailto:" + email + "?subject=" + subject + "&body=" + body);
	}

	public void Email_StopSign()
	{
		string email = "alfred@teamlaunchable.com";
		string subject = MyEscapeURL(" ");
		string body = MyEscapeURL(" ");
		Application.OpenURL("mailto:" + email + "?subject=" + subject + "&body=" + body);
	}

	public void Email_Salus()
	{
		string email = "nick@salusapp.net";
		string subject = MyEscapeURL(" ");
		string body = MyEscapeURL(" ");
		Application.OpenURL("mailto:" + email + "?subject=" + subject + "&body=" + body);	
	}

	public void Email_IsaccYi()
	{
		string email = "isaccyi@gmail.com";
		string subject = MyEscapeURL(" ");
		string body = MyEscapeURL(" ");
		Application.OpenURL("mailto:" + email + "?subject=" + subject + "&body=" + body);
	}
	
	
	string MyEscapeURL (string url)
	{
		return WWW.EscapeURL(url).Replace("+","%20");
	}
	/* ------------------------------------------------------------------------- */

}