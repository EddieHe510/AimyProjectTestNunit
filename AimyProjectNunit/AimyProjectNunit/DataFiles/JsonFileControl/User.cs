using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AimyNunitProject.DataFiles.UserJsonControl
{
    public class User
    {
        public string RegisterEmail { get; set; }
        public string RegisterPassword { get; set; }
        public string RegisterConfirmPassword { get; set; }
        public string loginUsername {  get; set; }
        public string loginPassword { get; set; }
        public string AHfirstname { get; set; }
        public string AHlastname { get; set; }
        public string AHemail { get; set; }
        public string AHmobilephoneCode { get; set; }
        public string AHmobilephoneNum { get; set; }
        public string AHstreet { get; set; }
        public string AHsuburb { get; set; }
        public string AHcity { get; set; }
        public string AHregion { get; set; }
        public string AHcountry { get; set; }
        public string AHpostcode { get; set; }
        public List<UserEmergencyContact> emergencyContact { get; set; }
        public List<Attendees> attendees { get; set; }
        public List<MedicalAndConditionsInfo> medicalAndConditionsInfo { get; set; }
    }

    public class UserEmergencyContact
    {
        public string ECfirstname { get; set; }
        public string EClastname { get; set; }
        public string ECemail { get; set; }
        public string ECmobilephoneCode { get; set; }
        public string ECmobilephoneNum { get; set; }
        public string ECstreet { get; set; }
        public string ECsuburb { get; set; }
        public string ECcity { get; set; }
        public string Ecregion { get; set; }
        public string ECcountry { get; set; }
        public string ECpostcode { get; set; }
    }

    public class Attendees
    {
        public string AttendeeFirstName { get; set; }
        public string AttendeeLastName { get; set; }
        public string AttendeeKnownAs { get; set; }
        public string AttendeeRoomNumber { get; set; }
        public string AttendeeSchoolYear { get; set; }
    }

    public class MedicalAndConditionsInfo
    {
        public string DoctorName { get; set; }
        public string MedicalServiceName { get; set; }
        public string NumberCode { get; set; }
        public string NumberAreaCode { get; set; }
        public string NumberLocalNum { get; set; }
        public string NumberExt { get; set; }
        public string InsurancePolicyNumber { get; set; }
    }
}
