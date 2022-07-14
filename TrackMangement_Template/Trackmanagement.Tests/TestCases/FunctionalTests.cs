using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TrackManagement;
using Xunit;
using Xunit.Abstractions;

namespace Trackmanagement.Tests.TestCases
{
    public class FunctionalTests
    {
        // <summary>
        /// Creating referance variable of ITestOutputHelper and injecting in constructor
        /// </summary>
        private readonly ITestOutputHelper _output;
        private Track _track;
        private static string type = "Functional";
        public FunctionalTests(ITestOutputHelper output)
        {
            _output = output;
            _track = new Track()
            {
                TrackId = 2,
                TrackName = "Track",
                TrackDuration = DateTime.Now,
                TrackLead = "Lead",
                NumberOfCampusMinds = 12
            };
        }

        [Fact]
        public async Task<bool> TestFor_AddTrack()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            try
            {
                IEnumerable<Object> result = Program.AddTrack(_track);
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

        [Fact]
        public async Task<bool> TestFor_UpdateTrack()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            try
            {
                var result = Program.UpdateTrack(_track);

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



        [Fact]
        public async Task<bool> TestFor_ShowAllTracks()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            string jsonValue = "";
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


        [Fact]
        public async Task<bool> TestFor_GetTrackById()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            int TrackId = 2;
            testName = CallAPI.GetCurrentMethodName();
            try
            {
                var result = Program.GetTrackById(TrackId);
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


        [Fact]
        public async Task<bool> TestFor_DeleteTrack()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            var trackId = 1;
            testName = CallAPI.GetCurrentMethodName();
            try
            {
                List<Track> result = (List<Track>)Program.RemoveTrackById(trackId);
                //Act
                if (result[1] == null)
                {
                    res = true;
                }
            }
            catch (Exception ex)
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