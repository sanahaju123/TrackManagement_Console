using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TrackManagement;
using Xunit;
using Xunit.Abstractions;

namespace Trackmanagement.Tests.TestCases
{
    public class BoundaryTests
    {
        // <summary>
        /// Creating referance variable of ITestOutputHelper and injecting in constructor
        /// </summary>
        private readonly ITestOutputHelper _output;
        private Track _track;
        private static string type = "Boundary";
        public BoundaryTests(ITestOutputHelper output)
        {
            _output = output;
            _track = new Track()
            {
                TrackId = 1,
                TrackName = "Track",
                TrackDuration = DateTime.Now,
                TrackLead = "Lead",
                NumberOfCampusMinds = 12
            };
        }
        /// <summary>
        /// Validate Show All Tracks.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> TestFor_ValidateShowAllTracks()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            try
            {
                var result = Program.ShowAllTracks();
                //Act
                if (result != null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            ///Assert
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

    }
}

