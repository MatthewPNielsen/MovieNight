using MovieNight.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MovieNight.Tests
{
    public class VotingTests
    {
        [Fact]
        public void Test_VotingId()
        {
            var expected = typeof(Guid);
            var sut = new Voting();
            var actual = sut.Id;

            Assert.True(expected == actual.GetType());
        }

        [Fact]
        public void Test_Voting()
        {
            var expected = 1;
            var sut = new Movie();
            var actual = sut.Votes;

            Assert.True(typeof(List<Voter>) == actual.GetType());
            Assert.True(expected == actual.Count);
        }
    }
}
