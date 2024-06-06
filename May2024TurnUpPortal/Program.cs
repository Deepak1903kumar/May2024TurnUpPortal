﻿// See https://aka.ms/new-console-template for more information
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

IWebDriver driver = new ChromeDriver();
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

IWebElement usernameElement = driver.FindElement(By.Id("UserName"));
usernameElement.SendKeys("hari");

IWebElement passwordElement = driver.FindElement(By.Id("Password"));
passwordElement.SendKeys("123123");

IWebElement LoginButtonElement = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
LoginButtonElement.Click();
