﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace JiraMobile
{
    public class App
    {
        public static Page GetMainPage()
        {
			return new NavigationPage (new IssueList ());
//			return new IssueList ();
		
        }
    }
}