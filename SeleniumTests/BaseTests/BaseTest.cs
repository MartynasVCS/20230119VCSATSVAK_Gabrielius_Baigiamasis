﻿using Framework;
using NUnit.Framework;

namespace SeleniumTests.BaseTests
{
    internal class BaseTest
    {
        [SetUp]
        public void Setup()
        {
            Driver.SetupDriver();
        }
        //[TearDown]
        //public void Teardown()
        //{
        //    Driver.QuitDriver();
        //}
    }
}
