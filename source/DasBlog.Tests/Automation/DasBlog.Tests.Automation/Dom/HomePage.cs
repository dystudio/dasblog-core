﻿using WebAppConstants = DasBlog.Core.Common.Constants;
using DasBlog.Tests.Automation.Common;
using DasBlog.Tests.Automation.Selenium.Interfaces;

namespace DasBlog.Tests.Automation.Dom
{
	public class HomePage : Page
	{
		public HomePage(IBrowser browser) : base(browser, Constants.HomePage, WebAppConstants.HomePageTestId)
		{
			
		}
		public TextBoxPageElement NameTextBox
		{
			get { return browser.GetTextBoxElementById(WebAppConstants.Name); }
		}
		public TextBoxPageElement EmailTextBox
		{
			get { return browser.GetTextBoxElementById(WebAppConstants.Email); }
		}
		public TextBoxPageElement ContentTextBox
		{
			get { return browser.GetTextBoxElementById(WebAppConstants.Content); }
		}
		public ButtonPageElement SaveContentButton
		{
			get { return browser.GetButtonById(WebAppConstants.SaveContentButtonId); }
		}

	}
}
