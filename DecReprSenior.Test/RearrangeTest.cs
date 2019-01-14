using FluentAssertions;
using System;
using Xunit;

namespace DecReprSenior.Test
{
    public class RearrangeTest
    {
        [Fact]
        public void TestInput213()
        {
            int n = 213;

            Rearrange rearrange = new Rearrange(n);
            int output = rearrange.Solution();
            output.Should().Be(321, "For the input 213 the output mus be 321");
        }

        [Fact]
        public void TestInput553()
        {
            int n = 553;

            Rearrange rearrange = new Rearrange(n);
            int output = rearrange.Solution();

            output.Should().Be(553, "For the input 553 the output mus be 553");
        }

        [Fact]
        public void TestInput100000001()
        {
            int n = 100000001;

            Rearrange rearrange = new Rearrange(n);
            int output = rearrange.Solution();

            output.Should().BeNegative("For a result greather than 100000000 the return= must be -1");
        }

        [Fact]
        public void TestInputNegative()
        {
            int n = -1;

            Rearrange rearrange = new Rearrange(n);
            Action action = () => rearrange.Solution();

            action.Should().Throw<Exception>().WithMessage("The input should be a non-negative number");
        }
    }
}
