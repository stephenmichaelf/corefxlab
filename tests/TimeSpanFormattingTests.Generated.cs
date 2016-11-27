// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

// THIS FILE IS AUTOGENERATED

using System;
using System.Globalization;
using Xunit;

namespace System.Text.Formatting.Tests
{
    public partial class SystemTextFormattingTests
    {
        public void CheckTimeSpan(TimeSpan value, string format)
        {
            var parsed = TextFormat.Parse(format);
            var formatter = new StringFormatter();
            formatter.Append(value, parsed);
            var result = formatter.ToString();
            var clrResult = value.ToString(format, CultureInfo.InvariantCulture);
            Assert.Equal(clrResult, result);
        }
        
        [Fact]
        public void TimeSpanFormatG()
        {
            
            // format G
            CheckTimeSpan(TimeSpan.MinValue, "G");
            CheckTimeSpan(TimeSpan.MaxValue, "G");
            CheckTimeSpan(new TimeSpan(-1448765827), "G");
            CheckTimeSpan(new TimeSpan(-831016174), "G");
            CheckTimeSpan(new TimeSpan(1631147086), "G");
            CheckTimeSpan(new TimeSpan(-1031504630), "G");
            CheckTimeSpan(new TimeSpan(1180641209), "G");
            CheckTimeSpan(new TimeSpan(-694575205), "G");
            CheckTimeSpan(new TimeSpan(945234342), "G");
            CheckTimeSpan(new TimeSpan(-1787117905), "G");
            CheckTimeSpan(new TimeSpan(-1783177716), "G");
            CheckTimeSpan(new TimeSpan(416580355), "G");
            CheckTimeSpan(new TimeSpan(1472817473), "G");
            CheckTimeSpan(new TimeSpan(-1362523919), "G");
            CheckTimeSpan(new TimeSpan(185175217), "G");
            CheckTimeSpan(new TimeSpan(1535048434), "G");
            CheckTimeSpan(new TimeSpan(-385272507), "G");
            CheckTimeSpan(new TimeSpan(1705873421), "G");
            CheckTimeSpan(new TimeSpan(609948184), "G");
            CheckTimeSpan(new TimeSpan(1343637461), "G");
        }
        
        [Fact]
        public void TimeSpanFormatc()
        {
            
            // format c
            CheckTimeSpan(TimeSpan.MinValue, "c");
            CheckTimeSpan(TimeSpan.MaxValue, "c");
            CheckTimeSpan(new TimeSpan(-1910179261), "c");
            CheckTimeSpan(new TimeSpan(-1422900903), "c");
            CheckTimeSpan(new TimeSpan(1532033402), "c");
            CheckTimeSpan(new TimeSpan(-1184199769), "c");
            CheckTimeSpan(new TimeSpan(-101806576), "c");
            CheckTimeSpan(new TimeSpan(-1344934829), "c");
            CheckTimeSpan(new TimeSpan(-377958802), "c");
            CheckTimeSpan(new TimeSpan(-1369500375), "c");
            CheckTimeSpan(new TimeSpan(-305492880), "c");
            CheckTimeSpan(new TimeSpan(2082306134), "c");
            CheckTimeSpan(new TimeSpan(820381335), "c");
            CheckTimeSpan(new TimeSpan(-1183579822), "c");
            CheckTimeSpan(new TimeSpan(1268834514), "c");
            CheckTimeSpan(new TimeSpan(572006580), "c");
            CheckTimeSpan(new TimeSpan(208019992), "c");
            CheckTimeSpan(new TimeSpan(67340520), "c");
            CheckTimeSpan(new TimeSpan(-1546309170), "c");
            CheckTimeSpan(new TimeSpan(-1844646218), "c");
        }
        
    }
}