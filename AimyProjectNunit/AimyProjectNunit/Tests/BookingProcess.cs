using AimyNunitProject.Components.HomePageCompo;
using AimyNunitProject.Components.LoginConpo;
using AimyNunitProject.Components.UserDetailsCompo;
using AimyNunitProject.Components.WVPBookingPageCompo;
using AimyNunitProject.DataFiles.UserJsonControl;
using AimyNunitProject.Drivers;
using AimyProjectNunit.Components.ABCBookingPageCompo;
using Newtonsoft.Json;
using NUnit.Framework;

namespace AimyNunitProject.Tests
{
    [TestFixture]
    [Parallelizable]
    public class BookingProcess : MainDriver
    {
        HomePage homePage = new HomePage();
        TermOnePrograms termOnePrograms = new TermOnePrograms();
        WVPBookingPage wvpBookingPage = new WVPBookingPage();
        ABCBookingPage abcBookingPage = new ABCBookingPage();
        HolidayProgramPage holidayProgramPage = new HolidayProgramPage();
        UserLogin userLogin = new UserLogin();
        UserRegister userRegister = new UserRegister();
        UserProfile userProfile = new UserProfile();
        EmergencyContact emergencyContact = new EmergencyContact();
        AttendeesProfile attendeesProfile = new AttendeesProfile();
        MedicalAndConditions medicalAndConditions = new MedicalAndConditions();

        [Test, Order(1)]
        public void RegisterNewAccount()
        {
            // Json reader
            string dataPath = File.ReadAllText(@"..\..\..\DataFiles\BookingProcessData.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);
            User user = users.ElementAt(0);

            homePage.goToWVPBookingPage();
            userRegister.Register(user.RegisterEmail, user.RegisterPassword, user.RegisterConfirmPassword);
        
        }



        [Test, Order(2)]
        public void BookingAction()
        {
            // Json reader
            string dataPath = File.ReadAllText(@"..\..\..\DataFiles\BookingProcessData.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);
            User user = users.ElementAt(0);

            Attendees attendee1 = user.attendees.ElementAt(0);
            UserEmergencyContact emergencyContact1 = user.emergencyContact.ElementAt(0);
            MedicalAndConditionsInfo medicalAndConditionsInfo = user.medicalAndConditionsInfo.ElementAt(0);

            homePage.goToWVPBookingPage();
            userLogin.login(user.loginUsername, user.loginPassword);
            wvpBookingPage.SelectTermOneProgram();
            termOnePrograms.RegularBooking();
            userProfile.AddNewAccountHolders(user.AHfirstname, user.AHlastname, user.AHemail, user.AHmobilephoneCode, user.AHmobilephoneNum, user.AHstreet, user.AHsuburb, user.AHcity, user.AHregion, user.AHcountry, user.AHpostcode);

            attendeesProfile.AddNewAttendees(attendee1.AttendeeFirstName, attendee1.AttendeeLastName, attendee1.AttendeeKnownAs, attendee1.AttendeeRoomNumber, attendee1.AttendeeSchoolYear);
            emergencyContact.AddNewEmergencyContactForNewAttendeee(emergencyContact1.ECfirstname, emergencyContact1.EClastname, emergencyContact1.ECemail, emergencyContact1.ECmobilephoneCode, emergencyContact1.ECmobilephoneNum, emergencyContact1.ECstreet, emergencyContact1.ECsuburb, emergencyContact1.ECcity, emergencyContact1.Ecregion, emergencyContact1.ECcountry, emergencyContact1.ECpostcode);
            emergencyContact.CompleteTheECRequest();

            medicalAndConditions.MedicalAndCondition(medicalAndConditionsInfo.DoctorName, medicalAndConditionsInfo.MedicalServiceName, medicalAndConditionsInfo.NumberCode, medicalAndConditionsInfo.NumberAreaCode, medicalAndConditionsInfo.NumberLocalNum, medicalAndConditionsInfo.NumberExt, medicalAndConditionsInfo.InsurancePolicyNumber);

            attendeesProfile.SelectFirstAttendee();

        
        }

        [Test, Order(3)]
        public void HolidayBookingAction()
        {
            // Json reader
            string dataPath = File.ReadAllText(@"..\..\..\DataFiles\BookingProcessData.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(dataPath);
            User user = users.ElementAt(0);

            Attendees attendee1 = user.attendees.ElementAt(0);
            UserEmergencyContact emergencyContact1 = user.emergencyContact.ElementAt(0);
            MedicalAndConditionsInfo medicalAndConditionsInfo = user.medicalAndConditionsInfo.ElementAt(0);

            homePage.goToABCBookingPage();
            abcBookingPage.selectFirstHolidayProgram();
            holidayProgramPage.SelectPrograms();
            holidayProgramPage.ABClogin(user.loginUsername, user.loginPassword);

            userProfile.AddNewAccountHolders(user.AHfirstname, user.AHlastname, user.AHemail, user.AHmobilephoneCode, user.AHmobilephoneNum, user.AHstreet, user.AHsuburb, user.AHcity, user.AHregion, user.AHcountry, user.AHpostcode);
            attendeesProfile.AddNewAttendees(attendee1.AttendeeFirstName, attendee1.AttendeeLastName, attendee1.AttendeeKnownAs, attendee1.AttendeeRoomNumber, attendee1.AttendeeSchoolYear);
            emergencyContact.AddNewEmergencyContactForNewAttendeee(emergencyContact1.ECfirstname, emergencyContact1.EClastname, emergencyContact1.ECemail, emergencyContact1.ECmobilephoneCode, emergencyContact1.ECmobilephoneNum, emergencyContact1.ECstreet, emergencyContact1.ECsuburb, emergencyContact1.ECcity, emergencyContact1.Ecregion, emergencyContact1.ECcountry, emergencyContact1.ECpostcode);
            emergencyContact.CompleteTheECRequest();

            medicalAndConditions.MedicalAndCondition(medicalAndConditionsInfo.DoctorName, medicalAndConditionsInfo.MedicalServiceName, medicalAndConditionsInfo.NumberCode, medicalAndConditionsInfo.NumberAreaCode, medicalAndConditionsInfo.NumberLocalNum, medicalAndConditionsInfo.NumberExt, medicalAndConditionsInfo.InsurancePolicyNumber);


            abcBookingPage.SelectAttendee();

        }
    }
}
