﻿using System;

namespace Connect.Koi.Polymorphing.Detection
{
    /// <summary>
    /// This is simply a test-detector, used for unit tests
    /// </summary>
    public class TestDetection: AutoDetectTyped<string>
    {
        public static string Result;

        public TestDetection(string configuration) : base(configuration)
        {
        }

        protected override string GetValue()
        {
            if(Result == null)
                throw new Exception("can't run tests - you must first set the static result value");
            return Result;
        }
    }
}
