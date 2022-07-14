using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TrackManagement;
using Xunit;
using Xunit.Abstractions;

namespace Trackmanagement.Tests.TestCases
{
    public class ExceptionalTests
    {
        // <summary>
        /// Creating referance variable of ITestOutputHelper and injecting in constructor
        /// </summary>
        private readonly ITestOutputHelper _output;
        private Track _track;
        private static string type = "Exception";
        public ExceptionalTests(ITestOutputHelper output)
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
        /// If passing null will return false.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> TestFor_ReturnNull_AddTrack()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            _track =null;
            testName = CallAPI.GetCurrentMethodName();
            try
            {
                var result = Program.AddTrack(_track);
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
