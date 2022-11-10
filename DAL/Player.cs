using System.Globalization;
using System.Runtime.Serialization;

namespace DAL
{
    [Serializable]
    public class Player :ISerializable
    {
        public Player(string firstName, string lastName, DateTime dateOfBirth, string status, string healthCondition, double salary, string position)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Status = status;
            HealthCondition = healthCondition;
            Salary = salary;
            Position = position;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Status { get; set; }
        public string HealthCondition { get; set; }
        public double Salary { get; set; }

        public string Position { get; set; }

        public override string ToString()
        {
            return  $"{FirstName} {LastName} ({Position})";
        }
        public string Display()
        {
            return $"\nГравець {FirstName} {LastName} ({Position});\nДата народження: {DateOfBirth};\nСтатус - {Status};\nСтан здоров'я - {HealthCondition};\nЗаробітня плата - ${Salary};";
        }
        public Player Copy()
        {
            return (Player)this.MemberwiseClone();
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("FirstName", FirstName);
            info.AddValue("LastName", LastName);
            info.AddValue("Date Of Birth", DateOfBirth.ToString());
            info.AddValue("Status", Status);
            info.AddValue("Health Condition", HealthCondition);
            info.AddValue("Salary", Salary);
        }
    }
}