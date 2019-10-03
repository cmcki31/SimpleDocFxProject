Example Console App

void Main()
{
	var lawyer = new Lawyer
	{
		FirstName = "John",
		LastName = "Mason",
		Practice = "Criminal"
	};
	
	
	var doctor = new Doctor
	{
		FirstName = "Mike",
		LastName = "Robertson",
		Occupation = "Dentist",
		Hospital = "The Dentist Office"
	};
	
	var people = new List<Person>()
	{
		lawyer,
		doctor
	};
	
	var peopleService = new PeopleService(people);
	
	var doctors = peopleService.GetDoctors();
	var lawyers = peopleService.GetLawyers();
}
