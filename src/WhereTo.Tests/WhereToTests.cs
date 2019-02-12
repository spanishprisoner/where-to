﻿using WhereTo.Expressions.Implementation;
using WhereTo.Parser;
using Xunit;

namespace WhereTo.Tests
{
	public class WhereToTests
	{
		[Theory]
		[InlineData(@"a  =  'b\'b'  or  (  a  >  1  and  c  !=  true  )  and  (  d  =  1  )")]
		public void ShouldValidateCorrectInputs(string input)
		{
			var whereToParser = new WhereToParser(new SelfTestExpressionFactory());
			whereToParser.Parse(input);
		}
	}
}
