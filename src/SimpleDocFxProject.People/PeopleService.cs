using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace SimpleDocFxProject.People
{
    /// <summary>
    /// People Services
    /// </summary>
    public class PeopleService
    {
        public PeopleService()
        {
            Peoples = new List<Person>();
        }

        public PeopleService(List<Person> peoples)
        {
            Peoples = peoples;
        }

        /// <summary>
        /// Gets People
        /// </summary>
        public List<Person> Peoples { get; private set; }

        /// <summary>
        /// Add doctor to list of people
        /// </summary>
        /// <param name="doctor">Doctor</param>
        public void AddDoctor(Doctor doctor)
        {
            Peoples.Add(doctor);
        }

        /// <summary>
        /// Add Lawyer to list people
        /// </summary>
        /// <param name="lawyer">Lawyer</param>
        public void AddLawyer(Lawyer lawyer)
        {
            Peoples.Add(lawyer);
        }

        /// <summary>
        /// Get list of lawyers
        /// </summary>
        /// <returns></returns>
        public List<Lawyer> GetLawyers()
        {
            var lawyers = Peoples
                            .Where(x => x.GetType() == typeof(Lawyer))
                            .Cast<Lawyer>()
                            .ToList();

            return lawyers;

        }

        /// <summary>
        /// Get list of doctors
        /// </summary>
        /// <returns></returns>
        public List<Doctor> GetDoctors()
        {
            var doctors = Peoples
                .Where(x => x.GetType() == typeof(Doctor))
                .Cast<Doctor>()
                .ToList();

            return doctors;
        }
    }
}
